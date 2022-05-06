// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Runspaces.Internal;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

#pragma warning disable 1634, 1691 // Stops compiler from warning about unknown warnings

namespace System.Management.Automation
{
internal class RemotePipeline : Pipeline
{
private PowerShell _powershell;

private bool _addToHistory;

private bool _isNested;

private bool _isSteppable;

private Runspace _runspace;

private object _syncRoot ;

private bool _disposed ;

private string _historyString;

private PipelineStateInfo _pipelineStateInfo ;

private CommandCollection _commands ;

private string _computerName;

private Guid _runspaceId;

private ConnectCommandInfo _connectCmdInfo ;

private Queue<ExecutionEventQueueItem> _executionEventQueue ;
private class ExecutionEventQueueItem
{
public ExecutionEventQueueItem(PipelineStateInfo pipelineStateInfo, RunspaceAvailability currentAvailability, RunspaceAvailability newAvailability)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1578,1927,2303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,2344,2361);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,2404,2431);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,2474,2497);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,2107,2150);

this.PipelineStateInfo = pipelineStateInfo;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,2168,2223);

this.CurrentRunspaceAvailability = currentAvailability;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,2241,2288);

this.NewRunspaceAvailability = newAvailability;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1578,1927,2303);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,1927,2303);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,1927,2303);
}
		}

public PipelineStateInfo PipelineStateInfo;

public RunspaceAvailability CurrentRunspaceAvailability;

public RunspaceAvailability NewRunspaceAvailability;

static ExecutionEventQueueItem()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1578,1865,2509);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1578,1865,2509);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,1865,2509);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1578,1865,2509);
}

private bool _performNestedCheck ;

private RemotePipeline(RemoteRunspace runspace, bool addToHistory, bool isNested)
:base(f_1578_3074_3082_C(runspace) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1578,2972,4753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,703,714);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,738,751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,775,784);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,808,820);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,848,857);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,883,907);
this._syncRoot = f_1578_895_907();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,931,948);
this._disposed = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,974,988);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,1025,1093);
this._pipelineStateInfo = f_1578_1046_1093(PipelineState.NotStarted);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,1130,1165);
this._commands = f_1578_1142_1165();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,1191,1204);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,1277,1299);
this._connectCmdInfo = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,1793,1852);
this._executionEventQueue = f_1578_1816_1852();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,2534,2560);
this._performNestedCheck = true;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,13404,13421);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,13473,13486);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,13535,13551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,13606,13618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,13662,13678);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,13728,13740);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,38137,38193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,38300,38357);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,38453,38504);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,3108,3137);

_addToHistory = addToHistory;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,3151,3172);

_isNested = isNested;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,3186,3207);

_isSteppable = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,3221,3242);

_runspace = runspace;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,3256,3328);

_computerName = f_1578_3272_3327(f_1578_3272_3314(((RemoteRunspace)_runspace)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,3342,3377);

_runspaceId = f_1578_3356_3376(_runspace);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,3428,3478);

_inputCollection = f_1578_3447_3477();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,3492,3537);

_inputCollection.ReleaseOnEnumeration = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,3553,3633);

_inputStream = f_1578_3568_3632(Guid.Empty, _inputCollection);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,3647,3700);

_outputCollection = f_1578_3667_3699();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,3714,3798);

_outputStream = f_1578_3730_3797(Guid.Empty, _outputCollection);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,3812,3867);

_errorCollection = f_1578_3831_3866();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,3881,3966);

_errorStream = f_1578_3896_3965(Guid.Empty, _errorCollection);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,4048,4090);

MethodExecutorStream = f_1578_4071_4089();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,4104,4142);

IsMethodExecutorStreamEnabled = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,4158,4190);

f_1578_4158_4189(this, _commands);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,4690,4742);

PipelineFinishedEvent = f_1578_4714_4741(false);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1578,2972,4753);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,2972,4753);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,2972,4753);
}
		}

internal RemotePipeline(RemoteRunspace runspace, string command, bool addToHistory, bool isNested)
:this(f_1578_5397_5405_C(runspace) ,addToHistory,isNested)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1578,5278,5985);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,5455,5565) || true) && (command != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,5455,5565);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,5508,5550);

f_1578_5508_5549(                _commands, f_1578_5522_5548(command, true));
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,5455,5565);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,5641,5772);

_powershell = f_1578_5655_5771(_inputStream, _outputStream, _errorStream, f_1578_5730_5770(((RemoteRunspace)_runspace)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,5788,5822);

f_1578_5788_5821(
            _powershell, isNested);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,5838,5974);

_powershell.InvocationStateChanged +=
               new EventHandler<PSInvocationStateChangedEventArgs>(HandleInvocationStateChanged);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1578,5278,5985);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,5278,5985);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,5278,5985);
}
		}

internal RemotePipeline(RemoteRunspace runspace)
:this(f_1578_6338_6346_C(runspace) ,false,false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1578,6269,7159);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,6386,6543) || true) && (f_1578_6390_6412(runspace)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,6386,6543);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,6454,6528);

throw f_1578_6460_6527(f_1578_6490_6526());
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,6386,6543);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,6559,6600);

_connectCmdInfo = f_1578_6577_6599(runspace);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,6614,6653);

f_1578_6614_6652(            _commands, f_1578_6628_6651(_connectCmdInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,6723,6774);

f_1578_6723_6773(this, PipelineState.Disconnected, null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,6847,6995);

_powershell = f_1578_6861_6994(_connectCmdInfo, _inputStream, _outputStream, _errorStream, f_1578_6953_6993(((RemoteRunspace)_runspace)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,7011,7148);

_powershell.InvocationStateChanged +=
                new EventHandler<PSInvocationStateChangedEventArgs>(HandleInvocationStateChanged);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1578,6269,7159);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,6269,7159);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,6269,7159);
}
		}

private RemotePipeline(RemotePipeline pipeline) :this(f_1578_7544_7577_C((RemoteRunspace)f_1578_7560_7577(pipeline)) ,null,false,f_1578_7592_7609(pipeline))
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1578,7476,8521);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,7635,7672);

_isSteppable = pipeline._isSteppable;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,7884,8010) || true) && (pipeline == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,7884,8010);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,7938,7995);

throw f_1578_7944_7994("pipeline");
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,7884,8010);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,8026,8156) || true) && (pipeline._disposed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,8026,8156);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,8082,8141);

throw f_1578_8088_8140("pipeline");
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,8026,8156);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,8172,8211);

_addToHistory = pipeline._addToHistory;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,8225,8266);

_historyString = pipeline._historyString;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,8280,8510);
foreach(Command command in f_1578_8308_8325_I(f_1578_8308_8325(pipeline)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,8280,8510);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,8359,8391);

Command 
clone = f_1578_8375_8390(command)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,8475,8495);

f_1578_8475_8494(f_1578_8475_8483(), clone);
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,8280,8510);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1578,1,231);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1578,1,231);
}DynAbs.Tracing.TraceSender.TraceExitConstructor(1578,7476,8521);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,7476,8521);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,7476,8521);
}
		}

public override Pipeline Copy()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,8742,8988);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,8798,8919) || true) && (_disposed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,8798,8919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,8845,8904);

throw f_1578_8851_8903("pipeline");
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,8798,8919);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,8935,8977);

return (Pipeline)f_1578_8952_8976(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,8742,8988);

System.Management.Automation.PSObjectDisposedException
f_1578_8851_8903(string
objectName)
{
var return_v = PSTraceSource.NewObjectDisposedException( objectName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 8851, 8903);
return return_v;
}


System.Management.Automation.RemotePipeline
f_1578_8952_8976(System.Management.Automation.RemotePipeline
pipeline)
{
var return_v = new System.Management.Automation.RemotePipeline( pipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 8952, 8976);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,8742,8988);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,8742,8988);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override Runspace Runspace
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,9232,9589);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,9373,9506) || true) && (_disposed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,9373,9506);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,9428,9487);

throw f_1578_9434_9486("pipeline");
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,9373,9506);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,9557,9574);

return _runspace;
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,9232,9589);

System.Management.Automation.PSObjectDisposedException
f_1578_9434_9486(string
objectName)
{
var return_v = PSTraceSource.NewObjectDisposedException( objectName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 9434, 9486);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,9174,9600);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,9174,9600);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal Runspace GetRunspace()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,9758,9842);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,9814,9831);

return _runspace;
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,9758,9842);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,9758,9842);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,9758,9842);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override bool IsNested
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,9993,10061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,10029,10046);

return _isNested;
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,9993,10061);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,9939,10072);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,9939,10072);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal void SetIsNested(bool isNested)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,10233,10378);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,10298,10319);

_isNested = isNested;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,10333,10367);

f_1578_10333_10366(            _powershell, isNested);
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,10233,10378);

int
f_1578_10333_10366(System.Management.Automation.PowerShell
this_param,bool
isNested)
{
this_param.SetIsNested( isNested);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 10333, 10366);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,10233,10378);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,10233,10378);
}
		}

