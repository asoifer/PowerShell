// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;
using System.Management.Automation.Remoting;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell.Commands
{
public class JobCmdletBase : PSRemotingCmdlet
{
internal const string 
JobParameterSet = "JobParameterSet"
;

internal const string 
InstanceIdParameterSet = "InstanceIdParameterSet"
;

internal const string 
SessionIdParameterSet = "SessionIdParameterSet"
;

internal const string 
NameParameterSet = "NameParameterSet"
;

internal const string 
StateParameterSet = "StateParameterSet"
;

internal const string 
CommandParameterSet = "CommandParameterSet"
;

internal const string 
FilterParameterSet = "FilterParameterSet"
;

internal const string 
JobParameter = "Job"
;

internal const string 
InstanceIdParameter = "InstanceId"
;

internal const string 
SessionIdParameter = "SessionId"
;

internal const string 
NameParameter = "Name"
;

internal const string 
StateParameter = "State"
;

internal const string 
CommandParameter = "Command"
;

internal const string 
FilterParameter = "Filter"
;

internal List<Job> FindJobsMatchingByName(
            bool recurse,
            bool writeobject,
            bool writeErrorOnNoMatch,
            bool checkIfJobCanBeRemoved)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,2355,4444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,2561,2597);

List<Job> 
matches = f_1607_2581_2596()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,2611,2657);

Hashtable 
duplicateDetector = f_1607_2641_2656()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,2673,2708) || true) && (_names == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,2673,2708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,2693,2708);

return matches;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,2673,2708);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,2724,4402);
foreach(string name in f_1607_2748_2754_I(_names) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,2724,4402);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,2788,2850) || true) && (f_1607_2792_2818(name))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,2788,2850);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,2841,2850);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,2788,2850);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,2921,2943);

bool 
jobFound = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,2961,2987);

f_1607_2961_2986(                duplicateDetector);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,3005,3182);

jobFound = f_1607_3016_3181(this, matches, f_1607_3054_3072(f_1607_3054_3067()), name, duplicateDetector, recurse, writeobject, checkIfJobCanBeRemoved);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,3252,3343);

List<Job2> 
jobs2 = f_1607_3271_3342(f_1607_3271_3281(), name, this, false, writeobject, recurse, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,3363,3417);

bool 
job2Found = (jobs2 != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1607, 3380, 3416)&&(f_1607_3400_3411(jobs2)> 0))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,3437,3892) || true) && (job2Found)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,3437,3892);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,3492,3873);
foreach(Job2 job2 in f_1607_3514_3519_I(jobs2) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,3492,3873);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,3569,3850) || true) && (f_1607_3573_3747(this, checkIfJobCanBeRemoved, NameParameter, job2, f_1607_3671_3726(), f_1607_3728_3735(job2), f_1607_3737_3746(job2)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,3569,3850);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,3805,3823);

f_1607_3805_3822(                            matches, job2);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,3569,3850);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,3492,3873);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1607,1,382);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1607,1,382);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1607,3437,3892);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,3912,3945);

jobFound = jobFound ||(DynAbs.Tracing.TraceSender.Expression_False(1607, 3923, 3944)||job2Found);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,4026,4125) || true) && (jobFound ||(DynAbs.Tracing.TraceSender.Expression_False(1607, 4030, 4062)||!writeErrorOnNoMatch )||(DynAbs.Tracing.TraceSender.Expression_False(1607, 4030, 4114)||f_1607_4066_4114(name)))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,4026,4125);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,4116,4125);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,4026,4125);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,4145,4269);

Exception 
ex = f_1607_4160_4268(NameParameter, f_1607_4210_4261(), name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,4287,4387);

f_1607_4287_4386(this, f_1607_4298_4385(ex, "JobWithSpecifiedNameNotFound", ErrorCategory.ObjectNotFound, name));
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,2724,4402);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1607,1,1679);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1607,1,1679);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,4418,4433);

return matches;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,2355,4444);

System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_2581_2596()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 2581, 2596);
return return_v;
}


System.Collections.Hashtable
f_1607_2641_2656()
{
var return_v = new System.Collections.Hashtable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 2641, 2656);
return return_v;
}


bool
f_1607_2792_2818(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 2792, 2818);
return return_v;
}


int
f_1607_2961_2986(System.Collections.Hashtable
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 2961, 2986);
return 0;
}


System.Management.Automation.JobRepository
f_1607_3054_3067()
{
var return_v = JobRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 3054, 3067);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_3054_3072(System.Management.Automation.JobRepository
this_param)
{
var return_v = this_param.Jobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 3054, 3072);
return return_v;
}


bool
f_1607_3016_3181(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
matches,System.Collections.Generic.List<System.Management.Automation.Job>
jobsToSearch,string
name,System.Collections.Hashtable
duplicateDetector,bool
recurse,bool
writeobject,bool
checkIfJobCanBeRemoved)
{
var return_v = this_param.FindJobsMatchingByNameHelper( matches, (System.Collections.Generic.IList<System.Management.Automation.Job>)jobsToSearch, name, duplicateDetector, recurse, writeobject, checkIfJobCanBeRemoved);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 3016, 3181);
return return_v;
}


System.Management.Automation.JobManager
f_1607_3271_3281()
{
var return_v = JobManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 3271, 3281);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job2>
f_1607_3271_3342(System.Management.Automation.JobManager
this_param,string
name,Microsoft.PowerShell.Commands.JobCmdletBase
cmdlet,bool
writeErrorOnException,bool
writeObject,bool
recurse,string[]
jobSourceAdapterTypes)
{
var return_v = this_param.GetJobsByName( name, (System.Management.Automation.Cmdlet)cmdlet, writeErrorOnException, writeObject, recurse, jobSourceAdapterTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 3271, 3342);
return return_v;
}


int
f_1607_3400_3411(System.Collections.Generic.List<System.Management.Automation.Job2>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 3400, 3411);
return return_v;
}


string
f_1607_3671_3726()
{
var return_v =                             RemotingErrorIdStrings.JobWithSpecifiedNameNotCompleted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 3671, 3726);
return return_v;
}


int
f_1607_3728_3735(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 3728, 3735);
return return_v;
}


string
f_1607_3737_3746(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 3737, 3746);
return return_v;
}


bool
f_1607_3573_3747(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,bool
checkForRemove,string
parameterName,System.Management.Automation.Job2
job2,string
resourceString,params object[]
args)
{
var return_v = this_param.CheckIfJob2CanBeRemoved( checkForRemove, parameterName, job2, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 3573, 3747);
return return_v;
}


int
f_1607_3805_3822(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Management.Automation.Job2
item)
{
this_param.Add( (System.Management.Automation.Job)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 3805, 3822);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job2>
f_1607_3514_3519_I(System.Collections.Generic.List<System.Management.Automation.Job2>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 3514, 3519);
return return_v;
}


bool
f_1607_4066_4114(string
pattern)
{
var return_v = WildcardPattern.ContainsWildcardCharacters( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 4066, 4114);
return return_v;
}


string
f_1607_4210_4261()
{
var return_v = RemotingErrorIdStrings.JobWithSpecifiedNameNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 4210, 4261);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1607_4160_4268(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 4160, 4268);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1607_4298_4385(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 4298, 4385);
return return_v;
}


int
f_1607_4287_4386(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 4287, 4386);
return 0;
}


string[]
f_1607_2748_2754_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 2748, 2754);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,2355,4444);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,2355,4444);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool CheckIfJob2CanBeRemoved(bool checkForRemove, string parameterName, Job2 job2, string resourceString, params object[] args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,4456,5149);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,4616,5110) || true) && (checkForRemove)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,4616,5110);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,4668,4752) || true) && (f_1607_4672_4717(job2, f_1607_4693_4716(f_1607_4693_4710(job2))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,4668,4752);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,4740,4752);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,4668,4752);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,4772,4858);

string 
message = f_1607_4789_4857(resourceString, args)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,4876,4937);

Exception 
ex = f_1607_4891_4936(message, parameterName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,4955,5064);

f_1607_4955_5063(this, f_1607_4966_5062(ex, "JobObjectNotFinishedCannotBeRemoved", ErrorCategory.InvalidOperation, job2));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,5082,5095);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,4616,5110);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,5126,5138);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,4456,5149);

System.Management.Automation.JobStateInfo
f_1607_4693_4710(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 4693, 4710);
return return_v;
}


System.Management.Automation.JobState
f_1607_4693_4716(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 4693, 4716);
return return_v;
}


bool
f_1607_4672_4717(System.Management.Automation.Job2
this_param,System.Management.Automation.JobState
state)
{
var return_v = this_param.IsFinishedState( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 4672, 4717);
return return_v;
}


string
f_1607_4789_4857(string
resourceString,params object[]
args)
{
var return_v = PSRemotingErrorInvariants.FormatResourceString( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 4789, 4857);
return return_v;
}


System.ArgumentException
f_1607_4891_4936(string
message,string
paramName)
{
var return_v = new System.ArgumentException( message, paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 4891, 4936);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1607_4966_5062(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Job2
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 4966, 5062);
return return_v;
}


int
f_1607_4955_5063(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 4955, 5063);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,4456,5149);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,4456,5149);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool FindJobsMatchingByNameHelper(List<Job> matches, IList<Job> jobsToSearch, string name,
                        Hashtable duplicateDetector, bool recurse, bool writeobject, bool checkIfJobCanBeRemoved)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,5161,7441);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,5399,5494);

