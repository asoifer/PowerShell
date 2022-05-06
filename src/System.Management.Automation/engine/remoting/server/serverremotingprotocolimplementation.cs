// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Remoting.Server;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
    internal class ServerRemoteSessionDSHandlerImpl : ServerRemoteSessionDataStructureHandler
    {
        private AbstractServerSessionTransportManager _transportManager;

        private ServerRemoteSessionDSHandlerStateMachine _stateMachine;

        private ServerRemoteSession _session;

        internal override AbstractServerSessionTransportManager TransportManager
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1656, 810, 886);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 846, 871);

                    return _transportManager;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1656, 810, 886);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1656, 713, 897);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1656, 713, 897);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ServerRemoteSessionDSHandlerImpl(ServerRemoteSession session,
                    AbstractServerSessionTransportManager transportManager)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1656, 1296, 1862);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 563, 580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 640, 653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 692, 700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 1460, 1515);

                f_1656_1460_1514(session != null, "session cannot be null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 1529, 1602);

                f_1656_1529_1601(transportManager != null, "transportManager cannot be null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 1618, 1637);

                _session = session;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 1651, 1721);

                _stateMachine = f_1656_1667_1720(session);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 1735, 1772);

                _transportManager = transportManager;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 1786, 1851);

                _transportManager.DataReceived += session.DispatchInputQueueData;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1656, 1296, 1862);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1656, 1296, 1862);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1656, 1296, 1862);
            }
        }

        internal override void ConnectAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1656, 2070, 2278);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1656, 2070, 2278);
                // for the WSMan implementation, this is a no-op..and statemachine is coded accordingly
                // to move to negotiation pending.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1656, 2070, 2278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1656, 2070, 2278);
            }
        }

        internal override void SendNegotiationAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1656, 2429, 3401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 2499, 2576);

                RemoteSessionCapability
                serverCapability = f_1656_2542_2575(f_1656_2542_2558(_session))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 2590, 2709);

                RemoteDataObject
                data = f_1656_2614_2708(serverCapability, Guid.Empty)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 2725, 2891);

                RemoteSessionStateMachineEventArgs
                negotiationSendCompletedArg =
                f_1656_2807_2890(RemoteSessionEvent.NegotiationSendCompleted)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 2905, 2959);

                f_1656_2905_2958(_stateMachine, negotiationSendCompletedArg);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 2975, 3167);

                RemoteDataObject<PSObject>
                dataToBeSent = f_1656_3017_3166(f_1656_3073_3089(data), f_1656_3091_3104(data), f_1656_3106_3125(data), f_1656_3127_3144(data), f_1656_3156_3165(data))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 3324, 3390);

                f_1656_3324_3389(            // send data to client..flush is not true as we expect to send state changed
                                             // information (from runspace creation)
                            _transportManager, dataToBeSent, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1656, 2429, 3401);

                System.Management.Automation.Remoting.ServerRemoteSessionContext
                f_1656_2542_2558(System.Management.Automation.Remoting.ServerRemoteSession
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1656, 2542, 2558);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionCapability
                f_1656_2542_2575(System.Management.Automation.Remoting.ServerRemoteSessionContext
                this_param)
                {
                    var return_v = this_param.ServerCapability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1656, 2542, 2575);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject
                f_1656_2614_2708(System.Management.Automation.Remoting.RemoteSessionCapability
                capability, System.Guid
                runspacePoolId)
                {
                    var return_v = RemotingEncoder.GenerateServerSessionCapability(capability, runspacePoolId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 2614, 2708);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1656_2807_2890(System.Management.Automation.RemoteSessionEvent
                stateEvent)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 2807, 2890);
                    return return_v;
                }


                int
                f_1656_2905_2958(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEvent(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 2905, 2958);
                    return 0;
                }


                System.Management.Automation.RemotingDestination
                f_1656_3073_3089(System.Management.Automation.Remoting.RemoteDataObject
                this_param)
                {
                    var return_v = this_param.Destination;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1656, 3073, 3089);
                    return return_v;
                }


                System.Management.Automation.RemotingDataType
                f_1656_3091_3104(System.Management.Automation.Remoting.RemoteDataObject
                this_param)
                {
                    var return_v = this_param.DataType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1656, 3091, 3104);
                    return return_v;
                }


                System.Guid
                f_1656_3106_3125(System.Management.Automation.Remoting.RemoteDataObject
                this_param)
                {
                    var return_v = this_param.RunspacePoolId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1656, 3106, 3125);
                    return return_v;
                }


                System.Guid
                f_1656_3127_3144(System.Management.Automation.Remoting.RemoteDataObject
                this_param)
                {
                    var return_v = this_param.PowerShellId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1656, 3127, 3144);
                    return return_v;
                }


                object
                f_1656_3156_3165(System.Management.Automation.Remoting.RemoteDataObject
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1656, 3156, 3165);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                f_1656_3017_3166(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, object
                data)
                {
                    var return_v = RemoteDataObject<PSObject>.CreateFrom(destination, dataType, runspacePoolId, powerShellId, (System.Management.Automation.PSObject)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 3017, 3166);
                    return return_v;
                }


                int
                f_1656_3324_3389(System.Management.Automation.Remoting.Server.AbstractServerSessionTransportManager
                this_param, System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                data, bool
                flush)
                {
                    this_param.SendDataToClient<System.Management.Automation.PSObject>(data, flush);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 3324, 3389);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1656, 2429, 3401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1656, 2429, 3401);
            }
        }

        /// <summary>
        /// This event indicates that the client capability negotiation packet has been received.
        /// </summary>
        internal override event EventHandler<RemoteSessionNegotiationEventArgs>
