// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Internal;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Runspaces.Internal;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
internal class ClientRemoteSessionContext
{
internal Uri RemoteAddress {get; set; }

internal PSCredential UserCredential {get; set; }

internal RemoteSessionCapability ClientCapability {get; set; }

internal RemoteSessionCapability ServerCapability {get; set; }

internal string ShellName {get; set; }

public ClientRemoteSessionContext()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1571,877,1913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,1064,1104);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,1227,1277);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,1393,1456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,1582,1645);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,1827,1866);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1571,877,1913);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,877,1913);
}


static ClientRemoteSessionContext()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1571,877,1913);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1571,877,1913);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,877,1913);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1571,877,1913);
}
internal abstract class ClientRemoteSession : RemoteSession
{
[TraceSourceAttribute("CRSession", "ClientRemoteSession")]
        private static PSTraceSource s_trace ;

public abstract void CreateAsync();

        /// <summary>
        /// This event handler is raised when the state of session changes.
        /// </summary>
        public abstract event EventHandler<RemoteSessionStateEventArgs> 
StateChanged
;

public abstract void CloseAsync();

public abstract void DisconnectAsync();

public abstract void ReconnectAsync();

public abstract void ConnectAsync();

internal ClientRemoteSessionContext Context {get; }

        
        
        /// <summary>
        /// Delegate used to report connection URI redirections to the application.
        /// </summary>
        /// <param name="newURI">
        /// New URI to which the connection is being redirected to.
        /// </param>
        internal delegate void URIDirectionReported(Uri newURI);

internal ClientRemoteSessionDataStructureHandler SessionDataStructureHandler {get; set; }

protected Version _serverProtocolVersion;

internal Version ServerProtocolVersion
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1571,4852,4933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,4888,4918);

return _serverProtocolVersion;
DynAbs.Tracing.TraceSender.TraceExitMethod(1571,4852,4933);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1571,4789,4944);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,4789,4944);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private RemoteRunspacePoolInternal _remoteRunspacePool;

internal RemoteRunspacePoolInternal RemoteRunspacePoolInternal
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1571,5218,5296);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,5254,5281);

return _remoteRunspacePool;
DynAbs.Tracing.TraceSender.TraceExitMethod(1571,5218,5296);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1571,5131,5546);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,5131,5546);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1571,5312,5535);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,5348,5474);

f_1571_5348_5473(_remoteRunspacePool == null, @"RunspacePool should be
                        attached only once to the session");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,5492,5520);

_remoteRunspacePool = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1571,5312,5535);

int
f_1571_5348_5473(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 5348, 5473);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1571,5131,5546);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,5131,5546);
}
		}}

internal RemoteRunspacePoolInternal GetRunspacePool(Guid clientRunspacePoolId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1571,5805,6140);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,5908,6101) || true) && (_remoteRunspacePool != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1571,5908,6101);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,5973,6086) || true) && (_remoteRunspacePool.InstanceId.Equals(clientRunspacePoolId))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1571,5973,6086);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,6059,6086);

return _remoteRunspacePool;
DynAbs.Tracing.TraceSender.TraceExitCondition(1571,5973,6086);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1571,5908,6101);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,6117,6129);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1571,5805,6140);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1571,5805,6140);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,5805,6140);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public ClientRemoteSession()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1571,2039,6147);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,3883,3971);
this.Context = f_1571_3938_3970();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,4533,4623);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,4653,4675);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,4991,5010);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1571,2039,6147);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,2039,6147);
}


static ClientRemoteSession()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1571,2039,6147);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,2212,2281);
s_trace = f_1571_2222_2281("CRSession", "ClientRemoteSession");DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1571,2039,6147);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,2039,6147);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1571,2039,6147);

static System.Management.Automation.PSTraceSource
f_1571_2222_2281(string
name,string
description)
{
var return_v = PSTraceSource.GetTracer( name, description);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 2222, 2281);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionContext
f_1571_3938_3970()
{
var return_v = new System.Management.Automation.Remoting.ClientRemoteSessionContext();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 3938, 3970);
return return_v;
}

}
internal class ClientRemoteSessionImpl : ClientRemoteSession, IDisposable
{
[TraceSourceAttribute("CRSessionImpl", "ClientRemoteSessionImpl")]
        private static PSTraceSource s_trace ;

private PSRemotingCryptoHelperClient _cryptoHelper ;

internal ClientRemoteSessionImpl(RemoteRunspacePoolInternal rsPool,
                                       URIDirectionReported uriRedirectionHandler)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1571,6926,9104);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,6556,6576);
this._cryptoHelper = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,18031,18066);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,24321,24374);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,7102,7160);

f_1571_7102_7159(rsPool != null, "RunspacePool cannot be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,7174,7215);

base.RemoteRunspacePoolInternal = rsPool;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,7229,7378);

f_1571_7229_7236().RemoteAddress = f_1571_7253_7377(f_1571_7315_7336(rsPool), "ConnectionUri", null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,7392,7443);

_cryptoHelper = f_1571_7408_7442();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,7457,7486);

_cryptoHelper.Session = this;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,7500,7576);