f_1607_5399_5493(!f_1607_5411_5437(name), "Caller should ensure that name is not null or empty");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,5510,5532);

bool 
jobFound = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,5548,5672);

WildcardPattern 
pattern =
f_1607_5591_5671(name, WildcardOptions.IgnoreCase | WildcardOptions.Compiled)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,5688,7398);
foreach(Job job in f_1607_5708_5720_I(jobsToSearch) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,5688,7398);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,5818,5929) || true) && (f_1607_5822_5859(duplicateDetector, f_1607_5852_5858(job)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,5818,5929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,5901,5910);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,5818,5929);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,5949,5987);

f_1607_5949_5986(
                duplicateDetector, f_1607_5971_5977(job), f_1607_5979_5985(job));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,6199,6825) || true) && (f_1607_6203_6228(pattern, f_1607_6219_6227(job)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,6199,6825);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,6270,6286);

jobFound = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,6308,6775) || true) && (!checkIfJobCanBeRemoved ||(DynAbs.Tracing.TraceSender.Expression_False(1607, 6312, 6454)||f_1607_6339_6454(this, job, NameParameter, f_1607_6380_6435(), f_1607_6437_6443(job), f_1607_6445_6453(job))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,6308,6775);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,6504,6752) || true) && (writeobject)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,6504,6752);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,6577,6594);

f_1607_6577_6593(this, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,6504,6752);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,6504,6752);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,6708,6725);

f_1607_6708_6724(                            matches, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,6504,6752);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,6308,6775);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,6199,6825);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,6919,7383) || true) && (f_1607_6923_6936(job)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1607, 6923, 6971)&&f_1607_6948_6967(f_1607_6948_6961(job))> 0 )&&(DynAbs.Tracing.TraceSender.Expression_True(1607, 6923, 6982)&&recurse))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,6919,7383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,7024,7228);

bool 
jobFoundinChildJobs = f_1607_7051_7227(this, matches, f_1607_7089_7102(job), name, duplicateDetector, recurse, writeobject, checkIfJobCanBeRemoved)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,7252,7364) || true) && (jobFoundinChildJobs)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,7252,7364);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,7325,7341);

jobFound = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,7252,7364);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,6919,7383);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,5688,7398);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1607,1,1711);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1607,1,1711);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,7414,7430);

return jobFound;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,5161,7441);

bool
f_1607_5411_5437(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 5411, 5437);
return return_v;
}


int
f_1607_5399_5493(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 5399, 5493);
return 0;
}


System.Management.Automation.WildcardPattern
f_1607_5591_5671(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 5591, 5671);
return return_v;
}


int
f_1607_5852_5858(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 5852, 5858);
return return_v;
}


bool
f_1607_5822_5859(System.Collections.Hashtable
this_param,int
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 5822, 5859);
return return_v;
}


int
f_1607_5971_5977(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 5971, 5977);
return return_v;
}


int
f_1607_5979_5985(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 5979, 5985);
return return_v;
}


int
f_1607_5949_5986(System.Collections.Hashtable
this_param,int
key,int
value)
{
this_param.Add( (object)key, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 5949, 5986);
return 0;
}


string
f_1607_6219_6227(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 6219, 6227);
return return_v;
}


bool
f_1607_6203_6228(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 6203, 6228);
return return_v;
}


string
f_1607_6380_6435()
{
var return_v = RemotingErrorIdStrings.JobWithSpecifiedNameNotCompleted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 6380, 6435);
return return_v;
}


int
f_1607_6437_6443(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 6437, 6443);
return return_v;
}


string
f_1607_6445_6453(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 6445, 6453);
return return_v;
}


bool
f_1607_6339_6454(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Management.Automation.Job
job,string
parameterName,string
resourceString,params object[]
list)
{
var return_v = this_param.CheckJobCanBeRemoved( job, parameterName, resourceString, list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 6339, 6454);
return return_v;
}


int
f_1607_6577_6593(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Management.Automation.Job
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 6577, 6593);
return 0;
}


int
f_1607_6708_6724(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 6708, 6724);
return 0;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1607_6923_6936(System.Management.Automation.Job
this_param)
{
var return_v = this_param.ChildJobs ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 6923, 6936);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1607_6948_6961(System.Management.Automation.Job
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 6948, 6961);
return return_v;
}


int
f_1607_6948_6967(System.Collections.Generic.IList<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 6948, 6967);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1607_7089_7102(System.Management.Automation.Job
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 7089, 7102);
return return_v;
}


bool
f_1607_7051_7227(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
matches,System.Collections.Generic.IList<System.Management.Automation.Job>
jobsToSearch,string
name,System.Collections.Hashtable
duplicateDetector,bool
recurse,bool
writeobject,bool
checkIfJobCanBeRemoved)
{
var return_v = this_param.FindJobsMatchingByNameHelper( matches, jobsToSearch, name, duplicateDetector, recurse, writeobject, checkIfJobCanBeRemoved);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 7051, 7227);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1607_5708_5720_I(System.Collections.Generic.IList<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 5708, 5720);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,5161,7441);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,5161,7441);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal List<Job> FindJobsMatchingByInstanceId(bool recurse, bool writeobject, bool writeErrorOnNoMatch, bool checkIfJobCanBeRemoved)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,8037,9988);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,8196,8232);

List<Job> 
matches = f_1607_8216_8231()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,8248,8294);

Hashtable 
duplicateDetector = f_1607_8278_8293()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,8310,8351) || true) && (_instanceIds == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,8310,8351);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,8336,8351);

return matches;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,8310,8351);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,8367,9946);
foreach(Guid id in f_1607_8387_8399_I(_instanceIds) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,8367,9946);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,8487,8513);

f_1607_8487_8512(                // search all jobs in Job repository
                duplicateDetector);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,8531,8717);

bool 
jobFound = f_1607_8547_8716(this, matches, f_1607_8591_8609(f_1607_8591_8604()), id, duplicateDetector, recurse, writeobject, checkIfJobCanBeRemoved)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,8891,8972);

Job2 
job2 = f_1607_8903_8971(f_1607_8903_8913(), id, this, false, writeobject, recurse)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,8992,9022);

bool 
job2Found = job2 != null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,9042,9399) || true) && (job2Found)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,9042,9399);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,9097,9380) || true) && (f_1607_9101_9289(this, checkIfJobCanBeRemoved, InstanceIdParameter, job2, f_1607_9201_9262(), f_1607_9264_9271(job2), f_1607_9273_9288(job2)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,9097,9380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,9339,9357);

f_1607_9339_9356(                        matches, job2);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,9097,9380);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,9042,9399);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,9419,9452);

jobFound = jobFound ||(DynAbs.Tracing.TraceSender.Expression_False(1607, 9430, 9451)||job2Found);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,9472,9519) || true) && (jobFound ||(DynAbs.Tracing.TraceSender.Expression_False(1607, 9476, 9508)||!writeErrorOnNoMatch))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,9472,9519);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,9510,9519);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,9472,9519);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,9539,9807);

Exception 
ex = f_1607_9554_9806(InstanceIdParameter, f_1607_9677_9734(), id)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,9827,9931);

f_1607_9827_9930(this, f_1607_9838_9929(ex, "JobWithSpecifiedInstanceIdNotFound", ErrorCategory.ObjectNotFound, id));
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,8367,9946);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1607,1,1580);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1607,1,1580);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,9962,9977);

return matches;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,8037,9988);

System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_8216_8231()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 8216, 8231);
return return_v;
}


System.Collections.Hashtable
f_1607_8278_8293()
{
var return_v = new System.Collections.Hashtable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 8278, 8293);
return return_v;
}


int
f_1607_8487_8512(System.Collections.Hashtable
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 8487, 8512);
return 0;
}


System.Management.Automation.JobRepository
f_1607_8591_8604()
{
var return_v = JobRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 8591, 8604);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_8591_8609(System.Management.Automation.JobRepository
this_param)
{
var return_v = this_param.Jobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 8591, 8609);
return return_v;
}


bool
f_1607_8547_8716(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
matches,System.Collections.Generic.List<System.Management.Automation.Job>
jobsToSearch,System.Guid
instanceId,System.Collections.Hashtable
duplicateDetector,bool
recurse,bool
writeobject,bool
checkIfJobCanBeRemoved)
{
var return_v = this_param.FindJobsMatchingByInstanceIdHelper( matches, (System.Collections.Generic.IList<System.Management.Automation.Job>)jobsToSearch, instanceId, duplicateDetector, recurse, writeobject, checkIfJobCanBeRemoved);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 8547, 8716);
return return_v;
}


System.Management.Automation.JobManager
f_1607_8903_8913()
{
var return_v = JobManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 8903, 8913);
return return_v;
}


System.Management.Automation.Job2
f_1607_8903_8971(System.Management.Automation.JobManager
this_param,System.Guid
instanceId,Microsoft.PowerShell.Commands.JobCmdletBase
cmdlet,bool
writeErrorOnException,bool
writeObject,bool
recurse)
{
var return_v = this_param.GetJobByInstanceId( instanceId, (System.Management.Automation.Cmdlet)cmdlet, writeErrorOnException, writeObject, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 8903, 8971);
return return_v;
}


