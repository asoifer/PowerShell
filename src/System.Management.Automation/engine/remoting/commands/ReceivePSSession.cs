// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting;
using System.Management.Automation.Remoting.Client;
using System.Management.Automation.Runspaces;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell.Commands
{
[SuppressMessage("Microsoft.PowerShell", "PS1012:CallShouldProcessOnlyIfDeclaringSupport")]
    [Cmdlet(VerbsCommunications.Receive, "PSSession", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Low,
        DefaultParameterSetName = ReceivePSSessionCommand.SessionParameterSet, HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096800",
        RemotingCapability = RemotingCapability.OwnedByCommand)]
    public class ReceivePSSessionCommand : PSRemotingCmdlet
{
private const string 
IdParameterSet = "Id"
;

private const string 
InstanceIdParameterSet = "InstanceId"
;

private const string 
NameParameterSet = "SessionName"
;

private const string 
ComputerSessionNameParameterSet = "ComputerSessionName"
;

private const string 
ConnectionUriSessionNameParameterSet = "ConnectionUriSessionName"
;

private const string 
ConnectionUriInstanceIdParameterSet = "ConnectionUriInstanceId"
;

[Parameter(Position = 0,
                   Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ValueFromPipeline = true,
                   ParameterSetName = ReceivePSSessionCommand.SessionParameterSet)]
        [ValidateNotNullOrEmpty]
        public PSSession Session {get; set; }

[Parameter(Position = 0,
                   Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ValueFromPipeline = true,
                   ParameterSetName = ReceivePSSessionCommand.IdParameterSet)]
        public int Id {get; set; }

[Parameter(Position = 0,
                   Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = ReceivePSSessionCommand.ComputerSessionNameParameterSet)]
        [Parameter(Position = 0,
                   Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = ReceivePSSessionCommand.ComputerInstanceIdParameterSet)]
        [ValidateNotNullOrEmpty]
        [Alias("Cn")]
        public string ComputerName {get; set; }

[Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = ReceivePSSessionCommand.ComputerSessionNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = ReceivePSSessionCommand.ComputerInstanceIdParameterSet)]
        public string ApplicationName
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,6211,6235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,6217,6233);

return _appName;
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,6211,6235);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,5844,6346);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,5844,6346);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,6251,6335);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,6287,6320);

_appName = f_1605_6298_6319(this, value);
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,6251,6335);

string
f_1605_6298_6319(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,string
appName)
{
var return_v = this_param.ResolveAppName( appName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 6298, 6319);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,5844,6346);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,5844,6346);
}
		}}

private string _appName;

[Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = ReceivePSSessionCommand.ComputerSessionNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = ReceivePSSessionCommand.ComputerInstanceIdParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = ReceivePSSessionCommand.ConnectionUriSessionNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = ReceivePSSessionCommand.ConnectionUriInstanceIdParameterSet)]
        public string ConfigurationName
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,7360,7382);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,7366,7380);

return _shell;
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,7360,7382);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,6668,7489);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,6668,7489);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,7398,7478);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,7434,7463);

_shell = f_1605_7443_7462(this, value);
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,7398,7478);

string
f_1605_7443_7462(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,string
shell)
{
var return_v = this_param.ResolveShell( shell);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 7443, 7462);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,6668,7489);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,6668,7489);
}
		}}

private string _shell;

[Parameter(Position = 0, Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = ReceivePSSessionCommand.ConnectionUriSessionNameParameterSet)]
        [Parameter(Position = 0, Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = ReceivePSSessionCommand.ConnectionUriInstanceIdParameterSet)]
        [ValidateNotNullOrEmpty]
        [Alias("URI", "CU")]
        public Uri ConnectionUri {get; set; }

[Parameter(ParameterSetName = ReceivePSSessionCommand.ConnectionUriSessionNameParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ConnectionUriInstanceIdParameterSet)]
        public SwitchParameter AllowRedirection
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,8658,8691);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,8664,8689);

return _allowRedirection;
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,8658,8691);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,8391,8752);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,8391,8752);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,8707,8741);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,8713,8739);

_allowRedirection = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,8707,8741);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,8391,8752);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,8391,8752);
}
		}}

private bool _allowRedirection ;

[Parameter(Position = 0,
                   Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ValueFromPipeline = true,
                   ParameterSetName = ReceivePSSessionCommand.InstanceIdParameterSet)]
        [Parameter(Mandatory = true,
                   ParameterSetName = ReceivePSSessionCommand.ComputerInstanceIdParameterSet)]
        [Parameter(Mandatory = true,
                   ParameterSetName = ReceivePSSessionCommand.ConnectionUriInstanceIdParameterSet)]
        [ValidateNotNullOrEmpty]
        public Guid InstanceId {get; set; }

[Parameter(Position = 0,
                   Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ValueFromPipeline = true,
                   ParameterSetName = ReceivePSSessionCommand.NameParameterSet)]
        [Parameter(Mandatory = true,
                   ParameterSetName = ReceivePSSessionCommand.ComputerSessionNameParameterSet)]
        [Parameter(Mandatory = true,
                   ParameterSetName = ReceivePSSessionCommand.ConnectionUriSessionNameParameterSet)]
        [ValidateNotNullOrEmpty]
        public string Name {get; set; }

[Parameter(ParameterSetName = ReceivePSSessionCommand.SessionParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.IdParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.InstanceIdParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.NameParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ComputerInstanceIdParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ComputerSessionNameParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ConnectionUriSessionNameParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ConnectionUriInstanceIdParameterSet)]
        public OutTarget OutTarget {get; set; }

[Parameter(ParameterSetName = ReceivePSSessionCommand.SessionParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.IdParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.InstanceIdParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.NameParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ComputerInstanceIdParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ComputerSessionNameParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ConnectionUriSessionNameParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ConnectionUriInstanceIdParameterSet)]
        [ValidateNotNullOrEmpty]
        public string JobName {get; set; }

[Parameter(ParameterSetName = ReceivePSSessionCommand.ComputerInstanceIdParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ComputerSessionNameParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ConnectionUriSessionNameParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ConnectionUriInstanceIdParameterSet)]
        [Credential()]
        public PSCredential Credential
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,12878,12907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,12884,12905);

return _psCredential;
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,12878,12907);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,12403,13131);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,12403,13131);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,12923,13120);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,12959,12981);

_psCredential = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,13001,13105);

f_1605_13001_13104(f_1605_13054_13064(), f_1605_13066_13087(), f_1605_13089_13103());
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,12923,13120);

System.Management.Automation.PSCredential
f_1605_13054_13064()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 13054, 13064);
return return_v;
}


string
f_1605_13066_13087()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 13066, 13087);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1605_13089_13103()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 13089, 13103);
return return_v;
}


int
f_1605_13001_13104(System.Management.Automation.PSCredential
credential,string
thumbprint,System.Management.Automation.Runspaces.AuthenticationMechanism
authentication)
{
PSRemotingBaseCmdlet.ValidateSpecifiedAuthentication( credential, thumbprint, authentication);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 13001, 13104);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,12403,13131);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,12403,13131);
}
		}}

private PSCredential _psCredential;

[Parameter(ParameterSetName = ReceivePSSessionCommand.ComputerInstanceIdParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ComputerSessionNameParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ConnectionUriSessionNameParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ConnectionUriInstanceIdParameterSet)]
        public AuthenticationMechanism Authentication
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,13767,13798);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,13773,13796);

return _authentication;
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,13767,13798);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,13301,14024);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,13301,14024);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,13814,14013);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,13850,13874);

_authentication = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,13894,13998);

f_1605_13894_13997(f_1605_13947_13957(), f_1605_13959_13980(), f_1605_13982_13996());
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,13814,14013);

System.Management.Automation.PSCredential
f_1605_13947_13957()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 13947, 13957);
return return_v;
}


string
f_1605_13959_13980()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 13959, 13980);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1605_13982_13996()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 13982, 13996);
return return_v;
}


int
f_1605_13894_13997(System.Management.Automation.PSCredential
credential,string
thumbprint,System.Management.Automation.Runspaces.AuthenticationMechanism
authentication)
{
PSRemotingBaseCmdlet.ValidateSpecifiedAuthentication( credential, thumbprint, authentication);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 13894, 13997);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,13301,14024);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,13301,14024);
}
		}}

private AuthenticationMechanism _authentication;

[Parameter(ParameterSetName = ReceivePSSessionCommand.ComputerInstanceIdParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ComputerSessionNameParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ConnectionUriSessionNameParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ConnectionUriInstanceIdParameterSet)]
        public string CertificateThumbprint
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,14720,14747);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,14726,14745);

return _thumbprint;
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,14720,14747);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,14264,14969);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,14264,14969);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,14763,14958);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,14799,14819);

_thumbprint = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,14839,14943);

f_1605_14839_14942(f_1605_14892_14902(), f_1605_14904_14925(), f_1605_14927_14941());
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,14763,14958);

System.Management.Automation.PSCredential
f_1605_14892_14902()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 14892, 14902);
return return_v;
}


string
f_1605_14904_14925()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 14904, 14925);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1605_14927_14941()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 14927, 14941);
return return_v;
}


int
f_1605_14839_14942(System.Management.Automation.PSCredential
credential,string
thumbprint,System.Management.Automation.Runspaces.AuthenticationMechanism
authentication)
{
PSRemotingBaseCmdlet.ValidateSpecifiedAuthentication( credential, thumbprint, authentication);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 14839, 14942);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,14264,14969);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,14264,14969);
}
		}}

private string _thumbprint;

[Parameter(ParameterSetName = ReceivePSSessionCommand.ComputerInstanceIdParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ComputerSessionNameParameterSet)]
        [ValidateRange((int)1, (int)UInt16.MaxValue)]
        public int Port {get; set; }

[Parameter(ParameterSetName = ReceivePSSessionCommand.ComputerInstanceIdParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ComputerSessionNameParameterSet)]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SSL")]
        public SwitchParameter UseSSL {get; set; }

[Parameter(ParameterSetName = ReceivePSSessionCommand.ComputerInstanceIdParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ComputerSessionNameParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ConnectionUriSessionNameParameterSet)]
        [Parameter(ParameterSetName = ReceivePSSessionCommand.ConnectionUriInstanceIdParameterSet)]
        public PSSessionOption SessionOption {get; set; }

protected override void ProcessRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,17271,18020);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,17335,18009) || true) && (f_1605_17339_17355()== ReceivePSSessionCommand.ComputerSessionNameParameterSet ||(DynAbs.Tracing.TraceSender.Expression_False(1605, 17339, 17515)||f_1605_17435_17451()== ReceivePSSessionCommand.ConnectionUriSessionNameParameterSet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,17335,18009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,17549,17594);

f_1605_17549_17593(this, f_1605_17576_17580(), Guid.Empty);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,17335,18009);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,17335,18009);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,17628,18009) || true) && (f_1605_17632_17648()== ReceivePSSessionCommand.ComputerInstanceIdParameterSet ||(DynAbs.Tracing.TraceSender.Expression_False(1605, 17632, 17811)||f_1605_17732_17748()== ReceivePSSessionCommand.ConnectionUriInstanceIdParameterSet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,17628,18009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,17845,17898);

f_1605_17845_17897(this, string.Empty, f_1605_17886_17896());
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,17628,18009);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,17628,18009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,17964,17994);

