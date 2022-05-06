// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting.Internal;
using System.Management.Automation.Runspaces;

namespace Microsoft.PowerShell.Commands
{
[SuppressMessage("Microsoft.PowerShell", "PS1012:CallShouldProcessOnlyIfDeclaringSupport")]
    [Cmdlet(VerbsDiagnostic.Debug, "Job", SupportsShouldProcess = true, DefaultParameterSetName = DebugJobCommand.JobParameterSet,
        HelpUri = "https://go.microsoft.com/fwlink/?LinkId=330208")]
    public sealed class DebugJobCommand : PSCmdlet
{
private const string 
JobParameterSet = "JobParameterSet"
;

private const string 
JobNameParameterSet = "JobNameParameterSet"
;

private const string 
JobIdParameterSet = "JobIdParameterSet"
;

private const string 
JobInstanceIdParameterSet = "JobInstanceIdParameterSet"
;

private Job _job;

private Debugger _debugger;

private PSDataCollection<PSStreamObject> _debugCollection;

[Parameter(Position = 0,
                   Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ValueFromPipeline = true,
                   ParameterSetName = DebugJobCommand.JobParameterSet)]
        public Job Job
{            get;
            set;
}

[Parameter(Position = 0,
                   Mandatory = true,
                   ParameterSetName = DebugJobCommand.JobNameParameterSet)]
        public string Name
{            get;
            set;
}

[Parameter(Position = 0,
                   Mandatory = true,
                   ParameterSetName = DebugJobCommand.JobIdParameterSet)]
        public int Id
{            get;
            set;
}

[Parameter(Position = 0,
                   Mandatory = true,
                   ParameterSetName = DebugJobCommand.JobInstanceIdParameterSet)]
        public Guid InstanceId
{            get;
            set;
}

[Experimental("Microsoft.PowerShell.Utility.PSManageBreakpointsInRunspace", ExperimentAction.Show)]
        [Parameter]
        public SwitchParameter BreakAll {get; set; }

protected override void EndProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1590,4060,7048);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,4124,4718);

switch (f_1590_4132_4148())
            {

case DebugJobCommand.JobParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,4124,4718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,4241,4252);

_job = f_1590_4248_4251();
DynAbs.Tracing.TraceSender.TraceBreak(1590,4274,4280);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,4124,4718);

case DebugJobCommand.JobNameParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,4124,4718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,4363,4389);

_job = f_1590_4370_4388(this, f_1590_4383_4387());
DynAbs.Tracing.TraceSender.TraceBreak(1590,4411,4417);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,4124,4718);

case DebugJobCommand.JobIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,4124,4718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,4498,4520);

_job = f_1590_4505_4519(this, f_1590_4516_4518());
DynAbs.Tracing.TraceSender.TraceBreak(1590,4542,4548);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,4124,4718);

case DebugJobCommand.JobInstanceIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,4124,4718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,4637,4675);

_job = f_1590_4644_4674(this, f_1590_4663_4673());
DynAbs.Tracing.TraceSender.TraceBreak(1590,4697,4703);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,4124,4718);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,4734,4842) || true) && (!f_1590_4739_4786(this, f_1590_4753_4762(_job), VerbsDiagnostic.Debug))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,4734,4842);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,4820,4827);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,4734,4842);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,4858,4908);

Runspace 
runspace = f_1590_4878_4907()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,4922,5354) || true) && (runspace == null ||(DynAbs.Tracing.TraceSender.Expression_False(1590, 4926, 4971)||f_1590_4946_4963(runspace)== null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,4922,5354);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,5005,5339);

f_1590_5005_5338(this, f_1590_5049_5315(f_1590_5091_5175(f_1590_5123_5174()), "DebugJobNoHostDebugger", ErrorCategory.InvalidOperation, this));
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,4922,5354);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,5370,5865) || true) && ((f_1590_5375_5402(f_1590_5375_5392(runspace))== DebugModes.Default) ||(DynAbs.Tracing.TraceSender.Expression_False(1590, 5374, 5477)||(f_1590_5430_5457(f_1590_5430_5447(runspace))== DebugModes.None)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,5370,5865);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,5511,5850);

f_1590_5511_5849(this, f_1590_5555_5826(f_1590_5597_5686(f_1590_5629_5685()), "DebugJobWrongDebugMode", ErrorCategory.InvalidOperation, this));
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,5370,5865);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,5881,6304) || true) && (f_1590_5885_5894(this)== null ||(DynAbs.Tracing.TraceSender.Expression_False(1590, 5885, 5926)||f_1590_5906_5918(f_1590_5906_5915(this))== null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,5881,6304);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,5960,6289);

