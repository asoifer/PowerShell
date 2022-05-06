// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Internal;
using System.Management.Automation.Remoting.Client;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Runspaces.Internal;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
internal class ClientRemoteSessionDSHandlerImpl : ClientRemoteSessionDataStructureHandler, IDisposable
{
[TraceSourceAttribute("CRSDSHdlerImpl", "ClientRemoteSessionDSHandlerImpl")]
        private static PSTraceSource s_trace ;

private const string 
resBaseName = "remotingerroridstrings"
;

private BaseClientSessionTransportManager _transportManager;

private ClientRemoteSessionDSHandlerStateMachine _stateMachine;

private ClientRemoteSession _session;

private RunspaceConnectionInfo _connectionInfo;

private Uri _redirectUri;

private int _maxUriRedirectionCount;

private bool _isCloseCalled;

private object _syncObject ;

private PSRemotingCryptoHelper _cryptoHelper;

private ClientRemoteSession.URIDirectionReported _uriRedirectionHandler;

internal override BaseClientSessionTransportManager TransportManager
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,1618,1694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,1654,1679);

return _transportManager;
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,1618,1694);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,1525,1705);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,1525,1705);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override BaseClientCommandTransportManager CreateClientCommandTransportManager(
            System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell cmd,
            bool noInput)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,1717,2264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,1946,2100);

BaseClientCommandTransportManager 
cmdTransportMgr =
f_1585_2015_2099(                _transportManager, _connectionInfo, cmd, noInput)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,2159,2214);

cmdTransportMgr.DataReceived += DispatchInputQueueData;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,2230,2253);

return cmdTransportMgr;
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,1717,2264);

System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
f_1585_2015_2099(System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
this_param,System.Management.Automation.Runspaces.RunspaceConnectionInfo
connectionInfo,System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
cmd,bool
noInput)
{
var return_v = this_param.CreateClientCommandTransportManager( connectionInfo, cmd, noInput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 2015, 2099);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,1717,2264);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,1717,2264);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal ClientRemoteSessionDSHandlerImpl(ClientRemoteSession session,
            PSRemotingCryptoHelper cryptoHelper,
            RunspaceConnectionInfo connectionInfo,
            ClientRemoteSession.URIDirectionReported uriRedirectionHandler)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1585,2425,4574);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,963,980);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,1040,1053);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,1092,1100);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,1142,1157);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,1225,1237);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,1260,1283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,1307,1321);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,1347,1373);
this._syncObject = f_1585_1361_1373();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,1415,1428);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,1490,1512);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,2699,2789);

f_1585_2699_2788(_maxUriRedirectionCount >= 0, "maxUriRedirectionCount cannot be less than 0.");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,2805,2929) || true) && (session == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,2805,2929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,2858,2914);

throw f_1585_2864_2913("session");
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,2805,2929);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,2945,2964);

_session = session;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,3017,3080);

_stateMachine = f_1585_3033_3079();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,3094,3143);

_stateMachine.StateChanged += HandleStateChanged;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,3159,3192);

_connectionInfo = connectionInfo;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,3249,3278);

_cryptoHelper = cryptoHelper;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,3292,3520);

_transportManager = f_1585_3312_3519(_connectionInfo, f_1585_3382_3428(f_1585_3382_3417(_session)), f_1585_3447_3487(f_1585_3447_3482(_session)), cryptoHelper);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,3536,3593);

_transportManager.DataReceived += DispatchInputQueueData;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,3607,3676);

_transportManager.WSManTransportErrorOccured += HandleTransportError;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,3690,3746);

_transportManager.CloseCompleted += HandleCloseComplete;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,3760,3826);

_transportManager.DisconnectCompleted += HandleDisconnectComplete;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,3840,3904);

_transportManager.ReconnectCompleted += HandleReconnectComplete;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,3920,4050);

_transportManager.RobustConnectionNotification += new EventHandler<ConnectionStatusEventArgs>(HandleRobustConnectionNotification);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,4066,4147);

WSManConnectionInfo 
wsmanConnectionInfo = _connectionInfo as WSManConnectionInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,4161,4563) || true) && (wsmanConnectionInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,4161,4563);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,4403,4450);

_uriRedirectionHandler = uriRedirectionHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,4468,4548);

_maxUriRedirectionCount = f_1585_4494_4547(wsmanConnectionInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,4161,4563);
}
DynAbs.Tracing.TraceSender.TraceExitConstructor(1585,2425,4574);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,2425,4574);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,2425,4574);
}
		}

internal override void CreateAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,4743,5038);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,4923,4981);

_transportManager.CreateCompleted += HandleCreateComplete;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,4995,5027);

f_1585_4995_5026(            _transportManager);
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,4743,5038);

int
f_1585_4995_5026(System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
this_param)
{
this_param.CreateAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 4995, 5026);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,4743,5038);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,4743,5038);
}
		}

private void HandleCreateComplete(object sender, EventArgs args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,5253,5638);
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,5253,5638);
            // This is a no-op at the moment..as we dont need to inform anything to
            // state machine here..StateMachine must already have reached NegotiationSent
            // state and waiting for Negotiation Received which will happen only from
            // DataReceived event.
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,5253,5638);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,5253,5638);
}
		}

private void HandleConnectComplete(object sender, EventArgs args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,5650,6271);
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,5650,6271);
            // No-OP. Once the negotiation messages are exchanged and the session gets into established state,
            // it will take care of spawning the receive operation on the connected session
            // There is however a caveat.
            // A rouge remote server if it does not send the required negotiation data in the Connect Response,
            // then the state machine can never get into the established state and the runspace can never get into a opened state
            // Living with this for now.
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,5650,6271);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,5650,6271);
}
		}

internal override void DisconnectAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,6340,6452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,6405,6441);

f_1585_6405_6440(            _transportManager);
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,6340,6452);

int
f_1585_6405_6440(System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
this_param)
{
this_param.DisconnectAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 6405, 6440);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,6340,6452);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,6340,6452);
}
		}

private void HandleDisconnectComplete(object sender, EventArgs args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,6464,6808);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,6596,6735);

RemoteSessionStateMachineEventArgs 
disconnectCompletedArg = f_1585_6656_6734(RemoteSessionEvent.DisconnectCompleted)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,6749,6797);

f_1585_6749_6796(f_1585_6749_6761(), disconnectCompletedArg);
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,6464,6808);

System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1585_6656_6734(System.Management.Automation.RemoteSessionEvent
stateEvent)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 6656, 6734);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1585_6749_6761()
{
var return_v = StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 6749, 6761);
return return_v;
}


int
f_1585_6749_6796(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 6749, 6796);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,6464,6808);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,6464,6808);
}
		}

private void HandleRobustConnectionNotification(object sender, ConnectionStatusEventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,6894,8132);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,7010,7066);

RemoteSessionStateMachineEventArgs 
eventArgument = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,7080,7992);

switch (f_1585_7088_7102(e))
            {

case ConnectionStatus.AutoDisconnectStarting:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,7080,7992);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,7203,7298);