f_1571_7500_7507().ClientCapability = f_1571_7527_7575();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,7590,7648);

f_1571_7590_7597().UserCredential = f_1571_7615_7647(f_1571_7615_7636(rsPool));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,7849,8000);

f_1571_7849_7856().ShellName = f_1571_7869_7999(f_1571_7934_7955(rsPool), "ShellUri", string.Empty);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,8016,8052);

MySelf = RemotingDestination.Client;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,8137,8322);

SessionDataStructureHandler = f_1571_8167_8321(this, _cryptoHelper, f_1571_8259_8280(rsPool), uriRedirectionHandler);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,8336,8398);

BaseSessionDataStructureHandler = f_1571_8370_8397();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,8412,8478);

_waitHandleForConfigurationReceived = f_1571_8450_8477(false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,8583,8660);

f_1571_8583_8610().NegotiationReceived += HandleNegotiationReceived;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,8674,8757);

f_1571_8674_8701().ConnectionStateChanged += HandleConnectionStateChanged;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,8771,8928);

f_1571_8771_8798().EncryptedSessionKeyReceived +=
                new EventHandler<RemoteDataEventArgs<string>>(HandleEncryptedSessionKeyReceived);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,8942,9093);

f_1571_8942_8969().PublicKeyRequestReceived +=
                new EventHandler<RemoteDataEventArgs<string>>(HandlePublicKeyRequestReceived);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1571,6926,9104);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1571,6926,9104);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,6926,9104);
}
		}

public override void CreateAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1571,9285,9688);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,9482,9601);

RemoteSessionStateMachineEventArgs 
startArg = f_1571_9528_9600(RemoteSessionEvent.CreateSession)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,9615,9677);

f_1571_9615_9676(f_1571_9615_9655(f_1571_9615_9642()), startArg);
DynAbs.Tracing.TraceSender.TraceExitMethod(1571,9285,9688);

System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1571_9528_9600(System.Management.Automation.RemoteSessionEvent
stateEvent)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 9528, 9600);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_9615_9642()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 9615, 9642);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1571_9615_9655(System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
this_param)
{
var return_v = this_param.StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 9615, 9655);
return return_v;
}


int
f_1571_9615_9676(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 9615, 9676);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1571,9285,9688);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,9285,9688);
}
		}

public override void ConnectAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1571,9859,10273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,10066,10186);

RemoteSessionStateMachineEventArgs 
startArg = f_1571_10112_10185(RemoteSessionEvent.ConnectSession)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,10200,10262);

f_1571_10200_10261(f_1571_10200_10240(f_1571_10200_10227()), startArg);
DynAbs.Tracing.TraceSender.TraceExitMethod(1571,9859,10273);

System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1571_10112_10185(System.Management.Automation.RemoteSessionEvent
stateEvent)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 10112, 10185);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_10200_10227()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 10200, 10227);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1571_10200_10240(System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
this_param)
{
var return_v = this_param.StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 10200, 10240);
return return_v;
}


int
f_1571_10200_10261(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 10200, 10261);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1571,9859,10273);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,9859,10273);
}
		}

public override void CloseAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1571,10513,10769);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,10571,10682);

RemoteSessionStateMachineEventArgs 
closeArg = f_1571_10617_10681(RemoteSessionEvent.Close)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,10696,10758);

f_1571_10696_10757(f_1571_10696_10736(f_1571_10696_10723()), closeArg);
DynAbs.Tracing.TraceSender.TraceExitMethod(1571,10513,10769);

System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1571_10617_10681(System.Management.Automation.RemoteSessionEvent
stateEvent)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 10617, 10681);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_10696_10723()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 10696, 10723);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1571_10696_10736(System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
this_param)
{
var return_v = this_param.StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 10696, 10736);
return return_v;
}


int
f_1571_10696_10757(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 10696, 10757);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1571,10513,10769);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,10513,10769);
}
		}

public override void DisconnectAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1571,10904,11195);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,10967,11098);

RemoteSessionStateMachineEventArgs 
startDisconnectArg = f_1571_11023_11097(RemoteSessionEvent.DisconnectStart)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,11112,11184);

f_1571_11112_11183(f_1571_11112_11152(f_1571_11112_11139()), startDisconnectArg);
DynAbs.Tracing.TraceSender.TraceExitMethod(1571,10904,11195);

System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1571_11023_11097(System.Management.Automation.RemoteSessionEvent
stateEvent)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 11023, 11097);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_11112_11139()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 11112, 11139);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1571_11112_11152(System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
this_param)
{
var return_v = this_param.StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 11112, 11152);
return return_v;
}


int
f_1571_11112_11183(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 11112, 11183);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1571,10904,11195);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,10904,11195);
}
		}

public override void ReconnectAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1571,11368,11655);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,11430,11559);

RemoteSessionStateMachineEventArgs 
startReconnectArg = f_1571_11485_11558(RemoteSessionEvent.ReconnectStart)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,11573,11644);

f_1571_11573_11643(f_1571_11573_11613(f_1571_11573_11600()), startReconnectArg);
DynAbs.Tracing.TraceSender.TraceExitMethod(1571,11368,11655);

