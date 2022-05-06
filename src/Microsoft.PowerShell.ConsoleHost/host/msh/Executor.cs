// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;

using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell
{
internal class Executor
{        [Flags]
        internal enum ExecutionOptions
        {
            None = 0x0,
            AddOutputter = 0x01,
            AddToHistory = 0x02,
            ReadInputObjects = 0x04
        }

internal Executor(ConsoleHost parent, bool useNestedPipelines, bool isPromptFunctionExecutor)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(121,2401,2767);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,29833,29840);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,29868,29877);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,29901,29911);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,29936,29954);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,29980,30013);
this._instanceStateLock = f_121_30001_30013();DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,30037,30062);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,2519,2575);

f_121_2519_2574(parent != null, "parent should not be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,2591,2608);

_parent = parent;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,2622,2667);

this.useNestedPipelines = useNestedPipelines;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,2681,2734);

_isPromptFunctionExecutor = isPromptFunctionExecutor;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,2748,2756);

f_121_2748_2755(this);
DynAbs.Tracing.TraceSender.TraceExitConstructor(121,2401,2767);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,2401,2767);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,2401,2767);
}
		}

private void OutputObjectStreamHandler(object sender, EventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(121,2846,3889);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,3175,3242);

PipelineReader<PSObject> 
reader = (PipelineReader<PSObject>)sender
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,3687,3743);

Collection<PSObject> 
objects = f_121_3718_3742(reader)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,3757,3878);
foreach(PSObject obj in f_121_3782_3789_I(objects) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,3757,3878);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,3823,3863);

f_121_3823_3862(f_121_3823_3847(_parent), obj);
DynAbs.Tracing.TraceSender.TraceExitCondition(121,3757,3878);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(121,1,122);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(121,1,122);
}DynAbs.Tracing.TraceSender.TraceExitMethod(121,2846,3889);

System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_121_3718_3742(System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.NonBlockingRead();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 3718, 3742);
return return_v;
}


Microsoft.PowerShell.WrappedSerializer
f_121_3823_3847(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.OutputSerializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 3823, 3847);
return return_v;
}


int
f_121_3823_3862(Microsoft.PowerShell.WrappedSerializer
this_param,System.Management.Automation.PSObject
o)
{
this_param.Serialize( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 3823, 3862);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_121_3782_3789_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 3782, 3789);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,2846,3889);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,2846,3889);
}
		}

private void ErrorObjectStreamHandler(object sender, EventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(121,3945,4977);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,4272,4335);

PipelineReader<object> 
reader = (PipelineReader<object>)sender
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,4780,4834);

Collection<object> 
objects = f_121_4809_4833(reader)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,4848,4966);
foreach(object obj in f_121_4871_4878_I(objects) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,4848,4966);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,4912,4951);

f_121_4912_4950(f_121_4912_4935(_parent), obj);
DynAbs.Tracing.TraceSender.TraceExitCondition(121,4848,4966);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(121,1,119);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(121,1,119);
}DynAbs.Tracing.TraceSender.TraceExitMethod(121,3945,4977);

System.Collections.ObjectModel.Collection<object>
f_121_4809_4833(System.Management.Automation.Runspaces.PipelineReader<object>
this_param)
{
var return_v = this_param.NonBlockingRead();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 4809, 4833);
return return_v;
}


Microsoft.PowerShell.WrappedSerializer
f_121_4912_4935(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.ErrorSerializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 4912, 4935);
return return_v;
}


int
f_121_4912_4950(Microsoft.PowerShell.WrappedSerializer
this_param,object
o)
{
this_param.Serialize( o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 4912, 4950);
return 0;
}


System.Collections.ObjectModel.Collection<object>
f_121_4871_4878_I(System.Collections.ObjectModel.Collection<object>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 4871, 4878);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,3945,4977);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,3945,4977);
}
		}

private void AsyncPipelineFailureHandler(Exception ex)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(121,5158,5892);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,5237,5259);

ErrorRecord 
er = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,5273,5327);

IContainsErrorRecord 
cer = ex as IContainsErrorRecord
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,5341,5654) || true) && (cer != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,5341,5654);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,5390,5411);

er = f_121_5395_5410(cer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,5610,5639);

er = f_121_5615_5638(er, ex);
DynAbs.Tracing.TraceSender.TraceExitCondition(121,5341,5654);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,5670,5827) || true) && (er == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,5670,5827);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,5718,5812);

er = f_121_5723_5811(ex, "ConsoleHostAsyncPipelineFailure", ErrorCategory.NotSpecified, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(121,5670,5827);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,5843,5881);

f_121_5843_5880(f_121_5843_5866(_parent), er);
DynAbs.Tracing.TraceSender.TraceExitMethod(121,5158,5892);

System.Management.Automation.ErrorRecord
f_121_5395_5410(System.Management.Automation.IContainsErrorRecord
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 5395, 5410);
return return_v;
}


System.Management.Automation.ErrorRecord
f_121_5615_5638(System.Management.Automation.ErrorRecord
errorRecord,System.Exception
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 5615, 5638);
return return_v;
}


System.Management.Automation.ErrorRecord
f_121_5723_5811(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 5723, 5811);
return return_v;
}


Microsoft.PowerShell.WrappedSerializer
f_121_5843_5866(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.ErrorSerializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 5843, 5866);
return return_v;
}


int
f_121_5843_5880(Microsoft.PowerShell.WrappedSerializer
this_param,System.Management.Automation.ErrorRecord
o)
{
this_param.Serialize( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 5843, 5880);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,5158,5892);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,5158,5892);
}
		}
private class PipelineFinishedWaitHandle
{
internal PipelineFinishedWaitHandle(Pipeline p)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(121,5969,6152);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,6769,6828);
this._eventHandle = f_121_6784_6828(false);DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,6049,6137);

p.StateChanged += new EventHandler<PipelineStateEventArgs>(PipelineStateChangedHandler);
DynAbs.Tracing.TraceSender.TraceExitConstructor(121,5969,6152);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,5969,6152);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,5969,6152);
}
		}

internal void Wait()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(121,6168,6259);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,6221,6244);

f_121_6221_6243(                _eventHandle);
DynAbs.Tracing.TraceSender.TraceExitMethod(121,6168,6259);

bool
f_121_6221_6243(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.WaitOne();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 6221, 6243);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,6168,6259);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,6168,6259);
}
		}

