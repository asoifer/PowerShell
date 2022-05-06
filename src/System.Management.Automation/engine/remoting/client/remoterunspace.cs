// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Runspaces.Internal;
using System.Management.Automation.Tracing;
using System.Security.Principal;
using System.Threading;
using Microsoft.PowerShell.Commands;

using Dbg = System.Management.Automation.Diagnostics;

#pragma warning disable 1634, 1691 // Stops compiler from warning about unknown warnings

namespace System.Management.Automation
{
internal class RemoteRunspace : Runspace, IDisposable
{
private List<RemotePipeline> _runningPipelines ;

private object _syncRoot ;

private RunspaceStateInfo _runspaceStateInfo ;

private bool _bSessionStateProxyCallInProgress ;

private RunspaceConnectionInfo _connectionInfo;

private RemoteDebugger _remoteDebugger;

private PSPrimitiveDictionary _applicationPrivateData;

private bool _disposed ;

private InvokeCommandCommand _currentInvokeCommand ;

private long _currentLocalPipelineId ;

private Queue<RunspaceEventQueueItem> _runspaceEventQueue ;
protected class RunspaceEventQueueItem
{
public RunspaceEventQueueItem(RunspaceStateInfo runspaceStateInfo, RunspaceAvailability currentAvailability, RunspaceAvailability newAvailability)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1579,2544,2919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,2960,2977);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,3020,3047);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,3090,3113);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,2723,2766);

this.RunspaceStateInfo = runspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,2784,2839);

this.CurrentRunspaceAvailability = currentAvailability;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,2857,2904);

this.NewRunspaceAvailability = newAvailability;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1579,2544,2919);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,2544,2919);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,2544,2919);
}
		}

public RunspaceStateInfo RunspaceStateInfo;

public RunspaceAvailability CurrentRunspaceAvailability;

public RunspaceAvailability NewRunspaceAvailability;

static RunspaceEventQueueItem()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1579,2481,3125);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1579,2481,3125);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,2481,3125);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1579,2481,3125);
}

private bool _bypassRunspaceStateCheck;

protected bool ByPassRunspaceStateCheck
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,3856,3940);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,3892,3925);

return _bypassRunspaceStateCheck;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,3856,3940);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,3792,4052);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,3792,4052);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,3956,4041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,3992,4026);

_bypassRunspaceStateCheck = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,3956,4041);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,3792,4052);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,3792,4052);
}
		}}

internal bool ShouldCloseOnPop {get; set; }

internal RemoteRunspace(TypeTable typeTable, RunspaceConnectionInfo connectionInfo, PSHost host, PSPrimitiveDictionary applicationArguments, string name = null, int id = -1)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1579,5568,6380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,1162,1208);
this._runningPipelines = f_1579_1182_1208();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,1234,1258);
this._syncRoot = f_1579_1246_1258();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,1295,1363);
this._runspaceStateInfo = f_1579_1316_1363(RunspaceState.BeforeOpen);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,1387,1428);
this._bSessionStateProxyCallInProgress = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,1470,1485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,1519,1534);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,1575,1598);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,1624,1641);
this._disposed = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,1811,1839);
this._currentInvokeCommand = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,1863,1890);
this._currentLocalPipelineId = 0;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,2411,2468);
this._runspaceEventQueue = f_1579_2433_2468();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,3452,3477);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,4236,4289);
this.ShouldCloseOnPop = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,10981,11048);
this.Version = f_1579_11024_11047();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,11150,11202);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,13004,13050);
this._createThreadOptions = PSThreadOptions.Default;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,13405,13454);
this._runspaceAvailability = RunspaceAvailability.None;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,15067,15137);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,15419,15432);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,18380,18424);
this.PSSessionId = -1;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,19085,19177);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,46797,46822);
this._sessionStateProxy = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,69491,69534);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,5766,5822);

f_1579_5766_5821(f_1579_5805_5820(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,5836,6048);

f_1579_5836_6047(PSEventId.RunspaceConstructor, PSOpcode.Constructor, PSTask.CreateRunspace, PSKeyword.UseAlwaysOperational, f_1579_6025_6035().ToString());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,6064,6112);

_connectionInfo = f_1579_6082_6111(connectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,6126,6181);

OriginalConnectionInfo = f_1579_6151_6180(connectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,6197,6296);

RunspacePool = f_1579_6212_6295(1, 1, typeTable, host, applicationArguments, connectionInfo, name);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,6312,6334);

this.PSSessionId = id;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,6350,6369);

f_1579_6350_6368(this);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1579,5568,6380);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,5568,6380);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,5568,6380);
}
		}

internal RemoteRunspace(RunspacePool runspacePool)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1579,6632,8788);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,1162,1208);
this._runningPipelines = f_1579_1182_1208();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,1234,1258);
this._syncRoot = f_1579_1246_1258();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,1295,1363);
this._runspaceStateInfo = f_1579_1316_1363(RunspaceState.BeforeOpen);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,1387,1428);
this._bSessionStateProxyCallInProgress = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,1470,1485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,1519,1534);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,1575,1598);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,1624,1641);
this._disposed = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,1811,1839);
this._currentInvokeCommand = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,1863,1890);
this._currentLocalPipelineId = 0;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,2411,2468);
this._runspaceEventQueue = f_1579_2433_2468();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,3452,3477);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,4236,4289);
this.ShouldCloseOnPop = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,10981,11048);
this.Version = f_1579_11024_11047();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,11150,11202);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,13004,13050);
this._createThreadOptions = PSThreadOptions.Default;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,13405,13454);
this._runspaceAvailability = RunspaceAvailability.None;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,15067,15137);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,15419,15432);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,18380,18424);
this.PSSessionId = -1;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,19085,19177);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,46797,46822);
this._sessionStateProxy = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,69491,69534);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,6853,7143) || true) && ((f_1579_6858_6898(f_1579_6858_6892(runspacePool))!= RunspacePoolState.Disconnected) ||(DynAbs.Tracing.TraceSender.Expression_False(1579, 6857, 7008)||                 !(f_1579_6957_6984(runspacePool)is WSManConnectionInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,6853,7143);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,7042,7128);

throw f_1579_7048_7127(f_1579_7091_7126());
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,6853,7143);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,7159,7187);

RunspacePool = runspacePool;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,7488,7547);

f_1579_7488_7546(f_1579_7488_7527(f_1579_7488_7500()), 1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,7561,7620);

f_1579_7561_7619(f_1579_7561_7600(f_1579_7561_7573()), 1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,7636,7697);

_connectionInfo = f_1579_7654_7696(f_1579_7654_7681(runspacePool));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,7808,7836);

f_1579_7808_7835(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,7904,7955);

f_1579_7904_7954(this, RunspaceState.Disconnected, null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,8259,8439);

_runspaceAvailability = (DynAbs.Tracing.TraceSender.Conditional_F1(1579, 8283, 8345)||((f_1579_8283_8345(f_1579_8283_8322(f_1579_8283_8295()))&&DynAbs.Tracing.TraceSender.Conditional_F2(1579, 8365, 8400))||DynAbs.Tracing.TraceSender.Conditional_F3(1579, 8403, 8438)))?                Runspaces.RunspaceAvailability.None :Runspaces.RunspaceAvailability.Busy;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,8455,8474);

f_1579_8455_8473(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,8490,8546);

f_1579_8490_8545(f_1579_8529_8544(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,8560,8777);

f_1579_8560_8776(PSEventId.RunspaceConstructor, PSOpcode.Constructor, PSTask.CreateRunspace, PSKeyword.UseAlwaysOperational, this.InstanceId.ToString());
DynAbs.Tracing.TraceSender.TraceExitConstructor(1579,6632,8788);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,6632,8788);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,6632,8788);
}
		}

private void SetEventHandlers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,8899,10061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,9128,9170);

this.InstanceId = f_1579_9146_9169(f_1579_9146_9158());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,9186,9274);

_eventManager = f_1579_9202_9273(f_1579_9227_9255(_connectionInfo), f_1579_9257_9272(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,9290,9420);

f_1579_9290_9302().StateChanged +=
                new EventHandler<RunspacePoolStateChangedEventArgs>(HandleRunspacePoolStateChanged);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,9434,9589);

f_1579_9434_9473(f_1579_9434_9446()).HostCallReceived +=
                new EventHandler<RemoteDataEventArgs<RemoteHostCall>>(HandleHostCallReceived);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,9603,9757);

f_1579_9603_9642(f_1579_9603_9615()).URIRedirectionReported +=
                new EventHandler<RemoteDataEventArgs<Uri>>(HandleURIDirectionReported);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,9771,9879);

f_1579_9771_9783().ForwardEvent +=
                new EventHandler<PSEventArgs>(HandleRunspacePoolForwardEvent);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,9895,10050);

f_1579_9895_9934(f_1579_9895_9907()).SessionCreateCompleted +=
                new EventHandler<CreateCompleteEventArgs>(HandleSessionCreateCompleted);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,8899,10061);

System.Management.Automation.Runspaces.RunspacePool
f_1579_9146_9158()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 9146, 9158);
return return_v;
}


System.Guid
f_1579_9146_9169(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 9146, 9169);
return return_v;
}


string
f_1579_9227_9255(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 9227, 9255);
return return_v;
}


System.Guid
f_1579_9257_9272(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 9257, 9272);
return return_v;
}


System.Management.Automation.PSRemoteEventManager
f_1579_9202_9273(string
computerName,System.Guid
runspaceId)
{
var return_v = new System.Management.Automation.PSRemoteEventManager( computerName, runspaceId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 9202, 9273);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_9290_9302()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 9290, 9302);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_9434_9446()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 9434, 9446);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_9434_9473(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 9434, 9473);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_9603_9615()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 9603, 9615);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_9603_9642(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 9603, 9642);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_9771_9783()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 9771, 9783);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_9895_9907()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 9895, 9907);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_9895_9934(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 9895, 9934);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,8899,10061);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,8899,10061);
}
		}

public override InitialSessionState InitialSessionState
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,10329,10495);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,10398,10447);

throw f_1579_10404_10446();
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,10329,10495);

System.Management.Automation.PSNotImplementedException
f_1579_10404_10446()
{
var return_v = PSTraceSource.NewNotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 10404, 10446);
return return_v;
}


#pragma warning restore 56503
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,10249,10506);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,10249,10506);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override JobManager JobManager
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,10699,10865);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,10768,10817);

throw f_1579_10774_10816();
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,10699,10865);

System.Management.Automation.PSNotImplementedException
f_1579_10774_10816()
{
var return_v = PSTraceSource.NewNotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 10774, 10816);
return return_v;
}


#pragma warning restore 56503
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,10637,10876);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,10637,10876);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override Version Version {get; }

internal Version ServerVersion {get; private set; }

public override RunspaceStateInfo RunspaceStateInfo
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,11408,11623);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,11450,11459);
                lock (_syncRoot)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,11555,11589);

return f_1579_11562_11588(_runspaceStateInfo);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,11408,11623);

System.Management.Automation.Runspaces.RunspaceStateInfo
f_1579_11562_11588(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.Clone();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 11562, 11588);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,11332,11634);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,11332,11634);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override PSThreadOptions ThreadOptions
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,12327,12406);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,12363,12391);

return _createThreadOptions;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,12327,12406);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,12257,12968);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,12257,12968);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,12422,12957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,12464,12473);
                lock (_syncRoot)
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,12515,12923) || true) && (value != _createThreadOptions)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,12515,12923);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,12598,12843) || true) && (f_1579_12602_12630(f_1579_12602_12624(this))!= RunspaceState.BeforeOpen)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,12598,12843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,12716,12816);

throw f_1579_12722_12815(f_1579_12756_12814(f_1579_12774_12813()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,12598,12843);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,12871,12900);

_createThreadOptions = value;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,12515,12923);
}
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,12422,12957);

System.Management.Automation.Runspaces.RunspaceStateInfo
f_1579_12602_12624(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 12602, 12624);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1579_12602_12630(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 12602, 12630);
return return_v;
}


string
f_1579_12774_12813()
{
var return_v = RunspaceStrings.ChangePropertyAfterOpen;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 12774, 12813);
return return_v;
}


string
f_1579_12756_12814(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 12756, 12814);
return return_v;
}


System.Management.Automation.Runspaces.InvalidRunspaceStateException
f_1579_12722_12815(string
message)
{
var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 12722, 12815);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,12257,12968);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,12257,12968);
}
		}}

private PSThreadOptions _createThreadOptions ;

public override RunspaceAvailability RunspaceAvailability
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,13252,13289);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,13258,13287);

return _runspaceAvailability;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,13252,13289);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,13170,13364);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,13170,13364);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
protected set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,13305,13353);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,13321,13351);

_runspaceAvailability = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,13305,13353);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,13170,13364);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,13170,13364);
}
		}}

private RunspaceAvailability _runspaceAvailability ;

        /// <summary>
        /// Event raised when RunspaceState changes.
        /// </summary>
        public override event EventHandler<RunspaceStateEventArgs> 
StateChanged
;

        /// <summary>
        /// Event raised when the availability of the Runspace changes.
        /// </summary>
        public override event EventHandler<RunspaceAvailabilityEventArgs> 
AvailabilityChanged
;

internal override bool HasAvailabilityChangedSubscribers
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,14087,14135);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,14093,14133);

return this.AvailabilityChanged != null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,14087,14135);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,14006,14146);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,14006,14146);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected override void OnAvailabilityChanged(RunspaceAvailabilityEventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,14256,14671);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,14359,14433);

EventHandler<RunspaceAvailabilityEventArgs> 
eh = this.AvailabilityChanged
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,14449,14660) || true) && (eh != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,14449,14660);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,14541,14553);

f_1579_14541_14552(eh, this, e);
                }
                catch (Exception)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,14590,14645);
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,14590,14645);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,14449,14660);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,14256,14671);

int
f_1579_14541_14552(System.EventHandler<System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs>
this_param,System.Management.Automation.RemoteRunspace
sender,System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs
e)
{
this_param.Invoke( (object)sender, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 14541, 14552);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,14256,14671);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,14256,14671);
}
		}

public override RunspaceConnectionInfo ConnectionInfo
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,14862,14936);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,14898,14921);

return _connectionInfo;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,14862,14936);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,14784,14947);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,14784,14947);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override RunspaceConnectionInfo OriginalConnectionInfo {get; }

public override PSEventManager Events
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,15295,15367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,15331,15352);

return _eventManager;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,15295,15367);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,15233,15378);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,15233,15378);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private PSRemoteEventManager _eventManager;

internal override ExecutionContext GetExecutionContext
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,15663,15763);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,15699,15748);

throw f_1579_15705_15747();
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,15663,15763);

System.Management.Automation.PSNotImplementedException
f_1579_15705_15747()
{
var return_v = PSTraceSource.NewNotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 15705, 15747);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,15584,15774);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,15584,15774);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override bool InNestedPrompt
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,15965,16085);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,16001,16014);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,15965,16085);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,15903,16096);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,15903,16096);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal ClientRemoteSession ClientRemoteSession
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,16631,16990);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,16711,16793);

return f_1579_16718_16792(f_1579_16718_16778(f_1579_16718_16757(f_1579_16718_16730())));
                }
                catch (InvalidRunspacePoolStateException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,16830,16975);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,16914,16956);

throw f_1579_16920_16955(e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,16830,16975);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,16631,16990);

System.Management.Automation.Runspaces.RunspacePool
f_1579_16718_16730()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 16718, 16730);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_16718_16757(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 16718, 16757);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1579_16718_16778(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 16718, 16778);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSession
f_1579_16718_16792(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param)
{
var return_v = this_param.RemoteSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 16718, 16792);
return return_v;
}


System.Management.Automation.Runspaces.InvalidRunspaceStateException
f_1579_16920_16955(System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
this_param)
{
var return_v = this_param.ToInvalidRunspaceStateException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 16920, 16955);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,16558,17001);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,16558,17001);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal ConnectCommandInfo RemoteCommand
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,17264,17934);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,17300,17440) || true) && (f_1579_17304_17359(f_1579_17304_17343(f_1579_17304_17316()))== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,17300,17440);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,17409,17421);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,17300,17440);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,17460,17610);

f_1579_17460_17609(f_1579_17471_17533(f_1579_17471_17526(f_1579_17471_17510(f_1579_17471_17483())))< 2, "RemoteRunspace should have no more than one remote running command.");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,17628,17919) || true) && (f_1579_17632_17694(f_1579_17632_17687(f_1579_17632_17671(f_1579_17632_17644())))> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,17628,17919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,17740,17806);

return f_1579_17747_17802(f_1579_17747_17786(f_1579_17747_17759()))[0];
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,17628,17919);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,17628,17919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,17888,17900);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,17628,17919);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,17264,17934);

System.Management.Automation.Runspaces.RunspacePool
f_1579_17304_17316()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 17304, 17316);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_17304_17343(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 17304, 17343);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ConnectCommandInfo[]
f_1579_17304_17359(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.ConnectCommands ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 17304, 17359);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_17471_17483()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 17471, 17483);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_17471_17510(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 17471, 17510);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ConnectCommandInfo[]
f_1579_17471_17526(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.ConnectCommands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 17471, 17526);
return return_v;
}


int
f_1579_17471_17533(System.Management.Automation.Runspaces.Internal.ConnectCommandInfo[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 17471, 17533);
return return_v;
}


int
f_1579_17460_17609(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 17460, 17609);
return 0;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_17632_17644()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 17632, 17644);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_17632_17671(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 17632, 17671);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ConnectCommandInfo[]
f_1579_17632_17687(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.ConnectCommands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 17632, 17687);
return return_v;
}


int
f_1579_17632_17694(System.Management.Automation.Runspaces.Internal.ConnectCommandInfo[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 17632, 17694);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_17747_17759()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 17747, 17759);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_17747_17786(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 17747, 17786);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ConnectCommandInfo[]
f_1579_17747_17802(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.ConnectCommands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 17747, 17802);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,17198,17945);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,17198,17945);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal string PSSessionName
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,18116,18176);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,18122,18174);

return f_1579_18129_18173(f_1579_18129_18168(f_1579_18129_18141()));
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,18116,18176);

System.Management.Automation.Runspaces.RunspacePool
f_1579_18129_18141()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 18129, 18141);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_18129_18168(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 18129, 18168);
return return_v;
}


string
f_1579_18129_18173(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 18129, 18173);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,18062,18264);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,18062,18264);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,18192,18253);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,18198,18251);

f_1579_18198_18237(f_1579_18198_18210()).Name = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,18192,18253);

System.Management.Automation.Runspaces.RunspacePool
f_1579_18198_18210()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 18198, 18210);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_18198_18237(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 18198, 18237);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,18062,18264);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,18062,18264);
}
		}}

internal int PSSessionId {get; set; }

internal bool CanDisconnect
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,18594,18663);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,18600,18661);

return f_1579_18607_18660(f_1579_18607_18646(f_1579_18607_18619()));
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,18594,18663);

System.Management.Automation.Runspaces.RunspacePool
f_1579_18607_18619()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 18607, 18619);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_18607_18646(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 18607, 18646);
return return_v;
}


bool
f_1579_18607_18660(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.CanDisconnect;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 18607, 18660);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,18542,18674);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,18542,18674);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool CanConnect
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,18838,18916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,18844,18914);

return f_1579_18851_18913(f_1579_18851_18890(f_1579_18851_18863()));
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,18838,18916);

System.Management.Automation.Runspaces.RunspacePool
f_1579_18851_18863()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 18851, 18863);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_18851_18890(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 18851, 18890);
return return_v;
}


bool
f_1579_18851_18913(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.AvailableForConnection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 18851, 18913);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,18789,18927);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,18789,18927);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool IsConfiguredLoopBack
{            get;
            set;
}

public override Debugger Debugger
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,19317,19391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,19353,19376);

return _remoteDebugger;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,19317,19391);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,19259,19402);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,19259,19402);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override void OpenAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,19698,20043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,19755,19783);

f_1579_19755_19782(this);

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,19835,19870);

f_1579_19835_19869(f_1579_19835_19847(), null, null);
            }
            catch (InvalidRunspacePoolStateException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,19899,20032);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,19975,20017);

throw f_1579_19981_20016(e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,19899,20032);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,19698,20043);

int
f_1579_19755_19782(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.AssertIfStateIsBeforeOpen();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 19755, 19782);
return 0;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_19835_19847()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 19835, 19847);
return return_v;
}


System.IAsyncResult
f_1579_19835_19869(System.Management.Automation.Runspaces.RunspacePool
this_param,System.AsyncCallback
callback,object
state)
{
var return_v = this_param.BeginOpen( callback, state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 19835, 19869);
return return_v;
}


System.Management.Automation.Runspaces.InvalidRunspaceStateException
f_1579_19981_20016(System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
this_param)
{
var return_v = this_param.ToInvalidRunspaceStateException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 19981, 20016);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,19698,20043);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,19698,20043);
}
		}

public override void Open()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,20281,20740);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,20333,20361);

f_1579_20333_20360(this);

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,20413,20461);

f_1579_20413_20425().ThreadOptions = f_1579_20442_20460(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,20479,20529);

f_1579_20479_20491().ApartmentState = f_1579_20509_20528(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,20547,20567);

f_1579_20547_20566(f_1579_20547_20559());
            }
            catch (InvalidRunspacePoolStateException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,20596,20729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,20672,20714);

throw f_1579_20678_20713(e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,20596,20729);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,20281,20740);

int
f_1579_20333_20360(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.AssertIfStateIsBeforeOpen();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 20333, 20360);
return 0;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_20413_20425()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 20413, 20425);
return return_v;
}


System.Management.Automation.Runspaces.PSThreadOptions
f_1579_20442_20460(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ThreadOptions;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 20442, 20460);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_20479_20491()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 20479, 20491);
return return_v;
}


System.Threading.ApartmentState
f_1579_20509_20528(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ApartmentState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 20509, 20528);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_20547_20559()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 20547, 20559);
return return_v;
}


int
f_1579_20547_20566(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
this_param.Open();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 20547, 20566);
return 0;
}


System.Management.Automation.Runspaces.InvalidRunspaceStateException
f_1579_20678_20713(System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
this_param)
{
var return_v = this_param.ToInvalidRunspaceStateException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 20678, 20713);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,20281,20740);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,20281,20740);
}
		}

public override void CloseAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,20899,21202);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,20993,21029);

f_1579_20993_21028(f_1579_20993_21005(), null, null);
            }
            catch (InvalidRunspacePoolStateException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,21058,21191);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,21134,21176);

throw f_1579_21140_21175(e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,21058,21191);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,20899,21202);

System.Management.Automation.Runspaces.RunspacePool
f_1579_20993_21005()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 20993, 21005);
return return_v;
}


System.IAsyncResult
f_1579_20993_21028(System.Management.Automation.Runspaces.RunspacePool
this_param,System.AsyncCallback
callback,object
state)
{
var return_v = this_param.BeginClose( callback, state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 20993, 21028);
return return_v;
}


System.Management.Automation.Runspaces.InvalidRunspaceStateException
f_1579_21140_21175(System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
this_param)
{
var return_v = this_param.ToInvalidRunspaceStateException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 21140, 21175);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,20899,21202);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,20899,21202);
}
		}

public override void Close()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,21431,22109);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,21520,21578);

IAsyncResult 
result = f_1579_21542_21577(f_1579_21542_21554(), null, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,21598,21625);

f_1579_21598_21624(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,21827,21936) || true) && (result != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,21827,21936);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,21887,21917);

f_1579_21887_21916(f_1579_21887_21899(), result);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,21827,21936);
}
            }
            catch (InvalidRunspacePoolStateException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,21965,22098);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,22041,22083);

throw f_1579_22047_22082(e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,21965,22098);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,21431,22109);

System.Management.Automation.Runspaces.RunspacePool
f_1579_21542_21554()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 21542, 21554);
return return_v;
}


System.IAsyncResult
f_1579_21542_21577(System.Management.Automation.Runspaces.RunspacePool
this_param,System.AsyncCallback
callback,object
state)
{
var return_v = this_param.BeginClose( callback, state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 21542, 21577);
return return_v;
}


bool
f_1579_21598_21624(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.WaitForFinishofPipelines();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 21598, 21624);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_21887_21899()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 21887, 21899);
return return_v;
}


int
f_1579_21887_21916(System.Management.Automation.Runspaces.RunspacePool
this_param,System.IAsyncResult
asyncResult)
{
this_param.EndClose( asyncResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 21887, 21916);
return 0;
}


System.Management.Automation.Runspaces.InvalidRunspaceStateException
f_1579_22047_22082(System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
this_param)
{
var return_v = this_param.ToInvalidRunspaceStateException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 22047, 22082);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,21431,22109);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,21431,22109);
}
		}

protected override void Dispose(bool disposing)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,22278,25067);
            try
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,22386,22467) || true) && (_disposed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,22386,22467);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,22441,22448);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,22386,22467);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,22493,22502);

                lock (_syncRoot)
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,22544,22637) || true) && (_disposed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,22544,22637);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,22607,22614);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,22544,22637);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,22661,22678);

_disposed = true;
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,22717,24948) || true) && (disposing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,22717,24948);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,22824,22832);

f_1579_22824_22831(this);
                    }
                    catch (PSRemotingTransportException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,22877,23395);
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,22877,23395);
                        //
                        // If the WinRM listener has been removed before the runspace is closed, then calling
                        // Close() will cause a PSRemotingTransportException.  We don't want this exception
                        // surfaced.  Most developers don't expect an exception from calling Dispose.
                        // See [Windows 8 Bugs] 968184.
                        //
                    }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,23419,23621) || true) && (_remoteDebugger != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,23419,23621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,23572,23598);

