// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Security;
using System.Text;

namespace Microsoft.PowerShell.Commands
{
[Cmdlet(VerbsCommon.Enter, "PSHostProcess", DefaultParameterSetName = EnterPSHostProcessCommand.ProcessIdParameterSet,
        HelpUri = "https://go.microsoft.com/fwlink/?LinkId=2096580")]
    public sealed class EnterPSHostProcessCommand : PSCmdlet
{
private IHostSupportsInteractiveSession _interactiveHost;

private RemoteRunspace _connectingRemoteRunspace;

private const string 
ProcessParameterSet = "ProcessParameterSet"
;

private const string 
ProcessNameParameterSet = "ProcessNameParameterSet"
;

private const string 
ProcessIdParameterSet = "ProcessIdParameterSet"
;

private const string 
PipeNameParameterSet = "PipeNameParameterSet"
;

private const string 
PSHostProcessInfoParameterSet = "PSHostProcessInfoParameterSet"
;

private const string 
NamedPipeRunspaceName = "PSAttachRunspace"
;

[Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true, ParameterSetName = EnterPSHostProcessCommand.ProcessParameterSet)]
        [ValidateNotNull()]
        public Process Process
{            get;
            set;
}

[Parameter(Position = 0, Mandatory = true, ParameterSetName = EnterPSHostProcessCommand.ProcessIdParameterSet)]
        [ValidateRange(0, int.MaxValue)]
        public int Id
{            get;
            set;
}

[Parameter(Position = 0, Mandatory = true, ParameterSetName = EnterPSHostProcessCommand.ProcessNameParameterSet)]
        [ValidateNotNullOrEmpty()]
        public string Name
{            get;
            set;
}

[Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true, ParameterSetName = EnterPSHostProcessCommand.PSHostProcessInfoParameterSet)]
        [ValidateNotNull()]
        public PSHostProcessInfo HostProcessInfo
{            get;
            set;
}

[Parameter(Mandatory = true, ParameterSetName = EnterPSHostProcessCommand.PipeNameParameterSet)]
        public string CustomPipeName
{            get;
            set;
}

[Parameter(Position = 1, ParameterSetName = EnterPSHostProcessCommand.ProcessParameterSet)]
        [Parameter(Position = 1, ParameterSetName = EnterPSHostProcessCommand.ProcessIdParameterSet)]
        [Parameter(Position = 1, ParameterSetName = EnterPSHostProcessCommand.ProcessNameParameterSet)]
        [Parameter(Position = 1, ParameterSetName = EnterPSHostProcessCommand.PSHostProcessInfoParameterSet)]
        [ValidateNotNullOrEmpty]
        public string AppDomainName
{            get;
            set;
}

protected override void EndProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1592,4815,8060);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,4974,5429) || true) && (f_1592_4978_5016()== SystemEnforcementMode.Enforce)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,4974,5429);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,5083,5387);

f_1592_5083_5386(this, f_1592_5116_5385(f_1592_5158_5238(f_1592_5182_5237()), "EnterPSHostProcessCmdletDisabled", ErrorCategory.SecurityError, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,5407,5414);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,4974,5429);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,5519,5583);

_interactiveHost = f_1592_5538_5547(this)as IHostSupportsInteractiveSession;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,5597,6013) || true) && (_interactiveHost == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,5597,6013);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,5659,5971);

f_1592_5659_5970(this, f_1592_5692_5969(f_1592_5734_5807(f_1592_5756_5806()), "EnterPSHostProcessHostDoesNotSupportIASession", ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,5991,5998);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,5597,6013);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,6116,6150);

Runspace 
namedPipeRunspace = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,6164,7342);

switch (f_1592_6172_6188())
            {

case ProcessIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,6164,7342);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,6271,6300);

Process = f_1592_6281_6299(this, f_1592_6296_6298());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,6322,6345);

f_1592_6322_6344(this, f_1592_6336_6343());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,6367,6438);

namedPipeRunspace = f_1592_6387_6437(this, f_1592_6411_6421(f_1592_6411_6418()), f_1592_6423_6436());
DynAbs.Tracing.TraceSender.TraceBreak(1592,6460,6466);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,6164,7342);

case ProcessNameParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,6164,7342);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,6537,6570);

Process = f_1592_6547_6569(this, f_1592_6564_6568());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,6592,6615);

f_1592_6592_6614(this, f_1592_6606_6613());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,6637,6708);

namedPipeRunspace = f_1592_6657_6707(this, f_1592_6681_6691(f_1592_6681_6688()), f_1592_6693_6706());
DynAbs.Tracing.TraceSender.TraceBreak(1592,6730,6736);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,6164,7342);

case PSHostProcessInfoParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,6164,7342);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,6813,6868);

Process = f_1592_6823_6867(this, f_1592_6851_6866());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,6890,6913);

f_1592_6890_6912(this, f_1592_6904_6911());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,7019,7090);

namedPipeRunspace = f_1592_7039_7089(this, f_1592_7063_7073(f_1592_7063_7070()), f_1592_7075_7088());
DynAbs.Tracing.TraceSender.TraceBreak(1592,7112,7118);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,6164,7342);

case PipeNameParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,6164,7342);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,7186,7217);

f_1592_7186_7216(this, f_1592_7201_7215());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,7239,7299);

namedPipeRunspace = f_1592_7259_7298(this, f_1592_7283_7297());
DynAbs.Tracing.TraceSender.TraceBreak(1592,7321,7327);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,6164,7342);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,7483,7518);

f_1592_7483_7517(this, namedPipeRunspace);

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,7615,7664);

f_1592_7615_7663(                // Push runspace onto host.
                _interactiveHost, namedPipeRunspace);
            }
            catch (Exception e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1592,7693,8049);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,7745,7771);

f_1592_7745_7770(                namedPipeRunspace);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,7791,8034);

f_1592_7791_8033(this, f_1592_7835_8032(e, "EnterPSHostProcessCannotPushRunspace", ErrorCategory.InvalidOperation, this));
DynAbs.Tracing.TraceSender.TraceExitCatch(1592,7693,8049);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1592,4815,8060);

System.Management.Automation.Security.SystemEnforcementMode
f_1592_4978_5016()
{
var return_v = SystemPolicy.GetSystemLockdownPolicy();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 4978, 5016);
return return_v;
}


string
f_1592_5182_5237()
{
var return_v = RemotingErrorIdStrings.EnterPSHostProcessCmdletDisabled;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 5182, 5237);
return return_v;
}


System.Management.Automation.PSSecurityException
f_1592_5158_5238(string
message)
{
var return_v = new System.Management.Automation.PSSecurityException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 5158, 5238);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1592_5116_5385(System.Management.Automation.PSSecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 5116, 5385);
return return_v;
}


int
f_1592_5083_5386(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 5083, 5386);
return 0;
}


System.Management.Automation.Host.PSHost
f_1592_5538_5547(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param)
{
var return_v = this_param.Host ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 5538, 5547);
return return_v;
}


string
f_1592_5756_5806()
{
var return_v = RemotingErrorIdStrings.HostDoesNotSupportIASession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 5756, 5806);
return return_v;
}


System.ArgumentException
f_1592_5734_5807(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 5734, 5807);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1592_5692_5969(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 5692, 5969);
return return_v;
}


int
f_1592_5659_5970(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 5659, 5970);
return 0;
}


string
f_1592_6172_6188()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 6172, 6188);
return return_v;
}


int
f_1592_6296_6298()
{
var return_v = Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 6296, 6298);
return return_v;
}


