// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Remoting;

using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell.Commands
{
[Cmdlet(VerbsCommon.Exit, "PSSession", HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096787")]
    public class ExitPSSessionCommand : PSRemotingCmdlet
{
protected override void ProcessRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1601,669,1349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1601,776,860);

IHostSupportsInteractiveSession 
host = f_1601_815_824(this)as IHostSupportsInteractiveSession
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1601,874,1303) || true) && (host == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1601,874,1303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1601,924,1263);

f_1601_924_1262(this, f_1601_957_1261(f_1601_999_1087(f_1601_1021_1086(this, f_1601_1032_1085())), f_1601_1114_1173(                        PSRemotingErrorId.HostDoesNotSupportPushRunspace), ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1601,1281,1288);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1601,874,1303);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1601,1319,1338);

f_1601_1319_1337(
            host);
DynAbs.Tracing.TraceSender.TraceExitMethod(1601,669,1349);

System.Management.Automation.Host.PSHost
f_1601_815_824(Microsoft.PowerShell.Commands.ExitPSSessionCommand
this_param)
{
var return_v = this_param.Host ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1601, 815, 824);
return return_v;
}


string
f_1601_1032_1085()
{
var return_v = RemotingErrorIdStrings.HostDoesNotSupportPushRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1601, 1032, 1085);
return return_v;
}


string
f_1601_1021_1086(Microsoft.PowerShell.Commands.ExitPSSessionCommand
this_param,string
resourceString)
{
var return_v = this_param.GetMessage( resourceString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1601, 1021, 1086);
return return_v;
}


System.ArgumentException
f_1601_999_1087(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1601, 999, 1087);
return return_v;
}


string
f_1601_1114_1173(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1601, 1114, 1173);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1601_957_1261(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1601, 957, 1261);
return return_v;
}


int
f_1601_924_1262(Microsoft.PowerShell.Commands.ExitPSSessionCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1601, 924, 1262);
return 0;
}


int
f_1601_1319_1337(System.Management.Automation.Host.IHostSupportsInteractiveSession
this_param)
{
this_param.PopRunspace();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1601, 1319, 1337);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1601,669,1349);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1601,669,1349);
}
		}

public ExitPSSessionCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1601,418,1356);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1601,418,1356);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1601,418,1356);
}


static ExitPSSessionCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1601,418,1356);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1601,418,1356);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1601,418,1356);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1601,418,1356);
}
}