f_1579_23572_23597(                        // Release RunspacePool event forwarding handlers.
                        _remoteDebugger);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,23419,23621);
}

                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,23697,23851);

f_1579_23697_23709().StateChanged -=
                                        new EventHandler<RunspacePoolStateChangedEventArgs>(HandleRunspacePoolStateChanged);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,23877,24044);

f_1579_23877_23916(f_1579_23877_23889()).HostCallReceived -=
                            new EventHandler<RemoteDataEventArgs<RemoteHostCall>>(HandleHostCallReceived);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,24070,24236);

f_1579_24070_24109(f_1579_24070_24082()).URIRedirectionReported -=
                            new EventHandler<RemoteDataEventArgs<Uri>>(HandleURIDirectionReported);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,24262,24382);

f_1579_24262_24274().ForwardEvent -=
                            new EventHandler<PSEventArgs>(HandleRunspacePoolForwardEvent);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,24410,24577);

f_1579_24410_24449(f_1579_24410_24422()).SessionCreateCompleted -=
                            new EventHandler<CreateCompleteEventArgs>(HandleSessionCreateCompleted);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,24605,24626);

_eventManager = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,24654,24677);

f_1579_24654_24676(f_1579_24654_24666());
                        // _runspacePool = null;
                    }
                    catch (InvalidRunspacePoolStateException e)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,24772,24929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,24864,24906);

throw f_1579_24870_24905(e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,24772,24929);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,22717,24948);
}
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1579,24977,25056);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,25017,25041);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(disposing),1579,25017,25040);
DynAbs.Tracing.TraceSender.TraceExitFinally(1579,24977,25056);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,22278,25067);

int
f_1579_22824_22831(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 22824, 22831);
return 0;
}


int
f_1579_23572_23597(System.Management.Automation.RemoteDebugger
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 23572, 23597);
return 0;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_23697_23709()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 23697, 23709);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_23877_23889()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 23877, 23889);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_23877_23916(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 23877, 23916);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_24070_24082()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 24070, 24082);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_24070_24109(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 24070, 24109);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_24262_24274()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 24262, 24274);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_24410_24422()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 24410, 24422);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_24410_24449(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 24410, 24449);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_24654_24666()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 24654, 24666);
return return_v;
}


int
f_1579_24654_24676(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 24654, 24676);
return 0;
}


System.Management.Automation.Runspaces.InvalidRunspaceStateException
f_1579_24870_24905(System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
this_param)
{
var return_v = this_param.ToInvalidRunspaceStateException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 24870, 24905);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,22278,25067);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,22278,25067);
}
		}

public override void ResetRunspaceState()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,25658,26829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,25724,25776);

PSInvalidOperationException 
invalidOperation = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,25792,26637) || true) && (f_1579_25796_25824(f_1579_25796_25818(this))!= Runspaces.RunspaceState.Opened)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,25792,26637);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,25892,26052);

invalidOperation = f_1579_25911_26051(f_1579_25980_26020(), f_1579_26022_26050(f_1579_26022_26044(this)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,25792,26637);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,25792,26637);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,26086,26637) || true) && (f_1579_26090_26115(this)!= Runspaces.RunspaceAvailability.Available)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,26086,26637);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,26193,26325);

invalidOperation = f_1579_26212_26324(f_1579_26281_26323());
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,26086,26637);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,26086,26637);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,26391,26467);

bool 
success = f_1579_26406_26466(f_1579_26406_26445(f_1579_26406_26418()))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,26485,26622) || true) && (!success)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,26485,26622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,26539,26603);

invalidOperation = f_1579_26558_26602();
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,26485,26622);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,26086,26637);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,25792,26637);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,26653,26818) || true) && (invalidOperation != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,26653,26818);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,26715,26762);

invalidOperation.Source = "ResetRunspaceState";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,26780,26803);

throw invalidOperation;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,26653,26818);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,25658,26829);

System.Management.Automation.Runspaces.RunspaceStateInfo
f_1579_25796_25818(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 25796, 25818);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1579_25796_25824(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 25796, 25824);
return return_v;
}


string
f_1579_25980_26020()
{
var return_v =                         RunspaceStrings.RunspaceNotInOpenedState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 25980, 26020);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1579_26022_26044(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 26022, 26044);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1579_26022_26050(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 26022, 26050);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1579_25911_26051(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 25911, 26051);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceAvailability
f_1579_26090_26115(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspaceAvailability ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 26090, 26115);
return return_v;
}


string
f_1579_26281_26323()
{
var return_v =                         RunspaceStrings.ConcurrentInvokeNotAllowed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 26281, 26323);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1579_26212_26324(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 26212, 26324);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_26406_26418()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 26406, 26418);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_26406_26445(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 26406, 26445);
return return_v;
}


bool
f_1579_26406_26466(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.ResetRunspaceState();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 26406, 26466);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1579_26558_26602()
{
var return_v = PSTraceSource.NewInvalidOperationException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 26558, 26602);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,25658,26829);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,25658,26829);
}
		}

internal static Runspace[] GetRemoteRunspaces(RunspaceConnectionInfo connectionInfo, PSHost host, TypeTable typeTable)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1579,27606,28587);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,27749,27797);

List<Runspace> 
runspaces = f_1579_27776_27796()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,27811,27925);

RunspacePool[] 
runspacePools = f_1579_27842_27924(connectionInfo, host, typeTable)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,28254,28533);
foreach(RunspacePool runspacePool in f_1579_28292_28305_I(runspacePools) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,28254,28533);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,28339,28518) || true) && (f_1579_28343_28405(f_1579_28343_28398(f_1579_28343_28382(runspacePool)))< 2)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,28339,28518);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,28451,28499);

f_1579_28451_28498(                    runspaces, f_1579_28465_28497(runspacePool));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,28339,28518);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,28254,28533);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1579,1,280);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1579,1,280);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,28549,28576);

return f_1579_28556_28575(runspaces);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1579,27606,28587);

System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>
f_1579_27776_27796()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 27776, 27796);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool[]
f_1579_27842_27924(System.Management.Automation.Runspaces.RunspaceConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Runspaces.TypeTable
typeTable)
{
var return_v = RemoteRunspacePoolInternal.GetRemoteRunspacePools( connectionInfo, host, typeTable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 27842, 27924);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_28343_28382(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 28343, 28382);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ConnectCommandInfo[]
f_1579_28343_28398(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.ConnectCommands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 28343, 28398);
return return_v;
}


int
f_1579_28343_28405(System.Management.Automation.Runspaces.Internal.ConnectCommandInfo[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 28343, 28405);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1579_28465_28497(System.Management.Automation.Runspaces.RunspacePool
runspacePool)
{
var return_v = new System.Management.Automation.RemoteRunspace( runspacePool);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 28465, 28497);
return return_v;
}


int
f_1579_28451_28498(System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>
this_param,System.Management.Automation.RemoteRunspace
item)
{
this_param.Add( (System.Management.Automation.Runspaces.Runspace)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 28451, 28498);
return 0;
}


System.Management.Automation.Runspaces.RunspacePool[]
f_1579_28292_28305_I(System.Management.Automation.Runspaces.RunspacePool[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 28292, 28305);
return return_v;
}


System.Management.Automation.Runspaces.Runspace[]
f_1579_28556_28575(System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 28556, 28575);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,27606,28587);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,27606,28587);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static Runspace GetRemoteRunspace(RunspaceConnectionInfo connectionInfo, Guid sessionId, Guid? commandId, PSHost host, TypeTable typeTable)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1579,29220,29678);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,29393,29611);

RunspacePool 
runspacePool = f_1579_29421_29610(connectionInfo, sessionId, commandId, host, typeTable)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,29627,29667);

return f_1579_29634_29666(runspacePool);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1579,29220,29678);

System.Management.Automation.Runspaces.RunspacePool
f_1579_29421_29610(System.Management.Automation.Runspaces.RunspaceConnectionInfo
connectionInfo,System.Guid
sessionId,System.Guid?
commandId,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Runspaces.TypeTable
typeTable)
{
var return_v = RemoteRunspacePoolInternal.GetRemoteRunspacePool( connectionInfo, sessionId, commandId, host, typeTable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 29421, 29610);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1579_29634_29666(System.Management.Automation.Runspaces.RunspacePool
runspacePool)
{
var return_v = new System.Management.Automation.RemoteRunspace( runspacePool);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 29634, 29666);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,29220,29678);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,29220,29678);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override void Disconnect()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,30553,31072);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,30611,30775) || true) && (f_1579_30615_30629_M(!CanDisconnect))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,30611,30775);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,30663,30760);

throw f_1579_30669_30759(f_1579_30712_30758());
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,30611,30775);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,30791,30821);

f_1579_30791_30820(this);

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,30873,30899);

f_1579_30873_30898(f_1579_30873_30885());
            }
            catch (InvalidRunspacePoolStateException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,30928,31061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,31004,31046);

throw f_1579_31010_31045(e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,30928,31061);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,30553,31072);

bool
f_1579_30615_30629_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 30615, 30629);
return return_v;
}


string
f_1579_30712_30758()
{
var return_v = RunspaceStrings.DisconnectNotSupportedOnServer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 30712, 30758);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1579_30669_30759(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 30669, 30759);
return return_v;
}


int
f_1579_30791_30820(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.UpdatePoolDisconnectOptions();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 30791, 30820);
return 0;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_30873_30885()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 30873, 30885);
return return_v;
}


int
f_1579_30873_30898(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
this_param.Disconnect();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 30873, 30898);
return 0;
}


System.Management.Automation.Runspaces.InvalidRunspaceStateException
f_1579_31010_31045(System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
this_param)
{
var return_v = this_param.ToInvalidRunspaceStateException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 31010, 31045);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,30553,31072);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,30553,31072);
}
		}

public override void DisconnectAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,31948,32487);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,32011,32175) || true) && (f_1579_32015_32029_M(!CanDisconnect))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,32011,32175);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,32063,32160);

throw f_1579_32069_32159(f_1579_32112_32158());
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,32011,32175);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,32191,32221);

f_1579_32191_32220(this);

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,32273,32314);

f_1579_32273_32313(f_1579_32273_32285(), null, null);
            }
            catch (InvalidRunspacePoolStateException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,32343,32476);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,32419,32461);

throw f_1579_32425_32460(e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,32343,32476);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,31948,32487);

bool
f_1579_32015_32029_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 32015, 32029);
return return_v;
}


string
f_1579_32112_32158()
{
var return_v = RunspaceStrings.DisconnectNotSupportedOnServer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 32112, 32158);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1579_32069_32159(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 32069, 32159);
return return_v;
}


int
f_1579_32191_32220(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.UpdatePoolDisconnectOptions();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 32191, 32220);
return 0;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_32273_32285()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 32273, 32285);
return return_v;
}


System.IAsyncResult
f_1579_32273_32313(System.Management.Automation.Runspaces.RunspacePool
this_param,System.AsyncCallback
callback,object
state)
{
var return_v = this_param.BeginDisconnect( callback, state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 32273, 32313);
return return_v;
}


System.Management.Automation.Runspaces.InvalidRunspaceStateException
f_1579_32425_32460(System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
this_param)
{
var return_v = this_param.ToInvalidRunspaceStateException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 32425, 32460);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,31948,32487);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,31948,32487);
}
		}

public override void Connect()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,33115,33608);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,33170,33314) || true) && (f_1579_33174_33185_M(!CanConnect))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,33170,33314);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,33219,33299);

throw f_1579_33225_33298(f_1579_33268_33297());
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,33170,33314);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,33330,33360);

f_1579_33330_33359(this);

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,33412,33435);

f_1579_33412_33434(f_1579_33412_33424());
            }
            catch (InvalidRunspacePoolStateException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,33464,33597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,33540,33582);

throw f_1579_33546_33581(e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,33464,33597);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,33115,33608);

bool
f_1579_33174_33185_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 33174, 33185);
return return_v;
}


string
f_1579_33268_33297()
{
var return_v = RunspaceStrings.CannotConnect;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 33268, 33297);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1579_33225_33298(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 33225, 33298);
return return_v;
}


int
f_1579_33330_33359(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.UpdatePoolDisconnectOptions();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 33330, 33359);
return 0;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_33412_33424()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 33412, 33424);
return return_v;
}


int
f_1579_33412_33434(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
this_param.Connect();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 33412, 33434);
return 0;
}


System.Management.Automation.Runspaces.InvalidRunspaceStateException
f_1579_33546_33581(System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
this_param)
{
var return_v = this_param.ToInvalidRunspaceStateException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 33546, 33581);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,33115,33608);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,33115,33608);
}
		}

public override void ConnectAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,34235,34748);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,34295,34439) || true) && (f_1579_34299_34310_M(!CanConnect))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,34295,34439);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,34344,34424);

throw f_1579_34350_34423(f_1579_34393_34422());
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,34295,34439);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,34455,34485);

f_1579_34455_34484(this);

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,34537,34575);

f_1579_34537_34574(f_1579_34537_34549(), null, null);
            }
            catch (InvalidRunspacePoolStateException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,34604,34737);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,34680,34722);

throw f_1579_34686_34721(e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,34604,34737);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,34235,34748);

bool
f_1579_34299_34310_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 34299, 34310);
return return_v;
}


string
f_1579_34393_34422()
{
var return_v = RunspaceStrings.CannotConnect;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 34393, 34422);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1579_34350_34423(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 34350, 34423);
return return_v;
}


int
f_1579_34455_34484(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.UpdatePoolDisconnectOptions();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 34455, 34484);
return 0;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_34537_34549()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 34537, 34549);
return return_v;
}


System.IAsyncResult
f_1579_34537_34574(System.Management.Automation.Runspaces.RunspacePool
this_param,System.AsyncCallback
callback,object
state)
{
var return_v = this_param.BeginConnect( callback, state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 34537, 34574);
return return_v;
}


System.Management.Automation.Runspaces.InvalidRunspaceStateException
f_1579_34686_34721(System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
this_param)
{
var return_v = this_param.ToInvalidRunspaceStateException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 34686, 34721);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,34235,34748);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,34235,34748);
}
		}

public override Pipeline CreateDisconnectedPipeline()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,35041,35340);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,35119,35281) || true) && (f_1579_35123_35136()== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,35119,35281);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,35178,35266);

throw f_1579_35184_35265(f_1579_35227_35264());
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,35119,35281);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,35297,35329);

return f_1579_35304_35328(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,35041,35340);

System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
f_1579_35123_35136()
{
var return_v = RemoteCommand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 35123, 35136);
return return_v;
}


string
f_1579_35227_35264()
{
var return_v = RunspaceStrings.NoDisconnectedCommand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 35227, 35264);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1579_35184_35265(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 35184, 35265);
return return_v;
}


System.Management.Automation.RemotePipeline
f_1579_35304_35328(System.Management.Automation.RemoteRunspace
runspace)
{
var return_v = new System.Management.Automation.RemotePipeline( runspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 35304, 35328);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,35041,35340);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,35041,35340);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override PowerShell CreateDisconnectedPowerShell()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,35637,35951);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,35719,35881) || true) && (f_1579_35723_35736()== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,35719,35881);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,35778,35866);

throw f_1579_35784_35865(f_1579_35827_35864());
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,35719,35881);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,35897,35940);

return f_1579_35904_35939(f_1579_35919_35932(), this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,35637,35951);

System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
f_1579_35723_35736()
{
var return_v = RemoteCommand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 35723, 35736);
return return_v;
}


string
f_1579_35827_35864()
{
var return_v = RunspaceStrings.NoDisconnectedCommand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 35827, 35864);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1579_35784_35865(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 35784, 35865);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
f_1579_35919_35932()
{
var return_v = RemoteCommand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 35919, 35932);
return return_v;
}


System.Management.Automation.PowerShell
f_1579_35904_35939(System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
connectCmdInfo,System.Management.Automation.RemoteRunspace
rsConnection)
{
var return_v = new System.Management.Automation.PowerShell( connectCmdInfo, (object)rsConnection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 35904, 35939);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,35637,35951);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,35637,35951);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override RunspaceCapability GetCapabilities()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,36106,37313);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,36183,36242);

RunspaceCapability 
returnCaps = RunspaceCapability.Default
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,36258,36376) || true) && (f_1579_36262_36275())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,36258,36376);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,36309,36361);

returnCaps |= RunspaceCapability.SupportsDisconnect;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,36258,36376);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,36392,37268) || true) && (_connectionInfo is NamedPipeConnectionInfo)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,36392,37268);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,36472,36524);

returnCaps |= RunspaceCapability.NamedPipeTransport;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,36392,37268);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,36392,37268);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,36558,37268) || true) && (_connectionInfo is VMConnectionInfo)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,36558,37268);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,36631,36682);

returnCaps |= RunspaceCapability.VMSocketTransport;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,36558,37268);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,36558,37268);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,36716,37268) || true) && (_connectionInfo is SSHConnectionInfo)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,36716,37268);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,36790,36836);

returnCaps |= RunspaceCapability.SSHTransport;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,36716,37268);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,36716,37268);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,36902,36995);

ContainerConnectionInfo 
containerConnectionInfo = _connectionInfo as ContainerConnectionInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,37015,37253) || true) && ((containerConnectionInfo != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1579, 37019, 37140)&&                    (f_1579_37078_37125(f_1579_37078_37115(containerConnectionInfo))== Guid.Empty)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,37015,37253);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,37182,37234);

returnCaps |= RunspaceCapability.NamedPipeTransport;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,37015,37253);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,36716,37268);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,36558,37268);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,36392,37268);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,37284,37302);

return returnCaps;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,36106,37313);

bool
f_1579_36262_36275()
{
var return_v = CanDisconnect;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 36262, 36275);
return return_v;
}


System.Management.Automation.Runspaces.ContainerProcess
f_1579_37078_37115(System.Management.Automation.Runspaces.ContainerConnectionInfo
this_param)
{
var return_v = this_param.ContainerProc;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 37078, 37115);
return return_v;
}


System.Guid
f_1579_37078_37125(System.Management.Automation.Runspaces.ContainerProcess
this_param)
{
var return_v = this_param.RuntimeId ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 37078, 37125);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,36106,37313);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,36106,37313);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void UpdatePoolDisconnectOptions()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,37524,38265);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,37591,37692);

WSManConnectionInfo 
runspaceWSManConnectionInfo = f_1579_37641_37668(f_1579_37641_37653())as WSManConnectionInfo
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,37706,37786);

WSManConnectionInfo 
wsManConnectionInfo = f_1579_37748_37762()as WSManConnectionInfo
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,37802,37928);

f_1579_37802_37927(runspaceWSManConnectionInfo != null, "Disconnect-Connect feature is currently only supported for WSMan transport");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,37942,38060);

f_1579_37942_38059(wsManConnectionInfo != null, "Disconnect-Connect feature is currently only supported for WSMan transport");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,38076,38150);

runspaceWSManConnectionInfo.IdleTimeout = f_1579_38118_38149(wsManConnectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,38164,38254);

runspaceWSManConnectionInfo.OutputBufferingMode = f_1579_38214_38253(wsManConnectionInfo);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,37524,38265);

System.Management.Automation.Runspaces.RunspacePool
f_1579_37641_37653()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 37641, 37653);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1579_37641_37668(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.ConnectionInfo ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 37641, 37668);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1579_37748_37762()
{
var return_v = ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 37748, 37762);
return return_v;
}


int
f_1579_37802_37927(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 37802, 37927);
return 0;
}


int
f_1579_37942_38059(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 37942, 38059);
return 0;
}


int
f_1579_38118_38149(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.IdleTimeout;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 38118, 38149);
return return_v;
}


System.Management.Automation.Runspaces.OutputBufferingMode
f_1579_38214_38253(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.OutputBufferingMode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 38214, 38253);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,37524,38265);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,37524,38265);
}
		}

        
        
        /// <summary>
        /// Remote DebuggerStop event.
        /// </summary>
        internal event EventHandler<PSEventArgs> 
RemoteDebuggerStop
;

        /// <summary>
        /// Remote BreakpointUpdated event.
        /// </summary>
        internal event EventHandler<PSEventArgs> 
RemoteDebuggerBreakpointUpdated
;

public override Pipeline CreatePipeline()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,38864,38987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,38930,38976);

return f_1579_38937_38975(this, null, false, false);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,38864,38987);

System.Management.Automation.Runspaces.Pipeline
f_1579_38937_38975(System.Management.Automation.RemoteRunspace
this_param,string
command,bool
addToHistory,bool
isNested)
{
var return_v = this_param.CoreCreatePipeline( command, addToHistory, isNested);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 38937, 38975);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,38864,38987);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,38864,38987);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override Pipeline CreatePipeline(string command)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,39400,39680);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,39480,39604) || true) && (command == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,39480,39604);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,39533,39589);

throw f_1579_39539_39588("command");
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,39480,39604);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,39620,39669);

return f_1579_39627_39668(this, command, false, false);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,39400,39680);

System.Management.Automation.PSArgumentNullException
f_1579_39539_39588(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 39539, 39588);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1579_39627_39668(System.Management.Automation.RemoteRunspace
this_param,string
command,bool
addToHistory,bool
isNested)
{
var return_v = this_param.CoreCreatePipeline( command, addToHistory, isNested);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 39627, 39668);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,39400,39680);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,39400,39680);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override Pipeline CreatePipeline(string command, bool addToHistory)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,40178,40484);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,40277,40401) || true) && (command == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,40277,40401);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,40330,40386);

throw f_1579_40336_40385("command");
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,40277,40401);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,40417,40473);

return f_1579_40424_40472(this, command, addToHistory, false);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,40178,40484);

System.Management.Automation.PSArgumentNullException
f_1579_40336_40385(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 40336, 40385);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1579_40424_40472(System.Management.Automation.RemoteRunspace
this_param,string
command,bool
addToHistory,bool
isNested)
{
var return_v = this_param.CoreCreatePipeline( command, addToHistory, isNested);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 40424, 40472);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,40178,40484);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,40178,40484);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override Pipeline CreateNestedPipeline()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,40978,41106);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,41050,41095);

return f_1579_41057_41094(this, null, false, true);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,40978,41106);

System.Management.Automation.Runspaces.Pipeline
f_1579_41057_41094(System.Management.Automation.RemoteRunspace
this_param,string
command,bool
addToHistory,bool
isNested)
{
var return_v = this_param.CoreCreatePipeline( command, addToHistory, isNested);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 41057, 41094);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,40978,41106);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,40978,41106);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override Pipeline CreateNestedPipeline(string command, bool addToHistory)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,41597,41908);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,41702,41826) || true) && (command == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,41702,41826);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,41755,41811);

throw f_1579_41761_41810("command");
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,41702,41826);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,41842,41897);

return f_1579_41849_41896(this, command, addToHistory, true);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,41597,41908);

System.Management.Automation.PSArgumentNullException
f_1579_41761_41810(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 41761, 41810);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1579_41849_41896(System.Management.Automation.RemoteRunspace
this_param,string
command,bool
addToHistory,bool
isNested)
{
var return_v = this_param.CoreCreatePipeline( command, addToHistory, isNested);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 41849, 41896);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,41597,41908);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,41597,41908);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void AddToRunningPipelineList(RemotePipeline pipeline)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,42560,44036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,42648,42717);

f_1579_42648_42716(pipeline != null, "caller should validate the parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,42739,42748);

            lock (_syncRoot)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,42782,43733) || true) && (_bypassRunspaceStateCheck == false &&(DynAbs.Tracing.TraceSender.Expression_True(1579, 42786, 42893)&&f_1579_42845_42869(_runspaceStateInfo)!= RunspaceState.Opened )&&(DynAbs.Tracing.TraceSender.Expression_True(1579, 42786, 42972)&&f_1579_42918_42942(_runspaceStateInfo)!= RunspaceState.Disconnected))
) // Disconnected runspaces can have running pipelines.

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,42782,43733);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,43068,43512);

InvalidRunspaceStateException 
e =
f_1579_43127_43511(f_1579_43217_43378(f_1579_43235_43277(), f_1579_43312_43347(f_1579_43312_43336(_runspaceStateInfo))), f_1579_43409_43433(_runspaceStateInfo), RunspaceState.Opened)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,43534,43682) || true) && (f_1579_43538_43557(this)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,43534,43682);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,43615,43659);

e.Source = f_1579_43626_43658(f_1579_43626_43645(this));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,43534,43682);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,43706,43714);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,42782,43733);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,43978,44010);

f_1579_43978_44009(
                // Add the pipeline to list of Executing pipeline.
                // Note:_runningPipelines is always accessed with the lock so
                // there is no need to create a synchronized version of list
                _runningPipelines, pipeline);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,42560,44036);

int
f_1579_42648_42716(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 42648, 42716);
return 0;
}


System.Management.Automation.Runspaces.RunspaceState
f_1579_42845_42869(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 42845, 42869);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1579_42918_42942(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 42918, 42942);
return return_v;
}


string
f_1579_43235_43277()
{
var return_v = RunspaceStrings.RunspaceNotOpenForPipeline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 43235, 43277);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1579_43312_43336(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 43312, 43336);
return return_v;
}


string
f_1579_43312_43347(System.Management.Automation.Runspaces.RunspaceState
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 43312, 43347);
return return_v;
}


string
f_1579_43217_43378(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 43217, 43378);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1579_43409_43433(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 43409, 43433);
return return_v;
}


System.Management.Automation.Runspaces.InvalidRunspaceStateException
f_1579_43127_43511(string
message,System.Management.Automation.Runspaces.RunspaceState
currentState,System.Management.Automation.Runspaces.RunspaceState
expectedState)
{
var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException( message, currentState, expectedState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 43127, 43511);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1579_43538_43557(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 43538, 43557);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1579_43626_43645(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 43626, 43645);
return return_v;
}