System.Diagnostics.Process
f_1592_6281_6299(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,int
procId)
{
var return_v = this_param.GetProcessById( procId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 6281, 6299);
return return_v;
}


System.Diagnostics.Process
f_1592_6336_6343()
{
var return_v = Process;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 6336, 6343);
return return_v;
}


int
f_1592_6322_6344(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,System.Diagnostics.Process
process)
{
this_param.VerifyProcess( process);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 6322, 6344);
return 0;
}


System.Diagnostics.Process
f_1592_6411_6418()
{
var return_v = Process;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 6411, 6418);
return return_v;
}


int
f_1592_6411_6421(System.Diagnostics.Process
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 6411, 6421);
return return_v;
}


string
f_1592_6423_6436()
{
var return_v = AppDomainName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 6423, 6436);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1592_6387_6437(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,int
procId,string
appDomainName)
{
var return_v = this_param.CreateNamedPipeRunspace( procId, appDomainName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 6387, 6437);
return return_v;
}


string
f_1592_6564_6568()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 6564, 6568);
return return_v;
}


System.Diagnostics.Process
f_1592_6547_6569(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,string
name)
{
var return_v = this_param.GetProcessByName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 6547, 6569);
return return_v;
}


System.Diagnostics.Process
f_1592_6606_6613()
{
var return_v = Process;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 6606, 6613);
return return_v;
}


int
f_1592_6592_6614(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,System.Diagnostics.Process
process)
{
this_param.VerifyProcess( process);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 6592, 6614);
return 0;
}


System.Diagnostics.Process
f_1592_6681_6688()
{
var return_v = Process;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 6681, 6688);
return return_v;
}


int
f_1592_6681_6691(System.Diagnostics.Process
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 6681, 6691);
return return_v;
}


string
f_1592_6693_6706()
{
var return_v = AppDomainName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 6693, 6706);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1592_6657_6707(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,int
procId,string
appDomainName)
{
var return_v = this_param.CreateNamedPipeRunspace( procId, appDomainName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 6657, 6707);
return return_v;
}


Microsoft.PowerShell.Commands.PSHostProcessInfo
f_1592_6851_6866()
{
var return_v = HostProcessInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 6851, 6866);
return return_v;
}


System.Diagnostics.Process
f_1592_6823_6867(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,Microsoft.PowerShell.Commands.PSHostProcessInfo
hostProcessInfo)
{
var return_v = this_param.GetProcessByHostProcessInfo( hostProcessInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 6823, 6867);
return return_v;
}


System.Diagnostics.Process
f_1592_6904_6911()
{
var return_v = Process;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 6904, 6911);
return return_v;
}


int
f_1592_6890_6912(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,System.Diagnostics.Process
process)
{
this_param.VerifyProcess( process);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 6890, 6912);
return 0;
}


System.Diagnostics.Process
f_1592_7063_7070()
{
var return_v = Process;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 7063, 7070);
return return_v;
}


int
f_1592_7063_7073(System.Diagnostics.Process
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 7063, 7073);
return return_v;
}


string
f_1592_7075_7088()
{
var return_v = AppDomainName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 7075, 7088);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1592_7039_7089(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,int
procId,string
appDomainName)
{
var return_v = this_param.CreateNamedPipeRunspace( procId, appDomainName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 7039, 7089);
return return_v;
}


string
f_1592_7201_7215()
{
var return_v = CustomPipeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 7201, 7215);
return return_v;
}


int
f_1592_7186_7216(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,string
customPipeName)
{
this_param.VerifyPipeName( customPipeName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 7186, 7216);
return 0;
}


string
f_1592_7283_7297()
{
var return_v = CustomPipeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 7283, 7297);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1592_7259_7298(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,string
customPipeName)
{
var return_v = this_param.CreateNamedPipeRunspace( customPipeName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 7259, 7298);
return return_v;
}


int
f_1592_7483_7517(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,System.Management.Automation.Runspaces.Runspace
runspace)
{
this_param.PrepareRunspace( runspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 7483, 7517);
return 0;
}


int
f_1592_7615_7663(System.Management.Automation.Host.IHostSupportsInteractiveSession
this_param,System.Management.Automation.Runspaces.Runspace
runspace)
{
this_param.PushRunspace( runspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 7615, 7663);
return 0;
}


int
f_1592_7745_7770(System.Management.Automation.Runspaces.Runspace
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 7745, 7770);
return 0;
}


System.Management.Automation.ErrorRecord
f_1592_7835_8032(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 7835, 8032);
return return_v;
}


int
f_1592_7791_8033(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 7791, 8033);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1592,4815,8060);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,4815,8060);
}
		}

protected override void StopProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1592,8149,8411);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,8214,8276);

RemoteRunspace 
connectingRunspace = _connectingRemoteRunspace
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,8290,8400) || true) && (connectingRunspace != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,8290,8400);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,8354,8385);

f_1592_8354_8384(                connectingRunspace);
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,8290,8400);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1592,8149,8411);

int
f_1592_8354_8384(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.AbortOpen();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 8354, 8384);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1592,8149,8411);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,8149,8411);
}
		}

private Runspace CreateNamedPipeRunspace(string customPipeName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1592,8480,8725);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,8568,8653);

NamedPipeConnectionInfo 
connectionInfo = f_1592_8609_8652(customPipeName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,8667,8714);

return f_1592_8674_8713(this, connectionInfo);
DynAbs.Tracing.TraceSender.TraceExitMethod(1592,8480,8725);

System.Management.Automation.Runspaces.NamedPipeConnectionInfo
f_1592_8609_8652(string
customPipeName)
{
var return_v = new System.Management.Automation.Runspaces.NamedPipeConnectionInfo( customPipeName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 8609, 8652);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1592_8674_8713(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,System.Management.Automation.Runspaces.NamedPipeConnectionInfo
connectionInfo)
{
var return_v = this_param.CreateNamedPipeRunspace( connectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 8674, 8713);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1592,8480,8725);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,8480,8725);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Runspace CreateNamedPipeRunspace(int procId, string appDomainName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1592,8737,9000);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,8836,8928);

NamedPipeConnectionInfo 
connectionInfo = f_1592_8877_8927(procId, appDomainName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,8942,8989);

return f_1592_8949_8988(this, connectionInfo);
DynAbs.Tracing.TraceSender.TraceExitMethod(1592,8737,9000);

System.Management.Automation.Runspaces.NamedPipeConnectionInfo
f_1592_8877_8927(int
processId,string
appDomainName)
{
var return_v = new System.Management.Automation.Runspaces.NamedPipeConnectionInfo( processId, appDomainName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 8877, 8927);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1592_8949_8988(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,System.Management.Automation.Runspaces.NamedPipeConnectionInfo
connectionInfo)
{
var return_v = this_param.CreateNamedPipeRunspace( connectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 8949, 8988);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1592,8737,9000);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,8737,9000);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Runspace CreateNamedPipeRunspace(NamedPipeConnectionInfo connectionInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1592,9012,11685);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,9117,9172);

TypeTable 
typeTable = f_1592_9139_9171()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,9186,9305);

RemoteRunspace 
remoteRunspace = f_1592_9218_9286(connectionInfo, f_1592_9265_9274(this), typeTable)as RemoteRunspace
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,9319,9363);

remoteRunspace.Name = NamedPipeRunspaceName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,9377,9416);

remoteRunspace.ShouldCloseOnPop = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,9430,9473);

_connectingRemoteRunspace = remoteRunspace;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,9525,9547);

