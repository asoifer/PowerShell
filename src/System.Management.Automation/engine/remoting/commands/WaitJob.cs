// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Management.Automation;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell.Commands
{
[Cmdlet(VerbsLifecycle.Wait, "Job", DefaultParameterSetName = JobCmdletBase.SessionIdParameterSet, HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096902")]
    [OutputType(typeof(Job))]
    public class WaitJobCommand : JobCmdletBase, IDisposable
{
[Parameter(Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = RemoveJobCommand.JobParameterSet)]
        [ValidateNotNullOrEmpty]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public Job[] Job {get; set; }

[Parameter]
        public SwitchParameter Any {get; set; }

[Parameter]
        [Alias("TimeoutSec")]
        [ValidateRangeAttribute(-1, Int32.MaxValue)]
        public int Timeout
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,1859,1935);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,1895,1920);

return _timeoutInSeconds;
DynAbs.Tracing.TraceSender.TraceExitMethod(1615,1859,1935);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,1710,2039);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,1710,2039);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,1951,2028);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,1987,2013);

_timeoutInSeconds = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1615,1951,2028);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,1710,2039);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,1710,2039);
}
		}}

private int _timeoutInSeconds ;

[Parameter]
        public SwitchParameter Force {get; set; }

public override string[] Command {get; set; }

private readonly object _endProcessingActionLock ;

private Action _endProcessingAction;

private readonly ManualResetEventSlim _endProcessingActionIsReady ;

private void SetEndProcessingAction(Action endProcessingAction)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,2975,3558);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,3063,3155);

f_1615_3063_3154(endProcessingAction != null, "Caller should verify endProcessingAction != null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,3175,3199);
            lock (_endProcessingActionLock)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,3233,3532) || true) && (_endProcessingAction == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,3233,3532);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,3307,3392);

f_1615_3307_3391(f_1615_3318_3352_M(!_endProcessingActionIsReady.IsSet), "This line should execute only once");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,3414,3457);

_endProcessingAction = endProcessingAction;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,3479,3513);

f_1615_3479_3512(                    _endProcessingActionIsReady);
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,3233,3532);
}
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1615,2975,3558);

int
f_1615_3063_3154(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 3063, 3154);
return 0;
}


bool
f_1615_3318_3352_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 3318, 3352);
return return_v;
}


int
f_1615_3307_3391(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 3307, 3391);
return 0;
}


int
f_1615_3479_3512(System.Threading.ManualResetEventSlim
this_param)
{
this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 3479, 3512);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,2975,3558);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,2975,3558);
}
		}

private void InvokeEndProcessingAction()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,3570,4022);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,3635,3670);

f_1615_3635_3669(            _endProcessingActionIsReady);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,3686,3713);

Action 
endProcessingAction
=default(Action);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,3733,3757);
            lock (_endProcessingActionLock)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,3791,3834);

endProcessingAction = _endProcessingAction;
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,3909,4011) || true) && (endProcessingAction != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,3909,4011);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,3974,3996);

f_1615_3974_3995(endProcessingAction);
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,3909,4011);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1615,3570,4022);

int
f_1615_3635_3669(System.Threading.ManualResetEventSlim
this_param)
{
this_param.Wait();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 3635, 3669);
return 0;
}


int
f_1615_3974_3995(System.Action
this_param)
{
this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 3974, 3995);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,3570,4022);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,3570,4022);
}
		}

private void CleanUpEndProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,4034,4143);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,4094,4132);

f_1615_4094_4131(            _endProcessingActionIsReady);
DynAbs.Tracing.TraceSender.TraceExitMethod(1615,4034,4143);

int
f_1615_4094_4131(System.Threading.ManualResetEventSlim
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 4094, 4131);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,4034,4143);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,4034,4143);
}
		}

private readonly HashSet<Job> _finishedJobs ;

private readonly HashSet<Job> _blockedJobs ;

private readonly List<Job> _jobsToWaitFor ;

private readonly object _jobTrackingLock ;

private void HandleJobStateChangedEvent(object source, JobStateEventArgs eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,4554,7503);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,4662,4726);

