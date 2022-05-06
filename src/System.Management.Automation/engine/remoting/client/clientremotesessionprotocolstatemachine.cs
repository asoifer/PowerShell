// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
internal class ClientRemoteSessionDSHandlerStateMachine
{
[TraceSourceAttribute("CRSessionFSM", "CRSessionFSM")]
        private static PSTraceSource s_trace ;

private EventHandler<RemoteSessionStateMachineEventArgs>[,] _stateMachineHandle;

private Queue<RemoteSessionStateEventArgs> _clientRemoteSessionStateChangeQueue;

private RemoteSessionState _state;

private Queue<RemoteSessionStateMachineEventArgs> _processPendingEventsQueue
;

private object _syncObject ;

private bool _eventsInProcess ;

private Timer _keyExchangeTimer;

private bool _keyExchanged ;

private bool _pendingDisconnect ;

private void ProcessEvents()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1572,4100,5089);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,4153,4205);

RemoteSessionStateMachineEventArgs 
eventArgs = null
;
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,4221,5078);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,4262,4273);
                lock (_syncObject)
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,4315,4486) || true) && (f_1572_4319_4351(_processPendingEventsQueue)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,4315,4486);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,4406,4431);

_eventsInProcess = false;
DynAbs.Tracing.TraceSender.TraceBreak(1572,4457,4463);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,4315,4486);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,4510,4559);

eventArgs = f_1572_4522_4558(_processPendingEventsQueue);
                }

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,4642,4671);

f_1572_4642_4670(this, eventArgs);
                }
                catch (Exception ex)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1572,4708,4809);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,4769,4790);

f_1572_4769_4789(this, ex);
DynAbs.Tracing.TraceSender.TraceExitCatch(1572,4708,4809);
                }

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,4873,4899);

f_1572_4873_4898(this);
                }
                catch (Exception ex)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1572,4936,5037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,4997,5018);

f_1572_4997_5017(this, ex);
DynAbs.Tracing.TraceSender.TraceExitCatch(1572,4936,5037);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,4221,5078);
}
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,4221,5078) || true) && (_eventsInProcess)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1572,4221,5078);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1572,4221,5078);
}}DynAbs.Tracing.TraceSender.TraceExitMethod(1572,4100,5089);

int
f_1572_4319_4351(System.Collections.Generic.Queue<System.Management.Automation.RemoteSessionStateMachineEventArgs>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 4319, 4351);
return return_v;
}


System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1572_4522_4558(System.Collections.Generic.Queue<System.Management.Automation.RemoteSessionStateMachineEventArgs>
this_param)
{
var return_v = this_param.Dequeue();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 4522, 4558);
return return_v;
}


int
f_1572_4642_4670(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEventPrivate( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 4642, 4670);
return 0;
}


int
f_1572_4769_4789(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Exception
ex)
{
this_param.HandleFatalError( ex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 4769, 4789);
return 0;
}


int
f_1572_4873_4898(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param)
{
this_param.RaiseStateMachineEvents();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 4873, 4898);
return 0;
}


int
f_1572_4997_5017(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Exception
ex)
{
this_param.HandleFatalError( ex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 4997, 5017);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1572,4100,5089);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,4100,5089);
}
		}

private void HandleFatalError(Exception ex)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1572,5101,5910);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,5537,5696);

PSRemotingDataStructureException 
fatalError = f_1572_5583_5695(ex, f_1572_5649_5694())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,5712,5854);

RemoteSessionStateMachineEventArgs 
closeEvent =
f_1572_5777_5853(RemoteSessionEvent.Close, fatalError)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,5870,5899);

f_1572_5870_5898(this, closeEvent, true);
DynAbs.Tracing.TraceSender.TraceExitMethod(1572,5101,5910);

string
f_1572_5649_5694()
{
var return_v =                         RemotingErrorIdStrings.FatalErrorCausingClose;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 5649, 5694);
return return_v;
}


System.Management.Automation.Remoting.PSRemotingDataStructureException
f_1572_5583_5695(System.Exception
innerException,string
resourceString,params object[]
args)
{
var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException( innerException, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 5583, 5695);
return return_v;
}


System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1572_5777_5853(System.Management.Automation.RemoteSessionEvent
stateEvent,System.Management.Automation.Remoting.PSRemotingDataStructureException
reason)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent, (System.Exception)reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 5777, 5853);
return return_v;
}


int
f_1572_5870_5898(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg,bool
clearQueuedEvents)
{
this_param.RaiseEvent( arg, clearQueuedEvents);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 5870, 5898);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1572,5101,5910);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,5101,5910);
}
		}

private void RaiseStateMachineEvents()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1572,6170,6542);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,6233,6283);

RemoteSessionStateEventArgs 
queuedEventArg = null
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,6299,6531) || true) && (f_1572_6306_6348(_clientRemoteSessionStateChangeQueue)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,6299,6531);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,6386,6450);

queuedEventArg = f_1572_6403_6449(_clientRemoteSessionStateChangeQueue);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,6470,6516);

f_1572_6470_6515(
                StateChanged, this, queuedEventArg);
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,6299,6531);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1572,6299,6531);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1572,6299,6531);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1572,6170,6542);

int
f_1572_6306_6348(System.Collections.Generic.Queue<System.Management.Automation.RemoteSessionStateEventArgs>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 6306, 6348);
return return_v;
}


System.Management.Automation.RemoteSessionStateEventArgs
f_1572_6403_6449(System.Collections.Generic.Queue<System.Management.Automation.RemoteSessionStateEventArgs>
this_param)
{
var return_v = this_param.Dequeue();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 6403, 6449);
return return_v;
}


int
f_1572_6470_6515(System.EventHandler<System.Management.Automation.RemoteSessionStateEventArgs>
eventHandler,System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
sender,System.Management.Automation.RemoteSessionStateEventArgs
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteSessionStateEventArgs>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 6470, 6515);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1572,6170,6542);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,6170,6542);
}
		}

private Guid _id;

private void SetStateHandler(object sender, RemoteSessionStateMachineEventArgs eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1572,7123,14211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,7237,14200);

switch (f_1572_7245_7265(eventArgs))
            {

case RemoteSessionEvent.NegotiationCompleted:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,7237,14200);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,7393,7565);

f_1572_7393_7564(_state == RemoteSessionState.NegotiationReceived, "State can be set to Established only when current state is NegotiationReceived");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,7591,7638);

f_1572_7591_7637(this, RemoteSessionState.Established, null);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1572,7685,7691);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,7237,14200);

case RemoteSessionEvent.NegotiationReceived:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,7237,14200);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,7804,7976);

f_1572_7804_7975(f_1572_7815_7848(eventArgs)!= null, "State can be set to NegotiationReceived only when RemoteSessionCapability is not null");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,8002,8186) || true) && (f_1572_8006_8039(eventArgs)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,8002,8186);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,8105,8159);