eventArgument = f_1585_7219_7297(RemoteSessionEvent.RCDisconnectStarted);
DynAbs.Tracing.TraceSender.TraceBreak(1585,7320,7326);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,7080,7992);

case ConnectionStatus.AutoDisconnectSucceeded:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,7080,7992);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,7414,7752);

eventArgument = f_1585_7430_7751(RemoteSessionEvent.DisconnectCompleted, f_1585_7534_7750(f_1585_7585_7749(f_1585_7603_7650(), f_1585_7685_7748(f_1585_7685_7735(f_1585_7685_7720(_session))))));
DynAbs.Tracing.TraceSender.TraceBreak(1585,7774,7780);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,7080,7992);

case ConnectionStatus.InternalErrorAbort:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,7080,7992);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,7863,7949);

eventArgument = f_1585_7879_7948(RemoteSessionEvent.FatalError);
DynAbs.Tracing.TraceSender.TraceBreak(1585,7971,7977);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,7080,7992);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,8008,8121) || true) && (eventArgument != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,8008,8121);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,8067,8106);

f_1585_8067_8105(f_1585_8067_8079(), eventArgument);
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,8008,8121);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,6894,8132);

System.Management.Automation.Remoting.ConnectionStatus
f_1585_7088_7102(System.Management.Automation.Remoting.ConnectionStatusEventArgs
this_param)
{
var return_v = this_param.Notification;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 7088, 7102);
return return_v;
}


System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1585_7219_7297(System.Management.Automation.RemoteSessionEvent
stateEvent)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 7219, 7297);
return return_v;
}


string
f_1585_7603_7650()
{
var return_v = RemotingErrorIdStrings.RCAutoDisconnectingError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 7603, 7650);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1585_7685_7720(System.Management.Automation.Remoting.ClientRemoteSession
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 7685, 7720);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1585_7685_7735(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 7685, 7735);
return return_v;
}


string
f_1585_7685_7748(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 7685, 7748);
return return_v;
}


string
f_1585_7585_7749(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 7585, 7749);
return return_v;
}


System.Management.Automation.RuntimeException
f_1585_7534_7750(string
message)
{
var return_v = new System.Management.Automation.RuntimeException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 7534, 7750);
return return_v;
}


System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1585_7430_7751(System.Management.Automation.RemoteSessionEvent
stateEvent,System.Management.Automation.RuntimeException
reason)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent, (System.Exception)reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 7430, 7751);
return return_v;
}


System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1585_7879_7948(System.Management.Automation.RemoteSessionEvent
stateEvent)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 7879, 7948);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1585_8067_8079()
{
var return_v = StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 8067, 8079);
return return_v;
}


int
f_1585_8067_8105(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 8067, 8105);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,6894,8132);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,6894,8132);
}
		}

internal override void ReconnectAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,8193,8303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,8257,8292);

f_1585_8257_8291(            _transportManager);
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,8193,8303);

int
f_1585_8257_8291(System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
this_param)
{
this_param.ReconnectAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 8257, 8291);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,8193,8303);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,8193,8303);
}
		}

private void HandleReconnectComplete(object sender, EventArgs args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,8315,8655);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,8446,8583);

RemoteSessionStateMachineEventArgs 
reconnectCompletedArg = f_1585_8505_8582(RemoteSessionEvent.ReconnectCompleted)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,8597,8644);

f_1585_8597_8643(f_1585_8597_8609(), reconnectCompletedArg);
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,8315,8655);

System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1585_8505_8582(System.Management.Automation.RemoteSessionEvent
stateEvent)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 8505, 8582);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1585_8597_8609()
{
var return_v = StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 8597, 8609);
return return_v;
}


int
f_1585_8597_8643(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 8597, 8643);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,8315,8655);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,8315,8655);
}
		}

internal override void CloseConnectionAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,8819,9143);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,8895,8906);
            lock (_syncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,8940,9026) || true) && (_isCloseCalled)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,8940,9026);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,9000,9007);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,8940,9026);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,9046,9077);

f_1585_9046_9076(
                _transportManager);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,9095,9117);

_isCloseCalled = true;
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,8819,9143);

int
f_1585_9046_9076(System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
this_param)
{
this_param.CloseAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 9046, 9076);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,8819,9143);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,8819,9143);
}
		}

private void HandleCloseComplete(object sender, EventArgs args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,9155,9531);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,9333,9462);

RemoteSessionStateMachineEventArgs 
closeCompletedArg = f_1585_9388_9461(RemoteSessionEvent.CloseCompleted)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,9476,9520);

f_1585_9476_9519(            _stateMachine, closeCompletedArg);
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,9155,9531);

System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1585_9388_9461(System.Management.Automation.RemoteSessionEvent
stateEvent)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 9388, 9461);
return return_v;
}


int
f_1585_9476_9519(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 9476, 9519);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,9155,9531);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,9155,9531);
}
		}

internal override void SendNegotiationAsync(RemoteSessionState sessionState)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,9708,11069);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,10282,10448);

RemoteSessionStateMachineEventArgs 
negotiationSendCompletedArg =
f_1585_10364_10447(RemoteSessionEvent.NegotiationSendCompleted)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,10462,10516);

f_1585_10462_10515(            _stateMachine, negotiationSendCompletedArg);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,10532,11058) || true) && (sessionState == RemoteSessionState.NegotiationSending)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,10532,11058);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,10623,10655);

f_1585_10623_10654(                _transportManager);
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,10532,11058);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,10532,11058);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,10689,11058) || true) && (sessionState == RemoteSessionState.NegotiationSendingOnConnect)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,10689,11058);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,10789,10849);

_transportManager.ConnectCompleted += HandleConnectComplete;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,10867,10900);

f_1585_10867_10899(                _transportManager);
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,10689,11058);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,10689,11058);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,10966,11043);

f_1585_10966_11042(false, "SendNegotiationAsync called in unexpected session state");
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,10689,11058);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,10532,11058);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,9708,11069);

System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1585_10364_10447(System.Management.Automation.RemoteSessionEvent
stateEvent)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 10364, 10447);
return return_v;
}


int
f_1585_10462_10515(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 10462, 10515);
return 0;
}


int
f_1585_10623_10654(System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
this_param)
{
this_param.CreateAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 10623, 10654);
return 0;
}


int
f_1585_10867_10899(System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
this_param)
{
this_param.ConnectAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 10867, 10899);
return 0;
}


int
f_1585_10966_11042(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 10966, 11042);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,9708,11069);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,9708,11069);
}
		}

        internal override event EventHandler<RemoteSessionNegotiationEventArgs> 
NegotiationReceived
;

        
        
        /// <summary>
        /// This event indicates that the connection state has changed.
        /// </summary>
        internal override event EventHandler<RemoteSessionStateEventArgs> 
ConnectionStateChanged
;

private void HandleStateChanged(object sender, RemoteSessionStateEventArgs arg)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,11472,13765);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,11576,11692) || true) && (arg == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,11576,11692);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,11625,11677);