System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1571_11485_11558(System.Management.Automation.RemoteSessionEvent
stateEvent)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 11485, 11558);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_11573_11600()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 11573, 11600);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1571_11573_11613(System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
this_param)
{
var return_v = this_param.StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 11573, 11613);
return return_v;
}


int
f_1571_11573_11643(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 11573, 11643);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1571,11368,11655);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,11368,11655);
}
		}

        /// <summary>
        /// This event handler is raised when the state of session changes.
        /// </summary>
        public override event EventHandler<RemoteSessionStateEventArgs> 
StateChanged
;

private void HandleConnectionStateChanged(object sender, RemoteSessionStateEventArgs arg)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1571,12143,13422);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,12257,13411);
using(f_1571_12264_12292(s_trace))            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,12326,12454) || true) && (arg == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1571,12326,12454);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,12383,12435);

throw f_1571_12389_12434("arg");
DynAbs.Tracing.TraceSender.TraceExitCondition(1571,12326,12454);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,12474,12750) || true) && (f_1571_12478_12504(f_1571_12478_12498(arg))== RemoteSessionState.EstablishedAndKeyReceived)
) // TODO - Client session would never get into this state... to be removed

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1571,12474,12750);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,12712,12731);

f_1571_12712_12730(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1571,12474,12750);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,12770,13341) || true) && (f_1571_12774_12800(f_1571_12774_12794(arg))== RemoteSessionState.ClosingConnection)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1571,12770,13341);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,13300,13322);

f_1571_13300_13321(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1571,12770,13341);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,13361,13396);

f_1571_13361_13395(
                StateChanged, this, arg);
DynAbs.Tracing.TraceSender.TraceExitUsing(1571,12257,13411);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1571,12143,13422);

System.IDisposable
f_1571_12264_12292(System.Management.Automation.PSTraceSource
this_param)
{
var return_v = this_param.TraceEventHandlers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 12264, 12292);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1571_12389_12434(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 12389, 12434);
return return_v;
}


System.Management.Automation.RemoteSessionStateInfo
f_1571_12478_12498(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 12478, 12498);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1571_12478_12504(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 12478, 12504);
return return_v;
}


int
f_1571_12712_12730(System.Management.Automation.Remoting.ClientRemoteSessionImpl
this_param)
{
this_param.StartKeyExchange();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 12712, 12730);
return 0;
}


System.Management.Automation.RemoteSessionStateInfo
f_1571_12774_12794(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 12774, 12794);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1571_12774_12800(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 12774, 12800);
return return_v;
}


int
f_1571_13300_13321(System.Management.Automation.Remoting.ClientRemoteSessionImpl
this_param)
{
this_param.CompleteKeyExchange();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 13300, 13321);
return 0;
}


int
f_1571_13361_13395(System.EventHandler<System.Management.Automation.RemoteSessionStateEventArgs>
eventHandler,System.Management.Automation.Remoting.ClientRemoteSessionImpl
sender,System.Management.Automation.RemoteSessionStateEventArgs
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteSessionStateEventArgs>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 13361, 13395);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1571,12143,13422);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,12143,13422);
}
		}

internal override void StartKeyExchange()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1571,13594,15457);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,13660,15446) || true) && (f_1571_13664_13710(f_1571_13664_13704(f_1571_13664_13691()))== RemoteSessionState.Established ||(DynAbs.Tracing.TraceSender.Expression_False(1571, 13664, 13860)||f_1571_13765_13811(f_1571_13765_13805(f_1571_13765_13792()))== RemoteSessionState.EstablishedAndKeyRequested))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1571,13660,15446);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,13944,13973);

string 
localPublicKey = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,13991,14008);

bool 
ret = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,14026,14078);

RemoteSessionStateMachineEventArgs 
eventArgs = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,14096,14123);

Exception 
exception = null
;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,14187,14248);

ret = f_1571_14193_14247(_cryptoHelper, out localPublicKey);
                }
                catch (PSCryptoException cryptoException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1571,14285,14448);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,14367,14379);

ret = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,14401,14429);

exception = cryptoException;
DynAbs.Tracing.TraceSender.TraceExitCatch(1571,14285,14448);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,14468,15431) || true) && (!ret)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1571,14468,15431);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,14649,14671);

f_1571_14649_14670(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,14797,14934);

eventArgs = f_1571_14809_14933(RemoteSessionEvent.KeySendFailed, exception);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,14958,15021);

f_1571_14958_15020(f_1571_14958_14998(f_1571_14958_14985()), eventArgs);
DynAbs.Tracing.TraceSender.TraceExitCondition(1571,14468,15431);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1571,14468,15431);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,15161,15240);

eventArgs = f_1571_15173_15239(RemoteSessionEvent.KeySent);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,15262,15325);

f_1571_15262_15324(f_1571_15262_15302(f_1571_15262_15289()), eventArgs);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,15349,15412);

f_1571_15349_15411(f_1571_15349_15376(), localPublicKey);
DynAbs.Tracing.TraceSender.TraceExitCondition(1571,14468,15431);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1571,13660,15446);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1571,13594,15457);