NegotiationReceived
;

        /// <summary>
        /// Event that raised when session datastructure handler is closing.
        /// </summary>
        internal override event EventHandler<EventArgs>
SessionClosing
;

        internal override event EventHandler<RemoteDataEventArgs<string>>
PublicKeyReceived
;

        internal override void SendEncryptedSessionKey(string encryptedSessionKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1656, 4172, 4435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 4271, 4424);

                f_1656_4271_4423(_transportManager, f_1656_4314_4416(Guid.Empty, encryptedSessionKey), true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1656, 4172, 4435);

                System.Management.Automation.Remoting.RemoteDataObject
                f_1656_4314_4416(System.Guid
                runspacePoolId, string
                encryptedSessionKey)
                {
                    var return_v = RemotingEncoder.GenerateEncryptedSessionKeyResponse(runspacePoolId, encryptedSessionKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 4314, 4416);
                    return return_v;
                }


                int
                f_1656_4271_4423(System.Management.Automation.Remoting.Server.AbstractServerSessionTransportManager
                this_param, System.Management.Automation.Remoting.RemoteDataObject
                data, bool
                flush)
                {
                    this_param.SendDataToClient<object>((System.Management.Automation.Remoting.RemoteDataObject<object>)data, flush);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 4271, 4423);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1656, 4172, 4435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1656, 4172, 4435);
            }
        }

        internal override void SendRequestForPublicKey()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1656, 4560, 4765);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 4633, 4754);

                f_1656_4633_4753(_transportManager, f_1656_4694_4746(Guid.Empty), true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1656, 4560, 4765);

                System.Management.Automation.Remoting.RemoteDataObject
                f_1656_4694_4746(System.Guid
                runspacePoolId)
                {
                    var return_v = RemotingEncoder.GeneratePublicKeyRequest(runspacePoolId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 4694, 4746);
                    return return_v;
                }


                int
                f_1656_4633_4753(System.Management.Automation.Remoting.Server.AbstractServerSessionTransportManager
                this_param, System.Management.Automation.Remoting.RemoteDataObject
                data, bool
                flush)
                {
                    this_param.SendDataToClient<object>((System.Management.Automation.Remoting.RemoteDataObject<object>)data, flush);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 4633, 4753);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1656, 4560, 4765);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1656, 4560, 4765);
            }
        }

        internal override void RaiseKeyExchangeMessageReceived(RemoteDataObject<PSObject> receivedData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1656, 5044, 5237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 5164, 5226);

                f_1656_5164_5225(this, f_1656_5187_5224(receivedData));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1656, 5044, 5237);

                System.Management.Automation.RemoteDataEventArgs
                f_1656_5187_5224(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                receivedData)
                {
                    var return_v = new System.Management.Automation.RemoteDataEventArgs(receivedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 5187, 5224);
                    return return_v;
                }


                int
                f_1656_5164_5225(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerImpl
                this_param, System.Management.Automation.RemoteDataEventArgs
                dataArg)
                {
                    this_param.RaiseDataReceivedEvent(dataArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 5164, 5225);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1656, 5044, 5237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1656, 5044, 5237);
            }
        }

        internal override void CloseConnectionAsync(Exception reasonForClose)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1656, 5646, 6099);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 5780, 5829);

                f_1656_5780_5828(            // Raise the closing event
                            SessionClosing, this, EventArgs.Empty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 5845, 5885);

                f_1656_5845_5884(
                            _transportManager, reasonForClose);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 5901, 6030);

                RemoteSessionStateMachineEventArgs
                closeCompletedArg = f_1656_5956_6029(RemoteSessionEvent.CloseCompleted)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 6044, 6088);

                f_1656_6044_6087(_stateMachine, closeCompletedArg);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1656, 5646, 6099);

                int
                f_1656_5780_5828(System.EventHandler<System.EventArgs>
                eventHandler, System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerImpl
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.EventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 5780, 5828);
                    return 0;
                }


                int
                f_1656_5845_5884(System.Management.Automation.Remoting.Server.AbstractServerSessionTransportManager
                this_param, System.Exception
                reasonForClose)
                {
                    this_param.Close(reasonForClose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 5845, 5884);
                    return 0;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1656_5956_6029(System.Management.Automation.RemoteSessionEvent
                stateEvent)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 5956, 6029);
                    return return_v;
                }


                int
                f_1656_6044_6087(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEvent(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 6044, 6087);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1656, 5646, 6099);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1656, 5646, 6099);
            }
        }

        /// <summary>
        /// This event indicates that the client has requested to create a new runspace pool
        /// on the server side.
        /// </summary>
        internal override event EventHandler<RemoteDataEventArgs>