throw f_1572_8111_8158("eventArgs");
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,8002,8186);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,8214,8269);

f_1572_8214_8268(this, RemoteSessionState.NegotiationReceived, null);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1572,8316,8322);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,7237,14200);

case RemoteSessionEvent.NegotiationSendCompleted:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,7237,14200);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,8440,8676);

f_1572_8440_8675((_state == RemoteSessionState.NegotiationSending) ||(DynAbs.Tracing.TraceSender.Expression_False(1572, 8451, 8562)||(_state == RemoteSessionState.NegotiationSendingOnConnect)), "Negotiating send can be completed only when current state is NegotiationSending");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,8704,8755);

f_1572_8704_8754(this, RemoteSessionState.NegotiationSent, null);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1572,8802,8808);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,7237,14200);

case RemoteSessionEvent.ConnectFailed:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,7237,14200);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,8915,9077);

f_1572_8915_9076(_state == RemoteSessionState.Connecting, "A ConnectFailed event can be raised only when the current state is Connecting");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,9105,9170);

f_1572_9105_9169(this, RemoteSessionState.ClosingConnection, f_1572_9152_9168(eventArgs));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1572,9217,9223);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,7237,14200);

case RemoteSessionEvent.CloseFailed:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,7237,14200);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,9328,9382);

f_1572_9328_9381(this, RemoteSessionState.Closed, f_1572_9364_9380(eventArgs));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1572,9429,9435);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,7237,14200);

case RemoteSessionEvent.CloseCompleted:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,7237,14200);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,9543,9597);

f_1572_9543_9596(this, RemoteSessionState.Closed, f_1572_9579_9595(eventArgs));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1572,9644,9650);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,7237,14200);

case RemoteSessionEvent.KeyRequested:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,7237,14200);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,9756,9918);

f_1572_9756_9917(_state == RemoteSessionState.Established, "Server can request a key only after the client reaches the Established state");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,9946,10149) || true) && (_state == RemoteSessionState.Established)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,9946,10149);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,10048,10122);

f_1572_10048_10121(this, RemoteSessionState.EstablishedAndKeyRequested, f_1572_10104_10120(eventArgs));
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,9946,10149);
}
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1572,10196,10202);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,7237,14200);

case RemoteSessionEvent.KeyReceived:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,7237,14200);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,10307,10472);

f_1572_10307_10471(_state == RemoteSessionState.EstablishedAndKeySent, "Key Receiving can only be raised after reaching the Established state");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,10500,11362) || true) && (_state == RemoteSessionState.EstablishedAndKeySent)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,10500,11362);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,10612,10674);

Timer 
tmp = f_1572_10624_10673(ref _keyExchangeTimer, null)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,10704,10830) || true) && (tmp != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,10704,10830);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,10785,10799);

f_1572_10785_10798(                                tmp);
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,10704,10830);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,10862,10883);

_keyExchanged = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,10913,10972);

f_1572_10913_10971(this, RemoteSessionState.Established, f_1572_10954_10970(eventArgs));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,11004,11335) || true) && (_pendingDisconnect)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,11004,11335);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,11211,11238);

_pendingDisconnect = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,11272,11304);

f_1572_11272_11303(this, sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,11004,11335);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,10500,11362);
}
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1572,11409,11415);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,7237,14200);

case RemoteSessionEvent.KeySent:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,7237,14200);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,11516,11672);

f_1572_11516_11671(_state >= RemoteSessionState.Established, "Client can send a public key only after reaching the Established state");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,11700,11778);

f_1572_11700_11777(_keyExchanged == false, "Client should do key exchange only once");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,11806,12315) || true) && (_state == RemoteSessionState.Established ||(DynAbs.Tracing.TraceSender.Expression_False(1572, 11810, 11938)||                            _state == RemoteSessionState.EstablishedAndKeyRequested))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,11806,12315);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,11996,12065);

f_1572_11996_12064(this, RemoteSessionState.EstablishedAndKeySent, f_1572_12047_12063(eventArgs));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,12154,12288);

_keyExchangeTimer = f_1572_12174_12287(HandleKeyExchangeTimeout, null, BaseTransportManager.ClientDefaultOperationTimeoutMs, Timeout.Infinite);
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,11806,12315);
}
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1572,12362,12368);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,7237,14200);

case RemoteSessionEvent.DisconnectCompleted:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,7237,14200);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,12479,12687);

f_1572_12479_12686(_state == RemoteSessionState.Disconnecting ||(DynAbs.Tracing.TraceSender.Expression_False(1572, 12490, 12580)||_state == RemoteSessionState.RCDisconnecting), "DisconnectCompleted event received while state machine is in wrong state");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,12715,12954) || true) && (_state == RemoteSessionState.Disconnecting ||(DynAbs.Tracing.TraceSender.Expression_False(1572, 12719, 12809)||_state == RemoteSessionState.RCDisconnecting))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,12715,12954);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,12867,12927);

f_1572_12867_12926(this, RemoteSessionState.Disconnected, f_1572_12909_12925(eventArgs));
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,12715,12954);
}
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1572,13001,13007);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,7237,14200);

case RemoteSessionEvent.DisconnectFailed:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,7237,14200);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,13115,13274);

f_1572_13115_13273(_state == RemoteSessionState.Disconnecting, "DisconnectCompleted event received while state machine is in wrong state");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,13302,13594) || true) && (_state == RemoteSessionState.Disconnecting)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,13302,13594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,13406,13466);

f_1572_13406_13465(this, RemoteSessionState.Disconnected, f_1572_13448_13464(eventArgs));
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,13302,13594);
}
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1572,13641,13647);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,7237,14200);

case RemoteSessionEvent.ReconnectCompleted:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,7237,14200);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,13757,13915);

f_1572_13757_13914(_state == RemoteSessionState.Reconnecting, "ReconnectCompleted event received while state machine is in wrong state");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,13943,14132) || true) && (_state == RemoteSessionState.Reconnecting)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,13943,14132);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,14046,14105);

f_1572_14046_14104(this, RemoteSessionState.Established, f_1572_14087_14103(eventArgs));
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,13943,14132);
}
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1572,14179,14185);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,7237,14200);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1572,7123,14211);

System.Management.Automation.RemoteSessionEvent
f_1572_7245_7265(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.StateEvent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 7245, 7265);
return return_v;
}


int
f_1572_7393_7564(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 7393, 7564);
return 0;
}


int
f_1572_7591_7637(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionState
newState,System.Exception
reason)
{
this_param.SetState( newState, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 7591, 7637);
return 0;
}


System.Management.Automation.Remoting.RemoteSessionCapability
f_1572_7815_7848(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.RemoteSessionCapability ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 7815, 7848);
return return_v;
}


int
f_1572_7804_7975(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 7804, 7975);
return 0;
}