f_1592_9525_9546(                remoteRunspace);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,9565,9653);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_1592_9565_9588(remoteRunspace), 1592, 9565, 9652).SetDebugMode(DebugModes.LocalScript | DebugModes.RemoteScript),1592,9589,9652);
            }
            catch (RuntimeException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1592,9682,11534);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,9820,9929);

string 
errorMessage = (DynAbs.Tracing.TraceSender.Conditional_F1(1592, 9842, 9868)||(((f_1592_9843_9859(e)!= null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1592, 9871, 9913))||DynAbs.Tracing.TraceSender.Conditional_F3(1592, 9916, 9928)))?(f_1592_9872_9896(f_1592_9872_9888(e))??(DynAbs.Tracing.TraceSender.Expression_Null<string>(1592, 9872, 9912)??string.Empty)) :string.Empty
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,9949,11519) || true) && (f_1592_9953_9982(connectionInfo)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,9949,11519);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,10032,10638);

f_1592_10032_10637(this, f_1592_10080_10636(f_1592_10126_10469(f_1592_10181_10417(f_1592_10237_10297(), f_1592_10336_10365(connectionInfo), errorMessage), f_1592_10452_10468(e)), "EnterPSHostProcessCannotConnectToPipe", ErrorCategory.OperationTimeout, this));
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,9949,11519);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,9949,11519);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,10720,10814);

string 
msgAppDomainName = f_1592_10746_10774(connectionInfo)??(DynAbs.Tracing.TraceSender.Expression_Null<string>(1592, 10746, 10813)??NamedPipeUtils.DefaultAppDomainName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,10838,11500);

f_1592_10838_11499(this, f_1592_10886_11498(f_1592_10932_11328(f_1592_10987_11276(f_1592_11043_11106(), msgAppDomainName, f_1592_11200_11224(connectionInfo), errorMessage), f_1592_11311_11327(e)), "EnterPSHostProcessCannotConnectToProcess", ErrorCategory.OperationTimeout, this));
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,9949,11519);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(1592,9682,11534);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1592,11548,11636);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,11588,11621);

_connectingRemoteRunspace = null;
DynAbs.Tracing.TraceSender.TraceExitFinally(1592,11548,11636);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,11652,11674);

return remoteRunspace;
DynAbs.Tracing.TraceSender.TraceExitMethod(1592,9012,11685);

System.Management.Automation.Runspaces.TypeTable
f_1592_9139_9171()
{
var return_v = TypeTable.LoadDefaultTypeFiles();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 9139, 9171);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1592_9265_9274(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 9265, 9274);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1592_9218_9286(System.Management.Automation.Runspaces.NamedPipeConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Runspaces.TypeTable
typeTable)
{
var return_v = RunspaceFactory.CreateRunspace( (System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host, typeTable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 9218, 9286);
return return_v;
}


int
f_1592_9525_9546(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.Open();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 9525, 9546);
return 0;
}


System.Management.Automation.Debugger
f_1592_9565_9588(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.Debugger;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 9565, 9588);
return return_v;
}


System.Exception
f_1592_9843_9859(System.Management.Automation.RuntimeException
this_param)
{
var return_v = this_param.InnerException ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 9843, 9859);
return return_v;
}


System.Exception
f_1592_9872_9888(System.Management.Automation.RuntimeException
this_param)
{
var return_v = this_param.InnerException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 9872, 9888);
return return_v;
}


string
f_1592_9872_9896(System.Exception
this_param)
{
var return_v = this_param.Message ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 9872, 9896);
return return_v;
}


string
f_1592_9953_9982(System.Management.Automation.Runspaces.NamedPipeConnectionInfo
this_param)
{
var return_v = this_param.CustomPipeName ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 9953, 9982);
return return_v;
}


string
f_1592_10237_10297()
{
var return_v =                                     RemotingErrorIdStrings.EnterPSHostProcessCannotConnectToPipe;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 10237, 10297);
return return_v;
}


string
f_1592_10336_10365(System.Management.Automation.Runspaces.NamedPipeConnectionInfo
this_param)
{
var return_v = this_param.CustomPipeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 10336, 10365);
return return_v;
}


string
f_1592_10181_10417(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 10181, 10417);
return return_v;
}


System.Exception
f_1592_10452_10468(System.Management.Automation.RuntimeException
this_param)
{
var return_v = this_param.InnerException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 10452, 10468);
return return_v;
}


System.Management.Automation.RuntimeException
f_1592_10126_10469(string
message,System.Exception
innerException)
{
var return_v = new System.Management.Automation.RuntimeException( message, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 10126, 10469);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1592_10080_10636(System.Management.Automation.RuntimeException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 10080, 10636);
return return_v;
}


int
f_1592_10032_10637(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 10032, 10637);
return 0;
}


string
f_1592_10746_10774(System.Management.Automation.Runspaces.NamedPipeConnectionInfo
this_param)
{
var return_v = this_param.AppDomainName ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 10746, 10774);
return return_v;
}


string
f_1592_11043_11106()
{
var return_v =                                     RemotingErrorIdStrings.EnterPSHostProcessCannotConnectToProcess;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 11043, 11106);
return return_v;
}


int
f_1592_11200_11224(System.Management.Automation.Runspaces.NamedPipeConnectionInfo
this_param)
{
var return_v = this_param.ProcessId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 11200, 11224);
return return_v;
}


string
f_1592_10987_11276(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 10987, 11276);
return return_v;
}


System.Exception
f_1592_11311_11327(System.Management.Automation.RuntimeException
this_param)
{
var return_v = this_param.InnerException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 11311, 11327);
return return_v;
}


System.Management.Automation.RuntimeException
f_1592_10932_11328(string
message,System.Exception
innerException)
{
var return_v = new System.Management.Automation.RuntimeException( message, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 10932, 11328);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1592_10886_11498(System.Management.Automation.RuntimeException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 10886, 11498);
return return_v;
}


int
f_1592_10838_11499(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 10838, 11499);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1592,9012,11685);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,9012,11685);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void PrepareRunspace(Runspace runspace)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1592,11697,12528);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,11769,12031);

string 
promptFn = f_1592_11787_12030(f_1592_11805_11852(), @"function global:prompt { """, @"$($PID)", @"PS $($executionContext.SessionState.Path.CurrentLocation)> "" }")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,12105,12517);
using(System.Management.Automation.PowerShell 
ps = f_1592_12157_12205()
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,12239,12262);

ps.Runspace = runspace;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,12378,12410);

f_1592_12378_12409(f_1592_12378_12400(                    // Set pushed runspace prompt.
                    ps, promptFn));
                }
                catch (Exception)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1592,12447,12502);
DynAbs.Tracing.TraceSender.TraceExitCatch(1592,12447,12502);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(1592,12105,12517);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1592,11697,12528);

string
f_1592_11805_11852()
{
var return_v = RemotingErrorIdStrings.EnterPSHostProcessPrompt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 11805, 11852);
return return_v;
}


string
f_1592_11787_12030(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 11787, 12030);
return return_v;
}


System.Management.Automation.PowerShell
f_1592_12157_12205()
{
var return_v = System.Management.Automation.PowerShell.Create();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 12157, 12205);
return return_v;
}


System.Management.Automation.PowerShell
f_1592_12378_12400(System.Management.Automation.PowerShell
this_param,string
script)
{
var return_v = this_param.AddScript( script);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 12378, 12400);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1592_12378_12409(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 12378, 12409);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1592,11697,12528);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,11697,12528);
}
		}