f_1590_5960_6288(this, f_1590_6004_6265(f_1590_6046_6124(f_1590_6078_6123()), "DebugJobNoHostAvailable", ErrorCategory.InvalidOperation, this));
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,5881,6304);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,6320,6724) || true) && (!f_1590_6325_6348(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,6320,6724);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,6382,6709);

f_1590_6382_6708(this, f_1590_6426_6685(f_1590_6468_6538(f_1590_6500_6537()), "DebugJobNoDebuggableJobsFound", ErrorCategory.InvalidOperation, this));
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,6320,6724);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,6802,6832);

_debugger = f_1590_6814_6831(runspace);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,6846,6891);

f_1590_6846_6890(            _debugger, _job, breakAll: f_1590_6881_6889());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,7011,7037);

f_1590_7011_7036(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1590,4060,7048);

string
f_1590_4132_4148()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 4132, 4148);
return return_v;
}


System.Management.Automation.Job
f_1590_4248_4251()
{
var return_v = Job;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 4248, 4251);
return return_v;
}


string
f_1590_4383_4387()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 4383, 4387);
return return_v;
}


System.Management.Automation.Job
f_1590_4370_4388(Microsoft.PowerShell.Commands.DebugJobCommand
this_param,string
name)
{
var return_v = this_param.GetJobByName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 4370, 4388);
return return_v;
}


int
f_1590_4516_4518()
{
var return_v = Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 4516, 4518);
return return_v;
}


System.Management.Automation.Job
f_1590_4505_4519(Microsoft.PowerShell.Commands.DebugJobCommand
this_param,int
id)
{
var return_v = this_param.GetJobById( id);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 4505, 4519);
return return_v;
}


System.Guid
f_1590_4663_4673()
{
var return_v = InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 4663, 4673);
return return_v;
}


System.Management.Automation.Job
f_1590_4644_4674(Microsoft.PowerShell.Commands.DebugJobCommand
this_param,System.Guid
instanceId)
{
var return_v = this_param.GetJobByInstanceId( instanceId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 4644, 4674);
return return_v;
}


string
f_1590_4753_4762(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 4753, 4762);
return return_v;
}


bool
f_1590_4739_4786(Microsoft.PowerShell.Commands.DebugJobCommand
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 4739, 4786);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1590_4878_4907()
{
var return_v = LocalRunspace.DefaultRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 4878, 4907);
return return_v;
}


System.Management.Automation.Debugger
f_1590_4946_4963(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.Debugger ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 4946, 4963);
return return_v;
}


string
f_1590_5123_5174()
{
var return_v = RemotingErrorIdStrings.CannotDebugJobNoHostDebugger;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 5123, 5174);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1590_5091_5175(string
message)
{
var return_v = new System.Management.Automation.PSInvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 5091, 5175);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1590_5049_5315(System.Management.Automation.PSInvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,Microsoft.PowerShell.Commands.DebugJobCommand
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 5049, 5315);
return return_v;
}


int
f_1590_5005_5338(Microsoft.PowerShell.Commands.DebugJobCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 5005, 5338);
return 0;
}


System.Management.Automation.Debugger
f_1590_5375_5392(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.Debugger;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 5375, 5392);
return return_v;
}


System.Management.Automation.DebugModes
f_1590_5375_5402(System.Management.Automation.Debugger
this_param)
{
var return_v = this_param.DebugMode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 5375, 5402);
return return_v;
}


System.Management.Automation.Debugger
f_1590_5430_5447(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.Debugger;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 5430, 5447);
return return_v;
}


System.Management.Automation.DebugModes
f_1590_5430_5457(System.Management.Automation.Debugger
this_param)
{
var return_v = this_param.DebugMode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 5430, 5457);
return return_v;
}


string
f_1590_5629_5685()
{
var return_v = RemotingErrorIdStrings.CannotDebugJobInvalidDebuggerMode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 5629, 5685);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1590_5597_5686(string
message)
{
var return_v = new System.Management.Automation.PSInvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 5597, 5686);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1590_5555_5826(System.Management.Automation.PSInvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,Microsoft.PowerShell.Commands.DebugJobCommand
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 5555, 5826);
return return_v;
}


int
f_1590_5511_5849(Microsoft.PowerShell.Commands.DebugJobCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 5511, 5849);
return 0;
}


System.Management.Automation.Host.PSHost
f_1590_5885_5894(Microsoft.PowerShell.Commands.DebugJobCommand
this_param)
{
var return_v = this_param.Host ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 5885, 5894);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1590_5906_5915(Microsoft.PowerShell.Commands.DebugJobCommand
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 5906, 5915);
return return_v;
}


System.Management.Automation.Host.PSHostUserInterface
f_1590_5906_5918(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.UI ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 5906, 5918);
return return_v;
}