string
f_1579_43626_43658(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 43626, 43658);
return return_v;
}


int
f_1579_43978_44009(System.Collections.Generic.List<System.Management.Automation.RemotePipeline>
this_param,System.Management.Automation.RemotePipeline
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 43978, 44009);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,42560,44036);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,42560,44036);
}
		}

internal void RemoveFromRunningPipelineList(RemotePipeline pipeline)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,44421,45170);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,44514,44583);

f_1579_44514_44582(pipeline != null, "caller should validate the parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,44605,44614);

            lock (_syncRoot)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,44648,44806);

f_1579_44648_44805(f_1579_44659_44683(_runspaceStateInfo)!= RunspaceState.BeforeOpen, "Runspace should not be before open when pipeline is running");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,45054,45089);

f_1579_45054_45088(
                // Remove the pipeline to list of Executing pipeline.
                // Note:_runningPipelines is always accessed with the lock so
                // there is no need to create a synchronized version of list
                _runningPipelines, pipeline);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,45107,45144);

f_1579_45107_45143(f_1579_45107_45137(pipeline));
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,44421,45170);

int
f_1579_44514_44582(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 44514, 44582);
return 0;
}


System.Management.Automation.Runspaces.RunspaceState
f_1579_44659_44683(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 44659, 44683);
return return_v;
}


int
f_1579_44648_44805(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 44648, 44805);
return 0;
}


bool
f_1579_45054_45088(System.Collections.Generic.List<System.Management.Automation.RemotePipeline>
this_param,System.Management.Automation.RemotePipeline
item)
{
var return_v = this_param.Remove( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 45054, 45088);
return return_v;
}


System.Threading.ManualResetEvent
f_1579_45107_45137(System.Management.Automation.RemotePipeline
this_param)
{
var return_v = this_param.PipelineFinishedEvent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 45107, 45137);
return return_v;
}


bool
f_1579_45107_45143(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 45107, 45143);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,44421,45170);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,44421,45170);
}
		}

internal void DoConcurrentCheckAndAddToRunningPipelines(RemotePipeline pipeline, bool syncCall)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,45562,46345);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,45757,45766);
            // Concurrency check should be done under runspace lock
            lock (_syncRoot)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,45800,46014) || true) && (_bSessionStateProxyCallInProgress == true)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,45800,46014);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,45887,45995);

throw f_1579_45893_45994(f_1579_45936_45993());
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,45800,46014);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,46163,46200);

f_1579_46163_46199(
                // Delegate to pipeline to do check if it is fine to invoke if another
                // pipeline is running.
                pipeline, syncCall);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,46284,46319);

f_1579_46284_46318(this, pipeline);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,45562,46345);

string
f_1579_45936_45993()
{
var return_v = RunspaceStrings.NoPipelineWhenSessionStateProxyInProgress;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 45936, 45993);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1579_45893_45994(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 45893, 45994);
return return_v;
}


int
f_1579_46163_46199(System.Management.Automation.RemotePipeline
this_param,bool
syncCall)
{
this_param.DoConcurrentCheck( syncCall);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 46163, 46199);
return 0;
}


int
f_1579_46284_46318(System.Management.Automation.RemoteRunspace
this_param,System.Management.Automation.RemotePipeline
pipeline)
{
this_param.AddToRunningPipelineList( pipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 46284, 46318);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,45562,46345);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,45562,46345);
}
		}

internal override SessionStateProxy GetSessionStateProxy()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,46573,46753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,46656,46742);

return _sessionStateProxy ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.RemoteSessionStateProxy>(1579, 46663, 46741)??(_sessionStateProxy = f_1579_46707_46740(this)));
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,46573,46753);

System.Management.Automation.RemoteSessionStateProxy
f_1579_46707_46740(System.Management.Automation.RemoteRunspace
runspace)
{
var return_v = new System.Management.Automation.RemoteSessionStateProxy( runspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 46707, 46740);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,46573,46753);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,46573,46753);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private RemoteSessionStateProxy _sessionStateProxy ;

private void HandleRunspacePoolStateChanged(object sender, RunspacePoolStateChangedEventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,46911,48770);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,47031,47101);

RunspaceState 
newState = (RunspaceState)f_1579_47071_47100(f_1579_47071_47094(e))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,47117,47202);

RunspaceState 
prevState = f_1579_47143_47201(this, newState, f_1579_47170_47200(f_1579_47170_47193(e)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,47218,48716);

switch (newState)
            {

case RunspaceState.Opened:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,47218,48716);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,47316,48541);

switch (prevState)
                    {

case RunspaceState.Opening:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,47316,48541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,47742,47763);

f_1579_47742_47762(this);
DynAbs.Tracing.TraceSender.TraceBreak(1579,47793,47799);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,47316,48541);

case RunspaceState.Connecting:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,47316,48541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,47887,47915);

f_1579_47887_47914(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,48222,48480) || true) && (_applicationPrivateData == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,48222,48480);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,48323,48377);

_applicationPrivateData = f_1579_48349_48376(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,48411,48449);

f_1579_48411_48448(this, _applicationPrivateData);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,48222,48480);
}
DynAbs.Tracing.TraceSender.TraceBreak(1579,48512,48518);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,47316,48541);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1579,48565,48571);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,47218,48716);

case RunspaceState.Disconnected:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,47218,48716);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,48645,48673);

f_1579_48645_48672(this);
DynAbs.Tracing.TraceSender.TraceBreak(1579,48695,48701);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,47218,48716);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,48732,48759);

f_1579_48732_48758(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,46911,48770);

System.Management.Automation.RunspacePoolStateInfo
f_1579_47071_47094(System.Management.Automation.Runspaces.RunspacePoolStateChangedEventArgs
this_param)
{
var return_v = this_param.RunspacePoolStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 47071, 47094);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1579_47071_47100(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 47071, 47100);
return return_v;
}


System.Management.Automation.RunspacePoolStateInfo
f_1579_47170_47193(System.Management.Automation.Runspaces.RunspacePoolStateChangedEventArgs
this_param)
{
var return_v = this_param.RunspacePoolStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 47170, 47193);
return return_v;
}


System.Exception
f_1579_47170_47200(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 47170, 47200);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1579_47143_47201(System.Management.Automation.RemoteRunspace
this_param,System.Management.Automation.Runspaces.RunspaceState
state,System.Exception
reason)
{
var return_v = this_param.SetRunspaceState( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 47143, 47201);
return return_v;
}


int
f_1579_47742_47762(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.SetDebugModeOnOpen();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 47742, 47762);
return 0;
}


int
f_1579_47887_47914(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.UpdateDisconnectExpiresOn();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 47887, 47914);
return 0;
}


System.Management.Automation.PSPrimitiveDictionary
f_1579_48349_48376(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.GetApplicationPrivateData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 48349, 48376);
return return_v;
}


bool
f_1579_48411_48448(System.Management.Automation.RemoteRunspace
this_param,System.Management.Automation.PSPrimitiveDictionary
psApplicationPrivateData)
{
var return_v = this_param.SetDebugInfo( psApplicationPrivateData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 48411, 48448);
return return_v;
}


int
f_1579_48645_48672(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.UpdateDisconnectExpiresOn();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 48645, 48672);
return 0;
}


int
f_1579_48732_48758(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.RaiseRunspaceStateEvents();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 48732, 48758);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,46911,48770);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,46911,48770);
}
		}

private void SetDebugModeOnOpen()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,48941,50291);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,49075,49129);

_applicationPrivateData = f_1579_49101_49128(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,49143,49212);

bool 
serverSupportsDebugging = f_1579_49174_49211(this, _applicationPrivateData)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,49226,49267) || true) && (!serverSupportsDebugging)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,49226,49267);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,49258,49265);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,49226,49267);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,49361,49407);

DebugModes 
hostDebugMode = DebugModes.Default
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,49457,49608);

IHostSupportsInteractiveSession 
interactiveHost =
f_1579_49528_49572(f_1579_49528_49567(f_1579_49528_49540()))as IHostSupportsInteractiveSession
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,49626,49897) || true) && (interactiveHost != null &&(DynAbs.Tracing.TraceSender.Expression_True(1579, 49630, 49710)&&f_1579_49678_49702(interactiveHost)!= null )&&(DynAbs.Tracing.TraceSender.Expression_True(1579, 49630, 49776)&&f_1579_49735_49768(f_1579_49735_49759(interactiveHost))!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,49626,49897);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,49818,49878);

hostDebugMode = f_1579_49834_49877(f_1579_49834_49867(f_1579_49834_49858(interactiveHost)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,49626,49897);
}
            }
            catch (PSNotImplementedException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,49926,49963);
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,49926,49963);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,49979,50280) || true) && ((hostDebugMode & DebugModes.RemoteScript) == DebugModes.RemoteScript)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,49979,50280);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,50129,50173);

f_1579_50129_50172(                    _remoteDebugger, hostDebugMode);
                }
                catch (Exception)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,50210,50265);
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,50210,50265);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,49979,50280);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,48941,50291);

System.Management.Automation.PSPrimitiveDictionary
f_1579_49101_49128(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.GetApplicationPrivateData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 49101, 49128);
return return_v;
}


bool
f_1579_49174_49211(System.Management.Automation.RemoteRunspace
this_param,System.Management.Automation.PSPrimitiveDictionary
psApplicationPrivateData)
{
var return_v = this_param.SetDebugInfo( psApplicationPrivateData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 49174, 49211);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_49528_49540()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 49528, 49540);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_49528_49567(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 49528, 49567);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1579_49528_49572(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.Host ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 49528, 49572);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1579_49678_49702(System.Management.Automation.Host.IHostSupportsInteractiveSession
this_param)
{
var return_v = this_param.Runspace ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 49678, 49702);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1579_49735_49759(System.Management.Automation.Host.IHostSupportsInteractiveSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 49735, 49759);
return return_v;
}


System.Management.Automation.Debugger
f_1579_49735_49768(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.Debugger ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 49735, 49768);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1579_49834_49858(System.Management.Automation.Host.IHostSupportsInteractiveSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 49834, 49858);
return return_v;
}


System.Management.Automation.Debugger
f_1579_49834_49867(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.Debugger;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 49834, 49867);
return return_v;
}


System.Management.Automation.DebugModes
f_1579_49834_49877(System.Management.Automation.Debugger
this_param)
{
var return_v = this_param.DebugMode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 49834, 49877);
return return_v;
}


int
f_1579_50129_50172(System.Management.Automation.RemoteDebugger
this_param,System.Management.Automation.DebugModes
mode)
{
this_param.SetDebugMode( mode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 50129, 50172);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,48941,50291);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,48941,50291);
}
		}

private bool SetDebugInfo(PSPrimitiveDictionary psApplicationPrivateData)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,50303,53105);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,50401,50430);

DebugModes? 
debugMode = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,50444,50468);

bool 
inDebugger = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,50482,50506);

int 
breakpointCount = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,50520,50542);

bool 
breakAll = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,50556,50657);

UnhandledBreakpointProcessingMode 
unhandledBreakpointMode = UnhandledBreakpointProcessingMode.Ignore
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,50673,52482) || true) && (psApplicationPrivateData != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,50673,52482);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,50743,50964) || true) && (f_1579_50747_50816(psApplicationPrivateData, RemoteDebugger.DebugModeSetting))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,50743,50964);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,50858,50945);

debugMode = (DebugModes)(int)f_1579_50887_50944(psApplicationPrivateData, RemoteDebugger.DebugModeSetting);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,50743,50964);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,50984,51191) || true) && (f_1579_50988_51055(psApplicationPrivateData, RemoteDebugger.DebugStopState))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,50984,51191);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,51097,51172);

inDebugger = (bool)f_1579_51116_51171(psApplicationPrivateData, RemoteDebugger.DebugStopState);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,50984,51191);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,51211,51434) || true) && (f_1579_51215_51288(psApplicationPrivateData, RemoteDebugger.DebugBreakpointCount))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,51211,51434);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,51330,51415);

breakpointCount = (int)f_1579_51353_51414(psApplicationPrivateData, RemoteDebugger.DebugBreakpointCount);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,51211,51434);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,51454,51661) || true) && (f_1579_51458_51526(psApplicationPrivateData, RemoteDebugger.BreakAllSetting))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,51454,51661);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,51568,51642);

breakAll = (bool)f_1579_51585_51641(psApplicationPrivateData, RemoteDebugger.BreakAllSetting);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,51454,51661);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,51681,51967) || true) && (f_1579_51685_51768(psApplicationPrivateData, RemoteDebugger.UnhandledBreakpointModeSetting))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,51681,51967);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,51810,51948);

unhandledBreakpointMode = (UnhandledBreakpointProcessingMode)(int)f_1579_51876_51947(psApplicationPrivateData, RemoteDebugger.UnhandledBreakpointModeSetting);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,51681,51967);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,51987,52467) || true) && (f_1579_51991_52061(psApplicationPrivateData, PSVersionInfo.PSVersionTableName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,51987,52467);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,52103,52208);

var 
psVersionTable = f_1579_52124_52182(psApplicationPrivateData, PSVersionInfo.PSVersionTableName)as PSPrimitiveDictionary
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,52230,52448) || true) && (f_1579_52234_52289(psVersionTable, PSVersionInfo.PSVersionName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,52230,52448);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,52339,52425);

ServerVersion = f_1579_52355_52413(f_1579_52369_52412(psVersionTable, PSVersionInfo.PSVersionName))as Version;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,52230,52448);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,51987,52467);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,50673,52482);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,52498,53065) || true) && (debugMode != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,52498,53065);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,52677,52764);

f_1579_52677_52763(_remoteDebugger == null, "Remote runspace should not have a debugger yet.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,52782,52825);

_remoteDebugger = f_1579_52800_52824(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,52893,53018);

f_1579_52893_53017(
                // Set initial debugger state.
                _remoteDebugger, debugMode, inDebugger, breakpointCount, breakAll, unhandledBreakpointMode, f_1579_53003_53016());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,53038,53050);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,52498,53065);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,53081,53094);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,50303,53105);

bool
f_1579_50747_50816(System.Management.Automation.PSPrimitiveDictionary
this_param,string
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 50747, 50816);
return return_v;
}


object
f_1579_50887_50944(System.Management.Automation.PSPrimitiveDictionary
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 50887, 50944);
return return_v;
}


bool
f_1579_50988_51055(System.Management.Automation.PSPrimitiveDictionary
this_param,string
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 50988, 51055);
return return_v;
}


object
f_1579_51116_51171(System.Management.Automation.PSPrimitiveDictionary
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 51116, 51171);
return return_v;
}


bool
f_1579_51215_51288(System.Management.Automation.PSPrimitiveDictionary
this_param,string
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 51215, 51288);
return return_v;
}


object
f_1579_51353_51414(System.Management.Automation.PSPrimitiveDictionary
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 51353, 51414);
return return_v;
}


bool
f_1579_51458_51526(System.Management.Automation.PSPrimitiveDictionary
this_param,string
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 51458, 51526);
return return_v;
}


object
f_1579_51585_51641(System.Management.Automation.PSPrimitiveDictionary
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 51585, 51641);
return return_v;
}


bool
f_1579_51685_51768(System.Management.Automation.PSPrimitiveDictionary
this_param,string
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 51685, 51768);
return return_v;
}


object
f_1579_51876_51947(System.Management.Automation.PSPrimitiveDictionary
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 51876, 51947);
return return_v;
}


bool
f_1579_51991_52061(System.Management.Automation.PSPrimitiveDictionary
this_param,string
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 51991, 52061);
return return_v;
}


object
f_1579_52124_52182(System.Management.Automation.PSPrimitiveDictionary
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 52124, 52182);
return return_v;
}


bool
f_1579_52234_52289(System.Management.Automation.PSPrimitiveDictionary
this_param,string
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 52234, 52289);
return return_v;
}


object
f_1579_52369_52412(System.Management.Automation.PSPrimitiveDictionary
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 52369, 52412);
return return_v;
}


object
f_1579_52355_52413(object
obj)
{
var return_v = PSObject.Base( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 52355, 52413);
return return_v;
}


int
f_1579_52677_52763(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 52677, 52763);
return 0;
}


System.Management.Automation.RemoteDebugger
f_1579_52800_52824(System.Management.Automation.RemoteRunspace
runspace)
{
var return_v = new System.Management.Automation.RemoteDebugger( runspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 52800, 52824);
return return_v;
}


System.Version
f_1579_53003_53016()
{
var return_v = ServerVersion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 53003, 53016);
return return_v;
}


int
f_1579_52893_53017(System.Management.Automation.RemoteDebugger
this_param,System.Management.Automation.DebugModes?
debugMode,bool
inBreakpoint,int
breakpointCount,bool
breakAll,System.Management.Automation.UnhandledBreakpointProcessingMode
unhandledBreakpointMode,System.Version
serverPSVersion)
{
this_param.SetClientDebugInfo( debugMode, inBreakpoint, breakpointCount, breakAll, unhandledBreakpointMode, serverPSVersion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 52893, 53017);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,50303,53105);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,50303,53105);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void AssertIfStateIsBeforeOpen()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,53237,54045);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,53308,53317);
            lock (_syncRoot)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,53418,54019) || true) && (f_1579_53422_53446(_runspaceStateInfo)!= RunspaceState.BeforeOpen)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,53418,54019);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,53516,53970);

InvalidRunspaceStateException 
e =
f_1579_53575_53969(f_1579_53665_53832(f_1579_53683_53714(), new object[] { f_1579_53764_53799(f_1579_53764_53788(_runspaceStateInfo))}), f_1579_53863_53887(_runspaceStateInfo), RunspaceState.BeforeOpen)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,53992,54000);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,53418,54019);
}
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,53237,54045);

System.Management.Automation.Runspaces.RunspaceState
f_1579_53422_53446(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 53422, 53446);
return return_v;
}


string
f_1579_53683_53714()
{
var return_v = RunspaceStrings.CannotOpenAgain;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 53683, 53714);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1579_53764_53788(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 53764, 53788);
return return_v;
}


string
f_1579_53764_53799(System.Management.Automation.Runspaces.RunspaceState
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 53764, 53799);
return return_v;
}


string
f_1579_53665_53832(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 53665, 53832);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1579_53863_53887(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 53863, 53887);
return return_v;
}


System.Management.Automation.Runspaces.InvalidRunspaceStateException
f_1579_53575_53969(string
message,System.Management.Automation.Runspaces.RunspaceState
currentState,System.Management.Automation.Runspaces.RunspaceState
expectedState)
{
var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException( message, currentState, expectedState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 53575, 53969);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,53237,54045);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,53237,54045);
}
		}

private RunspaceState SetRunspaceState(RunspaceState state, Exception reason)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,54670,56202);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,54772,54796);

RunspaceState 
prevState
=default(RunspaceState);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,54818,54827);

            lock (_syncRoot)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,54861,54898);

prevState = f_1579_54873_54897(_runspaceStateInfo);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,54916,56143) || true) && (state != prevState)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,54916,56143);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,54980,55038);

_runspaceStateInfo = f_1579_55001_55037(state, reason);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,55462,55528);

RunspaceAvailability 
previousAvailability = _runspaceAvailability
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,55552,55617);

f_1579_55552_55616(
                    this, f_1579_55584_55608(_runspaceStateInfo), false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,55641,55884);

f_1579_55641_55883(
                    _runspaceEventQueue, f_1579_55695_55882(f_1579_55752_55778(                            _runspaceStateInfo), previousAvailability, _runspaceAvailability));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,55908,56124);

f_1579_55908_56123(PSEventId.RunspaceStateChange, PSOpcode.Open, PSTask.CreateRunspace, PSKeyword.UseAlwaysOperational, f_1579_56106_56122(                                state));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,54916,56143);
}
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,56174,56191);

return prevState;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,54670,56202);

System.Management.Automation.Runspaces.RunspaceState
f_1579_54873_54897(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 54873, 54897);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1579_55001_55037(System.Management.Automation.Runspaces.RunspaceState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.Runspaces.RunspaceStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 55001, 55037);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1579_55584_55608(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 55584, 55608);
return return_v;
}


int
f_1579_55552_55616(System.Management.Automation.RemoteRunspace
this_param,System.Management.Automation.Runspaces.RunspaceState
runspaceState,bool
raiseEvent)
{
this_param.UpdateRunspaceAvailability( runspaceState, raiseEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 55552, 55616);
return 0;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1579_55752_55778(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.Clone();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 55752, 55778);
return return_v;
}


System.Management.Automation.RemoteRunspace.RunspaceEventQueueItem
f_1579_55695_55882(System.Management.Automation.Runspaces.RunspaceStateInfo
runspaceStateInfo,System.Management.Automation.Runspaces.RunspaceAvailability
currentAvailability,System.Management.Automation.Runspaces.RunspaceAvailability
newAvailability)
{
var return_v = new System.Management.Automation.RemoteRunspace.RunspaceEventQueueItem( runspaceStateInfo, currentAvailability, newAvailability);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 55695, 55882);
return return_v;
}


int
f_1579_55641_55883(System.Collections.Generic.Queue<System.Management.Automation.RemoteRunspace.RunspaceEventQueueItem>
this_param,System.Management.Automation.RemoteRunspace.RunspaceEventQueueItem
item)
{
this_param.Enqueue( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 55641, 55883);
return 0;
}


string
f_1579_56106_56122(System.Management.Automation.Runspaces.RunspaceState
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 56106, 56122);
return return_v;
}


int
f_1579_55908_56123(System.Management.Automation.Internal.PSEventId
id,System.Management.Automation.Internal.PSOpcode
opcode,System.Management.Automation.Internal.PSTask
task,System.Management.Automation.Internal.PSKeyword
keyword,params object[]
args)
{
PSEtwLog.LogOperationalVerbose( id, opcode, task, keyword, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 55908, 56123);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,54670,56202);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,54670,56202);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void RaiseRunspaceStateEvents()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,56319,58416);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,56383,56435);

Queue<RunspaceEventQueueItem> 
tempEventQueue = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,56449,56506);

EventHandler<RunspaceStateEventArgs> 
stateChanged = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,56520,56567);

bool 
hasAvailabilityChangedSubscribers = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,56589,56598);

            lock (_syncRoot)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,56632,56665);

stateChanged = this.StateChanged;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,56683,56758);

hasAvailabilityChangedSubscribers = f_1579_56719_56757(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,56778,57337) || true) && (stateChanged != null ||(DynAbs.Tracing.TraceSender.Expression_False(1579, 56782, 56839)||hasAvailabilityChangedSubscribers))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,56778,57337);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,56881,56918);

tempEventQueue = _runspaceEventQueue;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,56940,56998);

_runspaceEventQueue = f_1579_56962_56997();
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,56778,57337);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,56778,57337);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,57290,57318);

f_1579_57290_57317(                    // Clear the events if there are no EventHandlers. This
                    // ensures that events do not get called for state
                    // changes prior to their registration.
                    _runspaceEventQueue);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,56778,57337);
}
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,57368,58405) || true) && (tempEventQueue != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,57368,58405);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,57428,58390) || true) && (f_1579_57435_57455(tempEventQueue)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,57428,58390);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,57501,57561);

RunspaceEventQueueItem 
queueItem = f_1579_57536_57560(tempEventQueue)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,57585,57870) || true) && (hasAvailabilityChangedSubscribers &&(DynAbs.Tracing.TraceSender.Expression_True(1579, 57589, 57700)&&queueItem.NewRunspaceAvailability != queueItem.CurrentRunspaceAvailability))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,57585,57870);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,57750,57847);

f_1579_57750_57846(                        this, f_1579_57777_57845(queueItem.NewRunspaceAvailability));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,57585,57870);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,58014,58371) || true) && (stateChanged != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,58014,58371);
                        try
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,58148,58224);

f_1579_58148_58223(stateChanged, this, f_1579_58167_58222(queueItem.RunspaceStateInfo));
                        }
                        catch (Exception)
                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,58277,58348);
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,58277,58348);
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,58014,58371);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,57428,58390);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1579,57428,58390);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1579,57428,58390);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1579,57368,58405);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,56319,58416);

bool
f_1579_56719_56757(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.HasAvailabilityChangedSubscribers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 56719, 56757);
return return_v;
}


System.Collections.Generic.Queue<System.Management.Automation.RemoteRunspace.RunspaceEventQueueItem>
f_1579_56962_56997()
{
var return_v = new System.Collections.Generic.Queue<System.Management.Automation.RemoteRunspace.RunspaceEventQueueItem>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 56962, 56997);
return return_v;
}


int
f_1579_57290_57317(System.Collections.Generic.Queue<System.Management.Automation.RemoteRunspace.RunspaceEventQueueItem>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 57290, 57317);
return 0;
}


int
f_1579_57435_57455(System.Collections.Generic.Queue<System.Management.Automation.RemoteRunspace.RunspaceEventQueueItem>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 57435, 57455);
return return_v;
}


System.Management.Automation.RemoteRunspace.RunspaceEventQueueItem
f_1579_57536_57560(System.Collections.Generic.Queue<System.Management.Automation.RemoteRunspace.RunspaceEventQueueItem>
this_param)
{
var return_v = this_param.Dequeue();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 57536, 57560);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs
f_1579_57777_57845(System.Management.Automation.Runspaces.RunspaceAvailability
runspaceAvailability)
{
var return_v = new System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs( runspaceAvailability);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 57777, 57845);
return return_v;
}


