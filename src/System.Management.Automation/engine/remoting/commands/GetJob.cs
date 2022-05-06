// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;

namespace Microsoft.PowerShell.Commands
{
[Cmdlet(VerbsCommon.Get, "Job", DefaultParameterSetName = JobCmdletBase.SessionIdParameterSet, HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096582")]
    [OutputType(typeof(Job))]
    public class GetJobCommand : JobCmdletBase
{
[Parameter(ParameterSetName = JobCmdletBase.SessionIdParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.InstanceIdParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.NameParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.StateParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.CommandParameterSet)]
        public SwitchParameter IncludeChildJob {get; set; }

[Parameter(ParameterSetName = JobCmdletBase.SessionIdParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.InstanceIdParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.NameParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.StateParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.CommandParameterSet)]
        public JobState ChildJobState {get; set; }

[Parameter(ParameterSetName = JobCmdletBase.SessionIdParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.InstanceIdParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.NameParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.StateParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.CommandParameterSet)]
        public bool HasMoreData {get; set; }

[Parameter(ParameterSetName = JobCmdletBase.SessionIdParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.InstanceIdParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.NameParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.StateParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.CommandParameterSet)]
        public DateTime Before {get; set; }

[Parameter(ParameterSetName = JobCmdletBase.SessionIdParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.InstanceIdParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.NameParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.StateParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.CommandParameterSet)]
        public DateTime After {get; set; }

[Parameter(ParameterSetName = JobCmdletBase.SessionIdParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.InstanceIdParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.NameParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.StateParameterSet)]
        [Parameter(ParameterSetName = JobCmdletBase.CommandParameterSet)]
        public int Newest {get; set; }

[Parameter(ValueFromPipelineByPropertyName = true, Position = 0,
                  ParameterSetName = JobCmdletBase.SessionIdParameterSet)]
        [ValidateNotNullOrEmpty]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public override int[] Id
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1593,4146,4212);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,4182,4197);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Id,1593,4189,4196);
DynAbs.Tracing.TraceSender.TraceExitMethod(1593,4146,4212);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1593,3819,4306);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1593,3819,4306);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1593,4228,4295);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,4264,4280);

base.Id = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1593,4228,4295);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1593,3819,4306);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1593,3819,4306);
}
		}}

protected override void ProcessRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1593,4529,4770);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,4593,4624);

List<Job> 
jobList = f_1593_4613_4623(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,4640,4718);

f_1593_4640_4717(
            jobList, (x, y) => x != null ? x.Id.CompareTo(y != null ? y.Id : 1) : -1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,4732,4759);

f_1593_4732_4758(this, jobList, true);
DynAbs.Tracing.TraceSender.TraceExitMethod(1593,4529,4770);

System.Collections.Generic.List<System.Management.Automation.Job>
f_1593_4613_4623(Microsoft.PowerShell.Commands.GetJobCommand
this_param)
{
var return_v = this_param.FindJobs();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 4613, 4623);
return return_v;
}


int
f_1593_4640_4717(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Comparison<System.Management.Automation.Job>
comparison)
{
this_param.Sort( comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 4640, 4717);
return 0;
}


int
f_1593_4732_4758(Microsoft.PowerShell.Commands.GetJobCommand
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
sendToPipeline,bool
enumerateCollection)
{
this_param.WriteObject( (object)sendToPipeline, enumerateCollection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 4732, 4758);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1593,4529,4770);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1593,4529,4770);
}
		}

protected List<Job> FindJobs()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1593,5009,7046);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,5064,5100);

List<Job> 
jobList = f_1593_5084_5099()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,5116,6866);

switch (f_1593_5124_5140())
            {

case NameParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,5116,6866);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,5245,5312);

f_1593_5245_5311(                        jobList, f_1593_5262_5310(this, true, false, true, false));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1593,5359,5365);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,5116,6866);

case InstanceIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,5116,6866);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,5462,5535);

f_1593_5462_5534(                        jobList, f_1593_5479_5533(this, true, false, true, false));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1593,5582,5588);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,5116,6866);

case SessionIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,5116,6866);
                    {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,5684,6154) || true) && (f_1593_5688_5690()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,5684,6154);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,5756,5828);