string
f_1607_9201_9262()
{
var return_v =                         RemotingErrorIdStrings.JobWithSpecifiedInstanceIdNotCompleted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 9201, 9262);
return return_v;
}


int
f_1607_9264_9271(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 9264, 9271);
return return_v;
}


System.Guid
f_1607_9273_9288(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 9273, 9288);
return return_v;
}


bool
f_1607_9101_9289(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,bool
checkForRemove,string
parameterName,System.Management.Automation.Job2
job2,string
resourceString,params object[]
args)
{
var return_v = this_param.CheckIfJob2CanBeRemoved( checkForRemove, parameterName, job2, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 9101, 9289);
return return_v;
}


int
f_1607_9339_9356(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Management.Automation.Job2
item)
{
this_param.Add( (System.Management.Automation.Job)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 9339, 9356);
return 0;
}


string
f_1607_9677_9734()
{
var return_v =                                                                   RemotingErrorIdStrings.JobWithSpecifiedInstanceIdNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 9677, 9734);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1607_9554_9806(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 9554, 9806);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1607_9838_9929(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Guid
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 9838, 9929);
return return_v;
}


int
f_1607_9827_9930(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 9827, 9930);
return 0;
}


System.Guid[]
f_1607_8387_8399_I(System.Guid[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 8387, 8399);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,8037,9988);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,8037,9988);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool FindJobsMatchingByInstanceIdHelper(List<Job> matches, IList<Job> jobsToSearch, Guid instanceId,
                        Hashtable duplicateDetector, bool recurse, bool writeobject, bool checkIfJobCanBeRemoved)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,10000,12481);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,10248,10270);

bool 
jobFound = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,10714,11752);
foreach(Job job in f_1607_10734_10746_I(jobsToSearch) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,10714,11752);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,10780,10891) || true) && (f_1607_10784_10821(duplicateDetector, f_1607_10814_10820(job)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,10780,10891);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,10863,10872);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,10780,10891);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,10911,10949);

f_1607_10911_10948(
                duplicateDetector, f_1607_10933_10939(job), f_1607_10941_10947(job));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,10969,11737) || true) && (f_1607_10973_10987(job)== instanceId)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,10969,11737);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,11043,11059);

jobFound = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,11081,11718) || true) && (!checkIfJobCanBeRemoved ||(DynAbs.Tracing.TraceSender.Expression_False(1607, 11085, 11245)||f_1607_11112_11245(this, job, InstanceIdParameter, f_1607_11159_11220(), f_1607_11222_11228(job), f_1607_11230_11244(job))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,11081,11718);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,11413,11661) || true) && (writeobject)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,11413,11661);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,11486,11503);

f_1607_11486_11502(this, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,11413,11661);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,11413,11661);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,11617,11634);

f_1607_11617_11633(                            matches, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,11413,11661);
}
DynAbs.Tracing.TraceSender.TraceBreak(1607,11689,11695);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,11081,11718);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,10969,11737);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,10714,11752);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1607,1,1039);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1607,1,1039);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,11828,12438) || true) && (!jobFound &&(DynAbs.Tracing.TraceSender.Expression_True(1607, 11832, 11852)&&recurse))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,11828,12438);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,11886,12423);
foreach(Job job in f_1607_11906_11918_I(jobsToSearch) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,11886,12423);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,11960,12404) || true) && (f_1607_11964_11977(job)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1607, 11964, 12012)&&f_1607_11989_12008(f_1607_11989_12002(job))> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,11960,12404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,12062,12250);

jobFound = f_1607_12073_12249(this, matches, f_1607_12117_12130(job), instanceId, duplicateDetector, recurse, writeobject, checkIfJobCanBeRemoved);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,12278,12381) || true) && (jobFound)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,12278,12381);
DynAbs.Tracing.TraceSender.TraceBreak(1607,12348,12354);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,12278,12381);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,11960,12404);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,11886,12423);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1607,1,538);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1607,1,538);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1607,11828,12438);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,12454,12470);

return jobFound;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,10000,12481);

int
f_1607_10814_10820(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 10814, 10820);
return return_v;
}


bool
f_1607_10784_10821(System.Collections.Hashtable
this_param,int
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 10784, 10821);
return return_v;
}


int
f_1607_10933_10939(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 10933, 10939);
return return_v;
}


int
f_1607_10941_10947(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 10941, 10947);
return return_v;
}


int
f_1607_10911_10948(System.Collections.Hashtable
this_param,int
key,int
value)
{
this_param.Add( (object)key, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 10911, 10948);
return 0;
}


System.Guid
f_1607_10973_10987(System.Management.Automation.Job
this_param)
{
var return_v = this_param.InstanceId ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 10973, 10987);
return return_v;
}


string
f_1607_11159_11220()
{
var return_v = RemotingErrorIdStrings.JobWithSpecifiedInstanceIdNotCompleted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 11159, 11220);
return return_v;
}


int
f_1607_11222_11228(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 11222, 11228);
return return_v;
}


System.Guid
f_1607_11230_11244(System.Management.Automation.Job
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 11230, 11244);
return return_v;
}


bool
f_1607_11112_11245(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Management.Automation.Job
job,string
parameterName,string
resourceString,params object[]
list)
{
var return_v = this_param.CheckJobCanBeRemoved( job, parameterName, resourceString, list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 11112, 11245);
return return_v;
}


int
f_1607_11486_11502(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Management.Automation.Job
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 11486, 11502);
return 0;
}


int
f_1607_11617_11633(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 11617, 11633);
return 0;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1607_10734_10746_I(System.Collections.Generic.IList<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 10734, 10746);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1607_11964_11977(System.Management.Automation.Job
this_param)
{
var return_v = this_param.ChildJobs ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 11964, 11977);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1607_11989_12002(System.Management.Automation.Job
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 11989, 12002);
return return_v;
}


int
f_1607_11989_12008(System.Collections.Generic.IList<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 11989, 12008);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1607_12117_12130(System.Management.Automation.Job
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 12117, 12130);
return return_v;
}


bool
f_1607_12073_12249(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
matches,System.Collections.Generic.IList<System.Management.Automation.Job>
jobsToSearch,System.Guid
instanceId,System.Collections.Hashtable
duplicateDetector,bool
recurse,bool
writeobject,bool
checkIfJobCanBeRemoved)
{
var return_v = this_param.FindJobsMatchingByInstanceIdHelper( matches, jobsToSearch, instanceId, duplicateDetector, recurse, writeobject, checkIfJobCanBeRemoved);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 12073, 12249);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1607_11906_11918_I(System.Collections.Generic.IList<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 11906, 11918);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,10000,12481);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,10000,12481);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal List<Job> FindJobsMatchingBySessionId(bool recurse, bool writeobject, bool writeErrorOnNoMatch, bool checkIfJobCanBeRemoved)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,13082,14701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,13240,13276);

List<Job> 
matches = f_1607_13260_13275()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,13292,13332) || true) && (_sessionIds == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,13292,13332);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,13317,13332);

return matches;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,13292,13332);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,13348,13394);

Hashtable 
duplicateDetector = f_1607_13378_13393()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,13410,14659);
foreach(int id in f_1607_13429_13440_I(_sessionIds) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,13410,14659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,13523,13708);

bool 
jobFound = f_1607_13539_13707(this, matches, f_1607_13582_13600(f_1607_13582_13595()), id, duplicateDetector, recurse, writeobject, checkIfJobCanBeRemoved)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,13774,13847);

Job2 
job2 = f_1607_13786_13846(f_1607_13786_13796(), id, this, false, writeobject, recurse)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,13865,13895);

bool 
job2Found = job2 != null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,13915,14253) || true) && (job2Found)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,13915,14253);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,13970,14234) || true) && (f_1607_13974_14143(this, checkIfJobCanBeRemoved, SessionIdParameter, job2, f_1607_14073_14133(), f_1607_14135_14142(job2)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,13970,14234);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,14193,14211);

f_1607_14193_14210(                        matches, job2);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,13970,14234);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,13915,14253);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,14273,14306);

jobFound = jobFound ||(DynAbs.Tracing.TraceSender.Expression_False(1607, 14284, 14305)||job2Found);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,14326,14373) || true) && (jobFound ||(DynAbs.Tracing.TraceSender.Expression_False(1607, 14330, 14362)||!writeErrorOnNoMatch))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,14326,14373);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,14364,14373);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,14326,14373);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,14393,14525);

Exception 
ex = f_1607_14408_14524(SessionIdParameter, f_1607_14463_14519(), id)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,14543,14644);

f_1607_14543_14643(this, f_1607_14554_14642(ex, "JobWithSpecifiedSessionNotFound", ErrorCategory.ObjectNotFound, id));
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,13410,14659);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1607,1,1250);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1607,1,1250);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,14675,14690);

return matches;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,13082,14701);

System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_13260_13275()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 13260, 13275);
return return_v;
}


System.Collections.Hashtable
f_1607_13378_13393()
{
var return_v = new System.Collections.Hashtable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 13378, 13393);
return return_v;
}


System.Management.Automation.JobRepository
f_1607_13582_13595()
{
var return_v = JobRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 13582, 13595);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_13582_13600(System.Management.Automation.JobRepository
this_param)
{
var return_v = this_param.Jobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 13582, 13600);
return return_v;
}