int
f_1579_57750_57846(System.Management.Automation.RemoteRunspace
this_param,System.Management.Automation.Runspaces.RunspaceAvailabilityEventArgs
e)
{
this_param.OnAvailabilityChanged( e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 57750, 57846);
return 0;
}


System.Management.Automation.Runspaces.RunspaceStateEventArgs
f_1579_58167_58222(System.Management.Automation.Runspaces.RunspaceStateInfo
runspaceStateInfo)
{
var return_v = new System.Management.Automation.Runspaces.RunspaceStateEventArgs( runspaceStateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 58167, 58222);
return return_v;
}


int
f_1579_58148_58223(System.EventHandler<System.Management.Automation.Runspaces.RunspaceStateEventArgs>
this_param,System.Management.Automation.RemoteRunspace
sender,System.Management.Automation.Runspaces.RunspaceStateEventArgs
e)
{
this_param.Invoke( (object)sender, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 58148, 58223);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,56319,58416);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,56319,58416);
}
		}

private Pipeline CoreCreatePipeline(string command, bool addToHistory, bool isNested)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,58679,58865);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,58789,58854);

return f_1579_58796_58853(this, command, addToHistory, isNested);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,58679,58865);

System.Management.Automation.RemotePipeline
f_1579_58796_58853(System.Management.Automation.RemoteRunspace
runspace,string
command,bool
addToHistory,bool
isNested)
{
var return_v = new System.Management.Automation.RemotePipeline( runspace, command, addToHistory, isNested);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 58796, 58853);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,58679,58865);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,58679,58865);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Finishof")]
        private bool WaitForFinishofPipelines()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,59028,60330);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,59670,59704);

RemotePipeline[] 
runningPipelines
=default(RemotePipeline[]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,59726,59735);

            lock (_syncRoot)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,59769,59816);

runningPipelines = f_1579_59788_59815(_runningPipelines);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,59847,60319) || true) && (f_1579_59851_59874(runningPipelines)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,59847,60319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,59912,59979);

WaitHandle[] 
waitHandles = new WaitHandle[f_1579_59954_59977(runningPipelines)]
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,60008,60013);

                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,59999,60167) || true) && (i < f_1579_60019_60042(runningPipelines))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,60044,60047)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1579,59999,60167))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,59999,60167);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,60089,60148);

waitHandles[i] = f_1579_60106_60147(runningPipelines[i]);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1579,1,169);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1579,1,169);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,60187,60226);

return f_1579_60194_60225(waitHandles);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,59847,60319);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,59847,60319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,60292,60304);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,59847,60319);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,59028,60330);

System.Management.Automation.RemotePipeline[]
f_1579_59788_59815(System.Collections.Generic.List<System.Management.Automation.RemotePipeline>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 59788, 59815);
return return_v;
}


int
f_1579_59851_59874(System.Management.Automation.RemotePipeline[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 59851, 59874);
return return_v;
}


int
f_1579_59954_59977(System.Management.Automation.RemotePipeline[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 59954, 59977);
return return_v;
}


int
f_1579_60019_60042(System.Management.Automation.RemotePipeline[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 60019, 60042);
return return_v;
}


System.Threading.ManualResetEvent
f_1579_60106_60147(System.Management.Automation.RemotePipeline
this_param)
{
var return_v = this_param.PipelineFinishedEvent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 60106, 60147);
return return_v;
}


bool
f_1579_60194_60225(System.Threading.WaitHandle[]
waitHandles)
{
var return_v = WaitHandle.WaitAll( waitHandles);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 60194, 60225);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,59028,60330);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,59028,60330);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override Pipeline GetCurrentlyRunningPipeline()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,60521,60928);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,60608,60617);
            lock (_syncRoot)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,60651,60902) || true) && (f_1579_60655_60678(_runningPipelines)!= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,60651,60902);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,60725,60789);

return (Pipeline)f_1579_60742_60788(_runningPipelines, f_1579_60760_60783(_runningPipelines)- 1);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,60651,60902);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,60651,60902);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,60871,60883);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,60651,60902);
}
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,60521,60928);

int
f_1579_60655_60678(System.Collections.Generic.List<System.Management.Automation.RemotePipeline>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 60655, 60678);
return return_v;
}


int
f_1579_60760_60783(System.Collections.Generic.List<System.Management.Automation.RemotePipeline>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 60760, 60783);
return return_v;
}


System.Management.Automation.RemotePipeline
f_1579_60742_60788(System.Collections.Generic.List<System.Management.Automation.RemotePipeline>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 60742, 60788);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,60521,60928);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,60521,60928);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void HandleHostCallReceived(object sender, RemoteDataEventArgs<RemoteHostCall> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,61251,61880);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,61373,61869);

f_1579_61373_61868(f_1579_61421_61498(f_1579_61421_61481(f_1579_61421_61460(f_1579_61421_61433()))), f_1579_61517_61561(f_1579_61517_61556(f_1579_61517_61529())), null, null, false, f_1579_61746_61785(f_1579_61746_61758()), Guid.Empty, f_1579_61853_61867(eventArgs));
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,61251,61880);

System.Management.Automation.Runspaces.RunspacePool
f_1579_61421_61433()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 61421, 61433);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_61421_61460(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 61421, 61460);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1579_61421_61481(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 61421, 61481);
return return_v;
}


System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
f_1579_61421_61498(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param)
{
var return_v = this_param.TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 61421, 61498);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_61517_61529()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 61517, 61529);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_61517_61556(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 61517, 61556);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1579_61517_61561(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 61517, 61561);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_61746_61758()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 61746, 61758);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_61746_61785(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 61746, 61785);
return return_v;
}


System.Management.Automation.Remoting.RemoteHostCall
f_1579_61853_61867(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 61853, 61867);
return return_v;
}


int
f_1579_61373_61868(System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
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
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 61373, 61868);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,61251,61880);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,61251,61880);
}
		}

private void HandleURIDirectionReported(object sender, RemoteDataEventArgs<Uri> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,62198,62681);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,62313,62394);

WSManConnectionInfo 
wsmanConnectionInfo = _connectionInfo as WSManConnectionInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,62408,62670) || true) && (wsmanConnectionInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,62408,62670);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,62535,62586);

wsmanConnectionInfo.ConnectionUri = f_1579_62571_62585(eventArgs);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,62604,62655);

f_1579_62604_62654(                URIRedirectionReported, this, eventArgs);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,62408,62670);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,62198,62681);

System.Uri
f_1579_62571_62585(System.Management.Automation.RemoteDataEventArgs<System.Uri>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 62571, 62585);
return return_v;
}


int
f_1579_62604_62654(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Uri>>
eventHandler,System.Management.Automation.RemoteRunspace
sender,System.Management.Automation.RemoteDataEventArgs<System.Uri>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Uri>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 62604, 62654);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,62198,62681);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,62198,62681);
}
		}

private void HandleRunspacePoolForwardEvent(object sender, PSEventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,62820,63562);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,62918,63551) || true) && (f_1579_62922_62987(f_1579_62922_62940(e), RemoteDebugger.RemoteDebuggerStopEvent))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,62918,63551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,63101,63140);

f_1579_63101_63139(                // Special processing for forwarded remote DebuggerStop event.
                RemoteDebuggerStop, this, e);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,62918,63551);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,62918,63551);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,63174,63551) || true) && (f_1579_63178_63256(f_1579_63178_63196(e), RemoteDebugger.RemoteDebuggerBreakpointUpdatedEvent))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,63174,63551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,63383,63435);

f_1579_63383_63434(                // Special processing for forwarded remote DebuggerBreakpointUpdated event.
                RemoteDebuggerBreakpointUpdated, this, e);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,63174,63551);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,63174,63551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,63501,63536);

f_1579_63501_63535(                _eventManager, e);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,63174,63551);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,62918,63551);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,62820,63562);

string
f_1579_62922_62940(System.Management.Automation.PSEventArgs
this_param)
{
var return_v = this_param.SourceIdentifier;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 62922, 62940);
return return_v;
}


bool
f_1579_62922_62987(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 62922, 62987);
return return_v;
}


int
f_1579_63101_63139(System.EventHandler<System.Management.Automation.PSEventArgs>
eventHandler,System.Management.Automation.RemoteRunspace
sender,System.Management.Automation.PSEventArgs
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.PSEventArgs>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 63101, 63139);
return 0;
}


string
f_1579_63178_63196(System.Management.Automation.PSEventArgs
this_param)
{
var return_v = this_param.SourceIdentifier;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 63178, 63196);
return return_v;
}


bool
f_1579_63178_63256(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 63178, 63256);
return return_v;
}


int
f_1579_63383_63434(System.EventHandler<System.Management.Automation.PSEventArgs>
eventHandler,System.Management.Automation.RemoteRunspace
sender,System.Management.Automation.PSEventArgs
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.PSEventArgs>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 63383, 63434);
return 0;
}


int
f_1579_63501_63535(System.Management.Automation.PSRemoteEventManager
this_param,System.Management.Automation.PSEventArgs
forwardedEvent)
{
this_param.AddForwardedEvent( forwardedEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 63501, 63535);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,62820,63562);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,62820,63562);
}
		}

private void HandleSessionCreateCompleted(object sender, CreateCompleteEventArgs eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,63766,64548);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,63965,64537) || true) && (eventArgs != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,63965,64537);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,64020,64087);

_connectionInfo.IdleTimeout = f_1579_64050_64086(f_1579_64050_64074(eventArgs));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,64105,64178);

_connectionInfo.MaxIdleTimeout = f_1579_64138_64177(f_1579_64138_64162(eventArgs));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,64196,64277);

WSManConnectionInfo 
wsmanConnectionInfo = _connectionInfo as WSManConnectionInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,64295,64522) || true) && (wsmanConnectionInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,64295,64522);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,64368,64503);

wsmanConnectionInfo.OutputBufferingMode =
f_1579_64435_64502(((WSManConnectionInfo)f_1579_64457_64481(eventArgs)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,64295,64522);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,63965,64537);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,63766,64548);

System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1579_64050_64074(System.Management.Automation.Remoting.CreateCompleteEventArgs
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 64050, 64074);
return return_v;
}


int
f_1579_64050_64086(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.IdleTimeout;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 64050, 64086);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1579_64138_64162(System.Management.Automation.Remoting.CreateCompleteEventArgs
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 64138, 64162);
return return_v;
}


int
f_1579_64138_64177(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.MaxIdleTimeout;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 64138, 64177);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1579_64457_64481(System.Management.Automation.Remoting.CreateCompleteEventArgs
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 64457, 64481);
return return_v;
}


System.Management.Automation.Runspaces.OutputBufferingMode
f_1579_64435_64502(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.OutputBufferingMode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 64435, 64502);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,63766,64548);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,63766,64548);
}
		}

private void UpdateDisconnectExpiresOn()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,64695,65107);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,64760,64880);

WSManConnectionInfo 
wsmanConnectionInfo = f_1579_64802_64856(f_1579_64802_64841(f_1579_64802_64814()))as WSManConnectionInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,64894,65096) || true) && (wsmanConnectionInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,64894,65096);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,64959,65016);

this.DisconnectedOn = f_1579_64981_65015(wsmanConnectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,65034,65081);

this.ExpiresOn = f_1579_65051_65080(wsmanConnectionInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,64894,65096);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,64695,65107);

System.Management.Automation.Runspaces.RunspacePool
f_1579_64802_64814()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 64802, 64814);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_64802_64841(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 64802, 64841);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1579_64802_64856(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.ConnectionInfo ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 64802, 64856);
return return_v;
}


System.DateTime?
f_1579_64981_65015(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.DisconnectedOn;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 64981, 65015);
return return_v;
}


System.DateTime?
f_1579_65051_65080(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.ExpiresOn;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 65051, 65080);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,64695,65107);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,64695,65107);
}
		}

internal bool IsAnotherInvokeCommandExecuting(InvokeCommandCommand invokeCommand,
            long localPipelineId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,65702,67345);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,66145,67334) || true) && (_currentLocalPipelineId != localPipelineId &&(DynAbs.Tracing.TraceSender.Expression_True(1579, 66149, 66223)&&_currentLocalPipelineId != 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,66145,67334);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,66257,66270);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,66145,67334);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,66145,67334);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,66545,67319) || true) && (_currentInvokeCommand == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,66545,67319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,66725,66781);

f_1579_66725_66780(this, invokeCommand, localPipelineId);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,66803,66816);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,66545,67319);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,66545,67319);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,66858,67319) || true) && (f_1579_66862_66905(_currentInvokeCommand, invokeCommand))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,66858,67319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,67052,67065);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,66858,67319);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,66858,67319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,67288,67300);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,66858,67319);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,66545,67319);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,66145,67334);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,65702,67345);

int
f_1579_66725_66780(System.Management.Automation.RemoteRunspace
this_param,Microsoft.PowerShell.Commands.InvokeCommandCommand
invokeCommand,long
localPipelineId)
{
this_param.SetCurrentInvokeCommand( invokeCommand, localPipelineId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 66725, 66780);
return 0;
}


bool
f_1579_66862_66905(Microsoft.PowerShell.Commands.InvokeCommandCommand
this_param,Microsoft.PowerShell.Commands.InvokeCommandCommand
obj)
{
var return_v = this_param.Equals( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 66862, 66905);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,65702,67345);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,65702,67345);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void SetCurrentInvokeCommand(InvokeCommandCommand invokeCommand,
            long localPipelineId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,67716,68206);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,67849,67982);

f_1579_67849_67981(invokeCommand != null, "InvokeCommand instance cannot be null, use ClearInvokeCommand() method to reset current command");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,67996,68085);

f_1579_67996_68084(localPipelineId != 0, "Local pipeline id needs to be supplied - cannot be 0");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,68101,68139);

_currentInvokeCommand = invokeCommand;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,68153,68195);

_currentLocalPipelineId = localPipelineId;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,67716,68206);

int
f_1579_67849_67981(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 67849, 67981);
return 0;
}


int
f_1579_67996_68084(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 67996, 68084);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,67716,68206);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,67716,68206);
}
		}

internal void ClearInvokeCommand()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,68371,68512);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,68430,68458);

_currentLocalPipelineId = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,68472,68501);

_currentInvokeCommand = null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,68371,68512);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,68371,68512);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,68371,68512);
}
		}

internal void AbortOpen()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,68814,69285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,68864,69149);

System.Management.Automation.Remoting.Client.NamedPipeClientSessionTransportManager 
transportManager =
f_1579_68984_69061(f_1579_68984_69044(f_1579_68984_69023(f_1579_68984_68996())))as System.Management.Automation.Remoting.Client.NamedPipeClientSessionTransportManager
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,69165,69274) || true) && (transportManager != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,69165,69274);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,69227,69259);

f_1579_69227_69258(                transportManager);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,69165,69274);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,68814,69285);

System.Management.Automation.Runspaces.RunspacePool
f_1579_68984_68996()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 68984, 68996);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_68984_69023(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 68984, 69023);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1579_68984_69044(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 68984, 69044);
return return_v;
}


System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
f_1579_68984_69061(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param)
{
var return_v = this_param.TransportManager ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 68984, 69061);
return return_v;
}


int
f_1579_69227_69258(System.Management.Automation.Remoting.Client.NamedPipeClientSessionTransportManager
this_param)
{
this_param.AbortConnect();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 69227, 69258);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,68814,69285);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,68814,69285);
}
		}

internal RunspacePool RunspacePool {get; }

        /// <summary>
        /// EventHandler used to report connection URI redirections to the application.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<Uri>> 
URIRedirectionReported
;

public override PSPrimitiveDictionary GetApplicationPrivateData()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,70355,70702);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,70481,70529);

return f_1579_70488_70528(f_1579_70488_70500());
            }
            catch (InvalidRunspacePoolStateException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,70558,70691);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,70634,70676);

throw f_1579_70640_70675(e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,70558,70691);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,70355,70702);

System.Management.Automation.Runspaces.RunspacePool
f_1579_70488_70500()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 70488, 70500);
return return_v;
}


System.Management.Automation.PSPrimitiveDictionary
f_1579_70488_70528(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.GetApplicationPrivateData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 70488, 70528);
return return_v;
}


System.Management.Automation.Runspaces.InvalidRunspaceStateException
f_1579_70640_70675(System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
this_param)
{
var return_v = this_param.ToInvalidRunspaceStateException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 70640, 70675);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,70355,70702);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,70355,70702);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override void SetApplicationPrivateData(PSPrimitiveDictionary applicationPrivateData)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,70714,71034);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,70833,71023);

f_1579_70833_71022(false, "RemoteRunspace.SetApplicationPrivateData shouldn't be called - this runspace does not belong to a runspace pool [although it does use a remote runspace pool internally]");
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,70714,71034);

int
f_1579_70833_71022(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 70833, 71022);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,70714,71034);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,70714,71034);
}
		}

static RemoteRunspace()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1579,1028,71063);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1579,1028,71063);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,1028,71063);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1579,1028,71063);

System.Collections.Generic.List<System.Management.Automation.RemotePipeline>
f_1579_1182_1208()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.RemotePipeline>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 1182, 1208);
return return_v;
}


object
f_1579_1246_1258()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 1246, 1258);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1579_1316_1363(System.Management.Automation.Runspaces.RunspaceState
state)
{
var return_v = new System.Management.Automation.Runspaces.RunspaceStateInfo( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 1316, 1363);
return return_v;
}


System.Collections.Generic.Queue<System.Management.Automation.RemoteRunspace.RunspaceEventQueueItem>
f_1579_2433_2468()
{
var return_v = new System.Collections.Generic.Queue<System.Management.Automation.RemoteRunspace.RunspaceEventQueueItem>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 2433, 2468);
return return_v;
}


System.Guid
f_1579_5805_5820(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 5805, 5820);
return return_v;
}


int
f_1579_5766_5821(System.Guid
newActivityId)
{
PSEtwLog.SetActivityIdForCurrentThread( newActivityId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 5766, 5821);
return 0;
}


System.Guid
f_1579_6025_6035()
{
var return_v = InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 6025, 6035);
return return_v;
}


int
f_1579_5836_6047(System.Management.Automation.Internal.PSEventId
id,System.Management.Automation.Internal.PSOpcode
opcode,System.Management.Automation.Internal.PSTask
task,System.Management.Automation.Internal.PSKeyword
keyword,params object[]
args)
{
PSEtwLog.LogOperationalVerbose( id, opcode, task, keyword, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 5836, 6047);
return 0;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1579_6082_6111(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.InternalCopy();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 6082, 6111);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1579_6151_6180(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.InternalCopy();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 6151, 6180);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_6212_6295(int
minRunspaces,int
maxRunspaces,System.Management.Automation.Runspaces.TypeTable
typeTable,System.Management.Automation.Host.PSHost
host,System.Management.Automation.PSPrimitiveDictionary
applicationArguments,System.Management.Automation.Runspaces.RunspaceConnectionInfo
connectionInfo,string
name)
{
var return_v = new System.Management.Automation.Runspaces.RunspacePool( minRunspaces, maxRunspaces, typeTable, host, applicationArguments, connectionInfo, name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 6212, 6295);
return return_v;
}


int
f_1579_6350_6368(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.SetEventHandlers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 6350, 6368);
return 0;
}


System.Management.Automation.RunspacePoolStateInfo
f_1579_6858_6892(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RunspacePoolStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 6858, 6892);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1579_6858_6898(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 6858, 6898);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1579_6957_6984(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.ConnectionInfo ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 6957, 6984);
return return_v;
}


string
f_1579_7091_7126()
{
var return_v = RunspaceStrings.InvalidRunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 7091, 7126);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1579_7048_7127(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 7048, 7127);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_7488_7500()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 7488, 7500);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_7488_7527(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 7488, 7527);
return return_v;
}


bool
f_1579_7488_7546(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,int
minRunspaces)
{
var return_v = this_param.SetMinRunspaces( minRunspaces);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 7488, 7546);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_7561_7573()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 7561, 7573);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_7561_7600(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 7561, 7600);
return return_v;
}


bool
f_1579_7561_7619(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,int
maxRunspaces)
{
var return_v = this_param.SetMaxRunspaces( maxRunspaces);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 7561, 7619);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1579_7654_7681(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 7654, 7681);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1579_7654_7696(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.InternalCopy();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 7654, 7696);
return return_v;
}


int
f_1579_7808_7835(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.UpdateDisconnectExpiresOn();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 7808, 7835);
return 0;
}


System.Management.Automation.Runspaces.RunspaceState
f_1579_7904_7954(System.Management.Automation.RemoteRunspace
this_param,System.Management.Automation.Runspaces.RunspaceState
state,System.Exception
reason)
{
var return_v = this_param.SetRunspaceState( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 7904, 7954);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_8283_8295()
{
var return_v = RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 8283, 8295);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_8283_8322(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 8283, 8322);
return return_v;
}


bool
f_1579_8283_8345(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.AvailableForConnection ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 8283, 8345);
return return_v;
}


int
f_1579_8455_8473(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.SetEventHandlers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 8455, 8473);
return 0;
}


System.Guid
f_1579_8529_8544(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 8529, 8544);
return return_v;
}


int
f_1579_8490_8545(System.Guid
newActivityId)
{
PSEtwLog.SetActivityIdForCurrentThread( newActivityId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 8490, 8545);
return 0;
}


int
f_1579_8560_8776(System.Management.Automation.Internal.PSEventId
id,System.Management.Automation.Internal.PSOpcode
opcode,System.Management.Automation.Internal.PSTask
task,System.Management.Automation.Internal.PSKeyword
keyword,params object[]
args)
{
PSEtwLog.LogOperationalVerbose( id, opcode, task, keyword, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 8560, 8776);
return 0;
}


System.Version
f_1579_11024_11047()
{
var return_v = PSVersionInfo.PSVersion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 11024, 11047);
return return_v;
}

}
internal sealed class RemoteDebugger : Debugger, IDisposable
{
private RemoteRunspace _runspace;

private PowerShell _psDebuggerCommand;

private bool _remoteDebugSupported;

private bool _isActive;

private int _breakpointCount;

private RemoteDebuggingCapability _remoteDebuggingCapability;

private bool? _remoteBreakpointManagementIsSupported;

private volatile bool _handleDebuggerStop;

private bool _isDebuggerSteppingEnabled;

private UnhandledBreakpointProcessingMode _unhandledBreakpointMode;

private bool _detachCommand;

private WindowsIdentity _identityToPersonate;

private bool _identityPersonationChecked;

public const string 
RemoteDebuggerStopEvent = "PSInternalRemoteDebuggerStopEvent"
;

public const string 
RemoteDebuggerBreakpointUpdatedEvent = "PSInternalRemoteDebuggerBreakpointUpdatedEvent"
;

public const string 
DebugModeSetting = "DebugMode"
;

public const string 
DebugStopState = "DebugStop"
;

public const string 
DebugBreakpointCount = "DebugBreakpointCount"
;

public const string 
BreakAllSetting = "BreakAll"
;

public const string 
UnhandledBreakpointModeSetting = "UnhandledBreakpointMode"
;

private RemoteDebugger() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1579,72830,72858);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71293,71302);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71332,71350);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71374,71395);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71419,71428);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71451,71467);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71512,71538);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71563,71601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71634,71653);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71677,71703);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71756,71780);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71804,71818);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71905,71925);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71949,71976);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,100068,100161);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1579,72830,72858);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,72830,72858);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,72830,72858);
}
		}

public RemoteDebugger(RemoteRunspace runspace)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1579,73015,73585);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71293,71302);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71332,71350);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71374,71395);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71419,71428);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71451,71467);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71512,71538);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71563,71601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71634,71653);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71677,71703);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71756,71780);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71804,71818);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71905,71925);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,71949,71976);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,100068,100161);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,73086,73201) || true) && (runspace == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,73086,73201);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,73140,73186);

throw f_1579_73146_73185("runspace");
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,73086,73201);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,73217,73238);

_runspace = runspace;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,73254,73322);

_unhandledBreakpointMode = UnhandledBreakpointProcessingMode.Ignore;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,73404,73469);

_runspace.RemoteDebuggerStop += HandleForwardedDebuggerStopEvent;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,73483,73574);

_runspace.RemoteDebuggerBreakpointUpdated += HandleForwardedDebuggerBreakpointUpdatedEvent;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1579,73015,73585);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,73015,73585);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,73015,73585);
}
		}

public override DebuggerCommandResults ProcessCommand(PSCommand command, PSDataCollection<PSObject> output)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,73909,79141);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,74041,74065);

f_1579_74041_74064(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,74079,74102);

_detachCommand = false;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,74118,74231) || true) && (command == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,74118,74231);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,74171,74216);

throw f_1579_74177_74215("command");
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,74118,74231);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,74247,74358) || true) && (output == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,74247,74358);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,74299,74343);

throw f_1579_74305_74342("output");
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,74247,74358);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,74374,74728) || true) && (f_1579_74378_74394_M(!DebuggerStopped))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,74374,74728);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,74428,74713);

throw f_1579_74434_74712(f_1579_74488_74542(), null, Debugger.CannotProcessCommandNotStopped, ErrorCategory.InvalidOperation, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,74374,74728);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,74744,74782);

DebuggerCommandResults 
results = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,74841,74869);

bool 
executionError = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,74883,78696);
using(_psDebuggerCommand = f_1579_74911_74932(this))            {
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,74966,75192);
foreach(var cmd in f_1579_74986_75002_I(f_1579_74986_75002(command)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,74966,75192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,75044,75116);

f_1579_75044_75115(                    cmd, PipelineResultTypes.All, PipelineResultTypes.Output);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,75138,75173);

f_1579_75138_75172(                    _psDebuggerCommand, cmd);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,74966,75192);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1579,1,227);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1579,1,227);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,75212,75289);

