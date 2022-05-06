// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Automation.Remoting.Internal;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
internal abstract class StartableJob : Job
{
internal StartableJob(string commandName, string jobName)
:base(f_1587_545_556_C(commandName) ,jobName)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1587,467,588);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1587,467,588);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,467,588);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,467,588);
}
		}

internal abstract void StartJob();

static StartableJob()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1587,408,641);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1587,408,641);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,408,641);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1587,408,641);

static string
f_1587_545_556_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1587, 467, 588);
return return_v;
}

}
internal sealed class ThrottlingJob : Job
{
protected override void Dispose(bool disposing)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,951,2092);
            try
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,1059,1973) || true) && (disposing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,1059,1973);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,1114,1129);

f_1587_1114_1128(                    this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,1153,1182);

List<Job> 
childJobsToDispose
=default(List<Job>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,1210,1221);
                    lock (_lockObject)
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,1271,1407);

f_1587_1271_1406(f_1587_1282_1327(this, f_1587_1303_1326(f_1587_1303_1320(this))), "ThrottlingJob should be completed before removing and disposing child jobs");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,1433,1484);

childJobsToDispose = f_1587_1454_1483(f_1587_1468_1482(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,1510,1533);

f_1587_1510_1532(f_1587_1510_1524(this));
                    }
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,1580,1715);
foreach(Job childJob in f_1587_1605_1623_I(childJobsToDispose) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,1580,1715);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,1673,1692);

f_1587_1673_1691(                        childJob);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,1580,1715);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1587,1,136);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1587,1,136);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,1739,1895) || true) && (_jobResultsThrottlingSemaphore != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,1739,1895);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,1831,1872);

f_1587_1831_1871(                        _jobResultsThrottlingSemaphore);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,1739,1895);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,1919,1954);

f_1587_1919_1953(
                    _cancellationTokenSource);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,1059,1973);
}
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1587,2002,2081);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,2042,2066);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(disposing),1587,2042,2065);
DynAbs.Tracing.TraceSender.TraceExitFinally(1587,2002,2081);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,951,2092);

int
f_1587_1114_1128(System.Management.Automation.ThrottlingJob
this_param)
{
this_param.StopJob();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 1114, 1128);
return 0;
}


System.Management.Automation.JobStateInfo
f_1587_1303_1320(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 1303, 1320);
return return_v;
}


System.Management.Automation.JobState
f_1587_1303_1326(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 1303, 1326);
return return_v;
}


bool
f_1587_1282_1327(System.Management.Automation.ThrottlingJob
this_param,System.Management.Automation.JobState
state)
{
var return_v = this_param.IsFinishedState( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 1282, 1327);
return return_v;
}


int
f_1587_1271_1406(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 1271, 1406);
return 0;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1587_1468_1482(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 1468, 1482);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1587_1454_1483(System.Collections.Generic.IList<System.Management.Automation.Job>
collection)
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>( (System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 1454, 1483);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1587_1510_1524(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 1510, 1524);
return return_v;
}


int
f_1587_1510_1532(System.Collections.Generic.IList<System.Management.Automation.Job>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 1510, 1532);
return 0;
}


int
f_1587_1673_1691(System.Management.Automation.Job
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 1673, 1691);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1587_1605_1623_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 1605, 1623);
return return_v;
}


int
f_1587_1831_1871(System.Threading.SemaphoreSlim
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 1831, 1871);
return 0;
}


int
f_1587_1919_1953(System.Threading.CancellationTokenSource
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 1919, 1953);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,951,2092);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,951,2092);
}
		}

private readonly DateTime _progressStartTime ;

private readonly int _progressActivityId;

private readonly object _progressLock ;

private DateTime _progressReportLastTime ;

internal int GetProgressActivityId()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,2436,3242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,2503,2516);
            lock (_progressLock)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,2550,3169) || true) && (_progressReportLastTime.Equals(DateTime.MinValue))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,2550,3169);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,2697,2749);

f_1587_2697_2748(                        this, minimizeFrequentUpdates: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,2775,2886);

f_1587_2775_2885(_progressReportLastTime > DateTime.MinValue, "Progress was reported (lastTimeProgressWasReported)");
                    }
                    catch (PSInvalidOperationException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1587,2931,3150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,3117,3127);

return -1;
DynAbs.Tracing.TraceSender.TraceExitCatch(1587,2931,3150);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,2550,3169);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,3189,3216);

return _progressActivityId;
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,2436,3242);

int
f_1587_2697_2748(System.Management.Automation.ThrottlingJob
this_param,bool
minimizeFrequentUpdates)
{
this_param.ReportProgress( minimizeFrequentUpdates: minimizeFrequentUpdates);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 2697, 2748);
return 0;
}


int
f_1587_2775_2885(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 2775, 2885);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,2436,3242);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,2436,3242);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void ReportProgress(bool minimizeFrequentUpdates)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,3254,6041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,3342,3355);
            lock (_progressLock)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,3389,3420);

DateTime 
now = DateTime.UtcNow
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,3440,3917) || true) && (minimizeFrequentUpdates)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,3440,3917);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,3509,3645) || true) && ((now - _progressStartTime) < TimeSpan.FromSeconds(1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,3509,3645);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,3615,3622);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,3509,3645);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,3669,3898) || true) && ((!_progressReportLastTime.Equals(DateTime.MinValue)) &&(DynAbs.Tracing.TraceSender.Expression_True(1587, 3673, 3818)&&                        (now - _progressReportLastTime < TimeSpan.FromMilliseconds(200))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,3669,3898);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,3868,3875);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,3669,3898);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,3440,3917);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,3937,3967);

_progressReportLastTime = now;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,3987,4008);

double 
workCompleted
=default(double);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,4026,4043);

double 
totalWork
=default(double);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,4061,4081);

int 
percentComplete
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,4105,4116);
                lock (_lockObject)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,4158,4191);

totalWork = _countOfAllChildJobs;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,4213,4259);

workCompleted = f_1587_4229_4258(this);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,4298,4541) || true) && (totalWork >= 1.0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,4298,4541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,4360,4419);

percentComplete = (int)(100.0 * workCompleted / totalWork);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,4298,4541);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,4298,4541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,4501,4522);

percentComplete = -1;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,4298,4541);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,4561,4624);

percentComplete = f_1587_4579_4623(-1, f_1587_4592_4622(100, percentComplete));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,4644,4844);

var 
progressRecord = f_1587_4665_4843(activityId: _progressActivityId, activity: f_1587_4770_4782(this), statusDescription: f_1587_4824_4842(this))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,4864,5960) || true) && (f_1587_4868_4897(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,4864,5960);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,4939,5072) || true) && (_progressReportLastTime.Equals(DateTime.MinValue))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,4939,5072);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,5042,5049);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,4939,5072);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,5096,5153);

progressRecord.RecordType = ProgressRecordType.Completed;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,5175,5212);

progressRecord.PercentComplete = 100;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,5234,5270);

progressRecord.SecondsRemaining = 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,4864,5960);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,4864,5960);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,5352,5410);

progressRecord.RecordType = ProgressRecordType.Processing;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,5432,5481);

progressRecord.PercentComplete = percentComplete;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,5503,5532);

int? 
secondsRemaining = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,5554,5758) || true) && (percentComplete >= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,5554,5758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,5628,5735);

secondsRemaining = f_1587_5647_5734(_progressStartTime, (double)percentComplete / 100.0);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,5554,5758);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,5782,5941) || true) && (f_1587_5786_5811(secondsRemaining))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,5782,5941);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,5861,5918);

progressRecord.SecondsRemaining = f_1587_5895_5917(secondsRemaining);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,5782,5941);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,4864,5960);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,5980,6015);

f_1587_5980_6014(
                this, progressRecord);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,3254,6041);

int
f_1587_4229_4258(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.CountOfFinishedChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 4229, 4258);
return return_v;
}


int
f_1587_4592_4622(int
val1,int
val2)
{
var return_v = Math.Min( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 4592, 4622);
return return_v;
}


int
f_1587_4579_4623(int
val1,int
val2)
{
var return_v = Math.Max( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 4579, 4623);
return return_v;
}


string
f_1587_4770_4782(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 4770, 4782);
return return_v;
}


string
f_1587_4824_4842(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.StatusMessage;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 4824, 4842);
return return_v;
}


System.Management.Automation.ProgressRecord
f_1587_4665_4843(int
activityId,string
activity,string
statusDescription)
{
var return_v = new System.Management.Automation.ProgressRecord( activityId: activityId, activity: activity, statusDescription: statusDescription);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 4665, 4843);
return return_v;
}


bool
f_1587_4868_4897(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.IsThrottlingJobCompleted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 4868, 4897);
return return_v;
}


int?
f_1587_5647_5734(System.DateTime
startTime,double
percentageComplete)
{
var return_v = ProgressRecord.GetSecondsRemaining( startTime, percentageComplete);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 5647, 5734);
return return_v;
}


bool
f_1587_5786_5811(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 5786, 5811);
return return_v;
}


int
f_1587_5895_5917(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 5895, 5917);
return return_v;
}


int
f_1587_5980_6014(System.Management.Automation.ThrottlingJob
this_param,System.Management.Automation.ProgressRecord
progressRecord)
{
this_param.WriteProgress( progressRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 5980, 6014);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,3254,6041);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,3254,6041);
}
		}

        
        /// <summary>
        /// Flags of child jobs of a <see cref="ThrottlingJob"/>
        /// </summary>
        [Flags]
        internal enum ChildJobFlags
        {
            /// <summary>
            /// Child job doesn't have any special properties.
            /// </summary>
            None = 0,

            /// <summary>
            /// Child job can call <see cref="ThrottlingJob.AddChildJobWithoutBlocking"/> method
            /// or <see cref="ThrottlingJob.AddChildJobAndPotentiallyBlock(StartableJob, ChildJobFlags)" />
            /// or <see cref="ThrottlingJob.AddChildJobAndPotentiallyBlock(Cmdlet, StartableJob, ChildJobFlags)" />
            /// method
            /// of the <see cref="ThrottlingJob"/> instance it belongs to.
            /// </summary>
            CreatesChildJobs = 0x1,
        }

private bool _ownerWontSubmitNewChildJobs ;

private readonly HashSet<Guid> _setOfChildJobsThatCanAddMoreChildJobs ;

private bool IsEndOfChildJobs
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,7142,7377);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,7184,7195);
                lock (_lockObject)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,7237,7343);

return _isStopping ||(DynAbs.Tracing.TraceSender.Expression_False(1587, 7244, 7342)||(_ownerWontSubmitNewChildJobs &&(DynAbs.Tracing.TraceSender.Expression_True(1587, 7260, 7341)&&f_1587_7292_7336(_setOfChildJobsThatCanAddMoreChildJobs)== 0)));
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,7142,7377);

int
f_1587_7292_7336(System.Collections.Generic.HashSet<System.Guid>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 7292, 7336);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,7088,7388);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,7088,7388);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private bool IsThrottlingJobCompleted
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,7462,7679);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,7504,7515);
                lock (_lockObject)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,7557,7645);

return f_1587_7564_7585(this)&&(DynAbs.Tracing.TraceSender.Expression_True(1587, 7564, 7644)&&(_countOfAllChildJobs <= f_1587_7614_7643(this)));
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,7462,7679);

bool
f_1587_7564_7585(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.IsEndOfChildJobs ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 7564, 7585);
return return_v;
}


int
f_1587_7614_7643(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.CountOfFinishedChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 7614, 7643);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,7400,7690);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,7400,7690);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private readonly bool _cmdletMode;

private int _countOfAllChildJobs;

private int _countOfBlockedChildJobs;

private int _countOfFailedChildJobs;

private int _countOfStoppedChildJobs;

private int _countOfSuccessfullyCompletedChildJobs;

private int CountOfFinishedChildJobs
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,8057,8285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,8099,8110);
                lock (_lockObject)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,8152,8251);

return _countOfFailedChildJobs + _countOfStoppedChildJobs + _countOfSuccessfullyCompletedChildJobs;
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,8057,8285);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,7996,8296);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,7996,8296);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private int CountOfRunningOrReadyToRunChildJobs
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,8380,8569);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,8422,8433);
                lock (_lockObject)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,8475,8535);

return _countOfAllChildJobs - f_1587_8505_8534(this);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,8380,8569);

int
f_1587_8505_8534(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.CountOfFinishedChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 8505, 8534);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,8308,8580);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,8308,8580);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private readonly object _lockObject ;