System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_13664_13691()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 13664, 13691);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1571_13664_13704(System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
this_param)
{
var return_v = this_param.StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 13664, 13704);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1571_13664_13710(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 13664, 13710);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_13765_13792()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 13765, 13792);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1571_13765_13805(System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
this_param)
{
var return_v = this_param.StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 13765, 13805);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1571_13765_13811(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 13765, 13811);
return return_v;
}


bool
f_1571_14193_14247(System.Management.Automation.Internal.PSRemotingCryptoHelperClient
this_param,out string
publicKeyAsString)
{
var return_v = this_param.ExportLocalPublicKey( out publicKeyAsString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 14193, 14247);
return return_v;
}


int
f_1571_14649_14670(System.Management.Automation.Remoting.ClientRemoteSessionImpl
this_param)
{
this_param.CompleteKeyExchange();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 14649, 14670);
return 0;
}


System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1571_14809_14933(System.Management.Automation.RemoteSessionEvent
stateEvent,System.Exception
reason)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 14809, 14933);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_14958_14985()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 14958, 14985);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1571_14958_14998(System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
this_param)
{
var return_v = this_param.StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 14958, 14998);
return return_v;
}


int
f_1571_14958_15020(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 14958, 15020);
return 0;
}


System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1571_15173_15239(System.Management.Automation.RemoteSessionEvent
stateEvent)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 15173, 15239);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_15262_15289()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 15262, 15289);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1571_15262_15302(System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
this_param)
{
var return_v = this_param.StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 15262, 15302);
return return_v;
}


int
f_1571_15262_15324(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 15262, 15324);
return 0;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_15349_15376()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 15349, 15376);
return return_v;
}


int
f_1571_15349_15411(System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
this_param,string
localPublicKey)
{
this_param.SendPublicKeyAsync( localPublicKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 15349, 15411);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1571,13594,15457);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,13594,15457);
}
		}

internal override void CompleteKeyExchange()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1571,15564,15680);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,15633,15669);

f_1571_15633_15668(            _cryptoHelper);
DynAbs.Tracing.TraceSender.TraceExitMethod(1571,15564,15680);

int
f_1571_15633_15668(System.Management.Automation.Internal.PSRemotingCryptoHelperClient
this_param)
{
this_param.CompleteKeyExchange();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 15633, 15668);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1571,15564,15680);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,15564,15680);
}
		}

private void HandleEncryptedSessionKeyReceived(object sender, RemoteDataEventArgs<string> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1571,15982,17089);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,16107,17078) || true) && (f_1571_16111_16157(f_1571_16111_16151(f_1571_16111_16138()))== RemoteSessionState.EstablishedAndKeySent)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1571,16107,17078);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,16235,16279);

string 
encryptedSessionKey = f_1571_16264_16278(eventArgs)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,16299,16371);

bool 
ret = f_1571_16310_16370(_cryptoHelper, encryptedSessionKey)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,16391,16438);

RemoteSessionStateMachineEventArgs 
args = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,16456,16793) || true) && (!ret)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1571,16456,16793);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,16609,16692);

args = f_1571_16616_16691(RemoteSessionEvent.KeyReceiveFailed);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,16716,16774);

f_1571_16716_16773(f_1571_16716_16756(f_1571_16716_16743()), args);
DynAbs.Tracing.TraceSender.TraceExitCondition(1571,16456,16793);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,16867,16889);

f_1571_16867_16888(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,16909,16987);

args = f_1571_16916_16986(RemoteSessionEvent.KeyReceived);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,17005,17063);

f_1571_17005_17062(f_1571_17005_17045(f_1571_17005_17032()), args);
DynAbs.Tracing.TraceSender.TraceExitCondition(1571,16107,17078);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1571,15982,17089);

System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_16111_16138()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 16111, 16138);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1571_16111_16151(System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
this_param)
{
var return_v = this_param.StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 16111, 16151);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1571_16111_16157(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 16111, 16157);
return return_v;
}


string
f_1571_16264_16278(System.Management.Automation.RemoteDataEventArgs<string>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 16264, 16278);
return return_v;
}


bool
f_1571_16310_16370(System.Management.Automation.Internal.PSRemotingCryptoHelperClient
this_param,string
encryptedSessionKey)
{
var return_v = this_param.ImportEncryptedSessionKey( encryptedSessionKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 16310, 16370);
return return_v;
}


System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1571_16616_16691(System.Management.Automation.RemoteSessionEvent
stateEvent)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 16616, 16691);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_16716_16743()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 16716, 16743);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1571_16716_16756(System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
this_param)
{
var return_v = this_param.StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 16716, 16756);
return return_v;
}


int
f_1571_16716_16773(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 16716, 16773);
return 0;
}


int
f_1571_16867_16888(System.Management.Automation.Remoting.ClientRemoteSessionImpl
this_param)
{
this_param.CompleteKeyExchange();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 16867, 16888);
return 0;
}


System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1571_16916_16986(System.Management.Automation.RemoteSessionEvent
stateEvent)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 16916, 16986);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_17005_17032()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 17005, 17032);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1571_17005_17045(System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
this_param)
{
var return_v = this_param.StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 17005, 17045);
return return_v;
}


