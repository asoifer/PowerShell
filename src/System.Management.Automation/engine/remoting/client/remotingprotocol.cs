// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Remoting.Client;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
internal abstract class BaseSessionDataStructureHandler
{
internal abstract void RaiseKeyExchangeMessageReceived(RemoteDataObject<PSObject> receivedData);

public BaseSessionDataStructureHandler()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1583,268,443);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1583,268,443);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1583,268,443);
}


static BaseSessionDataStructureHandler()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1583,268,443);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1583,268,443);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1583,268,443);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1583,268,443);
}
internal abstract class ClientRemoteSessionDataStructureHandler : BaseSessionDataStructureHandler
{
internal abstract void CreateAsync();

        internal abstract event EventHandler<RemoteSessionStateEventArgs> 
ConnectionStateChanged
;

internal abstract void SendNegotiationAsync(RemoteSessionState sessionState);

        internal abstract event EventHandler<RemoteSessionNegotiationEventArgs> 
NegotiationReceived
;

internal abstract void CloseConnectionAsync();

internal abstract void DisconnectAsync();

internal abstract void ReconnectAsync();

internal abstract ClientRemoteSessionDSHandlerStateMachine StateMachine
{            get;
}

internal abstract BaseClientSessionTransportManager TransportManager {get; }

internal abstract BaseClientCommandTransportManager CreateClientCommandTransportManager(
            System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell cmd,
            bool noInput);

        // TODO: If this is not used, remove this.
        // internal abstract event EventHandler<RemoteDataEventArgs> DataReceived;

        internal abstract event EventHandler<RemoteDataEventArgs<string>> 
EncryptedSessionKeyReceived
;

        internal abstract event EventHandler<RemoteDataEventArgs<string>> 
PublicKeyRequestReceived
;

internal abstract void SendPublicKeyAsync(string localPublicKey);

public ClientRemoteSessionDataStructureHandler()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1583,451,1986);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1583,451,1986);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1583,451,1986);
}


static ClientRemoteSessionDataStructureHandler()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1583,451,1986);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1583,451,1986);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1583,451,1986);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1583,451,1986);
}
}