f_1605_17964_17993(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,17628,18009);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,17335,18009);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,17271,18020);

string
f_1605_17339_17355()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 17339, 17355);
return return_v;
}


string
f_1605_17435_17451()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 17435, 17451);
return return_v;
}


string
f_1605_17576_17580()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 17576, 17580);
return return_v;
}


int
f_1605_17549_17593(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,string
name,System.Guid
instanceId)
{
this_param.QueryForAndConnectCommands( name, instanceId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 17549, 17593);
return 0;
}


string
f_1605_17632_17648()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 17632, 17648);
return return_v;
}


string
f_1605_17732_17748()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 17732, 17748);
return return_v;
}


System.Guid
f_1605_17886_17896()
{
var return_v = InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 17886, 17896);
return return_v;
}


int
f_1605_17845_17897(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,string
name,System.Guid
instanceId)
{
this_param.QueryForAndConnectCommands( name, instanceId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 17845, 17897);
return 0;
}


int
f_1605_17964_17993(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param)
{
this_param.GetAndConnectSessionCommand();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 17964, 17993);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,17271,18020);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,17271,18020);
}
		}

protected override void StopProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,18134,18659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,18199,18226);

RemotePipeline 
tmpPipeline
=default(RemotePipeline);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,18240,18251);

Job 
tmpJob
=default(Job);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,18273,18284);

            lock (_syncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,18318,18341);

_stopProcessing = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,18359,18389);

tmpPipeline = _remotePipeline;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,18407,18421);

tmpJob = _job;
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,18452,18548) || true) && (tmpPipeline != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,18452,18548);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,18509,18533);

f_1605_18509_18532(                tmpPipeline);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,18452,18548);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,18564,18648) || true) && (tmpJob != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,18564,18648);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,18616,18633);

f_1605_18616_18632(                tmpJob);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,18564,18648);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,18134,18659);

int
f_1605_18509_18532(System.Management.Automation.RemotePipeline
this_param)
{
this_param.StopAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 18509, 18532);
return 0;
}


int
f_1605_18616_18632(System.Management.Automation.Job
this_param)
{
this_param.StopJob();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 18616, 18632);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,18134,18659);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,18134,18659);
}
		}

private void QueryForAndConnectCommands(string name, Guid instanceId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,19235,26454);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,19329,19388);

WSManConnectionInfo 
connectionInfo = f_1605_19366_19387(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,19480,19501);

Runspace[] 
runspaces
=default(Runspace[]);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,19551,19646);

runspaces = f_1605_19563_19645(connectionInfo, f_1605_19601_19610(this), f_1605_19612_19644());
            }
            catch (System.Management.Automation.RuntimeException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1605,19675,20413);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,19763,19777);

int 
errorCode
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,19795,19988);

string 
msg = f_1605_19808_19987(f_1605_19826_19872(), f_1605_19874_19901(connectionInfo), f_1605_19924_19986(f_1605_19954_19970(e), out errorCode))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,20006,20127);

string 
FQEID = f_1605_20021_20126(errorCode, "ReceivePSSessionQueryForSessionFailed")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,20145,20208);

Exception 
reason = f_1605_20164_20207(msg, f_1605_20190_20206(e))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,20226,20331);

ErrorRecord 
errorRecord = f_1605_20252_20330(reason, FQEID, ErrorCategory.InvalidOperation, connectionInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,20349,20373);

f_1605_20349_20372(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,20391,20398);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1605,19675,20413);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,20503,20526);

string 
shellUri = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,20540,20972) || true) && (!f_1605_20545_20584(f_1605_20566_20583()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,20540,20972);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,20618,20957);

shellUri = (DynAbs.Tracing.TraceSender.Conditional_F1(1605, 20629, 20807)||(((f_1605_20630_20800(f_1605_20630_20647(), System.Management.Automation.Remoting.Client.WSManNativeApi.ResourceURIPrefix, StringComparison.OrdinalIgnoreCase)!= -1) &&DynAbs.Tracing.TraceSender.Conditional_F2(1605, 20839, 20856))||DynAbs.Tracing.TraceSender.Conditional_F3(1605, 20859, 20956)))?f_1605_20839_20856():System.Management.Automation.Remoting.Client.WSManNativeApi.ResourceURIPrefix + f_1605_20939_20956();
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,20540,20972);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,21104,26443);
foreach(Runspace runspace in f_1605_21134_21143_I(runspaces) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,21104,26443);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,21177,21263) || true) && (_stopProcessing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,21177,21263);
DynAbs.Tracing.TraceSender.TraceBreak(1605,21238,21244);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,21177,21263);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,21363,21855) || true) && (shellUri != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,21363,21855);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,21501,21590);

WSManConnectionInfo 
wsmanConnectionInfo = f_1605_21543_21566(runspace)as WSManConnectionInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,21612,21836) || true) && (wsmanConnectionInfo != null &&(DynAbs.Tracing.TraceSender.Expression_True(1605, 21616, 21754)&&                        !f_1605_21673_21754(shellUri, f_1605_21689_21717(wsmanConnectionInfo), StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,21612,21836);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,21804,21813);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,21612,21836);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,21363,21855);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,21919,21942);

bool 
haveMatch = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,21960,22539) || true) && (!f_1605_21965_21991(name)&&(DynAbs.Tracing.TraceSender.Expression_True(1605, 21964, 22150)&&f_1605_22016_22145(name, f_1605_22037_22108(f_1605_22037_22103(f_1605_22037_22076(((RemoteRunspace)runspace)))), StringComparison.OrdinalIgnoreCase)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,21960,22539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,22243,22260);

haveMatch = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,21960,22539);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,21960,22539);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,22302,22539) || true) && (instanceId.Equals(f_1605_22324_22343(runspace)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,22302,22539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,22503,22520);

haveMatch = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,22302,22539);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,21960,22539);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,22559,26428) || true) && (haveMatch &&(DynAbs.Tracing.TraceSender.Expression_True(1605, 22563, 22681)&&f_1605_22597_22681(this, f_1605_22611_22651(((RemoteRunspace)runspace)), VerbsCommunications.Receive)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,22559,26428);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,22806,22882);

PSSession 
locSession = f_1605_22829_22881(f_1605_22829_22852(this), f_1605_22861_22880(runspace))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,23054,23067);

Exception 
ex
=default(Exception);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,23089,23153);

PSSession 
connectedSession = f_1605_23118_23152(this, locSession, out ex)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,23177,26379) || true) && (connectedSession != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,23177,26379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,23491,23546);

f_1605_23491_23545(f_1605_23491_23514(this), connectedSession);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,23740,23796);

PSRemotingJob 
job = f_1605_23760_23795(this, connectedSession)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,23822,24213) || true) && (f_1605_23826_23840(this)== OutTarget.Host)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,23822,24213);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,23916,23960);

f_1605_23916_23959(this, connectedSession, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,23822,24213);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,23822,24213);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,24143,24186);

f_1605_24143_24185(this, connectedSession, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,23822,24213);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,23177,26379);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,23177,26379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,24528,24593);

PSSession 
newSession = f_1605_24551_24592(runspace as RemoteRunspace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,24619,24673);

connectedSession = f_1605_24638_24672(this, newSession, out ex);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,24699,26356) || true) && (connectedSession != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,24699,26356);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,24878,25119) || true) && (locSession != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,24878,25119);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,24966,25088);

connectedSession = (DynAbs.Tracing.TraceSender.Conditional_F1(1605, 24985, 25055)||((f_1605_24985_25055(locSession, f_1605_25011_25036(connectedSession)as RemoteRunspace)&&DynAbs.Tracing.TraceSender.Conditional_F2(1605, 25058, 25068))||DynAbs.Tracing.TraceSender.Conditional_F3(1605, 25071, 25087)))?locSession :connectedSession;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,24878,25119);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,25395,25450);

f_1605_25395_25449(f_1605_25395_25418(this), connectedSession);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,25482,25895) || true) && (f_1605_25486_25500(this)== OutTarget.Job)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,25482,25895);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,25583,25621);

f_1605_25583_25620(this, connectedSession);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,25482,25895);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,25482,25895);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,25825,25864);

f_1605_25825_25863(this, connectedSession);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,25482,25895);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,24699,26356);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,24699,26356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,26009,26111);

string 
message = f_1605_26026_26110(f_1605_26044_26092(), f_1605_26094_26109(newSession))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,26141,26329);

f_1605_26141_26328(this, f_1605_26152_26327(f_1605_26168_26202(message, ex), "ReceivePSSessionCannotConnectSession", ErrorCategory.InvalidOperation, newSession));
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,24699,26356);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,23177,26379);
}
DynAbs.Tracing.TraceSender.TraceBreak(1605,26403,26409);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,22559,26428);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,21104,26443);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1605,1,5340);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1605,1,5340);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1605,19235,26454);

System.Management.Automation.Runspaces.WSManConnectionInfo
f_1605_19366_19387(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param)
{
var return_v = this_param.GetConnectionObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 19366, 19387);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1605_19601_19610(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 19601, 19610);
return return_v;
}


System.Management.Automation.Runspaces.TypeTable
f_1605_19612_19644()
{
var return_v = QueryRunspaces.BuiltInTypesTable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 19612, 19644);
return return_v;
}


System.Management.Automation.Runspaces.Runspace[]
f_1605_19563_19645(System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Runspaces.TypeTable
typeTable)
{
var return_v = Runspace.GetRunspaces( (System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host, typeTable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 19563, 19645);
return return_v;
}


string
f_1605_19826_19872()
{
var return_v = RemotingErrorIdStrings.QueryForRunspacesFailed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 19826, 19872);
return return_v;
}


string
f_1605_19874_19901(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 19874, 19901);
return return_v;
}


System.Exception
f_1605_19954_19970(System.Management.Automation.RuntimeException
this_param)
{
var return_v = this_param.InnerException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 19954, 19970);
return return_v;
}


string
f_1605_19924_19986(System.Exception
e,out int
errorCode)
{
var return_v = QueryRunspaces.ExtractMessage( e, out errorCode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 19924, 19986);
return return_v;
}


string
f_1605_19808_19987(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 19808, 19987);
return return_v;
}


string
f_1605_20021_20126(int
transportErrorCode,string
defaultFQEID)
{
var return_v = WSManTransportManagerUtils.GetFQEIDFromTransportError( transportErrorCode, defaultFQEID);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 20021, 20126);
return return_v;
}


System.Exception
f_1605_20190_20206(System.Management.Automation.RuntimeException
this_param)
{
var return_v = this_param.InnerException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 20190, 20206);
return return_v;
}


System.Management.Automation.RuntimeException
f_1605_20164_20207(string
message,System.Exception
innerException)
{
var return_v = new System.Management.Automation.RuntimeException( message, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 20164, 20207);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1605_20252_20330(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Runspaces.WSManConnectionInfo
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 20252, 20330);
return return_v;
}