internal void SetIsSteppable(bool isSteppable)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,10553,10662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,10624,10651);

_isSteppable = isSteppable;
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,10553,10662);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,10553,10662);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,10553,10662);
}
		}

public override PipelineStateInfo PipelineStateInfo
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,10977,11200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,11019,11028);
                lock (_syncRoot)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,11132,11166);

return f_1578_11139_11165(_pipelineStateInfo);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,10977,11200);

System.Management.Automation.Runspaces.PipelineStateInfo
f_1578_11139_11165(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.Clone();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 11139, 11165);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,10901,11211);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,10901,11211);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override PipelineWriter Input
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,11387,11471);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,11423,11456);

return f_1578_11430_11455(_inputStream);
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,11387,11471);

System.Management.Automation.Runspaces.PipelineWriter
f_1578_11430_11455(System.Management.Automation.Internal.PSDataCollectionStream<object>
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 11430, 11455);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,11326,11482);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,11326,11482);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override PipelineReader<PSObject> Output
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,11670,11799);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,11706,11784);

return f_1578_11713_11783(_outputStream, _computerName, _runspaceId);
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,11670,11799);

System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
f_1578_11713_11783(System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.PSObject>
this_param,string
computerName,System.Guid
runspaceId)
{
var return_v = this_param.GetPSObjectReaderForPipeline( computerName, runspaceId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 11713, 11783);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,11598,11810);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,11598,11810);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override PipelineReader<object> Error
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,12242,12368);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,12278,12353);

return f_1578_12285_12352(_errorStream, _computerName, _runspaceId);
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,12242,12368);

System.Management.Automation.Runspaces.PipelineReader<object>
f_1578_12285_12352(System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.ErrorRecord>
this_param,string
computerName,System.Guid
runspaceId)
{
var return_v = this_param.GetObjectReaderForPipeline( computerName, runspaceId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 12285, 12352);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,12173,12379);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,12173,12379);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal string HistoryString
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,12691,12764);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,12727,12749);

return _historyString;
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,12691,12764);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,12637,12865);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,12637,12865);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,12780,12854);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,12816,12839);

_historyString = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,12780,12854);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,12637,12865);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,12637,12865);
}
		}}

public bool AddToHistory
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,13053,13125);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,13089,13110);

return _addToHistory;
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,13053,13125);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,13004,13136);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,13004,13136);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private PSDataCollection<PSObject> _outputCollection;

private PSDataCollectionStream<PSObject> _outputStream;

private PSDataCollection<ErrorRecord> _errorCollection;

private PSDataCollectionStream<ErrorRecord> _errorStream;

private PSDataCollection<object> _inputCollection;

private PSDataCollectionStream<object> _inputStream;

protected PSDataCollectionStream<object> InputStream
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,14075,14146);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,14111,14131);

return _inputStream;
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,14075,14146);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,13998,14157);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,13998,14157);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override void InvokeAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,14452,14576);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,14511,14533);

f_1578_14511_14532(this, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,14547,14565);

f_1578_14547_14564(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,14452,14576);

int
f_1578_14511_14532(System.Management.Automation.RemotePipeline
this_param,bool
syncCall)
{
this_param.InitPowerShell( syncCall);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 14511, 14532);
return 0;
}


int
f_1578_14547_14564(System.Management.Automation.RemotePipeline
this_param)
{
this_param.CoreInvokeAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 14547, 14564);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,14452,14576);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,14452,14576);
}
		}

internal override void InvokeAsyncAndDisconnect()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,14746,14976);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,14905,14933);

f_1578_14905_14932(this, false, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,14947,14965);

f_1578_14947_14964(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,14746,14976);

int
f_1578_14905_14932(System.Management.Automation.RemotePipeline
this_param,bool
syncCall,bool
invokeAndDisconnect)
{
this_param.InitPowerShell( syncCall, invokeAndDisconnect);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 14905, 14932);
return 0;
}


int
f_1578_14947_14964(System.Management.Automation.RemotePipeline
this_param)
{
this_param.CoreInvokeAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 14947, 14964);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,14746,14976);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,14746,14976);
}
		}

public override Collection<PSObject> Invoke(System.Collections.IEnumerable input)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,15728,16656);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,15834,15925) || true) && (input == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,15834,15925);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,15885,15910);

f_1578_15885_15909(f_1578_15885_15901(this));
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,15834,15925);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,15941,15962);

f_1578_15941_15961(this, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,15978,16007);

Collection<PSObject> 
results
=default(Collection<PSObject>);

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,16059,16095);

results = f_1578_16069_16094(_powershell, input);
            }
            catch (InvalidRunspacePoolStateException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1578,16124,16614);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,16198,16573);

InvalidRunspaceStateException 
e =
f_1578_16253_16572(f_1578_16335_16442(f_1578_16353_16395(), f_1578_16397_16441(f_1578_16397_16430(f_1578_16397_16424(_runspace)))), f_1578_16469_16502(f_1578_16469_16496(_runspace)), RunspaceState.Opened)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,16591,16599);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCatch(1578,16124,16614);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,16630,16645);

return results;
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,15728,16656);

System.Management.Automation.Internal.PSDataCollectionStream<object>
f_1578_15885_15901(System.Management.Automation.RemotePipeline
this_param)
{
var return_v = this_param.InputStream;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 15885, 15901);
return return_v;
}


int
f_1578_15885_15909(System.Management.Automation.Internal.PSDataCollectionStream<object>
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 15885, 15909);
return 0;
}


int
f_1578_15941_15961(System.Management.Automation.RemotePipeline
this_param,bool
syncCall)
{
this_param.InitPowerShell( syncCall);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 15941, 15961);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1578_16069_16094(System.Management.Automation.PowerShell
this_param,System.Collections.IEnumerable
input)
{
var return_v = this_param.Invoke( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 16069, 16094);
return return_v;
}


string
f_1578_16353_16395()
{
var return_v = RunspaceStrings.RunspaceNotOpenForPipeline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 16353, 16395);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1578_16397_16424(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 16397, 16424);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1578_16397_16430(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 16397, 16430);
return return_v;
}


string
f_1578_16397_16441(System.Management.Automation.Runspaces.RunspaceState
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 16397, 16441);
return return_v;
}


string
f_1578_16335_16442(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 16335, 16442);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1578_16469_16496(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 16469, 16496);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1578_16469_16502(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 16469, 16502);
return return_v;
}


System.Management.Automation.Runspaces.InvalidRunspaceStateException
f_1578_16253_16572(string
message,System.Management.Automation.Runspaces.RunspaceState
currentState,System.Management.Automation.Runspaces.RunspaceState
expectedState)
{
var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException( message, currentState, expectedState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 16253, 16572);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,15728,16656);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,15728,16656);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override Collection<PSObject> Connect()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,16980,18246);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,17051,17082);

f_1578_17051_17081(this, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,17098,17127);

Collection<PSObject> 
results
=default(Collection<PSObject>);

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,17179,17211);

results = f_1578_17189_17210(_powershell);
            }
            catch (InvalidRunspacePoolStateException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1578,17240,17739);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,17314,17696);

InvalidRunspaceStateException 
e =
f_1578_17369_17695(f_1578_17451_17565(f_1578_17469_17518(), f_1578_17520_17564(f_1578_17520_17553(f_1578_17520_17547(_runspace)))), f_1578_17592_17625(f_1578_17592_17619(_runspace)), RunspaceState.Opened)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,17716,17724);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCatch(1578,17240,17739);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,17958,18204) || true) && (f_1578_17962_17975(results)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,17958,18204);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,18014,18189) || true) && (_outputCollection != null &&(DynAbs.Tracing.TraceSender.Expression_True(1578, 18018, 18074)&&f_1578_18047_18070(_outputCollection)> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,18014,18189);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,18116,18170);

results = f_1578_18126_18169(_outputCollection);
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,18014,18189);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,17958,18204);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,18220,18235);

return results;
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,16980,18246);

int
f_1578_17051_17081(System.Management.Automation.RemotePipeline
this_param,bool
syncCall)
{
this_param.InitPowerShellForConnect( syncCall);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 17051, 17081);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1578_17189_17210(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Connect();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 17189, 17210);
return return_v;
}


string
f_1578_17469_17518()
{
var return_v = RunspaceStrings.RunspaceNotOpenForPipelineConnect;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 17469, 17518);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1578_17520_17547(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 17520, 17547);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1578_17520_17553(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 17520, 17553);
return return_v;
}


string
f_1578_17520_17564(System.Management.Automation.Runspaces.RunspaceState
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 17520, 17564);
return return_v;
}


string
f_1578_17451_17565(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 17451, 17565);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1578_17592_17619(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 17592, 17619);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1578_17592_17625(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 17592, 17625);
return return_v;
}


System.Management.Automation.Runspaces.InvalidRunspaceStateException
f_1578_17369_17695(string
message,System.Management.Automation.Runspaces.RunspaceState
currentState,System.Management.Automation.Runspaces.RunspaceState
expectedState)
{
var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException( message, currentState, expectedState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 17369, 17695);
return return_v;
}