f_1593_5756_5827(                            jobList, f_1593_5773_5826(this, true, false, true, false));
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,5684,6154);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,5684,6154);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,5998,6035);

f_1593_5998_6034(                            // Get-Job with no filter.
                            jobList, f_1593_6015_6033(f_1593_6015_6028()));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,6065,6127);

f_1593_6065_6126(                            jobList, f_1593_6082_6125(f_1593_6082_6092(), this, true, false, null));
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,5684,6154);
}
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1593,6201,6207);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,5116,6866);

case CommandParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,5116,6866);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,6301,6352);

f_1593_6301_6351(                        jobList, f_1593_6318_6350(this, false));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1593,6399,6405);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,5116,6866);

case StateParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,5116,6866);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,6497,6546);

f_1593_6497_6545(                        jobList, f_1593_6514_6544(this, false));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1593,6593,6599);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,5116,6866);

case FilterParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,5116,6866);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,6692,6742);

f_1593_6692_6741(                        jobList, f_1593_6709_6740(this, false));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1593,6789,6795);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,5116,6866);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,5116,6866);
DynAbs.Tracing.TraceSender.TraceBreak(1593,6845,6851);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,5116,6866);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,6882,6923);

f_1593_6882_6922(
            jobList, f_1593_6899_6921(this, jobList));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,6939,6984);

jobList = f_1593_6949_6983(this, jobList);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,7000,7035);

return f_1593_7007_7034(this, jobList);
DynAbs.Tracing.TraceSender.TraceExitMethod(1593,5009,7046);

System.Collections.Generic.List<System.Management.Automation.Job>
f_1593_5084_5099()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 5084, 5099);
return return_v;
}


string
f_1593_5124_5140()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 5124, 5140);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1593_5262_5310(Microsoft.PowerShell.Commands.GetJobCommand
this_param,bool
recurse,bool
writeobject,bool
writeErrorOnNoMatch,bool
checkIfJobCanBeRemoved)
{
var return_v = this_param.FindJobsMatchingByName( recurse, writeobject, writeErrorOnNoMatch, checkIfJobCanBeRemoved);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 5262, 5310);
return return_v;
}