throw f_1585_11631_11676("arg");
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,11576,11692);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,11774,12016) || true) && ((f_1585_11779_11805(f_1585_11779_11799(arg))== RemoteSessionState.NegotiationSending) ||(DynAbs.Tracing.TraceSender.Expression_False(1585, 11778, 11929)||(f_1585_11852_11878(f_1585_11852_11872(arg))== RemoteSessionState.NegotiationSendingOnConnect)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,11774,12016);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,11963,12001);

f_1585_11963_12000(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,11774,12016);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,12166,12211);

f_1585_12166_12210(
            // this will enable top-layers to enqueue any packets during NegotiationSending and
            // during other states.
            ConnectionStateChanged, this, arg);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,12227,12480) || true) && ((f_1585_12232_12258(f_1585_12232_12252(arg))== RemoteSessionState.NegotiationSending) ||(DynAbs.Tracing.TraceSender.Expression_False(1585, 12231, 12382)||(f_1585_12305_12331(f_1585_12305_12325(arg))== RemoteSessionState.NegotiationSendingOnConnect)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,12227,12480);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,12416,12465);

f_1585_12416_12464(this, f_1585_12437_12463(f_1585_12437_12457(arg)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,12227,12480);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,12625,13036) || true) && (f_1585_12629_12655(f_1585_12629_12649(arg))== RemoteSessionState.Established)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,12625,13036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,12723,12819);

WSManClientSessionTransportManager 
tm = _transportManager as WSManClientSessionTransportManager
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,12837,13021) || true) && (tm != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,12837,13021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,12893,12956);

f_1585_12893_12955(                    tm, f_1585_12924_12954(_session));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,12978,13002);

f_1585_12978_13001(                    tm);
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,12837,13021);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,12625,13036);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,13247,13389) || true) && (f_1585_13251_13277(f_1585_13251_13271(arg))== RemoteSessionState.ClosingConnection)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,13247,13389);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,13351,13374);

f_1585_13351_13373(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,13247,13389);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,13440,13573) || true) && (f_1585_13444_13470(f_1585_13444_13464(arg))== RemoteSessionState.Disconnecting)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,13440,13573);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,13540,13558);

f_1585_13540_13557(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,13440,13573);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,13623,13754) || true) && (f_1585_13627_13653(f_1585_13627_13647(arg))== RemoteSessionState.Reconnecting)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,13623,13754);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,13722,13739);

f_1585_13722_13738(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,13623,13754);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,11472,13765);

System.Management.Automation.PSArgumentNullException
f_1585_11631_11676(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 11631, 11676);
return return_v;
}


System.Management.Automation.RemoteSessionStateInfo
f_1585_11779_11799(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 11779, 11799);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1585_11779_11805(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 11779, 11805);
return return_v;
}


System.Management.Automation.RemoteSessionStateInfo
f_1585_11852_11872(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 11852, 11872);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1585_11852_11878(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 11852, 11878);
return return_v;
}


int
f_1585_11963_12000(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerImpl
this_param)
{
this_param.HandleNegotiationSendingStateChange();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 11963, 12000);
return 0;
}


int
f_1585_12166_12210(System.EventHandler<System.Management.Automation.RemoteSessionStateEventArgs>
eventHandler,System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerImpl
sender,System.Management.Automation.RemoteSessionStateEventArgs
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteSessionStateEventArgs>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 12166, 12210);
return 0;
}


System.Management.Automation.RemoteSessionStateInfo
f_1585_12232_12252(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 12232, 12252);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1585_12232_12258(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 12232, 12258);
return return_v;
}


System.Management.Automation.RemoteSessionStateInfo
f_1585_12305_12325(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 12305, 12325);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1585_12305_12331(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 12305, 12331);
return return_v;
}


System.Management.Automation.RemoteSessionStateInfo
f_1585_12437_12457(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 12437, 12457);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1585_12437_12463(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 12437, 12463);
return return_v;
}


int
f_1585_12416_12464(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerImpl
this_param,System.Management.Automation.RemoteSessionState
sessionState)
{
this_param.SendNegotiationAsync( sessionState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 12416, 12464);
return 0;
}


System.Management.Automation.RemoteSessionStateInfo
f_1585_12629_12649(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 12629, 12649);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1585_12629_12655(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 12629, 12655);
return return_v;
}


System.Version
f_1585_12924_12954(System.Management.Automation.Remoting.ClientRemoteSession
this_param)
{
var return_v = this_param.ServerProtocolVersion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 12924, 12954);
return return_v;
}


int
f_1585_12893_12955(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
this_param,System.Version
serverProtocolVersion)
{
this_param.AdjustForProtocolVariations( serverProtocolVersion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 12893, 12955);
return 0;
}


int
f_1585_12978_13001(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
this_param)
{
this_param.StartReceivingData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 12978, 13001);
return 0;
}


System.Management.Automation.RemoteSessionStateInfo
f_1585_13251_13271(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 13251, 13271);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1585_13251_13277(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 13251, 13277);
return return_v;
}


int
f_1585_13351_13373(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerImpl
this_param)
{
this_param.CloseConnectionAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 13351, 13373);
return 0;
}


System.Management.Automation.RemoteSessionStateInfo
f_1585_13444_13464(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 13444, 13464);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1585_13444_13470(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 13444, 13470);
return return_v;
}


int
f_1585_13540_13557(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerImpl
this_param)
{
this_param.DisconnectAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 13540, 13557);
return 0;
}


System.Management.Automation.RemoteSessionStateInfo
f_1585_13627_13647(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 13627, 13647);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1585_13627_13653(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 13627, 13653);
return return_v;
}


int
f_1585_13722_13738(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerImpl
this_param)
{
this_param.ReconnectAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 13722, 13738);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,11472,13765);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,11472,13765);
}
		}

private void HandleNegotiationSendingStateChange()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,14022,14900);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,14097,14174);

RemoteSessionCapability 
clientCapability = f_1585_14140_14173(f_1585_14140_14156(_session))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,14188,14346);

f_1585_14188_14345(f_1585_14199_14235(clientCapability)== RemotingDestination.Server, "Expected clientCapability.RemotingDestination == RemotingDestination.Server");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,14416,14596);

RemoteDataObject 
data = f_1585_14440_14595(clientCapability, f_1585_14548_14594(f_1585_14548_14583(_session)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,14610,14804);

RemoteDataObject<PSObject> 
dataAsPSObject = f_1585_14654_14803(f_1585_14710_14726(data), f_1585_14728_14741(data), f_1585_14743_14762(data), f_1585_14764_14781(data), f_1585_14793_14802(data))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,14818,14889);

f_1585_14818_14888(f_1585_14818_14858(_transportManager), dataAsPSObject);
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,14022,14900);

System.Management.Automation.Remoting.ClientRemoteSessionContext
f_1585_14140_14156(System.Management.Automation.Remoting.ClientRemoteSession
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 14140, 14156);
return return_v;
}


System.Management.Automation.Remoting.RemoteSessionCapability
f_1585_14140_14173(System.Management.Automation.Remoting.ClientRemoteSessionContext
this_param)
{
var return_v = this_param.ClientCapability;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 14140, 14173);
return return_v;
}