string
f_1590_6078_6123()
{
var return_v = RemotingErrorIdStrings.CannotDebugJobNoHostUI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 6078, 6123);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1590_6046_6124(string
message)
{
var return_v = new System.Management.Automation.PSInvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 6046, 6124);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1590_6004_6265(System.Management.Automation.PSInvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,Microsoft.PowerShell.Commands.DebugJobCommand
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 6004, 6265);
return return_v;
}


int
f_1590_5960_6288(Microsoft.PowerShell.Commands.DebugJobCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 5960, 6288);
return 0;
}


bool
f_1590_6325_6348(Microsoft.PowerShell.Commands.DebugJobCommand
this_param)
{
var return_v = this_param.CheckForDebuggableJob();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 6325, 6348);
return return_v;
}


string
f_1590_6500_6537()
{
var return_v = DebuggerStrings.NoDebuggableJobsFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 6500, 6537);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1590_6468_6538(string
message)
{
var return_v = new System.Management.Automation.PSInvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 6468, 6538);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1590_6426_6685(System.Management.Automation.PSInvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,Microsoft.PowerShell.Commands.DebugJobCommand
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 6426, 6685);
return return_v;
}


int
f_1590_6382_6708(Microsoft.PowerShell.Commands.DebugJobCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 6382, 6708);
return 0;
}


System.Management.Automation.Debugger
f_1590_6814_6831(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.Debugger;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 6814, 6831);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1590_6881_6889()
{
var return_v = BreakAll;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 6881, 6889);
return return_v;
}


int
f_1590_6846_6890(System.Management.Automation.Debugger
this_param,System.Management.Automation.Job
job,System.Management.Automation.SwitchParameter
breakAll)
{
this_param.DebugJob( job, breakAll: (bool)breakAll);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 6846, 6890);
return 0;
}


int
f_1590_7011_7036(Microsoft.PowerShell.Commands.DebugJobCommand
this_param)
{
this_param.WaitAndReceiveJobOutput();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 7011, 7036);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1590,4060,7048);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1590,4060,7048);
}
		}

protected override void StopProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1590,7137,7658);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,7240,7270);

Debugger 
debugger = _debugger
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,7284,7401) || true) && ((debugger != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1590, 7288, 7324)&&(_job != null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,7284,7401);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,7358,7386);

f_1590_7358_7385(                debugger, _job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,7284,7401);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,7462,7530);

PSDataCollection<PSStreamObject> 
debugCollection = _debugCollection
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,7544,7647) || true) && (debugCollection != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,7544,7647);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,7605,7632);

f_1590_7605_7631(                debugCollection);
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,7544,7647);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1590,7137,7658);

int
f_1590_7358_7385(System.Management.Automation.Debugger
this_param,System.Management.Automation.Job
job)
{
this_param.StopDebugJob( job);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 7358, 7385);
return 0;
}


int
f_1590_7605_7631(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
this_param)
{
this_param.Complete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 7605, 7631);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1590,7137,7658);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1590,7137,7658);
}
		}

private bool CheckForDebuggableJob()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1590,7944,8519);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,8049,8098);

bool 
debuggableJobFound = f_1590_8075_8097(this, _job)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,8099,8100);
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,8116,8466) || true) && (!debuggableJobFound)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,8116,8466);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,8255,8451);
foreach(var cJob in f_1590_8276_8290_I(f_1590_8276_8290(_job)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,8255,8451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,8332,8376);

debuggableJobFound = f_1590_8353_8375(this, cJob);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,8398,8432) || true) && (debuggableJobFound)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,8398,8432);
DynAbs.Tracing.TraceSender.TraceBreak(1590,8424,8430);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,8398,8432);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,8255,8451);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1590,1,197);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1590,1,197);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1590,8116,8466);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,8482,8508);

return debuggableJobFound;
DynAbs.Tracing.TraceSender.TraceExitMethod(1590,7944,8519);

bool
f_1590_8075_8097(Microsoft.PowerShell.Commands.DebugJobCommand
this_param,System.Management.Automation.Job
job)
{
var return_v = this_param.GetJobDebuggable( job);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 8075, 8097);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1590_8276_8290(System.Management.Automation.Job
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 8276, 8290);
return return_v;
}


bool
f_1590_8353_8375(Microsoft.PowerShell.Commands.DebugJobCommand
this_param,System.Management.Automation.Job
job)
{
var return_v = this_param.GetJobDebuggable( job);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 8353, 8375);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1590_8276_8290_I(System.Collections.Generic.IList<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 8276, 8290);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1590,7944,8519);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1590,7944,8519);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool GetJobDebuggable(Job job)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1590,8531,8838);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,8594,8798) || true) && (job is IJobDebugger)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,8594,8798);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,8651,8783);