int
f_1571_17005_17062(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 17005, 17062);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1571,15982,17089);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,15982,17089);
}
		}

private void HandlePublicKeyRequestReceived(object sender, RemoteDataEventArgs<string> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1571,17367,17883);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,17489,17872) || true) && (f_1571_17493_17539(f_1571_17493_17533(f_1571_17493_17520()))== RemoteSessionState.Established)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1571,17489,17872);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,17607,17742);

RemoteSessionStateMachineEventArgs 
args =
f_1571_17670_17741(RemoteSessionEvent.KeyRequested)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,17760,17818);

f_1571_17760_17817(f_1571_17760_17800(f_1571_17760_17787()), args);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,17838,17857);

f_1571_17838_17856(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1571,17489,17872);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1571,17367,17883);

System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_17493_17520()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 17493, 17520);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1571_17493_17533(System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
this_param)
{
var return_v = this_param.StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 17493, 17533);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1571_17493_17539(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 17493, 17539);
return return_v;
}


System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1571_17670_17741(System.Management.Automation.RemoteSessionEvent
stateEvent)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 17670, 17741);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_17760_17787()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 17760, 17787);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1571_17760_17800(System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
this_param)
{
var return_v = this_param.StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 17760, 17800);
return return_v;
}


int
f_1571_17760_17817(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 17760, 17817);
return 0;
}


int
f_1571_17838_17856(System.Management.Automation.Remoting.ClientRemoteSessionImpl
this_param)
{
this_param.StartKeyExchange();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 17838, 17856);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1571,17367,17883);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,17367,17883);
}
		}

private ManualResetEvent _waitHandleForConfigurationReceived;

private void HandleNegotiationReceived(object sender, RemoteSessionNegotiationEventArgs arg)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1571,18347,19828);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,18464,19817);
using(f_1571_18471_18499(s_trace))            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,18533,18661) || true) && (arg == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1571,18533,18661);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,18590,18642);

throw f_1571_18596_18641("arg");
DynAbs.Tracing.TraceSender.TraceExitCondition(1571,18533,18661);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,18681,18829) || true) && (f_1571_18685_18712(arg)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1571,18681,18829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,18762,18810);

throw f_1571_18768_18809("arg");
DynAbs.Tracing.TraceSender.TraceExitCondition(1571,18681,18829);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,18849,18904);

f_1571_18849_18856().ServerCapability = f_1571_18876_18903(arg);

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,19051,19107);

f_1571_19051_19106(this, f_1571_19081_19105(f_1571_19081_19088()));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,19131,19272);

RemoteSessionStateMachineEventArgs 
negotiationCompletedArg = f_1571_19192_19271(RemoteSessionEvent.NegotiationCompleted)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,19294,19371);

f_1571_19294_19370(f_1571_19294_19334(f_1571_19294_19321()), negotiationCompletedArg);
                }
                catch (PSRemotingDataStructureException dse)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1571,19408,19802);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,19493,19687);

RemoteSessionStateMachineEventArgs 
negotiationFailedArg =
f_1571_19576_19686(RemoteSessionEvent.NegotiationFailed, dse)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,19709,19783);

f_1571_19709_19782(f_1571_19709_19749(f_1571_19709_19736()), negotiationFailedArg);
DynAbs.Tracing.TraceSender.TraceExitCatch(1571,19408,19802);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(1571,18464,19817);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1571,18347,19828);

System.IDisposable
f_1571_18471_18499(System.Management.Automation.PSTraceSource
this_param)
{
var return_v = this_param.TraceEventHandlers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 18471, 18499);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1571_18596_18641(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 18596, 18641);
return return_v;
}


System.Management.Automation.Remoting.RemoteSessionCapability
f_1571_18685_18712(System.Management.Automation.RemoteSessionNegotiationEventArgs
this_param)
{
var return_v = this_param.RemoteSessionCapability ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 18685, 18712);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1571_18768_18809(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 18768, 18809);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionContext
f_1571_18849_18856()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 18849, 18856);
return return_v;
}


System.Management.Automation.Remoting.RemoteSessionCapability
f_1571_18876_18903(System.Management.Automation.RemoteSessionNegotiationEventArgs
this_param)
{
var return_v = this_param.RemoteSessionCapability;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 18876, 18903);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionContext
f_1571_19081_19088()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 19081, 19088);
return return_v;
}


System.Management.Automation.Remoting.RemoteSessionCapability
f_1571_19081_19105(System.Management.Automation.Remoting.ClientRemoteSessionContext
this_param)
{
var return_v = this_param.ServerCapability;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 19081, 19105);
return return_v;
}


bool
f_1571_19051_19106(System.Management.Automation.Remoting.ClientRemoteSessionImpl
this_param,System.Management.Automation.Remoting.RemoteSessionCapability
serverRemoteSessionCapability)
{
var return_v = this_param.RunClientNegotiationAlgorithm( serverRemoteSessionCapability);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 19051, 19106);
return return_v;
}


System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1571_19192_19271(System.Management.Automation.RemoteSessionEvent
stateEvent)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 19192, 19271);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_19294_19321()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 19294, 19321);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1571_19294_19334(System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
this_param)
{
var return_v = this_param.StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 19294, 19334);
return return_v;
}