System.Management.Automation.Remoting.RemoteSessionCapability
f_1572_8006_8039(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.RemoteSessionCapability ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 8006, 8039);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1572_8111_8158(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 8111, 8158);
return return_v;
}


int
f_1572_8214_8268(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionState
newState,System.Exception
reason)
{
this_param.SetState( newState, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 8214, 8268);
return 0;
}


int
f_1572_8440_8675(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 8440, 8675);
return 0;
}


int
f_1572_8704_8754(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionState
newState,System.Exception
reason)
{
this_param.SetState( newState, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 8704, 8754);
return 0;
}


int
f_1572_8915_9076(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 8915, 9076);
return 0;
}


System.Exception
f_1572_9152_9168(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 9152, 9168);
return return_v;
}


int
f_1572_9105_9169(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionState
newState,System.Exception
reason)
{
this_param.SetState( newState, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 9105, 9169);
return 0;
}


System.Exception
f_1572_9364_9380(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 9364, 9380);
return return_v;
}


int
f_1572_9328_9381(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionState
newState,System.Exception
reason)
{
this_param.SetState( newState, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 9328, 9381);
return 0;
}


System.Exception
f_1572_9579_9595(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 9579, 9595);
return return_v;
}


int
f_1572_9543_9596(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionState
newState,System.Exception
reason)
{
this_param.SetState( newState, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 9543, 9596);
return 0;
}


int
f_1572_9756_9917(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 9756, 9917);
return 0;
}


System.Exception
f_1572_10104_10120(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 10104, 10120);
return return_v;
}


int
f_1572_10048_10121(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionState
newState,System.Exception
reason)
{
this_param.SetState( newState, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 10048, 10121);
return 0;
}


int
f_1572_10307_10471(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 10307, 10471);
return 0;
}


System.Threading.Timer
f_1572_10624_10673(ref System.Threading.Timer
location1,System.Threading.Timer
value)
{
var return_v = Interlocked.Exchange( ref location1, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 10624, 10673);
return return_v;
}


int
f_1572_10785_10798(System.Threading.Timer
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 10785, 10798);
return 0;
}


System.Exception
f_1572_10954_10970(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 10954, 10970);
return return_v;
}


int
f_1572_10913_10971(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionState
newState,System.Exception
reason)
{
this_param.SetState( newState, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 10913, 10971);
return 0;
}


int
f_1572_11272_11303(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,object
sender,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.DoDisconnect( sender, arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 11272, 11303);
return 0;
}


int
f_1572_11516_11671(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 11516, 11671);
return 0;
}


int
f_1572_11700_11777(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 11700, 11777);
return 0;
}


System.Exception
f_1572_12047_12063(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 12047, 12063);
return return_v;
}


int
f_1572_11996_12064(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionState
newState,System.Exception
reason)
{
this_param.SetState( newState, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 11996, 12064);
return 0;
}


System.Threading.Timer
f_1572_12174_12287(System.Threading.TimerCallback
callback,object?
state,int
dueTime,int
period)
{
var return_v = new System.Threading.Timer( callback, state, dueTime, period);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 12174, 12287);
return return_v;
}


int
f_1572_12479_12686(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 12479, 12686);
return 0;
}


System.Exception
f_1572_12909_12925(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 12909, 12925);
return return_v;
}


int
f_1572_12867_12926(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionState
newState,System.Exception
reason)
{
this_param.SetState( newState, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 12867, 12926);
return 0;
}


int
f_1572_13115_13273(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 13115, 13273);
return 0;
}


System.Exception
f_1572_13448_13464(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 13448, 13464);
return return_v;
}


int
f_1572_13406_13465(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionState
newState,System.Exception
reason)
{
this_param.SetState( newState, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 13406, 13465);
return 0;
}


int
f_1572_13757_13914(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 13757, 13914);
return 0;
}


System.Exception
f_1572_14087_14103(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 14087, 14103);
return return_v;
}


int
f_1572_14046_14104(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionState
newState,System.Exception
reason)
{
this_param.SetState( newState, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 14046, 14104);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1572,7123,14211);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,7123,14211);
}
		}

private void HandleKeyExchangeTimeout(object sender)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1572,14385,15037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,14462,14578);

f_1572_14462_14577(_state == RemoteSessionState.EstablishedAndKeySent, "timeout should only happen when waiting for a key");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,14594,14656);

Timer 
tmp = f_1572_14606_14655(ref _keyExchangeTimer, null)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,14670,14748) || true) && (tmp != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,14670,14748);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,14719,14733);

f_1572_14719_14732(                tmp);
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,14670,14748);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,14764,14911);

PSRemotingDataStructureException 
exception =
f_1572_14826_14910(f_1572_14863_14909())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,14927,15026);

f_1572_14927_15025(this, f_1572_14938_15024(RemoteSessionEvent.KeyReceiveFailed, exception));
DynAbs.Tracing.TraceSender.TraceExitMethod(1572,14385,15037);

int
f_1572_14462_14577(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 14462, 14577);
return 0;
}


System.Threading.Timer
f_1572_14606_14655(ref System.Threading.Timer
location1,System.Threading.Timer
value)
{
var return_v = Interlocked.Exchange( ref location1, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 14606, 14655);
return return_v;
}


int
f_1572_14719_14732(System.Threading.Timer
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 14719, 14732);
return 0;
}


string
f_1572_14863_14909()
{
var return_v = RemotingErrorIdStrings.ClientKeyExchangeFailed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 14863, 14909);
return return_v;
}


System.Management.Automation.Remoting.PSRemotingDataStructureException
f_1572_14826_14910(string
message)
{
var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 14826, 14910);
return return_v;
}


System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1572_14938_15024(System.Management.Automation.RemoteSessionEvent
stateEvent,System.Management.Automation.Remoting.PSRemotingDataStructureException
reason)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent, (System.Exception)reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 14938, 15024);
return return_v;
}


int
f_1572_14927_15025(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 14927, 15025);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1572,14385,15037);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,14385,15037);
}
		}

private void SetStateToClosedHandler(object sender, RemoteSessionStateMachineEventArgs eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1572,15458,17229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,15580,16663);