bool
f_1607_13539_13707(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
matches,System.Collections.Generic.List<System.Management.Automation.Job>
jobsToSearch,int
sessionId,System.Collections.Hashtable
duplicateDetector,bool
recurse,bool
writeobject,bool
checkIfJobCanBeRemoved)
{
var return_v = this_param.FindJobsMatchingBySessionIdHelper( matches, (System.Collections.Generic.IList<System.Management.Automation.Job>)jobsToSearch, sessionId, duplicateDetector, recurse, writeobject, checkIfJobCanBeRemoved);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 13539, 13707);
return return_v;
}


System.Management.Automation.JobManager
f_1607_13786_13796()
{
var return_v = JobManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 13786, 13796);
return return_v;
}


System.Management.Automation.Job2
f_1607_13786_13846(System.Management.Automation.JobManager
this_param,int
id,Microsoft.PowerShell.Commands.JobCmdletBase
cmdlet,bool
writeErrorOnException,bool
writeObject,bool
recurse)
{
var return_v = this_param.GetJobById( id, (System.Management.Automation.Cmdlet)cmdlet, writeErrorOnException, writeObject, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 13786, 13846);
return return_v;
}


string
f_1607_14073_14133()
{
var return_v =                         RemotingErrorIdStrings.JobWithSpecifiedSessionIdNotCompleted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 14073, 14133);
return return_v;
}


int
f_1607_14135_14142(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 14135, 14142);
return return_v;
}


bool
f_1607_13974_14143(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,bool
checkForRemove,string
parameterName,System.Management.Automation.Job2
job2,string
resourceString,params object[]
args)
{
var return_v = this_param.CheckIfJob2CanBeRemoved( checkForRemove, parameterName, job2, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 13974, 14143);
return return_v;
}


int
f_1607_14193_14210(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Management.Automation.Job2
item)
{
this_param.Add( (System.Management.Automation.Job)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 14193, 14210);
return 0;
}


string
f_1607_14463_14519()
{
var return_v = RemotingErrorIdStrings.JobWithSpecifiedSessionIdNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 14463, 14519);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1607_14408_14524(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 14408, 14524);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1607_14554_14642(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,int
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 14554, 14642);
return return_v;
}


int
f_1607_14543_14643(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 14543, 14643);
return 0;
}


int[]
f_1607_13429_13440_I(int[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 13429, 13440);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,13082,14701);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,13082,14701);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool FindJobsMatchingBySessionIdHelper(List<Job> matches, IList<Job> jobsToSearch, int sessionId,
                        Hashtable duplicateDetector, bool recurse, bool writeobject, bool checkIfJobCanBeRemoved)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,14713,17005);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,14958,14980);

bool 
jobFound = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,15432,16272);
foreach(Job job in f_1607_15452_15464_I(jobsToSearch) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,15432,16272);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,15498,16257) || true) && (f_1607_15502_15508(job)== sessionId)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,15498,16257);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,15563,15579);

jobFound = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,15601,16238) || true) && (!checkIfJobCanBeRemoved ||(DynAbs.Tracing.TraceSender.Expression_False(1607, 15605, 15747)||f_1607_15632_15747(this, job, SessionIdParameter, f_1607_15678_15738(), f_1607_15740_15746(job))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,15601,16238);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,15797,16045) || true) && (writeobject)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,15797,16045);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,15870,15887);

f_1607_15870_15886(this, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,15797,16045);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,15797,16045);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,16001,16018);

f_1607_16001_16017(                            matches, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,15797,16045);
}
DynAbs.Tracing.TraceSender.TraceBreak(1607,16209,16215);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,15601,16238);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,15498,16257);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,15432,16272);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1607,1,841);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1607,1,841);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,16354,16962) || true) && (!jobFound &&(DynAbs.Tracing.TraceSender.Expression_True(1607, 16358, 16378)&&recurse))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,16354,16962);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,16412,16947);
foreach(Job job in f_1607_16432_16444_I(jobsToSearch) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,16412,16947);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,16486,16928) || true) && (f_1607_16490_16503(job)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1607, 16490, 16538)&&f_1607_16515_16534(f_1607_16515_16528(job))> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,16486,16928);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,16588,16774);

jobFound = f_1607_16599_16773(this, matches, f_1607_16642_16655(job), sessionId, duplicateDetector, recurse, writeobject, checkIfJobCanBeRemoved);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,16802,16905) || true) && (jobFound)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,16802,16905);
DynAbs.Tracing.TraceSender.TraceBreak(1607,16872,16878);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,16802,16905);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,16486,16928);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,16412,16947);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1607,1,536);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1607,1,536);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1607,16354,16962);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,16978,16994);

return jobFound;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,14713,17005);

int
f_1607_15502_15508(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Id ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 15502, 15508);
return return_v;
}


string
f_1607_15678_15738()
{
var return_v = RemotingErrorIdStrings.JobWithSpecifiedSessionIdNotCompleted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 15678, 15738);
return return_v;
}


int
f_1607_15740_15746(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 15740, 15746);
return return_v;
}


bool
f_1607_15632_15747(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Management.Automation.Job
job,string
parameterName,string
resourceString,params object[]
list)
{
var return_v = this_param.CheckJobCanBeRemoved( job, parameterName, resourceString, list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 15632, 15747);
return return_v;
}


int
f_1607_15870_15886(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Management.Automation.Job
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 15870, 15886);
return 0;
}


int
f_1607_16001_16017(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 16001, 16017);
return 0;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1607_15452_15464_I(System.Collections.Generic.IList<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 15452, 15464);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1607_16490_16503(System.Management.Automation.Job
this_param)
{
var return_v = this_param.ChildJobs ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 16490, 16503);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1607_16515_16528(System.Management.Automation.Job
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 16515, 16528);
return return_v;
}


int
f_1607_16515_16534(System.Collections.Generic.IList<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 16515, 16534);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1607_16642_16655(System.Management.Automation.Job
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 16642, 16655);
return return_v;
}


bool
f_1607_16599_16773(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
matches,System.Collections.Generic.IList<System.Management.Automation.Job>
jobsToSearch,int
sessionId,System.Collections.Hashtable
duplicateDetector,bool
recurse,bool
writeobject,bool
checkIfJobCanBeRemoved)
{
var return_v = this_param.FindJobsMatchingBySessionIdHelper( matches, jobsToSearch, sessionId, duplicateDetector, recurse, writeobject, checkIfJobCanBeRemoved);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 16599, 16773);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1607_16432_16444_I(System.Collections.Generic.IList<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 16432, 16444);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,14713,17005);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,14713,17005);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal List<Job> FindJobsMatchingByCommand(
            bool writeobject)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,17350,19051);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,17451,17487);

List<Job> 
matches = f_1607_17471_17486()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,17503,17541) || true) && (_commands == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,17503,17541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,17526,17541);

return matches;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,17503,17541);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,17557,17590);

List<Job> 
jobs = f_1607_17574_17589()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,17606,17640);

f_1607_17606_17639(
            jobs, f_1607_17620_17638(f_1607_17620_17633()));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,17656,19009);
foreach(string command in f_1607_17683_17692_I(_commands) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,17656,19009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,17726,17815);

List<Job2> 
jobs2 = f_1607_17745_17814(f_1607_17745_17755(), command, this, false, false, false, null)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,17835,18028) || true) && (jobs2 != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,17835,18028);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,17894,18009);
foreach(Job2 job2 in f_1607_17916_17921_I(jobs2) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,17894,18009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,17971,17986);

f_1607_17971_17985(                        jobs, job2);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,17894,18009);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1607,1,116);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1607,1,116);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1607,17835,18028);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,18048,18994);
foreach(Job job in f_1607_18068_18072_I(jobs) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,18048,18994);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,18114,18204);

WildcardPattern 
commandPattern = f_1607_18147_18203(command, WildcardOptions.IgnoreCase)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,18226,18265);

string 
jobCommand = f_1607_18246_18264(f_1607_18246_18257(job))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,18543,18975) || true) && (f_1607_18547_18616(jobCommand, f_1607_18565_18579(command), StringComparison.OrdinalIgnoreCase)||(DynAbs.Tracing.TraceSender.Expression_False(1607, 18547, 18654)||f_1607_18620_18654(commandPattern, jobCommand)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,18543,18975);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,18704,18952) || true) && (writeobject)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,18704,18952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,18777,18794);

f_1607_18777_18793(this, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,18704,18952);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,18704,18952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,18908,18925);

f_1607_18908_18924(                            matches, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,18704,18952);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,18543,18975);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,18048,18994);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1607,1,947);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1607,1,947);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1607,17656,19009);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1607,1,1354);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1607,1,1354);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,19025,19040);

return matches;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,17350,19051);

System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_17471_17486()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 17471, 17486);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_17574_17589()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 17574, 17589);
return return_v;
}


System.Management.Automation.JobRepository
f_1607_17620_17633()
{
var return_v = JobRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 17620, 17633);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_17620_17638(System.Management.Automation.JobRepository
this_param)
{
var return_v = this_param.Jobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 17620, 17638);
return return_v;
}