int
f_1578_17962_17975(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 17962, 17975);
return return_v;
}


int
f_1578_18047_18070(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 18047, 18070);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1578_18126_18169(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
list)
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>( (System.Collections.Generic.IList<System.Management.Automation.PSObject>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 18126, 18169);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,16980,18246);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,16980,18246);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override void ConnectAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,18383,19091);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,18443,18475);

f_1578_18443_18474(this, false);

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,18527,18554);

f_1578_18527_18553(                _powershell);
            }
            catch (InvalidRunspacePoolStateException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1578,18583,19080);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,18657,19039);

InvalidRunspaceStateException 
e =
f_1578_18712_19038(f_1578_18794_18908(f_1578_18812_18861(), f_1578_18863_18907(f_1578_18863_18896(f_1578_18863_18890(_runspace)))), f_1578_18935_18968(f_1578_18935_18962(_runspace)), RunspaceState.Opened)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,19057,19065);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCatch(1578,18583,19080);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,18383,19091);

int
f_1578_18443_18474(System.Management.Automation.RemotePipeline
this_param,bool
syncCall)
{
this_param.InitPowerShellForConnect( syncCall);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 18443, 18474);
return 0;
}


System.IAsyncResult
f_1578_18527_18553(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.ConnectAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 18527, 18553);
return return_v;
}


string
f_1578_18812_18861()
{
var return_v = RunspaceStrings.RunspaceNotOpenForPipelineConnect;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 18812, 18861);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1578_18863_18890(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 18863, 18890);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1578_18863_18896(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 18863, 18896);
return return_v;
}


string
f_1578_18863_18907(System.Management.Automation.Runspaces.RunspaceState
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 18863, 18907);
return return_v;
}


string
f_1578_18794_18908(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 18794, 18908);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1578_18935_18962(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 18935, 18962);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1578_18935_18968(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 18935, 18968);
return return_v;
}


System.Management.Automation.Runspaces.InvalidRunspaceStateException
f_1578_18712_19038(string
message,System.Management.Automation.Runspaces.RunspaceState
currentState,System.Management.Automation.Runspaces.RunspaceState
expectedState)
{
var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException( message, currentState, expectedState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 18712, 19038);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,18383,19091);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,18383,19091);
}
		}

public override void Stop()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,19242,20167);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,19294,19325);

bool 
isAlreadyStopping = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,19339,20032) || true) && (f_1578_19343_19381(this, out isAlreadyStopping))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,19339,20032);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,19509,20017) || true) && (_powershell != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,19509,20017);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,19574,19606);

IAsyncResult 
asyncresult = null
;
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,19680,19728);

asyncresult = f_1578_19694_19727(_powershell, null, null);
                    }
                    catch (ObjectDisposedException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1578,19773,19935);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,19853,19912);

throw f_1578_19859_19911("Pipeline");
DynAbs.Tracing.TraceSender.TraceExitCatch(1578,19773,19935);
                    }DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,19935,19936);
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,19960,19998);

f_1578_19960_19997(f_1578_19960_19987(asyncresult));
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,19509,20017);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,19339,20032);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,20124,20156);

f_1578_20124_20155(f_1578_20124_20145());
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,19242,20167);

bool
f_1578_19343_19381(System.Management.Automation.RemotePipeline
this_param,out bool
isAlreadyStopping)
{
var return_v = this_param.CanStopPipeline( out isAlreadyStopping);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 19343, 19381);
return return_v;
}


System.IAsyncResult
f_1578_19694_19727(System.Management.Automation.PowerShell
this_param,System.AsyncCallback
callback,object
state)
{
var return_v = this_param.BeginStop( callback, state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 19694, 19727);
return return_v;
}


System.Management.Automation.PSObjectDisposedException
f_1578_19859_19911(string
objectName)
{
var return_v = PSTraceSource.NewObjectDisposedException( objectName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 19859, 19911);
return return_v;
}


System.Threading.WaitHandle
f_1578_19960_19987(System.IAsyncResult
this_param)
{
var return_v = this_param.AsyncWaitHandle;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 19960, 19987);
return return_v;
}


bool
f_1578_19960_19997(System.Threading.WaitHandle
this_param)
{
var return_v = this_param.WaitOne();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 19960, 19997);
return return_v;
}


System.Threading.ManualResetEvent
f_1578_20124_20145()
{
var return_v = PipelineFinishedEvent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 20124, 20145);
return return_v;
}


bool
f_1578_20124_20155(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.WaitOne();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 20124, 20155);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,19242,20167);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,19242,20167);
}
		}

public override void StopAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,20429,20890);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,20486,20509);

bool 
isAlreadyStopping
=default(bool);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,20523,20879) || true) && (f_1578_20527_20565(this, out isAlreadyStopping))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,20523,20879);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,20643,20677);

f_1578_20643_20676(                    _powershell, null, null);
                }
                catch (ObjectDisposedException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1578,20714,20864);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,20786,20845);

throw f_1578_20792_20844("Pipeline");
DynAbs.Tracing.TraceSender.TraceExitCatch(1578,20714,20864);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,20523,20879);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,20429,20890);

bool
f_1578_20527_20565(System.Management.Automation.RemotePipeline
this_param,out bool
isAlreadyStopping)
{
var return_v = this_param.CanStopPipeline( out isAlreadyStopping);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 20527, 20565);
return return_v;
}


System.IAsyncResult
f_1578_20643_20676(System.Management.Automation.PowerShell
this_param,System.AsyncCallback
callback,object
state)
{
var return_v = this_param.BeginStop( callback, state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 20643, 20676);
return return_v;
}


System.Management.Automation.PSObjectDisposedException
f_1578_20792_20844(string
objectName)
{
var return_v = PSTraceSource.NewObjectDisposedException( objectName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 20792, 20844);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,20429,20890);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,20429,20890);
}
		}

private bool CanStopPipeline(out bool isAlreadyStopping)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,21026,22607);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,21107,21133);

bool 
returnResult = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,21147,21173);

isAlreadyStopping = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,21193,21202);
            lock (_syncRoot)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,21340,22502);

switch (f_1578_21348_21372(_pipelineStateInfo))
                {

case PipelineState.NotStarted:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,21340,22502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,21470,21517);

f_1578_21470_21516(this, PipelineState.Stopping, null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,21543,21589);

f_1578_21543_21588(this, PipelineState.Stopped, null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,21615,21636);

returnResult = false;
DynAbs.Tracing.TraceSender.TraceBreak(1578,21662,21668);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,21340,22502);

case PipelineState.Stopped:
                    case PipelineState.Completed:
                    case PipelineState.Failed:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,21340,22502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,21966,21979);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,21340,22502);

case PipelineState.Stopping:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,21340,22502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,22163,22188);

isAlreadyStopping = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,22214,22227);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,21340,22502);

case PipelineState.Running:
                    case PipelineState.Disconnected:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,21340,22502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,22358,22405);

f_1578_22358_22404(this, PipelineState.Stopping, null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,22431,22451);

returnResult = true;
DynAbs.Tracing.TraceSender.TraceBreak(1578,22477,22483);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,21340,22502);
                }
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,22533,22560);

f_1578_22533_22559(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,22576,22596);

return returnResult;
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,21026,22607);

System.Management.Automation.Runspaces.PipelineState
f_1578_21348_21372(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 21348, 21372);
return return_v;
}


int
f_1578_21470_21516(System.Management.Automation.RemotePipeline
this_param,System.Management.Automation.Runspaces.PipelineState
state,System.Exception
reason)
{
this_param.SetPipelineState( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 21470, 21516);
return 0;
}


int
f_1578_21543_21588(System.Management.Automation.RemotePipeline
this_param,System.Management.Automation.Runspaces.PipelineState
state,System.Exception
reason)
{
this_param.SetPipelineState( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 21543, 21588);
return 0;
}


int
f_1578_22358_22404(System.Management.Automation.RemotePipeline
this_param,System.Management.Automation.Runspaces.PipelineState
state,System.Exception
reason)
{
this_param.SetPipelineState( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 22358, 22404);
return 0;
}


int
f_1578_22533_22559(System.Management.Automation.RemotePipeline
this_param)
{
this_param.RaisePipelineStateEvents();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 22533, 22559);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,21026,22607);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,21026,22607);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

        
        
        /// <summary>
        /// Event raised when Pipeline's state changes.
        /// </summary>
        public override event EventHandler<PipelineStateEventArgs> 
StateChanged = null
;

protected override void Dispose(bool disposing)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,23083,24490);
            try
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,23191,23272) || true) && (_disposed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,23191,23272);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,23246,23253);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,23191,23272);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,23298,23307);

                lock (_syncRoot)
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,23349,23442) || true) && (_disposed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,23349,23442);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,23412,23419);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,23349,23442);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,23466,23483);