private Process GetProcessById(int procId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1592,12540,13235);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,12643,12681);

return f_1592_12650_12680(procId);
            }
            catch (System.ArgumentException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1592,12710,13224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,12775,13177);

f_1592_12775_13176(this, f_1592_12823_13149(f_1592_12869_12982(f_1592_12893_12981(f_1592_12911_12972(), procId)), "EnterPSHostProcessNoProcessFoundWithId", ErrorCategory.InvalidArgument, this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,13197,13209);

return null;
DynAbs.Tracing.TraceSender.TraceExitCatch(1592,12710,13224);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1592,12540,13235);

System.Diagnostics.Process
f_1592_12650_12680(int
processId)
{
var return_v = Process.GetProcessById( processId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 12650, 12680);
return return_v;
}


string
f_1592_12911_12972()
{
var return_v = RemotingErrorIdStrings.EnterPSHostProcessNoProcessFoundWithId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 12911, 12972);
return return_v;
}


string
f_1592_12893_12981(string
formatSpec,int
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 12893, 12981);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1592_12869_12982(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 12869, 12982);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1592_12823_13149(System.Management.Automation.PSArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 12823, 13149);
return return_v;
}


int
f_1592_12775_13176(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 12775, 13176);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1592,12540,13235);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,12540,13235);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Process GetProcessByHostProcessInfo(PSHostProcessInfo hostProcessInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1592,13247,13410);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,13350,13399);

return f_1592_13357_13398(this, f_1592_13372_13397(hostProcessInfo));
DynAbs.Tracing.TraceSender.TraceExitMethod(1592,13247,13410);

int
f_1592_13372_13397(Microsoft.PowerShell.Commands.PSHostProcessInfo
this_param)
{
var return_v = this_param.ProcessId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 13372, 13397);
return return_v;
}


System.Diagnostics.Process
f_1592_13357_13398(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,int
procId)
{
var return_v = this_param.GetProcessById( procId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 13357, 13398);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1592,13247,13410);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,13247,13410);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Process GetProcessByName(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1592,13422,14898);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,13492,13527);

Collection<Process> 
foundProcesses
=default(Collection<Process>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,13543,13832);
using(System.Management.Automation.PowerShell 
ps = f_1592_13595_13671(RunspaceMode.CurrentRunspace)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,13705,13761);

f_1592_13705_13760(f_1592_13705_13733(                ps, "Get-Process"), "Name", name);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,13779,13817);

foundProcesses = f_1592_13796_13816(ps);
DynAbs.Tracing.TraceSender.TraceExitUsing(1592,13543,13832);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,13848,14846) || true) && (f_1592_13852_13872(foundProcesses)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,13848,14846);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,13911,14315);

f_1592_13911_14314(this, f_1592_13959_14287(f_1592_14005_14118(f_1592_14029_14117(f_1592_14047_14110(), name)), "EnterPSHostProcessNoProcessFoundWithName", ErrorCategory.InvalidArgument, this));
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,13848,14846);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,13848,14846);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,14349,14846) || true) && (f_1592_14353_14373(foundProcesses)> 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,14349,14846);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,14411,14831);

f_1592_14411_14830(this, f_1592_14459_14803(f_1592_14505_14626(f_1592_14529_14625(f_1592_14547_14618(), name)), "EnterPSHostProcessMultipleProcessesFoundWithName", ErrorCategory.InvalidArgument, this));
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,14349,14846);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,13848,14846);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,14862,14887);

return f_1592_14869_14886(foundProcesses, 0);
DynAbs.Tracing.TraceSender.TraceExitMethod(1592,13422,14898);

System.Management.Automation.PowerShell
f_1592_13595_13671(System.Management.Automation.RunspaceMode
runspace)
{
var return_v = System.Management.Automation.PowerShell.Create( runspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 13595, 13671);
return return_v;
}


System.Management.Automation.PowerShell
f_1592_13705_13733(System.Management.Automation.PowerShell
this_param,string
cmdlet)
{
var return_v = this_param.AddCommand( cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 13705, 13733);
return return_v;
}


System.Management.Automation.PowerShell
f_1592_13705_13760(System.Management.Automation.PowerShell
this_param,string
parameterName,string
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 13705, 13760);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Diagnostics.Process>
f_1592_13796_13816(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Invoke<System.Diagnostics.Process>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 13796, 13816);
return return_v;
}


int
f_1592_13852_13872(System.Collections.ObjectModel.Collection<System.Diagnostics.Process>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 13852, 13872);
return return_v;
}


string
f_1592_14047_14110()
{
var return_v = RemotingErrorIdStrings.EnterPSHostProcessNoProcessFoundWithName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 14047, 14110);
return return_v;
}


string
f_1592_14029_14117(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 14029, 14117);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1592_14005_14118(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 14005, 14118);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1592_13959_14287(System.Management.Automation.PSArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 13959, 14287);
return return_v;
}


int
f_1592_13911_14314(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 13911, 14314);
return 0;
}


int
f_1592_14353_14373(System.Collections.ObjectModel.Collection<System.Diagnostics.Process>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 14353, 14373);
return return_v;
}


string
f_1592_14547_14618()
{
var return_v = RemotingErrorIdStrings.EnterPSHostProcessMultipleProcessesFoundWithName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 14547, 14618);
return return_v;
}


string
f_1592_14529_14625(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 14529, 14625);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1592_14505_14626(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 14505, 14626);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1592_14459_14803(System.Management.Automation.PSArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 14459, 14803);
return return_v;
}


int
f_1592_14411_14830(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 14411, 14830);
return 0;
}


System.Diagnostics.Process
f_1592_14869_14886(System.Collections.ObjectModel.Collection<System.Diagnostics.Process>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 14869, 14886);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1592,13422,14898);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,13422,14898);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void VerifyProcess(Process process)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1592,14910,16378);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,14978,15459) || true) && (f_1592_14982_14992(process)== f_1592_14996_15026(f_1592_14996_15023()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,14978,15459);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,15060,15444);

f_1592_15060_15443(this, f_1592_15108_15416(f_1592_15154_15248(f_1592_15186_15247()), "EnterPSHostProcessCantEnterSameProcess", ErrorCategory.InvalidOperation, this));
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,14978,15459);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,15475,15497);

bool 
hostsSMA = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,15511,15635);

IReadOnlyCollection<PSHostProcessInfo> 
availableProcInfo = f_1592_15570_15634(null)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,15649,15881);
foreach(var procInfo in f_1592_15674_15691_I(availableProcInfo) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,15649,15881);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,15725,15866) || true) && (f_1592_15729_15739(process)== f_1592_15743_15761(procInfo))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,15725,15866);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,15803,15819);

hostsSMA = true;
DynAbs.Tracing.TraceSender.TraceBreak(1592,15841,15847);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,15725,15866);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,15649,15881);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1592,1,233);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1592,1,233);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,15897,16367) || true) && (!hostsSMA)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,15897,16367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,15944,16352);

f_1592_15944_16351(this, f_1592_15992_16324(f_1592_16038_16164(f_1592_16070_16163(f_1592_16088_16141(), f_1592_16143_16162(f_1592_16143_16150()))), "EnterPSHostProcessNoPowerShell", ErrorCategory.InvalidOperation, this));
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,15897,16367);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1592,14910,16378);

int
f_1592_14982_14992(System.Diagnostics.Process
this_param)
{
var return_v = this_param.Id ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 14982, 14992);
return return_v;
}