f_1572_15580_16662(_state == RemoteSessionState.NegotiationReceived &&(DynAbs.Tracing.TraceSender.Expression_True(1572, 15591, 15732)&&f_1572_15672_15692(eventArgs)== RemoteSessionEvent.NegotiationFailed )||(DynAbs.Tracing.TraceSender.Expression_False(1572, 15591, 15818)||f_1572_15765_15785(eventArgs)== RemoteSessionEvent.SendFailed )||(DynAbs.Tracing.TraceSender.Expression_False(1572, 15591, 15907)||f_1572_15851_15871(eventArgs)== RemoteSessionEvent.ReceiveFailed )||(DynAbs.Tracing.TraceSender.Expression_False(1572, 15591, 16001)||f_1572_15940_15960(eventArgs)== RemoteSessionEvent.NegotiationTimeout )||(DynAbs.Tracing.TraceSender.Expression_False(1572, 15591, 16090)||f_1572_16034_16054(eventArgs)== RemoteSessionEvent.KeySendFailed )||(DynAbs.Tracing.TraceSender.Expression_False(1572, 15591, 16182)||f_1572_16123_16143(eventArgs)== RemoteSessionEvent.KeyReceiveFailed )||(DynAbs.Tracing.TraceSender.Expression_False(1572, 15591, 16274)||f_1572_16215_16235(eventArgs)== RemoteSessionEvent.KeyRequestFailed )||(DynAbs.Tracing.TraceSender.Expression_False(1572, 15591, 16365)||f_1572_16307_16327(eventArgs)== RemoteSessionEvent.ReconnectFailed), "An event to close the state machine can be raised only on the following conditions: " +
            "1. Negotiation failed 2. Send failed 3. Receive failed 4. Negotiation timedout 5. Key send failed 6. key receive failed 7. key exchange failed 8. Reconnection failed");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,16839,17020) || true) && (f_1572_16843_16863(eventArgs)== RemoteSessionEvent.NegotiationTimeout &&(DynAbs.Tracing.TraceSender.Expression_True(1572, 16843, 16964)&&f_1572_16925_16930()== RemoteSessionState.Established))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,16839,17020);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,16998,17005);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,16839,17020);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,17094,17218);

f_1572_17094_17217(this, f_1572_17105_17216(RemoteSessionEvent.Close, f_1572_17199_17215(eventArgs)));
DynAbs.Tracing.TraceSender.TraceExitMethod(1572,15458,17229);

System.Management.Automation.RemoteSessionEvent
f_1572_15672_15692(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.StateEvent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 15672, 15692);
return return_v;
}


System.Management.Automation.RemoteSessionEvent
f_1572_15765_15785(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.StateEvent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 15765, 15785);
return return_v;
}


System.Management.Automation.RemoteSessionEvent
f_1572_15851_15871(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.StateEvent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 15851, 15871);
return return_v;
}


System.Management.Automation.RemoteSessionEvent
f_1572_15940_15960(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.StateEvent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 15940, 15960);
return return_v;
}


System.Management.Automation.RemoteSessionEvent
f_1572_16034_16054(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.StateEvent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 16034, 16054);
return return_v;
}


System.Management.Automation.RemoteSessionEvent
f_1572_16123_16143(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.StateEvent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 16123, 16143);
return return_v;
}


System.Management.Automation.RemoteSessionEvent
f_1572_16215_16235(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.StateEvent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 16215, 16235);
return return_v;
}


System.Management.Automation.RemoteSessionEvent
f_1572_16307_16327(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.StateEvent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 16307, 16327);
return return_v;
}


int
f_1572_15580_16662(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 15580, 16662);
return 0;
}


System.Management.Automation.RemoteSessionEvent
f_1572_16843_16863(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.StateEvent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 16843, 16863);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1572_16925_16930()
{
var return_v = State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 16925, 16930);
return return_v;
}


System.Exception
f_1572_17199_17215(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 17199, 17215);
return return_v;
}


System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1572_17105_17216(System.Management.Automation.RemoteSessionEvent
stateEvent,System.Exception
reason)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 17105, 17216);
return return_v;
}


int
f_1572_17094_17217(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 17094, 17217);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1572,15458,17229);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,15458,17229);
}
		}

internal ClientRemoteSessionDSHandlerStateMachine()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1572,17395,23575);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,2110,2129);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,2183,2219);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,2345,2351);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,2414,2503);
this._processPendingEventsQueue = f_1572_2456_2503();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,2620,2646);
this._syncObject = f_1572_2634_2646();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,2747,2771);
this._eventsInProcess = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,3218,3235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,3398,3419);
this._keyExchanged = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,3726,3752);
this._pendingDisconnect = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,17471,17551);

_clientRemoteSessionStateChangeQueue = f_1572_17510_17550();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,17634,17777);

_stateMachineHandle = new EventHandler<RemoteSessionStateMachineEventArgs>[(int)RemoteSessionState.MaxState, (int)RemoteSessionEvent.MaxEvent];
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,17800,17805);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,17791,18778) || true) && (i < f_1572_17811_17843(_stateMachineHandle, 0))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,17845,17848)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1572,17791,18778))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,17791,18778);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,17882,17952);

_stateMachineHandle[i, (int)RemoteSessionEvent.FatalError] += DoFatal;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,17972,18037);

_stateMachineHandle[i, (int)RemoteSessionEvent.Close] += DoClose;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,18055,18134);

_stateMachineHandle[i, (int)RemoteSessionEvent.CloseFailed] += SetStateHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,18152,18234);

_stateMachineHandle[i, (int)RemoteSessionEvent.CloseCompleted] += SetStateHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,18254,18348);

_stateMachineHandle[i, (int)RemoteSessionEvent.NegotiationTimeout] += SetStateToClosedHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,18368,18454);

_stateMachineHandle[i, (int)RemoteSessionEvent.SendFailed] += SetStateToClosedHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,18474,18563);

_stateMachineHandle[i, (int)RemoteSessionEvent.ReceiveFailed] += SetStateToClosedHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,18581,18662);

_stateMachineHandle[i, (int)RemoteSessionEvent.CreateSession] += DoCreateSession;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,18680,18763);

_stateMachineHandle[i, (int)RemoteSessionEvent.ConnectSession] += DoConnectSession;
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1572,1,988);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1572,1,988);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,18794,18912);

_stateMachineHandle[(int)RemoteSessionState.Idle, (int)RemoteSessionEvent.NegotiationSending] += DoNegotiationSending;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,18928,19055);

_stateMachineHandle[(int)RemoteSessionState.Idle, (int)RemoteSessionEvent.NegotiationSendingOnConnect] += DoNegotiationSending;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,19071,19204);

_stateMachineHandle[(int)RemoteSessionState.NegotiationSending, (int)RemoteSessionEvent.NegotiationSendCompleted] += SetStateHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,19220,19362);

_stateMachineHandle[(int)RemoteSessionState.NegotiationSendingOnConnect, (int)RemoteSessionEvent.NegotiationSendCompleted] += SetStateHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,19378,19503);

_stateMachineHandle[(int)RemoteSessionState.NegotiationSent, (int)RemoteSessionEvent.NegotiationReceived] += SetStateHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,19519,19649);

_stateMachineHandle[(int)RemoteSessionState.NegotiationReceived, (int)RemoteSessionEvent.NegotiationCompleted] += SetStateHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,19665,19800);

_stateMachineHandle[(int)RemoteSessionState.NegotiationReceived, (int)RemoteSessionEvent.NegotiationFailed] += SetStateToClosedHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,19816,19930);