int
f_1605_20349_20372(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 20349, 20372);
return 0;
}


string
f_1605_20566_20583()
{
var return_v = ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 20566, 20583);
return return_v;
}


bool
f_1605_20545_20584(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 20545, 20584);
return return_v;
}


string
f_1605_20630_20647()
{
var return_v = ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 20630, 20647);
return return_v;
}


int
f_1605_20630_20800(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.IndexOf( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 20630, 20800);
return return_v;
}


string
f_1605_20839_20856()
{
var return_v = ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 20839, 20856);
return return_v;
}


string
f_1605_20939_20956()
{
var return_v = ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 20939, 20956);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1605_21543_21566(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.ConnectionInfo ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 21543, 21566);
return return_v;
}


string
f_1605_21689_21717(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.ShellUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 21689, 21717);
return return_v;
}


bool
f_1605_21673_21754(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 21673, 21754);
return return_v;
}


bool
f_1605_21965_21991(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 21965, 21991);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1605_22037_22076(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 22037, 22076);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1605_22037_22103(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 22037, 22103);
return return_v;
}


string
f_1605_22037_22108(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 22037, 22108);
return return_v;
}


int
f_1605_22016_22145(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 22016, 22145);
return return_v;
}


System.Guid
f_1605_22324_22343(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 22324, 22343);
return return_v;
}


string
f_1605_22611_22651(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.PSSessionName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 22611, 22651);
return return_v;
}


bool
f_1605_22597_22681(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 22597, 22681);
return return_v;
}


System.Management.Automation.RunspaceRepository
f_1605_22829_22852(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 22829, 22852);
return return_v;
}


System.Guid
f_1605_22861_22880(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 22861, 22880);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1605_22829_22881(System.Management.Automation.RunspaceRepository
this_param,System.Guid
instanceId)
{
var return_v = this_param.GetItem( instanceId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 22829, 22881);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1605_23118_23152(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Runspaces.PSSession
session,out System.Exception
ex)
{
var return_v = this_param.ConnectSession( session, out ex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 23118, 23152);
return return_v;
}


System.Management.Automation.RunspaceRepository
f_1605_23491_23514(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 23491, 23514);
return return_v;
}


int
f_1605_23491_23545(System.Management.Automation.RunspaceRepository
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.AddOrReplace( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 23491, 23545);
return 0;
}


System.Management.Automation.PSRemotingJob
f_1605_23760_23795(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Runspaces.PSSession
session)
{
var return_v = this_param.FindJobForSession( session);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 23760, 23795);
return return_v;
}


Microsoft.PowerShell.Commands.OutTarget
f_1605_23826_23840(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param)
{
var return_v = this_param.OutTarget ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 23826, 23840);
return return_v;
}


int
f_1605_23916_23959(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Runspaces.PSSession
session,System.Management.Automation.PSRemotingJob
job)
{
this_param.ConnectSessionToHost( session, job);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 23916, 23959);
return 0;
}


int
f_1605_24143_24185(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Runspaces.PSSession
session,System.Management.Automation.PSRemotingJob
job)
{
this_param.ConnectSessionToJob( session, job);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 24143, 24185);
return 0;
}


System.Management.Automation.Runspaces.PSSession
f_1605_24551_24592(System.Management.Automation.Runspaces.Runspace
remoteRunspace)
{
var return_v = new System.Management.Automation.Runspaces.PSSession( (System.Management.Automation.RemoteRunspace)remoteRunspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 24551, 24592);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1605_24638_24672(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Runspaces.PSSession
session,out System.Exception
ex)
{
var return_v = this_param.ConnectSession( session, out ex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 24638, 24672);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1605_25011_25036(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 25011, 25036);
return return_v;
}


bool
f_1605_24985_25055(System.Management.Automation.Runspaces.PSSession
this_param,System.Management.Automation.Runspaces.Runspace
remoteRunspace)
{
var return_v = this_param.InsertRunspace( (System.Management.Automation.RemoteRunspace)remoteRunspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 24985, 25055);
return return_v;
}


System.Management.Automation.RunspaceRepository
f_1605_25395_25418(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 25395, 25418);
return return_v;
}


int
f_1605_25395_25449(System.Management.Automation.RunspaceRepository
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.AddOrReplace( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 25395, 25449);
return 0;
}


Microsoft.PowerShell.Commands.OutTarget
f_1605_25486_25500(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param)
{
var return_v = this_param.OutTarget ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 25486, 25500);
return return_v;
}


int
f_1605_25583_25620(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Runspaces.PSSession
session)
{
this_param.ConnectSessionToJob( session);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 25583, 25620);
return 0;
}


int
f_1605_25825_25863(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Runspaces.PSSession
session)
{
this_param.ConnectSessionToHost( session);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 25825, 25863);
return 0;
}


string
f_1605_26044_26092()
{
var return_v = RemotingErrorIdStrings.RunspaceCannotBeConnected;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 26044, 26092);
return return_v;
}


string
f_1605_26094_26109(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 26094, 26109);
return return_v;
}


string
f_1605_26026_26110(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 26026, 26110);
return return_v;
}


System.ArgumentException
f_1605_26168_26202(string
message,System.Exception
innerException)
{
var return_v = new System.ArgumentException( message, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 26168, 26202);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1605_26152_26327(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Runspaces.PSSession
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 26152, 26327);
return return_v;
}


int
f_1605_26141_26328(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 26141, 26328);
return 0;
}


System.Management.Automation.Runspaces.Runspace[]
f_1605_21134_21143_I(System.Management.Automation.Runspaces.Runspace[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 21134, 21143);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,19235,26454);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,19235,26454);
}
		}

private WSManConnectionInfo GetConnectionObject()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,26466,28404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,26540,26603);

WSManConnectionInfo 
connectionInfo = f_1605_26577_26602()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,26619,28355) || true) && (f_1605_26623_26639()== ReceivePSSessionCommand.ComputerSessionNameParameterSet ||(DynAbs.Tracing.TraceSender.Expression_False(1605, 26623, 26793)||f_1605_26719_26735()== ReceivePSSessionCommand.ComputerInstanceIdParameterSet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,26619,28355);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,26918,27018);

string 
scheme = (DynAbs.Tracing.TraceSender.Conditional_F1(1605, 26934, 26950)||((f_1605_26934_26940().IsPresent &&DynAbs.Tracing.TraceSender.Conditional_F2(1605, 26953, 26984))||DynAbs.Tracing.TraceSender.Conditional_F3(1605, 26987, 27017)))?WSManConnectionInfo.HttpsScheme :WSManConnectionInfo.HttpScheme
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,27038,27069);

connectionInfo.Scheme = scheme;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,27087,27151);

connectionInfo.ComputerName = f_1605_27117_27150(this, f_1605_27137_27149());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,27169,27210);

connectionInfo.AppName = f_1605_27194_27209();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,27228,27272);

connectionInfo.ShellUri = f_1605_27254_27271();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,27290,27317);

connectionInfo.Port = f_1605_27312_27316();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,27335,27611) || true) && (f_1605_27339_27360()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,27335,27611);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,27410,27471);

connectionInfo.CertificateThumbprint = f_1605_27449_27470();
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,27335,27611);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,27335,27611);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,27553,27592);

connectionInfo.Credential = f_1605_27581_27591();
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,27335,27611);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,27631,27687);

connectionInfo.AuthenticationMechanism = f_1605_27672_27686();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,27705,27742);

f_1605_27705_27741(this, connectionInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,26619,28355);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,26619,28355);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,27808,27853);

connectionInfo.ConnectionUri = f_1605_27839_27852();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,27871,27915);

connectionInfo.ShellUri = f_1605_27897_27914();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,27933,28209) || true) && (f_1605_27937_27958()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,27933,28209);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,28008,28069);

connectionInfo.CertificateThumbprint = f_1605_28047_28068();
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,27933,28209);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,27933,28209);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,28151,28190);

connectionInfo.Credential = f_1605_28179_28189();
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,27933,28209);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,28229,28285);

connectionInfo.AuthenticationMechanism = f_1605_28270_28284();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,28303,28340);

f_1605_28303_28339(this, connectionInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,26619,28355);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,28371,28393);

return connectionInfo;
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,26466,28404);

System.Management.Automation.Runspaces.WSManConnectionInfo
f_1605_26577_26602()
{
var return_v = new System.Management.Automation.Runspaces.WSManConnectionInfo();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 26577, 26602);
return return_v;
}


string
f_1605_26623_26639()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 26623, 26639);
return return_v;
}


string
f_1605_26719_26735()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 26719, 26735);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1605_26934_26940()
{
var return_v = UseSSL;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 26934, 26940);
return return_v;
}


string
f_1605_27137_27149()
{
var return_v = ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 27137, 27149);
return return_v;
}


string
f_1605_27117_27150(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,string
computerName)
{
var return_v = this_param.ResolveComputerName( computerName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 27117, 27150);
return return_v;
}


string
f_1605_27194_27209()
{
var return_v = ApplicationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 27194, 27209);
return return_v;
}


string
f_1605_27254_27271()
{
var return_v = ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 27254, 27271);
return return_v;
}


int
f_1605_27312_27316()
{
var return_v = Port;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 27312, 27316);
return return_v;
}


string
f_1605_27339_27360()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 27339, 27360);
return return_v;
}


string
f_1605_27449_27470()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 27449, 27470);
return return_v;
}


System.Management.Automation.PSCredential
f_1605_27581_27591()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 27581, 27591);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1605_27672_27686()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 27672, 27686);
return return_v;
}


int
f_1605_27705_27741(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo)
{
this_param.UpdateConnectionInfo( connectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 27705, 27741);
return 0;
}


System.Uri
f_1605_27839_27852()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 27839, 27852);
return return_v;
}


string
f_1605_27897_27914()
{
var return_v = ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 27897, 27914);
return return_v;
}


string
f_1605_27937_27958()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 27937, 27958);
return return_v;
}


string
f_1605_28047_28068()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 28047, 28068);
return return_v;
}


System.Management.Automation.PSCredential
f_1605_28179_28189()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 28179, 28189);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1605_28270_28284()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 28270, 28284);
return return_v;
}


int
f_1605_28303_28339(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo)
{
this_param.UpdateConnectionInfo( connectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 28303, 28339);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,26466,28404);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,26466,28404);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void UpdateConnectionInfo(WSManConnectionInfo connectionInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,28596,29490);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,28690,29053) || true) && (f_1605_28694_28710()!= ReceivePSSessionCommand.ConnectionUriInstanceIdParameterSet &&(DynAbs.Tracing.TraceSender.Expression_True(1605, 28694, 28874)&&f_1605_28794_28810()!= ReceivePSSessionCommand.ConnectionUriSessionNameParameterSet))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,28690,29053);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,28985,29038);

connectionInfo.MaximumConnectionRedirectionCount = 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,28690,29053);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,29069,29260) || true) && (!_allowRedirection)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,29069,29260);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,29192,29245);

connectionInfo.MaximumConnectionRedirectionCount = 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,29069,29260);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,29357,29479) || true) && (f_1605_29361_29374()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,29357,29479);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,29416,29464);