int
f_1571_19294_19370(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 19294, 19370);
return 0;
}


System.Management.Automation.RemoteSessionStateMachineEventArgs
f_1571_19576_19686(System.Management.Automation.RemoteSessionEvent
stateEvent,System.Management.Automation.Remoting.PSRemotingDataStructureException
reason)
{
var return_v = new System.Management.Automation.RemoteSessionStateMachineEventArgs( stateEvent, (System.Exception)reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 19576, 19686);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_19709_19736()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 19709, 19736);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1571_19709_19749(System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
this_param)
{
var return_v = this_param.StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 19709, 19749);
return return_v;
}


int
f_1571_19709_19782(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param,System.Management.Automation.RemoteSessionStateMachineEventArgs
arg)
{
this_param.RaiseEvent( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 19709, 19782);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1571,18347,19828);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,18347,19828);
}
		}

private bool RunClientNegotiationAlgorithm(RemoteSessionCapability serverRemoteSessionCapability)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1571,20715,24275);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,20837,20931);

f_1571_20837_20930(serverRemoteSessionCapability != null, "server capability cache must be non-null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,20985,21063);

Version 
serverProtocolVersion = f_1571_21017_21062(serverRemoteSessionCapability)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,21077,21124);

_serverProtocolVersion = serverProtocolVersion;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,21138,21211);

Version 
clientProtocolVersion = f_1571_21170_21210(f_1571_21170_21194(f_1571_21170_21177()))
;

if (
(DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,21227,22754) || true) && (f_1571_21249_21300(                clientProtocolVersion, serverProtocolVersion)||(DynAbs.Tracing.TraceSender.Expression_False(1571, 21249, 21477)||(clientProtocolVersion == RemotingConstants.ProtocolVersionWin7RTM &&(DynAbs.Tracing.TraceSender.Expression_True(1571, 21322, 21476)&&                    serverProtocolVersion == RemotingConstants.ProtocolVersionWin7RC))
)||(DynAbs.Tracing.TraceSender.Expression_False(1571, 21249, 21770)||(clientProtocolVersion == RemotingConstants.ProtocolVersionWin8RTM &&(DynAbs.Tracing.TraceSender.Expression_True(1571, 21499, 21769)&&                    (serverProtocolVersion == RemotingConstants.ProtocolVersionWin7RC ||(DynAbs.Tracing.TraceSender.Expression_False(1571, 21590, 21745)||                     serverProtocolVersion == RemotingConstants.ProtocolVersionWin7RTM
)                     )))
)||(DynAbs.Tracing.TraceSender.Expression_False(1571, 21249, 22155)||(clientProtocolVersion == RemotingConstants.ProtocolVersionWin10RTM &&(DynAbs.Tracing.TraceSender.Expression_True(1571, 21792, 22154)&&                    (serverProtocolVersion == RemotingConstants.ProtocolVersionWin7RC ||(DynAbs.Tracing.TraceSender.Expression_False(1571, 21884, 22039)||                     serverProtocolVersion == RemotingConstants.ProtocolVersionWin7RTM )||(DynAbs.Tracing.TraceSender.Expression_False(1571, 21884, 22130)||                     serverProtocolVersion == RemotingConstants.ProtocolVersionWin8RTM
)                     )))
))
                 )

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1571,21227,22754);
DynAbs.Tracing.TraceSender.TraceExitCondition(1571,21227,22754);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1571,21227,22754);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,22301,22699);

PSRemotingDataStructureException 
reasonOfFailure =
f_1571_22373_22698(f_1571_22410_22456(), RemoteDataNameStrings.PS_STARTUP_PROTOCOL_VERSION_NAME, serverProtocolVersion, f_1571_22612_22637(), RemotingConstants.ProtocolVersion)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,22717,22739);

throw reasonOfFailure;
DynAbs.Tracing.TraceSender.TraceExitCondition(1571,21227,22754);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,22802,22868);

Version 
serverPSVersion = f_1571_22828_22867(serverRemoteSessionCapability)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,22882,22943);

Version 
clientPSVersion = f_1571_22908_22942(f_1571_22908_22932(f_1571_22908_22915()))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,22957,23470) || true) && (!f_1571_22962_23001(clientPSVersion, serverPSVersion))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1571,22957,23470);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,23035,23415);

PSRemotingDataStructureException 
reasonOfFailure =
f_1571_23107_23414(f_1571_23144_23190(), RemoteDataNameStrings.PSVersion, f_1571_23275_23301(                        serverPSVersion), f_1571_23328_23353(), RemotingConstants.ProtocolVersion)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,23433,23455);

throw reasonOfFailure;
DynAbs.Tracing.TraceSender.TraceExitCondition(1571,22957,23470);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,23530,23608);

Version 
serverSerVersion = f_1571_23557_23607(serverRemoteSessionCapability)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,23622,23695);

Version 
clientSerVersion = f_1571_23649_23694(f_1571_23649_23673(f_1571_23649_23656()))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,23709,24236) || true) && (!f_1571_23714_23755(clientSerVersion, serverSerVersion))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1571,23709,24236);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,23789,24181);