System.Diagnostics.Process
f_1592_14996_15023()
{
var return_v = Process.GetCurrentProcess();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 14996, 15023);
return return_v;
}


int
f_1592_14996_15026(System.Diagnostics.Process
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 14996, 15026);
return return_v;
}


string
f_1592_15186_15247()
{
var return_v = RemotingErrorIdStrings.EnterPSHostProcessCantEnterSameProcess;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 15186, 15247);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1592_15154_15248(string
message)
{
var return_v = new System.Management.Automation.PSInvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 15154, 15248);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1592_15108_15416(System.Management.Automation.PSInvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 15108, 15416);
return return_v;
}


int
f_1592_15060_15443(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 15060, 15443);
return 0;
}


System.Collections.Generic.IReadOnlyCollection<Microsoft.PowerShell.Commands.PSHostProcessInfo>
f_1592_15570_15634(int[]
procIds)
{
var return_v = GetPSHostProcessInfoCommand.GetAppDomainNamesFromProcessId( procIds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 15570, 15634);
return return_v;
}


int
f_1592_15729_15739(System.Diagnostics.Process
this_param)
{
var return_v = this_param.Id ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 15729, 15739);
return return_v;
}


int
f_1592_15743_15761(Microsoft.PowerShell.Commands.PSHostProcessInfo
this_param)
{
var return_v = this_param.ProcessId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 15743, 15761);
return return_v;
}


System.Collections.Generic.IReadOnlyCollection<Microsoft.PowerShell.Commands.PSHostProcessInfo>
f_1592_15674_15691_I(System.Collections.Generic.IReadOnlyCollection<Microsoft.PowerShell.Commands.PSHostProcessInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 15674, 15691);
return return_v;
}


string
f_1592_16088_16141()
{
var return_v = RemotingErrorIdStrings.EnterPSHostProcessNoPowerShell;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 16088, 16141);
return return_v;
}


System.Diagnostics.Process
f_1592_16143_16150()
{
var return_v = Process;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 16143, 16150);
return return_v;
}


string
f_1592_16143_16162(System.Diagnostics.Process
this_param)
{
var return_v = this_param.ProcessName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 16143, 16162);
return return_v;
}


string
f_1592_16070_16163(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 16070, 16163);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1592_16038_16164(string
message)
{
var return_v = new System.Management.Automation.PSInvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 16038, 16164);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1592_15992_16324(System.Management.Automation.PSInvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 15992, 16324);
return return_v;
}


int
f_1592_15944_16351(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 15944, 16351);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1592,14910,16378);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,14910,16378);
}
		}

private void VerifyPipeName(string customPipeName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1592,16390,17372);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,16549,16599);

var 
sb = f_1592_16558_16598(f_1592_16576_16597(customPipeName))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,16613,16826) || true) && (f_1592_16617_16635())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,16613,16826);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,16669,16693);

f_1592_16669_16692(                sb, @"\\.\pipe\");
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,16613,16826);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,16613,16826);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,16759,16811);

f_1592_16759_16810(f_1592_16759_16788(                sb, f_1592_16769_16787()), "CoreFxPipe_");
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,16613,16826);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,16842,16868);

f_1592_16842_16867(
            sb, customPipeName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,16884,16916);

string 
pipePath = f_1592_16902_16915(sb)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,16930,17361) || true) && (!f_1592_16935_16956(pipePath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,16930,17361);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,16990,17346);

f_1592_16990_17345(this, f_1592_17034_17344(f_1592_17076_17193(f_1592_17100_17192(f_1592_17118_17175(), customPipeName)), "EnterPSHostProcessNoNamedPipeFound", ErrorCategory.InvalidArgument, this));
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,16930,17361);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1592,16390,17372);

int
f_1592_16576_16597(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 16576, 16597);
return return_v;
}


System.Text.StringBuilder
f_1592_16558_16598(int
capacity)
{
var return_v = new System.Text.StringBuilder( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 16558, 16598);
return return_v;
}


bool
f_1592_16617_16635()
{
var return_v = Platform.IsWindows;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 16617, 16635);
return return_v;
}


System.Text.StringBuilder
f_1592_16669_16692(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 16669, 16692);
return return_v;
}


string
f_1592_16769_16787()
{
var return_v = Path.GetTempPath();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 16769, 16787);
return return_v;
}


System.Text.StringBuilder
f_1592_16759_16788(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 16759, 16788);
return return_v;
}


System.Text.StringBuilder
f_1592_16759_16810(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 16759, 16810);
return return_v;
}


System.Text.StringBuilder
f_1592_16842_16867(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 16842, 16867);
return return_v;
}


string
f_1592_16902_16915(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 16902, 16915);
return return_v;
}


bool
f_1592_16935_16956(string
path)
{
var return_v = File.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 16935, 16956);
return return_v;
}


string
f_1592_17118_17175()
{
var return_v = RemotingErrorIdStrings.EnterPSHostProcessNoNamedPipeFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 17118, 17175);
return return_v;
}


string
f_1592_17100_17192(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 17100, 17192);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1592_17076_17193(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 17076, 17193);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1592_17034_17344(System.Management.Automation.PSArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 17034, 17344);
return return_v;
}


int
f_1592_16990_17345(Microsoft.PowerShell.Commands.EnterPSHostProcessCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 16990, 17345);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1592,16390,17372);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,16390,17372);
}
		}

public EnterPSHostProcessCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1592,1096,17401);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,1431,1447);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,1481,1506);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,2185,2439);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,2535,2769);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,2927,3162);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,3297,3579);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,3771,3963);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,4137,4676);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1592,1096,17401);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,1096,17401);
}


static EnterPSHostProcessCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1592,1096,17401);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,1567,1610);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,1642,1693);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,1725,1772);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,1804,1849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,1881,1944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,1978,2020);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1592,1096,17401);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,1096,17401);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1592,1096,17401);
}
[Cmdlet(VerbsCommon.Exit, "PSHostProcess",
        HelpUri = "https://go.microsoft.com/fwlink/?LinkId=2096583")]
    public sealed class ExitPSHostProcessCommand : PSCmdlet
{
protected override void ProcessRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1592,17816,18435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,17880,17948);

var 
_interactiveHost = f_1592_17903_17912(this)as IHostSupportsInteractiveSession
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,17962,18377) || true) && (_interactiveHost == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,17962,18377);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,18024,18335);

f_1592_18024_18334(this, f_1592_18057_18333(f_1592_18099_18172(f_1592_18121_18171()), "ExitPSHostProcessHostDoesNotSupportIASession", ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,18355,18362);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,17962,18377);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,18393,18424);

f_1592_18393_18423(
            _interactiveHost);
DynAbs.Tracing.TraceSender.TraceExitMethod(1592,17816,18435);

System.Management.Automation.Host.PSHost
f_1592_17903_17912(Microsoft.PowerShell.Commands.ExitPSHostProcessCommand
this_param)
{
var return_v = this_param.Host ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 17903, 17912);
return return_v;
}


string
f_1592_18121_18171()
{
var return_v = RemotingErrorIdStrings.HostDoesNotSupportIASession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 18121, 18171);
return return_v;
}


System.ArgumentException
f_1592_18099_18172(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 18099, 18172);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1592_18057_18333(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 18057, 18333);
return return_v;
}


int
f_1592_18024_18334(Microsoft.PowerShell.Commands.ExitPSHostProcessCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 18024, 18334);
return 0;
}


int
f_1592_18393_18423(System.Management.Automation.Host.IHostSupportsInteractiveSession
this_param)
{
this_param.PopRunspace();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 18393, 18423);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1592,17816,18435);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,17816,18435);
}
		}

public ExitPSHostProcessCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1592,17520,18464);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1592,17520,18464);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,17520,18464);
}


static ExitPSHostProcessCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1592,17520,18464);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1592,17520,18464);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,17520,18464);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1592,17520,18464);
}
[Cmdlet(VerbsCommon.Get, "PSHostProcessInfo", DefaultParameterSetName = GetPSHostProcessInfoCommand.ProcessNameParameterSet,
        HelpUri = "https://go.microsoft.com/fwlink/?LinkId=517012")]
    [OutputType(typeof(PSHostProcessInfo))]
    public sealed class GetPSHostProcessInfoCommand : PSCmdlet
{
private const string 
ProcessParameterSet = "ProcessParameterSet"
;

private const string 
ProcessIdParameterSet = "ProcessIdParameterSet"
;

private const string 
ProcessNameParameterSet = "ProcessNameParameterSet"
;

private const string 
NamedPipePath = @"\\.\pipe\"
;

[Parameter(Position = 0, ParameterSetName = GetPSHostProcessInfoCommand.ProcessNameParameterSet)]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [ValidateNotNullOrEmpty()]
        public string[] Name
{            get;
            set;
}

[Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true, ParameterSetName = GetPSHostProcessInfoCommand.ProcessParameterSet)]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [ValidateNotNullOrEmpty()]
        public Process[] Process
{            get;
            set;
}

[Parameter(Position = 0, Mandatory = true, ParameterSetName = GetPSHostProcessInfoCommand.ProcessIdParameterSet)]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [ValidateNotNullOrEmpty()]
        public int[] Id
{            get;
            set;
}

protected override void EndProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1592,21089,22109);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,21153,21213);

IReadOnlyCollection<PSHostProcessInfo> 
processAppDomainInfo
=default(IReadOnlyCollection<PSHostProcessInfo>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,21227,22042);

switch (f_1592_21235_21251())
            {

case ProcessNameParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,21227,22042);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,21336,21417);

processAppDomainInfo = f_1592_21359_21416(f_1592_21390_21415(this, f_1592_21410_21414()));
DynAbs.Tracing.TraceSender.TraceBreak(1592,21439,21445);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,21227,22042);

case ProcessIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,21227,22042);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,21514,21572);

processAppDomainInfo = f_1592_21537_21571(f_1592_21568_21570());
DynAbs.Tracing.TraceSender.TraceBreak(1592,21594,21600);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,21227,22042);

case ProcessParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,21227,22042);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,21667,21751);

processAppDomainInfo = f_1592_21690_21750(f_1592_21721_21749(this, f_1592_21741_21748()));
DynAbs.Tracing.TraceSender.TraceBreak(1592,21773,21779);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,21227,22042);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,21227,22042);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,21829,21875);

f_1592_21829_21874(false, "Unknown parameter set.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,21897,21999);

processAppDomainInfo = f_1592_21920_21998(f_1592_21962_21997());
DynAbs.Tracing.TraceSender.TraceBreak(1592,22021,22027);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,21227,22042);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,22058,22098);

f_1592_22058_22097(this, processAppDomainInfo, true);
DynAbs.Tracing.TraceSender.TraceExitMethod(1592,21089,22109);

string
f_1592_21235_21251()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 21235, 21251);
return return_v;
}


string[]
f_1592_21410_21414()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 21410, 21414);
return return_v;
}


int[]
f_1592_21390_21415(Microsoft.PowerShell.Commands.GetPSHostProcessInfoCommand
this_param,string[]
names)
{
var return_v = this_param.GetProcIdsFromNames( names);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 21390, 21415);
return return_v;
}


System.Collections.Generic.IReadOnlyCollection<Microsoft.PowerShell.Commands.PSHostProcessInfo>
f_1592_21359_21416(int[]
procIds)
{
var return_v = GetAppDomainNamesFromProcessId( procIds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 21359, 21416);
return return_v;
}


int[]
f_1592_21568_21570()
{
var return_v = Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 21568, 21570);
return return_v;
}


System.Collections.Generic.IReadOnlyCollection<Microsoft.PowerShell.Commands.PSHostProcessInfo>
f_1592_21537_21571(int[]
procIds)
{
var return_v = GetAppDomainNamesFromProcessId( procIds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 21537, 21571);
return return_v;
}


System.Diagnostics.Process[]
f_1592_21741_21748()
{
var return_v = Process;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 21741, 21748);
return return_v;
}


int[]
f_1592_21721_21749(Microsoft.PowerShell.Commands.GetPSHostProcessInfoCommand
this_param,System.Diagnostics.Process[]
processes)
{
var return_v = this_param.GetProcIdsFromProcs( processes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 21721, 21749);
return return_v;
}


System.Collections.Generic.IReadOnlyCollection<Microsoft.PowerShell.Commands.PSHostProcessInfo>
f_1592_21690_21750(int[]
procIds)
{
var return_v = GetAppDomainNamesFromProcessId( procIds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 21690, 21750);
return return_v;
}


int
f_1592_21829_21874(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 21829, 21874);
return 0;
}


System.Collections.ObjectModel.Collection<Microsoft.PowerShell.Commands.PSHostProcessInfo>
f_1592_21962_21997()
{
var return_v = new System.Collections.ObjectModel.Collection<Microsoft.PowerShell.Commands.PSHostProcessInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 21962, 21997);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<Microsoft.PowerShell.Commands.PSHostProcessInfo>
f_1592_21920_21998(System.Collections.ObjectModel.Collection<Microsoft.PowerShell.Commands.PSHostProcessInfo>
list)
{
var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<Microsoft.PowerShell.Commands.PSHostProcessInfo>( (System.Collections.Generic.IList<Microsoft.PowerShell.Commands.PSHostProcessInfo>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 21920, 21998);
return return_v;
}


int
f_1592_22058_22097(Microsoft.PowerShell.Commands.GetPSHostProcessInfoCommand
this_param,System.Collections.Generic.IReadOnlyCollection<Microsoft.PowerShell.Commands.PSHostProcessInfo>
sendToPipeline,bool
enumerateCollection)
{
this_param.WriteObject( (object)sendToPipeline, enumerateCollection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 22058, 22097);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1592,21089,22109);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,21089,22109);
}
		}

private int[] GetProcIdsFromProcs(Process[] processes)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1592,22178,22475);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,22257,22295);

List<int> 
returnIds = f_1592_22279_22294()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,22309,22421);
foreach(Process process in f_1592_22337_22346_I(processes) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,22309,22421);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,22380,22406);

f_1592_22380_22405(                returnIds, f_1592_22394_22404(process));
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,22309,22421);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1592,1,113);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1592,1,113);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,22437,22464);

return f_1592_22444_22463(returnIds);
DynAbs.Tracing.TraceSender.TraceExitMethod(1592,22178,22475);

System.Collections.Generic.List<int>
f_1592_22279_22294()
{
var return_v = new System.Collections.Generic.List<int>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 22279, 22294);
return return_v;
}


int
f_1592_22394_22404(System.Diagnostics.Process
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 22394, 22404);
return return_v;
}


int
f_1592_22380_22405(System.Collections.Generic.List<int>
this_param,int
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 22380, 22405);
return 0;
}


System.Diagnostics.Process[]
f_1592_22337_22346_I(System.Diagnostics.Process[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 22337, 22346);
return return_v;
}