f_1605_29416_29463(                connectionInfo, f_1605_29449_29462());
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,29357,29479);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,28596,29490);

string
f_1605_28694_28710()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 28694, 28710);
return return_v;
}


string
f_1605_28794_28810()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 28794, 28810);
return return_v;
}


System.Management.Automation.Remoting.PSSessionOption
f_1605_29361_29374()
{
var return_v = SessionOption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 29361, 29374);
return return_v;
}


System.Management.Automation.Remoting.PSSessionOption
f_1605_29449_29462()
{
var return_v = SessionOption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 29449, 29462);
return return_v;
}


int
f_1605_29416_29463(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param,System.Management.Automation.Remoting.PSSessionOption
options)
{
this_param.SetSessionOptions( options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 29416, 29463);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,28596,29490);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,28596,29490);
}
		}

private void GetAndConnectSessionCommand()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,29852,35885);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,29919,29944);

PSSession 
session = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,29960,31888) || true) && (f_1605_29964_29980()== ReceivePSSessionCommand.SessionParameterSet)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,29960,31888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,30061,30079);

session = f_1605_30071_30078();
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,29960,31888);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,29960,31888);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,30113,31888) || true) && (f_1605_30117_30133()== ReceivePSSessionCommand.IdParameterSet)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,30113,31888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,30209,30238);

session = f_1605_30219_30237(this, f_1605_30234_30236());

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,30256,30630) || true) && (session == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,30256,30630);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,30317,30580);

f_1605_30317_30579(this, PSRemotingErrorId.RemoteRunspaceNotAvailableForSpecifiedSessionId, f_1605_30457_30527(), f_1605_30576_30578());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,30604,30611);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,30256,30630);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,30113,31888);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,30113,31888);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,30664,31888) || true) && (f_1605_30668_30684()== ReceivePSSessionCommand.NameParameterSet)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,30664,31888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,30762,30795);

session = f_1605_30772_30794(this, f_1605_30789_30793());

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,30813,31179) || true) && (session == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,30813,31179);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,30874,31129);

f_1605_30874_31128(this, PSRemotingErrorId.RemoteRunspaceNotAvailableForSpecifiedName, f_1605_31009_31074(), f_1605_31123_31127());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,31153,31160);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,30813,31179);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,30664,31888);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,30664,31888);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,31213,31888) || true) && (f_1605_31217_31233()== ReceivePSSessionCommand.InstanceIdParameterSet)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,31213,31888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,31317,31362);

session = f_1605_31327_31361(this, f_1605_31350_31360());

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,31380,31764) || true) && (session == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,31380,31764);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,31441,31714);

f_1605_31441_31713(this, PSRemotingErrorId.RemoteRunspaceNotAvailableForSpecifiedRunspaceId, f_1605_31582_31653(), f_1605_31702_31712());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,31738,31745);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,31380,31764);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,31213,31888);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,31213,31888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,31830,31873);

f_1605_31830_31872(false, "Invalid Parameter Set");
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,31213,31888);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,30664,31888);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,30113,31888);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,29960,31888);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,31989,32558) || true) && (f_1605_31993_32013(session)!= TargetMachineType.RemoteMachine)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,31989,32558);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,32082,32262);

string 
msg = f_1605_32095_32261(f_1605_32113_32181(), f_1605_32204_32216(session), f_1605_32218_32238(session), f_1605_32240_32260(session))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,32280,32332);

Exception 
reason = f_1605_32299_32331(msg)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,32350,32476);

ErrorRecord 
errorRecord = f_1605_32376_32475(reason, "CannotReceiveVMContainerSession", ErrorCategory.InvalidOperation, session)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,32494,32518);

f_1605_32494_32517(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,32536,32543);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,31989,32558);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,32574,35874) || true) && (f_1605_32578_32634(this, f_1605_32592_32604(session), VerbsCommunications.Receive))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,32574,35874);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,32668,32681);

Exception 
ex
=default(Exception);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,32699,33650) || true) && (f_1605_32703_32734(this, session, out ex)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,32699,33650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,33019,33050);

PSSession 
oldSession = session
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,33072,33118);

session = f_1605_33082_33117(this, oldSession);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,33140,33631) || true) && (session == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,33140,33631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,33261,33363);

string 
message = f_1605_33278_33362(f_1605_33296_33344(), f_1605_33346_33361(oldSession))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,33389,33573);

f_1605_33389_33572(this, f_1605_33400_33571(f_1605_33416_33450(message, ex), "ReceivePSSessionCannotConnectSession", ErrorCategory.InvalidOperation, oldSession));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,33601,33608);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,33140,33631);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,32699,33650);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,33883,33930);

PSRemotingJob 
job = f_1605_33903_33929(this, session)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,33948,35390) || true) && (job != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,33948,35390);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,34062,34647) || true) && (f_1605_34066_34075()== OutTarget.Host)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,34062,34647);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,34303,34338);

f_1605_34303_34337(this, session, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,34062,34647);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,34062,34647);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,34590,34624);

f_1605_34590_34623(this, session, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,34062,34647);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,33948,35390);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,33948,35390);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,34787,35371) || true) && (f_1605_34791_34800()== OutTarget.Job)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,34787,35371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,35031,35060);

f_1605_35031_35059(this, session);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,34787,35371);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,34787,35371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,35318,35348);

f_1605_35318_35347(this, session);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,34787,35371);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,33948,35390);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,35678,35859) || true) && (f_1605_35682_35722(f_1605_35682_35716(f_1605_35682_35698(session)))!= RunspaceState.Disconnected)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,35678,35859);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,35794,35840);

f_1605_35794_35839(f_1605_35794_35817(this), session);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,35678,35859);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,32574,35874);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,29852,35885);

string
f_1605_29964_29980()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 29964, 29980);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1605_30071_30078()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 30071, 30078);
return return_v;
}


string
f_1605_30117_30133()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 30117, 30133);
return return_v;
}


int
f_1605_30234_30236()
{
var return_v = Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 30234, 30236);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1605_30219_30237(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,int
id)
{
var return_v = this_param.GetSessionById( id);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 30219, 30237);
return return_v;
}


string
f_1605_30457_30527()
{
var return_v =                                               RemotingErrorIdStrings.RemoteRunspaceNotAvailableForSpecifiedSessionId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 30457, 30527);
return return_v;
}


int
f_1605_30576_30578()
{
var return_v = Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 30576, 30578);
return return_v;
}


int
f_1605_30317_30579(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Remoting.PSRemotingErrorId
errorId,string
resourceString,int
errorArgument)
{
this_param.WriteInvalidArgumentError( errorId, resourceString, (object)errorArgument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 30317, 30579);
return 0;
}


string
f_1605_30668_30684()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 30668, 30684);
return return_v;
}


string
f_1605_30789_30793()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 30789, 30793);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1605_30772_30794(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,string
name)
{
var return_v = this_param.GetSessionByName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 30772, 30794);
return return_v;
}


string
f_1605_31009_31074()
{
var return_v =                                               RemotingErrorIdStrings.RemoteRunspaceNotAvailableForSpecifiedName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 31009, 31074);
return return_v;
}


string
f_1605_31123_31127()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 31123, 31127);
return return_v;
}


int
f_1605_30874_31128(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Remoting.PSRemotingErrorId
errorId,string
resourceString,string
errorArgument)
{
this_param.WriteInvalidArgumentError( errorId, resourceString, (object)errorArgument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 30874, 31128);
return 0;
}


string
f_1605_31217_31233()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 31217, 31233);
return return_v;
}


System.Guid
f_1605_31350_31360()
{
var return_v = InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 31350, 31360);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1605_31327_31361(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Guid
instanceId)
{
var return_v = this_param.GetSessionByInstanceId( instanceId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 31327, 31361);
return return_v;
}


string
f_1605_31582_31653()
{
var return_v =                                               RemotingErrorIdStrings.RemoteRunspaceNotAvailableForSpecifiedRunspaceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 31582, 31653);
return return_v;
}


System.Guid
f_1605_31702_31712()
{
var return_v = InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 31702, 31712);
return return_v;
}


int
f_1605_31441_31713(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Remoting.PSRemotingErrorId
errorId,string
resourceString,System.Guid
errorArgument)
{
this_param.WriteInvalidArgumentError( errorId, resourceString, (object)errorArgument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 31441, 31713);
return 0;
}


int
f_1605_31830_31872(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 31830, 31872);
return 0;
}


System.Management.Automation.Runspaces.TargetMachineType
f_1605_31993_32013(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.ComputerType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 31993, 32013);
return return_v;
}


string
f_1605_32113_32181()
{
var return_v = RemotingErrorIdStrings.RunspaceCannotBeReceivedForVMContainerSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 32113, 32181);
return return_v;
}


string
f_1605_32204_32216(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 32204, 32216);
return return_v;
}


string
f_1605_32218_32238(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 32218, 32238);
return return_v;
}


System.Management.Automation.Runspaces.TargetMachineType
f_1605_32240_32260(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.ComputerType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 32240, 32260);
return return_v;
}


string
f_1605_32095_32261(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 32095, 32261);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1605_32299_32331(string
message)
{
var return_v = new System.Management.Automation.PSNotSupportedException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 32299, 32331);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1605_32376_32475(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Runspaces.PSSession
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 32376, 32475);
return return_v;
}


int
f_1605_32494_32517(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 32494, 32517);
return 0;
}


string
f_1605_32592_32604(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 32592, 32604);
return return_v;
}


bool
f_1605_32578_32634(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 32578, 32634);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1605_32703_32734(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Runspaces.PSSession
session,out System.Exception
ex)
{
var return_v = this_param.ConnectSession( session, out ex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 32703, 32734);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1605_33082_33117(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Runspaces.PSSession
session)
{
var return_v = this_param.TryGetSessionFromServer( session);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 33082, 33117);
return return_v;
}


string
f_1605_33296_33344()
{
var return_v = RemotingErrorIdStrings.RunspaceCannotBeConnected;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 33296, 33344);
return return_v;
}


string
f_1605_33346_33361(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 33346, 33361);
return return_v;
}


string
f_1605_33278_33362(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 33278, 33362);
return return_v;
}


System.ArgumentException
f_1605_33416_33450(string
message,System.Exception
innerException)
{
var return_v = new System.ArgumentException( message, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 33416, 33450);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1605_33400_33571(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Runspaces.PSSession
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 33400, 33571);
return return_v;
}


int
f_1605_33389_33572(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 33389, 33572);
return 0;
}


System.Management.Automation.PSRemotingJob
f_1605_33903_33929(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Runspaces.PSSession
session)
{
var return_v = this_param.FindJobForSession( session);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 33903, 33929);
return return_v;
}


Microsoft.PowerShell.Commands.OutTarget
f_1605_34066_34075()
{
var return_v = OutTarget;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 34066, 34075);
return return_v;
}


int
f_1605_34303_34337(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Runspaces.PSSession
session,System.Management.Automation.PSRemotingJob
job)
{
this_param.ConnectSessionToHost( session, job);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 34303, 34337);
return 0;
}


int
f_1605_34590_34623(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Runspaces.PSSession
session,System.Management.Automation.PSRemotingJob
job)
{
this_param.ConnectSessionToJob( session, job);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 34590, 34623);
return 0;
}