int
f_1607_17606_17639(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
collection)
{
this_param.AddRange( (System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 17606, 17639);
return 0;
}


System.Management.Automation.JobManager
f_1607_17745_17755()
{
var return_v = JobManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 17745, 17755);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job2>
f_1607_17745_17814(System.Management.Automation.JobManager
this_param,string
command,Microsoft.PowerShell.Commands.JobCmdletBase
cmdlet,bool
writeErrorOnException,bool
writeObject,bool
recurse,string[]
jobSourceAdapterTypes)
{
var return_v = this_param.GetJobsByCommand( command, (System.Management.Automation.Cmdlet)cmdlet, writeErrorOnException, writeObject, recurse, jobSourceAdapterTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 17745, 17814);
return return_v;
}


int
f_1607_17971_17985(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Management.Automation.Job2
item)
{
this_param.Add( (System.Management.Automation.Job)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 17971, 17985);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job2>
f_1607_17916_17921_I(System.Collections.Generic.List<System.Management.Automation.Job2>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 17916, 17921);
return return_v;
}


System.Management.Automation.WildcardPattern
f_1607_18147_18203(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 18147, 18203);
return return_v;
}


string
f_1607_18246_18257(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 18246, 18257);
return return_v;
}


string
f_1607_18246_18264(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 18246, 18264);
return return_v;
}


string
f_1607_18565_18579(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 18565, 18579);
return return_v;
}


bool
f_1607_18547_18616(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 18547, 18616);
return return_v;
}


bool
f_1607_18620_18654(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 18620, 18654);
return return_v;
}


int
f_1607_18777_18793(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Management.Automation.Job
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 18777, 18793);
return 0;
}


int
f_1607_18908_18924(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 18908, 18924);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_18068_18072_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 18068, 18072);
return return_v;
}


string[]
f_1607_17683_17692_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 17683, 17692);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,17350,19051);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,17350,19051);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal List<Job> FindJobsMatchingByState(
            bool writeobject)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,19394,20309);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,19493,19529);

List<Job> 
matches = f_1607_19513_19528()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,19543,19576);

List<Job> 
jobs = f_1607_19560_19575()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,19592,19626);

f_1607_19592_19625(
            jobs, f_1607_19606_19624(f_1607_19606_19619()));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,19642,19731);

List<Job2> 
jobs2 = f_1607_19661_19730(f_1607_19661_19671(), _jobstate, this, false, false, false, null)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,19747,19916) || true) && (jobs2 != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,19747,19916);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,19798,19901);
foreach(Job2 job2 in f_1607_19820_19825_I(jobs2) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,19798,19901);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,19867,19882);

f_1607_19867_19881(                    jobs, job2);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,19798,19901);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1607,1,104);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1607,1,104);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1607,19747,19916);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,19932,20267);
foreach(Job job in f_1607_19952_19956_I(jobs) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,19932,20267);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,19990,20040) || true) && (f_1607_19994_20016(f_1607_19994_20010(job))!= _jobstate)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,19990,20040);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,20031,20040);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,19990,20040);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,20060,20252) || true) && (writeobject)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,20060,20252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,20117,20134);

f_1607_20117_20133(this, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,20060,20252);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,20060,20252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,20216,20233);

f_1607_20216_20232(                    matches, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,20060,20252);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,19932,20267);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1607,1,336);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1607,1,336);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,20283,20298);

return matches;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,19394,20309);

System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_19513_19528()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 19513, 19528);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_19560_19575()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 19560, 19575);
return return_v;
}


System.Management.Automation.JobRepository
f_1607_19606_19619()
{
var return_v = JobRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 19606, 19619);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_19606_19624(System.Management.Automation.JobRepository
this_param)
{
var return_v = this_param.Jobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 19606, 19624);
return return_v;
}


int
f_1607_19592_19625(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
collection)
{
this_param.AddRange( (System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 19592, 19625);
return 0;
}


System.Management.Automation.JobManager
f_1607_19661_19671()
{
var return_v = JobManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 19661, 19671);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job2>
f_1607_19661_19730(System.Management.Automation.JobManager
this_param,System.Management.Automation.JobState
state,Microsoft.PowerShell.Commands.JobCmdletBase
cmdlet,bool
writeErrorOnException,bool
writeObject,bool
recurse,string[]
jobSourceAdapterTypes)
{
var return_v = this_param.GetJobsByState( state, (System.Management.Automation.Cmdlet)cmdlet, writeErrorOnException, writeObject, recurse, jobSourceAdapterTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 19661, 19730);
return return_v;
}


int
f_1607_19867_19881(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Management.Automation.Job2
item)
{
this_param.Add( (System.Management.Automation.Job)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 19867, 19881);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job2>
f_1607_19820_19825_I(System.Collections.Generic.List<System.Management.Automation.Job2>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 19820, 19825);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1607_19994_20010(System.Management.Automation.Job
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 19994, 20010);
return return_v;
}


System.Management.Automation.JobState
f_1607_19994_20016(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 19994, 20016);
return return_v;
}


int
f_1607_20117_20133(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Management.Automation.Job
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 20117, 20133);
return 0;
}


int
f_1607_20216_20232(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 20216, 20232);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_19952_19956_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 19952, 19956);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,19394,20309);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,19394,20309);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal List<Job> FindJobsMatchingByFilter(bool writeobject)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,20510,21671);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,20596,20632);

List<Job> 
matches = f_1607_20616_20631()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,20646,20679);

List<Job> 
jobs = f_1607_20663_20678()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,20789,20846);

f_1607_20789_20845(this, jobs, f_1607_20826_20844(f_1607_20826_20839()));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,20862,20918);

var 
filterDictionary = f_1607_20885_20917()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,20932,21059);
foreach(string item in f_1607_20956_20968_I(f_1607_20956_20968(_filter)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,20932,21059);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,21002,21044);

f_1607_21002_21043(                filterDictionary, item, f_1607_21029_21042(_filter, item));
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,20932,21059);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1607,1,128);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1607,1,128);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,21075,21165);

List<Job2> 
jobs2 = f_1607_21094_21164(f_1607_21094_21104(), filterDictionary, this, false, false, true)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,21179,21348) || true) && (jobs2 != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,21179,21348);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,21230,21333);
foreach(Job2 job2 in f_1607_21252_21257_I(jobs2) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,21230,21333);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,21299,21314);

f_1607_21299_21313(                    jobs, job2);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,21230,21333);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1607,1,104);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1607,1,104);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1607,21179,21348);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,21364,21629);
foreach(Job job in f_1607_21384_21388_I(jobs) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,21364,21629);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,21422,21614) || true) && (writeobject)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,21422,21614);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,21479,21496);

f_1607_21479_21495(this, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,21422,21614);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,21422,21614);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,21578,21595);

f_1607_21578_21594(                    matches, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,21422,21614);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,21364,21629);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1607,1,266);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1607,1,266);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,21645,21660);

return matches;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,20510,21671);

System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_20616_20631()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 20616, 20631);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_20663_20678()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 20663, 20678);
return return_v;
}


System.Management.Automation.JobRepository
f_1607_20826_20839()
{
var return_v = JobRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 20826, 20839);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_20826_20844(System.Management.Automation.JobRepository
this_param)
{
var return_v = this_param.Jobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 20826, 20844);
return return_v;
}


bool
f_1607_20789_20845(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
matches,System.Collections.Generic.List<System.Management.Automation.Job>
jobsToSearch)
{
var return_v = this_param.FindJobsMatchingByFilterHelper( matches, jobsToSearch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 20789, 20845);
return return_v;
}


System.Collections.Generic.Dictionary<string, object>
f_1607_20885_20917()
{
var return_v = new System.Collections.Generic.Dictionary<string, object>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 20885, 20917);
return return_v;
}


System.Collections.ICollection
f_1607_20956_20968(System.Collections.Hashtable
this_param)
{
var return_v = this_param.Keys;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 20956, 20968);
return return_v;
}


object
f_1607_21029_21042(System.Collections.Hashtable
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 21029, 21042);
return return_v;
}


int
f_1607_21002_21043(System.Collections.Generic.Dictionary<string, object>
this_param,string
key,object
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 21002, 21043);
return 0;
}


System.Collections.ICollection
f_1607_20956_20968_I(System.Collections.ICollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 20956, 20968);
return return_v;
}


System.Management.Automation.JobManager
f_1607_21094_21104()
{
var return_v = JobManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 21094, 21104);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job2>
f_1607_21094_21164(System.Management.Automation.JobManager
this_param,System.Collections.Generic.Dictionary<string, object>
filter,Microsoft.PowerShell.Commands.JobCmdletBase
cmdlet,bool
writeErrorOnException,bool
writeObject,bool
recurse)
{
var return_v = this_param.GetJobsByFilter( filter, (System.Management.Automation.Cmdlet)cmdlet, writeErrorOnException, writeObject, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 21094, 21164);
return return_v;
}


int
f_1607_21299_21313(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Management.Automation.Job2
item)
{
this_param.Add( (System.Management.Automation.Job)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 21299, 21313);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job2>
f_1607_21252_21257_I(System.Collections.Generic.List<System.Management.Automation.Job2>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 21252, 21257);
return return_v;
}


int
f_1607_21479_21495(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Management.Automation.Job
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 21479, 21495);
return 0;
}


int
f_1607_21578_21594(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 21578, 21594);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_21384_21388_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 21384, 21388);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,20510,21671);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,20510,21671);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool FindJobsMatchingByFilterHelper(List<Job> matches, List<Job> jobsToSearch)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,21921,22176);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,22152,22165);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,21921,22176);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,21921,22176);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,21921,22176);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal List<Job> CopyJobsToList(Job[] jobs, bool writeobject, bool checkIfJobCanBeRemoved)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,22617,23362);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,22734,22770);