PSDataCollection<PSObject> 
internalOutput = f_1579_75256_75288()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,75307,76394);

internalOutput.DataAdded += (sender, args) =>
                    {
                        foreach (var item in internalOutput.ReadAll())
                        {
                            if (item == null) { return; }

                            DebuggerCommand dbgCmd = item.BaseObject as DebuggerCommand;
                            if (dbgCmd != null)
                            {
                                bool executedByDebugger = (dbgCmd.ResumeAction != null || dbgCmd.ExecutedByDebugger);
                                results = new DebuggerCommandResults(dbgCmd.ResumeAction, executedByDebugger);
                            }
                            else if (item.BaseObject is DebuggerCommandResults)
                            {
                                results = item.BaseObject as DebuggerCommandResults;
                            }
                            else
                            {
                                output.Add(item);
                            }
                        }
                    };

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,76458,76512);

f_1579_76458_76511(                    _psDebuggerCommand, null, internalOutput, null);
                }
                catch (Exception e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,76549,78681);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,76609,76631);

executionError = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,76653,76695);

RemoteException 
re = e as RemoteException
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,76717,78028) || true) && ((re != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1579, 76721, 76761)&&(f_1579_76738_76752(re)!= null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,76717,78028);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,76978,77360) || true) && (f_1579_76982_77016(f_1579_76982_77009(f_1579_76982_76996(re)))== f_1579_77020_77057(typeof(IncompleteParseException)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,76978,77360);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,77115,77333);

throw f_1579_77121_77332((DynAbs.Tracing.TraceSender.Conditional_F1(1579, 77184, 77218)||((                                (f_1579_77185_77209(f_1579_77185_77199(re))!= null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1579, 77221, 77253))||DynAbs.Tracing.TraceSender.Conditional_F3(1579, 77256, 77260)))?f_1579_77221_77253(f_1579_77221_77245(f_1579_77221_77235(re))):null, f_1579_77295_77331(f_1579_77295_77309(re)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,76978,77360);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,77570,78005) || true) && ((f_1579_77575_77609(f_1579_77575_77602(f_1579_77575_77589(re)))== f_1579_77613_77659(typeof(InvalidRunspacePoolStateException))) ||(DynAbs.Tracing.TraceSender.Expression_False(1579, 77574, 77761)||                            (f_1579_77694_77728(f_1579_77694_77721(f_1579_77694_77708(re)))== f_1579_77732_77760(typeof(RemoteException)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,77570,78005);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,77819,77978);

throw f_1579_77825_77977((DynAbs.Tracing.TraceSender.Conditional_F1(1579, 77892, 77926)||((                                (f_1579_77893_77917(f_1579_77893_77907(re))!= null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1579, 77929, 77961))||DynAbs.Tracing.TraceSender.Conditional_F3(1579, 77964, 77976)))?f_1579_77929_77961(f_1579_77929_77953(f_1579_77929_77943(re))):string.Empty);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,77570,78005);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,76717,78028);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,78221,78365) || true) && ((e is PSRemotingTransportException) ||(DynAbs.Tracing.TraceSender.Expression_False(1579, 78225, 78286)||(e is RemoteException)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,78221,78365);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,78336,78342);

throw;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,78221,78365);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,78389,78662);

f_1579_78389_78661(
                    output, f_1579_78426_78660(f_1579_78469_78659(e, "DebuggerError", ErrorCategory.InvalidOperation, null)));
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,76549,78681);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(1579,74883,78696);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,78712,78776);

executionError = executionError ||(DynAbs.Tracing.TraceSender.Expression_False(1579, 78729, 78775)||f_1579_78747_78775(_psDebuggerCommand));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,78790,78816);

_psDebuggerCommand = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,78899,79056);

_detachCommand = (!executionError) &&(DynAbs.Tracing.TraceSender.Expression_True(1579, 78916, 78965)&&(f_1579_78938_78960(f_1579_78938_78954(command))> 0) )&&(DynAbs.Tracing.TraceSender.Expression_True(1579, 78916, 79055)&&(f_1579_78970_79054(f_1579_78970_79001(f_1579_78970_78989(f_1579_78970_78986(command), 0)), "Detach", StringComparison.OrdinalIgnoreCase)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,79072,79130);

return results ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.DebuggerCommandResults>(1579, 79079, 79129)??f_1579_79090_79129(null, false));
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,73909,79141);

int
f_1579_74041_74064(System.Management.Automation.RemoteDebugger
this_param)
{
this_param.CheckForValidateState();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 74041, 74064);
return 0;
}


System.Management.Automation.PSArgumentNullException
f_1579_74177_74215(string
paramName)
{
var return_v = new System.Management.Automation.PSArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 74177, 74215);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1579_74305_74342(string
paramName)
{
var return_v = new System.Management.Automation.PSArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 74305, 74342);
return return_v;
}


bool
f_1579_74378_74394_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 74378, 74394);
return return_v;
}


string
f_1579_74488_74542()
{
var return_v =                     DebuggerStrings.CannotProcessDebuggerCommandNotStopped;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 74488, 74542);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1579_74434_74712(string
message,System.Exception
innerException,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
target)
{
var return_v = new System.Management.Automation.PSInvalidOperationException( message, innerException, errorId, errorCategory, target);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 74434, 74712);
return return_v;
}


System.Management.Automation.PowerShell
f_1579_74911_74932(System.Management.Automation.RemoteDebugger
this_param)
{
var return_v = this_param.GetNestedPowerShell();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 74911, 74932);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_1579_74986_75002(System.Management.Automation.PSCommand
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 74986, 75002);
return return_v;
}


int
f_1579_75044_75115(System.Management.Automation.Runspaces.Command
this_param,System.Management.Automation.Runspaces.PipelineResultTypes
myResult,System.Management.Automation.Runspaces.PipelineResultTypes
toResult)
{
this_param.MergeMyResults( myResult, toResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 75044, 75115);
return 0;
}


System.Management.Automation.PowerShell
f_1579_75138_75172(System.Management.Automation.PowerShell
this_param,System.Management.Automation.Runspaces.Command
command)
{
var return_v = this_param.AddCommand( command);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 75138, 75172);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_1579_74986_75002_I(System.Management.Automation.Runspaces.CommandCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 74986, 75002);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
f_1579_75256_75288()
{
var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 75256, 75288);
return return_v;
}


int
f_1579_76458_76511(System.Management.Automation.PowerShell
this_param,System.Collections.IEnumerable
input,System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
output,System.Management.Automation.PSInvocationSettings
settings)
{
this_param.Invoke<System.Management.Automation.PSObject>( input, (System.Collections.Generic.IList<System.Management.Automation.PSObject>)output, settings);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 76458, 76511);
return 0;
}


System.Management.Automation.ErrorRecord
f_1579_76738_76752(System.Management.Automation.RemoteException
this_param)
{
var return_v = this_param.ErrorRecord ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 76738, 76752);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1579_76982_76996(System.Management.Automation.RemoteException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 76982, 76996);
return return_v;
}


System.Management.Automation.ErrorCategoryInfo
f_1579_76982_77009(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.CategoryInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 76982, 77009);
return return_v;
}


string
f_1579_76982_77016(System.Management.Automation.ErrorCategoryInfo
this_param)
{
var return_v = this_param.Reason ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 76982, 77016);
return return_v;
}


string
f_1579_77020_77057(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 77020, 77057);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1579_77185_77199(System.Management.Automation.RemoteException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 77185, 77199);
return return_v;
}


System.Exception
f_1579_77185_77209(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.Exception ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 77185, 77209);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1579_77221_77235(System.Management.Automation.RemoteException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 77221, 77235);
return return_v;
}


System.Exception
f_1579_77221_77245(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 77221, 77245);
return return_v;
}


string
f_1579_77221_77253(System.Exception
this_param)
{
var return_v = this_param.Message ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 77221, 77253);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1579_77295_77309(System.Management.Automation.RemoteException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 77295, 77309);
return return_v;
}


string
f_1579_77295_77331(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.FullyQualifiedErrorId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 77295, 77331);
return return_v;
}


System.Management.Automation.IncompleteParseException
f_1579_77121_77332(string
message,string
errorId)
{
var return_v = new System.Management.Automation.IncompleteParseException( message, errorId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 77121, 77332);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1579_77575_77589(System.Management.Automation.RemoteException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 77575, 77589);
return return_v;
}


System.Management.Automation.ErrorCategoryInfo
f_1579_77575_77602(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.CategoryInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 77575, 77602);
return return_v;
}


string
f_1579_77575_77609(System.Management.Automation.ErrorCategoryInfo
this_param)
{
var return_v = this_param.Reason ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 77575, 77609);
return return_v;
}


string
f_1579_77613_77659(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 77613, 77659);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1579_77694_77708(System.Management.Automation.RemoteException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 77694, 77708);
return return_v;
}


System.Management.Automation.ErrorCategoryInfo
f_1579_77694_77721(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.CategoryInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 77694, 77721);
return return_v;
}


string
f_1579_77694_77728(System.Management.Automation.ErrorCategoryInfo
this_param)
{
var return_v = this_param.Reason ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 77694, 77728);
return return_v;
}


string
f_1579_77732_77760(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 77732, 77760);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1579_77893_77907(System.Management.Automation.RemoteException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 77893, 77907);
return return_v;
}


System.Exception
f_1579_77893_77917(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.Exception ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 77893, 77917);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1579_77929_77943(System.Management.Automation.RemoteException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 77929, 77943);
return return_v;
}


System.Exception
f_1579_77929_77953(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 77929, 77953);
return return_v;
}


string
f_1579_77929_77961(System.Exception
this_param)
{
var return_v = this_param.Message ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 77929, 77961);
return return_v;
}


System.Management.Automation.Remoting.PSRemotingTransportException
f_1579_77825_77977(string
message)
{
var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 77825, 77977);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1579_78469_78659(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 78469, 78659);
return return_v;
}


System.Management.Automation.PSObject
f_1579_78426_78660(System.Management.Automation.ErrorRecord
obj)
{
var return_v = new System.Management.Automation.PSObject( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 78426, 78660);
return return_v;
}


int
f_1579_78389_78661(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
this_param,System.Management.Automation.PSObject
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 78389, 78661);
return 0;
}


bool
f_1579_78747_78775(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.HadErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 78747, 78775);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_1579_78938_78954(System.Management.Automation.PSCommand
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 78938, 78954);
return return_v;
}


int
f_1579_78938_78960(System.Management.Automation.Runspaces.CommandCollection
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 78938, 78960);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_1579_78970_78986(System.Management.Automation.PSCommand
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 78970, 78986);
return return_v;
}


System.Management.Automation.Runspaces.Command
f_1579_78970_78989(System.Management.Automation.Runspaces.CommandCollection
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 78970, 78989);
return return_v;
}


string
f_1579_78970_79001(System.Management.Automation.Runspaces.Command
this_param)
{
var return_v = this_param.CommandText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 78970, 79001);
return return_v;
}


bool
f_1579_78970_79054(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 78970, 79054);
return return_v;
}


System.Management.Automation.DebuggerCommandResults
f_1579_79090_79129(System.Management.Automation.DebuggerResumeAction?
resumeAction,bool
evaluatedByDebugger)
{
var return_v = new System.Management.Automation.DebuggerCommandResults( resumeAction, evaluatedByDebugger);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 79090, 79129);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,73909,79141);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,73909,79141);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override void StopProcessCommand()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,79233,79569);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,79299,79323);

f_1579_79299_79322(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,79339,79374);

PowerShell 
ps = _psDebuggerCommand
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,79388,79558) || true) && ((ps != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1579, 79392, 79484)&&                (f_1579_79426_79454(f_1579_79426_79448(ps))== PSInvocationState.Running)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,79388,79558);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,79518,79543);

f_1579_79518_79542(                ps, null, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,79388,79558);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,79233,79569);

int
f_1579_79299_79322(System.Management.Automation.RemoteDebugger
this_param)
{
this_param.CheckForValidateState();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 79299, 79322);
return 0;
}


System.Management.Automation.PSInvocationStateInfo
f_1579_79426_79448(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.InvocationStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 79426, 79448);
return return_v;
}


System.Management.Automation.PSInvocationState
f_1579_79426_79454(System.Management.Automation.PSInvocationStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 79426, 79454);
return return_v;
}


System.IAsyncResult
f_1579_79518_79542(System.Management.Automation.PowerShell
this_param,System.AsyncCallback
callback,object
state)
{
var return_v = this_param.BeginStop( callback, state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 79518, 79542);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,79233,79569);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,79233,79569);
}
		}

public override void SetBreakpoints(IEnumerable<Breakpoint> breakpoints, int? runspaceId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,79911,80606);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,80095,80173);

f_1579_80095_80172(this, RemoteDebuggingCommands.SetBreakpoint);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,80189,80327);

var 
functionParameters = new Dictionary<string, object>
            {
                { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "BreakpointList",1579,80214,80326),breakpoints }            }
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,80343,80470) || true) && (f_1579_80347_80366(runspaceId))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,80343,80470);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,80400,80455);

f_1579_80400_80454(                functionParameters, "RunspaceId", f_1579_80437_80453(runspaceId));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,80343,80470);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,80486,80595);

f_1579_80486_80594(this, RemoteDebuggingCommands.SetBreakpoint, functionParameters);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,79911,80606);

int
f_1579_80095_80172(System.Management.Automation.RemoteDebugger
this_param,string
breakpointCommandNameToCheck)
{
this_param.CheckRemoteBreakpointManagementSupport( breakpointCommandNameToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 80095, 80172);
return 0;
}


bool
f_1579_80347_80366(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 80347, 80366);
return return_v;
}


int
f_1579_80437_80453(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 80437, 80453);
return return_v;
}


int
f_1579_80400_80454(System.Collections.Generic.Dictionary<string, object>
this_param,string
key,int
value)
{
this_param.Add( key, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 80400, 80454);
return 0;
}


System.Management.Automation.CommandBreakpoint
f_1579_80486_80594(System.Management.Automation.RemoteDebugger
this_param,string
functionName,System.Collections.Generic.Dictionary<string, object>
parameters)
{
var return_v = this_param.InvokeRemoteBreakpointFunction<System.Management.Automation.CommandBreakpoint>( functionName, parameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 80486, 80594);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,79911,80606);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,79911,80606);
}
		}

public override Breakpoint GetBreakpoint(int id, int? runspaceId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,81048,81698);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,81208,81286);

f_1579_81208_81285(this, RemoteDebuggingCommands.GetBreakpoint);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,81302,81419);

var 
functionParameters = new Dictionary<string, object>
            {
                { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "Id",1579,81327,81418),id }            }
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,81435,81562) || true) && (f_1579_81439_81458(runspaceId))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,81435,81562);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,81492,81547);

f_1579_81492_81546(                functionParameters, "RunspaceId", f_1579_81529_81545(runspaceId));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,81435,81562);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,81578,81687);

return f_1579_81585_81686(this, RemoteDebuggingCommands.GetBreakpoint, functionParameters);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,81048,81698);

int
f_1579_81208_81285(System.Management.Automation.RemoteDebugger
this_param,string
breakpointCommandNameToCheck)
{
this_param.CheckRemoteBreakpointManagementSupport( breakpointCommandNameToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 81208, 81285);
return 0;
}


bool
f_1579_81439_81458(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 81439, 81458);
return return_v;
}


int
f_1579_81529_81545(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 81529, 81545);
return return_v;
}


int
f_1579_81492_81546(System.Collections.Generic.Dictionary<string, object>
this_param,string
key,int
value)
{
this_param.Add( key, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 81492, 81546);
return 0;
}


System.Management.Automation.Breakpoint
f_1579_81585_81686(System.Management.Automation.RemoteDebugger
this_param,string
functionName,System.Collections.Generic.Dictionary<string, object>
parameters)
{
var return_v = this_param.InvokeRemoteBreakpointFunction<System.Management.Automation.Breakpoint>( functionName, parameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 81585, 81686);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,81048,81698);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,81048,81698);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override List<Breakpoint> GetBreakpoints(int? runspaceId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,82051,83219);
System.Exception ex = default(System.Exception);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,82210,82288);

f_1579_82210_82287(this, RemoteDebuggingCommands.GetBreakpoint);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,82304,82328);

f_1579_82304_82327(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,82344,82385);

var 
breakpoints = f_1579_82362_82384()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,82401,83173);
using(PowerShell 
ps = f_1579_82424_82445(this)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,82479,82532);

f_1579_82479_82531(                ps, RemoteDebuggingCommands.GetBreakpoint);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,82552,82684) || true) && (f_1579_82556_82575(runspaceId))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,82552,82684);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,82617,82665);

f_1579_82617_82664(                    ps, "RunspaceId", f_1579_82647_82663(runspaceId));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,82552,82684);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,82704,82756);

Collection<PSObject> 
output = f_1579_82734_82755(ps)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,82774,83158);
foreach(var item in f_1579_82795_82801_I(output) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,82774,83158);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,82843,83139) || true) && (f_1579_82847_82863_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(item, 1579, 82847, 82863)?.BaseObject)is Breakpoint bp)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,82843,83139);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,82930,82950);

f_1579_82930_82949(                        breakpoints, bp);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,82843,83139);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,82843,83139);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,83000,83139) || true) && (f_1579_83004_83057(item, out ex))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,83000,83139);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,83107,83116);

throw ex;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,83000,83139);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,82843,83139);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,82774,83158);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1579,1,385);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1579,1,385);
}DynAbs.Tracing.TraceSender.TraceExitUsing(1579,82401,83173);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,83189,83208);

return breakpoints;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,82051,83219);

int
f_1579_82210_82287(System.Management.Automation.RemoteDebugger
this_param,string
breakpointCommandNameToCheck)
{
this_param.CheckRemoteBreakpointManagementSupport( breakpointCommandNameToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 82210, 82287);
return 0;
}


int
f_1579_82304_82327(System.Management.Automation.RemoteDebugger
this_param)
{
this_param.CheckForValidateState();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 82304, 82327);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Breakpoint>
f_1579_82362_82384()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Breakpoint>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 82362, 82384);
return return_v;
}


System.Management.Automation.PowerShell
f_1579_82424_82445(System.Management.Automation.RemoteDebugger
this_param)
{
var return_v = this_param.GetNestedPowerShell();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 82424, 82445);
return return_v;
}


System.Management.Automation.PowerShell
f_1579_82479_82531(System.Management.Automation.PowerShell
this_param,string
cmdlet)
{
var return_v = this_param.AddCommand( cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 82479, 82531);
return return_v;
}


bool
f_1579_82556_82575(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 82556, 82575);
return return_v;
}


int
f_1579_82647_82663(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 82647, 82663);
return return_v;
}


System.Management.Automation.PowerShell
f_1579_82617_82664(System.Management.Automation.PowerShell
this_param,string
parameterName,int
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 82617, 82664);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1579_82734_82755(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Invoke<System.Management.Automation.PSObject>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 82734, 82755);
return return_v;
}


object
f_1579_82847_82863_M(object
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 82847, 82863);
return return_v;
}


int
f_1579_82930_82949(System.Collections.Generic.List<System.Management.Automation.Breakpoint>
this_param,System.Management.Automation.Breakpoint
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 82930, 82949);
return 0;
}


bool
f_1579_83004_83057(System.Management.Automation.PSObject
item,out System.Exception
exception)
{
var return_v = TryGetRemoteDebuggerException( item, out exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 83004, 83057);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1579_82795_82801_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 82795, 82801);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,82051,83219);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,82051,83219);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override CommandBreakpoint SetCommandBreakpoint(string command, ScriptBlock action, string path, int? runspaceId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,84016,84845);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,84231,84309);

f_1579_84231_84308(this, RemoteDebuggingCommands.SetBreakpoint);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,84337,84412);

Breakpoint 
breakpoint = f_1579_84361_84411(path, null, command, action)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,84426,84559);

var 
functionParameters = new Dictionary<string, object>
            {
                { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "Breakpoint",1579,84451,84558),breakpoint }            }
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,84575,84702) || true) && (f_1579_84579_84598(runspaceId))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,84575,84702);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,84632,84687);

f_1579_84632_84686(                functionParameters, "RunspaceId", f_1579_84669_84685(runspaceId));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,84575,84702);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,84718,84834);

return f_1579_84725_84833(this, RemoteDebuggingCommands.SetBreakpoint, functionParameters);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,84016,84845);

int
f_1579_84231_84308(System.Management.Automation.RemoteDebugger
this_param,string
breakpointCommandNameToCheck)
{
this_param.CheckRemoteBreakpointManagementSupport( breakpointCommandNameToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 84231, 84308);
return 0;
}


System.Management.Automation.CommandBreakpoint
f_1579_84361_84411(string
script,System.Management.Automation.WildcardPattern
command,string
commandString,System.Management.Automation.ScriptBlock
action)
{
var return_v = new System.Management.Automation.CommandBreakpoint( script, command, commandString, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 84361, 84411);
return return_v;
}


bool
f_1579_84579_84598(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 84579, 84598);
return return_v;
}


int
f_1579_84669_84685(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 84669, 84685);
return return_v;
}


int
f_1579_84632_84686(System.Collections.Generic.Dictionary<string, object>
this_param,string
key,int
value)
{
this_param.Add( key, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 84632, 84686);
return 0;
}


System.Management.Automation.CommandBreakpoint
f_1579_84725_84833(System.Management.Automation.RemoteDebugger
this_param,string
functionName,System.Collections.Generic.Dictionary<string, object>
parameters)
{
var return_v = this_param.InvokeRemoteBreakpointFunction<System.Management.Automation.CommandBreakpoint>( functionName, parameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 84725, 84833);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,84016,84845);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,84016,84845);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override LineBreakpoint SetLineBreakpoint(string path, int line, int column, ScriptBlock action, int? runspaceId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,85784,86596);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,85999,86077);

f_1579_85999_86076(this, RemoteDebuggingCommands.SetBreakpoint);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,86093,86164);

Breakpoint 
breakpoint = f_1579_86117_86163(path, line, column, action)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,86180,86313);

var 
functionParameters = new Dictionary<string, object>
            {
                { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "Breakpoint",1579,86205,86312),breakpoint }            }
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,86329,86456) || true) && (f_1579_86333_86352(runspaceId))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,86329,86456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,86386,86441);

f_1579_86386_86440(                functionParameters, "RunspaceId", f_1579_86423_86439(runspaceId));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,86329,86456);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,86472,86585);

return f_1579_86479_86584(this, RemoteDebuggingCommands.SetBreakpoint, functionParameters);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,85784,86596);

int
f_1579_85999_86076(System.Management.Automation.RemoteDebugger
this_param,string
breakpointCommandNameToCheck)
{
this_param.CheckRemoteBreakpointManagementSupport( breakpointCommandNameToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 85999, 86076);
return 0;
}


System.Management.Automation.LineBreakpoint
f_1579_86117_86163(string
script,int
line,int
column,System.Management.Automation.ScriptBlock
action)
{
var return_v = new System.Management.Automation.LineBreakpoint( script, line, column, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 86117, 86163);
return return_v;
}


bool
f_1579_86333_86352(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 86333, 86352);
return return_v;
}


int
f_1579_86423_86439(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 86423, 86439);
return return_v;
}


int
f_1579_86386_86440(System.Collections.Generic.Dictionary<string, object>
this_param,string
key,int
value)
{
this_param.Add( key, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 86386, 86440);
return 0;
}


System.Management.Automation.LineBreakpoint
f_1579_86479_86584(System.Management.Automation.RemoteDebugger
this_param,string
functionName,System.Collections.Generic.Dictionary<string, object>
parameters)
{
var return_v = this_param.InvokeRemoteBreakpointFunction<System.Management.Automation.LineBreakpoint>( functionName, parameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 86479, 86584);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,85784,86596);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,85784,86596);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override VariableBreakpoint SetVariableBreakpoint(string variableName, VariableAccessMode accessMode, ScriptBlock action, string path, int? runspaceId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,87540,88410);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,87793,87871);

f_1579_87793_87870(this, RemoteDebuggingCommands.SetBreakpoint);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,87887,87974);

Breakpoint 
breakpoint = f_1579_87911_87973(path, variableName, accessMode, action)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,87990,88123);

var 
functionParameters = new Dictionary<string, object>
            {
                { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "Breakpoint",1579,88015,88122),breakpoint }            }
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,88139,88266) || true) && (f_1579_88143_88162(runspaceId))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,88139,88266);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,88196,88251);

f_1579_88196_88250(                functionParameters, "RunspaceId", f_1579_88233_88249(runspaceId));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,88139,88266);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,88282,88399);

return f_1579_88289_88398(this, RemoteDebuggingCommands.SetBreakpoint, functionParameters);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,87540,88410);

int
f_1579_87793_87870(System.Management.Automation.RemoteDebugger
this_param,string
breakpointCommandNameToCheck)
{
this_param.CheckRemoteBreakpointManagementSupport( breakpointCommandNameToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 87793, 87870);
return 0;
}


System.Management.Automation.VariableBreakpoint
f_1579_87911_87973(string
script,string
variable,System.Management.Automation.VariableAccessMode
accessMode,System.Management.Automation.ScriptBlock
action)
{
var return_v = new System.Management.Automation.VariableBreakpoint( script, variable, accessMode, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 87911, 87973);
return return_v;
}


bool
f_1579_88143_88162(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 88143, 88162);
return return_v;
}


int
f_1579_88233_88249(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 88233, 88249);
return return_v;
}