_disposed = true;
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,23522,24371) || true) && (disposing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,23522,24371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,23709,23716);

f_1578_23709_23715(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,23796,23959) || true) && (_powershell != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,23796,23959);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,23869,23891);

f_1578_23869_23890(                        _powershell);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,23917,23936);

_powershell = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,23796,23959);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,23983,24010);

f_1578_23983_24009(
                    _inputCollection);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,24032,24055);

f_1578_24032_24054(                    _inputStream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,24077,24105);

f_1578_24077_24104(                    _outputCollection);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,24127,24151);

f_1578_24127_24150(                    _outputStream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,24173,24200);

f_1578_24173_24199(                    _errorCollection);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,24222,24245);

f_1578_24222_24244(                    _errorStream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,24267,24298);

f_1578_24267_24297(f_1578_24267_24287());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,24320,24352);

f_1578_24320_24351(f_1578_24320_24341());
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,23522,24371);
}
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1578,24400,24479);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,24440,24464);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(disposing),1578,24440,24463);
DynAbs.Tracing.TraceSender.TraceExitFinally(1578,24400,24479);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,23083,24490);

int
f_1578_23709_23715(System.Management.Automation.RemotePipeline
this_param)
{
this_param.Stop();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 23709, 23715);
return 0;
}


int
f_1578_23869_23890(System.Management.Automation.PowerShell
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 23869, 23890);
return 0;
}


int
f_1578_23983_24009(System.Management.Automation.PSDataCollection<object>
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 23983, 24009);
return 0;
}


int
f_1578_24032_24054(System.Management.Automation.Internal.PSDataCollectionStream<object>
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 24032, 24054);
return 0;
}


int
f_1578_24077_24104(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 24077, 24104);
return 0;
}


int
f_1578_24127_24150(System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.PSObject>
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 24127, 24150);
return 0;
}


int
f_1578_24173_24199(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 24173, 24199);
return 0;
}


int
f_1578_24222_24244(System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.ErrorRecord>
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 24222, 24244);
return 0;
}


System.Management.Automation.Internal.ObjectStream
f_1578_24267_24287()
{
var return_v = MethodExecutorStream;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 24267, 24287);
return return_v;
}


int
f_1578_24267_24297(System.Management.Automation.Internal.ObjectStream
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 24267, 24297);
return 0;
}


System.Threading.ManualResetEvent
f_1578_24320_24341()
{
var return_v = PipelineFinishedEvent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 24320, 24341);
return return_v;
}


int
f_1578_24320_24351(System.Threading.ManualResetEvent
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 24320, 24351);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,23083,24490);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,23083,24490);
}
		}

private void CoreInvokeAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,24567,25214);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,24658,24684);

f_1578_24658_24683(                _powershell);
            }
            catch (InvalidRunspacePoolStateException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1578,24713,25203);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,24787,25162);

InvalidRunspaceStateException 
e =
f_1578_24842_25161(f_1578_24924_25031(f_1578_24942_24984(), f_1578_24986_25030(f_1578_24986_25019(f_1578_24986_25013(_runspace)))), f_1578_25058_25091(f_1578_25058_25085(_runspace)), RunspaceState.Opened)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,25180,25188);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCatch(1578,24713,25203);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,24567,25214);

System.IAsyncResult
f_1578_24658_24683(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.BeginInvoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 24658, 24683);
return return_v;
}


string
f_1578_24942_24984()
{
var return_v = RunspaceStrings.RunspaceNotOpenForPipeline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 24942, 24984);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1578_24986_25013(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 24986, 25013);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1578_24986_25019(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 24986, 25019);
return return_v;
}


string
f_1578_24986_25030(System.Management.Automation.Runspaces.RunspaceState
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 24986, 25030);
return return_v;
}


string
f_1578_24924_25031(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 24924, 25031);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1578_25058_25085(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 25058, 25085);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1578_25058_25091(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 25058, 25091);
return return_v;
}


System.Management.Automation.Runspaces.InvalidRunspaceStateException
f_1578_24842_25161(string
message,System.Management.Automation.Runspaces.RunspaceState
currentState,System.Management.Automation.Runspaces.RunspaceState
expectedState)
{
var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException( message, currentState, expectedState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 24842, 25161);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,24567,25214);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,24567,25214);
}
		}

private void HandleInvocationStateChanged(object sender, PSInvocationStateChangedEventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,25226,25489);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,25344,25435);

f_1578_25344_25434(this, f_1578_25376_25403(f_1578_25376_25397(e)), f_1578_25405_25433(f_1578_25405_25426(e)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,25451,25478);

f_1578_25451_25477(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,25226,25489);

System.Management.Automation.PSInvocationStateInfo
f_1578_25376_25397(System.Management.Automation.PSInvocationStateChangedEventArgs
this_param)
{
var return_v = this_param.InvocationStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 25376, 25397);
return return_v;
}


System.Management.Automation.PSInvocationState
f_1578_25376_25403(System.Management.Automation.PSInvocationStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 25376, 25403);
return return_v;
}


System.Management.Automation.PSInvocationStateInfo
f_1578_25405_25426(System.Management.Automation.PSInvocationStateChangedEventArgs
this_param)
{
var return_v = this_param.InvocationStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 25405, 25426);
return return_v;
}


System.Exception
f_1578_25405_25433(System.Management.Automation.PSInvocationStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 25405, 25433);
return return_v;
}


int
f_1578_25344_25434(System.Management.Automation.RemotePipeline
this_param,System.Management.Automation.PSInvocationState
state,System.Exception
reason)
{
this_param.SetPipelineState( (System.Management.Automation.Runspaces.PipelineState)state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 25344, 25434);
return 0;
}


int
f_1578_25451_25477(System.Management.Automation.RemotePipeline
this_param)
{
this_param.RaisePipelineStateEvents();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 25451, 25477);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,25226,25489);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,25226,25489);
}
		}

private void SetPipelineState(PipelineState state, Exception reason)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,26075,29067);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,26168,26200);

PipelineState 
copyState = state
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,26214,26253);

PipelineStateInfo 
copyStateInfo = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,26275,26284);

            lock (_syncRoot)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,26318,27382);

switch (f_1578_26326_26350(_pipelineStateInfo))
                {

case PipelineState.Completed:
                    case PipelineState.Failed:
                    case PipelineState.Stopped:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,26318,27382);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,26544,26551);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,26318,27382);

case PipelineState.Running:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,26318,27382);
                        {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,26659,26797) || true) && (state == PipelineState.Running)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,26659,26797);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,26759,26766);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,26659,26797);
}
                        }
DynAbs.Tracing.TraceSender.TraceBreak(1578,26852,26858);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,26318,27382);

case PipelineState.Stopping:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,26318,27382);
                        {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,26965,27302) || true) && (state == PipelineState.Running ||(DynAbs.Tracing.TraceSender.Expression_False(1578, 26969, 27034)||state == PipelineState.Stopping))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,26965,27302);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,27100,27107);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,26965,27302);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,26965,27302);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,27237,27271);

copyState = PipelineState.Stopped;
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,26965,27302);
}
                        }
DynAbs.Tracing.TraceSender.TraceBreak(1578,27357,27363);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,26318,27382);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,27402,27464);

_pipelineStateInfo = f_1578_27423_27463(copyState, reason);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,27482,27517);

copyStateInfo = _pipelineStateInfo;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,27910,27985);

RunspaceAvailability 
previousAvailability = f_1578_27954_27984(_runspace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,28005,28088);

Guid? 
cmdInstanceId = (DynAbs.Tracing.TraceSender.Conditional_F1(1578, 28027, 28048)||(((_powershell != null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1578, 28051, 28073))||DynAbs.Tracing.TraceSender.Conditional_F3(1578, 28076, 28087)))?f_1578_28051_28073(_powershell):(Guid?)null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,28106,28191);

f_1578_28106_28190(                _runspace, f_1578_28143_28167(_pipelineStateInfo), false, cmdInstanceId);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,28211,28449);

f_1578_28211_28448(
                _executionEventQueue, f_1578_28262_28447(f_1578_28316_28342(                        _pipelineStateInfo), previousAvailability, f_1578_28416_28446(_runspace)));
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,28818,29056) || true) && (f_1578_28822_28841(copyStateInfo)== PipelineState.Completed ||(DynAbs.Tracing.TraceSender.Expression_False(1578, 28822, 28932)||f_1578_28889_28908(copyStateInfo)== PipelineState.Failed )||(DynAbs.Tracing.TraceSender.Expression_False(1578, 28822, 28997)||f_1578_28953_28972(copyStateInfo)== PipelineState.Stopped))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,28818,29056);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,29031,29041);

f_1578_29031_29040(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,28818,29056);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,26075,29067);

System.Management.Automation.Runspaces.PipelineState
f_1578_26326_26350(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 26326, 26350);
return return_v;
}


System.Management.Automation.Runspaces.PipelineStateInfo
f_1578_27423_27463(System.Management.Automation.Runspaces.PipelineState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.Runspaces.PipelineStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 27423, 27463);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceAvailability
f_1578_27954_27984(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceAvailability;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 27954, 27984);
return return_v;
}