int
f_1593_5245_5311(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
collection)
{
this_param.AddRange( (System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 5245, 5311);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1593_5479_5533(Microsoft.PowerShell.Commands.GetJobCommand
this_param,bool
recurse,bool
writeobject,bool
writeErrorOnNoMatch,bool
checkIfJobCanBeRemoved)
{
var return_v = this_param.FindJobsMatchingByInstanceId( recurse, writeobject, writeErrorOnNoMatch, checkIfJobCanBeRemoved);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 5479, 5533);
return return_v;
}


int
f_1593_5462_5534(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
collection)
{
this_param.AddRange( (System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 5462, 5534);
return 0;
}


int[]
f_1593_5688_5690()
{
var return_v = Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 5688, 5690);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1593_5773_5826(Microsoft.PowerShell.Commands.GetJobCommand
this_param,bool
recurse,bool
writeobject,bool
writeErrorOnNoMatch,bool
checkIfJobCanBeRemoved)
{
var return_v = this_param.FindJobsMatchingBySessionId( recurse, writeobject, writeErrorOnNoMatch, checkIfJobCanBeRemoved);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 5773, 5826);
return return_v;
}


int
f_1593_5756_5827(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
collection)
{
this_param.AddRange( (System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 5756, 5827);
return 0;
}


System.Management.Automation.JobRepository
f_1593_6015_6028()
{
var return_v = JobRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 6015, 6028);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1593_6015_6033(System.Management.Automation.JobRepository
this_param)
{
var return_v = this_param.Jobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 6015, 6033);
return return_v;
}


int
f_1593_5998_6034(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
collection)
{
this_param.AddRange( (System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 5998, 6034);
return 0;
}


System.Management.Automation.JobManager
f_1593_6082_6092()
{
var return_v = JobManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 6082, 6092);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job2>
f_1593_6082_6125(System.Management.Automation.JobManager
this_param,Microsoft.PowerShell.Commands.GetJobCommand
cmdlet,bool
writeErrorOnException,bool
writeObject,string[]
jobSourceAdapterTypes)
{
var return_v = this_param.GetJobs( (System.Management.Automation.Cmdlet)cmdlet, writeErrorOnException, writeObject, jobSourceAdapterTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 6082, 6125);
return return_v;
}


int
f_1593_6065_6126(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Collections.Generic.List<System.Management.Automation.Job2>
collection)
{
this_param.AddRange( (System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 6065, 6126);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1593_6318_6350(Microsoft.PowerShell.Commands.GetJobCommand
this_param,bool
writeobject)
{
var return_v = this_param.FindJobsMatchingByCommand( writeobject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 6318, 6350);
return return_v;
}


int
f_1593_6301_6351(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
collection)
{
this_param.AddRange( (System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 6301, 6351);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1593_6514_6544(Microsoft.PowerShell.Commands.GetJobCommand
this_param,bool
writeobject)
{
var return_v = this_param.FindJobsMatchingByState( writeobject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 6514, 6544);
return return_v;
}


int
f_1593_6497_6545(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
collection)
{
this_param.AddRange( (System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 6497, 6545);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1593_6709_6740(Microsoft.PowerShell.Commands.GetJobCommand
this_param,bool
writeobject)
{
var return_v = this_param.FindJobsMatchingByFilter( writeobject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 6709, 6740);
return return_v;
}


int
f_1593_6692_6741(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
collection)
{
this_param.AddRange( (System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 6692, 6741);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1593_6899_6921(Microsoft.PowerShell.Commands.GetJobCommand
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
jobList)
{
var return_v = this_param.FindChildJobs( jobList);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 6899, 6921);
return return_v;
}


int
f_1593_6882_6922(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
collection)
{
this_param.AddRange( (System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 6882, 6922);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1593_6949_6983(Microsoft.PowerShell.Commands.GetJobCommand
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
jobList)
{
var return_v = this_param.ApplyHasMoreDataFiltering( jobList);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 6949, 6983);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1593_7007_7034(Microsoft.PowerShell.Commands.GetJobCommand
this_param,System.Collections.Generic.List<System.Management.Automation.Job>
jobList)
{
var return_v = this_param.ApplyTimeFiltering( jobList);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 7007, 7034);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1593,5009,7046);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1593,5009,7046);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private List<Job> ApplyHasMoreDataFiltering(List<Job> jobList)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1593,7344,7924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,7431,7521);

bool 
hasMoreDataParameter = f_1593_7459_7520(f_1593_7459_7487(f_1593_7459_7471()), nameof(HasMoreData))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,7537,7626) || true) && (!hasMoreDataParameter)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,7537,7626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,7596,7611);

return jobList;
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,7537,7626);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,7642,7678);

List<Job> 
matches = f_1593_7662_7677()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,7694,7882);
foreach(Job job in f_1593_7714_7721_I(jobList) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,7694,7882);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,7755,7867) || true) && (f_1593_7759_7774(job)== f_1593_7778_7789())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,7755,7867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,7831,7848);

f_1593_7831_7847(                    matches, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,7755,7867);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,7694,7882);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1593,1,189);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1593,1,189);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,7898,7913);

return matches;
DynAbs.Tracing.TraceSender.TraceExitMethod(1593,7344,7924);

System.Management.Automation.InvocationInfo
f_1593_7459_7471()
{
var return_v = MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 7459, 7471);
return return_v;
}


System.Collections.Generic.Dictionary<string, object>
f_1593_7459_7487(System.Management.Automation.InvocationInfo
this_param)
{
var return_v = this_param.BoundParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 7459, 7487);
return return_v;
}


bool
f_1593_7459_7520(System.Collections.Generic.Dictionary<string, object>
this_param,string
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 7459, 7520);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1593_7662_7677()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 7662, 7677);
return return_v;
}


bool
f_1593_7759_7774(System.Management.Automation.Job
this_param)
{
var return_v = this_param.HasMoreData ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 7759, 7774);
return return_v;
}


bool
f_1593_7778_7789()
{
var return_v = HasMoreData;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 7778, 7789);
return return_v;
}


int
f_1593_7831_7847(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 7831, 7847);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1593_7714_7721_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 7714, 7721);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1593,7344,7924);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1593,7344,7924);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private List<Job> FindChildJobs(List<Job> jobList)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1593,8243,9578);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,8318,8412);

bool 
childJobStateParameter = f_1593_8348_8411(f_1593_8348_8376(f_1593_8348_8360()), nameof(ChildJobState))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,8426,8524);