List<Job> 
matches = f_1607_22754_22769()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,22784,22817) || true) && (jobs == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,22784,22817);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,22802,22817);

return matches;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,22784,22817);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,22833,23320);
foreach(Job job in f_1607_22853_22857_I(jobs) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,22833,23320);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,22891,23305) || true) && (!checkIfJobCanBeRemoved ||(DynAbs.Tracing.TraceSender.Expression_False(1607, 22895, 23024)||f_1607_22922_23024(this, job, "Job", f_1607_22955_23015(), f_1607_23017_23023(job))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,22891,23305);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,23066,23286) || true) && (writeobject)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,23066,23286);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,23131,23148);

f_1607_23131_23147(this, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,23066,23286);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,23066,23286);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,23246,23263);

f_1607_23246_23262(                        matches, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,23066,23286);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,22891,23305);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,22833,23320);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1607,1,488);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1607,1,488);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,23336,23351);

return matches;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,22617,23362);

System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_22754_22769()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 22754, 22769);
return return_v;
}


string
f_1607_22955_23015()
{
var return_v = RemotingErrorIdStrings.JobWithSpecifiedSessionIdNotCompleted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 22955, 23015);
return return_v;
}


int
f_1607_23017_23023(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 23017, 23023);
return return_v;
}


bool
f_1607_22922_23024(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Management.Automation.Job
job,string
parameterName,string
resourceString,params object[]
list)
{
var return_v = this_param.CheckJobCanBeRemoved( job, parameterName, resourceString, list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 22922, 23024);
return return_v;
}


int
f_1607_23131_23147(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Management.Automation.Job
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 23131, 23147);
return 0;
}


int
f_1607_23246_23262(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 23246, 23262);
return 0;
}


System.Management.Automation.Job[]
f_1607_22853_22857_I(System.Management.Automation.Job[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 22853, 22857);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,22617,23362);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,22617,23362);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool CheckJobCanBeRemoved(Job job, string parameterName, string resourceString, params object[] list)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,23937,24484);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,24071,24149) || true) && (f_1607_24075_24118(job, f_1607_24095_24117(f_1607_24095_24111(job))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,24071,24149);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,24137,24149);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,24071,24149);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,24163,24249);

string 
message = f_1607_24180_24248(resourceString, list)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,24263,24324);

Exception 
ex = f_1607_24278_24323(message, parameterName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,24338,24446);

f_1607_24338_24445(this, f_1607_24349_24444(ex, "JobObjectNotFinishedCannotBeRemoved", ErrorCategory.InvalidOperation, job));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,24460,24473);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,23937,24484);

System.Management.Automation.JobStateInfo
f_1607_24095_24111(System.Management.Automation.Job
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 24095, 24111);
return return_v;
}


System.Management.Automation.JobState
f_1607_24095_24117(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 24095, 24117);
return return_v;
}


bool
f_1607_24075_24118(System.Management.Automation.Job
this_param,System.Management.Automation.JobState
state)
{
var return_v = this_param.IsFinishedState( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 24075, 24118);
return return_v;
}


string
f_1607_24180_24248(string
resourceString,params object[]
args)
{
var return_v = PSRemotingErrorInvariants.FormatResourceString( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 24180, 24248);
return return_v;
}


System.ArgumentException
f_1607_24278_24323(string
message,string
paramName)
{
var return_v = new System.ArgumentException( message, paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 24278, 24323);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1607_24349_24444(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Job
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 24349, 24444);
return return_v;
}


int
f_1607_24338_24445(Microsoft.PowerShell.Commands.JobCmdletBase
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 24338, 24445);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,23937,24484);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,23937,24484);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Parameter(ValueFromPipelineByPropertyName = true, Position = 0,
                  Mandatory = true,
                  ParameterSetName = JobCmdletBase.NameParameterSet)]
        [ValidateNotNullOrEmpty]
        public string[] Name
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,24910,24975);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,24946,24960);

return _names;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,24910,24975);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,24649,25068);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,24649,25068);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,24991,25057);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,25027,25042);

_names = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,24991,25057);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,24649,25068);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,24649,25068);
}
		}}

private string[] _names;

[Parameter(ValueFromPipelineByPropertyName = true, Position = 0,
                   Mandatory = true,
                   ParameterSetName = JobCmdletBase.InstanceIdParameterSet)]
        [ValidateNotNullOrEmpty]
        public Guid[] InstanceId
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,25556,25627);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,25592,25612);

return _instanceIds;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,25556,25627);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,25283,25726);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,25283,25726);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,25643,25715);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,25679,25700);

_instanceIds = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,25643,25715);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,25283,25726);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,25283,25726);
}
		}}

private Guid[] _instanceIds;

[Parameter(ValueFromPipelineByPropertyName = true, Position = 0,
                  Mandatory = true,
                  ParameterSetName = JobCmdletBase.SessionIdParameterSet)]
        [ValidateNotNullOrEmpty]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public virtual int[] Id
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,26306,26376);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,26342,26361);

return _sessionIds;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,26306,26376);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,25943,26474);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,25943,26474);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,26392,26463);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,26428,26448);

_sessionIds = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,26392,26463);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,25943,26474);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,25943,26474);
}
		}}

private int[] _sessionIds;

[Parameter(Mandatory = true,
                   Position = 0, ValueFromPipelineByPropertyName = true,
            ParameterSetName = RemoveJobCommand.StateParameterSet)]
        public virtual JobState State
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,26905,26973);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,26941,26958);

return _jobstate;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,26905,26973);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,26670,27069);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,26670,27069);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,26989,27058);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,27025,27043);

_jobstate = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,26989,27058);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,26670,27069);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,26670,27069);
}
		}}

private JobState _jobstate;

[Parameter(ValueFromPipelineByPropertyName = true,
            ParameterSetName = RemoveJobCommand.CommandParameterSet)]
        [ValidateNotNullOrEmpty]
        public virtual string[] Command
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,27489,27557);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,27525,27542);

return _commands;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,27489,27557);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,27268,27653);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,27268,27653);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,27573,27642);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,27609,27627);

_commands = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,27573,27642);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,27268,27653);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,27268,27653);
}
		}}

private string[] _commands;

[Parameter(Mandatory = true,
                   Position = 0, ValueFromPipelineByPropertyName = true,
            ParameterSetName = RemoveJobCommand.FilterParameterSet)]
        [ValidateNotNullOrEmpty]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual Hashtable Filter
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,28227,28250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,28233,28248);

return _filter;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,28227,28250);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,27862,28301);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,27862,28301);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,28266,28290);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,28272,28288);

_filter = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,28266,28290);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,27862,28301);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,27862,28301);
}
		}}

private Hashtable _filter;

protected override void BeginProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,28801,29080);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,28867,28955);

f_1607_28867_28954(f_1607_28921_28933(this), f_1607_28935_28953(this));
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,28801,29080);

System.Management.Automation.ExecutionContext
f_1607_28921_28933(Microsoft.PowerShell.Commands.JobCmdletBase
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 28921, 28933);
return return_v;
}


System.Management.Automation.CommandOrigin
f_1607_28935_28953(Microsoft.PowerShell.Commands.JobCmdletBase
this_param)
{
var return_v = this_param.CommandOrigin;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 28935, 28953);
return return_v;
}


int
f_1607_28867_28954(System.Management.Automation.ExecutionContext
context,System.Management.Automation.CommandOrigin
commandOrigin)
{
CommandDiscovery.AutoloadModulesWithJobSourceAdapters( context, commandOrigin);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 28867, 28954);
return 0;
}

            // intentionally left blank to avoid
            // check being performed in base.BeginProcessing()
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,28801,29080);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,28801,29080);
}
		}

public JobCmdletBase()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1607,584,29117);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,25144,25150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,25800,25812);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,26547,26558);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,27145,27154);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,27729,27738);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,28331,28338);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1607,584,29117);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,584,29117);
}


static JobCmdletBase()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1607,584,29117);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,741,776);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,809,858);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,891,938);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,971,1008);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,1041,1080);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,1113,1156);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,1189,1230);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,1300,1320);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,1353,1387);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,1420,1452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,1485,1507);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,1540,1564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,1597,1625);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,1658,1684);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1607,584,29117);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,584,29117);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1607,584,29117);
}
[Cmdlet(VerbsCommon.Remove, "Job", SupportsShouldProcess = true, DefaultParameterSetName = JobCmdletBase.SessionIdParameterSet,
        HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096868")]
    [OutputType(typeof(Job), ParameterSetName = new string[] { JobCmdletBase.JobParameterSet })]
    public class RemoveJobCommand : JobCmdletBase, IDisposable
{
[Parameter(Mandatory = true,
                   Position = 0,
                   ValueFromPipeline = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = RemoveJobCommand.JobParameterSet)]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [ValidateNotNullOrEmpty]
        public Job[] Job
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,30321,30385);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,30357,30370);

return _jobs;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,30321,30385);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,29900,30477);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,29900,30477);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,30401,30466);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,30437,30451);

_jobs = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,30401,30466);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,29900,30477);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,29900,30477);
}
		}}

private Job[] _jobs;