PSRemotingDataStructureException 
reasonOfFailure =
f_1571_23861_24180(f_1571_23898_23944(), RemoteDataNameStrings.SerializationVersion, f_1571_24040_24067(                        serverSerVersion), f_1571_24094_24119(), RemotingConstants.ProtocolVersion)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,24199,24221);

throw reasonOfFailure;
DynAbs.Tracing.TraceSender.TraceExitCondition(1571,23709,24236);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,24252,24264);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1571,20715,24275);

int
f_1571_20837_20930(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 20837, 20930);
return 0;
}


System.Version
f_1571_21017_21062(System.Management.Automation.Remoting.RemoteSessionCapability
this_param)
{
var return_v = this_param.ProtocolVersion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 21017, 21062);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionContext
f_1571_21170_21177()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 21170, 21177);
return return_v;
}


System.Management.Automation.Remoting.RemoteSessionCapability
f_1571_21170_21194(System.Management.Automation.Remoting.ClientRemoteSessionContext
this_param)
{
var return_v = this_param.ClientCapability;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 21170, 21194);
return return_v;
}


System.Version
f_1571_21170_21210(System.Management.Automation.Remoting.RemoteSessionCapability
this_param)
{
var return_v = this_param.ProtocolVersion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 21170, 21210);
return return_v;
}


bool
f_1571_21249_21300(System.Version
this_param,System.Version
obj)
{
var return_v = this_param.Equals( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 21249, 21300);
return return_v;
}


string
f_1571_22410_22456()
{
var return_v = RemotingErrorIdStrings.ClientNegotiationFailed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 22410, 22456);
return return_v;
}


string
f_1571_22612_22637()
{
var return_v =                         PSVersionInfo.GitCommitId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 22612, 22637);
return return_v;
}


System.Management.Automation.Remoting.PSRemotingDataStructureException
f_1571_22373_22698(string
resourceString,params object[]
args)
{
var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 22373, 22698);
return return_v;
}


System.Version
f_1571_22828_22867(System.Management.Automation.Remoting.RemoteSessionCapability
this_param)
{
var return_v = this_param.PSVersion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 22828, 22867);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionContext
f_1571_22908_22915()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 22908, 22915);
return return_v;
}


System.Management.Automation.Remoting.RemoteSessionCapability
f_1571_22908_22932(System.Management.Automation.Remoting.ClientRemoteSessionContext
this_param)
{
var return_v = this_param.ClientCapability;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 22908, 22932);
return return_v;
}


System.Version
f_1571_22908_22942(System.Management.Automation.Remoting.RemoteSessionCapability
this_param)
{
var return_v = this_param.PSVersion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 22908, 22942);
return return_v;
}


bool
f_1571_22962_23001(System.Version
this_param,System.Version
obj)
{
var return_v = this_param.Equals( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 22962, 23001);
return return_v;
}


string
f_1571_23144_23190()
{
var return_v = RemotingErrorIdStrings.ClientNegotiationFailed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 23144, 23190);
return return_v;
}


string
f_1571_23275_23301(System.Version
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 23275, 23301);
return return_v;
}


string
f_1571_23328_23353()
{
var return_v =                         PSVersionInfo.GitCommitId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 23328, 23353);
return return_v;
}


System.Management.Automation.Remoting.PSRemotingDataStructureException
f_1571_23107_23414(string
resourceString,params object[]
args)
{
var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 23107, 23414);
return return_v;
}


System.Version
f_1571_23557_23607(System.Management.Automation.Remoting.RemoteSessionCapability
this_param)
{
var return_v = this_param.SerializationVersion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 23557, 23607);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionContext
f_1571_23649_23656()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 23649, 23656);
return return_v;
}


System.Management.Automation.Remoting.RemoteSessionCapability
f_1571_23649_23673(System.Management.Automation.Remoting.ClientRemoteSessionContext
this_param)
{
var return_v = this_param.ClientCapability;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 23649, 23673);
return return_v;
}


System.Version
f_1571_23649_23694(System.Management.Automation.Remoting.RemoteSessionCapability
this_param)
{
var return_v = this_param.SerializationVersion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 23649, 23694);
return return_v;
}


bool
f_1571_23714_23755(System.Version
this_param,System.Version
obj)
{
var return_v = this_param.Equals( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 23714, 23755);
return return_v;
}


string
f_1571_23898_23944()
{
var return_v = RemotingErrorIdStrings.ClientNegotiationFailed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 23898, 23944);
return return_v;
}


string
f_1571_24040_24067(System.Version
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 24040, 24067);
return return_v;
}


string
f_1571_24094_24119()
{
var return_v =                         PSVersionInfo.GitCommitId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 24094, 24119);
return return_v;
}


System.Management.Automation.Remoting.PSRemotingDataStructureException
f_1571_23861_24180(string
resourceString,params object[]
args)
{
var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 23861, 24180);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1571,20715,24275);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,20715,24275);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override RemotingDestination MySelf {get; }

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1571,24504,24617);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,24550,24564);

f_1571_24550_24563(this, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,24580,24606);