private void PipelineStateChangedHandler(object sender, PipelineStateEventArgs e)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(121,6275,6711);

if (
(DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,6389,6696) || true) && (f_121_6415_6440(f_121_6415_6434(e))== PipelineState.Completed
||(DynAbs.Tracing.TraceSender.Expression_False(121, 6415, 6541)||f_121_6492_6517(f_121_6492_6511(e))== PipelineState.Failed
)||(DynAbs.Tracing.TraceSender.Expression_False(121, 6415, 6616)||f_121_6566_6591(f_121_6566_6585(e))== PipelineState.Stopped))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,6389,6696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,6658,6677);

f_121_6658_6676(                    _eventHandle);
DynAbs.Tracing.TraceSender.TraceExitCondition(121,6389,6696);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(121,6275,6711);

System.Management.Automation.Runspaces.PipelineStateInfo
f_121_6415_6434(System.Management.Automation.Runspaces.PipelineStateEventArgs
this_param)
{
var return_v = this_param.PipelineStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 6415, 6434);
return return_v;
}


System.Management.Automation.Runspaces.PipelineState
f_121_6415_6440(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 6415, 6440);
return return_v;
}


System.Management.Automation.Runspaces.PipelineStateInfo
f_121_6492_6511(System.Management.Automation.Runspaces.PipelineStateEventArgs
this_param)
{
var return_v = this_param.PipelineStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 6492, 6511);
return return_v;
}


System.Management.Automation.Runspaces.PipelineState
f_121_6492_6517(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 6492, 6517);
return return_v;
}


System.Management.Automation.Runspaces.PipelineStateInfo
f_121_6566_6585(System.Management.Automation.Runspaces.PipelineStateEventArgs
this_param)
{
var return_v = this_param.PipelineStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 6566, 6585);
return return_v;
}


System.Management.Automation.Runspaces.PipelineState
f_121_6566_6591(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 6566, 6591);
return return_v;
}


bool
f_121_6658_6676(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 6658, 6676);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,6275,6711);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,6275,6711);
}
		}

private System.Threading.ManualResetEvent _eventHandle ;

static PipelineFinishedWaitHandle()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(121,5904,6840);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(121,5904,6840);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,5904,6840);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(121,5904,6840);

System.Threading.ManualResetEvent
f_121_6784_6828(bool
initialState)
{
var return_v = new System.Threading.ManualResetEvent( initialState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 6784, 6828);
return return_v;
}

}

internal void ExecuteCommandAsync(string command, out Exception exceptionThrown, ExecutionOptions options)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(121,6852,7423);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,6983,7055);

f_121_6983_7054(!useNestedPipelines, "can't async invoke a nested pipeline");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,7069,7143);

f_121_7069_7142(!f_121_7081_7110(command), "command should have a value");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,7159,7225);

bool 
addToHistory = (options & ExecutionOptions.AddToHistory) > 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,7239,7328);

Pipeline 
tempPipeline = f_121_7263_7327(f_121_7263_7282(_parent), command, addToHistory, false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,7342,7412);

f_121_7342_7411(this, tempPipeline, out exceptionThrown, options);
DynAbs.Tracing.TraceSender.TraceExitMethod(121,6852,7423);

int
f_121_6983_7054(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 6983, 7054);
return 0;
}


bool
f_121_7081_7110(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 7081, 7110);
return return_v;
}


int
f_121_7069_7142(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 7069, 7142);
return 0;
}


System.Management.Automation.Remoting.RunspaceRef
f_121_7263_7282(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.RunspaceRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 7263, 7282);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_121_7263_7327(System.Management.Automation.Remoting.RunspaceRef
this_param,string
line,bool
addToHistory,bool
useNestedPipelines)
{
var return_v = this_param.CreatePipeline( line, addToHistory, useNestedPipelines);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 7263, 7327);
return return_v;
}


int
f_121_7342_7411(Microsoft.PowerShell.Executor
this_param,System.Management.Automation.Runspaces.Pipeline
tempPipeline,out System.Exception
exceptionThrown,Microsoft.PowerShell.Executor.ExecutionOptions
options)
{
this_param.ExecuteCommandAsyncHelper( tempPipeline, out exceptionThrown, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 7342, 7411);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,6852,7423);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,6852,7423);
}
		}

internal void ExecuteCommandAsyncHelper(Pipeline tempPipeline, out Exception exceptionThrown, ExecutionOptions options)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(121,7901,12341);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,8045,8122);

f_121_8045_8121(!_isPromptFunctionExecutor, "should not async invoke the prompt");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,8138,8161);

exceptionThrown = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,8175,8213);

Executor 
oldCurrent = f_121_8197_8212()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,8227,8250);

CurrentExecutor = this;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,8272,8290);

            lock (_instanceStateLock)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,8324,8388);

f_121_8324_8387(_pipeline == null, "no other pipeline should exist");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,8406,8431);

_pipeline = tempPipeline;
            }

            try
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,8498,9222) || true) && ((options & ExecutionOptions.AddOutputter) > 0 &&(DynAbs.Tracing.TraceSender.Expression_True(121, 8502, 8604)&&f_121_8551_8571(_parent)== Serialization.DataFormat.Text))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,8498,9222);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,8735,8939) || true) && (f_121_8739_8766(f_121_8739_8760(tempPipeline))== 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,8735,8939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,8821,8916);

f_121_8821_8915(f_121_8821_8845(f_121_8821_8842(tempPipeline), 0), PipelineResultTypes.Error, PipelineResultTypes.Output);
DynAbs.Tracing.TraceSender.TraceExitCondition(121,8735,8939);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,9048,9143);

Command 
outDefault = f_121_9069_9142("Out-Default", false, true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,9165,9203);

f_121_9165_9202(f_121_9165_9186(tempPipeline), outDefault);
DynAbs.Tracing.TraceSender.TraceExitCondition(121,8498,9222);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,9242,9319);

f_121_9242_9261(tempPipeline).DataReady += new EventHandler(OutputObjectStreamHandler);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,9337,9412);

f_121_9337_9355(tempPipeline).DataReady += new EventHandler(ErrorObjectStreamHandler);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,9430,9519);

PipelineFinishedWaitHandle 
pipelineWaiter = f_121_9474_9518(tempPipeline)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,9665,9816) || true) && ((options & Executor.ExecutionOptions.ReadInputObjects) == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,9665,9816);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,9770,9797);