System.Guid
f_1578_28051_28073(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.InstanceId ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 28051, 28073);
return return_v;
}


System.Management.Automation.Runspaces.PipelineState
f_1578_28143_28167(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 28143, 28167);
return return_v;
}


int
f_1578_28106_28190(System.Management.Automation.Runspaces.Runspace
this_param,System.Management.Automation.Runspaces.PipelineState
pipelineState,bool
raiseEvent,System.Guid?
cmdInstanceId)
{
this_param.UpdateRunspaceAvailability( pipelineState, raiseEvent, cmdInstanceId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 28106, 28190);
return 0;
}


System.Management.Automation.Runspaces.PipelineStateInfo
f_1578_28316_28342(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.Clone();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 28316, 28342);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceAvailability
f_1578_28416_28446(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceAvailability;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 28416, 28446);
return return_v;
}


System.Management.Automation.RemotePipeline.ExecutionEventQueueItem
f_1578_28262_28447(System.Management.Automation.Runspaces.PipelineStateInfo
pipelineStateInfo,System.Management.Automation.Runspaces.RunspaceAvailability
currentAvailability,System.Management.Automation.Runspaces.RunspaceAvailability
newAvailability)
{
var return_v = new System.Management.Automation.RemotePipeline.ExecutionEventQueueItem( pipelineStateInfo, currentAvailability, newAvailability);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 28262, 28447);
return return_v;
}


int
f_1578_28211_28448(System.Collections.Generic.Queue<System.Management.Automation.RemotePipeline.ExecutionEventQueueItem>
this_param,System.Management.Automation.RemotePipeline.ExecutionEventQueueItem
item)
{
this_param.Enqueue( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 28211, 28448);
return 0;
}


System.Management.Automation.Runspaces.PipelineState
f_1578_28822_28841(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 28822, 28841);
return return_v;
}


System.Management.Automation.Runspaces.PipelineState
f_1578_28889_28908(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 28889, 28908);
return return_v;
}


System.Management.Automation.Runspaces.PipelineState
f_1578_28953_28972(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 28953, 28972);
return return_v;
}


int
f_1578_29031_29040(System.Management.Automation.RemotePipeline
this_param)
{
this_param.Cleanup();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 29031, 29040);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,26075,29067);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,26075,29067);
}
		}

protected void RaisePipelineStateEvents()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,29185,31319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,29251,29304);

Queue<ExecutionEventQueueItem> 
tempEventQueue = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,29318,29375);

EventHandler<PipelineStateEventArgs> 
stateChanged = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,29389,29444);

bool 
runspaceHasAvailabilityChangedSubscribers = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,29466,29475);

            lock (_syncRoot)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,29509,29542);

stateChanged = this.StateChanged;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,29560,29648);

runspaceHasAvailabilityChangedSubscribers = f_1578_29604_29647(_runspace);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,29668,30239) || true) && (stateChanged != null ||(DynAbs.Tracing.TraceSender.Expression_False(1578, 29672, 29737)||runspaceHasAvailabilityChangedSubscribers))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,29668,30239);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,29779,29817);

tempEventQueue = _executionEventQueue;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,29839,29899);

_executionEventQueue = f_1578_29862_29898();
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,29668,30239);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,29668,30239);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,30191,30220);

f_1578_30191_30219(                    // Clear the events if there are no EventHandlers. This
                    // ensures that events do not get called for state
                    // changes prior to their registration.
                    _executionEventQueue);
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,29668,30239);
}
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,30270,31308) || true) && (tempEventQueue != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,30270,31308);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,30330,31293) || true) && (f_1578_30337_30357(tempEventQueue)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,30330,31293);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,30403,30464);

ExecutionEventQueueItem 
queueItem = f_1578_30439_30463(tempEventQueue)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,30488,30759) || true) && (runspaceHasAvailabilityChangedSubscribers &&(DynAbs.Tracing.TraceSender.Expression_True(1578, 30492, 30611)&&queueItem.NewRunspaceAvailability != queueItem.CurrentRunspaceAvailability))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,30488,30759);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,30661,30736);

f_1578_30661_30735(                        _runspace, queueItem.NewRunspaceAvailability);
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,30488,30759);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,30917,31274) || true) && (stateChanged != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,30917,31274);
                        try
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,31051,31127);

f_1578_31051_31126(stateChanged, this, f_1578_31070_31125(queueItem.PipelineStateInfo));
                        }
                        catch (Exception)
                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1578,31180,31251);
DynAbs.Tracing.TraceSender.TraceExitCatch(1578,31180,31251);
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,30917,31274);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,30330,31293);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1578,30330,31293);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1578,30330,31293);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1578,30270,31308);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,29185,31319);

bool
f_1578_29604_29647(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.HasAvailabilityChangedSubscribers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 29604, 29647);
return return_v;
}


System.Collections.Generic.Queue<System.Management.Automation.RemotePipeline.ExecutionEventQueueItem>
f_1578_29862_29898()
{
var return_v = new System.Collections.Generic.Queue<System.Management.Automation.RemotePipeline.ExecutionEventQueueItem>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 29862, 29898);
return return_v;
}


int
f_1578_30191_30219(System.Collections.Generic.Queue<System.Management.Automation.RemotePipeline.ExecutionEventQueueItem>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 30191, 30219);
return 0;
}


int
f_1578_30337_30357(System.Collections.Generic.Queue<System.Management.Automation.RemotePipeline.ExecutionEventQueueItem>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 30337, 30357);
return return_v;
}


System.Management.Automation.RemotePipeline.ExecutionEventQueueItem
f_1578_30439_30463(System.Collections.Generic.Queue<System.Management.Automation.RemotePipeline.ExecutionEventQueueItem>
this_param)
{
var return_v = this_param.Dequeue();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 30439, 30463);
return return_v;
}


int
f_1578_30661_30735(System.Management.Automation.Runspaces.Runspace
this_param,System.Management.Automation.Runspaces.RunspaceAvailability
availability)
{
this_param.RaiseAvailabilityChangedEvent( availability);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 30661, 30735);
return 0;
}


System.Management.Automation.Runspaces.PipelineStateEventArgs
f_1578_31070_31125(System.Management.Automation.Runspaces.PipelineStateInfo
pipelineStateInfo)
{
var return_v = new System.Management.Automation.Runspaces.PipelineStateEventArgs( pipelineStateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 31070, 31125);
return return_v;
}


int
f_1578_31051_31126(System.EventHandler<System.Management.Automation.Runspaces.PipelineStateEventArgs>
this_param,System.Management.Automation.RemotePipeline
sender,System.Management.Automation.Runspaces.PipelineStateEventArgs
e)
{
this_param.Invoke( (object)sender, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 31051, 31126);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,29185,31319);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,29185,31319);
}
		}

private void InitPowerShell(bool syncCall, bool invokeAndDisconnect = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,31838,33225);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,31939,32145) || true) && (_commands == null ||(DynAbs.Tracing.TraceSender.Expression_False(1578, 31943, 31984)||f_1578_31964_31979(_commands)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,31939,32145);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,32018,32130);

throw f_1578_32024_32129(f_1578_32093_32128());
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,31939,32145);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,32161,32616) || true) && (f_1578_32165_32189(_pipelineStateInfo)!= PipelineState.NotStarted)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,32161,32616);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,32251,32575);

InvalidPipelineStateException 
e =
f_1578_32306_32574(f_1578_32388_32449(f_1578_32406_32448()), f_1578_32476_32500(_pipelineStateInfo), PipelineState.NotStarted)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,32593,32601);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,32161,32616);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,32632,32718);

f_1578_32632_32717(
            ((RemoteRunspace)_runspace), this, syncCall);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,32734,32793);

PSInvocationSettings 
settings = f_1578_32766_32792()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,32807,32845);

settings.AddToHistory = _addToHistory;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,32859,32910);

settings.InvokeAndDisconnect = invokeAndDisconnect;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,32926,33054);

f_1578_32926_33053(
            _powershell, _commands, _inputStream, _outputStream, _errorStream, settings, f_1578_33024_33052());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,33070,33214);

f_1578_33070_33098(_powershell).HostCallReceived +=
                new EventHandler<RemoteDataEventArgs<RemoteHostCall>>(HandleHostCallReceived);
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,31838,33225);

int
f_1578_31964_31979(System.Management.Automation.Runspaces.CommandCollection
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 31964, 31979);
return return_v;
}


string
f_1578_32093_32128()
{
var return_v =                         RunspaceStrings.NoCommandInPipeline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 32093, 32128);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1578_32024_32129(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 32024, 32129);
return return_v;
}


System.Management.Automation.Runspaces.PipelineState
f_1578_32165_32189(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 32165, 32189);
return return_v;
}


string
f_1578_32406_32448()
{
var return_v = RunspaceStrings.PipelineReInvokeNotAllowed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 32406, 32448);
return return_v;
}