f_1615_4662_4725(source is Job, "Caller should verify source is Job");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,4740,4812);

f_1615_4740_4811(eventArgs != null, "Caller should verify eventArgs != null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,4828,4850);

var 
job = (Job)source
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,4870,4886);
            lock (_jobTrackingLock)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,4920,5040);

f_1615_4920_5039(f_1615_4931_4980(_blockedJobs, j => !_finishedJobs.Contains(j)), "Job cannot be in *both* _blockedJobs and _finishedJobs");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,5060,5302) || true) && (f_1615_5064_5092(f_1615_5064_5086(eventArgs))== JobState.Blocked)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,5060,5302);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,5154,5176);

f_1615_5154_5175(                    _blockedJobs, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,5060,5302);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,5060,5302);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,5258,5283);

f_1615_5258_5282(                    _blockedJobs, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,5060,5302);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,5896,6392) || true) && (f_1615_5900_5906_M(!Force)&&(DynAbs.Tracing.TraceSender.Expression_True(1615, 5900, 5961)&&f_1615_5910_5961(job, f_1615_5932_5960(f_1615_5932_5954(eventArgs))))||(DynAbs.Tracing.TraceSender.Expression_False(1615, 5900, 6025)||(f_1615_5966_5971()&&(DynAbs.Tracing.TraceSender.Expression_True(1615, 5966, 6024)&&f_1615_5975_6024(job, f_1615_5995_6023(f_1615_5995_6017(eventArgs)))))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,5896,6392);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,6067,6218) || true) && (!f_1615_6072_6121(job, f_1615_6092_6120(f_1615_6092_6114(eventArgs))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,6067,6218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,6171,6195);

_warnNotTerminal = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,6067,6218);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,6242,6265);

f_1615_6242_6264(
                    _finishedJobs, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,5896,6392);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,5896,6392);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,6347,6373);

f_1615_6347_6372(                    _finishedJobs, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,5896,6392);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,6412,6532);

f_1615_6412_6531(f_1615_6423_6472(_blockedJobs, j => !_finishedJobs.Contains(j)), "Job cannot be in *both* _blockedJobs and _finishedJobs");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,6552,7477) || true) && (this.Any.IsPresent)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,6552,7477);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,6616,6997) || true) && (f_1615_6620_6639(_finishedJobs)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,6616,6997);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,6693,6764);

f_1615_6693_6763(                        this, this.EndProcessingOutputSingleFinishedJob);
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,6616,6997);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,6616,6997);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,6814,6997) || true) && (f_1615_6818_6836(_blockedJobs)== f_1615_6840_6860(_jobsToWaitFor))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,6814,6997);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,6910,6974);

f_1615_6910_6973(                        this, this.EndProcessingBlockedJobsError);
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,6814,6997);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,6616,6997);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,6552,7477);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,6552,7477);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,7079,7458) || true) && (f_1615_7083_7102(_finishedJobs)== f_1615_7106_7126(_jobsToWaitFor))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,7079,7458);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,7176,7245);

f_1615_7176_7244(                        this, this.EndProcessingOutputAllFinishedJobs);
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,7079,7458);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,7079,7458);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,7295,7458) || true) && (f_1615_7299_7317(_blockedJobs)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,7295,7458);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,7371,7435);

f_1615_7371_7434(                        this, this.EndProcessingBlockedJobsError);
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,7295,7458);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,7079,7458);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,6552,7477);
}
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1615,4554,7503);

int
f_1615_4662_4725(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 4662, 4725);
return 0;
}


int
f_1615_4740_4811(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 4740, 4811);
return 0;
}


bool
f_1615_4931_4980(System.Collections.Generic.HashSet<System.Management.Automation.Job>
source,System.Func<System.Management.Automation.Job, bool>
predicate)
{
var return_v = source.All<System.Management.Automation.Job>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 4931, 4980);
return return_v;
}


int
f_1615_4920_5039(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 4920, 5039);
return 0;
}


System.Management.Automation.JobStateInfo
f_1615_5064_5086(System.Management.Automation.JobStateEventArgs
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 5064, 5086);
return return_v;
}