System.Management.Automation.RemotingDestination
f_1585_14199_14235(System.Management.Automation.Remoting.RemoteSessionCapability
this_param)
{
var return_v = this_param.RemotingDestination ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 14199, 14235);
return return_v;
}


int
f_1585_14188_14345(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 14188, 14345);
return 0;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1585_14548_14583(System.Management.Automation.Remoting.ClientRemoteSession
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 14548, 14583);
return return_v;
}


System.Guid
f_1585_14548_14594(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 14548, 14594);
return return_v;
}


System.Management.Automation.Remoting.RemoteDataObject
f_1585_14440_14595(System.Management.Automation.Remoting.RemoteSessionCapability
capability,System.Guid
runspacePoolId)
{
var return_v = RemotingEncoder.GenerateClientSessionCapability( capability, runspacePoolId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 14440, 14595);
return return_v;
}


System.Management.Automation.RemotingDestination
f_1585_14710_14726(System.Management.Automation.Remoting.RemoteDataObject
this_param)
{
var return_v = this_param.Destination;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 14710, 14726);
return return_v;
}


System.Management.Automation.RemotingDataType
f_1585_14728_14741(System.Management.Automation.Remoting.RemoteDataObject
this_param)
{
var return_v = this_param.DataType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 14728, 14741);
return return_v;
}


System.Guid
f_1585_14743_14762(System.Management.Automation.Remoting.RemoteDataObject
this_param)
{
var return_v = this_param.RunspacePoolId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 14743, 14762);
return return_v;
}


System.Guid
f_1585_14764_14781(System.Management.Automation.Remoting.RemoteDataObject
this_param)
{
var return_v = this_param.PowerShellId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 14764, 14781);
return return_v;
}


object
f_1585_14793_14802(System.Management.Automation.Remoting.RemoteDataObject
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 14793, 14802);
return return_v;
}


System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
f_1585_14654_14803(System.Management.Automation.RemotingDestination
destination,System.Management.Automation.RemotingDataType
dataType,System.Guid
runspacePoolId,System.Guid
powerShellId,object
data)
{
var return_v = RemoteDataObject<PSObject>.CreateFrom( destination, dataType, runspacePoolId, powerShellId, (System.Management.Automation.PSObject)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 14654, 14803);
return return_v;
}


System.Management.Automation.Remoting.PrioritySendDataCollection
f_1585_14818_14858(System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
this_param)
{
var return_v = this_param.DataToBeSentCollection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 14818, 14858);
return return_v;
}


int
f_1585_14818_14888(System.Management.Automation.Remoting.PrioritySendDataCollection
this_param,System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
data)
{
this_param.Add<System.Management.Automation.PSObject>( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 14818, 14888);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,14022,14900);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,14022,14900);
}
		}

internal override ClientRemoteSessionDSHandlerStateMachine StateMachine
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,15043,15115);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,15079,15100);

return _stateMachine;
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,15043,15115);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,14947,15126);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,14947,15126);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private void PerformURIRedirection(string newURIString)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,16195,17380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,16275,16312);

_redirectUri = f_1585_16290_16311(newURIString);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,16424,16435);

            // make sure connection is not closed while we are handling the redirection.
            lock (_syncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,16546,16632) || true) && (_isCloseCalled)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,16546,16632);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,16606,16613);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,16546,16632);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,16722,16778);

_transportManager.CloseCompleted -= HandleCloseComplete;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,16796,16865);

_transportManager.WSManTransportErrorOccured -= HandleTransportError;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,16965,17044);

_transportManager.CloseCompleted += HandleTransportCloseCompleteForRedirection;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,17209,17292);

_transportManager.WSManTransportErrorOccured += HandleTransportErrorForRedirection;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,17312,17354);

f_1585_17312_17353(
                _transportManager);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,16195,17380);

System.Uri
f_1585_16290_16311(string
uriString)
{
var return_v = new System.Uri( uriString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 16290, 16311);
return return_v;
}


int
f_1585_17312_17353(System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
this_param)
{
this_param.PrepareForRedirection();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 17312, 17353);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,16195,17380);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,16195,17380);
}
		}

private void HandleTransportCloseCompleteForRedirection(object source, EventArgs args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,17392,17965);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,17503,17582);

_transportManager.CloseCompleted -= HandleTransportCloseCompleteForRedirection;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,17596,17679);

_transportManager.WSManTransportErrorOccured -= HandleTransportErrorForRedirection;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,17758,17814);

_transportManager.CloseCompleted += HandleCloseComplete;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,17828,17897);

_transportManager.WSManTransportErrorOccured += HandleTransportError;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,17913,17954);

f_1585_17913_17953(this, _redirectUri);
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,17392,17965);

int
f_1585_17913_17953(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerImpl
this_param,System.Uri
newURI)
{
this_param.PerformURIRedirectionStep2( newURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 17913, 17953);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,17392,17965);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,17392,17965);
}
		}

private void HandleTransportErrorForRedirection(object sender, TransportErrorOccuredEventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,17977,18551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,18098,18177);

_transportManager.CloseCompleted -= HandleTransportCloseCompleteForRedirection;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,18191,18274);

_transportManager.WSManTransportErrorOccured -= HandleTransportErrorForRedirection;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,18353,18409);

_transportManager.CloseCompleted += HandleCloseComplete;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,18423,18492);

_transportManager.WSManTransportErrorOccured += HandleTransportError;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,18508,18540);

f_1585_18508_18539(this, sender, e);
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,17977,18551);

int
f_1585_18508_18539(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerImpl
this_param,object
sender,System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
e)
{
this_param.HandleTransportError( sender, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 18508, 18539);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,17977,18551);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,17977,18551);
}
		}

private void PerformURIRedirectionStep2(System.Uri newURI)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,18833,19540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,18916,18965);

f_1585_18916_18964(newURI != null, "Uri cannot be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,18985,18996);
            lock (_syncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,19107,19193) || true) && (_isCloseCalled)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,19107,19193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,19167,19174);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,19107,19193);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,19273,19399) || true) && (_uriRedirectionHandler != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,19273,19399);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,19349,19380);

f_1585_19349_19379(this, newURI);
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,19273,19399);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,19462,19514);

f_1585_19462_19513(
                // start a new connection
                _transportManager, newURI, _connectionInfo);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,18833,19540);

int
f_1585_18916_18964(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 18916, 18964);
return 0;
}


int
f_1585_19349_19379(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerImpl
this_param,System.Uri
newURI)
{
this_param._uriRedirectionHandler( newURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 19349, 19379);
return 0;
}


int
f_1585_19462_19513(System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
this_param,System.Uri
newUri,System.Management.Automation.Runspaces.RunspaceConnectionInfo
connectionInfo)
{
this_param.Redirect( newUri, connectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 19462, 19513);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,18833,19540);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,18833,19540);
}
		}

internal void HandleTransportError(object sender, TransportErrorOccuredEventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,19788,22994);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,19896,19969);

