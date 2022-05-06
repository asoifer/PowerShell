// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Management.Automation.Remoting;
using System.Management.Automation.Runspaces;
using System.Security;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using Dbg = System.Management.Automation.Diagnostics;
using PowerShellApi = System.Management.Automation.PowerShell;
using WSManNativeApi = System.Management.Automation.Remoting.Client.WSManNativeApi;

namespace Microsoft.PowerShell.Commands
{
    [Cmdlet(VerbsLifecycle.Register, RemotingConstants.PSSessionConfigurationNoun,
            DefaultParameterSetName = PSSessionConfigurationCommandBase.NameParameterSetName,
            SupportsShouldProcess = true,
            ConfirmImpact = ConfirmImpact.Medium, HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096793")]
    public sealed class RegisterPSSessionConfigurationCommand : PSSessionConfigurationCommandBase
    {
        private const string
        newPluginSbFormat = @"
function Register-PSSessionConfiguration
{{
    [CmdletBinding(SupportsShouldProcess=$true, ConfirmImpact=""Medium"")]
    param(
      [string] $filepath,
      [string] $pluginName,
      [bool] $shouldShowUI,
      [bool] $force,
      [string] $restartWSManTarget,
      [string] $restartWSManAction,
      [string] $restartWSManRequired,
      [string] $runAsUserName,
      [system.security.securestring] $runAsPassword,
      [System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode] $accessMode,
      [bool] $isSddlSpecified,
      [string] $configTableSddl
    )

    begin
    {{
        ## Construct SID for network users
        [system.security.principal.wellknownsidtype]$evst = ""NetworkSid""
        $networkSID = new-object system.security.principal.securityidentifier $evst,$null

        ## If all session configurations have Network Access disabled,
        ## then we create this endpoint as Local as well.
        $newSDDL = $null
        $foundRemoteEndpoint = $false;
        Get-PSSessionConfiguration -Force:$force | Foreach-Object {{
            if ($_.Enabled)
            {{
                $sddl = $null
                if ($_.psobject.members[""SecurityDescriptorSddl""])
                {{
                    $sddl = $_.psobject.members[""SecurityDescriptorSddl""].Value
                }}

                if($sddl)
                {{
                    # See if it has 'Disable Network Access'
                    $sd = new-object system.security.accesscontrol.commonsecuritydescriptor $false,$false,$sddl
                    $disableNetworkExists = $false
                    $sd.DiscretionaryAcl | ForEach-Object {{
                        if (($_.acequalifier -eq ""accessdenied"") -and ($_.securityidentifier -match $networkSID) -and ($_.AccessMask -eq 268435456))
                        {{
                            $disableNetworkExists = $true
                        }}
                    }}

                    if(-not $disableNetworkExists) {{ $foundRemoteEndpoint = $true }}
                }}
            }}
        }}

        if(-not $foundRemoteEndpoint)
        {{
            $newSDDL = ""{1}""
        }}
    }}

    process
    {{
        if ($force)
        {{
            if (Test-Path (Join-Path WSMan:\localhost\Plugin ""$pluginName""))
            {{
                Unregister-PSSessionConfiguration -name ""$pluginName"" -force
            }}
        }}

        try
        {{
            new-item -path WSMan:\localhost\Plugin -file ""$filepath"" -name ""$pluginName""
        }}
        catch [System.InvalidOperationException] # WS2012/R2 WinRM w/o WMF has limitation where MaxConcurrentUsers can't be greater than 100
        {{
            $xml = [xml](get-content ""$filepath"")
            $xml.PlugInConfiguration.Quotas.MaxConcurrentUsers = 100
            Set-Content -path ""$filepath"" -Value $xml.OuterXml
            new-item -path WSMan:\localhost\Plugin -file ""$filepath"" -name ""$pluginName""
        }}

        if ($? -and $runAsUserName)
        {{
            try {{
                $runAsCredential = new-object system.management.automation.PSCredential($runAsUserName, $runAsPassword)
                $pluginWsmanRunAsUserPath = [System.IO.Path]::Combine(""WSMan:\localhost\Plugin"", ""$pluginName"", ""RunAsUser"")
                set-item -WarningAction SilentlyContinue $pluginWsmanRunAsUserPath $runAsCredential -confirm:$false
            }} catch {{

                remove-item (Join-Path WSMan:\localhost\Plugin ""$pluginName"") -recurse -force
                write-error $_
                # Do not add anymore clean up code after Write-Error, because if EA=Stop is set by user
                # any code at this point will not execute.

                return
            }}
        }}

        ## Replace the SDDL with any groups or restrictions defined in the PSSessionConfigurationFile
        if($? -and $configTableSddl -and (-not $isSddlSpecified))
        {{
            $null = Set-PSSessionConfiguration -Name $pluginName -SecurityDescriptorSddl $configTableSddl -Force:$force
        }}

        if ($? -and $shouldShowUI)
        {{
           $null = winrm configsddl ""{0}$pluginName""

           # if AccessMode is Disabled OR the winrm configsddl failed, we just return
           if ([System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode]::Disabled.Equals($accessMode) -or !$?)
           {{
               return
           }}
        }} # end of if ($shouldShowUI)

        if ($?)
        {{
           # if AccessMode is Local or Remote, we need to check the SDDL the user set in the UI or passed in to the cmdlet.
           $newSDDL = $null
           $curPlugin = Get-PSSessionConfiguration -Name $pluginName -Force:$force
           $curSDDL = $curPlugin.SecurityDescriptorSddl
           if (!$curSDDL)
           {{
               if ([System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode]::Local.Equals($accessMode))
               {{
                    $newSDDL = ""{1}""
               }}
           }}
           else
           {{
               # Construct SID for network users
               [system.security.principal.wellknownsidtype]$evst = ""NetworkSid""
               $networkSID = new-object system.security.principal.securityidentifier $evst,$null

               $sd = new-object system.security.accesscontrol.commonsecuritydescriptor $false,$false,$curSDDL
               $haveDisableACE = $false
               $securityIdentifierToPurge = $null
               $sd.DiscretionaryAcl | ForEach-Object {{
                    if (($_.acequalifier -eq ""accessdenied"") -and ($_.securityidentifier -match $networkSID) -and ($_.AccessMask -eq 268435456))
                    {{
                        $haveDisableACE = $true
                        $securityIdentifierToPurge = $_.securityidentifier
                    }}
               }}

               if (([System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode]::Local.Equals($accessMode) -or
                    [System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode]::Remote.Equals($accessMode)) -and $haveDisableACE)
               {{
                    # Add network deny ACE for local access or remote access with PSRemoting disabled.
                    $sd.DiscretionaryAcl.AddAccess(""deny"", $networkSID, 268435456, ""None"", ""None"")
                    $newSDDL = $sd.GetSddlForm(""all"")
               }}

               if ([System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode]::Remote.Equals($accessMode) -and $haveDisableACE)
               {{
                    # Remove the specific ACE
                    $sd.discretionaryacl.RemoveAccessSpecific('Deny', $securityIdentifierToPurge, 268435456, 'none', 'none')

                    # if there is no discretionaryacl..add Builtin Administrators and Remote Management Users
                    # to the DACL group as this is the default WSMan behavior
                    if ($sd.discretionaryacl.count -eq 0)
                    {{
                        [system.security.principal.wellknownsidtype]$bast = ""BuiltinAdministratorsSid""
                        $basid = new-object system.security.principal.securityidentifier $bast,$null
                        $sd.DiscretionaryAcl.AddAccess('Allow',$basid, 268435456, 'none', 'none')

                        # Remote Management Users, Win8+ only
                        if ([System.Environment]::OSVersion.Version -ge ""6.2.0.0"")
                        {{
                            $rmSidId = new-object system.security.principal.securityidentifier ""{2}""
                            $sd.DiscretionaryAcl.AddAccess('Allow', $rmSidId, 268435456, 'none', 'none')
                        }}

                        # Interactive Users
                        $iaSidId = new-object system.security.principal.securityidentifier ""{3}""
                        $sd.DiscretionaryAcl.AddAccess('Allow', $iaSidId, 268435456, 'none', 'none')
                    }}

                    $newSDDL = $sd.GetSddlForm(""all"")
               }}
           }} # end of if(!$curSDDL)
        }} # end of if ($?)

        if ($? -and $newSDDL)
        {{
            try {{
                if ($runAsUserName)
                {{
                    $runAsCredential = new-object system.management.automation.PSCredential($runAsUserName, $runAsPassword)
                    $null = Set-PSSessionConfiguration -Name $pluginName -SecurityDescriptorSddl $newSDDL -NoServiceRestart -force -WarningAction 0 -RunAsCredential $runAsCredential
                }}
                else
                {{
                    $null = Set-PSSessionConfiguration -Name $pluginName -SecurityDescriptorSddl $newSDDL -NoServiceRestart -force -WarningAction 0
                }}

            }} catch {{
                remove-item (Join-Path WSMan:\localhost\Plugin ""$pluginName"") -recurse -force
                write-error $_
                # Do not add anymore clean up code after Write-Error, because if EA=Stop is set by user
                # any code at this point will not execute.

                return
            }}
        }}

        if ($?){{
            try{{
                $s = New-PSSession -ComputerName localhost -ConfigurationName $pluginName -ErrorAction Stop
                # session is ok, no need to restart WinRM service
                Remove-PSSession $s -Confirm:$false
            }}catch{{
                # session is NOT ok, we need to restart winrm if -Force was specified, otherwise show a warning
                if ($force){{
                    Restart-Service -Name WinRM -Force -Confirm:$false
                }}else{{
                    $warningWSManRestart = [Microsoft.PowerShell.Commands.Internal.RemotingErrorResources]::WinRMRestartWarning -f $PSCmdlet.MyInvocation.MyCommand.Name
                    Write-Warning $warningWSManRestart
                }}
            }}
        }}
    }}
}}

if ($null -eq $args[14])
{{
    Register-PSSessionConfiguration -filepath $args[0] -pluginName $args[1] -shouldShowUI $args[2] -force $args[3] -whatif:$args[4] -confirm:$args[5] -restartWSManTarget $args[6] -restartWSManAction $args[7] -restartWSManRequired $args[8] -runAsUserName $args[9] -runAsPassword $args[10] -accessMode $args[11] -isSddlSpecified $args[12] -configTableSddl $args[13]
}}
else
{{
    Register-PSSessionConfiguration -filepath $args[0] -pluginName $args[1] -shouldShowUI $args[2] -force $args[3] -whatif:$args[4] -confirm:$args[5] -restartWSManTarget $args[6] -restartWSManAction $args[7] -restartWSManRequired $args[8] -runAsUserName $args[9] -runAsPassword $args[10] -accessMode $args[11] -isSddlSpecified $args[12] -configTableSddl $args[13] -erroraction $args[14]
}}
"
        ;

        private static readonly ScriptBlock s_newPluginSb;

        private const string
        pluginXmlFormat = @"
<PlugInConfiguration xmlns='http://schemas.microsoft.com/wbem/wsman/1/config/PluginConfiguration'
    Name='{0}'
    Filename='{1}'
    SDKVersion='{12}'
    XmlRenderingType='text' {2} {6} {7} {8} {9} {10}>
  <InitializationParameters>
{3}

  </InitializationParameters>
  <Resources>
    <Resource ResourceUri='{4}' SupportsOptions='true' ExactMatch='true'>
{5}

      <Capability Type='Shell' />
    </Resource>
  </Resources>
  {11}
</PlugInConfiguration>
"
        ;

        private const string
        architectureAttribFormat = @"
    Architecture='{0}'"
        ;

        private const string
        sharedHostAttribFormat = @"
    UseSharedProcess='{0}'"
        ;

        private const string
        runasVirtualAccountAttribFormat = @"
    RunAsVirtualAccount='{0}'"
        ;

        private const string
        runAsVirtualAccountGroupsAttribFormat = @"
    RunAsVirtualAccountGroups='{0}'"
        ;

        private const string
        allowRemoteShellAccessFormat = @"
    Enabled='{0}'"
        ;

        private const string
        initParamFormat = @"
<Param Name='{0}' Value='{1}' />{2}"
        ;

        private const string
        privateDataFormat = @"<Param Name='PrivateData'>{0}</Param>"
        ;

        private const string
        securityElementFormat = "<Security Uri='{0}' ExactMatch='true' Sddl='{1}' />"
        ;

        private const string
        SessionConfigDataFormat = @"<SessionConfigurationData>{0}</SessionConfigurationData>"
        ;

        private string _gmsaAccount;

        private string _configTableSDDL;

        private bool _isErrorReported;

        [Parameter()]
        [Alias("PA")]
        [ValidateNotNullOrEmpty]
        [ValidateSet("x86", "amd64")]
        public string ProcessorArchitecture { get; set; }

        static RegisterPSSessionConfigurationCommand()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1589, 14935, 15582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 1548, 12653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 12700, 12713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 12747, 13248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 13280, 13334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 13368, 13424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 13458, 13526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 13560, 13640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 13674, 13727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 13761, 13819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 13851, 13911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 13943, 14020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 14052, 14137);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 15006, 15040);

                string
                localSDDL = f_1589_15025_15039()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 15214, 15430);

                string
                newPluginSbString = f_1589_15241_15429(f_1589_15255_15283(), newPluginSbFormat, WSManNativeApi.ResourceURIPrefix, localSDDL, RemoteManagementUsersSID, InteractiveUsersSID)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 15446, 15500);

                s_newPluginSb = f_1589_15462_15499(newPluginSbString);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 15514, 15571);

                s_newPluginSb.LanguageMode = PSLanguageMode.FullLanguage;
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1589, 14935, 15582);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 14935, 15582);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 14935, 15582);
            }
        }

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 15916, 22019);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 15982, 16314) || true) && (isSddlSpecified && (DynAbs.Tracing.TraceSender.Expression_True(1589, 15986, 16020) && showUISpecified))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 15982, 16314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 16054, 16234);

                    string
                    message = f_1589_16071_16233(f_1589_16089_16136(), "SecurityDescriptorSddl", "ShowSecurityDescriptorUI")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 16252, 16299);

                    throw f_1589_16258_16298(message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 15982, 16314);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 16330, 16487) || true) && (isRunAsCredentialSpecified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 16330, 16487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 16394, 16472);

                    f_1589_16394_16471(this, f_1589_16407_16470());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 16330, 16487);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 16503, 20032) || true) && (isSddlSpecified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 16503, 20032);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 16650, 16737);

                    CommonSecurityDescriptor
                    descriptor = f_1589_16688_16736(false, false, sddl)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 16755, 16855);

                    SecurityIdentifier
                    networkSidIdentifier = f_1589_16797_16854(WellKnownSidType.NetworkSid, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 16873, 16907);

                    bool
                    networkDenyAllExists = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 16925, 17312);
                        foreach (CommonAce ace in f_1589_16951_16978_I(f_1589_16951_16978(descriptor)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 16925, 17312);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 17020, 17293) || true) && (f_1589_17024_17074(f_1589_17024_17040(ace), AceQualifier.AccessDenied) && (DynAbs.Tracing.TraceSender.Expression_True(1589, 17024, 17129) && f_1589_17078_17129(f_1589_17078_17100(ace), networkSidIdentifier)) && (DynAbs.Tracing.TraceSender.Expression_True(1589, 17024, 17160) && f_1589_17133_17147(ace) == 268435456))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 17020, 17293);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 17210, 17238);

                                networkDenyAllExists = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1589, 17264, 17270);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 17020, 17293);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 16925, 17312);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1589, 1, 388);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1589, 1, 388);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 17332, 20017);

                    switch (f_1589_17340_17350())
                    {

                        case PSSessionConfigurationAccessMode.Local:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 17332, 20017);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 17462, 17800) || true) && (!networkDenyAllExists)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 17462, 17800);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 17545, 17686);

                                f_1589_17545_17685(f_1589_17545_17572(descriptor), AccessControlType.Deny, networkSidIdentifier, 268435456, InheritanceFlags.None, PropagationFlags.None);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 17716, 17773);

                                sddl = f_1589_17723_17772(descriptor, AccessControlSections.All);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 17462, 17800);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1589, 17828, 17834);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 17332, 20017);

                        case PSSessionConfigurationAccessMode.Remote:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 17332, 20017);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 17927, 19863) || true) && (networkDenyAllExists)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 17927, 19863);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 18065, 18217);

                                f_1589_18065_18216(f_1589_18065_18092(descriptor), AccessControlType.Deny, networkSidIdentifier, 268435456, InheritanceFlags.None, PropagationFlags.None);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 18372, 19747) || true) && (f_1589_18376_18409(f_1589_18376_18403(descriptor)) == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 18372, 19747);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 18519, 18628);

                                    SecurityIdentifier
                                    baSidIdentifier = f_1589_18556_18627(WellKnownSidType.BuiltinAdministratorsSid, null)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 18662, 18799);

                                    f_1589_18662_18798(f_1589_18662_18689(descriptor), AccessControlType.Allow, baSidIdentifier, 268435456, InheritanceFlags.None, PropagationFlags.None);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 18886, 19374) || true) && (f_1589_18890_18919(f_1589_18890_18911()) >= f_1589_18923_18940(6, 2))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 18886, 19374);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 19078, 19164);

                                        SecurityIdentifier
                                        rmSidIdentifier = f_1589_19115_19163(RemoteManagementUsersSID)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 19202, 19339);

                                        f_1589_19202_19338(f_1589_19202_19229(descriptor), AccessControlType.Allow, rmSidIdentifier, 268435456, InheritanceFlags.None, PropagationFlags.None);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 18886, 19374);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 19464, 19545);

                                    SecurityIdentifier
                                    iaSidIdentifier = f_1589_19501_19544(InteractiveUsersSID)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 19579, 19716);

                                    f_1589_19579_19715(f_1589_19579_19606(descriptor), AccessControlType.Allow, iaSidIdentifier, 268435456, InheritanceFlags.None, PropagationFlags.None);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 18372, 19747);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 19779, 19836);

                                sddl = f_1589_19786_19835(descriptor, AccessControlSections.All);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 17927, 19863);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1589, 19891, 19897);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 17332, 20017);

                        case PSSessionConfigurationAccessMode.Disabled:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 17332, 20017);
                            DynAbs.Tracing.TraceSender.TraceBreak(1589, 19992, 19998);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 17332, 20017);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 16503, 20032);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 20048, 20662) || true) && (!isSddlSpecified && (DynAbs.Tracing.TraceSender.Expression_True(1589, 20052, 20088) && !showUISpecified))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 20048, 20662);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 20122, 20647) || true) && (f_1589_20126_20183(f_1589_20126_20136(), PSSessionConfigurationAccessMode.Local))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 20122, 20647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 20334, 20356);

                        sddl = f_1589_20341_20355();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 20122, 20647);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 20122, 20647);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 20398, 20647) || true) && (f_1589_20402_20460(f_1589_20402_20412(), PSSessionConfigurationAccessMode.Remote))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 20398, 20647);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 20605, 20628);

                            sddl = f_1589_20612_20627();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 20398, 20647);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 20122, 20647);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 20048, 20662);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 20728, 20783);

                f_1589_20728_20782();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 20797, 20862);

                f_1589_20797_20861();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 20878, 20961);

                WSManConfigurationOption
                wsmanOption = transportOption as WSManConfigurationOption
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 20977, 21486) || true) && (wsmanOption != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 20977, 21486);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 21034, 21471) || true) && (f_1589_21038_21071(wsmanOption) != null && (DynAbs.Tracing.TraceSender.Expression_True(1589, 21038, 21111) && !isUseSharedProcessSpecified))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 21034, 21471);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 21153, 21391);

                        PSInvalidOperationException
                        ioe = f_1589_21187_21390(f_1589_21245_21389(f_1589_21263_21318(), "ProcessIdleTimeoutSec", "UseSharedProcess"))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 21413, 21452);

                        f_1589_21413_21451(this, f_1589_21435_21450(ioe));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 21034, 21471);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 20977, 21486);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 21502, 21585);

                string
                pluginPath = f_1589_21522_21584()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 21599, 21663);

                pluginPath = f_1589_21612_21662(pluginPath);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 21677, 22008) || true) && (!f_1589_21682_21715(pluginPath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 21677, 22008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 21749, 21936);

                    PSInvalidOperationException
                    ioe = f_1589_21783_21935(f_1589_21841_21934(f_1589_21859_21898(), RemotingConstants.PSPluginDLLName))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 21954, 21993);

                    f_1589_21954_21992(this, f_1589_21976_21991(ioe));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 21677, 22008);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 15916, 22019);

                string
                f_1589_16089_16136()
                {
                    var return_v = RemotingErrorIdStrings.ShowUIAndSDDLCannotExist;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 16089, 16136);
                    return return_v;
                }


                string
                f_1589_16071_16233(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 16071, 16233);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1589_16258_16298(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 16258, 16298);
                    return return_v;
                }


                string
                f_1589_16407_16470()
                {
                    var return_v = RemotingErrorIdStrings.RunAsSessionConfigurationSecurityWarning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 16407, 16470);
                    return return_v;
                }


                int
                f_1589_16394_16471(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param, string
                text)
                {
                    this_param.WriteWarning(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 16394, 16471);
                    return 0;
                }


                System.Security.AccessControl.CommonSecurityDescriptor
                f_1589_16688_16736(bool
                isContainer, bool
                isDS, string
                sddlForm)
                {
                    var return_v = new System.Security.AccessControl.CommonSecurityDescriptor(isContainer, isDS, sddlForm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 16688, 16736);
                    return return_v;
                }


                System.Security.Principal.SecurityIdentifier
                f_1589_16797_16854(System.Security.Principal.WellKnownSidType
                sidType, System.Security.Principal.SecurityIdentifier
                domainSid)
                {
                    var return_v = new System.Security.Principal.SecurityIdentifier(sidType, domainSid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 16797, 16854);
                    return return_v;
                }


                System.Security.AccessControl.DiscretionaryAcl
                f_1589_16951_16978(System.Security.AccessControl.CommonSecurityDescriptor
                this_param)
                {
                    var return_v = this_param.DiscretionaryAcl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 16951, 16978);
                    return return_v;
                }


                System.Security.AccessControl.AceQualifier
                f_1589_17024_17040(System.Security.AccessControl.CommonAce
                this_param)
                {
                    var return_v = this_param.AceQualifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 17024, 17040);
                    return return_v;
                }


                bool
                f_1589_17024_17074(System.Security.AccessControl.AceQualifier
                this_param, System.Security.AccessControl.AceQualifier
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 17024, 17074);
                    return return_v;
                }


                System.Security.Principal.SecurityIdentifier
                f_1589_17078_17100(System.Security.AccessControl.CommonAce
                this_param)
                {
                    var return_v = this_param.SecurityIdentifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 17078, 17100);
                    return return_v;
                }


                bool
                f_1589_17078_17129(System.Security.Principal.SecurityIdentifier
                this_param, System.Security.Principal.SecurityIdentifier
                sid)
                {
                    var return_v = this_param.Equals(sid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 17078, 17129);
                    return return_v;
                }


                int
                f_1589_17133_17147(System.Security.AccessControl.CommonAce
                this_param)
                {
                    var return_v = this_param.AccessMask;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 17133, 17147);
                    return return_v;
                }


                System.Security.AccessControl.DiscretionaryAcl
                f_1589_16951_16978_I(System.Security.AccessControl.DiscretionaryAcl
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 16951, 16978);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode
                f_1589_17340_17350()
                {
                    var return_v = AccessMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 17340, 17350);
                    return return_v;
                }


                System.Security.AccessControl.DiscretionaryAcl
                f_1589_17545_17572(System.Security.AccessControl.CommonSecurityDescriptor
                this_param)
                {
                    var return_v = this_param.DiscretionaryAcl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 17545, 17572);
                    return return_v;
                }


                int
                f_1589_17545_17685(System.Security.AccessControl.DiscretionaryAcl
                this_param, System.Security.AccessControl.AccessControlType
                accessType, System.Security.Principal.SecurityIdentifier
                sid, int
                accessMask, System.Security.AccessControl.InheritanceFlags
                inheritanceFlags, System.Security.AccessControl.PropagationFlags
                propagationFlags)
                {
                    this_param.AddAccess(accessType, sid, accessMask, inheritanceFlags, propagationFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 17545, 17685);
                    return 0;
                }


                string
                f_1589_17723_17772(System.Security.AccessControl.CommonSecurityDescriptor
                this_param, System.Security.AccessControl.AccessControlSections
                includeSections)
                {
                    var return_v = this_param.GetSddlForm(includeSections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 17723, 17772);
                    return return_v;
                }


                System.Security.AccessControl.DiscretionaryAcl
                f_1589_18065_18092(System.Security.AccessControl.CommonSecurityDescriptor
                this_param)
                {
                    var return_v = this_param.DiscretionaryAcl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 18065, 18092);
                    return return_v;
                }


                int
                f_1589_18065_18216(System.Security.AccessControl.DiscretionaryAcl
                this_param, System.Security.AccessControl.AccessControlType
                accessType, System.Security.Principal.SecurityIdentifier
                sid, int
                accessMask, System.Security.AccessControl.InheritanceFlags
                inheritanceFlags, System.Security.AccessControl.PropagationFlags
                propagationFlags)
                {
                    this_param.RemoveAccessSpecific(accessType, sid, accessMask, inheritanceFlags, propagationFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 18065, 18216);
                    return 0;
                }


                System.Security.AccessControl.DiscretionaryAcl
                f_1589_18376_18403(System.Security.AccessControl.CommonSecurityDescriptor
                this_param)
                {
                    var return_v = this_param.DiscretionaryAcl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 18376, 18403);
                    return return_v;
                }


                int
                f_1589_18376_18409(System.Security.AccessControl.DiscretionaryAcl
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 18376, 18409);
                    return return_v;
                }


                System.Security.Principal.SecurityIdentifier
                f_1589_18556_18627(System.Security.Principal.WellKnownSidType
                sidType, System.Security.Principal.SecurityIdentifier
                domainSid)
                {
                    var return_v = new System.Security.Principal.SecurityIdentifier(sidType, domainSid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 18556, 18627);
                    return return_v;
                }


                System.Security.AccessControl.DiscretionaryAcl
                f_1589_18662_18689(System.Security.AccessControl.CommonSecurityDescriptor
                this_param)
                {
                    var return_v = this_param.DiscretionaryAcl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 18662, 18689);
                    return return_v;
                }


                int
                f_1589_18662_18798(System.Security.AccessControl.DiscretionaryAcl
                this_param, System.Security.AccessControl.AccessControlType
                accessType, System.Security.Principal.SecurityIdentifier
                sid, int
                accessMask, System.Security.AccessControl.InheritanceFlags
                inheritanceFlags, System.Security.AccessControl.PropagationFlags
                propagationFlags)
                {
                    this_param.AddAccess(accessType, sid, accessMask, inheritanceFlags, propagationFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 18662, 18798);
                    return 0;
                }


                System.OperatingSystem
                f_1589_18890_18911()
                {
                    var return_v = Environment.OSVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 18890, 18911);
                    return return_v;
                }


                System.Version
                f_1589_18890_18919(System.OperatingSystem
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 18890, 18919);
                    return return_v;
                }


                System.Version
                f_1589_18923_18940(int
                major, int
                minor)
                {
                    var return_v = new System.Version(major, minor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 18923, 18940);
                    return return_v;
                }


                System.Security.Principal.SecurityIdentifier
                f_1589_19115_19163(string
                sddlForm)
                {
                    var return_v = new System.Security.Principal.SecurityIdentifier(sddlForm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 19115, 19163);
                    return return_v;
                }


                System.Security.AccessControl.DiscretionaryAcl
                f_1589_19202_19229(System.Security.AccessControl.CommonSecurityDescriptor
                this_param)
                {
                    var return_v = this_param.DiscretionaryAcl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 19202, 19229);
                    return return_v;
                }


                int
                f_1589_19202_19338(System.Security.AccessControl.DiscretionaryAcl
                this_param, System.Security.AccessControl.AccessControlType
                accessType, System.Security.Principal.SecurityIdentifier
                sid, int
                accessMask, System.Security.AccessControl.InheritanceFlags
                inheritanceFlags, System.Security.AccessControl.PropagationFlags
                propagationFlags)
                {
                    this_param.AddAccess(accessType, sid, accessMask, inheritanceFlags, propagationFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 19202, 19338);
                    return 0;
                }


                System.Security.Principal.SecurityIdentifier
                f_1589_19501_19544(string
                sddlForm)
                {
                    var return_v = new System.Security.Principal.SecurityIdentifier(sddlForm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 19501, 19544);
                    return return_v;
                }


                System.Security.AccessControl.DiscretionaryAcl
                f_1589_19579_19606(System.Security.AccessControl.CommonSecurityDescriptor
                this_param)
                {
                    var return_v = this_param.DiscretionaryAcl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 19579, 19606);
                    return return_v;
                }


                int
                f_1589_19579_19715(System.Security.AccessControl.DiscretionaryAcl
                this_param, System.Security.AccessControl.AccessControlType
                accessType, System.Security.Principal.SecurityIdentifier
                sid, int
                accessMask, System.Security.AccessControl.InheritanceFlags
                inheritanceFlags, System.Security.AccessControl.PropagationFlags
                propagationFlags)
                {
                    this_param.AddAccess(accessType, sid, accessMask, inheritanceFlags, propagationFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 19579, 19715);
                    return 0;
                }


                string
                f_1589_19786_19835(System.Security.AccessControl.CommonSecurityDescriptor
                this_param, System.Security.AccessControl.AccessControlSections
                includeSections)
                {
                    var return_v = this_param.GetSddlForm(includeSections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 19786, 19835);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode
                f_1589_20126_20136()
                {
                    var return_v = AccessMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 20126, 20136);
                    return return_v;
                }


                bool
                f_1589_20126_20183(System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode
                this_param, System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 20126, 20183);
                    return return_v;
                }


                string
                f_1589_20341_20355()
                {
                    var return_v = GetLocalSddl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 20341, 20355);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode
                f_1589_20402_20412()
                {
                    var return_v = AccessMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 20402, 20412);
                    return return_v;
                }


                bool
                f_1589_20402_20460(System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode
                this_param, System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 20402, 20460);
                    return return_v;
                }


                string
                f_1589_20612_20627()
                {
                    var return_v = GetRemoteSddl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 20612, 20627);
                    return return_v;
                }


                int
                f_1589_20728_20782()
                {
                    RemotingCommandUtil.CheckRemotingCmdletPrerequisites();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 20728, 20782);
                    return 0;
                }


                int
                f_1589_20797_20861()
                {
                    PSSessionConfigurationCommandUtilities.ThrowIfNotAdministrator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 20797, 20861);
                    return 0;
                }


                int?
                f_1589_21038_21071(Microsoft.PowerShell.Commands.WSManConfigurationOption
                this_param)
                {
                    var return_v = this_param.ProcessIdleTimeoutSec;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 21038, 21071);
                    return return_v;
                }


                string
                f_1589_21263_21318()
                {
                    var return_v = RemotingErrorIdStrings.InvalidConfigurationXMLAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 21263, 21318);
                    return return_v;
                }


                string
                f_1589_21245_21389(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 21245, 21389);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1589_21187_21390(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 21187, 21390);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1589_21435_21450(System.Management.Automation.PSInvalidOperationException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 21435, 21450);
                    return return_v;
                }


                int
                f_1589_21413_21451(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 21413, 21451);
                    return 0;
                }


                string
                f_1589_21522_21584()
                {
                    var return_v = PSSessionConfigurationCommandUtilities.GetWinrmPluginDllPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 21522, 21584);
                    return return_v;
                }


                string
                f_1589_21612_21662(string
                name)
                {
                    var return_v = Environment.ExpandEnvironmentVariables(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 21612, 21662);
                    return return_v;
                }


                bool
                f_1589_21682_21715(string
                path)
                {
                    var return_v = System.IO.File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 21682, 21715);
                    return return_v;
                }


                string
                f_1589_21859_21898()
                {
                    var return_v = RemotingErrorIdStrings.PluginDllMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 21859, 21898);
                    return return_v;
                }


                string
                f_1589_21841_21934(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 21841, 21934);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1589_21783_21935(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 21783, 21935);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1589_21976_21991(System.Management.Automation.PSInvalidOperationException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 21976, 21991);
                    return return_v;
                }


                int
                f_1589_21954_21992(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 21954, 21992);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 15916, 22019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 15916, 22019);
            }
        }

        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 22179, 28809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 22243, 22336);

                f_1589_22243_22335(this, f_1589_22256_22334(f_1589_22274_22314(), newPluginSbFormat));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 22352, 23375) || true) && (!force)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 22352, 23375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 22396, 22533);

                    string
                    shouldProcessAction = f_1589_22425_22532(f_1589_22443_22487(), f_1589_22510_22531(f_1589_22510_22526(this)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 22551, 22578);

                    string
                    shouldProcessTarget
                    = default(string);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 22598, 22966) || true) && (isSddlSpecified)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 22598, 22966);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 22659, 22762);

                        shouldProcessTarget = f_1589_22681_22761(f_1589_22699_22748(), f_1589_22750_22754(), sddl);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 22598, 22966);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 22598, 22966);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 22844, 22947);

                        shouldProcessTarget = f_1589_22866_22946(f_1589_22884_22939(), f_1589_22941_22945());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 22598, 22966);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 22986, 23110);

                    string
                    action = f_1589_23002_23109(f_1589_23020_23064(), f_1589_23087_23108(f_1589_23087_23103(this)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 23128, 23212);

                    f_1589_23128_23211(this, f_1589_23141_23210(f_1589_23159_23201(), action));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 23232, 23360) || true) && (!f_1589_23237_23292(this, shouldProcessTarget, shouldProcessAction))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 23232, 23360);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 23334, 23341);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 23232, 23360);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 22352, 23375);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 23444, 23469);

                string
                srcConfigFilePath
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 23483, 23509);

                string
                destConfigFilePath
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 23571, 23664);

                string
                pluginContent = f_1589_23594_23663(this, out srcConfigFilePath, out destConfigFilePath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 23736, 23788);

                string
                file = f_1589_23750_23787(this, pluginContent)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 23914, 24125) || true) && (isRunAsCredentialSpecified || (DynAbs.Tracing.TraceSender.Expression_False(1589, 23918, 23976) || f_1589_23948_23976()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 23914, 24125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 24010, 24110);

                    f_1589_24010_24109(f_1589_24080_24108());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 23914, 24125);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 24208, 24427) || true) && (!isRunAsCredentialSpecified && (DynAbs.Tracing.TraceSender.Expression_True(1589, 24212, 24278) && !f_1589_24244_24278(_gmsaAccount)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 24208, 24427);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 24312, 24412);

                    runAsCredential = f_1589_24330_24411(_gmsaAccount);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 24208, 24427);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 24552, 24631);

                    string
                    restartServiceAction = f_1589_24582_24630()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 24649, 24756);

                    string
                    restartServiceTarget = f_1589_24679_24755(f_1589_24697_24745(), "WinRM")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 24776, 25067);

                    string
                    restartWSManRequiredForUI = f_1589_24811_25066(f_1589_24829_24878(), f_1589_24901_25065(f_1589_24915_24943(), "Set-PSSessionConfiguration {0} -ShowSecurityDescriptorUI", shellName))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 25179, 25199);

                    bool
                    whatIf = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 25274, 25294);

                    bool
                    confirm = true
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 25312, 25413);

                    f_1589_25312_25412(this, out whatIf, out confirm);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 25561, 25587);

                    object
                    errorAction = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 25605, 25806) || true) && (f_1589_25609_25672(f_1589_25609_25655(f_1589_25609_25640(f_1589_25609_25616()))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 25605, 25806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 25714, 25787);

                        errorAction = f_1589_25728_25786(f_1589_25728_25774(f_1589_25728_25759(f_1589_25728_25735())));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 25605, 25806);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 25826, 25887);

                    ArrayList
                    errorList = (ArrayList)f_1589_25859_25886(f_1589_25859_25866())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 25905, 25944);

                    int
                    errorCountBefore = f_1589_25928_25943(errorList)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 25964, 26396) || true) && (force && (DynAbs.Tracing.TraceSender.Expression_True(1589, 25968, 26014) && f_1589_25994_26006(this) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1589, 25968, 26075) && f_1589_26035_26067(f_1589_26035_26047(this)) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1589, 25968, 26149) && f_1589_26096_26141(f_1589_26096_26128(f_1589_26096_26108(this))) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1589, 25968, 26273) && f_1589_26170_26215(f_1589_26170_26202(f_1589_26170_26182(this))) is System.Management.Automation.Remoting.ServerRemoteHost))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 25964, 26396);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 26315, 26377);

                        f_1589_26315_26376(this, f_1589_26328_26375());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 25964, 26396);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 26416, 27882);

                    f_1589_26416_27881(
                                    s_newPluginSb, contextCmdlet: this, useLocalScope: true, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: f_1589_26670_26690(), input: f_1589_26720_26741(), scriptThis: f_1589_26776_26796(), args: new object[] {
                                            file,
                                            shellName,
f_1589_26992_27016().ToBool(),
                                            force,
                                            whatIf,
                                            confirm,
                                            restartServiceTarget,
                                            restartServiceAction,
                                            restartWSManRequiredForUI,
(DynAbs.Tracing.TraceSender.Conditional_F1(1589, 27437, 27460)||((                                            runAsCredential != null &&DynAbs.Tracing.TraceSender.Conditional_F2(1589, 27463, 27487))||DynAbs.Tracing.TraceSender.Conditional_F3(1589, 27490, 27494)))?f_1589_27463_27487(runAsCredential):null,
(DynAbs.Tracing.TraceSender.Conditional_F1(1589, 27541, 27564)||((                                            runAsCredential != null &&DynAbs.Tracing.TraceSender.Conditional_F2(1589, 27567, 27591))||DynAbs.Tracing.TraceSender.Conditional_F3(1589, 27594, 27598)))?f_1589_27567_27591(runAsCredential):null,
f_1589_27645_27655(),
                                            isSddlSpecified,
                                            _configTableSDDL,
                                            errorAction
                                                           });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 27902, 27953);

                    errorList = (ArrayList)f_1589_27925_27952(f_1589_27925_27932());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 27971, 28025);

                    _isErrorReported = f_1589_27990_28005(errorList) > errorCountBefore;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1589, 28054, 28126);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 28094, 28111);

                    f_1589_28094_28110(this, file);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1589, 28054, 28126);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 28319, 28798) || true) && ((srcConfigFilePath != null) && (DynAbs.Tracing.TraceSender.Expression_True(1589, 28323, 28382) && (destConfigFilePath != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1589, 28323, 28435) && !f_1589_28404_28435(destConfigFilePath)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 28319, 28798);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 28513, 28568);

                        f_1589_28513_28567(srcConfigFilePath, destConfigFilePath, true);
                    }
                    catch (IOException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 28605, 28628);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 28605, 28628);
                    }
                    catch (ArgumentException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 28646, 28675);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 28646, 28675);
                    }
                    catch (NotSupportedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 28693, 28726);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 28693, 28726);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 28744, 28783);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 28744, 28783);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 28319, 28798);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 22179, 28809);

                string
                f_1589_22274_22314()
                {
                    var return_v = RemotingErrorIdStrings.NcsScriptMessageV;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 22274, 22314);
                    return return_v;
                }


                string
                f_1589_22256_22334(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 22256, 22334);
                    return return_v;
                }


                int
                f_1589_22243_22335(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 22243, 22335);
                    return 0;
                }


                string
                f_1589_22443_22487()
                {
                    var return_v = RemotingErrorIdStrings.CSShouldProcessAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 22443, 22487);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1589_22510_22526(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 22510, 22526);
                    return return_v;
                }


                string
                f_1589_22510_22531(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 22510, 22531);
                    return return_v;
                }


                string
                f_1589_22425_22532(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 22425, 22532);
                    return return_v;
                }


                string
                f_1589_22699_22748()
                {
                    var return_v = RemotingErrorIdStrings.NcsShouldProcessTargetSDDL;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 22699, 22748);
                    return return_v;
                }


                string
                f_1589_22750_22754()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 22750, 22754);
                    return return_v;
                }


                string
                f_1589_22681_22761(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 22681, 22761);
                    return return_v;
                }


                string
                f_1589_22884_22939()
                {
                    var return_v = RemotingErrorIdStrings.CSShouldProcessTargetAdminEnable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 22884, 22939);
                    return return_v;
                }


                string
                f_1589_22941_22945()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 22941, 22945);
                    return return_v;
                }


                string
                f_1589_22866_22946(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 22866, 22946);
                    return return_v;
                }


                string
                f_1589_23020_23064()
                {
                    var return_v = RemotingErrorIdStrings.CSShouldProcessAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 23020, 23064);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1589_23087_23103(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 23087, 23103);
                    return return_v;
                }


                string
                f_1589_23087_23108(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 23087, 23108);
                    return return_v;
                }


                string
                f_1589_23002_23109(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 23002, 23109);
                    return return_v;
                }


                string
                f_1589_23159_23201()
                {
                    var return_v = RemotingErrorIdStrings.WinRMRestartWarning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 23159, 23201);
                    return return_v;
                }


                string
                f_1589_23141_23210(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 23141, 23210);
                    return return_v;
                }


                int
                f_1589_23128_23211(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param, string
                text)
                {
                    this_param.WriteWarning(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 23128, 23211);
                    return 0;
                }


                bool
                f_1589_23237_23292(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param, string
                target, string
                action)
                {
                    var return_v = this_param.ShouldProcess(target, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 23237, 23292);
                    return return_v;
                }


                string
                f_1589_23594_23663(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param, out string
                srcConfigFilePath, out string
                destConfigFilePath)
                {
                    var return_v = this_param.ConstructPluginContent(out srcConfigFilePath, out destConfigFilePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 23594, 23663);
                    return return_v;
                }


                string
                f_1589_23750_23787(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param, string
                pluginContent)
                {
                    var return_v = this_param.ConstructTemporaryFile(pluginContent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 23750, 23787);
                    return return_v;
                }


                bool
                f_1589_23948_23976()
                {
                    var return_v = RunAsVirtualAccountSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 23948, 23976);
                    return return_v;
                }


                bool
                f_1589_24080_24108()
                {
                    var return_v = RunAsVirtualAccountSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 24080, 24108);
                    return return_v;
                }


                int
                f_1589_24010_24109(bool
                forVirtualAccount)
                {
                    PSSessionConfigurationCommandUtilities.MoveWinRmToIsolatedServiceHost(forVirtualAccount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 24010, 24109);
                    return 0;
                }


                bool
                f_1589_24244_24278(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 24244, 24278);
                    return return_v;
                }


                System.Management.Automation.PSCredential
                f_1589_24330_24411(string
                gmsaAccount)
                {
                    var return_v = PSSessionConfigurationCommandUtilities.CreateGMSAAccountCredentials(gmsaAccount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 24330, 24411);
                    return return_v;
                }


                string
                f_1589_24582_24630()
                {
                    var return_v = RemotingErrorIdStrings.RestartWSManServiceAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 24582, 24630);
                    return return_v;
                }


                string
                f_1589_24697_24745()
                {
                    var return_v = RemotingErrorIdStrings.RestartWSManServiceTarget;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 24697, 24745);
                    return return_v;
                }


                string
                f_1589_24679_24755(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 24679, 24755);
                    return return_v;
                }


                string
                f_1589_24829_24878()
                {
                    var return_v = RemotingErrorIdStrings.RestartWSManRequiredShowUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 24829, 24878);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_24915_24943()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 24915, 24943);
                    return return_v;
                }


                string
                f_1589_24901_25065(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 24901, 25065);
                    return return_v;
                }


                string
                f_1589_24811_25066(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 24811, 25066);
                    return return_v;
                }


                int
                f_1589_25312_25412(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                cmdlet, out bool
                whatIf, out bool
                confirm)
                {
                    PSSessionConfigurationCommandUtilities.CollectShouldProcessParameters((System.Management.Automation.PSCmdlet)cmdlet, out whatIf, out confirm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 25312, 25412);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1589_25609_25616()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 25609, 25616);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1589_25609_25640(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 25609, 25640);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1589_25609_25655(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 25609, 25655);
                    return return_v;
                }


                bool
                f_1589_25609_25672(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.IsErrorActionSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 25609, 25672);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1589_25728_25735()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 25728, 25735);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1589_25728_25759(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 25728, 25759);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1589_25728_25774(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 25728, 25774);
                    return return_v;
                }


                System.Management.Automation.ActionPreference
                f_1589_25728_25786(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.ErrorAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 25728, 25786);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1589_25859_25866()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 25859, 25866);
                    return return_v;
                }


                object
                f_1589_25859_25886(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.DollarErrorVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 25859, 25886);
                    return return_v;
                }


                int
                f_1589_25928_25943(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 25928, 25943);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1589_25994_26006(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 25994, 26006);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1589_26035_26047(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 26035, 26047);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1589_26035_26067(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 26035, 26067);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1589_26096_26108(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 26096, 26108);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1589_26096_26128(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 26096, 26128);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1589_26096_26141(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.ExternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 26096, 26141);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1589_26170_26182(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 26170, 26182);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1589_26170_26202(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 26170, 26202);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1589_26170_26215(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.ExternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 26170, 26215);
                    return return_v;
                }


                string
                f_1589_26328_26375()
                {
                    var return_v = RemotingErrorIdStrings.WinRMForceRestartWarning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 26328, 26375);
                    return return_v;
                }


                int
                f_1589_26315_26376(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param, string
                text)
                {
                    this_param.WriteWarning(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 26315, 26376);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1589_26670_26690()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 26670, 26690);
                    return return_v;
                }


                object[]
                f_1589_26720_26741()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 26720, 26741);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_26776_26796()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 26776, 26796);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1589_26992_27016()
                {
                    var return_v = ShowSecurityDescriptorUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 26992, 27016);
                    return return_v;
                }


                string
                f_1589_27463_27487(System.Management.Automation.PSCredential
                this_param)
                {
                    var return_v = this_param.UserName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 27463, 27487);
                    return return_v;
                }


                System.Security.SecureString
                f_1589_27567_27591(System.Management.Automation.PSCredential
                this_param)
                {
                    var return_v = this_param.Password;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 27567, 27591);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode
                f_1589_27645_27655()
                {
                    var return_v = AccessMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 27645, 27655);
                    return return_v;
                }


                int
                f_1589_26416_27881(System.Management.Automation.ScriptBlock
                this_param, Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                contextCmdlet, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, object[]
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    this_param.InvokeUsingCmdlet(contextCmdlet: (System.Management.Automation.Cmdlet)contextCmdlet, useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 26416, 27881);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1589_27925_27932()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 27925, 27932);
                    return return_v;
                }


                object
                f_1589_27925_27952(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.DollarErrorVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 27925, 27952);
                    return return_v;
                }


                int
                f_1589_27990_28005(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 27990, 28005);
                    return return_v;
                }


                int
                f_1589_28094_28110(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param, string
                tmpFileName)
                {
                    this_param.DeleteFile(tmpFileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 28094, 28110);
                    return 0;
                }


                bool
                f_1589_28404_28435(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 28404, 28435);
                    return return_v;
                }


                int
                f_1589_28513_28567(string
                sourceFileName, string
                destFileName, bool
                overwrite)
                {
                    File.Copy(sourceFileName, destFileName, overwrite);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 28513, 28567);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 22179, 28809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 22179, 28809);
            }
        }

        protected override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 28868, 29132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 28932, 29035);

                System.Management.Automation.Tracing.Tracer
                tracer = f_1589_28985_29034()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 29049, 29121);

                f_1589_29049_29120(tracer, f_1589_29075_29084(this), f_1589_29086_29119(f_1589_29086_29114()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 28868, 29132);

                System.Management.Automation.Tracing.Tracer
                f_1589_28985_29034()
                {
                    var return_v = new System.Management.Automation.Tracing.Tracer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 28985, 29034);
                    return return_v;
                }


                string
                f_1589_29075_29084(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 29075, 29084);
                    return return_v;
                }


                System.Security.Principal.WindowsIdentity
                f_1589_29086_29114()
                {
                    var return_v = WindowsIdentity.GetCurrent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 29086, 29114);
                    return return_v;
                }


                string
                f_1589_29086_29119(System.Security.Principal.WindowsIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 29086, 29119);
                    return return_v;
                }


                int
                f_1589_29049_29120(System.Management.Automation.Tracing.Tracer
                this_param, string
                endpointName, string
                registeredBy)
                {
                    this_param.EndpointRegistered(endpointName, registeredBy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 29049, 29120);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 28868, 29132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 28868, 29132);
            }
        }

        private void DeleteFile(string tmpFileName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 29554, 30839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 29622, 29705);

                f_1589_29622_29704(!f_1589_29634_29667(tmpFileName), "tmpFile cannot be null or empty.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 29721, 29740);

                Exception
                e = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 29790, 29815);

                    f_1589_29790_29814(tmpFileName);
                    // WriteWarning(tmpFileName);
                }
                catch (UnauthorizedAccessException uae)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 29891, 29986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 29963, 29971);

                    e = uae;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 29891, 29986);
                }
                catch (ArgumentException ae)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 30000, 30083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 30061, 30068);

                    e = ae;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 30000, 30083);
                }
                catch (PathTooLongException pe)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 30097, 30183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 30161, 30168);

                    e = pe;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 30097, 30183);
                }
                catch (DirectoryNotFoundException dnfe)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 30197, 30293);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 30269, 30278);

                    e = dnfe;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 30197, 30293);
                }
                catch (IOException ioe)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 30307, 30386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 30363, 30371);

                    e = ioe;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 30307, 30386);
                }
                catch (NotSupportedException nse)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 30400, 30489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 30466, 30474);

                    e = nse;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 30400, 30489);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 30505, 30828) || true) && (e != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 30505, 30828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 30552, 30813);

                    throw f_1589_30558_30812(f_1589_30601_30655(), tmpFileName, f_1589_30802_30811(e));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 30505, 30828);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 29554, 30839);

                bool
                f_1589_29634_29667(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 29634, 29667);
                    return return_v;
                }


                int
                f_1589_29622_29704(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 29622, 29704);
                    return 0;
                }


                int
                f_1589_29790_29814(string
                path)
                {
                    File.Delete(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 29790, 29814);
                    return 0;
                }


                string
                f_1589_30601_30655()
                {
                    var return_v = RemotingErrorIdStrings.NcsCannotDeleteFileAfterInstall;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 30601, 30655);
                    return return_v;
                }


                string
                f_1589_30802_30811(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 30802, 30811);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1589_30558_30812(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 30558, 30812);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 29554, 30839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 29554, 30839);
            }
        }

        private string ConstructTemporaryFile(string pluginContent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 31282, 34839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 31464, 31590);

                string
                tmpFileName = f_1589_31485_31573(f_1589_31508_31536(), f_1589_31538_31572()) + "psshell.xml"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 31606, 31625);

                Exception
                e = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 31690, 33780) || true) && (f_1589_31694_31718(tmpFileName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 31690, 33780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 31752, 31798);

                    FileInfo
                    destfile = f_1589_31772_31797(tmpFileName)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 31816, 33765) || true) && (destfile != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 31816, 33765);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 31994, 32089);

                            destfile.Attributes = f_1589_32016_32035(destfile) & ~(FileAttributes.ReadOnly | FileAttributes.Hidden);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 32115, 32133);

                            f_1589_32115_32132(destfile);
                        }
                        catch (FileNotFoundException fnf)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 32178, 32291);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 32260, 32268);

                            e = fnf;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 32178, 32291);
                        }
                        catch (DirectoryNotFoundException dnf)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 32313, 32431);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 32400, 32408);

                            e = dnf;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 32313, 32431);
                        }
                        catch (UnauthorizedAccessException uac)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 32453, 32572);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 32541, 32549);

                            e = uac;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 32453, 32572);
                        }
                        catch (System.Security.SecurityException se)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 32594, 32717);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 32687, 32694);

                            e = se;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 32594, 32717);
                        }
                        catch (ArgumentNullException ane)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 32739, 32852);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 32821, 32829);

                            e = ane;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 32739, 32852);
                        }
                        catch (ArgumentException ae)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 32874, 32981);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 32951, 32958);

                            e = ae;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 32874, 32981);
                        }
                        catch (PathTooLongException pe)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 33003, 33113);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 33083, 33090);

                            e = pe;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 33003, 33113);
                        }
                        catch (NotSupportedException ns)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 33135, 33246);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 33216, 33223);

                            e = ns;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 33135, 33246);
                        }
                        catch (IOException ioe)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 33268, 33371);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 33340, 33348);

                            e = ioe;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 33268, 33371);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 33395, 33746) || true) && (e != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 33395, 33746);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 33458, 33723);

                            throw f_1589_33464_33722(f_1589_33507_33549(), tmpFileName, f_1589_33712_33721(e));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 33395, 33746);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 31816, 33765);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 31690, 33780);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 33832, 34027);
                    using (StreamWriter
                    fileStream = f_1589_33865_33893(tmpFileName)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 33935, 33967);

                        f_1589_33935_33966(fileStream, pluginContent);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 33989, 34008);

                        f_1589_33989_34007(fileStream);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1589, 33832, 34027);
                    }
                }
                catch (UnauthorizedAccessException uae)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 34056, 34151);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 34128, 34136);

                    e = uae;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 34056, 34151);
                }
                catch (ArgumentException ae)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 34165, 34248);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 34226, 34233);

                    e = ae;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 34165, 34248);
                }
                catch (PathTooLongException pe)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 34262, 34348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 34326, 34333);

                    e = pe;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 34262, 34348);
                }
                catch (DirectoryNotFoundException dnfe)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 34362, 34458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 34434, 34443);

                    e = dnfe;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 34362, 34458);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 34474, 34793) || true) && (e != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 34474, 34793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 34521, 34778);

                    throw f_1589_34527_34777(f_1589_34570_34620(), tmpFileName, f_1589_34767_34776(e));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 34474, 34793);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 34809, 34828);

                return tmpFileName;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 31282, 34839);

                string
                f_1589_31508_31536()
                {
                    var return_v = System.IO.Path.GetTempPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 31508, 31536);
                    return return_v;
                }


                string
                f_1589_31538_31572()
                {
                    var return_v = System.IO.Path.GetRandomFileName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 31538, 31572);
                    return return_v;
                }


                string
                f_1589_31485_31573(string
                path1, string
                path2)
                {
                    var return_v = System.IO.Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 31485, 31573);
                    return return_v;
                }


                bool
                f_1589_31694_31718(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 31694, 31718);
                    return return_v;
                }


                System.IO.FileInfo
                f_1589_31772_31797(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 31772, 31797);
                    return return_v;
                }


                System.IO.FileAttributes
                f_1589_32016_32035(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 32016, 32035);
                    return return_v;
                }


                int
                f_1589_32115_32132(System.IO.FileInfo
                this_param)
                {
                    this_param.Delete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 32115, 32132);
                    return 0;
                }


                string
                f_1589_33507_33549()
                {
                    var return_v = RemotingErrorIdStrings.NcsCannotDeleteFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 33507, 33549);
                    return return_v;
                }


                string
                f_1589_33712_33721(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 33712, 33721);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1589_33464_33722(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 33464, 33722);
                    return return_v;
                }


                System.IO.StreamWriter
                f_1589_33865_33893(string
                path)
                {
                    var return_v = File.CreateText(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 33865, 33893);
                    return return_v;
                }


                int
                f_1589_33935_33966(System.IO.StreamWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 33935, 33966);
                    return 0;
                }


                int
                f_1589_33989_34007(System.IO.StreamWriter
                this_param)
                {
                    this_param.Flush();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 33989, 34007);
                    return 0;
                }


                string
                f_1589_34570_34620()
                {
                    var return_v = RemotingErrorIdStrings.NcsCannotWritePluginContent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 34570, 34620);
                    return return_v;
                }


                string
                f_1589_34767_34776(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 34767, 34776);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1589_34527_34777(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 34527, 34777);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 31282, 34839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 31282, 34839);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string ConstructPluginContent(out string srcConfigFilePath, out string destConfigFilePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 34851, 56321);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 34974, 34999);

                srcConfigFilePath = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 35013, 35039);

                destConfigFilePath = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 35053, 35104);

                StringBuilder
                initParameters = f_1589_35084_35103()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 35120, 35158);

                bool
                assemblyAndTypeTokensSet = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 35204, 45698) || true) && (f_1589_35208_35212() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 35204, 45698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 35254, 35283);

                    ProviderInfo
                    provider = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 35301, 35319);

                    PSDriveInfo
                    drive
                    = default(PSDriveInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 35337, 35440);

                    string
                    filePath = f_1589_35355_35439(f_1589_35355_35372(f_1589_35355_35367()), f_1589_35409_35413(), out provider, out drive)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 35460, 36092) || true) && (!f_1589_35465_35518(provider, f_1589_35485_35517(f_1589_35485_35506(f_1589_35485_35492()))) || (DynAbs.Tracing.TraceSender.Expression_False(1589, 35464, 35620) || !f_1589_35523_35620(filePath, StringLiterals.PowerShellDISCFileExtension, StringComparison.OrdinalIgnoreCase)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 35460, 36092);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 35662, 35769);

                        string
                        message = f_1589_35679_35768(f_1589_35697_35757(), filePath)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 35791, 35862);

                        InvalidOperationException
                        ioe = f_1589_35823_35861(message)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 35884, 36025);

                        ErrorRecord
                        er = f_1589_35901_36024(ioe, "InvalidPSSessionConfigurationFilePath", ErrorCategory.InvalidArgument, f_1589_36019_36023())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 36047, 36073);

                        f_1589_36047_36072(this, er);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 35460, 36092);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 36112, 36142);

                    Guid
                    sessionGuid = Guid.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 36217, 36235);

                    string
                    scriptName
                    = default(string);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 36253, 36290);

                    ExternalScriptInfo
                    scriptInfo = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 36308, 36337);

                    Hashtable
                    configTable = null
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 36401, 36485);

                        scriptInfo = f_1589_36414_36484(f_1589_36445_36457(this), filePath, out scriptName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 36507, 36572);

                        configTable = f_1589_36521_36571(f_1589_36546_36558(this), scriptInfo);
                    }
                    catch (RuntimeException rte)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 36609, 37137);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 36678, 36809);

                        string
                        message = f_1589_36695_36808(f_1589_36713_36784(), filePath, f_1589_36796_36807(rte))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 36831, 36907);

                        InvalidOperationException
                        ioe = f_1589_36863_36906(message, rte)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 36929, 37070);

                        ErrorRecord
                        er = f_1589_36946_37069(ioe, "InvalidPSSessionConfigurationFilePath", ErrorCategory.InvalidArgument, f_1589_37064_37068())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 37092, 37118);

                        f_1589_37092_37117(this, er);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 36609, 37137);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 37157, 43131) || true) && (configTable == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 37157, 43131);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 37222, 37325);

                        string
                        message = f_1589_37239_37324(f_1589_37257_37313(), filePath)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 37347, 37418);

                        InvalidOperationException
                        ioe = f_1589_37379_37417(message)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 37440, 37577);

                        ErrorRecord
                        er = f_1589_37457_37576(ioe, "InvalidPSSessionConfigurationFile", ErrorCategory.InvalidArgument, f_1589_37571_37575())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 37599, 37625);

                        f_1589_37599_37624(this, er);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 37157, 43131);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 37157, 43131);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 37707, 38920) || true) && (f_1589_37711_37760(configTable, ConfigFileConstants.Guid))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 37707, 38920);
                            try
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 37870, 38612) || true) && (f_1589_37874_37911(configTable, ConfigFileConstants.Guid) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 37870, 38612);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 37985, 38060);

                                    sessionGuid = Guid.Parse(f_1589_38010_38058(f_1589_38010_38047(configTable, ConfigFileConstants.Guid)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 37870, 38612);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 37870, 38612);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 38190, 38400);

                                    InvalidOperationException
                                    invalidOperationException = f_1589_38244_38399(f_1589_38274_38398(f_1589_38292_38361(), ConfigFileConstants.Guid, filePath))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 38434, 38581);

                                    f_1589_38434_38580(this, f_1589_38456_38579(invalidOperationException, "InvalidGuidInPSSessionConfigurationFile", ErrorCategory.InvalidOperation, null));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 37870, 38612);
                                }
                            }
                            catch (FormatException e)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 38665, 38897);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 38747, 38870);

                                f_1589_38747_38869(this, f_1589_38769_38868(e, "InvalidGuidInPSSessionConfigurationFile", ErrorCategory.InvalidOperation, null));
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 38665, 38897);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 37707, 38920);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 38944, 40168) || true) && (f_1589_38948_39010(configTable, ConfigFileConstants.PowerShellVersion))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 38944, 40168);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 39060, 40145) || true) && (isPSVersionSpecified == false)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 39060, 40145);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 39219, 39306);

                                    PSVersion = f_1589_39231_39305(f_1589_39243_39304(f_1589_39243_39293(configTable, ConfigFileConstants.PowerShellVersion)));
                                }
                                catch (ArgumentException e)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 39367, 39598);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 39459, 39567);

                                    f_1589_39459_39566(this, f_1589_39481_39565(e, "InvalidPowerShellVersion", ErrorCategory.InvalidOperation, null));
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 39367, 39598);
                                }
                                catch (FormatException e)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 39628, 39857);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 39718, 39826);

                                    f_1589_39718_39825(this, f_1589_39740_39824(e, "InvalidPowerShellVersion", ErrorCategory.InvalidOperation, null));
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 39628, 39857);
                                }
                                catch (OverflowException e)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 39887, 40118);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 39979, 40087);

                                    f_1589_39979_40086(this, f_1589_40001_40085(e, "InvalidPowerShellVersion", ErrorCategory.InvalidOperation, null));
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 39887, 40118);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 39060, 40145);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 38944, 40168);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 40192, 40516) || true) && (f_1589_40196_40260(configTable, ConfigFileConstants.RunAsVirtualAccount))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 40192, 40516);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 40310, 40426);

                            this.RunAsVirtualAccount = f_1589_40337_40425(f_1589_40372_40424(configTable, ConfigFileConstants.RunAsVirtualAccount));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 40452, 40493);

                            this.RunAsVirtualAccountSpecified = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 40192, 40516);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 40540, 40931) || true) && (f_1589_40544_40614(configTable, ConfigFileConstants.RunAsVirtualAccountGroups))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 40540, 40931);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 40664, 40908);

                            this.RunAsVirtualAccountGroups = f_1589_40697_40907(f_1589_40801_40906(f_1589_40847_40905(configTable, ConfigFileConstants.RunAsVirtualAccountGroups)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 40540, 40931);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 40955, 41158) || true) && (f_1589_40959_41015(configTable, ConfigFileConstants.GMSAAccount))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 40955, 41158);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 41065, 41135);

                            _gmsaAccount = f_1589_41080_41124(configTable, ConfigFileConstants.GMSAAccount) as string;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 40955, 41158);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 41284, 41302);

                        ErrorRecord
                        error
                        = default(ErrorRecord);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 41324, 41523);

                        _configTableSDDL = f_1589_41343_41522(configTable, f_1589_41475_41485(), out error);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 41545, 41653) || true) && (error != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 41545, 41653);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 41612, 41630);

                            f_1589_41612_41629(this, error);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 41545, 41653);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 41761, 42325) || true) && (f_1589_41765_41803(_configTableSDDL) && (DynAbs.Tracing.TraceSender.Expression_True(1589, 41765, 41828) && !this.isSddlSpecified) && (DynAbs.Tracing.TraceSender.Expression_True(1589, 41765, 41859) && !f_1589_41833_41859(sddl)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 41761, 42325);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 41909, 42026);

                            string
                            configGroupMemberShipACE = f_1589_41943_42025(configTable)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 42052, 42302) || true) && (!f_1589_42057_42103(configGroupMemberShipACE))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 42052, 42302);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 42161, 42275);

                                sddl = f_1589_42168_42274(sddl, configGroupMemberShipACE);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 42052, 42302);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 41761, 42325);
                        }

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 42401, 42466);

                            f_1589_42401_42465(f_1589_42433_42445(), configTable, f_1589_42460_42464());
                        }
                        catch (InvalidOperationException e)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 42511, 42727);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 42595, 42704);

                            f_1589_42595_42703(this, f_1589_42617_42702(e, "RelativePathsNotSupported", ErrorCategory.InvalidOperation, null));
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 42511, 42727);
                        }

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 42803, 42851);

                            f_1589_42803_42850(configTable, f_1589_42845_42849());
                        }
                        catch (InvalidOperationException e)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 42896, 43112);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 42980, 43089);

                            f_1589_42980_43088(this, f_1589_43002_43087(e, "FileExtensionNotSupported", ErrorCategory.InvalidOperation, null));
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 42896, 43112);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 37157, 43131);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 43151, 43243);

                    string
                    destFolder = f_1589_43171_43242(f_1589_43194_43224(), "SessionConfig")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 43261, 43393) || true) && (!f_1589_43266_43294(destFolder))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 43261, 43393);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 43336, 43374);

                        f_1589_43336_43373(destFolder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 43261, 43393);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 43413, 43574);

                    string
                    destPath = f_1589_43431_43573(destFolder, shellName + "_" + sessionGuid.ToString() + StringLiterals.PowerShellDISCFileExtension)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 43592, 44590) || true) && (f_1589_43596_43675(f_1589_43610_43631(), "x86", StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 43592, 44590);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 43717, 43796);

                        string
                        procArch = f_1589_43735_43795("PROCESSOR_ARCHITECTURE")
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 43820, 44571) || true) && (f_1589_43824_43892(procArch, "amd64", StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1589, 43824, 43988) || f_1589_43921_43988(procArch, "ia64", StringComparison.OrdinalIgnoreCase)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 43820, 44571);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 44051, 44166);

                            InvalidOperationException
                            ioe = f_1589_44083_44165(f_1589_44113_44164())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 44192, 44299);

                            ErrorRecord
                            er = f_1589_44209_44298(ioe, "InvalidProcessorArchitecture", ErrorCategory.InvalidArgument, f_1589_44293_44297())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 44325, 44351);

                            f_1589_44325_44350(this, er);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 43820, 44571);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 43592, 44590);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 44890, 44919);

                    srcConfigFilePath = filePath;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 44937, 44967);

                    destConfigFilePath = destPath;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 45018, 45103);

                    string
                    destConfigFileDirectory = f_1589_45051_45102(destConfigFilePath)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 45277, 45338);

                    f_1589_45277_45337(destConfigFileDirectory);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 45358, 45413);

                    f_1589_45358_45412(srcConfigFilePath, destConfigFilePath, true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 45433, 45683);

                    f_1589_45433_45682(
                                    initParameters, f_1589_45455_45681(f_1589_45469_45497(), initParamFormat, ConfigurationDataFromXML.CONFIGFILEPATH_CamelCase, destPath, f_1589_45661_45680()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 35204, 45698);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 45714, 46555) || true) && (!assemblyAndTypeTokensSet)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 45714, 46555);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 45777, 46161) || true) && (!f_1589_45782_45825(configurationTypeName))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 45777, 46161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 45867, 46142);

                        f_1589_45867_46141(initParameters, f_1589_45889_46140(f_1589_45903_45931(), initParamFormat, ConfigurationDataFromXML.SHELLCONFIGTYPETOKEN, configurationTypeName, f_1589_46120_46139()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 45777, 46161);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 46181, 46540) || true) && (!f_1589_46186_46220(assemblyName))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 46181, 46540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 46262, 46521);

                        f_1589_46262_46520(initParameters, f_1589_46284_46519(f_1589_46298_46326(), initParamFormat, ConfigurationDataFromXML.ASSEMBLYTOKEN, assemblyName, f_1589_46499_46518()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 46181, 46540);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 45714, 46555);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 46571, 46907) || true) && (!f_1589_46576_46613(applicationBase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 46571, 46907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 46647, 46892);

                    f_1589_46647_46891(initParameters, f_1589_46669_46890(f_1589_46683_46711(), initParamFormat, ConfigurationDataFromXML.APPBASETOKEN, applicationBase, f_1589_46870_46889()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 46571, 46907);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 46923, 47273) || true) && (!f_1589_46928_46969(configurationScript))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 46923, 47273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 47003, 47258);

                    f_1589_47003_47257(initParameters, f_1589_47025_47256(f_1589_47039_47067(), initParamFormat, ConfigurationDataFromXML.STARTUPSCRIPTTOKEN, configurationScript, f_1589_47236_47255()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 46923, 47273);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 47289, 47626) || true) && (f_1589_47293_47318(maxCommandSizeMB))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 47289, 47626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 47352, 47611);

                    f_1589_47352_47610(initParameters, f_1589_47374_47609(f_1589_47388_47416(), initParamFormat, ConfigurationDataFromXML.MAXRCVDCMDSIZETOKEN, f_1589_47544_47566(maxCommandSizeMB), f_1589_47589_47608()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 47289, 47626);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 47642, 47977) || true) && (f_1589_47646_47670(maxObjectSizeMB))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 47642, 47977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 47704, 47962);

                    f_1589_47704_47961(initParameters, f_1589_47726_47960(f_1589_47740_47768(), initParamFormat, ConfigurationDataFromXML.MAXRCVDOBJSIZETOKEN, f_1589_47896_47917(maxObjectSizeMB), f_1589_47940_47959()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 47642, 47977);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 47993, 48326) || true) && (f_1589_47997_48020(threadAptState))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 47993, 48326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 48054, 48311);

                    f_1589_48054_48310(initParameters, f_1589_48076_48309(f_1589_48090_48118(), initParamFormat, ConfigurationDataFromXML.THREADAPTSTATETOKEN, f_1589_48246_48266(threadAptState), f_1589_48289_48308()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 47993, 48326);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 48342, 48672) || true) && (f_1589_48346_48368(threadOptions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 48342, 48672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 48402, 48657);

                    f_1589_48402_48656(initParameters, f_1589_48424_48655(f_1589_48438_48466(), initParamFormat, ConfigurationDataFromXML.THREADOPTIONSTOKEN, f_1589_48593_48612(threadOptions), f_1589_48635_48654()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 48342, 48672);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 48732, 48850) || true) && (isPSVersionSpecified == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 48732, 48850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 48799, 48835);

                    psVersion = f_1589_48811_48834();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 48732, 48850);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 48866, 49860) || true) && (psVersion != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 48866, 49860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 48921, 49237);

                    f_1589_48921_49236(initParameters, f_1589_48943_49235(f_1589_48957_48985(), initParamFormat, ConfigurationDataFromXML.PSVERSIONTOKEN, f_1589_49108_49192(psVersion), f_1589_49215_49234()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 49315, 49402);

                    MaxPSVersion = f_1589_49330_49401(psVersion);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 49422, 49845) || true) && (MaxPSVersion != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 49422, 49845);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 49488, 49826);

                        f_1589_49488_49825(initParameters, f_1589_49510_49824(f_1589_49524_49552(), initParamFormat, ConfigurationDataFromXML.MAXPSVERSIONTOKEN, f_1589_49690_49777(MaxPSVersion), f_1589_49804_49823()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 49422, 49845);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 48866, 49860);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 49876, 49917);

                string
                securityParameters = string.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 49931, 50238) || true) && (!f_1589_49936_49962(sddl))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 49931, 50238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 49996, 50223);

                    securityParameters = f_1589_50017_50222(f_1589_50031_50059(), securityElementFormat, WSManNativeApi.ResourceURIPrefix + shellName, f_1589_50193_50221(sddl));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 49931, 50238);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 50254, 50298);

                string
                architectureParameter = string.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 50312, 50923) || true) && (!f_1589_50317_50360(f_1589_50338_50359()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 50312, 50923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 50394, 50418);

                    string
                    tempValue = "32"
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 50436, 50741);

                    switch (f_1589_50444_50484(f_1589_50444_50465()))
                    {

                        case "x86":
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 50436, 50741);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 50563, 50580);

                            tempValue = "32";
                            DynAbs.Tracing.TraceSender.TraceBreak(1589, 50606, 50612);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 50436, 50741);

                        case "amd64":
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 50436, 50741);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 50673, 50690);

                            tempValue = "64";
                            DynAbs.Tracing.TraceSender.TraceBreak(1589, 50716, 50722);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 50436, 50741);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 50761, 50908);

                    architectureParameter = f_1589_50785_50907(f_1589_50799_50827(), architectureAttribFormat, tempValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 50312, 50923);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 50939, 50981);

                string
                sharedHostParameter = string.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 50995, 51233) || true) && (isUseSharedProcessSpecified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 50995, 51233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 51060, 51218);

                    sharedHostParameter = f_1589_51082_51217(f_1589_51096_51124(), sharedHostAttribFormat, f_1589_51171_51187().ToString());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 50995, 51233);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 51249, 51300);

                string
                runAsVirtualAccountParameter = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 51314, 51371);

                string
                runAsVirtualAccountGroupsParameter = string.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 51385, 52000) || true) && (f_1589_51389_51408())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 51385, 52000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 51442, 51621);

                    runAsVirtualAccountParameter = f_1589_51473_51620(f_1589_51487_51515(), runasVirtualAccountAttribFormat, f_1589_51571_51601(f_1589_51571_51590()));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 51700, 51985) || true) && (!f_1589_51705_51752(f_1589_51726_51751()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 51700, 51985);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 51794, 51966);

                        runAsVirtualAccountGroupsParameter = f_1589_51831_51965(f_1589_51845_51873(), runAsVirtualAccountGroupsAttribFormat, f_1589_51939_51964());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 51700, 51985);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 51385, 52000);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 52016, 52070);

                string
                allowRemoteShellAccessParameter = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 52084, 52724);

                switch (f_1589_52092_52102())
                {

                    case PSSessionConfigurationAccessMode.Disabled:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 52084, 52724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 52205, 52356);

                        allowRemoteShellAccessParameter = f_1589_52239_52355(f_1589_52253_52281(), allowRemoteShellAccessFormat, f_1589_52338_52354(false));
                        DynAbs.Tracing.TraceSender.TraceBreak(1589, 52378, 52384);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 52084, 52724);

                    case PSSessionConfigurationAccessMode.Local:
                    case PSSessionConfigurationAccessMode.Remote:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 52084, 52724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 52531, 52681);

                        allowRemoteShellAccessParameter = f_1589_52565_52680(f_1589_52579_52607(), allowRemoteShellAccessFormat, f_1589_52664_52679(true));
                        DynAbs.Tracing.TraceSender.TraceBreak(1589, 52703, 52709);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 52084, 52724);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 52740, 52801);

                StringBuilder
                sessionConfigurationData = f_1589_52781_52800()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 52817, 53355) || true) && (modulesToImport != null && (DynAbs.Tracing.TraceSender.Expression_True(1589, 52821, 52874) && f_1589_52848_52870(modulesToImport) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 52817, 53355);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 52908, 53340);

                    f_1589_52908_53339(sessionConfigurationData, f_1589_52940_53338(f_1589_52954_52982(), initParamFormat, PSSessionConfigurationData.ModulesToImportToken, f_1589_53197_53274(modulesToImport), string.Empty));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 52817, 53355);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 53371, 53825) || true) && (sessionTypeOption != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 53371, 53825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 53517, 53584);

                    string
                    privateData = f_1589_53538_53583(this.sessionTypeOption)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 53602, 53810) || true) && (!f_1589_53607_53640(privateData))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 53602, 53810);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 53682, 53791);

                        f_1589_53682_53790(sessionConfigurationData, f_1589_53714_53789(f_1589_53728_53756(), privateDataFormat, privateData));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 53602, 53810);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 53371, 53825);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 53841, 54660) || true) && (f_1589_53845_53876(sessionConfigurationData) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 53841, 54660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 53914, 54152);

                    string
                    sessionConfigData = f_1589_53941_54151(f_1589_53955_53983(), SessionConfigDataFormat, sessionConfigurationData)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 54170, 54246);

                    string
                    encodedSessionConfigData = f_1589_54204_54245(sessionConfigData)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 54264, 54645);

                    f_1589_54264_54644(initParameters, f_1589_54286_54643(f_1589_54300_54328(), initParamFormat, ConfigurationDataFromXML.SESSIONCONFIGTOKEN, encodedSessionConfigData, string.Empty));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 53841, 54660);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 54676, 54930) || true) && (transportOption == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 54676, 54930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 54737, 54786);

                    transportOption = f_1589_54755_54785();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 54676, 54930);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 54676, 54930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 54852, 54915);

                    transportOption = f_1589_54870_54893(transportOption) as PSTransportOption;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 54676, 54930);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 54946, 54985);

                f_1589_54946_54984(
                            transportOption, true);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 55121, 55294) || true) && (isUseSharedProcessSpecified && (DynAbs.Tracing.TraceSender.Expression_True(1589, 55125, 55173) && f_1589_55156_55173_M(!UseSharedProcess)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 55121, 55294);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 55207, 55279);

                    (transportOption as WSManConfigurationOption).ProcessIdleTimeoutSec = 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 55121, 55294);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 55310, 55398);

                string
                psPluginDllPath = f_1589_55335_55397()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 55414, 56280);

                string
                result = f_1589_55430_56279(f_1589_55444_55472(), pluginXmlFormat, shellName, psPluginDllPath, architectureParameter, f_1589_55657_55682(initParameters), WSManNativeApi.ResourceURIPrefix + shellName, securityParameters, sharedHostParameter, runAsVirtualAccountParameter, runAsVirtualAccountGroupsParameter, allowRemoteShellAccessParameter, f_1589_56059_56108(transportOption), f_1589_56138_56171(transportOption), (DynAbs.Tracing.TraceSender.Conditional_F1(1589, 56201, 56222) || (((f_1589_56202_56217(psVersion) < 3) && DynAbs.Tracing.TraceSender.Conditional_F2(1589, 56225, 56226)) || DynAbs.Tracing.TraceSender.Conditional_F3(1589, 56229, 56230))) ? 1 : 2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 56296, 56310);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 34851, 56321);

                System.Text.StringBuilder
                f_1589_35084_35103()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 35084, 35103);
                    return return_v;
                }


                string
                f_1589_35208_35212()
                {
                    var return_v = Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 35208, 35212);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1589_35355_35367()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 35355, 35367);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1589_35355_35372(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 35355, 35372);
                    return return_v;
                }


                string
                f_1589_35409_35413()
                {
                    var return_v = Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 35409, 35413);
                    return return_v;
                }


                string
                f_1589_35355_35439(System.Management.Automation.PathIntrinsics
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.GetUnresolvedProviderPathFromPSPath(path, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 35355, 35439);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1589_35485_35492()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 35485, 35492);
                    return return_v;
                }


                System.Management.Automation.ProviderNames
                f_1589_35485_35506(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ProviderNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 35485, 35506);
                    return return_v;
                }


                string
                f_1589_35485_35517(System.Management.Automation.ProviderNames
                this_param)
                {
                    var return_v = this_param.FileSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 35485, 35517);
                    return return_v;
                }


                bool
                f_1589_35465_35518(System.Management.Automation.ProviderInfo
                this_param, string
                providerName)
                {
                    var return_v = this_param.NameEquals(providerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 35465, 35518);
                    return return_v;
                }


                bool
                f_1589_35523_35620(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 35523, 35620);
                    return return_v;
                }


                string
                f_1589_35697_35757()
                {
                    var return_v = RemotingErrorIdStrings.InvalidPSSessionConfigurationFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 35697, 35757);
                    return return_v;
                }


                string
                f_1589_35679_35768(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 35679, 35768);
                    return return_v;
                }


                System.InvalidOperationException
                f_1589_35823_35861(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 35823, 35861);
                    return return_v;
                }


                string
                f_1589_36019_36023()
                {
                    var return_v = Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 36019, 36023);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1589_35901_36024(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 35901, 36024);
                    return return_v;
                }


                int
                f_1589_36047_36072(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 36047, 36072);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1589_36445_36457(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 36445, 36457);
                    return return_v;
                }


                System.Management.Automation.ExternalScriptInfo
                f_1589_36414_36484(System.Management.Automation.ExecutionContext
                context, string
                fileName, out string
                scriptName)
                {
                    var return_v = DISCUtils.GetScriptInfoForFile(context, fileName, out scriptName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 36414, 36484);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1589_36546_36558(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 36546, 36558);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1589_36521_36571(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.ExternalScriptInfo
                scriptInfo)
                {
                    var return_v = DISCUtils.LoadConfigFile(context, scriptInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 36521, 36571);
                    return return_v;
                }


                string
                f_1589_36713_36784()
                {
                    var return_v = RemotingErrorIdStrings.InvalidPSSessionConfigurationFileErrorProcessing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 36713, 36784);
                    return return_v;
                }


                string
                f_1589_36796_36807(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 36796, 36807);
                    return return_v;
                }


                string
                f_1589_36695_36808(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 36695, 36808);
                    return return_v;
                }


                System.InvalidOperationException
                f_1589_36863_36906(string
                message, System.Management.Automation.RuntimeException
                innerException)
                {
                    var return_v = new System.InvalidOperationException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 36863, 36906);
                    return return_v;
                }


                string
                f_1589_37064_37068()
                {
                    var return_v = Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 37064, 37068);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1589_36946_37069(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 36946, 37069);
                    return return_v;
                }


                int
                f_1589_37092_37117(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 37092, 37117);
                    return 0;
                }


                string
                f_1589_37257_37313()
                {
                    var return_v = RemotingErrorIdStrings.InvalidPSSessionConfigurationFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 37257, 37313);
                    return return_v;
                }


                string
                f_1589_37239_37324(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 37239, 37324);
                    return return_v;
                }


                System.InvalidOperationException
                f_1589_37379_37417(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 37379, 37417);
                    return return_v;
                }


                string
                f_1589_37571_37575()
                {
                    var return_v = Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 37571, 37575);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1589_37457_37576(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 37457, 37576);
                    return return_v;
                }


                int
                f_1589_37599_37624(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 37599, 37624);
                    return 0;
                }


                bool
                f_1589_37711_37760(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 37711, 37760);
                    return return_v;
                }


                object
                f_1589_37874_37911(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 37874, 37911);
                    return return_v;
                }


                object
                f_1589_38010_38047(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 38010, 38047);
                    return return_v;
                }


                string?
                f_1589_38010_38058(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 38010, 38058);
                    return return_v;
                }


                string
                f_1589_38292_38361()
                {
                    var return_v = RemotingErrorIdStrings.ErrorParsingTheKeyInPSSessionConfigurationFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 38292, 38361);
                    return return_v;
                }


                string
                f_1589_38274_38398(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 38274, 38398);
                    return return_v;
                }


                System.InvalidOperationException
                f_1589_38244_38399(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 38244, 38399);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1589_38456_38579(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 38456, 38579);
                    return return_v;
                }


                int
                f_1589_38434_38580(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 38434, 38580);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1589_38769_38868(System.FormatException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 38769, 38868);
                    return return_v;
                }


                int
                f_1589_38747_38869(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 38747, 38869);
                    return 0;
                }


                bool
                f_1589_38948_39010(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 38948, 39010);
                    return return_v;
                }


                object
                f_1589_39243_39293(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 39243, 39293);
                    return return_v;
                }


                string?
                f_1589_39243_39304(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 39243, 39304);
                    return return_v;
                }


                System.Version
                f_1589_39231_39305(string
                version)
                {
                    var return_v = new System.Version(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 39231, 39305);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1589_39481_39565(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 39481, 39565);
                    return return_v;
                }


                int
                f_1589_39459_39566(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 39459, 39566);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1589_39740_39824(System.FormatException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 39740, 39824);
                    return return_v;
                }


                int
                f_1589_39718_39825(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 39718, 39825);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1589_40001_40085(System.OverflowException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 40001, 40085);
                    return return_v;
                }


                int
                f_1589_39979_40086(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 39979, 40086);
                    return 0;
                }


                bool
                f_1589_40196_40260(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 40196, 40260);
                    return return_v;
                }


                object
                f_1589_40372_40424(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 40372, 40424);
                    return return_v;
                }


                bool
                f_1589_40337_40425(object
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<bool>(valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 40337, 40425);
                    return return_v;
                }


                bool
                f_1589_40544_40614(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 40544, 40614);
                    return return_v;
                }


                object
                f_1589_40847_40905(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 40847, 40905);
                    return return_v;
                }


                string[]
                f_1589_40801_40906(object
                hashObj)
                {
                    var return_v = DISCPowerShellConfiguration.TryGetStringArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 40801, 40906);
                    return return_v;
                }


                string
                f_1589_40697_40907(string[]
                groups)
                {
                    var return_v = PSSessionConfigurationCommandUtilities.GetRunAsVirtualAccountGroupsString(groups);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 40697, 40907);
                    return return_v;
                }


                bool
                f_1589_40959_41015(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 40959, 41015);
                    return return_v;
                }


                object
                f_1589_41080_41124(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 41080, 41124);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode
                f_1589_41475_41485()
                {
                    var return_v = AccessMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 41475, 41485);
                    return return_v;
                }


                string
                f_1589_41343_41522(System.Collections.Hashtable
                configTable, System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode
                accessMode, out System.Management.Automation.ErrorRecord
                error)
                {
                    var return_v = PSSessionConfigurationCommandUtilities.ComputeSDDLFromConfiguration(configTable, accessMode, out error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 41343, 41522);
                    return return_v;
                }


                int
                f_1589_41612_41629(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 41612, 41629);
                    return 0;
                }


                bool
                f_1589_41765_41803(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 41765, 41803);
                    return return_v;
                }


                bool
                f_1589_41833_41859(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 41833, 41859);
                    return return_v;
                }


                string
                f_1589_41943_42025(System.Collections.Hashtable
                configTable)
                {
                    var return_v = PSSessionConfigurationCommandUtilities.CreateConditionalACEFromConfig(configTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 41943, 42025);
                    return return_v;
                }


                bool
                f_1589_42057_42103(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 42057, 42103);
                    return return_v;
                }


                string
                f_1589_42168_42274(string
                sddl, string
                conditionalGroupACE)
                {
                    var return_v = PSSessionConfigurationCommandUtilities.UpdateSDDLUsersWithGroupConditional(sddl, conditionalGroupACE);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 42168, 42274);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1589_42433_42445()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 42433, 42445);
                    return return_v;
                }


                string
                f_1589_42460_42464()
                {
                    var return_v = Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 42460, 42464);
                    return return_v;
                }


                int
                f_1589_42401_42465(System.Management.Automation.SessionState
                state, System.Collections.Hashtable
                table, string
                filePath)
                {
                    DISCUtils.ValidateAbsolutePaths(state, table, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 42401, 42465);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1589_42617_42702(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 42617, 42702);
                    return return_v;
                }


                int
                f_1589_42595_42703(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 42595, 42703);
                    return 0;
                }


                string
                f_1589_42845_42849()
                {
                    var return_v = Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 42845, 42849);
                    return return_v;
                }


                int
                f_1589_42803_42850(System.Collections.Hashtable
                table, string
                filePath)
                {
                    DISCUtils.ValidateExtensions(table, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 42803, 42850);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1589_43002_43087(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 43002, 43087);
                    return return_v;
                }


                int
                f_1589_42980_43088(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 42980, 43088);
                    return 0;
                }


                string
                f_1589_43194_43224()
                {
                    var return_v = Utils.DefaultPowerShellAppBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 43194, 43224);
                    return return_v;
                }


                string
                f_1589_43171_43242(string
                path1, string
                path2)
                {
                    var return_v = System.IO.Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 43171, 43242);
                    return return_v;
                }


                bool
                f_1589_43266_43294(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 43266, 43294);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_1589_43336_43373(string
                path)
                {
                    var return_v = Directory.CreateDirectory(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 43336, 43373);
                    return return_v;
                }


                string
                f_1589_43431_43573(string
                path1, string
                path2)
                {
                    var return_v = System.IO.Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 43431, 43573);
                    return return_v;
                }


                string
                f_1589_43610_43631()
                {
                    var return_v = ProcessorArchitecture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 43610, 43631);
                    return return_v;
                }


                bool
                f_1589_43596_43675(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 43596, 43675);
                    return return_v;
                }


                string?
                f_1589_43735_43795(string
                variable)
                {
                    var return_v = Environment.GetEnvironmentVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 43735, 43795);
                    return return_v;
                }


                bool
                f_1589_43824_43892(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 43824, 43892);
                    return return_v;
                }


                bool
                f_1589_43921_43988(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 43921, 43988);
                    return return_v;
                }


                string
                f_1589_44113_44164()
                {
                    var return_v = RemotingErrorIdStrings.InvalidProcessorArchitecture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 44113, 44164);
                    return return_v;
                }


                System.InvalidOperationException
                f_1589_44083_44165(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 44083, 44165);
                    return return_v;
                }


                string
                f_1589_44293_44297()
                {
                    var return_v = Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 44293, 44297);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1589_44209_44298(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 44209, 44298);
                    return return_v;
                }


                int
                f_1589_44325_44350(Microsoft.PowerShell.Commands.RegisterPSSessionConfigurationCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 44325, 44350);
                    return 0;
                }


                string?
                f_1589_45051_45102(string
                path)
                {
                    var return_v = System.IO.Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 45051, 45102);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_1589_45277_45337(string
                path)
                {
                    var return_v = System.IO.Directory.CreateDirectory(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 45277, 45337);
                    return return_v;
                }


                int
                f_1589_45358_45412(string
                sourceFileName, string
                destFileName, bool
                overwrite)
                {
                    File.Copy(sourceFileName, destFileName, overwrite);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 45358, 45412);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1589_45469_45497()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 45469, 45497);
                    return return_v;
                }


                string
                f_1589_45661_45680()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 45661, 45680);
                    return return_v;
                }


                string
                f_1589_45455_45681(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 45455, 45681);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_45433_45682(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 45433, 45682);
                    return return_v;
                }


                bool
                f_1589_45782_45825(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 45782, 45825);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_45903_45931()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 45903, 45931);
                    return return_v;
                }


                string
                f_1589_46120_46139()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 46120, 46139);
                    return return_v;
                }


                string
                f_1589_45889_46140(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 45889, 46140);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_45867_46141(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 45867, 46141);
                    return return_v;
                }


                bool
                f_1589_46186_46220(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 46186, 46220);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_46298_46326()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 46298, 46326);
                    return return_v;
                }


                string
                f_1589_46499_46518()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 46499, 46518);
                    return return_v;
                }


                string
                f_1589_46284_46519(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 46284, 46519);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_46262_46520(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 46262, 46520);
                    return return_v;
                }


                bool
                f_1589_46576_46613(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 46576, 46613);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_46683_46711()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 46683, 46711);
                    return return_v;
                }


                string
                f_1589_46870_46889()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 46870, 46889);
                    return return_v;
                }


                string
                f_1589_46669_46890(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 46669, 46890);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_46647_46891(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 46647, 46891);
                    return return_v;
                }


                bool
                f_1589_46928_46969(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 46928, 46969);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_47039_47067()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 47039, 47067);
                    return return_v;
                }


                string
                f_1589_47236_47255()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 47236, 47255);
                    return return_v;
                }


                string
                f_1589_47025_47256(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 47025, 47256);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_47003_47257(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 47003, 47257);
                    return return_v;
                }


                bool
                f_1589_47293_47318(double?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 47293, 47318);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_47388_47416()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 47388, 47416);
                    return return_v;
                }


                double
                f_1589_47544_47566(double?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 47544, 47566);
                    return return_v;
                }


                string
                f_1589_47589_47608()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 47589, 47608);
                    return return_v;
                }


                string
                f_1589_47374_47609(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, double
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 47374, 47609);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_47352_47610(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 47352, 47610);
                    return return_v;
                }


                bool
                f_1589_47646_47670(double?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 47646, 47670);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_47740_47768()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 47740, 47768);
                    return return_v;
                }


                double
                f_1589_47896_47917(double?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 47896, 47917);
                    return return_v;
                }


                string
                f_1589_47940_47959()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 47940, 47959);
                    return return_v;
                }


                string
                f_1589_47726_47960(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, double
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 47726, 47960);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_47704_47961(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 47704, 47961);
                    return return_v;
                }


                bool
                f_1589_47997_48020(System.Threading.ApartmentState?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 47997, 48020);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_48090_48118()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 48090, 48118);
                    return return_v;
                }


                System.Threading.ApartmentState
                f_1589_48246_48266(System.Threading.ApartmentState?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 48246, 48266);
                    return return_v;
                }


                string
                f_1589_48289_48308()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 48289, 48308);
                    return return_v;
                }


                string
                f_1589_48076_48309(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, System.Threading.ApartmentState
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 48076, 48309);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_48054_48310(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 48054, 48310);
                    return return_v;
                }


                bool
                f_1589_48346_48368(System.Management.Automation.Runspaces.PSThreadOptions?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 48346, 48368);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_48438_48466()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 48438, 48466);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSThreadOptions
                f_1589_48593_48612(System.Management.Automation.Runspaces.PSThreadOptions?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 48593, 48612);
                    return return_v;
                }


                string
                f_1589_48635_48654()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 48635, 48654);
                    return return_v;
                }


                string
                f_1589_48424_48655(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, System.Management.Automation.Runspaces.PSThreadOptions
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 48424, 48655);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_48402_48656(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 48402, 48656);
                    return return_v;
                }


                System.Version
                f_1589_48811_48834()
                {
                    var return_v = PSVersionInfo.PSVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 48811, 48834);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_48957_48985()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 48957, 48985);
                    return return_v;
                }


                System.Version
                f_1589_49108_49192(System.Version
                psVersion)
                {
                    var return_v = PSSessionConfigurationCommandUtilities.ConstructVersionFormatForConfigXml(psVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 49108, 49192);
                    return return_v;
                }


                string
                f_1589_49215_49234()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 49215, 49234);
                    return return_v;
                }


                string
                f_1589_48943_49235(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, System.Version
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 48943, 49235);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_48921_49236(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 48921, 49236);
                    return return_v;
                }


                System.Version
                f_1589_49330_49401(System.Version
                psVersion)
                {
                    var return_v = PSSessionConfigurationCommandUtilities.CalculateMaxPSVersion(psVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 49330, 49401);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_49524_49552()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 49524, 49552);
                    return return_v;
                }


                System.Version
                f_1589_49690_49777(System.Version
                psVersion)
                {
                    var return_v = PSSessionConfigurationCommandUtilities.ConstructVersionFormatForConfigXml(psVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 49690, 49777);
                    return return_v;
                }


                string
                f_1589_49804_49823()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 49804, 49823);
                    return return_v;
                }


                string
                f_1589_49510_49824(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, System.Version
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 49510, 49824);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_49488_49825(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 49488, 49825);
                    return return_v;
                }


                bool
                f_1589_49936_49962(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 49936, 49962);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_50031_50059()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 50031, 50059);
                    return return_v;
                }


                string?
                f_1589_50193_50221(string
                str)
                {
                    var return_v = SecurityElement.Escape(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 50193, 50221);
                    return return_v;
                }


                string
                f_1589_50017_50222(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 50017, 50222);
                    return return_v;
                }


                string
                f_1589_50338_50359()
                {
                    var return_v = ProcessorArchitecture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 50338, 50359);
                    return return_v;
                }


                bool
                f_1589_50317_50360(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 50317, 50360);
                    return return_v;
                }


                string
                f_1589_50444_50465()
                {
                    var return_v = ProcessorArchitecture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 50444, 50465);
                    return return_v;
                }


                string
                f_1589_50444_50484(string
                this_param)
                {
                    var return_v = this_param.ToLowerInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 50444, 50484);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_50799_50827()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 50799, 50827);
                    return return_v;
                }


                string
                f_1589_50785_50907(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 50785, 50907);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_51096_51124()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 51096, 51124);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1589_51171_51187()
                {
                    var return_v = UseSharedProcess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 51171, 51187);
                    return return_v;
                }


                string
                f_1589_51082_51217(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 51082, 51217);
                    return return_v;
                }


                bool
                f_1589_51389_51408()
                {
                    var return_v = RunAsVirtualAccount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 51389, 51408);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_51487_51515()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 51487, 51515);
                    return return_v;
                }


                bool
                f_1589_51571_51590()
                {
                    var return_v = RunAsVirtualAccount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 51571, 51590);
                    return return_v;
                }


                string
                f_1589_51571_51601(bool
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 51571, 51601);
                    return return_v;
                }


                string
                f_1589_51473_51620(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 51473, 51620);
                    return return_v;
                }


                string
                f_1589_51726_51751()
                {
                    var return_v = RunAsVirtualAccountGroups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 51726, 51751);
                    return return_v;
                }


                bool
                f_1589_51705_51752(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 51705, 51752);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_51845_51873()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 51845, 51873);
                    return return_v;
                }


                string
                f_1589_51939_51964()
                {
                    var return_v = RunAsVirtualAccountGroups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 51939, 51964);
                    return return_v;
                }


                string
                f_1589_51831_51965(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 51831, 51965);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode
                f_1589_52092_52102()
                {
                    var return_v = AccessMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 52092, 52102);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_52253_52281()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 52253, 52281);
                    return return_v;
                }


                string
                f_1589_52338_52354(bool
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 52338, 52354);
                    return return_v;
                }


                string
                f_1589_52239_52355(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 52239, 52355);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_52579_52607()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 52579, 52607);
                    return return_v;
                }


                string
                f_1589_52664_52679(bool
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 52664, 52679);
                    return return_v;
                }


                string
                f_1589_52565_52680(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 52565, 52680);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_52781_52800()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 52781, 52800);
                    return return_v;
                }


                int
                f_1589_52848_52870(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 52848, 52870);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_52954_52982()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 52954, 52982);
                    return return_v;
                }


                string
                f_1589_53197_53274(object[]
                modulePath)
                {
                    var return_v = PSSessionConfigurationCommandUtilities.GetModulePathAsString(modulePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 53197, 53274);
                    return return_v;
                }


                string
                f_1589_52940_53338(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 52940, 53338);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_52908_53339(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 52908, 53339);
                    return return_v;
                }


                string
                f_1589_53538_53583(System.Management.Automation.PSSessionTypeOption
                this_param)
                {
                    var return_v = this_param.ConstructPrivateData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 53538, 53583);
                    return return_v;
                }


                bool
                f_1589_53607_53640(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 53607, 53640);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_53728_53756()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 53728, 53756);
                    return return_v;
                }


                string
                f_1589_53714_53789(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 53714, 53789);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_53682_53790(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 53682, 53790);
                    return return_v;
                }


                int
                f_1589_53845_53876(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 53845, 53876);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_53955_53983()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 53955, 53983);
                    return return_v;
                }


                string
                f_1589_53941_54151(System.Globalization.CultureInfo
                provider, string
                format, System.Text.StringBuilder
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 53941, 54151);
                    return return_v;
                }


                string?
                f_1589_54204_54245(string
                str)
                {
                    var return_v = SecurityElement.Escape(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 54204, 54245);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_54300_54328()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 54300, 54328);
                    return return_v;
                }


                string
                f_1589_54286_54643(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 54286, 54643);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_54264_54644(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 54264, 54644);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.WSManConfigurationOption
                f_1589_54755_54785()
                {
                    var return_v = new Microsoft.PowerShell.Commands.WSManConfigurationOption();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 54755, 54785);
                    return return_v;
                }


                object
                f_1589_54870_54893(System.Management.Automation.PSTransportOption
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 54870, 54893);
                    return return_v;
                }


                int
                f_1589_54946_54984(System.Management.Automation.PSTransportOption
                this_param, bool
                keepAssigned)
                {
                    this_param.LoadFromDefaults(keepAssigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 54946, 54984);
                    return 0;
                }


                bool
                f_1589_55156_55173_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 55156, 55173);
                    return return_v;
                }


                string
                f_1589_55335_55397()
                {
                    var return_v = PSSessionConfigurationCommandUtilities.GetWinrmPluginDllPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 55335, 55397);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_55444_55472()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 55444, 55472);
                    return return_v;
                }


                string
                f_1589_55657_55682(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 55657, 55682);
                    return return_v;
                }


                string
                f_1589_56059_56108(System.Management.Automation.PSTransportOption
                this_param)
                {
                    var return_v = this_param.ConstructOptionsAsXmlAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 56059, 56108);
                    return return_v;
                }


                string
                f_1589_56138_56171(System.Management.Automation.PSTransportOption
                this_param)
                {
                    var return_v = this_param.ConstructQuotas();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 56138, 56171);
                    return return_v;
                }


                int
                f_1589_56202_56217(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 56202, 56217);
                    return return_v;
                }


                string
                f_1589_55430_56279(System.Globalization.CultureInfo
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 55430, 56279);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 34851, 56321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 34851, 56321);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public RegisterPSSessionConfigurationCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1589, 1032, 56350);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 14165, 14177);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 14203, 14219);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 14336, 14352);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 14701, 14869);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1589, 1032, 56350);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 1032, 56350);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1589, 1032, 56350);

        static string
        f_1589_15025_15039()
        {
            var return_v = GetLocalSddl();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 15025, 15039);
            return return_v;
        }


        static System.Globalization.CultureInfo
        f_1589_15255_15283()
        {
            var return_v = CultureInfo.InvariantCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 15255, 15283);
            return return_v;
        }


        static string
        f_1589_15241_15429(System.Globalization.CultureInfo
        provider, string
        format, params object?[]
        args)
        {
            var return_v = string.Format((System.IFormatProvider)provider, format, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 15241, 15429);
            return return_v;
        }


        static System.Management.Automation.ScriptBlock
        f_1589_15462_15499(string
        script)
        {
            var return_v = ScriptBlock.Create(script);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 15462, 15499);
            return return_v;
        }

    }
    internal static class PSSessionConfigurationCommandUtilities
    {
        internal const string
        restartWSManFormat = "restart-service winrm -force -confirm:$false"
        ;

        internal const string
        PSCustomShellTypeName = "Microsoft.PowerShell.Commands.PSSessionConfigurationCommands#PSSessionConfiguration"
        ;

        internal static void RestartWinRMService(PSCmdlet cmdlet, bool isErrorReported, bool force, bool noServiceRestart)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 57586, 59089);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 57816, 59078) || true) && (!(isErrorReported || (DynAbs.Tracing.TraceSender.Expression_False(1589, 57822, 57857) || noServiceRestart)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 57816, 59078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 57965, 58044);

                    string
                    restartServiceAction = f_1589_57995_58043()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 58062, 58169);

                    string
                    restartServiceTarget = f_1589_58092_58168(f_1589_58110_58158(), "WinRM")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 58189, 59063) || true) && (force || (DynAbs.Tracing.TraceSender.Expression_False(1589, 58193, 58266) || f_1589_58202_58266(cmdlet, restartServiceTarget, restartServiceAction)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 58189, 59063);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 58308, 58399);

                        f_1589_58308_58398(cmdlet, f_1589_58328_58397(f_1589_58346_58396()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 58423, 58514);

                        ScriptBlock
                        restartServiceScript = f_1589_58458_58513(f_1589_58458_58478(cmdlet), restartWSManFormat)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 58536, 58575);

                        var
                        emptyArray = f_1589_58553_58574()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 58597, 59044);

                        f_1589_58597_59043(restartServiceScript, contextCmdlet: cmdlet, useLocalScope: true, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: f_1589_58876_58896(), input: emptyArray, scriptThis: f_1589_58979_58999(), args: emptyArray);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 58189, 59063);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 57816, 59078);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 57586, 59089);

                string
                f_1589_57995_58043()
                {
                    var return_v = RemotingErrorIdStrings.RestartWSManServiceAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 57995, 58043);
                    return return_v;
                }


                string
                f_1589_58110_58158()
                {
                    var return_v = RemotingErrorIdStrings.RestartWSManServiceTarget;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 58110, 58158);
                    return return_v;
                }


                string
                f_1589_58092_58168(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 58092, 58168);
                    return return_v;
                }


                bool
                f_1589_58202_58266(System.Management.Automation.PSCmdlet
                this_param, string
                target, string
                action)
                {
                    var return_v = this_param.ShouldProcess(target, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 58202, 58266);
                    return return_v;
                }


                string
                f_1589_58346_58396()
                {
                    var return_v = RemotingErrorIdStrings.RestartWSManServiceMessageV;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 58346, 58396);
                    return return_v;
                }


                string
                f_1589_58328_58397(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 58328, 58397);
                    return return_v;
                }


                int
                f_1589_58308_58398(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 58308, 58398);
                    return 0;
                }


                System.Management.Automation.CommandInvocationIntrinsics
                f_1589_58458_58478(System.Management.Automation.PSCmdlet
                this_param)
                {
                    var return_v = this_param.InvokeCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 58458, 58478);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1589_58458_58513(System.Management.Automation.CommandInvocationIntrinsics
                this_param, string
                scriptText)
                {
                    var return_v = this_param.NewScriptBlock(scriptText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 58458, 58513);
                    return return_v;
                }


                object[]
                f_1589_58553_58574()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 58553, 58574);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_58876_58896()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 58876, 58896);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_58979_58999()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 58979, 58999);
                    return return_v;
                }


                int
                f_1589_58597_59043(System.Management.Automation.ScriptBlock
                this_param, System.Management.Automation.PSCmdlet
                contextCmdlet, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, object[]
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    this_param.InvokeUsingCmdlet(contextCmdlet: (System.Management.Automation.Cmdlet)contextCmdlet, useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 58597, 59043);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 57586, 59089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 57586, 59089);
            }
        }

        internal static void MoveWinRmToIsolatedServiceHost(bool forVirtualAccount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 59101, 60208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 59201, 59253);

                string
                moveScript = "sc.exe config winrm type= own"
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 59269, 59960) || true) && (forVirtualAccount)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 59269, 59960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 59324, 59945);

                    moveScript += @"
                    $requiredPrivileges = Get-ItemPropertyValue -Path HKLM:\SYSTEM\CurrentControlSet\Services\winrm -Name RequiredPrivileges
                    if($requiredPrivileges -notcontains 'SeTcbPrivilege')
                    {
                        $requiredPrivileges += @('SeTcbPrivilege')
                    }

                    Set-ItemProperty -Path HKLM:\SYSTEM\CurrentControlSet\Services\winrm -Name RequiredPrivileges -Value $requiredPrivileges
                    Set-ItemProperty -Path HKLM:\SYSTEM\CurrentControlSet\Services\winrm -Name ObjectName -Value 'LocalSystem'";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 59269, 59960);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 59976, 60197);
                using (System.Management.Automation.PowerShell
                invoker = f_1589_60033_60109(RunspaceMode.CurrentRunspace)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 60143, 60182);

                    f_1589_60143_60181(f_1589_60143_60172(invoker, moveScript));
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1589, 59976, 60197);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 59101, 60208);

                System.Management.Automation.PowerShell
                f_1589_60033_60109(System.Management.Automation.RunspaceMode
                runspace)
                {
                    var return_v = System.Management.Automation.PowerShell.Create(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 60033, 60109);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1589_60143_60172(System.Management.Automation.PowerShell
                this_param, string
                script)
                {
                    var return_v = this_param.AddScript(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 60143, 60172);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1589_60143_60181(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 60143, 60181);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 59101, 60208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 59101, 60208);
            }
        }

        internal static void CollectShouldProcessParameters(PSCmdlet cmdlet, out bool whatIf, out bool confirm)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 60468, 61219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 60684, 60699);

                whatIf = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 60766, 60782);

                confirm = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 60796, 60870);

                MshCommandRuntime
                cmdRuntime = f_1589_60827_60848(cmdlet) as MshCommandRuntime
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 60884, 61208) || true) && (cmdRuntime != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 60884, 61208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 60940, 60967);

                    whatIf = f_1589_60949_60966(cmdRuntime);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 61072, 61193) || true) && (f_1589_61076_61103(cmdRuntime))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 61072, 61193);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 61145, 61174);

                        confirm = f_1589_61155_61173(cmdRuntime);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 61072, 61193);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 60884, 61208);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 60468, 61219);

                System.Management.Automation.ICommandRuntime
                f_1589_60827_60848(System.Management.Automation.PSCmdlet
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 60827, 60848);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1589_60949_60966(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.WhatIf;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 60949, 60966);
                    return return_v;
                }


                bool
                f_1589_61076_61103(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.IsConfirmFlagSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 61076, 61103);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1589_61155_61173(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.Confirm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 61155, 61173);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 60468, 61219);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 60468, 61219);
            }
        }

        internal static void ThrowIfNotAdministrator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 61538, 62158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 61609, 61724);

                System.Security.Principal.WindowsIdentity
                currentIdentity = f_1589_61669_61723()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 61738, 61857);

                System.Security.Principal.WindowsPrincipal
                principal = f_1589_61793_61856(currentIdentity)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 61871, 62147) || true) && (!f_1589_61876_61954(principal, System.Security.Principal.WindowsBuiltInRole.Administrator))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 61871, 62147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 61988, 62069);

                    string
                    message = f_1589_62005_62068(f_1589_62023_62067())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 62087, 62132);

                    throw f_1589_62093_62131(message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 61871, 62147);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 61538, 62158);

                System.Security.Principal.WindowsIdentity
                f_1589_61669_61723()
                {
                    var return_v = System.Security.Principal.WindowsIdentity.GetCurrent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 61669, 61723);
                    return return_v;
                }


                System.Security.Principal.WindowsPrincipal
                f_1589_61793_61856(System.Security.Principal.WindowsIdentity
                ntIdentity)
                {
                    var return_v = new System.Security.Principal.WindowsPrincipal(ntIdentity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 61793, 61856);
                    return return_v;
                }


                bool
                f_1589_61876_61954(System.Security.Principal.WindowsPrincipal
                this_param, System.Security.Principal.WindowsBuiltInRole
                role)
                {
                    var return_v = this_param.IsInRole(role);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 61876, 61954);
                    return return_v;
                }


                string
                f_1589_62023_62067()
                {
                    var return_v = RemotingErrorIdStrings.EDcsRequiresElevation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 62023, 62067);
                    return return_v;
                }


                string
                f_1589_62005_62068(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 62005, 62068);
                    return return_v;
                }


                System.InvalidOperationException
                f_1589_62093_62131(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 62093, 62131);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 61538, 62158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 61538, 62158);
            }
        }

        internal static PSCredential CreateGMSAAccountCredentials(string gmsaAccount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 62620, 63509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 62722, 62808);

                f_1589_62722_62807(!f_1589_62734_62767(gmsaAccount), "Should not be null or empty string.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 62897, 62955);

                var
                parts = f_1589_62909_62954(gmsaAccount, Utils.Separators.Backslash)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 62969, 63240) || true) && ((f_1589_62974_62986(parts) != 2) || (DynAbs.Tracing.TraceSender.Expression_False(1589, 62973, 63045) || (f_1589_63014_63044(parts[0]))) || (DynAbs.Tracing.TraceSender.Expression_False(1589, 62973, 63098) || (f_1589_63067_63097(parts[1]))
                ))
                               )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 62969, 63240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 63149, 63225);

                    throw f_1589_63155_63224(f_1589_63185_63223());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 62969, 63240);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 63347, 63383);

                string
                userName = gmsaAccount + "$"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 63397, 63440);

                SecureString
                password = f_1589_63421_63439()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 63454, 63498);

                return f_1589_63461_63497(userName, password);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 62620, 63509);

                bool
                f_1589_62734_62767(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 62734, 62767);
                    return return_v;
                }


                int
                f_1589_62722_62807(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 62722, 62807);
                    return 0;
                }


                string[]
                f_1589_62909_62954(string
                this_param, params char[]
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 62909, 62954);
                    return return_v;
                }


                int
                f_1589_62974_62986(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 62974, 62986);
                    return return_v;
                }


                bool
                f_1589_63014_63044(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 63014, 63044);
                    return return_v;
                }


                bool
                f_1589_63067_63097(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 63067, 63097);
                    return return_v;
                }


                string
                f_1589_63185_63223()
                {
                    var return_v = RemotingErrorIdStrings.InvalidGMSAName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 63185, 63223);
                    return return_v;
                }


                System.InvalidOperationException
                f_1589_63155_63224(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 63155, 63224);
                    return return_v;
                }


                System.Security.SecureString
                f_1589_63421_63439()
                {
                    var return_v = new System.Security.SecureString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 63421, 63439);
                    return return_v;
                }


                System.Management.Automation.PSCredential
                f_1589_63461_63497(string
                userName, System.Security.SecureString
                password)
                {
                    var return_v = new System.Management.Automation.PSCredential(userName, password);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 63461, 63497);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 62620, 63509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 62620, 63509);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Version CalculateMaxPSVersion(Version psVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 63689, 63994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 63778, 63806);

                Version
                maxPSVersion = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 63820, 63947) || true) && (psVersion != null && (DynAbs.Tracing.TraceSender.Expression_True(1589, 63824, 63865) && f_1589_63845_63860(psVersion) == 2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 63820, 63947);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 63899, 63932);

                    maxPSVersion = f_1589_63914_63931(2, 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 63820, 63947);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 63963, 63983);

                return maxPSVersion;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 63689, 63994);

                int
                f_1589_63845_63860(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 63845, 63860);
                    return return_v;
                }


                System.Version
                f_1589_63914_63931(int
                major, int
                minor)
                {
                    var return_v = new System.Version(major, minor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 63914, 63931);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 63689, 63994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 63689, 63994);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetModulePathAsString(object[] modulePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 64150, 65388);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 64240, 65341) || true) && (modulePath != null && (DynAbs.Tracing.TraceSender.Expression_True(1589, 64244, 64287) && f_1589_64266_64283(modulePath) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 64240, 65341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 64321, 64360);

                    StringBuilder
                    sb = f_1589_64340_64359()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 64378, 65239);
                        foreach (object s in f_1589_64399_64409_I(modulePath))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 64378, 65239);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 64451, 64476);

                            var
                            module = s as string
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 64498, 65220) || true) && (module != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 64498, 65220);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 64566, 64579);

                                f_1589_64566_64578(sb, s);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 64605, 64620);

                                f_1589_64605_64619(sb, ',');
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 64498, 65220);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 64498, 65220);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 64718, 64760);

                                var
                                moduleSpec = s as ModuleSpecification
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 64786, 65197) || true) && (moduleSpec != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 64786, 65197);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 65044, 65125);

                                    f_1589_65044_65124(                            // Double escaping on ModuleSpecification string is required to treat it as a single value along with module names/paths in SessionConfigurationData
                                                                sb, f_1589_65054_65123(f_1589_65077_65122(f_1589_65100_65121(moduleSpec))));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 65155, 65170);

                                    f_1589_65155_65169(sb, ',');
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 64786, 65197);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 64498, 65220);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 64378, 65239);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1589, 1, 862);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1589, 1, 862);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 65259, 65287);

                    f_1589_65259_65286(
                                    sb, f_1589_65269_65278(sb) - 1, 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 65305, 65326);

                    return f_1589_65312_65325(sb);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 64240, 65341);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 65357, 65377);

                return string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 64150, 65388);

                int
                f_1589_64266_64283(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 64266, 64283);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_64340_64359()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 64340, 64359);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_64566_64578(System.Text.StringBuilder
                this_param, object
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 64566, 64578);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_64605_64619(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 64605, 64619);
                    return return_v;
                }


                string
                f_1589_65100_65121(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 65100, 65121);
                    return return_v;
                }


                string?
                f_1589_65077_65122(string
                str)
                {
                    var return_v = SecurityElement.Escape(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 65077, 65122);
                    return return_v;
                }


                string?
                f_1589_65054_65123(string
                str)
                {
                    var return_v = SecurityElement.Escape(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 65054, 65123);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_65044_65124(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 65044, 65124);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_65155_65169(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 65155, 65169);
                    return return_v;
                }


                object[]
                f_1589_64399_64409_I(object[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 64399, 64409);
                    return return_v;
                }


                int
                f_1589_65269_65278(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 65269, 65278);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_65259_65286(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 65259, 65286);
                    return return_v;
                }


                string
                f_1589_65312_65325(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 65312, 65325);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 64150, 65388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 64150, 65388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Version ConstructVersionFormatForConfigXml(Version psVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 65609, 65913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 65711, 65733);

                Version
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 65747, 65872) || true) && (psVersion != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 65747, 65872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 65802, 65857);

                    result = f_1589_65811_65856(f_1589_65823_65838(psVersion), f_1589_65840_65855(psVersion));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 65747, 65872);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 65888, 65902);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 65609, 65913);

                int
                f_1589_65823_65838(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 65823, 65838);
                    return return_v;
                }


                int
                f_1589_65840_65855(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 65840, 65855);
                    return return_v;
                }


                System.Version
                f_1589_65811_65856(int
                major, int
                minor)
                {
                    var return_v = new System.Version(major, minor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 65811, 65856);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 65609, 65913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 65609, 65913);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetRunAsVirtualAccountGroupsString(string[] groups)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 66144, 66346);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 66243, 66287) || true) && (groups == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 66243, 66287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 66265, 66285);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 66243, 66287);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 66303, 66335);

                return f_1589_66310_66334(";", groups);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 66144, 66346);

                string
                f_1589_66310_66334(string
                separator, params string[]
                value)
                {
                    var return_v = string.Join(separator, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 66310, 66334);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 66144, 66346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 66144, 66346);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetWinrmPluginShellName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 66528, 66748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 66674, 66737);

                return f_1589_66681_66736("PowerShell.", f_1589_66710_66735());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 66528, 66748);

                string
                f_1589_66710_66735()
                {
                    var return_v = PSVersionInfo.GitCommitId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 66710, 66735);
                    return return_v;
                }


                string
                f_1589_66681_66736(string
                str0, string
                str1)
                {
                    var return_v = string.Concat(str0, str1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 66681, 66736);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 66528, 66748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 66528, 66748);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetWinrmPluginDllPath()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 66933, 67305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 67083, 67195);

                string
                pluginDllDirectory = f_1589_67111_67194("%windir%\\system32\\PowerShell", f_1589_67168_67193())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 67209, 67294);

                return f_1589_67216_67293(pluginDllDirectory, RemotingConstants.PSPluginDLLName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 66933, 67305);

                string
                f_1589_67168_67193()
                {
                    var return_v = PSVersionInfo.GitCommitId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 67168, 67193);
                    return return_v;
                }


                string
                f_1589_67111_67194(string
                path1, string
                path2)
                {
                    var return_v = System.IO.Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 67111, 67194);
                    return return_v;
                }


                string
                f_1589_67216_67293(string
                path1, string
                path2)
                {
                    var return_v = System.IO.Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 67216, 67293);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 66933, 67305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 66933, 67305);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string ComputeSDDLFromConfiguration(
                    Hashtable configTable,
                    PSSessionConfigurationAccessMode accessMode,
                    out ErrorRecord error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 67875, 71316);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 68082, 68161);

                f_1589_68082_68160(configTable != null, "configTable input parameter cannot be null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 68177, 68204);

                string
                sddl = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 68218, 68231);

                error = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 68279, 71277) || true) && (f_1589_68283_68343(configTable, ConfigFileConstants.RoleDefinitions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 68279, 71277);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 68440, 68811) || true) && (accessMode == PSSessionConfigurationAccessMode.Local)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 68440, 68811);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 68538, 68594);

                        sddl = f_1589_68545_68593();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 68440, 68811);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 68440, 68811);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 68636, 68811) || true) && (accessMode == PSSessionConfigurationAccessMode.Remote)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 68636, 68811);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 68735, 68792);

                            sddl = f_1589_68742_68791();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 68636, 68811);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 68440, 68811);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 68831, 68918);

                    CommonSecurityDescriptor
                    descriptor = f_1589_68869_68917(false, false, sddl)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 69050, 69121);

                    List<SecurityIdentifier>
                    sidsToRemove = f_1589_69090_69120()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 69139, 69294);
                        foreach (CommonAce ace in f_1589_69165_69192_I(f_1589_69165_69192(descriptor)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 69139, 69294);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 69234, 69275);

                            f_1589_69234_69274(sidsToRemove, f_1589_69251_69273(ace));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 69139, 69294);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1589, 1, 156);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1589, 1, 156);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 69314, 69458);
                        foreach (var sidToRemove in f_1589_69342_69354_I(sidsToRemove))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 69314, 69458);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 69396, 69439);

                            f_1589_69396_69438(descriptor, sidToRemove);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 69314, 69458);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1589, 1, 145);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1589, 1, 145);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 69478, 69566);

                    Hashtable
                    roleNamesHash = f_1589_69504_69552(configTable, ConfigFileConstants.RoleDefinitions) as Hashtable
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 69584, 70751);
                        foreach (object roleName in f_1589_69612_69630_I(f_1589_69612_69630(roleNamesHash)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 69584, 70751);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 69672, 69715);

                            string
                            roleNameValue = f_1589_69695_69714(roleName)
                            ;

                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 69791, 69842);

                                NTAccount
                                ntAccount = f_1589_69813_69841(roleNameValue)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 69868, 69968);

                                SecurityIdentifier
                                accountSid = (SecurityIdentifier)f_1589_69920_69967(ntAccount, typeof(SecurityIdentifier))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 70081, 70213);

                                f_1589_70081_70212(f_1589_70081_70108(descriptor), AccessControlType.Allow, accountSid, 268435456, InheritanceFlags.None, PropagationFlags.None);
                            }
                            catch (IdentityNotMappedException e)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 70258, 70732);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 70343, 70467);

                                string
                                message = f_1589_70360_70466(f_1589_70378_70439(), roleNameValue, f_1589_70456_70465(e))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 70493, 70567);

                                InvalidOperationException
                                ioe = f_1589_70525_70566(message, e)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 70593, 70709);

                                error = f_1589_70601_70708(ioe, "CouldNotResolveRoleDefinitionPrincipal", ErrorCategory.ObjectNotFound, roleNameValue);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 70258, 70732);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 69584, 70751);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1589, 1, 1168);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1589, 1, 1168);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 70771, 71262) || true) && (f_1589_70775_70808(f_1589_70775_70802(descriptor)) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 70771, 71262);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 70854, 70911);

                        sddl = f_1589_70861_70910(descriptor, AccessControlSections.All);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 70974, 71047);

                        string
                        conditionalGroupACE = f_1589_71003_71046(configTable)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 71069, 71243) || true) && (conditionalGroupACE != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 71069, 71243);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 71150, 71220);

                            sddl = f_1589_71157_71219(sddl, conditionalGroupACE);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 71069, 71243);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 70771, 71262);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 68279, 71277);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 71293, 71305);

                return sddl;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 67875, 71316);

                int
                f_1589_68082_68160(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 68082, 68160);
                    return 0;
                }


                bool
                f_1589_68283_68343(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 68283, 68343);
                    return return_v;
                }


                string
                f_1589_68545_68593()
                {
                    var return_v = PSSessionConfigurationCommandBase.GetLocalSddl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 68545, 68593);
                    return return_v;
                }


                string
                f_1589_68742_68791()
                {
                    var return_v = PSSessionConfigurationCommandBase.GetRemoteSddl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 68742, 68791);
                    return return_v;
                }


                System.Security.AccessControl.CommonSecurityDescriptor
                f_1589_68869_68917(bool
                isContainer, bool
                isDS, string
                sddlForm)
                {
                    var return_v = new System.Security.AccessControl.CommonSecurityDescriptor(isContainer, isDS, sddlForm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 68869, 68917);
                    return return_v;
                }


                System.Collections.Generic.List<System.Security.Principal.SecurityIdentifier>
                f_1589_69090_69120()
                {
                    var return_v = new System.Collections.Generic.List<System.Security.Principal.SecurityIdentifier>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 69090, 69120);
                    return return_v;
                }


                System.Security.AccessControl.DiscretionaryAcl
                f_1589_69165_69192(System.Security.AccessControl.CommonSecurityDescriptor
                this_param)
                {
                    var return_v = this_param.DiscretionaryAcl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 69165, 69192);
                    return return_v;
                }


                System.Security.Principal.SecurityIdentifier
                f_1589_69251_69273(System.Security.AccessControl.CommonAce
                this_param)
                {
                    var return_v = this_param.SecurityIdentifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 69251, 69273);
                    return return_v;
                }


                int
                f_1589_69234_69274(System.Collections.Generic.List<System.Security.Principal.SecurityIdentifier>
                this_param, System.Security.Principal.SecurityIdentifier
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 69234, 69274);
                    return 0;
                }


                System.Security.AccessControl.DiscretionaryAcl
                f_1589_69165_69192_I(System.Security.AccessControl.DiscretionaryAcl
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 69165, 69192);
                    return return_v;
                }


                int
                f_1589_69396_69438(System.Security.AccessControl.CommonSecurityDescriptor
                this_param, System.Security.Principal.SecurityIdentifier
                sid)
                {
                    this_param.PurgeAccessControl(sid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 69396, 69438);
                    return 0;
                }


                System.Collections.Generic.List<System.Security.Principal.SecurityIdentifier>
                f_1589_69342_69354_I(System.Collections.Generic.List<System.Security.Principal.SecurityIdentifier>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 69342, 69354);
                    return return_v;
                }


                object
                f_1589_69504_69552(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 69504, 69552);
                    return return_v;
                }


                System.Collections.ICollection
                f_1589_69612_69630(System.Collections.Hashtable
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 69612, 69630);
                    return return_v;
                }


                string?
                f_1589_69695_69714(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 69695, 69714);
                    return return_v;
                }


                System.Security.Principal.NTAccount
                f_1589_69813_69841(string
                name)
                {
                    var return_v = new System.Security.Principal.NTAccount(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 69813, 69841);
                    return return_v;
                }


                System.Security.Principal.IdentityReference
                f_1589_69920_69967(System.Security.Principal.NTAccount
                this_param, System.Type
                targetType)
                {
                    var return_v = this_param.Translate(targetType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 69920, 69967);
                    return return_v;
                }


                System.Security.AccessControl.DiscretionaryAcl
                f_1589_70081_70108(System.Security.AccessControl.CommonSecurityDescriptor
                this_param)
                {
                    var return_v = this_param.DiscretionaryAcl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 70081, 70108);
                    return return_v;
                }


                int
                f_1589_70081_70212(System.Security.AccessControl.DiscretionaryAcl
                this_param, System.Security.AccessControl.AccessControlType
                accessType, System.Security.Principal.SecurityIdentifier
                sid, int
                accessMask, System.Security.AccessControl.InheritanceFlags
                inheritanceFlags, System.Security.AccessControl.PropagationFlags
                propagationFlags)
                {
                    this_param.AddAccess(accessType, sid, accessMask, inheritanceFlags, propagationFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 70081, 70212);
                    return 0;
                }


                string
                f_1589_70378_70439()
                {
                    var return_v = RemotingErrorIdStrings.CouldNotResolveRoleDefinitionPrincipal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 70378, 70439);
                    return return_v;
                }


                string
                f_1589_70456_70465(System.Security.Principal.IdentityNotMappedException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 70456, 70465);
                    return return_v;
                }


                string
                f_1589_70360_70466(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 70360, 70466);
                    return return_v;
                }


                System.InvalidOperationException
                f_1589_70525_70566(string
                message, System.Security.Principal.IdentityNotMappedException
                innerException)
                {
                    var return_v = new System.InvalidOperationException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 70525, 70566);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1589_70601_70708(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 70601, 70708);
                    return return_v;
                }


                System.Collections.ICollection
                f_1589_69612_69630_I(System.Collections.ICollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 69612, 69630);
                    return return_v;
                }


                System.Security.AccessControl.DiscretionaryAcl
                f_1589_70775_70802(System.Security.AccessControl.CommonSecurityDescriptor
                this_param)
                {
                    var return_v = this_param.DiscretionaryAcl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 70775, 70802);
                    return return_v;
                }


                int
                f_1589_70775_70808(System.Security.AccessControl.DiscretionaryAcl
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 70775, 70808);
                    return return_v;
                }


                string
                f_1589_70861_70910(System.Security.AccessControl.CommonSecurityDescriptor
                this_param, System.Security.AccessControl.AccessControlSections
                includeSections)
                {
                    var return_v = this_param.GetSddlForm(includeSections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 70861, 70910);
                    return return_v;
                }


                string
                f_1589_71003_71046(System.Collections.Hashtable
                configTable)
                {
                    var return_v = CreateConditionalACEFromConfig(configTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 71003, 71046);
                    return return_v;
                }


                string
                f_1589_71157_71219(string
                sddl, string
                conditionalGroupACE)
                {
                    var return_v = UpdateSDDLUsersWithGroupConditional(sddl, conditionalGroupACE);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 71157, 71219);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 67875, 71316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 67875, 71316);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const char
        OpenParenChar = '('
        ;

        private const char
        CloseParenChar = ')'
        ;

        private const char
        ACESeparatorChar = ';'
        ;

        private const string
        ACESeparator = ";"
        ;

        private const string
        ConditionalACEPrefix = "X"
        ;

        internal static string UpdateSDDLUsersWithGroupConditional(
                    string sddl,
                    string conditionalGroupACE)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 72285, 75418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 72834, 72850);

                string
                prologue
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 72864, 72880);

                string
                epilogue
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 72894, 72968);

                Collection<string>
                aces = f_1589_72920_72967(sddl, out prologue, out epilogue)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 72984, 73021) || true) && (f_1589_72988_72998(aces) == 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 72984, 73021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 73007, 73019);

                    return sddl;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 72984, 73021);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 73037, 73076);

                StringBuilder
                sb = f_1589_73056_73075()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 73090, 73110);

                f_1589_73090_73109(sb, prologue);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 74203, 75334);
                    foreach (var ace in f_1589_74223_74227_I(aces))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 74203, 75334);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 74303, 74348);

                        var
                        components = f_1589_74320_74347(ace, ACESeparatorChar)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 74366, 74592) || true) && (f_1589_74370_74387(components) != 6)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 74366, 74592);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 74434, 74573);

                            throw f_1589_74440_74572(f_1589_74498_74571(f_1589_74516_74565(), ace));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 74366, 74592);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 74681, 74736);

                        components[0] = f_1589_74697_74735(components[0], OpenParenChar);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 74754, 74808);

                        components[5] = f_1589_74770_74807(components[5], CloseParenChar);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 74877, 74902);

                        f_1589_74877_74901(
                                        // Building new conditional ACE
                                        sb, OpenParenChar);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 74968, 75022);

                        var
                        accessType = ConditionalACEPrefix + components[0]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 75040, 75077);

                        f_1589_75040_75076(sb, accessType + ACESeparator);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 75104, 75109);
                            for (int
            i = 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 75095, 75222) || true) && (i < 6)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 75118, 75121)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 75095, 75222))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 75095, 75222);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 75163, 75203);

                                f_1589_75163_75202(sb, components[i] + ACESeparator);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1589, 1, 128);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1589, 1, 128);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 75242, 75273);

                        f_1589_75242_75272(
                                        sb, conditionalGroupACE);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 75293, 75319);

                        f_1589_75293_75318(
                                        sb, CloseParenChar);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 74203, 75334);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1589, 1, 1132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1589, 1, 1132);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 75350, 75370);

                f_1589_75350_75369(
                            sb, epilogue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 75386, 75407);

                return f_1589_75393_75406(sb);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 72285, 75418);

                System.Collections.ObjectModel.Collection<string>
                f_1589_72920_72967(string
                sddl, out string
                prologue, out string
                epilogue)
                {
                    var return_v = ParseDACLACEs(sddl, out prologue, out epilogue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 72920, 72967);
                    return return_v;
                }


                int
                f_1589_72988_72998(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 72988, 72998);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_73056_73075()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 73056, 73075);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_73090_73109(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 73090, 73109);
                    return return_v;
                }


                string[]
                f_1589_74320_74347(string
                this_param, char
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 74320, 74347);
                    return return_v;
                }


                int
                f_1589_74370_74387(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 74370, 74387);
                    return return_v;
                }


                string
                f_1589_74516_74565()
                {
                    var return_v = RemotingErrorIdStrings.RequiredGroupsMalformedACE;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 74516, 74565);
                    return return_v;
                }


                string
                f_1589_74498_74571(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 74498, 74571);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1589_74440_74572(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 74440, 74572);
                    return return_v;
                }


                string
                f_1589_74697_74735(string
                this_param, char
                trimChar)
                {
                    var return_v = this_param.TrimStart(trimChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 74697, 74735);
                    return return_v;
                }


                string
                f_1589_74770_74807(string
                this_param, char
                trimChar)
                {
                    var return_v = this_param.TrimEnd(trimChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 74770, 74807);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_74877_74901(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 74877, 74901);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_75040_75076(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 75040, 75076);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_75163_75202(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 75163, 75202);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_75242_75272(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 75242, 75272);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_75293_75318(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 75293, 75318);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1589_74223_74227_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 74223, 74227);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_75350_75369(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 75350, 75369);
                    return return_v;
                }


                string
                f_1589_75393_75406(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 75393, 75406);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 72285, 75418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 72285, 75418);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const string
        DACLPrefix = "D:"
        ;

        private static Collection<string> ParseDACLACEs(
                    string sddl,
                    out string prologue,
                    out string epilogue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 75479, 77911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 76201, 76256);

                Collection<string>
                sddlACEs = f_1589_76231_76255()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 76316, 76389);

                int
                index = f_1589_76328_76388(sddl, DACLPrefix, StringComparison.OrdinalIgnoreCase)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 76403, 76565) || true) && (index < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 76403, 76565);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 76450, 76474);

                    prologue = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 76492, 76516);

                    epilogue = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 76534, 76550);

                    return sddlACEs;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 76403, 76565);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 76655, 76698);

                index = f_1589_76663_76697(sddl, OpenParenChar, index);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 76712, 76874) || true) && (index < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 76712, 76874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 76759, 76783);

                    prologue = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 76801, 76825);

                    epilogue = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 76843, 76859);

                    return sddlACEs;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 76712, 76874);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 76890, 76926);

                prologue = f_1589_76901_76925(sddl, 0, index);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 76942, 76971);

                int
                sddlLength = f_1589_76959_76970(sddl)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 76985, 77698) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 76985, 77698);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 77069, 77120);

                        int
                        endIndex = f_1589_77084_77119(sddl, CloseParenChar, index)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 77138, 77352) || true) && (endIndex < 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 77138, 77352);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 77196, 77333);

                            throw f_1589_77202_77332(f_1589_77260_77331(f_1589_77278_77324(), sddl));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 77138, 77352);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 77372, 77431);

                        string
                        ace = f_1589_77385_77430(sddl, index, (endIndex - index + 1))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 77449, 77467);

                        f_1589_77449_77466(sddlACEs, ace);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 77573, 77594);

                        index = endIndex + 1;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 77612, 77683) || true) && ((index >= sddlLength) || (DynAbs.Tracing.TraceSender.Expression_False(1589, 77616, 77671) || (f_1589_77642_77653(sddl, index) != OpenParenChar)))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 77612, 77683);
                            DynAbs.Tracing.TraceSender.TraceBreak(1589, 77675, 77681);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 77612, 77683);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 76985, 77698);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1589, 76985, 77698);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1589, 76985, 77698);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 77775, 77868);

                epilogue = (DynAbs.Tracing.TraceSender.Conditional_F1(1589, 77786, 77806) || (((index < sddlLength) && DynAbs.Tracing.TraceSender.Conditional_F2(1589, 77809, 77852)) || DynAbs.Tracing.TraceSender.Conditional_F3(1589, 77855, 77867))) ? f_1589_77809_77852(sddl, index, (sddlLength - index)) : string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 77884, 77900);

                return sddlACEs;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 75479, 77911);

                System.Collections.ObjectModel.Collection<string>
                f_1589_76231_76255()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 76231, 76255);
                    return return_v;
                }


                int
                f_1589_76328_76388(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 76328, 76388);
                    return return_v;
                }


                int
                f_1589_76663_76697(string
                this_param, char
                value, int
                startIndex)
                {
                    var return_v = this_param.IndexOf(value, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 76663, 76697);
                    return return_v;
                }


                string
                f_1589_76901_76925(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 76901, 76925);
                    return return_v;
                }


                int
                f_1589_76959_76970(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 76959, 76970);
                    return return_v;
                }


                int
                f_1589_77084_77119(string
                this_param, char
                value, int
                startIndex)
                {
                    var return_v = this_param.IndexOf(value, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 77084, 77119);
                    return return_v;
                }


                string
                f_1589_77278_77324()
                {
                    var return_v = RemotingErrorIdStrings.BadSDDLMismatchedParens;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 77278, 77324);
                    return return_v;
                }


                string
                f_1589_77260_77331(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 77260, 77331);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1589_77202_77332(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 77202, 77332);
                    return return_v;
                }


                string
                f_1589_77385_77430(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 77385, 77430);
                    return return_v;
                }


                int
                f_1589_77449_77466(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 77449, 77466);
                    return 0;
                }


                char
                f_1589_77642_77653(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 77642, 77653);
                    return return_v;
                }


                string
                f_1589_77809_77852(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 77809, 77852);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 75479, 77911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 75479, 77911);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const string
        AndOperator = "And"
        ;

        private const string
        OrOperator = "Or"
        ;

        private const string
        AndCondition = " && "
        ;

        private const string
        OrCondition = " || "
        ;

        private const string
        MemberOfFormat = "Member_of {{SID({0})}}"
        ;

        internal static string CreateConditionalACEFromConfig(
                    Hashtable configTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 79068, 79991);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 79183, 79308) || true) && (!f_1589_79188_79247(configTable, ConfigFileConstants.RequiredGroups))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 79183, 79308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 79281, 79293);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 79183, 79308);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 79324, 79375);

                StringBuilder
                conditionalACE = f_1589_79355_79374()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 79389, 79481);

                Hashtable
                requiredGroupsHash = f_1589_79420_79467(configTable, ConfigFileConstants.RequiredGroups) as Hashtable
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 79495, 79663) || true) && (requiredGroupsHash == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 79495, 79663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 79559, 79648);

                    throw f_1589_79565_79647(f_1589_79597_79646());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 79495, 79663);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 79679, 79773) || true) && (f_1589_79683_79707(requiredGroupsHash) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 79679, 79773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 79746, 79758);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 79679, 79773);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 79882, 79931);

                f_1589_79882_79930(conditionalACE, requiredGroupsHash);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 79947, 79980);

                return f_1589_79954_79979(conditionalACE);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 79068, 79991);

                bool
                f_1589_79188_79247(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 79188, 79247);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_79355_79374()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 79355, 79374);
                    return return_v;
                }


                object
                f_1589_79420_79467(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 79420, 79467);
                    return return_v;
                }


                string
                f_1589_79597_79646()
                {
                    var return_v = RemotingErrorIdStrings.RequiredGroupsNotHashTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 79597, 79646);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1589_79565_79647(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 79565, 79647);
                    return return_v;
                }


                int
                f_1589_79683_79707(System.Collections.Hashtable
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 79683, 79707);
                    return return_v;
                }


                int
                f_1589_79882_79930(System.Text.StringBuilder
                sb, System.Collections.Hashtable
                condition)
                {
                    AddCondition(sb, condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 79882, 79930);
                    return 0;
                }


                string
                f_1589_79954_79979(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 79954, 79979);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 79068, 79991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 79068, 79991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AddCondition(
                    StringBuilder sb,
                    Hashtable condition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 80003, 80810);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 80253, 80799) || true) && (f_1589_80257_80291(condition, AndOperator))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 80253, 80799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 80325, 80366);

                    object
                    keyValue = f_1589_80343_80365(condition, AndOperator)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 80384, 80426);

                    f_1589_80384_80425(sb, keyValue, AndCondition);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 80253, 80799);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 80253, 80799);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 80460, 80799) || true) && (f_1589_80464_80497(condition, OrOperator))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 80460, 80799);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 80531, 80571);

                        object
                        keyValue = f_1589_80549_80570(condition, OrOperator)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 80589, 80630);

                        f_1589_80589_80629(sb, keyValue, OrCondition);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 80460, 80799);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 80460, 80799);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 80696, 80784);

                        throw f_1589_80702_80783(f_1589_80734_80782());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 80460, 80799);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 80253, 80799);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 80003, 80810);

                bool
                f_1589_80257_80291(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 80257, 80291);
                    return return_v;
                }


                object
                f_1589_80343_80365(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 80343, 80365);
                    return return_v;
                }


                int
                f_1589_80384_80425(System.Text.StringBuilder
                sb, object
                keyValue, string
                logicalOperator)
                {
                    ParseKeyValue(sb, keyValue, logicalOperator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 80384, 80425);
                    return 0;
                }


                bool
                f_1589_80464_80497(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 80464, 80497);
                    return return_v;
                }


                object
                f_1589_80549_80570(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 80549, 80570);
                    return return_v;
                }


                int
                f_1589_80589_80629(System.Text.StringBuilder
                sb, object
                keyValue, string
                logicalOperator)
                {
                    ParseKeyValue(sb, keyValue, logicalOperator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 80589, 80629);
                    return 0;
                }


                string
                f_1589_80734_80782()
                {
                    var return_v = RemotingErrorIdStrings.UnknownGroupMembershipKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 80734, 80782);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1589_80702_80783(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 80702, 80783);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 80003, 80810);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 80003, 80810);
            }
        }

        private static void ParseKeyValue(
                    StringBuilder sb,
                    object keyValue,
                    string logicalOperator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 80822, 82649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 81014, 81039);

                f_1589_81014_81038(            // Start of condition
                            sb, OpenParenChar);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 81977, 82016);

                object[]
                values = keyValue as object[]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 82030, 82563) || true) && (values != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 82030, 82563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 82082, 82108);

                    int
                    count = f_1589_82094_82107(values)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 82135, 82140);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 82126, 82456) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 82126, 82456))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 82126, 82456);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 82194, 82223);

                            f_1589_82194_82222(sb, values[i++]);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 82245, 82437) || true) && (i < count)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 82245, 82437);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 82387, 82414);

                                f_1589_82387_82413(                        // Combine sub conditional ACEs with logical operator
                                                        sb, logicalOperator);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 82245, 82437);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1589, 1, 331);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1589, 1, 331);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 82030, 82563);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 82030, 82563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 82522, 82548);

                    f_1589_82522_82547(sb, keyValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 82030, 82563);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 82612, 82638);

                f_1589_82612_82637(
                            // End of condition
                            sb, CloseParenChar);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 80822, 82649);

                System.Text.StringBuilder
                f_1589_81014_81038(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 81014, 81038);
                    return return_v;
                }


                int
                f_1589_82094_82107(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 82094, 82107);
                    return return_v;
                }


                int
                f_1589_82194_82222(System.Text.StringBuilder
                sb, object
                inValue)
                {
                    ParseValues(sb, inValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 82194, 82222);
                    return 0;
                }


                System.Text.StringBuilder
                f_1589_82387_82413(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 82387, 82413);
                    return return_v;
                }


                int
                f_1589_82522_82547(System.Text.StringBuilder
                sb, object
                inValue)
                {
                    ParseValues(sb, inValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 82522, 82547);
                    return 0;
                }


                System.Text.StringBuilder
                f_1589_82612_82637(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 82612, 82637);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 80822, 82649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 80822, 82649);
            }
        }

        private static void ParseValues(
                    StringBuilder sb,
                    object inValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 82661, 83189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 82855, 82893);

                object[]
                values = inValue as object[]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 82907, 83178) || true) && (values != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 82907, 83178);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 82959, 83073);
                        foreach (object value in f_1589_82984_82990_I(values))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 82959, 83073);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 83032, 83054);

                            f_1589_83032_83053(sb, value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 82959, 83073);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1589, 1, 115);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1589, 1, 115);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 82907, 83178);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 82907, 83178);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 83139, 83163);

                    f_1589_83139_83162(sb, inValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 82907, 83178);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 82661, 83189);

                int
                f_1589_83032_83053(System.Text.StringBuilder
                sb, object
                value)
                {
                    ParseValue(sb, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 83032, 83053);
                    return 0;
                }


                object[]
                f_1589_82984_82990_I(object[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 82984, 82990);
                    return return_v;
                }


                int
                f_1589_83139_83162(System.Text.StringBuilder
                sb, object
                value)
                {
                    ParseValue(sb, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 83139, 83162);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 82661, 83189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 82661, 83189);
            }
        }

        private static void ParseValue(
                    StringBuilder sb,
                    object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 83201, 84323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 83407, 83442);

                string
                groupName = value as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 83456, 84312) || true) && (groupName != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 83456, 84312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 83557, 83604);

                    NTAccount
                    ntAccount = f_1589_83579_83603(groupName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 83622, 83722);

                    SecurityIdentifier
                    accountSid = (SecurityIdentifier)f_1589_83674_83721(ntAccount, typeof(SecurityIdentifier))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 83740, 83808);

                    f_1589_83740_83807(sb, f_1589_83750_83806(MemberOfFormat, f_1589_83784_83805(accountSid)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 83456, 84312);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 83456, 84312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 83874, 83922);

                    Hashtable
                    recurseCondition = value as Hashtable
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 83940, 84297) || true) && (recurseCondition != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 83940, 84297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 84071, 84106);

                        f_1589_84071_84105(sb, recurseCondition);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 83940, 84297);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 83940, 84297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 84188, 84278);

                        throw f_1589_84194_84277(f_1589_84226_84276());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 83940, 84297);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 83456, 84312);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 83201, 84323);

                System.Security.Principal.NTAccount
                f_1589_83579_83603(string
                name)
                {
                    var return_v = new System.Security.Principal.NTAccount(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 83579, 83603);
                    return return_v;
                }


                System.Security.Principal.IdentityReference
                f_1589_83674_83721(System.Security.Principal.NTAccount
                this_param, System.Type
                targetType)
                {
                    var return_v = this_param.Translate(targetType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 83674, 83721);
                    return return_v;
                }


                string
                f_1589_83784_83805(System.Security.Principal.SecurityIdentifier
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 83784, 83805);
                    return return_v;
                }


                string
                f_1589_83750_83806(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 83750, 83806);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_83740_83807(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 83740, 83807);
                    return return_v;
                }


                int
                f_1589_84071_84105(System.Text.StringBuilder
                sb, System.Collections.Hashtable
                condition)
                {
                    AddCondition(sb, condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 84071, 84105);
                    return 0;
                }


                string
                f_1589_84226_84276()
                {
                    var return_v = RemotingErrorIdStrings.UnknownGroupMembershipValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 84226, 84276);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1589_84194_84277(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 84194, 84277);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 83201, 84323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 83201, 84323);
            }
        }

        static PSSessionConfigurationCommandUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1589, 56521, 84374);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 56620, 56687);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 56769, 56878);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 71378, 71397);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 71427, 71447);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 71477, 71499);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 71531, 71549);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 71581, 71607);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 75451, 75468);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 78001, 78020);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 78052, 78069);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 78101, 78122);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 78154, 78174);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 78206, 78247);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1589, 56521, 84374);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 56521, 84374);
        }

    }
    public class PSSessionConfigurationCommandBase : PSCmdlet
    {
        internal const string
        NameParameterSetName = "NameParameterSet"
        ;

        internal const string
        AssemblyNameParameterSetName = "AssemblyNameParameterSet"
        ;

        internal const string
        SessionConfigurationFileParameterSetName = "SessionConfigurationFile"
        ;

        private const string
        localSDDL = "O:NSG:BAD:P(D;;GA;;;NU)(A;;GA;;;BA)(A;;GA;;;IU)S:P(AU;FA;GA;;;WD)(AU;SA;GXGW;;;WD)"
        ;

        private const string
        localSDDL_Win8 = "O:NSG:BAD:P(D;;GA;;;NU)(A;;GA;;;BA)(A;;GA;;;RM)(A;;GA;;;IU)S:P(AU;FA;GA;;;WD)(AU;SA;GXGW;;;WD)"
        ;

        private const string
        remoteSDDL = "O:NSG:BAD:P(A;;GA;;;BA)(A;;GA;;;IU)S:P(AU;FA;GA;;;WD)(AU;SA;GXGW;;;WD)"
        ;

        private const string
        remoteSDDL_Win8 = "O:NSG:BAD:P(A;;GA;;;BA)(A;;GA;;;RM)(A;;GA;;;IU)S:P(AU;FA;GA;;;WD)(AU;SA;GXGW;;;WD)"
        ;

        internal const string
        RemoteManagementUsersSID = "S-1-5-32-580"
        ;

        internal const string
        InteractiveUsersSID = "S-1-5-4"
        ;

        internal Version MaxPSVersion;

        internal static string GetLocalSddl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 85924, 86086);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 85986, 86075);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1589, 85993, 86045) || (((f_1589_85994_86023(f_1589_85994_86015()) >= f_1589_86027_86044(6, 2)) && DynAbs.Tracing.TraceSender.Conditional_F2(1589, 86048, 86062)) || DynAbs.Tracing.TraceSender.Conditional_F3(1589, 86065, 86074))) ? localSDDL_Win8 : localSDDL;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 85924, 86086);

                System.OperatingSystem
                f_1589_85994_86015()
                {
                    var return_v = Environment.OSVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 85994, 86015);
                    return return_v;
                }


                System.Version
                f_1589_85994_86023(System.OperatingSystem
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 85994, 86023);
                    return return_v;
                }


                System.Version
                f_1589_86027_86044(int
                major, int
                minor)
                {
                    var return_v = new System.Version(major, minor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 86027, 86044);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 85924, 86086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 85924, 86086);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetRemoteSddl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 86098, 86263);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 86161, 86252);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1589, 86168, 86220) || (((f_1589_86169_86198(f_1589_86169_86190()) >= f_1589_86202_86219(6, 2)) && DynAbs.Tracing.TraceSender.Conditional_F2(1589, 86223, 86238)) || DynAbs.Tracing.TraceSender.Conditional_F3(1589, 86241, 86251))) ? remoteSDDL_Win8 : remoteSDDL;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 86098, 86263);

                System.OperatingSystem
                f_1589_86169_86190()
                {
                    var return_v = Environment.OSVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 86169, 86190);
                    return return_v;
                }


                System.Version
                f_1589_86169_86198(System.OperatingSystem
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 86169, 86198);
                    return return_v;
                }


                System.Version
                f_1589_86202_86219(int
                major, int
                minor)
                {
                    var return_v = new System.Version(major, minor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 86202, 86219);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 86098, 86263);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 86098, 86263);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipelineByPropertyName = true, ParameterSetName = NameParameterSetName)]
        [Parameter(Mandatory = true, Position = 0, ValueFromPipelineByPropertyName = true, ParameterSetName = AssemblyNameParameterSetName)]
        [Parameter(Mandatory = true, Position = 0, ValueFromPipelineByPropertyName = true, ParameterSetName = SessionConfigurationFileParameterSetName)]
        [ValidateNotNullOrEmpty]
        public string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 86993, 87018);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 86999, 87016);

                    return shellName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 86993, 87018);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 86486, 87071);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 86486, 87071);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 87034, 87060);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 87040, 87058);

                    shellName = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 87034, 87060);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 86486, 87071);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 86486, 87071);
                }
            }
        }

        internal string shellName;

        [Parameter(Position = 1, Mandatory = true, ParameterSetName = PSSessionConfigurationCommandBase.AssemblyNameParameterSetName)]
        public string AssemblyName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 87503, 87531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 87509, 87529);

                    return assemblyName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 87503, 87531);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 87316, 87679);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 87316, 87679);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 87547, 87668);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 87583, 87604);

                    assemblyName = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 87622, 87653);

                    isAssemblyNameSpecified = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 87547, 87668);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 87316, 87679);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 87316, 87679);
                }
            }
        }

        internal string assemblyName;

        internal bool isAssemblyNameSpecified;

        [Parameter(ParameterSetName = NameParameterSetName)]
        [Parameter(ParameterSetName = AssemblyNameParameterSetName)]
        public string ApplicationBase
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 88273, 88304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 88279, 88302);

                    return applicationBase;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 88273, 88304);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 88087, 88458);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 88087, 88458);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 88320, 88447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 88356, 88380);

                    applicationBase = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 88398, 88432);

                    isApplicationBaseSpecified = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 88320, 88447);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 88087, 88458);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 88087, 88458);
                }
            }
        }

        internal string applicationBase;

        internal bool isApplicationBaseSpecified;

        [Parameter(Position = 2, Mandatory = true, ParameterSetName = PSSessionConfigurationCommandBase.AssemblyNameParameterSetName)]
        public string ConfigurationTypeName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 89034, 89071);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 89040, 89069);

                    return configurationTypeName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 89034, 89071);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 88838, 89237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 88838, 89237);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 89087, 89226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 89123, 89153);

                    configurationTypeName = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 89171, 89211);

                    isConfigurationTypeNameSpecified = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 89087, 89226);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 88838, 89237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 88838, 89237);
                }
            }
        }

        internal string configurationTypeName;

        internal bool isConfigurationTypeNameSpecified;

        [Parameter, Credential]
        public PSCredential RunAsCredential
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 89558, 89632);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 89594, 89617);

                    return runAsCredential;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 89558, 89632);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 89465, 89786);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 89465, 89786);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 89648, 89775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 89684, 89708);

                    runAsCredential = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 89726, 89760);

                    isRunAsCredentialSpecified = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 89648, 89775);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 89465, 89786);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 89465, 89786);
                }
            }
        }

        internal PSCredential runAsCredential;

        internal bool isRunAsCredentialSpecified;

        [Parameter()]
        public ApartmentState ThreadApartmentState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 90103, 90320);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 90139, 90255) || true) && (f_1589_90143_90166(threadAptState))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 90139, 90255);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 90208, 90236);

                        return f_1589_90215_90235(threadAptState);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 90139, 90255);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 90275, 90305);

                    return ApartmentState.Unknown;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 90103, 90320);

                    bool
                    f_1589_90143_90166(System.Threading.ApartmentState?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 90143, 90166);
                        return return_v;
                    }


                    System.Threading.ApartmentState
                    f_1589_90215_90235(System.Threading.ApartmentState?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 90215, 90235);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 90013, 90378);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 90013, 90378);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 90336, 90367);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 90342, 90365);

                    threadAptState = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 90336, 90367);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 90013, 90378);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 90013, 90378);
                }
            }
        }

        internal ApartmentState? threadAptState;

        [Parameter()]
        public PSThreadOptions ThreadOptions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 90639, 90864);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 90675, 90789) || true) && (f_1589_90679_90701(threadOptions))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 90675, 90789);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 90743, 90770);

                        return f_1589_90750_90769(threadOptions);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 90675, 90789);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 90809, 90849);

                    return PSThreadOptions.UseCurrentThread;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 90639, 90864);

                    bool
                    f_1589_90679_90701(System.Management.Automation.Runspaces.PSThreadOptions?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 90679, 90701);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.PSThreadOptions
                    f_1589_90750_90769(System.Management.Automation.Runspaces.PSThreadOptions?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 90750, 90769);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 90555, 90921);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 90555, 90921);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 90880, 90910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 90886, 90908);

                    threadOptions = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 90880, 90910);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 90555, 90921);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 90555, 90921);
                }
            }
        }

        internal PSThreadOptions? threadOptions;

        [Parameter]
        public PSSessionConfigurationAccessMode AccessMode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 91158, 91185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 91164, 91183);

                    return _accessMode;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 91158, 91185);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 91062, 91328);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 91062, 91328);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 91201, 91317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 91237, 91257);

                    _accessMode = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 91275, 91302);

                    accessModeSpecified = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 91201, 91317);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 91062, 91328);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 91062, 91328);
                }
            }
        }

        private PSSessionConfigurationAccessMode _accessMode;

        internal bool accessModeSpecified;

        [Parameter]
        public SwitchParameter UseSharedProcess
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 91655, 91731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 91691, 91716);

                    return _useSharedProcess;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 91655, 91731);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 91570, 91888);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 91570, 91888);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 91747, 91877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 91783, 91809);

                    _useSharedProcess = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 91827, 91862);

                    isUseSharedProcessSpecified = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 91747, 91877);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 91570, 91888);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 91570, 91888);
                }
            }
        }

        private bool _useSharedProcess;

        internal bool isUseSharedProcessSpecified;

        [Parameter()]
        public string StartupScript
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 92198, 92233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 92204, 92231);

                    return configurationScript;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 92198, 92233);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 92123, 92395);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 92123, 92395);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 92249, 92384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 92285, 92313);

                    configurationScript = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 92331, 92369);

                    isConfigurationScriptSpecified = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 92249, 92384);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 92123, 92395);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 92123, 92395);
                }
            }
        }

        internal string configurationScript;

        internal bool isConfigurationScriptSpecified;

        [Parameter()]
        [AllowNull]
        public double? MaximumReceivedDataSizePerCommandMB
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 92792, 92824);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 92798, 92822);

                    return maxCommandSizeMB;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 92792, 92824);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 92673, 93364);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 92673, 93364);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 92840, 93353);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 92876, 93240) || true) && ((f_1589_92881_92895(value)) && (DynAbs.Tracing.TraceSender.Expression_True(1589, 92880, 92917) && (f_1589_92901_92912(value) < 0)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 92876, 93240);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 92959, 93221);

                        throw f_1589_92965_93220(f_1589_93013_93193(f_1589_93060_93111(), f_1589_93142_93153(value), "MaximumReceivedDataSizePerCommandMB"));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 92876, 93240);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 93260, 93285);

                    maxCommandSizeMB = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 93303, 93338);

                    isMaxCommandSizeMBSpecified = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 92840, 93353);

                    bool
                    f_1589_92881_92895(double?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 92881, 92895);
                        return return_v;
                    }


                    double
                    f_1589_92901_92912(double?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 92901, 92912);
                        return return_v;
                    }


                    string
                    f_1589_93060_93111()
                    {
                        var return_v = RemotingErrorIdStrings.CSCDoubleParameterOutOfRange;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 93060, 93111);
                        return return_v;
                    }


                    double
                    f_1589_93142_93153(double?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 93142, 93153);
                        return return_v;
                    }


                    string
                    f_1589_93013_93193(string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 93013, 93193);
                        return return_v;
                    }


                    System.ArgumentException
                    f_1589_92965_93220(string
                    message)
                    {
                        var return_v = new System.ArgumentException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 92965, 93220);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 92673, 93364);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 92673, 93364);
                }
            }
        }

        internal double? maxCommandSizeMB;

        internal bool isMaxCommandSizeMBSpecified;

        [Parameter()]
        [AllowNull]
        public double? MaximumReceivedObjectSizeMB
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 93723, 93754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 93729, 93752);

                    return maxObjectSizeMB;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 93723, 93754);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 93612, 94284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 93612, 94284);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 93770, 94273);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 93806, 94162) || true) && ((f_1589_93811_93825(value)) && (DynAbs.Tracing.TraceSender.Expression_True(1589, 93810, 93847) && (f_1589_93831_93842(value) < 0)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 93806, 94162);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 93889, 94143);

                        throw f_1589_93895_94142(f_1589_93943_94115(f_1589_93990_94041(), f_1589_94072_94083(value), "MaximumReceivedObjectSizeMB"));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 93806, 94162);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 94182, 94206);

                    maxObjectSizeMB = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 94224, 94258);

                    isMaxObjectSizeMBSpecified = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 93770, 94273);

                    bool
                    f_1589_93811_93825(double?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 93811, 93825);
                        return return_v;
                    }


                    double
                    f_1589_93831_93842(double?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 93831, 93842);
                        return return_v;
                    }


                    string
                    f_1589_93990_94041()
                    {
                        var return_v = RemotingErrorIdStrings.CSCDoubleParameterOutOfRange;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 93990, 94041);
                        return return_v;
                    }


                    double
                    f_1589_94072_94083(double?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 94072, 94083);
                        return return_v;
                    }


                    string
                    f_1589_93943_94115(string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 93943, 94115);
                        return return_v;
                    }


                    System.ArgumentException
                    f_1589_93895_94142(string
                    message)
                    {
                        var return_v = new System.ArgumentException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 93895, 94142);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 93612, 94284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 93612, 94284);
                }
            }
        }

        internal double? maxObjectSizeMB;

        internal bool isMaxObjectSizeMBSpecified;

        [Parameter()]
        public string SecurityDescriptorSddl
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 94651, 94671);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 94657, 94669);

                    return sddl;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 94651, 94671);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 94567, 95367);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 94567, 95367);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 94687, 95356);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 94723, 95267) || true) && (!f_1589_94728_94755(value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 94723, 95267);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 94862, 94941);

                        CommonSecurityDescriptor
                        c = f_1589_94891_94940(false, false, value)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 95128, 95248) || true) && (c == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 95128, 95248);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 95191, 95225);

                            throw f_1589_95197_95224();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 95128, 95248);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 94723, 95267);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 95287, 95300);

                    sddl = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 95318, 95341);

                    isSddlSpecified = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 94687, 95356);

                    bool
                    f_1589_94728_94755(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 94728, 94755);
                        return return_v;
                    }


                    System.Security.AccessControl.CommonSecurityDescriptor
                    f_1589_94891_94940(bool
                    isContainer, bool
                    isDS, string
                    sddlForm)
                    {
                        var return_v = new System.Security.AccessControl.CommonSecurityDescriptor(isContainer, isDS, sddlForm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 94891, 94940);
                        return return_v;
                    }


                    System.NotSupportedException
                    f_1589_95197_95224()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 95197, 95224);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 94567, 95367);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 94567, 95367);
                }
            }
        }

        internal string sddl;

        internal bool isSddlSpecified;

        [Parameter()]
        public SwitchParameter ShowSecurityDescriptorUI
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 95686, 95709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 95692, 95707);

                    return _showUI;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 95686, 95709);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 95591, 95844);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 95591, 95844);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 95725, 95833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 95761, 95777);

                    _showUI = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 95795, 95818);

                    showUISpecified = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 95725, 95833);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 95591, 95844);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 95591, 95844);
                }
            }
        }

        private bool _showUI;

        internal bool showUISpecified;

        [Parameter()]
        public SwitchParameter Force
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 96201, 96222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 96207, 96220);

                    return force;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 96201, 96222);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 96125, 96271);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 96125, 96271);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 96238, 96260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 96244, 96258);

                    force = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 96238, 96260);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 96125, 96271);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 96125, 96271);
                }
            }
        }

        internal bool force;

        [Parameter()]
        public SwitchParameter NoServiceRestart
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 96645, 96670);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 96651, 96668);

                    return noRestart;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 96645, 96670);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 96558, 96723);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 96558, 96723);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 96686, 96712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 96692, 96710);

                    noRestart = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 96686, 96712);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 96558, 96723);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 96558, 96723);
                }
            }
        }

        internal bool noRestart;

        [Parameter(ParameterSetName = NameParameterSetName)]
        [Parameter(ParameterSetName = AssemblyNameParameterSetName)]
        [Alias("PowerShellVersion")]
        [ValidateNotNullOrEmpty]
        public Version PSVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 97396, 97421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 97402, 97419);

                    return psVersion;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 97396, 97421);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 97143, 97782);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 97143, 97782);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 97437, 97771);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 97473, 97515);

                    f_1589_97473_97514(value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 97609, 97672);

                    f_1589_97609_97671(value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 97692, 97710);

                    psVersion = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 97728, 97756);

                    isPSVersionSpecified = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 97437, 97771);

                    int
                    f_1589_97473_97514(System.Version
                    version)
                    {
                        RemotingCommandUtil.CheckPSVersion(version);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 97473, 97514);
                        return 0;
                    }


                    int
                    f_1589_97609_97671(System.Version
                    version)
                    {
                        RemotingCommandUtil.CheckIfPowerShellVersionIsInstalled(version);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 97609, 97671);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 97143, 97782);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 97143, 97782);
                }
            }
        }

        internal Version psVersion;

        internal bool isPSVersionSpecified;

        [Parameter(ParameterSetName = NameParameterSetName)]
        [Parameter(ParameterSetName = AssemblyNameParameterSetName)]
        public PSSessionTypeOption SessionTypeOption
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 98158, 98234);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 98194, 98219);

                    return sessionTypeOption;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 98158, 98234);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 97957, 98338);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 97957, 98338);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 98250, 98327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 98286, 98312);

                    sessionTypeOption = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 98250, 98327);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 97957, 98338);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 97957, 98338);
                }
            }
        }

        internal PSSessionTypeOption sessionTypeOption;

        [Parameter]
        public PSTransportOption TransportOption
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 98572, 98646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 98608, 98631);

                    return transportOption;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 98572, 98646);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 98486, 98748);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 98486, 98748);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 98662, 98737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 98698, 98722);

                    transportOption = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 98662, 98737);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 98486, 98748);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 98486, 98748);
                }
            }
        }

        internal PSTransportOption transportOption;

        [Parameter(ParameterSetName = NameParameterSetName)]
        [Parameter(ParameterSetName = AssemblyNameParameterSetName)]
        public object[] ModulesToImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 99080, 99154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 99116, 99139);

                    return modulesToImport;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 99080, 99154);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 98892, 101079);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 98892, 101079);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 99170, 101068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 99206, 99260);

                    List<object>
                    modulesToImportList = f_1589_99241_99259()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 99278, 100940) || true) && (value != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 99278, 100940);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 99337, 100921);
                            foreach (var s in f_1589_99355_99360_I(value))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 99337, 100921);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 99410, 99441);

                                var
                                hashtable = s as Hashtable
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 99469, 99853) || true) && (hashtable != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 99469, 99853);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 99548, 99600);

                                    var
                                    moduleSpec = f_1589_99565_99599(hashtable)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 99630, 99785) || true) && (moduleSpec != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 99630, 99785);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 99718, 99754);

                                        f_1589_99718_99753(modulesToImportList, moduleSpec);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 99630, 99785);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 99817, 99826);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 99469, 99853);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 100068, 100101);

                                string
                                modulepath = f_1589_100088_100100(s)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 100198, 100898) || true) && (!f_1589_100203_100242(f_1589_100224_100241(modulepath)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 100198, 100898);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 100300, 100803) || true) && ((f_1589_100305_100330(modulepath, "\\") || (DynAbs.Tracing.TraceSender.Expression_False(1589, 100305, 100358) || f_1589_100334_100358(modulepath, ":"))) && (DynAbs.Tracing.TraceSender.Expression_True(1589, 100304, 100454) && !(f_1589_100398_100426(modulepath) || (DynAbs.Tracing.TraceSender.Expression_False(1589, 100398, 100453) || f_1589_100430_100453(modulepath)))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 100300, 100803);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 100520, 100772);

                                        throw f_1589_100526_100771(f_1589_100586_100770(f_1589_100646_100716(), modulepath));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 100300, 100803);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 100835, 100871);

                                    f_1589_100835_100870(
                                                                modulesToImportList, modulepath);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 100198, 100898);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 99337, 100921);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1589, 1, 1585);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1589, 1, 1585);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 99278, 100940);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 100960, 101008);

                    modulesToImport = f_1589_100978_101007(modulesToImportList);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 101026, 101053);

                    modulePathSpecified = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 99170, 101068);

                    System.Collections.Generic.List<object>
                    f_1589_99241_99259()
                    {
                        var return_v = new System.Collections.Generic.List<object>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 99241, 99259);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.ModuleSpecification
                    f_1589_99565_99599(System.Collections.Hashtable
                    moduleSpecification)
                    {
                        var return_v = new Microsoft.PowerShell.Commands.ModuleSpecification(moduleSpecification);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 99565, 99599);
                        return return_v;
                    }


                    int
                    f_1589_99718_99753(System.Collections.Generic.List<object>
                    this_param, Microsoft.PowerShell.Commands.ModuleSpecification
                    item)
                    {
                        this_param.Add((object)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 99718, 99753);
                        return 0;
                    }


                    string?
                    f_1589_100088_100100(object
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 100088, 100100);
                        return return_v;
                    }


                    string
                    f_1589_100224_100241(string
                    this_param)
                    {
                        var return_v = this_param.Trim();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 100224, 100241);
                        return return_v;
                    }


                    bool
                    f_1589_100203_100242(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 100203, 100242);
                        return return_v;
                    }


                    bool
                    f_1589_100305_100330(string
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Contains(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 100305, 100330);
                        return return_v;
                    }


                    bool
                    f_1589_100334_100358(string
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Contains(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 100334, 100358);
                        return return_v;
                    }


                    bool
                    f_1589_100398_100426(string
                    path)
                    {
                        var return_v = Directory.Exists(path);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 100398, 100426);
                        return return_v;
                    }


                    bool
                    f_1589_100430_100453(string
                    path)
                    {
                        var return_v = File.Exists(path);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 100430, 100453);
                        return return_v;
                    }


                    string
                    f_1589_100646_100716()
                    {
                        var return_v = RemotingErrorIdStrings.InvalidRegisterPSSessionConfigurationModulePath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 100646, 100716);
                        return return_v;
                    }


                    string
                    f_1589_100586_100770(string
                    formatSpec, string
                    o)
                    {
                        var return_v = StringUtil.Format(formatSpec, (object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 100586, 100770);
                        return return_v;
                    }


                    System.ArgumentException
                    f_1589_100526_100771(string
                    message)
                    {
                        var return_v = new System.ArgumentException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 100526, 100771);
                        return return_v;
                    }


                    int
                    f_1589_100835_100870(System.Collections.Generic.List<object>
                    this_param, string
                    item)
                    {
                        this_param.Add((object)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 100835, 100870);
                        return 0;
                    }


                    object[]
                    f_1589_99355_99360_I(object[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 99355, 99360);
                        return return_v;
                    }


                    object[]
                    f_1589_100978_101007(System.Collections.Generic.List<object>
                    this_param)
                    {
                        var return_v = this_param.ToArray();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 100978, 101007);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 98892, 101079);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 98892, 101079);
                }
            }
        }

        internal object[] modulesToImport;

        internal bool modulePathSpecified;

        [Parameter(Mandatory = true, ParameterSetName = SessionConfigurationFileParameterSetName)]
        [ValidateNotNullOrEmpty]
        public string Path { get; set; }

        protected bool RunAsVirtualAccount { get; set; }

        protected bool RunAsVirtualAccountSpecified { get; set; }

        protected string RunAsVirtualAccountGroups { get; set; }

        internal PSSessionConfigurationCommandBase()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1589, 102165, 102231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 85836, 85855);
                this.MaxPSVersion = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 87099, 87108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 87707, 87719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 87744, 87767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 88486, 88501);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 88526, 88552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 89265, 89286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 89311, 89343);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 89820, 89835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 89860, 89886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 90415, 90429);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 90959, 90972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 91381, 91434);
                this._accessMode = PSSessionConfigurationAccessMode.Remote;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 91459, 91486);
                this.accessModeSpecified = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 91913, 91930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 91955, 91982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 92423, 92442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 92467, 92497);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 93393, 93409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 93434, 93461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 94313, 94328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 94353, 94379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 95395, 95399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 95424, 95439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 95869, 95876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 95901, 95916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 96297, 96302);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 96749, 96758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 97811, 97820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 97845, 97865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 98379, 98396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 98787, 98802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 101109, 101124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 101149, 101176);
                this.modulePathSpecified = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 101295, 101461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 101585, 101642);
                this.RunAsVirtualAccount = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 101701, 101767);
                this.RunAsVirtualAccountSpecified = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 101918, 101974);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1589, 102165, 102231);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 102165, 102231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 102165, 102231);
            }
        }

        static PSSessionConfigurationCommandBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1589, 84587, 102260);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 84715, 84756);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 84789, 84846);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 84879, 84948);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 85037, 85133);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 85165, 85278);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 85326, 85411);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 85443, 85545);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 85654, 85695);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 85775, 85806);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1589, 84587, 102260);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 84587, 102260);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1589, 84587, 102260);
    }
    [Cmdlet(VerbsLifecycle.Unregister, RemotingConstants.PSSessionConfigurationNoun,
            SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Low, HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096803")]
    public sealed class UnregisterPSSessionConfigurationCommand : PSCmdlet
    {
        private const string
        removePluginSbFormat = @"
function Unregister-PSSessionConfiguration
{{
    [CmdletBinding(SupportsShouldProcess=$true, ConfirmImpact=""Low"")]
    param(
       $filter,
       $action,
       $targetTemplate,
       $shellNotErrMsgFormat,
       [bool]$force)

    begin
    {{
    }}

    process
    {{
        $shellsFound = 0
        Get-ChildItem 'WSMan:\localhost\Plugin\' -Force:$force | Where-Object {{ $_.Name -like ""$filter"" }} | ForEach-Object {{
            $pluginFileNamePath = join-path ""$($_.pspath)"" 'FileName'
            if (!(test-path ""$pluginFileNamePath""))
            {{
                return
            }}

           $pluginFileName = get-item -literalpath ""$pluginFileNamePath""
           if ((!$pluginFileName) -or ($pluginFileName.Value -notmatch '{0}'))
           {{
                return
           }}
           else
           {{
                if (($pluginFileName.Value -match 'system32\\{0}') -OR
                    ($pluginFileName.Value -match 'syswow64\\{0}'))
                {{
                    # Filter out WindowsPowerShell endpoints when running as PowerShell 6+
                    return
                }}
           }}

           $shellsFound++

           $shouldProcessTargetString = $targetTemplate -f $_.Name

           $DISCConfigFilePath = [System.IO.Path]::Combine($_.PSPath, ""InitializationParameters"")
           $DISCConfigFile = get-childitem -literalpath ""$DISCConfigFilePath"" | Where-Object {{$_.Name -like ""configFilePath""}}

           if($null -ne $DISCConfigFile)
           {{
               if(test-path -LiteralPath ""$($DISCConfigFile.Value)"") {{
                       remove-item -literalpath ""$($DISCConfigFile.Value)"" -recurse -force -confirm:$false
               }}
           }}

           if($force -or $pscmdlet.ShouldProcess($shouldProcessTargetString, $action))
           {{
                remove-item -literalpath ""$($_.pspath)"" -recurse -force -confirm:$false
           }}
        }}

        if (!$shellsFound)
        {{
            $errMsg = $shellNotErrMsgFormat -f $filter
            Write-Error $errMsg
        }}
    }} # end of Process block
}}

if ($null -eq $args[7])
{{
    Unregister-PSSessionConfiguration -filter $args[0] -whatif:$args[1] -confirm:$args[2] -action $args[3] -targetTemplate $args[4] -shellNotErrMsgFormat $args[5] -force $args[6]
}}
else
{{
    Unregister-PSSessionConfiguration -filter $args[0] -whatif:$args[1] -confirm:$args[2] -action $args[3] -targetTemplate $args[4] -shellNotErrMsgFormat $args[5] -force $args[6] -erroraction $args[7]
}}
"
        ;

        private static readonly ScriptBlock s_removePluginSb;

        private bool _isErrorReported;

        [Parameter(Mandatory = true, Position = 0, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter()]
        public SwitchParameter Force
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 106258, 106323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 106294, 106308);

                    return _force;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 106258, 106323);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 106182, 106416);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 106182, 106416);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 106339, 106405);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 106375, 106390);

                    _force = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 106339, 106405);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 106182, 106416);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 106182, 106416);
                }
            }
        }

        private bool _force;

        [Parameter()]
        public SwitchParameter NoServiceRestart
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 106790, 106859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 106826, 106844);

                    return _noRestart;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 106790, 106859);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 106703, 106956);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 106703, 106956);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 106875, 106945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 106911, 106930);

                    _noRestart = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 106875, 106945);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 106703, 106956);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 106703, 106956);
                }
            }
        }

        private bool _noRestart;

        static UnregisterPSSessionConfigurationCommand()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1589, 107058, 107609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 102836, 105507);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 105554, 105570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 107131, 107294);

                string
                removePluginScript = f_1589_107159_107293(f_1589_107173_107201(), removePluginSbFormat, RemotingConstants.PSPluginDLLName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 107466, 107524);

                s_removePluginSb = f_1589_107485_107523(removePluginScript);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 107538, 107598);

                s_removePluginSb.LanguageMode = PSLanguageMode.FullLanguage;
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1589, 107058, 107609);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 107058, 107609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 107058, 107609);
            }
        }

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 107781, 107992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 107847, 107902);

                f_1589_107847_107901();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 107916, 107981);

                f_1589_107916_107980();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 107781, 107992);

                int
                f_1589_107847_107901()
                {
                    RemotingCommandUtil.CheckRemotingCmdletPrerequisites();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 107847, 107901);
                    return 0;
                }


                int
                f_1589_107916_107980()
                {
                    PSSessionConfigurationCommandUtilities.ThrowIfNotAdministrator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 107916, 107980);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 107781, 107992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 107781, 107992);
            }
        }

        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 108051, 110390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 108115, 108211);

                f_1589_108115_108210(this, f_1589_108128_108209(f_1589_108146_108186(), removePluginSbFormat));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 108227, 108347);

                string
                action = f_1589_108243_108346(f_1589_108261_108305(), f_1589_108324_108345(f_1589_108324_108340(this)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 108361, 108430);

                string
                targetTemplate = f_1589_108385_108429()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 108444, 108520);

                string
                csNotFoundMessageFormat = f_1589_108477_108519()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 108624, 108644);

                bool
                whatIf = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 108711, 108731);

                bool
                confirm = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 108745, 108846);

                f_1589_108745_108845(this, out whatIf, out confirm);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 108986, 109012);

                object
                errorAction = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 109026, 109215) || true) && (f_1589_109030_109093(f_1589_109030_109076(f_1589_109030_109061(f_1589_109030_109037()))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 109026, 109215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 109127, 109200);

                    errorAction = f_1589_109141_109199(f_1589_109141_109187(f_1589_109141_109172(f_1589_109141_109148())));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 109026, 109215);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 109231, 109292);

                ArrayList
                errorList = (ArrayList)f_1589_109264_109291(f_1589_109264_109271())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 109306, 109345);

                int
                errorCountBefore = f_1589_109329_109344(errorList)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 109361, 110244);

                f_1589_109361_110243(
                            s_removePluginSb, contextCmdlet: this, useLocalScope: true, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: f_1589_109602_109622(), input: f_1589_109648_109669(), scriptThis: f_1589_109700_109720(), args: new object[] {
f_1589_109804_109808(),
                                           whatIf,
                                           confirm,
                                           action,
                                           targetTemplate,
                                           csNotFoundMessageFormat,
                                           _force,
                                           errorAction
                                                    });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 110260, 110311);

                errorList = (ArrayList)f_1589_110283_110310(f_1589_110283_110290());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 110325, 110379);

                _isErrorReported = f_1589_110344_110359(errorList) > errorCountBefore;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 108051, 110390);

                string
                f_1589_108146_108186()
                {
                    var return_v = RemotingErrorIdStrings.RcsScriptMessageV;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 108146, 108186);
                    return return_v;
                }


                string
                f_1589_108128_108209(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 108128, 108209);
                    return return_v;
                }


                int
                f_1589_108115_108210(Microsoft.PowerShell.Commands.UnregisterPSSessionConfigurationCommand
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 108115, 108210);
                    return 0;
                }


                string
                f_1589_108261_108305()
                {
                    var return_v = RemotingErrorIdStrings.CSShouldProcessAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 108261, 108305);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1589_108324_108340(Microsoft.PowerShell.Commands.UnregisterPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 108324, 108340);
                    return return_v;
                }


                string
                f_1589_108324_108345(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 108324, 108345);
                    return return_v;
                }


                string
                f_1589_108243_108346(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 108243, 108346);
                    return return_v;
                }


                string
                f_1589_108385_108429()
                {
                    var return_v = RemotingErrorIdStrings.CSShouldProcessTarget;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 108385, 108429);
                    return return_v;
                }


                string
                f_1589_108477_108519()
                {
                    var return_v = RemotingErrorIdStrings.CustomShellNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 108477, 108519);
                    return return_v;
                }


                int
                f_1589_108745_108845(Microsoft.PowerShell.Commands.UnregisterPSSessionConfigurationCommand
                cmdlet, out bool
                whatIf, out bool
                confirm)
                {
                    PSSessionConfigurationCommandUtilities.CollectShouldProcessParameters((System.Management.Automation.PSCmdlet)cmdlet, out whatIf, out confirm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 108745, 108845);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1589_109030_109037()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 109030, 109037);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1589_109030_109061(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 109030, 109061);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1589_109030_109076(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 109030, 109076);
                    return return_v;
                }


                bool
                f_1589_109030_109093(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.IsErrorActionSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 109030, 109093);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1589_109141_109148()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 109141, 109148);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1589_109141_109172(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 109141, 109172);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1589_109141_109187(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 109141, 109187);
                    return return_v;
                }


                System.Management.Automation.ActionPreference
                f_1589_109141_109199(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.ErrorAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 109141, 109199);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1589_109264_109271()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 109264, 109271);
                    return return_v;
                }


                object
                f_1589_109264_109291(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.DollarErrorVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 109264, 109291);
                    return return_v;
                }


                int
                f_1589_109329_109344(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 109329, 109344);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_109602_109622()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 109602, 109622);
                    return return_v;
                }


                object[]
                f_1589_109648_109669()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 109648, 109669);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_109700_109720()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 109700, 109720);
                    return return_v;
                }


                string
                f_1589_109804_109808()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 109804, 109808);
                    return return_v;
                }


                int
                f_1589_109361_110243(System.Management.Automation.ScriptBlock
                this_param, Microsoft.PowerShell.Commands.UnregisterPSSessionConfigurationCommand
                contextCmdlet, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, object[]
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    this_param.InvokeUsingCmdlet(contextCmdlet: (System.Management.Automation.Cmdlet)contextCmdlet, useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 109361, 110243);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1589_110283_110290()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 110283, 110290);
                    return return_v;
                }


                object
                f_1589_110283_110310(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.DollarErrorVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 110283, 110310);
                    return return_v;
                }


                int
                f_1589_110344_110359(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 110344, 110359);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 108051, 110390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 108051, 110390);
            }
        }

        protected override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 110449, 110715);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 110513, 110616);

                System.Management.Automation.Tracing.Tracer
                tracer = f_1589_110566_110615()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 110630, 110704);

                f_1589_110630_110703(tracer, f_1589_110658_110667(this), f_1589_110669_110702(f_1589_110669_110697()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 110449, 110715);

                System.Management.Automation.Tracing.Tracer
                f_1589_110566_110615()
                {
                    var return_v = new System.Management.Automation.Tracing.Tracer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 110566, 110615);
                    return return_v;
                }


                string
                f_1589_110658_110667(Microsoft.PowerShell.Commands.UnregisterPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 110658, 110667);
                    return return_v;
                }


                System.Security.Principal.WindowsIdentity
                f_1589_110669_110697()
                {
                    var return_v = WindowsIdentity.GetCurrent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 110669, 110697);
                    return return_v;
                }


                string
                f_1589_110669_110702(System.Security.Principal.WindowsIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 110669, 110702);
                    return return_v;
                }


                int
                f_1589_110630_110703(System.Management.Automation.Tracing.Tracer
                this_param, string
                endpointName, string
                unregisteredBy)
                {
                    this_param.EndpointUnregistered(endpointName, unregisteredBy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 110630, 110703);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 110449, 110715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 110449, 110715);
            }
        }

        public UnregisterPSSessionConfigurationCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1589, 102444, 110744);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 105594, 105610);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 105815, 105974);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 106441, 106447);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 106981, 106991);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1589, 102444, 110744);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 102444, 110744);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1589, 102444, 110744);

        static System.Globalization.CultureInfo
        f_1589_107173_107201()
        {
            var return_v = CultureInfo.InvariantCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 107173, 107201);
            return return_v;
        }


        static string
        f_1589_107159_107293(System.Globalization.CultureInfo
        provider, string
        format, string
        arg0)
        {
            var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 107159, 107293);
            return return_v;
        }


        static System.Management.Automation.ScriptBlock
        f_1589_107485_107523(string
        script)
        {
            var return_v = ScriptBlock.Create(script);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 107485, 107523);
            return return_v;
        }

    }
    [Cmdlet(VerbsCommon.Get, RemotingConstants.PSSessionConfigurationNoun, HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096790")]
    [OutputType("Microsoft.PowerShell.Commands.PSSessionConfigurationCommands#PSSessionConfiguration")]
    public sealed class GetPSSessionConfigurationCommand : PSCmdlet
    {
        private const string
        getPluginSbFormat = @"
function ExtractPluginProperties([string]$pluginDir, $objectToWriteTo)
{{
    function Unescape-Xml($s) {{
        if ($s) {{
            $s = $s.Replace(""&lt;"", ""<"");
            $s = $s.Replace(""&gt;"", "">"");
            $s = $s.Replace(""&quot;"", '""');
            $s = $s.Replace(""&apos;"", ""'"");
            $s = $s.Replace(""&#39;"", ""'"");
            $s = $s.Replace(""&amp;"", ""&"");
        }}

        return $s;
    }}

    # The default comparer is case insensitive and it is supported on Core CLR.
    $h = new-object system.collections.hashtable

    function Get-Details([string]$path, [hashtable]$h) {{
        foreach ($o in (get-childitem -LiteralPath $path)) {{
            if ($o.PSIsContainer) {{
                Get-Details $o.PSPath $h
            }} else {{
                $h[$o.Name] = $o.Value
            }}
        }}
    }}

    Get-Details $pluginDir $h

    if (test-path -LiteralPath $pluginDir\InitializationParameters\SessionConfigurationData) {{
        $xscd = [xml](Unescape-xml (Unescape-xml (get-item -LiteralPath $pluginDir\InitializationParameters\SessionConfigurationData).Value))

        foreach ($o in $xscd.SessionConfigurationData.Param) {{
            if ($o.Name -eq ""PrivateData"") {{
                foreach($wf in $o.PrivateData.Param) {{
                    $h[$wf.Name] = $wf.Value
                }}
            }} else {{
                $h[$o.Name] = $o.Value
            }}
        }}
    }}

    ## Extract DISC related information
    if(test-path -LiteralPath $pluginDir\InitializationParameters\ConfigFilePath) {{
        $DISCFilePath = (get-item -LiteralPath $pluginDir\InitializationParameters\ConfigFilePath).Value

        if(test-path -LiteralPath $DISCFilePath) {{
            $DISCFileContent = get-content $DISCFilePath | out-string
            $DISCHash = invoke-expression $DISCFileContent

            foreach ($o in $DISCHash.Keys) {{
                if ($o -ne ""PowerShellVersion"") {{
                    $objectToWriteTo = $objectToWriteTo | add-member -membertype noteproperty -name $o -value $DISCHash[$o] -force -passthru
                }}
            }}
        }}
    }}

    if ($h[""SessionConfigurationData""]) {{
        $h[""SessionConfigurationData""] = Unescape-Xml (Unescape-Xml $h[""SessionConfigurationData""])
    }}

    foreach ($o in $h.Keys) {{
        if ($o -eq 'sddl') {{
            $objectToWriteTo = $objectToWriteTo | add-member -membertype noteproperty -name 'SecurityDescriptorSddl' -value $h[$o] -force -passthru
        }} else {{
            $objectToWriteTo = $objectToWriteTo | add-member -membertype noteproperty -name $o -value $h[$o] -force -passthru
        }}
    }}
}}

$shellNotErrMsgFormat = $args[1]
$force = $args[2]
$args[0] | ForEach-Object {{
    $shellsFound = 0;
    $filter = $_
    Get-ChildItem 'WSMan:\localhost\Plugin\' -Force:$force | ? {{ $_.name -like ""$filter"" }} | ForEach-Object {{
        $customPluginObject = new-object object
        $customPluginObject.pstypenames.Insert(0, '{0}')
        ExtractPluginProperties ""$($_.PSPath)"" $customPluginObject
        # This is powershell based custom shell only if its plugin dll is pwrshplugin.dll
        if (($customPluginObject.FileName) -and ($customPluginObject.FileName -match '{1}'))
        {{
            # Filter the endpoints based on the typeof PowerShell that is
            # executing the cmdlet. {1} in another location indicates that it
            # is a PowerShell 6+ endpoint
            if (!($customPluginObject.FileName -match 'system32\\{1}') -AND # WindowsPowerShell
                !($customPluginObject.FileName -match 'syswow64\\{1}'))     # WOW64 WindowsPowerShell
            {{
                # Add the PowerShell 6+ endpoint when running PowerShell 6+
                $shellsFound++
                $customPluginObject
            }}
        }}
    }} # end of foreach

    if (!$shellsFound -and !([System.Management.Automation.WildcardPattern]::ContainsWildcardCharacters($_)))
    {{
      $errMsg = $shellNotErrMsgFormat -f $_
      Write-Error $errMsg
    }}
  }}
"
        ;

        private const string
        MODULEPATH = "ModulesToImport"
        ;

        private static readonly ScriptBlock s_getPluginSb;

        static GetPSSessionConfigurationCommand()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1589, 115811, 116411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 111382, 115620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 115654, 115684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 115731, 115744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 115877, 116109);

                string
                scriptToRun = f_1589_115898_116108(f_1589_115912_115940(), getPluginSbFormat, PSSessionConfigurationCommandUtilities.PSCustomShellTypeName, RemotingConstants.PSPluginDLLName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 116281, 116329);

                s_getPluginSb = f_1589_116297_116328(scriptToRun);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 116343, 116400);

                s_getPluginSb.LanguageMode = PSLanguageMode.FullLanguage;
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1589, 115811, 116411);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 115811, 116411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 115811, 116411);
            }
        }

        [Parameter(Position = 0, Mandatory = false)]
        [ValidateNotNullOrEmpty()]
        public string[] Name { get; set; }

        [Parameter()]
        public SwitchParameter Force
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 116811, 116876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 116847, 116861);

                    return _force;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 116811, 116876);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 116735, 116969);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 116735, 116969);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 116892, 116958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 116928, 116943);

                    _force = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 116892, 116958);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 116735, 116969);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 116735, 116969);
                }
            }
        }

        private bool _force;

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 117173, 117384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 117239, 117294);

                f_1589_117239_117293();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 117308, 117373);

                f_1589_117308_117372();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 117173, 117384);

                int
                f_1589_117239_117293()
                {
                    RemotingCommandUtil.CheckRemotingCmdletPrerequisites();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 117239, 117293);
                    return 0;
                }


                int
                f_1589_117308_117372()
                {
                    PSSessionConfigurationCommandUtilities.ThrowIfNotAdministrator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 117308, 117372);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 117173, 117384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 117173, 117384);
            }
        }

        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 117443, 119035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 117507, 117600);

                f_1589_117507_117599(this, f_1589_117520_117598(f_1589_117538_117578(), getPluginSbFormat));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 117616, 117692);

                string
                csNotFoundMessageFormat = f_1589_117649_117691()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 117706, 117729);

                object
                arguments = "*"
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 117743, 117825) || true) && (f_1589_117747_117751() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 117743, 117825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 117793, 117810);

                    arguments = f_1589_117805_117809();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 117743, 117825);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 117841, 117915);

                ActionPreference
                backupPreference = f_1589_117877_117914(f_1589_117877_117884())
                ;
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 117965, 118192) || true) && (f_1589_117969_118032(f_1589_117969_118015(f_1589_117969_118000(f_1589_117969_117976()))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 117965, 118192);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 118074, 118173);

                        f_1589_118074_118081().ErrorActionPreferenceVariable = f_1589_118114_118172(f_1589_118114_118160(f_1589_118114_118145(f_1589_118114_118121())));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 117965, 118192);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 118212, 118883);

                    f_1589_118212_118882(
                                    s_getPluginSb, contextCmdlet: this, useLocalScope: true, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: f_1589_118466_118486(), input: f_1589_118516_118537(), scriptThis: f_1589_118572_118592(), args: new object[] {
                                                   arguments,
                                                   csNotFoundMessageFormat,
                                                   _force});
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1589, 118912, 119024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 118952, 119009);

                    f_1589_118952_118959().ErrorActionPreferenceVariable = backupPreference;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1589, 118912, 119024);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 117443, 119035);

                string
                f_1589_117538_117578()
                {
                    var return_v = RemotingErrorIdStrings.GcsScriptMessageV;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 117538, 117578);
                    return return_v;
                }


                string
                f_1589_117520_117598(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 117520, 117598);
                    return return_v;
                }


                int
                f_1589_117507_117599(Microsoft.PowerShell.Commands.GetPSSessionConfigurationCommand
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 117507, 117599);
                    return 0;
                }


                string
                f_1589_117649_117691()
                {
                    var return_v = RemotingErrorIdStrings.CustomShellNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 117649, 117691);
                    return return_v;
                }


                string[]
                f_1589_117747_117751()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 117747, 117751);
                    return return_v;
                }


                string[]
                f_1589_117805_117809()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 117805, 117809);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1589_117877_117884()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 117877, 117884);
                    return return_v;
                }


                System.Management.Automation.ActionPreference
                f_1589_117877_117914(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ErrorActionPreferenceVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 117877, 117914);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1589_117969_117976()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 117969, 117976);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1589_117969_118000(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 117969, 118000);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1589_117969_118015(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 117969, 118015);
                    return return_v;
                }


                bool
                f_1589_117969_118032(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.IsErrorActionSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 117969, 118032);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1589_118074_118081()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 118074, 118081);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1589_118114_118121()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 118114, 118121);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1589_118114_118145(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 118114, 118145);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1589_118114_118160(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 118114, 118160);
                    return return_v;
                }


                System.Management.Automation.ActionPreference
                f_1589_118114_118172(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.ErrorAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 118114, 118172);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_118466_118486()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 118466, 118486);
                    return return_v;
                }


                object[]
                f_1589_118516_118537()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 118516, 118537);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_118572_118592()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 118572, 118592);
                    return return_v;
                }


                int
                f_1589_118212_118882(System.Management.Automation.ScriptBlock
                this_param, Microsoft.PowerShell.Commands.GetPSSessionConfigurationCommand
                contextCmdlet, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, object[]
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    this_param.InvokeUsingCmdlet(contextCmdlet: (System.Management.Automation.Cmdlet)contextCmdlet, useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 118212, 118882);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1589_118952_118959()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 118952, 118959);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 117443, 119035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 117443, 119035);
            }
        }

        public GetPSSessionConfigurationCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1589, 110914, 119064);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 116522, 116646);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 116994, 117000);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1589, 110914, 119064);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 110914, 119064);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1589, 110914, 119064);

        static System.Globalization.CultureInfo
        f_1589_115912_115940()
        {
            var return_v = CultureInfo.InvariantCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 115912, 115940);
            return return_v;
        }


        static string
        f_1589_115898_116108(System.Globalization.CultureInfo
        provider, string
        format, string
        arg0, string
        arg1)
        {
            var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 115898, 116108);
            return return_v;
        }


        static System.Management.Automation.ScriptBlock
        f_1589_116297_116328(string
        script)
        {
            var return_v = ScriptBlock.Create(script);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 116297, 116328);
            return return_v;
        }

    }
    [Cmdlet(VerbsCommon.Set, RemotingConstants.PSSessionConfigurationNoun,
           DefaultParameterSetName = PSSessionConfigurationCommandBase.NameParameterSetName,
           SupportsShouldProcess = true,
           ConfirmImpact = ConfirmImpact.Medium, HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096901")]
    public sealed class SetPSSessionConfigurationCommand : PSSessionConfigurationCommandBase
    {
        private const string
        getSessionTypeFormat = @"(get-item 'WSMan::localhost\Plugin\{0}\InitializationParameters\sessiontype' -ErrorAction SilentlyContinue).Value"
        ;

        private const string
        getCurrentIdleTimeoutmsFormat = @"(Get-Item 'WSMan:\localhost\Plugin\{0}\Quotas\IdleTimeoutms').Value"
        ;

        private const string
        getAssemblyNameDataFormat = @"(Get-Item 'WSMan:\localhost\Plugin\{0}\InitializationParameters\assemblyname').Value"
        ;

        private const string
        getSessionConfigurationDataSbFormat = @"(Get-Item 'WSMan:\localhost\Plugin\{0}\InitializationParameters\SessionConfigurationData').Value"
        ;

        private const string
        setSessionConfigurationDataSbFormat = @"
function Set-SessionConfigurationData([string] $scd) {{
    if (test-path 'WSMan:\localhost\Plugin\{0}\InitializationParameters\" + ConfigurationDataFromXML.SESSIONCONFIGTOKEN + @"')
    {{
        set-item -WarningAction SilentlyContinue -Force 'WSMan:\localhost\Plugin\{0}\InitializationParameters\" + ConfigurationDataFromXML.SESSIONCONFIGTOKEN + @"' -Value $scd
    }}
    else
    {{
        new-item -WarningAction SilentlyContinue -path 'WSMan:\localhost\Plugin\{0}\InitializationParameters' -paramname " + ConfigurationDataFromXML.SESSIONCONFIGTOKEN + @" -paramValue $scd -Force
    }}
}}
Set-SessionConfigurationData $args[0]
"
        ;

        private const string
        setSessionConfigurationQuotaSbFormat = @"
function Set-SessionPluginQuota([hashtable] $quotas) {{
    foreach($v in $quotas.GetEnumerator()) {{
        $name = $v.Name;
        $value = $v.Value;
        if (!$value) {{
            $value = [string]::empty;
        }}

        set-item -WarningAction SilentlyContinue ('WSMan:\localhost\Plugin\{0}\Quotas\' + $name) -Value $value -confirm:$false
    }}
}}
Set-SessionPluginQuota $args[0]
"
        ;

        private const string
        setSessionConfigurationTimeoutQuotasSbFormat = @"
function Set-SessionPluginIdleTimeoutQuotas([int] $maxIdleTimeoutms, [int] $idleTimeoutms, [bool] $setMaxIdleTimeoutFirst) {{
    if ($setMaxIdleTimeoutFirst) {{
        set-item -WarningAction SilentlyContinue 'WSMan:\localhost\Plugin\{0}\Quotas\MaxIdleTimeoutms' -Value $maxIdleTimeoutms -confirm:$false
        set-item -WarningAction SilentlyContinue 'WSMan:\localhost\Plugin\{0}\Quotas\IdleTimeoutms' -Value $idleTimeoutms -confirm:$false
    }}
    else {{
        set-item -WarningAction SilentlyContinue 'WSMan:\localhost\Plugin\{0}\Quotas\IdleTimeoutms' -Value $idleTimeoutms -confirm:$false
        set-item -WarningAction SilentlyContinue 'WSMan:\localhost\Plugin\{0}\Quotas\MaxIdleTimeoutms' -Value $maxIdleTimeoutms -confirm:$false
    }}
}}
Set-SessionPluginIdleTimeoutQuotas $args[0] $args[1] $args[2]
"
        ;

        private const string
        setSessionConfigurationOptionsSbFormat = @"
function Set-SessionPluginOptions([hashtable] $options) {{
    if ($options[""UsedSharedProcess""]) {{
        $value = $options[""UseSharedProcess""];
        set-item -WarningAction SilentlyContinue 'WSMan:\localhost\Plugin\{0}\UseSharedProcess' -Value $value -confirm:$false
        $options.Remove(""UseSharedProcess"");
    }}

    foreach($v in $options.GetEnumerator()) {{
        $name = $v.Name;
        $value = $v.Value

        if (!$value) {{
            $value = 0;
        }}

        set-item -WarningAction SilentlyContinue ('WSMan:\localhost\Plugin\{0}\' + $name) -Value $value -confirm:$false
    }}
}}
Set-SessionPluginOptions $args[0]
"
        ;

        private const string
        setRunAsSbFormat = @"
function Set-RunAsCredential{{
    param (
        [string]$runAsUserName,
        [system.security.securestring]$runAsPassword
    )

    $cred = new-object System.Management.Automation.PSCredential($runAsUserName, $runAsPassword)
    set-item -WarningAction SilentlyContinue 'WSMan:\localhost\Plugin\{0}\RunAsUser' $cred -confirm:$false
}}
Set-RunAsCredential $args[0] $args[1]
"
        ;

        private const string
        setPluginSbFormat = @"
function Set-PSSessionConfiguration([PSObject]$customShellObject,
     [Array]$initParametersMap,
     [bool]$force,
     [string]$sddl,
     [bool]$isSddlSpecified,
     [bool]$shouldShowUI,
     [string]$resourceUri,
     [string]$pluginNotFoundErrorMsg,
     [string]$pluginNotPowerShellMsg,
     [string]$pluginForPowerShellCoreMsg,
     [string]$pluginForWindowsPowerShellMsg,
     [System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode]$accessMode
)
{{
   $wsmanPluginDir = 'WSMan:\localhost\Plugin'
   $pluginName = $customShellObject.Name;
   $pluginDir = Join-Path ""$wsmanPluginDir"" ""$pluginName""
   if ((!$pluginName) -or !(test-path ""$pluginDir""))
   {{
      Write-Error $pluginNotFoundErrorMsg
      return
   }}

   # check if the plugin is a PowerShell plugin
   $pluginFileNamePath = Join-Path ""$pluginDir"" 'FileName'
   if (!(test-path ""$pluginFileNamePath""))
   {{
      Write-Error $pluginNotPowerShellMsg
      return
   }}

   $pluginFileName = get-item -literalpath ""$pluginFileNamePath""
   if ((!$pluginFileName) -or ($pluginFileName.Value -notmatch '{0}'))
   {{
      Write-Error $pluginNotPowerShellMsg
      return
   }}
   else
   {{
        # Filter out WindowsPowerShell endpoints when running as PowerShell 6+
        if (($pluginFileName.Value -match 'system32\\{0}') -OR
            ($pluginFileName.Value -match 'syswow64\\{0}'))
        {{
            Write-Error $pluginForWindowsPowerShellMsg
            return
        }}
   }}

   # set Initialization Parameters
   $initParametersPath = Join-Path ""$pluginDir"" 'InitializationParameters'
   foreach($initParameterName in $initParametersMap)
   {{
        if ($customShellObject | get-member $initParameterName)
        {{
            $parampath = Join-Path ""$initParametersPath"" $initParameterName

            if (test-path $parampath)
            {{
               remove-item -path ""$parampath""
            }}

            # 0 is an accepted value for MaximumReceivedDataSizePerCommandMB and MaximumReceivedObjectSizeMB
            if (($customShellObject.$initParameterName) -or ($customShellObject.$initParameterName -eq 0))
            {{
               new-item -path ""$initParametersPath"" -paramname $initParameterName  -paramValue ""$($customShellObject.$initParameterName)"" -Force
            }}
        }}
   }}

   # sddl processing
   if ($isSddlSpecified)
   {{
       $resourcesPath = Join-Path ""$pluginDir"" 'Resources'
       Get-ChildItem -literalpath ""$resourcesPath"" | ForEach-Object {{
            $securityPath = Join-Path ""$($_.pspath)"" 'Security'
            if ((@(Get-ChildItem -literalpath ""$securityPath"")).count -gt 0)
            {{
                Get-ChildItem -literalpath ""$securityPath"" | ForEach-Object {{
                    $securityIDPath = ""$($_.pspath)""
                    remove-item -path ""$securityIDPath"" -recurse -force
                }} #end of securityPath

                if ($sddl)
                {{
                    new-item -path ""$securityPath"" -Sddl $sddl -force
                }}
            }}
            else
            {{
                if ($sddl)
                {{
                    new-item -path ""$securityPath"" -Sddl $sddl -force
                }}
            }}
       }} # end of resources
       return
   }} #end of sddl processing
   elseif ($shouldShowUI)
   {{
        $null = winrm configsddl $resourceUri
   }}

   # If accessmode is Disabled, we do not bother to check the sddl
   if ([System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode]::Disabled.Equals($accessMode))
   {{
        return
   }}

   # Construct SID for network users
   [system.security.principal.wellknownsidtype]$evst = ""NetworkSid""
   $networkSID = new-object system.security.principal.securityidentifier $evst,$null

   $resPath = Join-Path ""$pluginDir"" 'Resources'
   Get-ChildItem -literalpath ""$resPath"" | ForEach-Object {{
        $securityPath = Join-Path ""$($_.pspath)"" 'Security'
        if ((@(Get-ChildItem -literalpath ""$securityPath"")).count -gt 0)
        {{
            Get-ChildItem -literalpath ""$securityPath"" | ForEach-Object {{
                $sddlPath = Join-Path ""$($_.pspath)"" 'Sddl'
                $curSDDL = (get-item -path $sddlPath).value
                $sd = new-object system.security.accesscontrol.commonsecuritydescriptor $false,$false,$curSDDL
                $newSDDL = $null

                $disableNetworkExists = $false
                $securityIdentifierToPurge = $null
                $sd.DiscretionaryAcl | ForEach-Object {{
                    if (($_.acequalifier -eq ""accessdenied"") -and ($_.securityidentifier -match $networkSID) -and ($_.AccessMask -eq 268435456))
                    {{
                        $disableNetworkExists = $true
                        $securityIdentifierToPurge = $_.securityidentifier
                    }}
                }}

                if ([System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode]::Local.Equals($accessMode) -and !$disableNetworkExists)
                {{
                    $sd.DiscretionaryAcl.AddAccess(""deny"", $networkSID, 268435456, ""None"", ""None"")
                    $newSDDL = $sd.GetSddlForm(""all"")
                }}

                if ([System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode]::Remote.Equals($accessMode) -and $disableNetworkExists)
                {{
                    # Remove the specific ACE
                    $sd.discretionaryacl.RemoveAccessSpecific('Deny', $securityIdentifierToPurge, 268435456, 'none', 'none')

                    # if there is no discretionaryacl..add Builtin Administrators and Remote Management Users
                    # to the DACL group as this is the default WSMan behavior
                    if ($sd.discretionaryacl.count -eq 0)
                    {{
                        # Built-in administrators
                        [system.security.principal.wellknownsidtype]$bast = ""BuiltinAdministratorsSid""
                        $basid = new-object system.security.principal.securityidentifier $bast,$null
                        $sd.DiscretionaryAcl.AddAccess('Allow',$basid, 268435456, 'none', 'none')

                        # Remote Management Users, Win8+ only
                        if ([System.Environment]::OSVersion.Version -ge ""6.2.0.0"")
                        {{
                            $rmSidId = new-object system.security.principal.securityidentifier ""{2}""
                            $sd.DiscretionaryAcl.AddAccess('Allow', $rmSidId, 268435456, 'none', 'none')
                        }}

                        # Interactive Users
                        $iuSidId = new-object system.security.principal.securityidentifier ""{3}""
                        $sd.DiscretionaryAcl.AddAccess('Allow', $iuSidId, 268435456, 'none', 'none')
                    }}

                    $newSDDL = $sd.GetSddlForm(""all"")
                }}

                if ($newSDDL)
                {{
                    set-item -WarningAction SilentlyContinue -path $sddlPath -value $newSDDL -force
                }}
            }}
        }}
        else
        {{
            if (([System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode]::Local.Equals($accessMode)))
            {{
                new-item -path ""$securityPath"" -Sddl ""{1}"" -force
            }}
        }}
   }}
}}

Set-PSSessionConfiguration $args[0] $args[1] $args[2] $args[3] $args[4] $args[5] $args[6] $args[7] $args[8] $args[9] $args[10] $args[11]
"
        ;

        private const string
        initParamFormat = @"<Param Name='{0}' Value='{1}' />"
        ;

        private const string
        privateDataFormat = @"<Param Name='PrivateData'>{0}</Param>"
        ;

        private const string
        SessionConfigDataFormat = @"<SessionConfigurationData>{0}</SessionConfigurationData>"
        ;

        private const string
        UseSharedProcessToken = "UseSharedProcess"
        ;

        private const string
        AllowRemoteAccessToken = "Enabled"
        ;

        private static readonly ScriptBlock s_setPluginSb;

        private static readonly string[] s_initParametersMap;

        private bool _isErrorReported;

        private Hashtable _configTable;

        private string _configFilePath;

        private string _gmsaAccount;

        private string _configSddl;

        static SetPSSessionConfigurationCommand()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1589, 133125, 133762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 119796, 119935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 119967, 120069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 120101, 120216);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 120248, 120385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 120417, 121106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 121140, 121593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 121627, 122507);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 122541, 123262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 123296, 123710);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 123744, 131565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 131597, 131650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 131682, 131742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 131776, 131861);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 131895, 131937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 131969, 132003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 132052, 132065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 132181, 132855);
                s_initParametersMap = new string[] {
            ConfigurationDataFromXML.APPBASETOKEN,
            ConfigurationDataFromXML.ASSEMBLYTOKEN,
            ConfigurationDataFromXML.SHELLCONFIGTYPETOKEN,
            ConfigurationDataFromXML.STARTUPSCRIPTTOKEN,
            ConfigurationDataFromXML.MAXRCVDOBJSIZETOKEN,
            ConfigurationDataFromXML.MAXRCVDCMDSIZETOKEN,
            ConfigurationDataFromXML.THREADOPTIONSTOKEN,
            ConfigurationDataFromXML.THREADAPTSTATETOKEN,
            ConfigurationDataFromXML.PSVERSIONTOKEN,
            ConfigurationDataFromXML.MAXPSVERSIONTOKEN,
            ConfigurationDataFromXML.SESSIONCONFIGTOKEN,
        };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 133191, 133225);

                string
                localSDDL = f_1589_133210_133224()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 133239, 133454);

                string
                setPluginScript = f_1589_133264_133453(f_1589_133278_133306(), setPluginSbFormat, RemotingConstants.PSPluginDLLName, localSDDL, RemoteManagementUsersSID, InteractiveUsersSID)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 133628, 133680);

                s_setPluginSb = f_1589_133644_133679(setPluginScript);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 133694, 133751);

                s_setPluginSb.LanguageMode = PSLanguageMode.FullLanguage;
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1589, 133125, 133762);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 133125, 133762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 133125, 133762);
            }
        }

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 134096, 139395);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 134162, 134494) || true) && (isSddlSpecified && (DynAbs.Tracing.TraceSender.Expression_True(1589, 134166, 134200) && showUISpecified))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 134162, 134494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 134234, 134414);

                    string
                    message = f_1589_134251_134413(f_1589_134269_134316(), "SecurityDescriptorSddl", "ShowSecurityDescriptorUI")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 134432, 134479);

                    throw f_1589_134438_134478(message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 134162, 134494);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 134510, 134667) || true) && (isRunAsCredentialSpecified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 134510, 134667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 134574, 134652);

                    f_1589_134574_134651(this, f_1589_134587_134650());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 134510, 134667);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 134757, 136729) || true) && (f_1589_134761_134765() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 134757, 136729);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 134807, 134836);

                    ProviderInfo
                    provider = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 134854, 134872);

                    PSDriveInfo
                    drive
                    = default(PSDriveInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 134890, 134993);

                    _configFilePath = f_1589_134908_134992(f_1589_134908_134925(f_1589_134908_134920()), f_1589_134962_134966(), out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 135013, 135031);

                    string
                    scriptName
                    = default(string);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 135049, 135159);

                    ExternalScriptInfo
                    scriptInfo = f_1589_135081_135158(f_1589_135112_135124(this), _configFilePath, out scriptName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 135177, 135243);

                    _configTable = f_1589_135192_135242(f_1589_135217_135229(this), scriptInfo);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 135263, 135987) || true) && (!isSddlSpecified)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 135263, 135987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 135325, 135343);

                        ErrorRecord
                        error
                        = default(ErrorRecord);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 135365, 135560);

                        _configSddl = f_1589_135379_135559(_configTable, f_1589_135512_135522(), out error);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 135582, 135690) || true) && (error != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 135582, 135690);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 135649, 135667);

                            f_1589_135649_135666(this, error);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 135582, 135690);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 135714, 135968) || true) && (!f_1589_135719_135752(_configSddl))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 135714, 135968);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 135859, 135882);

                            isSddlSpecified = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 135908, 135945);

                            SecurityDescriptorSddl = _configSddl;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 135714, 135968);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 135263, 135987);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 136007, 136317) || true) && (f_1589_136011_136076(_configTable, ConfigFileConstants.RunAsVirtualAccount))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 136007, 136317);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 136118, 136235);

                        this.RunAsVirtualAccount = f_1589_136145_136234(f_1589_136180_136233(_configTable, ConfigFileConstants.RunAsVirtualAccount));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 136257, 136298);

                        this.RunAsVirtualAccountSpecified = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 136007, 136317);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 136337, 136714) || true) && (f_1589_136341_136412(_configTable, ConfigFileConstants.RunAsVirtualAccountGroups))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 136337, 136714);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 136454, 136695);

                        this.RunAsVirtualAccountGroups = f_1589_136487_136694(f_1589_136587_136693(f_1589_136633_136692(_configTable, ConfigFileConstants.RunAsVirtualAccountGroups)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 136337, 136714);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 134757, 136729);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 136745, 139184) || true) && (isSddlSpecified && (DynAbs.Tracing.TraceSender.Expression_True(1589, 136749, 136787) && accessModeSpecified))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 136745, 139184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 136915, 137002);

                    CommonSecurityDescriptor
                    descriptor = f_1589_136953_137001(false, false, sddl)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 137020, 137120);

                    SecurityIdentifier
                    networkSidIdentifier = f_1589_137062_137119(WellKnownSidType.NetworkSid, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 137138, 137172);

                    bool
                    networkDenyAllExists = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 137190, 137577);
                        foreach (CommonAce ace in f_1589_137216_137243_I(f_1589_137216_137243(descriptor)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 137190, 137577);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 137285, 137558) || true) && (f_1589_137289_137339(f_1589_137289_137305(ace), AceQualifier.AccessDenied) && (DynAbs.Tracing.TraceSender.Expression_True(1589, 137289, 137394) && f_1589_137343_137394(f_1589_137343_137365(ace), networkSidIdentifier)) && (DynAbs.Tracing.TraceSender.Expression_True(1589, 137289, 137425) && f_1589_137398_137412(ace) == 268435456))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 137285, 137558);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 137475, 137503);

                                networkDenyAllExists = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1589, 137529, 137535);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 137285, 137558);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 137190, 137577);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1589, 1, 388);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1589, 1, 388);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 137597, 139169);

                    switch (f_1589_137605_137615())
                    {

                        case PSSessionConfigurationAccessMode.Local:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 137597, 139169);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 137727, 138065) || true) && (!networkDenyAllExists)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 137727, 138065);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 137810, 137951);

                                f_1589_137810_137950(f_1589_137810_137837(descriptor), AccessControlType.Deny, networkSidIdentifier, 268435456, InheritanceFlags.None, PropagationFlags.None);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 137981, 138038);

                                sddl = f_1589_137988_138037(descriptor, AccessControlSections.All);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 137727, 138065);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1589, 138093, 138099);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 137597, 139169);

                        case PSSessionConfigurationAccessMode.Remote:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 137597, 139169);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 138192, 139015) || true) && (networkDenyAllExists)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 138192, 139015);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 138330, 138482);

                                f_1589_138330_138481(f_1589_138330_138357(descriptor), AccessControlType.Deny, networkSidIdentifier, 268435456, InheritanceFlags.None, PropagationFlags.None);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 138639, 138988) || true) && (f_1589_138643_138676(f_1589_138643_138670(descriptor)) == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 138639, 138988);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 138747, 138770);

                                    sddl = f_1589_138754_138769();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 138639, 138988);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 138639, 138988);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 138900, 138957);

                                    sddl = f_1589_138907_138956(descriptor, AccessControlSections.All);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 138639, 138988);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 138192, 139015);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1589, 139043, 139049);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 137597, 139169);

                        case PSSessionConfigurationAccessMode.Disabled:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 137597, 139169);
                            DynAbs.Tracing.TraceSender.TraceBreak(1589, 139144, 139150);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 137597, 139169);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 136745, 139184);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 139250, 139305);

                f_1589_139250_139304();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 139319, 139384);

                f_1589_139319_139383();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 134096, 139395);

                string
                f_1589_134269_134316()
                {
                    var return_v = RemotingErrorIdStrings.ShowUIAndSDDLCannotExist;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 134269, 134316);
                    return return_v;
                }


                string
                f_1589_134251_134413(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 134251, 134413);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1589_134438_134478(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 134438, 134478);
                    return return_v;
                }


                string
                f_1589_134587_134650()
                {
                    var return_v = RemotingErrorIdStrings.RunAsSessionConfigurationSecurityWarning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 134587, 134650);
                    return return_v;
                }


                int
                f_1589_134574_134651(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param, string
                text)
                {
                    this_param.WriteWarning(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 134574, 134651);
                    return 0;
                }


                string
                f_1589_134761_134765()
                {
                    var return_v = Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 134761, 134765);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1589_134908_134920()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 134908, 134920);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1589_134908_134925(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 134908, 134925);
                    return return_v;
                }


                string
                f_1589_134962_134966()
                {
                    var return_v = Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 134962, 134966);
                    return return_v;
                }


                string
                f_1589_134908_134992(System.Management.Automation.PathIntrinsics
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.GetUnresolvedProviderPathFromPSPath(path, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 134908, 134992);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1589_135112_135124(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 135112, 135124);
                    return return_v;
                }


                System.Management.Automation.ExternalScriptInfo
                f_1589_135081_135158(System.Management.Automation.ExecutionContext
                context, string
                fileName, out string
                scriptName)
                {
                    var return_v = DISCUtils.GetScriptInfoForFile(context, fileName, out scriptName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 135081, 135158);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1589_135217_135229(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 135217, 135229);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1589_135192_135242(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.ExternalScriptInfo
                scriptInfo)
                {
                    var return_v = DISCUtils.LoadConfigFile(context, scriptInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 135192, 135242);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode
                f_1589_135512_135522()
                {
                    var return_v = AccessMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 135512, 135522);
                    return return_v;
                }


                string
                f_1589_135379_135559(System.Collections.Hashtable
                configTable, System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode
                accessMode, out System.Management.Automation.ErrorRecord
                error)
                {
                    var return_v = PSSessionConfigurationCommandUtilities.ComputeSDDLFromConfiguration(configTable, accessMode, out error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 135379, 135559);
                    return return_v;
                }


                int
                f_1589_135649_135666(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 135649, 135666);
                    return 0;
                }


                bool
                f_1589_135719_135752(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 135719, 135752);
                    return return_v;
                }


                bool
                f_1589_136011_136076(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 136011, 136076);
                    return return_v;
                }


                object
                f_1589_136180_136233(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 136180, 136233);
                    return return_v;
                }


                bool
                f_1589_136145_136234(object
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<bool>(valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 136145, 136234);
                    return return_v;
                }


                bool
                f_1589_136341_136412(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 136341, 136412);
                    return return_v;
                }


                object
                f_1589_136633_136692(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 136633, 136692);
                    return return_v;
                }


                string[]
                f_1589_136587_136693(object
                hashObj)
                {
                    var return_v = DISCPowerShellConfiguration.TryGetStringArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 136587, 136693);
                    return return_v;
                }


                string
                f_1589_136487_136694(string[]
                groups)
                {
                    var return_v = PSSessionConfigurationCommandUtilities.GetRunAsVirtualAccountGroupsString(groups);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 136487, 136694);
                    return return_v;
                }


                System.Security.AccessControl.CommonSecurityDescriptor
                f_1589_136953_137001(bool
                isContainer, bool
                isDS, string
                sddlForm)
                {
                    var return_v = new System.Security.AccessControl.CommonSecurityDescriptor(isContainer, isDS, sddlForm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 136953, 137001);
                    return return_v;
                }


                System.Security.Principal.SecurityIdentifier
                f_1589_137062_137119(System.Security.Principal.WellKnownSidType
                sidType, System.Security.Principal.SecurityIdentifier
                domainSid)
                {
                    var return_v = new System.Security.Principal.SecurityIdentifier(sidType, domainSid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 137062, 137119);
                    return return_v;
                }


                System.Security.AccessControl.DiscretionaryAcl
                f_1589_137216_137243(System.Security.AccessControl.CommonSecurityDescriptor
                this_param)
                {
                    var return_v = this_param.DiscretionaryAcl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 137216, 137243);
                    return return_v;
                }


                System.Security.AccessControl.AceQualifier
                f_1589_137289_137305(System.Security.AccessControl.CommonAce
                this_param)
                {
                    var return_v = this_param.AceQualifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 137289, 137305);
                    return return_v;
                }


                bool
                f_1589_137289_137339(System.Security.AccessControl.AceQualifier
                this_param, System.Security.AccessControl.AceQualifier
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 137289, 137339);
                    return return_v;
                }


                System.Security.Principal.SecurityIdentifier
                f_1589_137343_137365(System.Security.AccessControl.CommonAce
                this_param)
                {
                    var return_v = this_param.SecurityIdentifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 137343, 137365);
                    return return_v;
                }


                bool
                f_1589_137343_137394(System.Security.Principal.SecurityIdentifier
                this_param, System.Security.Principal.SecurityIdentifier
                sid)
                {
                    var return_v = this_param.Equals(sid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 137343, 137394);
                    return return_v;
                }


                int
                f_1589_137398_137412(System.Security.AccessControl.CommonAce
                this_param)
                {
                    var return_v = this_param.AccessMask;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 137398, 137412);
                    return return_v;
                }


                System.Security.AccessControl.DiscretionaryAcl
                f_1589_137216_137243_I(System.Security.AccessControl.DiscretionaryAcl
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 137216, 137243);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode
                f_1589_137605_137615()
                {
                    var return_v = AccessMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 137605, 137615);
                    return return_v;
                }


                System.Security.AccessControl.DiscretionaryAcl
                f_1589_137810_137837(System.Security.AccessControl.CommonSecurityDescriptor
                this_param)
                {
                    var return_v = this_param.DiscretionaryAcl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 137810, 137837);
                    return return_v;
                }


                int
                f_1589_137810_137950(System.Security.AccessControl.DiscretionaryAcl
                this_param, System.Security.AccessControl.AccessControlType
                accessType, System.Security.Principal.SecurityIdentifier
                sid, int
                accessMask, System.Security.AccessControl.InheritanceFlags
                inheritanceFlags, System.Security.AccessControl.PropagationFlags
                propagationFlags)
                {
                    this_param.AddAccess(accessType, sid, accessMask, inheritanceFlags, propagationFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 137810, 137950);
                    return 0;
                }


                string
                f_1589_137988_138037(System.Security.AccessControl.CommonSecurityDescriptor
                this_param, System.Security.AccessControl.AccessControlSections
                includeSections)
                {
                    var return_v = this_param.GetSddlForm(includeSections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 137988, 138037);
                    return return_v;
                }


                System.Security.AccessControl.DiscretionaryAcl
                f_1589_138330_138357(System.Security.AccessControl.CommonSecurityDescriptor
                this_param)
                {
                    var return_v = this_param.DiscretionaryAcl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 138330, 138357);
                    return return_v;
                }


                int
                f_1589_138330_138481(System.Security.AccessControl.DiscretionaryAcl
                this_param, System.Security.AccessControl.AccessControlType
                accessType, System.Security.Principal.SecurityIdentifier
                sid, int
                accessMask, System.Security.AccessControl.InheritanceFlags
                inheritanceFlags, System.Security.AccessControl.PropagationFlags
                propagationFlags)
                {
                    this_param.RemoveAccessSpecific(accessType, sid, accessMask, inheritanceFlags, propagationFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 138330, 138481);
                    return 0;
                }


                System.Security.AccessControl.DiscretionaryAcl
                f_1589_138643_138670(System.Security.AccessControl.CommonSecurityDescriptor
                this_param)
                {
                    var return_v = this_param.DiscretionaryAcl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 138643, 138670);
                    return return_v;
                }


                int
                f_1589_138643_138676(System.Security.AccessControl.DiscretionaryAcl
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 138643, 138676);
                    return return_v;
                }


                string
                f_1589_138754_138769()
                {
                    var return_v = GetRemoteSddl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 138754, 138769);
                    return return_v;
                }


                string
                f_1589_138907_138956(System.Security.AccessControl.CommonSecurityDescriptor
                this_param, System.Security.AccessControl.AccessControlSections
                includeSections)
                {
                    var return_v = this_param.GetSddlForm(includeSections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 138907, 138956);
                    return return_v;
                }


                int
                f_1589_139250_139304()
                {
                    RemotingCommandUtil.CheckRemotingCmdletPrerequisites();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 139250, 139304);
                    return 0;
                }


                int
                f_1589_139319_139383()
                {
                    PSSessionConfigurationCommandUtilities.ThrowIfNotAdministrator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 139319, 139383);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 134096, 139395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 134096, 139395);
            }
        }

        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 139454, 146476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 139518, 139611);

                f_1589_139518_139610(this, f_1589_139531_139609(f_1589_139549_139589(), setPluginSbFormat));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 139627, 139760);

                string
                shouldProcessAction = f_1589_139656_139759(f_1589_139674_139718(), f_1589_139737_139758(f_1589_139737_139753(this)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 139774, 139801);

                string
                shouldProcessTarget
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 139815, 140218) || true) && (!isSddlSpecified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 139815, 140218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 139869, 139987);

                    shouldProcessTarget = f_1589_139891_139986(f_1589_139909_139953(), f_1589_139976_139985(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 139815, 140218);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 139815, 140218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 140053, 140203);

                    shouldProcessTarget = f_1589_140075_140202(f_1589_140093_140142(), f_1589_140165_140174(this), sddl);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 139815, 140218);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 140234, 140533) || true) && (!noRestart && (DynAbs.Tracing.TraceSender.Expression_True(1589, 140238, 140258) && !force))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 140234, 140533);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 140292, 140416);

                    string
                    action = f_1589_140308_140415(f_1589_140326_140370(), f_1589_140393_140414(f_1589_140393_140409(this)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 140434, 140518);

                    f_1589_140434_140517(this, f_1589_140447_140516(f_1589_140465_140507(), action));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 140234, 140533);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 140549, 140675) || true) && (!force && (DynAbs.Tracing.TraceSender.Expression_True(1589, 140553, 140619) && !f_1589_140564_140619(this, shouldProcessTarget, shouldProcessAction)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 140549, 140675);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 140653, 140660);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 140549, 140675);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 140756, 141504) || true) && (isUseSharedProcessSpecified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 140756, 141504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 140821, 141489);
                    using (System.Management.Automation.PowerShell
                    ps = f_1589_140873_140921()
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 140963, 141097);

                        f_1589_140963_141096(ps, f_1589_140976_141095(f_1589_140990_141018(), getSessionTypeFormat, f_1589_141042_141094(f_1589_141089_141093())));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 141119, 141218);

                        Collection<PSObject>
                        psObjectCollection = f_1589_141161_141193(ps, new object[] { f_1589_141186_141190() }) as Collection<PSObject>
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 141240, 141470) || true) && (psObjectCollection == null || (DynAbs.Tracing.TraceSender.Expression_False(1589, 141244, 141303) || f_1589_141274_141298(psObjectCollection) != 1))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 141240, 141470);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 141353, 141447);

                            f_1589_141353_141446(false, "This should never happen. ps.Invoke always return a Collection<PSObject>");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 141240, 141470);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1589, 140821, 141489);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 140756, 141504);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 141574, 142612) || true) && (_configTable != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 141574, 142612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 141632, 141662);

                    Guid
                    sessionGuid = Guid.Empty
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 141741, 141932) || true) && (f_1589_141745_141795(_configTable, ConfigFileConstants.Guid))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 141741, 141932);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 141837, 141913);

                        sessionGuid = Guid.Parse(f_1589_141862_141911(f_1589_141862_141900(_configTable, ConfigFileConstants.Guid)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 141741, 141932);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 142015, 142208) || true) && (f_1589_142019_142076(_configTable, ConfigFileConstants.GMSAAccount))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 142015, 142208);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 142118, 142189);

                        _gmsaAccount = f_1589_142133_142178(_configTable, ConfigFileConstants.GMSAAccount) as string;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 142015, 142208);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 142228, 142426);

                    string
                    destPath = f_1589_142246_142425(f_1589_142269_142299(), "SessionConfig", shellName + "_" + sessionGuid.ToString() + StringLiterals.PowerShellDISCFileExtension)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 142554, 142597);

                    f_1589_142554_142596(_configFilePath, destPath, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 141574, 142612);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 142628, 142732);

                string
                shellNotFoundErrorMsg = f_1589_142659_142731(f_1589_142677_142719(), shellName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 142746, 142860);

                string
                shellNotPowerShellMsg = f_1589_142777_142859(f_1589_142795_142847(), shellName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 142874, 143001);

                string
                shellForPowerShellCoreMsg = f_1589_142909_143000(f_1589_142927_142988(), shellName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 143015, 143147);

                string
                shellForWindowsPowerShellMsg = f_1589_143053_143146(f_1589_143071_143134(), shellName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 143221, 143282);

                PSObject
                propertiesToUpdate = f_1589_143251_143281(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 143377, 143438);

                ArrayList
                errorList = (ArrayList)f_1589_143410_143437(f_1589_143410_143417())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 143452, 143491);

                int
                errorCountBefore = f_1589_143475_143490(errorList)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 143505, 144825);

                f_1589_143505_144824(s_setPluginSb, contextCmdlet: this, useLocalScope: true, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: f_1589_143743_143763(), input: f_1589_143789_143810(), scriptThis: f_1589_143841_143861(), args: new object[] {
                                               propertiesToUpdate,
                                               s_initParametersMap,
                                               force,
                                               sddl,
                                               isSddlSpecified,
f_1589_144260_144284().ToBool(),
                                               WSManNativeApi.ResourceURIPrefix + shellName,
                                               shellNotFoundErrorMsg,
                                               shellNotPowerShellMsg,
                                               shellForPowerShellCoreMsg,
                                               shellForWindowsPowerShellMsg,
(DynAbs.Tracing.TraceSender.Conditional_F1(1589, 144732, 144751)||((                                               accessModeSpecified &&DynAbs.Tracing.TraceSender.Conditional_F2(1589, 144754, 144764))||DynAbs.Tracing.TraceSender.Conditional_F3(1589, 144767, 144808)))?f_1589_144754_144764():PSSessionConfigurationAccessMode.Disabled,
           });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 144841, 144892);

                errorList = (ArrayList)f_1589_144864_144891(f_1589_144864_144871());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 144908, 145044) || true) && (f_1589_144912_144927(errorList) > errorCountBefore)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 144908, 145044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 144980, 145004);

                    _isErrorReported = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 145022, 145029);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 144908, 145044);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 145060, 145097);

                f_1589_145060_145096(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 145113, 145249) || true) && (f_1589_145117_145132(errorList) > errorCountBefore)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 145113, 145249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 145185, 145209);

                    _isErrorReported = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 145227, 145234);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 145113, 145249);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 145265, 145277);

                f_1589_145265_145276(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 145293, 145429) || true) && (f_1589_145297_145312(errorList) > errorCountBefore)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 145293, 145429);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 145365, 145389);

                    _isErrorReported = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 145407, 145414);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 145293, 145429);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 145445, 145456);

                f_1589_145445_145455(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 145472, 145608) || true) && (f_1589_145476_145491(errorList) > errorCountBefore)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 145472, 145608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 145544, 145568);

                    _isErrorReported = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 145586, 145593);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 145472, 145608);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 145624, 145644);

                f_1589_145624_145643(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 145660, 145796) || true) && (f_1589_145664_145679(errorList) > errorCountBefore)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 145660, 145796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 145732, 145756);

                    _isErrorReported = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 145774, 145781);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 145660, 145796);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 145921, 146132) || true) && (isRunAsCredentialSpecified || (DynAbs.Tracing.TraceSender.Expression_False(1589, 145925, 145983) || f_1589_145955_145983()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 145921, 146132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 146017, 146117);

                    f_1589_146017_146116(f_1589_146087_146115());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 145921, 146132);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 146148, 146284) || true) && (f_1589_146152_146167(errorList) > errorCountBefore)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 146148, 146284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 146220, 146244);

                    _isErrorReported = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 146262, 146269);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 146148, 146284);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 146300, 146313);

                f_1589_146300_146312(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 146329, 146465) || true) && (f_1589_146333_146348(errorList) > errorCountBefore)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 146329, 146465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 146401, 146425);

                    _isErrorReported = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 146443, 146450);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 146329, 146465);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 139454, 146476);

                string
                f_1589_139549_139589()
                {
                    var return_v = RemotingErrorIdStrings.ScsScriptMessageV;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 139549, 139589);
                    return return_v;
                }


                string
                f_1589_139531_139609(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 139531, 139609);
                    return return_v;
                }


                int
                f_1589_139518_139610(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 139518, 139610);
                    return 0;
                }


                string
                f_1589_139674_139718()
                {
                    var return_v = RemotingErrorIdStrings.CSShouldProcessAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 139674, 139718);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1589_139737_139753(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 139737, 139753);
                    return return_v;
                }


                string
                f_1589_139737_139758(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 139737, 139758);
                    return return_v;
                }


                string
                f_1589_139656_139759(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 139656, 139759);
                    return return_v;
                }


                string
                f_1589_139909_139953()
                {
                    var return_v = RemotingErrorIdStrings.CSShouldProcessTarget;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 139909, 139953);
                    return return_v;
                }


                string
                f_1589_139976_139985(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 139976, 139985);
                    return return_v;
                }


                string
                f_1589_139891_139986(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 139891, 139986);
                    return return_v;
                }


                string
                f_1589_140093_140142()
                {
                    var return_v = RemotingErrorIdStrings.ScsShouldProcessTargetSDDL;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 140093, 140142);
                    return return_v;
                }


                string
                f_1589_140165_140174(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 140165, 140174);
                    return return_v;
                }


                string
                f_1589_140075_140202(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 140075, 140202);
                    return return_v;
                }


                string
                f_1589_140326_140370()
                {
                    var return_v = RemotingErrorIdStrings.CSShouldProcessAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 140326, 140370);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1589_140393_140409(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 140393, 140409);
                    return return_v;
                }


                string
                f_1589_140393_140414(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 140393, 140414);
                    return return_v;
                }


                string
                f_1589_140308_140415(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 140308, 140415);
                    return return_v;
                }


                string
                f_1589_140465_140507()
                {
                    var return_v = RemotingErrorIdStrings.WinRMRestartWarning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 140465, 140507);
                    return return_v;
                }


                string
                f_1589_140447_140516(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 140447, 140516);
                    return return_v;
                }


                int
                f_1589_140434_140517(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param, string
                text)
                {
                    this_param.WriteWarning(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 140434, 140517);
                    return 0;
                }


                bool
                f_1589_140564_140619(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param, string
                target, string
                action)
                {
                    var return_v = this_param.ShouldProcess(target, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 140564, 140619);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1589_140873_140921()
                {
                    var return_v = System.Management.Automation.PowerShell.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 140873, 140921);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_140990_141018()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 140990, 141018);
                    return return_v;
                }


                string
                f_1589_141089_141093()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 141089, 141093);
                    return return_v;
                }


                string
                f_1589_141042_141094(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 141042, 141094);
                    return return_v;
                }


                string
                f_1589_140976_141095(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 140976, 141095);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1589_140963_141096(System.Management.Automation.PowerShell
                this_param, string
                script)
                {
                    var return_v = this_param.AddScript(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 140963, 141096);
                    return return_v;
                }


                string
                f_1589_141186_141190()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 141186, 141190);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1589_141161_141193(System.Management.Automation.PowerShell
                this_param, object[]
                input)
                {
                    var return_v = this_param.Invoke((System.Collections.IEnumerable)input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 141161, 141193);
                    return return_v;
                }


                int
                f_1589_141274_141298(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 141274, 141298);
                    return return_v;
                }


                int
                f_1589_141353_141446(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 141353, 141446);
                    return 0;
                }


                bool
                f_1589_141745_141795(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 141745, 141795);
                    return return_v;
                }


                object
                f_1589_141862_141900(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 141862, 141900);
                    return return_v;
                }


                string?
                f_1589_141862_141911(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 141862, 141911);
                    return return_v;
                }


                bool
                f_1589_142019_142076(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 142019, 142076);
                    return return_v;
                }


                object
                f_1589_142133_142178(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 142133, 142178);
                    return return_v;
                }


                string
                f_1589_142269_142299()
                {
                    var return_v = Utils.DefaultPowerShellAppBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 142269, 142299);
                    return return_v;
                }


                string
                f_1589_142246_142425(string
                path1, string
                path2, string
                path3)
                {
                    var return_v = System.IO.Path.Combine(path1, path2, path3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 142246, 142425);
                    return return_v;
                }


                int
                f_1589_142554_142596(string
                sourceFileName, string
                destFileName, bool
                overwrite)
                {
                    File.Copy(sourceFileName, destFileName, overwrite);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 142554, 142596);
                    return 0;
                }


                string
                f_1589_142677_142719()
                {
                    var return_v = RemotingErrorIdStrings.CSCmdsShellNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 142677, 142719);
                    return return_v;
                }


                string
                f_1589_142659_142731(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 142659, 142731);
                    return return_v;
                }


                string
                f_1589_142795_142847()
                {
                    var return_v = RemotingErrorIdStrings.CSCmdsShellNotPowerShellBased;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 142795, 142847);
                    return return_v;
                }


                string
                f_1589_142777_142859(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 142777, 142859);
                    return return_v;
                }


                string
                f_1589_142927_142988()
                {
                    var return_v = RemotingErrorIdStrings.CSCmdsPowerShellCoreShellNotModifiable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 142927, 142988);
                    return return_v;
                }


                string
                f_1589_142909_143000(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 142909, 143000);
                    return return_v;
                }


                string
                f_1589_143071_143134()
                {
                    var return_v = RemotingErrorIdStrings.CSCmdsWindowsPowerShellCoreNotModifiable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 143071, 143134);
                    return return_v;
                }


                string
                f_1589_143053_143146(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 143053, 143146);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_143251_143281(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.ConstructPropertiesForUpdate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 143251, 143281);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1589_143410_143417()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 143410, 143417);
                    return return_v;
                }


                object
                f_1589_143410_143437(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.DollarErrorVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 143410, 143437);
                    return return_v;
                }


                int
                f_1589_143475_143490(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 143475, 143490);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_143743_143763()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 143743, 143763);
                    return return_v;
                }


                object[]
                f_1589_143789_143810()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 143789, 143810);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_143841_143861()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 143841, 143861);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1589_144260_144284()
                {
                    var return_v = ShowSecurityDescriptorUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 144260, 144284);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode
                f_1589_144754_144764()
                {
                    var return_v = AccessMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 144754, 144764);
                    return return_v;
                }


                int
                f_1589_143505_144824(System.Management.Automation.ScriptBlock
                this_param, Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                contextCmdlet, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, object[]
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    this_param.InvokeUsingCmdlet(contextCmdlet: (System.Management.Automation.Cmdlet)contextCmdlet, useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 143505, 144824);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1589_144864_144871()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 144864, 144871);
                    return return_v;
                }


                object
                f_1589_144864_144891(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.DollarErrorVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 144864, 144891);
                    return return_v;
                }


                int
                f_1589_144912_144927(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 144912, 144927);
                    return return_v;
                }


                int
                f_1589_145060_145096(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param)
                {
                    this_param.SetSessionConfigurationTypeOptions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 145060, 145096);
                    return 0;
                }


                int
                f_1589_145117_145132(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 145117, 145132);
                    return return_v;
                }


                int
                f_1589_145265_145276(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param)
                {
                    this_param.SetQuotas();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 145265, 145276);
                    return 0;
                }


                int
                f_1589_145297_145312(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 145297, 145312);
                    return return_v;
                }


                int
                f_1589_145445_145455(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param)
                {
                    this_param.SetRunAs();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 145445, 145455);
                    return 0;
                }


                int
                f_1589_145476_145491(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 145476, 145491);
                    return return_v;
                }


                int
                f_1589_145624_145643(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param)
                {
                    this_param.SetVirtualAccount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 145624, 145643);
                    return 0;
                }


                int
                f_1589_145664_145679(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 145664, 145679);
                    return return_v;
                }


                bool
                f_1589_145955_145983()
                {
                    var return_v = RunAsVirtualAccountSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 145955, 145983);
                    return return_v;
                }


                bool
                f_1589_146087_146115()
                {
                    var return_v = RunAsVirtualAccountSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 146087, 146115);
                    return return_v;
                }


                int
                f_1589_146017_146116(bool
                forVirtualAccount)
                {
                    PSSessionConfigurationCommandUtilities.MoveWinRmToIsolatedServiceHost(forVirtualAccount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 146017, 146116);
                    return 0;
                }


                int
                f_1589_146152_146167(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 146152, 146167);
                    return return_v;
                }


                int
                f_1589_146300_146312(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param)
                {
                    this_param.SetOptions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 146300, 146312);
                    return 0;
                }


                int
                f_1589_146333_146348(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 146333, 146348);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 139454, 146476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 139454, 146476);
            }
        }

        private void SetRunAs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 146488, 147647);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 146536, 146788) || true) && (this.runAsCredential == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 146536, 146788);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 146602, 146653) || true) && (f_1589_146606_146640(_gmsaAccount))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 146602, 146653);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 146644, 146651);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 146602, 146653);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 146673, 146773);

                    runAsCredential = f_1589_146691_146772(_gmsaAccount);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 146536, 146788);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 146804, 146991);

                ScriptBlock
                setRunAsSbFormatSb = f_1589_146837_146990(f_1589_146874_146989(f_1589_146888_146916(), setRunAsSbFormat, f_1589_146936_146988(f_1589_146983_146987())))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 147005, 147067);

                setRunAsSbFormatSb.LanguageMode = PSLanguageMode.FullLanguage;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 147083, 147636);

                f_1589_147083_147635(
                            setRunAsSbFormatSb, contextCmdlet: this, useLocalScope: true, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: f_1589_147334_147354(), input: f_1589_147382_147403(), scriptThis: f_1589_147436_147456(), args: new object[] {
f_1589_147527_147551(runAsCredential),
f_1589_147582_147606(runAsCredential),
                                        });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 146488, 147647);

                bool
                f_1589_146606_146640(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 146606, 146640);
                    return return_v;
                }


                System.Management.Automation.PSCredential
                f_1589_146691_146772(string
                gmsaAccount)
                {
                    var return_v = PSSessionConfigurationCommandUtilities.CreateGMSAAccountCredentials(gmsaAccount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 146691, 146772);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_146888_146916()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 146888, 146916);
                    return return_v;
                }


                string
                f_1589_146983_146987()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 146983, 146987);
                    return return_v;
                }


                string
                f_1589_146936_146988(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 146936, 146988);
                    return return_v;
                }


                string
                f_1589_146874_146989(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 146874, 146989);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1589_146837_146990(string
                script)
                {
                    var return_v = ScriptBlock.Create(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 146837, 146990);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_147334_147354()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 147334, 147354);
                    return return_v;
                }


                object[]
                f_1589_147382_147403()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 147382, 147403);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_147436_147456()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 147436, 147456);
                    return return_v;
                }


                string
                f_1589_147527_147551(System.Management.Automation.PSCredential
                this_param)
                {
                    var return_v = this_param.UserName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 147527, 147551);
                    return return_v;
                }


                System.Security.SecureString
                f_1589_147582_147606(System.Management.Automation.PSCredential
                this_param)
                {
                    var return_v = this_param.Password;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 147582, 147606);
                    return return_v;
                }


                int
                f_1589_147083_147635(System.Management.Automation.ScriptBlock
                this_param, Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                contextCmdlet, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, object[]
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    this_param.InvokeUsingCmdlet(contextCmdlet: (System.Management.Automation.Cmdlet)contextCmdlet, useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 147083, 147635);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 146488, 147647);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 146488, 147647);
            }
        }

        private void SetVirtualAccount()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 147659, 148258);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 147716, 147780) || true) && (f_1589_147720_147754_M(!this.RunAsVirtualAccountSpecified))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 147716, 147780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 147773, 147780);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 147716, 147780);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 147796, 148247);
                using (System.Management.Automation.PowerShell
                invoker = f_1589_147853_147929(RunspaceMode.CurrentRunspace)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 147963, 148063);

                    string
                    pluginLocation = f_1589_147987_148062(@"WSMAN:\localhost\plugin\{0}\RunAsVirtualAccount", f_1589_148057_148061())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 148081, 148197);

                    f_1589_148081_148196(f_1589_148081_148148(f_1589_148081_148111(invoker, "Set-Item"), "Path", pluginLocation), "Value", f_1589_148171_148195(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 148215, 148232);

                    f_1589_148215_148231(invoker);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1589, 147796, 148247);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 147659, 148258);

                bool
                f_1589_147720_147754_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 147720, 147754);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1589_147853_147929(System.Management.Automation.RunspaceMode
                runspace)
                {
                    var return_v = System.Management.Automation.PowerShell.Create(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 147853, 147929);
                    return return_v;
                }


                string
                f_1589_148057_148061()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 148057, 148061);
                    return return_v;
                }


                string
                f_1589_147987_148062(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 147987, 148062);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1589_148081_148111(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 148081, 148111);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1589_148081_148148(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 148081, 148148);
                    return return_v;
                }


                bool
                f_1589_148171_148195(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.RunAsVirtualAccount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 148171, 148195);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1589_148081_148196(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 148081, 148196);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1589_148215_148231(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 148215, 148231);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 147659, 148258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 147659, 148258);
            }
        }

        private void SetQuotas()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 148270, 152159);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 148319, 152148) || true) && (this.transportOption != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 148319, 152148);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 148385, 148592);

                    ScriptBlock
                    setQuotasSb = f_1589_148411_148591(f_1589_148455_148590(f_1589_148469_148497(), setSessionConfigurationQuotaSbFormat, f_1589_148537_148589(f_1589_148584_148588())))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 148610, 148665);

                    setQuotasSb.LanguageMode = PSLanguageMode.FullLanguage;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 148685, 148749);

                    Hashtable
                    quotas = f_1589_148704_148748(transportOption)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 148769, 148789);

                    int
                    idleTimeOut = 0
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 148809, 151680) || true) && (idleTimeOut != 0 && (DynAbs.Tracing.TraceSender.Expression_True(1589, 148813, 148898) && f_1589_148833_148898(quotas, WSManConfigurationOption.AttribMaxIdleTimeout)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 148809, 151680);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 148940, 148975);

                        bool
                        setMaxIdleTimeoutFirst = true
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 148997, 149016);

                        int
                        maxIdleTimeOut
                        = default(int);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 149040, 150525) || true) && (f_1589_149044_149155(f_1589_149081_149134(quotas, WSManConfigurationOption.AttribMaxIdleTimeout), out maxIdleTimeOut))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 149040, 150525);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 149205, 149277);

                            int?
                            currentIdleTimeoutms = WSManConfigurationOption.DefaultIdleTimeout
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 149401, 150277);
                            using (System.Management.Automation.PowerShell
                            ps = f_1589_149453_149501()
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 149559, 149702);

                                f_1589_149559_149701(ps, f_1589_149572_149700(f_1589_149586_149614(), getCurrentIdleTimeoutmsFormat, f_1589_149647_149699(f_1589_149694_149698())));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 149732, 149831);

                                Collection<PSObject>
                                psObjectCollection = f_1589_149774_149806(ps, new object[] { f_1589_149799_149803() }) as Collection<PSObject>
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 149861, 150115) || true) && (psObjectCollection == null || (DynAbs.Tracing.TraceSender.Expression_False(1589, 149865, 149924) || f_1589_149895_149919(psObjectCollection) != 1))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 149861, 150115);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 149990, 150084);

                                    f_1589_149990_150083(false, "This should never happen. ps.Invoke always return a Collection<PSObject>");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 149861, 150115);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 150147, 150250);

                                currentIdleTimeoutms = f_1589_150170_150249(f_1589_150186_150218(f_1589_150186_150207(psObjectCollection, 0)), f_1589_150220_150248());
                                DynAbs.Tracing.TraceSender.TraceExitUsing(1589, 149401, 150277);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 150305, 150502) || true) && (currentIdleTimeoutms >= maxIdleTimeOut && (DynAbs.Tracing.TraceSender.Expression_True(1589, 150309, 150386) && currentIdleTimeoutms >= idleTimeOut))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 150305, 150502);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 150444, 150475);

                                setMaxIdleTimeoutFirst = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 150305, 150502);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 149040, 150525);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 150549, 150775);

                        ScriptBlock
                        setTimeoutQuotasSb = f_1589_150582_150774(f_1589_150630_150773(f_1589_150644_150672(), setSessionConfigurationTimeoutQuotasSbFormat, f_1589_150720_150772(f_1589_150767_150771())))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 150797, 150859);

                        setTimeoutQuotasSb.LanguageMode = PSLanguageMode.FullLanguage;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 150883, 151395);

                        f_1589_150883_151394(
                                            setTimeoutQuotasSb, contextCmdlet: this, useLocalScope: true, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: f_1589_151158_151178(), input: f_1589_151212_151233(), scriptThis: f_1589_151272_151292(), args: new object[] { maxIdleTimeOut, idleTimeOut, setMaxIdleTimeoutFirst });
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 151520, 151581);

                        f_1589_151520_151580(
                                            // Remove Idle timeout values as we have set them above
                                            //
                                            quotas, WSManConfigurationOption.AttribMaxIdleTimeout);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 151603, 151661);

                        f_1589_151603_151660(quotas, WSManConfigurationOption.AttribIdleTimeout);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 148809, 151680);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 151700, 152133);

                    f_1589_151700_152132(
                                    setQuotasSb, contextCmdlet: this, useLocalScope: true, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: f_1589_151952_151972(), input: f_1589_152002_152023(), scriptThis: f_1589_152058_152078(), args: new object[] { quotas, });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 148319, 152148);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 148270, 152159);

                System.Globalization.CultureInfo
                f_1589_148469_148497()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 148469, 148497);
                    return return_v;
                }


                string
                f_1589_148584_148588()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 148584, 148588);
                    return return_v;
                }


                string
                f_1589_148537_148589(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 148537, 148589);
                    return return_v;
                }


                string
                f_1589_148455_148590(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 148455, 148590);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1589_148411_148591(string
                script)
                {
                    var return_v = ScriptBlock.Create(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 148411, 148591);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1589_148704_148748(System.Management.Automation.PSTransportOption
                this_param)
                {
                    var return_v = this_param.ConstructQuotasAsHashtable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 148704, 148748);
                    return return_v;
                }


                bool
                f_1589_148833_148898(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 148833, 148898);
                    return return_v;
                }


                object
                f_1589_149081_149134(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 149081, 149134);
                    return return_v;
                }


                bool
                f_1589_149044_149155(object
                valueToConvert, out int
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo<int>(valueToConvert, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 149044, 149155);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1589_149453_149501()
                {
                    var return_v = System.Management.Automation.PowerShell.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 149453, 149501);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_149586_149614()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 149586, 149614);
                    return return_v;
                }


                string
                f_1589_149694_149698()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 149694, 149698);
                    return return_v;
                }


                string
                f_1589_149647_149699(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 149647, 149699);
                    return return_v;
                }


                string
                f_1589_149572_149700(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 149572, 149700);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1589_149559_149701(System.Management.Automation.PowerShell
                this_param, string
                script)
                {
                    var return_v = this_param.AddScript(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 149559, 149701);
                    return return_v;
                }


                string
                f_1589_149799_149803()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 149799, 149803);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1589_149774_149806(System.Management.Automation.PowerShell
                this_param, object[]
                input)
                {
                    var return_v = this_param.Invoke((System.Collections.IEnumerable)input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 149774, 149806);
                    return return_v;
                }


                int
                f_1589_149895_149919(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 149895, 149919);
                    return return_v;
                }


                int
                f_1589_149990_150083(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 149990, 150083);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1589_150186_150207(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 150186, 150207);
                    return return_v;
                }


                string
                f_1589_150186_150218(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 150186, 150218);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_150220_150248()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 150220, 150248);
                    return return_v;
                }


                int
                f_1589_150170_150249(string
                value, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = Convert.ToInt32(value, (System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 150170, 150249);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_150644_150672()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 150644, 150672);
                    return return_v;
                }


                string
                f_1589_150767_150771()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 150767, 150771);
                    return return_v;
                }


                string
                f_1589_150720_150772(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 150720, 150772);
                    return return_v;
                }


                string
                f_1589_150630_150773(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 150630, 150773);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1589_150582_150774(string
                script)
                {
                    var return_v = ScriptBlock.Create(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 150582, 150774);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_151158_151178()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 151158, 151178);
                    return return_v;
                }


                object[]
                f_1589_151212_151233()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 151212, 151233);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_151272_151292()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 151272, 151292);
                    return return_v;
                }


                int
                f_1589_150883_151394(System.Management.Automation.ScriptBlock
                this_param, Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                contextCmdlet, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, object[]
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    this_param.InvokeUsingCmdlet(contextCmdlet: (System.Management.Automation.Cmdlet)contextCmdlet, useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 150883, 151394);
                    return 0;
                }


                int
                f_1589_151520_151580(System.Collections.Hashtable
                this_param, string
                key)
                {
                    this_param.Remove((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 151520, 151580);
                    return 0;
                }


                int
                f_1589_151603_151660(System.Collections.Hashtable
                this_param, string
                key)
                {
                    this_param.Remove((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 151603, 151660);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1589_151952_151972()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 151952, 151972);
                    return return_v;
                }


                object[]
                f_1589_152002_152023()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 152002, 152023);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_152058_152078()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 152058, 152078);
                    return return_v;
                }


                int
                f_1589_151700_152132(System.Management.Automation.ScriptBlock
                this_param, Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                contextCmdlet, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, object[]
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    this_param.InvokeUsingCmdlet(contextCmdlet: (System.Management.Automation.Cmdlet)contextCmdlet, useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 151700, 152132);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 148270, 152159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 148270, 152159);
            }
        }

        private void SetOptions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 152171, 153917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 152221, 152427);

                ScriptBlock
                setOptionsSb = f_1589_152248_152426(f_1589_152288_152425(f_1589_152302_152330(), setSessionConfigurationOptionsSbFormat, f_1589_152372_152424(f_1589_152419_152423())))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 152441, 152497);

                setOptionsSb.LanguageMode = PSLanguageMode.FullLanguage;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 152513, 152679);

                Hashtable
                optionsTable
                                = (DynAbs.Tracing.TraceSender.Conditional_F1(1589, 152555, 152578) || ((transportOption != null
                && DynAbs.Tracing.TraceSender.Conditional_F2(1589, 152598, 152643)) || DynAbs.Tracing.TraceSender.Conditional_F3(1589, 152663, 152678))) ? f_1589_152598_152643(transportOption) : f_1589_152663_152678()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 152695, 153253) || true) && (accessModeSpecified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 152695, 153253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 152752, 153238);

                    switch (f_1589_152760_152770())
                    {

                        case PSSessionConfigurationAccessMode.Disabled:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 152752, 153238);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 152885, 152941);

                            optionsTable[AllowRemoteAccessToken] = f_1589_152924_152940(false);
                            DynAbs.Tracing.TraceSender.TraceBreak(1589, 152967, 152973);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 152752, 153238);

                        case PSSessionConfigurationAccessMode.Local:
                        case PSSessionConfigurationAccessMode.Remote:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 152752, 153238);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 153132, 153187);

                            optionsTable[AllowRemoteAccessToken] = f_1589_153171_153186(true);
                            DynAbs.Tracing.TraceSender.TraceBreak(1589, 153213, 153219);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 152752, 153238);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 152695, 153253);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 153269, 153424) || true) && (isUseSharedProcessSpecified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 153269, 153424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 153334, 153409);

                    optionsTable[UseSharedProcessToken] = f_1589_153372_153408(f_1589_153372_153388().ToBool());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 153269, 153424);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 153440, 153906);

                f_1589_153440_153905(
                            setOptionsSb, contextCmdlet: this, useLocalScope: true, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: f_1589_153677_153697(), input: f_1589_153723_153744(), scriptThis: f_1589_153775_153795(), args: new object[] {
                            optionsTable,
                                        });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 152171, 153917);

                System.Globalization.CultureInfo
                f_1589_152302_152330()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 152302, 152330);
                    return return_v;
                }


                string
                f_1589_152419_152423()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 152419, 152423);
                    return return_v;
                }


                string
                f_1589_152372_152424(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 152372, 152424);
                    return return_v;
                }


                string
                f_1589_152288_152425(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 152288, 152425);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1589_152248_152426(string
                script)
                {
                    var return_v = ScriptBlock.Create(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 152248, 152426);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1589_152598_152643(System.Management.Automation.PSTransportOption
                this_param)
                {
                    var return_v = this_param.ConstructOptionsAsHashtable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 152598, 152643);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1589_152663_152678()
                {
                    var return_v = new System.Collections.Hashtable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 152663, 152678);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSSessionConfigurationAccessMode
                f_1589_152760_152770()
                {
                    var return_v = AccessMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 152760, 152770);
                    return return_v;
                }


                string
                f_1589_152924_152940(bool
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 152924, 152940);
                    return return_v;
                }


                string
                f_1589_153171_153186(bool
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 153171, 153186);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1589_153372_153388()
                {
                    var return_v = UseSharedProcess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 153372, 153388);
                    return return_v;
                }


                string
                f_1589_153372_153408(bool
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 153372, 153408);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_153677_153697()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 153677, 153697);
                    return return_v;
                }


                object[]
                f_1589_153723_153744()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 153723, 153744);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_153775_153795()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 153775, 153795);
                    return return_v;
                }


                int
                f_1589_153440_153905(System.Management.Automation.ScriptBlock
                this_param, Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                contextCmdlet, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, object[]
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    this_param.InvokeUsingCmdlet(contextCmdlet: (System.Management.Automation.Cmdlet)contextCmdlet, useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 153440, 153905);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 152171, 153917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 152171, 153917);
            }
        }

        private void SetSessionConfigurationTypeOptions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 153929, 160440);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 154003, 160429) || true) && (sessionTypeOption != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 154003, 160429);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 154066, 160414);
                    using (System.Management.Automation.PowerShell
                    ps = f_1589_154118_154166()
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 154208, 154357);

                        f_1589_154208_154356(ps, f_1589_154221_154355(f_1589_154235_154263(), getSessionConfigurationDataSbFormat, f_1589_154302_154354(f_1589_154349_154353())));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 154379, 154478);

                        Collection<PSObject>
                        psObjectCollection = f_1589_154421_154453(ps, new object[] { f_1589_154446_154450() }) as Collection<PSObject>
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 154500, 154748) || true) && (psObjectCollection == null || (DynAbs.Tracing.TraceSender.Expression_False(1589, 154504, 154563) || f_1589_154534_154558(psObjectCollection) != 1))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 154500, 154748);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 154613, 154725);

                            f_1589_154613_154724(false, "This should never happen.  Plugin must exist because caller code has already checked this.");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 154500, 154748);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 154772, 154968);

                        PSSessionConfigurationData
                        scd = f_1589_154805_154967((DynAbs.Tracing.TraceSender.Conditional_F1(1589, 154839, 154868) || ((f_1589_154839_154860(psObjectCollection, 0) == null && DynAbs.Tracing.TraceSender.Conditional_F2(1589, 154871, 154883)) || DynAbs.Tracing.TraceSender.Conditional_F3(1589, 154886, 154966))) ? string.Empty : f_1589_154886_154966(f_1589_154922_154965(f_1589_154922_154954(f_1589_154922_154943(psObjectCollection, 0)))))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 154990, 155087);

                        PSSessionTypeOption
                        original = f_1589_155021_155086(sessionTypeOption, f_1589_155070_155085(scd))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 155109, 155159);

                        f_1589_155109_155158(original, sessionTypeOption);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 155183, 155244);

                        StringBuilder
                        sessionConfigurationData = f_1589_155224_155243()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 155268, 155302);

                        string
                        modulePathParameter = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 155324, 155353);

                        bool
                        unsetModulePath = false
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 155375, 156075) || true) && (modulePathSpecified)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 155375, 156075);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 155448, 156052) || true) && (modulesToImport == null || (DynAbs.Tracing.TraceSender.Expression_False(1589, 155452, 155535) || f_1589_155508_155530(modulesToImport) == 0) || (DynAbs.Tracing.TraceSender.Expression_False(1589, 155452, 155718) || (f_1589_155569_155591(modulesToImport) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(1589, 155569, 155628) && modulesToImport[0] is string) && (DynAbs.Tracing.TraceSender.Expression_True(1589, 155569, 155717) && f_1589_155632_155717(((string)modulesToImport[0]), string.Empty, StringComparison.OrdinalIgnoreCase)))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 155448, 156052);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 155776, 155799);

                                unsetModulePath = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 155448, 156052);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 155448, 156052);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 155913, 156025);

                                modulePathParameter = f_1589_155935_156024(f_1589_155935_156017(this.modulesToImport));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 155448, 156052);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 155375, 156075);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 156307, 156621) || true) && (!unsetModulePath && (DynAbs.Tracing.TraceSender.Expression_True(1589, 156311, 156372) && f_1589_156331_156372(modulePathParameter)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 156307, 156621);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 156422, 156598);

                            modulePathParameter = (DynAbs.Tracing.TraceSender.Conditional_F1(1589, 156444, 156481) || (((f_1589_156445_156472(scd) == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1589, 156484, 156488)) || DynAbs.Tracing.TraceSender.Conditional_F3(1589, 156491, 156597))) ? null : f_1589_156491_156597(f_1589_156491_156590(f_1589_156552_156589(f_1589_156552_156579(scd))));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 156307, 156621);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 157304, 158567) || true) && (unsetModulePath || (DynAbs.Tracing.TraceSender.Expression_False(1589, 157308, 157368) || f_1589_157327_157368(modulePathParameter)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 157304, 158567);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 157418, 157641);

                            f_1589_157418_157640(sessionConfigurationData, f_1589_157450_157639(f_1589_157464_157492(), initParamFormat, PSSessionConfigurationData.ModulesToImportToken, string.Empty));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 157304, 158567);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 157304, 158567);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 158281, 158544);

                            f_1589_158281_158543(sessionConfigurationData, f_1589_158313_158542(f_1589_158327_158355(), initParamFormat, PSSessionConfigurationData.ModulesToImportToken, modulePathParameter));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 157304, 158567);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 158591, 158644);

                        string
                        privateData = f_1589_158612_158643(original)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 158666, 158886) || true) && (!f_1589_158671_158704(privateData))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 158666, 158886);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 158754, 158863);

                            f_1589_158754_158862(sessionConfigurationData, f_1589_158786_158861(f_1589_158800_158828(), privateDataFormat, privateData));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 158666, 158886);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 158910, 160395) || true) && (f_1589_158914_158945(sessionConfigurationData) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 158910, 160395);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 158999, 159253);

                            string
                            sessionConfigData = f_1589_159026_159252(f_1589_159040_159068(), SessionConfigDataFormat, sessionConfigurationData)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 159279, 159355);

                            string
                            encodedSessionConfigData = f_1589_159313_159354(sessionConfigData)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 159381, 159632);

                            ScriptBlock
                            setSessionConfigurationSb = f_1589_159421_159631(f_1589_159470_159604(f_1589_159484_159512(), setSessionConfigurationDataSbFormat, f_1589_159551_159603(f_1589_159598_159602())))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 159658, 159727);

                            setSessionConfigurationSb.LanguageMode = PSLanguageMode.FullLanguage;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 159755, 160372);

                            f_1589_159755_160371(
                                                    setSessionConfigurationSb, contextCmdlet: this, useLocalScope: true, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: f_1589_160053_160073(), input: f_1589_160111_160132(), scriptThis: f_1589_160175_160195(), args: new object[] {
                                                encodedSessionConfigData,
                                                                          });
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 158910, 160395);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1589, 154066, 160414);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 154003, 160429);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 153929, 160440);

                System.Management.Automation.PowerShell
                f_1589_154118_154166()
                {
                    var return_v = System.Management.Automation.PowerShell.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 154118, 154166);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_154235_154263()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 154235, 154263);
                    return return_v;
                }


                string
                f_1589_154349_154353()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 154349, 154353);
                    return return_v;
                }


                string
                f_1589_154302_154354(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 154302, 154354);
                    return return_v;
                }


                string
                f_1589_154221_154355(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 154221, 154355);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1589_154208_154356(System.Management.Automation.PowerShell
                this_param, string
                script)
                {
                    var return_v = this_param.AddScript(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 154208, 154356);
                    return return_v;
                }


                string
                f_1589_154446_154450()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 154446, 154450);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1589_154421_154453(System.Management.Automation.PowerShell
                this_param, object[]
                input)
                {
                    var return_v = this_param.Invoke((System.Collections.IEnumerable)input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 154421, 154453);
                    return return_v;
                }


                int
                f_1589_154534_154558(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 154534, 154558);
                    return return_v;
                }


                int
                f_1589_154613_154724(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 154613, 154724);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1589_154839_154860(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 154839, 154860);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_154922_154943(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 154922, 154943);
                    return return_v;
                }


                object
                f_1589_154922_154954(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 154922, 154954);
                    return return_v;
                }


                string?
                f_1589_154922_154965(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 154922, 154965);
                    return return_v;
                }


                string
                f_1589_154886_154966(string
                s)
                {
                    var return_v = PSSessionConfigurationData.Unescape(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 154886, 154966);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSSessionConfigurationData
                f_1589_154805_154967(string
                configurationData)
                {
                    var return_v = PSSessionConfigurationData.Create(configurationData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 154805, 154967);
                    return return_v;
                }


                string
                f_1589_155070_155085(System.Management.Automation.Remoting.PSSessionConfigurationData
                this_param)
                {
                    var return_v = this_param.PrivateData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 155070, 155085);
                    return return_v;
                }


                System.Management.Automation.PSSessionTypeOption
                f_1589_155021_155086(System.Management.Automation.PSSessionTypeOption
                this_param, string
                privateData)
                {
                    var return_v = this_param.ConstructObjectFromPrivateData(privateData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 155021, 155086);
                    return return_v;
                }


                int
                f_1589_155109_155158(System.Management.Automation.PSSessionTypeOption
                this_param, System.Management.Automation.PSSessionTypeOption
                updated)
                {
                    this_param.CopyUpdatedValuesFrom(updated);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 155109, 155158);
                    return 0;
                }


                System.Text.StringBuilder
                f_1589_155224_155243()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 155224, 155243);
                    return return_v;
                }


                int
                f_1589_155508_155530(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 155508, 155530);
                    return return_v;
                }


                int
                f_1589_155569_155591(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 155569, 155591);
                    return return_v;
                }


                bool
                f_1589_155632_155717(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 155632, 155717);
                    return return_v;
                }


                string
                f_1589_155935_156017(object[]
                modulePath)
                {
                    var return_v = PSSessionConfigurationCommandUtilities.GetModulePathAsString(modulePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 155935, 156017);
                    return return_v;
                }


                string
                f_1589_155935_156024(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 155935, 156024);
                    return return_v;
                }


                bool
                f_1589_156331_156372(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 156331, 156372);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1589_156445_156472(System.Management.Automation.Remoting.PSSessionConfigurationData
                this_param)
                {
                    var return_v = this_param.ModulesToImportInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 156445, 156472);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1589_156552_156579(System.Management.Automation.Remoting.PSSessionConfigurationData
                this_param)
                {
                    var return_v = this_param.ModulesToImportInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 156552, 156579);
                    return return_v;
                }


                object[]
                f_1589_156552_156589(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 156552, 156589);
                    return return_v;
                }


                string
                f_1589_156491_156590(object[]
                modulePath)
                {
                    var return_v = PSSessionConfigurationCommandUtilities.GetModulePathAsString(modulePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 156491, 156590);
                    return return_v;
                }


                string
                f_1589_156491_156597(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 156491, 156597);
                    return return_v;
                }


                bool
                f_1589_157327_157368(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 157327, 157368);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_157464_157492()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 157464, 157492);
                    return return_v;
                }


                string
                f_1589_157450_157639(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 157450, 157639);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_157418_157640(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 157418, 157640);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_158327_158355()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 158327, 158355);
                    return return_v;
                }


                string
                f_1589_158313_158542(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 158313, 158542);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_158281_158543(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 158281, 158543);
                    return return_v;
                }


                string
                f_1589_158612_158643(System.Management.Automation.PSSessionTypeOption
                this_param)
                {
                    var return_v = this_param.ConstructPrivateData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 158612, 158643);
                    return return_v;
                }


                bool
                f_1589_158671_158704(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 158671, 158704);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_158800_158828()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 158800, 158828);
                    return return_v;
                }


                string
                f_1589_158786_158861(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 158786, 158861);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_158754_158862(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 158754, 158862);
                    return return_v;
                }


                int
                f_1589_158914_158945(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 158914, 158945);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_159040_159068()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 159040, 159068);
                    return return_v;
                }


                string
                f_1589_159026_159252(System.Globalization.CultureInfo
                provider, string
                format, System.Text.StringBuilder
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 159026, 159252);
                    return return_v;
                }


                string?
                f_1589_159313_159354(string
                str)
                {
                    var return_v = SecurityElement.Escape(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 159313, 159354);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_159484_159512()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 159484, 159512);
                    return return_v;
                }


                string
                f_1589_159598_159602()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 159598, 159602);
                    return return_v;
                }


                string
                f_1589_159551_159603(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 159551, 159603);
                    return return_v;
                }


                string
                f_1589_159470_159604(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 159470, 159604);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1589_159421_159631(string
                script)
                {
                    var return_v = ScriptBlock.Create(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 159421, 159631);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_160053_160073()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 160053, 160073);
                    return return_v;
                }


                object[]
                f_1589_160111_160132()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 160111, 160132);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_160175_160195()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 160175, 160195);
                    return return_v;
                }


                int
                f_1589_159755_160371(System.Management.Automation.ScriptBlock
                this_param, Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                contextCmdlet, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, object[]
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    this_param.InvokeUsingCmdlet(contextCmdlet: (System.Management.Automation.Cmdlet)contextCmdlet, useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 159755, 160371);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 153929, 160440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 153929, 160440);
            }
        }

        protected override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 160499, 161181);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 160563, 160664);

                f_1589_160563_160663(this, _isErrorReported, f_1589_160646_160651(), noRestart);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 160678, 160967) || true) && (!_isErrorReported && (DynAbs.Tracing.TraceSender.Expression_True(1589, 160682, 160712) && noRestart))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 160678, 160967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 160746, 160849);

                    string
                    action = f_1589_160762_160848(f_1589_160780_160824(), f_1589_160826_160847(f_1589_160826_160842(this)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 160867, 160952);

                    f_1589_160867_160951(this, f_1589_160880_160950(f_1589_160898_160941(), action));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 160678, 160967);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 160983, 161086);

                System.Management.Automation.Tracing.Tracer
                tracer = f_1589_161036_161085()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 161100, 161170);

                f_1589_161100_161169(tracer, f_1589_161124_161133(this), f_1589_161135_161168(f_1589_161135_161163()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 160499, 161181);

                System.Management.Automation.SwitchParameter
                f_1589_160646_160651()
                {
                    var return_v = Force;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 160646, 160651);
                    return return_v;
                }


                int
                f_1589_160563_160663(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                cmdlet, bool
                isErrorReported, System.Management.Automation.SwitchParameter
                force, bool
                noServiceRestart)
                {
                    PSSessionConfigurationCommandUtilities.RestartWinRMService((System.Management.Automation.PSCmdlet)cmdlet, isErrorReported, (bool)force, noServiceRestart);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 160563, 160663);
                    return 0;
                }


                string
                f_1589_160780_160824()
                {
                    var return_v = RemotingErrorIdStrings.CSShouldProcessAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 160780, 160824);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1589_160826_160842(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 160826, 160842);
                    return return_v;
                }


                string
                f_1589_160826_160847(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 160826, 160847);
                    return return_v;
                }


                string
                f_1589_160762_160848(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 160762, 160848);
                    return return_v;
                }


                string
                f_1589_160898_160941()
                {
                    var return_v = RemotingErrorIdStrings.WinRMRequiresRestart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 160898, 160941);
                    return return_v;
                }


                string
                f_1589_160880_160950(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 160880, 160950);
                    return return_v;
                }


                int
                f_1589_160867_160951(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param, string
                text)
                {
                    this_param.WriteWarning(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 160867, 160951);
                    return 0;
                }


                System.Management.Automation.Tracing.Tracer
                f_1589_161036_161085()
                {
                    var return_v = new System.Management.Automation.Tracing.Tracer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 161036, 161085);
                    return return_v;
                }


                string
                f_1589_161124_161133(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 161124, 161133);
                    return return_v;
                }


                System.Security.Principal.WindowsIdentity
                f_1589_161135_161163()
                {
                    var return_v = WindowsIdentity.GetCurrent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 161135, 161163);
                    return return_v;
                }


                string
                f_1589_161135_161168(System.Security.Principal.WindowsIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 161135, 161168);
                    return return_v;
                }


                int
                f_1589_161100_161169(System.Management.Automation.Tracing.Tracer
                this_param, string
                endpointName, string
                modifiedBy)
                {
                    this_param.EndpointModified(endpointName, modifiedBy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 161100, 161169);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 160499, 161181);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 160499, 161181);
            }
        }

        private PSObject ConstructPropertiesForUpdate()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 161250, 172424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 161322, 161355);

                PSObject
                result = f_1589_161340_161354()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 161369, 161430);

                f_1589_161369_161429(f_1589_161369_161386(result), f_1589_161391_161428("Name", shellName));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 161446, 161618) || true) && (isAssemblyNameSpecified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 161446, 161618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 161507, 161603);

                    f_1589_161507_161602(f_1589_161507_161524(result), f_1589_161529_161601(ConfigurationDataFromXML.ASSEMBLYTOKEN, assemblyName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 161446, 161618);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 161634, 161811) || true) && (isApplicationBaseSpecified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 161634, 161811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 161698, 161796);

                    f_1589_161698_161795(f_1589_161698_161715(result), f_1589_161720_161794(ConfigurationDataFromXML.APPBASETOKEN, applicationBase));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 161634, 161811);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 161827, 162024) || true) && (isConfigurationTypeNameSpecified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 161827, 162024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 161897, 162009);

                    f_1589_161897_162008(f_1589_161897_161914(result), f_1589_161919_162007(ConfigurationDataFromXML.SHELLCONFIGTYPETOKEN, configurationTypeName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 161827, 162024);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 162040, 162231) || true) && (isConfigurationScriptSpecified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 162040, 162231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 162108, 162216);

                    f_1589_162108_162215(f_1589_162108_162125(result), f_1589_162130_162214(ConfigurationDataFromXML.STARTUPSCRIPTTOKEN, configurationScript));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 162040, 162231);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 162247, 162521) || true) && (isMaxCommandSizeMBSpecified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 162247, 162521);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 162312, 162393);

                    object
                    input = (DynAbs.Tracing.TraceSender.Conditional_F1(1589, 162327, 162352) || ((f_1589_162327_162352(maxCommandSizeMB) && DynAbs.Tracing.TraceSender.Conditional_F2(1589, 162355, 162385)) || DynAbs.Tracing.TraceSender.Conditional_F3(1589, 162388, 162392))) ? (object)f_1589_162363_162385(maxCommandSizeMB) : null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 162411, 162506);

                    f_1589_162411_162505(f_1589_162411_162428(result), f_1589_162433_162504(ConfigurationDataFromXML.MAXRCVDCMDSIZETOKEN, input));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 162247, 162521);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 162537, 162808) || true) && (isMaxObjectSizeMBSpecified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 162537, 162808);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 162601, 162680);

                    object
                    input = (DynAbs.Tracing.TraceSender.Conditional_F1(1589, 162616, 162640) || ((f_1589_162616_162640(maxObjectSizeMB) && DynAbs.Tracing.TraceSender.Conditional_F2(1589, 162643, 162672)) || DynAbs.Tracing.TraceSender.Conditional_F3(1589, 162675, 162679))) ? (object)f_1589_162651_162672(maxObjectSizeMB) : null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 162698, 162793);

                    f_1589_162698_162792(f_1589_162698_162715(result), f_1589_162720_162791(ConfigurationDataFromXML.MAXRCVDOBJSIZETOKEN, input));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 162537, 162808);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 162824, 163010) || true) && (f_1589_162828_162851(threadAptState))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 162824, 163010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 162885, 162995);

                    f_1589_162885_162994(f_1589_162885_162902(result), f_1589_162907_162993(ConfigurationDataFromXML.THREADAPTSTATETOKEN, f_1589_162972_162992(threadAptState)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 162824, 163010);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 163026, 163209) || true) && (f_1589_163030_163052(threadOptions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 163026, 163209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 163086, 163194);

                    f_1589_163086_163193(f_1589_163086_163103(result), f_1589_163108_163192(ConfigurationDataFromXML.THREADOPTIONSTOKEN, f_1589_163172_163191(threadOptions)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 163026, 163209);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 163225, 164535) || true) && (isPSVersionSpecified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 163225, 164535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 163283, 163452);

                    f_1589_163283_163451(f_1589_163283_163300(result), f_1589_163305_163450(ConfigurationDataFromXML.PSVERSIONTOKEN, f_1589_163365_163449(psVersion)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 163470, 163557);

                    MaxPSVersion = f_1589_163485_163556(psVersion);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 164345, 164520);

                    f_1589_164345_164519(f_1589_164345_164362(result), f_1589_164367_164518(ConfigurationDataFromXML.MAXPSVERSIONTOKEN, f_1589_164430_164517(MaxPSVersion)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 163225, 164535);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 164551, 170566) || true) && (modulePathSpecified && (DynAbs.Tracing.TraceSender.Expression_True(1589, 164555, 164603) && sessionTypeOption == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 164551, 170566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 164637, 164666);

                    bool
                    unsetModulePath = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 164684, 164718);

                    string
                    modulePathParameter = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 164738, 165249) || true) && (modulesToImport == null || (DynAbs.Tracing.TraceSender.Expression_False(1589, 164742, 164796) || f_1589_164769_164791(modulesToImport) == 0) || (DynAbs.Tracing.TraceSender.Expression_False(1589, 164742, 164971) || (f_1589_164822_164844(modulesToImport) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(1589, 164822, 164881) && modulesToImport[0] is string) && (DynAbs.Tracing.TraceSender.Expression_True(1589, 164822, 164970) && f_1589_164885_164970(((string)modulesToImport[0]), string.Empty, StringComparison.OrdinalIgnoreCase)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 164738, 165249);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 165013, 165036);

                        unsetModulePath = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 164738, 165249);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 164738, 165249);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 165118, 165230);

                        modulePathParameter = f_1589_165140_165229(f_1589_165140_165222(this.modulesToImport));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 164738, 165249);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 165269, 170551) || true) && (unsetModulePath || (DynAbs.Tracing.TraceSender.Expression_False(1589, 165273, 165334) || !f_1589_165293_165334(modulePathParameter)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 165269, 170551);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 165376, 170532);
                        using (System.Management.Automation.PowerShell
                        ps = f_1589_165428_165476()
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 165593, 165742);

                            f_1589_165593_165741(                        // Get the SessionConfigurationDataFormat
                                                    ps, f_1589_165606_165740(f_1589_165620_165648(), getSessionConfigurationDataSbFormat, f_1589_165687_165739(f_1589_165734_165738())));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 165768, 165867);

                            Collection<PSObject>
                            psObjectCollection = f_1589_165810_165842(ps, new object[] { f_1589_165835_165839() }) as Collection<PSObject>
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 165893, 166135) || true) && (psObjectCollection == null || (DynAbs.Tracing.TraceSender.Expression_False(1589, 165897, 165956) || f_1589_165927_165951(psObjectCollection) != 1))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 165893, 166135);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 166014, 166108);

                                f_1589_166014_166107(false, "This should never happen. ps.Invoke always return a Collection<PSObject>");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 165893, 166135);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 166163, 166224);

                            StringBuilder
                            sessionConfigurationData = f_1589_166204_166223()
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 166347, 169846) || true) && (f_1589_166351_166372(psObjectCollection, 0) == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 166347, 169846);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 166576, 166968) || true) && (!unsetModulePath)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 166576, 166968);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 166662, 166937);

                                    f_1589_166662_166936(sessionConfigurationData, f_1589_166694_166935(f_1589_166708_166736(), initParamFormat, PSSessionConfigurationData.ModulesToImportToken, modulePathParameter));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 166576, 166968);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 166347, 169846);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 166347, 169846);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 167409, 167521);

                                PSSessionConfigurationData
                                scd = f_1589_167442_167520(f_1589_167476_167519(f_1589_167476_167508(f_1589_167476_167497(psObjectCollection, 0))))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 167551, 167762);

                                string
                                privateData = (DynAbs.Tracing.TraceSender.Conditional_F1(1589, 167572, 167609) || ((f_1589_167572_167609(f_1589_167593_167608(scd)) && DynAbs.Tracing.TraceSender.Conditional_F2(1589, 167666, 167670)) || DynAbs.Tracing.TraceSender.Conditional_F3(1589, 167727, 167761))) ? null
                                : f_1589_167727_167761(f_1589_167727_167742(scd), '"', '\'')
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 167865, 169819) || true) && (unsetModulePath)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 167865, 169819);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 168042, 168777) || true) && (f_1589_168046_168073(scd) != null && (DynAbs.Tracing.TraceSender.Expression_True(1589, 168046, 168123) && f_1589_168085_168118(f_1589_168085_168112(scd)) != 0))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 168042, 168777);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 168197, 168436);

                                        f_1589_168197_168435(sessionConfigurationData, f_1589_168229_168434(f_1589_168243_168271(), initParamFormat, PSSessionConfigurationData.ModulesToImportToken, string.Empty));

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 168474, 168742) || true) && (!f_1589_168479_168512(privateData))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 168474, 168742);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 168594, 168703);

                                            f_1589_168594_168702(sessionConfigurationData, f_1589_168626_168701(f_1589_168640_168668(), privateDataFormat, privateData));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 168474, 168742);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 168042, 168777);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 167865, 169819);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 167865, 169819);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 169223, 169498);

                                    f_1589_169223_169497(                                // Replace the old module path
                                                                    sessionConfigurationData, f_1589_169255_169496(f_1589_169269_169297(), initParamFormat, PSSessionConfigurationData.ModulesToImportToken, modulePathParameter));

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 169532, 169788) || true) && (!f_1589_169537_169570(privateData))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 169532, 169788);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 169644, 169753);

                                        f_1589_169644_169752(sessionConfigurationData, f_1589_169676_169751(f_1589_169690_169718(), privateDataFormat, privateData));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 169532, 169788);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 167865, 169819);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 166347, 169846);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 169874, 170509) || true) && (f_1589_169878_169909(sessionConfigurationData) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 169874, 170509);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 169971, 170233);

                                string
                                sessionConfigData = f_1589_169998_170232(f_1589_170012_170040(), SessionConfigDataFormat, sessionConfigurationData)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 170263, 170339);

                                string
                                encodedSessionConfigData = f_1589_170297_170338(sessionConfigData)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 170369, 170482);

                                f_1589_170369_170481(f_1589_170369_170386(result), f_1589_170391_170480(ConfigurationDataFromXML.SESSIONCONFIGTOKEN, encodedSessionConfigData));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 169874, 170509);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1589, 165376, 170532);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 165269, 170551);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 164551, 170566);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 170612, 172383) || true) && (f_1589_170616_170620() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 170612, 172383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 170662, 170691);

                    ProviderInfo
                    provider = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 170709, 170727);

                    PSDriveInfo
                    drive
                    = default(PSDriveInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 170745, 170848);

                    string
                    filePath = f_1589_170763_170847(f_1589_170763_170780(f_1589_170763_170775()), f_1589_170817_170821(), out provider, out drive)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 170868, 171496) || true) && (!f_1589_170873_170926(provider, f_1589_170893_170925(f_1589_170893_170914(f_1589_170893_170900()))) || (DynAbs.Tracing.TraceSender.Expression_False(1589, 170872, 171028) || !f_1589_170931_171028(filePath, StringLiterals.PowerShellDISCFileExtension, StringComparison.OrdinalIgnoreCase)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 170868, 171496);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 171070, 171173);

                        string
                        message = f_1589_171087_171172(f_1589_171105_171165(), f_1589_171167_171171())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 171195, 171266);

                        InvalidOperationException
                        ioe = f_1589_171227_171265(message)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 171288, 171429);

                        ErrorRecord
                        er = f_1589_171305_171428(ioe, "InvalidPSSessionConfigurationFilePath", ErrorCategory.InvalidArgument, f_1589_171423_171427())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 171451, 171477);

                        f_1589_171451_171476(this, er);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 170868, 171496);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 171516, 171546);

                    Guid
                    sessionGuid = Guid.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 171621, 171639);

                    string
                    scriptName
                    = default(string);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 171657, 171760);

                    ExternalScriptInfo
                    scriptInfo = f_1589_171689_171759(f_1589_171720_171732(this), filePath, out scriptName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 171780, 171855);

                    Hashtable
                    configTable = f_1589_171804_171854(f_1589_171829_171841(this), scriptInfo)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 171875, 172368);
                        foreach (object currentKey in f_1589_171905_171921_I(f_1589_171905_171921(configTable)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 171875, 172368);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 171963, 172349) || true) && (f_1589_171967_172007(f_1589_171967_171984(result), f_1589_171985_172006(currentKey)) == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 171963, 172349);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 172065, 172155);

                                f_1589_172065_172154(f_1589_172065_172082(result), f_1589_172087_172153(f_1589_172106_172127(currentKey), f_1589_172129_172152(configTable, currentKey)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 171963, 172349);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 171963, 172349);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 172253, 172326);

                                f_1589_172253_172293(f_1589_172253_172270(result), f_1589_172271_172292(currentKey)).Value = f_1589_172302_172325(configTable, currentKey);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 171963, 172349);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 171875, 172368);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1589, 1, 494);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1589, 1, 494);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 170612, 172383);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 172399, 172413);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 161250, 172424);

                System.Management.Automation.PSObject
                f_1589_161340_161354()
                {
                    var return_v = new System.Management.Automation.PSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 161340, 161354);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1589_161369_161386(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 161369, 161386);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1589_161391_161428(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 161391, 161428);
                    return return_v;
                }


                int
                f_1589_161369_161429(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 161369, 161429);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1589_161507_161524(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 161507, 161524);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1589_161529_161601(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 161529, 161601);
                    return return_v;
                }


                int
                f_1589_161507_161602(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 161507, 161602);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1589_161698_161715(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 161698, 161715);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1589_161720_161794(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 161720, 161794);
                    return return_v;
                }


                int
                f_1589_161698_161795(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 161698, 161795);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1589_161897_161914(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 161897, 161914);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1589_161919_162007(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 161919, 162007);
                    return return_v;
                }


                int
                f_1589_161897_162008(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 161897, 162008);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1589_162108_162125(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 162108, 162125);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1589_162130_162214(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 162130, 162214);
                    return return_v;
                }


                int
                f_1589_162108_162215(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 162108, 162215);
                    return 0;
                }


                bool
                f_1589_162327_162352(double?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 162327, 162352);
                    return return_v;
                }


                double
                f_1589_162363_162385(double?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 162363, 162385);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1589_162411_162428(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 162411, 162428);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1589_162433_162504(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 162433, 162504);
                    return return_v;
                }


                int
                f_1589_162411_162505(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 162411, 162505);
                    return 0;
                }


                bool
                f_1589_162616_162640(double?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 162616, 162640);
                    return return_v;
                }


                double
                f_1589_162651_162672(double?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 162651, 162672);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1589_162698_162715(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 162698, 162715);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1589_162720_162791(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 162720, 162791);
                    return return_v;
                }


                int
                f_1589_162698_162792(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 162698, 162792);
                    return 0;
                }


                bool
                f_1589_162828_162851(System.Threading.ApartmentState?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 162828, 162851);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1589_162885_162902(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 162885, 162902);
                    return return_v;
                }


                System.Threading.ApartmentState
                f_1589_162972_162992(System.Threading.ApartmentState?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 162972, 162992);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1589_162907_162993(string
                name, System.Threading.ApartmentState
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 162907, 162993);
                    return return_v;
                }


                int
                f_1589_162885_162994(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 162885, 162994);
                    return 0;
                }


                bool
                f_1589_163030_163052(System.Management.Automation.Runspaces.PSThreadOptions?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 163030, 163052);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1589_163086_163103(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 163086, 163103);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSThreadOptions
                f_1589_163172_163191(System.Management.Automation.Runspaces.PSThreadOptions?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 163172, 163191);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1589_163108_163192(string
                name, System.Management.Automation.Runspaces.PSThreadOptions
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 163108, 163192);
                    return return_v;
                }


                int
                f_1589_163086_163193(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 163086, 163193);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1589_163283_163300(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 163283, 163300);
                    return return_v;
                }


                System.Version
                f_1589_163365_163449(System.Version
                psVersion)
                {
                    var return_v = PSSessionConfigurationCommandUtilities.ConstructVersionFormatForConfigXml(psVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 163365, 163449);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1589_163305_163450(string
                name, System.Version
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 163305, 163450);
                    return return_v;
                }


                int
                f_1589_163283_163451(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 163283, 163451);
                    return 0;
                }


                System.Version
                f_1589_163485_163556(System.Version
                psVersion)
                {
                    var return_v = PSSessionConfigurationCommandUtilities.CalculateMaxPSVersion(psVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 163485, 163556);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1589_164345_164362(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 164345, 164362);
                    return return_v;
                }


                System.Version
                f_1589_164430_164517(System.Version
                psVersion)
                {
                    var return_v = PSSessionConfigurationCommandUtilities.ConstructVersionFormatForConfigXml(psVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 164430, 164517);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1589_164367_164518(string
                name, System.Version
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 164367, 164518);
                    return return_v;
                }


                int
                f_1589_164345_164519(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 164345, 164519);
                    return 0;
                }


                int
                f_1589_164769_164791(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 164769, 164791);
                    return return_v;
                }


                int
                f_1589_164822_164844(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 164822, 164844);
                    return return_v;
                }


                bool
                f_1589_164885_164970(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 164885, 164970);
                    return return_v;
                }


                string
                f_1589_165140_165222(object[]
                modulePath)
                {
                    var return_v = PSSessionConfigurationCommandUtilities.GetModulePathAsString(modulePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 165140, 165222);
                    return return_v;
                }


                string
                f_1589_165140_165229(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 165140, 165229);
                    return return_v;
                }


                bool
                f_1589_165293_165334(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 165293, 165334);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1589_165428_165476()
                {
                    var return_v = System.Management.Automation.PowerShell.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 165428, 165476);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_165620_165648()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 165620, 165648);
                    return return_v;
                }


                string
                f_1589_165734_165738()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 165734, 165738);
                    return return_v;
                }


                string
                f_1589_165687_165739(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 165687, 165739);
                    return return_v;
                }


                string
                f_1589_165606_165740(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 165606, 165740);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1589_165593_165741(System.Management.Automation.PowerShell
                this_param, string
                script)
                {
                    var return_v = this_param.AddScript(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 165593, 165741);
                    return return_v;
                }


                string
                f_1589_165835_165839()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 165835, 165839);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1589_165810_165842(System.Management.Automation.PowerShell
                this_param, object[]
                input)
                {
                    var return_v = this_param.Invoke((System.Collections.IEnumerable)input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 165810, 165842);
                    return return_v;
                }


                int
                f_1589_165927_165951(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 165927, 165951);
                    return return_v;
                }


                int
                f_1589_166014_166107(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 166014, 166107);
                    return 0;
                }


                System.Text.StringBuilder
                f_1589_166204_166223()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 166204, 166223);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_166351_166372(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 166351, 166372);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_166708_166736()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 166708, 166736);
                    return return_v;
                }


                string
                f_1589_166694_166935(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 166694, 166935);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_166662_166936(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 166662, 166936);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_167476_167497(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 167476, 167497);
                    return return_v;
                }


                object
                f_1589_167476_167508(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 167476, 167508);
                    return return_v;
                }


                string?
                f_1589_167476_167519(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 167476, 167519);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSSessionConfigurationData
                f_1589_167442_167520(string
                configurationData)
                {
                    var return_v = PSSessionConfigurationData.Create(configurationData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 167442, 167520);
                    return return_v;
                }


                string
                f_1589_167593_167608(System.Management.Automation.Remoting.PSSessionConfigurationData
                this_param)
                {
                    var return_v = this_param.PrivateData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 167593, 167608);
                    return return_v;
                }


                bool
                f_1589_167572_167609(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 167572, 167609);
                    return return_v;
                }


                string
                f_1589_167727_167742(System.Management.Automation.Remoting.PSSessionConfigurationData
                this_param)
                {
                    var return_v = this_param.PrivateData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 167727, 167742);
                    return return_v;
                }


                string
                f_1589_167727_167761(string
                this_param, char
                oldChar, char
                newChar)
                {
                    var return_v = this_param.Replace(oldChar, newChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 167727, 167761);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1589_168046_168073(System.Management.Automation.Remoting.PSSessionConfigurationData
                this_param)
                {
                    var return_v = this_param.ModulesToImportInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 168046, 168073);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1589_168085_168112(System.Management.Automation.Remoting.PSSessionConfigurationData
                this_param)
                {
                    var return_v = this_param.ModulesToImportInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 168085, 168112);
                    return return_v;
                }


                int
                f_1589_168085_168118(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 168085, 168118);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_168243_168271()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 168243, 168271);
                    return return_v;
                }


                string
                f_1589_168229_168434(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 168229, 168434);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_168197_168435(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 168197, 168435);
                    return return_v;
                }


                bool
                f_1589_168479_168512(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 168479, 168512);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_168640_168668()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 168640, 168668);
                    return return_v;
                }


                string
                f_1589_168626_168701(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 168626, 168701);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_168594_168702(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 168594, 168702);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_169269_169297()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 169269, 169297);
                    return return_v;
                }


                string
                f_1589_169255_169496(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 169255, 169496);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_169223_169497(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 169223, 169497);
                    return return_v;
                }


                bool
                f_1589_169537_169570(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 169537, 169570);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_169690_169718()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 169690, 169718);
                    return return_v;
                }


                string
                f_1589_169676_169751(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 169676, 169751);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_169644_169752(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 169644, 169752);
                    return return_v;
                }


                int
                f_1589_169878_169909(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 169878, 169909);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1589_170012_170040()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 170012, 170040);
                    return return_v;
                }


                string
                f_1589_169998_170232(System.Globalization.CultureInfo
                provider, string
                format, System.Text.StringBuilder
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 169998, 170232);
                    return return_v;
                }


                string?
                f_1589_170297_170338(string
                str)
                {
                    var return_v = SecurityElement.Escape(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 170297, 170338);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1589_170369_170386(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 170369, 170386);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1589_170391_170480(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 170391, 170480);
                    return return_v;
                }


                int
                f_1589_170369_170481(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 170369, 170481);
                    return 0;
                }


                string
                f_1589_170616_170620()
                {
                    var return_v = Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 170616, 170620);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1589_170763_170775()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 170763, 170775);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1589_170763_170780(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 170763, 170780);
                    return return_v;
                }


                string
                f_1589_170817_170821()
                {
                    var return_v = Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 170817, 170821);
                    return return_v;
                }


                string
                f_1589_170763_170847(System.Management.Automation.PathIntrinsics
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.GetUnresolvedProviderPathFromPSPath(path, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 170763, 170847);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1589_170893_170900()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 170893, 170900);
                    return return_v;
                }


                System.Management.Automation.ProviderNames
                f_1589_170893_170914(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ProviderNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 170893, 170914);
                    return return_v;
                }


                string
                f_1589_170893_170925(System.Management.Automation.ProviderNames
                this_param)
                {
                    var return_v = this_param.FileSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 170893, 170925);
                    return return_v;
                }


                bool
                f_1589_170873_170926(System.Management.Automation.ProviderInfo
                this_param, string
                providerName)
                {
                    var return_v = this_param.NameEquals(providerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 170873, 170926);
                    return return_v;
                }


                bool
                f_1589_170931_171028(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 170931, 171028);
                    return return_v;
                }


                string
                f_1589_171105_171165()
                {
                    var return_v = RemotingErrorIdStrings.InvalidPSSessionConfigurationFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 171105, 171165);
                    return return_v;
                }


                string
                f_1589_171167_171171()
                {
                    var return_v = Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 171167, 171171);
                    return return_v;
                }


                string
                f_1589_171087_171172(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 171087, 171172);
                    return return_v;
                }


                System.InvalidOperationException
                f_1589_171227_171265(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 171227, 171265);
                    return return_v;
                }


                string
                f_1589_171423_171427()
                {
                    var return_v = Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 171423, 171427);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1589_171305_171428(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 171305, 171428);
                    return return_v;
                }


                int
                f_1589_171451_171476(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 171451, 171476);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1589_171720_171732(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 171720, 171732);
                    return return_v;
                }


                System.Management.Automation.ExternalScriptInfo
                f_1589_171689_171759(System.Management.Automation.ExecutionContext
                context, string
                fileName, out string
                scriptName)
                {
                    var return_v = DISCUtils.GetScriptInfoForFile(context, fileName, out scriptName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 171689, 171759);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1589_171829_171841(Microsoft.PowerShell.Commands.SetPSSessionConfigurationCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 171829, 171841);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1589_171804_171854(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.ExternalScriptInfo
                scriptInfo)
                {
                    var return_v = DISCUtils.LoadConfigFile(context, scriptInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 171804, 171854);
                    return return_v;
                }


                System.Collections.ICollection
                f_1589_171905_171921(System.Collections.Hashtable
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 171905, 171921);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1589_171967_171984(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 171967, 171984);
                    return return_v;
                }


                string?
                f_1589_171985_172006(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 171985, 172006);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1589_171967_172007(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 171967, 172007);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1589_172065_172082(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 172065, 172082);
                    return return_v;
                }


                string?
                f_1589_172106_172127(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 172106, 172127);
                    return return_v;
                }


                object
                f_1589_172129_172152(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 172129, 172152);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1589_172087_172153(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 172087, 172153);
                    return return_v;
                }


                int
                f_1589_172065_172154(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 172065, 172154);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1589_172253_172270(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 172253, 172270);
                    return return_v;
                }


                string?
                f_1589_172271_172292(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 172271, 172292);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1589_172253_172293(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 172253, 172293);
                    return return_v;
                }


                object
                f_1589_172302_172325(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 172302, 172325);
                    return return_v;
                }


                System.Collections.ICollection
                f_1589_171905_171921_I(System.Collections.ICollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 171905, 171921);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 161250, 172424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 161250, 172424);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SetPSSessionConfigurationCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1589, 119234, 172453);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 132881, 132897);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 132928, 132940);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 132966, 132981);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 133009, 133021);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 133047, 133058);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1589, 119234, 172453);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 119234, 172453);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1589, 119234, 172453);

        static string
        f_1589_133210_133224()
        {
            var return_v = GetLocalSddl();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 133210, 133224);
            return return_v;
        }


        static System.Globalization.CultureInfo
        f_1589_133278_133306()
        {
            var return_v = CultureInfo.InvariantCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 133278, 133306);
            return return_v;
        }


        static string
        f_1589_133264_133453(System.Globalization.CultureInfo
        provider, string
        format, params object?[]
        args)
        {
            var return_v = string.Format((System.IFormatProvider)provider, format, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 133264, 133453);
            return return_v;
        }


        static System.Management.Automation.ScriptBlock
        f_1589_133644_133679(string
        script)
        {
            var return_v = ScriptBlock.Create(script);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 133644, 133679);
            return return_v;
        }

    }
    [Cmdlet(VerbsLifecycle.Enable, RemotingConstants.PSSessionConfigurationNoun,
            SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium, HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096785")]
    public sealed class EnablePSSessionConfigurationCommand : PSCmdlet
    {
        private const string
        setWSManConfigCommand = "Set-WSManQuickConfig"
        ;

        private const string
        enablePluginSbFormat = @"

function Test-WinRMQuickConfigNeeded
{{
    # see issue #11005 - Function Test-WinRMQuickConfigNeeded needs to be updated: 
    # 1) currently this function always returns $True
    # 2) checking for a firewall rule using Get-NetFirewallRule engages WinCompat code and has significant perf impact on Enable-PSRemoting; maybe change to Get-CimInstance -ClassName MSFT_NetFirewallRule
    return $True

# Checking the following items
#1. Starting or restarting (if already started) the WinRM service
#2. Setting the WinRM service startup type to Automatic
#3. Creating a listener to accept requests on any IP address
#4. Enabling Windows Firewall inbound rule exceptions for WS-Management traffic (for http only).

    $winrmQuickConfigNeeded = $false

    # check if WinRM service is running
    if ((Get-Service winrm).Status -ne 'Running'){{
        $winrmQuickConfigNeeded = $true
    }}

    # check if WinRM service startup is Auto
    elseif ((Get-CimInstance -Query ""Select StartMode From Win32_Service Where Name='winmgmt'"").StartMode -ne 'Auto'){{
        $winrmQuickConfigNeeded = $true
    }}

    # check if a winrm listener is present
    elseif (!(Test-Path WSMan:\localhost\Listener) -or ($null -eq (Get-ChildItem WSMan:\localhost\Listener))){{
        $winrmQuickConfigNeeded = $true
    }}

    # check if WinRM firewall is enabled for HTTP
    else{{
        if (Get-Command Get-NetFirewallRule -ErrorAction SilentlyContinue){{
            $winrmFirewall = Get-NetFirewallRule -Name 'WINRM-HTTP-In-TCP' -ErrorAction SilentlyContinue
            if (!$winrmFirewall -or $winrmFirewall.Enabled -ne $true){{
                $winrmQuickConfigNeeded = $true
            }}
        }}
        else{{
            $winrmQuickConfigNeeded = $true
        }}
    }}

    $winrmQuickConfigNeeded
}}

function Enable-PSSessionConfiguration
{{
[CmdletBinding(SupportsShouldProcess=$true, ConfirmImpact=""Medium"")]
param(
    [Parameter(Position=0, ValueFromPipeline=$true)]
    [System.String]
    $Name,

    [Parameter()]
    [bool]
    $Force,

    [Parameter()]
    [string]
    $sddl,

    [Parameter()]
    [bool]
    $isSDDLSpecified,

    [Parameter()]
    [string]
    $queryForSet,

    [Parameter()]
    [string]
    $captionForSet,

    [Parameter()]
    [string]
    $queryForQC,

    [Parameter()]
    [string]
    $captionForQC,

    [Parameter()]
    [string]
    $shouldProcessDescForQC,

    [Parameter()]
    [string]
    $setEnabledTarget,

    [Parameter()]
    [string]
    $setEnabledAction,

    [Parameter()]
    [bool]
    $skipNetworkProfileCheck,

    [Parameter()]
    [bool]
    $noServiceRestart
    )

    begin
    {{
        $winrmQuickConfigNeeded = Test-WinRMQuickConfigNeeded

        if ($winrmQuickConfigNeeded -and ($force -or $pscmdlet.ShouldProcess($shouldProcessDescForQC, $queryForQC, $captionForQC)))
        {{
            # get the status of winrm before Quick Config. if it is already
            # running..restart the service after Quick Config.
            $svc = get-service winrm
            if ($skipNetworkProfileCheck)
            {{
                {0} -force -SkipNetworkProfileCheck
            }}
            else
            {{
                {0} -force
            }}

            if ($svc.Status -match ""Running"")
            {{
               Restart-Service winrm -force -confirm:$false
            }}
        }}
    }} #end of Begin block

    process
    {{
       Get-PSSessionConfiguration $name -Force:$Force | ForEach-Object {{

          if ($_.Enabled -eq $false -and ($force -or $pscmdlet.ShouldProcess($setEnabledTarget, $setEnabledAction)))
          {{
             Set-Item -WarningAction SilentlyContinue -Path ""WSMan:\localhost\Plugin\$name\Enabled"" -Value $true -confirm:$false
          }}

          if (!$isSDDLSpecified)
          {{
             $sddlTemp = $null
             if ($_.psobject.members[""SecurityDescriptorSddl""])
             {{
                 $sddlTemp = $_.psobject.members[""SecurityDescriptorSddl""].Value
             }}

             $securityIdentifierToPurge = $null
             # strip out Disable-Everyone DACL from the SDDL
             if ($sddlTemp)
             {{
                # construct SID for ""EveryOne""
                [system.security.principal.wellknownsidtype]$evst = ""worldsid""
                $everyOneSID = new-object system.security.principal.securityidentifier $evst,$null

                $sd = new-object system.security.accesscontrol.commonsecuritydescriptor $false,$false,$sddlTemp
                $sd.DiscretionaryAcl | ForEach-Object {{
                    if (($_.acequalifier -eq ""accessdenied"") -and ($_.securityidentifier -match $everyOneSID))
                    {{
                       $securityIdentifierToPurge = $_.securityidentifier
                    }}
                }}

                if ($securityIdentifierToPurge)
                {{
                   $sd.discretionaryacl.purge($securityIdentifierToPurge)

                   # if there is no discretionaryacl..add Builtin Administrators and Remote Management Users
                   # to the DACL group as this is the default WSMan behavior
                   if ($sd.discretionaryacl.count -eq 0)
                   {{
                      # Built-in administrators
                      [system.security.principal.wellknownsidtype]$bast = ""BuiltinAdministratorsSid""
                      $basid = new-object system.security.principal.securityidentifier $bast,$null
                      $sd.DiscretionaryAcl.AddAccess('Allow',$basid, 268435456, 'none', 'none')

                      # Remote Management Users, Win8+ only
                      if ([System.Environment]::OSVersion.Version -ge ""6.2.0.0"")
                      {{
                          $rmSidId = new-object system.security.principal.securityidentifier ""{1}""
                          $sd.DiscretionaryAcl.AddAccess('Allow', $rmSidId, 268435456, 'none', 'none')
                      }}

                      # Interactive Users
                      $iuSidId = new-object system.security.principal.securityidentifier ""{2}""
                      $sd.DiscretionaryAcl.AddAccess('Allow', $iuSidId, 268435456, 'none', 'none')
                   }}

                   $sddl = $sd.GetSddlForm(""all"")
                }}
             }} # if ($sddlTemp)
          }} # if (!$isSDDLSpecified)

          $qMessage = $queryForSet -f $_.name,$sddl
          if (($sddl -or $isSDDLSpecified) -and ($force -or $pscmdlet.ShouldProcess($qMessage, $captionForSet)))
          {{
              $null = Set-PSSessionConfiguration -Name $_.Name -SecurityDescriptorSddl $sddl -NoServiceRestart -force -WarningAction 0
          }}
       }} #end of Get-PSSessionConfiguration | foreach
    }} # end of Process block

    End
    {{
    }}
}}

$_ | Enable-PSSessionConfiguration -force $args[0] -sddl $args[1] -isSDDLSpecified $args[2] -queryForSet $args[3] -captionForSet $args[4] -queryForQC $args[5] -captionForQC $args[6] -whatif:$args[7] -confirm:$args[8] -shouldProcessDescForQC $args[9] -setEnabledTarget $args[10] -setEnabledAction $args[11] -skipNetworkProfileCheck $args[12] -noServiceRestart $args[13]
"
        ;

        private static ScriptBlock s_enablePluginSb;

        static EnablePSSessionConfigurationCommand()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1589, 180732, 181367);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 172994, 173040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 173162, 180609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 180649, 180665);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 180801, 181050);

                string
                enablePluginScript = f_1589_180829_181049(f_1589_180843_180871(), enablePluginSbFormat, setWSManConfigCommand, PSSessionConfigurationCommandBase.RemoteManagementUsersSID, PSSessionConfigurationCommandBase.InteractiveUsersSID)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 181224, 181282);

                s_enablePluginSb = f_1589_181243_181281(enablePluginScript);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 181296, 181356);

                s_enablePluginSb.LanguageMode = PSLanguageMode.FullLanguage;
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1589, 180732, 181367);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 180732, 181367);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 180732, 181367);
            }
        }

        [Parameter(Position = 0, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public string[] Name { get; set; }

        private Collection<string> _shellsToEnable;

        [Parameter()]
        public SwitchParameter Force
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 182084, 182149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 182120, 182134);

                    return _force;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 182084, 182149);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 182008, 182242);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 182008, 182242);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 182165, 182231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 182201, 182216);

                    _force = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 182165, 182231);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 182008, 182242);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 182008, 182242);
                }
            }
        }

        private bool _force;

        [Parameter()]
        public string SecurityDescriptorSddl
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 182531, 182594);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 182567, 182579);

                    return sddl;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 182531, 182594);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 182447, 183290);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 182447, 183290);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 182610, 183279);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 182646, 183190) || true) && (!f_1589_182651_182678(value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 182646, 183190);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 182785, 182864);

                        CommonSecurityDescriptor
                        c = f_1589_182814_182863(false, false, value)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 183051, 183171) || true) && (c == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 183051, 183171);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 183114, 183148);

                            throw f_1589_183120_183147();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 183051, 183171);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 182646, 183190);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 183210, 183223);

                    sddl = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 183241, 183264);

                    isSddlSpecified = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 182610, 183279);

                    bool
                    f_1589_182651_182678(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 182651, 182678);
                        return return_v;
                    }


                    System.Security.AccessControl.CommonSecurityDescriptor
                    f_1589_182814_182863(bool
                    isContainer, bool
                    isDS, string
                    sddlForm)
                    {
                        var return_v = new System.Security.AccessControl.CommonSecurityDescriptor(isContainer, isDS, sddlForm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 182814, 182863);
                        return return_v;
                    }


                    System.NotSupportedException
                    f_1589_183120_183147()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 183120, 183147);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 182447, 183290);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 182447, 183290);
                }
            }
        }

        internal string sddl;

        internal bool isSddlSpecified;

        [Parameter()]
        public SwitchParameter SkipNetworkProfileCheck
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 183624, 183664);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 183630, 183662);

                    return _skipNetworkProfileCheck;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 183624, 183664);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 183530, 183732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 183530, 183732);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 183680, 183721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 183686, 183719);

                    _skipNetworkProfileCheck = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 183680, 183721);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 183530, 183732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 183530, 183732);
                }
            }
        }

        private bool _skipNetworkProfileCheck;

        [Parameter()]
        public SwitchParameter NoServiceRestart
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 184125, 184151);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 184131, 184149);

                    return _noRestart;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 184125, 184151);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 184038, 184205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 184038, 184205);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 184167, 184194);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 184173, 184192);

                    _noRestart = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 184167, 184194);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 184038, 184205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 184038, 184205);
                }
            }
        }

        private bool _noRestart;

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 184575, 184836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 184691, 184746);

                f_1589_184691_184745();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 184760, 184825);

                f_1589_184760_184824();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 184575, 184836);

                int
                f_1589_184691_184745()
                {
                    RemotingCommandUtil.CheckRemotingCmdletPrerequisites();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 184691, 184745);
                    return 0;
                }


                int
                f_1589_184760_184824()
                {
                    PSSessionConfigurationCommandUtilities.ThrowIfNotAdministrator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 184760, 184824);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 184575, 184836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 184575, 184836);
            }
        }

        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 184895, 185152);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 184959, 185141) || true) && (f_1589_184963_184967() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 184959, 185141);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 185009, 185126);
                        foreach (string shell in f_1589_185034_185038_I(f_1589_185034_185038()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 185009, 185126);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 185080, 185107);

                            f_1589_185080_185106(_shellsToEnable, shell);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 185009, 185126);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1589, 1, 118);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1589, 1, 118);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 184959, 185141);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 184895, 185152);

                string[]
                f_1589_184963_184967()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 184963, 184967);
                    return return_v;
                }


                string[]
                f_1589_185034_185038()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 185034, 185038);
                    return return_v;
                }


                int
                f_1589_185080_185106(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 185080, 185106);
                    return 0;
                }


                string[]
                f_1589_185034_185038_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 185034, 185038);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 184895, 185152);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 184895, 185152);
            }
        }

        protected override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 185211, 188609);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 185352, 185517) || true) && (f_1589_185356_185377(_shellsToEnable) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 185352, 185517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 185416, 185502);

                    f_1589_185416_185501(_shellsToEnable, f_1589_185436_185500());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 185352, 185517);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 185533, 185629);

                f_1589_185533_185628(this, f_1589_185546_185627(f_1589_185564_185604(), enablePluginSbFormat));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 185733, 185753);

                bool
                whatIf = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 185820, 185840);

                bool
                confirm = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 185854, 185955);

                f_1589_185854_185954(this, out whatIf, out confirm);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 185971, 186057);

                string
                qcCaptionMessage = f_1589_185997_186056(f_1589_186015_186055())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 186071, 186176);

                string
                qcQueryMessage = f_1589_186095_186175(f_1589_186113_186151(), setWSManConfigCommand)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 186190, 186310);

                string
                qcShouldProcessDesc = f_1589_186219_186309(f_1589_186237_186285(), setWSManConfigCommand)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 186324, 186462);

                string
                setCaptionMessage = f_1589_186351_186461(f_1589_186369_186413(), "Set-PSSessionConfiguration")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 186476, 186547);

                string
                setQueryMessage = f_1589_186501_186546()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 186561, 186663);

                string
                setEnabledAction = f_1589_186587_186662(f_1589_186605_186649(), "Set-Item")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 186677, 186747);

                string
                setEnabledTarget = f_1589_186703_186746()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 186763, 188043);

                f_1589_186763_188042(
                            s_enablePluginSb, contextCmdlet: this, useLocalScope: true, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: _shellsToEnable, input: f_1589_187045_187066(), scriptThis: f_1589_187097_187117(), args: new object[] {
                                               _force,
                                               sddl,
                                               isSddlSpecified,
                                               setQueryMessage,
                                               setCaptionMessage,
                                               qcQueryMessage,
                                               qcCaptionMessage,
                                               whatIf,
                                               confirm,
                                               qcShouldProcessDesc,
                                               setEnabledTarget,
                                               setEnabledAction,
                                               _skipNetworkProfileCheck,
                                               _noRestart});
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 188059, 188162);

                System.Management.Automation.Tracing.Tracer
                tracer = f_1589_188112_188161()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 188178, 188217);

                StringBuilder
                sb = f_1589_188197_188216()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 188231, 188399);
                    foreach (string endPointName in f_1589_188263_188292_I(f_1589_188263_188267() ?? (DynAbs.Tracing.TraceSender.Expression_Null<string[]>(1589, 188263, 188292) ?? f_1589_188271_188292())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 188231, 188399);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 188326, 188350);

                        f_1589_188326_188349(sb, endPointName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 188368, 188384);

                        f_1589_188368_188383(sb, ", ");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 188231, 188399);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1589, 1, 169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1589, 1, 169);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 188415, 188509) || true) && (f_1589_188419_188428(sb) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 188415, 188509);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 188466, 188494);

                    f_1589_188466_188493(sb, f_1589_188476_188485(sb) - 2, 2);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 188415, 188509);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 188525, 188598);

                f_1589_188525_188597(
                            tracer, f_1589_188548_188561(sb), f_1589_188563_188596(f_1589_188563_188591()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 185211, 188609);

                int
                f_1589_185356_185377(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 185356, 185377);
                    return return_v;
                }


                string
                f_1589_185436_185500()
                {
                    var return_v = PSSessionConfigurationCommandUtilities.GetWinrmPluginShellName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 185436, 185500);
                    return return_v;
                }


                int
                f_1589_185416_185501(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 185416, 185501);
                    return 0;
                }


                string
                f_1589_185564_185604()
                {
                    var return_v = RemotingErrorIdStrings.EcsScriptMessageV;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 185564, 185604);
                    return return_v;
                }


                string
                f_1589_185546_185627(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 185546, 185627);
                    return return_v;
                }


                int
                f_1589_185533_185628(Microsoft.PowerShell.Commands.EnablePSSessionConfigurationCommand
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 185533, 185628);
                    return 0;
                }


                int
                f_1589_185854_185954(Microsoft.PowerShell.Commands.EnablePSSessionConfigurationCommand
                cmdlet, out bool
                whatIf, out bool
                confirm)
                {
                    PSSessionConfigurationCommandUtilities.CollectShouldProcessParameters((System.Management.Automation.PSCmdlet)cmdlet, out whatIf, out confirm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 185854, 185954);
                    return 0;
                }


                string
                f_1589_186015_186055()
                {
                    var return_v = RemotingErrorIdStrings.EcsWSManQCCaption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 186015, 186055);
                    return return_v;
                }


                string
                f_1589_185997_186056(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 185997, 186056);
                    return return_v;
                }


                string
                f_1589_186113_186151()
                {
                    var return_v = RemotingErrorIdStrings.EcsWSManQCQuery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 186113, 186151);
                    return return_v;
                }


                string
                f_1589_186095_186175(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 186095, 186175);
                    return return_v;
                }


                string
                f_1589_186237_186285()
                {
                    var return_v = RemotingErrorIdStrings.EcsWSManShouldProcessDesc;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 186237, 186285);
                    return return_v;
                }


                string
                f_1589_186219_186309(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 186219, 186309);
                    return return_v;
                }


                string
                f_1589_186369_186413()
                {
                    var return_v = RemotingErrorIdStrings.CSShouldProcessAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 186369, 186413);
                    return return_v;
                }


                string
                f_1589_186351_186461(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 186351, 186461);
                    return return_v;
                }


                string
                f_1589_186501_186546()
                {
                    var return_v = RemotingErrorIdStrings.EcsShouldProcessTarget;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 186501, 186546);
                    return return_v;
                }


                string
                f_1589_186605_186649()
                {
                    var return_v = RemotingErrorIdStrings.CSShouldProcessAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 186605, 186649);
                    return return_v;
                }


                string
                f_1589_186587_186662(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 186587, 186662);
                    return return_v;
                }


                string
                f_1589_186703_186746()
                {
                    var return_v = RemotingErrorIdStrings.SetEnabledTrueTarget;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 186703, 186746);
                    return return_v;
                }


                object[]
                f_1589_187045_187066()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 187045, 187066);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_187097_187117()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 187097, 187117);
                    return return_v;
                }


                int
                f_1589_186763_188042(System.Management.Automation.ScriptBlock
                this_param, Microsoft.PowerShell.Commands.EnablePSSessionConfigurationCommand
                contextCmdlet, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Collections.ObjectModel.Collection<string>
                dollarUnder, object[]
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    this_param.InvokeUsingCmdlet(contextCmdlet: (System.Management.Automation.Cmdlet)contextCmdlet, useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 186763, 188042);
                    return 0;
                }


                System.Management.Automation.Tracing.Tracer
                f_1589_188112_188161()
                {
                    var return_v = new System.Management.Automation.Tracing.Tracer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 188112, 188161);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_188197_188216()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 188197, 188216);
                    return return_v;
                }


                string[]
                f_1589_188263_188267()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 188263, 188267);
                    return return_v;
                }


                string[]
                f_1589_188271_188292()
                {
                    var return_v = Array.Empty<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 188271, 188292);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_188326_188349(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 188326, 188349);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_188368_188383(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 188368, 188383);
                    return return_v;
                }


                string[]
                f_1589_188263_188292_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 188263, 188292);
                    return return_v;
                }


                int
                f_1589_188419_188428(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 188419, 188428);
                    return return_v;
                }


                int
                f_1589_188476_188485(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 188476, 188485);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_188466_188493(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 188466, 188493);
                    return return_v;
                }


                string
                f_1589_188548_188561(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 188548, 188561);
                    return return_v;
                }


                System.Security.Principal.WindowsIdentity
                f_1589_188563_188591()
                {
                    var return_v = WindowsIdentity.GetCurrent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 188563, 188591);
                    return return_v;
                }


                string
                f_1589_188563_188596(System.Security.Principal.WindowsIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 188563, 188596);
                    return return_v;
                }


                int
                f_1589_188525_188597(System.Management.Automation.Tracing.Tracer
                this_param, string
                endpointName, string
                enabledBy)
                {
                    this_param.EndpointEnabled(endpointName, enabledBy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 188525, 188597);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 185211, 188609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 185211, 188609);
            }
        }

        public EnablePSSessionConfigurationCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1589, 172637, 188638);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 181517, 181686);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 181725, 181767);
            this._shellsToEnable = f_1589_181743_181767();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 182267, 182273);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 183318, 183322);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 183347, 183362);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 183757, 183781);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 184230, 184240);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1589, 172637, 188638);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 172637, 188638);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1589, 172637, 188638);

        static System.Globalization.CultureInfo
        f_1589_180843_180871()
        {
            var return_v = CultureInfo.InvariantCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 180843, 180871);
            return return_v;
        }


        static string
        f_1589_180829_181049(System.Globalization.CultureInfo
        provider, string
        format, string
        arg0, string
        arg1, string
        arg2)
        {
            var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 180829, 181049);
            return return_v;
        }


        static System.Management.Automation.ScriptBlock
        f_1589_181243_181281(string
        script)
        {
            var return_v = ScriptBlock.Create(script);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 181243, 181281);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1589_181743_181767()
        {
            var return_v = new System.Collections.ObjectModel.Collection<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 181743, 181767);
            return return_v;
        }

    }
    [Cmdlet(VerbsLifecycle.Disable, RemotingConstants.PSSessionConfigurationNoun,
            SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Low, HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096692")]
    public sealed class DisablePSSessionConfigurationCommand : PSCmdlet
    {
        private const string
        disablePluginSbFormat = @"
function Disable-PSSessionConfiguration
{{
[CmdletBinding(SupportsShouldProcess=$true, ConfirmImpact=""Low"")]
param(
    [Parameter(Position=0, ValueFromPipeline=$true, ValueFromPipelineByPropertyName=$true)]
    [System.String]
    $Name,

    [Parameter()]
    [bool]
    $Force,

    [Parameter()]
    [string]
    $restartWinRMMessage,

    [Parameter()]
    [string]
    $setEnabledTarget,

    [Parameter()]
    [string]
    $setEnabledAction,

    [Parameter()]
    [bool]
    $noServiceRestart
)

    begin
    {{
        if ($force -or $pscmdlet.ShouldProcess($restartWinRMMessage))
        {{
            $svc = get-service winrm
            if ($svc.Status -match ""Stopped"")
            {{
               Restart-Service winrm -force -confirm:$false
            }}
        }}
    }} #end of Begin block

    process
    {{
       Get-PSSessionConfiguration $name -Force:$Force | ForEach-Object {{

           if ($_.Enabled -and ($force -or $pscmdlet.ShouldProcess($setEnabledTarget, $setEnabledAction)))
           {{
                Set-Item -WarningAction SilentlyContinue -Path ""WSMan:\localhost\Plugin\$name\Enabled"" -Value $false -Force -Confirm:$false
           }}
       }} # end of foreach block
    }} #end of process block

    # no longer necessary to restart the winrm to apply the config change
    End
    {{
    }}
}}

$_ | Disable-PSSessionConfiguration -force $args[0] -whatif:$args[1] -confirm:$args[2] -restartWinRMMessage $args[3] -setEnabledTarget $args[4] -setEnabledAction $args[5] -noServiceRestart $args[6]
"
        ;

        private static ScriptBlock s_disablePluginSb;

        static DisablePSSessionConfigurationCommand()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1589, 190891, 191394);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 189131, 190769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 190807, 190824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 190961, 191074);

                string
                disablePluginScript = f_1589_190990_191073(f_1589_191004_191032(), disablePluginSbFormat)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 191248, 191308);

                s_disablePluginSb = f_1589_191268_191307(disablePluginScript);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 191322, 191383);

                s_disablePluginSb.LanguageMode = PSLanguageMode.FullLanguage;
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1589, 190891, 191394);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 190891, 191394);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 190891, 191394);
            }
        }

        [Parameter(Position = 0, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public string[] Name { get; set; }

        private Collection<string> _shellsToDisable;

        [Parameter()]
        public SwitchParameter Force
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 192112, 192177);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 192148, 192162);

                    return _force;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 192112, 192177);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 192036, 192270);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 192036, 192270);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 192193, 192259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 192229, 192244);

                    _force = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 192193, 192259);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 192036, 192270);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 192036, 192270);
                }
            }
        }

        private bool _force;

        [Parameter()]
        public SwitchParameter NoServiceRestart
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 192645, 192671);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 192651, 192669);

                    return _noRestart;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 192645, 192671);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 192558, 192725);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 192558, 192725);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 192687, 192714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 192693, 192712);

                    _noRestart = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 192687, 192714);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 192558, 192725);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 192558, 192725);
                }
            }
        }

        private bool _noRestart;

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 193095, 193356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 193211, 193266);

                f_1589_193211_193265();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 193280, 193345);

                f_1589_193280_193344();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 193095, 193356);

                int
                f_1589_193211_193265()
                {
                    RemotingCommandUtil.CheckRemotingCmdletPrerequisites();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 193211, 193265);
                    return 0;
                }


                int
                f_1589_193280_193344()
                {
                    PSSessionConfigurationCommandUtilities.ThrowIfNotAdministrator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 193280, 193344);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 193095, 193356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 193095, 193356);
            }
        }

        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 193415, 193673);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 193479, 193662) || true) && (f_1589_193483_193487() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 193479, 193662);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 193529, 193647);
                        foreach (string shell in f_1589_193554_193558_I(f_1589_193554_193558()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 193529, 193647);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 193600, 193628);

                            f_1589_193600_193627(_shellsToDisable, shell);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 193529, 193647);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1589, 1, 119);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1589, 1, 119);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 193479, 193662);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 193415, 193673);

                string[]
                f_1589_193483_193487()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 193483, 193487);
                    return return_v;
                }


                string[]
                f_1589_193554_193558()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 193554, 193558);
                    return return_v;
                }


                int
                f_1589_193600_193627(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 193600, 193627);
                    return 0;
                }


                string[]
                f_1589_193554_193558_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 193554, 193558);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 193415, 193673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 193415, 193673);
            }
        }

        protected override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 193732, 196269);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 193873, 194040) || true) && (f_1589_193877_193899(_shellsToDisable) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 193873, 194040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 193938, 194025);

                    f_1589_193938_194024(_shellsToDisable, f_1589_193959_194023());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 193873, 194040);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 194147, 194244);

                f_1589_194147_194243(this, f_1589_194160_194242(f_1589_194178_194218(), disablePluginSbFormat));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 194348, 194368);

                bool
                whatIf = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 194435, 194455);

                bool
                confirm = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 194469, 194570);

                f_1589_194469_194569(this, out whatIf, out confirm);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 194586, 194658);

                string
                restartWinRMMessage = f_1589_194615_194657()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 194672, 194743);

                string
                setEnabledTarget = f_1589_194698_194742()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 194757, 194859);

                string
                setEnabledAction = f_1589_194783_194858(f_1589_194801_194845(), "Set-Item")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 194875, 195702);

                f_1589_194875_195701(
                            s_disablePluginSb, contextCmdlet: this, useLocalScope: true, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: _shellsToDisable, input: f_1589_195159_195180(), scriptThis: f_1589_195211_195231(), args: new object[] {
                                               _force,
                                               whatIf,
                                               confirm,
                                               restartWinRMMessage,
                                               setEnabledTarget,
                                               setEnabledAction,
                                               _noRestart});
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 195718, 195821);

                System.Management.Automation.Tracing.Tracer
                tracer = f_1589_195771_195820()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 195837, 195876);

                StringBuilder
                sb = f_1589_195856_195875()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 195890, 196058);
                    foreach (string endPointName in f_1589_195922_195951_I(f_1589_195922_195926() ?? (DynAbs.Tracing.TraceSender.Expression_Null<string[]>(1589, 195922, 195951) ?? f_1589_195930_195951())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 195890, 196058);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 195985, 196009);

                        f_1589_195985_196008(sb, endPointName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 196027, 196043);

                        f_1589_196027_196042(sb, ", ");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 195890, 196058);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1589, 1, 169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1589, 1, 169);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 196074, 196168) || true) && (f_1589_196078_196087(sb) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 196074, 196168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 196125, 196153);

                    f_1589_196125_196152(sb, f_1589_196135_196144(sb) - 2, 2);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 196074, 196168);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 196184, 196258);

                f_1589_196184_196257(
                            tracer, f_1589_196208_196221(sb), f_1589_196223_196256(f_1589_196223_196251()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 193732, 196269);

                int
                f_1589_193877_193899(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 193877, 193899);
                    return return_v;
                }


                string
                f_1589_193959_194023()
                {
                    var return_v = PSSessionConfigurationCommandUtilities.GetWinrmPluginShellName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 193959, 194023);
                    return return_v;
                }


                int
                f_1589_193938_194024(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 193938, 194024);
                    return 0;
                }


                string
                f_1589_194178_194218()
                {
                    var return_v = RemotingErrorIdStrings.EcsScriptMessageV;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 194178, 194218);
                    return return_v;
                }


                string
                f_1589_194160_194242(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 194160, 194242);
                    return return_v;
                }


                int
                f_1589_194147_194243(Microsoft.PowerShell.Commands.DisablePSSessionConfigurationCommand
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 194147, 194243);
                    return 0;
                }


                int
                f_1589_194469_194569(Microsoft.PowerShell.Commands.DisablePSSessionConfigurationCommand
                cmdlet, out bool
                whatIf, out bool
                confirm)
                {
                    PSSessionConfigurationCommandUtilities.CollectShouldProcessParameters((System.Management.Automation.PSCmdlet)cmdlet, out whatIf, out confirm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 194469, 194569);
                    return 0;
                }


                string
                f_1589_194615_194657()
                {
                    var return_v = RemotingErrorIdStrings.RestartWinRMMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 194615, 194657);
                    return return_v;
                }


                string
                f_1589_194698_194742()
                {
                    var return_v = RemotingErrorIdStrings.SetEnabledFalseTarget;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 194698, 194742);
                    return return_v;
                }


                string
                f_1589_194801_194845()
                {
                    var return_v = RemotingErrorIdStrings.CSShouldProcessAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 194801, 194845);
                    return return_v;
                }


                string
                f_1589_194783_194858(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 194783, 194858);
                    return return_v;
                }


                object[]
                f_1589_195159_195180()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 195159, 195180);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_195211_195231()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 195211, 195231);
                    return return_v;
                }


                int
                f_1589_194875_195701(System.Management.Automation.ScriptBlock
                this_param, Microsoft.PowerShell.Commands.DisablePSSessionConfigurationCommand
                contextCmdlet, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Collections.ObjectModel.Collection<string>
                dollarUnder, object[]
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    this_param.InvokeUsingCmdlet(contextCmdlet: (System.Management.Automation.Cmdlet)contextCmdlet, useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 194875, 195701);
                    return 0;
                }


                System.Management.Automation.Tracing.Tracer
                f_1589_195771_195820()
                {
                    var return_v = new System.Management.Automation.Tracing.Tracer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 195771, 195820);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_195856_195875()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 195856, 195875);
                    return return_v;
                }


                string[]
                f_1589_195922_195926()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 195922, 195926);
                    return return_v;
                }


                string[]
                f_1589_195930_195951()
                {
                    var return_v = Array.Empty<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 195930, 195951);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_195985_196008(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 195985, 196008);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_196027_196042(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 196027, 196042);
                    return return_v;
                }


                string[]
                f_1589_195922_195951_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 195922, 195951);
                    return return_v;
                }


                int
                f_1589_196078_196087(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 196078, 196087);
                    return return_v;
                }


                int
                f_1589_196135_196144(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 196135, 196144);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1589_196125_196152(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 196125, 196152);
                    return return_v;
                }


                string
                f_1589_196208_196221(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 196208, 196221);
                    return return_v;
                }


                System.Security.Principal.WindowsIdentity
                f_1589_196223_196251()
                {
                    var return_v = WindowsIdentity.GetCurrent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 196223, 196251);
                    return return_v;
                }


                string
                f_1589_196223_196256(System.Security.Principal.WindowsIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 196223, 196256);
                    return return_v;
                }


                int
                f_1589_196184_196257(System.Management.Automation.Tracing.Tracer
                this_param, string
                endpointName, string
                disabledBy)
                {
                    this_param.EndpointDisabled(endpointName, disabledBy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 196184, 196257);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 193732, 196269);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 193732, 196269);
            }
        }

        public DisablePSSessionConfigurationCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1589, 188685, 196298);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 191544, 191713);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 191752, 191795);
            this._shellsToDisable = f_1589_191771_191795();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 192295, 192301);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 192750, 192760);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1589, 188685, 196298);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 188685, 196298);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1589, 188685, 196298);

        static System.Globalization.CultureInfo
        f_1589_191004_191032()
        {
            var return_v = CultureInfo.InvariantCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 191004, 191032);
            return return_v;
        }


        static string
        f_1589_190990_191073(System.Globalization.CultureInfo
        provider, string
        format, params object?[]
        args)
        {
            var return_v = string.Format((System.IFormatProvider)provider, format, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 190990, 191073);
            return return_v;
        }


        static System.Management.Automation.ScriptBlock
        f_1589_191268_191307(string
        script)
        {
            var return_v = ScriptBlock.Create(script);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 191268, 191307);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1589_191771_191795()
        {
            var return_v = new System.Collections.ObjectModel.Collection<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 191771, 191795);
            return return_v;
        }

    }
    [Cmdlet(VerbsLifecycle.Enable, RemotingConstants.PSRemotingNoun,
            SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium, HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096577")]
    public sealed class EnablePSRemotingCommand : PSCmdlet
    {
        private const string
        enableRemotingSbFormat = @"
Set-StrictMode -Version Latest

function New-PluginConfigFile
{{
[CmdletBinding(SupportsShouldProcess=$true, ConfirmImpact=""Medium"")]
param(
    [Parameter()] [string] $pluginInstallPath
)
    $pluginConfigFile = Join-Path $pluginInstallPath ""RemotePowerShellConfig.txt""

    # This always overwrites the file with a new version of it (if it already exists)
    Set-Content -Path $pluginConfigFile -Value ""PSHOMEDIR=$PSHOME"" -ErrorAction Stop
    Add-Content -Path $pluginConfigFile -Value ""CORECLRDIR=$PSHOME"" -ErrorAction Stop
}}

function Copy-PluginToEndpoint
{{
param(
    [Parameter()] [string] $endpointDir
)
    $resolvedPluginInstallPath = """"
    $pluginInstallPath = Join-Path ([System.Environment]::GetFolderPath([System.Environment+SpecialFolder]::Windows) + ""\System32\PowerShell"") $endpointDir
    if (!(Test-Path $pluginInstallPath))
    {{
        $resolvedPluginInstallPath = New-Item -Type Directory -Path $pluginInstallPath
    }}
    else
    {{
        $resolvedPluginInstallPath = Resolve-Path $pluginInstallPath
    }}

    if (!(Test-Path $resolvedPluginInstallPath\{4}))
    {{
        Copy-Item -Path $PSHOME\{4} -Destination $resolvedPluginInstallPath -Force -ErrorAction Stop
        if (!(Test-Path $resolvedPluginInstallPath\{4}))
        {{
            Write-Error ($errorMsgUnableToInstallPlugin -f ""{4}"", $resolvedPluginInstallPath)
            return $null
        }}
    }}

    return $resolvedPluginInstallPath
}}

function Register-Endpoint
{{
param(
    [Parameter()] [string] $configurationName
)
    #
    # Section 1:
    # Move pwrshplugin.dll from $PSHOME to the endpoint directory
    #
    # The plugin directory pattern for endpoint configuration is:
    # '$env:WINDIR\System32\PowerShell\' + powershell_version,
    # so we call Copy-PluginToEndpoint function only with the PowerShell version argument.

    $pwshVersion = $configurationName.Replace(""PowerShell."", """")
    $resolvedPluginInstallPath = Copy-PluginToEndpoint $pwshVersion
    if (!$resolvedPluginInstallPath) {{
        return
    }}

    #
    # Section 2:
    # Generate the Plugin Configuration File
    #
    New-PluginConfigFile $resolvedPluginInstallPath

    #
    # Section 3:
    # Register the endpoint
    #
    $null = Register-PSSessionConfiguration -Name $configurationName -force -ErrorAction Stop

    set-item -WarningAction SilentlyContinue wsman:\localhost\plugin\$configurationName\Quotas\MaxShellsPerUser -value ""25"" -confirm:$false
    set-item -WarningAction SilentlyContinue wsman:\localhost\plugin\$configurationName\Quotas\MaxIdleTimeoutms -value {3} -confirm:$false
    restart-service winrm -confirm:$false
}}

function Register-EndpointIfNotPresent
{{
[CmdletBinding(SupportsShouldProcess=$true, ConfirmImpact=""Medium"")]
param(
    [Parameter()] [string] $Name,
    [Parameter()] [bool] $Force,
    [Parameter()] [string] $queryForRegisterDefault,
    [Parameter()] [string] $captionForRegisterDefault
)
    #
    # This cmdlet will make sure default powershell end points exist upon successful completion.
    #
    # Windows PowerShell:
    #   Microsoft.PowerShell
    #   Microsoft.PowerShell32 (wow64)
    #
    # PowerShell:
    #   PowerShell.<version ID>
    #
    $errorCount = $error.Count
    $endPoint = Get-PSSessionConfiguration $Name -Force:$Force -ErrorAction silentlycontinue 2>&1
    $newErrorCount = $error.Count

    # remove the 'No Session Configuration matches criteria' errors
    for ($index = 0; $index -lt ($newErrorCount - $errorCount); $index ++)
    {{
        $error.RemoveAt(0)
    }}

    $qMessage = $queryForRegisterDefault -f ""$Name"",""Register-PSSessionConfiguration {0} -force""
    if ((!$endpoint) -and
        ($force  -or $pscmdlet.ShouldProcess($qMessage, $captionForRegisterDefault)))
    {{
        Register-Endpoint $Name
    }}
}}

function Enable-PSRemoting
{{
[CmdletBinding(SupportsShouldProcess=$true, ConfirmImpact=""Medium"")]
param(
    [Parameter()] [bool] $Force,
    [Parameter()] [string] $queryForRegisterDefault,
    [Parameter()] [string] $captionForRegisterDefault,
    [Parameter()] [string] $queryForSet,
    [Parameter()] [string] $captionForSet,
    [Parameter()] [bool] $skipNetworkProfileCheck,
    [Parameter()] [string] $errorMsgUnableToInstallPlugin
)

    end
    {{
        # Enable all Session Configurations
        try {{
            $null = $PSBoundParameters.Remove(""queryForRegisterDefault"")
            $null = $PSBoundParameters.Remove(""captionForRegisterDefault"")
            $null = $PSBoundParameters.Remove(""queryForSet"")
            $null = $PSBoundParameters.Remove(""captionForSet"")
            $null = $PSBoundParameters.Remove(""errorMsgUnableToInstallPlugin"")

            $PSBoundParameters.Add(""Name"",""*"")

            # first try to enable all the sessions
            Enable-PSSessionConfiguration @PSBoundParameters

            Register-EndpointIfNotPresent -Name {0} $Force $queryForRegisterDefault $captionForRegisterDefault

            # Create the default PSSession configuration, not tied to specific PowerShell version
            # e. g. 'PowerShell.6'.
            $powershellVersionMajor = $PSVersionTable.PSVersion.ToString()
            $dotPos = $powershellVersionMajor.IndexOf(""."")
            if ($dotPos -ne -1) {{
                $powershellVersionMajor = $powershellVersionMajor.Substring(0, $dotPos)
            }}
            # If we are running a Preview version, we don't want to clobber the generic PowerShell.6 endpoint
            # but instead create a PowerShell.6-Preview endpoint
            if ($PSVersionTable.PSVersion.PreReleaseLabel)
            {{
                $powershellVersionMajor += ""-preview""
            }}

            Register-EndpointIfNotPresent -Name (""PowerShell."" + $powershellVersionMajor) $Force $queryForRegisterDefault $captionForRegisterDefault

            # remove the 'network deny all' tag
            Get-PSSessionConfiguration -Force:$Force | ForEach-Object {{
                $sddl = $null
                if ($_.psobject.members[""SecurityDescriptorSddl""])
                {{
                    $sddl = $_.psobject.members[""SecurityDescriptorSddl""].Value
                }}

                if ($sddl)
                {{
                    # Construct SID for network users
                    [system.security.principal.wellknownsidtype]$evst = ""NetworkSid""
                    $networkSID = new-object system.security.principal.securityidentifier $evst,$null

                    $securityIdentifierToPurge = $null
                    $sd = new-object system.security.accesscontrol.commonsecuritydescriptor $false,$false,$sddl
                    $sd.DiscretionaryAcl | ForEach-Object {{
                        if (($_.acequalifier -eq ""accessdenied"") -and ($_.securityidentifier -match $networkSID) -and ($_.AccessMask -eq 268435456))
                        {{
                            $securityIdentifierToPurge = $_.securityidentifier
                        }}
                    }}

                    if ($securityIdentifierToPurge)
                    {{
                        # Remove the specific ACE
                        $sd.discretionaryacl.RemoveAccessSpecific('Deny', $securityIdentifierToPurge, 268435456, 'none', 'none')

                        # if there is no discretionaryacl..add Builtin Administrators and Remote Management Users
                        # to the DACL group as this is the default WSMan behavior
                        if ($sd.discretionaryacl.count -eq 0)
                        {{
                            # Built-in administrators.
                            [system.security.principal.wellknownsidtype]$bast = ""BuiltinAdministratorsSid""
                            $basid = new-object system.security.principal.securityidentifier $bast,$null
                            $sd.DiscretionaryAcl.AddAccess('Allow',$basid, 268435456, 'none', 'none')

                            # Remote Management Users, Win8+ only
                            if ([System.Environment]::OSVersion.Version -ge ""6.2.0.0"")
                            {{
                                $rmSidId = new-object system.security.principal.securityidentifier ""{1}""
                                $sd.DiscretionaryAcl.AddAccess('Allow', $rmSidId, 268435456, 'none', 'none')
                            }}

                            # Interactive Users
                            $iaSidId = new-object system.security.principal.securityidentifier ""{2}""
                            $sd.DiscretionaryAcl.AddAccess('Allow', $iaSidId, 268435456, 'none', 'none')
                        }}

                        $sddl = $sd.GetSddlForm(""all"")
                    }}
                }} ## end of if($sddl)

                $qMessage = $queryForSet -f $_.name,$sddl
                if (($sddl) -and ($force -or $pscmdlet.ShouldProcess($qMessage, $captionForSet)))
                {{
                    $null = Set-PSSessionConfiguration -Name $_.Name -SecurityDescriptorSddl $sddl -NoServiceRestart -force -WarningAction 0
                }}
            }} ## end of foreach-object
        }}
        catch {{
            throw
        }}  # end of catch
    }} # end of end block
}} # end of Enable-PSRemoting

Enable-PSRemoting -force $args[0] -queryForRegisterDefault $args[1] -captionForRegisterDefault $args[2] -queryForSet $args[3] -captionForSet $args[4] -whatif:$args[5] -confirm:$args[6] -skipNetworkProfileCheck $args[7] -errorMsgUnableToInstallPlugin $args[8]
"
        ;

        private static ScriptBlock s_enableRemotingSb;

        static EnablePSRemotingCommand()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1589, 206921, 207702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 196970, 206796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 206836, 206854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 206978, 207379);

                string
                enableRemotingScript = f_1589_207008_207378(f_1589_207022_207050(), enableRemotingSbFormat, f_1589_207093_207157(), PSSessionConfigurationCommandBase.RemoteManagementUsersSID, PSSessionConfigurationCommandBase.InteractiveUsersSID, RemotingConstants.MaxIdleTimeoutMS, RemotingConstants.PSPluginDLLName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 207553, 207615);

                s_enableRemotingSb = f_1589_207574_207614(enableRemotingScript);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 207629, 207691);

                s_enableRemotingSb.LanguageMode = PSLanguageMode.FullLanguage;
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1589, 206921, 207702);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 206921, 207702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 206921, 207702);
            }
        }

        [Parameter()]
        public SwitchParameter Force
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 208070, 208135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 208106, 208120);

                    return _force;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 208070, 208135);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 207994, 208228);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 207994, 208228);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 208151, 208217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 208187, 208202);

                    _force = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 208151, 208217);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 207994, 208228);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 207994, 208228);
                }
            }
        }

        private bool _force;

        [Parameter()]
        public SwitchParameter SkipNetworkProfileCheck
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 208521, 208561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 208527, 208559);

                    return _skipNetworkProfileCheck;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 208521, 208561);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 208427, 208629);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 208427, 208629);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 208577, 208618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 208583, 208616);

                    _skipNetworkProfileCheck = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 208577, 208618);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 208427, 208629);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 208427, 208629);
                }
            }
        }

        private bool _skipNetworkProfileCheck;

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 209013, 209274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 209129, 209184);

                f_1589_209129_209183();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 209198, 209263);

                f_1589_209198_209262();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 209013, 209274);

                int
                f_1589_209129_209183()
                {
                    RemotingCommandUtil.CheckRemotingCmdletPrerequisites();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 209129, 209183);
                    return 0;
                }


                int
                f_1589_209198_209262()
                {
                    PSSessionConfigurationCommandUtilities.ThrowIfNotAdministrator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 209198, 209262);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 209013, 209274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 209013, 209274);
            }
        }

        protected override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 209333, 211188);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 209397, 209462);

                f_1589_209397_209461(this, f_1589_209410_209460());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 209566, 209586);

                bool
                whatIf = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 209653, 209673);

                bool
                confirm = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 209687, 209788);

                f_1589_209687_209787(this, out whatIf, out confirm);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 209804, 209868);

                string
                captionMessage = f_1589_209828_209867()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 209882, 209942);

                string
                queryMessage = f_1589_209904_209941()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 209958, 210079);

                string
                setCaptionMessage = f_1589_209985_210078(f_1589_210003_210047(), "Set-PSSessionConfiguration")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 210093, 210164);

                string
                setQueryMessage = f_1589_210118_210163()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 210180, 211177);

                f_1589_210180_211176(
                            s_enableRemotingSb, contextCmdlet: this, useLocalScope: true, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: f_1589_210423_210443(), input: f_1589_210469_210490(), scriptThis: f_1589_210521_210541(), args: new object[] {
                                               _force,
                                               queryMessage,
                                               captionMessage,
                                               setQueryMessage,
                                               setCaptionMessage,
                                               whatIf,
                                               confirm,
                                               _skipNetworkProfileCheck,
f_1589_211130_211174()});
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 209333, 211188);

                string
                f_1589_209410_209460()
                {
                    var return_v = RemotingErrorIdStrings.PSCoreRemotingEnableWarning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 209410, 209460);
                    return return_v;
                }


                int
                f_1589_209397_209461(Microsoft.PowerShell.Commands.EnablePSRemotingCommand
                this_param, string
                text)
                {
                    this_param.WriteWarning(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 209397, 209461);
                    return 0;
                }


                int
                f_1589_209687_209787(Microsoft.PowerShell.Commands.EnablePSRemotingCommand
                cmdlet, out bool
                whatIf, out bool
                confirm)
                {
                    PSSessionConfigurationCommandUtilities.CollectShouldProcessParameters((System.Management.Automation.PSCmdlet)cmdlet, out whatIf, out confirm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 209687, 209787);
                    return 0;
                }


                string
                f_1589_209828_209867()
                {
                    var return_v = RemotingErrorIdStrings.ERemotingCaption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 209828, 209867);
                    return return_v;
                }


                string
                f_1589_209904_209941()
                {
                    var return_v = RemotingErrorIdStrings.ERemotingQuery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 209904, 209941);
                    return return_v;
                }


                string
                f_1589_210003_210047()
                {
                    var return_v = RemotingErrorIdStrings.CSShouldProcessAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 210003, 210047);
                    return return_v;
                }


                string
                f_1589_209985_210078(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 209985, 210078);
                    return return_v;
                }


                string
                f_1589_210118_210163()
                {
                    var return_v = RemotingErrorIdStrings.EcsShouldProcessTarget;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 210118, 210163);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_210423_210443()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 210423, 210443);
                    return return_v;
                }


                object[]
                f_1589_210469_210490()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 210469, 210490);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_210521_210541()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 210521, 210541);
                    return return_v;
                }


                string
                f_1589_211130_211174()
                {
                    var return_v = RemotingErrorIdStrings.UnableToInstallPlugin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 211130, 211174);
                    return return_v;
                }


                int
                f_1589_210180_211176(System.Management.Automation.ScriptBlock
                this_param, Microsoft.PowerShell.Commands.EnablePSRemotingCommand
                contextCmdlet, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, object[]
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    this_param.InvokeUsingCmdlet(contextCmdlet: (System.Management.Automation.Cmdlet)contextCmdlet, useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 210180, 211176);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 209333, 211188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 209333, 211188);
            }
        }

        public EnablePSRemotingCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1589, 196396, 211217);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 208253, 208259);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 208654, 208678);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1589, 196396, 211217);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 196396, 211217);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1589, 196396, 211217);

        static System.Globalization.CultureInfo
        f_1589_207022_207050()
        {
            var return_v = CultureInfo.InvariantCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 207022, 207050);
            return return_v;
        }


        static string
        f_1589_207093_207157()
        {
            var return_v = PSSessionConfigurationCommandUtilities.GetWinrmPluginShellName();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 207093, 207157);
            return return_v;
        }


        static string
        f_1589_207008_207378(System.Globalization.CultureInfo
        provider, string
        format, params object?[]
        args)
        {
            var return_v = string.Format((System.IFormatProvider)provider, format, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 207008, 207378);
            return return_v;
        }


        static System.Management.Automation.ScriptBlock
        f_1589_207574_207614(string
        script)
        {
            var return_v = ScriptBlock.Create(script);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 207574, 207614);
            return return_v;
        }

    }
    [Cmdlet(VerbsLifecycle.Disable, RemotingConstants.PSRemotingNoun,
            SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium, HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096482")]
    public sealed class DisablePSRemotingCommand : PSCmdlet
    {
        private const string
        disablePSRemotingFormat = @"
function Disable-PSRemoting
{{
[CmdletBinding(SupportsShouldProcess=$true, ConfirmImpact=""Medium"")]
param(
    [Parameter()]
    [switch]
    $force,

    [Parameter()]
    [string]
    $queryForSet,

    [Parameter()]
    [string]
    $captionForSet,

    [Parameter()]
    [string]
    $restartWinRMMessage
)

    begin
    {{
        if ($pscmdlet.ShouldProcess($restartWinRMMessage))
        {{
            $svc = get-service winrm
            if ($svc.Status -match ""Stopped"")
            {{
                Restart-Service winrm -force -confirm:$false
            }}
        }}
    }} # end of begin block

    end
    {{
        # Disable the network for all Session Configurations
        Get-PSSessionConfiguration -Force:$force | ForEach-Object {{

            if ($_.Enabled)
            {{
                $sddl = $null
                if ($_.psobject.members[""SecurityDescriptorSddl""])
                {{
                    $sddl = $_.psobject.members[""SecurityDescriptorSddl""].Value
                }}

                if (!$sddl)
                {{
                    # Disable network users from accessing this configuration
                    $sddl = ""{0}""
                }}
                else
                {{
                    # Construct SID for network users
                    [system.security.principal.wellknownsidtype]$evst = ""NetworkSid""
                    $networkSID = new-object system.security.principal.securityidentifier $evst,$null

                    # Add disable network to the existing sddl
                    $sd = new-object system.security.accesscontrol.commonsecuritydescriptor $false,$false,$sddl
                    $disableNetworkExists = $false
                    $sd.DiscretionaryAcl | ForEach-Object {{
                        if (($_.acequalifier -eq ""accessdenied"") -and ($_.securityidentifier -match $networkSID) -and ($_.AccessMask -eq 268435456))
                        {{
                            $disableNetworkExists = $true
                        }}
                    }}

                    if (!$disableNetworkExists)
                    {{
                        $sd.DiscretionaryAcl.AddAccess(""deny"", $networkSID, 268435456, ""None"", ""None"")
                        $sddl = $sd.GetSddlForm(""all"")
                    }}
                    else
                    {{
                        # since disable network GA already exists, we dont need to change anything.
                        $sddl = $null
                    }}
                }} ## end of if(!$sddl)

                $qMessage = $queryForSet -f $_.name,$sddl
                if (($sddl) -and ($force -or $pscmdlet.ShouldProcess($qMessage, $captionForSet)))
                {{
                    $null = Set-PSSessionConfiguration -Name $_.Name -SecurityDescriptorSddl $sddl -NoServiceRestart -force -WarningAction 0
                }}
            }} ## end of if($_.Enabled)
        }} ## end of %
    }} ## end of Process block
}}

Disable-PSRemoting -force:$args[0] -queryForSet $args[1] -captionForSet $args[2] -restartWinRMMessage $args[3] -whatif:$args[4] -confirm:$args[5]
"
        ;

        private static ScriptBlock s_disableRemotingSb;

        static DisablePSRemotingCommand()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1589, 215302, 215879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 211891, 215165);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 215203, 215222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 215360, 215428);

                string
                localSDDL = f_1589_215379_215427()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 215442, 215553);

                string
                disableRemotingScript = f_1589_215473_215552(f_1589_215487_215515(), disablePSRemotingFormat, localSDDL)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 215727, 215791);

                s_disableRemotingSb = f_1589_215749_215790(disableRemotingScript);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 215805, 215868);

                s_disableRemotingSb.LanguageMode = PSLanguageMode.FullLanguage;
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1589, 215302, 215879);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 215302, 215879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 215302, 215879);
            }
        }

        [Parameter()]
        public SwitchParameter Force
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 216109, 216174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 216145, 216159);

                    return _force;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 216109, 216174);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 216033, 216267);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 216033, 216267);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 216190, 216256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 216226, 216241);

                    _force = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 216190, 216256);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 216033, 216267);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 216033, 216267);
                }
            }
        }

        private bool _force;

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 216483, 216744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 216599, 216654);

                f_1589_216599_216653();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 216668, 216733);

                f_1589_216668_216732();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 216483, 216744);

                int
                f_1589_216599_216653()
                {
                    RemotingCommandUtil.CheckRemotingCmdletPrerequisites();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 216599, 216653);
                    return 0;
                }


                int
                f_1589_216668_216732()
                {
                    PSSessionConfigurationCommandUtilities.ThrowIfNotAdministrator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 216668, 216732);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 216483, 216744);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 216483, 216744);
            }
        }

        protected override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 216843, 218608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 216907, 216973);

                f_1589_216907_216972(this, f_1589_216920_216971());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 216987, 217061);

                f_1589_216987_217060(this, f_1589_217000_217059(f_1589_217018_217058()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 217075, 217174);

                f_1589_217075_217173(this, f_1589_217088_217172(f_1589_217106_217146(), disablePSRemotingFormat));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 217278, 217298);

                bool
                whatIf = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 217365, 217385);

                bool
                confirm = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 217399, 217500);

                f_1589_217399_217499(this, out whatIf, out confirm);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 217516, 217634);

                string
                captionMessage = f_1589_217540_217633(f_1589_217558_217602(), "Set-PSSessionConfiguration")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 217648, 217728);

                string
                queryMessage = f_1589_217670_217727()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 217742, 217814);

                string
                restartWinRMMessage = f_1589_217771_217813()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 217830, 218597);

                f_1589_217830_218596(
                            s_disableRemotingSb, contextCmdlet: this, useLocalScope: true, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: f_1589_218074_218094(), input: f_1589_218120_218141(), scriptThis: f_1589_218172_218192(), args: new object[] {
                                               _force,
                                               queryMessage,
                                               captionMessage,
                                               restartWinRMMessage,
                                               whatIf,
                                               confirm});
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 216843, 218608);

                string
                f_1589_216920_216971()
                {
                    var return_v = RemotingErrorIdStrings.PSCoreRemotingDisableWarning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 216920, 216971);
                    return return_v;
                }


                int
                f_1589_216907_216972(Microsoft.PowerShell.Commands.DisablePSRemotingCommand
                this_param, string
                text)
                {
                    this_param.WriteWarning(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 216907, 216972);
                    return 0;
                }


                string
                f_1589_217018_217058()
                {
                    var return_v = RemotingErrorIdStrings.DcsWarningMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 217018, 217058);
                    return return_v;
                }


                string
                f_1589_217000_217059(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 217000, 217059);
                    return return_v;
                }


                int
                f_1589_216987_217060(Microsoft.PowerShell.Commands.DisablePSRemotingCommand
                this_param, string
                text)
                {
                    this_param.WriteWarning(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 216987, 217060);
                    return 0;
                }


                string
                f_1589_217106_217146()
                {
                    var return_v = RemotingErrorIdStrings.EcsScriptMessageV;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 217106, 217146);
                    return return_v;
                }


                string
                f_1589_217088_217172(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 217088, 217172);
                    return return_v;
                }


                int
                f_1589_217075_217173(Microsoft.PowerShell.Commands.DisablePSRemotingCommand
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 217075, 217173);
                    return 0;
                }


                int
                f_1589_217399_217499(Microsoft.PowerShell.Commands.DisablePSRemotingCommand
                cmdlet, out bool
                whatIf, out bool
                confirm)
                {
                    PSSessionConfigurationCommandUtilities.CollectShouldProcessParameters((System.Management.Automation.PSCmdlet)cmdlet, out whatIf, out confirm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 217399, 217499);
                    return 0;
                }


                string
                f_1589_217558_217602()
                {
                    var return_v = RemotingErrorIdStrings.CSShouldProcessAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 217558, 217602);
                    return return_v;
                }


                string
                f_1589_217540_217633(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 217540, 217633);
                    return return_v;
                }


                string
                f_1589_217670_217727()
                {
                    var return_v = RemotingErrorIdStrings.DisableRemotingShouldProcessTarget;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 217670, 217727);
                    return return_v;
                }


                string
                f_1589_217771_217813()
                {
                    var return_v = RemotingErrorIdStrings.RestartWinRMMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 217771, 217813);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_218074_218094()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 218074, 218094);
                    return return_v;
                }


                object[]
                f_1589_218120_218141()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 218120, 218141);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1589_218172_218192()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 218172, 218192);
                    return return_v;
                }


                int
                f_1589_217830_218596(System.Management.Automation.ScriptBlock
                this_param, Microsoft.PowerShell.Commands.DisablePSRemotingCommand
                contextCmdlet, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, object[]
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    this_param.InvokeUsingCmdlet(contextCmdlet: (System.Management.Automation.Cmdlet)contextCmdlet, useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 217830, 218596);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 216843, 218608);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 216843, 218608);
            }
        }

        public DisablePSRemotingCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1589, 211466, 218653);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 216292, 216298);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1589, 211466, 218653);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 211466, 218653);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1589, 211466, 218653);

        static string
        f_1589_215379_215427()
        {
            var return_v = PSSessionConfigurationCommandBase.GetLocalSddl();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 215379, 215427);
            return return_v;
        }


        static System.Globalization.CultureInfo
        f_1589_215487_215515()
        {
            var return_v = CultureInfo.InvariantCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 215487, 215515);
            return return_v;
        }


        static string
        f_1589_215473_215552(System.Globalization.CultureInfo
        provider, string
        format, string
        arg0)
        {
            var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 215473, 215552);
            return return_v;
        }


        static System.Management.Automation.ScriptBlock
        f_1589_215749_215790(string
        script)
        {
            var return_v = ScriptBlock.Create(script);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 215749, 215790);
            return return_v;
        }

    }
    [Cmdlet(VerbsCommon.Get, "PSSessionCapability", HelpUri = "https://go.microsoft.com/fwlink/?LinkId=623709")]
    [OutputType(new Type[] { typeof(System.Management.Automation.CommandInfo), typeof(System.Management.Automation.Runspaces.InitialSessionState) })]
    public sealed class GetPSSessionCapabilityCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ConfigurationName { get; set; }

        [Parameter(Mandatory = true, Position = 1)]
        public string Username { get; set; }

        [Parameter()]
        public SwitchParameter Full { get; set; }

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1589, 219997, 224662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 220146, 220201);

                f_1589_220146_220200();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 220215, 220280);

                f_1589_220215_220279();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 220357, 220400);

                Collection<PSObject>
                configurations = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 220414, 221142);
                using (PowerShellApi
                invoker = f_1589_220445_220495(RunspaceMode.CurrentRunspace)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 220529, 220659);

                    f_1589_220529_220658(f_1589_220529_220622(f_1589_220529_220577(invoker, "Get-PSSessionConfiguration"), "Name", f_1589_220599_220621(this)), "ErrorAction", "Stop");

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 220803, 220837);

                        configurations = f_1589_220820_220836(invoker);
                    }
                    catch (ActionPreferenceStopException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 220874, 221127);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 220954, 221108);

                        f_1589_220954_221107(this, f_1589_220976_221106(f_1589_220992_221015(f_1589_220992_221005(e)), "CouldNotFindSessionConfiguration", ErrorCategory.ObjectNotFound, f_1589_221083_221105(this)));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 220874, 221127);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1589, 220414, 221142);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 221228, 221274);

                Func<string, bool>
                validator = (role) => true
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 221290, 222739) || true) && (!f_1589_221295_221330(f_1589_221316_221329(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 221290, 222739);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 221364, 221822) || true) && (f_1589_221368_221396(f_1589_221368_221381(this), '\\'))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 221364, 221822);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 221438, 221455);

                        validator = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 221548, 221621);

                        string[]
                        upnComponents = f_1589_221573_221620(f_1589_221573_221586(this), Utils.Separators.Backslash)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 221643, 221803) || true) && (f_1589_221647_221667(upnComponents) == 2)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 221643, 221803);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 221722, 221780);

                            this.Username = upnComponents[1] + "@" + upnComponents[0];
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 221643, 221803);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 221364, 221822);
                    }

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 221886, 222083);

                        System.Security.Principal.WindowsPrincipal
                        windowsPrincipal = f_1589_221948_222082(f_1589_222021_222081(f_1589_222067_222080(this)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 222105, 222159);

                        validator = (role) => windowsPrincipal.IsInRole(role);
                    }
                    catch (SecurityException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1589, 222196, 222724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 222317, 222415);

                        string
                        message = f_1589_222334_222414(f_1589_222352_222398(), f_1589_222400_222413(this))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 222437, 222495);

                        ArgumentException
                        ioe = f_1589_222461_222494(message, e)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 222517, 222628);

                        ErrorRecord
                        er = f_1589_222534_222627(ioe, "CouldNotResolveUsername", ErrorCategory.InvalidArgument, f_1589_222613_222626(this))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 222650, 222676);

                        f_1589_222650_222675(this, er);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 222698, 222705);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1589, 222196, 222724);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 221290, 222739);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 222755, 224651);
                    foreach (PSObject foundConfiguration in f_1589_222795_222809_I(configurations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 222755, 224651);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 222843, 222872);

                        string
                        configFilePath = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 222890, 222978);

                        PSPropertyInfo
                        configFilePathProperty = f_1589_222930_222977(f_1589_222930_222959(foundConfiguration), "ConfigFilePath")
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 222996, 223147) || true) && (configFilePathProperty != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 222996, 223147);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 223072, 223128);

                            configFilePath = f_1589_223089_223117(configFilePathProperty) as string;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 222996, 223147);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 223344, 223941) || true) && (configFilePath == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 223344, 223941);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 223412, 223491);

                            string
                            configurationName = (string)f_1589_223447_223490(f_1589_223447_223484(f_1589_223447_223476(foundConfiguration), "Name"))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 223513, 223627);

                            string
                            message = f_1589_223530_223626(f_1589_223548_223606(), configurationName)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 223649, 223704);

                            ArgumentException
                            ioe = f_1589_223673_223703(message)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 223726, 223854);

                            ErrorRecord
                            er = f_1589_223743_223853(ioe, "SessionConfigurationMustBeFileBased", ErrorCategory.InvalidArgument, foundConfiguration)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 223876, 223891);

                            f_1589_223876_223890(this, er);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 223913, 223922);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 223344, 223941);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 223961, 224069);

                        InitialSessionState
                        iss = f_1589_223987_224068(configFilePath, validator)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 224087, 224636) || true) && (f_1589_224091_224100(this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 224087, 224636);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 224142, 224159);

                            f_1589_224142_224158(this, iss);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 224087, 224636);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 224087, 224636);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 224241, 224617);
                            using (PowerShellApi
                            analyzer = f_1589_224273_224298(iss)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 224348, 224418);

                                f_1589_224348_224417(f_1589_224348_224382(analyzer, "Get-Command"), "CommandType", "All");
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 224444, 224594);
                                    foreach (PSObject output in f_1589_224472_224489_I(f_1589_224472_224489(analyzer)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1589, 224444, 224594);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 224547, 224567);

                                        f_1589_224547_224566(this, output);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 224444, 224594);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1589, 1, 151);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1589, 1, 151);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitUsing(1589, 224241, 224617);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 224087, 224636);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1589, 222755, 224651);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1589, 1, 1897);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1589, 1, 1897);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1589, 219997, 224662);

                int
                f_1589_220146_220200()
                {
                    RemotingCommandUtil.CheckRemotingCmdletPrerequisites();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 220146, 220200);
                    return 0;
                }


                int
                f_1589_220215_220279()
                {
                    PSSessionConfigurationCommandUtilities.ThrowIfNotAdministrator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 220215, 220279);
                    return 0;
                }


                System.Management.Automation.PowerShell
                f_1589_220445_220495(System.Management.Automation.RunspaceMode
                runspace)
                {
                    var return_v = PowerShellApi.Create(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 220445, 220495);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1589_220529_220577(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 220529, 220577);
                    return return_v;
                }


                string
                f_1589_220599_220621(Microsoft.PowerShell.Commands.GetPSSessionCapabilityCommand
                this_param)
                {
                    var return_v = this_param.ConfigurationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 220599, 220621);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1589_220529_220622(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 220529, 220622);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1589_220529_220658(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 220529, 220658);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1589_220820_220836(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 220820, 220836);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1589_220992_221005(System.Management.Automation.ActionPreferenceStopException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 220992, 221005);
                    return return_v;
                }


                System.Exception
                f_1589_220992_221015(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 220992, 221015);
                    return return_v;
                }


                string
                f_1589_221083_221105(Microsoft.PowerShell.Commands.GetPSSessionCapabilityCommand
                this_param)
                {
                    var return_v = this_param.ConfigurationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 221083, 221105);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1589_220976_221106(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 220976, 221106);
                    return return_v;
                }


                int
                f_1589_220954_221107(Microsoft.PowerShell.Commands.GetPSSessionCapabilityCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 220954, 221107);
                    return 0;
                }


                string
                f_1589_221316_221329(Microsoft.PowerShell.Commands.GetPSSessionCapabilityCommand
                this_param)
                {
                    var return_v = this_param.Username;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 221316, 221329);
                    return return_v;
                }


                bool
                f_1589_221295_221330(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 221295, 221330);
                    return return_v;
                }


                string
                f_1589_221368_221381(Microsoft.PowerShell.Commands.GetPSSessionCapabilityCommand
                this_param)
                {
                    var return_v = this_param.Username;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 221368, 221381);
                    return return_v;
                }


                bool
                f_1589_221368_221396(string
                this_param, char
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 221368, 221396);
                    return return_v;
                }


                string
                f_1589_221573_221586(Microsoft.PowerShell.Commands.GetPSSessionCapabilityCommand
                this_param)
                {
                    var return_v = this_param.Username;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 221573, 221586);
                    return return_v;
                }


                string[]
                f_1589_221573_221620(string
                this_param, params char[]
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 221573, 221620);
                    return return_v;
                }


                int
                f_1589_221647_221667(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 221647, 221667);
                    return return_v;
                }


                string
                f_1589_222067_222080(Microsoft.PowerShell.Commands.GetPSSessionCapabilityCommand
                this_param)
                {
                    var return_v = this_param.Username;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 222067, 222080);
                    return return_v;
                }


                System.Security.Principal.WindowsIdentity
                f_1589_222021_222081(string
                sUserPrincipalName)
                {
                    var return_v = new System.Security.Principal.WindowsIdentity(sUserPrincipalName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 222021, 222081);
                    return return_v;
                }


                System.Security.Principal.WindowsPrincipal
                f_1589_221948_222082(System.Security.Principal.WindowsIdentity
                ntIdentity)
                {
                    var return_v = new System.Security.Principal.WindowsPrincipal(ntIdentity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 221948, 222082);
                    return return_v;
                }


                string
                f_1589_222352_222398()
                {
                    var return_v = RemotingErrorIdStrings.CouldNotResolveUsername;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 222352, 222398);
                    return return_v;
                }


                string
                f_1589_222400_222413(Microsoft.PowerShell.Commands.GetPSSessionCapabilityCommand
                this_param)
                {
                    var return_v = this_param.Username;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 222400, 222413);
                    return return_v;
                }


                string
                f_1589_222334_222414(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 222334, 222414);
                    return return_v;
                }


                System.ArgumentException
                f_1589_222461_222494(string
                message, System.Security.SecurityException
                innerException)
                {
                    var return_v = new System.ArgumentException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 222461, 222494);
                    return return_v;
                }


                string
                f_1589_222613_222626(Microsoft.PowerShell.Commands.GetPSSessionCapabilityCommand
                this_param)
                {
                    var return_v = this_param.Username;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 222613, 222626);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1589_222534_222627(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 222534, 222627);
                    return return_v;
                }


                int
                f_1589_222650_222675(Microsoft.PowerShell.Commands.GetPSSessionCapabilityCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 222650, 222675);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1589_222930_222959(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 222930, 222959);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1589_222930_222977(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 222930, 222977);
                    return return_v;
                }


                object
                f_1589_223089_223117(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 223089, 223117);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1589_223447_223476(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 223447, 223476);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1589_223447_223484(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 223447, 223484);
                    return return_v;
                }


                object
                f_1589_223447_223490(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 223447, 223490);
                    return return_v;
                }


                string
                f_1589_223548_223606()
                {
                    var return_v = RemotingErrorIdStrings.SessionConfigurationMustBeFileBased;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 223548, 223606);
                    return return_v;
                }


                string
                f_1589_223530_223626(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 223530, 223626);
                    return return_v;
                }


                System.ArgumentException
                f_1589_223673_223703(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 223673, 223703);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1589_223743_223853(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.PSObject
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 223743, 223853);
                    return return_v;
                }


                int
                f_1589_223876_223890(Microsoft.PowerShell.Commands.GetPSSessionCapabilityCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 223876, 223890);
                    return 0;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_1589_223987_224068(string
                path, System.Func<string, bool>
                roleVerifier)
                {
                    var return_v = InitialSessionState.CreateFromSessionConfigurationFile(path, roleVerifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 223987, 224068);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1589_224091_224100(Microsoft.PowerShell.Commands.GetPSSessionCapabilityCommand
                this_param)
                {
                    var return_v = this_param.Full;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 224091, 224100);
                    return return_v;
                }


                int
                f_1589_224142_224158(Microsoft.PowerShell.Commands.GetPSSessionCapabilityCommand
                this_param, System.Management.Automation.Runspaces.InitialSessionState
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 224142, 224158);
                    return 0;
                }


                System.Management.Automation.PowerShell
                f_1589_224273_224298(System.Management.Automation.Runspaces.InitialSessionState
                initialSessionState)
                {
                    var return_v = PowerShellApi.Create(initialSessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 224273, 224298);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1589_224348_224382(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 224348, 224382);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1589_224348_224417(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 224348, 224417);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1589_224472_224489(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 224472, 224489);
                    return return_v;
                }


                int
                f_1589_224547_224566(Microsoft.PowerShell.Commands.GetPSSessionCapabilityCommand
                this_param, System.Management.Automation.PSObject
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 224547, 224566);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1589_224472_224489_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 224472, 224489);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1589_222795_222809_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1589, 222795, 222809);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 219997, 224662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 219997, 224662);
            }
        }

        public GetPSSessionCapabilityCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1589, 218856, 224669);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 219341, 219439);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 219577, 219666);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1589, 218856, 224669);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 218856, 224669);
        }


        static GetPSSessionCapabilityCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1589, 218856, 224669);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1589, 218856, 224669);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 218856, 224669);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1589, 218856, 224669);
    }

}

namespace Microsoft.PowerShell.Commands.Internal
{
    public static class RemotingErrorResources
    {
        public static string WinRMRestartWarning
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 225025, 225083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 225031, 225081);

                    return f_1589_225038_225080();
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 225025, 225083);

                    string
                    f_1589_225038_225080()
                    {
                        var return_v = RemotingErrorIdStrings.WinRMRestartWarning;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 225038, 225080);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 224982, 225085);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 224982, 225085);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static string CouldNotResolveRoleDefinitionPrincipal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1589, 225206, 225283);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1589, 225212, 225281);

                    return f_1589_225219_225280();
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1589, 225206, 225283);

                    string
                    f_1589_225219_225280()
                    {
                        var return_v = RemotingErrorIdStrings.CouldNotResolveRoleDefinitionPrincipal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1589, 225219, 225280);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1589, 225144, 225285);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 225144, 225285);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static RemotingErrorResources()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1589, 224876, 225292);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1589, 224876, 225292);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1589, 224876, 225292);
        }

    }
}