System.Management.Automation.JobState
f_1615_5064_5092(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 5064, 5092);
return return_v;
}


bool
f_1615_5154_5175(System.Collections.Generic.HashSet<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
var return_v = this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 5154, 5175);
return return_v;
}


bool
f_1615_5258_5282(System.Collections.Generic.HashSet<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
var return_v = this_param.Remove( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 5258, 5282);
return return_v;
}


bool
f_1615_5900_5906_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 5900, 5906);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1615_5932_5954(System.Management.Automation.JobStateEventArgs
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 5932, 5954);
return return_v;
}


System.Management.Automation.JobState
f_1615_5932_5960(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 5932, 5960);
return return_v;
}


bool
f_1615_5910_5961(System.Management.Automation.Job
this_param,System.Management.Automation.JobState
state)
{
var return_v = this_param.IsPersistentState( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 5910, 5961);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1615_5966_5971()
{
var return_v = Force;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 5966, 5971);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1615_5995_6017(System.Management.Automation.JobStateEventArgs
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 5995, 6017);
return return_v;
}


System.Management.Automation.JobState
f_1615_5995_6023(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 5995, 6023);
return return_v;
}


bool
f_1615_5975_6024(System.Management.Automation.Job
this_param,System.Management.Automation.JobState
state)
{
var return_v = this_param.IsFinishedState( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 5975, 6024);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1615_6092_6114(System.Management.Automation.JobStateEventArgs
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 6092, 6114);
return return_v;
}


System.Management.Automation.JobState
f_1615_6092_6120(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 6092, 6120);
return return_v;
}


bool
f_1615_6072_6121(System.Management.Automation.Job
this_param,System.Management.Automation.JobState
state)
{
var return_v = this_param.IsFinishedState( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 6072, 6121);
return return_v;
}


bool
f_1615_6242_6264(System.Collections.Generic.HashSet<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
var return_v = this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 6242, 6264);
return return_v;
}


bool
f_1615_6347_6372(System.Collections.Generic.HashSet<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
var return_v = this_param.Remove( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 6347, 6372);
return return_v;
}


bool
f_1615_6423_6472(System.Collections.Generic.HashSet<System.Management.Automation.Job>
source,System.Func<System.Management.Automation.Job, bool>
predicate)
{
var return_v = source.All<System.Management.Automation.Job>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 6423, 6472);
return return_v;
}


int
f_1615_6412_6531(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 6412, 6531);
return 0;
}


int
f_1615_6620_6639(System.Collections.Generic.HashSet<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 6620, 6639);
return return_v;
}


int
f_1615_6693_6763(Microsoft.PowerShell.Commands.WaitJobCommand
this_param,System.Action
endProcessingAction)
{
this_param.SetEndProcessingAction( endProcessingAction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 6693, 6763);
return 0;
}


int
f_1615_6818_6836(System.Collections.Generic.HashSet<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 6818, 6836);
return return_v;
}


int
f_1615_6840_6860(System.Collections.Generic.List<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 6840, 6860);
return return_v;
}


int
f_1615_6910_6973(Microsoft.PowerShell.Commands.WaitJobCommand
this_param,System.Action
endProcessingAction)
{
this_param.SetEndProcessingAction( endProcessingAction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 6910, 6973);
return 0;
}


int
f_1615_7083_7102(System.Collections.Generic.HashSet<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 7083, 7102);
return return_v;
}


int
f_1615_7106_7126(System.Collections.Generic.List<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 7106, 7126);
return return_v;
}


int
f_1615_7176_7244(Microsoft.PowerShell.Commands.WaitJobCommand
this_param,System.Action
endProcessingAction)
{
this_param.SetEndProcessingAction( endProcessingAction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 7176, 7244);
return 0;
}


int
f_1615_7299_7317(System.Collections.Generic.HashSet<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 7299, 7317);
return return_v;
}


int
f_1615_7371_7434(Microsoft.PowerShell.Commands.WaitJobCommand
this_param,System.Action
endProcessingAction)
{
this_param.SetEndProcessingAction( endProcessingAction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 7371, 7434);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,4554,7503);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,4554,7503);
}
		}