f_1585_19896_19968(e != null, "HandleTransportError expects non-null eventargs");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,20023,20132);

PSRemotingTransportRedirectException 
redirectException = f_1585_20080_20091(e)as PSRemotingTransportRedirectException
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,20146,21544) || true) && ((redirectException != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1585, 20150, 20210)&&(_maxUriRedirectionCount > 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,20146,21544);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,20244,20271);

Exception 
exception = null
;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,20406,20432);

_maxUriRedirectionCount--;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,20454,20512);

f_1585_20454_20511(this, f_1585_20476_20510(redirectException));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,20534,20541);

return;
                }
                catch (ArgumentNullException argumentException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1585,20578,20715);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,20666,20696);

exception = argumentException;
DynAbs.Tracing.TraceSender.TraceExitCatch(1585,20578,20715);
                }
                catch (UriFormatException uriFormatException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1585,20733,20869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,20819,20850);

exception = uriFormatException;
DynAbs.Tracing.TraceSender.TraceExitCatch(1585,20733,20869);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,20969,21529) || true) && (exception != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,20969,21529);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,21032,21378);

PSRemotingTransportException 
newException =
f_1585_21101_21377(PSRemotingErrorId.RedirectedURINotWellFormatted, f_1585_21183_21235(), f_1585_21266_21311(f_1585_21266_21296(f_1585_21266_21282(_session))), f_1585_21342_21376(redirectException))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,21400,21461);

newException.TransportMessage = f_1585_21432_21460(f_1585_21432_21443(e));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,21483,21510);

e.Exception = newException;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,20969,21529);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,20146,21544);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,21560,21627);

RemoteSessionEvent 
sessionEvent = RemoteSessionEvent.ConnectFailed
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,21643,22787);

switch (f_1585_21651_21677(e))
            {

case TransportMethodEnum.CreateShellEx:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,21643,22787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,21772,21820);

sessionEvent = RemoteSessionEvent.ConnectFailed;
DynAbs.Tracing.TraceSender.TraceBreak(1585,21842,21848);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,21643,22787);

case TransportMethodEnum.SendShellInputEx:
                case TransportMethodEnum.CommandInputEx:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,21643,22787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,21988,22033);

sessionEvent = RemoteSessionEvent.SendFailed;
DynAbs.Tracing.TraceSender.TraceBreak(1585,22055,22061);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,21643,22787);

case TransportMethodEnum.ReceiveShellOutputEx:
                case TransportMethodEnum.ReceiveCommandOutputEx:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,21643,22787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,22213,22261);

sessionEvent = RemoteSessionEvent.ReceiveFailed;
DynAbs.Tracing.TraceSender.TraceBreak(1585,22283,22289);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,21643,22787);

case TransportMethodEnum.CloseShellOperationEx:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,21643,22787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,22376,22422);

sessionEvent = RemoteSessionEvent.CloseFailed;
DynAbs.Tracing.TraceSender.TraceBreak(1585,22444,22450);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,21643,22787);

case TransportMethodEnum.DisconnectShellEx:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,21643,22787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,22533,22584);

sessionEvent = RemoteSessionEvent.DisconnectFailed;
DynAbs.Tracing.TraceSender.TraceBreak(1585,22606,22612);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,21643,22787);

case TransportMethodEnum.ReconnectShellEx:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,21643,22787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,22694,22744);

sessionEvent = RemoteSessionEvent.ReconnectFailed;
DynAbs.Tracing.TraceSender.TraceBreak(1585,22766,22772);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,21643,22787);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,22803,22933);

RemoteSessionStateMachineEventArgs 
errorArgs =
f_1585_22867_22932(sessionEvent, f_1585_22920_22931(e))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,22947,22983);

f_1585_22947_22982(            _stateMachine, errorArgs);
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,19788,22994);

int
f_1585_19896_19968(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 19896, 19968);
return 0;
}


System.Management.Automation.Remoting.PSRemotingTransportException
f_1585_20080_20091(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
this_param)
{
var return_v = this_param.Exception ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 20080, 20091);
return return_v;
}


string
f_1585_20476_20510(System.Management.Automation.Remoting.PSRemotingTransportRedirectException
this_param)
{
var return_v = this_param.RedirectLocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 20476, 20510);
return return_v;
}


int
f_1585_20454_20511(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerImpl
this_param,string
newURIString)
{
this_param.PerformURIRedirection( newURIString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 20454, 20511);
return 0;
}


string
f_1585_21183_21235()
{
var return_v = RemotingErrorIdStrings.RedirectedURINotWellFormatted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 21183, 21235);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionContext
f_1585_21266_21282(System.Management.Automation.Remoting.ClientRemoteSession
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 21266, 21282);
return return_v;
}


System.Uri
f_1585_21266_21296(System.Management.Automation.Remoting.ClientRemoteSessionContext
this_param)
{
var return_v = this_param.RemoteAddress;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 21266, 21296);
return return_v;
}


string
f_1585_21266_21311(System.Uri
this_param)
{
var return_v = this_param.OriginalString;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 21266, 21311);
return return_v;
}


string
f_1585_21342_21376(System.Management.Automation.Remoting.PSRemotingTransportRedirectException
this_param)
{
var return_v = this_param.RedirectLocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 21342, 21376);
return return_v;
}


System.Management.Automation.Remoting.PSRemotingTransportException
f_1585_21101_21377(System.Management.Automation.Remoting.PSRemotingErrorId
errorId,string
resourceString,params object[]
args)
{
var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException( errorId, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 21101, 21377);
return return_v;
}


System.Management.Automation.Remoting.PSRemotingTransportException
f_1585_21432_21443(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
this_param)
{
var return_v = this_param.Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 21432, 21443);
return return_v;
}


string
f_1585_21432_21460(System.Management.Automation.Remoting.PSRemotingTransportException
this_param)
{
var return_v = this_param.TransportMessage;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 21432, 21460);
return return_v;
}


System.Management.Automation.Remoting.TransportMethodEnum
f_1585_21651_21677(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
this_param)
{
var return_v = this_param.ReportingTransportMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 21651, 21677);
return return_v;
}


System.Management.Automation.Remoting.PSRemotingTransportException
f_1585_22920_22931(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
this_param)
{
var return_v = this_param.Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 22920, 22931);
return return_v;
}


System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1585_22867_22932(System.Management.Automation.RemoteSessionEvent
stateEvent,System.Management.Automation.Remoting.PSRemotingTransportException
reason)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent, (System.Exception)reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 22867, 22932);
return return_v;
}


int
f_1585_22947_22982(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 22947, 22982);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,19788,22994);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,19788,22994);
}
		}

internal void DispatchInputQueueData(object sender, RemoteDataEventArgs dataArg)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,23288,25994);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,23393,23517) || true) && (dataArg == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,23393,23517);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,23446,23502);

throw f_1585_23452_23501("dataArg");
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,23393,23517);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,23533,23592);

RemoteDataObject<PSObject> 
rcvdData = f_1585_23571_23591(dataArg)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,23608,23729) || true) && (rcvdData == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,23608,23729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,23662,23714);