int[]
f_1592_22444_22463(System.Collections.Generic.List<int>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 22444, 22463);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1592,22178,22475);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,22178,22475);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private int[] GetProcIdsFromNames(string[] names)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1592,22487,23291);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,22561,22664) || true) && ((names == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1592, 22565, 22603)||(f_1592_22585_22597(names)== 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,22561,22664);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,22637,22649);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,22561,22664);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,22680,22718);

List<int> 
returnIds = f_1592_22702_22717()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,22732,22815);

System.Diagnostics.Process[] 
processes = f_1592_22773_22814()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,22829,23237);
foreach(string name in f_1592_22853_22858_I(names) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,22829,23237);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,22892,22976);

WildcardPattern 
namePattern = f_1592_22922_22975(name, WildcardOptions.IgnoreCase)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,22994,23222);
foreach(var proc in f_1592_23015_23024_I(processes) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,22994,23222);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,23066,23203) || true) && (f_1592_23070_23107(namePattern, f_1592_23090_23106(proc)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,23066,23203);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,23157,23180);

f_1592_23157_23179(                        returnIds, f_1592_23171_23178(proc));
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,23066,23203);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,22994,23222);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1592,1,229);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1592,1,229);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1592,22829,23237);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1592,1,409);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1592,1,409);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,23253,23280);

return f_1592_23260_23279(returnIds);
DynAbs.Tracing.TraceSender.TraceExitMethod(1592,22487,23291);

int
f_1592_22585_22597(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 22585, 22597);
return return_v;
}


System.Collections.Generic.List<int>
f_1592_22702_22717()
{
var return_v = new System.Collections.Generic.List<int>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 22702, 22717);
return return_v;
}


System.Diagnostics.Process[]
f_1592_22773_22814()
{
var return_v = System.Diagnostics.Process.GetProcesses();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 22773, 22814);
return return_v;
}


System.Management.Automation.WildcardPattern
f_1592_22922_22975(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 22922, 22975);
return return_v;
}


string
f_1592_23090_23106(System.Diagnostics.Process
this_param)
{
var return_v = this_param.ProcessName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 23090, 23106);
return return_v;
}


bool
f_1592_23070_23107(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 23070, 23107);
return return_v;
}


int
f_1592_23171_23178(System.Diagnostics.Process
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 23171, 23178);
return return_v;
}


int
f_1592_23157_23179(System.Collections.Generic.List<int>
this_param,int
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 23157, 23179);
return 0;
}


System.Diagnostics.Process[]
f_1592_23015_23024_I(System.Diagnostics.Process[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 23015, 23024);
return return_v;
}


string[]
f_1592_22853_22858_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 22853, 22858);
return return_v;
}


int[]
f_1592_23260_23279(System.Collections.Generic.List<int>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 23260, 23279);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1592,22487,23291);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,22487,23291);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static IReadOnlyCollection<PSHostProcessInfo> GetAppDomainNamesFromProcessId(int[] procIds)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1592,23807,29185);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,23932,23986);

var 
procAppDomainInfo = f_1592_23956_23985()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,24063,24108);

List<string> 
namedPipes = f_1592_24089_24107()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,24122,24180);

var 
namedPipeDirectory = f_1592_24147_24179(NamedPipePath)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,24194,24423);
foreach(var pipeFileInfo in f_1592_24223_24298_I(f_1592_24223_24298(namedPipeDirectory, NamedPipeUtils.NamedPipeNamePrefixSearch)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,24194,24423);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,24332,24408);

f_1592_24332_24407(                namedPipes, f_1592_24347_24406(f_1592_24360_24386(pipeFileInfo), f_1592_24388_24405(pipeFileInfo)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,24194,24423);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1592,1,230);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1592,1,230);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,24513,28723);
foreach(string namedPipe in f_1592_24542_24552_I(namedPipes) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,24513,28723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,24586,24693);

int 
startIndex = f_1592_24603_24692(namedPipe, NamedPipeUtils.NamedPipeNamePrefix, StringComparison.OrdinalIgnoreCase)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,24711,28708) || true) && (startIndex > -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,24711,28708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,24772,24829);

int 
pStartTimeIndex = f_1592_24794_24828(namedPipe, '.', startIndex)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,24851,28689) || true) && (pStartTimeIndex > -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,24851,28689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,24925,24984);

int 
pIdIndex = f_1592_24940_24983(namedPipe, '.', pStartTimeIndex + 1)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,25010,28666) || true) && (pIdIndex > -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,25010,28666);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,25085,25144);

int 
pAppDomainIndex = f_1592_25107_25143(namedPipe, '.', pIdIndex + 1)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,25174,28639) || true) && (pAppDomainIndex > -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,25174,28639);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,25264,25350);

string 
idString = f_1592_25282_25349(namedPipe, pIdIndex + 1, (pAppDomainIndex - pIdIndex - 1))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,25384,25396);

int 
id = -1
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,25430,26538) || true) && (f_1592_25434_25464(idString, out id))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,25430,26538);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,25607,26270) || true) && (procIds != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,25607,26270);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,25708,25727);

bool 
found = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,25769,26162);
foreach(int procId in f_1592_25792_25799_I(procIds) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,25769,26162);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,25889,26119) || true) && (id == procId)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,25889,26119);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,26003,26016);

found = true;
DynAbs.Tracing.TraceSender.TraceBreak(1592,26066,26072);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,25889,26119);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,25769,26162);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1592,1,394);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1592,1,394);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,26206,26231) || true) && (!found)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,26206,26231);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,26220,26229);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,26206,26231);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,25607,26270);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,25430,26538);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,25430,26538);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,26494,26503);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,25430,26538);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,26574,26635);

int 
pNameIndex = f_1592_26591_26634(namedPipe, '.', pAppDomainIndex + 1)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,26669,28608) || true) && (pNameIndex > -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,26669,28608);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,26762,26862);

string 
appDomainName = f_1592_26785_26861(namedPipe, pAppDomainIndex + 1, (pNameIndex - pAppDomainIndex - 1))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,26900,26951);

string 
pName = f_1592_26915_26950(namedPipe, pNameIndex + 1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,26991,27014);

Process 
process = null
;

                                    try
                                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,27138,27194);

process = f_1592_27148_27193(id);
                                    }
                                    catch (Exception)
                                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1592,27271,27453);
DynAbs.Tracing.TraceSender.TraceExitCatch(1592,27271,27453);
                                        // Do nothing if the process no longer exists
                                    }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,27493,28573) || true) && (process == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,27493,28573);
                                        try
                                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,27793,27832);

var 
pipeFile = f_1592_27808_27831(namedPipe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,27878,27896);

f_1592_27878_27895(                                            pipeFile);
                                        }
                                        catch (Exception)
                                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1592,27981,28155);
DynAbs.Tracing.TraceSender.TraceExitCatch(1592,27981,28155);
                                            // best effort to cleanup
                                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,27493,28573);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,27493,28573);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,28237,28573) || true) && (f_1592_28241_28300(f_1592_28241_28260(process), pName, StringComparison.Ordinal))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,28237,28573);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,28463,28534);

f_1592_28463_28533(                                        // only add if the process name matches
                                        procAppDomainInfo, f_1592_28485_28532(pName, id, appDomainName));
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,28237,28573);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,27493,28573);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,26669,28608);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,25174,28639);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,25010,28666);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,24851,28689);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,24711,28708);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,24513,28723);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1592,1,4211);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1592,1,4211);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,28739,29090) || true) && (f_1592_28743_28766(procAppDomainInfo)> 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,28739,29090);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,28851,28911);