internal ThrottlingJob(string command, string jobName, string jobTypeName, int maximumConcurrentChildJobs, bool cmdletMode)
:base(f_1587_9989_9996_C(command) ,jobName)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1587,9845,10488);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,2202,2238);
this._progressStartTime = DateTime.UtcNow;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,2270,2289);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,2324,2352);
this._progressLock = f_1587_2340_2352();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,2380,2423);
this._progressReportLastTime = DateTime.MinValue;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,6939,6975);
this._ownerWontSubmitNewChildJobs = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,7017,7077);
this._setOfChildJobsThatCanAddMoreChildJobs = f_1587_7058_7077();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,7724,7735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,7760,7780);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,7805,7829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,7854,7877);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,7900,7924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,7947,7985);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,8616,8642);
this._lockObject = f_1587_8630_8642();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,11551,11605);
this._alreadyDisabledFlowControlForPendingJobsQueue = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,12340,12403);
this._alreadyDisabledFlowControlForPendingCmdletActionsQueue = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,16935,17007);
this._alreadyWroteFlowControlBuffersHighMemoryUsageWarningLock = f_1587_16995_17007();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,17031,17084);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,18202,18229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,18252,18285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,18308,18339);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,18363,18400);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,18439,18459);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,18498,18520);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,18553,18588);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,18611,18629);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,18671,18701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,18725,18748);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,25468,25479);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,25531,25587);
this._cancellationTokenSource = f_1587_25558_25587();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,30304,30378);
this._childJobLocations = f_1587_30325_30378(f_1587_30345_30377());DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,10031,10070);

f_1587_10031_10043(this).BlockingEnumerator = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,10084,10109);

_cmdletMode = cmdletMode;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,10123,10156);

this.PSJobTypeName = jobTypeName;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,10170,10331) || true) && (_cmdletMode)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,10170,10331);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,10219,10316);

_jobResultsThrottlingSemaphore = f_1587_10252_10315(ForwardingHelper.AggregationQueueMaxCapacity);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,10170,10331);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,10347,10407);

_progressActivityId = f_1587_10369_10406(f_1587_10369_10399(f_1587_10380_10398(this)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,10423,10477);

f_1587_10423_10476(
            this, maximumConcurrentChildJobs);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1587,9845,10488);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,9845,10488);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,9845,10488);
}
		}

internal void AddChildJobAndPotentiallyBlock(
            StartableJob childJob,
            ChildJobFlags flags)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,10500,10968);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,10640,10957);
using(var 
jobGotEnqueued = f_1587_10668_10713(initialState: false)
)            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,10747,10813) || true) && (childJob == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,10747,10813);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,10769,10813);

throw f_1587_10775_10812("childJob");
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,10747,10813);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,10833,10902);

f_1587_10833_10901(
                this, childJob, flags, jobGotEnqueued.Set);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,10920,10942);

f_1587_10920_10941(                jobGotEnqueued);
DynAbs.Tracing.TraceSender.TraceExitUsing(1587,10640,10957);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,10500,10968);

System.Threading.ManualResetEventSlim
f_1587_10668_10713(bool
initialState)
{
var return_v = new System.Threading.ManualResetEventSlim( initialState: initialState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 10668, 10713);
return return_v;
}


System.ArgumentNullException
f_1587_10775_10812(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 10775, 10812);
return return_v;
}


int
f_1587_10833_10901(System.Management.Automation.ThrottlingJob
this_param,System.Management.Automation.StartableJob
childJob,System.Management.Automation.ThrottlingJob.ChildJobFlags
flags,System.Action
jobEnqueuedAction)
{
this_param.AddChildJobWithoutBlocking( childJob, flags, jobEnqueuedAction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 10833, 10901);
return 0;
}


int
f_1587_10920_10941(System.Threading.ManualResetEventSlim
this_param)
{
this_param.Wait();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 10920, 10941);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,10500,10968);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,10500,10968);
}
		}

internal void AddChildJobAndPotentiallyBlock(
            Cmdlet cmdlet,
            StartableJob childJob,
            ChildJobFlags flags)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,10980,11526);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,11148,11515);
using(var 
forwardingCancellation = f_1587_11184_11213()
)            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,11247,11313) || true) && (childJob == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,11247,11313);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,11269,11313);

throw f_1587_11275_11312("childJob");
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,11247,11313);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,11333,11413);

f_1587_11333_11412(
                this, childJob, flags, forwardingCancellation.Cancel);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,11431,11500);

f_1587_11431_11499(                this, cmdlet, f_1587_11470_11498(forwardingCancellation));
DynAbs.Tracing.TraceSender.TraceExitUsing(1587,11148,11515);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,10980,11526);

System.Threading.CancellationTokenSource
f_1587_11184_11213()
{
var return_v = new System.Threading.CancellationTokenSource();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 11184, 11213);
return return_v;
}


System.ArgumentNullException
f_1587_11275_11312(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 11275, 11312);
return return_v;
}


int
f_1587_11333_11412(System.Management.Automation.ThrottlingJob
this_param,System.Management.Automation.StartableJob
childJob,System.Management.Automation.ThrottlingJob.ChildJobFlags
flags,System.Action
jobEnqueuedAction)
{
this_param.AddChildJobWithoutBlocking( childJob, flags, jobEnqueuedAction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 11333, 11412);
return 0;
}


System.Threading.CancellationToken
f_1587_11470_11498(System.Threading.CancellationTokenSource
this_param)
{
var return_v = this_param.Token;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 11470, 11498);
return return_v;
}


int
f_1587_11431_11499(System.Management.Automation.ThrottlingJob
this_param,System.Management.Automation.Cmdlet
cmdlet,System.Threading.CancellationToken
cancellationToken)
{
this_param.ForwardAllResultsToCmdlet( cmdlet, (System.Threading.CancellationToken?)cancellationToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 11431, 11499);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,10980,11526);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,10980,11526);
}
		}

private bool _alreadyDisabledFlowControlForPendingJobsQueue ;

internal void DisableFlowControlForPendingJobsQueue()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,11616,12315);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,11694,11816) || true) && (!_cmdletMode ||(DynAbs.Tracing.TraceSender.Expression_False(1587, 11698, 11760)||_alreadyDisabledFlowControlForPendingJobsQueue))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,11694,11816);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,11794,11801);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,11694,11816);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,11832,11886);

_alreadyDisabledFlowControlForPendingJobsQueue = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,11908,11919);

            lock (_lockObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,11953,11987);

_maxReadyToRunJobs = int.MaxValue;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,12007,12289) || true) && (f_1587_12014_12055(_actionsForUnblockingChildAdditions)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,12007,12289);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,12101,12158);

Action 
a = f_1587_12112_12157(_actionsForUnblockingChildAdditions)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,12180,12270) || true) && (a != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,12180,12270);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,12243,12247);

f_1587_12243_12246(a);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,12180,12270);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,12007,12289);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1587,12007,12289);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1587,12007,12289);
}            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,11616,12315);

int
f_1587_12014_12055(System.Collections.Generic.Queue<System.Action>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 12014, 12055);
return return_v;
}


System.Action
f_1587_12112_12157(System.Collections.Generic.Queue<System.Action>
this_param)
{
var return_v = this_param.Dequeue();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 12112, 12157);
return return_v;
}


int
f_1587_12243_12246(System.Action
this_param)
{
this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 12243, 12246);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,11616,12315);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,11616,12315);
}
		}

private bool _alreadyDisabledFlowControlForPendingCmdletActionsQueue ;

internal void DisableFlowControlForPendingCmdletActionsQueue()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,12414,13021);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,12501,12632) || true) && (!_cmdletMode ||(DynAbs.Tracing.TraceSender.Expression_False(1587, 12505, 12576)||_alreadyDisabledFlowControlForPendingCmdletActionsQueue))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,12501,12632);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,12610,12617);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,12501,12632);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,12648,12711);

_alreadyDisabledFlowControlForPendingCmdletActionsQueue = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,12727,12828);

long 
slotsToRelease = (long)(int.MaxValue / 2) - (long)(f_1587_12783_12826(_jobResultsThrottlingSemaphore))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,12842,13010) || true) && ((slotsToRelease > 0) &&(DynAbs.Tracing.TraceSender.Expression_True(1587, 12846, 12901)&&(slotsToRelease < int.MaxValue)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,12842,13010);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,12935,12995);

f_1587_12935_12994(                _jobResultsThrottlingSemaphore, slotsToRelease);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,12842,13010);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,12414,13021);

int
f_1587_12783_12826(System.Threading.SemaphoreSlim
this_param)
{
var return_v = this_param.CurrentCount;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 12783, 12826);
return return_v;
}


int
f_1587_12935_12994(System.Threading.SemaphoreSlim
this_param,long
releaseCount)
{
var return_v = this_param.Release( (int)releaseCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 12935, 12994);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,12414,13021);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,12414,13021);
}
		}

internal void AddChildJobWithoutBlocking(StartableJob childJob, ChildJobFlags flags, Action jobEnqueuedAction = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,13662,16149);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,13804,13870) || true) && (childJob == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,13804,13870);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,13826,13870);

throw f_1587_13832_13869("childJob");
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,13804,13870);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,13884,14037) || true) && (f_1587_13888_13915(f_1587_13888_13909(childJob))!= JobState.NotStarted)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,13884,14037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,13940,14037);

throw f_1587_13946_14036(f_1587_13968_14023(), "childJob");
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,13884,14037);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,14051,14076);

f_1587_14051_14075(            this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,14092,14128);

JobStateInfo 
newJobStateInfo = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,14148,14159);
            lock (_lockObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,14193,14323) || true) && (f_1587_14197_14218(this))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,14193,14323);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,14220,14323);

throw f_1587_14226_14322(f_1587_14256_14321());
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,14193,14323);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,14341,14369) || true) && (_isStopping)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,14341,14369);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,14360,14367);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,14341,14369);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,14389,14532) || true) && (_countOfAllChildJobs == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,14389,14532);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,14460,14513);

newJobStateInfo = f_1587_14478_14512(JobState.Running);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,14389,14532);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,14552,14755) || true) && (ChildJobFlags.CreatesChildJobs == (ChildJobFlags.CreatesChildJobs & flags))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,14552,14755);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,14672,14736);

f_1587_14672_14735(                    _setOfChildJobsThatCanAddMoreChildJobs, f_1587_14715_14734(childJob));
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,14552,14755);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,14775,14804);

f_1587_14775_14803(f_1587_14775_14789(this), childJob);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,14822,14864);

f_1587_14822_14863(                _childJobLocations, f_1587_14845_14862(childJob));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,14882,14905);

_countOfAllChildJobs++;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,14925,15019);

f_1587_14925_15018(
                this, f_1587_14977_15017(this));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,15037,15430) || true) && (f_1587_15041_15081(this)> _maxReadyToRunJobs)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,15037,15430);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,15144,15207);

f_1587_15144_15206(                    _actionsForUnblockingChildAdditions, jobEnqueuedAction);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,15037,15430);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,15037,15430);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,15289,15411) || true) && (jobEnqueuedAction != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,15289,15411);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,15368,15388);

f_1587_15368_15387(jobEnqueuedAction);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,15289,15411);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,15037,15430);
}
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,15461,15601) || true) && (newJobStateInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,15461,15601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,15522,15586);

f_1587_15522_15585(                this, f_1587_15539_15560(newJobStateInfo), f_1587_15562_15584(newJobStateInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,15461,15601);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,15617,15701);

f_1587_15617_15700(
            this.ChildJobAdded, this, f_1587_15653_15699(childJob));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,15717,15780);

f_1587_15717_15779(
            childJob, this.GetProgressActivityId);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,15794,15846);

childJob.StateChanged += this.childJob_StateChanged;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,15860,16014) || true) && (_cmdletMode)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,15860,16014);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,15909,15999);

f_1587_15909_15925(childJob).DataAdded += new EventHandler<DataAddedEventArgs>(childJob_ResultsAdded);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,15860,16014);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,16030,16071);

f_1587_16030_16070(
            this, childJob);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,16087,16138);

f_1587_16087_16137(
            this, minimizeFrequentUpdates: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,13662,16149);

System.ArgumentNullException
f_1587_13832_13869(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 13832, 13869);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1587_13888_13909(System.Management.Automation.StartableJob
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 13888, 13909);
return return_v;
}


System.Management.Automation.JobState
f_1587_13888_13915(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 13888, 13915);
return return_v;
}


string
f_1587_13968_14023()
{
var return_v = RemotingErrorIdStrings.ThrottlingJobChildAlreadyRunning;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 13968, 14023);
return return_v;
}


System.ArgumentException
f_1587_13946_14036(string
message,string
paramName)
{
var return_v = new System.ArgumentException( message, paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 13946, 14036);
return return_v;
}


int
f_1587_14051_14075(System.Management.Automation.ThrottlingJob
this_param)
{
this_param.AssertNotDisposed();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 14051, 14075);
return 0;
}


bool
f_1587_14197_14218(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.IsEndOfChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 14197, 14218);
return return_v;
}


string
f_1587_14256_14321()
{
var return_v = RemotingErrorIdStrings.ThrottlingJobChildAddedAfterEndOfChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 14256, 14321);
return return_v;
}