f_121_9770_9796(f_121_9770_9788(tempPipeline));
DynAbs.Tracing.TraceSender.TraceExitCondition(121,9665,9816);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,9836,9863);

f_121_9836_9862(
                tempPipeline);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,9881,11123) || true) && ((options & ExecutionOptions.ReadInputObjects) > 0 &&(DynAbs.Tracing.TraceSender.Expression_True(121, 9885, 9963)&&f_121_9938_9963()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,9881,11123);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,10059,10164);

WrappedDeserializer 
des = f_121_10085_10163(f_121_10109_10128(_parent), "Input", f_121_10139_10162(f_121_10139_10156(_parent)))
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,10186,11071) || true) && (f_121_10193_10203_M(!des.AtEnd))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,10186,11071);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,10253,10282);

object 
o = f_121_10264_10281(des)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,10308,10412) || true) && (o == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,10308,10412);
DynAbs.Tracing.TraceSender.TraceBreak(121,10379,10385);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(121,10308,10412);
}

                        try
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,10500,10528);

f_121_10500_10527(f_121_10500_10518(tempPipeline), o);
                        }
                        catch (PipelineClosedException)
                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(121,10581,11048);
DynAbs.Tracing.TraceSender.TraceBreak(121,11015,11021);

break;
DynAbs.Tracing.TraceSender.TraceExitCatch(121,10581,11048);
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(121,10186,11071);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(121,10186,11071);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(121,10186,11071);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,11071,11072);
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,11094,11104);

f_121_11094_11103(                    des);
DynAbs.Tracing.TraceSender.TraceExitCondition(121,9881,11123);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,11143,11170);

f_121_11143_11169(f_121_11143_11161(tempPipeline));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,11190,11212);

f_121_11190_11211(
                pipelineWaiter);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,11284,11942) || true) && (f_121_11288_11324(f_121_11288_11318(tempPipeline))== PipelineState.Failed &&(DynAbs.Tracing.TraceSender.Expression_True(121, 11288, 11397)&&f_121_11352_11389(f_121_11352_11382(tempPipeline))!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,11284,11942);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,11439,11923) || true) && (f_121_11443_11463(_parent)== Serialization.DataFormat.Text)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,11439,11923);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,11624,11680);

exceptionThrown = f_121_11642_11679(f_121_11642_11672(tempPipeline));
DynAbs.Tracing.TraceSender.TraceExitCondition(121,11439,11923);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,11439,11923);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,11833,11900);

f_121_11833_11899(this, f_121_11861_11898(f_121_11861_11891(tempPipeline)));
DynAbs.Tracing.TraceSender.TraceExitCondition(121,11439,11923);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(121,11284,11942);
}
            }
            catch (Exception e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(121,11971,12058);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,12023,12043);

exceptionThrown = e;
DynAbs.Tracing.TraceSender.TraceExitCatch(121,11971,12058);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(121,12072,12330);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,12215,12242);

f_121_12215_12241(                // Once we have the results, or an exception is thrown, we throw away the pipeline.

                _parent.ui);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,12260,12289);

CurrentExecutor = oldCurrent;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,12307,12315);

f_121_12307_12314(this);
DynAbs.Tracing.TraceSender.TraceExitFinally(121,12072,12330);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(121,7901,12341);

int
f_121_8045_8121(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 8045, 8121);
return 0;
}


Microsoft.PowerShell.Executor
f_121_8197_8212()
{
var return_v = CurrentExecutor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 8197, 8212);
return return_v;
}


int
f_121_8324_8387(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 8324, 8387);
return 0;
}


Microsoft.PowerShell.Serialization.DataFormat
f_121_8551_8571(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.OutputFormat ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 8551, 8571);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_121_8739_8760(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 8739, 8760);
return return_v;
}


int
f_121_8739_8766(System.Management.Automation.Runspaces.CommandCollection
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 8739, 8766);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_121_8821_8842(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 8821, 8842);
return return_v;
}


System.Management.Automation.Runspaces.Command
f_121_8821_8845(System.Management.Automation.Runspaces.CommandCollection
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 8821, 8845);
return return_v;
}


int
f_121_8821_8915(System.Management.Automation.Runspaces.Command
this_param,System.Management.Automation.Runspaces.PipelineResultTypes
myResult,System.Management.Automation.Runspaces.PipelineResultTypes
toResult)
{
this_param.MergeMyResults( myResult, toResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 8821, 8915);
return 0;
}


System.Management.Automation.Runspaces.Command
f_121_9069_9142(string
command,bool
isScript,bool
useLocalScope)
{
var return_v = new System.Management.Automation.Runspaces.Command( command, isScript, useLocalScope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 9069, 9142);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_121_9165_9186(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 9165, 9186);
return return_v;
}


int
f_121_9165_9202(System.Management.Automation.Runspaces.CommandCollection
this_param,System.Management.Automation.Runspaces.Command
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 9165, 9202);
return 0;
}


System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
f_121_9242_9261(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Output;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 9242, 9261);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_121_9337_9355(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Error;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 9337, 9355);
return return_v;
}


Microsoft.PowerShell.Executor.PipelineFinishedWaitHandle
f_121_9474_9518(System.Management.Automation.Runspaces.Pipeline
p)
{
var return_v = new Microsoft.PowerShell.Executor.PipelineFinishedWaitHandle( p);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 9474, 9518);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_121_9770_9788(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Input;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 9770, 9788);
return return_v;
}


int
f_121_9770_9796(System.Management.Automation.Runspaces.PipelineWriter
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 9770, 9796);
return 0;
}


int
f_121_9836_9862(System.Management.Automation.Runspaces.Pipeline
this_param)
{
this_param.InvokeAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 9836, 9862);
return 0;
}


bool
f_121_9938_9963()
{
var return_v = Console.IsInputRedirected;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 9938, 9963);
return return_v;
}


Microsoft.PowerShell.Serialization.DataFormat
f_121_10109_10128(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.InputFormat;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 10109, 10128);
return return_v;
}


System.Lazy<System.IO.TextReader>
f_121_10139_10156(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.ConsoleIn;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 10139, 10156);
return return_v;
}


System.IO.TextReader
f_121_10139_10162(System.Lazy<System.IO.TextReader>
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 10139, 10162);
return return_v;
}