f_1571_24580_24605(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1571,24504,24617);

int
f_1571_24550_24563(System.Management.Automation.Remoting.ClientRemoteSessionImpl
this_param,bool
disposing)
{
this_param.Dispose( disposing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 24550, 24563);
return 0;
}


int
f_1571_24580_24605(System.Management.Automation.Remoting.ClientRemoteSessionImpl
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 24580, 24605);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1571,24504,24617);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,24504,24617);
}
		}

public void Dispose(bool disposing)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1571,24797,25377);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,24857,25366) || true) && (disposing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1571,24857,25366);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,24904,25123) || true) && (_waitHandleForConfigurationReceived != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1571,24904,25123);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,24993,25039);

f_1571_24993_25038(                    _waitHandleForConfigurationReceived);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,25061,25104);

_waitHandleForConfigurationReceived = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1571,24904,25123);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,25143,25217);

f_1571_25143_25216(
                ((ClientRemoteSessionDSHandlerImpl)f_1571_25178_25205()));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,25235,25270);

SessionDataStructureHandler = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,25288,25312);

f_1571_25288_25311(                _cryptoHelper);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,25330,25351);

_cryptoHelper = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1571,24857,25366);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1571,24797,25377);

int
f_1571_24993_25038(System.Threading.ManualResetEvent
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 24993, 25038);
return 0;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_25178_25205()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 25178, 25205);
return return_v;
}


int
f_1571_25143_25216(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerImpl
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 25143, 25216);
return 0;
}


int
f_1571_25288_25311(System.Management.Automation.Internal.PSRemotingCryptoHelperClient
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 25288, 25311);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1571,24797,25377);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,24797,25377);
}
		}

static ClientRemoteSessionImpl()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1571,6234,25418);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1571,6429,6506);
s_trace = f_1571_6439_6506("CRSessionImpl", "ClientRemoteSessionImpl");DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1571,6234,25418);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1571,6234,25418);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1571,6234,25418);

static System.Management.Automation.PSTraceSource
f_1571_6439_6506(string
name,string
description)
{
var return_v = PSTraceSource.GetTracer( name, description);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 6439, 6506);
return return_v;
}


int
f_1571_7102_7159(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 7102, 7159);
return 0;
}


System.Management.Automation.Remoting.ClientRemoteSessionContext
f_1571_7229_7236()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 7229, 7236);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1571_7315_7336(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 7315, 7336);
return return_v;
}


System.Uri
f_1571_7253_7377(System.Management.Automation.Runspaces.RunspaceConnectionInfo
rsCI,string
property,System.Uri
defaultValue)
{
var return_v = WSManConnectionInfo.ExtractPropertyAsWsManConnectionInfo<Uri>( rsCI, property, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 7253, 7377);
return return_v;
}


System.Management.Automation.Internal.PSRemotingCryptoHelperClient
f_1571_7408_7442()
{
var return_v = new System.Management.Automation.Internal.PSRemotingCryptoHelperClient();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 7408, 7442);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionContext
f_1571_7500_7507()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 7500, 7507);
return return_v;
}


System.Management.Automation.Remoting.RemoteSessionCapability
f_1571_7527_7575()
{
var return_v = RemoteSessionCapability.CreateClientCapability();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 7527, 7575);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionContext
f_1571_7590_7597()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 7590, 7597);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1571_7615_7636(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 7615, 7636);
return return_v;
}


System.Management.Automation.PSCredential
f_1571_7615_7647(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 7615, 7647);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionContext
f_1571_7849_7856()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 7849, 7856);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1571_7934_7955(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 7934, 7955);
return return_v;
}


string
f_1571_7869_7999(System.Management.Automation.Runspaces.RunspaceConnectionInfo
rsCI,string
property,string
defaultValue)
{
var return_v = WSManConnectionInfo.ExtractPropertyAsWsManConnectionInfo<string>( rsCI, property, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 7869, 7999);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1571_8259_8280(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 8259, 8280);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerImpl
f_1571_8167_8321(System.Management.Automation.Remoting.ClientRemoteSessionImpl
session,System.Management.Automation.Internal.PSRemotingCryptoHelperClient
cryptoHelper,System.Management.Automation.Runspaces.RunspaceConnectionInfo
connectionInfo,System.Management.Automation.Remoting.ClientRemoteSession.URIDirectionReported
uriRedirectionHandler)
{
var return_v = new System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerImpl( (System.Management.Automation.Remoting.ClientRemoteSession)session, (System.Management.Automation.Internal.PSRemotingCryptoHelper)cryptoHelper, connectionInfo, uriRedirectionHandler);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 8167, 8321);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_8370_8397()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 8370, 8397);
return return_v;
}


System.Threading.ManualResetEvent
f_1571_8450_8477(bool
initialState)
{
var return_v = new System.Threading.ManualResetEvent( initialState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1571, 8450, 8477);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_8583_8610()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 8583, 8610);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_8674_8701()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 8674, 8701);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_8771_8798()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 8771, 8798);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1571_8942_8969()
{
var return_v = SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1571, 8942, 8969);
return return_v;
}

}
}