Microsoft.PowerShell.Commands.OutTarget
f_1605_34791_34800()
{
var return_v = OutTarget;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 34791, 34800);
return return_v;
}


int
f_1605_35031_35059(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Runspaces.PSSession
session)
{
this_param.ConnectSessionToJob( session);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 35031, 35059);
return 0;
}


int
f_1605_35318_35347(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Runspaces.PSSession
session)
{
this_param.ConnectSessionToHost( session);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 35318, 35347);
return 0;
}


System.Management.Automation.Runspaces.Runspace
f_1605_35682_35698(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 35682, 35698);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1605_35682_35716(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 35682, 35716);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1605_35682_35722(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 35682, 35722);
return return_v;
}


System.Management.Automation.RunspaceRepository
f_1605_35794_35817(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 35794, 35817);
return return_v;
}


int
f_1605_35794_35839(System.Management.Automation.RunspaceRepository
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.AddOrReplace( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 35794, 35839);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,29852,35885);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,29852,35885);
}
		}

private bool CheckForDebugMode(PSSession session, bool monitorAvailabilityChange)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,35897,36607);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,36003,36070);

RemoteRunspace 
remoteRunspace = f_1605_36035_36051(session)as RemoteRunspace
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,36084,36325) || true) && (f_1605_36088_36123(remoteRunspace)== RunspaceAvailability.RemoteDebug)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,36084,36325);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,36193,36238);

f_1605_36193_36237(this, remoteRunspace);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,36256,36280);

f_1605_36256_36279(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,36298,36310);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,36084,36325);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,36341,36567) || true) && (monitorAvailabilityChange)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,36341,36567);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,36480,36552);

remoteRunspace.AvailabilityChanged += HandleRunspaceAvailabilityChanged;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,36341,36567);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,36583,36596);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,35897,36607);

System.Management.Automation.Runspaces.Runspace
f_1605_36035_36051(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 36035, 36051);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceAvailability
f_1605_36088_36123(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspaceAvailability ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 36088, 36123);
return return_v;
}


int
f_1605_36193_36237(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.RemoteRunspace
remoteRunspace)
{
this_param.DisconnectAndStopRunningCmds( remoteRunspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 36193, 36237);
return 0;
}


int
f_1605_36256_36279(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param)
{
this_param.WriteDebugStopWarning();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 36256, 36279);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,35897,36607);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,35897,36607);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void HandleRunspaceAvailabilityChanged(object sender, RunspaceAvailabilityEventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,36619,37074);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,36738,37063) || true) && ((f_1605_36743_36765(e)== RunspaceAvailability.RemoteDebug))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,36738,37063);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,36836,36893);

RemoteRunspace 
remoteRunspace = sender as RemoteRunspace
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,36911,36983);

remoteRunspace.AvailabilityChanged -= HandleRunspaceAvailabilityChanged;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,37003,37048);

f_1605_37003_37047(this, remoteRunspace);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,36738,37063);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,36619,37074);

System.Management.Automation.Runspaces.RunspaceAvailability
f_1605_36743_36765(System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs
this_param)
{
var return_v = this_param.RunspaceAvailability ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 36743, 36765);
return return_v;
}


int
f_1605_37003_37047(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.RemoteRunspace
remoteRunspace)
{
this_param.DisconnectAndStopRunningCmds( remoteRunspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 37003, 37047);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,36619,37074);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,36619,37074);
}
		}

private void DisconnectAndStopRunningCmds(RemoteRunspace remoteRunspace)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,37086,38108);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,37319,38097) || true) && (f_1605_37323_37361(f_1605_37323_37355(remoteRunspace))== RunspaceState.Opened)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,37319,38097);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,37419,37427);

Job 
job
=default(Job);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,37445,37482);

ManualResetEvent 
stopPipelineReceive
=default(ManualResetEvent);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,37506,37517);
                lock (_syncObject)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,37559,37570);

job = _job;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,37592,37635);

stopPipelineReceive = _stopPipelineReceive;
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,37674,37702);

f_1605_37674_37701(
                remoteRunspace);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,37722,37972) || true) && (stopPipelineReceive != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,37722,37972);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,37847,37873);

f_1605_37847_37872(                        stopPipelineReceive);
                    }
                    catch (ObjectDisposedException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1605,37918,37953);
DynAbs.Tracing.TraceSender.TraceExitCatch(1605,37918,37953);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,37722,37972);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,37992,38082) || true) && (job != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,37992,38082);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,38049,38063);

f_1605_38049_38062(                    job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,37992,38082);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,37319,38097);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,37086,38108);

System.Management.Automation.Runspaces.RunspaceStateInfo
f_1605_37323_37355(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 37323, 37355);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1605_37323_37361(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 37323, 37361);
return return_v;
}


int
f_1605_37674_37701(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.Disconnect();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 37674, 37701);
return 0;
}


bool
f_1605_37847_37872(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 37847, 37872);
return return_v;
}


int
f_1605_38049_38062(System.Management.Automation.Job
this_param)
{
this_param.StopJob();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 38049, 38062);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,37086,38108);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,37086,38108);
}
		}

private void WriteDebugStopWarning()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,38120,38327);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,38181,38276);

f_1605_38181_38275(this, f_1605_38212_38274(this, f_1605_38223_38273()));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,38290,38316);

f_1605_38290_38315(this, string.Empty);
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,38120,38327);

string
f_1605_38223_38273()
{
var return_v = RemotingErrorIdStrings.ReceivePSSessionInDebugMode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 38223, 38273);
return return_v;
}


string
f_1605_38212_38274(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,string
resourceString)
{
var return_v = this_param.GetMessage( resourceString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 38212, 38274);
return return_v;
}


int
f_1605_38181_38275(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,string
text)
{
this_param.WriteWarning( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 38181, 38275);
return 0;
}


int
f_1605_38290_38315(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,string
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 38290, 38315);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,38120,38327);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,38120,38327);
}
		}

private void ConnectSessionToHost(PSSession session, PSRemotingJob job = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,38603,47116);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,38706,38773);

RemoteRunspace 
remoteRunspace = f_1605_38738_38754(session)as RemoteRunspace
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,38787,38875);

f_1605_38787_38874(remoteRunspace != null, "PS sessions can only contain RemoteRunspace type.");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,38891,40628) || true) && (job != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,38891,40628);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,39194,39205);
                // If we have a job object associated with the session then this means
                // the user explicitly chose to connect and return data synchronously.

                // Reconnect the job object and stream data to host.
                lock (_syncObject) { DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,39209,39220);

_job = job;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,39221,39272);

_stopPipelineReceive = f_1605_39244_39271(false);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,39294,40502);
using(_stopPipelineReceive){DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,39340,40502);
using(job)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,39392,39424);

Job 
childJob = f_1605_39407_39423(f_1605_39407_39420(job), 0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,39446,39464);

f_1605_39446_39463(                    job);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,39486,39535) || true) && (f_1605_39490_39522(this, session, true))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,39486,39535);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,39526,39533);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,39486,39535);
}
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,39559,40483);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,39736,39897);

int 
index = f_1605_39748_39896(new WaitHandle[] {
                            _stopPipelineReceive,
f_1605_39866_39893(f_1605_39866_39882(childJob))})
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,39925,40197);
foreach(var result in f_1605_39948_39966_I(f_1605_39948_39966(childJob)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,39925,40197);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,40024,40170) || true) && (result != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,40024,40170);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,40108,40139);

f_1605_40108_40138(                                result, this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,40024,40170);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,39925,40197);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1605,1,273);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1605,1,273);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,40225,40385) || true) && (index == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,40225,40385);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,40297,40321);

f_1605_40297_40320(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,40351,40358);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,40225,40385);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,39559,40483);
}
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,39559,40483) || true) && (!f_1605_40438_40481(job, f_1605_40458_40480(f_1605_40458_40474(job))))
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1605,39559,40483);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1605,39559,40483);
}}DynAbs.Tracing.TraceSender.TraceExitUsing(1605,39340,40502);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(1605,39294,40502);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,40528,40539);

                lock (_syncObject) { DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,40543,40555);

_job = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,40556,40584);

_stopPipelineReceive = null;
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,40606,40613);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,38891,40628);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,40780,41090) || true) && (f_1605_40784_40812(remoteRunspace)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,40780,41090);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,41016,41050);

f_1605_41016_41049(this, session, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,41068,41075);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,40780,41090);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,41200,41211);

            // Create a RemotePipeline object for this command and attempt to connect.
            lock (_syncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,41245,41325);

_remotePipeline = (RemotePipeline)f_1605_41279_41324(f_1605_41279_41295(session));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,41343,41394);

_stopPipelineReceive = f_1605_41366_41393(false);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,41425,47014);
using(_stopPipelineReceive)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,41486,46999);
using(_remotePipeline)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,41609,41679);

ManualResetEvent 
pipelineConnectedEvent = f_1605_41651_41678(false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,41701,42522);
using(pipelineConnectedEvent)                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,41780,42383);

_remotePipeline.StateChanged += (sender, args) =>
                            {
                                if (pipelineConnectedEvent != null &&
                                    (args.PipelineStateInfo.State == PipelineState.Running ||
                                     args.PipelineStateInfo.State == PipelineState.Stopped ||
                                     args.PipelineStateInfo.State == PipelineState.Failed))
                                {
                                    pipelineConnectedEvent.Set();
                                }
                            };
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,42409,42440);

f_1605_42409_42439(                        _remotePipeline);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,42466,42499);

f_1605_42466_42498(                        pipelineConnectedEvent);
DynAbs.Tracing.TraceSender.TraceExitUsing(1605,41701,42522);
                    }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,42546,42576);

pipelineConnectedEvent = null;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,42600,42649) || true) && (f_1605_42604_42636(this, session, true))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,42600,42649);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,42640,42647);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,42600,42649);
}
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,42768,43801) || true) && (f_1605_42775_42812_M(!f_1605_42776_42798(_remotePipeline).EndOfPipeline))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,42768,43801);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,42862,42972) || true) && (_stopProcessing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,42862,42972);
DynAbs.Tracing.TraceSender.TraceBreak(1605,42939,42945);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,42862,42972);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,43000,43167);

int 
index = f_1605_43012_43166(new WaitHandle[] {
                            _stopPipelineReceive,
f_1605_43130_43163(f_1605_43130_43152(_remotePipeline))})
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,43195,43355) || true) && (index == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,43195,43355);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,43267,43291);

f_1605_43267_43290(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,43321,43328);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,43195,43355);
}
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,43383,43778) || true) && (f_1605_43390_43418(f_1605_43390_43412(_remotePipeline))> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,43383,43778);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,43480,43602) || true) && (_stopProcessing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,43480,43602);
DynAbs.Tracing.TraceSender.TraceBreak(1605,43565,43571);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,43480,43602);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,43634,43684);

PSObject 
psObject = f_1605_43654_43683(f_1605_43654_43676(_remotePipeline))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,43714,43751);

