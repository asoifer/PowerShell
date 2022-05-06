// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Remoting;
using System.Threading;

namespace Microsoft.PowerShell.Commands
{
[Cmdlet(VerbsLifecycle.Stop, "Job", SupportsShouldProcess = true, DefaultParameterSetName = JobCmdletBase.SessionIdParameterSet,
        HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096795")]
    [OutputType(typeof(Job))]
    public class StopJobCommand : JobCmdletBase, IDisposable
{
[Parameter(Mandatory = true,
                   Position = 0,
                   ValueFromPipeline = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = RemoveJobCommand.JobParameterSet)]
        [ValidateNotNullOrEmpty]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public Job[] Job
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1612,1394,1458);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,1430,1443);

return _jobs;
DynAbs.Tracing.TraceSender.TraceExitMethod(1612,1394,1458);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1612,973,1550);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1612,973,1550);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1612,1474,1539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,1510,1524);

_jobs = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1612,1474,1539);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1612,973,1550);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1612,973,1550);
}
		}}

private Job[] _jobs;

[Parameter]
        public SwitchParameter PassThru
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1612,1773,1841);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,1809,1826);

return _passThru;
DynAbs.Tracing.TraceSender.TraceExitMethod(1612,1773,1841);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1612,1696,1937);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1612,1696,1937);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1612,1857,1926);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,1893,1911);

_passThru = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1612,1857,1926);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1612,1696,1937);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1612,1696,1937);
}
		}}

private bool _passThru;

public override string[] Command
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1612,2088,2151);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,2124,2136);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1612,2088,2151);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1612,2031,2162);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1612,2031,2162);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected override void ProcessRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1612,2310,5327);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,2411,2439);

List<Job> 
jobsToStop = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,2455,3707);

switch (f_1612_2463_2479())
            {

case NameParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,2455,3707);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,2584,2646);

jobsToStop = f_1612_2597_2645(this, true, false, true, false);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1612,2693,2699);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,2455,3707);

case InstanceIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,2455,3707);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,2796,2864);

jobsToStop = f_1612_2809_2863(this, true, false, true, false);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1612,2911,2917);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,2455,3707);

case SessionIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,2455,3707);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,3013,3080);

jobsToStop = f_1612_3026_3079(this, true, false, true, false);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1612,3127,3133);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,2455,3707);

case StateParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,2455,3707);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,3225,3269);

jobsToStop = f_1612_3238_3268(this, false);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1612,3316,3322);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,2455,3707);

case FilterParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,2455,3707);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,3415,3460);

jobsToStop = f_1612_3428_3459(this, false);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1612,3507,3513);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,2455,3707);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,2455,3707);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,3590,3639);

jobsToStop = f_1612_3603_3638(this, _jobs, false, false);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1612,3686,3692);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,2455,3707);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,3723,3759);

f_1612_3723_3758(
            _allJobsToStop, jobsToStop);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,3775,5316);
foreach(Job job in f_1612_3795_3805_I(jobsToStop) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,3775,5316);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,3839,3865) || true) && (f_1612_3843_3856(this))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,3839,3865);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,3858,3865);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,3839,3865);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,3883,4000) || true) && (f_1612_3887_3930(job, f_1612_3907_3929(f_1612_3907_3923(job))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,3883,4000);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,3972,3981);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,3883,4000);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,4020,4247);

string 
targetString =
f_1612_4063_4246(f_1612_4110_4156(), f_1612_4226_4237(job), f_1612_4239_4245(job))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,4265,5301) || true) && (f_1612_4269_4317(this, targetString, VerbsLifecycle.Stop))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,4265,5301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,4359,4383);

Job2 
job2 = job as Job2
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,4522,5282) || true) && (job2 != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,4522,5282);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,4588,4638);

f_1612_4588_4637(                        _cleanUpActions, job2, HandleStopJobCompleted);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,4664,4712);