var 
comparerInfo = f_1592_28870_28910(f_1592_28870_28898())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,28929,29075);

f_1592_28929_29074(                procAppDomainInfo, (firstItem, secondItem) => comparerInfo.Compare(firstItem.ProcessName, secondItem.ProcessName, CompareOptions.IgnoreCase));
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,28739,29090);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,29106,29174);

return f_1592_29113_29173(procAppDomainInfo);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1592,23807,29185);

System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSHostProcessInfo>
f_1592_23956_23985()
{
var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSHostProcessInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 23956, 23985);
return return_v;
}


System.Collections.Generic.List<string>
f_1592_24089_24107()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 24089, 24107);
return return_v;
}


System.IO.DirectoryInfo
f_1592_24147_24179(string
path)
{
var return_v = new System.IO.DirectoryInfo( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 24147, 24179);
return return_v;
}


System.Collections.Generic.IEnumerable<System.IO.FileInfo>
f_1592_24223_24298(System.IO.DirectoryInfo
this_param,string
searchPattern)
{
var return_v = this_param.EnumerateFiles( searchPattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 24223, 24298);
return return_v;
}


string
f_1592_24360_24386(System.IO.FileInfo
this_param)
{
var return_v = this_param.DirectoryName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 24360, 24386);
return return_v;
}


string
f_1592_24388_24405(System.IO.FileInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 24388, 24405);
return return_v;
}


string
f_1592_24347_24406(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 24347, 24406);
return return_v;
}


int
f_1592_24332_24407(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 24332, 24407);
return 0;
}


System.Collections.Generic.IEnumerable<System.IO.FileInfo>
f_1592_24223_24298_I(System.Collections.Generic.IEnumerable<System.IO.FileInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 24223, 24298);
return return_v;
}


int
f_1592_24603_24692(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.IndexOf( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 24603, 24692);
return return_v;
}


int
f_1592_24794_24828(string
this_param,char
value,int
startIndex)
{
var return_v = this_param.IndexOf( value, startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 24794, 24828);
return return_v;
}


int
f_1592_24940_24983(string
this_param,char
value,int
startIndex)
{
var return_v = this_param.IndexOf( value, startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 24940, 24983);
return return_v;
}


int
f_1592_25107_25143(string
this_param,char
value,int
startIndex)
{
var return_v = this_param.IndexOf( value, startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 25107, 25143);
return return_v;
}


string
f_1592_25282_25349(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 25282, 25349);
return return_v;
}


bool
f_1592_25434_25464(string
s,out int
result)
{
var return_v = int.TryParse( s, out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 25434, 25464);
return return_v;
}


int[]
f_1592_25792_25799_I(int[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 25792, 25799);
return return_v;
}


int
f_1592_26591_26634(string
this_param,char
value,int
startIndex)
{
var return_v = this_param.IndexOf( value, startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 26591, 26634);
return return_v;
}


string
f_1592_26785_26861(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 26785, 26861);
return return_v;
}


string
f_1592_26915_26950(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 26915, 26950);
return return_v;
}


System.Diagnostics.Process
f_1592_27148_27193(int
processId)
{
var return_v = System.Diagnostics.Process.GetProcessById( processId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 27148, 27193);
return return_v;
}


System.IO.FileInfo
f_1592_27808_27831(string
fileName)
{
var return_v = new System.IO.FileInfo( fileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 27808, 27831);
return return_v;
}


int
f_1592_27878_27895(System.IO.FileInfo
this_param)
{
this_param.Delete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 27878, 27895);
return 0;
}


string
f_1592_28241_28260(System.Diagnostics.Process
this_param)
{
var return_v = this_param.ProcessName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 28241, 28260);
return return_v;
}


bool
f_1592_28241_28300(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 28241, 28300);
return return_v;
}


Microsoft.PowerShell.Commands.PSHostProcessInfo
f_1592_28485_28532(string
processName,int
processId,string
appDomainName)
{
var return_v = new Microsoft.PowerShell.Commands.PSHostProcessInfo( processName, processId, appDomainName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 28485, 28532);
return return_v;
}


int
f_1592_28463_28533(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSHostProcessInfo>
this_param,Microsoft.PowerShell.Commands.PSHostProcessInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 28463, 28533);
return 0;
}


System.Collections.Generic.List<string>
f_1592_24542_24552_I(System.Collections.Generic.List<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 24542, 24552);
return return_v;
}


int
f_1592_28743_28766(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSHostProcessInfo>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 28743, 28766);
return return_v;
}


System.Globalization.CultureInfo
f_1592_28870_28898()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 28870, 28898);
return return_v;
}


System.Globalization.CompareInfo
f_1592_28870_28910(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.CompareInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1592, 28870, 28910);
return return_v;
}


int
f_1592_28929_29074(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSHostProcessInfo>
this_param,System.Comparison<Microsoft.PowerShell.Commands.PSHostProcessInfo>
comparison)
{
this_param.Sort( comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 28929, 29074);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<Microsoft.PowerShell.Commands.PSHostProcessInfo>
f_1592_29113_29173(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSHostProcessInfo>
list)
{
var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<Microsoft.PowerShell.Commands.PSHostProcessInfo>( (System.Collections.Generic.IList<Microsoft.PowerShell.Commands.PSHostProcessInfo>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 29113, 29173);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1592,23807,29185);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,23807,29185);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public GetPSHostProcessInfoCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1592,18684,29214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,19777,20092);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,20173,20532);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,20619,20945);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1592,18684,29214);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,18684,29214);
}


static GetPSHostProcessInfoCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1592,18684,29214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,19052,19095);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,19127,19174);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,19206,19257);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,19599,19627);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1592,18684,29214);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,18684,29214);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1592,18684,29214);
}
public sealed class PSHostProcessInfo
{
public string ProcessName
{            get;
            private set;
}

public int ProcessId
{            get;
            private set;
}

public string AppDomainName
{            get;
            private set;
}

private PSHostProcessInfo() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1592,30272,30303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,29513,29604);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,29691,29777);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,29890,29983);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1592,30272,30303);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1592,30272,30303);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,30272,30303);
}
		}

internal PSHostProcessInfo(string processName, int processId, string appDomainName)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1592,30588,31394);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,29513,29604);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,29691,29777);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,29890,29983);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,30696,30788) || true) && (f_1592_30700_30733(processName))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,30696,30788);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,30737,30786);

throw f_1592_30743_30785("processName");
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,30696,30788);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,30804,30900) || true) && (f_1592_30808_30843(appDomainName))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1592,30804,30900);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,30847,30898);

throw f_1592_30853_30897("appDomainName");
DynAbs.Tracing.TraceSender.TraceExitCondition(1592,30804,30900);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,31262,31293);

this.ProcessName = processName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,31307,31334);

this.ProcessId = processId;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1592,31348,31383);

this.AppDomainName = appDomainName;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1592,30588,31394);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1592,30588,31394);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,30588,31394);
}
		}

static PSHostProcessInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1592,29352,31423);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1592,29352,31423);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1592,29352,31423);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1592,29352,31423);

bool
f_1592_30700_30733(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 30700, 30733);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1592_30743_30785(string
paramName)
{
var return_v = new System.Management.Automation.PSArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 30743, 30785);
return return_v;
}


bool
f_1592_30808_30843(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 30808, 30843);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1592_30853_30897(string
paramName)
{
var return_v = new System.Management.Automation.PSArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1592, 30853, 30897);
return return_v;
}

}

    }