return ((f_1590_8660_8682(f_1590_8660_8676(job))== JobState.Running) ||(DynAbs.Tracing.TraceSender.Expression_False(1590, 8659, 8781)||                        (f_1590_8733_8755(f_1590_8733_8749(job))== JobState.AtBreakpoint)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,8594,8798);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,8814,8827);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1590,8531,8838);

System.Management.Automation.JobStateInfo
f_1590_8660_8676(System.Management.Automation.Job
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 8660, 8676);
return return_v;
}


System.Management.Automation.JobState
f_1590_8660_8682(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 8660, 8682);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1590_8733_8749(System.Management.Automation.Job
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 8733, 8749);
return return_v;
}


System.Management.Automation.JobState
f_1590_8733_8755(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 8733, 8755);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1590,8531,8838);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1590,8531,8838);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void WaitAndReceiveJobOutput()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1590,8850,9924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,8913,8971);

_debugCollection = f_1590_8932_8970();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,8985,9028);

_debugCollection.BlockingEnumerator = true;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,9080,9099);

f_1590_9080_9098(this);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,9252,9486);
foreach(var streamItem in f_1590_9279_9295_I(_debugCollection) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,9252,9486);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,9337,9467) || true) && (streamItem != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,9337,9467);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,9409,9444);

f_1590_9409_9443(                        streamItem, this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,9337,9467);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,9252,9486);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1590,1,235);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1590,1,235);
}            }
            catch (Exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1590,9515,9780);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,9613,9739) || true) && (!f_1590_9618_9663(_job, f_1590_9639_9662(f_1590_9639_9656(_job))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,9613,9739);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,9705,9720);

f_1590_9705_9719(                    _job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,9613,9739);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,9759,9765);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1590,9515,9780);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1590,9794,9913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,9834,9856);

f_1590_9834_9855(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,9874,9898);

_debugCollection = null;
DynAbs.Tracing.TraceSender.TraceExitFinally(1590,9794,9913);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1590,8850,9924);

System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1590_8932_8970()
{
var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 8932, 8970);
return return_v;
}


int
f_1590_9080_9098(Microsoft.PowerShell.Commands.DebugJobCommand
this_param)
{
this_param.AddEventHandlers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 9080, 9098);
return 0;
}


int
f_1590_9409_9443(System.Management.Automation.Remoting.Internal.PSStreamObject
this_param,Microsoft.PowerShell.Commands.DebugJobCommand
cmdlet)
{
this_param.WriteStreamObject( (System.Management.Automation.Cmdlet)cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 9409, 9443);
return 0;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1590_9279_9295_I(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 9279, 9295);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1590_9639_9656(System.Management.Automation.Job
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 9639, 9656);
return return_v;
}


System.Management.Automation.JobState
f_1590_9639_9662(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 9639, 9662);
return return_v;
}


bool
f_1590_9618_9663(System.Management.Automation.Job
this_param,System.Management.Automation.JobState
state)
{
var return_v = this_param.IsFinishedState( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 9618, 9663);
return return_v;
}


int
f_1590_9705_9719(System.Management.Automation.Job
this_param)
{
this_param.StopJob();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 9705, 9719);
return 0;
}


int
f_1590_9834_9855(Microsoft.PowerShell.Commands.DebugJobCommand
this_param)
{
this_param.RemoveEventHandlers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 9834, 9855);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1590,8850,9924);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1590,8850,9924);
}
		}

private void HandleJobStateChangedEvent(object sender, JobStateEventArgs stateChangedArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1590,9936,10237);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,10051,10075);

Job 
job = sender as Job
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,10089,10226) || true) && (f_1590_10093_10149(job, f_1590_10113_10148(f_1590_10113_10142(stateChangedArgs))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,10089,10226);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,10183,10211);

f_1590_10183_10210(                _debugCollection);
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,10089,10226);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1590,9936,10237);

System.Management.Automation.JobStateInfo
f_1590_10113_10142(System.Management.Automation.JobStateEventArgs
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 10113, 10142);
return return_v;
}


System.Management.Automation.JobState
f_1590_10113_10148(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 10113, 10148);
return return_v;
}


bool
f_1590_10093_10149(System.Management.Automation.Job
this_param,System.Management.Automation.JobState
state)
{
var return_v = this_param.IsFinishedState( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 10093, 10149);
return return_v;
}


int
f_1590_10183_10210(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
this_param)
{
this_param.Complete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 10183, 10210);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1590,9936,10237);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1590,9936,10237);
}
		}