_stateMachineHandle[(int)RemoteSessionState.Connecting, (int)RemoteSessionEvent.ConnectFailed] += SetStateHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,19946,20068);

_stateMachineHandle[(int)RemoteSessionState.ClosingConnection, (int)RemoteSessionEvent.CloseCompleted] += SetStateHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,20084,20198);

_stateMachineHandle[(int)RemoteSessionState.Established, (int)RemoteSessionEvent.DisconnectStart] += DoDisconnect;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,20212,20335);

_stateMachineHandle[(int)RemoteSessionState.Disconnecting, (int)RemoteSessionEvent.DisconnectCompleted] += SetStateHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,20349,20469);

_stateMachineHandle[(int)RemoteSessionState.Disconnecting, (int)RemoteSessionEvent.DisconnectFailed] += SetStateHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,20497,20610);

_stateMachineHandle[(int)RemoteSessionState.Disconnected, (int)RemoteSessionEvent.ReconnectStart] += DoReconnect;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,20624,20745);

_stateMachineHandle[(int)RemoteSessionState.Reconnecting, (int)RemoteSessionEvent.ReconnectCompleted] += SetStateHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,20759,20885);

_stateMachineHandle[(int)RemoteSessionState.Reconnecting, (int)RemoteSessionEvent.ReconnectFailed] += SetStateToClosedHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,20901,21030);

_stateMachineHandle[(int)RemoteSessionState.Disconnecting, (int)RemoteSessionEvent.RCDisconnectStarted] += DoRCDisconnectStarted;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,21044,21172);

_stateMachineHandle[(int)RemoteSessionState.Disconnected, (int)RemoteSessionEvent.RCDisconnectStarted] += DoRCDisconnectStarted;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,21186,21313);

_stateMachineHandle[(int)RemoteSessionState.Established, (int)RemoteSessionEvent.RCDisconnectStarted] += DoRCDisconnectStarted;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,21327,21452);

_stateMachineHandle[(int)RemoteSessionState.RCDisconnecting, (int)RemoteSessionEvent.DisconnectCompleted] += SetStateHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,21523,21664);

_stateMachineHandle[(int)RemoteSessionState.EstablishedAndKeySent, (int)RemoteSessionEvent.DisconnectStart] += DoDisconnectDuringKeyExchange;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,21678,21824);

_stateMachineHandle[(int)RemoteSessionState.EstablishedAndKeyRequested, (int)RemoteSessionEvent.DisconnectStart] += DoDisconnectDuringKeyExchange;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,21840,21954);

_stateMachineHandle[(int)RemoteSessionState.Established, (int)RemoteSessionEvent.KeyRequested] += SetStateHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,21971,22080);

_stateMachineHandle[(int)RemoteSessionState.Established, (int)RemoteSessionEvent.KeySent] += SetStateHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,22097,22220);

_stateMachineHandle[(int)RemoteSessionState.Established, (int)RemoteSessionEvent.KeySendFailed] += SetStateToClosedHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,22237,22360);

_stateMachineHandle[(int)RemoteSessionState.EstablishedAndKeySent, (int)RemoteSessionEvent.KeyReceived] += SetStateHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,22377,22501);

_stateMachineHandle[(int)RemoteSessionState.EstablishedAndKeyRequested, (int)RemoteSessionEvent.KeySent] += SetStateHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,22518,22654);

_stateMachineHandle[(int)RemoteSessionState.EstablishedAndKeySent, (int)RemoteSessionEvent.KeyReceiveFailed] += SetStateToClosedHandler;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,22671,22809);

_stateMachineHandle[(int)RemoteSessionState.EstablishedAndKeyRequested, (int)RemoteSessionEvent.KeySendFailed] += SetStateToClosedHandler;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,23016,23021);

            // TODO: All these are potential unexpected state transitions.. should have a way to track these calls..
            // should atleast put a dbg assert in this handler
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,23007,23378) || true) && (i < f_1572_23027_23059(_stateMachineHandle, 0))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,23061,23064)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1572,23007,23378))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,23007,23378);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,23107,23112);
                for (int 
j = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,23098,23363) || true) && (j < f_1572_23118_23150(_stateMachineHandle, 1))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,23152,23155)
,j++,DynAbs.Tracing.TraceSender.TraceExitCondition(1572,23098,23363))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,23098,23363);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,23197,23344) || true) && (_stateMachineHandle[i, j] == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,23197,23344);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,23284,23321);

_stateMachineHandle[i, j] += DoClose;
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,23197,23344);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1572,1,266);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1572,1,266);
}}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1572,1,372);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1572,1,372);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,23394,23415);

_id = Guid.NewGuid();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,23524,23564);

f_1572_23524_23563(this, RemoteSessionState.Idle, null);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1572,17395,23575);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1572,17395,23575);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,17395,23575);
}
		}

internal bool CanByPassRaiseEvent(RemoteSessionStateMachineEventArgs arg)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1572,23983,24884);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,24081,24844) || true) && (f_1572_24085_24099(arg)== RemoteSessionEvent.MessageReceived)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,24081,24844);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,24171,24829) || true) && (_state == RemoteSessionState.Established ||(DynAbs.Tracing.TraceSender.Expression_False(1572, 24175, 24294)||                    _state == RemoteSessionState.EstablishedAndKeyReceived )||(DynAbs.Tracing.TraceSender.Expression_False(1572, 24175, 24445)||                    _state == RemoteSessionState.EstablishedAndKeySent )||(DynAbs.Tracing.TraceSender.Expression_False(1572, 24175, 24512)||                    _state == RemoteSessionState.Disconnecting )||(DynAbs.Tracing.TraceSender.Expression_False(1572, 24175, 24655)||                    _state == RemoteSessionState.Disconnected))
)                  // Data can arrive while state machine is transitioning to disconnected, in a race.

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,24171,24829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,24798,24810);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,24171,24829);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,24081,24844);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,24860,24873);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1572,23983,24884);

System.Management.Automation.RemoteSessionEvent
f_1572_24085_24099(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.StateEvent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 24085, 24099);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1572,23983,24884);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,23983,24884);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void RaiseEvent(RemoteSessionStateMachineEventArgs arg, bool clearQueuedEvents = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1572,25539,26250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,25666,25677);
            lock (_syncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,25711,25782);

f_1572_25711_25781(                s_trace, "Event received : {0} for {1}", f_1572_25761_25775(arg), _id);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,25800,25917) || true) && (clearQueuedEvents)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,25800,25917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,25863,25898);

f_1572_25863_25897(                    _processPendingEventsQueue);
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,25800,25917);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,25937,25977);

f_1572_25937_25976(
                _processPendingEventsQueue, arg);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,25997,26192) || true) && (!_eventsInProcess)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,25997,26192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,26060,26084);

_eventsInProcess = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,25997,26192);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,25997,26192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,26166,26173);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,25997,26192);
}
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,26223,26239);