job2.StopJobCompleted += HandleStopJobCompleted;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,4746,4757);

                        lock (_syncObject)
                        {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,4815,5072) || true) && (!f_1612_4820_4865(job2, f_1612_4841_4864(f_1612_4841_4858(job2)))&&(DynAbs.Tracing.TraceSender.Expression_True(1612, 4819, 4941)&&                                !f_1612_4903_4941(_pendingJobs, f_1612_4925_4940(job2))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,4815,5072);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,5007,5041);

f_1612_5007_5040(                                _pendingJobs, f_1612_5024_5039(job2));
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,4815,5072);
}
                        }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,5127,5147);

f_1612_5127_5146(
                        job2);
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,4522,5282);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,4522,5282);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,5245,5259);

f_1612_5245_5258(                        job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,4522,5282);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,4265,5301);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,3775,5316);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1612,1,1542);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1612,1,1542);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1612,2310,5327);

string
f_1612_2463_2479()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1612, 2463, 2479);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1612_2597_2645(Microsoft.PowerShell.Commands.StopJobCommand
this_param,bool
recurse,bool
writeobject,bool
writeErrorOnNoMatch,bool
checkIfJobCanBeRemoved)
{
var return_v = this_param.FindJobsMatchingByName( recurse, writeobject, writeErrorOnNoMatch, checkIfJobCanBeRemoved);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 2597, 2645);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1612_2809_2863(Microsoft.PowerShell.Commands.StopJobCommand
this_param,bool
recurse,bool
writeobject,bool
writeErrorOnNoMatch,bool
checkIfJobCanBeRemoved)
{
var return_v = this_param.FindJobsMatchingByInstanceId( recurse, writeobject, writeErrorOnNoMatch, checkIfJobCanBeRemoved);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 2809, 2863);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1612_3026_3079(Microsoft.PowerShell.Commands.StopJobCommand
this_param,bool
recurse,bool
writeobject,bool
writeErrorOnNoMatch,bool
checkIfJobCanBeRemoved)
{
var return_v = this_param.FindJobsMatchingBySessionId( recurse, writeobject, writeErrorOnNoMatch, checkIfJobCanBeRemoved);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 3026, 3079);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1612_3238_3268(Microsoft.PowerShell.Commands.StopJobCommand
this_param,bool
writeobject)
{
var return_v = this_param.FindJobsMatchingByState( writeobject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 3238, 3268);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1612_3428_3459(Microsoft.PowerShell.Commands.StopJobCommand
this_param,bool
writeobject)
{
var return_v = this_param.FindJobsMatchingByFilter( writeobject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 3428, 3459);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1612_3603_3638(Microsoft.PowerShell.Commands.StopJobCommand
this_param,System.Management.Automation.Job[]
jobs,bool
writeobject,bool
checkIfJobCanBeRemoved)
{
var return_v = this_param.CopyJobsToList( jobs, writeobject, checkIfJobCanBeRemoved);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 3603, 3638);
return return_v;
}


int
f_1612_3723_3758(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
collection)
{
this_param.AddRange( (System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 3723, 3758);
return 0;
}


bool
f_1612_3843_3856(Microsoft.PowerShell.Commands.StopJobCommand
this_param)
{
var return_v = this_param.Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1612, 3843, 3856);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1612_3907_3923(System.Management.Automation.Job
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1612, 3907, 3923);
return return_v;
}


System.Management.Automation.JobState
f_1612_3907_3929(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1612, 3907, 3929);
return return_v;
}


bool
f_1612_3887_3930(System.Management.Automation.Job
this_param,System.Management.Automation.JobState
state)
{
var return_v = this_param.IsFinishedState( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 3887, 3930);
return return_v;
}


string
f_1612_4110_4156()
{
var return_v = RemotingErrorIdStrings.RemovePSJobWhatIfTarget;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1612, 4110, 4156);
return return_v;
}


string
f_1612_4226_4237(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1612, 4226, 4237);
return return_v;
}


int
f_1612_4239_4245(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1612, 4239, 4245);
return return_v;
}


string
f_1612_4063_4246(string
resourceString,params object[]
args)
{
var return_v = PSRemotingErrorInvariants.FormatResourceString( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 4063, 4246);
return return_v;
}