throw f_1585_23668_23713("dataArg");
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,23608,23729);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,23745,23800);

RemotingDestination 
destination = f_1585_23779_23799(rcvdData)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,23816,24077) || true) && ((destination & RemotingDestination.Client) != RemotingDestination.Client)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,23816,24077);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,23926,24062);

throw f_1585_23932_24061(f_1585_23969_24019(), RemotingDestination.Client, destination);
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,23816,24077);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,24093,24160);

RemotingTargetInterface 
targetInterface = f_1585_24135_24159(rcvdData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,24174,25983);

switch (targetInterface)
            {

case RemotingTargetInterface.Session:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,24174,25983);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,24613,24645);

f_1585_24613_24644(this, dataArg);
DynAbs.Tracing.TraceSender.TraceBreak(1585,24671,24677);

break;
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,24174,25983);

case RemotingTargetInterface.RunspacePool:
                case RemotingTargetInterface.PowerShell:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,24174,25983);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,25303,25431);

RemoteSessionStateMachineEventArgs 
msgRcvArg = f_1585_25350_25430(RemoteSessionEvent.MessageReceived, null)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,25453,25754) || true) && (f_1585_25457_25500(f_1585_25457_25469(), msgRcvArg))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,25453,25754);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,25550,25598);

f_1585_25550_25597(this, f_1585_25576_25596(dataArg));
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,25453,25754);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,25453,25754);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,25696,25731);

f_1585_25696_25730(f_1585_25696_25708(), msgRcvArg);
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,25453,25754);
}
DynAbs.Tracing.TraceSender.TraceBreak(1585,25778,25784);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,24174,25983);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,24174,25983);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,25859,25915);

f_1585_25859_25914(false, "we should not be encountering this");
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1585,25962,25968);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,24174,25983);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,23288,25994);

System.Management.Automation.PSArgumentNullException
f_1585_23452_23501(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 23452, 23501);
return return_v;
}


System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
f_1585_23571_23591(System.Management.Automation.RemoteDataEventArgs
this_param)
{
var return_v = this_param.ReceivedData;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 23571, 23591);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1585_23668_23713(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 23668, 23713);
return return_v;
}


System.Management.Automation.RemotingDestination
f_1585_23779_23799(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Destination;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 23779, 23799);
return return_v;
}


string
f_1585_23969_24019()
{
var return_v = RemotingErrorIdStrings.RemotingDestinationNotForMe;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 23969, 24019);
return return_v;
}


System.Management.Automation.Remoting.PSRemotingDataStructureException
f_1585_23932_24061(string
resourceString,params object[]
args)
{
var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 23932, 24061);
return return_v;
}


System.Management.Automation.RemotingTargetInterface
f_1585_24135_24159(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.TargetInterface;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 24135, 24159);
return return_v;
}


int
f_1585_24613_24644(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerImpl
this_param,System.Management.Automation.RemoteDataEventArgs
arg)
{
this_param.ProcessSessionMessages( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 24613, 24644);
return 0;
}


System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1585_25350_25430(System.Management.Automation.RemoteSessionEvent
stateEvent,System.Exception
reason)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 25350, 25430);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1585_25457_25469()
{
var return_v = StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 25457, 25469);
return return_v;
}


bool
f_1585_25457_25500(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
var return_v = this_param.CanByPassRaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 25457, 25500);
return return_v;
}


System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
f_1585_25576_25596(System.Management.Automation.RemoteDataEventArgs
this_param)
{
var return_v = this_param.ReceivedData;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 25576, 25596);
return return_v;
}


int
f_1585_25550_25597(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerImpl
this_param,System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
rcvdData)
{
this_param.ProcessNonSessionMessages( rcvdData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 25550, 25597);
return 0;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1585_25696_25708()
{
var return_v = StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 25696, 25708);
return return_v;
}


int
f_1585_25696_25730(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 25696, 25730);
return 0;
}


int
f_1585_25859_25914(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 25859, 25914);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,23288,25994);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,23288,25994);
}
		}

private void ProcessSessionMessages(RemoteDataEventArgs arg)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,26398,29599);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,26483,26627) || true) && (arg == null ||(DynAbs.Tracing.TraceSender.Expression_False(1585, 26487, 26526)||f_1585_26502_26518(arg)== null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,26483,26627);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,26560,26612);

throw f_1585_26566_26611("arg");
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,26483,26627);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,26643,26698);

RemoteDataObject<PSObject> 
rcvdData = f_1585_26681_26697(arg)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,26714,26781);

RemotingTargetInterface 
targetInterface = f_1585_26756_26780(rcvdData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,26795,26893);

f_1585_26795_26892(targetInterface == RemotingTargetInterface.Session, "targetInterface must be Session");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,26909,26955);

RemotingDataType 
dataType = f_1585_26937_26954(rcvdData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,26971,29588);

switch (dataType)
            {

case RemotingDataType.CloseSession:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,26971,29588);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,27078,27218);

PSRemotingDataStructureException 
reasonOfClose = f_1585_27127_27217(f_1585_27164_27216())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,27240,27373);

RemoteSessionStateMachineEventArgs 
closeSessionArg = f_1585_27293_27372(RemoteSessionEvent.Close, reasonOfClose)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,27395,27437);

f_1585_27395_27436(                    _stateMachine, closeSessionArg);
DynAbs.Tracing.TraceSender.TraceBreak(1585,27459,27465);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,26971,29588);

case RemotingDataType.SessionCapability:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,26971,29588);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,27547,27589);

RemoteSessionCapability 
capability = null
;
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,27663,27728);

capability = f_1585_27676_27727(f_1585_27713_27726(rcvdData));
                    }
                    catch (PSRemotingDataStructureException dse)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1585,27773,28231);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,28002,28208);

throw f_1585_28008_28207(f_1585_28045_28102(), f_1585_28133_28144(dse), f_1585_28146_28171(), RemotingConstants.ProtocolVersion);
DynAbs.Tracing.TraceSender.TraceExitCatch(1585,27773,28231);
                    }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,28255,28385);

RemoteSessionStateMachineEventArgs 
capabilityArg = f_1585_28306_28384(RemoteSessionEvent.NegotiationReceived)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,28407,28458);

capabilityArg.RemoteSessionCapability = capability;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,28480,28520);

f_1585_28480_28519(                    _stateMachine, capabilityArg);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,28544,28645);

RemoteSessionNegotiationEventArgs 
negotiationArg = f_1585_28595_28644(capability)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,28667,28720);

f_1585_28667_28719(                    NegotiationReceived, this, negotiationArg);
DynAbs.Tracing.TraceSender.TraceBreak(1585,28742,28748);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,26971,29588);

case RemotingDataType.EncryptedSessionKey:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,26971,29588);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,28859,28942);

string 
encryptedSessionKey = f_1585_28888_28941(f_1585_28927_28940(rcvdData))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,28968,29067);

f_1585_28968_29066(                        EncryptedSessionKeyReceived, this, f_1585_29013_29065(encryptedSessionKey));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1585,29114,29120);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,26971,29588);