private void AddJobsThatNeedJobChangesTracking(IEnumerable<Job> jobsToAdd)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,7515,7814);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,7614,7681);

f_1615_7614_7680(jobsToAdd != null, "Caller should verify jobs != null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,7703,7719);

            lock (_jobTrackingLock)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,7753,7788);

f_1615_7753_7787(                _jobsToWaitFor, jobsToAdd);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1615,7515,7814);

int
f_1615_7614_7680(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 7614, 7680);
return 0;
}


int
f_1615_7753_7787(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Collections.Generic.IEnumerable<System.Management.Automation.Job>
collection)
{
this_param.AddRange( collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 7753, 7787);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,7515,7814);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,7515,7814);
}
		}

private void StartJobChangesTracking()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,7826,8414);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,7895,7911);
            lock (_jobTrackingLock)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,7945,8121) || true) && (f_1615_7949_7969(_jobsToWaitFor)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,7945,8121);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,8016,8073);

f_1615_8016_8072(                    this, this.EndProcessingDoNothing);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,8095,8102);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,7945,8121);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,8141,8388);
foreach(Job job in f_1615_8161_8175_I(_jobsToWaitFor) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,8141,8388);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,8217,8269);

job.StateChanged += this.HandleJobStateChangedEvent;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,8291,8369);

f_1615_8291_8368(                    this, job, f_1615_8328_8367(f_1615_8350_8366(job)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,8141,8388);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1615,1,248);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1615,1,248);
}            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1615,7826,8414);

int
f_1615_7949_7969(System.Collections.Generic.List<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 7949, 7969);
return return_v;
}


int
f_1615_8016_8072(Microsoft.PowerShell.Commands.WaitJobCommand
this_param,System.Action
endProcessingAction)
{
this_param.SetEndProcessingAction( endProcessingAction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 8016, 8072);
return 0;
}


System.Management.Automation.JobStateInfo
f_1615_8350_8366(System.Management.Automation.Job
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 8350, 8366);
return return_v;
}


System.Management.Automation.JobStateEventArgs
f_1615_8328_8367(System.Management.Automation.JobStateInfo
jobStateInfo)
{
var return_v = new System.Management.Automation.JobStateEventArgs( jobStateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 8328, 8367);
return return_v;
}


int
f_1615_8291_8368(Microsoft.PowerShell.Commands.WaitJobCommand
this_param,System.Management.Automation.Job
source,System.Management.Automation.JobStateEventArgs
eventArgs)
{
this_param.HandleJobStateChangedEvent( (object)source, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 8291, 8368);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1615_8161_8175_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 8161, 8175);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,7826,8414);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,7826,8414);
}
		}

private void CleanUpJobChangesTracking()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,8426,8720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,8497,8513);
            lock (_jobTrackingLock)
            {
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,8547,8694);
foreach(Job job in f_1615_8567_8581_I(_jobsToWaitFor) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,8547,8694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,8623,8675);

job.StateChanged -= this.HandleJobStateChangedEvent;
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,8547,8694);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1615,1,148);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1615,1,148);
}            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1615,8426,8720);

System.Collections.Generic.List<System.Management.Automation.Job>
f_1615_8567_8581_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 8567, 8581);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,8426,8720);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,8426,8720);
}
		}

private List<Job> GetFinishedJobs()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,8732,9108);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,8792,8815);

List<Job> 
jobsToOutput
=default(List<Job>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,8835,8851);
            lock (_jobTrackingLock)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,8885,9046);

jobsToOutput = f_1615_8900_9045(f_1615_8900_9036(_jobsToWaitFor, j => ((!Force && j.IsPersistentState(j.JobStateInfo.State)) || (Force && j.IsFinishedState(j.JobStateInfo.State)))));
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,9077,9097);

return jobsToOutput;
DynAbs.Tracing.TraceSender.TraceExitMethod(1615,8732,9108);