private void HandleResultsDataAdding(object sender, DataAddingEventArgs dataAddingArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1590,10249,10795);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,10361,10784) || true) && (f_1590_10365_10388(_debugCollection))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,10361,10784);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,10422,10495);

PSStreamObject 
streamObject = f_1590_10452_10476(dataAddingArgs)as PSStreamObject
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,10513,10769) || true) && (streamObject != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,10513,10769);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,10631,10666);

f_1590_10631_10665(                        _debugCollection, streamObject);
                    }
                    catch (PSInvalidOperationException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1590,10711,10750);
DynAbs.Tracing.TraceSender.TraceExitCatch(1590,10711,10750);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,10513,10769);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,10361,10784);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1590,10249,10795);

bool
f_1590_10365_10388(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
this_param)
{
var return_v = this_param.IsOpen;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 10365, 10388);
return return_v;
}


object
f_1590_10452_10476(System.Management.Automation.DataAddingEventArgs
this_param)
{
var return_v = this_param.ItemAdded ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 10452, 10476);
return return_v;
}


int
f_1590_10631_10665(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
this_param,System.Management.Automation.Remoting.Internal.PSStreamObject
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 10631, 10665);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1590,10249,10795);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1590,10249,10795);
}
		}

private void HandleDebuggerNestedDebuggingCancelledEvent(object sender, EventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1590,10807,10944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,10916,10933);

f_1590_10916_10932(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1590,10807,10944);

int
f_1590_10916_10932(Microsoft.PowerShell.Commands.DebugJobCommand
this_param)
{
this_param.StopProcessing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 10916, 10932);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1590,10807,10944);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1590,10807,10944);
}
		}

private void AddEventHandlers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1590,10956,11678);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,11012,11060);

_job.StateChanged += HandleJobStateChangedEvent;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,11074,11161);

_debugger.NestedDebuggingCancelledEvent += HandleDebuggerNestedDebuggingCancelledEvent;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,11177,11667) || true) && (f_1590_11181_11201(f_1590_11181_11195(_job))== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,11177,11667);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,11314,11365);

f_1590_11314_11326(_job).DataAdding += HandleResultsDataAdding;
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,11177,11667);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,11177,11667);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,11497,11652);
foreach(var childJob in f_1590_11522_11536_I(f_1590_11522_11536(_job)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,11497,11652);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,11578,11633);

f_1590_11578_11594(childJob).DataAdding += HandleResultsDataAdding;
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,11497,11652);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1590,1,156);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1590,1,156);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1590,11177,11667);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1590,10956,11678);

System.Collections.Generic.IList<System.Management.Automation.Job>
f_1590_11181_11195(System.Management.Automation.Job
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 11181, 11195);
return return_v;
}


int
f_1590_11181_11201(System.Collections.Generic.IList<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 11181, 11201);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1590_11314_11326(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Results;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 11314, 11326);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1590_11522_11536(System.Management.Automation.Job
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 11522, 11536);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1590_11578_11594(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Results;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 11578, 11594);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1590_11522_11536_I(System.Collections.Generic.IList<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 11522, 11536);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1590,10956,11678);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1590,10956,11678);
}
		}

private void RemoveEventHandlers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1590,11690,12409);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,11749,11797);

_job.StateChanged -= HandleJobStateChangedEvent;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,11811,11898);

_debugger.NestedDebuggingCancelledEvent -= HandleDebuggerNestedDebuggingCancelledEvent;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,11914,12398) || true) && (f_1590_11918_11938(f_1590_11918_11932(_job))== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,11914,12398);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,12041,12092);

f_1590_12041_12053(_job).DataAdding -= HandleResultsDataAdding;
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,11914,12398);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,11914,12398);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,12228,12383);
foreach(var childJob in f_1590_12253_12267_I(f_1590_12253_12267(_job)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,12228,12383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,12309,12364);

f_1590_12309_12325(childJob).DataAdding -= HandleResultsDataAdding;
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,12228,12383);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1590,1,156);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1590,1,156);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1590,11914,12398);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1590,11690,12409);

System.Collections.Generic.IList<System.Management.Automation.Job>
f_1590_11918_11932(System.Management.Automation.Job
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 11918, 11932);
return return_v;
}


int
f_1590_11918_11938(System.Collections.Generic.IList<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 11918, 11938);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1590_12041_12053(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Results;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 12041, 12053);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1590_12253_12267(System.Management.Automation.Job
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 12253, 12267);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1590_12309_12325(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Results;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 12309, 12325);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1590_12253_12267_I(System.Collections.Generic.IList<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 12253, 12267);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1590,11690,12409);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1590,11690,12409);
}
		}

private Job GetJobByName(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1590,12421,14107);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,12530,12564);

List<Job> 
jobs1 = f_1590_12548_12563()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,12578,12702);