bool 
includeChildJobParameter = f_1593_8458_8523(f_1593_8458_8486(f_1593_8458_8470()), nameof(IncludeChildJob))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,8540,8576);

List<Job> 
matches = f_1593_8560_8575()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,8592,8712) || true) && (!childJobStateParameter &&(DynAbs.Tracing.TraceSender.Expression_True(1593, 8596, 8648)&&!includeChildJobParameter))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,8592,8712);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,8682,8697);

return matches;
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,8592,8712);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,8813,9536) || true) && (!childJobStateParameter &&(DynAbs.Tracing.TraceSender.Expression_True(1593, 8817, 8868)&&includeChildJobParameter))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,8813,9536);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,8902,9147);
foreach(Job job in f_1593_8922_8929_I(jobList) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,8902,9147);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,8971,9128) || true) && (f_1593_8975_8988(job)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1593, 8975, 9023)&&f_1593_9000_9019(f_1593_9000_9013(job))> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,8971,9128);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,9073,9105);

f_1593_9073_9104(                        matches, f_1593_9090_9103(job));
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,8971,9128);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,8902,9147);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1593,1,246);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1593,1,246);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1593,8813,9536);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,8813,9536);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,9213,9521);
foreach(Job job in f_1593_9233_9240_I(jobList) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,9213,9521);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,9282,9502);
foreach(Job childJob in f_1593_9307_9320_I(f_1593_9307_9320(job)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,9282,9502);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,9370,9429) || true) && (f_1593_9374_9401(f_1593_9374_9395(childJob))!= f_1593_9405_9418())
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,9370,9429);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,9420,9429);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,9370,9429);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,9457,9479);

f_1593_9457_9478(
                        matches, childJob);
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,9282,9502);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1593,1,221);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1593,1,221);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1593,9213,9521);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1593,1,309);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1593,1,309);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1593,8813,9536);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,9552,9567);

return matches;
DynAbs.Tracing.TraceSender.TraceExitMethod(1593,8243,9578);

System.Management.Automation.InvocationInfo
f_1593_8348_8360()
{
var return_v = MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 8348, 8360);
return return_v;
}


System.Collections.Generic.Dictionary<string, object>
f_1593_8348_8376(System.Management.Automation.InvocationInfo
this_param)
{
var return_v = this_param.BoundParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 8348, 8376);
return return_v;
}


bool
f_1593_8348_8411(System.Collections.Generic.Dictionary<string, object>
this_param,string
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 8348, 8411);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1593_8458_8470()
{
var return_v = MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 8458, 8470);
return return_v;
}


System.Collections.Generic.Dictionary<string, object>
f_1593_8458_8486(System.Management.Automation.InvocationInfo
this_param)
{
var return_v = this_param.BoundParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 8458, 8486);
return return_v;
}


bool
f_1593_8458_8523(System.Collections.Generic.Dictionary<string, object>
this_param,string
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 8458, 8523);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1593_8560_8575()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 8560, 8575);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1593_8975_8988(System.Management.Automation.Job
this_param)
{
var return_v = this_param.ChildJobs ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 8975, 8988);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1593_9000_9013(System.Management.Automation.Job
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 9000, 9013);
return return_v;
}


int
f_1593_9000_9019(System.Collections.Generic.IList<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 9000, 9019);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1593_9090_9103(System.Management.Automation.Job
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 9090, 9103);
return return_v;
}


int
f_1593_9073_9104(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Collections.Generic.IList<System.Management.Automation.Job>
collection)
{
this_param.AddRange( (System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 9073, 9104);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1593_8922_8929_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 8922, 8929);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1593_9307_9320(System.Management.Automation.Job
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 9307, 9320);
return return_v;
}


System.Management.Automation.JobStateInfo
f_1593_9374_9395(System.Management.Automation.Job
this_param)
{
var return_v = this_param.JobStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 9374, 9395);
return return_v;
}


System.Management.Automation.JobState
f_1593_9374_9401(System.Management.Automation.JobStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 9374, 9401);
return return_v;
}


System.Management.Automation.JobState
f_1593_9405_9418()
{
var return_v = ChildJobState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 9405, 9418);
return return_v;
}


