// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Dbg = System.Management.Automation.Diagnostics;

using System.Management.Automation.Remoting.Server;

namespace System.Management.Automation.Remoting
{
    internal abstract class ServerRemoteSessionDataStructureHandler : BaseSessionDataStructureHandler
    {
        internal ServerRemoteSessionDataStructureHandler()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1654, 937, 1009);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1654, 937, 1009);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1654, 937, 1009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1654, 937, 1009);
            }
        }

        internal abstract void ConnectAsync();

        internal abstract void SendNegotiationAsync();

        /// <summary>
        /// This event indicates that a client's capability negotiation packet has been received.
        /// </summary>
        internal abstract event EventHandler<RemoteSessionNegotiationEventArgs>
NegotiationReceived
;

        internal abstract void CloseConnectionAsync(Exception reasonForClose);

        /// <summary>
        /// Event that raised when session datastructure handler is closing.
        /// </summary>
        internal abstract event EventHandler<EventArgs>
SessionClosing
;

        /// <summary>
        /// This event indicates a request for creating a new runspace pool
        /// has been received on the server side.
        /// </summary>
        internal abstract event EventHandler<RemoteDataEventArgs>
CreateRunspacePoolReceived
;

        internal abstract ServerRemoteSessionDSHandlerStateMachine StateMachine
        {
            get;
        }

        internal abstract AbstractServerSessionTransportManager TransportManager
        {
            get;
        }

        internal abstract void RaiseDataReceivedEvent(RemoteDataEventArgs arg);

        internal abstract event EventHandler<RemoteDataEventArgs<string>>
PublicKeyReceived
;

        internal abstract void SendRequestForPublicKey();

        internal abstract void SendEncryptedSessionKey(string encryptedSessionKey);

        static ServerRemoteSessionDataStructureHandler()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1654, 687, 3527);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1654, 687, 3527);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1654, 687, 3527);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1654, 687, 3527);
    }
}