Microsoft.PowerShell.WrappedDeserializer
f_121_10085_10163(Microsoft.PowerShell.Serialization.DataFormat
dataFormat,string
streamName,System.IO.TextReader
input)
{
var return_v = new Microsoft.PowerShell.WrappedDeserializer( dataFormat, streamName, input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 10085, 10163);
return return_v;
}


bool
f_121_10193_10203_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 10193, 10203);
return return_v;
}


object
f_121_10264_10281(Microsoft.PowerShell.WrappedDeserializer
this_param)
{
var return_v = this_param.Deserialize();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 10264, 10281);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_121_10500_10518(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Input;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 10500, 10518);
return return_v;
}


int
f_121_10500_10527(System.Management.Automation.Runspaces.PipelineWriter
this_param,object
obj)
{
var return_v = this_param.Write( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 10500, 10527);
return return_v;
}


int
f_121_11094_11103(Microsoft.PowerShell.WrappedDeserializer
this_param)
{
this_param.End();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 11094, 11103);
return 0;
}


System.Management.Automation.Runspaces.PipelineWriter
f_121_11143_11161(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Input;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 11143, 11161);
return return_v;
}


int
f_121_11143_11169(System.Management.Automation.Runspaces.PipelineWriter
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 11143, 11169);
return 0;
}


int
f_121_11190_11211(Microsoft.PowerShell.Executor.PipelineFinishedWaitHandle
this_param)
{
this_param.Wait();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 11190, 11211);
return 0;
}


System.Management.Automation.Runspaces.PipelineStateInfo
f_121_11288_11318(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.PipelineStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 11288, 11318);
return return_v;
}


System.Management.Automation.Runspaces.PipelineState
f_121_11288_11324(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 11288, 11324);
return return_v;
}


System.Management.Automation.Runspaces.PipelineStateInfo
f_121_11352_11382(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.PipelineStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 11352, 11382);
return return_v;
}


System.Exception
f_121_11352_11389(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.Reason ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 11352, 11389);
return return_v;
}


Microsoft.PowerShell.Serialization.DataFormat
f_121_11443_11463(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.OutputFormat ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 11443, 11463);
return return_v;
}


System.Management.Automation.Runspaces.PipelineStateInfo
f_121_11642_11672(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.PipelineStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 11642, 11672);
return return_v;
}


System.Exception
f_121_11642_11679(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 11642, 11679);
return return_v;
}


System.Management.Automation.Runspaces.PipelineStateInfo
f_121_11861_11891(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.PipelineStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 11861, 11891);
return return_v;
}


System.Exception
f_121_11861_11898(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 11861, 11898);
return return_v;
}


int
f_121_11833_11899(Microsoft.PowerShell.Executor
this_param,System.Exception
ex)
{
this_param.AsyncPipelineFailureHandler( ex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 11833, 11899);
return 0;
}


int
f_121_12215_12241(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.ResetProgress();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 12215, 12241);
return 0;
}


int
f_121_12307_12314(Microsoft.PowerShell.Executor
this_param)
{
this_param.Reset();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 12307, 12314);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,7901,12341);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,7901,12341);
}
		}

internal Pipeline CreatePipeline()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(121,12381,12682);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,12440,12671) || true) && (useNestedPipelines)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,12440,12671);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,12496,12546);

return f_121_12503_12545(f_121_12503_12522(_parent));
DynAbs.Tracing.TraceSender.TraceExitCondition(121,12440,12671);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,12440,12671);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,12612,12656);

return f_121_12619_12655(f_121_12619_12638(_parent));
DynAbs.Tracing.TraceSender.TraceExitCondition(121,12440,12671);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(121,12381,12682);

System.Management.Automation.Remoting.RunspaceRef
f_121_12503_12522(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.RunspaceRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 12503, 12522);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_121_12503_12545(System.Management.Automation.Remoting.RunspaceRef
this_param)
{
var return_v = this_param.CreateNestedPipeline();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 12503, 12545);
return return_v;
}


System.Management.Automation.Remoting.RunspaceRef
f_121_12619_12638(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.RunspaceRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 12619, 12638);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_121_12619_12655(System.Management.Automation.Remoting.RunspaceRef
this_param)
{
var return_v = this_param.CreatePipeline();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 12619, 12655);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,12381,12682);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,12381,12682);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Pipeline CreatePipeline(string command, bool addToHistory)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(121,12694,12970);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,12786,12860);

f_121_12786_12859(!f_121_12798_12827(command), "command should have a value");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,12874,12959);

return f_121_12881_12958(f_121_12881_12900(_parent), command, addToHistory, useNestedPipelines);
DynAbs.Tracing.TraceSender.TraceExitMethod(121,12694,12970);

bool
f_121_12798_12827(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 12798, 12827);
return return_v;
}


int
f_121_12786_12859(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 12786, 12859);
return 0;
}


System.Management.Automation.Remoting.RunspaceRef
f_121_12881_12900(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.RunspaceRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 12881, 12900);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_121_12881_12958(System.Management.Automation.Remoting.RunspaceRef
this_param,string
line,bool
addToHistory,bool
useNestedPipelines)
{
var return_v = this_param.CreatePipeline( line, addToHistory, useNestedPipelines);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 12881, 12958);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,12694,12970);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,12694,12970);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<PSObject> ExecuteCommand(string command, out Exception exceptionThrown, ExecutionOptions options)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(121,14228,15489);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,14370,14444);

f_121_14370_14443(!f_121_14382_14411(command), "command should have a value");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,14596,15279) || true) && (f_121_14600_14659("PSImplicitRemotingBatching"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,14596,15279);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,14693,14760);

var 
addOutputter = ((options & ExecutionOptions.AddOutputter) > 0)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,14778,15264) || true) && (addOutputter &&(DynAbs.Tracing.TraceSender.Expression_True(121, 14782, 14860)&&f_121_14819_14860_M(!f_121_14820_14839(_parent).IsRunspaceOverridden))&&(DynAbs.Tracing.TraceSender.Expression_True(121, 14782, 14946)&&f_121_14885_14938(f_121_14885_14930(f_121_14885_14913(f_121_14885_14904(_parent))))!= null )&&(DynAbs.Tracing.TraceSender.Expression_True(121, 14782, 15055)&&f_121_14971_15055(f_121_14971_15024(f_121_14971_15016(f_121_14971_14999(f_121_14971_14990(_parent))))))&&(DynAbs.Tracing.TraceSender.Expression_True(121, 14782, 15146)&&f_121_15080_15146(command, f_121_15117_15145(f_121_15117_15136(_parent)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,14778,15264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,15188,15211);

exceptionThrown = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,15233,15245);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(121,14778,15264);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(121,14596,15279);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,15295,15390);

Pipeline 
tempPipeline = f_121_15319_15389(this, command, (options & ExecutionOptions.AddToHistory) > 0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,15406,15478);

return f_121_15413_15477(this, tempPipeline, out exceptionThrown, options);
DynAbs.Tracing.TraceSender.TraceExitMethod(121,14228,15489);

bool
f_121_14382_14411(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 14382, 14411);
return return_v;
}