f_1605_43714_43750(this, psObject, session);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,43383,43778);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1605,43383,43778);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1605,43383,43778);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1605,42768,43801);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1605,42768,43801);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1605,42768,43801);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,43879,45029) || true) && (f_1605_43883_43910(f_1605_43883_43904(_remotePipeline))> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,43879,45029);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,43964,45006) || true) && (f_1605_43971_44007_M(!f_1605_43972_43993(_remotePipeline).EndOfPipeline))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,43964,45006);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,44065,44112);

object 
errorObj = f_1605_44083_44111(f_1605_44083_44104(_remotePipeline))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,44142,44979) || true) && (errorObj is Collection<ErrorRecord>)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,44142,44979);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,44247,44323);

Collection<ErrorRecord> 
errorCollection = (Collection<ErrorRecord>)errorObj
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,44357,44541);
foreach(ErrorRecord errorRecord in f_1605_44393_44408_I(errorCollection) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,44357,44541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,44482,44506);

f_1605_44482_44505(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,44357,44541);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1605,1,185);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1605,1,185);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1605,44142,44979);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,44142,44979);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,44607,44979) || true) && (errorObj is ErrorRecord)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,44607,44979);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,44700,44734);

f_1605_44700_44733(this, errorObj);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,44607,44979);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,44607,44979);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,44864,44948);

f_1605_44864_44947(false, "Objects in pipeline Error collection must be ErrorRecord type.");
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,44607,44979);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,44142,44979);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,43964,45006);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1605,43964,45006);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1605,43964,45006);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1605,43879,45029);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,45106,45278);

int 
wIndex = f_1605_45119_45277(new WaitHandle[] {
                            _stopPipelineReceive,
f_1605_45237_45274(_remotePipeline)})
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,45302,45447) || true) && (wIndex == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,45302,45447);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,45367,45391);

f_1605_45367_45390(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,45417,45424);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,45302,45447);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,45658,45736);

f_1605_45658_45712(f_1605_45658_45685(remoteRunspace)).ConnectCommands = null;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,45828,46980) || true) && (f_1605_45832_45871(f_1605_45832_45865(_remotePipeline))== PipelineState.Failed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,45828,46980);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,45945,46005);

Exception 
reason = f_1605_45964_46004(f_1605_45964_45997(_remotePipeline))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,46031,46042);

string 
msg
=default(string);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,46068,46472) || true) && (reason != null &&(DynAbs.Tracing.TraceSender.Expression_True(1605, 46072, 46127)&&!f_1605_46091_46127(f_1605_46112_46126(reason))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,46068,46472);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,46185,46274);

msg = f_1605_46191_46273(f_1605_46209_46256(), f_1605_46258_46272(reason));
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,46068,46472);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,46068,46472);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,46388,46445);

msg = f_1605_46394_46444();
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,46068,46472);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,46500,46905);

ErrorRecord 
errorRecord = f_1605_46526_46904(f_1605_46542_46575(msg, reason), "ReceivePSSessionPipelineFailed", ErrorCategory.OperationStopped, _remotePipeline)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,46933,46957);

f_1605_46933_46956(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,45828,46980);
}
DynAbs.Tracing.TraceSender.TraceExitUsing(1605,41486,46999);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(1605,41425,47014);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,47036,47047);

            lock (_syncObject) { DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,47051,47074);

_remotePipeline = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,47075,47103);

_stopPipelineReceive = null;
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,38603,47116);

System.Management.Automation.Runspaces.Runspace
f_1605_38738_38754(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 38738, 38754);
return return_v;
}


int
f_1605_38787_38874(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 38787, 38874);
return 0;
}


System.Threading.ManualResetEvent
f_1605_39244_39271(bool
initialState)
{
var return_v = new System.Threading.ManualResetEvent( initialState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 39244, 39271);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1605_39407_39420(System.Management.Automation.PSRemotingJob
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 39407, 39420);
return return_v;
}


System.Management.Automation.Job
f_1605_39407_39423(System.Collections.Generic.IList<System.Management.Automation.Job>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 39407, 39423);
return return_v;
}


int
f_1605_39446_39463(System.Management.Automation.PSRemotingJob
this_param)
{
this_param.ConnectJobs();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 39446, 39463);
return 0;
}


bool
f_1605_39490_39522(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Runspaces.PSSession
session,bool
monitorAvailabilityChange)
{
var return_v = this_param.CheckForDebugMode( session, monitorAvailabilityChange);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 39490, 39522);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1605_39866_39882(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Results;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 39866, 39882);
return return_v;
}


System.Threading.WaitHandle
f_1605_39866_39893(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
this_param)
{
var return_v = this_param.WaitHandle ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 39866, 39893);
return return_v;
}


int
f_1605_39748_39896(System.Threading.WaitHandle[]
waitHandles)
{
var return_v = WaitHandle.WaitAny( waitHandles);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 39748, 39896);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1605_39948_39966(System.Management.Automation.Job
this_param)
{
var return_v = this_param.ReadAll();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 39948, 39966);
return return_v;
}


int
f_1605_40108_40138(System.Management.Automation.Remoting.Internal.PSStreamObject
this_param,Microsoft.PowerShell.Commands.ReceivePSSessionCommand
cmdlet)
{
this_param.WriteStreamObject( (System.Management.Automation.Cmdlet)cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 40108, 40138);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1605_39948_39966_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 39948, 39966);
return return_v;
}


int
f_1605_40297_40320(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param)
{
this_param.WriteDebugStopWarning();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 40297, 40320);
return 0;
}


System.Management.Automation.JobStateInfo
f_1605_40458_40474(System.Management.Automation.PSRemotingJob
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 40458, 40474);
return return_v;
}


System.Management.Automation.JobState
f_1605_40458_40480(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 40458, 40480);
return return_v;
}


bool
f_1605_40438_40481(System.Management.Automation.PSRemotingJob
this_param,System.Management.Automation.JobState
state)
{
var return_v = this_param.IsFinishedState( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 40438, 40481);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
f_1605_40784_40812(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RemoteCommand ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 40784, 40812);
return return_v;
}


bool
f_1605_41016_41049(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Runspaces.PSSession
session,bool
monitorAvailabilityChange)
{
var return_v = this_param.CheckForDebugMode( session, monitorAvailabilityChange);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 41016, 41049);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1605_41279_41295(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 41279, 41295);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1605_41279_41324(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.CreateDisconnectedPipeline();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 41279, 41324);
return return_v;
}


System.Threading.ManualResetEvent
f_1605_41366_41393(bool
initialState)
{
var return_v = new System.Threading.ManualResetEvent( initialState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 41366, 41393);
return return_v;
}


System.Threading.ManualResetEvent
f_1605_41651_41678(bool
initialState)
{
var return_v = new System.Threading.ManualResetEvent( initialState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 41651, 41678);
return return_v;
}


int
f_1605_42409_42439(System.Management.Automation.RemotePipeline
this_param)
{
this_param.ConnectAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 42409, 42439);
return 0;
}


bool
f_1605_42466_42498(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.WaitOne();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 42466, 42498);
return return_v;
}


bool
f_1605_42604_42636(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Runspaces.PSSession
session,bool
monitorAvailabilityChange)
{
var return_v = this_param.CheckForDebugMode( session, monitorAvailabilityChange);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 42604, 42636);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
f_1605_42776_42798(System.Management.Automation.RemotePipeline
this_param)
{
var return_v = this_param.Output;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 42776, 42798);
return return_v;
}


bool
f_1605_42775_42812_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 42775, 42812);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
f_1605_43130_43152(System.Management.Automation.RemotePipeline
this_param)
{
var return_v = this_param.Output;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 43130, 43152);
return return_v;
}


System.Threading.WaitHandle
f_1605_43130_43163(System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.WaitHandle ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 43130, 43163);
return return_v;
}


int
f_1605_43012_43166(System.Threading.WaitHandle[]
waitHandles)
{
var return_v = WaitHandle.WaitAny( waitHandles);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 43012, 43166);
return return_v;
}


int
f_1605_43267_43290(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param)
{
this_param.WriteDebugStopWarning();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 43267, 43290);
return 0;
}


System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
f_1605_43390_43412(System.Management.Automation.RemotePipeline
this_param)
{
var return_v = this_param.Output;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 43390, 43412);
return return_v;
}


int
f_1605_43390_43418(System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 43390, 43418);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
f_1605_43654_43676(System.Management.Automation.RemotePipeline
this_param)
{
var return_v = this_param.Output;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 43654, 43676);
return return_v;
}


System.Management.Automation.PSObject
f_1605_43654_43683(System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Read();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 43654, 43683);
return return_v;
}


int
f_1605_43714_43750(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.PSObject
psObject,System.Management.Automation.Runspaces.PSSession
session)
{
this_param.WriteRemoteObject( psObject, session);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 43714, 43750);
return 0;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1605_43883_43904(System.Management.Automation.RemotePipeline
this_param)
{
var return_v = this_param.Error;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 43883, 43904);
return return_v;
}


int
f_1605_43883_43910(System.Management.Automation.Runspaces.PipelineReader<object>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 43883, 43910);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1605_43972_43993(System.Management.Automation.RemotePipeline
this_param)
{
var return_v = this_param.Error;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 43972, 43993);
return return_v;
}


bool
f_1605_43971_44007_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 43971, 44007);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1605_44083_44104(System.Management.Automation.RemotePipeline
this_param)
{
var return_v = this_param.Error;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 44083, 44104);
return return_v;
}


object
f_1605_44083_44111(System.Management.Automation.Runspaces.PipelineReader<object>
this_param)
{
var return_v = this_param.Read();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 44083, 44111);
return return_v;
}


int
f_1605_44482_44505(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 44482, 44505);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1605_44393_44408_I(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 44393, 44408);
return return_v;
}


int
f_1605_44700_44733(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,object
errorRecord)
{
this_param.WriteError( (System.Management.Automation.ErrorRecord)errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 44700, 44733);
return 0;
}


int
f_1605_44864_44947(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 44864, 44947);
return 0;
}


System.Threading.ManualResetEvent
f_1605_45237_45274(System.Management.Automation.RemotePipeline
this_param)
{
var return_v = this_param.PipelineFinishedEvent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 45237, 45274);
return return_v;
}


int
f_1605_45119_45277(System.Threading.WaitHandle[]
waitHandles)
{
var return_v = WaitHandle.WaitAny( waitHandles);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 45119, 45277);
return return_v;
}


int
f_1605_45367_45390(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param)
{
this_param.WriteDebugStopWarning();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 45367, 45390);
return 0;
}


System.Management.Automation.Runspaces.RunspacePool
f_1605_45658_45685(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 45658, 45685);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1605_45658_45712(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 45658, 45712);
return return_v;
}


System.Management.Automation.Runspaces.PipelineStateInfo
f_1605_45832_45865(System.Management.Automation.RemotePipeline
this_param)
{
var return_v = this_param.PipelineStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 45832, 45865);
return return_v;
}


System.Management.Automation.Runspaces.PipelineState
f_1605_45832_45871(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 45832, 45871);
return return_v;
}


System.Management.Automation.Runspaces.PipelineStateInfo
f_1605_45964_45997(System.Management.Automation.RemotePipeline
this_param)
{
var return_v = this_param.PipelineStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 45964, 45997);
return return_v;
}