case RemotingDataType.PublicKeyRequest:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,26971,29588);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,29228,29317);

f_1585_29228_29316(                        PublicKeyRequestReceived, this, f_1585_29270_29315(string.Empty));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1585,29364,29370);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,26971,29588);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,26971,29588);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,29447,29550);

throw f_1585_29453_29549(f_1585_29490_29538(), dataType);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,26971,29588);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,26398,29599);

System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
f_1585_26502_26518(System.Management.Automation.RemoteDataEventArgs
this_param)
{
var return_v = this_param.ReceivedData ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 26502, 26518);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1585_26566_26611(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 26566, 26611);
return return_v;
}


System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
f_1585_26681_26697(System.Management.Automation.RemoteDataEventArgs
this_param)
{
var return_v = this_param.ReceivedData;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 26681, 26697);
return return_v;
}


System.Management.Automation.RemotingTargetInterface
f_1585_26756_26780(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.TargetInterface;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 26756, 26780);
return return_v;
}


int
f_1585_26795_26892(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 26795, 26892);
return 0;
}


System.Management.Automation.RemotingDataType
f_1585_26937_26954(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.DataType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 26937, 26954);
return return_v;
}


string
f_1585_27164_27216()
{
var return_v = RemotingErrorIdStrings.ServerRequestedToCloseSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 27164, 27216);
return return_v;
}


System.Management.Automation.Remoting.PSRemotingDataStructureException
f_1585_27127_27217(string
message)
{
var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 27127, 27217);
return return_v;
}


System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1585_27293_27372(System.Management.Automation.RemoteSessionEvent
stateEvent,System.Management.Automation.Remoting.PSRemotingDataStructureException
reason)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent, (System.Exception)reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 27293, 27372);
return return_v;
}


int
f_1585_27395_27436(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 27395, 27436);
return 0;
}


System.Management.Automation.PSObject
f_1585_27713_27726(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 27713, 27726);
return return_v;
}


System.Management.Automation.Remoting.RemoteSessionCapability
f_1585_27676_27727(System.Management.Automation.PSObject
data)
{
var return_v = RemotingDecoder.GetSessionCapability( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 27676, 27727);
return return_v;
}


string
f_1585_28045_28102()
{
var return_v = RemotingErrorIdStrings.ClientNotFoundCapabilityProperties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 28045, 28102);
return return_v;
}


string
f_1585_28133_28144(System.Management.Automation.Remoting.PSRemotingDataStructureException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 28133, 28144);
return return_v;
}


string
f_1585_28146_28171()
{
var return_v = PSVersionInfo.GitCommitId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 28146, 28171);
return return_v;
}


System.Management.Automation.Remoting.PSRemotingDataStructureException
f_1585_28008_28207(string
resourceString,params object[]
args)
{
var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 28008, 28207);
return return_v;
}


System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1585_28306_28384(System.Management.Automation.RemoteSessionEvent
stateEvent)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 28306, 28384);
return return_v;
}


int
f_1585_28480_28519(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 28480, 28519);
return 0;
}


System.Management.Automation.RemoteSessionNegotiationEventArgs
f_1585_28595_28644(System.Management.Automation.Remoting.RemoteSessionCapability
remoteSessionCapability)
{
var return_v = new System.Management.Automation.RemoteSessionNegotiationEventArgs( remoteSessionCapability);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 28595, 28644);
return return_v;
}


int
f_1585_28667_28719(System.EventHandler<System.Management.Automation.RemoteSessionNegotiationEventArgs>
eventHandler,System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerImpl
sender,System.Management.Automation.RemoteSessionNegotiationEventArgs
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteSessionNegotiationEventArgs>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 28667, 28719);
return 0;
}


System.Management.Automation.PSObject
f_1585_28927_28940(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 28927, 28940);
return return_v;
}


string
f_1585_28888_28941(System.Management.Automation.PSObject
dataAsPSObject)
{
var return_v = RemotingDecoder.GetEncryptedSessionKey( dataAsPSObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 28888, 28941);
return return_v;
}


System.Management.Automation.RemoteDataEventArgs<string>
f_1585_29013_29065(string
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<string>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 29013, 29065);
return return_v;
}


int
f_1585_28968_29066(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<string>>
eventHandler,System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerImpl
sender,System.Management.Automation.RemoteDataEventArgs<string>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<string>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 28968, 29066);
return 0;
}


System.Management.Automation.RemoteDataEventArgs<string>
f_1585_29270_29315(string
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<string>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 29270, 29315);
return return_v;
}


int
f_1585_29228_29316(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<string>>
eventHandler,System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerImpl
sender,System.Management.Automation.RemoteDataEventArgs<string>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<string>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 29228, 29316);
return 0;
}


string
f_1585_29490_29538()
{
var return_v = RemotingErrorIdStrings.ReceivedUnsupportedAction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 29490, 29538);
return return_v;
}


System.Management.Automation.Remoting.PSRemotingDataStructureException
f_1585_29453_29549(string
resourceString,params object[]
args)
{
var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 29453, 29549);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,26398,29599);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,26398,29599);
}
		}

internal void ProcessNonSessionMessages(RemoteDataObject<PSObject> rcvdData)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,29857,31929);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,30014,30140) || true) && (rcvdData == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,30014,30140);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,30068,30125);

throw f_1585_30074_30124("rcvdData");
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,30014,30140);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,30156,30223);

RemotingTargetInterface 
targetInterface = f_1585_30198_30222(rcvdData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,30239,30265);

Guid 
clientRunspacePoolId
=default(Guid);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,30279,30319);

RemoteRunspacePoolInternal 
runspacePool
=default(RemoteRunspacePoolInternal);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,30335,31918);

switch (targetInterface)
            {

case RemotingTargetInterface.Session:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,30335,31918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,30453,30578);

f_1585_30453_30577(false, "The session remote data is handled my session data structure handler, not here");
DynAbs.Tracing.TraceSender.TraceBreak(1585,30600,30606);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,30335,31918);

case RemotingTargetInterface.RunspacePool:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,30335,31918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,30690,30737);

clientRunspacePoolId = f_1585_30713_30736(rcvdData);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,30759,30821);

runspacePool = f_1585_30774_30820(_session, clientRunspacePoolId);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,30845,31446) || true) && (runspacePool != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,30845,31446);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,30955,31019);

f_1585_30955_31018(f_1585_30955_30988(runspacePool), rcvdData);
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,30845,31446);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,30845,31446);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,31272,31423);

f_1585_31272_31422(                        // The runspace pool may have been removed on the client side,
                        // so, we should just ignore the message.
                        s_trace, @"Client received data for Runspace (id: {0}),
                            but the Runspace cannot be found", clientRunspacePoolId);
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,30845,31446);
}
DynAbs.Tracing.TraceSender.TraceBreak(1585,31470,31476);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,30335,31918);

case RemotingTargetInterface.PowerShell:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,30335,31918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,31558,31605);

clientRunspacePoolId = f_1585_31581_31604(rcvdData);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,31627,31689);

