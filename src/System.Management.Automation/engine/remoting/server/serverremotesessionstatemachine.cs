// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
    internal class ServerRemoteSessionDSHandlerStateMachine
    {
        [TraceSourceAttribute("ServerRemoteSessionDSHandlerStateMachine", "ServerRemoteSessionDSHandlerStateMachine")]
        private static PSTraceSource s_trace;

        private ServerRemoteSession _session;

        private object _syncObject;

        private Queue<RemoteSessionStateMachineEventArgs> _processPendingEventsQueue
        ;

        private bool _eventsInProcess;

        private EventHandler<RemoteSessionStateMachineEventArgs>[,] _stateMachineHandle;

        private RemoteSessionState _state;

        private Timer _keyExchangeTimer;

        internal ServerRemoteSessionDSHandlerStateMachine(ServerRemoteSession session)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1653, 3420, 8217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 2019, 2027);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 2053, 2064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 2125, 2214);
                this._processPendingEventsQueue = f_1653_2167_2214();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 2563, 2587);
                this._eventsInProcess = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 2660, 2679);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 2717, 2723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 2839, 2856);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 3523, 3647) || true) && (session == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 3523, 3647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 3576, 3632);

                    throw f_1653_3582_3631("session");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 3523, 3647);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 3663, 3682);

                _session = session;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 3696, 3723);

                _syncObject = f_1653_3710_3722();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 3739, 3882);

                _stateMachineHandle = new EventHandler<RemoteSessionStateMachineEventArgs>[(int)RemoteSessionState.MaxState, (int)RemoteSessionEvent.MaxEvent];
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 3907, 3912);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 3898, 4761) || true) && (i < f_1653_3918_3950(_stateMachineHandle, 0))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 3952, 3955)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 3898, 4761))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 3898, 4761);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 3989, 4064);

                        _stateMachineHandle[i, (int)RemoteSessionEvent.FatalError] += DoFatalError;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 4084, 4149);

                        _stateMachineHandle[i, (int)RemoteSessionEvent.Close] += DoClose;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 4167, 4244);

                        _stateMachineHandle[i, (int)RemoteSessionEvent.CloseFailed] += DoCloseFailed;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 4262, 4345);

                        _stateMachineHandle[i, (int)RemoteSessionEvent.CloseCompleted] += DoCloseCompleted;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 4365, 4456);

                        _stateMachineHandle[i, (int)RemoteSessionEvent.NegotiationTimeout] += DoNegotiationTimeout;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 4476, 4551);

                        _stateMachineHandle[i, (int)RemoteSessionEvent.SendFailed] += DoSendFailed;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 4571, 4652);

                        _stateMachineHandle[i, (int)RemoteSessionEvent.ReceiveFailed] += DoReceiveFailed;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 4670, 4746);

                        _stateMachineHandle[i, (int)RemoteSessionEvent.ConnectSession] += DoConnect;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1653, 1, 864);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1653, 1, 864);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 4777, 4885);

                _stateMachineHandle[(int)RemoteSessionState.Idle, (int)RemoteSessionEvent.CreateSession] += DoCreateSession;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 4901, 5035);

                _stateMachineHandle[(int)RemoteSessionState.NegotiationPending, (int)RemoteSessionEvent.NegotiationReceived] += DoNegotiationReceived;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 5051, 5184);

                _stateMachineHandle[(int)RemoteSessionState.NegotiationReceived, (int)RemoteSessionEvent.NegotiationSending] += DoNegotiationSending;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 5200, 5340);

                _stateMachineHandle[(int)RemoteSessionState.NegotiationSending, (int)RemoteSessionEvent.NegotiationSendCompleted] += DoNegotiationCompleted;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 5356, 5480);

                _stateMachineHandle[(int)RemoteSessionState.NegotiationSent, (int)RemoteSessionEvent.NegotiationCompleted] += DoEstablished;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 5496, 5625);

                _stateMachineHandle[(int)RemoteSessionState.NegotiationSent, (int)RemoteSessionEvent.NegotiationPending] += DoNegotiationPending;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 5641, 5760);

                _stateMachineHandle[(int)RemoteSessionState.Established, (int)RemoteSessionEvent.MessageReceived] += DoMessageReceived;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 5776, 5907);

                _stateMachineHandle[(int)RemoteSessionState.NegotiationReceived, (int)RemoteSessionEvent.NegotiationFailed] += DoNegotiationFailed;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 5923, 6037);

                _stateMachineHandle[(int)RemoteSessionState.Connecting, (int)RemoteSessionEvent.ConnectFailed] += DoConnectFailed;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 6053, 6164);

                _stateMachineHandle[(int)RemoteSessionState.Established, (int)RemoteSessionEvent.KeyReceived] += DoKeyExchange;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 6181, 6293);

                _stateMachineHandle[(int)RemoteSessionState.Established, (int)RemoteSessionEvent.KeyRequested] += DoKeyExchange;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 6310, 6426);

                _stateMachineHandle[(int)RemoteSessionState.Established, (int)RemoteSessionEvent.KeyReceiveFailed] += DoKeyExchange;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 6443, 6569);

                _stateMachineHandle[(int)RemoteSessionState.EstablishedAndKeyRequested, (int)RemoteSessionEvent.KeyReceived] += DoKeyExchange;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 6586, 6708);

                _stateMachineHandle[(int)RemoteSessionState.EstablishedAndKeyRequested, (int)RemoteSessionEvent.KeySent] += DoKeyExchange;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 6725, 6856);

                _stateMachineHandle[(int)RemoteSessionState.EstablishedAndKeyRequested, (int)RemoteSessionEvent.KeyReceiveFailed] += DoKeyExchange;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 6873, 7000);

                _stateMachineHandle[(int)RemoteSessionState.EstablishedAndKeyReceived, (int)RemoteSessionEvent.KeySendFailed] += DoKeyExchange;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 7014, 7135);

                _stateMachineHandle[(int)RemoteSessionState.EstablishedAndKeyReceived, (int)RemoteSessionEvent.KeySent] += DoKeyExchange;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 7297, 7423);

                _stateMachineHandle[(int)RemoteSessionState.EstablishedAndKeyExchanged, (int)RemoteSessionEvent.KeyReceived] += DoKeyExchange;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 7440, 7567);

                _stateMachineHandle[(int)RemoteSessionState.EstablishedAndKeyExchanged, (int)RemoteSessionEvent.KeyRequested] += DoKeyExchange;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 7584, 7715);

                _stateMachineHandle[(int)RemoteSessionState.EstablishedAndKeyExchanged, (int)RemoteSessionEvent.KeyReceiveFailed] += DoKeyExchange;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 7743, 7748);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 7734, 8105) || true) && (i < f_1653_7754_7786(_stateMachineHandle, 0))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 7788, 7791)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 7734, 8105))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 7734, 8105);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 7834, 7839);
                            for (int
            j = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 7825, 8090) || true) && (j < f_1653_7845_7877(_stateMachineHandle, 1))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 7879, 7882)
            , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 7825, 8090))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 7825, 8090);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 7924, 8071) || true) && (_stateMachineHandle[i, j] == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 7924, 8071);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 8011, 8048);

                                    _stateMachineHandle[i, j] += DoClose;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 7924, 8071);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1653, 1, 266);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1653, 1, 266);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1653, 1, 372);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1653, 1, 372);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 8166, 8206);

                f_1653_8166_8205(this, RemoteSessionState.Idle, null);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1653, 3420, 8217);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 3420, 8217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 3420, 8217);
            }
        }

        internal RemoteSessionState State
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 8561, 8626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 8597, 8611);

                    return _state;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 8561, 8626);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 8503, 8637);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 8503, 8637);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool CanByPassRaiseEvent(RemoteSessionStateMachineEventArgs arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 9011, 9671);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 9109, 9631) || true) && (f_1653_9113_9127(arg) == RemoteSessionEvent.MessageReceived)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 9109, 9631);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 9199, 9616) || true) && (_state == RemoteSessionState.Established || (DynAbs.Tracing.TraceSender.Expression_False(1653, 9203, 9318) || _state == RemoteSessionState.EstablishedAndKeySent) || (DynAbs.Tracing.TraceSender.Expression_False(1653, 9203, 9463) || _state == RemoteSessionState.EstablishedAndKeyReceived) || (DynAbs.Tracing.TraceSender.Expression_False(1653, 9203, 9543) || _state == RemoteSessionState.EstablishedAndKeyExchanged))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 9199, 9616);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 9585, 9597);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 9199, 9616);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 9109, 9631);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 9647, 9660);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 9011, 9671);

                System.Management.Automation.RemoteSessionEvent
                f_1653_9113_9127(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 9113, 9127);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 9011, 9671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 9011, 9671);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void RaiseEvent(RemoteSessionStateMachineEventArgs fsmEventArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 10187, 10924);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 10354, 10365);
                // make sure only one thread is processing events.
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 10399, 10465);

                    f_1653_10399_10464(s_trace, "Event received : {0}", f_1653_10441_10463(fsmEventArg));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 10483, 10531);

                    f_1653_10483_10530(_processPendingEventsQueue, fsmEventArg);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 10551, 10639) || true) && (_eventsInProcess)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 10551, 10639);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 10613, 10620);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 10551, 10639);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 10659, 10683);

                    _eventsInProcess = true;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 10714, 10730);

                f_1653_10714_10729(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 10187, 10924);

                System.Management.Automation.RemoteSessionEvent
                f_1653_10441_10463(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 10441, 10463);
                    return return_v;
                }


                int
                f_1653_10399_10464(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Management.Automation.RemoteSessionEvent
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 10399, 10464);
                    return 0;
                }


                int
                f_1653_10483_10530(System.Collections.Generic.Queue<System.Management.Automation.RemoteSessionStateMachineEventArgs>
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 10483, 10530);
                    return 0;
                }


                int
                f_1653_10714_10729(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param)
                {
                    this_param.ProcessEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 10714, 10729);
                    return 0;
                }


                // currently server state machine doesn't raise events
                // this will allow server state machine to raise events.
                // RaiseStateMachineEvents();
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 10187, 10924);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 10187, 10924);
            }
        }

        private void ProcessEvents()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 11271, 11850);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 11324, 11376);

                RemoteSessionStateMachineEventArgs
                eventArgs = null
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 11392, 11839);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 11433, 11444);
                            lock (_syncObject)
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 11486, 11657) || true) && (f_1653_11490_11522(_processPendingEventsQueue) == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 11486, 11657);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 11577, 11602);

                                    _eventsInProcess = false;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1653, 11628, 11634);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 11486, 11657);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 11681, 11730);

                                eventArgs = f_1653_11693_11729(_processPendingEventsQueue);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 11769, 11798);

                            f_1653_11769_11797(this, eventArgs);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 11392, 11839);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 11392, 11839) || true) && (_eventsInProcess)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1653, 11392, 11839);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1653, 11392, 11839);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 11271, 11850);

                int
                f_1653_11490_11522(System.Collections.Generic.Queue<System.Management.Automation.RemoteSessionStateMachineEventArgs>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 11490, 11522);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1653_11693_11729(System.Collections.Generic.Queue<System.Management.Automation.RemoteSessionStateMachineEventArgs>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 11693, 11729);
                    return return_v;
                }


                int
                f_1653_11769_11797(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEventPrivate(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 11769, 11797);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 11271, 11850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 11271, 11850);
            }
        }

        private void RaiseEventPrivate(RemoteSessionStateMachineEventArgs fsmEventArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 12409, 13184);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 12512, 12644) || true) && (fsmEventArg == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 12512, 12644);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 12569, 12629);

                    throw f_1653_12575_12628("fsmEventArg");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 12512, 12644);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 12660, 12781);

                EventHandler<RemoteSessionStateMachineEventArgs>
                handler = _stateMachineHandle[(int)_state, (int)f_1653_12757_12779(fsmEventArg)]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 12795, 13173) || true) && (handler != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 12795, 13173);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 12848, 12970);

                    f_1653_12848_12969(s_trace, "Before calling state machine event handler: state = {0}, event = {1}", _state, f_1653_12946_12968(fsmEventArg));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 12990, 13017);

                    f_1653_12990_13016(handler, this, fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 13037, 13158);

                    f_1653_13037_13157(
                                    s_trace, "After calling state machine event handler: state = {0}, event = {1}", _state, f_1653_13134_13156(fsmEventArg));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 12795, 13173);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 12409, 13184);

                System.Management.Automation.PSArgumentNullException
                f_1653_12575_12628(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 12575, 12628);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionEvent
                f_1653_12757_12779(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 12757, 12779);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionEvent
                f_1653_12946_12968(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 12946, 12968);
                    return return_v;
                }


                int
                f_1653_12848_12969(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Management.Automation.RemoteSessionState
                arg1, System.Management.Automation.RemoteSessionEvent
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 12848, 12969);
                    return 0;
                }


                int
                f_1653_12990_13016(System.EventHandler<System.Management.Automation.RemoteSessionStateMachineEventArgs>
                this_param, System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                sender, System.Management.Automation.RemoteSessionStateMachineEventArgs
                e)
                {
                    this_param.Invoke((object)sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 12990, 13016);
                    return 0;
                }


                System.Management.Automation.RemoteSessionEvent
                f_1653_13134_13156(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 13134, 13156);
                    return return_v;
                }


                int
                f_1653_13037_13157(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Management.Automation.RemoteSessionState
                arg1, System.Management.Automation.RemoteSessionEvent
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 13037, 13157);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 12409, 13184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 12409, 13184);
            }
        }

        private void DoCreateSession(object sender, RemoteSessionStateMachineEventArgs fsmEventArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 13824, 14487);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 13940, 14476);
                using (f_1653_13947_13975(s_trace))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 14009, 14153) || true) && (fsmEventArg == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 14009, 14153);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 14074, 14134);

                        throw f_1653_14080_14133("fsmEventArg");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 14009, 14153);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 14173, 14280);

                    f_1653_14173_14279(f_1653_14184_14206(fsmEventArg) == RemoteSessionEvent.CreateSession, "StateEvent must be CreateSession");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 14298, 14399);

                    f_1653_14298_14398(_state == RemoteSessionState.Idle, "DoCreateSession cannot only be called in Idle state");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 14419, 14461);

                    f_1653_14419_14460(this, sender, fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1653, 13940, 14476);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 13824, 14487);

                System.IDisposable
                f_1653_13947_13975(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.TraceEventHandlers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 13947, 13975);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1653_14080_14133(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 14080, 14133);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionEvent
                f_1653_14184_14206(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 14184, 14206);
                    return return_v;
                }


                int
                f_1653_14173_14279(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 14173, 14279);
                    return 0;
                }


                int
                f_1653_14298_14398(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 14298, 14398);
                    return 0;
                }


                int
                f_1653_14419_14460(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, object
                sender, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.DoNegotiationPending(sender, fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 14419, 14460);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 13824, 14487);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 13824, 14487);
            }
        }

        private void DoNegotiationPending(object sender, RemoteSessionStateMachineEventArgs fsmEventArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 15130, 15785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 15251, 15774);
                using (f_1653_15258_15286(s_trace))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 15320, 15464) || true) && (fsmEventArg == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 15320, 15464);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 15385, 15445);

                        throw f_1653_15391_15444("fsmEventArg");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 15320, 15464);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 15484, 15685);

                    f_1653_15484_15684((_state == RemoteSessionState.Idle) || (DynAbs.Tracing.TraceSender.Expression_False(1653, 15495, 15580) || (_state == RemoteSessionState.NegotiationSent)), "DoNegotiationPending can only occur when the state is Idle or NegotiationSent.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 15705, 15759);

                    f_1653_15705_15758(this, RemoteSessionState.NegotiationPending, null);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1653, 15251, 15774);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 15130, 15785);

                System.IDisposable
                f_1653_15258_15286(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.TraceEventHandlers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 15258, 15286);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1653_15391_15444(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 15391, 15444);
                    return return_v;
                }


                int
                f_1653_15484_15684(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 15484, 15684);
                    return 0;
                }


                int
                f_1653_15705_15758(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionState
                newState, System.Exception
                reason)
                {
                    this_param.SetState(newState, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 15705, 15758);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 15130, 15785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 15130, 15785);
            }
        }

        private void DoNegotiationReceived(object sender, RemoteSessionStateMachineEventArgs fsmEventArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 16517, 17722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 16639, 17711);
                using (f_1653_16646_16674(s_trace))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 16708, 16852) || true) && (fsmEventArg == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 16708, 16852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 16773, 16833);

                        throw f_1653_16779_16832("fsmEventArg");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 16708, 16852);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 16872, 16991);

                    f_1653_16872_16990(f_1653_16883_16905(fsmEventArg) == RemoteSessionEvent.NegotiationReceived, "StateEvent must be NegotiationReceived");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 17009, 17109);

                    f_1653_17009_17108(f_1653_17020_17055(fsmEventArg) != null, "RemoteSessioncapability must be non-null");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 17127, 17232);

                    f_1653_17127_17231(_state == RemoteSessionState.NegotiationPending, "state must be in NegotiationPending state");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 17252, 17437) || true) && (f_1653_17256_17278(fsmEventArg) != RemoteSessionEvent.NegotiationReceived)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 17252, 17437);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 17362, 17418);

                        throw f_1653_17368_17417("fsmEventArg");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 17252, 17437);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 17457, 17621) || true) && (f_1653_17461_17496(fsmEventArg) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 17457, 17621);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 17546, 17602);

                        throw f_1653_17552_17601("fsmEventArg");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 17457, 17621);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 17641, 17696);

                    f_1653_17641_17695(this, RemoteSessionState.NegotiationReceived, null);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1653, 16639, 17711);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 16517, 17722);

                System.IDisposable
                f_1653_16646_16674(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.TraceEventHandlers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 16646, 16674);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1653_16779_16832(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 16779, 16832);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionEvent
                f_1653_16883_16905(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 16883, 16905);
                    return return_v;
                }


                int
                f_1653_16872_16990(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 16872, 16990);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteSessionCapability
                f_1653_17020_17055(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.RemoteSessionCapability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 17020, 17055);
                    return return_v;
                }


                int
                f_1653_17009_17108(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 17009, 17108);
                    return 0;
                }


                int
                f_1653_17127_17231(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 17127, 17231);
                    return 0;
                }


                System.Management.Automation.RemoteSessionEvent
                f_1653_17256_17278(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 17256, 17278);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1653_17368_17417(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 17368, 17417);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionCapability
                f_1653_17461_17496(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.RemoteSessionCapability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 17461, 17496);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1653_17552_17601(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 17552, 17601);
                    return return_v;
                }


                int
                f_1653_17641_17695(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionState
                newState, System.Exception
                reason)
                {
                    this_param.SetState(newState, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 17641, 17695);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 16517, 17722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 16517, 17722);
            }
        }

        private void DoNegotiationSending(object sender, RemoteSessionStateMachineEventArgs fsmEventArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 18307, 18957);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 18428, 18560) || true) && (fsmEventArg == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 18428, 18560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 18485, 18545);

                    throw f_1653_18491_18544("fsmEventArg");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 18428, 18560);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 18576, 18688);

                f_1653_18576_18687(f_1653_18587_18609(fsmEventArg) == RemoteSessionEvent.NegotiationSending, "Event must be NegotiationSending");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 18702, 18800);

                f_1653_18702_18799(_state == RemoteSessionState.NegotiationReceived, "State must be NegotiationReceived");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 18816, 18870);

                f_1653_18816_18869(this, RemoteSessionState.NegotiationSending, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 18886, 18946);

                f_1653_18886_18945(f_1653_18886_18922(_session));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 18307, 18957);

                System.Management.Automation.PSArgumentNullException
                f_1653_18491_18544(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 18491, 18544);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionEvent
                f_1653_18587_18609(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 18587, 18609);
                    return return_v;
                }


                int
                f_1653_18576_18687(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 18576, 18687);
                    return 0;
                }


                int
                f_1653_18702_18799(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 18702, 18799);
                    return 0;
                }


                int
                f_1653_18816_18869(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionState
                newState, System.Exception
                reason)
                {
                    this_param.SetState(newState, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 18816, 18869);
                    return 0;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1653_18886_18922(System.Management.Automation.Remoting.ServerRemoteSession
                this_param)
                {
                    var return_v = this_param.SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 18886, 18922);
                    return return_v;
                }


                int
                f_1653_18886_18945(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param)
                {
                    this_param.SendNegotiationAsync();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 18886, 18945);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 18307, 18957);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 18307, 18957);
            }
        }

        private void DoNegotiationCompleted(object sender, RemoteSessionStateMachineEventArgs fsmEventArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 19452, 20148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 19575, 20137);
                using (f_1653_19582_19610(s_trace))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 19644, 19788) || true) && (fsmEventArg == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 19644, 19788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 19709, 19769);

                        throw f_1653_19715_19768("fsmEventArg");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 19644, 19788);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 19808, 19904);

                    f_1653_19808_19903(_state == RemoteSessionState.NegotiationSending, "State must be NegotiationSending");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 19922, 20051);

                    f_1653_19922_20050(f_1653_19933_19955(fsmEventArg) == RemoteSessionEvent.NegotiationSendCompleted, "StateEvent must be NegotiationSendCompleted");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 20071, 20122);

                    f_1653_20071_20121(this, RemoteSessionState.NegotiationSent, null);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1653, 19575, 20137);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 19452, 20148);

                System.IDisposable
                f_1653_19582_19610(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.TraceEventHandlers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 19582, 19610);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1653_19715_19768(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 19715, 19768);
                    return return_v;
                }


                int
                f_1653_19808_19903(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 19808, 19903);
                    return 0;
                }


                System.Management.Automation.RemoteSessionEvent
                f_1653_19933_19955(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 19933, 19955);
                    return return_v;
                }


                int
                f_1653_19922_20050(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 19922, 20050);
                    return 0;
                }


                int
                f_1653_20071_20121(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionState
                newState, System.Exception
                reason)
                {
                    this_param.SetState(newState, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 20071, 20121);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 19452, 20148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 19452, 20148);
            }
        }

        private void DoEstablished(object sender, RemoteSessionStateMachineEventArgs fsmEventArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 20683, 21742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 20797, 21731);
                using (f_1653_20804_20832(s_trace))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 20866, 21010) || true) && (fsmEventArg == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 20866, 21010);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 20931, 20991);

                        throw f_1653_20937_20990("fsmEventArg");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 20866, 21010);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 21030, 21124);

                    f_1653_21030_21123(_state == RemoteSessionState.NegotiationSent, "State must be NegotiationReceived");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 21142, 21263);

                    f_1653_21142_21262(f_1653_21153_21175(fsmEventArg) == RemoteSessionEvent.NegotiationCompleted, "StateEvent must be NegotiationCompleted");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 21283, 21469) || true) && (f_1653_21287_21309(fsmEventArg) != RemoteSessionEvent.NegotiationCompleted)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 21283, 21469);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 21394, 21450);

                        throw f_1653_21400_21449("fsmEventArg");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 21283, 21469);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 21489, 21649) || true) && (_state != RemoteSessionState.NegotiationSent)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 21489, 21649);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 21579, 21630);

                        throw f_1653_21585_21629();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 21489, 21649);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 21669, 21716);

                    f_1653_21669_21715(this, RemoteSessionState.Established, null);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1653, 20797, 21731);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 20683, 21742);

                System.IDisposable
                f_1653_20804_20832(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.TraceEventHandlers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 20804, 20832);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1653_20937_20990(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 20937, 20990);
                    return return_v;
                }


                int
                f_1653_21030_21123(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 21030, 21123);
                    return 0;
                }


                System.Management.Automation.RemoteSessionEvent
                f_1653_21153_21175(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 21153, 21175);
                    return return_v;
                }


                int
                f_1653_21142_21262(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 21142, 21262);
                    return 0;
                }


                System.Management.Automation.RemoteSessionEvent
                f_1653_21287_21309(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 21287, 21309);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1653_21400_21449(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 21400, 21449);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1653_21585_21629()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 21585, 21629);
                    return return_v;
                }


                int
                f_1653_21669_21715(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionState
                newState, System.Exception
                reason)
                {
                    this_param.SetState(newState, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 21669, 21715);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 20683, 21742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 20683, 21742);
            }
        }

        internal void DoMessageReceived(object sender, RemoteSessionStateMachineEventArgs fsmEventArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 22413, 27113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 22532, 27102);
                using (f_1653_22539_22567(s_trace))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 22601, 22745) || true) && (fsmEventArg == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 22601, 22745);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 22666, 22726);

                        throw f_1653_22672_22725("fsmEventArg");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 22601, 22745);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 22765, 22916) || true) && (f_1653_22769_22791(fsmEventArg) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 22765, 22916);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 22841, 22897);

                        throw f_1653_22847_22896("fsmEventArg");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 22765, 22916);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 22936, 23452);

                    f_1653_22936_23451(_state == RemoteSessionState.Established || (DynAbs.Tracing.TraceSender.Expression_False(1653, 22947, 23074) || _state == RemoteSessionState.EstablishedAndKeyExchanged) || (DynAbs.Tracing.TraceSender.Expression_False(1653, 22947, 23160) || _state == RemoteSessionState.EstablishedAndKeyReceived) || (DynAbs.Tracing.TraceSender.Expression_False(1653, 22947, 23242) || _state == RemoteSessionState.EstablishedAndKeySent), "State must be Established or EstablishedAndKeySent or EstablishedAndKeyReceived or EstablishedAndKeyExchanged");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 23472, 23553);

                    RemotingTargetInterface
                    targetInterface = f_1653_23514_23552(f_1653_23514_23536(fsmEventArg))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 23571, 23631);

                    RemotingDataType
                    dataType = f_1653_23599_23630(f_1653_23599_23621(fsmEventArg))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 23651, 23677);

                    Guid
                    clientRunspacePoolId
                    = default(Guid);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 23695, 23739);

                    ServerRunspacePoolDriver
                    runspacePoolDriver
                    = default(ServerRunspacePoolDriver);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 23807, 23858);

                    RemoteDataEventArgs
                    remoteDataForSessionArg = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 23878, 27087);

                    switch (targetInterface)
                    {

                        case RemotingTargetInterface.Session:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 23878, 27087);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 24037, 24685);

                                switch (dataType)
                                {

                                    case RemotingDataType.CreateRunspacePool:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 24037, 24685);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 24242, 24316);

                                        remoteDataForSessionArg = f_1653_24268_24315(f_1653_24292_24314(fsmEventArg));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 24354, 24439);

                                        f_1653_24354_24438(f_1653_24354_24390(_session), remoteDataForSessionArg);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1653, 24477, 24483);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 24037, 24685);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 24037, 24685);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 24565, 24610);

                                        f_1653_24565_24609(false, "Should never reach here");
                                        DynAbs.Tracing.TraceSender.TraceBreak(1653, 24648, 24654);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 24037, 24685);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1653, 24740, 24746);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 23878, 27087);

                        case RemotingTargetInterface.RunspacePool:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 23878, 27087);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 24874, 24935);

                            clientRunspacePoolId = f_1653_24897_24934(f_1653_24897_24919(fsmEventArg));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 24961, 25035);

                            runspacePoolDriver = f_1653_24982_25034(_session, clientRunspacePoolId);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 25063, 26025) || true) && (runspacePoolDriver != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 25063, 26025);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 25151, 25235);

                                f_1653_25151_25234(f_1653_25151_25190(runspacePoolDriver), f_1653_25211_25233(fsmEventArg));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 25063, 26025);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 25063, 26025);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 25349, 25504);

                                f_1653_25349_25503(s_trace, @"Server received data for Runspace (id: {0}),
                                but the Runspace cannot be found", clientRunspacePoolId);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 25536, 25762);

                                PSRemotingDataStructureException
                                reasonOfFailure = f_1653_25587_25761(f_1653_25657_25701(), clientRunspacePoolId)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 25792, 25936);

                                RemoteSessionStateMachineEventArgs
                                runspaceNotFoundArg = f_1653_25849_25935(RemoteSessionEvent.FatalError, reasonOfFailure)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 25966, 25998);

                                f_1653_25966_25997(this, runspaceNotFoundArg);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 25063, 26025);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1653, 26053, 26059);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 23878, 27087);

                        case RemotingTargetInterface.PowerShell:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 23878, 27087);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 26149, 26210);

                            clientRunspacePoolId = f_1653_26172_26209(f_1653_26172_26194(fsmEventArg));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 26236, 26310);

                            runspacePoolDriver = f_1653_26257_26309(_session, clientRunspacePoolId);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 26338, 26430);

                            f_1653_26338_26429(f_1653_26338_26377(runspacePoolDriver), f_1653_26406_26428(fsmEventArg));
                            DynAbs.Tracing.TraceSender.TraceBreak(1653, 26456, 26462);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 23878, 27087);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 23878, 27087);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 26520, 26608);

                            f_1653_26520_26607(s_trace, "Server received data unknown targetInterface: {0}", targetInterface);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 26636, 26813);

                            PSRemotingDataStructureException
                            reasonOfFailure2 = f_1653_26688_26812(f_1653_26725_26794(), targetInterface)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 26839, 26981);

                            RemoteSessionStateMachineEventArgs
                            unknownTargetArg = f_1653_26893_26980(RemoteSessionEvent.FatalError, reasonOfFailure2)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 27007, 27036);

                            f_1653_27007_27035(this, unknownTargetArg);
                            DynAbs.Tracing.TraceSender.TraceBreak(1653, 27062, 27068);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 23878, 27087);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1653, 22532, 27102);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 22413, 27113);

                System.IDisposable
                f_1653_22539_22567(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.TraceEventHandlers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 22539, 22567);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1653_22672_22725(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 22672, 22725);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                f_1653_22769_22791(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.RemoteData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 22769, 22791);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1653_22847_22896(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 22847, 22896);
                    return return_v;
                }


                int
                f_1653_22936_23451(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 22936, 23451);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                f_1653_23514_23536(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.RemoteData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 23514, 23536);
                    return return_v;
                }


                System.Management.Automation.RemotingTargetInterface
                f_1653_23514_23552(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.TargetInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 23514, 23552);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                f_1653_23599_23621(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.RemoteData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 23599, 23621);
                    return return_v;
                }


                System.Management.Automation.RemotingDataType
                f_1653_23599_23630(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.DataType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 23599, 23630);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                f_1653_24292_24314(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.RemoteData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 24292, 24314);
                    return return_v;
                }


                System.Management.Automation.RemoteDataEventArgs
                f_1653_24268_24315(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                receivedData)
                {
                    var return_v = new System.Management.Automation.RemoteDataEventArgs(receivedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 24268, 24315);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1653_24354_24390(System.Management.Automation.Remoting.ServerRemoteSession
                this_param)
                {
                    var return_v = this_param.SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 24354, 24390);
                    return return_v;
                }


                int
                f_1653_24354_24438(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param, System.Management.Automation.RemoteDataEventArgs
                arg)
                {
                    this_param.RaiseDataReceivedEvent(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 24354, 24438);
                    return 0;
                }


                int
                f_1653_24565_24609(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 24565, 24609);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                f_1653_24897_24919(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.RemoteData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 24897, 24919);
                    return return_v;
                }


                System.Guid
                f_1653_24897_24934(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.RunspacePoolId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 24897, 24934);
                    return return_v;
                }


                System.Management.Automation.ServerRunspacePoolDriver
                f_1653_24982_25034(System.Management.Automation.Remoting.ServerRemoteSession
                this_param, System.Guid
                clientRunspacePoolId)
                {
                    var return_v = this_param.GetRunspacePoolDriver(clientRunspacePoolId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 24982, 25034);
                    return return_v;
                }


                System.Management.Automation.ServerRunspacePoolDataStructureHandler
                f_1653_25151_25190(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    var return_v = this_param.DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 25151, 25190);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                f_1653_25211_25233(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.RemoteData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 25211, 25233);
                    return return_v;
                }


                int
                f_1653_25151_25234(System.Management.Automation.ServerRunspacePoolDataStructureHandler
                this_param, System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                receivedData)
                {
                    this_param.ProcessReceivedData(receivedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 25151, 25234);
                    return 0;
                }


                int
                f_1653_25349_25503(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Guid
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 25349, 25503);
                    return 0;
                }


                string
                f_1653_25657_25701()
                {
                    var return_v = RemotingErrorIdStrings.RunspaceCannotBeFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 25657, 25701);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1653_25587_25761(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 25587, 25761);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1653_25849_25935(System.Management.Automation.RemoteSessionEvent
                stateEvent, System.Management.Automation.Remoting.PSRemotingDataStructureException
                reason)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent, (System.Exception)reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 25849, 25935);
                    return return_v;
                }


                int
                f_1653_25966_25997(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEvent(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 25966, 25997);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                f_1653_26172_26194(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.RemoteData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 26172, 26194);
                    return return_v;
                }


                System.Guid
                f_1653_26172_26209(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.RunspacePoolId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 26172, 26209);
                    return return_v;
                }


                System.Management.Automation.ServerRunspacePoolDriver
                f_1653_26257_26309(System.Management.Automation.Remoting.ServerRemoteSession
                this_param, System.Guid
                clientRunspacePoolId)
                {
                    var return_v = this_param.GetRunspacePoolDriver(clientRunspacePoolId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 26257, 26309);
                    return return_v;
                }


                System.Management.Automation.ServerRunspacePoolDataStructureHandler
                f_1653_26338_26377(System.Management.Automation.ServerRunspacePoolDriver
                this_param)
                {
                    var return_v = this_param.DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 26338, 26377);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                f_1653_26406_26428(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.RemoteData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 26406, 26428);
                    return return_v;
                }


                int
                f_1653_26338_26429(System.Management.Automation.ServerRunspacePoolDataStructureHandler
                this_param, System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                rcvdData)
                {
                    this_param.DispatchMessageToPowerShell(rcvdData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 26338, 26429);
                    return 0;
                }


                int
                f_1653_26520_26607(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Management.Automation.RemotingTargetInterface
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 26520, 26607);
                    return 0;
                }


                string
                f_1653_26725_26794()
                {
                    var return_v = RemotingErrorIdStrings.ReceivedUnsupportedRemotingTargetInterfaceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 26725, 26794);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1653_26688_26812(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 26688, 26812);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1653_26893_26980(System.Management.Automation.RemoteSessionEvent
                stateEvent, System.Management.Automation.Remoting.PSRemotingDataStructureException
                reason)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent, (System.Exception)reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 26893, 26980);
                    return return_v;
                }


                int
                f_1653_27007_27035(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEvent(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 27007, 27035);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 22413, 27113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 22413, 27113);
            }
        }

        private void DoConnectFailed(object sender, RemoteSessionStateMachineEventArgs fsmEventArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 27903, 28840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 28019, 28829);
                using (f_1653_28026_28054(s_trace))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 28088, 28232) || true) && (fsmEventArg == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 28088, 28232);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 28153, 28213);

                        throw f_1653_28159_28212("fsmEventArg");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 28088, 28232);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 28252, 28359);

                    f_1653_28252_28358(f_1653_28263_28285(fsmEventArg) == RemoteSessionEvent.ConnectFailed, "StateEvent must be ConnectFailed");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 28379, 28558) || true) && (f_1653_28383_28405(fsmEventArg) != RemoteSessionEvent.ConnectFailed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 28379, 28558);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 28483, 28539);

                        throw f_1653_28489_28538("fsmEventArg");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 28379, 28558);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 28578, 28666);

                    f_1653_28578_28665(_state == RemoteSessionState.Connecting, "session State must be Connecting");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 28763, 28814);

                    throw f_1653_28769_28813();
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1653, 28019, 28829);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 27903, 28840);

                System.IDisposable
                f_1653_28026_28054(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.TraceEventHandlers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 28026, 28054);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1653_28159_28212(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 28159, 28212);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionEvent
                f_1653_28263_28285(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 28263, 28285);
                    return return_v;
                }


                int
                f_1653_28252_28358(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 28252, 28358);
                    return 0;
                }


                System.Management.Automation.RemoteSessionEvent
                f_1653_28383_28405(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 28383, 28405);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1653_28489_28538(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 28489, 28538);
                    return return_v;
                }


                int
                f_1653_28578_28665(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 28578, 28665);
                    return 0;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1653_28769_28813()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 28769, 28813);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 27903, 28840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 27903, 28840);
            }
        }

        private void DoFatalError(object sender, RemoteSessionStateMachineEventArgs fsmEventArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 29516, 30232);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 29629, 30221);
                using (f_1653_29636_29664(s_trace))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 29698, 29842) || true) && (fsmEventArg == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 29698, 29842);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 29763, 29823);

                        throw f_1653_29769_29822("fsmEventArg");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 29698, 29842);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 29862, 29963);

                    f_1653_29862_29962(f_1653_29873_29895(fsmEventArg) == RemoteSessionEvent.FatalError, "StateEvent must be FatalError");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 29983, 30159) || true) && (f_1653_29987_30009(fsmEventArg) != RemoteSessionEvent.FatalError)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 29983, 30159);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 30084, 30140);

                        throw f_1653_30090_30139("fsmEventArg");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 29983, 30159);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 30179, 30206);

                    f_1653_30179_30205(this, this, fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1653, 29629, 30221);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 29516, 30232);

                System.IDisposable
                f_1653_29636_29664(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.TraceEventHandlers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 29636, 29664);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1653_29769_29822(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 29769, 29822);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionEvent
                f_1653_29873_29895(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 29873, 29895);
                    return return_v;
                }


                int
                f_1653_29862_29962(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 29862, 29962);
                    return 0;
                }


                System.Management.Automation.RemoteSessionEvent
                f_1653_29987_30009(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 29987, 30009);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1653_30090_30139(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 30090, 30139);
                    return return_v;
                }


                int
                f_1653_30179_30205(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                sender, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.DoClose((object)sender, fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 30179, 30205);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 29516, 30232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 29516, 30232);
            }
        }

        private void DoConnect(object sender, RemoteSessionStateMachineEventArgs fsmEventArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 30587, 31014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 30697, 30818);

                f_1653_30697_30817(_state != RemoteSessionState.Idle, "session should not be in idle state when SessionConnect event is queued");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 30832, 31003) || true) && ((_state != RemoteSessionState.Closed) && (DynAbs.Tracing.TraceSender.Expression_True(1653, 30836, 30925) && (_state != RemoteSessionState.ClosingConnection)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 30832, 31003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 30959, 30988);

                    f_1653_30959_30987(_session);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 30832, 31003);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 30587, 31014);

                int
                f_1653_30697_30817(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 30697, 30817);
                    return 0;
                }


                int
                f_1653_30959_30987(System.Management.Automation.Remoting.ServerRemoteSession
                this_param)
                {
                    this_param.HandlePostConnect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 30959, 30987);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 30587, 31014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 30587, 31014);
            }
        }

        private void DoClose(object sender, RemoteSessionStateMachineEventArgs fsmEventArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 31456, 33437);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 31564, 33426);
                using (f_1653_31571_31599(s_trace))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 31633, 31777) || true) && (fsmEventArg == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 31633, 31777);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 31698, 31758);

                        throw f_1653_31704_31757("fsmEventArg");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 31633, 31777);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 31797, 31834);

                    RemoteSessionState
                    oldState = _state
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 31854, 33380);

                    switch (oldState)
                    {

                        case RemoteSessionState.ClosingConnection:
                        case RemoteSessionState.Closed:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 31854, 33380);
                            DynAbs.Tracing.TraceSender.TraceBreak(1653, 32072, 32078);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 31854, 33380);

                        case RemoteSessionState.Connecting:
                        case RemoteSessionState.Connected:
                        case RemoteSessionState.Established:
                        case RemoteSessionState.EstablishedAndKeySent:  // server session will never be in this state.. TODO- remove this
                        case RemoteSessionState.EstablishedAndKeyReceived:
                        case RemoteSessionState.EstablishedAndKeyExchanged:
                        case RemoteSessionState.NegotiationReceived:
                        case RemoteSessionState.NegotiationSent:
                        case RemoteSessionState.NegotiationSending:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 31854, 33380);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 32750, 32817);

                            f_1653_32750_32816(this, RemoteSessionState.ClosingConnection, f_1653_32797_32815(fsmEventArg));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 32843, 32921);

                            f_1653_32843_32920(f_1653_32843_32879(_session), f_1653_32901_32919(fsmEventArg));
                            DynAbs.Tracing.TraceSender.TraceBreak(1653, 32947, 32953);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 31854, 33380);

                        case RemoteSessionState.Idle:
                        case RemoteSessionState.UndefinedState:
                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 31854, 33380);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 33123, 33245);

                            Exception
                            forcedCloseException = f_1653_33156_33244(f_1653_33189_33207(fsmEventArg), f_1653_33209_33243())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 33271, 33329);

                            f_1653_33271_33328(this, RemoteSessionState.Closed, forcedCloseException);
                            DynAbs.Tracing.TraceSender.TraceBreak(1653, 33355, 33361);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 31854, 33380);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 33400, 33411);

                    f_1653_33400_33410(this);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1653, 31564, 33426);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 31456, 33437);

                System.IDisposable
                f_1653_31571_31599(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.TraceEventHandlers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 31571, 31599);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1653_31704_31757(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 31704, 31757);
                    return return_v;
                }


                System.Exception
                f_1653_32797_32815(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 32797, 32815);
                    return return_v;
                }


                int
                f_1653_32750_32816(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionState
                newState, System.Exception
                reason)
                {
                    this_param.SetState(newState, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 32750, 32816);
                    return 0;
                }


                System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                f_1653_32843_32879(System.Management.Automation.Remoting.ServerRemoteSession
                this_param)
                {
                    var return_v = this_param.SessionDataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 32843, 32879);
                    return return_v;
                }


                System.Exception
                f_1653_32901_32919(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 32901, 32919);
                    return return_v;
                }


                int
                f_1653_32843_32920(System.Management.Automation.Remoting.ServerRemoteSessionDataStructureHandler
                this_param, System.Exception
                reasonForClose)
                {
                    this_param.CloseConnectionAsync(reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 32843, 32920);
                    return 0;
                }


                System.Exception
                f_1653_33189_33207(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 33189, 33207);
                    return return_v;
                }


                string
                f_1653_33209_33243()
                {
                    var return_v = RemotingErrorIdStrings.ForceClosed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 33209, 33243);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1653_33156_33244(System.Exception
                innerException, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(innerException, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 33156, 33244);
                    return return_v;
                }


                int
                f_1653_33271_33328(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionState
                newState, System.Exception
                reason)
                {
                    this_param.SetState(newState, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 33271, 33328);
                    return 0;
                }


                int
                f_1653_33400_33410(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param)
                {
                    this_param.CleanAll();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 33400, 33410);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 31456, 33437);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 31456, 33437);
            }
        }

        private void DoCloseFailed(object sender, RemoteSessionStateMachineEventArgs fsmEventArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 33916, 34596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 34030, 34585);
                using (f_1653_34037_34065(s_trace))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 34099, 34243) || true) && (fsmEventArg == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 34099, 34243);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 34164, 34224);

                        throw f_1653_34170_34223("fsmEventArg");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 34099, 34243);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 34263, 34366);

                    f_1653_34263_34365(f_1653_34274_34296(fsmEventArg) == RemoteSessionEvent.CloseFailed, "StateEvent must be CloseFailed");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 34386, 34436);

                    RemoteSessionState
                    stateBeforeTransition = _state
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 34456, 34512);

                    f_1653_34456_34511(this, RemoteSessionState.Closed, f_1653_34492_34510(fsmEventArg));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 34559, 34570);

                    f_1653_34559_34569(this);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1653, 34030, 34585);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 33916, 34596);

                System.IDisposable
                f_1653_34037_34065(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.TraceEventHandlers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 34037, 34065);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1653_34170_34223(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 34170, 34223);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionEvent
                f_1653_34274_34296(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 34274, 34296);
                    return return_v;
                }


                int
                f_1653_34263_34365(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 34263, 34365);
                    return 0;
                }


                System.Exception
                f_1653_34492_34510(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 34492, 34510);
                    return return_v;
                }


                int
                f_1653_34456_34511(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionState
                newState, System.Exception
                reason)
                {
                    this_param.SetState(newState, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 34456, 34511);
                    return 0;
                }


                int
                f_1653_34559_34569(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param)
                {
                    this_param.CleanAll();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 34559, 34569);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 33916, 34596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 33916, 34596);
            }
        }

        private void DoCloseCompleted(object sender, RemoteSessionStateMachineEventArgs fsmEventArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 35057, 35832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 35174, 35821);
                using (f_1653_35181_35209(s_trace))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 35243, 35387) || true) && (fsmEventArg == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 35243, 35387);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 35308, 35368);

                        throw f_1653_35314_35367("fsmEventArg");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 35243, 35387);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 35407, 35516);

                    f_1653_35407_35515(f_1653_35418_35440(fsmEventArg) == RemoteSessionEvent.CloseCompleted, "StateEvent must be CloseCompleted");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 35536, 35592);

                    f_1653_35536_35591(this, RemoteSessionState.Closed, f_1653_35572_35590(fsmEventArg));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 35749, 35777);

                    f_1653_35749_35776(                // Close the session only after changing the state..this way
                                                       // state machine will not process anything.
                                    _session, fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 35795, 35806);

                    f_1653_35795_35805(this);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1653, 35174, 35821);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 35057, 35832);

                System.IDisposable
                f_1653_35181_35209(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.TraceEventHandlers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 35181, 35209);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1653_35314_35367(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 35314, 35367);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionEvent
                f_1653_35418_35440(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 35418, 35440);
                    return return_v;
                }


                int
                f_1653_35407_35515(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 35407, 35515);
                    return 0;
                }


                System.Exception
                f_1653_35572_35590(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 35572, 35590);
                    return return_v;
                }


                int
                f_1653_35536_35591(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionState
                newState, System.Exception
                reason)
                {
                    this_param.SetState(newState, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 35536, 35591);
                    return 0;
                }


                int
                f_1653_35749_35776(System.Management.Automation.Remoting.ServerRemoteSession
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                reasonForClose)
                {
                    this_param.Close(reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 35749, 35776);
                    return 0;
                }


                int
                f_1653_35795_35805(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param)
                {
                    this_param.CleanAll();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 35795, 35805);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 35057, 35832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 35057, 35832);
            }
        }

        private void DoNegotiationFailed(object sender, RemoteSessionStateMachineEventArgs fsmEventArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 36339, 37012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 36459, 37001);
                using (f_1653_36466_36494(s_trace))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 36528, 36672) || true) && (fsmEventArg == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 36528, 36672);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 36593, 36653);

                        throw f_1653_36599_36652("fsmEventArg");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 36528, 36672);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 36692, 36807);

                    f_1653_36692_36806(f_1653_36703_36725(fsmEventArg) == RemoteSessionEvent.NegotiationFailed, "StateEvent must be NegotiationFailed");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 36827, 36938);

                    RemoteSessionStateMachineEventArgs
                    closeArg = f_1653_36873_36937(RemoteSessionEvent.Close)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 36958, 36986);

                    f_1653_36958_36985(this, closeArg);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1653, 36459, 37001);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 36339, 37012);

                System.IDisposable
                f_1653_36466_36494(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.TraceEventHandlers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 36466, 36494);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1653_36599_36652(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 36599, 36652);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionEvent
                f_1653_36703_36725(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 36703, 36725);
                    return return_v;
                }


                int
                f_1653_36692_36806(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 36692, 36806);
                    return 0;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1653_36873_36937(System.Management.Automation.RemoteSessionEvent
                stateEvent)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 36873, 36937);
                    return return_v;
                }


                int
                f_1653_36958_36985(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEventPrivate(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 36958, 36985);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 36339, 37012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 36339, 37012);
            }
        }

        private void DoNegotiationTimeout(object sender, RemoteSessionStateMachineEventArgs fsmEventArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 37605, 38444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 37726, 38433);
                using (f_1653_37733_37761(s_trace))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 37795, 37939) || true) && (fsmEventArg == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 37795, 37939);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 37860, 37920);

                        throw f_1653_37866_37919("fsmEventArg");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 37795, 37939);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 37959, 38076);

                    f_1653_37959_38075(f_1653_37970_37992(fsmEventArg) == RemoteSessionEvent.NegotiationTimeout, "StateEvent must be NegotiationTimeout");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 38096, 38239) || true) && (_state == RemoteSessionState.Established)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 38096, 38239);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 38213, 38220);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 38096, 38239);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 38259, 38370);

                    RemoteSessionStateMachineEventArgs
                    closeArg = f_1653_38305_38369(RemoteSessionEvent.Close)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 38390, 38418);

                    f_1653_38390_38417(this, closeArg);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1653, 37726, 38433);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 37605, 38444);

                System.IDisposable
                f_1653_37733_37761(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.TraceEventHandlers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 37733, 37761);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1653_37866_37919(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 37866, 37919);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionEvent
                f_1653_37970_37992(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 37970, 37992);
                    return return_v;
                }


                int
                f_1653_37959_38075(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 37959, 38075);
                    return 0;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1653_38305_38369(System.Management.Automation.RemoteSessionEvent
                stateEvent)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 38305, 38369);
                    return return_v;
                }


                int
                f_1653_38390_38417(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEventPrivate(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 38390, 38417);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 37605, 38444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 37605, 38444);
            }
        }

        private void DoSendFailed(object sender, RemoteSessionStateMachineEventArgs fsmEventArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 39021, 39673);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 39134, 39662);
                using (f_1653_39141_39169(s_trace))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 39203, 39347) || true) && (fsmEventArg == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 39203, 39347);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 39268, 39328);

                        throw f_1653_39274_39327("fsmEventArg");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 39203, 39347);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 39367, 39468);

                    f_1653_39367_39467(f_1653_39378_39400(fsmEventArg) == RemoteSessionEvent.SendFailed, "StateEvent must be SendFailed");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 39488, 39599);

                    RemoteSessionStateMachineEventArgs
                    closeArg = f_1653_39534_39598(RemoteSessionEvent.Close)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 39619, 39647);

                    f_1653_39619_39646(this, closeArg);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1653, 39134, 39662);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 39021, 39673);

                System.IDisposable
                f_1653_39141_39169(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.TraceEventHandlers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 39141, 39169);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1653_39274_39327(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 39274, 39327);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionEvent
                f_1653_39378_39400(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 39378, 39400);
                    return return_v;
                }


                int
                f_1653_39367_39467(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 39367, 39467);
                    return 0;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1653_39534_39598(System.Management.Automation.RemoteSessionEvent
                stateEvent)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 39534, 39598);
                    return return_v;
                }


                int
                f_1653_39619_39646(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEventPrivate(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 39619, 39646);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 39021, 39673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 39021, 39673);
            }
        }

        private void DoReceiveFailed(object sender, RemoteSessionStateMachineEventArgs fsmEventArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 40254, 40916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 40370, 40905);
                using (f_1653_40377_40405(s_trace))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 40439, 40583) || true) && (fsmEventArg == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 40439, 40583);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 40504, 40564);

                        throw f_1653_40510_40563("fsmEventArg");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 40439, 40583);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 40603, 40711);

                    f_1653_40603_40710(f_1653_40614_40636(fsmEventArg) == RemoteSessionEvent.ReceiveFailed, "StateEvent must be ReceivedFailed");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 40731, 40842);

                    RemoteSessionStateMachineEventArgs
                    closeArg = f_1653_40777_40841(RemoteSessionEvent.Close)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 40862, 40890);

                    f_1653_40862_40889(this, closeArg);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1653, 40370, 40905);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 40254, 40916);

                System.IDisposable
                f_1653_40377_40405(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.TraceEventHandlers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 40377, 40405);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1653_40510_40563(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 40510, 40563);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionEvent
                f_1653_40614_40636(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 40614, 40636);
                    return return_v;
                }


                int
                f_1653_40603_40710(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 40603, 40710);
                    return 0;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1653_40777_40841(System.Management.Automation.RemoteSessionEvent
                stateEvent)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 40777, 40841);
                    return return_v;
                }


                int
                f_1653_40862_40889(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEventPrivate(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 40862, 40889);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 40254, 40916);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 40254, 40916);
            }
        }

        private void DoKeyExchange(object sender, RemoteSessionStateMachineEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 41263, 44736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 41728, 41871);

                f_1653_41728_41870(_state >= RemoteSessionState.Established, "Key Receiving can only be raised after reaching the Established state");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 41887, 44725);

                switch (f_1653_41895_41915(eventArgs))
                {

                    case RemoteSessionEvent.KeyReceived:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 41887, 44725);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 42138, 42548) || true) && (_state == RemoteSessionState.EstablishedAndKeyRequested)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 42138, 42548);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 42303, 42365);

                                Timer
                                tmp = f_1653_42315_42364(ref _keyExchangeTimer, null)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 42395, 42521) || true) && (tmp != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 42395, 42521);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 42476, 42490);

                                    f_1653_42476_42489(tmp);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 42395, 42521);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 42138, 42548);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 42690, 42763);

                            f_1653_42690_42762(this, RemoteSessionState.EstablishedAndKeyReceived, f_1653_42745_42761(eventArgs));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 42875, 42910);

                            f_1653_42875_42909(
                                                    // you need to send an encrypted session key to the client
                                                    _session);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1653, 42957, 42963);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 41887, 44725);

                    case RemoteSessionEvent.KeySent:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 41887, 44725);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 43064, 43342) || true) && (_state == RemoteSessionState.EstablishedAndKeyReceived)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 43064, 43342);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 43241, 43315);

                                f_1653_43241_43314(this, RemoteSessionState.EstablishedAndKeyExchanged, f_1653_43297_43313(eventArgs));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 43064, 43342);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1653, 43389, 43395);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 41887, 44725);

                    case RemoteSessionEvent.KeyRequested:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 41887, 44725);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 43501, 44057) || true) && ((_state == RemoteSessionState.Established) || (DynAbs.Tracing.TraceSender.Expression_False(1653, 43505, 43608) || (_state == RemoteSessionState.EstablishedAndKeyExchanged)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 43501, 44057);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 43742, 43816);

                                f_1653_43742_43815(this, RemoteSessionState.EstablishedAndKeyRequested, f_1653_43798_43814(eventArgs));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 43896, 44030);

                                _keyExchangeTimer = f_1653_43916_44029(HandleKeyExchangeTimeout, null, BaseTransportManager.ServerDefaultKeepAliveTimeoutMs, Timeout.Infinite);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 43501, 44057);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1653, 44104, 44110);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 41887, 44725);

                    case RemoteSessionEvent.KeyReceiveFailed:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 41887, 44725);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 44220, 44419) || true) && ((_state == RemoteSessionState.Established) || (DynAbs.Tracing.TraceSender.Expression_False(1653, 44224, 44327) || (_state == RemoteSessionState.EstablishedAndKeyExchanged)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 44220, 44419);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 44385, 44392);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 44220, 44419);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 44447, 44472);

                            f_1653_44447_44471(this, this, eventArgs);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1653, 44519, 44525);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 41887, 44725);

                    case RemoteSessionEvent.KeySendFailed:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 41887, 44725);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 44632, 44657);

                            f_1653_44632_44656(this, this, eventArgs);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1653, 44704, 44710);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 41887, 44725);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 41263, 44736);

                int
                f_1653_41728_41870(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 41728, 41870);
                    return 0;
                }


                System.Management.Automation.RemoteSessionEvent
                f_1653_41895_41915(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.StateEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 41895, 41915);
                    return return_v;
                }


                System.Threading.Timer
                f_1653_42315_42364(ref System.Threading.Timer
                location1, System.Threading.Timer
                value)
                {
                    var return_v = Interlocked.Exchange(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 42315, 42364);
                    return return_v;
                }


                int
                f_1653_42476_42489(System.Threading.Timer
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 42476, 42489);
                    return 0;
                }


                System.Exception
                f_1653_42745_42761(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 42745, 42761);
                    return return_v;
                }


                int
                f_1653_42690_42762(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionState
                newState, System.Exception
                reason)
                {
                    this_param.SetState(newState, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 42690, 42762);
                    return 0;
                }


                int
                f_1653_42875_42909(System.Management.Automation.Remoting.ServerRemoteSession
                this_param)
                {
                    this_param.SendEncryptedSessionKey();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 42875, 42909);
                    return 0;
                }


                System.Exception
                f_1653_43297_43313(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 43297, 43313);
                    return return_v;
                }


                int
                f_1653_43241_43314(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionState
                newState, System.Exception
                reason)
                {
                    this_param.SetState(newState, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 43241, 43314);
                    return 0;
                }


                System.Exception
                f_1653_43798_43814(System.Management.Automation.RemoteSessionStateMachineEventArgs
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 43798, 43814);
                    return return_v;
                }


                int
                f_1653_43742_43815(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionState
                newState, System.Exception
                reason)
                {
                    this_param.SetState(newState, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 43742, 43815);
                    return 0;
                }


                System.Threading.Timer
                f_1653_43916_44029(System.Threading.TimerCallback
                callback, object?
                state, int
                dueTime, int
                period)
                {
                    var return_v = new System.Threading.Timer(callback, state, dueTime, period);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 43916, 44029);
                    return return_v;
                }


                int
                f_1653_44447_44471(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                sender, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.DoClose((object)sender, fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 44447, 44471);
                    return 0;
                }


                int
                f_1653_44632_44656(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                sender, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.DoClose((object)sender, fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 44632, 44656);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 41263, 44736);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 41263, 44736);
            }
        }

        private void HandleKeyExchangeTimeout(object sender)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 44910, 45567);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 44987, 45108);

                f_1653_44987_45107(_state == RemoteSessionState.EstablishedAndKeyRequested, "timeout should only happen when waiting for a key");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 45124, 45186);

                Timer
                tmp = f_1653_45136_45185(ref _keyExchangeTimer, null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 45200, 45278) || true) && (tmp != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 45200, 45278);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 45249, 45263);

                    f_1653_45249_45262(tmp);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 45200, 45278);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 45294, 45441);

                PSRemotingDataStructureException
                exception =
                f_1653_45356_45440(f_1653_45393_45439())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 45457, 45556);

                f_1653_45457_45555(this, f_1653_45468_45554(RemoteSessionEvent.KeyReceiveFailed, exception));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 44910, 45567);

                int
                f_1653_44987_45107(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 44987, 45107);
                    return 0;
                }


                System.Threading.Timer
                f_1653_45136_45185(ref System.Threading.Timer
                location1, System.Threading.Timer
                value)
                {
                    var return_v = Interlocked.Exchange(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 45136, 45185);
                    return return_v;
                }


                int
                f_1653_45249_45262(System.Threading.Timer
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 45249, 45262);
                    return 0;
                }


                string
                f_1653_45393_45439()
                {
                    var return_v = RemotingErrorIdStrings.ServerKeyExchangeFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1653, 45393, 45439);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1653_45356_45440(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 45356, 45440);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1653_45468_45554(System.Management.Automation.RemoteSessionEvent
                stateEvent, System.Management.Automation.Remoting.PSRemotingDataStructureException
                reason)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent, (System.Exception)reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 45468, 45554);
                    return return_v;
                }


                int
                f_1653_45457_45555(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEvent(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 45457, 45555);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 44910, 45567);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 44910, 45567);
            }
        }

        private void CleanAll()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 45883, 45928);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 45883, 45928);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 45883, 45928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 45883, 45928);
            }
        }

        private void SetState(RemoteSessionState newState, Exception reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1653, 46279, 46703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 46372, 46409);

                RemoteSessionState
                oldState = _state
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 46423, 46631) || true) && (newState != oldState)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1653, 46423, 46631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 46481, 46499);

                    _state = newState;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 46517, 46616);

                    f_1653_46517_46615(s_trace, "state machine state transition: from state {0} to state {1}", oldState, _state);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1653, 46423, 46631);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1653, 46279, 46703);

                int
                f_1653_46517_46615(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Management.Automation.RemoteSessionState
                arg1, System.Management.Automation.RemoteSessionState
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 46517, 46615);
                    return 0;
                }

                // TODO: else should we close the session here?
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1653, 46279, 46703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 46279, 46703);
            }
        }

        static ServerRemoteSessionDSHandlerStateMachine()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1653, 1636, 46710);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1653, 1857, 1978);
            s_trace = f_1653_1867_1978("ServerRemoteSessionDSHandlerStateMachine", "ServerRemoteSessionDSHandlerStateMachine");
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1653, 1636, 46710);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1653, 1636, 46710);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1653, 1636, 46710);

        static System.Management.Automation.PSTraceSource
        f_1653_1867_1978(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 1867, 1978);
            return return_v;
        }


        System.Collections.Generic.Queue<System.Management.Automation.RemoteSessionStateMachineEventArgs>
        f_1653_2167_2214()
        {
            var return_v = new System.Collections.Generic.Queue<System.Management.Automation.RemoteSessionStateMachineEventArgs>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 2167, 2214);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1653_3582_3631(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 3582, 3631);
            return return_v;
        }


        object
        f_1653_3710_3722()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 3710, 3722);
            return return_v;
        }


        int
        f_1653_3918_3950(System.EventHandler<System.Management.Automation.RemoteSessionStateMachineEventArgs>[,]
        this_param, int
        dimension)
        {
            var return_v = this_param.GetLength(dimension);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 3918, 3950);
            return return_v;
        }


        int
        f_1653_7754_7786(System.EventHandler<System.Management.Automation.RemoteSessionStateMachineEventArgs>[,]
        this_param, int
        dimension)
        {
            var return_v = this_param.GetLength(dimension);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 7754, 7786);
            return return_v;
        }


        int
        f_1653_7845_7877(System.EventHandler<System.Management.Automation.RemoteSessionStateMachineEventArgs>[,]
        this_param, int
        dimension)
        {
            var return_v = this_param.GetLength(dimension);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 7845, 7877);
            return return_v;
        }


        int
        f_1653_8166_8205(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
        this_param, System.Management.Automation.RemoteSessionState
        newState, System.Exception
        reason)
        {
            this_param.SetState(newState, reason);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1653, 8166, 8205);
            return 0;
        }

    }
}