WildcardPattern 
pattern =
f_1590_12621_12701(name, WildcardOptions.IgnoreCase | WildcardOptions.Compiled)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,12718,12910);
foreach(Job job in f_1590_12738_12756_I(f_1590_12738_12756(f_1590_12738_12751())) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,12718,12910);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,12790,12895) || true) && (f_1590_12794_12819(pattern, f_1590_12810_12818(job)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,12790,12895);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,12861,12876);

f_1590_12861_12875(                    jobs1, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,12790,12895);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,12718,12910);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1590,1,193);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1590,1,193);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,12970,13053);

List<Job2> 
jobs2 = f_1590_12989_13052(f_1590_12989_12999(), name, this, false, false, false, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,13069,13110);

int 
jobCount = f_1590_13084_13095(jobs1)+ f_1590_13098_13109(jobs2)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,13124,13237) || true) && (jobCount == 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,13124,13237);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,13175,13222);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1590, 13182, 13199)||(((f_1590_13183_13194(jobs1)> 0) &&DynAbs.Tracing.TraceSender.Conditional_F2(1590, 13202, 13210))||DynAbs.Tracing.TraceSender.Conditional_F3(1590, 13213, 13221)))?f_1590_13202_13210(jobs1, 0):f_1590_13213_13221(jobs2, 0);
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,13124,13237);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,13253,13717) || true) && (jobCount > 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,13253,13717);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,13303,13670);

f_1590_13303_13669(this, f_1590_13347_13646(f_1590_13389_13495(f_1590_13421_13494(f_1590_13439_13487(), name)), "DebugJobFoundMultipleJobsWithName", ErrorCategory.InvalidOperation, this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,13690,13702);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,13253,13717);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,13733,14068);

f_1590_13733_14067(this, f_1590_13773_14048(f_1590_13811_13913(f_1590_13843_13912(f_1590_13861_13905(), name)), "DebugJobCannotFindJobWithName", ErrorCategory.InvalidOperation, this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,14084,14096);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1590,12421,14107);

System.Collections.Generic.List<System.Management.Automation.Job>
f_1590_12548_12563()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 12548, 12563);
return return_v;
}


System.Management.Automation.WildcardPattern
f_1590_12621_12701(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 12621, 12701);
return return_v;
}


System.Management.Automation.JobRepository
f_1590_12738_12751()
{
var return_v = JobRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 12738, 12751);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1590_12738_12756(System.Management.Automation.JobRepository
this_param)
{
var return_v = this_param.Jobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 12738, 12756);
return return_v;
}


string
f_1590_12810_12818(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 12810, 12818);
return return_v;
}


bool
f_1590_12794_12819(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 12794, 12819);
return return_v;
}


int
f_1590_12861_12875(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 12861, 12875);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1590_12738_12756_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 12738, 12756);
return return_v;
}


System.Management.Automation.JobManager
f_1590_12989_12999()
{
var return_v = JobManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 12989, 12999);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job2>
f_1590_12989_13052(System.Management.Automation.JobManager
this_param,string
name,Microsoft.PowerShell.Commands.DebugJobCommand
cmdlet,bool
writeErrorOnException,bool
writeObject,bool
recurse,string[]
jobSourceAdapterTypes)
{
var return_v = this_param.GetJobsByName( name, (System.Management.Automation.Cmdlet)cmdlet, writeErrorOnException, writeObject, recurse, jobSourceAdapterTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 12989, 13052);
return return_v;
}


int
f_1590_13084_13095(System.Collections.Generic.List<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 13084, 13095);
return return_v;
}


int
f_1590_13098_13109(System.Collections.Generic.List<System.Management.Automation.Job2>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 13098, 13109);
return return_v;
}


int
f_1590_13183_13194(System.Collections.Generic.List<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 13183, 13194);
return return_v;
}


System.Management.Automation.Job
f_1590_13202_13210(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 13202, 13210);
return return_v;
}


System.Management.Automation.Job2
f_1590_13213_13221(System.Collections.Generic.List<System.Management.Automation.Job2>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 13213, 13221);
return return_v;
}


string
f_1590_13439_13487()
{
var return_v = RemotingErrorIdStrings.FoundMultipleJobsWithName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 13439, 13487);
return return_v;
}


string
f_1590_13421_13494(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 13421, 13494);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1590_13389_13495(string
message)
{
var return_v = new System.Management.Automation.PSInvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 13389, 13495);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1590_13347_13646(System.Management.Automation.PSInvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,Microsoft.PowerShell.Commands.DebugJobCommand
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 13347, 13646);
return return_v;
}


int
f_1590_13303_13669(Microsoft.PowerShell.Commands.DebugJobCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 13303, 13669);
return 0;
}