runspacePool = f_1585_31642_31688(_session, clientRunspacePoolId);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,31745,31817);

f_1585_31745_31816(f_1585_31745_31778(runspacePool), rcvdData);
DynAbs.Tracing.TraceSender.TraceBreak(1585,31839,31845);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,30335,31918);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,30335,31918);
DynAbs.Tracing.TraceSender.TraceBreak(1585,31897,31903);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,30335,31918);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,29857,31929);

System.Management.Automation.PSArgumentNullException
f_1585_30074_30124(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 30074, 30124);
return return_v;
}


System.Management.Automation.RemotingTargetInterface
f_1585_30198_30222(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.TargetInterface;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 30198, 30222);
return return_v;
}


int
f_1585_30453_30577(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 30453, 30577);
return 0;
}


System.Guid
f_1585_30713_30736(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.RunspacePoolId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 30713, 30736);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1585_30774_30820(System.Management.Automation.Remoting.ClientRemoteSession
this_param,System.Guid
clientRunspacePoolId)
{
var return_v = this_param.GetRunspacePool( clientRunspacePoolId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 30774, 30820);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1585_30955_30988(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 30955, 30988);
return return_v;
}


int
f_1585_30955_31018(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
receivedData)
{
this_param.ProcessReceivedData( receivedData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 30955, 31018);
return 0;
}


int
f_1585_31272_31422(System.Management.Automation.PSTraceSource
this_param,string
format,System.Guid
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 31272, 31422);
return 0;
}


System.Guid
f_1585_31581_31604(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.RunspacePoolId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 31581, 31604);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1585_31642_31688(System.Management.Automation.Remoting.ClientRemoteSession
this_param,System.Guid
clientRunspacePoolId)
{
var return_v = this_param.GetRunspacePool( clientRunspacePoolId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 31642, 31688);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1585_31745_31778(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 31745, 31778);
return return_v;
}


int
f_1585_31745_31816(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
rcvdData)
{
this_param.DispatchMessageToPowerShell( rcvdData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 31745, 31816);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,29857,31929);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,29857,31929);
}
		}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,32095,32208);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,32141,32155);

f_1585_32141_32154(this, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,32171,32197);

f_1585_32171_32196(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,32095,32208);

int
f_1585_32141_32154(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerImpl
this_param,bool
disposing)
{
this_param.Dispose( disposing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 32141, 32154);
return 0;
}


int
f_1585_32171_32196(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerImpl
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 32171, 32196);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,32095,32208);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,32095,32208);
}
		}

protected void Dispose(bool disposing)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,32388,32552);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,32451,32541) || true) && (disposing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1585,32451,32541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,32498,32526);

f_1585_32498_32525(                _transportManager);
DynAbs.Tracing.TraceSender.TraceExitCondition(1585,32451,32541);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,32388,32552);

int
f_1585_32498_32525(System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 32498, 32525);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,32388,32552);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,32388,32552);
}
		}

        
        
        internal override event EventHandler<RemoteDataEventArgs<string>> 
EncryptedSessionKeyReceived
;

        internal override event EventHandler<RemoteDataEventArgs<string>> 
PublicKeyRequestReceived
;

internal override void SendPublicKeyAsync(string localPublicKey)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,33032,33353);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,33121,33342);

f_1585_33121_33341(f_1585_33121_33161(_transportManager), f_1585_33192_33340(f_1585_33228_33274(f_1585_33228_33263(_session)), localPublicKey, RemotingDestination.Server));
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,33032,33353);

System.Management.Automation.Remoting.PrioritySendDataCollection
f_1585_33121_33161(System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
this_param)
{
var return_v = this_param.DataToBeSentCollection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 33121, 33161);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1585_33228_33263(System.Management.Automation.Remoting.ClientRemoteSession
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 33228, 33263);
return return_v;
}


System.Guid
f_1585_33228_33274(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 33228, 33274);
return return_v;
}


System.Management.Automation.Remoting.RemoteDataObject
f_1585_33192_33340(System.Guid
runspacePoolId,string
publicKey,System.Management.Automation.RemotingDestination
destination)
{
var return_v = RemotingEncoder.GenerateMyPublicKey( runspacePoolId, publicKey, destination);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 33192, 33340);
return return_v;
}


int
f_1585_33121_33341(System.Management.Automation.Remoting.PrioritySendDataCollection
this_param,System.Management.Automation.Remoting.RemoteDataObject
data)
{
this_param.Add<object>( (System.Management.Automation.Remoting.RemoteDataObject<object>)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 33121, 33341);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,33032,33353);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,33032,33353);
}
		}

internal override void RaiseKeyExchangeMessageReceived(RemoteDataObject<PSObject> receivedData)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1585,33632,33825);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,33752,33814);

f_1585_33752_33813(this, f_1585_33775_33812(receivedData));
DynAbs.Tracing.TraceSender.TraceExitMethod(1585,33632,33825);

System.Management.Automation.RemoteDataEventArgs
f_1585_33775_33812(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
receivedData)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs( receivedData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 33775, 33812);
return return_v;
}


int
f_1585_33752_33813(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerImpl
this_param,System.Management.Automation.RemoteDataEventArgs
arg)
{
this_param.ProcessSessionMessages( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 33752, 33813);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1585,33632,33825);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,33632,33825);
}
		}

static ClientRemoteSessionDSHandlerImpl()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1585,517,33867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,751,838);
s_trace = f_1585_761_838("CRSDSHdlerImpl", "ClientRemoteSessionDSHandlerImpl");DynAbs.Tracing.TraceSender.TraceSimpleStatement(1585,870,908);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1585,517,33867);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1585,517,33867);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1585,517,33867);

static System.Management.Automation.PSTraceSource
f_1585_761_838(string
name,string
description)
{
var return_v = PSTraceSource.GetTracer( name, description);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 761, 838);
return return_v;
}


object
f_1585_1361_1373()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 1361, 1373);
return return_v;
}


int
f_1585_2699_2788(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 2699, 2788);
return 0;
}


System.Management.Automation.PSArgumentNullException
f_1585_2864_2913(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 2864, 2913);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1585_3033_3079()
{
var return_v = new System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 3033, 3079);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1585_3382_3417(System.Management.Automation.Remoting.ClientRemoteSession
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 3382, 3417);
return return_v;
}


System.Guid
f_1585_3382_3428(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 3382, 3428);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1585_3447_3482(System.Management.Automation.Remoting.ClientRemoteSession
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 3447, 3482);
return return_v;
}


string
f_1585_3447_3487(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 3447, 3487);
return return_v;
}


System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
f_1585_3312_3519(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param,System.Guid
instanceId,string
sessionName,System.Management.Automation.Internal.PSRemotingCryptoHelper
cryptoHelper)
{
var return_v = this_param.CreateClientSessionTransportManager( instanceId, sessionName, cryptoHelper);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1585, 3312, 3519);
return return_v;
}


int
f_1585_4494_4547(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.MaximumConnectionRedirectionCount;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1585, 4494, 4547);
return return_v;
}

}
}