int
f_1579_88196_88250(System.Collections.Generic.Dictionary<string, object>
this_param,string
key,int
value)
{
this_param.Add( key, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 88196, 88250);
return 0;
}


System.Management.Automation.VariableBreakpoint
f_1579_88289_88398(System.Management.Automation.RemoteDebugger
this_param,string
functionName,System.Collections.Generic.Dictionary<string, object>
parameters)
{
var return_v = this_param.InvokeRemoteBreakpointFunction<System.Management.Automation.VariableBreakpoint>( functionName, parameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 88289, 88398);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,87540,88410);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,87540,88410);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override bool RemoveBreakpoint(Breakpoint breakpoint, int? runspaceId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,88892,89665);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,89064,89145);

f_1579_89064_89144(this, RemoteDebuggingCommands.RemoveBreakpoint);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,89161,89245) || true) && (breakpoint == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,89161,89245);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,89217,89230);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,89161,89245);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,89261,89389);

var 
functionParameters = new Dictionary<string, object>
            {
                { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "Id",1579,89286,89388),f_1579_89357_89370(breakpoint)}            }
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,89405,89532) || true) && (f_1579_89409_89428(runspaceId))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,89405,89532);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,89462,89517);

f_1579_89462_89516(                functionParameters, "RunspaceId", f_1579_89499_89515(runspaceId));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,89405,89532);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,89548,89654);

return f_1579_89555_89653(this, RemoteDebuggingCommands.RemoveBreakpoint, functionParameters);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,88892,89665);

int
f_1579_89064_89144(System.Management.Automation.RemoteDebugger
this_param,string
breakpointCommandNameToCheck)
{
this_param.CheckRemoteBreakpointManagementSupport( breakpointCommandNameToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 89064, 89144);
return 0;
}


int
f_1579_89357_89370(System.Management.Automation.Breakpoint
this_param)
{
var return_v = this_param.Id ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 89357, 89370);
return return_v;
}


bool
f_1579_89409_89428(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 89409, 89428);
return return_v;
}


int
f_1579_89499_89515(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 89499, 89515);
return return_v;
}


int
f_1579_89462_89516(System.Collections.Generic.Dictionary<string, object>
this_param,string
key,int
value)
{
this_param.Add( key, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 89462, 89516);
return 0;
}


bool
f_1579_89555_89653(System.Management.Automation.RemoteDebugger
this_param,string
functionName,System.Collections.Generic.Dictionary<string, object>
parameters)
{
var return_v = this_param.InvokeRemoteBreakpointFunction<bool>( functionName, parameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 89555, 89653);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,88892,89665);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,88892,89665);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override Breakpoint EnableBreakpoint(Breakpoint breakpoint, int? runspaceId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,90166,90950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,90344,90425);

f_1579_90344_90424(this, RemoteDebuggingCommands.EnableBreakpoint);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,90441,90524) || true) && (breakpoint == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,90441,90524);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,90497,90509);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,90441,90524);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,90540,90668);

var 
functionParameters = new Dictionary<string, object>
            {
                { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "Id",1579,90565,90667),f_1579_90636_90649(breakpoint)}            }
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,90684,90811) || true) && (f_1579_90688_90707(runspaceId))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,90684,90811);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,90741,90796);

f_1579_90741_90795(                functionParameters, "RunspaceId", f_1579_90778_90794(runspaceId));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,90684,90811);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,90827,90939);

return f_1579_90834_90938(this, RemoteDebuggingCommands.EnableBreakpoint, functionParameters);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,90166,90950);

int
f_1579_90344_90424(System.Management.Automation.RemoteDebugger
this_param,string
breakpointCommandNameToCheck)
{
this_param.CheckRemoteBreakpointManagementSupport( breakpointCommandNameToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 90344, 90424);
return 0;
}


int
f_1579_90636_90649(System.Management.Automation.Breakpoint
this_param)
{
var return_v = this_param.Id ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 90636, 90649);
return return_v;
}


bool
f_1579_90688_90707(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 90688, 90707);
return return_v;
}


int
f_1579_90778_90794(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 90778, 90794);
return return_v;
}


int
f_1579_90741_90795(System.Collections.Generic.Dictionary<string, object>
this_param,string
key,int
value)
{
this_param.Add( key, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 90741, 90795);
return 0;
}


System.Management.Automation.Breakpoint
f_1579_90834_90938(System.Management.Automation.RemoteDebugger
this_param,string
functionName,System.Collections.Generic.Dictionary<string, object>
parameters)
{
var return_v = this_param.InvokeRemoteBreakpointFunction<System.Management.Automation.Breakpoint>( functionName, parameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 90834, 90938);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,90166,90950);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,90166,90950);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override Breakpoint DisableBreakpoint(Breakpoint breakpoint, int? runspaceId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,91452,92239);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,91631,91713);

f_1579_91631_91712(this, RemoteDebuggingCommands.DisableBreakpoint);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,91729,91812) || true) && (breakpoint == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,91729,91812);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,91785,91797);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,91729,91812);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,91828,91956);

var 
functionParameters = new Dictionary<string, object>
            {
                { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "Id",1579,91853,91955),f_1579_91924_91937(breakpoint)}            }
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,91972,92099) || true) && (f_1579_91976_91995(runspaceId))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,91972,92099);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,92029,92084);

f_1579_92029_92083(                functionParameters, "RunspaceId", f_1579_92066_92082(runspaceId));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,91972,92099);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,92115,92228);

return f_1579_92122_92227(this, RemoteDebuggingCommands.DisableBreakpoint, functionParameters);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,91452,92239);

int
f_1579_91631_91712(System.Management.Automation.RemoteDebugger
this_param,string
breakpointCommandNameToCheck)
{
this_param.CheckRemoteBreakpointManagementSupport( breakpointCommandNameToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 91631, 91712);
return 0;
}


int
f_1579_91924_91937(System.Management.Automation.Breakpoint
this_param)
{
var return_v = this_param.Id ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 91924, 91937);
return return_v;
}


bool
f_1579_91976_91995(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 91976, 91995);
return return_v;
}


int
f_1579_92066_92082(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 92066, 92082);
return return_v;
}


int
f_1579_92029_92083(System.Collections.Generic.Dictionary<string, object>
this_param,string
key,int
value)
{
this_param.Add( key, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 92029, 92083);
return 0;
}


System.Management.Automation.Breakpoint
f_1579_92122_92227(System.Management.Automation.RemoteDebugger
this_param,string
functionName,System.Collections.Generic.Dictionary<string, object>
parameters)
{
var return_v = this_param.InvokeRemoteBreakpointFunction<System.Management.Automation.Breakpoint>( functionName, parameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 92122, 92227);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,91452,92239);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,91452,92239);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override void SetDebuggerAction(DebuggerResumeAction resumeAction)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,92400,93111);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,92498,92522);

f_1579_92498_92521(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,92538,92587);

f_1579_92538_92586(this, false, RunspaceAvailability.Busy);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,92603,93100);
using(PowerShell 
ps = f_1579_92626_92647(this)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,92681,92781);

f_1579_92681_92780(f_1579_92681_92737(                ps, RemoteDebuggingCommands.SetDebuggerAction), "ResumeAction", resumeAction);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,92799,92811);

f_1579_92799_92810(                ps);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,92905,93085) || true) && (f_1579_92909_92929(f_1579_92909_92923(ps))> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,92905,93085);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,92975,93017);

Exception 
e = f_1579_92989_93016(f_1579_92989_93006(f_1579_92989_93003(ps), 0))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,93039,93066) || true) && (e != null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,93039,93066);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,93056,93064);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,93039,93066);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,92905,93085);
}
DynAbs.Tracing.TraceSender.TraceExitUsing(1579,92603,93100);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,92400,93111);

int
f_1579_92498_92521(System.Management.Automation.RemoteDebugger
this_param)
{
this_param.CheckForValidateState();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 92498, 92521);
return 0;
}


int
f_1579_92538_92586(System.Management.Automation.RemoteDebugger
this_param,bool
remoteDebug,System.Management.Automation.Runspaces.RunspaceAvailability
availability)
{
this_param.SetRemoteDebug( remoteDebug, (System.Management.Automation.Runspaces.RunspaceAvailability?)availability);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 92538, 92586);
return 0;
}


System.Management.Automation.PowerShell
f_1579_92626_92647(System.Management.Automation.RemoteDebugger
this_param)
{
var return_v = this_param.GetNestedPowerShell();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 92626, 92647);
return return_v;
}


System.Management.Automation.PowerShell
f_1579_92681_92737(System.Management.Automation.PowerShell
this_param,string
cmdlet)
{
var return_v = this_param.AddCommand( cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 92681, 92737);
return return_v;
}


System.Management.Automation.PowerShell
f_1579_92681_92780(System.Management.Automation.PowerShell
this_param,string
parameterName,System.Management.Automation.DebuggerResumeAction
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 92681, 92780);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1579_92799_92810(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 92799, 92810);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
f_1579_92909_92923(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.ErrorBuffer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 92909, 92923);
return return_v;
}


int
f_1579_92909_92929(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 92909, 92929);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
f_1579_92989_93003(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.ErrorBuffer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 92989, 93003);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1579_92989_93006(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 92989, 93006);
return return_v;
}


System.Exception
f_1579_92989_93016(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 92989, 93016);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,92400,93111);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,92400,93111);
}
		}

public override DebuggerStopEventArgs GetDebuggerStopArgs()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,93258,94116);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,93342,93366);

f_1579_93342_93365(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,93382,93419);

DebuggerStopEventArgs 
rtnArgs = null
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,93471,93998);
using(PowerShell 
ps = f_1579_93494_93515(this)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,93557,93616);

f_1579_93557_93615(                    ps, RemoteDebuggingCommands.GetDebuggerStopArgs);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,93638,93690);

Collection<PSObject> 
output = f_1579_93668_93689(ps)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,93712,93979);
foreach(var item in f_1579_93733_93739_I(output) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,93712,93979);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,93789,93820) || true) && (item == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,93789,93820);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,93809,93818);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,93789,93820);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,93848,93899);

rtnArgs = f_1579_93858_93873(item)as DebuggerStopEventArgs;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,93925,93956) || true) && (rtnArgs != null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,93925,93956);
DynAbs.Tracing.TraceSender.TraceBreak(1579,93948,93954);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,93925,93956);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,93712,93979);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1579,1,268);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1579,1,268);
}DynAbs.Tracing.TraceSender.TraceExitUsing(1579,93471,93998);
                }
            }
            catch (Exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,94027,94074);
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,94027,94074);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,94090,94105);

return rtnArgs;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,93258,94116);

int
f_1579_93342_93365(System.Management.Automation.RemoteDebugger
this_param)
{
this_param.CheckForValidateState();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 93342, 93365);
return 0;
}


System.Management.Automation.PowerShell
f_1579_93494_93515(System.Management.Automation.RemoteDebugger
this_param)
{
var return_v = this_param.GetNestedPowerShell();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 93494, 93515);
return return_v;
}


System.Management.Automation.PowerShell
f_1579_93557_93615(System.Management.Automation.PowerShell
this_param,string
cmdlet)
{
var return_v = this_param.AddCommand( cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 93557, 93615);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1579_93668_93689(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Invoke<System.Management.Automation.PSObject>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 93668, 93689);
return return_v;
}


object
f_1579_93858_93873(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.BaseObject ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 93858, 93873);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1579_93733_93739_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 93733, 93739);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,93258,94116);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,93258,94116);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override void SetDebugMode(DebugModes mode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,94243,94995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,94318,94342);

f_1579_94318_94341(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,94477,94640) || true) && ((f_1579_94482_94521(_runspace)!= null) ||(DynAbs.Tracing.TraceSender.Expression_False(1579, 94481, 94584)||                (f_1579_94552_94575(_runspace)!= null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,94477,94640);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,94618,94625);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,94477,94640);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,94656,94898);
using(PowerShell 
ps = f_1579_94679_94700(this)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,94734,94756);

f_1579_94734_94755(                ps, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,94774,94853);

f_1579_94774_94852(f_1579_94774_94825(                ps, RemoteDebuggingCommands.SetDebugMode), "Mode", mode);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,94871,94883);

f_1579_94871_94882(                ps);
DynAbs.Tracing.TraceSender.TraceExitUsing(1579,94656,94898);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,94914,94938);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetDebugMode(mode),1579,94914,94937);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,94954,94984);

f_1579_94954_94983(this, _breakpointCount);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,94243,94995);

int
f_1579_94318_94341(System.Management.Automation.RemoteDebugger
this_param)
{
this_param.CheckForValidateState();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 94318, 94341);
return 0;
}


System.Management.Automation.Runspaces.Pipeline
f_1579_94482_94521(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.GetCurrentlyRunningPipeline();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 94482, 94521);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
f_1579_94552_94575(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RemoteCommand ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 94552, 94575);
return return_v;
}


System.Management.Automation.PowerShell
f_1579_94679_94700(System.Management.Automation.RemoteDebugger
this_param)
{
var return_v = this_param.GetNestedPowerShell();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 94679, 94700);
return return_v;
}


int
f_1579_94734_94755(System.Management.Automation.PowerShell
this_param,bool
isNested)
{
this_param.SetIsNested( isNested);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 94734, 94755);
return 0;
}


System.Management.Automation.PowerShell
f_1579_94774_94825(System.Management.Automation.PowerShell
this_param,string
cmdlet)
{
var return_v = this_param.AddCommand( cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 94774, 94825);
return return_v;
}


System.Management.Automation.PowerShell
f_1579_94774_94852(System.Management.Automation.PowerShell
this_param,string
parameterName,System.Management.Automation.DebugModes
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 94774, 94852);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1579_94871_94882(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 94871, 94882);
return return_v;
}


int
f_1579_94954_94983(System.Management.Automation.RemoteDebugger
this_param,int
breakpointCount)
{
this_param.SetIsActive( breakpointCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 94954, 94983);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,94243,94995);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,94243,94995);
}
		}

public override void SetDebuggerStepMode(bool enabled)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,95174,96201);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,95253,95277);

f_1579_95253_95276(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,95363,95514) || true) && (!f_1579_95368_95458(_remoteDebuggingCapability, RemoteDebuggingCommands.SetDebuggerStepMode))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,95363,95514);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,95492,95499);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,95363,95514);
}

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,95622,95690);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetDebugMode(DebugModes.LocalScript | DebugModes.RemoteScript),1579,95622,95689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,95776,96066);
using(PowerShell 
ps = f_1579_95799_95820(this)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,95862,95954);

f_1579_95862_95953(f_1579_95862_95920(                    ps, RemoteDebuggingCommands.SetDebuggerStepMode), "Enabled", enabled);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,95976,95988);

f_1579_95976_95987(                    ps);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,96010,96047);

_isDebuggerSteppingEnabled = enabled;
DynAbs.Tracing.TraceSender.TraceExitUsing(1579,95776,96066);
                }
            }
            catch (Exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,96095,96190);
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,96095,96190);
                // Don't propagate exceptions.
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,95174,96201);

int
f_1579_95253_95276(System.Management.Automation.RemoteDebugger
this_param)
{
this_param.CheckForValidateState();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 95253, 95276);
return 0;
}


bool
f_1579_95368_95458(System.Management.Automation.Remoting.RemoteDebuggingCapability
this_param,string
commandName)
{
var return_v = this_param.IsCommandSupported( commandName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 95368, 95458);
return return_v;
}


System.Management.Automation.PowerShell
f_1579_95799_95820(System.Management.Automation.RemoteDebugger
this_param)
{
var return_v = this_param.GetNestedPowerShell();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 95799, 95820);
return return_v;
}


System.Management.Automation.PowerShell
f_1579_95862_95920(System.Management.Automation.PowerShell
this_param,string
cmdlet)
{
var return_v = this_param.AddCommand( cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 95862, 95920);
return return_v;
}


System.Management.Automation.PowerShell
f_1579_95862_95953(System.Management.Automation.PowerShell
this_param,string
parameterName,bool
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 95862, 95953);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1579_95976_95987(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 95976, 95987);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,95174,96201);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,95174,96201);
}
		}

public override bool IsActive
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,96374,96399);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,96380,96397);

return _isActive;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,96374,96399);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,96320,96410);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,96320,96410);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override bool InBreakpoint
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,96587,96737);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,96623,96722);

return _handleDebuggerStop ||(DynAbs.Tracing.TraceSender.Expression_False(1579, 96630, 96721)||(f_1579_96654_96684(_runspace)== RunspaceAvailability.RemoteDebug));
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,96587,96737);

System.Management.Automation.Runspaces.RunspaceAvailability
f_1579_96654_96684(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspaceAvailability ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 96654, 96684);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,96529,96748);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,96529,96748);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override DebuggerCommand InternalProcessCommand(string command, IList<PSObject> output)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,96964,97134);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,97085,97123);

throw f_1579_97091_97122();
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,96964,97134);

System.Management.Automation.PSNotImplementedException
f_1579_97091_97122()
{
var return_v = new System.Management.Automation.PSNotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 97091, 97122);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,96964,97134);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,96964,97134);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool IsRemote
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,97272,97292);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,97278,97290);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,97272,97292);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,97216,97303);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,97216,97303);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override UnhandledBreakpointProcessingMode UnhandledBreakpointMode
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,97827,97910);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,97863,97895);

return _unhandledBreakpointMode;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,97827,97910);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,97727,98744);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,97727,98744);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,97926,98733);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,97962,97986);

f_1579_97962_97985(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,98080,98250) || true) && (!f_1579_98085_98182(_remoteDebuggingCapability, RemoteDebuggingCommands.SetUnhandledBreakpointMode))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,98080,98250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,98224,98231);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,98080,98250);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,98270,98321);

f_1579_98270_98320(this, false, null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,98413,98665);
using(PowerShell 
ps = f_1579_98436_98457(this)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,98499,98612);

f_1579_98499_98611(f_1579_98499_98564(                    ps, RemoteDebuggingCommands.SetUnhandledBreakpointMode), "UnhandledBreakpointMode", value);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,98634,98646);

f_1579_98634_98645(                    ps);
DynAbs.Tracing.TraceSender.TraceExitUsing(1579,98413,98665);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,98685,98718);

_unhandledBreakpointMode = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,97926,98733);

int
f_1579_97962_97985(System.Management.Automation.RemoteDebugger
this_param)
{
this_param.CheckForValidateState();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 97962, 97985);
return 0;
}


bool
f_1579_98085_98182(System.Management.Automation.Remoting.RemoteDebuggingCapability
this_param,string
commandName)
{
var return_v = this_param.IsCommandSupported( commandName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 98085, 98182);
return return_v;
}


int
f_1579_98270_98320(System.Management.Automation.RemoteDebugger
this_param,bool
remoteDebug,System.Management.Automation.Runspaces.RunspaceAvailability?
availability)
{
this_param.SetRemoteDebug( remoteDebug, availability);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 98270, 98320);
return 0;
}


System.Management.Automation.PowerShell
f_1579_98436_98457(System.Management.Automation.RemoteDebugger
this_param)
{
var return_v = this_param.GetNestedPowerShell();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 98436, 98457);
return return_v;
}


System.Management.Automation.PowerShell
f_1579_98499_98564(System.Management.Automation.PowerShell
this_param,string
cmdlet)
{
var return_v = this_param.AddCommand( cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 98499, 98564);
return return_v;
}


System.Management.Automation.PowerShell
f_1579_98499_98611(System.Management.Automation.PowerShell
this_param,string
parameterName,System.Management.Automation.UnhandledBreakpointProcessingMode
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 98499, 98611);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1579_98634_98645(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 98634, 98645);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,97727,98744);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,97727,98744);
}
		}}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,98878,99298);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,98924,98989);

_runspace.RemoteDebuggerStop -= HandleForwardedDebuggerStopEvent;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,99003,99094);

_runspace.RemoteDebuggerBreakpointUpdated -= HandleForwardedDebuggerBreakpointUpdatedEvent;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,99121,99279) || true) && (_identityToPersonate != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,99121,99279);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,99187,99218);

f_1579_99187_99217(                _identityToPersonate);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,99236,99264);

_identityToPersonate = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,99121,99279);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,98878,99298);

int
f_1579_99187_99217(System.Security.Principal.WindowsIdentity
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 99187, 99217);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,98878,99298);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,98878,99298);
}
		}

internal void CheckStateAndRaiseStopEvent()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,99729,99981);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,99797,99852);

DebuggerStopEventArgs 
stopArgs = f_1579_99830_99851(this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,99866,99970) || true) && (stopArgs != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,99866,99970);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,99920,99955);

f_1579_99920_99954(this, stopArgs);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,99866,99970);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,99729,99981);

System.Management.Automation.DebuggerStopEventArgs
f_1579_99830_99851(System.Management.Automation.RemoteDebugger
this_param)
{
var return_v = this_param.GetDebuggerStopArgs();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 99830, 99851);
return return_v;
}


int
f_1579_99920_99954(System.Management.Automation.RemoteDebugger
this_param,System.Management.Automation.DebuggerStopEventArgs
args)
{
this_param.ProcessDebuggerStopEvent( args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 99920, 99954);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,99729,99981);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,99729,99981);
}
		}

internal bool IsRemoteDebug
{            private set;
            get;
}

internal void SetClientDebugInfo(
            DebugModes? debugMode,
            bool inBreakpoint,
            int breakpointCount,
            bool breakAll,
            UnhandledBreakpointProcessingMode unhandledBreakpointMode,
            Version serverPSVersion)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,100708,101719);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,101006,101247) || true) && (debugMode != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,101006,101247);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,101061,101090);

_remoteDebugSupported = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,101108,101136);

DebugMode = f_1579_101120_101135(debugMode);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,101006,101247);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,101006,101247);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,101202,101232);

_remoteDebugSupported = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,101006,101247);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,101263,101383) || true) && (inBreakpoint)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,101263,101383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,101313,101368);

f_1579_101313_101367(this, true, RunspaceAvailability.RemoteDebug);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,101263,101383);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,101399,101497);

_remoteDebuggingCapability = f_1579_101428_101496(serverPSVersion);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,101513,101548);

_breakpointCount = breakpointCount;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,101562,101600);

_isDebuggerSteppingEnabled = breakAll;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,101614,101665);

_unhandledBreakpointMode = unhandledBreakpointMode;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,101679,101708);

f_1579_101679_101707(this, breakpointCount);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,100708,101719);

System.Management.Automation.DebugModes
f_1579_101120_101135(System.Management.Automation.DebugModes?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 101120, 101135);
return return_v;
}


int
f_1579_101313_101367(System.Management.Automation.RemoteDebugger
this_param,bool
remoteDebug,System.Management.Automation.Runspaces.RunspaceAvailability
availability)
{
this_param.SetRemoteDebug( remoteDebug, (System.Management.Automation.Runspaces.RunspaceAvailability?)availability);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 101313, 101367);
return 0;
}


System.Management.Automation.Remoting.RemoteDebuggingCapability
f_1579_101428_101496(System.Version
powerShellVersion)
{
var return_v = RemoteDebuggingCapability.CreateDebuggingCapability( powerShellVersion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 101428, 101496);
return return_v;
}


int
f_1579_101679_101707(System.Management.Automation.RemoteDebugger
this_param,int
breakpointCount)
{
this_param.SetIsActive( breakpointCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 101679, 101707);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,100708,101719);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,100708,101719);
}
		}

internal void OnCommandStopped()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,101932,102088);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,101989,102077) || true) && (f_1579_101993_102006())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,101989,102077);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,102040,102062);

IsRemoteDebug = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,101989,102077);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,101932,102088);

bool
f_1579_101993_102006()
{
var return_v = IsRemoteDebug;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 101993, 102006);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,101932,102088);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,101932,102088);
}
		}

internal void SendBreakpointUpdatedEvents()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,102293,103584);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,102361,102510) || true) && (!f_1579_102366_102410(this)||(DynAbs.Tracing.TraceSender.Expression_False(1579, 102365, 102454)||                (_breakpointCount == 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,102361,102510);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,102488,102495);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,102361,102510);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,102526,102600);

PSDataCollection<PSObject> 
breakpoints = f_1579_102567_102599()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,102709,103099);
using(PowerShell 
ps = f_1579_102732_102753(this)
)            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,102787,102983) || true) && (f_1579_102791_102809_M(!this.InBreakpoint))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,102787,102983);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,102942,102964);

f_1579_102942_102963(                    // Can't use nested PowerShell if we are not stopped in a breakpoint.
                    ps, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,102787,102983);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,103003,103037);

f_1579_103003_103036(
                ps, "Get-PSBreakpoint");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,103055,103084);

f_1579_103055_103083(                ps, null, breakpoints);
DynAbs.Tracing.TraceSender.TraceExitUsing(1579,102709,103099);
            }
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,103192,103573);
foreach(PSObject obj in f_1579_103217_103228_I(breakpoints) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,103192,103573);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,103262,103315);

Breakpoint 
breakpoint = f_1579_103286_103300(obj)as Breakpoint
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,103333,103558) || true) && (breakpoint != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,103333,103558);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,103397,103539);

f_1579_103397_103538(this, f_1579_103451_103537(breakpoint, BreakpointUpdateType.Set, _breakpointCount));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,103333,103558);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,103192,103573);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1579,1,382);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1579,1,382);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1579,102293,103584);

bool
f_1579_102366_102410(System.Management.Automation.RemoteDebugger
this_param)
{
var return_v = this_param.IsDebuggerBreakpointUpdatedEventSubscribed();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 102366, 102410);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
f_1579_102567_102599()
{
var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 102567, 102599);
return return_v;
}


System.Management.Automation.PowerShell
f_1579_102732_102753(System.Management.Automation.RemoteDebugger
this_param)
{
var return_v = this_param.GetNestedPowerShell();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 102732, 102753);
return return_v;
}