string
f_1590_13861_13905()
{
var return_v = RemotingErrorIdStrings.CannotFindJobWithName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 13861, 13905);
return return_v;
}


string
f_1590_13843_13912(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 13843, 13912);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1590_13811_13913(string
message)
{
var return_v = new System.Management.Automation.PSInvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 13811, 13913);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1590_13773_14048(System.Management.Automation.PSInvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,Microsoft.PowerShell.Commands.DebugJobCommand
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 13773, 14048);
return return_v;
}


int
f_1590_13733_14067(Microsoft.PowerShell.Commands.DebugJobCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 13733, 14067);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1590,12421,14107);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1590,12421,14107);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Job GetJobById(int id)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1590,14119,15668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,14221,14255);

List<Job> 
jobs1 = f_1590_14239_14254()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,14269,14448);
foreach(Job job in f_1590_14289_14307_I(f_1590_14289_14307(f_1590_14289_14302())) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,14269,14448);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,14341,14433) || true) && (f_1590_14345_14351(job)== id)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,14341,14433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,14399,14414);

f_1590_14399_14413(                    jobs1, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,14341,14433);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,14269,14448);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1590,1,180);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1590,1,180);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,14508,14572);

Job 
job2 = f_1590_14519_14571(f_1590_14519_14529(), id, this, false, false, false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,14588,15062) || true) && ((f_1590_14593_14604(jobs1)== 0) &&(DynAbs.Tracing.TraceSender.Expression_True(1590, 14592, 14628)&&(job2 == null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,14588,15062);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,14662,15015);

f_1590_14662_15014(this, f_1590_14706_14991(f_1590_14748_14846(f_1590_14780_14845(f_1590_14798_14840(), id)), "DebugJobCannotFindJobWithId", ErrorCategory.InvalidOperation, this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,15035,15047);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,14588,15062);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,15078,15598) || true) && ((f_1590_15083_15094(jobs1)> 1) ||(DynAbs.Tracing.TraceSender.Expression_False(1590, 15082, 15156)||                (f_1590_15121_15132(jobs1)== 1) &&(DynAbs.Tracing.TraceSender.Expression_True(1590, 15120, 15156)&&(job2 != null))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,15078,15598);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,15190,15551);

f_1590_15190_15550(this, f_1590_15234_15527(f_1590_15276_15378(f_1590_15308_15377(f_1590_15326_15372(), id)), "DebugJobFoundMultipleJobsWithId", ErrorCategory.InvalidOperation, this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,15571,15583);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,15078,15598);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,15614,15657);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1590, 15621, 15638)||(((f_1590_15622_15633(jobs1)> 0) &&DynAbs.Tracing.TraceSender.Conditional_F2(1590, 15641, 15649))||DynAbs.Tracing.TraceSender.Conditional_F3(1590, 15652, 15656)))?f_1590_15641_15649(jobs1, 0):job2;
DynAbs.Tracing.TraceSender.TraceExitMethod(1590,14119,15668);

System.Collections.Generic.List<System.Management.Automation.Job>
f_1590_14239_14254()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 14239, 14254);
return return_v;
}


System.Management.Automation.JobRepository
f_1590_14289_14302()
{
var return_v = JobRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 14289, 14302);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1590_14289_14307(System.Management.Automation.JobRepository
this_param)
{
var return_v = this_param.Jobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 14289, 14307);
return return_v;
}


int
f_1590_14345_14351(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Id ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 14345, 14351);
return return_v;
}


int
f_1590_14399_14413(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 14399, 14413);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1590_14289_14307_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 14289, 14307);
return return_v;
}


System.Management.Automation.JobManager
f_1590_14519_14529()
{
var return_v = JobManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 14519, 14529);
return return_v;
}


System.Management.Automation.Job2
f_1590_14519_14571(System.Management.Automation.JobManager
this_param,int
id,Microsoft.PowerShell.Commands.DebugJobCommand
cmdlet,bool
writeErrorOnException,bool
writeObject,bool
recurse)
{
var return_v = this_param.GetJobById( id, (System.Management.Automation.Cmdlet)cmdlet, writeErrorOnException, writeObject, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 14519, 14571);
return return_v;
}


int
f_1590_14593_14604(System.Collections.Generic.List<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 14593, 14604);
return return_v;
}


string
f_1590_14798_14840()
{
var return_v = RemotingErrorIdStrings.CannotFindJobWithId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 14798, 14840);
return return_v;
}


string
f_1590_14780_14845(string
formatSpec,int
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 14780, 14845);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1590_14748_14846(string
message)
{
var return_v = new System.Management.Automation.PSInvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 14748, 14846);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1590_14706_14991(System.Management.Automation.PSInvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,Microsoft.PowerShell.Commands.DebugJobCommand
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 14706, 14991);
return return_v;
}