System.Collections.Generic.IEnumerable<System.Management.Automation.Job>
f_1615_8900_9036(System.Collections.Generic.List<System.Management.Automation.Job>
source,System.Func<System.Management.Automation.Job, bool>
predicate)
{
var return_v = source.Where<System.Management.Automation.Job>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 8900, 9036);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1615_8900_9045(System.Collections.Generic.IEnumerable<System.Management.Automation.Job>
source)
{
var return_v = source.ToList<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 8900, 9045);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,8732,9108);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,8732,9108);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Job GetOneBlockedJob()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,9120,9341);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,9181,9197);
            lock (_jobTrackingLock)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,9231,9315);

return f_1615_9238_9314(_jobsToWaitFor, j => j.JobStateInfo.State == JobState.Blocked);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1615,9120,9341);

System.Management.Automation.Job
f_1615_9238_9314(System.Collections.Generic.List<System.Management.Automation.Job>
source,System.Func<System.Management.Automation.Job, bool>
predicate)
{
var return_v = source.FirstOrDefault<System.Management.Automation.Job>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 9238, 9314);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,9120,9341);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,9120,9341);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Timer _timer;

private readonly object _timerLock ;

private void StartTimeoutTracking(int timeoutInSeconds)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,9540,10081);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,9620,10070) || true) && (timeoutInSeconds == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,9620,10070);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,9679,9736);

f_1615_9679_9735(                this, this.EndProcessingDoNothing);
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,9620,10070);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,9620,10070);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,9770,10070) || true) && (timeoutInSeconds > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,9770,10070);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,9834,9844);
                lock (_timerLock)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,9886,10036);

_timer = f_1615_9895_10035((_) => this.SetEndProcessingAction(this.EndProcessingDoNothing), null, timeoutInSeconds * 1000, System.Threading.Timeout.Infinite);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,9770,10070);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,9620,10070);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1615,9540,10081);

int
f_1615_9679_9735(Microsoft.PowerShell.Commands.WaitJobCommand
this_param,System.Action
endProcessingAction)
{
this_param.SetEndProcessingAction( endProcessingAction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 9679, 9735);
return 0;
}


System.Threading.Timer
f_1615_9895_10035(System.Threading.TimerCallback
callback,object?
state,int
dueTime,int
period)
{
var return_v = new System.Threading.Timer( callback, state, dueTime, period);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 9895, 10035);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,9540,10081);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,9540,10081);
}
		}

private void CleanUpTimeoutTracking()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,10093,10363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,10161,10171);
            lock (_timerLock)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,10205,10337) || true) && (_timer != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,10205,10337);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,10265,10282);

f_1615_10265_10281(                    _timer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,10304,10318);

_timer = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,10205,10337);
}
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1615,10093,10363);

int
f_1615_10265_10281(System.Threading.Timer
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 10265, 10281);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,10093,10363);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,10093,10363);
}
		}

protected override void StopProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,10514,10647);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,10579,10636);

f_1615_10579_10635(            this, this.EndProcessingDoNothing);
DynAbs.Tracing.TraceSender.TraceExitMethod(1615,10514,10647);

int
f_1615_10579_10635(Microsoft.PowerShell.Commands.WaitJobCommand
this_param,System.Action
endProcessingAction)
{
this_param.SetEndProcessingAction( endProcessingAction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 10579, 10635);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,10514,10647);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,10514,10647);
}
		}

protected override void BeginProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,10794,10916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,10860,10905);

f_1615_10860_10904(            this, _timeoutInSeconds);
DynAbs.Tracing.TraceSender.TraceExitMethod(1615,10794,10916);

int
f_1615_10860_10904(Microsoft.PowerShell.Commands.WaitJobCommand
this_param,int
timeoutInSeconds)
{
this_param.StartTimeoutTracking( timeoutInSeconds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 10860, 10904);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,10794,10916);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,10794,10916);
}
		}

protected override void ProcessRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,11076,12211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,11177,11195);

List<Job> 
matches
=default(List<Job>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,11211,12136);

switch (f_1615_11219_11235())
            {

case NameParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,11211,12136);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,11313,11372);

matches = f_1615_11323_11371(this, true, false, true, false);
DynAbs.Tracing.TraceSender.TraceBreak(1615,11394,11400);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,11211,12136);

case InstanceIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,11211,12136);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,11470,11535);