int
f_1593_9457_9478(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 9457, 9478);
return 0;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1593_9307_9320_I(System.Collections.Generic.IList<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 9307, 9320);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1593_9233_9240_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 9233, 9240);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1593,8243,9578);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1593,8243,9578);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private List<Job> ApplyTimeFiltering(List<Job> jobList)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1593,9877,12756);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,9957,10037);

bool 
beforeParameter = f_1593_9980_10036(f_1593_9980_10008(f_1593_9980_9992()), nameof(Before))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,10051,10129);

bool 
afterParameter = f_1593_10073_10128(f_1593_10073_10101(f_1593_10073_10085()), nameof(After))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,10143,10223);

bool 
newestParameter = f_1593_10166_10222(f_1593_10166_10194(f_1593_10166_10178()), nameof(Newest))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,10239,10362) || true) && (!beforeParameter &&(DynAbs.Tracing.TraceSender.Expression_True(1593, 10243, 10278)&&!afterParameter )&&(DynAbs.Tracing.TraceSender.Expression_True(1593, 10243, 10298)&&!newestParameter))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,10239,10362);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,10332,10347);

return jobList;
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,10239,10362);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,10411,10434);

List<Job> 
filteredJobs
=default(List<Job>);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,10448,11555) || true) && (beforeParameter ||(DynAbs.Tracing.TraceSender.Expression_False(1593, 10452, 10485)||afterParameter))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,10448,11555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,10519,10550);

filteredJobs = f_1593_10534_10549();
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,10568,11451);
foreach(Job job in f_1593_10588_10595_I(jobList) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,10568,11451);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,10637,10805) || true) && (f_1593_10641_10654(job)== DateTime.MinValue)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,10637,10805);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,10773,10782);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,10637,10805);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,10829,11432) || true) && (beforeParameter &&(DynAbs.Tracing.TraceSender.Expression_True(1593, 10833, 10866)&&afterParameter))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,10829,11432);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,10916,11103) || true) && (f_1593_10920_10933(job)< f_1593_10936_10942()&&(DynAbs.Tracing.TraceSender.Expression_True(1593, 10920, 10996)&&f_1593_10975_10988(job)> f_1593_10991_10996()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,10916,11103);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,11054,11076);

f_1593_11054_11075(                            filteredJobs, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,10916,11103);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,10829,11432);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,10829,11432);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,11153,11432) || true) && ((beforeParameter &&(DynAbs.Tracing.TraceSender.Expression_True(1593, 11158, 11230)&&f_1593_11208_11221(job)< f_1593_11224_11230())) ||(DynAbs.Tracing.TraceSender.Expression_False(1593, 11157, 11337)||                             (afterParameter &&(DynAbs.Tracing.TraceSender.Expression_True(1593, 11266, 11336)&&f_1593_11315_11328(job)> f_1593_11331_11336()))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,11153,11432);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,11387,11409);

f_1593_11387_11408(                        filteredJobs, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,11153,11432);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,10829,11432);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,10568,11451);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1593,1,884);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1593,1,884);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1593,10448,11555);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,10448,11555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,11517,11540);

filteredJobs = jobList;
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,10448,11555);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,11571,11704) || true) && (!newestParameter ||(DynAbs.Tracing.TraceSender.Expression_False(1593, 11575, 11635)||f_1593_11612_11630(filteredJobs)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,11571,11704);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,11669,11689);

return filteredJobs;
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,11571,11704);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,11825,12316);

f_1593_11825_12315(
            //
            // Apply Newest count.
            //

            // Sort filtered jobs
            filteredJobs, (firstJob, secondJob) =>
                {
                    if (firstJob.PSEndTime > secondJob.PSEndTime)
                    {
                        return -1;
                    }
                    else if (firstJob.PSEndTime < secondJob.PSEndTime)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,12332,12371);

List<Job> 
newestJobs = f_1593_12355_12370()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,12385,12399);

int 
count = 0
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,12413,12711);
foreach(Job job in f_1593_12433_12445_I(filteredJobs) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,12413,12711);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,12479,12566) || true) && (++count > f_1593_12493_12499())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,12479,12566);
DynAbs.Tracing.TraceSender.TraceBreak(1593,12541,12547);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,12479,12566);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,12586,12696) || true) && (!f_1593_12591_12615(newestJobs, job))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1593,12586,12696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,12657,12677);

f_1593_12657_12676(                    newestJobs, job);
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,12586,12696);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1593,12413,12711);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1593,1,299);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1593,1,299);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,12727,12745);