[Parameter(ParameterSetName = RemoveJobCommand.InstanceIdParameterSet)]
        [Parameter(ParameterSetName = RemoveJobCommand.JobParameterSet)]
        [Parameter(ParameterSetName = RemoveJobCommand.NameParameterSet)]
        [Parameter(ParameterSetName = RemoveJobCommand.SessionIdParameterSet)]
        [Parameter(ParameterSetName = RemoveJobCommand.FilterParameterSet)]
        [Alias("F")]
        public SwitchParameter Force
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,31119,31184);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,31155,31169);

return _force;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,31119,31184);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,30657,31277);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,30657,31277);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,31200,31266);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,31236,31251);

_force = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,31200,31266);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,30657,31277);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,30657,31277);
}
		}}

private bool _force ;

protected override void ProcessRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,31508,34718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,31572,31608);

List<Job> 
listOfJobsToRemove = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,31624,33134);

switch (f_1607_31632_31648())
            {

case NameParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,31624,33134);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,31753,31826);

listOfJobsToRemove = f_1607_31774_31825(this, false, false, true, !_force);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1607,31873,31879);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,31624,33134);

case InstanceIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,31624,33134);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,31976,32054);

listOfJobsToRemove = f_1607_31997_32053(this, true, false, true, !_force);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1607,32101,32107);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,31624,33134);

case SessionIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,31624,33134);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,32203,32280);

listOfJobsToRemove = f_1607_32224_32279(this, true, false, true, !_force);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1607,32327,32333);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,31624,33134);

case CommandParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,31624,33134);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,32427,32481);

listOfJobsToRemove = f_1607_32448_32480(this, false);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1607,32528,32534);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,31624,33134);

case StateParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,31624,33134);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,32626,32678);

listOfJobsToRemove = f_1607_32647_32677(this, false);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1607,32725,32731);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,31624,33134);

case FilterParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,31624,33134);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,32824,32877);

listOfJobsToRemove = f_1607_32845_32876(this, false);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1607,32924,32930);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,31624,33134);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,31624,33134);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,33007,33066);

listOfJobsToRemove = f_1607_33028_33065(this, _jobs, false, !_force);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1607,33113,33119);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,31624,33134);
            }
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,33195,34707);
foreach(Job job in f_1607_33215_33233_I(listOfJobsToRemove) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,33195,34707);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,33267,33387);

string 
message = f_1607_33284_33386(this, f_1607_33295_33339(), f_1607_33366_33377(job), f_1607_33379_33385(job))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,33407,33465) || true) && (!f_1607_33412_33454(this, message, VerbsCommon.Remove))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,33407,33465);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,33456,33465);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,33407,33465);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,33485,33509);

Job2 
job2 = job as Job2
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,33527,34692) || true) && (!f_1607_33532_33575(job, f_1607_33552_33574(f_1607_33552_33568(job))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,33527,34692);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,33734,34552) || true) && (job2 != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,33734,34552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,33800,33850);

f_1607_33800_33849(                        _cleanUpActions, job2, HandleStopJobCompleted);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,33876,33924);

job2.StopJobCompleted += HandleStopJobCompleted;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,33958,33969);

                        lock (_syncObject)
                        {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,34027,34284) || true) && (!f_1607_34032_34077(job2, f_1607_34053_34076(f_1607_34053_34070(job2)))&&(DynAbs.Tracing.TraceSender.Expression_True(1607, 34031, 34153)&&                                !f_1607_34115_34153(_pendingJobs, f_1607_34137_34152(job2))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,34027,34284);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,34219,34253);

f_1607_34219_34252(                                _pendingJobs, f_1607_34236_34251(job2));
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,34027,34284);
}
                        }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,34339,34359);

f_1607_34339_34358(
                        job2);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,33734,34552);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,33734,34552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,34457,34471);

f_1607_34457_34470(                        job);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,34497,34529);

f_1607_34497_34528(this, job, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,33734,34552);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,33527,34692);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,33527,34692);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,34634,34673);

f_1607_34634_34672(this, job, job2 != null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,33527,34692);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,33195,34707);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1607,1,1513);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1607,1,1513);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1607,31508,34718);

string
f_1607_31632_31648()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 31632, 31648);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_31774_31825(Microsoft.PowerShell.Commands.RemoveJobCommand
this_param,bool
recurse,bool
writeobject,bool
writeErrorOnNoMatch,bool
checkIfJobCanBeRemoved)
{
var return_v = this_param.FindJobsMatchingByName( recurse, writeobject, writeErrorOnNoMatch, checkIfJobCanBeRemoved);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 31774, 31825);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_31997_32053(Microsoft.PowerShell.Commands.RemoveJobCommand
this_param,bool
recurse,bool
writeobject,bool
writeErrorOnNoMatch,bool
checkIfJobCanBeRemoved)
{
var return_v = this_param.FindJobsMatchingByInstanceId( recurse, writeobject, writeErrorOnNoMatch, checkIfJobCanBeRemoved);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 31997, 32053);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_32224_32279(Microsoft.PowerShell.Commands.RemoveJobCommand
this_param,bool
recurse,bool
writeobject,bool
writeErrorOnNoMatch,bool
checkIfJobCanBeRemoved)
{
var return_v = this_param.FindJobsMatchingBySessionId( recurse, writeobject, writeErrorOnNoMatch, checkIfJobCanBeRemoved);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 32224, 32279);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_32448_32480(Microsoft.PowerShell.Commands.RemoveJobCommand
this_param,bool
writeobject)
{
var return_v = this_param.FindJobsMatchingByCommand( writeobject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 32448, 32480);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_32647_32677(Microsoft.PowerShell.Commands.RemoveJobCommand
this_param,bool
writeobject)
{
var return_v = this_param.FindJobsMatchingByState( writeobject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 32647, 32677);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_32845_32876(Microsoft.PowerShell.Commands.RemoveJobCommand
this_param,bool
writeobject)
{
var return_v = this_param.FindJobsMatchingByFilter( writeobject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 32845, 32876);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_33028_33065(Microsoft.PowerShell.Commands.RemoveJobCommand
this_param,System.Management.Automation.Job[]
jobs,bool
writeobject,bool
checkIfJobCanBeRemoved)
{
var return_v = this_param.CopyJobsToList( jobs, writeobject, checkIfJobCanBeRemoved);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 33028, 33065);
return return_v;
}


string
f_1607_33295_33339()
{
var return_v = RemotingErrorIdStrings.StopPSJobWhatIfTarget;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 33295, 33339);
return return_v;
}


string
f_1607_33366_33377(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 33366, 33377);
return return_v;
}


int
f_1607_33379_33385(System.Management.Automation.Job
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 33379, 33385);
return return_v;
}


string
f_1607_33284_33386(Microsoft.PowerShell.Commands.RemoveJobCommand
this_param,string
resourceString,params object[]
args)
{
var return_v = this_param.GetMessage( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 33284, 33386);
return return_v;
}


bool
f_1607_33412_33454(Microsoft.PowerShell.Commands.RemoveJobCommand
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 33412, 33454);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1607_33552_33568(System.Management.Automation.Job
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 33552, 33568);
return return_v;
}


System.Management.Automation.JobState
f_1607_33552_33574(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 33552, 33574);
return return_v;
}


bool
f_1607_33532_33575(System.Management.Automation.Job
this_param,System.Management.Automation.JobState
state)
{
var return_v = this_param.IsFinishedState( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 33532, 33575);
return return_v;
}


int
f_1607_33800_33849(System.Collections.Generic.Dictionary<System.Management.Automation.Job2, System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs>>
this_param,System.Management.Automation.Job2
key,System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs>
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 33800, 33849);
return 0;
}


System.Management.Automation.JobStateInfo
f_1607_34053_34070(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 34053, 34070);
return return_v;
}


System.Management.Automation.JobState
f_1607_34053_34076(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 34053, 34076);
return return_v;
}


bool
f_1607_34032_34077(System.Management.Automation.Job2
this_param,System.Management.Automation.JobState
state)
{
var return_v = this_param.IsFinishedState( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 34032, 34077);
return return_v;
}


System.Guid
f_1607_34137_34152(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 34137, 34152);
return return_v;
}


bool
f_1607_34115_34153(System.Collections.Generic.HashSet<System.Guid>
this_param,System.Guid
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 34115, 34153);
return return_v;
}


System.Guid
f_1607_34236_34251(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 34236, 34251);
return return_v;
}


bool
f_1607_34219_34252(System.Collections.Generic.HashSet<System.Guid>
this_param,System.Guid
item)
{
var return_v = this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 34219, 34252);
return return_v;
}


int
f_1607_34339_34358(System.Management.Automation.Job2
this_param)
{
this_param.StopJobAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 34339, 34358);
return 0;
}


int
f_1607_34457_34470(System.Management.Automation.Job
this_param)
{
this_param.StopJob();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 34457, 34470);
return 0;
}


int
f_1607_34497_34528(Microsoft.PowerShell.Commands.RemoveJobCommand
this_param,System.Management.Automation.Job
job,bool
jobIsJob2)
{
this_param.RemoveJobAndDispose( job, jobIsJob2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 34497, 34528);
return 0;
}


int
f_1607_34634_34672(Microsoft.PowerShell.Commands.RemoveJobCommand
this_param,System.Management.Automation.Job
job,bool
jobIsJob2)
{
this_param.RemoveJobAndDispose( job, jobIsJob2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 34634, 34672);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1607_33215_33233_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 33215, 33233);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,31508,34718);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,31508,34718);
}
		}