string
f_1578_32388_32449(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 32388, 32449);
return return_v;
}


System.Management.Automation.Runspaces.PipelineState
f_1578_32476_32500(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 32476, 32500);
return return_v;
}


System.Management.Automation.Runspaces.InvalidPipelineStateException
f_1578_32306_32574(string
message,System.Management.Automation.Runspaces.PipelineState
currentState,System.Management.Automation.Runspaces.PipelineState
expectedState)
{
var return_v = new System.Management.Automation.Runspaces.InvalidPipelineStateException( message, currentState, expectedState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 32306, 32574);
return return_v;
}


int
f_1578_32632_32717(System.Management.Automation.RemoteRunspace
this_param,System.Management.Automation.RemotePipeline
pipeline,bool
syncCall)
{
this_param.DoConcurrentCheckAndAddToRunningPipelines( pipeline, syncCall);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 32632, 32717);
return 0;
}


System.Management.Automation.PSInvocationSettings
f_1578_32766_32792()
{
var return_v = new System.Management.Automation.PSInvocationSettings();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 32766, 32792);
return return_v;
}


bool
f_1578_33024_33052()
{
var return_v = RedirectShellErrorOutputPipe;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 33024, 33052);
return return_v;
}


int
f_1578_32926_33053(System.Management.Automation.PowerShell
this_param,System.Management.Automation.Runspaces.CommandCollection
command,System.Management.Automation.Internal.PSDataCollectionStream<object>
inputstream,System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.PSObject>
outputstream,System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.ErrorRecord>
errorstream,System.Management.Automation.PSInvocationSettings
settings,bool
redirectShellErrorOutputPipe)
{
this_param.InitForRemotePipeline( command, (System.Management.Automation.Internal.ObjectStreamBase)inputstream, (System.Management.Automation.Internal.ObjectStreamBase)outputstream, (System.Management.Automation.Internal.ObjectStreamBase)errorstream, settings, redirectShellErrorOutputPipe);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 32926, 33053);
return 0;
}


System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
f_1578_33070_33098(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.RemotePowerShell;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 33070, 33098);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,31838,33225);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,31838,33225);
}
		}

private void InitPowerShellForConnect(bool syncCall)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,33482,35262);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,33559,33934) || true) && (f_1578_33563_33587(_pipelineStateInfo)!= PipelineState.Disconnected)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,33559,33934);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,33651,33919);

throw f_1578_33657_33918(f_1578_33691_33749(f_1578_33709_33748()), f_1578_33808_33832(_pipelineStateInfo), PipelineState.Disconnected);
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,33559,33934);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,34286,34393);

RemotePipeline 
currentPipeline = (RemotePipeline)f_1578_34335_34392(((RemoteRunspace)_runspace))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,34407,34585) || true) && (!f_1578_34412_34450(currentPipeline, this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,34407,34585);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,34484,34570);

f_1578_34484_34569(                ((RemoteRunspace)_runspace), this, syncCall);
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,34407,34585);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,34688,35251) || true) && ((f_1578_34693_34721(_powershell)) == null ||(DynAbs.Tracing.TraceSender.Expression_False(1578, 34692, 34775)||f_1578_34734_34775_M(!f_1578_34735_34763(_powershell).Initialized)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,34688,35251);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,34809,34868);

PSInvocationSettings 
settings = f_1578_34841_34867()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,34886,34924);

settings.AddToHistory = _addToHistory;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,34944,35068);

f_1578_34944_35067(
                _powershell, _inputStream, _outputStream, _errorStream, settings, f_1578_35038_35066());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,35088,35236);

f_1578_35088_35116(_powershell).HostCallReceived +=
                    new EventHandler<RemoteDataEventArgs<RemoteHostCall>>(HandleHostCallReceived);
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,34688,35251);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,33482,35262);

System.Management.Automation.Runspaces.PipelineState
f_1578_33563_33587(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 33563, 33587);
return return_v;
}


string
f_1578_33709_33748()
{
var return_v = PipelineStrings.PipelineNotDisconnected;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 33709, 33748);
return return_v;
}


string
f_1578_33691_33749(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 33691, 33749);
return return_v;
}


System.Management.Automation.Runspaces.PipelineState
f_1578_33808_33832(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 33808, 33832);
return return_v;
}


System.Management.Automation.Runspaces.InvalidPipelineStateException
f_1578_33657_33918(string
message,System.Management.Automation.Runspaces.PipelineState
currentState,System.Management.Automation.Runspaces.PipelineState
expectedState)
{
var return_v = new System.Management.Automation.Runspaces.InvalidPipelineStateException( message, currentState, expectedState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 33657, 33918);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1578_34335_34392(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.GetCurrentlyRunningPipeline();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 34335, 34392);
return return_v;
}


bool
f_1578_34412_34450(System.Management.Automation.RemotePipeline
objA,System.Management.Automation.RemotePipeline
objB)
{
var return_v = ReferenceEquals( (object)objA, (object)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 34412, 34450);
return return_v;
}


int
f_1578_34484_34569(System.Management.Automation.RemoteRunspace
this_param,System.Management.Automation.RemotePipeline
pipeline,bool
syncCall)
{
this_param.DoConcurrentCheckAndAddToRunningPipelines( pipeline, syncCall);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 34484, 34569);
return 0;
}


System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
f_1578_34693_34721(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.RemotePowerShell;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 34693, 34721);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
f_1578_34735_34763(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.RemotePowerShell;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 34735, 34763);
return return_v;
}


bool
f_1578_34734_34775_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 34734, 34775);
return return_v;
}


System.Management.Automation.PSInvocationSettings
f_1578_34841_34867()
{
var return_v = new System.Management.Automation.PSInvocationSettings();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 34841, 34867);
return return_v;
}


bool
f_1578_35038_35066()
{
var return_v = RedirectShellErrorOutputPipe;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 35038, 35066);
return return_v;
}


int
f_1578_34944_35067(System.Management.Automation.PowerShell
this_param,System.Management.Automation.Internal.PSDataCollectionStream<object>
inputstream,System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.PSObject>
outputstream,System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.ErrorRecord>
errorstream,System.Management.Automation.PSInvocationSettings
settings,bool
redirectShellErrorOutputPipe)
{
this_param.InitForRemotePipelineConnect( (System.Management.Automation.Internal.ObjectStreamBase)inputstream, (System.Management.Automation.Internal.ObjectStreamBase)outputstream, (System.Management.Automation.Internal.ObjectStreamBase)errorstream, settings, redirectShellErrorOutputPipe);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 34944, 35067);
return 0;
}


System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
f_1578_35088_35116(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.RemotePowerShell;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 35088, 35116);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,33482,35262);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,33482,35262);
}
		}

private void HandleHostCallReceived(object sender, RemoteDataEventArgs<RemoteHostCall> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,35524,36142);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,35646,36131);

f_1578_35646_36130(f_1578_35694_35760(f_1578_35694_35743(f_1578_35694_35722(_powershell))), f_1578_35779_35851(f_1578_35779_35846(f_1578_35779_35819(((RemoteRunspace)_runspace)))), _errorStream, f_1578_35901_35921(), f_1578_35940_35969(), f_1578_35988_36055(f_1578_35988_36028(((RemoteRunspace)_runspace))), f_1578_36074_36096(_powershell), f_1578_36115_36129(eventArgs));
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,35524,36142);

System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
f_1578_35694_35722(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.RemotePowerShell;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 35694, 35722);
return return_v;
}


System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
f_1578_35694_35743(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param)
{
var return_v = this_param.DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 35694, 35743);
return return_v;
}


System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
f_1578_35694_35760(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param)
{
var return_v = this_param.TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 35694, 35760);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1578_35779_35819(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 35779, 35819);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1578_35779_35846(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 35779, 35846);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1578_35779_35851(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 35779, 35851);
return return_v;
}


System.Management.Automation.Internal.ObjectStream
f_1578_35901_35921()
{
var return_v = MethodExecutorStream;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 35901, 35921);
return return_v;
}


bool
f_1578_35940_35969()
{
var return_v = IsMethodExecutorStreamEnabled;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 35940, 35969);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1578_35988_36028(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 35988, 36028);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1578_35988_36055(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 35988, 36055);
return return_v;
}


System.Guid
f_1578_36074_36096(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 36074, 36096);
return return_v;
}


System.Management.Automation.Remoting.RemoteHostCall
f_1578_36115_36129(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 36115, 36129);
return return_v;
}


int
f_1578_35646_36130(System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
transportManager,System.Management.Automation.Host.PSHost
clientHost,System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.ErrorRecord>
errorStream,System.Management.Automation.Internal.ObjectStream
methodExecutorStream,bool
isMethodExecutorStreamEnabled,System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
runspacePool,System.Guid
clientPowerShellId,System.Management.Automation.Remoting.RemoteHostCall
remoteHostCall)
{
ClientMethodExecutor.Dispatch( (System.Management.Automation.Remoting.Client.BaseClientTransportManager)transportManager, clientHost, errorStream, methodExecutorStream, isMethodExecutorStreamEnabled, runspacePool, clientPowerShellId, remoteHostCall);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 35646, 36130);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,35524,36142);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,35524,36142);
}
		}