bool
f_1579_102791_102809_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 102791, 102809);
return return_v;
}


int
f_1579_102942_102963(System.Management.Automation.PowerShell
this_param,bool
isNested)
{
this_param.SetIsNested( isNested);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 102942, 102963);
return 0;
}


System.Management.Automation.PowerShell
f_1579_103003_103036(System.Management.Automation.PowerShell
this_param,string
cmdlet)
{
var return_v = this_param.AddCommand( cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 103003, 103036);
return return_v;
}


int
f_1579_103055_103083(System.Management.Automation.PowerShell
this_param,System.Collections.IEnumerable
input,System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
output)
{
this_param.Invoke<System.Management.Automation.PSObject>( input, (System.Collections.Generic.IList<System.Management.Automation.PSObject>)output);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 103055, 103083);
return 0;
}


object
f_1579_103286_103300(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.BaseObject ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 103286, 103300);
return return_v;
}


System.Management.Automation.BreakpointUpdatedEventArgs
f_1579_103451_103537(System.Management.Automation.Breakpoint
breakpoint,System.Management.Automation.BreakpointUpdateType
updateType,int
breakpointCount)
{
var return_v = new System.Management.Automation.BreakpointUpdatedEventArgs( breakpoint, updateType, breakpointCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 103451, 103537);
return return_v;
}


int
f_1579_103397_103538(System.Management.Automation.RemoteDebugger
this_param,System.Management.Automation.BreakpointUpdatedEventArgs
args)
{
this_param.RaiseBreakpointUpdatedEvent( args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 103397, 103538);
return 0;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
f_1579_103217_103228_I(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 103217, 103228);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,102293,103584);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,102293,103584);
}
		}

internal override bool IsDebuggerSteppingEnabled
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,103756,103798);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,103762,103796);

return _isDebuggerSteppingEnabled;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,103756,103798);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,103683,103809);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,103683,103809);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private static bool TryGetRemoteDebuggerException(
            PSObject item,
            out Exception exception)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1579,103878,104862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,104019,104036);

exception = null;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,104050,104128) || true) && (item == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,104050,104128);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,104100,104113);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,104050,104128);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,104144,104175);

bool 
haveExceptionType = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,104189,104443);
foreach(var typeName in f_1579_104214_104228_I(f_1579_104214_104228(item)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,104189,104443);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,104262,104428) || true) && (f_1579_104266_104314(typeName, "Deserialized.System.Exception"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,104262,104428);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,104356,104381);

haveExceptionType = true;
DynAbs.Tracing.TraceSender.TraceBreak(1579,104403,104409);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,104262,104428);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,104189,104443);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1579,1,255);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1579,1,255);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,104459,104822) || true) && (haveExceptionType)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,104459,104822);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,104514,104583);

var 
errorMessage = f_1579_104533_104566_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_1579_104533_104559(f_1579_104533_104548(item), "Message"), 1579, 104533, 104566)?.Value)??(DynAbs.Tracing.TraceSender.Expression_Null<object>(1579, 104533, 104582)??string.Empty)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,104601,104777);

exception = f_1579_104613_104776(f_1579_104655_104775(f_1579_104699_104741(), f_1579_104743_104760(f_1579_104743_104757(item), 0), errorMessage));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,104795,104807);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,104459,104822);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,104838,104851);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1579,103878,104862);

System.Collections.ObjectModel.Collection<string>
f_1579_104214_104228(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 104214, 104228);
return return_v;
}


bool
f_1579_104266_104314(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 104266, 104314);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1579_104214_104228_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 104214, 104228);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1579_104533_104548(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 104533, 104548);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1579_104533_104559(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 104533, 104559);
return return_v;
}


object
f_1579_104533_104566_M(object
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 104533, 104566);
return return_v;
}


string
f_1579_104699_104741()
{
var return_v =                         RemotingErrorIdStrings.RemoteDebuggerError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 104699, 104741);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1579_104743_104757(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 104743, 104757);
return return_v;
}


string
f_1579_104743_104760(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 104743, 104760);
return return_v;
}


string
f_1579_104655_104775(string
formatSpec,string
o1,object
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 104655, 104775);
return return_v;
}


System.Management.Automation.RemoteException
f_1579_104613_104776(string
message)
{
var return_v = new System.Management.Automation.RemoteException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 104613, 104776);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,103878,104862);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,103878,104862);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void HandleForwardedDebuggerStopEvent(object sender, PSEventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,104927,105521);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,105027,105143);

f_1579_105027_105142(f_1579_105038_105057(f_1579_105038_105050(e))== 1, "Forwarded debugger stop event args must always contain one SourceArgs item.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,105157,105184);

DebuggerStopEventArgs 
args
=default(DebuggerStopEventArgs);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,105198,105463) || true) && (f_1579_105202_105214(e)[0] is PSObject)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,105198,105463);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,105263,105334);

args = f_1579_105270_105308(((PSObject)f_1579_105281_105293(e)[0]))as DebuggerStopEventArgs;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,105198,105463);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,105198,105463);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,105400,105448);

args = f_1579_105407_105419(e)[0] as DebuggerStopEventArgs;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,105198,105463);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,105479,105510);

f_1579_105479_105509(this, args);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,104927,105521);

object[]
f_1579_105038_105050(System.Management.Automation.PSEventArgs
this_param)
{
var return_v = this_param.SourceArgs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 105038, 105050);
return return_v;
}


int
f_1579_105038_105057(object[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 105038, 105057);
return return_v;
}


int
f_1579_105027_105142(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 105027, 105142);
return 0;
}


object[]
f_1579_105202_105214(System.Management.Automation.PSEventArgs
this_param)
{
var return_v = this_param.SourceArgs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 105202, 105214);
return return_v;
}


object[]
f_1579_105281_105293(System.Management.Automation.PSEventArgs
this_param)
{
var return_v = this_param.SourceArgs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 105281, 105293);
return return_v;
}


object
f_1579_105270_105308(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.BaseObject ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 105270, 105308);
return return_v;
}


object[]
f_1579_105407_105419(System.Management.Automation.PSEventArgs
this_param)
{
var return_v = this_param.SourceArgs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 105407, 105419);
return return_v;
}


int
f_1579_105479_105509(System.Management.Automation.RemoteDebugger
this_param,System.Management.Automation.DebuggerStopEventArgs
args)
{
this_param.ProcessDebuggerStopEvent( args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 105479, 105509);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,104927,105521);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,104927,105521);
}
		}

private void ProcessDebuggerStopEvent(DebuggerStopEventArgs args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,105533,107054);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,105837,105873) || true) && (_handleDebuggerStop)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,105837,105873);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,105864,105871);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,105837,105873);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,106037,106141);

PowerShell 
powershell = f_1579_106061_106140(f_1579_106061_106110(f_1579_106061_106083(_runspace)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,106155,106249);

AsyncResult 
invokeAsyncResult = (DynAbs.Tracing.TraceSender.Conditional_F1(1579, 106187, 106207)||(((powershell != null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1579, 106210, 106241))||DynAbs.Tracing.TraceSender.Conditional_F3(1579, 106244, 106248)))?f_1579_106210_106241(powershell):null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,106265,106301);

bool 
invokedOnBlockedThread = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,106315,106576) || true) && ((invokeAsyncResult != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1579, 106319, 106382)&&(f_1579_106351_106381_M(!invokeAsyncResult.IsCompleted))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,106315,106576);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,106416,106561);

invokedOnBlockedThread = f_1579_106441_106560(invokeAsyncResult, ProcessDebuggerStopEventProc, args);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,106315,106576);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,106592,107043) || true) && (!invokedOnBlockedThread)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,106592,107043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,106716,106875);

f_1579_106716_106874(_identityToPersonate, ProcessDebuggerStopEventProc, args);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,106592,107043);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,105533,107054);

System.Management.Automation.Runspaces.RunspacePool
f_1579_106061_106083(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 106061, 106083);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_106061_106110(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 106061, 106110);
return return_v;
}


System.Management.Automation.PowerShell
f_1579_106061_106140(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.GetCurrentRunningPowerShell();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 106061, 106140);
return return_v;
}


System.Management.Automation.Runspaces.AsyncResult
f_1579_106210_106241(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.EndInvokeAsyncResult ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 106210, 106241);
return return_v;
}


bool
f_1579_106351_106381_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 106351, 106381);
return return_v;
}


bool
f_1579_106441_106560(System.Management.Automation.Runspaces.AsyncResult
this_param,System.Threading.WaitCallback
callback,System.Management.Automation.DebuggerStopEventArgs
state)
{
var return_v = this_param.InvokeCallbackOnThread( callback, (object)state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 106441, 106560);
return return_v;
}


int
f_1579_106716_106874(System.Security.Principal.WindowsIdentity
identityToImpersonate,System.Threading.WaitCallback
threadProc,System.Management.Automation.DebuggerStopEventArgs
state)
{
Utils.QueueWorkItemWithImpersonation( identityToImpersonate, threadProc, (object)state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 106716, 106874);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,105533,107054);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,105533,107054);
}
		}

private void ProcessDebuggerStopEventProc(object state)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,107066,109953);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,107146,107217);

RunspaceAvailability 
prevAvailability = f_1579_107186_107216(_runspace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,107231,107263);

bool 
restoreAvailability = true
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,107315,107342);

_handleDebuggerStop = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,107411,107466);

f_1579_107411_107465(this, true, RunspaceAvailability.RemoteDebug);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,107541,107601);

DebuggerStopEventArgs 
args = state as DebuggerStopEventArgs
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,107619,109382) || true) && (args != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,107619,109382);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,107677,108912) || true) && (f_1579_107681_107712(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,107677,108912);
                        try
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,107869,107903);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.RaiseDebuggerStopEvent(args),1579,107869,107902);
                        }
                        finally
                        {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1579,107956,108281);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,108020,108048);

_handleDebuggerStop = false;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,108078,108254) || true) && (!_detachCommand &&(DynAbs.Tracing.TraceSender.Expression_True(1579, 108082, 108120)&&f_1579_108101_108120_M(!args.SuspendRemote)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,108078,108254);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,108186,108223);

f_1579_108186_108222(this, f_1579_108204_108221(args));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,108078,108254);
}
DynAbs.Tracing.TraceSender.TraceExitFinally(1579,107956,108281);
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,107677,108912);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,107677,108912);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,108807,108835);

restoreAvailability = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,108861,108889);

_handleDebuggerStop = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,107677,108912);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,107619,109382);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,107619,109382);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,109264,109292);

_handleDebuggerStop = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,109314,109363);

f_1579_109314_109362(this, DebuggerResumeAction.Continue);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,107619,109382);
}
            }
            catch (Exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,109411,109504);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,109461,109489);

_handleDebuggerStop = false;
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,109411,109504);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1579,109518,109942);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,109609,109805) || true) && (restoreAvailability &&(DynAbs.Tracing.TraceSender.Expression_True(1579, 109613, 109704)&&(f_1579_109637_109667(_runspace)== RunspaceAvailability.RemoteDebug)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,109609,109805);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,109746,109786);

f_1579_109746_109785(this, false, prevAvailability);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,109609,109805);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,109825,109927) || true) && (_detachCommand)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,109825,109927);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,109885,109908);

_detachCommand = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,109825,109927);
}
DynAbs.Tracing.TraceSender.TraceExitFinally(1579,109518,109942);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,107066,109953);

System.Management.Automation.Runspaces.RunspaceAvailability
f_1579_107186_107216(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspaceAvailability;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 107186, 107216);
return return_v;
}


int
f_1579_107411_107465(System.Management.Automation.RemoteDebugger
this_param,bool
remoteDebug,System.Management.Automation.Runspaces.RunspaceAvailability
availability)
{
this_param.SetRemoteDebug( remoteDebug, (System.Management.Automation.Runspaces.RunspaceAvailability?)availability);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 107411, 107465);
return 0;
}


bool
f_1579_107681_107712(System.Management.Automation.RemoteDebugger
this_param)
{
var return_v = this_param.IsDebuggerStopEventSubscribed();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 107681, 107712);
return return_v;
}


bool
f_1579_108101_108120_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 108101, 108120);
return return_v;
}


System.Management.Automation.DebuggerResumeAction
f_1579_108204_108221(System.Management.Automation.DebuggerStopEventArgs
this_param)
{
var return_v = this_param.ResumeAction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 108204, 108221);
return return_v;
}


int
f_1579_108186_108222(System.Management.Automation.RemoteDebugger
this_param,System.Management.Automation.DebuggerResumeAction
resumeAction)
{
this_param.SetDebuggerAction( resumeAction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 108186, 108222);
return 0;
}


int
f_1579_109314_109362(System.Management.Automation.RemoteDebugger
this_param,System.Management.Automation.DebuggerResumeAction
resumeAction)
{
this_param.SetDebuggerAction( resumeAction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 109314, 109362);
return 0;
}


System.Management.Automation.Runspaces.RunspaceAvailability
f_1579_109637_109667(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspaceAvailability ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 109637, 109667);
return return_v;
}


int
f_1579_109746_109785(System.Management.Automation.RemoteDebugger
this_param,bool
remoteDebug,System.Management.Automation.Runspaces.RunspaceAvailability
availability)
{
this_param.SetRemoteDebug( remoteDebug, (System.Management.Automation.Runspaces.RunspaceAvailability?)availability);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 109746, 109785);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,107066,109953);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,107066,109953);
}
		}

private void HandleForwardedDebuggerBreakpointUpdatedEvent(object sender, PSEventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,109965,110495);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,110078,110200);

f_1579_110078_110199(f_1579_110089_110108(f_1579_110089_110101(e))== 1, "Forwarded debugger breakpoint event args must always contain one SourceArgs item.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,110214,110296);

BreakpointUpdatedEventArgs 
bpArgs = f_1579_110250_110262(e)[0] as BreakpointUpdatedEventArgs
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,110312,110484) || true) && (bpArgs != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,110312,110484);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,110364,110410);

f_1579_110364_110409(this, f_1579_110386_110408(bpArgs));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,110428,110469);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.RaiseBreakpointUpdatedEvent(bpArgs),1579,110428,110468);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,110312,110484);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,109965,110495);

object[]
f_1579_110089_110101(System.Management.Automation.PSEventArgs
this_param)
{
var return_v = this_param.SourceArgs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 110089, 110101);
return return_v;
}


int
f_1579_110089_110108(object[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 110089, 110108);
return return_v;
}


int
f_1579_110078_110199(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 110078, 110199);
return 0;
}


object[]
f_1579_110250_110262(System.Management.Automation.PSEventArgs
this_param)
{
var return_v = this_param.SourceArgs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 110250, 110262);
return return_v;
}


int
f_1579_110386_110408(System.Management.Automation.BreakpointUpdatedEventArgs
this_param)
{
var return_v = this_param.BreakpointCount;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 110386, 110408);
return return_v;
}


int
f_1579_110364_110409(System.Management.Automation.RemoteDebugger
this_param,int
bpCount)
{
this_param.UpdateBreakpointCount( bpCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 110364, 110409);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,109965,110495);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,109965,110495);
}
		}

private PowerShell GetNestedPowerShell()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,110507,110718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,110572,110608);

PowerShell 
ps = f_1579_110588_110607()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,110622,110646);

ps.Runspace = _runspace;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,110660,110681);

f_1579_110660_110680(            ps, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,110697,110707);

return ps;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,110507,110718);

System.Management.Automation.PowerShell
f_1579_110588_110607()
{
var return_v = PowerShell.Create();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 110588, 110607);
return return_v;
}


int
f_1579_110660_110680(System.Management.Automation.PowerShell
this_param,bool
isNested)
{
this_param.SetIsNested( isNested);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 110660, 110680);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,110507,110718);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,110507,110718);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void CheckForValidateState()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,110730,111880);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,110791,111414) || true) && (!_remoteDebugSupported)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,110791,111414);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,110851,111399);

throw f_1579_110857_111398(f_1579_111121_111225(f_1579_111139_111197(), f_1579_111199_111224()), null, "RemoteDebugger:RemoteDebuggingNotSupported", ErrorCategory.NotImplemented, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,110791,111414);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,111430,111582) || true) && (f_1579_111434_111467(f_1579_111434_111461(_runspace))!= RunspaceState.Opened)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,111430,111582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,111525,111567);

throw f_1579_111531_111566();
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,111430,111582);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,111609,111861) || true) && (!_identityPersonationChecked)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,111609,111861);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,111675,111710);

_identityPersonationChecked = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,111780,111846);

f_1579_111780_111845(out _identityToPersonate);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,111609,111861);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,110730,111880);

string
f_1579_111139_111197()
{
var return_v = RemotingErrorIdStrings.RemoteDebuggingEndpointVersionError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 111139, 111197);
return return_v;
}


System.Version
f_1579_111199_111224()
{
var return_v = PSVersionInfo.PSV4Version;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 111199, 111224);
return return_v;
}


string
f_1579_111121_111225(string
formatSpec,System.Version
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 111121, 111225);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1579_110857_111398(string
message,System.Exception
innerException,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
target)
{
var return_v = new System.Management.Automation.PSInvalidOperationException( message, innerException, errorId, errorCategory, target);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 110857, 111398);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1579_111434_111461(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 111434, 111461);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1579_111434_111467(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 111434, 111467);
return return_v;
}


System.Management.Automation.Runspaces.InvalidRunspaceStateException
f_1579_111531_111566()
{
var return_v = new System.Management.Automation.Runspaces.InvalidRunspaceStateException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 111531, 111566);
return return_v;
}


bool
f_1579_111780_111845(out System.Security.Principal.WindowsIdentity
impersonatedIdentity)
{
var return_v = Utils.TryGetWindowsImpersonatedIdentity( out impersonatedIdentity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 111780, 111845);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,110730,111880);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,110730,111880);
}
		}

private void SetRemoteDebug(bool remoteDebug, RunspaceAvailability? availability)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,111892,112949);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,111998,112115) || true) && (f_1579_112002_112035(f_1579_112002_112029(_runspace))!= RunspaceState.Opened)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,111998,112115);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,112093,112100);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,111998,112115);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,112131,112340) || true) && (f_1579_112135_112148()!= remoteDebug)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,112131,112340);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,112197,112225);

IsRemoteDebug = remoteDebug;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,112243,112325);

f_1579_112243_112292(f_1579_112243_112265(_runspace)).IsRemoteDebugStop = remoteDebug;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,112131,112340);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,112356,112938) || true) && (availability != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,112356,112938);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,112414,112472);

RunspaceAvailability 
newAvailability = f_1579_112453_112471(availability)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,112492,112923) || true) && ((f_1579_112497_112527(_runspace)!= newAvailability) &&(DynAbs.Tracing.TraceSender.Expression_True(1579, 112496, 112642)&&                    (remoteDebug ||(DynAbs.Tracing.TraceSender.Expression_False(1579, 112573, 112641)||(newAvailability != RunspaceAvailability.RemoteDebug)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,112492,112923);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,112736,112796);

f_1579_112736_112795(                        _runspace, newAvailability, true);
                    }
                    catch (Exception)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,112841,112904);
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,112841,112904);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,112492,112923);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,112356,112938);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,111892,112949);

System.Management.Automation.Runspaces.RunspaceStateInfo
f_1579_112002_112029(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 112002, 112029);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1579_112002_112035(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 112002, 112035);
return return_v;
}


bool
f_1579_112135_112148()
{
var return_v = IsRemoteDebug;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 112135, 112148);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1579_112243_112265(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 112243, 112265);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1579_112243_112292(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 112243, 112292);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceAvailability
f_1579_112453_112471(System.Management.Automation.Runspaces.RunspaceAvailability?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 112453, 112471);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceAvailability
f_1579_112497_112527(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspaceAvailability ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 112497, 112527);
return return_v;
}


int
f_1579_112736_112795(System.Management.Automation.RemoteRunspace
this_param,System.Management.Automation.Runspaces.RunspaceAvailability
availability,bool
raiseEvent)
{
this_param.UpdateRunspaceAvailability( availability, raiseEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 112736, 112795);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,111892,112949);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,111892,112949);
}
		}

private void UpdateBreakpointCount(int bpCount)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,112961,113106);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,113033,113060);

_breakpointCount = bpCount;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,113074,113095);

f_1579_113074_113094(this, bpCount);
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,112961,113106);

int
f_1579_113074_113094(System.Management.Automation.RemoteDebugger
this_param,int
breakpointCount)
{
this_param.SetIsActive( breakpointCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 113074, 113094);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,112961,113106);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,112961,113106);
}
		}

private void SetIsActive(int breakpointCount)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,113118,113667);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,113188,113428) || true) && ((f_1579_113193_113202()& DebugModes.RemoteScript) == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,113188,113428);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,113349,113386) || true) && (_isActive)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,113349,113386);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,113366,113384);

_isActive = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,113349,113386);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,113406,113413);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,113188,113428);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,113444,113656) || true) && (breakpointCount > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,113444,113656);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,113501,113538) || true) && (!_isActive)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,113501,113538);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,113519,113536);

_isActive = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,113501,113538);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,113444,113656);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,113444,113656);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,113604,113641) || true) && (_isActive)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,113604,113641);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,113621,113639);

_isActive = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,113604,113641);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,113444,113656);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,113118,113667);

System.Management.Automation.DebugModes
f_1579_113193_113202()
{
var return_v = DebugMode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 113193, 113202);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,113118,113667);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,113118,113667);
}
		}

private T InvokeRemoteBreakpointFunction<T>(string functionName, Dictionary<string, object> parameters)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,113679,115094);
System.Exception ex = default(System.Exception);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,113807,113831);

f_1579_113807_113830(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,113847,115083);
using(PowerShell 
ps = f_1579_113870_113891(this)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,113925,113953);

f_1579_113925_113952(                ps, functionName);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,113971,114135);
foreach(var parameterName in f_1579_114001_114016_I(f_1579_114001_114016(parameters)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,113971,114135);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,114058,114116);

f_1579_114058_114115(                    ps, parameterName, f_1579_114089_114114(parameters, parameterName));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,113971,114135);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1579,1,165);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1579,1,165);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,114155,114207);

Collection<PSObject> 
output = f_1579_114185_114206(ps)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,114301,114548) || true) && (f_1579_114305_114325(f_1579_114305_114319(ps))> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,114301,114548);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,114371,114413);

Exception 
e = f_1579_114385_114412(f_1579_114385_114402(f_1579_114385_114399(ps), 0))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,114435,114529) || true) && (e != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,114435,114529);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,114498,114506);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,114435,114529);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,114301,114548);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,114655,115030);
foreach(var item in f_1579_114676_114682_I(output) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,114655,115030);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,114724,114848) || true) && (f_1579_114728_114744_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(item, 1579, 114728, 114744)?.BaseObject)is T)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,114724,114848);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,114799,114825);

return (T)f_1579_114809_114824(item);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,114724,114848);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,114872,115011) || true) && (f_1579_114876_114929(item, out ex))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,114872,115011);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,114979,114988);

throw ex;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,114872,115011);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,114655,115030);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1579,1,376);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1579,1,376);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,115050,115068);

return default(T);
DynAbs.Tracing.TraceSender.TraceExitUsing(1579,113847,115083);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,113679,115094);

int
f_1579_113807_113830(System.Management.Automation.RemoteDebugger
this_param)
{
this_param.CheckForValidateState();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 113807, 113830);
return 0;
}


System.Management.Automation.PowerShell
f_1579_113870_113891(System.Management.Automation.RemoteDebugger
this_param)
{
var return_v = this_param.GetNestedPowerShell();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 113870, 113891);
return return_v;
}


System.Management.Automation.PowerShell
f_1579_113925_113952(System.Management.Automation.PowerShell
this_param,string
cmdlet)
{
var return_v = this_param.AddCommand( cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 113925, 113952);
return return_v;
}


System.Collections.Generic.Dictionary<string, object>.KeyCollection
f_1579_114001_114016(System.Collections.Generic.Dictionary<string, object>
this_param)
{
var return_v = this_param.Keys;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 114001, 114016);
return return_v;
}


object
f_1579_114089_114114(System.Collections.Generic.Dictionary<string, object>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 114089, 114114);
return return_v;
}


System.Management.Automation.PowerShell
f_1579_114058_114115(System.Management.Automation.PowerShell
this_param,string
parameterName,object
value)
{
var return_v = this_param.AddParameter( parameterName, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 114058, 114115);
return return_v;
}


System.Collections.Generic.Dictionary<string, object>.KeyCollection
f_1579_114001_114016_I(System.Collections.Generic.Dictionary<string, object>.KeyCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 114001, 114016);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1579_114185_114206(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Invoke<System.Management.Automation.PSObject>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 114185, 114206);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
f_1579_114305_114319(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.ErrorBuffer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 114305, 114319);
return return_v;
}


int
f_1579_114305_114325(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 114305, 114325);
return return_v;
}


System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
f_1579_114385_114399(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.ErrorBuffer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 114385, 114399);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1579_114385_114402(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 114385, 114402);
return return_v;
}


System.Exception
f_1579_114385_114412(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 114385, 114412);
return return_v;
}


object
f_1579_114728_114744_M(object
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 114728, 114744);
return return_v;
}


object
f_1579_114809_114824(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.BaseObject;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 114809, 114824);
return return_v;
}


bool
f_1579_114876_114929(System.Management.Automation.PSObject
item,out System.Exception
exception)
{
var return_v = TryGetRemoteDebuggerException( item, out exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 114876, 114929);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1579_114676_114682_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 114676, 114682);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,113679,115094);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,113679,115094);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void CheckRemoteBreakpointManagementSupport(string breakpointCommandNameToCheck)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,115106,115823);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,115219,115435) || true) && (_remoteBreakpointManagementIsSupported == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,115219,115435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,115303,115420);