matches = f_1615_11480_11534(this, true, false, true, false);
DynAbs.Tracing.TraceSender.TraceBreak(1615,11557,11563);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,11211,12136);

case SessionIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,11211,12136);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,11632,11696);

matches = f_1615_11642_11695(this, true, false, true, false);
DynAbs.Tracing.TraceSender.TraceBreak(1615,11718,11724);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,11211,12136);

case StateParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,11211,12136);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,11789,11830);

matches = f_1615_11799_11829(this, false);
DynAbs.Tracing.TraceSender.TraceBreak(1615,11852,11858);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,11211,12136);

case FilterParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,11211,12136);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,11924,11966);

matches = f_1615_11934_11965(this, false);
DynAbs.Tracing.TraceSender.TraceBreak(1615,11988,11994);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,11211,12136);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,11211,12136);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,12044,12093);

matches = f_1615_12054_12092(this, f_1615_12069_12077(this), false, false);
DynAbs.Tracing.TraceSender.TraceBreak(1615,12115,12121);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,11211,12136);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,12152,12200);

f_1615_12152_12199(
            this, matches);
DynAbs.Tracing.TraceSender.TraceExitMethod(1615,11076,12211);

string
f_1615_11219_11235()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 11219, 11235);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1615_11323_11371(Microsoft.PowerShell.Commands.WaitJobCommand
this_param,bool
recurse,bool
writeobject,bool
writeErrorOnNoMatch,bool
checkIfJobCanBeRemoved)
{
var return_v = this_param.FindJobsMatchingByName( recurse, writeobject, writeErrorOnNoMatch, checkIfJobCanBeRemoved);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 11323, 11371);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1615_11480_11534(Microsoft.PowerShell.Commands.WaitJobCommand
this_param,bool
recurse,bool
writeobject,bool
writeErrorOnNoMatch,bool
checkIfJobCanBeRemoved)
{
var return_v = this_param.FindJobsMatchingByInstanceId( recurse, writeobject, writeErrorOnNoMatch, checkIfJobCanBeRemoved);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 11480, 11534);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1615_11642_11695(Microsoft.PowerShell.Commands.WaitJobCommand
this_param,bool
recurse,bool
writeobject,bool
writeErrorOnNoMatch,bool
checkIfJobCanBeRemoved)
{
var return_v = this_param.FindJobsMatchingBySessionId( recurse, writeobject, writeErrorOnNoMatch, checkIfJobCanBeRemoved);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 11642, 11695);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1615_11799_11829(Microsoft.PowerShell.Commands.WaitJobCommand
this_param,bool
writeobject)
{
var return_v = this_param.FindJobsMatchingByState( writeobject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 11799, 11829);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1615_11934_11965(Microsoft.PowerShell.Commands.WaitJobCommand
this_param,bool
writeobject)
{
var return_v = this_param.FindJobsMatchingByFilter( writeobject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 11934, 11965);
return return_v;
}


System.Management.Automation.Job[]
f_1615_12069_12077(Microsoft.PowerShell.Commands.WaitJobCommand
this_param)
{
var return_v = this_param.Job;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 12069, 12077);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1615_12054_12092(Microsoft.PowerShell.Commands.WaitJobCommand
this_param,System.Management.Automation.Job[]
jobs,bool
writeobject,bool
checkIfJobCanBeRemoved)
{
var return_v = this_param.CopyJobsToList( jobs, writeobject, checkIfJobCanBeRemoved);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 12054, 12092);
return return_v;
}


int
f_1615_12152_12199(Microsoft.PowerShell.Commands.WaitJobCommand
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
jobsToAdd)
{
this_param.AddJobsThatNeedJobChangesTracking( (System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)jobsToAdd);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 12152, 12199);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,11076,12211);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,11076,12211);
}
		}

protected override void EndProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,12311,12622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,12375,12406);

f_1615_12375_12405(            this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,12420,12453);

f_1615_12420_12452(            this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,12467,12611) || true) && (_warnNotTerminal)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,12467,12611);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,12521,12596);

f_1615_12521_12595(this, f_1615_12534_12594());
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,12467,12611);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1615,12311,12622);