int
f_121_14370_14443(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 14370, 14443);
return 0;
}


bool
f_121_14600_14659(string
featureName)
{
var return_v = ExperimentalFeature.IsEnabled( featureName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 14600, 14659);
return return_v;
}


System.Management.Automation.Remoting.RunspaceRef
f_121_14820_14839(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.RunspaceRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 14820, 14839);
return return_v;
}


bool
f_121_14819_14860_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 14819, 14860);
return return_v;
}


System.Management.Automation.Remoting.RunspaceRef
f_121_14885_14904(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.RunspaceRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 14885, 14904);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_121_14885_14913(System.Management.Automation.Remoting.RunspaceRef
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 14885, 14913);
return return_v;
}


System.Management.Automation.ExecutionContext
f_121_14885_14930(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 14885, 14930);
return return_v;
}


System.Management.Automation.ModuleIntrinsics
f_121_14885_14938(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.Modules ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 14885, 14938);
return return_v;
}


System.Management.Automation.Remoting.RunspaceRef
f_121_14971_14990(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.RunspaceRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 14971, 14990);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_121_14971_14999(System.Management.Automation.Remoting.RunspaceRef
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 14971, 14999);
return return_v;
}


System.Management.Automation.ExecutionContext
f_121_14971_15016(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 14971, 15016);
return return_v;
}


System.Management.Automation.ModuleIntrinsics
f_121_14971_15024(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.Modules;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 14971, 15024);
return return_v;
}


bool
f_121_14971_15055(System.Management.Automation.ModuleIntrinsics
this_param)
{
var return_v = this_param.IsImplicitRemotingModuleLoaded ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 14971, 15055);
return return_v;
}


System.Management.Automation.Remoting.RunspaceRef
f_121_15117_15136(Microsoft.PowerShell.ConsoleHost
this_param)
{
var return_v = this_param.RunspaceRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 15117, 15136);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_121_15117_15145(System.Management.Automation.Remoting.RunspaceRef
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 15117, 15145);
return return_v;
}


bool
f_121_15080_15146(string
command,System.Management.Automation.Runspaces.Runspace
runspace)
{
var return_v = Utils.TryRunAsImplicitBatch( command, runspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 15080, 15146);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_121_15319_15389(Microsoft.PowerShell.Executor
this_param,string
command,bool
addToHistory)
{
var return_v = this_param.CreatePipeline( command, addToHistory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 15319, 15389);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_121_15413_15477(Microsoft.PowerShell.Executor
this_param,System.Management.Automation.Runspaces.Pipeline
tempPipeline,out System.Exception
exceptionThrown,Microsoft.PowerShell.Executor.ExecutionOptions
options)
{
var return_v = this_param.ExecuteCommandHelper( tempPipeline, out exceptionThrown, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 15413, 15477);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,14228,15489);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,14228,15489);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Command GetOutDefaultCommand(bool endOfStatement)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(121,15501,15894);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,15583,15883);

return new Command(command: "Out-Default",
                               isScript: false,
                               useLocalScope: true,
                               mergeUnclaimedPreviousErrorResults: true)
            {
                IsEndOfStatement = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => endOfStatement,121,15590,15882)
            };
DynAbs.Tracing.TraceSender.TraceExitMethod(121,15501,15894);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,15501,15894);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,15501,15894);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<PSObject> ExecuteCommandHelper(Pipeline tempPipeline, out Exception exceptionThrown, ExecutionOptions options)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(121,15906,19180);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,16061,16125);

f_121_16061_16124(tempPipeline != null, "command should have a value");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,16141,16164);

exceptionThrown = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,16180,16216);

Collection<PSObject> 
results = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,16232,18319) || true) && ((options & ExecutionOptions.AddOutputter) > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,16232,18319);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,16315,18304) || true) && (f_121_16319_16346(f_121_16319_16340(tempPipeline))< 2)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,16315,18304);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,16392,16688) || true) && (f_121_16396_16423(f_121_16396_16417(tempPipeline))== 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,16392,16688);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,16570,16665);

f_121_16570_16664(f_121_16570_16594(f_121_16570_16591(tempPipeline), 0), PipelineResultTypes.Error, PipelineResultTypes.Output);
DynAbs.Tracing.TraceSender.TraceExitCondition(121,16392,16688);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,16779,16850);

f_121_16779_16849(f_121_16779_16800(tempPipeline), f_121_16805_16848(this, endOfStatement: false));
DynAbs.Tracing.TraceSender.TraceExitCondition(121,16315,18304);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,16315,18304);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,17046,17106);

CommandCollection 
executeCommands = f_121_17082_17105()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,17128,17606);
foreach(var cmd in f_121_17148_17169_I(f_121_17148_17169(tempPipeline)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,17128,17606);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,17219,17244);

f_121_17219_17243(                        executeCommands, cmd);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,17272,17583) || true) && (f_121_17276_17296(cmd))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,17272,17583);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,17433,17462);

cmd.IsEndOfStatement = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,17492,17556);

f_121_17492_17555(                            executeCommands, f_121_17512_17554(this, endOfStatement: true));
DynAbs.Tracing.TraceSender.TraceExitCondition(121,17272,17583);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(121,17128,17606);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(121,1,479);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(121,1,479);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,17630,17667);

var 
lastCmd = f_121_17644_17666(executeCommands)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,17689,18070) || true) && (!((f_121_17696_17715(lastCmd)!= null) &&(DynAbs.Tracing.TraceSender.Expression_True(121, 17695, 17834)&&                          (f_121_17756_17833(f_121_17756_17775(lastCmd), "Out-Default", StringComparison.OrdinalIgnoreCase)))))
                       )

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,17689,18070);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,17982,18047);