f_1572_26223_26238(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1572,25539,26250);

System.Management.Automation.RemoteSessionEvent
f_1572_25761_25775(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.StateEvent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 25761, 25775);
return return_v;
}


int
f_1572_25711_25781(System.Management.Automation.PSTraceSource
this_param,string
format,System.Management.Automation.RemoteSessionEvent
arg1,System.Guid
arg2)
{
this_param.WriteLine( format, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 25711, 25781);
return 0;
}


int
f_1572_25863_25897(System.Collections.Generic.Queue<System.Management.Automation.RemoteSessionStateMachineEventArgs>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 25863, 25897);
return 0;
}


int
f_1572_25937_25976(System.Collections.Generic.Queue<System.Management.Automation.RemoteSessionStateMachineEventArgs>
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
item)
{
this_param.Enqueue( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 25937, 25976);
return 0;
}


int
f_1572_26223_26238(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param)
{
this_param.ProcessEvents();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 26223, 26238);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1572,25539,26250);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,25539,26250);
}
		}

private void RaiseEventPrivate(RemoteSessionStateMachineEventArgs arg)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1572,26801,27547);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,26896,27012) || true) && (arg == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,26896,27012);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,26945,26997);

throw f_1572_26951_26996("arg");
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,26896,27012);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,27028,27140);

EventHandler<RemoteSessionStateMachineEventArgs> 
handler = _stateMachineHandle[(int)f_1572_27112_27117(), (int)f_1572_27124_27138(arg)]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,27154,27536) || true) && (handler != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,27154,27536);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,27207,27335);

f_1572_27207_27334(                s_trace, "Before calling state machine event handler: state = {0}, event = {1}, id = {2}", f_1572_27307_27312(), f_1572_27314_27328(arg), _id);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,27355,27374);

f_1572_27355_27373(handler, this, arg);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,27394,27521);

f_1572_27394_27520(
                s_trace, "After calling state machine event handler: state = {0}, event = {1}, id = {2}", f_1572_27493_27498(), f_1572_27500_27514(arg), _id);
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,27154,27536);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1572,26801,27547);

System.Management.Automation.PSArgumentNullException
f_1572_26951_26996(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 26951, 26996);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1572_27112_27117()
{
var return_v = State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 27112, 27117);
return return_v;
}


System.Management.Automation.RemoteSessionEvent
f_1572_27124_27138(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.StateEvent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 27124, 27138);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1572_27307_27312()
{
var return_v = State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 27307, 27312);
return return_v;
}


System.Management.Automation.RemoteSessionEvent
f_1572_27314_27328(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.StateEvent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 27314, 27328);
return return_v;
}


int
f_1572_27207_27334(System.Management.Automation.PSTraceSource
this_param,string
format,System.Management.Automation.RemoteSessionState
arg1,System.Management.Automation.RemoteSessionEvent
arg2,System.Guid
arg3)
{
this_param.WriteLine( format, (object)arg1, (object)arg2, (object)arg3);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 27207, 27334);
return 0;
}


int
f_1572_27355_27373(System.EventHandler<System.Management.Automation.RemoteSessionStateMachineEventArgs>
this_param,System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
sender,System.Management.Automation.RemoteSessionStateMachineEventArgs
e)
{
this_param.Invoke( (object)sender, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 27355, 27373);
return 0;
}


System.Management.Automation.RemoteSessionState
f_1572_27493_27498()
{
var return_v = State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 27493, 27498);
return return_v;
}


System.Management.Automation.RemoteSessionEvent
f_1572_27500_27514(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.StateEvent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 27500, 27514);
return return_v;
}


int
f_1572_27394_27520(System.Management.Automation.PSTraceSource
this_param,string
format,System.Management.Automation.RemoteSessionState
arg1,System.Management.Automation.RemoteSessionEvent
arg2,System.Guid
arg3)
{
this_param.WriteLine( format, (object)arg1, (object)arg2, (object)arg3);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 27394, 27520);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1572,26801,27547);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,26801,27547);
}
		}

internal RemoteSessionState State
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1572,27856,27921);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,27892,27906);

return _state;
DynAbs.Tracing.TraceSender.TraceExitMethod(1572,27856,27921);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1572,27798,27932);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,27798,27932);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

        /// <summary>
        /// This event indicates that the FSM state changed.
        /// </summary>
        internal event EventHandler<RemoteSessionStateEventArgs> 
StateChanged
;

private void DoCreateSession(object sender, RemoteSessionStateMachineEventArgs arg)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1572,28757,29846);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,28865,29835);
using(f_1572_28872_28900(s_trace))            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,28934,29047);

f_1572_28934_29046(_state == RemoteSessionState.Idle, "State needs to be idle to start connection");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,29065,29278);

f_1572_29065_29277(_state != RemoteSessionState.ClosingConnection ||(DynAbs.Tracing.TraceSender.Expression_False(1572, 29076, 29189)||                           _state != RemoteSessionState.Closed), "Reconnect after connection is closing or closed is not allowed");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,29298,29820) || true) && (f_1572_29302_29307()== RemoteSessionState.Idle)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,29298,29820);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,29630,29756);

RemoteSessionStateMachineEventArgs 
sendingArg = f_1572_29678_29755(RemoteSessionEvent.NegotiationSending)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,29778,29801);

f_1572_29778_29800(this, sendingArg);
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,29298,29820);
}
DynAbs.Tracing.TraceSender.TraceExitUsing(1572,28865,29835);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1572,28757,29846);

System.IDisposable
f_1572_28872_28900(System.Management.Automation.PSTraceSource
this_param)
{
var return_v = this_param.TraceEventHandlers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 28872, 28900);
return return_v;
}


int
f_1572_28934_29046(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 28934, 29046);
return 0;
}


int
f_1572_29065_29277(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 29065, 29277);
return 0;
}


System.Management.Automation.RemoteSessionState
f_1572_29302_29307()
{
var return_v = State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 29302, 29307);
return return_v;
}


System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1572_29678_29755(System.Management.Automation.RemoteSessionEvent
stateEvent)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 29678, 29755);
return return_v;
}


int
f_1572_29778_29800(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 29778, 29800);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1572,28757,29846);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,28757,29846);
}
		}

private void DoConnectSession(object sender, RemoteSessionStateMachineEventArgs arg)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1572,30447,31282);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,30556,31271);
using(f_1572_30563_30591(s_trace))            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,30625,30738);

f_1572_30625_30737(_state == RemoteSessionState.Idle, "State needs to be idle to start connection");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,30758,31256) || true) && (f_1572_30762_30767()== RemoteSessionState.Idle)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,30758,31256);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,31057,31192);

RemoteSessionStateMachineEventArgs 
sendingArg = f_1572_31105_31191(RemoteSessionEvent.NegotiationSendingOnConnect)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,31214,31237);