System.InvalidOperationException
f_1587_14226_14322(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 14226, 14322);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1587_14478_14512(System.Management.Automation.JobState
state)
{
var return_v = new System.Management.Automation.JobStateInfo( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 14478, 14512);
return return_v;
}


System.Guid
f_1587_14715_14734(System.Management.Automation.StartableJob
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 14715, 14734);
return return_v;
}


bool
f_1587_14672_14735(System.Collections.Generic.HashSet<System.Guid>
this_param,System.Guid
item)
{
var return_v = this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 14672, 14735);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1587_14775_14789(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 14775, 14789);
return return_v;
}


int
f_1587_14775_14803(System.Collections.Generic.IList<System.Management.Automation.Job>
this_param,System.Management.Automation.StartableJob
item)
{
this_param.Add( (System.Management.Automation.Job)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 14775, 14803);
return 0;
}


string
f_1587_14845_14862(System.Management.Automation.StartableJob
this_param)
{
var return_v = this_param.Location;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 14845, 14862);
return return_v;
}


bool
f_1587_14822_14863(System.Collections.Generic.HashSet<string>
this_param,string
item)
{
var return_v = this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 14822, 14863);
return return_v;
}


int
f_1587_14977_15017(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.CountOfRunningOrReadyToRunChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 14977, 15017);
return return_v;
}


int
f_1587_14925_15018(System.Management.Automation.ThrottlingJob
this_param,int
currentCount)
{
this_param.WriteWarningAboutHighUsageOfFlowControlBuffers( (long)currentCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 14925, 15018);
return 0;
}


int
f_1587_15041_15081(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.CountOfRunningOrReadyToRunChildJobs ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 15041, 15081);
return return_v;
}


int
f_1587_15144_15206(System.Collections.Generic.Queue<System.Action>
this_param,System.Action
item)
{
this_param.Enqueue( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 15144, 15206);
return 0;
}


int
f_1587_15368_15387(System.Action
this_param)
{
this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 15368, 15387);
return 0;
}


System.Management.Automation.JobState
f_1587_15539_15560(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 15539, 15560);
return return_v;
}


System.Exception
f_1587_15562_15584(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 15562, 15584);
return return_v;
}


int
f_1587_15522_15585(System.Management.Automation.ThrottlingJob
this_param,System.Management.Automation.JobState
state,System.Exception
reason)
{
this_param.SetJobState( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 15522, 15585);
return 0;
}


System.Management.Automation.ThrottlingJobChildAddedEventArgs
f_1587_15653_15699(System.Management.Automation.StartableJob
addedChildJob)
{
var return_v = new System.Management.Automation.ThrottlingJobChildAddedEventArgs( (System.Management.Automation.Job)addedChildJob);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 15653, 15699);
return return_v;
}


int
f_1587_15617_15700(System.EventHandler<System.Management.Automation.ThrottlingJobChildAddedEventArgs>
eventHandler,System.Management.Automation.ThrottlingJob
sender,System.Management.Automation.ThrottlingJobChildAddedEventArgs
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.ThrottlingJobChildAddedEventArgs>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 15617, 15700);
return 0;
}


int
f_1587_15717_15779(System.Management.Automation.StartableJob
this_param,System.Func<int>
parentActivityIdGetter)
{
this_param.SetParentActivityIdGetter( parentActivityIdGetter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 15717, 15779);
return 0;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1587_15909_15925(System.Management.Automation.StartableJob
this_param)
{
var return_v = this_param.Results;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 15909, 15925);
return return_v;
}


int
f_1587_16030_16070(System.Management.Automation.ThrottlingJob
this_param,System.Management.Automation.StartableJob
childJob)
{
this_param.EnqueueReadyToRunChildJob( childJob);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 16030, 16070);
return 0;
}


int
f_1587_16087_16137(System.Management.Automation.ThrottlingJob
this_param,bool
minimizeFrequentUpdates)
{
this_param.ReportProgress( minimizeFrequentUpdates: minimizeFrequentUpdates);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 16087, 16137);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,13662,16149);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,13662,16149);
}
		}

private void childJob_ResultsAdded(object sender, DataAddedEventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,16161,16899);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,16257,16407);

f_1587_16257_16406(_jobResultsThrottlingSemaphore != null, "JobResultsThrottlingSemaphore should be non-null if childJob_ResultsAdded handled is registered");
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,16457,16538);

long 
jobResultsUpdatedCount = f_1587_16487_16537(ref _jobResultsCurrentCount)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,16556,16632);

f_1587_16556_16631(                this, jobResultsUpdatedCount);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,16652,16720);

f_1587_16652_16719(
                _jobResultsThrottlingSemaphore, f_1587_16688_16718(_cancellationTokenSource));
            }
            catch (ObjectDisposedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1587,16749,16810);
DynAbs.Tracing.TraceSender.TraceExitCatch(1587,16749,16810);
            }
            catch (OperationCanceledException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1587,16824,16888);
DynAbs.Tracing.TraceSender.TraceExitCatch(1587,16824,16888);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,16161,16899);

int
f_1587_16257_16406(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 16257, 16406);
return 0;
}


long
f_1587_16487_16537(ref long
location)
{
var return_v = Interlocked.Increment( ref location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 16487, 16537);
return return_v;
}


int
f_1587_16556_16631(System.Management.Automation.ThrottlingJob
this_param,long
currentCount)
{
this_param.WriteWarningAboutHighUsageOfFlowControlBuffers( currentCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 16556, 16631);
return 0;
}


System.Threading.CancellationToken
f_1587_16688_16718(System.Threading.CancellationTokenSource
this_param)
{
var return_v = this_param.Token;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 16688, 16718);
return return_v;
}


int
f_1587_16652_16719(System.Threading.SemaphoreSlim
this_param,System.Threading.CancellationToken
cancellationToken)
{
this_param.Wait( cancellationToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 16652, 16719);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,16161,16899);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,16161,16899);
}
		}

private readonly object _alreadyWroteFlowControlBuffersHighMemoryUsageWarningLock ;

private bool _alreadyWroteFlowControlBuffersHighMemoryUsageWarning;

private const long 
FlowControlBuffersHighMemoryUsageThreshold = 30000
;

private void WriteWarningAboutHighUsageOfFlowControlBuffers(long currentCount)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,17177,18090);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,17280,17352) || true) && (!_cmdletMode)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,17280,17352);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,17330,17337);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,17280,17352);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,17368,17485) || true) && (currentCount < FlowControlBuffersHighMemoryUsageThreshold)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,17368,17485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,17463,17470);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,17368,17485);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,17507,17564);

            lock (_alreadyWroteFlowControlBuffersHighMemoryUsageWarningLock)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,17598,17723) || true) && (_alreadyWroteFlowControlBuffersHighMemoryUsageWarning)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,17598,17723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,17697,17704);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,17598,17723);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,17743,17804);

_alreadyWroteFlowControlBuffersHighMemoryUsageWarning = true;
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,17835,18031);

string 
warningMessage = f_1587_17859_18030(f_1587_17891_17919(), f_1587_17938_17998(), f_1587_18017_18029(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,18045,18079);

f_1587_18045_18078(            this, warningMessage);
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,17177,18090);

System.Globalization.CultureInfo
f_1587_17891_17919()
{
var return_v =                 CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 17891, 17919);
return return_v;
}


string
f_1587_17938_17998()
{
var return_v =                 RemotingErrorIdStrings.ThrottlingJobFlowControlMemoryWarning;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 17938, 17998);
return return_v;
}


string
f_1587_18017_18029(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 18017, 18029);
return return_v;
}


string
f_1587_17859_18030(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 17859, 18030);
return return_v;
}


int
f_1587_18045_18078(System.Management.Automation.ThrottlingJob
this_param,string
message)
{
this_param.WriteWarning( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 18045, 18078);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,17177,18090);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,17177,18090);
}
		}

        internal event EventHandler<ThrottlingJobChildAddedEventArgs> 
ChildJobAdded
;

private int _maximumConcurrentChildJobs;

private int _extraCapacityForRunningQueryJobs;

private int _extraCapacityForRunningAllJobs;

private bool _inBoostModeToPreventQueryJobDeadlock;

private Queue<StartableJob> _readyToRunQueryJobs;

private Queue<StartableJob> _readyToRunRegularJobs;

private Queue<Action> _actionsForUnblockingChildAdditions;

private int _maxReadyToRunJobs;

private readonly SemaphoreSlim _jobResultsThrottlingSemaphore;

private long _jobResultsCurrentCount;

private static readonly int s_maximumReadyToRunJobs ;

private void SetupThrottlingQueue(int maximumConcurrentChildJobs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,18833,19701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,18923,19028);

_maximumConcurrentChildJobs = (DynAbs.Tracing.TraceSender.Conditional_F1(1587, 18953, 18983)||((maximumConcurrentChildJobs > 0 &&DynAbs.Tracing.TraceSender.Conditional_F2(1587, 18986, 19012))||DynAbs.Tracing.TraceSender.Conditional_F3(1587, 19015, 19027)))?maximumConcurrentChildJobs :int.MaxValue;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,19042,19251) || true) && (_cmdletMode)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,19042,19251);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,19091,19136);

_maxReadyToRunJobs = s_maximumReadyToRunJobs;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,19042,19251);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,19042,19251);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,19202,19236);

_maxReadyToRunJobs = int.MaxValue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,19042,19251);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,19267,19329);

_extraCapacityForRunningAllJobs = _maximumConcurrentChildJobs;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,19343,19428);

_extraCapacityForRunningQueryJobs = f_1587_19379_19427(1, _extraCapacityForRunningAllJobs / 2);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,19444,19490);

_inBoostModeToPreventQueryJobDeadlock = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,19504,19553);

_readyToRunQueryJobs = f_1587_19527_19552();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,19567,19618);

_readyToRunRegularJobs = f_1587_19592_19617();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,19632,19690);

_actionsForUnblockingChildAdditions = f_1587_19670_19689();
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,18833,19701);

int
f_1587_19379_19427(int
val1,int
val2)
{
var return_v = Math.Max( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 19379, 19427);
return return_v;
}


System.Collections.Generic.Queue<System.Management.Automation.StartableJob>
f_1587_19527_19552()
{
var return_v = new System.Collections.Generic.Queue<System.Management.Automation.StartableJob>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 19527, 19552);
return return_v;
}


System.Collections.Generic.Queue<System.Management.Automation.StartableJob>
f_1587_19592_19617()
{
var return_v = new System.Collections.Generic.Queue<System.Management.Automation.StartableJob>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 19592, 19617);
return return_v;
}


System.Collections.Generic.Queue<System.Action>
f_1587_19670_19689()
{
var return_v = new System.Collections.Generic.Queue<System.Action>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 19670, 19689);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,18833,19701);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,18833,19701);
}
		}

private void StartChildJobIfPossible()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,19713,20904);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,19776,19815);

StartableJob 
readyToRunChildJob = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,19835,19846);
            lock (_lockObject)
            {
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,19880,20753);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,19923,20372) || true) && ((f_1587_19928_19954(_readyToRunQueryJobs)> 0) &&(DynAbs.Tracing.TraceSender.Expression_True(1587, 19927, 20027)&&                        (_extraCapacityForRunningQueryJobs > 0) )&&(DynAbs.Tracing.TraceSender.Expression_True(1587, 19927, 20093)&&                        (_extraCapacityForRunningAllJobs > 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,19923,20372);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,20143,20179);

_extraCapacityForRunningQueryJobs--;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,20205,20239);

_extraCapacityForRunningAllJobs--;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,20265,20317);

readyToRunChildJob = f_1587_20286_20316(_readyToRunQueryJobs);
DynAbs.Tracing.TraceSender.TraceBreak(1587,20343,20349);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,19923,20372);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,20396,20719) || true) && ((f_1587_20401_20429(_readyToRunRegularJobs)> 0) &&(DynAbs.Tracing.TraceSender.Expression_True(1587, 20400, 20500)&&                        (_extraCapacityForRunningAllJobs > 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,20396,20719);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,20550,20584);

_extraCapacityForRunningAllJobs--;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,20610,20664);

readyToRunChildJob = f_1587_20631_20663(_readyToRunRegularJobs);
DynAbs.Tracing.TraceSender.TraceBreak(1587,20690,20696);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,20396,20719);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,19880,20753);
}
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,19880,20753) || true) && (false)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1587,19880,20753);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1587,19880,20753);
}}            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,20784,20893) || true) && (readyToRunChildJob != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,20784,20893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,20848,20878);

f_1587_20848_20877(                readyToRunChildJob);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,20784,20893);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,19713,20904);

int
f_1587_19928_19954(System.Collections.Generic.Queue<System.Management.Automation.StartableJob>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 19928, 19954);
return return_v;
}


System.Management.Automation.StartableJob
f_1587_20286_20316(System.Collections.Generic.Queue<System.Management.Automation.StartableJob>
this_param)
{
var return_v = this_param.Dequeue();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 20286, 20316);
return return_v;
}