int
f_1590_14662_15014(Microsoft.PowerShell.Commands.DebugJobCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 14662, 15014);
return 0;
}


int
f_1590_15083_15094(System.Collections.Generic.List<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 15083, 15094);
return return_v;
}


int
f_1590_15121_15132(System.Collections.Generic.List<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 15121, 15132);
return return_v;
}


string
f_1590_15326_15372()
{
var return_v = RemotingErrorIdStrings.FoundMultipleJobsWithId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 15326, 15372);
return return_v;
}


string
f_1590_15308_15377(string
formatSpec,int
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 15308, 15377);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1590_15276_15378(string
message)
{
var return_v = new System.Management.Automation.PSInvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 15276, 15378);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1590_15234_15527(System.Management.Automation.PSInvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,Microsoft.PowerShell.Commands.DebugJobCommand
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 15234, 15527);
return return_v;
}


int
f_1590_15190_15550(Microsoft.PowerShell.Commands.DebugJobCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 15190, 15550);
return 0;
}


int
f_1590_15622_15633(System.Collections.Generic.List<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 15622, 15633);
return return_v;
}


System.Management.Automation.Job
f_1590_15641_15649(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 15641, 15649);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1590,14119,15668);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1590,14119,15668);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Job GetJobByInstanceId(Guid instanceId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1590,15680,16630);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,15799,15990);
foreach(Job job in f_1590_15819_15837_I(f_1590_15819_15837(f_1590_15819_15832())) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,15799,15990);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,15871,15975) || true) && (f_1590_15875_15889(job)== instanceId)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,15871,15975);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,15945,15956);

return job;
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,15871,15975);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,15799,15990);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1590,1,192);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1590,1,192);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,16050,16131);

Job2 
job2 = f_1590_16062_16130(f_1590_16062_16072(), instanceId, this, false, false, false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,16145,16222) || true) && (job2 != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1590,16145,16222);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,16195,16207);

return job2;
DynAbs.Tracing.TraceSender.TraceExitCondition(1590,16145,16222);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,16238,16591);

f_1590_16238_16590(this, f_1590_16278_16571(f_1590_16316_16430(f_1590_16348_16429(f_1590_16366_16416(), instanceId)), "DebugJobCannotFindJobWithInstanceId", ErrorCategory.InvalidOperation, this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,16607,16619);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1590,15680,16630);

System.Management.Automation.JobRepository
f_1590_15819_15832()
{
var return_v = JobRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 15819, 15832);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1590_15819_15837(System.Management.Automation.JobRepository
this_param)
{
var return_v = this_param.Jobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 15819, 15837);
return return_v;
}


System.Guid
f_1590_15875_15889(System.Management.Automation.Job
this_param)
{
var return_v = this_param.InstanceId ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 15875, 15889);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1590_15819_15837_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 15819, 15837);
return return_v;
}


System.Management.Automation.JobManager
f_1590_16062_16072()
{
var return_v = JobManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 16062, 16072);
return return_v;
}


System.Management.Automation.Job2
f_1590_16062_16130(System.Management.Automation.JobManager
this_param,System.Guid
instanceId,Microsoft.PowerShell.Commands.DebugJobCommand
cmdlet,bool
writeErrorOnException,bool
writeObject,bool
recurse)
{
var return_v = this_param.GetJobByInstanceId( instanceId, (System.Management.Automation.Cmdlet)cmdlet, writeErrorOnException, writeObject, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 16062, 16130);
return return_v;
}


string
f_1590_16366_16416()
{
var return_v = RemotingErrorIdStrings.CannotFindJobWithInstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1590, 16366, 16416);
return return_v;
}


string
f_1590_16348_16429(string
formatSpec,System.Guid
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 16348, 16429);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1590_16316_16430(string
message)
{
var return_v = new System.Management.Automation.PSInvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 16316, 16430);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1590_16278_16571(System.Management.Automation.PSInvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,Microsoft.PowerShell.Commands.DebugJobCommand
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 16278, 16571);
return return_v;
}


int
f_1590_16238_16590(Microsoft.PowerShell.Commands.DebugJobCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1590, 16238, 16590);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1590,15680,16630);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1590,15680,16630);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public DebugJobCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1590,1180,16659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,1940,1944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,1972,1981);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,2033,2049);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,2205,2528);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,2636,2861);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,2967,3185);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1590,1180,16659);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1590,1180,16659);
}


static DebugJobCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1590,1180,16659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,1590,1625);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,1657,1700);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,1732,1771);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1590,1803,1858);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1590,1180,16659);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1590,1180,16659);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1590,1180,16659);
}
}