private void Cleanup()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,36265,37880);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,36373,36669) || true) && (f_1578_36377_36397(_outputStream))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,36373,36669);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,36475,36504);

f_1578_36475_36503(                    _outputCollection);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,36526,36548);

f_1578_36526_36547(                    _outputStream);
                }
                catch (ObjectDisposedException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1578,36585,36654);
DynAbs.Tracing.TraceSender.TraceExitCatch(1578,36585,36654);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,36373,36669);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,36745,37038) || true) && (f_1578_36749_36768(_errorStream))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,36745,37038);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,36846,36874);

f_1578_36846_36873(                    _errorCollection);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,36896,36917);

f_1578_36896_36916(                    _errorStream);
                }
                catch (ObjectDisposedException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1578,36954,37023);
DynAbs.Tracing.TraceSender.TraceExitCatch(1578,36954,37023);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,36745,37038);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,37114,37407) || true) && (f_1578_37118_37137(_inputStream))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,37114,37407);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,37215,37243);

f_1578_37215_37242(                    _inputCollection);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,37265,37286);

f_1578_37265_37285(                    _inputStream);
                }
                catch (ObjectDisposedException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1578,37323,37392);
DynAbs.Tracing.TraceSender.TraceExitCatch(1578,37323,37392);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,37114,37407);
}

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,37667,37731);

f_1578_37667_37730(                // Runspace object maintains a list of pipelines in execution.
                // Remove this pipeline from the list. This method also calls the
                // pipeline finished event.
                ((RemoteRunspace)_runspace), this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,37751,37779);

f_1578_37751_37778(f_1578_37751_37772());
            }
            catch (ObjectDisposedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1578,37808,37869);
DynAbs.Tracing.TraceSender.TraceExitCatch(1578,37808,37869);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,36265,37880);

bool
f_1578_36377_36397(System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.IsOpen;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 36377, 36397);
return return_v;
}


int
f_1578_36475_36503(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
this_param)
{
this_param.Complete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 36475, 36503);
return 0;
}


int
f_1578_36526_36547(System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.PSObject>
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 36526, 36547);
return 0;
}


bool
f_1578_36749_36768(System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.ErrorRecord>
this_param)
{
var return_v = this_param.IsOpen;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 36749, 36768);
return return_v;
}


int
f_1578_36846_36873(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
this_param)
{
this_param.Complete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 36846, 36873);
return 0;
}


int
f_1578_36896_36916(System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.ErrorRecord>
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 36896, 36916);
return 0;
}


bool
f_1578_37118_37137(System.Management.Automation.Internal.PSDataCollectionStream<object>
this_param)
{
var return_v = this_param.IsOpen;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 37118, 37137);
return return_v;
}


int
f_1578_37215_37242(System.Management.Automation.PSDataCollection<object>
this_param)
{
this_param.Complete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 37215, 37242);
return 0;
}


int
f_1578_37265_37285(System.Management.Automation.Internal.PSDataCollectionStream<object>
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 37265, 37285);
return 0;
}


int
f_1578_37667_37730(System.Management.Automation.RemoteRunspace
this_param,System.Management.Automation.RemotePipeline
pipeline)
{
this_param.RemoveFromRunningPipelineList( pipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 37667, 37730);
return 0;
}


System.Threading.ManualResetEvent
f_1578_37751_37772()
{
var return_v = PipelineFinishedEvent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 37751, 37772);
return return_v;
}


bool
f_1578_37751_37778(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 37751, 37778);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,36265,37880);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,36265,37880);
}
		}

internal ManualResetEvent PipelineFinishedEvent {get; }

internal bool IsMethodExecutorStreamEnabled {get; set; }

internal ObjectStream MethodExecutorStream {get; }

internal void DoConcurrentCheck(bool syncCall)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,39314,41999);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,39385,39509);

RemotePipeline 
currentPipeline =
                (RemotePipeline)f_1578_39451_39508(((RemoteRunspace)_runspace))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,39525,41988) || true) && (_isNested == false)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,39525,41988);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,39581,40013) || true) && (currentPipeline == null &&(DynAbs.Tracing.TraceSender.Expression_True(1578, 39585, 39710)&&f_1578_39633_39681(((RemoteRunspace)_runspace))!= RunspaceAvailability.Busy )&&(DynAbs.Tracing.TraceSender.Expression_True(1578, 39585, 39819)&&f_1578_39735_39783(((RemoteRunspace)_runspace))!= RunspaceAvailability.RemoteDebug))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,39581,40013);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,39987,39994);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,39581,40013);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,40033,40566) || true) && (currentPipeline == null &&(DynAbs.Tracing.TraceSender.Expression_True(1578, 40037, 40134)&&f_1578_40085_40126(((RemoteRunspace)_runspace))!= null )&&(DynAbs.Tracing.TraceSender.Expression_True(1578, 40037, 40182)&&                    _connectCmdInfo != null )&&(DynAbs.Tracing.TraceSender.Expression_True(1578, 40037, 40298)&&f_1578_40207_40298(f_1578_40219_40270(f_1578_40219_40260(((RemoteRunspace)_runspace))), f_1578_40272_40297(_connectCmdInfo))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,40033,40566);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,40540,40547);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,40033,40566);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,40586,40901) || true) && (currentPipeline != null &&(DynAbs.Tracing.TraceSender.Expression_True(1578, 40590, 40681)&&f_1578_40643_40681(currentPipeline, this)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,40586,40901);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,40875,40882);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,40586,40901);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,40921,41122) || true) && (!_isSteppable)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,40921,41122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,40980,41103);

throw f_1578_40986_41102(f_1578_41059_41101());
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,40921,41122);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,39525,41988);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,39525,41988);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,41188,41973) || true) && (_performNestedCheck)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,41188,41973);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,41253,41349) || true) && (_isSteppable)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,41253,41349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,41319,41326);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,41253,41349);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,41373,41593) || true) && (syncCall == false)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,41373,41593);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,41444,41570);

throw f_1578_41450_41569(f_1578_41527_41568());
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,41373,41593);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,41617,41954) || true) && (currentPipeline == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,41617,41954);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,41694,41931) || true) && (!_isSteppable)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1578,41694,41931);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,41769,41904);

throw f_1578_41775_41903(f_1578_41856_41902());
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,41694,41931);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,41617,41954);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,41188,41973);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1578,39525,41988);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,39314,41999);

System.Management.Automation.Runspaces.Pipeline
f_1578_39451_39508(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.GetCurrentlyRunningPipeline();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 39451, 39508);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceAvailability
f_1578_39633_39681(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspaceAvailability ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 39633, 39681);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceAvailability
f_1578_39735_39783(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspaceAvailability ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 39735, 39783);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
f_1578_40085_40126(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RemoteCommand ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 40085, 40126);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
f_1578_40219_40260(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RemoteCommand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 40219, 40260);
return return_v;
}


System.Guid
f_1578_40219_40270(System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
this_param)
{
var return_v = this_param.CommandId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 40219, 40270);
return return_v;
}


System.Guid
f_1578_40272_40297(System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
this_param)
{
var return_v = this_param.CommandId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 40272, 40297);
return return_v;
}


bool
f_1578_40207_40298(System.Guid
objA,System.Guid
objB)
{
var return_v = Guid.Equals( (object)objA, (object)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 40207, 40298);
return return_v;
}


bool
f_1578_40643_40681(System.Management.Automation.RemotePipeline
objA,System.Management.Automation.RemotePipeline
objB)
{
var return_v = ReferenceEquals( (object)objA, (object)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 40643, 40681);
return return_v;
}


string
f_1578_41059_41101()
{
var return_v =                             RunspaceStrings.ConcurrentInvokeNotAllowed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 41059, 41101);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1578_40986_41102(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 40986, 41102);
return return_v;
}


string
f_1578_41527_41568()
{
var return_v =                                 RunspaceStrings.NestedPipelineInvokeAsync;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 41527, 41568);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1578_41450_41569(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 41450, 41569);
return return_v;
}


string
f_1578_41856_41902()
{
var return_v =                                     RunspaceStrings.NestedPipelineNoParentPipeline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 41856, 41902);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1578_41775_41903(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 41775, 41903);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,39314,41999);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,39314,41999);
}
		}

internal PowerShell PowerShell
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,42214,42284);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,42250,42269);

return _powershell;
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,42214,42284);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,42159,42295);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,42159,42295);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override void SetHistoryString(string historyString)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,42495,42634);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,42581,42623);

_powershell.HistoryString = historyString;
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,42495,42634);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,42495,42634);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,42495,42634);
}
		}

internal override void SuspendIncomingData()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,42849,42963);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,42918,42952);

f_1578_42918_42951(            _powershell);
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,42849,42963);