int
f_1587_20401_20429(System.Collections.Generic.Queue<System.Management.Automation.StartableJob>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 20401, 20429);
return return_v;
}


System.Management.Automation.StartableJob
f_1587_20631_20663(System.Collections.Generic.Queue<System.Management.Automation.StartableJob>
this_param)
{
var return_v = this_param.Dequeue();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 20631, 20663);
return return_v;
}


int
f_1587_20848_20877(System.Management.Automation.StartableJob
this_param)
{
this_param.StartJob();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 20848, 20877);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,19713,20904);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,19713,20904);
}
		}

private void EnqueueReadyToRunChildJob(StartableJob childJob)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,20916,21781);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,21008,21019);
            lock (_lockObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,21053,21140);

bool 
isQueryJob = f_1587_21071_21139(_setOfChildJobsThatCanAddMoreChildJobs, f_1587_21119_21138(childJob))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,21158,21456) || true) && (isQueryJob &&(DynAbs.Tracing.TraceSender.Expression_True(1587, 21162, 21235)&&                    !_inBoostModeToPreventQueryJobDeadlock )&&(DynAbs.Tracing.TraceSender.Expression_True(1587, 21162, 21294)&&                    (_maximumConcurrentChildJobs == 1)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,21158,21456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,21336,21381);

_inBoostModeToPreventQueryJobDeadlock = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,21403,21437);

_extraCapacityForRunningAllJobs++;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,21158,21456);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,21476,21713) || true) && (isQueryJob)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,21476,21713);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,21532,21571);

f_1587_21532_21570(                    _readyToRunQueryJobs, childJob);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,21476,21713);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,21476,21713);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,21653,21694);

f_1587_21653_21693(                    _readyToRunRegularJobs, childJob);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,21476,21713);
}
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,21744,21770);

f_1587_21744_21769(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,20916,21781);

System.Guid
f_1587_21119_21138(System.Management.Automation.StartableJob
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 21119, 21138);
return return_v;
}


bool
f_1587_21071_21139(System.Collections.Generic.HashSet<System.Guid>
this_param,System.Guid
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 21071, 21139);
return return_v;
}


int
f_1587_21532_21570(System.Collections.Generic.Queue<System.Management.Automation.StartableJob>
this_param,System.Management.Automation.StartableJob
item)
{
this_param.Enqueue( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 21532, 21570);
return 0;
}


int
f_1587_21653_21693(System.Collections.Generic.Queue<System.Management.Automation.StartableJob>
this_param,System.Management.Automation.StartableJob
item)
{
this_param.Enqueue( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 21653, 21693);
return 0;
}


int
f_1587_21744_21769(System.Management.Automation.ThrottlingJob
this_param)
{
this_param.StartChildJobIfPossible();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 21744, 21769);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,20916,21781);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,20916,21781);
}
		}

private void MakeRoomForRunningOtherJobs(Job completedChildJob)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,21793,22676);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,21887,21898);
            lock (_lockObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,21932,21966);

_extraCapacityForRunningAllJobs++;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,21986,22082);

bool 
isQueryJob = f_1587_22004_22081(_setOfChildJobsThatCanAddMoreChildJobs, f_1587_22052_22080(completedChildJob))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,22100,22608) || true) && (isQueryJob)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,22100,22608);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,22156,22232);

f_1587_22156_22231(                    _setOfChildJobsThatCanAddMoreChildJobs, f_1587_22202_22230(completedChildJob));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,22256,22292);

_extraCapacityForRunningQueryJobs++;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,22314,22589) || true) && (_inBoostModeToPreventQueryJobDeadlock &&(DynAbs.Tracing.TraceSender.Expression_True(1587, 22318, 22410)&&(f_1587_22360_22404(_setOfChildJobsThatCanAddMoreChildJobs)== 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,22314,22589);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,22460,22506);

_inBoostModeToPreventQueryJobDeadlock = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,22532,22566);

_extraCapacityForRunningAllJobs--;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,22314,22589);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,22100,22608);
}
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,22639,22665);

f_1587_22639_22664(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,21793,22676);

System.Guid
f_1587_22052_22080(System.Management.Automation.Job
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 22052, 22080);
return return_v;
}


bool
f_1587_22004_22081(System.Collections.Generic.HashSet<System.Guid>
this_param,System.Guid
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 22004, 22081);
return return_v;
}


System.Guid
f_1587_22202_22230(System.Management.Automation.Job
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 22202, 22230);
return return_v;
}


bool
f_1587_22156_22231(System.Collections.Generic.HashSet<System.Guid>
this_param,System.Guid
item)
{
var return_v = this_param.Remove( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 22156, 22231);
return return_v;
}


int
f_1587_22360_22404(System.Collections.Generic.HashSet<System.Guid>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 22360, 22404);
return return_v;
}


int
f_1587_22639_22664(System.Management.Automation.ThrottlingJob
this_param)
{
this_param.StartChildJobIfPossible();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 22639, 22664);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,21793,22676);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,21793,22676);
}
		}

private void FigureOutIfThrottlingJobIsCompleted()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,22688,23922);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,22763,22801);

JobStateInfo 
finalJobStateInfo = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,22821,22832);
            lock (_lockObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,22866,23693) || true) && (f_1587_22870_22899(this)&&(DynAbs.Tracing.TraceSender.Expression_True(1587, 22870, 22944)&&!f_1587_22904_22944(this, f_1587_22920_22943(f_1587_22920_22937(this)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,22866,23693);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,22986,23674) || true) && (_isStopping)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,22986,23674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,23051,23112);

finalJobStateInfo = f_1587_23071_23111(JobState.Stopped, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,22986,23674);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,22986,23674);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,23162,23674) || true) && (_countOfFailedChildJobs > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,23162,23674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,23243,23303);

finalJobStateInfo = f_1587_23263_23302(JobState.Failed, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,23162,23674);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,23162,23674);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,23353,23674) || true) && (_countOfStoppedChildJobs > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,23353,23674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,23435,23496);

finalJobStateInfo = f_1587_23455_23495(JobState.Stopped, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,23353,23674);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,23353,23674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,23594,23651);

finalJobStateInfo = f_1587_23614_23650(JobState.Completed);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,23353,23674);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,23162,23674);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,22986,23674);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,22866,23693);
}
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,23724,23911) || true) && (finalJobStateInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,23724,23911);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,23787,23855);

f_1587_23787_23854(                this, f_1587_23804_23827(finalJobStateInfo), f_1587_23829_23853(finalJobStateInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,23873,23896);

f_1587_23873_23895(                this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,23724,23911);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,22688,23922);

bool
f_1587_22870_22899(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.IsThrottlingJobCompleted ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 22870, 22899);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1587_22920_22937(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 22920, 22937);
return return_v;
}


System.Management.Automation.JobState
f_1587_22920_22943(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 22920, 22943);
return return_v;
}


bool
f_1587_22904_22944(System.Management.Automation.ThrottlingJob
this_param,System.Management.Automation.JobState
state)
{
var return_v = this_param.IsFinishedState( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 22904, 22944);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1587_23071_23111(System.Management.Automation.JobState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.JobStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 23071, 23111);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1587_23263_23302(System.Management.Automation.JobState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.JobStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 23263, 23302);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1587_23455_23495(System.Management.Automation.JobState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.JobStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 23455, 23495);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1587_23614_23650(System.Management.Automation.JobState
state)
{
var return_v = new System.Management.Automation.JobStateInfo( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 23614, 23650);
return return_v;
}


System.Management.Automation.JobState
f_1587_23804_23827(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 23804, 23827);
return return_v;
}


System.Exception
f_1587_23829_23853(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 23829, 23853);
return return_v;
}


int
f_1587_23787_23854(System.Management.Automation.ThrottlingJob
this_param,System.Management.Automation.JobState
state,System.Exception
reason)
{
this_param.SetJobState( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 23787, 23854);
return 0;
}


int
f_1587_23873_23895(System.Management.Automation.ThrottlingJob
this_param)
{
this_param.CloseAllStreams();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 23873, 23895);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,22688,23922);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,22688,23922);
}
		}

internal void EndOfChildJobs()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,24082,24348);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,24137,24162);

f_1587_24137_24161(            this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,24182,24193);
            lock (_lockObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,24227,24263);

_ownerWontSubmitNewChildJobs = true;
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,24294,24337);

f_1587_24294_24336(
            this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,24082,24348);

int
f_1587_24137_24161(System.Management.Automation.ThrottlingJob
this_param)
{
this_param.AssertNotDisposed();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 24137, 24161);
return 0;
}


int
f_1587_24294_24336(System.Management.Automation.ThrottlingJob
this_param)
{
this_param.FigureOutIfThrottlingJobIsCompleted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 24294, 24336);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,24082,24348);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,24082,24348);
}
		}

public override void StopJob()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,24511,25443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,24566,24599);

List<Job> 
childJobsToStop = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,24619,24630);
            lock (_lockObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,24664,24863) || true) && (!(_isStopping ||(DynAbs.Tracing.TraceSender.Expression_False(1587, 24670, 24714)||f_1587_24685_24714(this))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,24664,24863);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,24757,24776);

_isStopping = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,24798,24844);

childJobsToStop = f_1587_24816_24843(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,24664,24863);
}
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,24894,25392) || true) && (childJobsToStop != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,24894,25392);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,24955,24991);

f_1587_24955_24990(                this, JobState.Stopping);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,25011,25045);

f_1587_25011_25044(
                _cancellationTokenSource);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,25063,25314);
foreach(Job childJob in f_1587_25088_25103_I(childJobsToStop) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,25063,25314);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,25145,25295) || true) && (!f_1587_25150_25203(childJob, f_1587_25175_25202(f_1587_25175_25196(childJob))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,25145,25295);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,25253,25272);

f_1587_25253_25271(                        childJob);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,25145,25295);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,25063,25314);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1587,1,252);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1587,1,252);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,25334,25377);

f_1587_25334_25376(
                this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,24894,25392);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,25408,25432);

f_1587_25408_25431(f_1587_25408_25421(this));
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,24511,25443);

bool
f_1587_24685_24714(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.IsThrottlingJobCompleted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 24685, 24714);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1587_24816_24843(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.GetChildJobsSnapshot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 24816, 24843);
return return_v;
}


int
f_1587_24955_24990(System.Management.Automation.ThrottlingJob
this_param,System.Management.Automation.JobState
state)
{
this_param.SetJobState( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 24955, 24990);
return 0;
}


int
f_1587_25011_25044(System.Threading.CancellationTokenSource
this_param)
{
this_param.Cancel();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 25011, 25044);
return 0;
}


System.Management.Automation.JobStateInfo
f_1587_25175_25196(System.Management.Automation.Job
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 25175, 25196);
return return_v;
}


System.Management.Automation.JobState
f_1587_25175_25202(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 25175, 25202);
return return_v;
}


bool
f_1587_25150_25203(System.Management.Automation.Job
this_param,System.Management.Automation.JobState
state)
{
var return_v = this_param.IsFinishedState( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 25150, 25203);
return return_v;
}


int
f_1587_25253_25271(System.Management.Automation.Job
this_param)
{
this_param.StopJob();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 25253, 25271);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1587_25088_25103_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 25088, 25103);
return return_v;
}


int
f_1587_25334_25376(System.Management.Automation.ThrottlingJob
this_param)
{
this_param.FigureOutIfThrottlingJobIsCompleted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 25334, 25376);
return 0;
}


System.Threading.WaitHandle
f_1587_25408_25421(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.Finished;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 25408, 25421);
return return_v;
}


bool
f_1587_25408_25431(System.Threading.WaitHandle
this_param)
{
var return_v = this_param.WaitOne();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 25408, 25431);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,24511,25443);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,24511,25443);
}
		}

private bool _isStopping;

private readonly CancellationTokenSource _cancellationTokenSource ;

private void childJob_StateChanged(object sender, JobStateEventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,25600,29162);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,25695,25833);

f_1587_25695_25832(sender != null, "Only our internal implementation of Job should raise this event and it should make sure that sender != null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,25847,25983);

f_1587_25847_25982(sender is Job, "Only our internal implementation of Job should raise this event and it should make sure that sender is Job");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,25997,26024);

var 
childJob = (Job)sender
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,26040,26645) || true) && ((f_1587_26045_26073(f_1587_26045_26067(e))== JobState.Blocked) &&(DynAbs.Tracing.TraceSender.Expression_True(1587, 26044, 26140)&&(f_1587_26099_26119(f_1587_26099_26113(e))!= JobState.Blocked)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,26040,26645);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,26174,26209);

bool 
parentJobGotUnblocked = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,26233,26244);
                lock (_lockObject)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,26286,26313);

_countOfBlockedChildJobs--;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,26335,26470) || true) && (_countOfBlockedChildJobs == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,26335,26470);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,26418,26447);