System.Exception
f_1605_45964_46004(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 45964, 46004);
return return_v;
}


string
f_1605_46112_46126(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 46112, 46126);
return return_v;
}


bool
f_1605_46091_46127(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 46091, 46127);
return return_v;
}


string
f_1605_46209_46256()
{
var return_v = RemotingErrorIdStrings.PipelineFailedWithReason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 46209, 46256);
return return_v;
}


string
f_1605_46258_46272(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 46258, 46272);
return return_v;
}


string
f_1605_46191_46273(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 46191, 46273);
return return_v;
}


string
f_1605_46394_46444()
{
var return_v = RemotingErrorIdStrings.PipelineFailedWithoutReason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 46394, 46444);
return return_v;
}


System.Management.Automation.RuntimeException
f_1605_46542_46575(string
message,System.Exception
innerException)
{
var return_v = new System.Management.Automation.RuntimeException( message, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 46542, 46575);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1605_46526_46904(System.Management.Automation.RuntimeException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.RemotePipeline
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 46526, 46904);
return return_v;
}


int
f_1605_46933_46956(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 46933, 46956);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,38603,47116);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,38603,47116);
}
		}

private void WriteRemoteObject(
            PSObject psObject,
            PSSession session)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,47418,48481);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,47538,47614) || true) && (psObject == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,47538,47614);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,47592,47599);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,47538,47614);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,47712,47946) || true) && (f_1605_47716_47779(f_1605_47716_47735(psObject), RemotingConstants.ComputerNameNoteProperty)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,47712,47946);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,47821,47931);

f_1605_47821_47930(f_1605_47821_47840(psObject), f_1605_47845_47929(RemotingConstants.ComputerNameNoteProperty, f_1605_47908_47928(session)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,47712,47946);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,47962,48190) || true) && (f_1605_47966_48027(f_1605_47966_47985(psObject), RemotingConstants.RunspaceIdNoteProperty)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,47962,48190);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,48069,48175);

f_1605_48069_48174(f_1605_48069_48088(psObject), f_1605_48093_48173(RemotingConstants.RunspaceIdNoteProperty, f_1605_48154_48172(session)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,47962,48190);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,48206,48432) || true) && (f_1605_48210_48277(f_1605_48210_48229(psObject), RemotingConstants.ShowComputerNameNoteProperty)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,48206,48432);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,48319,48417);

f_1605_48319_48416(f_1605_48319_48338(psObject), f_1605_48343_48415(RemotingConstants.ShowComputerNameNoteProperty, true));
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,48206,48432);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,48448,48470);

f_1605_48448_48469(this, psObject);
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,47418,48481);

System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1605_47716_47735(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 47716, 47735);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1605_47716_47779(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 47716, 47779);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1605_47821_47840(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 47821, 47840);
return return_v;
}


string
f_1605_47908_47928(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 47908, 47928);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1605_47845_47929(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 47845, 47929);
return return_v;
}


int
f_1605_47821_47930(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 47821, 47930);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1605_47966_47985(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 47966, 47985);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1605_47966_48027(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 47966, 48027);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1605_48069_48088(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 48069, 48088);
return return_v;
}


System.Guid
f_1605_48154_48172(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 48154, 48172);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1605_48093_48173(string
name,System.Guid
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 48093, 48173);
return return_v;
}


int
f_1605_48069_48174(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 48069, 48174);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1605_48210_48229(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 48210, 48229);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1605_48210_48277(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 48210, 48277);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1605_48319_48338(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 48319, 48338);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1605_48343_48415(string
name,bool
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 48343, 48415);
return return_v;
}


int
f_1605_48319_48416(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 48319, 48416);
return 0;
}


int
f_1605_48448_48469(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.PSObject
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 48448, 48469);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,47418,48481);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,47418,48481);
}
		}

private void ConnectSessionToJob(PSSession session, PSRemotingJob job = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,48959,50872);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,49191,49218);

bool 
newJobCreated = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,49232,50266) || true) && (job == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,49232,50266);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,49382,49448);

List<IThrottleOperation> 
helpers = f_1605_49417_49447()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,49653,49725);

Pipeline 
remotePipeline = f_1605_49679_49724(f_1605_49679_49695(session))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,49828,49886);

f_1605_49828_49885(
                // Create a disconnected runspace helper for this remote command.
                helpers, f_1605_49840_49884(remotePipeline));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,50040,50092);

job = f_1605_50046_50091(helpers, 0, f_1605_50076_50083(), false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,50110,50165);

job.PSJobTypeName = InvokeCommandCommand.RemoteJobType;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,50183,50212);

job.HideComputerName = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,50230,50251);

newJobCreated = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,49232,50266);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,50282,50715) || true) && (f_1605_50286_50308(f_1605_50286_50302(job))== JobState.Disconnected)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,50282,50715);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,50448,50492);

f_1605_50448_50491(                // Connect the job to the remote command running on the server.
                job, f_1605_50463_50490(f_1605_50463_50479(session)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,50599,50700) || true) && (newJobCreated)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,50599,50700);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,50658,50681);

f_1605_50658_50680(f_1605_50658_50671(), job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,50599,50700);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,50282,50715);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,50731,50780) || true) && (f_1605_50735_50767(this, session, true))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,50731,50780);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,50771,50778);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,50731,50780);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,50844,50861);

f_1605_50844_50860(this, job);
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,48959,50872);

System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1605_49417_49447()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 49417, 49447);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1605_49679_49695(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 49679, 49695);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1605_49679_49724(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.CreateDisconnectedPipeline();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 49679, 49724);
return return_v;
}


System.Management.Automation.DisconnectedJobOperation
f_1605_49840_49884(System.Management.Automation.Runspaces.Pipeline
pipeline)
{
var return_v = new System.Management.Automation.DisconnectedJobOperation( pipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 49840, 49884);
return return_v;
}


int
f_1605_49828_49885(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
this_param,System.Management.Automation.DisconnectedJobOperation
item)
{
this_param.Add( (System.Management.Automation.Remoting.IThrottleOperation)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 49828, 49885);
return 0;
}


string
f_1605_50076_50083()
{
var return_v = JobName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 50076, 50083);
return return_v;
}


System.Management.Automation.PSRemotingJob
f_1605_50046_50091(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
helpers,int
throttleLimit,string
name,bool
aggregateResults)
{
var return_v = new System.Management.Automation.PSRemotingJob( helpers, throttleLimit, name, aggregateResults);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 50046, 50091);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1605_50286_50302(System.Management.Automation.PSRemotingJob
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 50286, 50302);
return return_v;
}


System.Management.Automation.JobState
f_1605_50286_50308(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 50286, 50308);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1605_50463_50479(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 50463, 50479);
return return_v;
}


System.Guid
f_1605_50463_50490(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 50463, 50490);
return return_v;
}


int
f_1605_50448_50491(System.Management.Automation.PSRemotingJob
this_param,System.Guid
runspaceInstanceId)
{
this_param.ConnectJob( runspaceInstanceId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 50448, 50491);
return 0;
}


System.Management.Automation.JobRepository
f_1605_50658_50671()
{
var return_v = JobRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 50658, 50671);
return return_v;
}


int
f_1605_50658_50680(System.Management.Automation.JobRepository
this_param,System.Management.Automation.PSRemotingJob
item)
{
this_param.Add( (System.Management.Automation.Job)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 50658, 50680);
return 0;
}


bool
f_1605_50735_50767(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.Runspaces.PSSession
session,bool
monitorAvailabilityChange)
{
var return_v = this_param.CheckForDebugMode( session, monitorAvailabilityChange);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 50735, 50767);
return return_v;
}


int
f_1605_50844_50860(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.PSRemotingJob
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 50844, 50860);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,48959,50872);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,48959,50872);
}
		}

private PSSession ConnectSession(PSSession session, out Exception ex)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,51306,52303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,51400,51410);

ex = null;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,51426,51836) || true) && (session == null ||(DynAbs.Tracing.TraceSender.Expression_False(1605, 51430, 51624)||                (f_1605_51467_51507(f_1605_51467_51501(f_1605_51467_51483(session)))!= RunspaceState.Opened &&(DynAbs.Tracing.TraceSender.Expression_True(1605, 51467, 51623)&&f_1605_51553_51593(f_1605_51553_51587(f_1605_51553_51569(session)))!= RunspaceState.Disconnected))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,51426,51836);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,51658,51670);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,51426,51836);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,51426,51836);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,51704,51836) || true) && (f_1605_51708_51748(f_1605_51708_51742(f_1605_51708_51724(session)))== RunspaceState.Opened)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,51704,51836);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,51806,51821);

return session;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,51704,51836);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,51426,51836);
}

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,51888,51915);

f_1605_51888_51914(f_1605_51888_51904(session));
            }
            catch (PSInvalidOperationException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1605,51944,52036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,52014,52021);

ex = e;
DynAbs.Tracing.TraceSender.TraceExitCatch(1605,51944,52036);
            }
            catch (InvalidRunspaceStateException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1605,52050,52144);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,52122,52129);

ex = e;
DynAbs.Tracing.TraceSender.TraceExitCatch(1605,52050,52144);
            }
            catch (RuntimeException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1605,52158,52239);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,52217,52224);

ex = e;
DynAbs.Tracing.TraceSender.TraceExitCatch(1605,52158,52239);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,52255,52292);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1605, 52262, 52274)||(((ex == null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1605, 52277, 52284))||DynAbs.Tracing.TraceSender.Conditional_F3(1605, 52287, 52291)))?session :null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,51306,52303);

System.Management.Automation.Runspaces.Runspace
f_1605_51467_51483(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 51467, 51483);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1605_51467_51501(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 51467, 51501);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1605_51467_51507(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 51467, 51507);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1605_51553_51569(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 51553, 51569);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1605_51553_51587(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 51553, 51587);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1605_51553_51593(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 51553, 51593);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1605_51708_51724(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 51708, 51724);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1605_51708_51742(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 51708, 51742);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1605_51708_51748(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 51708, 51748);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1605_51888_51904(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 51888, 51904);
return return_v;
}


int
f_1605_51888_51914(System.Management.Automation.Runspaces.Runspace
this_param)
{
this_param.Connect();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 51888, 51914);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,51306,52303);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,51306,52303);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private PSSession TryGetSessionFromServer(PSSession session)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,52652,53701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,52737,52804);

RemoteRunspace 
remoteRunspace = f_1605_52769_52785(session)as RemoteRunspace
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,52818,52905) || true) && (remoteRunspace == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,52818,52905);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,52878,52890);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,52818,52905);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,52921,52943);

remoteRunspace = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,52957,53080);

Runspace[] 
runspaces = f_1605_52980_53079(f_1605_53002_53033(f_1605_53002_53018(session)), f_1605_53035_53044(this), f_1605_53046_53078())
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,53094,53369);
foreach(Runspace runspace in f_1605_53124_53133_I(runspaces) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,53094,53369);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,53167,53354) || true) && (f_1605_53171_53190(runspace)== f_1605_53194_53221(f_1605_53194_53210(session)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,53167,53354);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,53263,53307);