f_1572_31214_31236(this, sendingArg);
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,30758,31256);
}
DynAbs.Tracing.TraceSender.TraceExitUsing(1572,30556,31271);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1572,30447,31282);

System.IDisposable
f_1572_30563_30591(System.Management.Automation.PSTraceSource
this_param)
{
var return_v = this_param.TraceEventHandlers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 30563, 30591);
return return_v;
}


int
f_1572_30625_30737(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 30625, 30737);
return 0;
}


System.Management.Automation.RemoteSessionState
f_1572_30762_30767()
{
var return_v = State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 30762, 30767);
return return_v;
}


System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1572_31105_31191(System.Management.Automation.RemoteSessionEvent
stateEvent)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 31105, 31191);
return return_v;
}


int
f_1572_31214_31236(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 31214, 31236);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1572,30447,31282);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,30447,31282);
}
		}

private void DoNegotiationSending(object sender, RemoteSessionStateMachineEventArgs arg)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1572,31833,32446);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,31946,32435) || true) && (f_1572_31950_31964(arg)== RemoteSessionEvent.NegotiationSending)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,31946,32435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,32039,32093);

f_1572_32039_32092(this, RemoteSessionState.NegotiationSending, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,31946,32435);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,31946,32435);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,32127,32435) || true) && (f_1572_32131_32145(arg)== RemoteSessionEvent.NegotiationSendingOnConnect)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,32127,32435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,32229,32292);

f_1572_32229_32291(this, RemoteSessionState.NegotiationSendingOnConnect, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,32127,32435);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,32127,32435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,32358,32420);

f_1572_32358_32419(false, "NegotiationSending called on wrong event");
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,32127,32435);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,31946,32435);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1572,31833,32446);

System.Management.Automation.RemoteSessionEvent
f_1572_31950_31964(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.StateEvent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 31950, 31964);
return return_v;
}


int
f_1572_32039_32092(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionState
newState,System.Exception
reason)
{
this_param.SetState( newState, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 32039, 32092);
return 0;
}


System.Management.Automation.RemoteSessionEvent
f_1572_32131_32145(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.StateEvent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 32131, 32145);
return return_v;
}


int
f_1572_32229_32291(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionState
newState,System.Exception
reason)
{
this_param.SetState( newState, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 32229, 32291);
return 0;
}


int
f_1572_32358_32419(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 32358, 32419);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1572,31833,32446);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,31833,32446);
}
		}

private void DoDisconnectDuringKeyExchange(object sender, RemoteSessionStateMachineEventArgs arg)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1572,32458,32682);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,32645,32671);

_pendingDisconnect = true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1572,32458,32682);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1572,32458,32682);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,32458,32682);
}
		}

private void DoDisconnect(object sender, RemoteSessionStateMachineEventArgs arg)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1572,32694,32859);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,32799,32848);

f_1572_32799_32847(this, RemoteSessionState.Disconnecting, null);
DynAbs.Tracing.TraceSender.TraceExitMethod(1572,32694,32859);

int
f_1572_32799_32847(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionState
newState,System.Exception
reason)
{
this_param.SetState( newState, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 32799, 32847);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1572,32694,32859);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,32694,32859);
}
		}

private void DoReconnect(object sender, RemoteSessionStateMachineEventArgs arg)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1572,32871,33034);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,32975,33023);

f_1572_32975_33022(this, RemoteSessionState.Reconnecting, null);
DynAbs.Tracing.TraceSender.TraceExitMethod(1572,32871,33034);

int
f_1572_32975_33022(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionState
newState,System.Exception
reason)
{
this_param.SetState( newState, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 32975, 33022);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1572,32871,33034);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,32871,33034);
}
		}

private void DoRCDisconnectStarted(object sender, RemoteSessionStateMachineEventArgs arg)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1572,33046,33377);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,33160,33366) || true) && (f_1572_33164_33169()!= RemoteSessionState.Disconnecting &&(DynAbs.Tracing.TraceSender.Expression_True(1572, 33164, 33266)&&f_1572_33226_33231()!= RemoteSessionState.Disconnected))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,33160,33366);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,33300,33351);

f_1572_33300_33350(this, RemoteSessionState.RCDisconnecting, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,33160,33366);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1572,33046,33377);

System.Management.Automation.RemoteSessionState
f_1572_33164_33169()
{
var return_v = State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 33164, 33169);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1572_33226_33231()
{
var return_v = State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 33226, 33231);
return return_v;
}


int
f_1572_33300_33350(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionState
newState,System.Exception
reason)
{
this_param.SetState( newState, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 33300, 33350);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1572,33046,33377);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,33046,33377);
}
		}

private void DoClose(object sender, RemoteSessionStateMachineEventArgs arg)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1572,33936,35819);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,34036,35808);
using(f_1572_34043_34071(s_trace))            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,34105,34142);

RemoteSessionState 
oldState = _state
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,34162,35762);

switch (oldState)
                {

case RemoteSessionState.ClosingConnection:
                    case RemoteSessionState.Closed:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,34162,35762);
DynAbs.Tracing.TraceSender.TraceBreak(1572,34380,34386);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,34162,35762);

case RemoteSessionState.Connecting:
                    case RemoteSessionState.Connected:
                    case RemoteSessionState.Established:
                    case RemoteSessionState.EstablishedAndKeyReceived:  // TODO - Client session would never get into this state... to be removed
                    case RemoteSessionState.EstablishedAndKeySent:
                    case RemoteSessionState.NegotiationReceived:
                    case RemoteSessionState.NegotiationSent:
                    case RemoteSessionState.NegotiationSending:
                    case RemoteSessionState.Disconnected:
                    case RemoteSessionState.Disconnecting:
                    case RemoteSessionState.Reconnecting:
                    case RemoteSessionState.RCDisconnecting:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,34162,35762);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,35233,35292);

f_1572_35233_35291(this, RemoteSessionState.ClosingConnection, f_1572_35280_35290(arg));
DynAbs.Tracing.TraceSender.TraceBreak(1572,35318,35324);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,34162,35762);

case RemoteSessionState.Idle:
                    case RemoteSessionState.UndefinedState:
                    default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,34162,35762);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,35494,35627);

PSRemotingTransportException 
forceClosedException = f_1572_35546_35626(f_1572_35579_35589(arg), f_1572_35591_35625())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,35653,35711);

f_1572_35653_35710(this, RemoteSessionState.Closed, forceClosedException);
DynAbs.Tracing.TraceSender.TraceBreak(1572,35737,35743);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,34162,35762);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,35782,35793);

f_1572_35782_35792(this);
DynAbs.Tracing.TraceSender.TraceExitUsing(1572,34036,35808);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1572,33936,35819);

System.IDisposable
f_1572_34043_34071(System.Management.Automation.PSTraceSource
this_param)
{
var return_v = this_param.TraceEventHandlers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 34043, 34071);
return return_v;
}