parentJobGotUnblocked = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,26335,26470);
}
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,26509,26630) || true) && (parentJobGotUnblocked)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,26509,26630);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,26576,26611);

f_1587_26576_26610(                    this, JobState.Running);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,26509,26630);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,26040,26645);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,26661,29092);

switch (f_1587_26669_26689(f_1587_26669_26683(e)))
            {

case JobState.Blocked:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,26661,29092);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,26813,26824);
                    lock (_lockObject)
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,26874,26901);

_countOfBlockedChildJobs++;
                    }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,26948,26983);

f_1587_26948_26982(
                    this, JobState.Blocked);
DynAbs.Tracing.TraceSender.TraceBreak(1587,27005,27011);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,26661,29092);

case JobState.Failed:
                case JobState.Stopped:
                case JobState.Completed:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,26661,29092);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,27194,27241);

childJob.StateChanged -= childJob_StateChanged;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,27263,27306);

f_1587_27263_27305(                    this, childJob);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,27334,27345);
                    lock (_lockObject)
                    {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,27395,27939) || true) && (f_1587_27399_27419(f_1587_27399_27413(e))== JobState.Failed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,27395,27939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,27496,27522);

_countOfFailedChildJobs++;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,27395,27939);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,27395,27939);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,27580,27939) || true) && (f_1587_27584_27604(f_1587_27584_27598(e))== JobState.Stopped)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,27580,27939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,27682,27709);

_countOfStoppedChildJobs++;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,27580,27939);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,27580,27939);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,27767,27939) || true) && (f_1587_27771_27791(f_1587_27771_27785(e))== JobState.Completed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,27767,27939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,27871,27912);

_countOfSuccessfullyCompletedChildJobs++;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,27767,27939);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,27580,27939);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,27395,27939);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,27967,28302) || true) && (f_1587_27971_28012(_actionsForUnblockingChildAdditions)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,27967,28302);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,28074,28131);

Action 
a = f_1587_28085_28130(_actionsForUnblockingChildAdditions)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,28161,28275) || true) && (a != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,28161,28275);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,28240,28244);

f_1587_28240_28243(a);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,28161,28275);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,27967,28302);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,28330,28834) || true) && (_cmdletMode)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,28330,28834);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,28403,28597);
foreach(PSStreamObject streamObject in f_1587_28443_28469_I(f_1587_28443_28469(f_1587_28443_28459(childJob))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,28403,28597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,28535,28566);

f_1587_28535_28565(f_1587_28535_28547(this), streamObject);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,28403,28597);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1587,1,195);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1587,1,195);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,28629,28661);

f_1587_28629_28660(f_1587_28629_28643(this), childJob);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,28691,28758);

f_1587_28691_28757(                            _setOfChildJobsThatCanAddMoreChildJobs, f_1587_28737_28756(childJob));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,28788,28807);

f_1587_28788_28806(                            childJob);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,28330,28834);
}
                    }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,28881,28958);

f_1587_28881_28957(
                    this, minimizeFrequentUpdates: f_1587_28926_28956_M(!this.IsThrottlingJobCompleted));
DynAbs.Tracing.TraceSender.TraceBreak(1587,28980,28986);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,26661,29092);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,26661,29092);
DynAbs.Tracing.TraceSender.TraceBreak(1587,29071,29077);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,26661,29092);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,29108,29151);

f_1587_29108_29150(
            this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,25600,29162);

int
f_1587_25695_25832(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 25695, 25832);
return 0;
}


int
f_1587_25847_25982(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 25847, 25982);
return 0;
}


System.Management.Automation.JobStateInfo
f_1587_26045_26067(System.Management.Automation.JobStateEventArgs
this_param)
{
var return_v = this_param.PreviousJobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 26045, 26067);
return return_v;
}


System.Management.Automation.JobState
f_1587_26045_26073(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 26045, 26073);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1587_26099_26113(System.Management.Automation.JobStateEventArgs
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 26099, 26113);
return return_v;
}


System.Management.Automation.JobState
f_1587_26099_26119(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 26099, 26119);
return return_v;
}


int
f_1587_26576_26610(System.Management.Automation.ThrottlingJob
this_param,System.Management.Automation.JobState
state)
{
this_param.SetJobState( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 26576, 26610);
return 0;
}


System.Management.Automation.JobStateInfo
f_1587_26669_26683(System.Management.Automation.JobStateEventArgs
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 26669, 26683);
return return_v;
}


System.Management.Automation.JobState
f_1587_26669_26689(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 26669, 26689);
return return_v;
}


int
f_1587_26948_26982(System.Management.Automation.ThrottlingJob
this_param,System.Management.Automation.JobState
state)
{
this_param.SetJobState( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 26948, 26982);
return 0;
}


int
f_1587_27263_27305(System.Management.Automation.ThrottlingJob
this_param,System.Management.Automation.Job
completedChildJob)
{
this_param.MakeRoomForRunningOtherJobs( completedChildJob);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 27263, 27305);
return 0;
}


System.Management.Automation.JobStateInfo
f_1587_27399_27413(System.Management.Automation.JobStateEventArgs
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 27399, 27413);
return return_v;
}


System.Management.Automation.JobState
f_1587_27399_27419(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 27399, 27419);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1587_27584_27598(System.Management.Automation.JobStateEventArgs
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 27584, 27598);
return return_v;
}


System.Management.Automation.JobState
f_1587_27584_27604(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 27584, 27604);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1587_27771_27785(System.Management.Automation.JobStateEventArgs
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 27771, 27785);
return return_v;
}


System.Management.Automation.JobState
f_1587_27771_27791(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 27771, 27791);
return return_v;
}


int
f_1587_27971_28012(System.Collections.Generic.Queue<System.Action>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 27971, 28012);
return return_v;
}


System.Action
f_1587_28085_28130(System.Collections.Generic.Queue<System.Action>
this_param)
{
var return_v = this_param.Dequeue();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 28085, 28130);
return return_v;
}


int
f_1587_28240_28243(System.Action
this_param)
{
this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 28240, 28243);
return 0;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1587_28443_28459(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Results;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 28443, 28459);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1587_28443_28469(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
this_param)
{
var return_v = this_param.ReadAll();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 28443, 28469);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1587_28535_28547(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.Results;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 28535, 28547);
return return_v;
}


int
f_1587_28535_28565(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
this_param,System.Management.Automation.Remoting.Internal.PSStreamObject
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 28535, 28565);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1587_28443_28469_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 28443, 28469);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1587_28629_28643(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 28629, 28643);
return return_v;
}


bool
f_1587_28629_28660(System.Collections.Generic.IList<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
var return_v = this_param.Remove( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 28629, 28660);
return return_v;
}


System.Guid
f_1587_28737_28756(System.Management.Automation.Job
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 28737, 28756);
return return_v;
}


bool
f_1587_28691_28757(System.Collections.Generic.HashSet<System.Guid>
this_param,System.Guid
item)
{
var return_v = this_param.Remove( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 28691, 28757);
return return_v;
}


int
f_1587_28788_28806(System.Management.Automation.Job
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 28788, 28806);
return 0;
}


bool
f_1587_28926_28956_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 28926, 28956);
return return_v;
}


int
f_1587_28881_28957(System.Management.Automation.ThrottlingJob
this_param,bool
minimizeFrequentUpdates)
{
this_param.ReportProgress( minimizeFrequentUpdates: minimizeFrequentUpdates);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 28881, 28957);
return 0;
}


int
f_1587_29108_29150(System.Management.Automation.ThrottlingJob
this_param)
{
this_param.FigureOutIfThrottlingJobIsCompleted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 29108, 29150);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,25600,29162);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,25600,29162);
}
		}

private List<Job> GetChildJobsSnapshot()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,29174,29353);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,29245,29256);
            lock (_lockObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,29290,29327);

return f_1587_29297_29326(f_1587_29311_29325(this));
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,29174,29353);

System.Collections.Generic.IList<System.Management.Automation.Job>
f_1587_29311_29325(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 29311, 29325);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1587_29297_29326(System.Collections.Generic.IList<System.Management.Automation.Job>
collection)
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>( (System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 29297, 29326);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,29174,29353);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,29174,29353);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override bool HasMoreData
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,29687,29840);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,29723,29825);

return f_1587_29730_29795(f_1587_29730_29757(this), childJob => childJob.HasMoreData)||(DynAbs.Tracing.TraceSender.Expression_False(1587, 29730, 29824)||(f_1587_29800_29818(f_1587_29800_29812(this))!= 0));
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,29687,29840);

System.Collections.Generic.List<System.Management.Automation.Job>
f_1587_29730_29757(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.GetChildJobsSnapshot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 29730, 29757);
return return_v;
}


bool
f_1587_29730_29795(System.Collections.Generic.List<System.Management.Automation.Job>
source,System.Func<System.Management.Automation.Job, bool>
predicate)
{
var return_v = source.Any<System.Management.Automation.Job>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 29730, 29795);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1587_29800_29812(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.Results;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 29800, 29812);
return return_v;
}


int
f_1587_29800_29818(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 29800, 29818);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,29630,29851);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,29630,29851);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override string Location
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,30074,30248);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,30116,30127);
                lock (_lockObject)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,30169,30214);

return f_1587_30176_30213(", ", _childJobLocations);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,30074,30248);

string
f_1587_30176_30213(string
separator,System.Collections.Generic.HashSet<string>
values)
{
var return_v = string.Join( separator, (System.Collections.Generic.IEnumerable<string?>)values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 30176, 30213);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,30018,30259);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,30018,30259);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private readonly HashSet<string> _childJobLocations ;

public override string StatusMessage
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,30552,31354);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,30588,30611);

int 
completedChildJobs
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,30629,30648);

int 
totalChildJobs
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,30672,30683);
                lock (_lockObject)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,30725,30776);

completedChildJobs = f_1587_30746_30775(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,30798,30836);

totalChildJobs = _countOfAllChildJobs;
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,30875,30957);

string 
totalChildJobsString = f_1587_30905_30956(totalChildJobs, f_1587_30929_30955())
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,30975,31090) || true) && (f_1587_30979_31001_M(!this.IsEndOfChildJobs))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,30975,31090);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,31043,31071);

totalChildJobsString += "+";
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,30975,31090);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,31110,31339);

return f_1587_31117_31338(f_1587_31153_31181(), f_1587_31204_31253(), completedChildJobs, totalChildJobsString);
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,30552,31354);

int
f_1587_30746_30775(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.CountOfFinishedChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 30746, 30775);
return return_v;
}


System.Globalization.CultureInfo
f_1587_30929_30955()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 30929, 30955);
return return_v;
}


string
f_1587_30905_30956(int
this_param,System.Globalization.CultureInfo
provider)
{
var return_v = this_param.ToString( (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 30905, 30956);
return return_v;
}


bool
f_1587_30979_31001_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 30979, 31001);
return return_v;
}


System.Globalization.CultureInfo
f_1587_31153_31181()
{
var return_v =                     CultureInfo.CurrentUICulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 31153, 31181);
return return_v;
}


string
f_1587_31204_31253()
{
var return_v =                     RemotingErrorIdStrings.ThrottlingJobStatusMessage;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 31204, 31253);
return return_v;
}


string
f_1587_31117_31338(System.Globalization.CultureInfo
provider,string
format,int
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 31117, 31338);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,30491,31365);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,30491,31365);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override void ForwardAvailableResultsToCmdlet(Cmdlet cmdlet)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,31427,31782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,31521,31546);

f_1587_31521_31545(            this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,31562,31607);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ForwardAvailableResultsToCmdlet(cmdlet),1587,31562,31606);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,31621,31771);
foreach(Job childJob in f_1587_31646_31673_I(f_1587_31646_31673(this)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,31621,31771);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,31707,31756);

f_1587_31707_31755(                childJob, cmdlet);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,31621,31771);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1587,1,151);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1587,1,151);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1587,31427,31782);

int
f_1587_31521_31545(System.Management.Automation.ThrottlingJob
this_param)
{
this_param.AssertNotDisposed();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 31521, 31545);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1587_31646_31673(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.GetChildJobsSnapshot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 31646, 31673);
return return_v;
}


int
f_1587_31707_31755(System.Management.Automation.Job
this_param,System.Management.Automation.Cmdlet
cmdlet)
{
this_param.ForwardAvailableResultsToCmdlet( cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 31707, 31755);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1587_31646_31673_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 31646, 31673);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,31427,31782);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,31427,31782);
}
		}
private class ForwardingHelper : IDisposable
{
internal static readonly int AggregationQueueMaxCapacity ;

private readonly ThrottlingJob _throttlingJob;

private readonly object _myLock;

private readonly BlockingCollection<PSStreamObject> _aggregatedResults;

private readonly HashSet<Job> _monitoredJobs;

private readonly CancellationTokenSource _cancellationTokenSource ;

private bool _disposed;

private ForwardingHelper(ThrottlingJob throttlingJob)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1587,32934,33245);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,32560,32574);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,32615,32622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,32689,32707);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,32752,32766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,32824,32880);
this._cancellationTokenSource = f_1587_32851_32880();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,32908,32917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,44431,44456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,33020,33051);