return newestJobs;
DynAbs.Tracing.TraceSender.TraceExitMethod(1593,9877,12756);

System.Management.Automation.InvocationInfo
f_1593_9980_9992()
{
var return_v = MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 9980, 9992);
return return_v;
}


System.Collections.Generic.Dictionary<string, object>
f_1593_9980_10008(System.Management.Automation.InvocationInfo
this_param)
{
var return_v = this_param.BoundParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 9980, 10008);
return return_v;
}


bool
f_1593_9980_10036(System.Collections.Generic.Dictionary<string, object>
this_param,string
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 9980, 10036);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1593_10073_10085()
{
var return_v = MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 10073, 10085);
return return_v;
}


System.Collections.Generic.Dictionary<string, object>
f_1593_10073_10101(System.Management.Automation.InvocationInfo
this_param)
{
var return_v = this_param.BoundParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 10073, 10101);
return return_v;
}


bool
f_1593_10073_10128(System.Collections.Generic.Dictionary<string, object>
this_param,string
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 10073, 10128);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1593_10166_10178()
{
var return_v = MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 10166, 10178);
return return_v;
}


System.Collections.Generic.Dictionary<string, object>
f_1593_10166_10194(System.Management.Automation.InvocationInfo
this_param)
{
var return_v = this_param.BoundParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 10166, 10194);
return return_v;
}


bool
f_1593_10166_10222(System.Collections.Generic.Dictionary<string, object>
this_param,string
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 10166, 10222);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1593_10534_10549()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 10534, 10549);
return return_v;
}


System.DateTime?
f_1593_10641_10654(System.Management.Automation.Job
this_param)
{
var return_v = this_param.PSEndTime ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 10641, 10654);
return return_v;
}


System.DateTime?
f_1593_10920_10933(System.Management.Automation.Job
this_param)
{
var return_v = this_param.PSEndTime ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 10920, 10933);
return return_v;
}


System.DateTime
f_1593_10936_10942()
{
var return_v = Before;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 10936, 10942);
return return_v;
}


System.DateTime?
f_1593_10975_10988(System.Management.Automation.Job
this_param)
{
var return_v = this_param.PSEndTime ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 10975, 10988);
return return_v;
}


System.DateTime
f_1593_10991_10996()
{
var return_v = After;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 10991, 10996);
return return_v;
}


int
f_1593_11054_11075(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 11054, 11075);
return 0;
}


System.DateTime?
f_1593_11208_11221(System.Management.Automation.Job
this_param)
{
var return_v = this_param.PSEndTime ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 11208, 11221);
return return_v;
}


System.DateTime
f_1593_11224_11230()
{
var return_v = Before;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 11224, 11230);
return return_v;
}


System.DateTime?
f_1593_11315_11328(System.Management.Automation.Job
this_param)
{
var return_v = this_param.PSEndTime ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 11315, 11328);
return return_v;
}


System.DateTime
f_1593_11331_11336()
{
var return_v = After;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 11331, 11336);
return return_v;
}


int
f_1593_11387_11408(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 11387, 11408);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1593_10588_10595_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 10588, 10595);
return return_v;
}


int
f_1593_11612_11630(System.Collections.Generic.List<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 11612, 11630);
return return_v;
}


int
f_1593_11825_12315(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Comparison<System.Management.Automation.Job>
comparison)
{
this_param.Sort( comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 11825, 12315);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1593_12355_12370()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 12355, 12370);
return return_v;
}


int
f_1593_12493_12499()
{
var return_v = Newest;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1593, 12493, 12499);
return return_v;
}


bool
f_1593_12591_12615(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 12591, 12615);
return return_v;
}


int
f_1593_12657_12676(System.Collections.Generic.List<System.Management.Automation.Job>
this_param,System.Management.Automation.Job
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 12657, 12676);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Job>
f_1593_12433_12445_I(System.Collections.Generic.List<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1593, 12433, 12445);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1593,9877,12756);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1593,9877,12756);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public GetJobCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1593,366,12801);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,1259,1677);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,1772,2184);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1593,3283,3689);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1593,366,12801);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1593,366,12801);
}


static GetJobCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1593,366,12801);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1593,366,12801);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1593,366,12801);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1593,366,12801);
}
}