int
f_1615_12375_12405(Microsoft.PowerShell.Commands.WaitJobCommand
this_param)
{
this_param.StartJobChangesTracking();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 12375, 12405);
return 0;
}


int
f_1615_12420_12452(Microsoft.PowerShell.Commands.WaitJobCommand
this_param)
{
this_param.InvokeEndProcessingAction();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 12420, 12452);
return 0;
}


string
f_1615_12534_12594()
{
var return_v = RemotingErrorIdStrings.JobSuspendedDisconnectedWaitWithForce;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 12534, 12594);
return return_v;
}


int
f_1615_12521_12595(Microsoft.PowerShell.Commands.WaitJobCommand
this_param,string
text)
{
this_param.WriteWarning( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 12521, 12595);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,12311,12622);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,12311,12622);
}
		}

private void EndProcessingOutputSingleFinishedJob()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,12634,12895);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,12710,12768);

Job 
finishedJob = f_1615_12728_12767(f_1615_12728_12750(this))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,12782,12884) || true) && (finishedJob != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,12782,12884);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,12839,12869);

f_1615_12839_12868(                this, finishedJob);
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,12782,12884);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1615,12634,12895);

System.Collections.Generic.List<System.Management.Automation.Job>
f_1615_12728_12750(Microsoft.PowerShell.Commands.WaitJobCommand
this_param)
{
var return_v = this_param.GetFinishedJobs();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 12728, 12750);
return return_v;
}


System.Management.Automation.Job
f_1615_12728_12767(System.Collections.Generic.List<System.Management.Automation.Job>
source)
{
var return_v = source.FirstOrDefault<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 12728, 12767);
return return_v;
}


int
f_1615_12839_12868(Microsoft.PowerShell.Commands.WaitJobCommand
this_param,System.Management.Automation.Job
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 12839, 12868);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,12634,12895);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,12634,12895);
}
		}

private void EndProcessingOutputAllFinishedJobs()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,12907,13180);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,12981,13036);

IEnumerable<Job> 
finishedJobs = f_1615_13013_13035(this)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,13050,13169);
foreach(Job finishedJob in f_1615_13078_13090_I(finishedJobs) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,13050,13169);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,13124,13154);

f_1615_13124_13153(                this, finishedJob);
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,13050,13169);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1615,1,120);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1615,1,120);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1615,12907,13180);

System.Collections.Generic.List<System.Management.Automation.Job>
f_1615_13013_13035(Microsoft.PowerShell.Commands.WaitJobCommand
this_param)
{
var return_v = this_param.GetFinishedJobs();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 13013, 13035);
return return_v;
}


int
f_1615_13124_13153(Microsoft.PowerShell.Commands.WaitJobCommand
this_param,System.Management.Automation.Job
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 13124, 13153);
return 0;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.Job>
f_1615_13078_13090_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 13078, 13090);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,12907,13180);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,12907,13180);
}
		}

private void EndProcessingBlockedJobsError()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,13192,13694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,13261,13335);

string 
message = f_1615_13278_13334()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,13349,13402);

Exception 
exception = f_1615_13371_13401(message)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,13416,13629);

ErrorRecord 
errorRecord = f_1615_13442_13628(exception, "BlockedJobsDeadlockWithWaitJob", ErrorCategory.DeadlockDetected, f_1615_13604_13627(                this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,13643,13683);

f_1615_13643_13682(            this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitMethod(1615,13192,13694);

string
f_1615_13278_13334()
{
var return_v = RemotingErrorIdStrings.JobBlockedSoWaitJobCannotContinue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1615, 13278, 13334);
return return_v;
}


System.ArgumentException
f_1615_13371_13401(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 13371, 13401);
return return_v;
}


System.Management.Automation.Job
f_1615_13604_13627(Microsoft.PowerShell.Commands.WaitJobCommand
this_param)
{
var return_v = this_param.GetOneBlockedJob();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 13604, 13627);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1615_13442_13628(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Job
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 13442, 13628);
return return_v;
}


int
f_1615_13643_13682(Microsoft.PowerShell.Commands.WaitJobCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 13643, 13682);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,13192,13694);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,13192,13694);
}
		}