protected override void EndProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,34834,35204);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,34898,34922);

bool 
haveToWait = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,34942,34953);
            lock (_syncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,34987,35021);

_needToCheckForWaitingJobs = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,35039,35106) || true) && (f_1607_35043_35061(_pendingJobs)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,35039,35106);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,35088,35106);

haveToWait = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,35039,35106);
}
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,35137,35193) || true) && (haveToWait)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,35137,35193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,35170,35193);

f_1607_35170_35192(                _waitForJobs);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,35137,35193);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,34834,35204);

int
f_1607_35043_35061(System.Collections.Generic.HashSet<System.Guid>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 35043, 35061);
return return_v;
}


bool
f_1607_35170_35192(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.WaitOne();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 35170, 35192);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,34834,35204);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,34834,35204);
}
		}

protected override void StopProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,35302,35397);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,35367,35386);

f_1607_35367_35385(            _waitForJobs);
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,35302,35397);

bool
f_1607_35367_35385(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 35367, 35385);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,35302,35397);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,35302,35397);
}
		}

private void RemoveJobAndDispose(Job job, bool jobIsJob2)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,35474,36389);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,35592,35619);

bool 
job2TypeFound = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,35639,35782) || true) && (jobIsJob2)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,35639,35782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,35694,35763);

job2TypeFound = f_1607_35710_35762(f_1607_35710_35720(), job as Job2, this, true, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,35639,35782);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,35802,35907) || true) && (!job2TypeFound)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,35802,35907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,35862,35888);

f_1607_35862_35887(f_1607_35862_35875(), job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,35802,35907);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,35927,35941);

f_1607_35927_35940(
                job);
            }
            catch (ArgumentException ex)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1607,35970,36378);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,36031,36177);

string 
message = f_1607_36048_36176(f_1607_36137_36175())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,36197,36256);

ArgumentException 
ex2 = f_1607_36221_36255(message, ex)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,36274,36363);

f_1607_36274_36362(this, f_1607_36285_36361(ex2, "CannotRemoveJob", ErrorCategory.InvalidOperation, job));
DynAbs.Tracing.TraceSender.TraceExitCatch(1607,35970,36378);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,35474,36389);

System.Management.Automation.JobManager
f_1607_35710_35720()
{
var return_v = JobManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 35710, 35720);
return return_v;
}


bool
f_1607_35710_35762(System.Management.Automation.JobManager
this_param,System.Management.Automation.Job
job,Microsoft.PowerShell.Commands.RemoveJobCommand
cmdlet,bool
writeErrorOnException,bool
throwExceptions)
{
var return_v = this_param.RemoveJob( (System.Management.Automation.Job2)job, (System.Management.Automation.Cmdlet)cmdlet, writeErrorOnException, throwExceptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 35710, 35762);
return return_v;
}


System.Management.Automation.JobRepository
f_1607_35862_35875()
{
var return_v = JobRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 35862, 35875);
return return_v;
}


int
f_1607_35862_35887(System.Management.Automation.JobRepository
this_param,System.Management.Automation.Job
item)
{
this_param.Remove( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 35862, 35887);
return 0;
}


int
f_1607_35927_35940(System.Management.Automation.Job
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 35927, 35940);
return 0;
}


string
f_1607_36137_36175()
{
var return_v =                                         RemotingErrorIdStrings.CannotRemoveJob;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 36137, 36175);
return return_v;
}


string
f_1607_36048_36176(string
resourceString,params object[]
args)
{
var return_v = PSRemotingErrorInvariants.FormatResourceString( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 36048, 36176);
return return_v;
}


System.ArgumentException
f_1607_36221_36255(string
message,System.ArgumentException
innerException)
{
var return_v = new System.ArgumentException( message, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 36221, 36255);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1607_36285_36361(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Job
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 36285, 36361);
return return_v;
}


int
f_1607_36274_36362(Microsoft.PowerShell.Commands.RemoveJobCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 36274, 36362);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,35474,36389);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,35474,36389);
}
		}

private void HandleStopJobCompleted(object sender, AsyncCompletedEventArgs eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,36401,37138);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,36511,36535);

Job 
job = sender as Job
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,36549,36580);

f_1607_36549_36579(this, job, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,36596,36621);

bool 
releaseWait = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,36641,36652);
            lock (_syncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,36686,36824) || true) && (f_1607_36690_36727(_pendingJobs, f_1607_36712_36726(job)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,36686,36824);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,36769,36805);

f_1607_36769_36804(                    _pendingJobs, f_1607_36789_36803(job));
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,36686,36824);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,36844,36943) || true) && (_needToCheckForWaitingJobs &&(DynAbs.Tracing.TraceSender.Expression_True(1607, 36848, 36901)&&f_1607_36878_36896(_pendingJobs)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,36844,36943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,36924,36943);

releaseWait = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,36844,36943);
}
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,37074,37127) || true) && (releaseWait)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,37074,37127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,37108,37127);

f_1607_37108_37126(                _waitForJobs);
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,37074,37127);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,36401,37138);

int
f_1607_36549_36579(Microsoft.PowerShell.Commands.RemoveJobCommand
this_param,System.Management.Automation.Job
job,bool
jobIsJob2)
{
this_param.RemoveJobAndDispose( job, jobIsJob2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 36549, 36579);
return 0;
}


System.Guid
f_1607_36712_36726(System.Management.Automation.Job
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 36712, 36726);
return return_v;
}


bool
f_1607_36690_36727(System.Collections.Generic.HashSet<System.Guid>
this_param,System.Guid
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 36690, 36727);
return return_v;
}


System.Guid
f_1607_36789_36803(System.Management.Automation.Job
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 36789, 36803);
return return_v;
}


bool
f_1607_36769_36804(System.Collections.Generic.HashSet<System.Guid>
this_param,System.Guid
item)
{
var return_v = this_param.Remove( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 36769, 36804);
return return_v;
}


int
f_1607_36878_36896(System.Collections.Generic.HashSet<System.Guid>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1607, 36878, 36896);
return return_v;
}


bool
f_1607_37108_37126(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 37108, 37126);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,36401,37138);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,36401,37138);
}
		}

private HashSet<Guid> _pendingJobs ;

private readonly ManualResetEvent _waitForJobs ;

private readonly Dictionary<Job2, EventHandler<AsyncCompletedEventArgs>> _cleanUpActions ;

private readonly object _syncObject ;

private bool _needToCheckForWaitingJobs;

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,37780,37891);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,37826,37840);

f_1607_37826_37839(this, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,37854,37880);

f_1607_37854_37879(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,37780,37891);

int
f_1607_37826_37839(Microsoft.PowerShell.Commands.RemoveJobCommand
this_param,bool
disposing)
{
this_param.Dispose( disposing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 37826, 37839);
return 0;
}


int
f_1607_37854_37879(Microsoft.PowerShell.Commands.RemoveJobCommand
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 37854, 37879);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,37780,37891);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,37780,37891);
}
		}

protected void Dispose(bool disposing)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1607,37996,38271);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,38059,38082) || true) && (!disposing)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,38059,38082);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,38075,38082);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,38059,38082);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,38096,38221);
foreach(var pair in f_1607_38117_38132_I(_cleanUpActions) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1607,38096,38221);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,38166,38206);

pair.Key.StopJobCompleted -= pair.Value;
DynAbs.Tracing.TraceSender.TraceExitCondition(1607,38096,38221);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1607,1,126);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1607,1,126);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,38237,38260);

f_1607_38237_38259(
            _waitForJobs);
DynAbs.Tracing.TraceSender.TraceExitMethod(1607,37996,38271);

System.Collections.Generic.Dictionary<System.Management.Automation.Job2, System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs>>
f_1607_38117_38132_I(System.Collections.Generic.Dictionary<System.Management.Automation.Job2, System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs>>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 38117, 38132);
return return_v;
}


int
f_1607_38237_38259(System.Threading.ManualResetEvent
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 38237, 38259);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1607,37996,38271);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,37996,38271);
}
		}

public RemoveJobCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1607,29367,38306);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,30503,30508);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,31302,31316);
this._force = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,37245,37279);
this._pendingJobs = f_1607_37260_37279();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,37324,37366);
this._waitForJobs = f_1607_37339_37366(false);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,37450,37542);
this._cleanUpActions = f_1607_37481_37542();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,37579,37605);
this._syncObject = f_1607_37593_37605();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1607,37629,37655);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1607,29367,38306);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,29367,38306);
}


static RemoveJobCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1607,29367,38306);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1607,29367,38306);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1607,29367,38306);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1607,29367,38306);

System.Collections.Generic.HashSet<System.Guid>
f_1607_37260_37279()
{
var return_v = new System.Collections.Generic.HashSet<System.Guid>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 37260, 37279);
return return_v;
}


System.Threading.ManualResetEvent
f_1607_37339_37366(bool
initialState)
{
var return_v = new System.Threading.ManualResetEvent( initialState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 37339, 37366);
return return_v;
}


System.Collections.Generic.Dictionary<System.Management.Automation.Job2, System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs>>
f_1607_37481_37542()
{
var return_v = new System.Collections.Generic.Dictionary<System.Management.Automation.Job2, System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs>>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 37481, 37542);
return return_v;
}


object
f_1607_37593_37605()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1607, 37593, 37605);
return return_v;
}

}
}