CreateRunspacePoolReceived
;

        internal override ServerRemoteSessionDSHandlerStateMachine StateMachine
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1656, 6569, 6641);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 6605, 6626);

                    return _stateMachine;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1656, 6569, 6641);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1656, 6473, 6652);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1656, 6473, 6652);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void RaiseDataReceivedEvent(RemoteDataEventArgs dataArg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1656, 7067, 10458);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 7166, 7290) || true) && (dataArg == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1656, 7166, 7290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 7219, 7275);

                    throw f_1656_7225_7274("dataArg");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1656, 7166, 7290);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 7306, 7365);

                RemoteDataObject<PSObject>
                rcvdData = f_1656_7344_7364(dataArg)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 7381, 7448);

                RemotingTargetInterface
                targetInterface = f_1656_7423_7447(rcvdData)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 7462, 7508);

                RemotingDataType
                dataType = f_1656_7490_7507(rcvdData)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 7524, 7622);

                f_1656_7524_7621(targetInterface == RemotingTargetInterface.Session, "targetInterface must be Session");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 7638, 10447);

                switch (dataType)
                {

                    case RemotingDataType.CreateRunspacePool:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1656, 7638, 10447);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 7919, 7972);

                            f_1656_7919_7971(                        // At this point, the negotiation is complete, so
                                                                     // need to import the clients public key
                                                    CreateRunspacePoolReceived, this, dataArg);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1656, 8019, 8025);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1656, 7638, 10447);

                    case RemotingDataType.CloseSession:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1656, 7638, 10447);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 8102, 8242);

                        PSRemotingDataStructureException
                        reasonOfClose = f_1656_8151_8241(f_1656_8188_8240())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 8264, 8397);

                        RemoteSessionStateMachineEventArgs
                        closeSessionArg = f_1656_8317_8396(RemoteSessionEvent.Close, reasonOfClose)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 8419, 8461);

                        f_1656_8419_8460(_stateMachine, closeSessionArg);
                        DynAbs.Tracing.TraceSender.TraceBreak(1656, 8483, 8489);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1656, 7638, 10447);

                    case RemotingDataType.SessionCapability:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1656, 7638, 10447);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 8571, 8613);

                        RemoteSessionCapability
                        capability = null
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 8687, 8752);

                            capability = f_1656_8700_8751(f_1656_8737_8750(rcvdData));
                        }
                        catch (PSRemotingDataStructureException dse)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1656, 8797, 9255);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 9026, 9232);

                            throw f_1656_9032_9231(f_1656_9069_9126(), f_1656_9157_9168(dse), f_1656_9170_9195(), RemotingConstants.ProtocolVersion);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1656, 8797, 9255);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 9279, 9409);

                        RemoteSessionStateMachineEventArgs
                        capabilityArg = f_1656_9330_9408(RemoteSessionEvent.NegotiationReceived)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 9431, 9482);

                        capabilityArg.RemoteSessionCapability = capability;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 9504, 9544);

                        f_1656_9504_9543(_stateMachine, capabilityArg);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 9568, 9915) || true) && (NegotiationReceived != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1656, 9568, 9915);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 9649, 9750);

                            RemoteSessionNegotiationEventArgs
                            negotiationArg = f_1656_9700_9749(capability)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 9776, 9813);

                            negotiationArg.RemoteData = rcvdData;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 9839, 9892);

                            f_1656_9839_9891(NegotiationReceived, this, negotiationArg);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1656, 9568, 9915);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1656, 9939, 9945);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1656, 7638, 10447);

                    case RemotingDataType.PublicKey:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1656, 7638, 10447);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 10046, 10115);

                            string
                            remotePublicKey = f_1656_10071_10114(f_1656_10100_10113(rcvdData))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 10141, 10226);

                            f_1656_10141_10225(PublicKeyReceived, this, f_1656_10176_10224(remotePublicKey));
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1656, 10273, 10279);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1656, 7638, 10447);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1656, 7638, 10447);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1656, 10329, 10432);

                        throw f_1656_10335_10431(f_1656_10372_10420(), dataType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1656, 7638, 10447);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1656, 7067, 10458);

                System.Management.Automation.PSArgumentNullException
                f_1656_7225_7274(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 7225, 7274);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                f_1656_7344_7364(System.Management.Automation.RemoteDataEventArgs
                this_param)
                {
                    var return_v = this_param.ReceivedData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1656, 7344, 7364);
                    return return_v;
                }


                System.Management.Automation.RemotingTargetInterface
                f_1656_7423_7447(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.TargetInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1656, 7423, 7447);
                    return return_v;
                }


                System.Management.Automation.RemotingDataType
                f_1656_7490_7507(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.DataType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1656, 7490, 7507);
                    return return_v;
                }


                int
                f_1656_7524_7621(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 7524, 7621);
                    return 0;
                }


                int
                f_1656_7919_7971(System.EventHandler<System.Management.Automation.RemoteDataEventArgs>
                eventHandler, System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerImpl
                sender, System.Management.Automation.RemoteDataEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 7919, 7971);
                    return 0;
                }


                string
                f_1656_8188_8240()
                {
                    var return_v = RemotingErrorIdStrings.ClientRequestedToCloseSession;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1656, 8188, 8240);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1656_8151_8241(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 8151, 8241);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1656_8317_8396(System.Management.Automation.RemoteSessionEvent
                stateEvent, System.Management.Automation.Remoting.PSRemotingDataStructureException
                reason)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent, (System.Exception)reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 8317, 8396);
                    return return_v;
                }


                int
                f_1656_8419_8460(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEvent(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 8419, 8460);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1656_8737_8750(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1656, 8737, 8750);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionCapability
                f_1656_8700_8751(System.Management.Automation.PSObject
                data)
                {
                    var return_v = RemotingDecoder.GetSessionCapability((object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 8700, 8751);
                    return return_v;
                }


                string
                f_1656_9069_9126()
                {
                    var return_v = RemotingErrorIdStrings.ServerNotFoundCapabilityProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1656, 9069, 9126);
                    return return_v;
                }


                string
                f_1656_9157_9168(System.Management.Automation.Remoting.PSRemotingDataStructureException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1656, 9157, 9168);
                    return return_v;
                }


                string
                f_1656_9170_9195()
                {
                    var return_v = PSVersionInfo.GitCommitId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1656, 9170, 9195);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1656_9032_9231(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 9032, 9231);
                    return return_v;
                }


                System.Management.Automation.RemoteSessionStateMachineEventArgs
                f_1656_9330_9408(System.Management.Automation.RemoteSessionEvent
                stateEvent)
                {
                    var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs(stateEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 9330, 9408);
                    return return_v;
                }


                int
                f_1656_9504_9543(System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
                this_param, System.Management.Automation.RemoteSessionStateMachineEventArgs
                fsmEventArg)
                {
                    this_param.RaiseEvent(fsmEventArg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 9504, 9543);
                    return 0;
                }


                System.Management.Automation.RemoteSessionNegotiationEventArgs
                f_1656_9700_9749(System.Management.Automation.Remoting.RemoteSessionCapability
                remoteSessionCapability)
                {
                    var return_v = new System.Management.Automation.RemoteSessionNegotiationEventArgs(remoteSessionCapability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 9700, 9749);
                    return return_v;
                }


                int
                f_1656_9839_9891(System.EventHandler<System.Management.Automation.RemoteSessionNegotiationEventArgs>
                eventHandler, System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerImpl
                sender, System.Management.Automation.RemoteSessionNegotiationEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.RemoteSessionNegotiationEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 9839, 9891);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1656_10100_10113(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1656, 10100, 10113);
                    return return_v;
                }


                string
                f_1656_10071_10114(System.Management.Automation.PSObject
                dataAsPSObject)
                {
                    var return_v = RemotingDecoder.GetPublicKey(dataAsPSObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 10071, 10114);
                    return return_v;
                }


                System.Management.Automation.RemoteDataEventArgs<string>
                f_1656_10176_10224(string
                data)
                {
                    var return_v = new System.Management.Automation.RemoteDataEventArgs<string>((object)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 10176, 10224);
                    return return_v;
                }


                int
                f_1656_10141_10225(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<string>>
                eventHandler, System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerImpl
                sender, System.Management.Automation.RemoteDataEventArgs<string>
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<string>>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 10141, 10225);
                    return 0;
                }


                string
                f_1656_10372_10420()
                {
                    var return_v = RemotingErrorIdStrings.ReceivedUnsupportedAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1656, 10372, 10420);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1656_10335_10431(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 10335, 10431);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1656, 7067, 10458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1656, 7067, 10458);
            }
        }

        static ServerRemoteSessionDSHandlerImpl()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1656, 411, 10497);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1656, 411, 10497);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1656, 411, 10497);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1656, 411, 10497);

        int
        f_1656_1460_1514(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 1460, 1514);
            return 0;
        }


        int
        f_1656_1529_1601(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 1529, 1601);
            return 0;
        }


        System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine
        f_1656_1667_1720(System.Management.Automation.Remoting.ServerRemoteSession
        session)
        {
            var return_v = new System.Management.Automation.Remoting.ServerRemoteSessionDSHandlerStateMachine(session);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1656, 1667, 1720);
            return return_v;
        }

    }
}