_remoteBreakpointManagementIsSupported = f_1579_115344_115419(_remoteDebuggingCapability, breakpointCommandNameToCheck);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,115219,115435);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,115451,115812) || true) && (f_1579_115455_115500_M(!_remoteBreakpointManagementIsSupported.Value))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,115451,115812);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,115534,115797);

throw f_1579_115540_115796(f_1579_115590_115795(f_1579_115634_115697(), f_1579_115724_115794(breakpointCommandNameToCheck)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,115451,115812);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,115106,115823);

bool
f_1579_115344_115419(System.Management.Automation.Remoting.RemoteDebuggingCapability
this_param,string
commandName)
{
var return_v = this_param.IsCommandSupported( commandName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 115344, 115419);
return return_v;
}


bool
f_1579_115455_115500_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 115455, 115500);
return return_v;
}


string
f_1579_115634_115697()
{
var return_v =                         DebuggerStrings.CommandNotSupportedForRemoteUseInServerDebugger;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 115634, 115697);
return return_v;
}


string
f_1579_115724_115794(string
commandName)
{
var return_v = RemoteDebuggingCommands.CleanCommandName( commandName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 115724, 115794);
return return_v;
}


string
f_1579_115590_115795(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 115590, 115795);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1579_115540_115796(string
message)
{
var return_v = new System.Management.Automation.PSNotSupportedException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 115540, 115796);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,115106,115823);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,115106,115823);
}
		}

static RemoteDebugger()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1579,71166,115852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,72102,72163);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,72294,72381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,72451,72481);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,72512,72540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,72571,72616);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,72647,72675);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,72706,72764);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1579,71166,115852);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,71166,115852);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1579,71166,115852);

System.Management.Automation.PSArgumentNullException
f_1579_73146_73185(string
paramName)
{
var return_v = new System.Management.Automation.PSArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 73146, 73185);
return return_v;
}

}
internal class RemoteSessionStateProxy : SessionStateProxy
{
private RemoteRunspace _runspace;

internal RemoteSessionStateProxy(RemoteRunspace runspace)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1579,116035,116232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,116015,116024);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,116262,116297);
this._isInNoLanguageModeException = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,116326,116369);
this._getVariableCommandNotFoundException = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,116398,116441);
this._setVariableCommandNotFoundException = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,116117,116186);

f_1579_116117_116185(runspace != null, "Caller should validate the parameter");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,116200,116221);

_runspace = runspace;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1579,116035,116232);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,116035,116232);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,116035,116232);
}
		}

private Exception _isInNoLanguageModeException ;

private Exception _getVariableCommandNotFoundException ;

private Exception _setVariableCommandNotFoundException ;

public override void SetVariable(string name, object value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,117143,119051);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,117227,117345) || true) && (name == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,117227,117345);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,117277,117330);

throw f_1579_117283_117329("name");
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,117227,117345);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,117493,117603) || true) && (_setVariableCommandNotFoundException != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,117493,117603);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,117560,117603);

throw _setVariableCommandNotFoundException;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,117493,117603);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,117792,117845);

Pipeline 
remotePipeline = f_1579_117818_117844(_runspace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,117859,117935);

Command 
command = f_1579_117877_117934("Microsoft.PowerShell.Utility\\Set-Variable")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,117949,117986);

f_1579_117949_117985(f_1579_117949_117967(command), "Name", name);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,118000,118039);

f_1579_118000_118038(f_1579_118000_118018(command), "Value", value);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,118053,118090);

f_1579_118053_118089(f_1579_118053_118076(remotePipeline), command);

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,118142,118166);

f_1579_118142_118165(                remotePipeline);
            }
            catch (RemoteException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,118195,118661);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,118253,118646) || true) && (f_1579_118257_118371("CommandNotFoundException", f_1579_118299_118334(f_1579_118299_118312(e)), StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,118253,118646);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,118413,118533);

_setVariableCommandNotFoundException = f_1579_118452_118532(f_1579_118480_118528(), e);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,118555,118598);

throw _setVariableCommandNotFoundException;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,118253,118646);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,118253,118646);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,118640,118646);

throw;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,118253,118646);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,118195,118661);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,118677,119040) || true) && (f_1579_118681_118707(f_1579_118681_118701(remotePipeline))> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,118677,119040);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,118845,118906);

ErrorRecord 
error = (ErrorRecord)f_1579_118878_118905(f_1579_118878_118898(remotePipeline))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,118924,119025);

throw f_1579_118930_119024(f_1579_118958_119006(), f_1579_119008_119023(error));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,118677,119040);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,117143,119051);

System.Management.Automation.PSArgumentNullException
f_1579_117283_117329(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 117283, 117329);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1579_117818_117844(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.CreatePipeline();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 117818, 117844);
return return_v;
}


System.Management.Automation.Runspaces.Command
f_1579_117877_117934(string
command)
{
var return_v = new System.Management.Automation.Runspaces.Command( command);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 117877, 117934);
return return_v;
}


System.Management.Automation.Runspaces.CommandParameterCollection
f_1579_117949_117967(System.Management.Automation.Runspaces.Command
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 117949, 117967);
return return_v;
}


int
f_1579_117949_117985(System.Management.Automation.Runspaces.CommandParameterCollection
this_param,string
name,string
value)
{
this_param.Add( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 117949, 117985);
return 0;
}


System.Management.Automation.Runspaces.CommandParameterCollection
f_1579_118000_118018(System.Management.Automation.Runspaces.Command
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 118000, 118018);
return return_v;
}


int
f_1579_118000_118038(System.Management.Automation.Runspaces.CommandParameterCollection
this_param,string
name,object
value)
{
this_param.Add( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 118000, 118038);
return 0;
}


System.Management.Automation.Runspaces.CommandCollection
f_1579_118053_118076(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 118053, 118076);
return return_v;
}


int
f_1579_118053_118089(System.Management.Automation.Runspaces.CommandCollection
this_param,System.Management.Automation.Runspaces.Command
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 118053, 118089);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1579_118142_118165(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 118142, 118165);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1579_118299_118312(System.Management.Automation.RemoteException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 118299, 118312);
return return_v;
}


string
f_1579_118299_118334(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.FullyQualifiedErrorId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 118299, 118334);
return return_v;
}


bool
f_1579_118257_118371(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 118257, 118371);
return return_v;
}


string
f_1579_118480_118528()
{
var return_v = RunspaceStrings.NotSupportedOnRestrictedRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 118480, 118528);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1579_118452_118532(string
message,System.Management.Automation.RemoteException
innerException)
{
var return_v = new System.Management.Automation.PSNotSupportedException( message, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 118452, 118532);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1579_118681_118701(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Error;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 118681, 118701);
return return_v;
}


int
f_1579_118681_118707(System.Management.Automation.Runspaces.PipelineReader<object>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 118681, 118707);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1579_118878_118898(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Error;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 118878, 118898);
return return_v;
}


object
f_1579_118878_118905(System.Management.Automation.Runspaces.PipelineReader<object>
this_param)
{
var return_v = this_param.Read();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 118878, 118905);
return return_v;
}


string
f_1579_118958_119006()
{
var return_v = RunspaceStrings.NotSupportedOnRestrictedRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 118958, 119006);
return return_v;
}


System.Exception
f_1579_119008_119023(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 119008, 119023);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1579_118930_119024(string
message,System.Exception
innerException)
{
var return_v = new System.Management.Automation.PSNotSupportedException( message, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 118930, 119024);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,117143,119051);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,117143,119051);
}
		}

public override object GetVariable(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,119746,122158);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,119818,119936) || true) && (name == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,119818,119936);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,119868,119921);

throw f_1579_119874_119920("name");
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,119818,119936);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,120084,120194) || true) && (_getVariableCommandNotFoundException != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,120084,120194);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,120151,120194);

throw _getVariableCommandNotFoundException;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,120084,120194);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,120383,120436);

Pipeline 
remotePipeline = f_1579_120409_120435(_runspace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,120450,120526);

Command 
command = f_1579_120468_120525("Microsoft.PowerShell.Utility\\Get-Variable")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,120540,120577);

f_1579_120540_120576(f_1579_120540_120558(command), "Name", name);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,120591,120628);

f_1579_120591_120627(f_1579_120591_120614(remotePipeline), command);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,120642,120708);

System.Collections.ObjectModel.Collection<PSObject> 
result = null
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,120760,120793);

result = f_1579_120769_120792(remotePipeline);
            }
            catch (RemoteException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,120822,121288);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,120880,121273) || true) && (f_1579_120884_120998("CommandNotFoundException", f_1579_120926_120961(f_1579_120926_120939(e)), StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,120880,121273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,121040,121160);

_getVariableCommandNotFoundException = f_1579_121079_121159(f_1579_121107_121155(), e);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,121182,121225);

throw _getVariableCommandNotFoundException;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,120880,121273);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,120880,121273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,121267,121273);

throw;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,120880,121273);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,120822,121288);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,121304,122000) || true) && (f_1579_121308_121334(f_1579_121308_121328(remotePipeline))> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,121304,122000);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,121472,121533);

ErrorRecord 
error = (ErrorRecord)f_1579_121505_121532(f_1579_121505_121525(remotePipeline))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,121551,121985) || true) && (f_1579_121555_121661("CommandNotFoundException", f_1579_121597_121624(error), StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,121551,121985);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,121703,121804);

throw f_1579_121709_121803(f_1579_121737_121785(), f_1579_121787_121802(error));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,121551,121985);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,121551,121985);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,121886,121966);

throw f_1579_121892_121965(f_1579_121924_121947(f_1579_121924_121939(error)), f_1579_121949_121964(error));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,121551,121985);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,121304,122000);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,122016,122147) || true) && (f_1579_122020_122032(result)!= 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,122016,122147);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,122056,122068);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,122016,122147);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,122016,122147);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,122104,122147);

return f_1579_122111_122146(f_1579_122111_122140(f_1579_122111_122131(f_1579_122111_122120(result, 0)), "Value"));
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,122016,122147);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,119746,122158);

System.Management.Automation.PSArgumentNullException
f_1579_119874_119920(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 119874, 119920);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1579_120409_120435(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.CreatePipeline();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 120409, 120435);
return return_v;
}


System.Management.Automation.Runspaces.Command
f_1579_120468_120525(string
command)
{
var return_v = new System.Management.Automation.Runspaces.Command( command);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 120468, 120525);
return return_v;
}


System.Management.Automation.Runspaces.CommandParameterCollection
f_1579_120540_120558(System.Management.Automation.Runspaces.Command
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 120540, 120558);
return return_v;
}


int
f_1579_120540_120576(System.Management.Automation.Runspaces.CommandParameterCollection
this_param,string
name,string
value)
{
this_param.Add( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 120540, 120576);
return 0;
}


System.Management.Automation.Runspaces.CommandCollection
f_1579_120591_120614(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 120591, 120614);
return return_v;
}


int
f_1579_120591_120627(System.Management.Automation.Runspaces.CommandCollection
this_param,System.Management.Automation.Runspaces.Command
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 120591, 120627);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1579_120769_120792(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 120769, 120792);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1579_120926_120939(System.Management.Automation.RemoteException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 120926, 120939);
return return_v;
}


string
f_1579_120926_120961(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.FullyQualifiedErrorId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 120926, 120961);
return return_v;
}


bool
f_1579_120884_120998(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 120884, 120998);
return return_v;
}


string
f_1579_121107_121155()
{
var return_v = RunspaceStrings.NotSupportedOnRestrictedRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 121107, 121155);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1579_121079_121159(string
message,System.Management.Automation.RemoteException
innerException)
{
var return_v = new System.Management.Automation.PSNotSupportedException( message, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 121079, 121159);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1579_121308_121328(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Error;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 121308, 121328);
return return_v;
}


int
f_1579_121308_121334(System.Management.Automation.Runspaces.PipelineReader<object>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 121308, 121334);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1579_121505_121525(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Error;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 121505, 121525);
return return_v;
}


object
f_1579_121505_121532(System.Management.Automation.Runspaces.PipelineReader<object>
this_param)
{
var return_v = this_param.Read();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 121505, 121532);
return return_v;
}


string
f_1579_121597_121624(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.FullyQualifiedErrorId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 121597, 121624);
return return_v;
}


bool
f_1579_121555_121661(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 121555, 121661);
return return_v;
}


string
f_1579_121737_121785()
{
var return_v = RunspaceStrings.NotSupportedOnRestrictedRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 121737, 121785);
return return_v;
}


System.Exception
f_1579_121787_121802(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 121787, 121802);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1579_121709_121803(string
message,System.Exception
innerException)
{
var return_v = new System.Management.Automation.PSNotSupportedException( message, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 121709, 121803);
return return_v;
}


System.Exception
f_1579_121924_121939(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 121924, 121939);
return return_v;
}


string
f_1579_121924_121947(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 121924, 121947);
return return_v;
}


System.Exception
f_1579_121949_121964(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 121949, 121964);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1579_121892_121965(string
message,System.Exception
innerException)
{
var return_v = new System.Management.Automation.PSInvalidOperationException( message, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 121892, 121965);
return return_v;
}


int
f_1579_122020_122032(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 122020, 122032);
return return_v;
}


System.Management.Automation.PSObject
f_1579_122111_122120(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 122111, 122120);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1579_122111_122131(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 122111, 122131);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1579_122111_122140(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 122111, 122140);
return return_v;
}


object
f_1579_122111_122146(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 122111, 122146);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,119746,122158);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,119746,122158);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override List<string> Applications
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,122634,124077);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,122811,122909) || true) && (_isInNoLanguageModeException != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,122811,122909);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,122874,122909);

throw _isInNoLanguageModeException;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,122811,122909);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,123110,123163);

Pipeline 
remotePipeline = f_1579_123136_123162(_runspace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,123181,123262);

f_1579_123181_123261(f_1579_123181_123204(remotePipeline), "$executionContext.SessionState.Applications");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,123282,123323);

List<string> 
result = f_1579_123304_123322()
;
                try
                {
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,123385,123559);
foreach(PSObject application in f_1579_123418_123441_I(f_1579_123418_123441(remotePipeline)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,123385,123559);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,123491,123536);

f_1579_123491_123535(                        result, f_1579_123502_123524(application)as string);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,123385,123559);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1579,1,175);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1579,1,175);
}                }
                catch (RemoteException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,123596,124028);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,123662,124009) || true) && (f_1579_123666_123701(f_1579_123666_123692(f_1579_123666_123679(e)))== ErrorCategory.ParserError)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,123662,124009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,123780,123892);

_isInNoLanguageModeException = f_1579_123811_123891(f_1579_123839_123887(), e);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,123918,123953);

throw _isInNoLanguageModeException;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,123662,124009);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,123662,124009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,124003,124009);

throw;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,123662,124009);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,123596,124028);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,124048,124062);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,122634,124077);

System.Management.Automation.Runspaces.Pipeline
f_1579_123136_123162(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.CreatePipeline();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 123136, 123162);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_1579_123181_123204(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 123181, 123204);
return return_v;
}


int
f_1579_123181_123261(System.Management.Automation.Runspaces.CommandCollection
this_param,string
scriptContents)
{
this_param.AddScript( scriptContents);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 123181, 123261);
return 0;
}


System.Collections.Generic.List<string>
f_1579_123304_123322()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 123304, 123322);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1579_123418_123441(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 123418, 123441);
return return_v;
}


object
f_1579_123502_123524(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.BaseObject ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 123502, 123524);
return return_v;
}


int
f_1579_123491_123535(System.Collections.Generic.List<string>
this_param,object
item)
{
this_param.Add( (string)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 123491, 123535);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1579_123418_123441_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 123418, 123441);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1579_123666_123679(System.Management.Automation.RemoteException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 123666, 123679);
return return_v;
}


System.Management.Automation.ErrorCategoryInfo
f_1579_123666_123692(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.CategoryInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 123666, 123692);
return return_v;
}


System.Management.Automation.ErrorCategory
f_1579_123666_123701(System.Management.Automation.ErrorCategoryInfo
this_param)
{
var return_v = this_param.Category ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 123666, 123701);
return return_v;
}


string
f_1579_123839_123887()
{
var return_v = RunspaceStrings.NotSupportedOnRestrictedRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 123839, 123887);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1579_123811_123891(string
message,System.Management.Automation.RemoteException
innerException)
{
var return_v = new System.Management.Automation.PSNotSupportedException( message, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 123811, 123891);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,122568,124088);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,122568,124088);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override List<string> Scripts
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,124554,125992);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,124731,124829) || true) && (_isInNoLanguageModeException != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,124731,124829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,124794,124829);

throw _isInNoLanguageModeException;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,124731,124829);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,125030,125083);

Pipeline 
remotePipeline = f_1579_125056_125082(_runspace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,125101,125177);

f_1579_125101_125176(f_1579_125101_125124(remotePipeline), "$executionContext.SessionState.Scripts");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,125197,125238);

List<string> 
result = f_1579_125219_125237()
;
                try
                {
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,125300,125474);
foreach(PSObject application in f_1579_125333_125356_I(f_1579_125333_125356(remotePipeline)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,125300,125474);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,125406,125451);

f_1579_125406_125450(                        result, f_1579_125417_125439(application)as string);
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,125300,125474);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1579,1,175);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1579,1,175);
}                }
                catch (RemoteException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,125511,125943);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,125577,125924) || true) && (f_1579_125581_125616(f_1579_125581_125607(f_1579_125581_125594(e)))== ErrorCategory.ParserError)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,125577,125924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,125695,125807);

_isInNoLanguageModeException = f_1579_125726_125806(f_1579_125754_125802(), e);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,125833,125868);

throw _isInNoLanguageModeException;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,125577,125924);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,125577,125924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,125918,125924);

throw;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,125577,125924);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,125511,125943);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,125963,125977);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,124554,125992);

System.Management.Automation.Runspaces.Pipeline
f_1579_125056_125082(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.CreatePipeline();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 125056, 125082);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_1579_125101_125124(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 125101, 125124);
return return_v;
}


int
f_1579_125101_125176(System.Management.Automation.Runspaces.CommandCollection
this_param,string
scriptContents)
{
this_param.AddScript( scriptContents);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 125101, 125176);
return 0;
}


System.Collections.Generic.List<string>
f_1579_125219_125237()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 125219, 125237);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1579_125333_125356(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 125333, 125356);
return return_v;
}


object
f_1579_125417_125439(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.BaseObject ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 125417, 125439);
return return_v;
}


int
f_1579_125406_125450(System.Collections.Generic.List<string>
this_param,object
item)
{
this_param.Add( (string)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 125406, 125450);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1579_125333_125356_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 125333, 125356);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1579_125581_125594(System.Management.Automation.RemoteException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 125581, 125594);
return return_v;
}


System.Management.Automation.ErrorCategoryInfo
f_1579_125581_125607(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.CategoryInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 125581, 125607);
return return_v;
}


System.Management.Automation.ErrorCategory
f_1579_125581_125616(System.Management.Automation.ErrorCategoryInfo
this_param)
{
var return_v = this_param.Category ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 125581, 125616);
return return_v;
}


string
f_1579_125754_125802()
{
var return_v = RunspaceStrings.NotSupportedOnRestrictedRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 125754, 125802);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1579_125726_125806(string
message,System.Management.Automation.RemoteException
innerException)
{
var return_v = new System.Management.Automation.PSNotSupportedException( message, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 125726, 125806);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,124493,126003);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,124493,126003);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override DriveManagementIntrinsics Drive
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,126486,126573);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,126522,126558);

throw f_1579_126528_126557();
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,126486,126573);

System.Management.Automation.PSNotSupportedException
f_1579_126528_126557()
{
var return_v = new System.Management.Automation.PSNotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 126528, 126557);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,126414,126584);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,126414,126584);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override PSLanguageMode LanguageMode
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,127059,128505);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,127254,127350) || true) && (_isInNoLanguageModeException != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,127254,127350);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,127317,127350);

return PSLanguageMode.NoLanguage;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,127254,127350);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,127551,127604);

Pipeline 
remotePipeline = f_1579_127577_127603(_runspace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,127622,127703);

f_1579_127622_127702(f_1579_127622_127645(remotePipeline), "$executionContext.SessionState.LanguageMode");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,127723,127789);

System.Collections.ObjectModel.Collection<PSObject> 
result = null
;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,127853,127886);

result = f_1579_127862_127885(remotePipeline);
                }
                catch (RemoteException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1579,127923,128353);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,127989,128334) || true) && (f_1579_127993_128028(f_1579_127993_128019(f_1579_127993_128006(e)))== ErrorCategory.ParserError)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,127989,128334);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,128107,128219);

_isInNoLanguageModeException = f_1579_128138_128218(f_1579_128166_128214(), e);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,128245,128278);

return PSLanguageMode.NoLanguage;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,127989,128334);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1579,127989,128334);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,128328,128334);

throw;
DynAbs.Tracing.TraceSender.TraceExitCondition(1579,127989,128334);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(1579,127923,128353);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,128373,128490);

return (PSLanguageMode)f_1579_128396_128489(f_1579_128425_128434(result, 0), typeof(PSLanguageMode), f_1579_128460_128488());
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,127059,128505);

System.Management.Automation.Runspaces.Pipeline
f_1579_127577_127603(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.CreatePipeline();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 127577, 127603);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_1579_127622_127645(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 127622, 127645);
return return_v;
}


int
f_1579_127622_127702(System.Management.Automation.Runspaces.CommandCollection
this_param,string
scriptContents)
{
this_param.AddScript( scriptContents);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 127622, 127702);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1579_127862_127885(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 127862, 127885);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1579_127993_128006(System.Management.Automation.RemoteException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 127993, 128006);
return return_v;
}


System.Management.Automation.ErrorCategoryInfo
f_1579_127993_128019(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.CategoryInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 127993, 128019);
return return_v;
}


System.Management.Automation.ErrorCategory
f_1579_127993_128028(System.Management.Automation.ErrorCategoryInfo
this_param)
{
var return_v = this_param.Category ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 127993, 128028);
return return_v;
}


string
f_1579_128166_128214()
{
var return_v = RunspaceStrings.NotSupportedOnRestrictedRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 128166, 128214);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1579_128138_128218(string
message,System.Management.Automation.RemoteException
innerException)
{
var return_v = new System.Management.Automation.PSNotSupportedException( message, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 128138, 128218);
return return_v;
}


System.Management.Automation.PSObject
f_1579_128425_128434(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 128425, 128434);
return return_v;
}


System.Globalization.CultureInfo
f_1579_128460_128488()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1579, 128460, 128488);
return return_v;
}


object
f_1579_128396_128489(System.Management.Automation.PSObject
valueToConvert,System.Type
resultType,System.Globalization.CultureInfo
formatProvider)
{
var return_v = LanguagePrimitives.ConvertTo( (object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 128396, 128489);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,126991,128619);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,126991,128619);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,128521,128608);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,128557,128593);

throw f_1579_128563_128592();
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,128521,128608);

System.Management.Automation.PSNotSupportedException
f_1579_128563_128592()
{
var return_v = new System.Management.Automation.PSNotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 128563, 128592);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,126991,128619);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,126991,128619);
}
		}}

public override PSModuleInfo Module
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,129080,129167);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,129116,129152);

throw f_1579_129122_129151();
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,129080,129167);

System.Management.Automation.PSNotSupportedException
f_1579_129122_129151()
{
var return_v = new System.Management.Automation.PSNotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 129122, 129151);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,129020,129178);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,129020,129178);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override PathIntrinsics Path
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,129662,129749);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,129698,129734);

throw f_1579_129704_129733();
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,129662,129749);

System.Management.Automation.PSNotSupportedException
f_1579_129704_129733()
{
var return_v = new System.Management.Automation.PSNotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 129704, 129733);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,129602,129760);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,129602,129760);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override CmdletProviderManagementIntrinsics Provider
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,130259,130346);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,130295,130331);

throw f_1579_130301_130330();
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,130259,130346);

System.Management.Automation.PSNotSupportedException
f_1579_130301_130330()
{
var return_v = new System.Management.Automation.PSNotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 130301, 130330);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,130175,130357);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,130175,130357);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override PSVariableIntrinsics PSVariable
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,130843,130930);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,130879,130915);

throw f_1579_130885_130914();
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,130843,130930);

System.Management.Automation.PSNotSupportedException
f_1579_130885_130914()
{
var return_v = new System.Management.Automation.PSNotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 130885, 130914);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,130771,130941);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,130771,130941);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override CommandInvocationIntrinsics InvokeCommand
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,131459,131546);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,131495,131531);

throw f_1579_131501_131530();
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,131459,131546);

System.Management.Automation.PSNotSupportedException
f_1579_131501_131530()
{
var return_v = new System.Management.Automation.PSNotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 131501, 131530);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,131377,131557);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,131377,131557);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override ProviderIntrinsics InvokeProvider
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1579,132061,132148);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1579,132097,132133);

throw f_1579_132103_132132();
DynAbs.Tracing.TraceSender.TraceExitMethod(1579,132061,132148);

System.Management.Automation.PSNotSupportedException
f_1579_132103_132132()
{
var return_v = new System.Management.Automation.PSNotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 132103, 132132);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1579,131987,132159);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,131987,132159);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

static RemoteSessionStateProxy()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1579,115917,132166);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1579,115917,132166);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1579,115917,132166);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1579,115917,132166);

int
f_1579_116117_116185(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1579, 116117, 116185);
return 0;
}

}

    }