System.Exception
f_1572_35280_35290(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 35280, 35290);
return return_v;
}


int
f_1572_35233_35291(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionState
newState,System.Exception
reason)
{
this_param.SetState( newState, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 35233, 35291);
return 0;
}


System.Exception
f_1572_35579_35589(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 35579, 35589);
return return_v;
}


string
f_1572_35591_35625()
{
var return_v = RemotingErrorIdStrings.ForceClosed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 35591, 35625);
return return_v;
}


System.Management.Automation.Remoting.PSRemotingTransportException
f_1572_35546_35626(System.Exception
innerException,string
resourceString,params object[]
args)
{
var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException( innerException, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 35546, 35626);
return return_v;
}


int
f_1572_35653_35710(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionState
newState,System.Management.Automation.Remoting.PSRemotingTransportException
reason)
{
this_param.SetState( newState, (System.Exception)reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 35653, 35710);
return 0;
}


int
f_1572_35782_35792(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param)
{
this_param.CleanAll();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 35782, 35792);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1572,33936,35819);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,33936,35819);
}
		}

private void DoFatal(object sender, RemoteSessionStateMachineEventArgs eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1572,36264,36743);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,36370,36535);

PSRemotingDataStructureException 
fatalError =
f_1572_36433_36534(f_1572_36470_36486(eventArgs), f_1572_36488_36533())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,36551,36693);

RemoteSessionStateMachineEventArgs 
closeEvent =
f_1572_36616_36692(RemoteSessionEvent.Close, fatalError)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,36709,36732);

f_1572_36709_36731(this, closeEvent);
DynAbs.Tracing.TraceSender.TraceExitMethod(1572,36264,36743);

System.Exception
f_1572_36470_36486(System.Management.Automation.RemoteSessionStateMachineEventArgs
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 36470, 36486);
return return_v;
}


string
f_1572_36488_36533()
{
var return_v = RemotingErrorIdStrings.FatalErrorCausingClose;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1572, 36488, 36533);
return return_v;
}


System.Management.Automation.Remoting.PSRemotingDataStructureException
f_1572_36433_36534(System.Exception
innerException,string
resourceString,params object[]
args)
{
var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException( innerException, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 36433, 36534);
return return_v;
}


System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1572_36616_36692(System.Management.Automation.RemoteSessionEvent
stateEvent,System.Management.Automation.Remoting.PSRemotingDataStructureException
reason)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent, (System.Exception)reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 36616, 36692);
return return_v;
}


int
f_1572_36709_36731(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 36709, 36731);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1572,36264,36743);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,36264,36743);
}
		}

private void CleanAll()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1572,36792,36837);
DynAbs.Tracing.TraceSender.TraceExitMethod(1572,36792,36837);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1572,36792,36837);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,36792,36837);
}
		}

private void SetState(RemoteSessionState newState, Exception reason)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1572,37249,37911);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,37342,37379);

RemoteSessionState 
oldState = _state
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,37395,37900) || true) && (newState != oldState)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1572,37395,37900);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,37453,37471);

_state = newState;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,37489,37588);

f_1572_37489_37587(                s_trace, "state machine state transition: from state {0} to state {1}", oldState, _state);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,37608,37686);

RemoteSessionStateInfo 
stateInfo = f_1572_37643_37685(_state, reason)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,37704,37798);

RemoteSessionStateEventArgs 
sessionStateEventArg = f_1572_37755_37797(stateInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,37818,37885);

f_1572_37818_37884(
                _clientRemoteSessionStateChangeQueue, sessionStateEventArg);
DynAbs.Tracing.TraceSender.TraceExitCondition(1572,37395,37900);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1572,37249,37911);

int
f_1572_37489_37587(System.Management.Automation.PSTraceSource
this_param,string
format,System.Management.Automation.RemoteSessionState
arg1,System.Management.Automation.RemoteSessionState
arg2)
{
this_param.WriteLine( format, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 37489, 37587);
return 0;
}


System.Management.Automation.RemoteSessionStateInfo
f_1572_37643_37685(System.Management.Automation.RemoteSessionState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.RemoteSessionStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 37643, 37685);
return return_v;
}


System.Management.Automation.RemoteSessionStateEventArgs
f_1572_37755_37797(System.Management.Automation.RemoteSessionStateInfo
remoteSessionStateInfo)
{
var return_v = new System.Management.Automation.RemoteSessionStateEventArgs( remoteSessionStateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 37755, 37797);
return return_v;
}


int
f_1572_37818_37884(System.Collections.Generic.Queue<System.Management.Automation.RemoteSessionStateEventArgs>
this_param,System.Management.Automation.RemoteSessionStateEventArgs
item)
{
this_param.Enqueue( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 37818, 37884);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1572,37249,37911);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,37249,37911);
}
		}

static ClientRemoteSessionDSHandlerStateMachine()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1572,1636,37918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1572,1801,1866);
s_trace = f_1572_1811_1866("CRSessionFSM", "CRSessionFSM");DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1572,1636,37918);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1572,1636,37918);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1572,1636,37918);

static System.Management.Automation.PSTraceSource
f_1572_1811_1866(string
name,string
description)
{
var return_v = PSTraceSource.GetTracer( name, description);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 1811, 1866);
return return_v;
}


System.Collections.Generic.Queue<System.Management.Automation.RemoteSessionStateMachineEventArgs>
f_1572_2456_2503()
{
var return_v = new System.Collections.Generic.Queue<System.Management.Automation.RemoteSessionStateMachineEventArgs>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 2456, 2503);
return return_v;
}


object
f_1572_2634_2646()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 2634, 2646);
return return_v;
}


System.Collections.Generic.Queue<System.Management.Automation.RemoteSessionStateEventArgs>
f_1572_17510_17550()
{
var return_v = new System.Collections.Generic.Queue<System.Management.Automation.RemoteSessionStateEventArgs>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 17510, 17550);
return return_v;
}


int
f_1572_17811_17843(System.EventHandler<System.Management.Automation.RemoteSessionStateMachineEventArgs>[,]
this_param,int
dimension)
{
var return_v = this_param.GetLength( dimension);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 17811, 17843);
return return_v;
}


int
f_1572_23027_23059(System.EventHandler<System.Management.Automation.RemoteSessionStateMachineEventArgs>[,]
this_param,int
dimension)
{
var return_v = this_param.GetLength( dimension);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 23027, 23059);
return return_v;
}


int
f_1572_23118_23150(System.EventHandler<System.Management.Automation.RemoteSessionStateMachineEventArgs>[,]
this_param,int
dimension)
{
var return_v = this_param.GetLength( dimension);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 23118, 23150);
return return_v;
}


int
f_1572_23524_23563(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionState
newState,System.Exception
reason)
{
this_param.SetState( newState, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1572, 23524, 23563);
return 0;
}

}
}