remoteRunspace = runspace as RemoteRunspace;
DynAbs.Tracing.TraceSender.TraceBreak(1605,53329,53335);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,53167,53354);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,53094,53369);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1605,1,276);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1605,1,276);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,53385,53662) || true) && (remoteRunspace != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,53385,53662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,53523,53614);

session = (DynAbs.Tracing.TraceSender.Conditional_F1(1605, 53533, 53571)||((f_1605_53533_53571(session, remoteRunspace)&&DynAbs.Tracing.TraceSender.Conditional_F2(1605, 53574, 53581))||DynAbs.Tracing.TraceSender.Conditional_F3(1605, 53584, 53613)))?session :f_1605_53584_53613(remoteRunspace);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,53632,53647);

return session;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,53385,53662);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,53678,53690);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,52652,53701);

System.Management.Automation.Runspaces.Runspace
f_1605_52769_52785(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 52769, 52785);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1605_53002_53018(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 53002, 53018);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1605_53002_53033(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 53002, 53033);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1605_53035_53044(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 53035, 53044);
return return_v;
}


System.Management.Automation.Runspaces.TypeTable
f_1605_53046_53078()
{
var return_v = QueryRunspaces.BuiltInTypesTable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 53046, 53078);
return return_v;
}


System.Management.Automation.Runspaces.Runspace[]
f_1605_52980_53079(System.Management.Automation.Runspaces.RunspaceConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Runspaces.TypeTable
typeTable)
{
var return_v = Runspace.GetRunspaces( connectionInfo, host, typeTable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 52980, 53079);
return return_v;
}


System.Guid
f_1605_53171_53190(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.InstanceId ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 53171, 53190);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1605_53194_53210(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 53194, 53210);
return return_v;
}


System.Guid
f_1605_53194_53221(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 53194, 53221);
return return_v;
}


System.Management.Automation.Runspaces.Runspace[]
f_1605_53124_53133_I(System.Management.Automation.Runspaces.Runspace[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 53124, 53133);
return return_v;
}


bool
f_1605_53533_53571(System.Management.Automation.Runspaces.PSSession
this_param,System.Management.Automation.RemoteRunspace
remoteRunspace)
{
var return_v = this_param.InsertRunspace( remoteRunspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 53533, 53571);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1605_53584_53613(System.Management.Automation.RemoteRunspace
remoteRunspace)
{
var return_v = new System.Management.Automation.Runspaces.PSSession( remoteRunspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 53584, 53613);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,52652,53701);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,52652,53701);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private PSRemotingJob FindJobForSession(PSSession session)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,54033,55388);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,54116,54141);

PSRemotingJob 
job = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,54155,54229);

RemoteRunspace 
remoteSessionRunspace = f_1605_54194_54210(session)as RemoteRunspace
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,54245,54609) || true) && (remoteSessionRunspace == null ||(DynAbs.Tracing.TraceSender.Expression_False(1605, 54249, 54342)||f_1605_54299_54334(remoteSessionRunspace)!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,54245,54609);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,54582,54594);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,54245,54609);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,54625,55350);
foreach(Job repJob in f_1605_54648_54671_I(f_1605_54648_54671(f_1605_54648_54666(this))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,54625,55350);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,54705,55335) || true) && (repJob is PSRemotingJob)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,54705,55335);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,54774,55198);
foreach(PSRemotingChildJob childJob in f_1605_54814_54830_I(f_1605_54814_54830(repJob)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,54774,55198);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,54880,55175) || true) && (f_1605_54884_54901(childJob).InstanceId.Equals(f_1605_54920_54938(session))&&(DynAbs.Tracing.TraceSender.Expression_True(1605, 54884, 55026)&&                            (f_1605_54973_55000(f_1605_54973_54994(childJob))== JobState.Disconnected)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,54880,55175);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,55084,55112);

job = (PSRemotingJob)repJob;
DynAbs.Tracing.TraceSender.TraceBreak(1605,55142,55148);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,54880,55175);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,54774,55198);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1605,1,425);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1605,1,425);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,55222,55316) || true) && (job != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,55222,55316);
DynAbs.Tracing.TraceSender.TraceBreak(1605,55287,55293);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,55222,55316);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,54705,55335);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,54625,55350);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1605,1,726);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1605,1,726);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,55366,55377);

return job;
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,54033,55388);

System.Management.Automation.Runspaces.Runspace
f_1605_54194_54210(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 54194, 54210);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
f_1605_54299_54334(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RemoteCommand ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 54299, 54334);
return return_v;
}


System.Management.Automation.JobRepository
f_1605_54648_54666(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param)
{
var return_v = this_param.JobRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 54648, 54666);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1605_54648_54671(System.Management.Automation.JobRepository
this_param)
{
var return_v = this_param.Jobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 54648, 54671);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1605_54814_54830(System.Management.Automation.Job
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 54814, 54830);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1605_54884_54901(System.Management.Automation.PSRemotingChildJob
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 54884, 54901);
return return_v;
}


System.Guid
f_1605_54920_54938(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 54920, 54938);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1605_54973_54994(System.Management.Automation.PSRemotingChildJob
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 54973, 54994);
return return_v;
}


System.Management.Automation.JobState
f_1605_54973_55000(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 54973, 55000);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1605_54814_54830_I(System.Collections.Generic.IList<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 54814, 54830);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1605_54648_54671_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 54648, 54671);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,54033,55388);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,54033,55388);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private PSSession GetSessionById(int id)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,55609,55921);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,55674,55882);
foreach(PSSession session in f_1605_55704_55737_I(f_1605_55704_55737(f_1605_55704_55727(this))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,55674,55882);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,55771,55867) || true) && (f_1605_55775_55785(session)== id)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,55771,55867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,55833,55848);

return session;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,55771,55867);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,55674,55882);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1605,1,209);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1605,1,209);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,55898,55910);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,55609,55921);

System.Management.Automation.RunspaceRepository
f_1605_55704_55727(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 55704, 55727);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1605_55704_55737(System.Management.Automation.RunspaceRepository
this_param)
{
var return_v = this_param.Runspaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 55704, 55737);
return return_v;
}


int
f_1605_55775_55785(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Id ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 55775, 55785);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1605_55704_55737_I(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 55704, 55737);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,55609,55921);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,55609,55921);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private PSSession GetSessionByName(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,56148,56582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,56220,56304);

WildcardPattern 
namePattern = f_1605_56250_56303(name, WildcardOptions.IgnoreCase)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,56318,56543);
foreach(PSSession session in f_1605_56348_56381_I(f_1605_56348_56381(f_1605_56348_56371(this))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,56318,56543);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,56415,56528) || true) && (f_1605_56419_56452(namePattern, f_1605_56439_56451(session)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,56415,56528);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,56494,56509);

return session;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,56415,56528);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,56318,56543);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1605,1,226);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1605,1,226);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,56559,56571);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,56148,56582);

System.Management.Automation.WildcardPattern
f_1605_56250_56303(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 56250, 56303);
return return_v;
}


System.Management.Automation.RunspaceRepository
f_1605_56348_56371(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 56348, 56371);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1605_56348_56381(System.Management.Automation.RunspaceRepository
this_param)
{
var return_v = this_param.Runspaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 56348, 56381);
return return_v;
}


string
f_1605_56439_56451(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 56439, 56451);
return return_v;
}


bool
f_1605_56419_56452(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 56419, 56452);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1605_56348_56381_I(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 56348, 56381);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,56148,56582);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,56148,56582);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private PSSession GetSessionByInstanceId(Guid instanceId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,56827,57177);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,56909,57138);
foreach(PSSession session in f_1605_56939_56972_I(f_1605_56939_56972(f_1605_56939_56962(this))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,56909,57138);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,57006,57123) || true) && (instanceId.Equals(f_1605_57028_57046(session)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1605,57006,57123);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,57089,57104);

return session;
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,57006,57123);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1605,56909,57138);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1605,1,230);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1605,1,230);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,57154,57166);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,56827,57177);

System.Management.Automation.RunspaceRepository
f_1605_56939_56962(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 56939, 56962);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1605_56939_56972(System.Management.Automation.RunspaceRepository
this_param)
{
var return_v = this_param.Runspaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 56939, 56972);
return return_v;
}


System.Guid
f_1605_57028_57046(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1605, 57028, 57046);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1605_56939_56972_I(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 56939, 56972);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,56827,57177);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,56827,57177);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void WriteInvalidArgumentError(PSRemotingErrorId errorId, string resourceString, object errorArgument)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1605,57279,57650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,57414,57473);

string 
message = f_1605_57431_57472(this, resourceString, errorArgument)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,57489,57639);

f_1605_57489_57638(this, f_1605_57500_57637(f_1605_57516_57546(message), f_1605_57548_57566(errorId), ErrorCategory.InvalidArgument, errorArgument));
DynAbs.Tracing.TraceSender.TraceExitMethod(1605,57279,57650);

string
f_1605_57431_57472(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,string
resourceString,params object[]
args)
{
var return_v = this_param.GetMessage( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 57431, 57472);
return return_v;
}


System.ArgumentException
f_1605_57516_57546(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 57516, 57546);
return return_v;
}


string
f_1605_57548_57566(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 57548, 57566);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1605_57500_57637(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 57500, 57637);
return return_v;
}


int
f_1605_57489_57638(Microsoft.PowerShell.Commands.ReceivePSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 57489, 57638);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1605,57279,57650);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,57279,57650);
}
		}

private bool _stopProcessing;

private RemotePipeline _remotePipeline;

private Job _job;

private ManualResetEvent _stopPipelineReceive;

private object _syncObject ;

public ReceivePSSessionCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1605,2925,57961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,4058,4393);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,4518,4803);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,4919,5473);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,6373,6381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,7516,7522);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,7711,8240);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,8777,8802);
this._allowRedirection = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,9657,10258);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,10391,11183);
this.OutTarget = OutTarget.Default;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,11312,12128);
this.JobName = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,13164,13177);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,14068,14083);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,14996,15007);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,15578,15855);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,16680,17126);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,57732,57747);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,57781,57796);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,57819,57823);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,57859,57879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,57905,57931);
this._syncObject = f_1605_57919_57931();DynAbs.Tracing.TraceSender.TraceExitConstructor(1605,2925,57961);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,2925,57961);
}


static ReceivePSSessionCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1605,2925,57961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,3472,3493);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,3525,3562);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,3594,3626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,3658,3713);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,3782,3847);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1605,3879,3942);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1605,2925,57961);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1605,2925,57961);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1605,2925,57961);

object
f_1605_57919_57931()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1605, 57919, 57931);
return return_v;
}

}

    
    /// <summary>
    /// Output modes available to the Receive-PSSession cmdlet.
    /// </summary>
    public enum OutTarget
    {
        /// <summary>
        /// Default mode.  If.
        /// </summary>
        Default = 0,

        /// <summary>
        /// Synchronous mode.  Receive-PSSession output data goes to host (returned by cmdlet object).
        /// </summary>
        Host = 1,

        /// <summary>
        /// Asynchronous mode.  Receive-PSSession ouput data goes to returned job object.
        /// </summary>
        Job = 2
    }

    }