bool
f_1612_4269_4317(Microsoft.PowerShell.Commands.StopJobCommand
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 4269, 4317);
return return_v;
}


int
f_1612_4588_4637(System.Collections.Generic.Dictionary<System.Management.Automation.Job2, System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs>>
this_param,System.Management.Automation.Job2
key,System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs>
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 4588, 4637);
return 0;
}


System.Management.Automation.JobStateInfo
f_1612_4841_4858(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1612, 4841, 4858);
return return_v;
}


System.Management.Automation.JobState
f_1612_4841_4864(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1612, 4841, 4864);
return return_v;
}


bool
f_1612_4820_4865(System.Management.Automation.Job2
this_param,System.Management.Automation.JobState
state)
{
var return_v = this_param.IsFinishedState( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 4820, 4865);
return return_v;
}


System.Guid
f_1612_4925_4940(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1612, 4925, 4940);
return return_v;
}


bool
f_1612_4903_4941(System.Collections.Generic.HashSet<System.Guid>
this_param,System.Guid
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 4903, 4941);
return return_v;
}


System.Guid
f_1612_5024_5039(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1612, 5024, 5039);
return return_v;
}


bool
f_1612_5007_5040(System.Collections.Generic.HashSet<System.Guid>
this_param,System.Guid
item)
{
var return_v = this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 5007, 5040);
return return_v;
}


int
f_1612_5127_5146(System.Management.Automation.Job2
this_param)
{
this_param.StopJobAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 5127, 5146);
return 0;
}


int
f_1612_5245_5258(System.Management.Automation.Job
this_param)
{
this_param.StopJob();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 5245, 5258);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1612_3795_3805_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 3795, 3805);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1612,2310,5327);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1612,2310,5327);
}
		}

protected override void EndProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1612,5443,6006);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,5507,5531);

bool 
haveToWait = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,5551,5562);
            lock (_syncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,5596,5630);

_needToCheckForWaitingJobs = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,5648,5715) || true) && (f_1612_5652_5670(_pendingJobs)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,5648,5715);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,5697,5715);

haveToWait = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,5648,5715);
}
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,5746,5802) || true) && (haveToWait)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,5746,5802);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,5779,5802);

f_1612_5779_5801(                _waitForJobs);
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,5746,5802);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,5818,5866);
foreach(var e in f_1612_5836_5850_I(_errorsToWrite) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,5818,5866);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,5852,5866);

f_1612_5852_5865(this, e);
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,5818,5866);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1612,1,49);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1612,1,49);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,5880,5995) || true) && (_passThru)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,5880,5995);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,5927,5980);
foreach(var job in f_1612_5947_5961_I(_allJobsToStop) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,5927,5980);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,5963,5980);

f_1612_5963_5979(this, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,5927,5980);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1612,1,54);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1612,1,54);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1612,5880,5995);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1612,5443,6006);

int
f_1612_5652_5670(System.Collections.Generic.HashSet<System.Guid>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1612, 5652, 5670);
return return_v;
}


bool
f_1612_5779_5801(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.WaitOne();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 5779, 5801);
return return_v;
}


int
f_1612_5852_5865(Microsoft.PowerShell.Commands.StopJobCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 5852, 5865);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.ErrorRecord>
f_1612_5836_5850_I(System.Collections.Generic.List<System.Management.Automation.ErrorRecord>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 5836, 5850);
return return_v;
}


int
f_1612_5963_5979(Microsoft.PowerShell.Commands.StopJobCommand
this_param,System.Management.Automation.Job
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 5963, 5979);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1612_5947_5961_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 5947, 5961);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1612,5443,6006);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1612,5443,6006);
}
		}

protected override void StopProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1612,6065,6160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,6130,6149);

f_1612_6130_6148(            _waitForJobs);
DynAbs.Tracing.TraceSender.TraceExitMethod(1612,6065,6160);

bool
f_1612_6130_6148(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 6130, 6148);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1612,6065,6160);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1612,6065,6160);
}
		}

private void HandleStopJobCompleted(object sender, AsyncCompletedEventArgs eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1612,6239,7578);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,6349,6373);