f_121_17982_18046(                        // Ensure pipeline output goes to Out-Default.
                        executeCommands, f_121_18002_18045(this, endOfStatement: false));
DynAbs.Tracing.TraceSender.TraceExitCondition(121,17689,18070);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,18094,18124);

f_121_18094_18123(f_121_18094_18115(tempPipeline));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,18146,18285);
foreach(var cmd in f_121_18166_18181_I(executeCommands) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,18146,18285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,18231,18262);

f_121_18231_18261(f_121_18231_18252(tempPipeline), cmd);
DynAbs.Tracing.TraceSender.TraceExitCondition(121,18146,18285);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(121,1,140);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(121,1,140);
}DynAbs.Tracing.TraceSender.TraceExitCondition(121,16315,18304);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(121,16232,18319);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,18335,18373);

Executor 
oldCurrent = f_121_18357_18372()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,18387,18410);

CurrentExecutor = this;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,18432,18450);

            lock (_instanceStateLock)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,18484,18548);

f_121_18484_18547(_pipeline == null, "no other pipeline should exist");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,18566,18591);

_pipeline = tempPipeline;
            }

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,18718,18750);

results = f_121_18728_18749(tempPipeline);
            }
            catch (Exception e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(121,18779,18866);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,18831,18851);

exceptionThrown = e;
DynAbs.Tracing.TraceSender.TraceExitCatch(121,18779,18866);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(121,18880,19138);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,19023,19050);

f_121_19023_19049(                // Once we have the results, or an exception is thrown, we throw away the pipeline.

                _parent.ui);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,19068,19097);

CurrentExecutor = oldCurrent;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,19115,19123);

f_121_19115_19122(this);
DynAbs.Tracing.TraceSender.TraceExitFinally(121,18880,19138);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,19154,19169);

return results;
DynAbs.Tracing.TraceSender.TraceExitMethod(121,15906,19180);

int
f_121_16061_16124(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 16061, 16124);
return 0;
}


System.Management.Automation.Runspaces.CommandCollection
f_121_16319_16340(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 16319, 16340);
return return_v;
}


int
f_121_16319_16346(System.Management.Automation.Runspaces.CommandCollection
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 16319, 16346);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_121_16396_16417(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 16396, 16417);
return return_v;
}


int
f_121_16396_16423(System.Management.Automation.Runspaces.CommandCollection
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 16396, 16423);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_121_16570_16591(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 16570, 16591);
return return_v;
}


System.Management.Automation.Runspaces.Command
f_121_16570_16594(System.Management.Automation.Runspaces.CommandCollection
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 16570, 16594);
return return_v;
}


int
f_121_16570_16664(System.Management.Automation.Runspaces.Command
this_param,System.Management.Automation.Runspaces.PipelineResultTypes
myResult,System.Management.Automation.Runspaces.PipelineResultTypes
toResult)
{
this_param.MergeMyResults( myResult, toResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 16570, 16664);
return 0;
}


System.Management.Automation.Runspaces.CommandCollection
f_121_16779_16800(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 16779, 16800);
return return_v;
}


System.Management.Automation.Runspaces.Command
f_121_16805_16848(Microsoft.PowerShell.Executor
this_param,bool
endOfStatement)
{
var return_v = this_param.GetOutDefaultCommand( endOfStatement:endOfStatement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 16805, 16848);
return return_v;
}


int
f_121_16779_16849(System.Management.Automation.Runspaces.CommandCollection
this_param,System.Management.Automation.Runspaces.Command
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 16779, 16849);
return 0;
}


System.Management.Automation.Runspaces.CommandCollection
f_121_17082_17105()
{
var return_v = new System.Management.Automation.Runspaces.CommandCollection();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 17082, 17105);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_121_17148_17169(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 17148, 17169);
return return_v;
}


int
f_121_17219_17243(System.Management.Automation.Runspaces.CommandCollection
this_param,System.Management.Automation.Runspaces.Command
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 17219, 17243);
return 0;
}


bool
f_121_17276_17296(System.Management.Automation.Runspaces.Command
this_param)
{
var return_v = this_param.IsEndOfStatement;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 17276, 17296);
return return_v;
}


System.Management.Automation.Runspaces.Command
f_121_17512_17554(Microsoft.PowerShell.Executor
this_param,bool
endOfStatement)
{
var return_v = this_param.GetOutDefaultCommand( endOfStatement:endOfStatement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 17512, 17554);
return return_v;
}


int
f_121_17492_17555(System.Management.Automation.Runspaces.CommandCollection
this_param,System.Management.Automation.Runspaces.Command
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 17492, 17555);
return 0;
}


System.Management.Automation.Runspaces.CommandCollection
f_121_17148_17169_I(System.Management.Automation.Runspaces.CommandCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 17148, 17169);
return return_v;
}


System.Management.Automation.Runspaces.Command
f_121_17644_17666(System.Management.Automation.Runspaces.CommandCollection
source)
{
var return_v = source.Last<System.Management.Automation.Runspaces.Command>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 17644, 17666);
return return_v;
}


string
f_121_17696_17715(System.Management.Automation.Runspaces.Command
this_param)
{
var return_v = this_param.CommandText ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 17696, 17715);
return return_v;
}


string
f_121_17756_17775(System.Management.Automation.Runspaces.Command
this_param)
{
var return_v = this_param.CommandText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 17756, 17775);
return return_v;
}


bool
f_121_17756_17833(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 17756, 17833);
return return_v;
}


System.Management.Automation.Runspaces.Command
f_121_18002_18045(Microsoft.PowerShell.Executor
this_param,bool
endOfStatement)
{
var return_v = this_param.GetOutDefaultCommand( endOfStatement:endOfStatement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 18002, 18045);
return return_v;
}


int
f_121_17982_18046(System.Management.Automation.Runspaces.CommandCollection
this_param,System.Management.Automation.Runspaces.Command
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 17982, 18046);
return 0;
}


System.Management.Automation.Runspaces.CommandCollection
f_121_18094_18115(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 18094, 18115);
return return_v;
}


int
f_121_18094_18123(System.Management.Automation.Runspaces.CommandCollection
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 18094, 18123);
return 0;
}


System.Management.Automation.Runspaces.CommandCollection
f_121_18231_18252(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 18231, 18252);
return return_v;
}