_throttlingJob = throttlingJob;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,33071,33094);

_myLock = f_1587_33081_33093();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,33112,33148);

_monitoredJobs = f_1587_33129_33147();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,33168,33230);

_aggregatedResults = f_1587_33189_33229();
DynAbs.Tracing.TraceSender.TraceExitConstructor(1587,32934,33245);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,32934,33245);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,32934,33245);
}
		}

private void StartMonitoringJob(Job job)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,33261,33997);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,33340,33347);
                lock (_myLock)
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,33389,33511) || true) && (_disposed ||(DynAbs.Tracing.TraceSender.Expression_False(1587, 33393, 33431)||_stoppedMonitoringAllJobs))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,33389,33511);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,33481,33488);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,33389,33511);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,33535,33647) || true) && (f_1587_33539_33567(_monitoredJobs, job))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,33535,33647);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,33617,33624);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,33535,33647);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,33671,33695);

f_1587_33671_33694(
                    _monitoredJobs, job);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,33719,33779);

f_1587_33719_33730(job).DataAdded += this.MonitoredJobResults_DataAdded;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,33801,33847);

job.StateChanged += MonitoredJob_StateChanged;
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,33886,33924);

f_1587_33886_33923(
                this, f_1587_33911_33922(job));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,33942,33982);

f_1587_33942_33981(                this, job);
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,33261,33997);

bool
f_1587_33539_33567(System.Collections.Generic.HashSet<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 33539, 33567);
return return_v;
}


bool
f_1587_33671_33694(System.Collections.Generic.HashSet<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
var return_v = this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 33671, 33694);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1587_33719_33730(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Results;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 33719, 33730);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1587_33911_33922(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Results;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 33911, 33922);
return return_v;
}


int
f_1587_33886_33923(System.Management.Automation.ThrottlingJob.ForwardingHelper
this_param,System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
resultsCollection)
{
this_param.AggregateJobResults( resultsCollection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 33886, 33923);
return 0;
}


int
f_1587_33942_33981(System.Management.Automation.ThrottlingJob.ForwardingHelper
this_param,System.Management.Automation.Job
job)
{
this_param.CheckIfMonitoredJobIsComplete( job);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 33942, 33981);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,33261,33997);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,33261,33997);
}
		}

private void StopMonitoringJob(Job job)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,34013,34469);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,34091,34098);
                lock (_myLock)
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,34140,34435) || true) && (f_1587_34144_34172(_monitoredJobs, job))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,34140,34435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,34222,34282);

f_1587_34222_34233(job).DataAdded -= this.MonitoredJobResults_DataAdded;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,34308,34359);

job.StateChanged -= this.MonitoredJob_StateChanged;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,34385,34412);

f_1587_34385_34411(                        _monitoredJobs, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,34140,34435);
}
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,34013,34469);

bool
f_1587_34144_34172(System.Collections.Generic.HashSet<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 34144, 34172);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1587_34222_34233(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Results;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 34222, 34233);
return return_v;
}


bool
f_1587_34385_34411(System.Collections.Generic.HashSet<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
var return_v = this_param.Remove( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 34385, 34411);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,34013,34469);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,34013,34469);
}
		}

private void AggregateJobResults(PSDataCollection<PSStreamObject> resultsCollection)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,34485,36842);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,34608,34615);
                lock (_myLock)
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,34744,34958) || true) && (_disposed ||(DynAbs.Tracing.TraceSender.Expression_False(1587, 34748, 34786)||_stoppedMonitoringAllJobs )||(DynAbs.Tracing.TraceSender.Expression_False(1587, 34748, 34826)||f_1587_34790_34826(_aggregatedResults))||(DynAbs.Tracing.TraceSender.Expression_False(1587, 34748, 34878)||f_1587_34830_34878(_cancellationTokenSource)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,34744,34958);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,34928,34935);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,34744,34958);
}
                }
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,35114,36827);
foreach(var result in f_1587_35137_35164_I(f_1587_35137_35164(resultsCollection)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,35114,36827);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,35206,35248);

bool 
successfullyAggregatedResult = false
;
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,35328,35335);
                        lock (_myLock)
                        {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,35488,35855) || true) && (!(_disposed ||(DynAbs.Tracing.TraceSender.Expression_False(1587, 35494, 35532)||_stoppedMonitoringAllJobs )||(DynAbs.Tracing.TraceSender.Expression_False(1587, 35494, 35572)||f_1587_35536_35572(_aggregatedResults))||(DynAbs.Tracing.TraceSender.Expression_False(1587, 35494, 35624)||f_1587_35576_35624(_cancellationTokenSource))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,35488,35855);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,35691,35754);

f_1587_35691_35753(                                _aggregatedResults, result, f_1587_35722_35752(_cancellationTokenSource));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,35788,35824);

successfullyAggregatedResult = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,35488,35855);
}
                        }
                    }
                    catch (Exception) // BlockingCollection.Add can throw undocumented exceptions - we cannot just catch InvalidOperationException
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1587,35927,36099);
DynAbs.Tracing.TraceSender.TraceExitCatch(1587,35927,36099);
                    }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,36247,36808) || true) && (!successfullyAggregatedResult)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,36247,36808);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,36330,36369);

f_1587_36330_36368(                        this, _throttlingJob);
                        try
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,36455,36490);

f_1587_36455_36489(f_1587_36455_36477(_throttlingJob), result);
                        }
                        catch (InvalidOperationException)
                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1587,36543,36785);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,36633,36758);

f_1587_36633_36757(false, "ThrottlingJob.Results was already closed when trying to preserve results aggregated by ForwardingHelper");
DynAbs.Tracing.TraceSender.TraceExitCatch(1587,36543,36785);
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,36247,36808);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,35114,36827);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1587,1,1714);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1587,1,1714);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1587,34485,36842);

bool
f_1587_34790_34826(System.Collections.Concurrent.BlockingCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
this_param)
{
var return_v = this_param.IsAddingCompleted ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 34790, 34826);
return return_v;
}


bool
f_1587_34830_34878(System.Threading.CancellationTokenSource
this_param)
{
var return_v = this_param.IsCancellationRequested;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 34830, 34878);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1587_35137_35164(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
this_param)
{
var return_v = this_param.ReadAll();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 35137, 35164);
return return_v;
}


bool
f_1587_35536_35572(System.Collections.Concurrent.BlockingCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
this_param)
{
var return_v = this_param.IsAddingCompleted ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 35536, 35572);
return return_v;
}


bool
f_1587_35576_35624(System.Threading.CancellationTokenSource
this_param)
{
var return_v = this_param.IsCancellationRequested;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 35576, 35624);
return return_v;
}


System.Threading.CancellationToken
f_1587_35722_35752(System.Threading.CancellationTokenSource
this_param)
{
var return_v = this_param.Token;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 35722, 35752);
return return_v;
}


int
f_1587_35691_35753(System.Collections.Concurrent.BlockingCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
this_param,System.Management.Automation.Remoting.Internal.PSStreamObject
item,System.Threading.CancellationToken
cancellationToken)
{
this_param.Add( item, cancellationToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 35691, 35753);
return 0;
}


int
f_1587_36330_36368(System.Management.Automation.ThrottlingJob.ForwardingHelper
this_param,System.Management.Automation.ThrottlingJob
job)
{
this_param.StopMonitoringJob( (System.Management.Automation.Job)job);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 36330, 36368);
return 0;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1587_36455_36477(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.Results;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 36455, 36477);
return return_v;
}


int
f_1587_36455_36489(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
this_param,System.Management.Automation.Remoting.Internal.PSStreamObject
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 36455, 36489);
return 0;
}


int
f_1587_36633_36757(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 36633, 36757);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1587_35137_35164_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 35137, 35164);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,34485,36842);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,34485,36842);
}
		}

private void CancelForwarding()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,36858,37225);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,36922,36956);

f_1587_36922_36955(                _cancellationTokenSource);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,36980,36987);
                lock (_myLock)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,37029,37133);

f_1587_37029_37132(!_disposed, "CancelForwarding should be unregistered before ForwardingHelper gets disposed");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,37155,37191);

f_1587_37155_37190(                    _aggregatedResults);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,36858,37225);

int
f_1587_36922_36955(System.Threading.CancellationTokenSource
this_param)
{
this_param.Cancel();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 36922, 36955);
return 0;
}


int
f_1587_37029_37132(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 37029, 37132);
return 0;
}


int
f_1587_37155_37190(System.Collections.Concurrent.BlockingCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
this_param)
{
this_param.CompleteAdding();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 37155, 37190);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,36858,37225);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,36858,37225);
}
		}

private void CheckIfMonitoredJobIsComplete(Job job)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,37241,37399);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,37325,37384);

f_1587_37325_37383(this, job, f_1587_37360_37382(f_1587_37360_37376(job)));
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,37241,37399);

System.Management.Automation.JobStateInfo
f_1587_37360_37376(System.Management.Automation.Job
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 37360, 37376);
return return_v;
}


System.Management.Automation.JobState
f_1587_37360_37382(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 37360, 37382);
return return_v;
}


int
f_1587_37325_37383(System.Management.Automation.ThrottlingJob.ForwardingHelper
this_param,System.Management.Automation.Job
job,System.Management.Automation.JobState
jobState)
{
this_param.CheckIfMonitoredJobIsComplete( job, jobState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 37325, 37383);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,37241,37399);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,37241,37399);
}
		}

private void CheckIfMonitoredJobIsComplete(Job job, JobState jobState)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,37415,37741);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,37518,37726) || true) && (f_1587_37522_37551(job, jobState))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,37518,37726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,37599,37606);
                    lock (_myLock)
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,37656,37684);

f_1587_37656_37683(                        this, job);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,37518,37726);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,37415,37741);

bool
f_1587_37522_37551(System.Management.Automation.Job
this_param,System.Management.Automation.JobState
state)
{
var return_v = this_param.IsFinishedState( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 37522, 37551);
return return_v;
}


int
f_1587_37656_37683(System.Management.Automation.ThrottlingJob.ForwardingHelper
this_param,System.Management.Automation.Job
job)
{
this_param.StopMonitoringJob( job);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 37656, 37683);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,37415,37741);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,37415,37741);
}
		}

private void CheckIfThrottlingJobIsComplete()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,37757,39149);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,37835,39134) || true) && (f_1587_37839_37878(_throttlingJob))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,37835,39134);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,37920,38025);

List<PSDataCollection<PSStreamObject>> 
resultsToAggregate = f_1587_37980_38024()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,38053,38060);
                    lock (_myLock)
                    {
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,38110,38285);
foreach(Job registeredJob in f_1587_38140_38154_I(_monitoredJobs) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,38110,38285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,38212,38258);

f_1587_38212_38257(                            resultsToAggregate, f_1587_38235_38256(registeredJob));
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,38110,38285);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1587,1,176);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1587,1,176);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,38313,38509);
foreach(Job throttledJob in f_1587_38342_38379_I(f_1587_38342_38379(_throttlingJob)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,38313,38509);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,38437,38482);

f_1587_38437_38481(                            resultsToAggregate, f_1587_38460_38480(throttledJob));
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,38313,38509);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1587,1,197);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1587,1,197);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,38537,38584);

f_1587_38537_38583(
                        resultsToAggregate, f_1587_38560_38582(_throttlingJob));
                    }
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,38631,38829);
foreach(PSDataCollection<PSStreamObject> resultToAggregate in f_1587_38694_38712_I(resultsToAggregate) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,38631,38829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,38762,38806);

f_1587_38762_38805(                        this, resultToAggregate);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,38631,38829);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1587,1,199);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1587,1,199);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,38859,38866);

                    lock (_myLock)
                    {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,38916,39092) || true) && (!_disposed &&(DynAbs.Tracing.TraceSender.Expression_True(1587, 38920, 38971)&&f_1587_38934_38971_M(!_aggregatedResults.IsAddingCompleted)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,38916,39092);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,39029,39065);

f_1587_39029_39064(                            _aggregatedResults);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,38916,39092);
}
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,37835,39134);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,37757,39149);

bool
f_1587_37839_37878(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.IsThrottlingJobCompleted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 37839, 37878);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>>
f_1587_37980_38024()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 37980, 38024);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1587_38235_38256(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Results;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 38235, 38256);
return return_v;
}


int
f_1587_38212_38257(System.Collections.Generic.List<System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>>
this_param,System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 38212, 38257);
return 0;
}


System.Collections.Generic.HashSet<System.Management.Automation.Job>
f_1587_38140_38154_I(System.Collections.Generic.HashSet<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 38140, 38154);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1587_38342_38379(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.GetChildJobsSnapshot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 38342, 38379);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1587_38460_38480(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Results;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 38460, 38480);
return return_v;
}