Job 
job = sender as Job
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,6389,6564) || true) && (f_1612_6393_6408(eventArgs)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,6389,6564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,6450,6549);

f_1612_6450_6548(                _errorsToWrite, f_1612_6469_6547(f_1612_6485_6500(eventArgs), "StopJobError", ErrorCategory.ReadError, job));
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,6389,6564);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,6580,6622);

var 
parentJob = job as ContainerParentJob
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,6636,7020) || true) && (parentJob != null &&(DynAbs.Tracing.TraceSender.Expression_True(1612, 6640, 6695)&&f_1612_6661_6691(f_1612_6661_6685(parentJob))> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,6636,7020);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,6729,7005);
foreach(                    var e in f_1612_6794_6922_I(f_1612_6794_6922(f_1612_6794_6818(parentJob), e => e.FullyQualifiedErrorId == "ContainerParentJobStopAsyncError")) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,6729,7005);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,6964,6986);

f_1612_6964_6985(                    _errorsToWrite, e);
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,6729,7005);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1612,1,277);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1612,1,277);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1612,6636,7020);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,7036,7061);

bool 
releaseWait = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,7081,7092);
            lock (_syncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,7126,7264) || true) && (f_1612_7130_7167(_pendingJobs, f_1612_7152_7166(job)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,7126,7264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,7209,7245);

f_1612_7209_7244(                    _pendingJobs, f_1612_7229_7243(job));
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,7126,7264);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,7284,7383) || true) && (_needToCheckForWaitingJobs &&(DynAbs.Tracing.TraceSender.Expression_True(1612, 7288, 7341)&&f_1612_7318_7336(_pendingJobs)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,7284,7383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,7364,7383);

releaseWait = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,7284,7383);
}
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,7514,7567) || true) && (releaseWait)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,7514,7567);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,7548,7567);

f_1612_7548_7566(                _waitForJobs);
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,7514,7567);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1612,6239,7578);

System.Exception
f_1612_6393_6408(System.ComponentModel.AsyncCompletedEventArgs
this_param)
{
var return_v = this_param.Error ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1612, 6393, 6408);
return return_v;
}


System.Exception
f_1612_6485_6500(System.ComponentModel.AsyncCompletedEventArgs
this_param)
{
var return_v = this_param.Error;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1612, 6485, 6500);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1612_6469_6547(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Job
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 6469, 6547);
return return_v;
}


int
f_1612_6450_6548(System.Collections.Generic.List<System.Management.Automation.ErrorRecord>
this_param,System.Management.Automation.ErrorRecord
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 6450, 6548);
return 0;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
f_1612_6661_6685(System.Management.Automation.ContainerParentJob
this_param)
{
var return_v = this_param.ExecutionError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1612, 6661, 6685);
return return_v;
}


int
f_1612_6661_6691(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1612, 6661, 6691);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
f_1612_6794_6818(System.Management.Automation.ContainerParentJob
this_param)
{
var return_v = this_param.ExecutionError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1612, 6794, 6818);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.ErrorRecord>
f_1612_6794_6922(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
source,System.Func<System.Management.Automation.ErrorRecord, bool>
predicate)
{
var return_v = source.Where<System.Management.Automation.ErrorRecord>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 6794, 6922);
return return_v;
}


int
f_1612_6964_6985(System.Collections.Generic.List<System.Management.Automation.ErrorRecord>
this_param,System.Management.Automation.ErrorRecord
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 6964, 6985);
return 0;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.ErrorRecord>
f_1612_6794_6922_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ErrorRecord>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 6794, 6922);
return return_v;
}


System.Guid
f_1612_7152_7166(System.Management.Automation.Job
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1612, 7152, 7166);
return return_v;
}


bool
f_1612_7130_7167(System.Collections.Generic.HashSet<System.Guid>
this_param,System.Guid
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 7130, 7167);
return return_v;
}


System.Guid
f_1612_7229_7243(System.Management.Automation.Job
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1612, 7229, 7243);
return return_v;
}