int
f_121_18231_18261(System.Management.Automation.Runspaces.CommandCollection
this_param,System.Management.Automation.Runspaces.Command
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 18231, 18261);
return 0;
}


System.Management.Automation.Runspaces.CommandCollection
f_121_18166_18181_I(System.Management.Automation.Runspaces.CommandCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 18166, 18181);
return return_v;
}


Microsoft.PowerShell.Executor
f_121_18357_18372()
{
var return_v = CurrentExecutor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 18357, 18372);
return return_v;
}


int
f_121_18484_18547(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 18484, 18547);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_121_18728_18749(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 18728, 18749);
return return_v;
}


int
f_121_19023_19049(Microsoft.PowerShell.ConsoleHostUserInterface
this_param)
{
this_param.ResetProgress();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 19023, 19049);
return 0;
}


int
f_121_19115_19122(Microsoft.PowerShell.Executor
this_param)
{
this_param.Reset();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 19115, 19122);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,15906,19180);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,15906,19180);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Needed by ProfileTests as mentioned in bug 140572")]
        internal Collection<PSObject> ExecuteCommand(string command)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(121,19192,19889);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,19433,19468);

Collection<PSObject> 
result = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,19482,19501);

Exception 
e = null
;
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,19517,19848);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,19552,19615);

result = f_121_19561_19614(this, command, out e, ExecutionOptions.None);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,19633,19713) || true) && (e != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,19633,19713);
DynAbs.Tracing.TraceSender.TraceBreak(121,19688,19694);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(121,19633,19713);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,19733,19818) || true) && (result == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,19733,19818);
DynAbs.Tracing.TraceSender.TraceBreak(121,19793,19799);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(121,19733,19818);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(121,19517,19848);
}
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,19517,19848) || true) && (false)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(121,19517,19848);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(121,19517,19848);
}}DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,19864,19878);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(121,19192,19889);

System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_121_19561_19614(Microsoft.PowerShell.Executor
this_param,string
command,out System.Exception
exceptionThrown,Microsoft.PowerShell.Executor.ExecutionOptions
options)
{
var return_v = this_param.ExecuteCommand( command, out exceptionThrown, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 19561, 19614);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,19192,19889);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,19192,19889);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal string ExecuteCommandAndGetResultAsString(string command, out Exception exceptionThrown)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(121,20785,22074);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,20907,20930);

exceptionThrown = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,20946,20967);

string 
result = null
;
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,20983,22033);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,21018,21123);

Collection<PSObject> 
streamResults = f_121_21055_21122(this, command, out exceptionThrown, ExecutionOptions.None)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,21143,21237) || true) && (exceptionThrown != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,21143,21237);
DynAbs.Tracing.TraceSender.TraceBreak(121,21212,21218);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(121,21143,21237);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,21257,21377) || true) && (streamResults == null ||(DynAbs.Tracing.TraceSender.Expression_False(121, 21261, 21310)||f_121_21286_21305(streamResults)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,21257,21377);
DynAbs.Tracing.TraceSender.TraceBreak(121,21352,21358);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(121,21257,21377);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,21477,21548) || true) && (f_121_21481_21497(streamResults, 0)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,21477,21548);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,21528,21548);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(121,21477,21548);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,21771,21816);

PSObject 
msho = f_121_21787_21803(streamResults, 0)as PSObject
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,21834,21990) || true) && (msho != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,21834,21990);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,21873,21909);

result = f_121_21882_21908(f_121_21882_21897(msho));
DynAbs.Tracing.TraceSender.TraceExitCondition(121,21834,21990);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,21834,21990);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,21953,21990);

result = f_121_21962_21989(f_121_21962_21978(streamResults, 0));
DynAbs.Tracing.TraceSender.TraceExitCondition(121,21834,21990);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(121,20983,22033);
}
            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,20983,22033) || true) && (false)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(121,20983,22033);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(121,20983,22033);
}}DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,22049,22063);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(121,20785,22074);

System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_121_21055_21122(Microsoft.PowerShell.Executor
this_param,string
command,out System.Exception
exceptionThrown,Microsoft.PowerShell.Executor.ExecutionOptions
options)
{
var return_v = this_param.ExecuteCommand( command, out exceptionThrown, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 21055, 21122);
return return_v;
}


int
f_121_21286_21305(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 21286, 21305);
return return_v;
}


System.Management.Automation.PSObject
f_121_21481_21497(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 21481, 21497);
return return_v;
}


System.Management.Automation.PSObject
f_121_21787_21803(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 21787, 21803);
return return_v;
}


object
f_121_21882_21897(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.BaseObject;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 21882, 21897);
return return_v;
}


string?
f_121_21882_21908(object
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 21882, 21908);
return return_v;
}


System.Management.Automation.PSObject
f_121_21962_21978(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 21962, 21978);
return return_v;
}


string
f_121_21962_21989(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 21962, 21989);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,20785,22074);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,20785,22074);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool? ExecuteCommandAndGetResultAsBool(string command)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(121,22683,22921);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,22771,22795);

Exception 
unused = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,22811,22880);

bool? 
result = f_121_22826_22879(this, command, out unused)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,22896,22910);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(121,22683,22921);

bool?
f_121_22826_22879(Microsoft.PowerShell.Executor
this_param,string
command,out System.Exception
exceptionThrown)
{
var return_v = this_param.ExecuteCommandAndGetResultAsBool( command, out exceptionThrown);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 22826, 22879);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,22683,22921);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,22683,22921);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool? ExecuteCommandAndGetResultAsBool(string command, out Exception exceptionThrown)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(121,23822,24743);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,23941,23964);

exceptionThrown = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,23980,24054);

f_121_23980_24053(!f_121_23992_24021(command), "command should have a value");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,24070,24090);

bool? 
result = null
;
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,24106,24702);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,24141,24246);

Collection<PSObject> 
streamResults = f_121_24178_24245(this, command, out exceptionThrown, ExecutionOptions.None)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,24266,24360) || true) && (exceptionThrown != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,24266,24360);
DynAbs.Tracing.TraceSender.TraceBreak(121,24335,24341);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(121,24266,24360);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,24380,24500) || true) && (streamResults == null ||(DynAbs.Tracing.TraceSender.Expression_False(121, 24384, 24433)||f_121_24409_24428(streamResults)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,24380,24500);
DynAbs.Tracing.TraceSender.TraceBreak(121,24475,24481);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(121,24380,24500);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,24575,24659);

