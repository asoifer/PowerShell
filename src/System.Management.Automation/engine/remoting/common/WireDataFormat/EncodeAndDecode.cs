// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Runspaces.Internal;
using System.Management.Automation.Tracing;
using System.Reflection;
using System.Threading;

using Microsoft.PowerShell;
using Microsoft.PowerShell.Commands;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    internal static class RemotingConstants
    {
        internal static readonly Version HostVersion;

        internal static readonly Version ProtocolVersionWin7RC;

        internal static readonly Version ProtocolVersionWin7RTM;

        internal static readonly Version ProtocolVersionWin8RTM;

        internal static readonly Version ProtocolVersionWin10RTM;

        internal static readonly Version ProtocolVersionCurrent;

        internal static readonly Version ProtocolVersion;

        internal static readonly string ComputerNameNoteProperty;

        internal static readonly string RunspaceIdNoteProperty;

        internal static readonly string ShowComputerNameNoteProperty;

        internal static readonly string SourceJobInstanceId;

        internal static readonly string EventObject;

        internal const string
        PSSessionConfigurationNoun = "PSSessionConfiguration"
        ;

        internal const string
        PSRemotingNoun = "PSRemoting"
        ;

        internal const string
        PSPluginDLLName = "pwrshplugin.dll"
        ;

        internal const string
        DefaultShellName = "Microsoft.PowerShell"
        ;

        internal const string
        MaxIdleTimeoutMS = "2147483647"
        ;

        static RemotingConstants()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1668, 2081, 4095);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 2170, 2207);
            HostVersion = f_1668_2184_2207(1, 0, 0, 0);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 2253, 2294);
            ProtocolVersionWin7RC = f_1668_2277_2294(2, 0);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 2338, 2380);
            ProtocolVersionWin7RTM = f_1668_2363_2380(2, 1);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 2424, 2466);
            ProtocolVersionWin8RTM = f_1668_2449_2466(2, 2);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 2510, 2553);
            ProtocolVersionWin10RTM = f_1668_2536_2553(2, 3);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 3057, 3099);
            ProtocolVersionCurrent = f_1668_3082_3099(2, 3);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 3143, 3183);
            ProtocolVersion = ProtocolVersionCurrent;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 3306, 3349);
            ComputerNameNoteProperty = "PSComputerName";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 3392, 3429);
            RunspaceIdNoteProperty = "RunspaceId";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 3472, 3523);
            ShowComputerNameNoteProperty = "PSShowComputerName";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 3566, 3611);
            SourceJobInstanceId = "PSSourceJobInstanceId";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 3654, 3683);
            EventObject = "PSEventObject";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 3766, 3819);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 3852, 3881);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 3914, 3949);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 3982, 4023);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 4056, 4087);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1668, 2081, 4095);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 2081, 4095);
        }


        static System.Version
        f_1668_2184_2207(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new System.Version(major, minor, build, revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 2184, 2207);
            return return_v;
        }


        static System.Version
        f_1668_2277_2294(int
        major, int
        minor)
        {
            var return_v = new System.Version(major, minor);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 2277, 2294);
            return return_v;
        }


        static System.Version
        f_1668_2363_2380(int
        major, int
        minor)
        {
            var return_v = new System.Version(major, minor);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 2363, 2380);
            return return_v;
        }


        static System.Version
        f_1668_2449_2466(int
        major, int
        minor)
        {
            var return_v = new System.Version(major, minor);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 2449, 2466);
            return return_v;
        }


        static System.Version
        f_1668_2536_2553(int
        major, int
        minor)
        {
            var return_v = new System.Version(major, minor);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 2536, 2553);
            return return_v;
        }


        static System.Version
        f_1668_3082_3099(int
        major, int
        minor)
        {
            var return_v = new System.Version(major, minor);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 3082, 3099);
            return return_v;
        }

    }
    internal static class RemoteDataNameStrings
    {
        internal const string
        Destination = "Destination"
        ;

        internal const string
        RemotingTargetInterface = "RemotingTargetInterface"
        ;

        internal const string
        ClientRunspacePoolId = "ClientRunspacePoolId"
        ;

        internal const string
        ClientPowerShellId = "ClientPowerShellId"
        ;

        internal const string
        Action = "Action"
        ;

        internal const string
        DataType = "DataType"
        ;

        internal const string
        TimeZone = "TimeZone"
        ;

        internal const string
        SenderInfoPreferenceVariable = "PSSenderInfo"
        ;

        internal const string
        MustComply = "MustComply"
        ;

        internal const string
        IsNegotiationSucceeded = "IsNegotiationSucceeded"
        ;

        internal const string
        PSv2TabExpansionFunction = "TabExpansion"
        ;

        internal const string
        PSv2TabExpansionFunctionText = @"
            param($line, $lastWord)
            & {
                function Write-Members ($sep='.')
                {
                    Invoke-Expression ('$_val=' + $_expression)

                    $_method = [Management.Automation.PSMemberTypes] `
                        'Method,CodeMethod,ScriptMethod,ParameterizedProperty'
                    if ($sep -eq '.')
                    {
                        $params = @{view = 'extended','adapted','base'}
                    }
                    else
                    {
                        $params = @{static=$true}
                    }

                    foreach ($_m in ,$_val | Get-Member @params $_pat |
                        Sort-Object membertype,name)
                    {
                        if ($_m.MemberType -band $_method)
                        {
                            # Return a method...
                            $_base + $_expression + $sep + $_m.name + '('
                        }
                        else {
                            # Return a property...
                            $_base + $_expression + $sep + $_m.name
                        }
                    }
                }

                # If a command name contains any of these chars, it needs to be quoted
                $_charsRequiringQuotes = ('`&@''#{}()$,;|<> ' + ""`t"").ToCharArray()

                # If a variable name contains any of these characters it needs to be in braces
                $_varsRequiringQuotes = ('-`&@''#{}()$,;|<> .\/' + ""`t"").ToCharArray()

                switch -regex ($lastWord)
                {
                    # Handle property and method expansion rooted at variables...
                    # e.g. $a.b.<tab>
                    '(^.*)(\$(\w|:|\.)+)\.([*\w]*)$' {
                        $_base = $matches[1]
                        $_expression = $matches[2]
                        $_pat = $matches[4] + '*'
                        Write-Members
                        break;
                    }

                    # Handle simple property and method expansion on static members...
                    # e.g. [datetime]::n<tab>
                    '(^.*)(\[(\w|\.|\+)+\])(\:\:|\.){0,1}([*\w]*)$' {
                        $_base = $matches[1]
                        $_expression = $matches[2]
                        $_pat = $matches[5] + '*'
                        Write-Members $(if (! $matches[4]) {'::'} else {$matches[4]})
                        break;
                    }

                    # Handle complex property and method expansion on static members
                    # where there are intermediate properties...
                    # e.g. [datetime]::now.d<tab>
                    '(^.*)(\[(\w|\.|\+)+\](\:\:|\.)(\w+\.)+)([*\w]*)$' {
                        $_base = $matches[1]  # everything before the expression
                        $_expression = $matches[2].TrimEnd('.') # expression less trailing '.'
                        $_pat = $matches[6] + '*'  # the member to look for...
                        Write-Members
                        break;
                    }

                    # Handle variable name expansion...
                    '(^.*\$)([*\w:]+)$' {
                        $_prefix = $matches[1]
                        $_varName = $matches[2]
                        $_colonPos = $_varname.IndexOf(':')
                        if ($_colonPos -eq -1)
                        {
                            $_varName = 'variable:' + $_varName
                            $_provider = ''
                        }
                        else
                        {
                            $_provider = $_varname.Substring(0, $_colonPos+1)
                        }

                        foreach ($_v in Get-ChildItem ($_varName + '*') | sort Name)
                        {
                            $_nameFound = $_v.name
                            $(if ($_nameFound.IndexOfAny($_varsRequiringQuotes) -eq -1) {'{0}{1}{2}'}
                            else {'{0}{{{1}{2}}}'}) -f $_prefix, $_provider, $_nameFound
                        }

                        break;
                    }

                    # Do completion on parameters...
                    '^-([*\w0-9]*)' {
                        $_pat = $matches[1] + '*'

                        # extract the command name from the string
                        # first split the string into statements and pipeline elements
                        # This doesn't handle strings however.
                        $_command = [regex]::Split($line, '[|;=]')[-1]

                        #  Extract the trailing unclosed block e.g. ls | foreach { cp
                        if ($_command -match '\{([^\{\}]*)$')
                        {
                            $_command = $matches[1]
                        }

                        # Extract the longest unclosed parenthetical expression...
                        if ($_command -match '\(([^()]*)$')
                        {
                            $_command = $matches[1]
                        }

                        # take the first space separated token of the remaining string
                        # as the command to look up. Trim any leading or trailing spaces
                        # so you don't get leading empty elements.
                        $_command = $_command.TrimEnd('-')
                        $_command,$_arguments = $_command.Trim().Split()

                        # now get the info object for it, -ArgumentList will force aliases to be resolved
                        # it also retrieves dynamic parameters
                        try
                        {
                            $_command = @(Get-Command -type 'Alias,Cmdlet,Function,Filter,ExternalScript' `
                                -Name $_command -ArgumentList $_arguments)[0]
                        }
                        catch
                        {
                            # see if the command is an alias. If so, resolve it to the real command
                            if(Test-Path alias:\$_command)
                            {
                                $_command = @(Get-Command -Type Alias $_command)[0].Definition
                            }

                            # If we were unsuccessful retrieving the command, try again without the parameters
                            $_command = @(Get-Command -type 'Cmdlet,Function,Filter,ExternalScript' `
                                -Name $_command)[0]
                        }

                        # remove errors generated by the command not being found, and break
                        if(-not $_command) { $error.RemoveAt(0); break; }

                        # expand the parameter sets and emit the matching elements
                        # need to use psbase.Keys in case 'keys' is one of the parameters
                        # to the cmdlet
                        foreach ($_n in $_command.Parameters.psbase.Keys)
                        {
                            if ($_n -like $_pat) { '-' + $_n }
                        }

                        break;
                    }

                    # Tab complete against history either #<pattern> or #<id>
                    '^#(\w*)' {
                        $_pattern = $matches[1]
                        if ($_pattern -match '^[0-9]+$')
                        {
                            Get-History -ea SilentlyContinue -Id $_pattern | ForEach-Object { $_.CommandLine }
                        }
                        else
                        {
                            $_pattern = '*' + $_pattern + '*'
                            Get-History -Count 32767 | Sort-Object -Descending Id| ForEach-Object { $_.CommandLine } | where { $_ -like $_pattern }
                        }

                        break;
                    }

                    # try to find a matching command...
                    default {
                        # parse the script...
                        $_tokens = [System.Management.Automation.PSParser]::Tokenize($line,
                            [ref] $null)

                        if ($_tokens)
                        {
                            $_lastToken = $_tokens[$_tokens.count - 1]
                            if ($_lastToken.Type -eq 'Command')
                            {
                                $_cmd = $_lastToken.Content

                                # don't look for paths...
                                if ($_cmd.IndexOfAny('/\:') -eq -1)
                                {
                                    # handle parsing errors - the last token string should be the last
                                    # string in the line...
                                    if ($lastword.Length -ge $_cmd.Length -and
                                        $lastword.substring($lastword.length-$_cmd.length) -eq $_cmd)
                                    {
                                        $_pat = $_cmd + '*'
                                        $_base = $lastword.substring(0, $lastword.length-$_cmd.length)

                                        # get files in current directory first, then look for commands...
                                        $( try {Resolve-Path -ea SilentlyContinue -Relative $_pat } catch {} ;
                                           try { $ExecutionContext.InvokeCommand.GetCommandName($_pat, $true, $false) |
                                               Sort-Object -Unique } catch {} ) |
                                                   # If the command contains non-word characters (space, ) ] ; ) etc.)
                                                   # then it needs to be quoted and prefixed with &
                                                   ForEach-Object {
                                                        if ($_.IndexOfAny($_charsRequiringQuotes) -eq -1) { $_ }
                                                        elseif ($_.IndexOf('''') -ge 0) {'& ''{0}''' -f $_.Replace('''','''''') }
                                                        else { '& ''{0}''' -f $_ }} |
                                                   ForEach-Object {'{0}{1}' -f $_base,$_ }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        "
        ;

        internal const string
        CallId = "ci"
        ;

        internal const string
        MethodId = "mi"
        ;

        internal const string
        MethodParameters = "mp"
        ;

        internal const string
        MethodReturnValue = "mr"
        ;

        internal const string
        MethodException = "me"
        ;

        internal const string
        PS_STARTUP_PROTOCOL_VERSION_NAME = "protocolversion"
        ;

        internal const string
        PublicKeyAsXml = "PublicKeyAsXml"
        ;

        internal const string
        PSVersion = "PSVersion"
        ;

        internal const string
        SerializationVersion = "SerializationVersion"
        ;

        internal const string
        MethodArrayElementType = "mat"
        ;

        internal const string
        MethodArrayLengths = "mal"
        ;

        internal const string
        MethodArrayElements = "mae"
        ;

        internal const string
        ObjectType = "T"
        ;

        internal const string
        ObjectValue = "V"
        ;

        internal const string
        DiscoveryName = "Name"
        ;

        internal const string
        DiscoveryType = "CommandType"
        ;

        internal const string
        DiscoveryModule = "Namespace"
        ;

        internal const string
        DiscoveryFullyQualifiedModule = "FullyQualifiedModule"
        ;

        internal const string
        DiscoveryArgumentList = "ArgumentList"
        ;

        internal const string
        DiscoveryCount = "Count"
        ;

        internal const string
        PSInvocationSettings = "PSInvocationSettings"
        ;

        internal const string
        ApartmentState = "ApartmentState"
        ;

        internal const string
        RemoteStreamOptions = "RemoteStreamOptions"
        ;

        internal const string
        AddToHistory = "AddToHistory"
        ;

        internal const string
        PowerShell = "PowerShell"
        ;

        internal const string
        IsNested = "IsNested"
        ;

        internal const string
        HistoryString = "History"
        ;

        internal const string
        RedirectShellErrorOutputPipe = "RedirectShellErrorOutputPipe"
        ;

        internal const string
        Commands = "Cmds"
        ;

        internal const string
        ExtraCommands = "ExtraCmds"
        ;

        internal const string
        CommandText = "Cmd"
        ;

        internal const string
        IsScript = "IsScript"
        ;

        internal const string
        UseLocalScopeNullable = "UseLocalScope"
        ;

        internal const string
        MergeUnclaimedPreviousCommandResults = "MergePreviousResults"
        ;

        internal const string
        MergeMyResult = "MergeMyResult"
        ;

        internal const string
        MergeToResult = "MergeToResult"
        ;

        internal const string
        MergeError = "MergeError"
        ;

        internal const string
        MergeWarning = "MergeWarning"
        ;

        internal const string
        MergeVerbose = "MergeVerbose"
        ;

        internal const string
        MergeDebug = "MergeDebug"
        ;

        internal const string
        MergeInformation = "MergeInformation"
        ;

        internal const string
        Parameters = "Args"
        ;

        internal const string
        ParameterName = "N"
        ;

        internal const string
        ParameterValue = "V"
        ;

        internal const string
        NoInput = "NoInput"
        ;

        internal const string
        ExceptionAsErrorRecord = "ExceptionAsErrorRecord"
        ;

        internal const string
        PipelineState = "PipelineState"
        ;

        internal const string
        RunspaceState = "RunspaceState"
        ;

        internal const string
        PSEventArgsComputerName = "PSEventArgs.ComputerName"
        ;

        internal const string
        PSEventArgsRunspaceId = "PSEventArgs.RunspaceId"
        ;

        internal const string
        PSEventArgsEventIdentifier = "PSEventArgs.EventIdentifier"
        ;

        internal const string
        PSEventArgsSourceIdentifier = "PSEventArgs.SourceIdentifier"
        ;

        internal const string
        PSEventArgsTimeGenerated = "PSEventArgs.TimeGenerated"
        ;

        internal const string
        PSEventArgsSender = "PSEventArgs.Sender"
        ;

        internal const string
        PSEventArgsSourceArgs = "PSEventArgs.SourceArgs"
        ;

        internal const string
        PSEventArgsMessageData = "PSEventArgs.MessageData"
        ;

        internal const string
        MinRunspaces = "MinRunspaces"
        ;

        internal const string
        MaxRunspaces = "MaxRunspaces"
        ;

        internal const string
        ThreadOptions = "PSThreadOptions"
        ;

        internal const string
        HostInfo = "HostInfo"
        ;

        internal const string
        RunspacePoolOperationResponse = "SetMinMaxRunspacesResponse"
        ;

        internal const string
        AvailableRunspaces = "AvailableRunspaces"
        ;

        internal const string
        PublicKey = "PublicKey"
        ;

        internal const string
        EncryptedSessionKey = "EncryptedSessionKey"
        ;

        internal const string
        ApplicationArguments = "ApplicationArguments"
        ;

        internal const string
        ApplicationPrivateData = "ApplicationPrivateData"
        ;

        internal const string
        ProgressRecord_Activity = "Activity"
        ;

        internal const string
        ProgressRecord_ActivityId = "ActivityId"
        ;

        internal const string
        ProgressRecord_CurrentOperation = "CurrentOperation"
        ;

        internal const string
        ProgressRecord_ParentActivityId = "ParentActivityId"
        ;

        internal const string
        ProgressRecord_PercentComplete = "PercentComplete"
        ;

        internal const string
        ProgressRecord_Type = "Type"
        ;

        internal const string
        ProgressRecord_SecondsRemaining = "SecondsRemaining"
        ;

        internal const string
        ProgressRecord_StatusDescription = "StatusDescription"
        ;

        static RemoteDataNameStrings()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1668, 4279, 22581);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 4361, 4388);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 4421, 4472);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 4505, 4550);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 4583, 4624);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 4657, 4674);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 4707, 4728);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 4836, 4857);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 4890, 4935);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 5090, 5115);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 5297, 5346);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 5430, 5471);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 5743, 16528);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 16655, 16668);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 16701, 16716);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 16749, 16772);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 16805, 16829);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 16862, 16884);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 16919, 16971);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 17004, 17037);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 17070, 17093);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 17126, 17171);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 17206, 17236);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 17269, 17295);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 17328, 17355);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 17390, 17406);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 17439, 17456);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 17559, 17581);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 17614, 17643);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 17676, 17705);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 17738, 17792);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 17825, 17863);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 17896, 17920);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 18007, 18052);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 18085, 18118);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 18151, 18194);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 18227, 18256);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 18291, 18316);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 18349, 18370);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 18403, 18428);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 18461, 18522);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 18555, 18572);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 18605, 18632);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 18665, 18684);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 18717, 18738);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 18771, 18810);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 18843, 18904);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 18937, 18968);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 19001, 19032);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 19065, 19090);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 19123, 19152);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 19185, 19214);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 19247, 19272);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 19305, 19342);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 19375, 19394);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 19427, 19446);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 19479, 19499);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 19534, 19553);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 19773, 19822);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 19996, 20027);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 20201, 20232);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 20440, 20492);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 20525, 20573);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 20606, 20664);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 20697, 20757);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 20790, 20844);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 20877, 20917);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 20950, 20998);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 21031, 21081);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 21182, 21211);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 21244, 21273);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 21306, 21339);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 21372, 21393);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 21426, 21486);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 21519, 21560);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 21593, 21616);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 21649, 21692);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 21725, 21770);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 21803, 21852);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 21956, 21992);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 22025, 22065);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 22098, 22150);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 22183, 22235);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 22268, 22318);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 22351, 22379);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 22412, 22464);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 22497, 22551);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1668, 4279, 22581);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 4279, 22581);
        }

    }

    /// <summary>
    /// The destination of the remote message.
    /// </summary>
    [Flags]
    internal enum RemotingDestination : uint
    {
        InvalidDestination = 0x0,
        Client = 0x1,
        Server = 0x2,
        Listener = 0x4,
    }

    /// <summary>
    /// The layer the remoting message is being communicated between.
    /// </summary>
    /// <remarks>
    /// Please keep in sync with RemotingTargetInterface from
    /// C:\e\win7_powershell\admin\monad\nttargets\assemblies\logging\ETW\Manifests\Microsoft-Windows-PowerShell-Instrumentation.man
    /// </remarks>
    internal enum RemotingTargetInterface : int
    {
        InvalidTargetInterface = 0,
        Session = 1,
        RunspacePool = 2,
        PowerShell = 3,
    }

    /// <summary>
    /// The type of the remoting message.
    /// </summary>
    /// <remarks>
    /// Please keep in sync with RemotingDataType from
    /// C:\e\win7_powershell\admin\monad\nttargets\assemblies\logging\ETW\Manifests\Microsoft-Windows-PowerShell-Instrumentation.man
    /// </remarks>
    internal enum RemotingDataType : uint
    {
        InvalidDataType = 0,

        /// <summary>
        /// This data type is used when an Exception derived from IContainsErrorRecord
        /// is caught on server and is sent to client. This exception gets
        /// serialized as an error record. On the client this data type is deserialized in
        /// to an ErrorRecord.
        ///
        /// ErrorRecord on the client has an instance of RemoteException as exception.
        /// </summary>
        ExceptionAsErrorRecord = 1,

        // Session messages
        SessionCapability = 0x00010002,
        CloseSession = 0x00010003,
        CreateRunspacePool = 0x00010004,
        PublicKey = 0x00010005,
        EncryptedSessionKey = 0x00010006,
        PublicKeyRequest = 0x00010007,
        ConnectRunspacePool = 0x00010008,

        // Runspace Pool messages
        SetMaxRunspaces = 0x00021002,
        SetMinRunspaces = 0x00021003,
        RunspacePoolOperationResponse = 0x00021004,
        RunspacePoolStateInfo = 0x00021005,
        CreatePowerShell = 0x00021006,
        AvailableRunspaces = 0x00021007,
        PSEventArgs = 0x00021008,
        ApplicationPrivateData = 0x00021009,
        GetCommandMetadata = 0x0002100A,
        RunspacePoolInitData = 0x0002100B,
        ResetRunspaceState = 0x0002100C,

        // Runspace host messages
        RemoteHostCallUsingRunspaceHost = 0x00021100,
        RemoteRunspaceHostResponseData = 0x00021101,

        // PowerShell messages
        PowerShellInput = 0x00041002,
        PowerShellInputEnd = 0x00041003,
        PowerShellOutput = 0x00041004,
        PowerShellErrorRecord = 0x00041005,
        PowerShellStateInfo = 0x00041006,
        PowerShellDebug = 0x00041007,
        PowerShellVerbose = 0x00041008,
        PowerShellWarning = 0x00041009,
        PowerShellProgress = 0x00041010,
        PowerShellInformationStream = 0x00041011,
        StopPowerShell = 0x00041012,

        // PowerShell host messages
        RemoteHostCallUsingPowerShellHost = 0x00041100,
        RemotePowerShellHostResponseData = 0x00041101,
    }
    internal static class RemotingEncoder
    {
        internal delegate T ValueGetterDelegate<T>();

        internal static void AddNoteProperty<T>(PSObject pso, string propertyName, ValueGetterDelegate<T> valueGetter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 26155, 27588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 26290, 26311);

                T
                value = default(T)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 26361, 26383);

                    value = f_1668_26369_26382(valueGetter);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1668, 26412, 27056);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 26464, 26547);

                    f_1668_26464_26546(false, "Internal code shouldn't throw exceptions during serialization");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 26567, 27041);

                    f_1668_26567_27040(PSEventId.Serializer_PropertyGetterFailed, PSOpcode.Exception, PSTask.Serialization, PSKeyword.Serializer | PSKeyword.UseAlwaysAnalytic, propertyName, (DynAbs.Tracing.TraceSender.Conditional_F1(1668, 26831, 26857) || ((f_1668_26831_26849(valueGetter) == null && DynAbs.Tracing.TraceSender.Conditional_F2(1668, 26860, 26872)) || DynAbs.Tracing.TraceSender.Conditional_F3(1668, 26875, 26912))) ? string.Empty : f_1668_26875_26912(f_1668_26875_26903(f_1668_26875_26893(valueGetter))), f_1668_26935_26947(e), (DynAbs.Tracing.TraceSender.Conditional_F1(1668, 26970, 26994) || ((f_1668_26970_26986(e) == null && DynAbs.Tracing.TraceSender.Conditional_F2(1668, 26997, 27009)) || DynAbs.Tracing.TraceSender.Conditional_F3(1668, 27012, 27039))) ? string.Empty : f_1668_27012_27039(f_1668_27012_27028(e)));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1668, 26412, 27056);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 27108, 27168);

                    f_1668_27108_27167(f_1668_27108_27122(pso), f_1668_27127_27166(propertyName, value));
                }
                catch (ExtendedTypeSystemException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1668, 27197, 27577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 27346, 27401);

                    var
                    existingValue = f_1668_27366_27400(f_1668_27366_27394(f_1668_27366_27380(pso), propertyName))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 27419, 27562);

                    f_1668_27419_27561(f_1668_27438_27473(existingValue, value), "Property already exists but new value differs.");
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1668, 27197, 27577);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 26155, 27588);

                T
                f_1668_26369_26382(System.Management.Automation.RemotingEncoder.ValueGetterDelegate<T>
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 26369, 26382);
                    return return_v;
                }


                int
                f_1668_26464_26546(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 26464, 26546);
                    return 0;
                }


                object
                f_1668_26831_26849(System.Management.Automation.RemotingEncoder.ValueGetterDelegate<T>
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 26831, 26849);
                    return return_v;
                }


                object
                f_1668_26875_26893(System.Management.Automation.RemotingEncoder.ValueGetterDelegate<T>
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 26875, 26893);
                    return return_v;
                }


                System.Type
                f_1668_26875_26903(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 26875, 26903);
                    return return_v;
                }


                string
                f_1668_26875_26912(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 26875, 26912);
                    return return_v;
                }


                string
                f_1668_26935_26947(System.Exception
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 26935, 26947);
                    return return_v;
                }


                System.Exception
                f_1668_26970_26986(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 26970, 26986);
                    return return_v;
                }


                System.Exception
                f_1668_27012_27028(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 27012, 27028);
                    return return_v;
                }


                string
                f_1668_27012_27039(System.Exception
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 27012, 27039);
                    return return_v;
                }


                int
                f_1668_26567_27040(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticWarning(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 26567, 27040);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_27108_27122(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 27108, 27122);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_27127_27166(string
                name, T
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 27127, 27166);
                    return return_v;
                }


                int
                f_1668_27108_27167(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 27108, 27167);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_27366_27380(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 27366, 27380);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1668_27366_27394(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 27366, 27394);
                    return return_v;
                }


                object
                f_1668_27366_27400(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 27366, 27400);
                    return return_v;
                }


                bool
                f_1668_27438_27473(object
                objA, T
                objB)
                {
                    var return_v = object.Equals(objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 27438, 27473);
                    return return_v;
                }


                int
                f_1668_27419_27561(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 27419, 27561);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 26155, 27588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 26155, 27588);
            }
        }

        internal static PSObject CreateEmptyPSObject()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 27600, 27995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 27671, 27701);

                PSObject
                pso = f_1668_27686_27700()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 27908, 27957);

                pso.InternalTypeNames = ConsolidatedString.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 27973, 27984);

                return pso;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 27600, 27995);

                System.Management.Automation.PSObject
                f_1668_27686_27700()
                {
                    var return_v = new System.Management.Automation.PSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 27686, 27700);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 27600, 27995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 27600, 27995);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSNoteProperty CreateHostInfoProperty(HostInfo hostInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 28007, 28249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 28103, 28238);

                return f_1668_28110_28237(RemoteDataNameStrings.HostInfo, f_1668_28196_28236(hostInfo));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 28007, 28249);

                object
                f_1668_28196_28236(System.Management.Automation.Remoting.HostInfo
                obj)
                {
                    var return_v = RemoteHostEncoder.EncodeObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 28196, 28236);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_28110_28237(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 28110, 28237);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 28007, 28249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 28007, 28249);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GenerateCreateRunspacePool(
                    Guid clientRunspacePoolId,
                    int minRunspaces,
                    int maxRunspaces,
                    RemoteRunspacePoolInternal runspacePool,
                    PSHost host,
                    PSPrimitiveDictionary applicationArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 30506, 32239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 30830, 30878);

                PSObject
                dataAsPSObject = f_1668_30856_30877()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 30892, 30992);

                f_1668_30892_30991(f_1668_30892_30917(dataAsPSObject), f_1668_30922_30990(RemoteDataNameStrings.MinRunspaces, minRunspaces));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 31006, 31106);

                f_1668_31006_31105(f_1668_31006_31031(dataAsPSObject), f_1668_31036_31104(RemoteDataNameStrings.MaxRunspaces, maxRunspaces));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 31120, 31235);

                f_1668_31120_31234(f_1668_31120_31145(dataAsPSObject), f_1668_31150_31233(RemoteDataNameStrings.ThreadOptions, f_1668_31206_31232(runspacePool)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 31249, 31304);

                ApartmentState
                poolState = f_1668_31276_31303(runspacePool)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 31318, 31417);

                f_1668_31318_31416(f_1668_31318_31343(dataAsPSObject), f_1668_31348_31415(RemoteDataNameStrings.ApartmentState, poolState));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 31431, 31547);

                f_1668_31431_31546(f_1668_31431_31456(dataAsPSObject), f_1668_31461_31545(RemoteDataNameStrings.ApplicationArguments, applicationArguments));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 31808, 31882);

                f_1668_31808_31881(f_1668_31808_31833(dataAsPSObject), f_1668_31838_31880(f_1668_31861_31879(host)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 31898, 32228);

                return f_1668_31905_32227(RemotingDestination.Server, RemotingDataType.CreateRunspacePool, clientRunspacePoolId, Guid.Empty, dataAsPSObject);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 30506, 32239);

                System.Management.Automation.PSObject
                f_1668_30856_30877()
                {
                    var return_v = CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 30856, 30877);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_30892_30917(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 30892, 30917);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_30922_30990(string
                name, int
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 30922, 30990);
                    return return_v;
                }


                int
                f_1668_30892_30991(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 30892, 30991);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_31006_31031(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 31006, 31031);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_31036_31104(string
                name, int
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 31036, 31104);
                    return return_v;
                }


                int
                f_1668_31006_31105(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 31006, 31105);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_31120_31145(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 31120, 31145);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSThreadOptions
                f_1668_31206_31232(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                this_param)
                {
                    var return_v = this_param.ThreadOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 31206, 31232);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_31150_31233(string
                name, System.Management.Automation.Runspaces.PSThreadOptions
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 31150, 31233);
                    return return_v;
                }


                int
                f_1668_31120_31234(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 31120, 31234);
                    return 0;
                }


                System.Threading.ApartmentState
                f_1668_31276_31303(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                this_param)
                {
                    var return_v = this_param.ApartmentState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 31276, 31303);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_31318_31343(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 31318, 31343);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_31348_31415(string
                name, System.Threading.ApartmentState
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 31348, 31415);
                    return return_v;
                }


                int
                f_1668_31318_31416(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 31318, 31416);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_31431_31456(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 31431, 31456);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_31461_31545(string
                name, System.Management.Automation.PSPrimitiveDictionary
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 31461, 31545);
                    return return_v;
                }


                int
                f_1668_31431_31546(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 31431, 31546);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_31808_31833(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 31808, 31833);
                    return return_v;
                }


                System.Management.Automation.Remoting.HostInfo
                f_1668_31861_31879(System.Management.Automation.Host.PSHost
                host)
                {
                    var return_v = new System.Management.Automation.Remoting.HostInfo(host);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 31861, 31879);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_31838_31880(System.Management.Automation.Remoting.HostInfo
                hostInfo)
                {
                    var return_v = CreateHostInfoProperty(hostInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 31838, 31880);
                    return return_v;
                }


                int
                f_1668_31808_31881(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 31808, 31881);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_31905_32227(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 31905, 32227);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 30506, 32239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 30506, 32239);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GenerateConnectRunspacePool(
                    Guid clientRunspacePoolId,
                    int minRunspaces,
                    int maxRunspaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 33650, 35185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 33838, 33886);

                PSObject
                dataAsPSObject = f_1668_33864_33885()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 33900, 33922);

                int
                propertyCount = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 33936, 34141) || true) && (minRunspaces != -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 33936, 34141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 33992, 34092);

                    f_1668_33992_34091(f_1668_33992_34017(dataAsPSObject), f_1668_34022_34090(RemoteDataNameStrings.MinRunspaces, minRunspaces));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 34110, 34126);

                    propertyCount++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 33936, 34141);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 34157, 34362) || true) && (maxRunspaces != -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 34157, 34362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 34213, 34313);

                    f_1668_34213_34312(f_1668_34213_34238(dataAsPSObject), f_1668_34243_34311(RemoteDataNameStrings.MaxRunspaces, maxRunspaces));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 34331, 34347);

                    propertyCount++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 34157, 34362);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 34378, 35174) || true) && (propertyCount > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 34378, 35174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 34433, 34764);

                    return f_1668_34440_34763(RemotingDestination.Server, RemotingDataType.ConnectRunspacePool, clientRunspacePoolId, Guid.Empty, dataAsPSObject);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 34378, 35174);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 34378, 35174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 34830, 35159);

                    return f_1668_34837_35158(RemotingDestination.Server, RemotingDataType.ConnectRunspacePool, clientRunspacePoolId, Guid.Empty, string.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 34378, 35174);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 33650, 35185);

                System.Management.Automation.PSObject
                f_1668_33864_33885()
                {
                    var return_v = CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 33864, 33885);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_33992_34017(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 33992, 34017);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_34022_34090(string
                name, int
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 34022, 34090);
                    return return_v;
                }


                int
                f_1668_33992_34091(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 33992, 34091);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_34213_34238(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 34213, 34238);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_34243_34311(string
                name, int
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 34243, 34311);
                    return return_v;
                }


                int
                f_1668_34213_34312(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 34213, 34312);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_34440_34763(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 34440, 34763);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_34837_35158(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, string
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 34837, 35158);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 33650, 35185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 33650, 35185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GenerateRunspacePoolInitData(
                    Guid runspacePoolId,
                    int minRunspaces,
                    int maxRunspaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 36611, 37421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 36794, 36842);

                PSObject
                dataAsPSObject = f_1668_36820_36841()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 36856, 36956);

                f_1668_36856_36955(f_1668_36856_36881(dataAsPSObject), f_1668_36886_36954(RemoteDataNameStrings.MinRunspaces, minRunspaces));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 36970, 37070);

                f_1668_36970_37069(f_1668_36970_36995(dataAsPSObject), f_1668_37000_37068(RemoteDataNameStrings.MaxRunspaces, maxRunspaces));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 37084, 37410);

                return f_1668_37091_37409(RemotingDestination.Client, RemotingDataType.RunspacePoolInitData, runspacePoolId, Guid.Empty, dataAsPSObject);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 36611, 37421);

                System.Management.Automation.PSObject
                f_1668_36820_36841()
                {
                    var return_v = CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 36820, 36841);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_36856_36881(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 36856, 36881);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_36886_36954(string
                name, int
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 36886, 36954);
                    return return_v;
                }


                int
                f_1668_36856_36955(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 36856, 36955);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_36970_36995(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 36970, 36995);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_37000_37068(string
                name, int
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 37000, 37068);
                    return return_v;
                }


                int
                f_1668_36970_37069(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 36970, 37069);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_37091_37409(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 37091, 37409);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 36611, 37421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 36611, 37421);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GenerateSetMaxRunspaces(Guid clientRunspacePoolId,
                                            int maxRunspaces, long callId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 38783, 39589);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 38959, 39007);

                PSObject
                dataAsPSObject = f_1668_38985_39006()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 39021, 39121);

                f_1668_39021_39120(f_1668_39021_39046(dataAsPSObject), f_1668_39051_39119(RemoteDataNameStrings.MaxRunspaces, maxRunspaces));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 39135, 39223);

                f_1668_39135_39222(f_1668_39135_39160(dataAsPSObject), f_1668_39165_39221(RemoteDataNameStrings.CallId, callId));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 39239, 39578);

                return f_1668_39246_39577(RemotingDestination.Server, RemotingDataType.SetMaxRunspaces, clientRunspacePoolId, Guid.Empty, dataAsPSObject);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 38783, 39589);

                System.Management.Automation.PSObject
                f_1668_38985_39006()
                {
                    var return_v = CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 38985, 39006);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_39021_39046(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 39021, 39046);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_39051_39119(string
                name, int
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 39051, 39119);
                    return return_v;
                }


                int
                f_1668_39021_39120(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 39021, 39120);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_39135_39160(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 39135, 39160);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_39165_39221(string
                name, long
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 39165, 39221);
                    return return_v;
                }


                int
                f_1668_39135_39222(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 39135, 39222);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_39246_39577(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 39246, 39577);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 38783, 39589);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 38783, 39589);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GenerateSetMinRunspaces(Guid clientRunspacePoolId,
                                            int minRunspaces, long callId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 40951, 41757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 41127, 41175);

                PSObject
                dataAsPSObject = f_1668_41153_41174()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 41189, 41289);

                f_1668_41189_41288(f_1668_41189_41214(dataAsPSObject), f_1668_41219_41287(RemoteDataNameStrings.MinRunspaces, minRunspaces));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 41303, 41391);

                f_1668_41303_41390(f_1668_41303_41328(dataAsPSObject), f_1668_41333_41389(RemoteDataNameStrings.CallId, callId));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 41407, 41746);

                return f_1668_41414_41745(RemotingDestination.Server, RemotingDataType.SetMinRunspaces, clientRunspacePoolId, Guid.Empty, dataAsPSObject);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 40951, 41757);

                System.Management.Automation.PSObject
                f_1668_41153_41174()
                {
                    var return_v = CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 41153, 41174);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_41189_41214(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 41189, 41214);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_41219_41287(string
                name, int
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 41219, 41287);
                    return return_v;
                }


                int
                f_1668_41189_41288(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 41189, 41288);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_41303_41328(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 41303, 41328);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_41333_41389(string
                name, long
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 41333, 41389);
                    return return_v;
                }


                int
                f_1668_41303_41390(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 41303, 41390);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_41414_41745(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 41414, 41745);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 40951, 41757);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 40951, 41757);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GenerateRunspacePoolOperationResponse(Guid clientRunspacePoolId,
                                            object response, long callId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 43056, 43902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 43245, 43293);

                PSObject
                dataAsPSObject = f_1668_43271_43292()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 43307, 43420);

                f_1668_43307_43419(f_1668_43307_43332(dataAsPSObject), f_1668_43337_43418(RemoteDataNameStrings.RunspacePoolOperationResponse, response));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 43434, 43522);

                f_1668_43434_43521(f_1668_43434_43459(dataAsPSObject), f_1668_43464_43520(RemoteDataNameStrings.CallId, callId));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 43538, 43891);

                return f_1668_43545_43890(RemotingDestination.Client, RemotingDataType.RunspacePoolOperationResponse, clientRunspacePoolId, Guid.Empty, dataAsPSObject);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 43056, 43902);

                System.Management.Automation.PSObject
                f_1668_43271_43292()
                {
                    var return_v = CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 43271, 43292);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_43307_43332(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 43307, 43332);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_43337_43418(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 43337, 43418);
                    return return_v;
                }


                int
                f_1668_43307_43419(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 43307, 43419);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_43434_43459(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 43434, 43459);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_43464_43520(string
                name, long
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 43464, 43520);
                    return return_v;
                }


                int
                f_1668_43434_43521(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 43434, 43521);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_43545_43890(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 43545, 43890);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 43056, 43902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 43056, 43902);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GenerateGetAvailableRunspaces(Guid clientRunspacePoolId,
                                            long callId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 44993, 45676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 45157, 45205);

                PSObject
                dataAsPSObject = f_1668_45183_45204()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 45219, 45307);

                f_1668_45219_45306(f_1668_45219_45244(dataAsPSObject), f_1668_45249_45305(RemoteDataNameStrings.CallId, callId));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 45323, 45665);

                return f_1668_45330_45664(RemotingDestination.Server, RemotingDataType.AvailableRunspaces, clientRunspacePoolId, Guid.Empty, dataAsPSObject);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 44993, 45676);

                System.Management.Automation.PSObject
                f_1668_45183_45204()
                {
                    var return_v = CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 45183, 45204);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_45219_45244(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 45219, 45244);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_45249_45305(string
                name, long
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 45249, 45305);
                    return return_v;
                }


                int
                f_1668_45219_45306(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 45219, 45306);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_45330_45664(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 45330, 45664);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 44993, 45676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 44993, 45676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GenerateMyPublicKey(Guid runspacePoolId,
                                            string publicKey, RemotingDestination destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 46774, 47455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 46960, 47008);

                PSObject
                dataAsPSObject = f_1668_46986_47007()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 47022, 47116);

                f_1668_47022_47115(f_1668_47022_47047(dataAsPSObject), f_1668_47052_47114(RemoteDataNameStrings.PublicKey, publicKey));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 47132, 47444);

                return f_1668_47139_47443(destination, RemotingDataType.PublicKey, runspacePoolId, Guid.Empty, dataAsPSObject);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 46774, 47455);

                System.Management.Automation.PSObject
                f_1668_46986_47007()
                {
                    var return_v = CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 46986, 47007);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_47022_47047(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 47022, 47047);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_47052_47114(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 47052, 47114);
                    return return_v;
                }


                int
                f_1668_47022_47115(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 47022, 47115);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_47139_47443(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 47139, 47443);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 46774, 47455);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 46774, 47455);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GeneratePublicKeyRequest(Guid runspacePoolId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 48380, 48826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 48483, 48815);

                return f_1668_48490_48814(RemotingDestination.Client, RemotingDataType.PublicKeyRequest, runspacePoolId, Guid.Empty, string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 48380, 48826);

                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_48490_48814(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, string
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 48490, 48814);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 48380, 48826);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 48380, 48826);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GenerateEncryptedSessionKeyResponse(Guid runspacePoolId,
                    string encryptedSessionKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 49822, 50562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 49977, 50025);

                PSObject
                dataAsPSObject = f_1668_50003_50024()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 50039, 50198);

                f_1668_50039_50197(f_1668_50039_50064(dataAsPSObject), f_1668_50069_50196(RemoteDataNameStrings.EncryptedSessionKey, encryptedSessionKey));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 50214, 50551);

                return f_1668_50221_50550(RemotingDestination.Client, RemotingDataType.EncryptedSessionKey, runspacePoolId, Guid.Empty, dataAsPSObject);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 49822, 50562);

                System.Management.Automation.PSObject
                f_1668_50003_50024()
                {
                    var return_v = CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 50003, 50024);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_50039_50064(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 50039, 50064);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_50069_50196(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 50069, 50196);
                    return return_v;
                }


                int
                f_1668_50039_50197(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 50039, 50197);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_50221_50550(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 50221, 50550);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 49822, 50562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 49822, 50562);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GenerateGetCommandMetadata(ClientRemotePowerShell shell)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 51874, 55530);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 51988, 52014);

                Command
                getCommand = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 52028, 52312);
                    foreach (Command c in f_1668_52050_52084_I(f_1668_52050_52084(f_1668_52050_52075(f_1668_52050_52066(shell)))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 52028, 52312);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 52118, 52297) || true) && (f_1668_52122_52193(f_1668_52122_52135(c), "Get-Command", StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 52118, 52297);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 52235, 52250);

                            getCommand = c;
                            DynAbs.Tracing.TraceSender.TraceBreak(1668, 52272, 52278);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 52118, 52297);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 52028, 52312);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1668, 1, 285);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1668, 1, 285);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 52328, 52464);

                f_1668_52328_52463(getCommand != null, "Whoever sets PowerShell.IsGetCommandMetadataSpecialPipeline needs to make sure Get-Command is present");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 52480, 52501);

                string[]
                name = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 52515, 52659);

                CommandTypes
                commandTypes = CommandTypes.Alias | CommandTypes.Cmdlet | CommandTypes.Function | CommandTypes.Filter | CommandTypes.Configuration
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 52673, 52696);

                string[]
                module = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 52710, 52760);

                ModuleSpecification[]
                fullyQualifiedModule = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 52776, 52805);

                object[]
                argumentList = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 52819, 54238);
                    foreach (CommandParameter p in f_1668_52850_52871_I(f_1668_52850_52871(getCommand)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 52819, 54238);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 52905, 54223) || true) && (f_1668_52909_52966(f_1668_52909_52915(p), "Name", StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 52905, 54223);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 53008, 53111);

                            name = (string[])f_1668_53025_53110(f_1668_53054_53061(p), typeof(string[]), f_1668_53081_53109());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 52905, 54223);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 52905, 54223);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 53153, 54223) || true) && (f_1668_53157_53221(f_1668_53157_53163(p), "CommandType", StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 53153, 54223);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 53263, 53382);

                                commandTypes = (CommandTypes)f_1668_53292_53381(f_1668_53321_53328(p), typeof(CommandTypes), f_1668_53352_53380());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 53153, 54223);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 53153, 54223);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 53424, 54223) || true) && (f_1668_53428_53487(f_1668_53428_53434(p), "Module", StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 53424, 54223);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 53529, 53634);

                                    module = (string[])f_1668_53548_53633(f_1668_53577_53584(p), typeof(string[]), f_1668_53604_53632());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 53424, 54223);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 53424, 54223);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 53676, 54223) || true) && (f_1668_53680_53753(f_1668_53680_53686(p), "FullyQualifiedModule", StringComparison.OrdinalIgnoreCase))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 53676, 54223);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 53795, 53940);

                                        fullyQualifiedModule = (ModuleSpecification[])f_1668_53841_53939(f_1668_53870_53877(p), typeof(ModuleSpecification[]), f_1668_53910_53938());
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 53676, 54223);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 53676, 54223);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 53982, 54223) || true) && (f_1668_53986_54051(f_1668_53986_53992(p), "ArgumentList", StringComparison.OrdinalIgnoreCase))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 53982, 54223);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 54093, 54204);

                                            argumentList = (object[])f_1668_54118_54203(f_1668_54147_54154(p), typeof(object[]), f_1668_54174_54202());
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 53982, 54223);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 53676, 54223);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 53424, 54223);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 53153, 54223);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 52905, 54223);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 52819, 54238);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1668, 1, 1420);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1668, 1, 1420);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 54254, 54333);

                RunspacePool
                rsPool = f_1668_54276_54316(f_1668_54276_54292(shell)) as RunspacePool
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 54347, 54436);

                f_1668_54347_54435(rsPool != null, "Runspacepool cannot be null for a CreatePowerShell request");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 54450, 54496);

                Guid
                clientRunspacePoolId = f_1668_54478_54495(rsPool)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 54512, 54560);

                PSObject
                dataAsPSObject = f_1668_54538_54559()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 54574, 54667);

                f_1668_54574_54666(f_1668_54574_54599(dataAsPSObject), f_1668_54604_54665(RemoteDataNameStrings.DiscoveryName, name));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 54681, 54782);

                f_1668_54681_54781(f_1668_54681_54706(dataAsPSObject), f_1668_54711_54780(RemoteDataNameStrings.DiscoveryType, commandTypes));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 54796, 54893);

                f_1668_54796_54892(f_1668_54796_54821(dataAsPSObject), f_1668_54826_54891(RemoteDataNameStrings.DiscoveryModule, module));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 54907, 55032);

                f_1668_54907_55031(f_1668_54907_54932(dataAsPSObject), f_1668_54937_55030(RemoteDataNameStrings.DiscoveryFullyQualifiedModule, fullyQualifiedModule));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 55046, 55155);

                f_1668_55046_55154(f_1668_55046_55071(dataAsPSObject), f_1668_55076_55153(RemoteDataNameStrings.DiscoveryArgumentList, argumentList));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 55171, 55519);

                return f_1668_55178_55518(RemotingDestination.Server, RemotingDataType.GetCommandMetadata, clientRunspacePoolId, f_1668_55437_55453(shell), dataAsPSObject);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 51874, 55530);

                System.Management.Automation.PowerShell
                f_1668_52050_52066(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    var return_v = this_param.PowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 52050, 52066);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1668_52050_52075(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 52050, 52075);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1668_52050_52084(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 52050, 52084);
                    return return_v;
                }


                string
                f_1668_52122_52135(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.CommandText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 52122, 52135);
                    return return_v;
                }


                bool
                f_1668_52122_52193(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 52122, 52193);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1668_52050_52084_I(System.Management.Automation.Runspaces.CommandCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 52050, 52084);
                    return return_v;
                }


                int
                f_1668_52328_52463(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 52328, 52463);
                    return 0;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1668_52850_52871(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 52850, 52871);
                    return return_v;
                }


                string
                f_1668_52909_52915(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 52909, 52915);
                    return return_v;
                }


                bool
                f_1668_52909_52966(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 52909, 52966);
                    return return_v;
                }


                object
                f_1668_53054_53061(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 53054, 53061);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1668_53081_53109()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 53081, 53109);
                    return return_v;
                }


                object
                f_1668_53025_53110(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 53025, 53110);
                    return return_v;
                }


                string
                f_1668_53157_53163(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 53157, 53163);
                    return return_v;
                }


                bool
                f_1668_53157_53221(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 53157, 53221);
                    return return_v;
                }


                object
                f_1668_53321_53328(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 53321, 53328);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1668_53352_53380()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 53352, 53380);
                    return return_v;
                }


                object
                f_1668_53292_53381(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 53292, 53381);
                    return return_v;
                }


                string
                f_1668_53428_53434(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 53428, 53434);
                    return return_v;
                }


                bool
                f_1668_53428_53487(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 53428, 53487);
                    return return_v;
                }


                object
                f_1668_53577_53584(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 53577, 53584);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1668_53604_53632()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 53604, 53632);
                    return return_v;
                }


                object
                f_1668_53548_53633(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 53548, 53633);
                    return return_v;
                }


                string
                f_1668_53680_53686(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 53680, 53686);
                    return return_v;
                }


                bool
                f_1668_53680_53753(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 53680, 53753);
                    return return_v;
                }


                object
                f_1668_53870_53877(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 53870, 53877);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1668_53910_53938()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 53910, 53938);
                    return return_v;
                }


                object
                f_1668_53841_53939(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 53841, 53939);
                    return return_v;
                }


                string
                f_1668_53986_53992(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 53986, 53992);
                    return return_v;
                }


                bool
                f_1668_53986_54051(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 53986, 54051);
                    return return_v;
                }


                object
                f_1668_54147_54154(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 54147, 54154);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1668_54174_54202()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 54174, 54202);
                    return return_v;
                }


                object
                f_1668_54118_54203(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 54118, 54203);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1668_52850_52871_I(System.Management.Automation.Runspaces.CommandParameterCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 52850, 52871);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1668_54276_54292(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    var return_v = this_param.PowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 54276, 54292);
                    return return_v;
                }


                object
                f_1668_54276_54316(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.GetRunspaceConnection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 54276, 54316);
                    return return_v;
                }


                int
                f_1668_54347_54435(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 54347, 54435);
                    return 0;
                }


                System.Guid
                f_1668_54478_54495(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 54478, 54495);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1668_54538_54559()
                {
                    var return_v = CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 54538, 54559);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_54574_54599(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 54574, 54599);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_54604_54665(string
                name, string[]
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 54604, 54665);
                    return return_v;
                }


                int
                f_1668_54574_54666(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 54574, 54666);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_54681_54706(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 54681, 54706);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_54711_54780(string
                name, System.Management.Automation.CommandTypes
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 54711, 54780);
                    return return_v;
                }


                int
                f_1668_54681_54781(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 54681, 54781);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_54796_54821(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 54796, 54821);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_54826_54891(string
                name, string[]
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 54826, 54891);
                    return return_v;
                }


                int
                f_1668_54796_54892(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 54796, 54892);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_54907_54932(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 54907, 54932);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_54937_55030(string
                name, Microsoft.PowerShell.Commands.ModuleSpecification[]
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 54937, 55030);
                    return return_v;
                }


                int
                f_1668_54907_55031(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 54907, 55031);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_55046_55071(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 55046, 55071);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_55076_55153(string
                name, object[]
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 55076, 55153);
                    return return_v;
                }


                int
                f_1668_55046_55154(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 55046, 55154);
                    return 0;
                }


                System.Guid
                f_1668_55437_55453(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 55437, 55453);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_55178_55518(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 55178, 55518);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 51874, 55530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 51874, 55530);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GenerateCreatePowerShell(ClientRemotePowerShell shell)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 57000, 59883);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 57112, 57153);

                PowerShell
                powerShell = f_1668_57136_57152(shell)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 57167, 57214);

                PSInvocationSettings
                settings = f_1668_57199_57213(shell)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 57230, 57278);

                PSObject
                dataAsPSObject = f_1668_57256_57277()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 57292, 57331);

                Guid
                clientRunspacePoolId = Guid.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 57345, 57363);

                HostInfo
                hostInfo
                = default(HostInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 57377, 57409);

                PSNoteProperty
                hostInfoProperty
                = default(PSNoteProperty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 57425, 57498);

                RunspacePool
                rsPool = f_1668_57447_57481(powerShell) as RunspacePool
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 57514, 57603);

                f_1668_57514_57602(rsPool != null, "Runspacepool cannot be null for a CreatePowerShell request");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 57619, 57660);

                clientRunspacePoolId = f_1668_57642_57659(rsPool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 57676, 57796);

                f_1668_57676_57795(f_1668_57676_57701(dataAsPSObject), f_1668_57706_57794(RemoteDataNameStrings.PowerShell, f_1668_57759_57793(powerShell)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 57810, 57906);

                f_1668_57810_57905(f_1668_57810_57835(dataAsPSObject), f_1668_57840_57904(RemoteDataNameStrings.NoInput, f_1668_57890_57903(shell)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 57922, 59259) || true) && (settings == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 57922, 59259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 57976, 58006);

                    hostInfo = f_1668_57987_58005(null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 58024, 58056);

                    hostInfo.UseRunspaceHost = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 58076, 58136);

                    ApartmentState
                    passedApartmentState = f_1668_58114_58135(rsPool)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 58154, 58264);

                    f_1668_58154_58263(f_1668_58154_58179(dataAsPSObject), f_1668_58184_58262(RemoteDataNameStrings.ApartmentState, passedApartmentState));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 58282, 58414);

                    f_1668_58282_58413(f_1668_58282_58307(dataAsPSObject), f_1668_58312_58412(RemoteDataNameStrings.RemoteStreamOptions, RemoteStreamOptions.AddInvocationInfo));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 58432, 58525);

                    f_1668_58432_58524(f_1668_58432_58457(dataAsPSObject), f_1668_58462_58523(RemoteDataNameStrings.AddToHistory, false));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 57922, 59259);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 57922, 59259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 58591, 58630);

                    hostInfo = f_1668_58602_58629(f_1668_58615_58628(settings));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 58648, 58766) || true) && (f_1668_58652_58665(settings) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 58648, 58766);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 58715, 58747);

                        hostInfo.UseRunspaceHost = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 58648, 58766);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 58786, 58848);

                    ApartmentState
                    passedApartmentState = f_1668_58824_58847(settings)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 58866, 58976);

                    f_1668_58866_58975(f_1668_58866_58891(dataAsPSObject), f_1668_58896_58974(RemoteDataNameStrings.ApartmentState, passedApartmentState));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 58994, 59117);

                    f_1668_58994_59116(f_1668_58994_59019(dataAsPSObject), f_1668_59024_59115(RemoteDataNameStrings.RemoteStreamOptions, f_1668_59086_59114(settings)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 59135, 59244);

                    f_1668_59135_59243(f_1668_59135_59160(dataAsPSObject), f_1668_59165_59242(RemoteDataNameStrings.AddToHistory, f_1668_59220_59241(settings)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 57922, 59259);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 59275, 59327);

                hostInfoProperty = f_1668_59294_59326(hostInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 59341, 59389);

                f_1668_59341_59388(f_1668_59341_59366(dataAsPSObject), hostInfoProperty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 59403, 59512);

                f_1668_59403_59511(f_1668_59403_59428(dataAsPSObject), f_1668_59433_59510(RemoteDataNameStrings.IsNested, f_1668_59484_59509(f_1668_59484_59500(shell))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 59526, 59872);

                return f_1668_59533_59871(RemotingDestination.Server, RemotingDataType.CreatePowerShell, clientRunspacePoolId, f_1668_59790_59806(shell), dataAsPSObject);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 57000, 59883);

                System.Management.Automation.PowerShell
                f_1668_57136_57152(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    var return_v = this_param.PowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 57136, 57152);
                    return return_v;
                }


                System.Management.Automation.PSInvocationSettings
                f_1668_57199_57213(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    var return_v = this_param.Settings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 57199, 57213);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1668_57256_57277()
                {
                    var return_v = CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 57256, 57277);
                    return return_v;
                }


                object
                f_1668_57447_57481(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.GetRunspaceConnection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 57447, 57481);
                    return return_v;
                }


                int
                f_1668_57514_57602(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 57514, 57602);
                    return 0;
                }


                System.Guid
                f_1668_57642_57659(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 57642, 57659);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_57676_57701(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 57676, 57701);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1668_57759_57793(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.ToPSObjectForRemoting();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 57759, 57793);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_57706_57794(string
                name, System.Management.Automation.PSObject
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 57706, 57794);
                    return return_v;
                }


                int
                f_1668_57676_57795(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 57676, 57795);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_57810_57835(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 57810, 57835);
                    return return_v;
                }


                bool
                f_1668_57890_57903(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    var return_v = this_param.NoInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 57890, 57903);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_57840_57904(string
                name, bool
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 57840, 57904);
                    return return_v;
                }


                int
                f_1668_57810_57905(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 57810, 57905);
                    return 0;
                }


                System.Management.Automation.Remoting.HostInfo
                f_1668_57987_58005(System.Management.Automation.Host.PSHost
                host)
                {
                    var return_v = new System.Management.Automation.Remoting.HostInfo(host);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 57987, 58005);
                    return return_v;
                }


                System.Threading.ApartmentState
                f_1668_58114_58135(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.ApartmentState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 58114, 58135);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_58154_58179(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 58154, 58179);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_58184_58262(string
                name, System.Threading.ApartmentState
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 58184, 58262);
                    return return_v;
                }


                int
                f_1668_58154_58263(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 58154, 58263);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_58282_58307(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 58282, 58307);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_58312_58412(string
                name, System.Management.Automation.RemoteStreamOptions
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 58312, 58412);
                    return return_v;
                }


                int
                f_1668_58282_58413(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 58282, 58413);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_58432_58457(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 58432, 58457);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_58462_58523(string
                name, bool
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 58462, 58523);
                    return return_v;
                }


                int
                f_1668_58432_58524(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 58432, 58524);
                    return 0;
                }


                System.Management.Automation.Host.PSHost
                f_1668_58615_58628(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 58615, 58628);
                    return return_v;
                }


                System.Management.Automation.Remoting.HostInfo
                f_1668_58602_58629(System.Management.Automation.Host.PSHost
                host)
                {
                    var return_v = new System.Management.Automation.Remoting.HostInfo(host);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 58602, 58629);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1668_58652_58665(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 58652, 58665);
                    return return_v;
                }


                System.Threading.ApartmentState
                f_1668_58824_58847(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.ApartmentState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 58824, 58847);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_58866_58891(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 58866, 58891);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_58896_58974(string
                name, System.Threading.ApartmentState
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 58896, 58974);
                    return return_v;
                }


                int
                f_1668_58866_58975(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 58866, 58975);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_58994_59019(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 58994, 59019);
                    return return_v;
                }


                System.Management.Automation.RemoteStreamOptions
                f_1668_59086_59114(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.RemoteStreamOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 59086, 59114);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_59024_59115(string
                name, System.Management.Automation.RemoteStreamOptions
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 59024, 59115);
                    return return_v;
                }


                int
                f_1668_58994_59116(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 58994, 59116);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_59135_59160(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 59135, 59160);
                    return return_v;
                }


                bool
                f_1668_59220_59241(System.Management.Automation.PSInvocationSettings
                this_param)
                {
                    var return_v = this_param.AddToHistory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 59220, 59241);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_59165_59242(string
                name, bool
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 59165, 59242);
                    return return_v;
                }


                int
                f_1668_59135_59243(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 59135, 59243);
                    return 0;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_59294_59326(System.Management.Automation.Remoting.HostInfo
                hostInfo)
                {
                    var return_v = CreateHostInfoProperty(hostInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 59294, 59326);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_59341_59366(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 59341, 59366);
                    return return_v;
                }


                int
                f_1668_59341_59388(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 59341, 59388);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_59403_59428(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 59403, 59428);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1668_59484_59500(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    var return_v = this_param.PowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 59484, 59500);
                    return return_v;
                }


                bool
                f_1668_59484_59509(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.IsNested;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 59484, 59509);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_59433_59510(string
                name, bool
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 59433, 59510);
                    return return_v;
                }


                int
                f_1668_59403_59511(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 59403, 59511);
                    return 0;
                }


                System.Guid
                f_1668_59790_59806(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 59790, 59806);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_59533_59871(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 59533, 59871);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 57000, 59883);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 57000, 59883);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GenerateApplicationPrivateData(
                                            Guid clientRunspacePoolId,
                                            PSPrimitiveDictionary applicationPrivateData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 61022, 61815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 61258, 61306);

                PSObject
                dataAsPSObject = f_1668_61284_61305()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 61322, 61442);

                f_1668_61322_61441(f_1668_61322_61347(dataAsPSObject), f_1668_61352_61440(RemoteDataNameStrings.ApplicationPrivateData, applicationPrivateData));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 61458, 61804);

                return f_1668_61465_61803(RemotingDestination.Client, RemotingDataType.ApplicationPrivateData, clientRunspacePoolId, Guid.Empty, dataAsPSObject);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 61022, 61815);

                System.Management.Automation.PSObject
                f_1668_61284_61305()
                {
                    var return_v = CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 61284, 61305);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_61322_61347(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 61322, 61347);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_61352_61440(string
                name, System.Management.Automation.PSPrimitiveDictionary
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 61352, 61440);
                    return return_v;
                }


                int
                f_1668_61322_61441(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 61322, 61441);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_61465_61803(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 61465, 61803);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 61022, 61815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 61022, 61815);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GenerateRunspacePoolStateInfo(
                                            Guid clientRunspacePoolId,
                                            RunspacePoolStateInfo stateInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 62936, 64428);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 63224, 63272);

                PSObject
                dataAsPSObject = f_1668_63250_63271()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 63323, 63488);

                PSNoteProperty
                stateProperty =
                f_1668_63379_63487(RemoteDataNameStrings.RunspaceState, (int)(f_1668_63470_63485(stateInfo)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 63502, 63547);

                f_1668_63502_63546(f_1668_63502_63527(dataAsPSObject), stateProperty);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 63599, 64056) || true) && (f_1668_63603_63619(stateInfo) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 63599, 64056);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 63796, 63845);

                    string
                    errorId = "RemoteRunspaceStateInfoReason"
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 63863, 63974);

                    PSNoteProperty
                    exceptionProperty = f_1668_63898_63973(f_1668_63919_63935(stateInfo), errorId, ErrorCategory.NotSpecified)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 63992, 64041);

                    f_1668_63992_64040(f_1668_63992_64017(dataAsPSObject), exceptionProperty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 63599, 64056);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 64072, 64417);

                return f_1668_64079_64416(RemotingDestination.Client, RemotingDataType.RunspacePoolStateInfo, clientRunspacePoolId, Guid.Empty, dataAsPSObject);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 62936, 64428);

                System.Management.Automation.PSObject
                f_1668_63250_63271()
                {
                    var return_v = CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 63250, 63271);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1668_63470_63485(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 63470, 63485);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_63379_63487(string
                name, int
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 63379, 63487);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_63502_63527(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 63502, 63527);
                    return return_v;
                }


                int
                f_1668_63502_63546(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 63502, 63546);
                    return 0;
                }


                System.Exception
                f_1668_63603_63619(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 63603, 63619);
                    return return_v;
                }


                System.Exception
                f_1668_63919_63935(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 63919, 63935);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_63898_63973(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                category)
                {
                    var return_v = GetExceptionProperty(exception, errorId, category);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 63898, 63973);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_63992_64017(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 63992, 64017);
                    return return_v;
                }


                int
                f_1668_63992_64040(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 63992, 64040);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_64079_64416(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 64079, 64416);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 62936, 64428);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 62936, 64428);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GeneratePSEventArgs(Guid clientRunspacePoolId, PSEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 65532, 67073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 65651, 65699);

                PSObject
                dataAsPSObject = f_1668_65677_65698()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 65715, 65834);

                f_1668_65715_65833(f_1668_65715_65740(dataAsPSObject), f_1668_65745_65832(RemoteDataNameStrings.PSEventArgsEventIdentifier, f_1668_65814_65831(e)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 65848, 65969);

                f_1668_65848_65968(f_1668_65848_65873(dataAsPSObject), f_1668_65878_65967(RemoteDataNameStrings.PSEventArgsSourceIdentifier, f_1668_65948_65966(e)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 65983, 66098);

                f_1668_65983_66097(f_1668_65983_66008(dataAsPSObject), f_1668_66013_66096(RemoteDataNameStrings.PSEventArgsTimeGenerated, f_1668_66080_66095(e)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 66112, 66213);

                f_1668_66112_66212(f_1668_66112_66137(dataAsPSObject), f_1668_66142_66211(RemoteDataNameStrings.PSEventArgsSender, f_1668_66202_66210(e)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 66227, 66336);

                f_1668_66227_66335(f_1668_66227_66252(dataAsPSObject), f_1668_66257_66334(RemoteDataNameStrings.PSEventArgsSourceArgs, f_1668_66321_66333(e)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 66350, 66461);

                f_1668_66350_66460(f_1668_66350_66375(dataAsPSObject), f_1668_66380_66459(RemoteDataNameStrings.PSEventArgsMessageData, f_1668_66445_66458(e)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 66475, 66588);

                f_1668_66475_66587(f_1668_66475_66500(dataAsPSObject), f_1668_66505_66586(RemoteDataNameStrings.PSEventArgsComputerName, f_1668_66571_66585(e)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 66602, 66711);

                f_1668_66602_66710(f_1668_66602_66627(dataAsPSObject), f_1668_66632_66709(RemoteDataNameStrings.PSEventArgsRunspaceId, f_1668_66696_66708(e)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 66727, 67062);

                return f_1668_66734_67061(RemotingDestination.Client, RemotingDataType.PSEventArgs, clientRunspacePoolId, Guid.Empty, dataAsPSObject);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 65532, 67073);

                System.Management.Automation.PSObject
                f_1668_65677_65698()
                {
                    var return_v = CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 65677, 65698);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_65715_65740(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 65715, 65740);
                    return return_v;
                }


                int
                f_1668_65814_65831(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.EventIdentifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 65814, 65831);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_65745_65832(string
                name, int
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 65745, 65832);
                    return return_v;
                }


                int
                f_1668_65715_65833(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 65715, 65833);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_65848_65873(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 65848, 65873);
                    return return_v;
                }


                string
                f_1668_65948_65966(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.SourceIdentifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 65948, 65966);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_65878_65967(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 65878, 65967);
                    return return_v;
                }


                int
                f_1668_65848_65968(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 65848, 65968);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_65983_66008(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 65983, 66008);
                    return return_v;
                }


                System.DateTime
                f_1668_66080_66095(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.TimeGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 66080, 66095);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_66013_66096(string
                name, System.DateTime
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 66013, 66096);
                    return return_v;
                }


                int
                f_1668_65983_66097(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 65983, 66097);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_66112_66137(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 66112, 66137);
                    return return_v;
                }


                object
                f_1668_66202_66210(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.Sender;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 66202, 66210);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_66142_66211(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 66142, 66211);
                    return return_v;
                }


                int
                f_1668_66112_66212(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 66112, 66212);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_66227_66252(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 66227, 66252);
                    return return_v;
                }


                object[]
                f_1668_66321_66333(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.SourceArgs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 66321, 66333);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_66257_66334(string
                name, object[]
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 66257, 66334);
                    return return_v;
                }


                int
                f_1668_66227_66335(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 66227, 66335);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_66350_66375(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 66350, 66375);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1668_66445_66458(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.MessageData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 66445, 66458);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_66380_66459(string
                name, System.Management.Automation.PSObject
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 66380, 66459);
                    return return_v;
                }


                int
                f_1668_66350_66460(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 66350, 66460);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_66475_66500(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 66475, 66500);
                    return return_v;
                }


                string
                f_1668_66571_66585(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 66571, 66585);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_66505_66586(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 66505, 66586);
                    return return_v;
                }


                int
                f_1668_66475_66587(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 66475, 66587);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_66602_66627(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 66602, 66627);
                    return return_v;
                }


                System.Guid
                f_1668_66696_66708(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.RunspaceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 66696, 66708);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_66632_66709(string
                name, System.Guid
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 66632, 66709);
                    return return_v;
                }


                int
                f_1668_66602_66710(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 66602, 66710);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_66734_67061(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 66734, 67061);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 65532, 67073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 65532, 67073);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GenerateResetRunspaceState(Guid clientRunspacePoolId, long callId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 68190, 68833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 68314, 68362);

                PSObject
                dataAsPSObject = f_1668_68340_68361()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 68376, 68464);

                f_1668_68376_68463(f_1668_68376_68401(dataAsPSObject), f_1668_68406_68462(RemoteDataNameStrings.CallId, callId));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 68480, 68822);

                return f_1668_68487_68821(RemotingDestination.Server, RemotingDataType.ResetRunspaceState, clientRunspacePoolId, Guid.Empty, dataAsPSObject);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 68190, 68833);

                System.Management.Automation.PSObject
                f_1668_68340_68361()
                {
                    var return_v = CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 68340, 68361);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_68376_68401(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 68376, 68401);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_68406_68462(string
                name, long
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 68406, 68462);
                    return return_v;
                }


                int
                f_1668_68376_68463(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 68376, 68463);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_68487_68821(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 68487, 68821);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 68190, 68833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 68190, 68833);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Version GetPSRemotingProtocolVersion(RunspacePool rsPool)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 69094, 69358);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 69192, 69347);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1668, 69199, 69260) || (((rsPool != null && (DynAbs.Tracing.TraceSender.Expression_True(1668, 69200, 69259) && f_1668_69218_69251(rsPool) != null)) && DynAbs.Tracing.TraceSender.Conditional_F2(1668, 69280, 69339)) || DynAbs.Tracing.TraceSender.Conditional_F3(1668, 69342, 69346))) ? f_1668_69280_69339(f_1668_69280_69313(rsPool)) : null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 69094, 69358);

                System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                f_1668_69218_69251(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.RemoteRunspacePoolInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 69218, 69251);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                f_1668_69280_69313(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.RemoteRunspacePoolInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 69280, 69313);
                    return return_v;
                }


                System.Version
                f_1668_69280_69339(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                this_param)
                {
                    var return_v = this_param.PSRemotingProtocolVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 69280, 69339);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 69094, 69358);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 69094, 69358);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GeneratePowerShellInput(object data, Guid clientRemoteRunspacePoolId,
                    Guid clientPowerShellId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 70632, 71151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 70797, 71140);

                return f_1668_70804_71139(RemotingDestination.Server, RemotingDataType.PowerShellInput, clientRemoteRunspacePoolId, clientPowerShellId, data);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 70632, 71151);

                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_70804_71139(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, object
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 70804, 71139);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 70632, 71151);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 70632, 71151);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GeneratePowerShellInputEnd(Guid clientRemoteRunspacePoolId,
                    Guid clientPowerShellId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 72266, 72778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 72421, 72767);

                return f_1668_72428_72766(RemotingDestination.Server, RemotingDataType.PowerShellInputEnd, clientRemoteRunspacePoolId, clientPowerShellId, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 72266, 72778);

                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_72428_72766(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, object
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 72428, 72766);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 72266, 72778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 72266, 72778);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GeneratePowerShellOutput(PSObject data, Guid clientPowerShellId,
                    Guid clientRunspacePoolId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 74068, 74579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 74230, 74568);

                return f_1668_74237_74567(RemotingDestination.Client, RemotingDataType.PowerShellOutput, clientRunspacePoolId, clientPowerShellId, data);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 74068, 74579);

                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_74237_74567(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 74237, 74567);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 74068, 74579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 74068, 74579);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GeneratePowerShellInformational(object data,
                    Guid clientRunspacePoolId, Guid clientPowerShellId, RemotingDataType dataType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 76021, 76560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 76215, 76549);

                return f_1668_76222_76548(RemotingDestination.Client, dataType, clientRunspacePoolId, clientPowerShellId, f_1668_76522_76547(data));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 76021, 76560);

                System.Management.Automation.PSObject
                f_1668_76522_76547(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 76522, 76547);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_76222_76548(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 76222, 76548);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 76021, 76560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 76021, 76560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GeneratePowerShellInformational(ProgressRecord progressRecord,
                    Guid clientRunspacePoolId, Guid clientPowerShellId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 77886, 78610);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 78071, 78209) || true) && (progressRecord == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 78071, 78209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 78131, 78194);

                    throw f_1668_78137_78193("progressRecord");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 78071, 78209);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 78225, 78599);

                return f_1668_78232_78598(RemotingDestination.Client, RemotingDataType.PowerShellProgress, clientRunspacePoolId, clientPowerShellId, f_1668_78559_78597(progressRecord));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 77886, 78610);

                System.Management.Automation.PSArgumentNullException
                f_1668_78137_78193(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 78137, 78193);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1668_78559_78597(System.Management.Automation.ProgressRecord
                this_param)
                {
                    var return_v = this_param.ToPSObjectForRemoting();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 78559, 78597);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_78232_78598(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 78232, 78598);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 77886, 78610);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 77886, 78610);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GeneratePowerShellInformational(InformationRecord informationRecord,
                    Guid clientRunspacePoolId, Guid clientPowerShellId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 80003, 80751);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 80194, 80338) || true) && (informationRecord == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 80194, 80338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 80257, 80323);

                    throw f_1668_80263_80322("informationRecord");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 80194, 80338);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 80354, 80740);

                return f_1668_80361_80739(RemotingDestination.Client, RemotingDataType.PowerShellInformationStream, clientRunspacePoolId, clientPowerShellId, f_1668_80697_80738(informationRecord));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 80003, 80751);

                System.Management.Automation.PSArgumentNullException
                f_1668_80263_80322(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 80263, 80322);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1668_80697_80738(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.ToPSObjectForRemoting();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 80697, 80738);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_80361_80739(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 80361, 80739);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 80003, 80751);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 80003, 80751);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GeneratePowerShellError(object errorRecord,
                    Guid clientRunspacePoolId, Guid clientPowerShellId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 82057, 82605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 82223, 82594);

                return f_1668_82230_82593(RemotingDestination.Client, RemotingDataType.PowerShellErrorRecord, clientRunspacePoolId, clientPowerShellId, f_1668_82560_82592(errorRecord));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 82057, 82605);

                System.Management.Automation.PSObject
                f_1668_82560_82592(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 82560, 82592);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_82230_82593(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 82230, 82593);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 82057, 82605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 82057, 82605);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GeneratePowerShellStateInfo(PSInvocationStateInfo stateInfo,
                    Guid clientPowerShellId, Guid clientRunspacePoolId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 83915, 85405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 84152, 84200);

                PSObject
                dataAsPSObject = f_1668_84178_84199()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 84277, 84406);

                PSNoteProperty
                stateProperty = f_1668_84308_84405(RemoteDataNameStrings.PipelineState, (int)(f_1668_84388_84403(stateInfo)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 84420, 84465);

                f_1668_84420_84464(f_1668_84420_84445(dataAsPSObject), stateProperty);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 84520, 85027) || true) && (f_1668_84524_84540(stateInfo) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 84520, 85027);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 84717, 84770);

                    string
                    errorId = "RemotePSInvocationStateInfoReason"
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 84788, 84945);

                    PSNoteProperty
                    exceptionProperty =
                    f_1668_84844_84944(f_1668_84865_84881(stateInfo), errorId, ErrorCategory.NotSpecified)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 84963, 85012);

                    f_1668_84963_85011(f_1668_84963_84988(dataAsPSObject), exceptionProperty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 84520, 85027);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 85043, 85394);

                return f_1668_85050_85393(RemotingDestination.Client, RemotingDataType.PowerShellStateInfo, clientRunspacePoolId, clientPowerShellId, dataAsPSObject);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 83915, 85405);

                System.Management.Automation.PSObject
                f_1668_84178_84199()
                {
                    var return_v = CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 84178, 84199);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1668_84388_84403(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 84388, 84403);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_84308_84405(string
                name, int
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 84308, 84405);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_84420_84445(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 84420, 84445);
                    return return_v;
                }


                int
                f_1668_84420_84464(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 84420, 84464);
                    return 0;
                }


                System.Exception
                f_1668_84524_84540(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 84524, 84540);
                    return return_v;
                }


                System.Exception
                f_1668_84865_84881(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 84865, 84881);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_84844_84944(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                category)
                {
                    var return_v = GetExceptionProperty(exception, errorId, category);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 84844, 84944);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_84963_84988(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 84963, 84988);
                    return return_v;
                }


                int
                f_1668_84963_85011(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 84963, 85011);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_85050_85393(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 85050, 85393);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 83915, 85405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 83915, 85405);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ErrorRecord GetErrorRecordFromException(Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 85847, 86497);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 85948, 86013);

                f_1668_85948_86012(exception != null, "Caller should validate the data");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 86029, 86051);

                ErrorRecord
                er = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 86065, 86126);

                IContainsErrorRecord
                cer = exception as IContainsErrorRecord
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 86140, 86460) || true) && (cer != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 86140, 86460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 86189, 86210);

                    er = f_1668_86194_86209(cer);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 86409, 86445);

                    er = f_1668_86414_86444(er, exception);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 86140, 86460);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 86476, 86486);

                return er;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 85847, 86497);

                int
                f_1668_85948_86012(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 85948, 86012);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1668_86194_86209(System.Management.Automation.IContainsErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 86194, 86209);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1668_86414_86444(System.Management.Automation.ErrorRecord
                errorRecord, System.Exception
                replaceParentContainsErrorRecordException)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(errorRecord, replaceParentContainsErrorRecordException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 86414, 86444);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 85847, 86497);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 85847, 86497);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSNoteProperty GetExceptionProperty(Exception exception, string errorId, ErrorCategory category)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 86911, 87370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 87047, 87112);

                f_1668_87047_87111(exception != null, "Caller should validate the data");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 87128, 87269);

                ErrorRecord
                er = f_1668_87145_87183(exception) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.ErrorRecord>(1668, 87145, 87268) ?? f_1668_87217_87268(exception, errorId, category, null))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 87283, 87359);

                return f_1668_87290_87358(RemoteDataNameStrings.ExceptionAsErrorRecord, er);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 86911, 87370);

                int
                f_1668_87047_87111(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 87047, 87111);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1668_87145_87183(System.Exception
                exception)
                {
                    var return_v = GetErrorRecordFromException(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 87145, 87183);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1668_87217_87268(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 87217, 87268);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_87290_87358(string
                name, System.Management.Automation.ErrorRecord
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 87290, 87358);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 86911, 87370);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 86911, 87370);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GenerateClientSessionCapability(RemoteSessionCapability capability,
                        Guid runspacePoolId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 88654, 89212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 88817, 88871);

                PSObject
                temp = f_1668_88833_88870(capability)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 88885, 89033);

                f_1668_88885_89032(f_1668_88885_88900(temp), f_1668_88923_89031(RemoteDataNameStrings.TimeZone, f_1668_88974_89030()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 89047, 89201);

                return f_1668_89054_89200(f_1668_89082_89112(capability), RemotingDataType.SessionCapability, runspacePoolId, Guid.Empty, temp);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 88654, 89212);

                System.Management.Automation.PSObject
                f_1668_88833_88870(System.Management.Automation.Remoting.RemoteSessionCapability
                capability)
                {
                    var return_v = GenerateSessionCapability(capability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 88833, 88870);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_88885_88900(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 88885, 88900);
                    return return_v;
                }


                byte[]
                f_1668_88974_89030()
                {
                    var return_v = RemoteSessionCapability.GetCurrentTimeZoneInByteFormat();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 88974, 89030);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_88923_89031(string
                name, byte[]
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 88923, 89031);
                    return return_v;
                }


                int
                f_1668_88885_89032(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 88885, 89032);
                    return 0;
                }


                System.Management.Automation.RemotingDestination
                f_1668_89082_89112(System.Management.Automation.Remoting.RemoteSessionCapability
                this_param)
                {
                    var return_v = this_param.RemotingDestination;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 89082, 89112);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_89054_89200(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 89054, 89200);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 88654, 89212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 88654, 89212);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject GenerateServerSessionCapability(RemoteSessionCapability capability,
                    Guid runspacePoolId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 89224, 89616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 89383, 89437);

                PSObject
                temp = f_1668_89399_89436(capability)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 89451, 89605);

                return f_1668_89458_89604(f_1668_89486_89516(capability), RemotingDataType.SessionCapability, runspacePoolId, Guid.Empty, temp);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 89224, 89616);

                System.Management.Automation.PSObject
                f_1668_89399_89436(System.Management.Automation.Remoting.RemoteSessionCapability
                capability)
                {
                    var return_v = GenerateSessionCapability(capability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 89399, 89436);
                    return return_v;
                }


                System.Management.Automation.RemotingDestination
                f_1668_89486_89516(System.Management.Automation.Remoting.RemoteSessionCapability
                this_param)
                {
                    var return_v = this_param.RemotingDestination;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 89486, 89516);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1668_89458_89604(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemoteDataObject.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 89458, 89604);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 89224, 89616);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 89224, 89616);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSObject GenerateSessionCapability(RemoteSessionCapability capability)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 89628, 90245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 89738, 89776);

                PSObject
                temp = f_1668_89754_89775()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 89790, 89932);

                f_1668_89790_89931(f_1668_89790_89805(temp), f_1668_89828_89930(RemoteDataNameStrings.PS_STARTUP_PROTOCOL_VERSION_NAME, f_1668_89903_89929(capability)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 89946, 90059);

                f_1668_89946_90058(f_1668_89946_89961(temp), f_1668_89984_90057(RemoteDataNameStrings.PSVersion, f_1668_90036_90056(capability)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 90073, 90208);

                f_1668_90073_90207(f_1668_90073_90088(temp), f_1668_90111_90206(RemoteDataNameStrings.SerializationVersion, f_1668_90174_90205(capability)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 90222, 90234);

                return temp;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 89628, 90245);

                System.Management.Automation.PSObject
                f_1668_89754_89775()
                {
                    var return_v = CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 89754, 89775);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_89790_89805(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 89790, 89805);
                    return return_v;
                }


                System.Version
                f_1668_89903_89929(System.Management.Automation.Remoting.RemoteSessionCapability
                this_param)
                {
                    var return_v = this_param.ProtocolVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 89903, 89929);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_89828_89930(string
                name, System.Version
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 89828, 89930);
                    return return_v;
                }


                int
                f_1668_89790_89931(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 89790, 89931);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_89946_89961(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 89946, 89961);
                    return return_v;
                }


                System.Version
                f_1668_90036_90056(System.Management.Automation.Remoting.RemoteSessionCapability
                this_param)
                {
                    var return_v = this_param.PSVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 90036, 90056);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_89984_90057(string
                name, System.Version
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 89984, 90057);
                    return return_v;
                }


                int
                f_1668_89946_90058(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 89946, 90058);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_90073_90088(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 90073, 90088);
                    return return_v;
                }


                System.Version
                f_1668_90174_90205(System.Management.Automation.Remoting.RemoteSessionCapability
                this_param)
                {
                    var return_v = this_param.SerializationVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 90174, 90205);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1668_90111_90206(string
                name, System.Version
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 90111, 90206);
                    return return_v;
                }


                int
                f_1668_90073_90207(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 90073, 90207);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 89628, 90245);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 89628, 90245);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RemotingEncoder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1668, 26005, 90290);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1668, 26005, 90290);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 26005, 90290);
        }

    }
    internal static class RemotingDecoder
    {
        private static T ConvertPropertyValueTo<T>(string propertyName, object propertyValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 90471, 94948);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 90581, 90745) || true) && (propertyName == null)
                ) // comes from internal caller

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 90581, 90745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 90669, 90730);

                    throw f_1668_90675_90729("propertyName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 90581, 90745);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 90761, 94937) || true) && (f_1668_90765_90781(typeof(T)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 90761, 94937);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 90815, 91542) || true) && (propertyValue is string)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 90815, 91542);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 90936, 90979);

                            string
                            stringValue = (string)propertyValue
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 91005, 91059);

                            T
                            value = (T)f_1668_91018_91058(typeof(T), stringValue, true)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 91085, 91098);

                            return value;
                        }
                        catch (ArgumentException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1668, 91143, 91523);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 91217, 91500);

                            throw f_1668_91223_91499(f_1668_91290_91343(), propertyName, f_1668_91417_91435(typeof(T)), f_1668_91466_91498(f_1668_91466_91489(propertyValue)));
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1668, 91143, 91523);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 90815, 91542);
                    }

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 91606, 91662);

                        Type
                        underlyingType = f_1668_91628_91661(typeof(T))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 91684, 91799);

                        object
                        underlyingValue = f_1668_91709_91798(propertyValue, underlyingType, f_1668_91769_91797())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 91821, 91850);

                        T
                        value = (T)underlyingValue
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 91872, 91885);

                        return value;
                    }
                    catch (InvalidCastException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1668, 91922, 92277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 91991, 92258);

                        throw f_1668_91997_92257(f_1668_92060_92113(), propertyName, f_1668_92179_92197(typeof(T)), f_1668_92224_92256(f_1668_92224_92247(propertyValue)));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1668, 91922, 92277);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 90761, 94937);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 90761, 94937);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 92311, 94937) || true) && (f_1668_92315_92349(typeof(T), typeof(PSObject)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 92311, 94937);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 92383, 92655) || true) && (propertyValue == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 92383, 92655);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 92450, 92468);

                            return default(T);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 92383, 92655);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 92383, 92655);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 92583, 92636);

                            return (T)(object)f_1668_92601_92635(propertyValue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 92383, 92655);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 92311, 94937);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 92311, 94937);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 92689, 94937) || true) && (propertyValue == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 92689, 94937);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 92748, 92853) || true) && (f_1668_92752_92774_M(!typeof(T).IsValueType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 92748, 92853);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 92816, 92834);

                                return default(T);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 92748, 92853);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 92873, 93046) || true) && (f_1668_92877_92900(typeof(T)) && (DynAbs.Tracing.TraceSender.Expression_True(1668, 92877, 92967) && f_1668_92904_92967(f_1668_92904_92940(typeof(T)), typeof(Nullable<>))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 92873, 93046);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 93009, 93027);

                                return default(T);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 92873, 93046);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 93066, 93350);

                            throw f_1668_93072_93349(f_1668_93131_93184(), propertyName, f_1668_93242_93260(typeof(T)), (DynAbs.Tracing.TraceSender.Conditional_F1(1668, 93283, 93304) || ((propertyValue != null && DynAbs.Tracing.TraceSender.Conditional_F2(1668, 93307, 93339)) || DynAbs.Tracing.TraceSender.Conditional_F3(1668, 93342, 93348))) ? f_1668_93307_93339(f_1668_93307_93330(propertyValue)) : "null");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 92689, 94937);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 92689, 94937);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 93384, 94937) || true) && (propertyValue is T)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 93384, 94937);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 93440, 93466);

                                return (T)(propertyValue);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 93384, 94937);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 93384, 94937);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 93500, 94937) || true) && (propertyValue is PSObject)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 93500, 94937);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 93563, 93607);

                                    PSObject
                                    psObject = (PSObject)propertyValue
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 93625, 93693);

                                    return f_1668_93632_93692(propertyName, f_1668_93672_93691(psObject));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 93500, 94937);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 93500, 94937);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 93727, 94937) || true) && ((propertyValue is Hashtable) && (DynAbs.Tracing.TraceSender.Expression_True(1668, 93731, 93812) && (f_1668_93764_93811(typeof(T), typeof(PSPrimitiveDictionary)))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 93727, 94937);
                                        // rehydration of PSPrimitiveDictionary might not work when CreateRunspacePool message is received
                                        // (there is no runspace and so no type table at this point) so try converting manually
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 94111, 94183);

                                            return (T)(object)(f_1668_94130_94181((Hashtable)propertyValue));
                                        }
                                        catch (ArgumentException)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1668, 94220, 94605);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 94286, 94586);

                                            throw f_1668_94292_94585(f_1668_94355_94408(), propertyName, f_1668_94474_94492(typeof(T)), (DynAbs.Tracing.TraceSender.Conditional_F1(1668, 94519, 94540) || ((propertyValue != null && DynAbs.Tracing.TraceSender.Conditional_F2(1668, 94543, 94575)) || DynAbs.Tracing.TraceSender.Conditional_F3(1668, 94578, 94584))) ? f_1668_94543_94575(f_1668_94543_94566(propertyValue)) : "null");
                                            DynAbs.Tracing.TraceSender.TraceExitCatch(1668, 94220, 94605);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 93727, 94937);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 93727, 94937);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 94671, 94922);

                                        throw f_1668_94677_94921(f_1668_94736_94789(), propertyName, f_1668_94847_94865(typeof(T)), f_1668_94888_94920(f_1668_94888_94911(propertyValue)));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 93727, 94937);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 93500, 94937);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 93384, 94937);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 92689, 94937);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 92311, 94937);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 90761, 94937);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 90471, 94948);

                System.Management.Automation.PSArgumentNullException
                f_1668_90675_90729(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 90675, 90729);
                    return return_v;
                }


                bool
                f_1668_90765_90781(System.Type
                this_param)
                {
                    var return_v = this_param.IsEnum;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 90765, 90781);
                    return return_v;
                }


                object
                f_1668_91018_91058(System.Type
                enumType, string
                value, bool
                ignoreCase)
                {
                    var return_v = Enum.Parse(enumType, value, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 91018, 91058);
                    return return_v;
                }


                string
                f_1668_91290_91343()
                {
                    var return_v = RemotingErrorIdStrings.CantCastPropertyToExpectedType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 91290, 91343);
                    return return_v;
                }


                string
                f_1668_91417_91435(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 91417, 91435);
                    return return_v;
                }


                System.Type
                f_1668_91466_91489(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 91466, 91489);
                    return return_v;
                }


                string
                f_1668_91466_91498(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 91466, 91498);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1668_91223_91499(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 91223, 91499);
                    return return_v;
                }


                System.Type
                f_1668_91628_91661(System.Type
                enumType)
                {
                    var return_v = Enum.GetUnderlyingType(enumType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 91628, 91661);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1668_91769_91797()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 91769, 91797);
                    return return_v;
                }


                object
                f_1668_91709_91798(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 91709, 91798);
                    return return_v;
                }


                string
                f_1668_92060_92113()
                {
                    var return_v = RemotingErrorIdStrings.CantCastPropertyToExpectedType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 92060, 92113);
                    return return_v;
                }


                string
                f_1668_92179_92197(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 92179, 92197);
                    return return_v;
                }


                System.Type
                f_1668_92224_92247(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 92224, 92247);
                    return return_v;
                }


                string
                f_1668_92224_92256(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 92224, 92256);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1668_91997_92257(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 91997, 92257);
                    return return_v;
                }


                bool
                f_1668_92315_92349(System.Type
                this_param, System.Type
                o)
                {
                    var return_v = this_param.Equals(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 92315, 92349);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1668_92601_92635(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 92601, 92635);
                    return return_v;
                }


                bool
                f_1668_92752_92774_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 92752, 92774);
                    return return_v;
                }


                bool
                f_1668_92877_92900(System.Type
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 92877, 92900);
                    return return_v;
                }


                System.Type
                f_1668_92904_92940(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericTypeDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 92904, 92940);
                    return return_v;
                }


                bool
                f_1668_92904_92967(System.Type
                this_param, System.Type
                o)
                {
                    var return_v = this_param.Equals(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 92904, 92967);
                    return return_v;
                }


                string
                f_1668_93131_93184()
                {
                    var return_v = RemotingErrorIdStrings.CantCastPropertyToExpectedType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 93131, 93184);
                    return return_v;
                }


                string
                f_1668_93242_93260(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 93242, 93260);
                    return return_v;
                }


                System.Type
                f_1668_93307_93330(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 93307, 93330);
                    return return_v;
                }


                string
                f_1668_93307_93339(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 93307, 93339);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1668_93072_93349(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 93072, 93349);
                    return return_v;
                }


                object
                f_1668_93672_93691(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 93672, 93691);
                    return return_v;
                }


                T
                f_1668_93632_93692(string
                propertyName, object
                propertyValue)
                {
                    var return_v = ConvertPropertyValueTo<T>(propertyName, propertyValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 93632, 93692);
                    return return_v;
                }


                bool
                f_1668_93764_93811(System.Type
                this_param, System.Type
                o)
                {
                    var return_v = this_param.Equals(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 93764, 93811);
                    return return_v;
                }


                System.Management.Automation.PSPrimitiveDictionary
                f_1668_94130_94181(object
                other)
                {
                    var return_v = new System.Management.Automation.PSPrimitiveDictionary((System.Collections.Hashtable)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 94130, 94181);
                    return return_v;
                }


                string
                f_1668_94355_94408()
                {
                    var return_v = RemotingErrorIdStrings.CantCastPropertyToExpectedType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 94355, 94408);
                    return return_v;
                }


                string
                f_1668_94474_94492(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 94474, 94492);
                    return return_v;
                }


                System.Type
                f_1668_94543_94566(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 94543, 94566);
                    return return_v;
                }


                string
                f_1668_94543_94575(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 94543, 94575);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1668_94292_94585(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 94292, 94585);
                    return return_v;
                }


                string
                f_1668_94736_94789()
                {
                    var return_v = RemotingErrorIdStrings.CantCastPropertyToExpectedType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 94736, 94789);
                    return return_v;
                }


                string
                f_1668_94847_94865(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 94847, 94865);
                    return return_v;
                }


                System.Type
                f_1668_94888_94911(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 94888, 94911);
                    return return_v;
                }


                string
                f_1668_94888_94920(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 94888, 94920);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1668_94677_94921(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 94677, 94921);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 90471, 94948);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 90471, 94948);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSPropertyInfo GetProperty(PSObject psObject, string propertyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 94960, 95643);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 95066, 95192) || true) && (psObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 95066, 95192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 95120, 95177);

                    throw f_1668_95126_95176("psObject");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 95066, 95192);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 95208, 95342) || true) && (propertyName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 95208, 95342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 95266, 95327);

                    throw f_1668_95272_95326("propertyName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 95208, 95342);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 95358, 95418);

                PSPropertyInfo
                property = f_1668_95384_95417(f_1668_95384_95403(psObject), propertyName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 95434, 95600) || true) && (property == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 95434, 95600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 95488, 95585);

                    throw f_1668_95494_95584(f_1668_95531_95569(), propertyName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 95434, 95600);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 95616, 95632);

                return property;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 94960, 95643);

                System.Management.Automation.PSArgumentNullException
                f_1668_95126_95176(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 95126, 95176);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1668_95272_95326(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 95272, 95326);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_95384_95403(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 95384, 95403);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1668_95384_95417(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 95384, 95417);
                    return return_v;
                }


                string
                f_1668_95531_95569()
                {
                    var return_v = RemotingErrorIdStrings.MissingProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 95531, 95569);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1668_95494_95584(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 95494, 95584);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 94960, 95643);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 94960, 95643);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static T GetPropertyValue<T>(PSObject psObject, string propertyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 95655, 96250);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 95757, 95883) || true) && (psObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 95757, 95883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 95811, 95868);

                    throw f_1668_95817_95867("psObject");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 95757, 95883);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 95899, 96033) || true) && (propertyName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 95899, 96033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 95957, 96018);

                    throw f_1668_95963_96017("propertyName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 95899, 96033);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 96049, 96111);

                PSPropertyInfo
                property = f_1668_96075_96110(psObject, propertyName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 96125, 96163);

                object
                propertyValue = f_1668_96148_96162(property)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 96177, 96239);

                return f_1668_96184_96238(propertyName, propertyValue);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 95655, 96250);

                System.Management.Automation.PSArgumentNullException
                f_1668_95817_95867(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 95817, 95867);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1668_95963_96017(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 95963, 96017);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1668_96075_96110(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetProperty(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 96075, 96110);
                    return return_v;
                }


                object
                f_1668_96148_96162(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 96148, 96162);
                    return return_v;
                }


                T
                f_1668_96184_96238(string
                propertyName, object
                propertyValue)
                {
                    var return_v = ConvertPropertyValueTo<T>(propertyName, propertyValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 96184, 96238);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 95655, 96250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 95655, 96250);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<T> EnumerateListProperty<T>(PSObject psObject, string propertyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 96262, 96970);

                var listYield = new List<T>();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 96382, 96508) || true) && (psObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 96382, 96508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 96436, 96493);

                    throw f_1668_96442_96492("psObject");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 96382, 96508);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 96524, 96658) || true) && (propertyName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 96524, 96658);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 96582, 96643);

                    throw f_1668_96588_96642("propertyName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 96524, 96658);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 96674, 96744);

                IEnumerable
                e = f_1668_96690_96743(psObject, propertyName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 96758, 96959) || true) && (e != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 96758, 96959);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 96805, 96944);
                        foreach (object o in f_1668_96826_96827_I(e))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 96805, 96944);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 96869, 96925);

                            listYield.Add(f_1668_96882_96924(propertyName, o));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 96805, 96944);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1668, 1, 140);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1668, 1, 140);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 96758, 96959);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 96262, 96970);

                return listYield;

                System.Management.Automation.PSArgumentNullException
                f_1668_96442_96492(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 96442, 96492);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1668_96588_96642(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 96588, 96642);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1668_96690_96743(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<IEnumerable>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 96690, 96743);
                    return return_v;
                }


                T
                f_1668_96882_96924(string
                propertyName, object
                propertyValue)
                {
                    var return_v = ConvertPropertyValueTo<T>(propertyName, propertyValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 96882, 96924);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1668_96826_96827_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 96826, 96827);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 96262, 96970);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 96262, 96970);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<KeyValuePair<KeyType, ValueType>> EnumerateHashtableProperty<KeyType, ValueType>(PSObject psObject, string propertyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 96982, 97940);

                var listYield = new List<KeyValuePair<KeyType, ValueType>>();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 97155, 97281) || true) && (psObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 97155, 97281);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 97209, 97266);

                    throw f_1668_97215_97265("psObject");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 97155, 97281);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 97297, 97431) || true) && (propertyName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 97297, 97431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 97355, 97416);

                    throw f_1668_97361_97415("propertyName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 97297, 97431);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 97447, 97513);

                Hashtable
                h = f_1668_97461_97512(psObject, propertyName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 97527, 97929) || true) && (h != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 97527, 97929);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 97574, 97914);
                        foreach (DictionaryEntry e in f_1668_97604_97605_I(h))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 97574, 97914);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 97647, 97714);

                            KeyType
                            key = f_1668_97661_97713(propertyName, e.Key)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 97736, 97811);

                            ValueType
                            value = f_1668_97754_97810(propertyName, e.Value)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 97833, 97895);

                            listYield.Add(f_1668_97846_97894(key, value));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 97574, 97914);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1668, 1, 341);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1668, 1, 341);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 97527, 97929);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 96982, 97940);

                return listYield;

                System.Management.Automation.PSArgumentNullException
                f_1668_97215_97265(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 97215, 97265);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1668_97361_97415(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 97361, 97415);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1668_97461_97512(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<Hashtable>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 97461, 97512);
                    return return_v;
                }


                KeyType
                f_1668_97661_97713(string
                propertyName, object
                propertyValue)
                {
                    var return_v = ConvertPropertyValueTo<KeyType>(propertyName, propertyValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 97661, 97713);
                    return return_v;
                }


                ValueType
                f_1668_97754_97810(string
                propertyName, object
                propertyValue)
                {
                    var return_v = ConvertPropertyValueTo<ValueType>(propertyName, propertyValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 97754, 97810);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<KeyType, ValueType>
                f_1668_97846_97894(KeyType
                key, ValueType
                value)
                {
                    var return_v = new System.Collections.Generic.KeyValuePair<KeyType, ValueType>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 97846, 97894);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1668_97604_97605_I(System.Collections.Hashtable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 97604, 97605);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 96982, 97940);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 96982, 97940);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RunspacePoolStateInfo GetRunspacePoolStateInfo(PSObject dataAsPSObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 98231, 98768);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 98343, 98481) || true) && (dataAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 98343, 98481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 98403, 98466);

                    throw f_1668_98409_98465("dataAsPSObject");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 98343, 98481);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 98497, 98612);

                RunspacePoolState
                state = f_1668_98523_98611(dataAsPSObject, RemoteDataNameStrings.RunspaceState)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 98626, 98693);

                Exception
                reason = f_1668_98645_98692(dataAsPSObject)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 98709, 98757);

                return f_1668_98716_98756(state, reason);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 98231, 98768);

                System.Management.Automation.PSArgumentNullException
                f_1668_98409_98465(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 98409, 98465);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1668_98523_98611(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<RunspacePoolState>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 98523, 98611);
                    return return_v;
                }


                System.Exception
                f_1668_98645_98692(System.Management.Automation.PSObject
                stateInfo)
                {
                    var return_v = GetExceptionFromStateInfoObject(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 98645, 98692);
                    return return_v;
                }


                System.Management.Automation.RunspacePoolStateInfo
                f_1668_98716_98756(System.Management.Automation.Runspaces.RunspacePoolState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.RunspacePoolStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 98716, 98756);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 98231, 98768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 98231, 98768);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSPrimitiveDictionary GetApplicationPrivateData(PSObject dataAsPSObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 99063, 99450);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 99176, 99314) || true) && (dataAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 99176, 99314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 99236, 99299);

                    throw f_1668_99242_99298("dataAsPSObject");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 99176, 99314);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 99330, 99439);

                return f_1668_99337_99438(dataAsPSObject, RemoteDataNameStrings.ApplicationPrivateData);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 99063, 99450);

                System.Management.Automation.PSArgumentNullException
                f_1668_99242_99298(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 99242, 99298);
                    return return_v;
                }


                System.Management.Automation.PSPrimitiveDictionary
                f_1668_99337_99438(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<PSPrimitiveDictionary>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 99337, 99438);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 99063, 99450);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 99063, 99450);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetPublicKey(PSObject dataAsPSObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 99695, 100026);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 99780, 99918) || true) && (dataAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 99780, 99918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 99840, 99903);

                    throw f_1668_99846_99902("dataAsPSObject");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 99780, 99918);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 99934, 100015);

                return f_1668_99941_100014(dataAsPSObject, RemoteDataNameStrings.PublicKey);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 99695, 100026);

                System.Management.Automation.PSArgumentNullException
                f_1668_99846_99902(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 99846, 99902);
                    return return_v;
                }


                string
                f_1668_99941_100014(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<string>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 99941, 100014);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 99695, 100026);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 99695, 100026);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetEncryptedSessionKey(PSObject dataAsPSObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 100293, 100644);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 100388, 100526) || true) && (dataAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 100388, 100526);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 100448, 100511);

                    throw f_1668_100454_100510("dataAsPSObject");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 100388, 100526);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 100542, 100633);

                return f_1668_100549_100632(dataAsPSObject, RemoteDataNameStrings.EncryptedSessionKey);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 100293, 100644);

                System.Management.Automation.PSArgumentNullException
                f_1668_100454_100510(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 100454, 100510);
                    return return_v;
                }


                string
                f_1668_100549_100632(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<string>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 100549, 100632);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 100293, 100644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 100293, 100644);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSEventArgs GetPSEventArgs(PSObject dataAsPSObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 100935, 102678);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 101027, 101165) || true) && (dataAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 101027, 101165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 101087, 101150);

                    throw f_1668_101093_101149("dataAsPSObject");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 101027, 101165);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 101181, 101291);

                int
                eventIdentifier = f_1668_101203_101290(dataAsPSObject, RemoteDataNameStrings.PSEventArgsEventIdentifier)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 101305, 101423);

                string
                sourceIdentifier = f_1668_101331_101422(dataAsPSObject, RemoteDataNameStrings.PSEventArgsSourceIdentifier)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 101437, 101535);

                object
                sender = f_1668_101453_101534(dataAsPSObject, RemoteDataNameStrings.PSEventArgsSender)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 101549, 101657);

                object
                messageData = f_1668_101570_101656(dataAsPSObject, RemoteDataNameStrings.PSEventArgsMessageData)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 101671, 101781);

                string
                computerName = f_1668_101693_101780(dataAsPSObject, RemoteDataNameStrings.PSEventArgsComputerName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 101795, 101897);

                Guid
                runspaceId = f_1668_101813_101896(dataAsPSObject, RemoteDataNameStrings.PSEventArgsRunspaceId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 101913, 101949);

                var
                sourceArgs = f_1668_101930_101948()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 101963, 102171);
                    foreach (object argument in f_1668_101991_102097_I(f_1668_101991_102097(dataAsPSObject, RemoteDataNameStrings.PSEventArgsSourceArgs)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 101963, 102171);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 102131, 102156);

                        f_1668_102131_102155(sourceArgs, argument);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 101963, 102171);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1668, 1, 209);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1668, 1, 209);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 102187, 102501);

                PSEventArgs
                eventArgs = f_1668_102211_102500(computerName, runspaceId, eventIdentifier, sourceIdentifier, sender, f_1668_102399_102419(sourceArgs), (DynAbs.Tracing.TraceSender.Conditional_F1(1668, 102438, 102457) || ((messageData == null && DynAbs.Tracing.TraceSender.Conditional_F2(1668, 102460, 102464)) || DynAbs.Tracing.TraceSender.Conditional_F3(1668, 102467, 102499))) ? null : f_1668_102467_102499(messageData))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 102517, 102634);

                eventArgs.TimeGenerated = f_1668_102543_102633(dataAsPSObject, RemoteDataNameStrings.PSEventArgsTimeGenerated);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 102650, 102667);

                return eventArgs;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 100935, 102678);

                System.Management.Automation.PSArgumentNullException
                f_1668_101093_101149(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 101093, 101149);
                    return return_v;
                }


                int
                f_1668_101203_101290(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<int>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 101203, 101290);
                    return return_v;
                }


                string
                f_1668_101331_101422(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<string>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 101331, 101422);
                    return return_v;
                }


                object
                f_1668_101453_101534(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<object>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 101453, 101534);
                    return return_v;
                }


                object
                f_1668_101570_101656(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<object>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 101570, 101656);
                    return return_v;
                }


                string
                f_1668_101693_101780(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<string>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 101693, 101780);
                    return return_v;
                }


                System.Guid
                f_1668_101813_101896(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<Guid>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 101813, 101896);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1668_101930_101948()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 101930, 101948);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<object>
                f_1668_101991_102097(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.EnumerateListProperty<object>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 101991, 102097);
                    return return_v;
                }


                int
                f_1668_102131_102155(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 102131, 102155);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<object>
                f_1668_101991_102097_I(System.Collections.Generic.IEnumerable<object>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 101991, 102097);
                    return return_v;
                }


                object[]
                f_1668_102399_102419(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 102399, 102419);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1668_102467_102499(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 102467, 102499);
                    return return_v;
                }


                System.Management.Automation.PSEventArgs
                f_1668_102211_102500(string
                computerName, System.Guid
                runspaceId, int
                eventIdentifier, string
                sourceIdentifier, object
                sender, object[]
                originalArgs, System.Management.Automation.PSObject
                additionalData)
                {
                    var return_v = new System.Management.Automation.PSEventArgs(computerName, runspaceId, eventIdentifier, sourceIdentifier, sender, originalArgs, additionalData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 102211, 102500);
                    return return_v;
                }


                System.DateTime
                f_1668_102543_102633(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<DateTime>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 102543, 102633);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 100935, 102678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 100935, 102678);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetMinRunspaces(PSObject dataAsPSObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 102990, 103321);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 103075, 103213) || true) && (dataAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 103075, 103213);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 103135, 103198);

                    throw f_1668_103141_103197("dataAsPSObject");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 103075, 103213);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 103229, 103310);

                return f_1668_103236_103309(dataAsPSObject, RemoteDataNameStrings.MinRunspaces);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 102990, 103321);

                System.Management.Automation.PSArgumentNullException
                f_1668_103141_103197(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 103141, 103197);
                    return return_v;
                }


                int
                f_1668_103236_103309(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<int>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 103236, 103309);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 102990, 103321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 102990, 103321);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetMaxRunspaces(PSObject dataAsPSObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 103633, 103964);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 103718, 103856) || true) && (dataAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 103718, 103856);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 103778, 103841);

                    throw f_1668_103784_103840("dataAsPSObject");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 103718, 103856);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 103872, 103953);

                return f_1668_103879_103952(dataAsPSObject, RemoteDataNameStrings.MaxRunspaces);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 103633, 103964);

                System.Management.Automation.PSArgumentNullException
                f_1668_103784_103840(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 103784, 103840);
                    return return_v;
                }


                int
                f_1668_103879_103952(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<int>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 103879, 103952);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 103633, 103964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 103633, 103964);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSPrimitiveDictionary GetApplicationArguments(PSObject dataAsPSObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 104278, 104848);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 104389, 104527) || true) && (dataAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 104389, 104527);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 104449, 104512);

                    throw f_1668_104455_104511("dataAsPSObject");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 104389, 104527);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 104730, 104837);

                return f_1668_104737_104836(dataAsPSObject, RemoteDataNameStrings.ApplicationArguments);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 104278, 104848);

                System.Management.Automation.PSArgumentNullException
                f_1668_104455_104511(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 104455, 104511);
                    return return_v;
                }


                System.Management.Automation.PSPrimitiveDictionary
                f_1668_104737_104836(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<PSPrimitiveDictionary>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 104737, 104836);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 104278, 104848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 104278, 104848);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RunspacePoolInitInfo GetRunspacePoolInitInfo(PSObject dataAsPSObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 105121, 105644);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 105231, 105369) || true) && (dataAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 105231, 105369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 105291, 105354);

                    throw f_1668_105297_105353("dataAsPSObject");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 105231, 105369);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 105385, 105471);

                int
                maxRS = f_1668_105397_105470(dataAsPSObject, RemoteDataNameStrings.MaxRunspaces)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 105485, 105571);

                int
                minRS = f_1668_105497_105570(dataAsPSObject, RemoteDataNameStrings.MinRunspaces)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 105587, 105633);

                return f_1668_105594_105632(minRS, maxRS);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 105121, 105644);

                System.Management.Automation.PSArgumentNullException
                f_1668_105297_105353(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 105297, 105353);
                    return return_v;
                }


                int
                f_1668_105397_105470(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<int>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 105397, 105470);
                    return return_v;
                }


                int
                f_1668_105497_105570(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<int>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 105497, 105570);
                    return return_v;
                }


                System.Management.Automation.Remoting.RunspacePoolInitInfo
                f_1668_105594_105632(int
                minRS, int
                maxRS)
                {
                    var return_v = new System.Management.Automation.Remoting.RunspacePoolInitInfo(minRS, maxRS);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 105594, 105632);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 105121, 105644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 105121, 105644);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSThreadOptions GetThreadOptions(PSObject dataAsPSObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 105958, 106315);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 106056, 106194) || true) && (dataAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 106056, 106194);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 106116, 106179);

                    throw f_1668_106122_106178("dataAsPSObject");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 106056, 106194);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 106210, 106304);

                return f_1668_106217_106303(dataAsPSObject, RemoteDataNameStrings.ThreadOptions);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 105958, 106315);

                System.Management.Automation.PSArgumentNullException
                f_1668_106122_106178(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 106122, 106178);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSThreadOptions
                f_1668_106217_106303(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<PSThreadOptions>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 106217, 106303);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 105958, 106315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 105958, 106315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static HostInfo GetHostInfo(PSObject dataAsPSObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 106613, 107061);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 106699, 106837) || true) && (dataAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 106699, 106837);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 106759, 106822);

                    throw f_1668_106765_106821("dataAsPSObject");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 106699, 106837);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 106853, 106953);

                PSObject
                propertyValue = f_1668_106878_106952(dataAsPSObject, RemoteDataNameStrings.HostInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 106967, 107050);

                return f_1668_106974_107037(propertyValue, typeof(HostInfo)) as HostInfo;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 106613, 107061);

                System.Management.Automation.PSArgumentNullException
                f_1668_106765_106821(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 106765, 106821);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1668_106878_106952(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<PSObject>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 106878, 106952);
                    return return_v;
                }


                object
                f_1668_106974_107037(System.Management.Automation.PSObject
                obj, System.Type
                type)
                {
                    var return_v = RemoteHostEncoder.DecodeObject((object)obj, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 106974, 107037);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 106613, 107061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 106613, 107061);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Exception GetExceptionFromStateInfoObject(PSObject stateInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 107277, 107797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 107439, 107532);

                PSPropertyInfo
                property = f_1668_107465_107531(f_1668_107465_107485(stateInfo), RemoteDataNameStrings.ExceptionAsErrorRecord)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 107546, 107702) || true) && (property != null && (DynAbs.Tracing.TraceSender.Expression_True(1668, 107550, 107592) && f_1668_107570_107584(property) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 107546, 107702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 107626, 107687);

                    return f_1668_107633_107686(f_1668_107671_107685(property));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 107546, 107702);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 107774, 107786);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 107277, 107797);

                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_107465_107485(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 107465, 107485);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1668_107465_107531(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 107465, 107531);
                    return return_v;
                }


                object
                f_1668_107570_107584(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 107570, 107584);
                    return return_v;
                }


                object
                f_1668_107671_107685(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 107671, 107685);
                    return return_v;
                }


                System.Exception
                f_1668_107633_107686(object
                serializedErrorRecord)
                {
                    var return_v = GetExceptionFromSerializedErrorRecord(serializedErrorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 107633, 107686);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 107277, 107797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 107277, 107797);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Exception GetExceptionFromSerializedErrorRecord(object serializedErrorRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 108008, 108494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 108126, 108223);

                ErrorRecord
                er = f_1668_108143_108222(f_1668_108179_108221(serializedErrorRecord))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 108239, 108483) || true) && (er == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 108239, 108483);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 108287, 108382);

                    throw f_1668_108293_108381(f_1668_108330_108380());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 108239, 108483);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 108239, 108483);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 108448, 108468);

                    return f_1668_108455_108467(er);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 108239, 108483);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 108008, 108494);

                System.Management.Automation.PSObject
                f_1668_108179_108221(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 108179, 108221);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1668_108143_108222(System.Management.Automation.PSObject
                serializedErrorRecord)
                {
                    var return_v = ErrorRecord.FromPSObjectForRemoting(serializedErrorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 108143, 108222);
                    return return_v;
                }


                string
                f_1668_108330_108380()
                {
                    var return_v = RemotingErrorIdStrings.DecodingErrorForErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 108330, 108380);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1668_108293_108381(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 108293, 108381);
                    return return_v;
                }


                System.Exception
                f_1668_108455_108467(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 108455, 108467);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 108008, 108494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 108008, 108494);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object GetPowerShellOutput(object data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 108899, 109002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 108979, 108991);

                return data;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 108899, 109002);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 108899, 109002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 108899, 109002);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSInvocationStateInfo GetPowerShellStateInfo(object data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 109228, 109868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 109326, 109369);

                PSObject
                dataAsPSObject = data as PSObject
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 109383, 109583) || true) && (dataAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 109383, 109583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 109443, 109568);

                    throw f_1668_109449_109567(f_1668_109508_109566());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 109383, 109583);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 109599, 109714);

                PSInvocationState
                state = f_1668_109625_109713(dataAsPSObject, RemoteDataNameStrings.PipelineState)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 109728, 109795);

                Exception
                reason = f_1668_109747_109794(dataAsPSObject)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 109809, 109857);

                return f_1668_109816_109856(state, reason);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 109228, 109868);

                string
                f_1668_109508_109566()
                {
                    var return_v = RemotingErrorIdStrings.DecodingErrorForPowerShellStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 109508, 109566);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1668_109449_109567(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 109449, 109567);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1668_109625_109713(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<PSInvocationState>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 109625, 109713);
                    return return_v;
                }


                System.Exception
                f_1668_109747_109794(System.Management.Automation.PSObject
                stateInfo)
                {
                    var return_v = GetExceptionFromStateInfoObject(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 109747, 109794);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1668_109816_109856(System.Management.Automation.PSInvocationState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.PSInvocationStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 109816, 109856);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 109228, 109868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 109228, 109868);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ErrorRecord GetPowerShellError(object data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 110081, 110482);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 110165, 110283) || true) && (data == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 110165, 110283);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 110215, 110268);

                    throw f_1668_110221_110267("data");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 110165, 110283);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 110299, 110342);

                PSObject
                dataAsPSObject = data as PSObject
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 110358, 110436);

                ErrorRecord
                errorRecord = f_1668_110384_110435(dataAsPSObject)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 110452, 110471);

                return errorRecord;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 110081, 110482);

                System.Management.Automation.PSArgumentNullException
                f_1668_110221_110267(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 110221, 110267);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1668_110384_110435(System.Management.Automation.PSObject
                serializedErrorRecord)
                {
                    var return_v = ErrorRecord.FromPSObjectForRemoting(serializedErrorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 110384, 110435);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 110081, 110482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 110081, 110482);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static WarningRecord GetPowerShellWarning(object data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 110595, 110869);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 110683, 110801) || true) && (data == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 110683, 110801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 110733, 110786);

                    throw f_1668_110739_110785("data");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 110683, 110801);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 110817, 110858);

                return f_1668_110824_110857((PSObject)data);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 110595, 110869);

                System.Management.Automation.PSArgumentNullException
                f_1668_110739_110785(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 110739, 110785);
                    return return_v;
                }


                System.Management.Automation.WarningRecord
                f_1668_110824_110857(object
                record)
                {
                    var return_v = new System.Management.Automation.WarningRecord((System.Management.Automation.PSObject)record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 110824, 110857);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 110595, 110869);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 110595, 110869);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static VerboseRecord GetPowerShellVerbose(object data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 110982, 111256);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 111070, 111188) || true) && (data == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 111070, 111188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 111120, 111173);

                    throw f_1668_111126_111172("data");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 111070, 111188);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 111204, 111245);

                return f_1668_111211_111244((PSObject)data);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 110982, 111256);

                System.Management.Automation.PSArgumentNullException
                f_1668_111126_111172(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 111126, 111172);
                    return return_v;
                }


                System.Management.Automation.VerboseRecord
                f_1668_111211_111244(object
                record)
                {
                    var return_v = new System.Management.Automation.VerboseRecord((System.Management.Automation.PSObject)record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 111211, 111244);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 110982, 111256);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 110982, 111256);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static DebugRecord GetPowerShellDebug(object data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 111367, 111635);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 111451, 111569) || true) && (data == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 111451, 111569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 111501, 111554);

                    throw f_1668_111507_111553("data");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 111451, 111569);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 111585, 111624);

                return f_1668_111592_111623((PSObject)data);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 111367, 111635);

                System.Management.Automation.PSArgumentNullException
                f_1668_111507_111553(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 111507, 111553);
                    return return_v;
                }


                System.Management.Automation.DebugRecord
                f_1668_111592_111623(object
                record)
                {
                    var return_v = new System.Management.Automation.DebugRecord((System.Management.Automation.PSObject)record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 111592, 111623);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 111367, 111635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 111367, 111635);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ProgressRecord GetPowerShellProgress(object data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 111749, 112192);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 111839, 111891);

                PSObject
                dataAsPSObject = f_1668_111865_111890(data)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 111905, 112103) || true) && (dataAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 111905, 112103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 111965, 112088);

                    throw f_1668_111971_112087(f_1668_112008_112061(), f_1668_112063_112086(f_1668_112063_112077(data)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 111905, 112103);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 112119, 112181);

                return f_1668_112126_112180(dataAsPSObject);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 111749, 112192);

                System.Management.Automation.PSObject
                f_1668_111865_111890(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 111865, 111890);
                    return return_v;
                }


                string
                f_1668_112008_112061()
                {
                    var return_v = RemotingErrorIdStrings.CantCastRemotingDataToPSObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 112008, 112061);
                    return return_v;
                }


                System.Type
                f_1668_112063_112077(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 112063, 112077);
                    return return_v;
                }


                string
                f_1668_112063_112086(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 112063, 112086);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1668_111971_112087(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 111971, 112087);
                    return return_v;
                }


                System.Management.Automation.ProgressRecord
                f_1668_112126_112180(System.Management.Automation.PSObject
                progressAsPSObject)
                {
                    var return_v = ProgressRecord.FromPSObjectForRemoting(progressAsPSObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 112126, 112180);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 111749, 112192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 111749, 112192);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static InformationRecord GetPowerShellInformation(object data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 112309, 112761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 112405, 112457);

                PSObject
                dataAsPSObject = f_1668_112431_112456(data)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 112471, 112669) || true) && (dataAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 112471, 112669);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 112531, 112654);

                    throw f_1668_112537_112653(f_1668_112574_112627(), f_1668_112629_112652(f_1668_112629_112643(data)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 112471, 112669);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 112685, 112750);

                return f_1668_112692_112749(dataAsPSObject);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 112309, 112761);

                System.Management.Automation.PSObject
                f_1668_112431_112456(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 112431, 112456);
                    return return_v;
                }


                string
                f_1668_112574_112627()
                {
                    var return_v = RemotingErrorIdStrings.CantCastRemotingDataToPSObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 112574, 112627);
                    return return_v;
                }


                System.Type
                f_1668_112629_112643(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 112629, 112643);
                    return return_v;
                }


                string
                f_1668_112629_112652(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 112629, 112652);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1668_112537_112653(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 112537, 112653);
                    return return_v;
                }


                System.Management.Automation.InformationRecord
                f_1668_112692_112749(System.Management.Automation.PSObject
                inputObject)
                {
                    var return_v = InformationRecord.FromPSObjectForRemoting(inputObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 112692, 112749);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 112309, 112761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 112309, 112761);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PowerShell GetPowerShell(object data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 113005, 113561);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 113083, 113135);

                PSObject
                dataAsPSObject = f_1668_113109_113134(data)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 113149, 113347) || true) && (dataAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 113149, 113347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 113209, 113332);

                    throw f_1668_113215_113331(f_1668_113252_113305(), f_1668_113307_113330(f_1668_113307_113321(data)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 113149, 113347);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 113363, 113472);

                PSObject
                powerShellAsPSObject = f_1668_113395_113471(dataAsPSObject, RemoteDataNameStrings.PowerShell)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 113486, 113550);

                return f_1668_113493_113549(powerShellAsPSObject);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 113005, 113561);

                System.Management.Automation.PSObject
                f_1668_113109_113134(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 113109, 113134);
                    return return_v;
                }


                string
                f_1668_113252_113305()
                {
                    var return_v = RemotingErrorIdStrings.CantCastRemotingDataToPSObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 113252, 113305);
                    return return_v;
                }


                System.Type
                f_1668_113307_113321(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 113307, 113321);
                    return return_v;
                }


                string
                f_1668_113307_113330(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 113307, 113330);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1668_113215_113331(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 113215, 113331);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1668_113395_113471(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<PSObject>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 113395, 113471);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1668_113493_113549(System.Management.Automation.PSObject
                powerShellAsPSObject)
                {
                    var return_v = PowerShell.FromPSObjectForRemoting(powerShellAsPSObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 113493, 113549);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 113005, 113561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 113005, 113561);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PowerShell GetCommandDiscoveryPipeline(object data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 113805, 117023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 113897, 113949);

                PSObject
                dataAsPSObject = f_1668_113923_113948(data)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 113963, 114161) || true) && (dataAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 113963, 114161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 114023, 114146);

                    throw f_1668_114029_114145(f_1668_114066_114119(), f_1668_114121_114144(f_1668_114121_114135(data)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 113963, 114161);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 114177, 114288);

                CommandTypes
                commandType = f_1668_114204_114287(dataAsPSObject, RemoteDataNameStrings.DiscoveryType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 114304, 114318);

                string[]
                name
                = default(string[]);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 114332, 114732) || true) && (f_1668_114336_114415(dataAsPSObject, RemoteDataNameStrings.DiscoveryName) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 114332, 114732);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 114457, 114566);

                    IEnumerable<string>
                    tmp = f_1668_114483_114565(dataAsPSObject, RemoteDataNameStrings.DiscoveryName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 114584, 114623);

                    name = f_1668_114591_114622(f_1668_114591_114612(tmp));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 114332, 114732);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 114332, 114732);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 114689, 114717);

                    name = new string[] { "*" };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 114332, 114732);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 114748, 114764);

                string[]
                module
                = default(string[]);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 114778, 115185) || true) && (f_1668_114782_114863(dataAsPSObject, RemoteDataNameStrings.DiscoveryModule) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 114778, 115185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 114905, 115016);

                    IEnumerable<string>
                    tmp = f_1668_114931_115015(dataAsPSObject, RemoteDataNameStrings.DiscoveryModule)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 115034, 115075);

                    module = f_1668_115043_115074(f_1668_115043_115064(tmp));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 114778, 115185);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 114778, 115185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 115141, 115170);

                    module = new string[] { "" };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 114778, 115185);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 115201, 115249);

                ModuleSpecification[]
                fullyQualifiedName = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 115263, 115944) || true) && (f_1668_115267_115652(dataAsPSObject, RemoteDataNameStrings.DiscoveryFullyQualifiedModule, DeserializingTypeConverter.RehydrationFlags.NullValueOk | DeserializingTypeConverter.RehydrationFlags.MissingPropertyOk) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 115263, 115944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 115694, 115845);

                    IEnumerable<ModuleSpecification>
                    tmp = f_1668_115733_115844(dataAsPSObject, RemoteDataNameStrings.DiscoveryFullyQualifiedModule)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 115863, 115929);

                    fullyQualifiedName = f_1668_115884_115928(f_1668_115884_115918(tmp));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 115263, 115944);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 115960, 115982);

                object[]
                argumentList
                = default(object[]);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 115996, 116412) || true) && (f_1668_116000_116087(dataAsPSObject, RemoteDataNameStrings.DiscoveryArgumentList) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 115996, 116412);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 116129, 116246);

                    IEnumerable<object>
                    tmp = f_1668_116155_116245(dataAsPSObject, RemoteDataNameStrings.DiscoveryArgumentList)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 116264, 116311);

                    argumentList = f_1668_116279_116310(f_1668_116279_116300(tmp));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 115996, 116412);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 115996, 116412);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 116377, 116397);

                    argumentList = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 115996, 116412);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 116428, 116472);

                PowerShell
                powerShell = f_1668_116452_116471()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 116486, 116523);

                f_1668_116486_116522(powerShell, "Get-Command");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 116537, 116575);

                f_1668_116537_116574(powerShell, "Name", name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 116589, 116641);

                f_1668_116589_116640(powerShell, "CommandType", commandType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 116655, 116910) || true) && (fullyQualifiedName != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 116655, 116910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 116719, 116787);

                    f_1668_116719_116786(powerShell, "FullyQualifiedModule", fullyQualifiedName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 116655, 116910);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 116655, 116910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 116853, 116895);

                    f_1668_116853_116894(powerShell, "Module", module);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 116655, 116910);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 116926, 116980);

                f_1668_116926_116979(
                            powerShell, "ArgumentList", argumentList);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 116994, 117012);

                return powerShell;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 113805, 117023);

                System.Management.Automation.PSObject
                f_1668_113923_113948(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 113923, 113948);
                    return return_v;
                }


                string
                f_1668_114066_114119()
                {
                    var return_v = RemotingErrorIdStrings.CantCastRemotingDataToPSObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 114066, 114119);
                    return return_v;
                }


                System.Type
                f_1668_114121_114135(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 114121, 114135);
                    return return_v;
                }


                string
                f_1668_114121_114144(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 114121, 114144);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1668_114029_114145(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 114029, 114145);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1668_114204_114287(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<CommandTypes>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 114204, 114287);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1668_114336_114415(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<PSObject>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 114336, 114415);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1668_114483_114565(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = EnumerateListProperty<string>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 114483, 114565);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1668_114591_114612(System.Collections.Generic.IEnumerable<string>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<string>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 114591, 114612);
                    return return_v;
                }


                string[]
                f_1668_114591_114622(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 114591, 114622);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1668_114782_114863(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<PSObject>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 114782, 114863);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1668_114931_115015(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = EnumerateListProperty<string>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 114931, 115015);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1668_115043_115064(System.Collections.Generic.IEnumerable<string>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<string>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 115043, 115064);
                    return return_v;
                }


                string[]
                f_1668_115043_115074(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 115043, 115074);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1668_115267_115652(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<PSObject>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 115267, 115652);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1668_115733_115844(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = EnumerateListProperty<ModuleSpecification>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 115733, 115844);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1668_115884_115918(System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.ModuleSpecification>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.ModuleSpecification>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 115884, 115918);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1668_115884_115928(System.Collections.Generic.List<Microsoft.PowerShell.Commands.ModuleSpecification>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 115884, 115928);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1668_116000_116087(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<PSObject>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 116000, 116087);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<object>
                f_1668_116155_116245(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = EnumerateListProperty<object>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 116155, 116245);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1668_116279_116300(System.Collections.Generic.IEnumerable<object>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<object>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 116279, 116300);
                    return return_v;
                }


                object[]
                f_1668_116279_116310(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 116279, 116310);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1668_116452_116471()
                {
                    var return_v = PowerShell.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 116452, 116471);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1668_116486_116522(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 116486, 116522);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1668_116537_116574(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string[]
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 116537, 116574);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1668_116589_116640(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.CommandTypes
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 116589, 116640);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1668_116719_116786(System.Management.Automation.PowerShell
                this_param, string
                parameterName, Microsoft.PowerShell.Commands.ModuleSpecification[]
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 116719, 116786);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1668_116853_116894(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string[]
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 116853, 116894);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1668_116926_116979(System.Management.Automation.PowerShell
                this_param, string
                parameterName, object[]
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 116926, 116979);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 113805, 117023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 113805, 117023);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool GetNoInput(object data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 117300, 117739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 117369, 117421);

                PSObject
                dataAsPSObject = f_1668_117395_117420(data)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 117437, 117635) || true) && (dataAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 117437, 117635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 117497, 117620);

                    throw f_1668_117503_117619(f_1668_117540_117593(), f_1668_117595_117618(f_1668_117595_117609(data)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 117437, 117635);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 117651, 117728);

                return f_1668_117658_117727(dataAsPSObject, RemoteDataNameStrings.NoInput);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 117300, 117739);

                System.Management.Automation.PSObject
                f_1668_117395_117420(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 117395, 117420);
                    return return_v;
                }


                string
                f_1668_117540_117593()
                {
                    var return_v = RemotingErrorIdStrings.CantCastRemotingDataToPSObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 117540, 117593);
                    return return_v;
                }


                System.Type
                f_1668_117595_117609(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 117595, 117609);
                    return return_v;
                }


                string
                f_1668_117595_117618(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 117595, 117618);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1668_117503_117619(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 117503, 117619);
                    return return_v;
                }


                bool
                f_1668_117658_117727(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<bool>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 117658, 117727);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 117300, 117739);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 117300, 117739);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool GetAddToHistory(object data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 118021, 118470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 118095, 118147);

                PSObject
                dataAsPSObject = f_1668_118121_118146(data)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 118163, 118361) || true) && (dataAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 118163, 118361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 118223, 118346);

                    throw f_1668_118229_118345(f_1668_118266_118319(), f_1668_118321_118344(f_1668_118321_118335(data)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 118163, 118361);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 118377, 118459);

                return f_1668_118384_118458(dataAsPSObject, RemoteDataNameStrings.AddToHistory);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 118021, 118470);

                System.Management.Automation.PSObject
                f_1668_118121_118146(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 118121, 118146);
                    return return_v;
                }


                string
                f_1668_118266_118319()
                {
                    var return_v = RemotingErrorIdStrings.CantCastRemotingDataToPSObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 118266, 118319);
                    return return_v;
                }


                System.Type
                f_1668_118321_118335(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 118321, 118335);
                    return return_v;
                }


                string
                f_1668_118321_118344(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 118321, 118344);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1668_118229_118345(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 118229, 118345);
                    return return_v;
                }


                bool
                f_1668_118384_118458(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<bool>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 118384, 118458);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 118021, 118470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 118021, 118470);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool GetIsNested(object data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 118744, 119185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 118814, 118866);

                PSObject
                dataAsPSObject = f_1668_118840_118865(data)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 118882, 119080) || true) && (dataAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 118882, 119080);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 118942, 119065);

                    throw f_1668_118948_119064(f_1668_118985_119038(), f_1668_119040_119063(f_1668_119040_119054(data)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 118882, 119080);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 119096, 119174);

                return f_1668_119103_119173(dataAsPSObject, RemoteDataNameStrings.IsNested);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 118744, 119185);

                System.Management.Automation.PSObject
                f_1668_118840_118865(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 118840, 118865);
                    return return_v;
                }


                string
                f_1668_118985_119038()
                {
                    var return_v = RemotingErrorIdStrings.CantCastRemotingDataToPSObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 118985, 119038);
                    return return_v;
                }


                System.Type
                f_1668_119040_119054(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 119040, 119054);
                    return return_v;
                }


                string
                f_1668_119040_119063(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 119040, 119063);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1668_118948_119064(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 118948, 119064);
                    return return_v;
                }


                bool
                f_1668_119103_119173(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<bool>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 119103, 119173);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 118744, 119185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 118744, 119185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ApartmentState GetApartmentState(object data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 119390, 119647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 119476, 119528);

                PSObject
                dataAsPSObject = f_1668_119502_119527(data)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 119542, 119636);

                return f_1668_119549_119635(dataAsPSObject, RemoteDataNameStrings.ApartmentState);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 119390, 119647);

                System.Management.Automation.PSObject
                f_1668_119502_119527(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 119502, 119527);
                    return return_v;
                }


                System.Threading.ApartmentState
                f_1668_119549_119635(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<ApartmentState>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 119549, 119635);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 119390, 119647);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 119390, 119647);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteStreamOptions GetRemoteStreamOptions(object data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 119835, 120112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 119931, 119983);

                PSObject
                dataAsPSObject = f_1668_119957_119982(data)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 119997, 120101);

                return f_1668_120004_120100(dataAsPSObject, RemoteDataNameStrings.RemoteStreamOptions);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 119835, 120112);

                System.Management.Automation.PSObject
                f_1668_119957_119982(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 119957, 119982);
                    return return_v;
                }


                System.Management.Automation.RemoteStreamOptions
                f_1668_120004_120100(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<RemoteStreamOptions>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 120004, 120100);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 119835, 120112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 119835, 120112);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteSessionCapability GetSessionCapability(object data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 120346, 122254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 120444, 120487);

                PSObject
                dataAsPSObject = data as PSObject
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 120503, 120723) || true) && (dataAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 120503, 120723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 120563, 120708);

                    throw f_1668_120569_120707(f_1668_120628_120681(), f_1668_120683_120706(f_1668_120683_120697(data)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 120503, 120723);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 120739, 120863);

                Version
                protocolVersion = f_1668_120765_120862(dataAsPSObject, RemoteDataNameStrings.PS_STARTUP_PROTOCOL_VERSION_NAME)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 120877, 120972);

                Version
                psVersion = f_1668_120897_120971(dataAsPSObject, RemoteDataNameStrings.PSVersion)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 120986, 121120);

                Version
                serializationVersion = f_1668_121017_121119(dataAsPSObject, RemoteDataNameStrings.SerializationVersion)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 121136, 121322);

                RemoteSessionCapability
                result = f_1668_121169_121321(RemotingDestination.InvalidDestination, protocolVersion, psVersion, serializationVersion)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 121338, 122213) || true) && (f_1668_121342_121399(f_1668_121342_121367(dataAsPSObject), RemoteDataNameStrings.TimeZone) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 121338, 122213);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 121338, 122213);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 122229, 122243);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 120346, 122254);

                string
                f_1668_120628_120681()
                {
                    var return_v = RemotingErrorIdStrings.CantCastRemotingDataToPSObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 120628, 120681);
                    return return_v;
                }


                System.Type
                f_1668_120683_120697(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 120683, 120697);
                    return return_v;
                }


                string
                f_1668_120683_120706(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 120683, 120706);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1668_120569_120707(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 120569, 120707);
                    return return_v;
                }


                System.Version
                f_1668_120765_120862(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<Version>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 120765, 120862);
                    return return_v;
                }


                System.Version
                f_1668_120897_120971(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<Version>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 120897, 120971);
                    return return_v;
                }


                System.Version
                f_1668_121017_121119(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue<Version>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 121017, 121119);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionCapability
                f_1668_121169_121321(System.Management.Automation.RemotingDestination
                remotingDestination, System.Version
                protocolVersion, System.Version
                psVersion, System.Version
                serVersion)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteSessionCapability(remotingDestination, protocolVersion, psVersion, serVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 121169, 121321);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1668_121342_121367(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 121342, 121367);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1668_121342_121399(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 121342, 121399);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 120346, 122254);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 120346, 122254);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ServerSupportsBatchInvocation(Runspace runspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1668, 122522, 122878);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 122616, 122762) || true) && (runspace == null || (DynAbs.Tracing.TraceSender.Expression_False(1668, 122620, 122700) || f_1668_122640_122672(f_1668_122640_122666(runspace)) == RunspaceState.BeforeOpen))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1668, 122616, 122762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 122734, 122747);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1668, 122616, 122762);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1668, 122778, 122867);

                return (f_1668_122786_122821(runspace) >= RemotingConstants.ProtocolVersionWin8RTM);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1668, 122522, 122878);

                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1668_122640_122666(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 122640, 122666);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1668_122640_122672(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1668, 122640, 122672);
                    return return_v;
                }


                System.Version
                f_1668_122786_122821(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.GetRemoteProtocolVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1668, 122786, 122821);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1668, 122522, 122878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 122522, 122878);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RemotingDecoder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1668, 90417, 122885);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1668, 90417, 122885);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1668, 90417, 122885);
        }

    }
}
