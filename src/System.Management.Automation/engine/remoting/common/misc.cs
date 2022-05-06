// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Remoting;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    internal sealed class RemoteSessionNegotiationEventArgs : EventArgs
    {
        internal RemoteSessionNegotiationEventArgs(RemoteSessionCapability remoteSessionCapability)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1620, 368, 817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 985, 1050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 1161, 1221);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 484, 568);

                f_1620_484_567(remoteSessionCapability != null, "caller should validate the parameter");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 584, 740) || true) && (remoteSessionCapability == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1620, 584, 740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 653, 725);

                    throw f_1620_659_724("remoteSessionCapability");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1620, 584, 740);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 756, 806);

                RemoteSessionCapability = remoteSessionCapability;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1620, 368, 817);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1620, 368, 817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1620, 368, 817);
            }
        }

        internal RemoteSessionCapability RemoteSessionCapability { get; }

        internal RemoteDataObject<PSObject> RemoteData { get; set; }

        static RemoteSessionNegotiationEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1620, 252, 1228);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1620, 252, 1228);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1620, 252, 1228);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1620, 252, 1228);

        int
        f_1620_484_567(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1620, 484, 567);
            return 0;
        }


        System.Management.Automation.PSArgumentNullException
        f_1620_659_724(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1620, 659, 724);
            return return_v;
        }

    }
    internal sealed class RemoteDataEventArgs : EventArgs
    {
        internal RemoteDataEventArgs(RemoteDataObject<PSObject> receivedData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1620, 1559, 1931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 2053, 2108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 1653, 1726);

                f_1620_1653_1725(receivedData != null, "caller should validate the parameter");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 1742, 1876) || true) && (receivedData == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1620, 1742, 1876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 1800, 1861);

                    throw f_1620_1806_1860("receivedData");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1620, 1742, 1876);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 1892, 1920);

                ReceivedData = receivedData;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1620, 1559, 1931);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1620, 1559, 1931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1620, 1559, 1931);
            }
        }

        public RemoteDataObject<PSObject> ReceivedData { get; }

        static RemoteDataEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1620, 1457, 2115);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1620, 1457, 2115);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1620, 1457, 2115);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1620, 1457, 2115);

        int
        f_1620_1653_1725(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1620, 1653, 1725);
            return 0;
        }


        System.Management.Automation.PSArgumentNullException
        f_1620_1806_1860(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1620, 1806, 1860);
            return return_v;
        }

    }
    internal sealed class RemoteDataEventArgs<T> : EventArgs
    {
        internal T Data { get; }

        internal RemoteDataEventArgs(object data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1620, 2741, 2911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 2641, 2665);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 2885, 2900);

                Data = (T)data;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1620, 2741, 2911);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1620, 2741, 2911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1620, 2741, 2911);
            }
        }
    }

    /// <summary>
    /// This defines the various states a remote connection can be in.
    /// </summary>
    internal enum RemoteSessionState
    {
        /// <summary>
        /// Undefined state.
        /// </summary>
        UndefinedState = 0,

        /// <summary>
        /// This is the state a connect start with. When a connection is closed,
        /// the connection will eventually come back to this Idle state.
        /// </summary>
        Idle = 1,

        /// <summary>
        /// A connection operation has been initiated.
        /// </summary>
        Connecting = 2,

        /// <summary>
        /// A connection operation has completed successfully.
        /// </summary>
        Connected = 3,

        /// <summary>
        /// The capability negotiation message is in the process being sent on a create operation.
        /// </summary>
        NegotiationSending = 4,

        /// <summary>
        /// The capability negotiation message is in the process being sent on a connect operation.
        /// </summary>
        NegotiationSendingOnConnect = 5,

        /// <summary>
        /// The capability negotiation message is sent successfully from a sender point of view.
        /// </summary>
        NegotiationSent = 6,

        /// <summary>
        /// A capability negotiation message is received.
        /// </summary>
        NegotiationReceived = 7,

        /// <summary>
        /// Used by server to wait for negotiation from client.
        /// </summary>
        NegotiationPending = 8,

        /// <summary>
        /// The connection is in the progress of getting closed.
        /// </summary>
        ClosingConnection = 9,

        /// <summary>
        /// The connection is closed completely.
        /// </summary>
        Closed = 10,

        /// <summary>
        /// The capability negotiation has been successfully completed.
        /// </summary>
        Established = 11,

        /// <summary>
        /// Have sent a public key to the remote end,
        /// awaiting a response.
        /// </summary>
        /// <remarks>Applicable only to client</remarks>
        EstablishedAndKeySent = 12,

        /// <summary>
        /// Have received a public key from the remote
        /// end, need to send a response.
        /// </summary>
        /// <remarks>Applicable only to server</remarks>
        EstablishedAndKeyReceived = 13,

        /// <summary>
        /// For Server - Have sent a request to the remote end to
        /// send a public key
        /// for Client - have received a PK request from server.
        /// </summary>
        /// <remarks>Applicable to both client and server</remarks>
        EstablishedAndKeyRequested = 14,

        /// <summary>
        /// Key exchange complete. This can mean
        ///      (a) Sent an encrypted session key to the
        ///          remote end in response to receiving
        ///          a public key - this is for the server
        ///      (b) Received an encrypted session key from
        ///          remote end after sending a public key -
        ///          this is for the client.
        /// </summary>
        EstablishedAndKeyExchanged = 15,

        /// <summary>
        /// </summary>
        Disconnecting = 16,

        /// <summary>
        /// </summary>
        Disconnected = 17,

        /// <summary>
        /// </summary>
        Reconnecting = 18,

        /// <summary>
        /// A disconnect operation initiated by the WinRM robust connection
        /// layer and *not* by the user.
        /// </summary>
        RCDisconnecting = 19,

        /// <summary>
        /// Number of states.
        /// </summary>
        MaxState = 20
    }

    /// <summary>
    /// This defines the internal events that the finite state machine for the connection
    /// uses to take action and perform state transitions.
    /// </summary>
    internal enum RemoteSessionEvent
    {
        InvalidEvent = 0,
        CreateSession = 1,
        ConnectSession = 2,
        NegotiationSending = 3,
        NegotiationSendingOnConnect = 4,
        NegotiationSendCompleted = 5,
        NegotiationReceived = 6,
        NegotiationCompleted = 7,
        NegotiationPending = 8,
        Close = 9,
        CloseCompleted = 10,
        CloseFailed = 11,
        ConnectFailed = 12,
        NegotiationFailed = 13,
        NegotiationTimeout = 14,
        SendFailed = 15,
        ReceiveFailed = 16,
        FatalError = 17,
        MessageReceived = 18,
        KeySent = 19,
        KeySendFailed = 20,
        KeyReceived = 21,
        KeyReceiveFailed = 22,
        KeyRequested = 23,
        KeyRequestFailed = 24,
        DisconnectStart = 25,
        DisconnectCompleted = 26,
        DisconnectFailed = 27,
        ReconnectStart = 28,
        ReconnectCompleted = 29,
        ReconnectFailed = 30,
        RCDisconnectStarted = 31,
        MaxEvent = 32
    }
    internal class RemoteSessionStateInfo
    {
        internal RemoteSessionStateInfo(RemoteSessionState state)
        : this(f_1620_8315_8320_C(state), null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1620, 8237, 8349);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1620, 8237, 8349);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1620, 8237, 8349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1620, 8237, 8349);
            }
        }

        internal RemoteSessionStateInfo(RemoteSessionState state, Exception reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1620, 8361, 8516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 8883, 8925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 9068, 9102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 8461, 8475);

                State = state;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 8489, 8505);

                Reason = reason;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1620, 8361, 8516);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1620, 8361, 8516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1620, 8361, 8516);
            }
        }

        internal RemoteSessionStateInfo(RemoteSessionStateInfo sessionStateInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1620, 8528, 8714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 8883, 8925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 9068, 9102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 8625, 8656);

                State = f_1620_8633_8655(sessionStateInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 8670, 8703);

                Reason = f_1620_8679_8702(sessionStateInfo);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1620, 8528, 8714);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1620, 8528, 8714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1620, 8528, 8714);
            }
        }

        internal RemoteSessionState State { get; }

        internal Exception Reason { get; }

        static RemoteSessionStateInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1620, 8151, 9149);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1620, 8151, 9149);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1620, 8151, 9149);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1620, 8151, 9149);

        static System.Management.Automation.RemoteSessionState
        f_1620_8315_8320_C(System.Management.Automation.RemoteSessionState
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1620, 8237, 8349);
            return return_v;
        }


        System.Management.Automation.RemoteSessionState
        f_1620_8633_8655(System.Management.Automation.RemoteSessionStateInfo
        this_param)
        {
            var return_v = this_param.State;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1620, 8633, 8655);
            return return_v;
        }


        System.Exception
        f_1620_8679_8702(System.Management.Automation.RemoteSessionStateInfo
        this_param)
        {
            var return_v = this_param.Reason;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1620, 8679, 8702);
            return return_v;
        }

    }
    internal class RemoteSessionStateEventArgs : EventArgs
    {
        internal RemoteSessionStateEventArgs(RemoteSessionStateInfo remoteSessionStateInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1620, 9367, 9791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 9975, 10030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 9475, 9558);

                f_1620_9475_9557(remoteSessionStateInfo != null, "caller should validate the parameter");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 9574, 9722) || true) && (remoteSessionStateInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1620, 9574, 9722);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 9642, 9707);

                    f_1620_9642_9706("remoteSessionStateInfo");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1620, 9574, 9722);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 9738, 9780);

                SessionStateInfo = remoteSessionStateInfo;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1620, 9367, 9791);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1620, 9367, 9791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1620, 9367, 9791);
            }
        }

        public RemoteSessionStateInfo SessionStateInfo { get; }

        static RemoteSessionStateEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1620, 9264, 10077);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1620, 9264, 10077);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1620, 9264, 10077);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1620, 9264, 10077);

        int
        f_1620_9475_9557(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1620, 9475, 9557);
            return 0;
        }


        System.Management.Automation.PSArgumentNullException
        f_1620_9642_9706(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1620, 9642, 9706);
            return return_v;
        }

    }
    internal class RemoteSessionStateMachineEventArgs : EventArgs
    {
        internal RemoteSessionStateMachineEventArgs(RemoteSessionEvent stateEvent)
        : this(f_1620_10290_10300_C(stateEvent), null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1620, 10195, 10329);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1620, 10195, 10329);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1620, 10195, 10329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1620, 10195, 10329);
            }
        }

        internal RemoteSessionStateMachineEventArgs(RemoteSessionEvent stateEvent, Exception reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1620, 10341, 10523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 10570, 10617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 10629, 10663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 10675, 10745);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 10757, 10817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 10458, 10482);

                StateEvent = stateEvent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1620, 10496, 10512);

                Reason = reason;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1620, 10341, 10523);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1620, 10341, 10523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1620, 10341, 10523);
            }
        }

        internal RemoteSessionEvent StateEvent { get; }

        internal Exception Reason { get; }

        internal RemoteSessionCapability RemoteSessionCapability { get; set; }

        internal RemoteDataObject<PSObject> RemoteData { get; set; }

        static RemoteSessionStateMachineEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1620, 10085, 10824);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1620, 10085, 10824);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1620, 10085, 10824);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1620, 10085, 10824);

        static System.Management.Automation.RemoteSessionEvent
        f_1620_10290_10300_C(System.Management.Automation.RemoteSessionEvent
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1620, 10195, 10329);
            return return_v;
        }

    }

    /// <summary>
    /// Defines the various types of remoting behaviour that a cmdlet may
    /// desire when used in a context that supports ambient / automatic remoting.
    /// </summary>
    public enum RemotingCapability
    {
        /// <summary>
        /// In the presence of ambient remoting, this command should
        /// still be run locally.
        /// </summary>
        None,

        /// <summary>
        /// In the presence of ambient remoting, this command should
        /// be run on the target computer using PowerShell Remoting.
        /// </summary>
        PowerShell,

        /// <summary>
        /// In the presence of ambient remoting, this command supports
        /// its own form of remoting which can be used instead to target
        /// the remote computer.
        /// </summary>
        SupportedByCommand,

        /// <summary>
        /// In the presence of ambient remoting, the command assumes
        /// all responsibility for targeting the remote computer;
        /// PowerShell Remoting is not supported.
        /// </summary>
        OwnedByCommand
    }

    /// <summary>
    /// Controls or overrides the remoting behavior, during invocation, of a
    /// command that supports ambient remoting.
    /// </summary>
    public enum RemotingBehavior
    {
        /// <summary>
        /// In the presence of ambient remoting, run this command locally.
        /// </summary>
        None,

        /// <summary>
        /// In the presence of ambient remoting, run this command on the target
        /// computer using PowerShell Remoting.
        /// </summary>
        PowerShell,

        /// <summary>
        /// In the presence of ambient remoting, and a command that declares
        /// 'SupportedByCommand' remoting capability, run this command on the
        /// target computer using the command's custom remoting facilities.
        /// </summary>
        Custom
    }
}