private void EndProcessingDoNothing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,13706,13792);
DynAbs.Tracing.TraceSender.TraceExitMethod(1615,13706,13792);
            // do nothing
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,13706,13792);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,13706,13792);
}
		}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,14087,14407);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,14133,14147);

f_1615_14133_14146(this, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,14363,14396);

f_1615_14363_14395(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1615,14087,14407);

int
f_1615_14133_14146(Microsoft.PowerShell.Commands.WaitJobCommand
this_param,bool
disposing)
{
this_param.Dispose( disposing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 14133, 14146);
return 0;
}


int
f_1615_14363_14395(Microsoft.PowerShell.Commands.WaitJobCommand
obj)
{
System.GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 14363, 14395);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,14087,14407);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,14087,14407);
}
		}

private void Dispose(bool disposing)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1615,14621,15137);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,14682,15126) || true) && (disposing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,14682,15126);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,14735,14750);
                lock (_disposableLock)
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,14792,15092) || true) && (!_isDisposed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1615,14792,15092);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,14858,14877);

_isDisposed = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,14905,14935);

f_1615_14905_14934(
                        this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,14961,14994);

f_1615_14961_14993(                        this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,15020,15048);

f_1615_15020_15047(                        this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,14792,15092);
}
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1615,14682,15126);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1615,14621,15137);

int
f_1615_14905_14934(Microsoft.PowerShell.Commands.WaitJobCommand
this_param)
{
this_param.CleanUpTimeoutTracking();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 14905, 14934);
return 0;
}


int
f_1615_14961_14993(Microsoft.PowerShell.Commands.WaitJobCommand
this_param)
{
this_param.CleanUpJobChangesTracking();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 14961, 14993);
return 0;
}


int
f_1615_15020_15047(Microsoft.PowerShell.Commands.WaitJobCommand
this_param)
{
this_param.CleanUpEndProcessing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 15020, 15047);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1615,14621,15137);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,14621,15137);
}
		}

private bool _isDisposed;

private readonly object _disposableLock ;

private bool _warnNotTerminal ;

public WaitJobCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1615,466,15336);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,892,1274);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,2063,2085);
this._timeoutInSeconds = -1;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,2511,2557);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,2767,2806);
this._endProcessingActionLock = f_1615_2794_2806();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,2832,2852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,2901,2962);
this._endProcessingActionIsReady = f_1615_2931_2962(false);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,4297,4331);
this._finishedJobs = f_1615_4313_4331();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,4372,4405);
this._blockedJobs = f_1615_4387_4405();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,4443,4475);
this._jobsToWaitFor = f_1615_4460_4475();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,4510,4541);
this._jobTrackingLock = f_1615_4529_4541();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,9461,9467);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,9502,9527);
this._timerLock = f_1615_9515_9527();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,15162,15173);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,15208,15238);
this._disposableLock = f_1615_15226_15238();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1615,15262,15286);
this._warnNotTerminal = false;DynAbs.Tracing.TraceSender.TraceExitConstructor(1615,466,15336);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,466,15336);
}


static WaitJobCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1615,466,15336);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1615,466,15336);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1615,466,15336);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1615,466,15336);

object
f_1615_2794_2806()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 2794, 2806);
return return_v;
}


System.Threading.ManualResetEventSlim
f_1615_2931_2962(bool
initialState)
{
var return_v = new System.Threading.ManualResetEventSlim( initialState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 2931, 2962);
return return_v;
}


System.Collections.Generic.HashSet<System.Management.Automation.Job>
f_1615_4313_4331()
{
var return_v = new System.Collections.Generic.HashSet<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 4313, 4331);
return return_v;
}


System.Collections.Generic.HashSet<System.Management.Automation.Job>
f_1615_4387_4405()
{
var return_v = new System.Collections.Generic.HashSet<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 4387, 4405);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1615_4460_4475()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 4460, 4475);
return return_v;
}


object
f_1615_4529_4541()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 4529, 4541);
return return_v;
}


object
f_1615_9515_9527()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 9515, 9527);
return return_v;
}


object
f_1615_15226_15238()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1615, 15226, 15238);
return return_v;
}

}
}