int
f_1578_42918_42951(System.Management.Automation.PowerShell
this_param)
{
this_param.SuspendIncomingData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 42918, 42951);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,42849,42963);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,42849,42963);
}
		}

internal override void ResumeIncomingData()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,43076,43188);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,43144,43177);

f_1578_43144_43176(            _powershell);
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,43076,43188);

int
f_1578_43144_43176(System.Management.Automation.PowerShell
this_param)
{
this_param.ResumeIncomingData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 43144, 43176);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,43076,43188);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,43076,43188);
}
		}

internal override void DrainIncomingData()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1578,43344,43461);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1578,43411,43450);

f_1578_43411_43449(            _powershell);
DynAbs.Tracing.TraceSender.TraceExitMethod(1578,43344,43461);

int
f_1578_43411_43449(System.Management.Automation.PowerShell
this_param)
{
this_param.WaitForServicingComplete();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 43411, 43449);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1578,43344,43461);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,43344,43461);
}
		}

static RemotePipeline()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1578,592,43490);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1578,592,43490);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1578,592,43490);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1578,592,43490);

object
f_1578_895_907()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 895, 907);
return return_v;
}


System.Management.Automation.Runspaces.PipelineStateInfo
f_1578_1046_1093(System.Management.Automation.Runspaces.PipelineState
state)
{
var return_v = new System.Management.Automation.Runspaces.PipelineStateInfo( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 1046, 1093);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_1578_1142_1165()
{
var return_v = new System.Management.Automation.Runspaces.CommandCollection();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 1142, 1165);
return return_v;
}


System.Collections.Generic.Queue<System.Management.Automation.RemotePipeline.ExecutionEventQueueItem>
f_1578_1816_1852()
{
var return_v = new System.Collections.Generic.Queue<System.Management.Automation.RemotePipeline.ExecutionEventQueueItem>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 1816, 1852);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1578_3272_3314(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 3272, 3314);
return return_v;
}


string
f_1578_3272_3327(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 3272, 3327);
return return_v;
}


System.Guid
f_1578_3356_3376(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 3356, 3376);
return return_v;
}


System.Management.Automation.PSDataCollection<object>
f_1578_3447_3477()
{
var return_v = new System.Management.Automation.PSDataCollection<object>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 3447, 3477);
return return_v;
}


System.Management.Automation.Internal.PSDataCollectionStream<object>
f_1578_3568_3632(System.Guid
psInstanceId,System.Management.Automation.PSDataCollection<object>
storeToUse)
{
var return_v = new System.Management.Automation.Internal.PSDataCollectionStream<object>( psInstanceId, storeToUse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 3568, 3632);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
f_1578_3667_3699()
{
var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 3667, 3699);
return return_v;
}


System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.PSObject>
f_1578_3730_3797(System.Guid
psInstanceId,System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
storeToUse)
{
var return_v = new System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.PSObject>( psInstanceId, storeToUse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 3730, 3797);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
f_1578_3831_3866()
{
var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 3831, 3866);
return return_v;
}


System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.ErrorRecord>
f_1578_3896_3965(System.Guid
psInstanceId,System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
storeToUse)
{
var return_v = new System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.ErrorRecord>( psInstanceId, storeToUse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 3896, 3965);
return return_v;
}


System.Management.Automation.Internal.ObjectStream
f_1578_4071_4089()
{
var return_v = new System.Management.Automation.Internal.ObjectStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 4071, 4089);
return return_v;
}


int
f_1578_4158_4189(System.Management.Automation.RemotePipeline
this_param,System.Management.Automation.Runspaces.CommandCollection
commands)
{
this_param.SetCommandCollection( commands);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 4158, 4189);
return 0;
}


System.Threading.ManualResetEvent
f_1578_4714_4741(bool
initialState)
{
var return_v = new System.Threading.ManualResetEvent( initialState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 4714, 4741);
return return_v;
}


static System.Management.Automation.Runspaces.Runspace
f_1578_3074_3082_C(System.Management.Automation.Runspaces.Runspace
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1578, 2972, 4753);
return return_v;
}


System.Management.Automation.Runspaces.Command
f_1578_5522_5548(string
command,bool
isScript)
{
var return_v = new System.Management.Automation.Runspaces.Command( command, isScript);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 5522, 5548);
return return_v;
}


int
f_1578_5508_5549(System.Management.Automation.Runspaces.CommandCollection
this_param,System.Management.Automation.Runspaces.Command
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 5508, 5549);
return 0;
}


System.Management.Automation.Runspaces.RunspacePool
f_1578_5730_5770(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 5730, 5770);
return return_v;
}


System.Management.Automation.PowerShell
f_1578_5655_5771(System.Management.Automation.Internal.PSDataCollectionStream<object>
inputstream,System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.PSObject>
outputstream,System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.ErrorRecord>
errorstream,System.Management.Automation.Runspaces.RunspacePool
runspacePool)
{
var return_v = new System.Management.Automation.PowerShell( (System.Management.Automation.Internal.ObjectStreamBase)inputstream, (System.Management.Automation.Internal.ObjectStreamBase)outputstream, (System.Management.Automation.Internal.ObjectStreamBase)errorstream, runspacePool);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 5655, 5771);
return return_v;
}


int
f_1578_5788_5821(System.Management.Automation.PowerShell
this_param,bool
isNested)
{
this_param.SetIsNested( isNested);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 5788, 5821);
return 0;
}


static System.Management.Automation.RemoteRunspace
f_1578_5397_5405_C(System.Management.Automation.RemoteRunspace
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1578, 5278, 5985);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
f_1578_6390_6412(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RemoteCommand ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 6390, 6412);
return return_v;
}


string
f_1578_6490_6526()
{
var return_v = PipelineStrings.InvalidRemoteCommand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 6490, 6526);
return return_v;
}


System.InvalidOperationException
f_1578_6460_6527(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 6460, 6527);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
f_1578_6577_6599(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RemoteCommand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 6577, 6599);
return return_v;
}


string
f_1578_6628_6651(System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 6628, 6651);
return return_v;
}


int
f_1578_6614_6652(System.Management.Automation.Runspaces.CommandCollection
this_param,string
command)
{
this_param.Add( command);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 6614, 6652);
return 0;
}


int
f_1578_6723_6773(System.Management.Automation.RemotePipeline
this_param,System.Management.Automation.Runspaces.PipelineState
state,System.Exception
reason)
{
this_param.SetPipelineState( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 6723, 6773);
return 0;
}


System.Management.Automation.Runspaces.RunspacePool
f_1578_6953_6993(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 6953, 6993);
return return_v;
}


System.Management.Automation.PowerShell
f_1578_6861_6994(System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
connectCmdInfo,System.Management.Automation.Internal.PSDataCollectionStream<object>
inputstream,System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.PSObject>
outputstream,System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.ErrorRecord>
errorstream,System.Management.Automation.Runspaces.RunspacePool
runspacePool)
{
var return_v = new System.Management.Automation.PowerShell( connectCmdInfo, (System.Management.Automation.Internal.ObjectStreamBase)inputstream, (System.Management.Automation.Internal.ObjectStreamBase)outputstream, (System.Management.Automation.Internal.ObjectStreamBase)errorstream, runspacePool);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 6861, 6994);
return return_v;
}


static System.Management.Automation.RemoteRunspace
f_1578_6338_6346_C(System.Management.Automation.RemoteRunspace
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1578, 6269, 7159);
return return_v;
}


static System.Management.Automation.Runspaces.Runspace
f_1578_7560_7577(System.Management.Automation.RemotePipeline
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 7560, 7577);
return return_v;
}


static bool
f_1578_7592_7609(System.Management.Automation.RemotePipeline
this_param)
{
var return_v = this_param.IsNested;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 7592, 7609);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1578_7944_7994(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 7944, 7994);
return return_v;
}


System.Management.Automation.PSObjectDisposedException
f_1578_8088_8140(string
objectName)
{
var return_v = PSTraceSource.NewObjectDisposedException( objectName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 8088, 8140);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_1578_8308_8325(System.Management.Automation.RemotePipeline
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 8308, 8325);
return return_v;
}


System.Management.Automation.Runspaces.Command
f_1578_8375_8390(System.Management.Automation.Runspaces.Command
this_param)
{
var return_v = this_param.Clone();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 8375, 8390);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_1578_8475_8483()
{
var return_v = Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1578, 8475, 8483);
return return_v;
}


int
f_1578_8475_8494(System.Management.Automation.Runspaces.CommandCollection
this_param,System.Management.Automation.Runspaces.Command
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 8475, 8494);
return 0;
}


System.Management.Automation.Runspaces.CommandCollection
f_1578_8308_8325_I(System.Management.Automation.Runspaces.CommandCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1578, 8308, 8325);
return return_v;
}


static System.Management.Automation.RemoteRunspace
f_1578_7544_7577_C(System.Management.Automation.RemoteRunspace
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1578, 7476, 8521);
return return_v;
}

}
}