bool
f_1612_7209_7244(System.Collections.Generic.HashSet<System.Guid>
this_param,System.Guid
item)
{
var return_v = this_param.Remove( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 7209, 7244);
return return_v;
}


int
f_1612_7318_7336(System.Collections.Generic.HashSet<System.Guid>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1612, 7318, 7336);
return return_v;
}


bool
f_1612_7548_7566(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 7548, 7566);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1612,6239,7578);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1612,6239,7578);
}
		}

private readonly HashSet<Guid> _pendingJobs ;

private readonly ManualResetEvent _waitForJobs ;

private readonly Dictionary<Job2, EventHandler<AsyncCompletedEventArgs>> _cleanUpActions ;

private readonly List<Job> _allJobsToStop ;

private readonly List<ErrorRecord> _errorsToWrite ;

private readonly object _syncObject ;

private bool _needToCheckForWaitingJobs;

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1612,8387,8498);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,8433,8447);

f_1612_8433_8446(this, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,8461,8487);

f_1612_8461_8486(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1612,8387,8498);

int
f_1612_8433_8446(Microsoft.PowerShell.Commands.StopJobCommand
this_param,bool
disposing)
{
this_param.Dispose( disposing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 8433, 8446);
return 0;
}


int
f_1612_8461_8486(Microsoft.PowerShell.Commands.StopJobCommand
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 8461, 8486);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1612,8387,8498);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1612,8387,8498);
}
		}

protected void Dispose(bool disposing)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1612,8603,8878);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,8666,8689) || true) && (!disposing)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,8666,8689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,8682,8689);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,8666,8689);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,8703,8828);
foreach(var pair in f_1612_8724_8739_I(_cleanUpActions) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1612,8703,8828);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,8773,8813);

pair.Key.StopJobCompleted -= pair.Value;
DynAbs.Tracing.TraceSender.TraceExitCondition(1612,8703,8828);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1612,1,126);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1612,1,126);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,8844,8867);

f_1612_8844_8866(
            _waitForJobs);
DynAbs.Tracing.TraceSender.TraceExitMethod(1612,8603,8878);

System.Collections.Generic.Dictionary<System.Management.Automation.Job2, System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs>>
f_1612_8724_8739_I(System.Collections.Generic.Dictionary<System.Management.Automation.Job2, System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs>>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 8724, 8739);
return return_v;
}


int
f_1612_8844_8866(System.Threading.ManualResetEvent
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 8844, 8866);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1612,8603,8878);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1612,8603,8878);
}
		}

public StopJobCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1612,510,8913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,1576,1581);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,1962,1971);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,7694,7728);
this._pendingJobs = f_1612_7709_7728();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,7773,7815);
this._waitForJobs = f_1612_7788_7815(false);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,7899,7991);
this._cleanUpActions = f_1612_7930_7991();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,8031,8063);
this._allJobsToStop = f_1612_8048_8063();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,8109,8149);
this._errorsToWrite = f_1612_8126_8149();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,8186,8212);
this._syncObject = f_1612_8200_8212();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1612,8236,8262);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1612,510,8913);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1612,510,8913);
}


static StopJobCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1612,510,8913);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1612,510,8913);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1612,510,8913);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1612,510,8913);

System.Collections.Generic.HashSet<System.Guid>
f_1612_7709_7728()
{
var return_v = new System.Collections.Generic.HashSet<System.Guid>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 7709, 7728);
return return_v;
}


System.Threading.ManualResetEvent
f_1612_7788_7815(bool
initialState)
{
var return_v = new System.Threading.ManualResetEvent( initialState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 7788, 7815);
return return_v;
}


System.Collections.Generic.Dictionary<System.Management.Automation.Job2, System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs>>
f_1612_7930_7991()
{
var return_v = new System.Collections.Generic.Dictionary<System.Management.Automation.Job2, System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs>>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 7930, 7991);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1612_8048_8063()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 8048, 8063);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.ErrorRecord>
f_1612_8126_8149()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.ErrorRecord>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 8126, 8149);
return return_v;
}


object
f_1612_8200_8212()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1612, 8200, 8212);
return return_v;
}

}
}