int
f_1587_38437_38481(System.Collections.Generic.List<System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>>
this_param,System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 38437, 38481);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1587_38342_38379_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 38342, 38379);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1587_38560_38582(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.Results;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 38560, 38582);
return return_v;
}


int
f_1587_38537_38583(System.Collections.Generic.List<System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>>
this_param,System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 38537, 38583);
return 0;
}


int
f_1587_38762_38805(System.Management.Automation.ThrottlingJob.ForwardingHelper
this_param,System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
resultsCollection)
{
this_param.AggregateJobResults( resultsCollection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 38762, 38805);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>>
f_1587_38694_38712_I(System.Collections.Generic.List<System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 38694, 38712);
return return_v;
}


bool
f_1587_38934_38971_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 38934, 38971);
return return_v;
}


int
f_1587_39029_39064(System.Collections.Concurrent.BlockingCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
this_param)
{
this_param.CompleteAdding();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 39029, 39064);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,37757,39149);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,37757,39149);
}
		}

private void MonitoredJobResults_DataAdded(object sender, DataAddedEventArgs e)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,39165,39419);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,39277,39342);

var 
resultsCollection = (PSDataCollection<PSStreamObject>)sender
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,39360,39404);

f_1587_39360_39403(                this, resultsCollection);
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,39165,39419);

int
f_1587_39360_39403(System.Management.Automation.ThrottlingJob.ForwardingHelper
this_param,System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
resultsCollection)
{
this_param.AggregateJobResults( resultsCollection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 39360, 39403);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,39165,39419);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,39165,39419);
}
		}

private void MonitoredJob_StateChanged(object sender, JobStateEventArgs e)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,39435,39659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,39542,39564);

var 
job = (Job)sender
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,39582,39644);

f_1587_39582_39643(                this, job, f_1587_39622_39642(f_1587_39622_39636(e)));
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,39435,39659);

System.Management.Automation.JobStateInfo
f_1587_39622_39636(System.Management.Automation.JobStateEventArgs
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 39622, 39636);
return return_v;
}


System.Management.Automation.JobState
f_1587_39622_39642(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 39622, 39642);
return return_v;
}


int
f_1587_39582_39643(System.Management.Automation.ThrottlingJob.ForwardingHelper
this_param,System.Management.Automation.Job
job,System.Management.Automation.JobState
jobState)
{
this_param.CheckIfMonitoredJobIsComplete( job, jobState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 39582, 39643);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,39435,39659);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,39435,39659);
}
		}

private void ThrottlingJob_ChildJobAdded(object sender, ThrottlingJobChildAddedEventArgs e)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,39675,39855);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,39799,39840);

f_1587_39799_39839(                this, f_1587_39823_39838(e));
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,39675,39855);

System.Management.Automation.Job
f_1587_39823_39838(System.Management.Automation.ThrottlingJobChildAddedEventArgs
this_param)
{
var return_v = this_param.AddedChildJob;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 39823, 39838);
return return_v;
}


int
f_1587_39799_39839(System.Management.Automation.ThrottlingJob.ForwardingHelper
this_param,System.Management.Automation.Job
job)
{
this_param.StartMonitoringJob( job);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 39799, 39839);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,39675,39855);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,39675,39855);
}
		}

private void ThrottlingJob_StateChanged(object sender, JobStateEventArgs e)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,39871,40032);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,39979,40017);

f_1587_39979_40016(                this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,39871,40032);

int
f_1587_39979_40016(System.Management.Automation.ThrottlingJob.ForwardingHelper
this_param)
{
this_param.CheckIfThrottlingJobIsComplete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 39979, 40016);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,39871,40032);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,39871,40032);
}
		}

private void AttemptToPreserveAggregatedResults()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,40048,41499);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,40147,40154);
                lock (_myLock)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,40196,40308);

f_1587_40196_40307(!_disposed, "AttemptToPreserveAggregatedResults should be called before disposing ForwardingHelper");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,40330,40465);

f_1587_40330_40464(_stoppedMonitoringAllJobs, "Caller should guarantee no-more-results before calling AttemptToPreserveAggregatedResults (1)");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,40487,40633);

f_1587_40487_40632(f_1587_40498_40534(_aggregatedResults), "Caller should guarantee no-more-results before calling AttemptToPreserveAggregatedResults (2)");
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,40680,40717);

bool 
isThrottlingJobFinished = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,40735,41484);
foreach(var aggregatedButNotYetProcessedResult in f_1587_40786_40804_I(_aggregatedResults) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,40735,41484);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,40846,41465) || true) && (!isThrottlingJobFinished)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,40846,41465);
                        try
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,40984,41047);

f_1587_40984_41046(f_1587_40984_41006(_throttlingJob), aggregatedButNotYetProcessedResult);
                        }
                        catch (PSInvalidOperationException)
                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1587,41100,41442);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,41192,41284);

isThrottlingJobFinished = f_1587_41218_41283(_throttlingJob, f_1587_41249_41282(f_1587_41249_41276(_throttlingJob)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,41314,41415);

f_1587_41314_41414(isThrottlingJobFinished, "Buffers should not be closed before throttling job is stopped");
DynAbs.Tracing.TraceSender.TraceExitCatch(1587,41100,41442);
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,40846,41465);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,40735,41484);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1587,1,750);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1587,1,750);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1587,40048,41499);

int
f_1587_40196_40307(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 40196, 40307);
return 0;
}


int
f_1587_40330_40464(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 40330, 40464);
return 0;
}


bool
f_1587_40498_40534(System.Collections.Concurrent.BlockingCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
this_param)
{
var return_v = this_param.IsAddingCompleted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 40498, 40534);
return return_v;
}


int
f_1587_40487_40632(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 40487, 40632);
return 0;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1587_40984_41006(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.Results;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 40984, 41006);
return return_v;
}


int
f_1587_40984_41046(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
this_param,System.Management.Automation.Remoting.Internal.PSStreamObject
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 40984, 41046);
return 0;
}


System.Management.Automation.JobStateInfo
f_1587_41249_41276(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 41249, 41276);
return return_v;
}


System.Management.Automation.JobState
f_1587_41249_41282(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 41249, 41282);
return return_v;
}


bool
f_1587_41218_41283(System.Management.Automation.ThrottlingJob
this_param,System.Management.Automation.JobState
state)
{
var return_v = this_param.IsFinishedState( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 41218, 41283);
return return_v;
}


int
f_1587_41314_41414(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 41314, 41414);
return 0;
}


System.Collections.Concurrent.BlockingCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1587_40786_40804_I(System.Collections.Concurrent.BlockingCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 40786, 40804);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,40048,41499);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,40048,41499);
}
		}

private static readonly bool s_isCliXmlTestabilityHookActive ;

private static bool GetIsCliXmlTestabilityHookActive()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1587,41693,41881);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,41780,41866);

return !f_1587_41788_41865(f_1587_41809_41864("CDXML_CLIXML_TEST"));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1587,41693,41881);

string?
f_1587_41809_41864(string
variable)
{
var return_v = Environment.GetEnvironmentVariable( variable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 41809, 41864);
return return_v;
}


bool
f_1587_41788_41865(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 41788, 41865);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,41693,41881);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,41693,41881);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static void ProcessCliXmlTestabilityHook(PSStreamObject streamObject)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1587,41897,42845);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,42008,42112) || true) && (!s_isCliXmlTestabilityHookActive)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,42008,42112);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,42086,42093);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,42008,42112);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,42132,42256) || true) && (f_1587_42136_42159(streamObject)!= PSStreamObjectType.Output)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,42132,42256);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,42230,42237);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,42132,42256);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,42276,42374) || true) && (f_1587_42280_42298(streamObject)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,42276,42374);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,42348,42355);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,42276,42374);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,42394,42556) || true) && (!(f_1587_42400_42487(f_1587_42400_42465(f_1587_42400_42460(f_1587_42400_42450(f_1587_42400_42439(f_1587_42420_42438(streamObject))))), "CimInstance")))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,42394,42556);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,42530,42537);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,42394,42556);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,42576,42653);

string 
serializedForm = f_1587_42600_42652(f_1587_42623_42641(streamObject), depth: 1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,42671,42740);

object 
deserializedObject = f_1587_42699_42739(serializedForm)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,42758,42830);

streamObject.Value = f_1587_42779_42829(f_1587_42779_42818(deserializedObject));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1587,41897,42845);

System.Management.Automation.Remoting.Internal.PSStreamObjectType
f_1587_42136_42159(System.Management.Automation.Remoting.Internal.PSStreamObject
this_param)
{
var return_v = this_param.ObjectType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 42136, 42159);
return return_v;
}


object
f_1587_42280_42298(System.Management.Automation.Remoting.Internal.PSStreamObject
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 42280, 42298);
return return_v;
}


object
f_1587_42420_42438(System.Management.Automation.Remoting.Internal.PSStreamObject
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 42420, 42438);
return return_v;
}


System.Management.Automation.PSObject
f_1587_42400_42439(object
obj)
{
var return_v = PSObject.AsPSObject( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 42400, 42439);
return return_v;
}


object
f_1587_42400_42450(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.BaseObject;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 42400, 42450);
return return_v;
}


System.Type
f_1587_42400_42460(object
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 42400, 42460);
return return_v;
}


string
f_1587_42400_42465(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 42400, 42465);
return return_v;
}


bool
f_1587_42400_42487(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 42400, 42487);
return return_v;
}


object
f_1587_42623_42641(System.Management.Automation.Remoting.Internal.PSStreamObject
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 42623, 42641);
return return_v;
}


string
f_1587_42600_42652(object
source,int
depth)
{
var return_v = PSSerializer.Serialize( source, depth: depth);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 42600, 42652);
return return_v;
}


object
f_1587_42699_42739(string
source)
{
var return_v = PSSerializer.Deserialize( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 42699, 42739);
return return_v;
}


System.Management.Automation.PSObject
f_1587_42779_42818(object
obj)
{
var return_v = PSObject.AsPSObject( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 42779, 42818);
return return_v;
}


object
f_1587_42779_42829(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.BaseObject;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 42779, 42829);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,41897,42845);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,41897,42845);
}
		}

private void ForwardResults(Cmdlet cmdlet)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,42869,44402);
                try
                {
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,42988,44162);
foreach(var result in f_1587_43011_43099_I(f_1587_43011_43099(_aggregatedResults, f_1587_43053_43098(_throttlingJob._cancellationTokenSource))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,42988,44162);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,43149,44139) || true) && (result != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,43149,44139);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,43303,43340);

f_1587_43303_43339(result);
                            try
                            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,43446,43479);

f_1587_43446_43478(                                result, cmdlet);
                            }
                            finally
                            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1587,43540,44112);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,43612,44081) || true) && (_throttlingJob._cmdletMode)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,43612,44081);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,43716,43848);

f_1587_43716_43847(_throttlingJob._jobResultsThrottlingSemaphore != null, "JobResultsThrottlingSemaphore should be present in cmdlet mode");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,43886,43952);

f_1587_43886_43951(ref _throttlingJob._jobResultsCurrentCount);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,43990,44046);

f_1587_43990_44045(                                    _throttlingJob._jobResultsThrottlingSemaphore);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,43612,44081);
}
DynAbs.Tracing.TraceSender.TraceExitFinally(1587,43540,44112);
                            }
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,43149,44139);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,42988,44162);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1587,1,1175);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1587,1,1175);
}                }
                catch
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1587,44199,44387);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,44245,44274);

f_1587_44245_44273(                    this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,44296,44338);

f_1587_44296_44337(                    this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,44362,44368);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1587,44199,44387);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,42869,44402);

System.Threading.CancellationToken
f_1587_43053_43098(System.Threading.CancellationTokenSource
this_param)
{
var return_v = this_param.Token;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 43053, 43098);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1587_43011_43099(System.Collections.Concurrent.BlockingCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
this_param,System.Threading.CancellationToken
cancellationToken)
{
var return_v = this_param.GetConsumingEnumerable( cancellationToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 43011, 43099);
return return_v;
}


int
f_1587_43303_43339(System.Management.Automation.Remoting.Internal.PSStreamObject
streamObject)
{
ProcessCliXmlTestabilityHook( streamObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 43303, 43339);
return 0;
}


int
f_1587_43446_43478(System.Management.Automation.Remoting.Internal.PSStreamObject
this_param,System.Management.Automation.Cmdlet
cmdlet)
{
this_param.WriteStreamObject( cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 43446, 43478);
return 0;
}


int
f_1587_43716_43847(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 43716, 43847);
return 0;
}


long
f_1587_43886_43951(ref long
location)
{
var return_v = Interlocked.Decrement( ref location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 43886, 43951);
return return_v;
}


int
f_1587_43990_44045(System.Threading.SemaphoreSlim
this_param)
{
var return_v = this_param.Release();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 43990, 44045);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1587_43011_43099_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Remoting.Internal.PSStreamObject>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 43011, 43099);
return return_v;
}