result = (f_121_24585_24604(streamResults)> 1) ||(DynAbs.Tracing.TraceSender.Expression_False(121, 24584, 24658)||(f_121_24614_24657(f_121_24640_24656(streamResults, 0))));
DynAbs.Tracing.TraceSender.TraceExitCondition(121,24106,24702);
}
            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,24106,24702) || true) && (false)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(121,24106,24702);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(121,24106,24702);
}}DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,24718,24732);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(121,23822,24743);

bool
f_121_23992_24021(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 23992, 24021);
return return_v;
}


int
f_121_23980_24053(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 23980, 24053);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_121_24178_24245(Microsoft.PowerShell.Executor
this_param,string
command,out System.Exception
exceptionThrown,Microsoft.PowerShell.Executor.ExecutionOptions
options)
{
var return_v = this_param.ExecuteCommand( command, out exceptionThrown, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 24178, 24245);
return return_v;
}


int
f_121_24409_24428(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 24409, 24428);
return return_v;
}


int
f_121_24585_24604(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 24585, 24604);
return return_v;
}


System.Management.Automation.PSObject
f_121_24640_24656(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(121, 24640, 24656);
return return_v;
}


bool
f_121_24614_24657(System.Management.Automation.PSObject
obj)
{
var return_v = LanguagePrimitives.IsTrue( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 24614, 24657);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,23822,24743);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,23822,24743);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void Cancel()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(121,25009,25514);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,25119,25137);
            // if there's a pipeline running, stop it.

            lock (_instanceStateLock)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,25171,25488) || true) && (_pipeline != null &&(DynAbs.Tracing.TraceSender.Expression_True(121, 25175, 25207)&&!_cancelled))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,25171,25488);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,25249,25267);

_cancelled = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,25291,25428) || true) && (_isPromptFunctionExecutor)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,25291,25428);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,25370,25405);

f_121_25370_25404(100);
DynAbs.Tracing.TraceSender.TraceExitCondition(121,25291,25428);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,25452,25469);

f_121_25452_25468(
                    _pipeline);
DynAbs.Tracing.TraceSender.TraceExitCondition(121,25171,25488);
}
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(121,25009,25514);

int
f_121_25370_25404(int
millisecondsTimeout)
{
System.Threading.Thread.Sleep( millisecondsTimeout);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 25370, 25404);
return 0;
}


int
f_121_25452_25468(System.Management.Automation.Runspaces.Pipeline
this_param)
{
this_param.Stop();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 25452, 25468);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,25009,25514);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,25009,25514);
}
		}

internal void BlockCommandOutput()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(121,25526,25934);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,25585,25645);

RemotePipeline 
remotePipeline = _pipeline as RemotePipeline
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,25659,25923) || true) && (remotePipeline != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,25659,25923);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,25775,25810);

f_121_25775_25809(                // Waits until queued data is handled.
                remotePipeline);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,25871,25908);

f_121_25871_25907(
                // Blocks any new data.
                remotePipeline);
DynAbs.Tracing.TraceSender.TraceExitCondition(121,25659,25923);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(121,25526,25934);

int
f_121_25775_25809(System.Management.Automation.RemotePipeline
this_param)
{
this_param.DrainIncomingData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 25775, 25809);
return 0;
}


int
f_121_25871_25907(System.Management.Automation.RemotePipeline
this_param)
{
this_param.SuspendIncomingData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 25871, 25907);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,25526,25934);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,25526,25934);
}
		}

internal void ResumeCommandOutput()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(121,25946,26241);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,26006,26066);

RemotePipeline 
remotePipeline = _pipeline as RemotePipeline
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,26080,26230) || true) && (remotePipeline != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,26080,26230);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,26179,26215);

f_121_26179_26214(                // Resumes data flow.
                remotePipeline);
DynAbs.Tracing.TraceSender.TraceExitCondition(121,26080,26230);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(121,25946,26241);

int
f_121_26179_26214(System.Management.Automation.RemotePipeline
this_param)
{
this_param.ResumeIncomingData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 26179, 26214);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,25946,26241);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,25946,26241);
}
		}

private void Reset()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(121,26385,26568);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,26436,26454);
            lock (_instanceStateLock)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,26488,26505);

_pipeline = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,26523,26542);

_cancelled = false;
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(121,26385,26568);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,26385,26568);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,26385,26568);
}
		}

internal static Executor CurrentExecutor
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(121,28408,28647);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,28444,28467);

Executor 
result = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,28493,28510);

                lock (s_staticStateLock)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,28552,28579);

result = s_currentExecutor;
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,28618,28632);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(121,28408,28647);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,28343,28881);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,28343,28881);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(121,28663,28870);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,28705,28722);
                lock (s_staticStateLock)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,28810,28836);

s_currentExecutor = value;
                }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(121,28663,28870);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,28343,28881);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,28343,28881);
}
		}}

internal static void CancelCurrentExecutor()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(121,29118,29427);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,29187,29208);

Executor 
temp = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,29230,29247);

            lock (s_staticStateLock)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,29281,29306);

temp = s_currentExecutor;
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,29337,29416) || true) && (temp != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(121,29337,29416);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,29387,29401);

f_121_29387_29400(                temp);
DynAbs.Tracing.TraceSender.TraceExitCondition(121,29337,29416);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(121,29118,29427);

int
f_121_29387_29400(Microsoft.PowerShell.Executor
this_param)
{
this_param.Cancel();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 29387, 29400);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121,29118,29427);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,29118,29427);
}
		}

private static Executor s_currentExecutor;

private static object s_staticStateLock ;

private ConsoleHost _parent;

private Pipeline _pipeline;

private bool _cancelled;

internal bool useNestedPipelines;

private object _instanceStateLock ;

private bool _isPromptFunctionExecutor;

static Executor()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(121,1331,30070);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,29718,29735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(121,29768,29800);
s_staticStateLock = f_121_29788_29800();DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(121,1331,30070);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121,1331,30070);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(121,1331,30070);

int
f_121_2519_2574(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 2519, 2574);
return 0;
}


int
f_121_2748_2755(Microsoft.PowerShell.Executor
this_param)
{
this_param.Reset();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 2748, 2755);
return 0;
}


static object
f_121_29788_29800()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 29788, 29800);
return return_v;
}


object
f_121_30001_30013()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 30001, 30013);
return return_v;
}

}
}   // namespace