int
f_1587_44245_44273(System.Management.Automation.ThrottlingJob.ForwardingHelper
this_param)
{
this_param.StopMonitoringAllJobs();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 44245, 44273);
return 0;
}


int
f_1587_44296_44337(System.Management.Automation.ThrottlingJob.ForwardingHelper
this_param)
{
this_param.AttemptToPreserveAggregatedResults();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 44296, 44337);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,42869,44402);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,42869,44402);
}
		}

private bool _stoppedMonitoringAllJobs;

private void StopMonitoringAllJobs()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,44471,45321);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,44540,44574);

f_1587_44540_44573(                _cancellationTokenSource);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,44598,44605);
                lock (_myLock)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,44647,44680);

_stoppedMonitoringAllJobs = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,44704,44773);

List<Job> 
snapshotOfCurrentlyMonitoredJobs = f_1587_44749_44772(_monitoredJobs)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,44795,44966);
foreach(Job monitoredJob in f_1587_44824_44856_I(snapshotOfCurrentlyMonitoredJobs) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,44795,44966);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,44906,44943);

f_1587_44906_44942(                        this, monitoredJob);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,44795,44966);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1587,1,172);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1587,1,172);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,44990,45099);

f_1587_44990_45098(f_1587_45001_45021(_monitoredJobs)== 0, "No monitored jobs should be left after ForwardingHelper is disposed");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,45123,45287) || true) && (!_disposed &&(DynAbs.Tracing.TraceSender.Expression_True(1587, 45127, 45178)&&f_1587_45141_45178_M(!_aggregatedResults.IsAddingCompleted)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,45123,45287);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,45228,45264);

f_1587_45228_45263(                        _aggregatedResults);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,45123,45287);
}
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,44471,45321);

int
f_1587_44540_44573(System.Threading.CancellationTokenSource
this_param)
{
this_param.Cancel();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 44540, 44573);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1587_44749_44772(System.Collections.Generic.HashSet<System.Management.Automation.Job>
source)
{
var return_v = source.ToList<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 44749, 44772);
return return_v;
}


int
f_1587_44906_44942(System.Management.Automation.ThrottlingJob.ForwardingHelper
this_param,System.Management.Automation.Job
job)
{
this_param.StopMonitoringJob( job);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 44906, 44942);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1587_44824_44856_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 44824, 44856);
return return_v;
}


int
f_1587_45001_45021(System.Collections.Generic.HashSet<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 45001, 45021);
return return_v;
}


int
f_1587_44990_45098(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 44990, 45098);
return 0;
}


bool
f_1587_45141_45178_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 45141, 45178);
return return_v;
}


int
f_1587_45228_45263(System.Collections.Concurrent.BlockingCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
this_param)
{
this_param.CompleteAdding();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 45228, 45263);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,44471,45321);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,44471,45321);
}
		}

public void Dispose()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,45337,45869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,45391,45417);

f_1587_45391_45416(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,45435,45469);

f_1587_45435_45468(                _cancellationTokenSource);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,45493,45500);
                lock (_myLock)
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,45542,45635) || true) && (_disposed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,45542,45635);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,45605,45612);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,45542,45635);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,45659,45688);

f_1587_45659_45687(
                    this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,45710,45739);

f_1587_45710_45738(                    _aggregatedResults);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,45761,45796);

f_1587_45761_45795(                    _cancellationTokenSource);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,45818,45835);

_disposed = true;
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,45337,45869);

int
f_1587_45391_45416(System.Management.Automation.ThrottlingJob.ForwardingHelper
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 45391, 45416);
return 0;
}


int
f_1587_45435_45468(System.Threading.CancellationTokenSource
this_param)
{
this_param.Cancel();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 45435, 45468);
return 0;
}


int
f_1587_45659_45687(System.Management.Automation.ThrottlingJob.ForwardingHelper
this_param)
{
this_param.StopMonitoringAllJobs();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 45659, 45687);
return 0;
}


int
f_1587_45710_45738(System.Collections.Concurrent.BlockingCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 45710, 45738);
return 0;
}


int
f_1587_45761_45795(System.Threading.CancellationTokenSource
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 45761, 45795);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,45337,45869);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,45337,45869);
}
		}

public static void ForwardAllResultsToCmdlet(ThrottlingJob throttlingJob, Cmdlet cmdlet, CancellationToken? cancellationToken)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1587,45885,48383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,46044,48368);
using(var 
helper = f_1587_46064_46099(throttlingJob)
)                {
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,46193,46259);

throttlingJob.ChildJobAdded += helper.ThrottlingJob_ChildJobAdded;

                        try
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,46347,46411);

throttlingJob.StateChanged += helper.ThrottlingJob_StateChanged;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,46443,46492);

IDisposable 
cancellationTokenRegistration = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,46522,46739) || true) && (cancellationToken.HasValue)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,46522,46739);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,46618,46708);

cancellationTokenRegistration = cancellationToken.Value.Register(helper.CancelForwarding);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,46522,46739);
}

                            try
                            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,46839,46867);

f_1587_46839_46866();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,46901,47531);

f_1587_46901_47530(delegate
                                        {
                                            helper.StartMonitoringJob(throttlingJob);
                                            foreach (Job childJob in throttlingJob.GetChildJobsSnapshot())
                                            {
                                                helper.StartMonitoringJob(childJob);
                                            }

                                            helper.CheckIfThrottlingJobIsComplete();
                                        });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,47567,47597);

f_1587_47567_47596(
                                helper, cmdlet);
                            }
                            finally
                            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1587,47658,47951);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,47730,47920) || true) && (cancellationTokenRegistration != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1587,47730,47920);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,47845,47885);

f_1587_47845_47884(                                    cancellationTokenRegistration);
DynAbs.Tracing.TraceSender.TraceExitCondition(1587,47730,47920);
}
DynAbs.Tracing.TraceSender.TraceExitFinally(1587,47658,47951);
                            }
                        }
                        finally
                        {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1587,48004,48159);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,48068,48132);

throttlingJob.StateChanged -= helper.ThrottlingJob_StateChanged;
DynAbs.Tracing.TraceSender.TraceExitFinally(1587,48004,48159);
                        }
                    }
                    finally
                    {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1587,48204,48349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,48260,48326);

throttlingJob.ChildJobAdded -= helper.ThrottlingJob_ChildJobAdded;
DynAbs.Tracing.TraceSender.TraceExitFinally(1587,48204,48349);
                    }
DynAbs.Tracing.TraceSender.TraceExitUsing(1587,46044,48368);
                }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1587,45885,48383);

System.Management.Automation.ThrottlingJob.ForwardingHelper
f_1587_46064_46099(System.Management.Automation.ThrottlingJob
throttlingJob)
{
var return_v = new System.Management.Automation.ThrottlingJob.ForwardingHelper( throttlingJob);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 46064, 46099);
return return_v;
}


int
f_1587_46839_46866()
{
Interlocked.MemoryBarrier();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 46839, 46866);
return 0;
}


bool
f_1587_46901_47530(System.Threading.WaitCallback
callBack)
{
var return_v = ThreadPool.QueueUserWorkItem( callBack);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 46901, 47530);
return return_v;
}


int
f_1587_47567_47596(System.Management.Automation.ThrottlingJob.ForwardingHelper
this_param,System.Management.Automation.Cmdlet
cmdlet)
{
this_param.ForwardResults( cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 47567, 47596);
return 0;
}


int
f_1587_47845_47884(System.IDisposable
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 47845, 47884);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,45885,48383);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,45885,48383);
}
		}

static ForwardingHelper()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1587,31794,48394);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,32477,32512);
AggregationQueueMaxCapacity = 10000;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,41608,41676);
s_isCliXmlTestabilityHookActive = f_1587_41642_41676();DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1587,31794,48394);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,31794,48394);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1587,31794,48394);

System.Threading.CancellationTokenSource
f_1587_32851_32880()
{
var return_v = new System.Threading.CancellationTokenSource();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 32851, 32880);
return return_v;
}


object
f_1587_33081_33093()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 33081, 33093);
return return_v;
}


System.Collections.Generic.HashSet<System.Management.Automation.Job>
f_1587_33129_33147()
{
var return_v = new System.Collections.Generic.HashSet<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 33129, 33147);
return return_v;
}


System.Collections.Concurrent.BlockingCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1587_33189_33229()
{
var return_v = new System.Collections.Concurrent.BlockingCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 33189, 33229);
return return_v;
}


static bool
f_1587_41642_41676()
{
var return_v = GetIsCliXmlTestabilityHookActive();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 41642, 41676);
return return_v;
}

}

internal override void ForwardAllResultsToCmdlet(Cmdlet cmdlet)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,48406,48569);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,48494,48558);

f_1587_48494_48557(            this, cmdlet, cancellationToken: null);
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,48406,48569);

int
f_1587_48494_48557(System.Management.Automation.ThrottlingJob
this_param,System.Management.Automation.Cmdlet
cmdlet,System.Threading.CancellationToken?
cancellationToken)
{
this_param.ForwardAllResultsToCmdlet( cmdlet, cancellationToken: cancellationToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 48494, 48557);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,48406,48569);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,48406,48569);
}
		}

private void ForwardAllResultsToCmdlet(Cmdlet cmdlet, CancellationToken? cancellationToken)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1587,48581,48823);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,48697,48722);

f_1587_48697_48721(            this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,48736,48812);

f_1587_48736_48811(this, cmdlet, cancellationToken);
DynAbs.Tracing.TraceSender.TraceExitMethod(1587,48581,48823);

int
f_1587_48697_48721(System.Management.Automation.ThrottlingJob
this_param)
{
this_param.AssertNotDisposed();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 48697, 48721);
return 0;
}


int
f_1587_48736_48811(System.Management.Automation.ThrottlingJob
throttlingJob,System.Management.Automation.Cmdlet
cmdlet,System.Threading.CancellationToken?
cancellationToken)
{
ForwardingHelper.ForwardAllResultsToCmdlet( throttlingJob, cmdlet, cancellationToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 48736, 48811);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,48581,48823);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,48581,48823);
}
		}

static ThrottlingJob()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1587,746,48883);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,17114,17164);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,18789,18820);
s_maximumReadyToRunJobs = 10000;DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1587,746,48883);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,746,48883);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1587,746,48883);

object
f_1587_2340_2352()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 2340, 2352);
return return_v;
}


System.Collections.Generic.HashSet<System.Guid>
f_1587_7058_7077()
{
var return_v = new System.Collections.Generic.HashSet<System.Guid>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 7058, 7077);
return return_v;
}


object
f_1587_8630_8642()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 8630, 8642);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
f_1587_10031_10043(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.Results;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 10031, 10043);
return return_v;
}


System.Threading.SemaphoreSlim
f_1587_10252_10315(int
initialCount)
{
var return_v = new System.Threading.SemaphoreSlim( initialCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 10252, 10315);
return return_v;
}


int
f_1587_10380_10398(System.Management.Automation.ThrottlingJob
this_param)
{
var return_v = this_param.GetHashCode();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 10380, 10398);
return return_v;
}


System.Random
f_1587_10369_10399(int
Seed)
{
var return_v = new System.Random( Seed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 10369, 10399);
return return_v;
}


int
f_1587_10369_10406(System.Random
this_param)
{
var return_v = this_param.Next();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 10369, 10406);
return return_v;
}


int
f_1587_10423_10476(System.Management.Automation.ThrottlingJob
this_param,int
maximumConcurrentChildJobs)
{
this_param.SetupThrottlingQueue( maximumConcurrentChildJobs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 10423, 10476);
return 0;
}


static string
f_1587_9989_9996_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1587, 9845, 10488);
return return_v;
}


object
f_1587_16995_17007()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 16995, 17007);
return return_v;
}


System.Threading.CancellationTokenSource
f_1587_25558_25587()
{
var return_v = new System.Threading.CancellationTokenSource();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 25558, 25587);
return return_v;
}


System.StringComparer
f_1587_30345_30377()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1587, 30345, 30377);
return return_v;
}


System.Collections.Generic.HashSet<string>
f_1587_30325_30378(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.HashSet<string>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 30325, 30378);
return return_v;
}

}
internal class ThrottlingJobChildAddedEventArgs : EventArgs
{
internal Job AddedChildJob {get; }

internal ThrottlingJobChildAddedEventArgs(Job addedChildJob)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1587,49014,49234);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,48967,49002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,49099,49179);

f_1587_49099_49178(addedChildJob != null, "Caller should verify addedChildJob != null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1587,49193,49223);

AddedChildJob = addedChildJob;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1587,49014,49234);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1587,49014,49234);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,49014,49234);
}
		}

static ThrottlingJobChildAddedEventArgs()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1587,48891,49241);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1587,48891,49241);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1587,48891,49241);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1587,48891,49241);

int
f_1587_49099_49178(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1587, 49099, 49178);
return 0;
}

}
}
