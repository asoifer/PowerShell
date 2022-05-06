// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation.Host;
using System.Management.Automation.Remoting;
using System.Management.Automation.Remoting.Client;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Runspaces.Internal;
using System.Management.Automation.Tracing;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Internal
{
internal class ClientRunspacePoolDataStructureHandler : IDisposable
{
private bool _reconnecting ;

internal ClientRunspacePoolDataStructureHandler(RemoteRunspacePoolInternal clientRunspacePool,
            TypeTable typeTable)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1584,1284,2584);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,852,873);
this._reconnecting = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,37927,37953);
this._syncObject = f_1584_37941_37953();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,37977,38006);
this._createRunspaceCalled = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,38035,38049);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,38072,38085);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,38108,38121);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,38147,38152);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,38193,38214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,38288,38395);
this._associatedPowerShellDSHandlers = f_1584_38335_38395();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,38544,38581);
this._associationSyncObject = f_1584_38569_38581();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,38688,38705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,38834,38861);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,39102,39166);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,1437,1491);

_clientRunspacePoolId = f_1584_1461_1490(clientRunspacePool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,1505,1558);

_minRunspaces = f_1584_1521_1557(clientRunspacePool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,1572,1625);

_maxRunspaces = f_1584_1588_1624(clientRunspacePool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,1639,1671);

_host = f_1584_1647_1670(clientRunspacePool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,1685,1749);

_applicationArguments = f_1584_1709_1748(clientRunspacePool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,1763,1825);

RemoteSession = f_1584_1779_1824(this, clientRunspacePool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,1931,2010);

_transportManager = f_1584_1951_2009(f_1584_1951_1992(f_1584_1951_1964()));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,2024,2064);

_transportManager.TypeTable = typeTable;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,2078,2232);

f_1584_2078_2091().StateChanged +=
                new EventHandler<RemoteSessionStateEventArgs>(
                    HandleClientRemoteSessionStateChanged);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,2246,2268);

_reconnecting = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,2284,2431);

_transportManager.RobustConnectionNotification +=
                new EventHandler<ConnectionStatusEventArgs>(HandleRobustConnectionNotification);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,2447,2573);

_transportManager.CreateCompleted +=
                new EventHandler<CreateCompleteEventArgs>(HandleSessionCreateCompleted);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1584,1284,2584);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,1284,2584);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,1284,2584);
}
		}

internal void CreateRunspacePoolAndOpenAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,2822,3333);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,2939,3144);

f_1584_2939_3143(f_1584_2950_3010(f_1584_2950_3004(f_1584_2950_2991(f_1584_2950_2963())))== RemoteSessionState.Idle, "State of ClientRemoteSession is expected to be idle before connection is established");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,3158,3186);

f_1584_3158_3185(f_1584_3158_3171());
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,2822,3333);

System.Management.Automation.Remoting.ClientRemoteSession
f_1584_2950_2963()
{
var return_v = RemoteSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 2950, 2963);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1584_2950_2991(System.Management.Automation.Remoting.ClientRemoteSession
this_param)
{
var return_v = this_param.SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 2950, 2991);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1584_2950_3004(System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
this_param)
{
var return_v = this_param.StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 2950, 3004);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1584_2950_3010(System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 2950, 3010);
return return_v;
}


int
f_1584_2939_3143(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 2939, 3143);
return 0;
}


System.Management.Automation.Remoting.ClientRemoteSession
f_1584_3158_3171()
{
var return_v = RemoteSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 3158, 3171);
return return_v;
}


int
f_1584_3158_3185(System.Management.Automation.Remoting.ClientRemoteSession
this_param)
{
this_param.CreateAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 3158, 3185);
return 0;
}


            // #2: send the message for runspace pool creation
            // this is done in HandleClientRemoteSessionStateChanged
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,2822,3333);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,2822,3333);
}
		}

internal void CloseRunspacePoolAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,3453,3554);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,3516,3543);

f_1584_3516_3542(f_1584_3516_3529());
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,3453,3554);

System.Management.Automation.Remoting.ClientRemoteSession
f_1584_3516_3529()
{
var return_v = RemoteSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 3516, 3529);
return return_v;
}


int
f_1584_3516_3542(System.Management.Automation.Remoting.ClientRemoteSession
this_param)
{
this_param.CloseAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 3516, 3542);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,3453,3554);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,3453,3554);
}
		}

internal void DisconnectPoolAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,3681,3888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,3846,3877);

f_1584_3846_3876(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,3681,3888);

int
f_1584_3846_3876(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param)
{
this_param.PrepareForAndStartDisconnect();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 3846, 3876);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,3681,3888);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,3681,3888);
}
		}

internal void ReconnectPoolAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,4014,4240);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,4129,4150);

_reconnecting = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,4164,4184);

f_1584_4164_4183(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,4198,4229);

f_1584_4198_4228(f_1584_4198_4211());
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,4014,4240);

int
f_1584_4164_4183(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param)
{
this_param.PrepareForConnect();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 4164, 4183);
return 0;
}


System.Management.Automation.Remoting.ClientRemoteSession
f_1584_4198_4211()
{
var return_v = RemoteSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 4198, 4211);
return return_v;
}


int
f_1584_4198_4228(System.Management.Automation.Remoting.ClientRemoteSession
this_param)
{
this_param.ReconnectAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 4198, 4228);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,4014,4240);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,4014,4240);
}
		}

internal void ConnectPoolAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,4370,4501);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,4427,4447);

f_1584_4427_4446(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,4461,4490);

f_1584_4461_4489(f_1584_4461_4474());
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,4370,4501);

int
f_1584_4427_4446(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param)
{
this_param.PrepareForConnect();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 4427, 4446);
return 0;
}


System.Management.Automation.Remoting.ClientRemoteSession
f_1584_4461_4474()
{
var return_v = RemoteSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 4461, 4474);
return return_v;
}


int
f_1584_4461_4489(System.Management.Automation.Remoting.ClientRemoteSession
this_param)
{
this_param.ConnectAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 4461, 4489);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,4370,4501);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,4370,4501);
}
		}

internal void ProcessReceivedData(RemoteDataObject<PSObject> receivedData)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,4713,8963);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,4892,5171) || true) && (f_1584_4896_4923(receivedData)!= _clientRunspacePoolId)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,4892,5171);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,4982,5156);

throw f_1584_4988_5155(f_1584_5025_5069(), f_1584_5104_5131(receivedData), _clientRunspacePoolId);
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,4892,5171);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,5252,5401);

f_1584_5252_5400(f_1584_5263_5291(receivedData)== RemotingTargetInterface.RunspacePool, "Target interface is expected to be RunspacePool");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,5417,8952);

switch (f_1584_5425_5446(receivedData))
            {

case RemotingDataType.RemoteHostCallUsingRunspaceHost:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,5417,8952);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,5583,5739);

f_1584_5583_5738(RemoteHostCallReceived != null, "RemoteRunspacePoolInternal should subscribe to all data structure handler events");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,5767,5840);

RemoteHostCall 
remoteHostCall = f_1584_5799_5839(f_1584_5821_5838(receivedData))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,5866,5963);

f_1584_5866_5962(                        RemoteHostCallReceived, this, f_1584_5906_5961(remoteHostCall));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1584,6010,6016);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,5417,8952);

case RemotingDataType.RunspacePoolInitData:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,5417,8952);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,6128,6219);

RunspacePoolInitInfo 
initInfo = f_1584_6160_6218(f_1584_6200_6217(receivedData))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,6247,6403);

f_1584_6247_6402(RSPoolInitInfoReceived != null, "RemoteRunspacePoolInternal should subscribe to all data structure handler events");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,6429,6555);

f_1584_6429_6554(                        RSPoolInitInfoReceived, this, f_1584_6498_6553(initInfo));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1584,6602,6608);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,5417,8952);

case RemotingDataType.RunspacePoolStateInfo:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,5417,8952);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,6721,6844);

RunspacePoolStateInfo 
stateInfo =
f_1584_6784_6843(f_1584_6825_6842(receivedData))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,6872,7023);

f_1584_6872_7022(StateInfoReceived != null, "RemoteRunspacePoolInternal should subscribe to all data structure handler events");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,7049,7172);

f_1584_7049_7171(                        StateInfoReceived, this, f_1584_7113_7170(stateInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,7200,7239);

f_1584_7200_7238(this, stateInfo);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1584,7286,7292);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,5417,8952);

case RemotingDataType.ApplicationPrivateData:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,5417,8952);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,7406,7514);

PSPrimitiveDictionary 
applicationPrivateData = f_1584_7453_7513(f_1584_7495_7512(receivedData))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,7540,7704);

f_1584_7540_7703(ApplicationPrivateDataReceived != null, "RemoteRunspacePoolInternal should subscribe to all data structure handler events");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,7730,7879);

f_1584_7730_7878(                        ApplicationPrivateDataReceived, this, f_1584_7807_7877(applicationPrivateData));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1584,7926,7932);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,5417,8952);

case RemotingDataType.RunspacePoolOperationResponse:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,5417,8952);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,8053,8221);

f_1584_8053_8220(SetMaxMinRunspacesResponseReceived != null, "RemoteRunspacePoolInternal should subscribe to all data structure handler events");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,8249,8355);

f_1584_8249_8354(
                        SetMaxMinRunspacesResponseReceived, this, f_1584_8301_8353(f_1584_8335_8352(receivedData)));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1584,8402,8408);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,5417,8952);

case RemotingDataType.PSEventArgs:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,5417,8952);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,8511,8587);

PSEventArgs 
psEventArgs = f_1584_8537_8586(f_1584_8568_8585(receivedData))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,8615,8768);

f_1584_8615_8767(PSEventArgsReceived != null, "RemoteRunspacePoolInternal should subscribe to all data structure handler events");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,8796,8884);

f_1584_8796_8883(
                        PSEventArgsReceived, this, f_1584_8833_8882(psEventArgs));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1584,8931,8937);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,5417,8952);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,4713,8963);

System.Guid
f_1584_4896_4923(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.RunspacePoolId ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 4896, 4923);
return return_v;
}


string
f_1584_5025_5069()
{
var return_v = RemotingErrorIdStrings.RunspaceIdsDoNotMatch;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 5025, 5069);
return return_v;
}


System.Guid
f_1584_5104_5131(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.RunspacePoolId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 5104, 5131);
return return_v;
}


System.Management.Automation.Remoting.PSRemotingDataStructureException
f_1584_4988_5155(string
resourceString,params object[]
args)
{
var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 4988, 5155);
return return_v;
}


System.Management.Automation.RemotingTargetInterface
f_1584_5263_5291(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.TargetInterface ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 5263, 5291);
return return_v;
}


int
f_1584_5252_5400(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 5252, 5400);
return 0;
}


System.Management.Automation.RemotingDataType
f_1584_5425_5446(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.DataType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 5425, 5446);
return return_v;
}


int
f_1584_5583_5738(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 5583, 5738);
return 0;
}


System.Management.Automation.PSObject
f_1584_5821_5838(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 5821, 5838);
return return_v;
}


System.Management.Automation.Remoting.RemoteHostCall
f_1584_5799_5839(System.Management.Automation.PSObject
data)
{
var return_v = RemoteHostCall.Decode( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 5799, 5839);
return return_v;
}


System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>
f_1584_5906_5961(System.Management.Automation.Remoting.RemoteHostCall
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 5906, 5961);
return return_v;
}


int
f_1584_5866_5962(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>>
eventHandler,System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 5866, 5962);
return 0;
}


System.Management.Automation.PSObject
f_1584_6200_6217(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 6200, 6217);
return return_v;
}


System.Management.Automation.Remoting.RunspacePoolInitInfo
f_1584_6160_6218(System.Management.Automation.PSObject
dataAsPSObject)
{
var return_v = RemotingDecoder.GetRunspacePoolInitInfo( dataAsPSObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 6160, 6218);
return return_v;
}


int
f_1584_6247_6402(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 6247, 6402);
return 0;
}


System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RunspacePoolInitInfo>
f_1584_6498_6553(System.Management.Automation.Remoting.RunspacePoolInitInfo
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RunspacePoolInitInfo>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 6498, 6553);
return return_v;
}


int
f_1584_6429_6554(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RunspacePoolInitInfo>>
eventHandler,System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RunspacePoolInitInfo>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RunspacePoolInitInfo>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 6429, 6554);
return 0;
}


System.Management.Automation.PSObject
f_1584_6825_6842(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 6825, 6842);
return return_v;
}


System.Management.Automation.RunspacePoolStateInfo
f_1584_6784_6843(System.Management.Automation.PSObject
dataAsPSObject)
{
var return_v = RemotingDecoder.GetRunspacePoolStateInfo( dataAsPSObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 6784, 6843);
return return_v;
}


int
f_1584_6872_7022(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 6872, 7022);
return 0;
}


System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.RunspacePoolStateInfo>
f_1584_7113_7170(System.Management.Automation.RunspacePoolStateInfo
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.RunspacePoolStateInfo>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 7113, 7170);
return return_v;
}


int
f_1584_7049_7171(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.RunspacePoolStateInfo>>
eventHandler,System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.RunspacePoolStateInfo>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.RunspacePoolStateInfo>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 7049, 7171);
return 0;
}


int
f_1584_7200_7238(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,System.Management.Automation.RunspacePoolStateInfo
stateInfo)
{
this_param.NotifyAssociatedPowerShells( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 7200, 7238);
return 0;
}


System.Management.Automation.PSObject
f_1584_7495_7512(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 7495, 7512);
return return_v;
}


System.Management.Automation.PSPrimitiveDictionary
f_1584_7453_7513(System.Management.Automation.PSObject
dataAsPSObject)
{
var return_v = RemotingDecoder.GetApplicationPrivateData( dataAsPSObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 7453, 7513);
return return_v;
}


int
f_1584_7540_7703(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 7540, 7703);
return 0;
}


System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSPrimitiveDictionary>
f_1584_7807_7877(System.Management.Automation.PSPrimitiveDictionary
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSPrimitiveDictionary>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 7807, 7877);
return return_v;
}


int
f_1584_7730_7878(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSPrimitiveDictionary>>
eventHandler,System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSPrimitiveDictionary>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSPrimitiveDictionary>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 7730, 7878);
return 0;
}


int
f_1584_8053_8220(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 8053, 8220);
return 0;
}


System.Management.Automation.PSObject
f_1584_8335_8352(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 8335, 8352);
return return_v;
}


System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>
f_1584_8301_8353(System.Management.Automation.PSObject
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 8301, 8353);
return return_v;
}


int
f_1584_8249_8354(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>>
eventHandler,System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 8249, 8354);
return 0;
}


System.Management.Automation.PSObject
f_1584_8568_8585(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 8568, 8585);
return return_v;
}


System.Management.Automation.PSEventArgs
f_1584_8537_8586(System.Management.Automation.PSObject
dataAsPSObject)
{
var return_v = RemotingDecoder.GetPSEventArgs( dataAsPSObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 8537, 8586);
return return_v;
}


int
f_1584_8615_8767(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 8615, 8767);
return 0;
}


System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSEventArgs>
f_1584_8833_8882(System.Management.Automation.PSEventArgs
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSEventArgs>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 8833, 8882);
return return_v;
}


int
f_1584_8796_8883(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSEventArgs>>
eventHandler,System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSEventArgs>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSEventArgs>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 8796, 8883);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,4713,8963);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,4713,8963);
}
		}

internal ClientPowerShellDataStructureHandler CreatePowerShellDataStructureHandler(
            ClientRemotePowerShell shell)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,9298,9775);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,9449,9621);

BaseClientCommandTransportManager 
clientTransportMgr =
f_1584_9521_9620(f_1584_9521_9562(f_1584_9521_9534()), shell, f_1584_9606_9619(shell))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,9637,9764);

return f_1584_9644_9763(clientTransportMgr, _clientRunspacePoolId, f_1584_9746_9762(shell));
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,9298,9775);

System.Management.Automation.Remoting.ClientRemoteSession
f_1584_9521_9534()
{
var return_v = RemoteSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 9521, 9534);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1584_9521_9562(System.Management.Automation.Remoting.ClientRemoteSession
this_param)
{
var return_v = this_param.SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 9521, 9562);
return return_v;
}


bool
f_1584_9606_9619(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param)
{
var return_v = this_param.NoInput;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 9606, 9619);
return return_v;
}


System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
f_1584_9521_9620(System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
this_param,System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
cmd,bool
noInput)
{
var return_v = this_param.CreateClientCommandTransportManager( cmd, noInput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 9521, 9620);
return return_v;
}


System.Guid
f_1584_9746_9762(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 9746, 9762);
return return_v;
}


System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
f_1584_9644_9763(System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
transportManager,System.Guid
clientRunspacePoolId,System.Guid
clientPowerShellId)
{
var return_v = new System.Management.Automation.Internal.ClientPowerShellDataStructureHandler( transportManager, clientRunspacePoolId, clientPowerShellId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 9644, 9763);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,9298,9775);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,9298,9775);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void CreatePowerShellOnServerAndInvoke(ClientRemotePowerShell shell)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,10028,11310);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,10213,10235);
            // add to associated powershell list and send request to server
            lock (_associationSyncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,10269,10351);

f_1584_10269_10350(                _associatedPowerShellDSHandlers, f_1584_10305_10321(shell), f_1584_10323_10349(shell));
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,10382,10489);

f_1584_10382_10408(shell).RemoveAssociation +=
                new EventHandler(HandleRemoveAssociation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,10693,10790);

bool 
invokeAndDisconnect = (DynAbs.Tracing.TraceSender.Conditional_F1(1584, 10720, 10744)||(((f_1584_10721_10735(shell)!= null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1584, 10747, 10781))||DynAbs.Tracing.TraceSender.Conditional_F3(1584, 10784, 10789)))?f_1584_10747_10781(f_1584_10747_10761(shell)):false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,10804,11007) || true) && (invokeAndDisconnect &&(DynAbs.Tracing.TraceSender.Expression_True(1584, 10808, 10858)&&f_1584_10831_10858_M(!EndpointSupportsDisconnect)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,10804,11007);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,10892,10992);

throw f_1584_10898_10991(f_1584_10935_10990());
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,10804,11007);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,11023,11173) || true) && (f_1584_11027_11040()== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,11023,11173);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,11082,11158);

throw f_1584_11088_11157("ClientRunspacePoolDataStructureHandler");
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,11023,11173);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,11189,11299);

f_1584_11189_11298(f_1584_11189_11215(shell), f_1584_11222_11276(f_1584_11222_11263(f_1584_11222_11235())), invokeAndDisconnect);
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,10028,11310);

System.Guid
f_1584_10305_10321(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 10305, 10321);
return return_v;
}


System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
f_1584_10323_10349(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param)
{
var return_v = this_param.DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 10323, 10349);
return return_v;
}


int
f_1584_10269_10350(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
this_param,System.Guid
key,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 10269, 10350);
return 0;
}


System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
f_1584_10382_10408(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param)
{
var return_v = this_param.DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 10382, 10408);
return return_v;
}


System.Management.Automation.PSInvocationSettings
f_1584_10721_10735(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param)
{
var return_v = this_param.Settings ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 10721, 10735);
return return_v;
}


System.Management.Automation.PSInvocationSettings
f_1584_10747_10761(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param)
{
var return_v = this_param.Settings;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 10747, 10761);
return return_v;
}


bool
f_1584_10747_10781(System.Management.Automation.PSInvocationSettings
this_param)
{
var return_v = this_param.InvokeAndDisconnect ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 10747, 10781);
return return_v;
}


bool
f_1584_10831_10858_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 10831, 10858);
return return_v;
}


string
f_1584_10935_10990()
{
var return_v = RemotingErrorIdStrings.EndpointDoesNotSupportDisconnect;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 10935, 10990);
return return_v;
}


System.Management.Automation.Remoting.PSRemotingDataStructureException
f_1584_10898_10991(string
message)
{
var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 10898, 10991);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSession
f_1584_11027_11040()
{
var return_v = RemoteSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 11027, 11040);
return return_v;
}


System.ObjectDisposedException
f_1584_11088_11157(string
objectName)
{
var return_v = new System.ObjectDisposedException( objectName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 11088, 11157);
return return_v;
}


System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
f_1584_11189_11215(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param)
{
var return_v = this_param.DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 11189, 11215);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSession
f_1584_11222_11235()
{
var return_v = RemoteSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 11222, 11235);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1584_11222_11263(System.Management.Automation.Remoting.ClientRemoteSession
this_param)
{
var return_v = this_param.SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 11222, 11263);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
f_1584_11222_11276(System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
this_param)
{
var return_v = this_param.StateMachine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 11222, 11276);
return return_v;
}


int
f_1584_11189_11298(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param,System.Management.Automation.Remoting.ClientRemoteSessionDSHandlerStateMachine
stateMachine,bool
inDisconnectMode)
{
this_param.Start( stateMachine, inDisconnectMode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 11189, 11298);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,10028,11310);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,10028,11310);
}
		}

internal void AddRemotePowerShellDSHandler(Guid psShellInstanceId, ClientPowerShellDataStructureHandler psDSHandler)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,11623,12071);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,11770,11792);
            lock (_associationSyncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,11889,11954);

_associatedPowerShellDSHandlers[psShellInstanceId] = psDSHandler;
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,11985,12060);

psDSHandler.RemoveAssociation += new EventHandler(HandleRemoveAssociation);
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,11623,12071);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,11623,12071);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,11623,12071);
}
		}

internal void DispatchMessageToPowerShell(RemoteDataObject<PSObject> rcvdData)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,12279,12804);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,12382,12515);

ClientPowerShellDataStructureHandler 
dsHandler =
f_1584_12448_12514(this, f_1584_12492_12513(rcvdData))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,12683,12793) || true) && (dsHandler != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,12683,12793);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,12738,12778);

f_1584_12738_12777(                dsHandler, rcvdData);
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,12683,12793);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,12279,12804);

System.Guid
f_1584_12492_12513(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.PowerShellId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 12492, 12513);
return return_v;
}


System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
f_1584_12448_12514(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,System.Guid
clientPowerShellId)
{
var return_v = this_param.GetAssociatedPowerShellDataStructureHandler( clientPowerShellId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 12448, 12514);
return return_v;
}


int
f_1584_12738_12777(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param,System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
receivedData)
{
this_param.ProcessReceivedData( receivedData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 12738, 12777);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,12279,12804);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,12279,12804);
}
		}

internal void SendHostResponseToServer(RemoteHostResponse hostResponse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,12992,13169);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,13088,13158);

f_1584_13088_13157(this, f_1584_13102_13123(hostResponse), DataPriorityType.PromptResponse);
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,12992,13169);

System.Management.Automation.PSObject
f_1584_13102_13123(System.Management.Automation.Remoting.RemoteHostResponse
this_param)
{
var return_v = this_param.Encode();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 13102, 13123);
return return_v;
}


int
f_1584_13088_13157(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,System.Management.Automation.PSObject
data,System.Management.Automation.Remoting.DataPriorityType
priority)
{
this_param.SendDataAsync( data, priority);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 13088, 13157);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,12992,13169);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,12992,13169);
}
		}

internal void SendResetRunspaceStateToServer(long callId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,13367,13617);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,13449,13567);

RemoteDataObject 
message =
f_1584_13493_13566(_clientRunspacePoolId, callId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,13583,13606);

f_1584_13583_13605(this, message);
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,13367,13617);

System.Management.Automation.Remoting.RemoteDataObject
f_1584_13493_13566(System.Guid
clientRunspacePoolId,long
callId)
{
var return_v = RemotingEncoder.GenerateResetRunspaceState( clientRunspacePoolId, callId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 13493, 13566);
return return_v;
}


int
f_1584_13583_13605(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,System.Management.Automation.Remoting.RemoteDataObject
data)
{
this_param.SendDataAsync( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 13583, 13605);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,13367,13617);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,13367,13617);
}
		}

internal void SendSetMaxRunspacesToServer(int maxRunspaces, long callId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,13937,14213);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,14034,14163);

RemoteDataObject 
message =
f_1584_14078_14162(_clientRunspacePoolId, maxRunspaces, callId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,14179,14202);

f_1584_14179_14201(this, message);
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,13937,14213);

System.Management.Automation.Remoting.RemoteDataObject
f_1584_14078_14162(System.Guid
clientRunspacePoolId,int
maxRunspaces,long
callId)
{
var return_v = RemotingEncoder.GenerateSetMaxRunspaces( clientRunspacePoolId, maxRunspaces, callId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 14078, 14162);
return return_v;
}


int
f_1584_14179_14201(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,System.Management.Automation.Remoting.RemoteDataObject
data)
{
this_param.SendDataAsync( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 14179, 14201);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,13937,14213);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,13937,14213);
}
		}

internal void SendSetMinRunspacesToServer(int minRunspaces, long callId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,14533,14809);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,14630,14759);

RemoteDataObject 
message =
f_1584_14674_14758(_clientRunspacePoolId, minRunspaces, callId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,14775,14798);

f_1584_14775_14797(this, message);
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,14533,14809);

System.Management.Automation.Remoting.RemoteDataObject
f_1584_14674_14758(System.Guid
clientRunspacePoolId,int
minRunspaces,long
callId)
{
var return_v = RemotingEncoder.GenerateSetMinRunspaces( clientRunspacePoolId, minRunspaces, callId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 14674, 14758);
return return_v;
}


int
f_1584_14775_14797(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,System.Management.Automation.Remoting.RemoteDataObject
data)
{
this_param.SendDataAsync( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 14775, 14797);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,14533,14809);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,14533,14809);
}
		}

internal void SendGetAvailableRunspacesToServer(long callId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,15054,15242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,15139,15231);

f_1584_15139_15230(this, f_1584_15153_15229(_clientRunspacePoolId, callId));
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,15054,15242);

System.Management.Automation.Remoting.RemoteDataObject
f_1584_15153_15229(System.Guid
clientRunspacePoolId,long
callId)
{
var return_v = RemotingEncoder.GenerateGetAvailableRunspaces( clientRunspacePoolId, callId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 15153, 15229);
return return_v;
}


int
f_1584_15139_15230(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,System.Management.Automation.Remoting.RemoteDataObject
data)
{
this_param.SendDataAsync( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 15139, 15230);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,15054,15242);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,15054,15242);
}
		}

        
        
        /// <summary>
        /// Event raised when a host call is received.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<RemoteHostCall>> 
RemoteHostCallReceived
;

        /// <summary>
        /// Event raised when state information is received.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<RunspacePoolStateInfo>> 
StateInfoReceived
;

        /// <summary>
        /// Event raised when RunspacePoolInitInfo is received. This is the first runspace pool message expected
        /// after connecting to an existing remote runspace pool. RemoteRunspacePoolInternal should use this
        /// notification to set the state of a reconstructed runspace to "Opened State" and use the
        /// minRunspace and MaxRunspaces information to set its state.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<RunspacePoolInitInfo>> 
RSPoolInitInfoReceived
;

        /// <summary>
        /// Event raised when application private data is received.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<PSPrimitiveDictionary>> 
ApplicationPrivateDataReceived
;

        /// <summary>
        /// Event raised when a PSEventArgs is received.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<PSEventArgs>> 
PSEventArgsReceived
;

        /// <summary>
        /// Event raised when the session is closed.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<Exception>> 
SessionClosed
;

        /// <summary>
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<Exception>> 
SessionDisconnected
;

        /// <summary>
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<Exception>> 
SessionReconnected
;

        /// <summary>
        /// Event raised when the session is closing.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<Exception>> 
SessionClosing
;

        /// <summary>
        /// Event raised when a response to a SetMaxRunspaces or SetMinRunspaces call
        /// is received.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<PSObject>> 
SetMaxMinRunspacesResponseReceived
;

        /// <summary>
        /// EventHandler used to report connection URI redirections to the application.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<Uri>> 
URIRedirectionReported
;

        /// <summary>
        /// Indicates that a disconnect has been initiated by the WinRM robust connections layer.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<Exception>> 
SessionRCDisconnecting
;

        /// <summary>
        /// Notification that session creation has completed.
        /// </summary>
        internal event EventHandler<CreateCompleteEventArgs> 
SessionCreateCompleted
;

private void SendDataAsync(RemoteDataObject data)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,18779,18923);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,18853,18912);

f_1584_18853_18911(f_1584_18853_18893(_transportManager), data);
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,18779,18923);

System.Management.Automation.Remoting.PrioritySendDataCollection
f_1584_18853_18893(System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
this_param)
{
var return_v = this_param.DataToBeSentCollection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 18853, 18893);
return return_v;
}


int
f_1584_18853_18911(System.Management.Automation.Remoting.PrioritySendDataCollection
this_param,System.Management.Automation.Remoting.RemoteDataObject
data)
{
this_param.Add<object>( (System.Management.Automation.Remoting.RemoteDataObject<object>)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 18853, 18911);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,18779,18923);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,18779,18923);
}
		}

internal void SendDataAsync<T>(RemoteDataObject<T> data, DataPriorityType priority)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,19299,19482);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,19407,19471);

f_1584_19407_19470(f_1584_19407_19447(_transportManager), data, priority);
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,19299,19482);

System.Management.Automation.Remoting.PrioritySendDataCollection
f_1584_19407_19447(System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
this_param)
{
var return_v = this_param.DataToBeSentCollection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 19407, 19447);
return return_v;
}


int
f_1584_19407_19470(System.Management.Automation.Remoting.PrioritySendDataCollection
this_param,System.Management.Automation.Remoting.RemoteDataObject<T>
data,System.Management.Automation.Remoting.DataPriorityType
priority)
{
this_param.Add<T>( data, priority);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 19407, 19470);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,19299,19482);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,19299,19482);
}
		}

internal void SendDataAsync(PSObject data, DataPriorityType priority)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,19806,20196);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,19900,20100);

RemoteDataObject<PSObject> 
dataToBeSent = f_1584_19942_20099(RemotingDestination.Server, RemotingDataType.InvalidDataType, _clientRunspacePoolId, Guid.Empty, data)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,20116,20185);

f_1584_20116_20184(f_1584_20116_20156(_transportManager), dataToBeSent);
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,19806,20196);

System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
f_1584_19942_20099(System.Management.Automation.RemotingDestination
destination,System.Management.Automation.RemotingDataType
dataType,System.Guid
runspacePoolId,System.Guid
powerShellId,System.Management.Automation.PSObject
data)
{
var return_v = RemoteDataObject<PSObject>.CreateFrom( destination, dataType, runspacePoolId, powerShellId, data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 19942, 20099);
return return_v;
}


System.Management.Automation.Remoting.PrioritySendDataCollection
f_1584_20116_20156(System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
this_param)
{
var return_v = this_param.DataToBeSentCollection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 20116, 20156);
return return_v;
}


int
f_1584_20116_20184(System.Management.Automation.Remoting.PrioritySendDataCollection
this_param,System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
data)
{
this_param.Add<System.Management.Automation.PSObject>( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 20116, 20184);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,19806,20196);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,19806,20196);
}
		}

private ClientRemoteSessionImpl CreateClientRemoteSession(
                    RemoteRunspacePoolInternal rsPoolInternal)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,20459,20908);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,20606,20761);

ClientRemoteSession.URIDirectionReported 
uriRedirectionHandler =
                new ClientRemoteSession.URIDirectionReported(HandleURIDirectionReported)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,20775,20897);

return f_1584_20782_20896(rsPoolInternal, uriRedirectionHandler);
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,20459,20908);

System.Management.Automation.Remoting.ClientRemoteSessionImpl
f_1584_20782_20896(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
rsPool,System.Management.Automation.Remoting.ClientRemoteSession.URIDirectionReported
uriRedirectionHandler)
{
var return_v = new System.Management.Automation.Remoting.ClientRemoteSessionImpl( rsPool, uriRedirectionHandler);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 20782, 20896);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,20459,20908);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,20459,20908);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void HandleClientRemoteSessionStateChanged(
                        object sender, RemoteSessionStateEventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,21152,26764);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,21460,22755) || true) && (f_1584_21464_21488(f_1584_21464_21482(e))== RemoteSessionState.NegotiationSending)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,21460,22755);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,21563,21656) || true) && (_createRunspaceCalled)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,21563,21656);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,21630,21637);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,21563,21656);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,21682,21693);

                lock (_syncObject)
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,21858,22107) || true) && (_createRunspaceCalled)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,21858,22107);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,22077,22084);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,21858,22107);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,22131,22160);

_createRunspaceCalled = true;
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,22299,22441);

PSPrimitiveDictionary 
argumentsWithVersionTable =
f_1584_22370_22440(_applicationArguments)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,22510,22740);

f_1584_22510_22739(this, f_1584_22524_22738(_clientRunspacePoolId, _minRunspaces, _maxRunspaces, f_1584_22642_22682(f_1584_22642_22655()), _host, argumentsWithVersionTable));
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,21460,22755);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,22771,26753) || true) && (f_1584_22775_22799(f_1584_22775_22793(e))== RemoteSessionState.NegotiationSendingOnConnect)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,22771,26753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,22939,23073);

f_1584_22939_23072(this, f_1584_22953_23071(_clientRunspacePoolId, _minRunspaces, _maxRunspaces));
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,22771,26753);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,22771,26753);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,23107,26753) || true) && (f_1584_23111_23135(f_1584_23111_23129(e))== RemoteSessionState.ClosingConnection)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,23107,26753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,23273,23307);

Exception 
reason = _closingReason
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,23325,23485) || true) && (reason == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,23325,23485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,23385,23420);

reason = f_1584_23394_23419(f_1584_23394_23412(e));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,23442,23466);

_closingReason = reason;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,23325,23485);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,23577,23631);

List<ClientPowerShellDataStructureHandler> 
dsHandlers
=default(List<ClientPowerShellDataStructureHandler>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,23655,23677);
                lock (_associationSyncObject)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,23719,23819);

dsHandlers = f_1584_23732_23818(f_1584_23779_23817(_associatedPowerShellDSHandlers));
                }
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,23858,24035);
foreach(ClientPowerShellDataStructureHandler dsHandler in f_1584_23917_23927_I(dsHandlers) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,23858,24035);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,23969,24016);

f_1584_23969_24015(                    dsHandler, _closingReason);
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,23858,24035);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1584,1,178);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1584,1,178);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,24055,24131);

f_1584_24055_24130(
                SessionClosing, this, f_1584_24087_24129(reason));
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,23107,26753);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,23107,26753);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,24165,26753) || true) && (f_1584_24169_24193(f_1584_24169_24187(e))== RemoteSessionState.Closed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,24165,26753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,24320,24354);

Exception 
reason = _closingReason
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,24372,24532) || true) && (reason == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,24372,24532);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,24432,24467);

reason = f_1584_24441_24466(f_1584_24441_24459(e));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,24489,24513);

_closingReason = reason;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,24372,24532);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,24694,25150) || true) && (reason != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,24694,25150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,24754,24843);

f_1584_24754_24842(this, f_1584_24782_24841(RunspacePoolState.Broken, reason));
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,24694,25150);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,24694,25150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,25042,25131);

f_1584_25042_25130(this, f_1584_25070_25129(RunspacePoolState.Closed, reason));
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,24694,25150);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,25170,25245);

f_1584_25170_25244(
                SessionClosed, this, f_1584_25201_25243(reason));
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,24165,26753);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,24165,26753);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,25279,26753) || true) && (f_1584_25283_25307(f_1584_25283_25301(e))== RemoteSessionState.Connected)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,25279,26753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,25421,25644);

f_1584_25421_25643(_clientRunspacePoolId, PSEventId.OperationalTransferEventRunspacePool, PSEventId.AnalyticTransferEventRunspacePool, PSKeyword.Runspace, PSTask.CreateRunspace);
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,25279,26753);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,25279,26753);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,25678,26753) || true) && (f_1584_25682_25706(f_1584_25682_25700(e))== RemoteSessionState.Disconnected)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,25678,26753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,25775,25932);

f_1584_25775_25931(this, f_1584_25803_25930(RunspacePoolState.Disconnected, f_1584_25904_25929(f_1584_25904_25922(e))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,25950,26050);

f_1584_25950_26049(                SessionDisconnected, this, f_1584_25987_26048(f_1584_26022_26047(f_1584_26022_26040(e))));
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,25678,26753);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,25678,26753);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,26084,26753) || true) && (_reconnecting &&(DynAbs.Tracing.TraceSender.Expression_True(1584, 26088, 26163)&&f_1584_26105_26129(f_1584_26105_26123(e))== RemoteSessionState.Established))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,26084,26753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,26197,26275);

f_1584_26197_26274(                SessionReconnected, this, f_1584_26233_26273(null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,26293,26315);

_reconnecting = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,26084,26753);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,26084,26753);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,26349,26753) || true) && (f_1584_26353_26377(f_1584_26353_26371(e))== RemoteSessionState.RCDisconnecting)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,26349,26753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,26449,26531);

f_1584_26449_26530(                SessionRCDisconnecting, this, f_1584_26489_26529(null));
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,26349,26753);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,26349,26753);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,26597,26738) || true) && (f_1584_26601_26626(f_1584_26601_26619(e))!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,26597,26738);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,26676,26719);

_closingReason = f_1584_26693_26718(f_1584_26693_26711(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,26597,26738);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,26349,26753);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,26084,26753);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,25678,26753);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,25279,26753);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,24165,26753);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,23107,26753);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,22771,26753);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,21152,26764);

System.Management.Automation.RemoteSessionStateInfo
f_1584_21464_21482(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 21464, 21482);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1584_21464_21488(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 21464, 21488);
return return_v;
}


System.Management.Automation.PSPrimitiveDictionary
f_1584_22370_22440(System.Management.Automation.PSPrimitiveDictionary
originalHash)
{
var return_v = PSPrimitiveDictionary.CloneAndAddPSVersionTable( originalHash);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 22370, 22440);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSession
f_1584_22642_22655()
{
var return_v = RemoteSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 22642, 22655);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1584_22642_22682(System.Management.Automation.Remoting.ClientRemoteSession
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 22642, 22682);
return return_v;
}


System.Management.Automation.Remoting.RemoteDataObject
f_1584_22524_22738(System.Guid
clientRunspacePoolId,int
minRunspaces,int
maxRunspaces,System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
runspacePool,System.Management.Automation.Host.PSHost
host,System.Management.Automation.PSPrimitiveDictionary
applicationArguments)
{
var return_v = RemotingEncoder.GenerateCreateRunspacePool( clientRunspacePoolId, minRunspaces, maxRunspaces, runspacePool, host, applicationArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 22524, 22738);
return return_v;
}


int
f_1584_22510_22739(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,System.Management.Automation.Remoting.RemoteDataObject
data)
{
this_param.SendDataAsync( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 22510, 22739);
return 0;
}


System.Management.Automation.RemoteSessionStateInfo
f_1584_22775_22793(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 22775, 22793);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1584_22775_22799(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 22775, 22799);
return return_v;
}


System.Management.Automation.Remoting.RemoteDataObject
f_1584_22953_23071(System.Guid
clientRunspacePoolId,int
minRunspaces,int
maxRunspaces)
{
var return_v = RemotingEncoder.GenerateConnectRunspacePool( clientRunspacePoolId, minRunspaces, maxRunspaces);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 22953, 23071);
return return_v;
}


int
f_1584_22939_23072(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,System.Management.Automation.Remoting.RemoteDataObject
data)
{
this_param.SendDataAsync( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 22939, 23072);
return 0;
}


System.Management.Automation.RemoteSessionStateInfo
f_1584_23111_23129(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 23111, 23129);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1584_23111_23135(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 23111, 23135);
return return_v;
}


System.Management.Automation.RemoteSessionStateInfo
f_1584_23394_23412(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 23394, 23412);
return return_v;
}


System.Exception
f_1584_23394_23419(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 23394, 23419);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>.ValueCollection
f_1584_23779_23817(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 23779, 23817);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
f_1584_23732_23818(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>.ValueCollection
collection)
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>( (System.Collections.Generic.IEnumerable<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 23732, 23818);
return return_v;
}


int
f_1584_23969_24015(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param,System.Exception
sessionCloseReason)
{
this_param.CloseConnectionAsync( sessionCloseReason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 23969, 24015);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
f_1584_23917_23927_I(System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 23917, 23927);
return return_v;
}


System.Management.Automation.RemoteDataEventArgs<System.Exception>
f_1584_24087_24129(System.Exception
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Exception>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 24087, 24129);
return return_v;
}


int
f_1584_24055_24130(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Exception>>
eventHandler,System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Exception>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Exception>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 24055, 24130);
return 0;
}


System.Management.Automation.RemoteSessionStateInfo
f_1584_24169_24187(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 24169, 24187);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1584_24169_24193(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 24169, 24193);
return return_v;
}


System.Management.Automation.RemoteSessionStateInfo
f_1584_24441_24459(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 24441, 24459);
return return_v;
}


System.Exception
f_1584_24441_24466(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 24441, 24466);
return return_v;
}


System.Management.Automation.RunspacePoolStateInfo
f_1584_24782_24841(System.Management.Automation.Runspaces.RunspacePoolState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.RunspacePoolStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 24782, 24841);
return return_v;
}


int
f_1584_24754_24842(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,System.Management.Automation.RunspacePoolStateInfo
stateInfo)
{
this_param.NotifyAssociatedPowerShells( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 24754, 24842);
return 0;
}


System.Management.Automation.RunspacePoolStateInfo
f_1584_25070_25129(System.Management.Automation.Runspaces.RunspacePoolState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.RunspacePoolStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 25070, 25129);
return return_v;
}


int
f_1584_25042_25130(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,System.Management.Automation.RunspacePoolStateInfo
stateInfo)
{
this_param.NotifyAssociatedPowerShells( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 25042, 25130);
return 0;
}


System.Management.Automation.RemoteDataEventArgs<System.Exception>
f_1584_25201_25243(System.Exception
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Exception>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 25201, 25243);
return return_v;
}


int
f_1584_25170_25244(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Exception>>
eventHandler,System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Exception>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Exception>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 25170, 25244);
return 0;
}


System.Management.Automation.RemoteSessionStateInfo
f_1584_25283_25301(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 25283, 25301);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1584_25283_25307(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 25283, 25307);
return return_v;
}


int
f_1584_25421_25643(System.Guid
newActivityId,System.Management.Automation.Internal.PSEventId
eventForOperationalChannel,System.Management.Automation.Internal.PSEventId
eventForAnalyticChannel,System.Management.Automation.Internal.PSKeyword
keyword,System.Management.Automation.Internal.PSTask
task)
{
PSEtwLog.ReplaceActivityIdForCurrentThread( newActivityId, eventForOperationalChannel, eventForAnalyticChannel, keyword, task);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 25421, 25643);
return 0;
}


System.Management.Automation.RemoteSessionStateInfo
f_1584_25682_25700(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 25682, 25700);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1584_25682_25706(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 25682, 25706);
return return_v;
}


System.Management.Automation.RemoteSessionStateInfo
f_1584_25904_25922(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 25904, 25922);
return return_v;
}


System.Exception
f_1584_25904_25929(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 25904, 25929);
return return_v;
}


System.Management.Automation.RunspacePoolStateInfo
f_1584_25803_25930(System.Management.Automation.Runspaces.RunspacePoolState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.RunspacePoolStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 25803, 25930);
return return_v;
}


int
f_1584_25775_25931(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,System.Management.Automation.RunspacePoolStateInfo
stateInfo)
{
this_param.NotifyAssociatedPowerShells( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 25775, 25931);
return 0;
}


System.Management.Automation.RemoteSessionStateInfo
f_1584_26022_26040(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 26022, 26040);
return return_v;
}


System.Exception
f_1584_26022_26047(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 26022, 26047);
return return_v;
}


System.Management.Automation.RemoteDataEventArgs<System.Exception>
f_1584_25987_26048(System.Exception
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Exception>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 25987, 26048);
return return_v;
}


int
f_1584_25950_26049(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Exception>>
eventHandler,System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Exception>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Exception>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 25950, 26049);
return 0;
}


System.Management.Automation.RemoteSessionStateInfo
f_1584_26105_26123(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 26105, 26123);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1584_26105_26129(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 26105, 26129);
return return_v;
}


System.Management.Automation.RemoteDataEventArgs<System.Exception>
f_1584_26233_26273(object
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Exception>( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 26233, 26273);
return return_v;
}


int
f_1584_26197_26274(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Exception>>
eventHandler,System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Exception>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Exception>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 26197, 26274);
return 0;
}


System.Management.Automation.RemoteSessionStateInfo
f_1584_26353_26371(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 26353, 26371);
return return_v;
}


System.Management.Automation.RemoteSessionState
f_1584_26353_26377(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 26353, 26377);
return return_v;
}


System.Management.Automation.RemoteDataEventArgs<System.Exception>
f_1584_26489_26529(object
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Exception>( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 26489, 26529);
return return_v;
}


int
f_1584_26449_26530(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Exception>>
eventHandler,System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Exception>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Exception>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 26449, 26530);
return 0;
}


System.Management.Automation.RemoteSessionStateInfo
f_1584_26601_26619(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 26601, 26619);
return return_v;
}


System.Exception
f_1584_26601_26626(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.Reason ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 26601, 26626);
return return_v;
}


System.Management.Automation.RemoteSessionStateInfo
f_1584_26693_26711(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 26693, 26711);
return return_v;
}


System.Exception
f_1584_26693_26718(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 26693, 26718);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,21152,26764);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,21152,26764);
}
		}

private void HandleURIDirectionReported(Uri newURI)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,27011,27176);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,27087,27165);

f_1584_27087_27164(            URIRedirectionReported, this, f_1584_27127_27163(newURI));
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,27011,27176);

System.Management.Automation.RemoteDataEventArgs<System.Uri>
f_1584_27127_27163(System.Uri
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Uri>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 27127, 27163);
return return_v;
}


int
f_1584_27087_27164(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Uri>>
eventHandler,System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Uri>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Uri>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 27087, 27164);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,27011,27176);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,27011,27176);
}
		}

private void NotifyAssociatedPowerShells(RunspacePoolStateInfo stateInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,27417,29360);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,27515,27569);

List<ClientPowerShellDataStructureHandler> 
dsHandlers
=default(List<ClientPowerShellDataStructureHandler>);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,27585,28092) || true) && (f_1584_27589_27604(stateInfo)== RunspacePoolState.Disconnected)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,27585,28092);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,27678,27700);
                lock (_associationSyncObject)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,27742,27842);

dsHandlers = f_1584_27755_27841(f_1584_27802_27840(_associatedPowerShellDSHandlers));
                }
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,27881,28050);
foreach(ClientPowerShellDataStructureHandler dsHandler in f_1584_27940_27950_I(dsHandlers) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,27881,28050);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,27992,28031);

f_1584_27992_28030(                    dsHandler, stateInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,27881,28050);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1584,1,170);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1584,1,170);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,28070,28077);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,27585,28092);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,28228,29349) || true) && (f_1584_28232_28247(stateInfo)== RunspacePoolState.Broken ||(DynAbs.Tracing.TraceSender.Expression_False(1584, 28232, 28322)||f_1584_28279_28294(stateInfo)== RunspacePoolState.Closed))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,28228,29349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,28362,28384);
                lock (_associationSyncObject)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,28426,28526);

dsHandlers = f_1584_28439_28525(f_1584_28486_28524(_associatedPowerShellDSHandlers));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,28548,28588);

f_1584_28548_28587(                    _associatedPowerShellDSHandlers);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,28627,29307) || true) && (f_1584_28631_28646(stateInfo)== RunspacePoolState.Broken)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,28627,29307);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,28782,28969);
foreach(ClientPowerShellDataStructureHandler dsHandler in f_1584_28841_28851_I(dsHandlers) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,28782,28969);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,28901,28946);

f_1584_28901_28945(                        dsHandler, f_1584_28928_28944(stateInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,28782,28969);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1584,1,188);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1584,1,188);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1584,28627,29307);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,28627,29307);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,29011,29307) || true) && (f_1584_29015_29030(stateInfo)== RunspacePoolState.Closed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,29011,29307);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,29100,29288);
foreach(ClientPowerShellDataStructureHandler dsHandler in f_1584_29159_29169_I(dsHandlers) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,29100,29288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,29219,29265);

f_1584_29219_29264(                        dsHandler, f_1584_29247_29263(stateInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,29100,29288);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1584,1,189);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1584,1,189);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1584,29011,29307);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,28627,29307);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,29327,29334);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,28228,29349);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,27417,29360);

System.Management.Automation.Runspaces.RunspacePoolState
f_1584_27589_27604(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 27589, 27604);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>.ValueCollection
f_1584_27802_27840(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 27802, 27840);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
f_1584_27755_27841(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>.ValueCollection
collection)
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>( (System.Collections.Generic.IEnumerable<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 27755, 27841);
return return_v;
}


int
f_1584_27992_28030(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param,System.Management.Automation.RunspacePoolStateInfo
rsStateInfo)
{
this_param.ProcessDisconnect( rsStateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 27992, 28030);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
f_1584_27940_27950_I(System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 27940, 27950);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1584_28232_28247(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 28232, 28247);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1584_28279_28294(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 28279, 28294);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>.ValueCollection
f_1584_28486_28524(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 28486, 28524);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
f_1584_28439_28525(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>.ValueCollection
collection)
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>( (System.Collections.Generic.IEnumerable<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 28439, 28525);
return return_v;
}


int
f_1584_28548_28587(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 28548, 28587);
return 0;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1584_28631_28646(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 28631, 28646);
return return_v;
}


System.Exception
f_1584_28928_28944(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 28928, 28944);
return return_v;
}


int
f_1584_28901_28945(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param,System.Exception
reason)
{
this_param.SetStateToFailed( reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 28901, 28945);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
f_1584_28841_28851_I(System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 28841, 28851);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1584_29015_29030(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 29015, 29030);
return return_v;
}


System.Exception
f_1584_29247_29263(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 29247, 29263);
return return_v;
}


int
f_1584_29219_29264(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param,System.Exception
reason)
{
this_param.SetStateToStopped( reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 29219, 29264);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
f_1584_29159_29169_I(System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 29159, 29169);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,27417,29360);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,27417,29360);
}
		}

private ClientPowerShellDataStructureHandler GetAssociatedPowerShellDataStructureHandler
            (Guid clientPowerShellId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,29676,30223);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,29828,29882);

ClientPowerShellDataStructureHandler 
dsHandler = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,29904,29926);

            lock (_associationSyncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,29960,30054);

bool 
success = f_1584_29975_30053(_associatedPowerShellDSHandlers, clientPowerShellId, out dsHandler)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,30074,30164) || true) && (!success)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,30074,30164);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,30128,30145);

dsHandler = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,30074,30164);
}
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,30195,30212);

return dsHandler;
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,29676,30223);

bool
f_1584_29975_30053(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
this_param,System.Guid
key,out System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 29975, 30053);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,29676,30223);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,29676,30223);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void HandleRemoveAssociation(object sender, EventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,30469,31087);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,30558,30703);

f_1584_30558_30702(sender is ClientPowerShellDataStructureHandler, @"sender of the event
                must be ClientPowerShellDataStructureHandler");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,30719,30832);

ClientPowerShellDataStructureHandler 
dsHandler =
                sender as ClientPowerShellDataStructureHandler
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,30854,30876);

            lock (_associationSyncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,30910,30973);

f_1584_30910_30972(                _associatedPowerShellDSHandlers, f_1584_30949_30971(dsHandler));
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,31004,31076);

f_1584_31004_31075(
            _transportManager, f_1584_31052_31074(dsHandler));
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,30469,31087);

int
f_1584_30558_30702(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 30558, 30702);
return 0;
}


System.Guid
f_1584_30949_30971(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param)
{
var return_v = this_param.PowerShellId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 30949, 30971);
return return_v;
}


bool
f_1584_30910_30972(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
this_param,System.Guid
key)
{
var return_v = this_param.Remove( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 30910, 30972);
return return_v;
}


System.Guid
f_1584_31052_31074(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param)
{
var return_v = this_param.PowerShellId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 31052, 31074);
return return_v;
}


int
f_1584_31004_31075(System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
this_param,System.Guid
powerShellCmdId)
{
this_param.RemoveCommandTransportManager( powerShellCmdId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 31004, 31075);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,30469,31087);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,30469,31087);
}
		}

private void PrepareForAndStartDisconnect()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,31407,33761);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,31475,31499);

bool 
startDisconnectNow
=default(bool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,31521,31543);

            lock (_associationSyncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,31577,32860) || true) && (f_1584_31581_31618(_associatedPowerShellDSHandlers)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,31577,32860);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,31755,31781);

startDisconnectNow = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,31803,31838);

_preparingForDisconnectList = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,31577,32860);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,31577,32860);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,32025,32052);

startDisconnectNow = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,32281,32391);

f_1584_32281_32390(_preparingForDisconnectList == null, "Cannot prepare for disconnect while disconnect is pending.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,32413,32489);

_preparingForDisconnectList = f_1584_32443_32488();
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,32511,32841);
foreach(ClientPowerShellDataStructureHandler dsHandler in f_1584_32570_32608_I(f_1584_32570_32608(_associatedPowerShellDSHandlers)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,32511,32841);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,32658,32718);

f_1584_32658_32717(                        _preparingForDisconnectList, f_1584_32690_32716(dsHandler));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,32744,32818);

f_1584_32744_32770(dsHandler).ReadyForDisconnect += HandleReadyForDisconnect;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,32511,32841);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1584,1,331);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1584,1,331);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1584,31577,32860);
}
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,32891,33750) || true) && (startDisconnectNow)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,32891,33750);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,32995,33031);

f_1584_32995_33030(this, f_1584_33016_33029());
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,32891,33750);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,32891,33750);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,33274,33328);

List<ClientPowerShellDataStructureHandler> 
dsHandlers
=default(List<ClientPowerShellDataStructureHandler>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,33352,33374);
                lock (_associationSyncObject)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,33416,33516);

dsHandlers = f_1584_33429_33515(f_1584_33476_33514(_associatedPowerShellDSHandlers));
                }
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,33555,33735);
foreach(ClientPowerShellDataStructureHandler dsHandler in f_1584_33614_33624_I(dsHandlers) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,33555,33735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,33666,33716);

f_1584_33666_33715(f_1584_33666_33692(dsHandler));
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,33555,33735);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1584,1,181);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1584,1,181);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1584,32891,33750);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,31407,33761);

int
f_1584_31581_31618(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 31581, 31618);
return return_v;
}


int
f_1584_32281_32390(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 32281, 32390);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager>
f_1584_32443_32488()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 32443, 32488);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>.ValueCollection
f_1584_32570_32608(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 32570, 32608);
return return_v;
}


System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
f_1584_32690_32716(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param)
{
var return_v = this_param.TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 32690, 32716);
return return_v;
}


int
f_1584_32658_32717(System.Collections.Generic.List<System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager>
this_param,System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 32658, 32717);
return 0;
}


System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
f_1584_32744_32770(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param)
{
var return_v = this_param.TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 32744, 32770);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>.ValueCollection
f_1584_32570_32608_I(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>.ValueCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 32570, 32608);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSession
f_1584_33016_33029()
{
var return_v = RemoteSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 33016, 33029);
return return_v;
}


int
f_1584_32995_33030(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,System.Management.Automation.Remoting.ClientRemoteSession
remoteSession)
{
this_param.StartDisconnectAsync( (object)remoteSession);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 32995, 33030);
return 0;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>.ValueCollection
f_1584_33476_33514(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 33476, 33514);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
f_1584_33429_33515(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>.ValueCollection
collection)
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>( (System.Collections.Generic.IEnumerable<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 33429, 33515);
return return_v;
}


System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
f_1584_33666_33692(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param)
{
var return_v = this_param.TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 33666, 33692);
return return_v;
}


int
f_1584_33666_33715(System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
this_param)
{
this_param.PrepareForDisconnect();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 33666, 33715);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
f_1584_33614_33624_I(System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 33614, 33624);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,31407,33761);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,31407,33761);
}
		}

private void PrepareForConnect()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,33971,34557);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,34028,34082);

List<ClientPowerShellDataStructureHandler> 
dsHandlers
=default(List<ClientPowerShellDataStructureHandler>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,34102,34124);
            lock (_associationSyncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,34158,34258);

dsHandlers = f_1584_34171_34257(f_1584_34218_34256(_associatedPowerShellDSHandlers));
            }
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,34289,34546);
foreach(ClientPowerShellDataStructureHandler dsHandler in f_1584_34348_34358_I(dsHandlers) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,34289,34546);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,34392,34466);

f_1584_34392_34418(dsHandler).ReadyForDisconnect -= HandleReadyForDisconnect;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,34484,34531);

f_1584_34484_34530(f_1584_34484_34510(dsHandler));
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,34289,34546);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1584,1,258);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1584,1,258);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1584,33971,34557);

System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>.ValueCollection
f_1584_34218_34256(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 34218, 34256);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
f_1584_34171_34257(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>.ValueCollection
collection)
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>( (System.Collections.Generic.IEnumerable<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 34171, 34257);
return return_v;
}


System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
f_1584_34392_34418(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param)
{
var return_v = this_param.TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 34392, 34418);
return return_v;
}


System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
f_1584_34484_34510(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param)
{
var return_v = this_param.TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 34484, 34510);
return return_v;
}


int
f_1584_34484_34530(System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
this_param)
{
this_param.PrepareForConnect();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 34484, 34530);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
f_1584_34348_34358_I(System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 34348, 34358);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,33971,34557);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,33971,34557);
}
		}

private void HandleReadyForDisconnect(object sender, EventArgs args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,34868,36196);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,34961,35035) || true) && (sender == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,34961,35035);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,35013,35020);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,34961,35035);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,35051,35136);

BaseClientCommandTransportManager 
bcmdTM = (BaseClientCommandTransportManager)sender
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,35158,35180);

            lock (_associationSyncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,35288,35395) || true) && (_preparingForDisconnectList == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,35288,35395);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,35369,35376);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,35288,35395);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,35415,35567) || true) && (f_1584_35419_35463(_preparingForDisconnectList, bcmdTM))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,35415,35567);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,35505,35548);

f_1584_35505_35547(                    _preparingForDisconnectList, bcmdTM);
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,35415,35567);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,35587,36170) || true) && (f_1584_35591_35624(_preparingForDisconnectList)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,35587,36170);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,35671,35706);

_preparingForDisconnectList = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,36067,36151);

f_1584_36067_36150(new WaitCallback(StartDisconnectAsync), f_1584_36136_36149());
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,35587,36170);
}
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,34868,36196);

bool
f_1584_35419_35463(System.Collections.Generic.List<System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager>
this_param,System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 35419, 35463);
return return_v;
}


bool
f_1584_35505_35547(System.Collections.Generic.List<System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager>
this_param,System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
item)
{
var return_v = this_param.Remove( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 35505, 35547);
return return_v;
}


int
f_1584_35591_35624(System.Collections.Generic.List<System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 35591, 35624);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSession
f_1584_36136_36149()
{
var return_v = RemoteSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 36136, 36149);
return return_v;
}


bool
f_1584_36067_36150(System.Threading.WaitCallback
callBack,System.Management.Automation.Remoting.ClientRemoteSession
state)
{
var return_v = ThreadPool.QueueUserWorkItem( callBack, (object)state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 36067, 36150);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,34868,36196);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,34868,36196);
}
		}

private void StartDisconnectAsync(object remoteSession)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,36375,36521);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,36455,36510);

f_1584_36455_36509(            ((ClientRemoteSession)remoteSession));
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,36375,36521);

int
f_1584_36455_36509(System.Management.Automation.Remoting.ClientRemoteSession
this_param)
{
this_param.DisconnectAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 36455, 36509);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,36375,36521);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,36375,36521);
}
		}

private void HandleRobustConnectionNotification(
            object sender,
            ConnectionStatusEventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,36749,37331);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,36892,36946);

List<ClientPowerShellDataStructureHandler> 
dsHandlers
=default(List<ClientPowerShellDataStructureHandler>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,36966,36988);
            lock (_associationSyncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,37022,37122);

dsHandlers = f_1584_37035_37121(f_1584_37082_37120(_associatedPowerShellDSHandlers));
            }
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,37153,37320);
foreach(ClientPowerShellDataStructureHandler dsHandler in f_1584_37212_37222_I(dsHandlers) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,37153,37320);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,37256,37305);

f_1584_37256_37304(                dsHandler, e);
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,37153,37320);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1584,1,168);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1584,1,168);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1584,36749,37331);

System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>.ValueCollection
f_1584_37082_37120(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 37082, 37120);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
f_1584_37035_37121(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>.ValueCollection
collection)
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>( (System.Collections.Generic.IEnumerable<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 37035, 37121);
return return_v;
}


int
f_1584_37256_37304(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param,System.Management.Automation.Remoting.ConnectionStatusEventArgs
e)
{
this_param.ProcessRobustConnectionNotification( e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 37256, 37304);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
f_1584_37212_37222_I(System.Collections.Generic.List<System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 37212, 37222);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,36749,37331);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,36749,37331);
}
		}

private void HandleSessionCreateCompleted(object sender, CreateCompleteEventArgs eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,37579,37782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,37695,37771);

f_1584_37695_37770(            SessionCreateCompleted, this, eventArgs);
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,37579,37782);

int
f_1584_37695_37770(System.EventHandler<System.Management.Automation.Remoting.CreateCompleteEventArgs>
eventHandler,System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
sender,System.Management.Automation.Remoting.CreateCompleteEventArgs
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.Remoting.CreateCompleteEventArgs>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 37695, 37770);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,37579,37782);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,37579,37782);
}
		}

private Guid _clientRunspacePoolId;

private object _syncObject ;

private bool _createRunspaceCalled ;

private Exception _closingReason;

private int _minRunspaces;

private int _maxRunspaces;

private PSHost _host;

private PSPrimitiveDictionary _applicationArguments;

private Dictionary<Guid, ClientPowerShellDataStructureHandler> _associatedPowerShellDSHandlers
;

private object _associationSyncObject ;

private BaseClientSessionTransportManager _transportManager;

private List<BaseClientCommandTransportManager> _preparingForDisconnectList;

internal ClientRemoteSession RemoteSession {get; private set; }

internal BaseClientSessionTransportManager TransportManager
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,39377,39674);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,39413,39659) || true) && (f_1584_39417_39430()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,39413,39659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,39480,39546);

return f_1584_39487_39545(f_1584_39487_39528(f_1584_39487_39500()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,39413,39659);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,39413,39659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,39628,39640);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,39413,39659);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,39377,39674);

System.Management.Automation.Remoting.ClientRemoteSession
f_1584_39417_39430()
{
var return_v = RemoteSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 39417, 39430);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSession
f_1584_39487_39500()
{
var return_v = RemoteSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 39487, 39500);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1584_39487_39528(System.Management.Automation.Remoting.ClientRemoteSession
this_param)
{
var return_v = this_param.SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 39487, 39528);
return return_v;
}


System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
f_1584_39487_39545(System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
this_param)
{
var return_v = this_param.TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 39487, 39545);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,39293,39685);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,39293,39685);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal int MaxRetryConnectionTime
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,39938,40276);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,39974,40232) || true) && (_transportManager != null &&(DynAbs.Tracing.TraceSender.Expression_True(1584, 39978, 40083)&&                    _transportManager is WSManClientSessionTransportManager))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,39974,40232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,40125,40213);

return f_1584_40132_40212(((WSManClientSessionTransportManager)(_transportManager)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,39974,40232);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,40252,40261);

return 0;
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,39938,40276);

int
f_1584_40132_40212(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
this_param)
{
var return_v = this_param.MaxRetryConnectionTime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 40132, 40212);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,39878,40287);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,39878,40287);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool EndpointSupportsDisconnect
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,40536,40810);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,40572,40687);

WSManClientSessionTransportManager 
wsmanTransportManager = _transportManager as WSManClientSessionTransportManager
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,40705,40795);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1584, 40712, 40743)||(((wsmanTransportManager != null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1584, 40746, 40786))||DynAbs.Tracing.TraceSender.Conditional_F3(1584, 40789, 40794)))?f_1584_40746_40786(wsmanTransportManager):false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,40536,40810);

bool
f_1584_40746_40786(System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
this_param)
{
var return_v = this_param.SupportsDisconnect ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 40746, 40786);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,40471,40821);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,40471,40821);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,40996,41109);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,41042,41056);

f_1584_41042_41055(this, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,41072,41098);

f_1584_41072_41097(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,40996,41109);

int
f_1584_41042_41055(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,bool
disposing)
{
this_param.Dispose( disposing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 41042, 41055);
return 0;
}


int
f_1584_41072_41097(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 41072, 41097);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,40996,41109);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,40996,41109);
}
		}

public void Dispose(bool disposing)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,41289,41602);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,41349,41591) || true) && (disposing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,41349,41591);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,41396,41576) || true) && (f_1584_41400_41413()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,41396,41576);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,41463,41514);

f_1584_41463_41513(                    ((ClientRemoteSessionImpl)f_1584_41489_41502()));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,41536,41557);

RemoteSession = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,41396,41576);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,41349,41591);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,41289,41602);

System.Management.Automation.Remoting.ClientRemoteSession
f_1584_41400_41413()
{
var return_v = RemoteSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 41400, 41413);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSession
f_1584_41489_41502()
{
var return_v = RemoteSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 41489, 41502);
return return_v;
}


int
f_1584_41463_41513(System.Management.Automation.Remoting.ClientRemoteSessionImpl
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 41463, 41513);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,41289,41602);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,41289,41602);
}
		}

static ClientRunspacePoolDataStructureHandler()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1584,755,41643);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1584,755,41643);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,755,41643);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1584,755,41643);

System.Guid
f_1584_1461_1490(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 1461, 1490);
return return_v;
}


int
f_1584_1521_1557(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.GetMinRunspaces();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 1521, 1557);
return return_v;
}


int
f_1584_1588_1624(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.GetMaxRunspaces();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 1588, 1624);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1584_1647_1670(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 1647, 1670);
return return_v;
}


System.Management.Automation.PSPrimitiveDictionary
f_1584_1709_1748(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.ApplicationArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 1709, 1748);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionImpl
f_1584_1779_1824(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
rsPoolInternal)
{
var return_v = this_param.CreateClientRemoteSession( rsPoolInternal);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 1779, 1824);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSession
f_1584_1951_1964()
{
var return_v = RemoteSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 1951, 1964);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
f_1584_1951_1992(System.Management.Automation.Remoting.ClientRemoteSession
this_param)
{
var return_v = this_param.SessionDataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 1951, 1992);
return return_v;
}


System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
f_1584_1951_2009(System.Management.Automation.Remoting.ClientRemoteSessionDataStructureHandler
this_param)
{
var return_v = this_param.TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 1951, 2009);
return return_v;
}


System.Management.Automation.Remoting.ClientRemoteSession
f_1584_2078_2091()
{
var return_v = RemoteSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 2078, 2091);
return return_v;
}


object
f_1584_37941_37953()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 37941, 37953);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>
f_1584_38335_38395()
{
var return_v = new System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Internal.ClientPowerShellDataStructureHandler>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 38335, 38395);
return return_v;
}


object
f_1584_38569_38581()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 38569, 38581);
return return_v;
}

}
internal class ClientPowerShellDataStructureHandler
{        
        /// <summary>
        /// This event is raised when the state of associated
        /// powershell is terminal and the runspace pool has
        /// to detach the association.
        /// </summary>
        internal event EventHandler 
RemoveAssociation
;

        /// <summary>
        /// This event is raised when a state information object
        /// is received from the server.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<PSInvocationStateInfo>> 
InvocationStateInfoReceived
;

        /// <summary>
        /// This event is raised when an output object is received
        /// from the server.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<object>> 
OutputReceived
;

        /// <summary>
        /// This event is raised when an error record is received
        /// from the server.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<ErrorRecord>> 
ErrorReceived
;

        /// <summary>
        /// This event is raised when an informational message -
        /// debug, verbose, warning, progress is received from
        /// the server.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<InformationalMessage>> 
InformationalMessageReceived
;

        /// <summary>
        /// This event is raised when a host call is targeted to the
        /// powershell.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<RemoteHostCall>> 
HostCallReceived
;

        /// <summary>
        /// This event is raised when a runspace pool data structure handler notifies an
        /// associated powershell data structure handler that its closed.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<Exception>> 
ClosedNotificationFromRunspacePool
;

        /// <summary>
        /// Event that is raised when a remote connection is successfully closed. The event is raised
        /// from a WSMan transport thread. Since this thread can hold on to a HTTP
        /// connection, the event handler should complete processing as fast as possible.
        /// Importantly the event handler should not generate any call that results in a
        /// user request like host.ReadLine().
        ///
        /// Errors (occurred during connection attempt) are reported through WSManTransportErrorOccured
        /// event.
        /// </summary>
        /// <remarks>
        /// The eventhandler should make sure not to throw any exceptions.
        /// </remarks>
        internal event EventHandler<EventArgs> 
CloseCompleted
;

        /// <summary>
        /// This event is raised when a runspace pool data structure handler notifies an
        /// associated powershell data structure handler that its broken.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<Exception>> 
BrokenNotificationFromRunspacePool
;

        /// <summary>
        /// This event is raised when reconnect async operation on the associated powershell/pipeline instance is completed.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<Exception>> 
ReconnectCompleted
;

        /// <summary>
        /// This event is raised when connect async operation on the associated powershell/pipeline instance is completed.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<Exception>> 
ConnectCompleted
;

        /// <summary>
        /// This event is raised when a Robust Connection layer notification is available.
        /// </summary>
        internal event EventHandler<ConnectionStatusEventArgs> 
RobustConnectionNotification
;

internal void Start(ClientRemoteSessionDSHandlerStateMachine stateMachine, bool inDisconnectMode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,45829,46103);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,46007,46047);

f_1584_46007_46046(this, inDisconnectMode);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,46061,46092);

f_1584_46061_46091(f_1584_46061_46077());
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,45829,46103);

int
f_1584_46007_46046(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param,bool
inDisconnectMode)
{
this_param.SetupTransportManager( inDisconnectMode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 46007, 46046);
return 0;
}


System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
f_1584_46061_46077()
{
var return_v = TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 46061, 46077);
return return_v;
}


int
f_1584_46061_46091(System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
this_param)
{
this_param.CreateAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 46061, 46091);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,45829,46103);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,45829,46103);
}
		}

private void HandleDelayStreamRequestProcessed(object sender, EventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,46115,46353);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,46318,46342);

f_1584_46318_46341(this, null);
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,46115,46353);

int
f_1584_46318_46341(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param,System.Management.Automation.RunspacePoolStateInfo
rsStateInfo)
{
this_param.ProcessDisconnect( rsStateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 46318, 46341);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,46115,46353);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,46115,46353);
}
		}

internal void HandleReconnectCompleted(object sender, EventArgs args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,46365,46723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,46459,46597);

int 
currentState = f_1584_46478_46596(ref _connectionState, connectionStates.Connected, connectionStates.Reconnecting)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,46613,46691);

f_1584_46613_46690(
            ReconnectCompleted, this, f_1584_46649_46689(null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,46705,46712);

return;
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,46365,46723);

int
f_1584_46478_46596(ref int
location1,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler.connectionStates
value,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler.connectionStates
comparand)
{
var return_v = Interlocked.CompareExchange( ref location1, (int)value, (int)comparand);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 46478, 46596);
return return_v;
}


System.Management.Automation.RemoteDataEventArgs<System.Exception>
f_1584_46649_46689(object
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Exception>( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 46649, 46689);
return return_v;
}


int
f_1584_46613_46690(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Exception>>
eventHandler,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Exception>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Exception>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 46613, 46690);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,46365,46723);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,46365,46723);
}
		}

internal void HandleConnectCompleted(object sender, EventArgs args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,46735,47087);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,46827,46963);

int 
currentState = f_1584_46846_46962(ref _connectionState, connectionStates.Connected, connectionStates.Connecting)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,46979,47055);

f_1584_46979_47054(
            ConnectCompleted, this, f_1584_47013_47053(null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,47069,47076);

return;
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,46735,47087);

int
f_1584_46846_46962(ref int
location1,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler.connectionStates
value,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler.connectionStates
comparand)
{
var return_v = Interlocked.CompareExchange( ref location1, (int)value, (int)comparand);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 46846, 46962);
return return_v;
}


System.Management.Automation.RemoteDataEventArgs<System.Exception>
f_1584_47013_47053(object
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Exception>( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 47013, 47053);
return return_v;
}


int
f_1584_46979_47054(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Exception>>
eventHandler,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Exception>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Exception>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 46979, 47054);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,46735,47087);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,46735,47087);
}
		}

internal void HandleTransportError(object sender, TransportErrorOccuredEventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,47280,47852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,47477,47576);

PSInvocationStateInfo 
stateInfo = f_1584_47511_47575(PSInvocationState.Failed, f_1584_47563_47574(e))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,47590,47694);

f_1584_47590_47693(            InvocationStateInfoReceived, this, f_1584_47635_47692(stateInfo));
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,47280,47852);

System.Management.Automation.Remoting.PSRemotingTransportException
f_1584_47563_47574(System.Management.Automation.Remoting.TransportErrorOccuredEventArgs
this_param)
{
var return_v = this_param.Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 47563, 47574);
return return_v;
}


System.Management.Automation.PSInvocationStateInfo
f_1584_47511_47575(System.Management.Automation.PSInvocationState
state,System.Management.Automation.Remoting.PSRemotingTransportException
reason)
{
var return_v = new System.Management.Automation.PSInvocationStateInfo( state, (System.Exception)reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 47511, 47575);
return return_v;
}


System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSInvocationStateInfo>
f_1584_47635_47692(System.Management.Automation.PSInvocationStateInfo
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSInvocationStateInfo>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 47635, 47692);
return return_v;
}


int
f_1584_47590_47693(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSInvocationStateInfo>>
eventHandler,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSInvocationStateInfo>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSInvocationStateInfo>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 47590, 47693);
return 0;
}


            // The handler to InvocationStateInfoReceived would have already
            // closed the connection. No need to do it here again
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,47280,47852);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,47280,47852);
}
		}

internal void SendStopPowerShellMessage()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,47970,48147);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,48036,48088);

f_1584_48036_48087(f_1584_48036_48065(f_1584_48036_48052()));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,48102,48136);

f_1584_48102_48135(f_1584_48102_48118());
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,47970,48147);

System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
f_1584_48036_48052()
{
var return_v = TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 48036, 48052);
return return_v;
}


System.Management.Automation.Internal.PSRemotingCryptoHelper
f_1584_48036_48065(System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
this_param)
{
var return_v = this_param.CryptoHelper;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 48036, 48065);
return return_v;
}


int
f_1584_48036_48087(System.Management.Automation.Internal.PSRemotingCryptoHelper
this_param)
{
this_param.CompleteKeyExchange();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 48036, 48087);
return 0;
}


System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
f_1584_48102_48118()
{
var return_v = TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 48102, 48118);
return return_v;
}


int
f_1584_48102_48135(System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
this_param)
{
this_param.SendStopSignal();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 48102, 48135);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,47970,48147);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,47970,48147);
}
		}

private void OnSignalCompleted(object sender, EventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,48354,49059);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,48697,48837);

PSRemotingDataStructureException 
exception = f_1584_48742_48836(f_1584_48797_48835())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,48851,49048);

f_1584_48851_49047(            InvocationStateInfoReceived, this, f_1584_48913_49046(f_1584_48982_49045(PSInvocationState.Stopped, exception)));
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,48354,49059);

string
f_1584_48797_48835()
{
var return_v =                 RemotingErrorIdStrings.PipelineStopped;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 48797, 48835);
return return_v;
}


System.Management.Automation.Remoting.PSRemotingDataStructureException
f_1584_48742_48836(string
message)
{
var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 48742, 48836);
return return_v;
}


System.Management.Automation.PSInvocationStateInfo
f_1584_48982_49045(System.Management.Automation.PSInvocationState
state,System.Management.Automation.Remoting.PSRemotingDataStructureException
reason)
{
var return_v = new System.Management.Automation.PSInvocationStateInfo( state, (System.Exception)reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 48982, 49045);
return return_v;
}


System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSInvocationStateInfo>
f_1584_48913_49046(System.Management.Automation.PSInvocationStateInfo
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSInvocationStateInfo>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 48913, 49046);
return return_v;
}


int
f_1584_48851_49047(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSInvocationStateInfo>>
eventHandler,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSInvocationStateInfo>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSInvocationStateInfo>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 48851, 49047);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,48354,49059);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,48354,49059);
}
		}

internal void SendHostResponseToServer(RemoteHostResponse hostResponse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,49240,49790);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,49336,49645);

RemoteDataObject<PSObject> 
dataToBeSent =
f_1584_49395_49644(RemotingDestination.Server, RemotingDataType.RemotePowerShellHostResponseData, clientRunspacePoolId, clientPowerShellId, f_1584_49622_49643(                hostResponse))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,49661,49779);

f_1584_49661_49778(f_1584_49661_49700(f_1584_49661_49677()), dataToBeSent, DataPriorityType.PromptResponse);
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,49240,49790);

System.Management.Automation.PSObject
f_1584_49622_49643(System.Management.Automation.Remoting.RemoteHostResponse
this_param)
{
var return_v = this_param.Encode();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 49622, 49643);
return return_v;
}


System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
f_1584_49395_49644(System.Management.Automation.RemotingDestination
destination,System.Management.Automation.RemotingDataType
dataType,System.Guid
runspacePoolId,System.Guid
powerShellId,System.Management.Automation.PSObject
data)
{
var return_v = RemoteDataObject<PSObject>.CreateFrom( destination, dataType, runspacePoolId, powerShellId, data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 49395, 49644);
return return_v;
}


System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
f_1584_49661_49677()
{
var return_v = TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 49661, 49677);
return return_v;
}


System.Management.Automation.Remoting.PrioritySendDataCollection
f_1584_49661_49700(System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
this_param)
{
var return_v = this_param.DataToBeSentCollection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 49661, 49700);
return return_v;
}


int
f_1584_49661_49778(System.Management.Automation.Remoting.PrioritySendDataCollection
this_param,System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
data,System.Management.Automation.Remoting.DataPriorityType
priority)
{
this_param.Add<System.Management.Automation.PSObject>( data, priority);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 49661, 49778);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,49240,49790);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,49240,49790);
}
		}

internal void SendInput(ObjectStreamBase inputstream)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,49995,51389);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,50073,51378) || true) && (f_1584_50077_50096_M(!inputstream.IsOpen)&&(DynAbs.Tracing.TraceSender.Expression_True(1584, 50077, 50122)&&f_1584_50100_50117(inputstream)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,50073,51378);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,50250,50266);
                // there is no input, send an end of input
                // message
                lock (_inputSyncObject)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,50372,50498);

f_1584_50372_50497(this, f_1584_50386_50496(clientRunspacePoolId, clientPowerShellId));
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,50073,51378);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,50073,51378);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,51176,51192);
                // its possible that in client input data is written in a thread
                // other than the current thread. Since we want to write input
                // to the server in the order in which it was received, this
                // operation of writing to the server need to be synced
                // Also we need to ensure that all the data currently available
                // for enumeration are written out before any newly added data
                // is written. Hence the lock is made even before the handler is
                // registered
                lock (_inputSyncObject)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,51234,51298);

inputstream.DataReady += new EventHandler(HandleInputDataReady);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,51320,51344);

f_1584_51320_51343(this, inputstream);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,50073,51378);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,49995,51389);

bool
f_1584_50077_50096_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 50077, 50096);
return return_v;
}


int
f_1584_50100_50117(System.Management.Automation.Internal.ObjectStreamBase
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 50100, 50117);
return return_v;
}


System.Management.Automation.Remoting.RemoteDataObject
f_1584_50386_50496(System.Guid
clientRemoteRunspacePoolId,System.Guid
clientPowerShellId)
{
var return_v = RemotingEncoder.GeneratePowerShellInputEnd( clientRemoteRunspacePoolId, clientPowerShellId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 50386, 50496);
return return_v;
}


int
f_1584_50372_50497(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param,System.Management.Automation.Remoting.RemoteDataObject
data)
{
this_param.SendDataAsync( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 50372, 50497);
return 0;
}


int
f_1584_51320_51343(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param,System.Management.Automation.Internal.ObjectStreamBase
inputstream)
{
this_param.WriteInput( inputstream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 51320, 51343);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,49995,51389);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,49995,51389);
}
		}

internal void ProcessReceivedData(RemoteDataObject<PSObject> receivedData)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,51601,58047);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,51780,52049) || true) && (f_1584_51784_51809(receivedData)!= clientPowerShellId)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,51780,52049);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,51865,52034);

throw f_1584_51871_52033(f_1584_51908_51952(), f_1584_51987_52012(receivedData), clientPowerShellId);
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,51780,52049);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,52128,52271);

f_1584_52128_52270(f_1584_52139_52167(receivedData)== RemotingTargetInterface.PowerShell, "Target interface is expected to be Pipeline");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,52287,58036);

switch (f_1584_52295_52316(receivedData))
            {

case RemotingDataType.PowerShellStateInfo:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,52287,58036);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,52441,52562);

PSInvocationStateInfo 
stateInfo =
f_1584_52504_52561(f_1584_52543_52560(receivedData))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,52590,52747);

f_1584_52590_52746(InvocationStateInfoReceived != null, "ClientRemotePowerShell should subscribe to all data structure handler events");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,52773,52906);

f_1584_52773_52905(                        InvocationStateInfoReceived, this, f_1584_52847_52904(stateInfo));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1584,52953,52959);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,52287,58036);

case RemotingDataType.PowerShellOutput:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,52287,58036);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,53067,53173);

object 
outputObject =
f_1584_53118_53172(f_1584_53154_53171(receivedData))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,53561,53705);

f_1584_53561_53704(OutputReceived != null, "ClientRemotePowerShell should subscribe to all data structure handler events");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,53731,53839);

f_1584_53731_53838(                        OutputReceived, this, f_1584_53792_53837(outputObject));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1584,53886,53892);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,52287,58036);

case RemotingDataType.PowerShellErrorRecord:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,52287,58036);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,54005,54114);

ErrorRecord 
errorRecord =
f_1584_54060_54113(f_1584_54095_54112(receivedData))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,54631,54778);

f_1584_54631_54777(ErrorReceived != null, "ClientRemotePowerShell should subscribe to all data structure handler events");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,54806,54917);

f_1584_54806_54916(
                        ErrorReceived, this, f_1584_54866_54915(errorRecord));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1584,54964,54970);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,52287,58036);

case RemotingDataType.PowerShellDebug:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,52287,58036);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,55075,55150);

DebugRecord 
record = f_1584_55096_55149(f_1584_55131_55148(receivedData))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,55178,55402);

f_1584_55178_55401(
                        InformationalMessageReceived, this, f_1584_55253_55400(f_1584_55333_55399(record, RemotingDataType.PowerShellDebug)));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1584,55449,55455);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,52287,58036);

case RemotingDataType.PowerShellVerbose:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,52287,58036);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,55564,55643);

VerboseRecord 
record = f_1584_55587_55642(f_1584_55624_55641(receivedData))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,55671,55897);

f_1584_55671_55896(
                        InformationalMessageReceived, this, f_1584_55746_55895(f_1584_55826_55894(record, RemotingDataType.PowerShellVerbose)));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1584,55944,55950);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,52287,58036);

case RemotingDataType.PowerShellWarning:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,52287,58036);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,56059,56138);

WarningRecord 
record = f_1584_56082_56137(f_1584_56119_56136(receivedData))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,56166,56392);

f_1584_56166_56391(
                        InformationalMessageReceived, this, f_1584_56241_56390(f_1584_56321_56389(record, RemotingDataType.PowerShellWarning)));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1584,56439,56445);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,52287,58036);

case RemotingDataType.PowerShellProgress:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,52287,58036);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,56555,56636);

ProgressRecord 
record = f_1584_56579_56635(f_1584_56617_56634(receivedData))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,56664,56891);

f_1584_56664_56890(
                        InformationalMessageReceived, this, f_1584_56739_56889(f_1584_56819_56888(record, RemotingDataType.PowerShellProgress)));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1584,56938,56944);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,52287,58036);

case RemotingDataType.PowerShellInformationStream:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,52287,58036);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,57063,57150);

InformationRecord 
record = f_1584_57090_57149(f_1584_57131_57148(receivedData))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,57178,57414);

f_1584_57178_57413(
                        InformationalMessageReceived, this, f_1584_57253_57412(f_1584_57333_57411(record, RemotingDataType.PowerShellInformationStream)));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1584,57461,57467);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,52287,58036);

case RemotingDataType.RemoteHostCallUsingPowerShellHost:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,52287,58036);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,57592,57665);

RemoteHostCall 
remoteHostCall = f_1584_57624_57664(f_1584_57646_57663(receivedData))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,57691,57782);

f_1584_57691_57781(                        HostCallReceived, this, f_1584_57725_57780(remoteHostCall));
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1584,57829,57835);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,52287,58036);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,52287,58036);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,57912,57968);

f_1584_57912_57967(false, "we should not be encountering this");
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1584,58015,58021);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,52287,58036);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,51601,58047);

System.Guid
f_1584_51784_51809(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.PowerShellId ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 51784, 51809);
return return_v;
}


string
f_1584_51908_51952()
{
var return_v = RemotingErrorIdStrings.PipelineIdsDoNotMatch;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 51908, 51952);
return return_v;
}


System.Guid
f_1584_51987_52012(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.PowerShellId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 51987, 52012);
return return_v;
}


System.Management.Automation.Remoting.PSRemotingDataStructureException
f_1584_51871_52033(string
resourceString,params object[]
args)
{
var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 51871, 52033);
return return_v;
}


System.Management.Automation.RemotingTargetInterface
f_1584_52139_52167(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.TargetInterface ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 52139, 52167);
return return_v;
}


int
f_1584_52128_52270(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 52128, 52270);
return 0;
}


System.Management.Automation.RemotingDataType
f_1584_52295_52316(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.DataType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 52295, 52316);
return return_v;
}


System.Management.Automation.PSObject
f_1584_52543_52560(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 52543, 52560);
return return_v;
}


System.Management.Automation.PSInvocationStateInfo
f_1584_52504_52561(System.Management.Automation.PSObject
data)
{
var return_v = RemotingDecoder.GetPowerShellStateInfo( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 52504, 52561);
return return_v;
}


int
f_1584_52590_52746(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 52590, 52746);
return 0;
}


System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSInvocationStateInfo>
f_1584_52847_52904(System.Management.Automation.PSInvocationStateInfo
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSInvocationStateInfo>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 52847, 52904);
return return_v;
}


int
f_1584_52773_52905(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSInvocationStateInfo>>
eventHandler,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSInvocationStateInfo>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSInvocationStateInfo>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 52773, 52905);
return 0;
}


System.Management.Automation.PSObject
f_1584_53154_53171(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 53154, 53171);
return return_v;
}


object
f_1584_53118_53172(System.Management.Automation.PSObject
data)
{
var return_v = RemotingDecoder.GetPowerShellOutput( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 53118, 53172);
return return_v;
}


int
f_1584_53561_53704(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 53561, 53704);
return 0;
}


System.Management.Automation.RemoteDataEventArgs<object>
f_1584_53792_53837(object
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<object>( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 53792, 53837);
return return_v;
}


int
f_1584_53731_53838(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<object>>
eventHandler,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<object>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<object>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 53731, 53838);
return 0;
}


System.Management.Automation.PSObject
f_1584_54095_54112(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 54095, 54112);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1584_54060_54113(System.Management.Automation.PSObject
data)
{
var return_v = RemotingDecoder.GetPowerShellError( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 54060, 54113);
return return_v;
}


int
f_1584_54631_54777(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 54631, 54777);
return 0;
}


System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.ErrorRecord>
f_1584_54866_54915(System.Management.Automation.ErrorRecord
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.ErrorRecord>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 54866, 54915);
return return_v;
}


int
f_1584_54806_54916(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.ErrorRecord>>
eventHandler,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.ErrorRecord>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.ErrorRecord>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 54806, 54916);
return 0;
}


System.Management.Automation.PSObject
f_1584_55131_55148(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 55131, 55148);
return return_v;
}


System.Management.Automation.DebugRecord
f_1584_55096_55149(System.Management.Automation.PSObject
data)
{
var return_v = RemotingDecoder.GetPowerShellDebug( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 55096, 55149);
return return_v;
}


System.Management.Automation.Internal.InformationalMessage
f_1584_55333_55399(System.Management.Automation.DebugRecord
message,System.Management.Automation.RemotingDataType
dataType)
{
var return_v = new System.Management.Automation.Internal.InformationalMessage( (object)message, dataType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 55333, 55399);
return return_v;
}


System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>
f_1584_55253_55400(System.Management.Automation.Internal.InformationalMessage
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 55253, 55400);
return return_v;
}


int
f_1584_55178_55401(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>>
eventHandler,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 55178, 55401);
return 0;
}


System.Management.Automation.PSObject
f_1584_55624_55641(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 55624, 55641);
return return_v;
}


System.Management.Automation.VerboseRecord
f_1584_55587_55642(System.Management.Automation.PSObject
data)
{
var return_v = RemotingDecoder.GetPowerShellVerbose( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 55587, 55642);
return return_v;
}


System.Management.Automation.Internal.InformationalMessage
f_1584_55826_55894(System.Management.Automation.VerboseRecord
message,System.Management.Automation.RemotingDataType
dataType)
{
var return_v = new System.Management.Automation.Internal.InformationalMessage( (object)message, dataType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 55826, 55894);
return return_v;
}


System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>
f_1584_55746_55895(System.Management.Automation.Internal.InformationalMessage
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 55746, 55895);
return return_v;
}


int
f_1584_55671_55896(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>>
eventHandler,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 55671, 55896);
return 0;
}


System.Management.Automation.PSObject
f_1584_56119_56136(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 56119, 56136);
return return_v;
}


System.Management.Automation.WarningRecord
f_1584_56082_56137(System.Management.Automation.PSObject
data)
{
var return_v = RemotingDecoder.GetPowerShellWarning( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 56082, 56137);
return return_v;
}


System.Management.Automation.Internal.InformationalMessage
f_1584_56321_56389(System.Management.Automation.WarningRecord
message,System.Management.Automation.RemotingDataType
dataType)
{
var return_v = new System.Management.Automation.Internal.InformationalMessage( (object)message, dataType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 56321, 56389);
return return_v;
}


System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>
f_1584_56241_56390(System.Management.Automation.Internal.InformationalMessage
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 56241, 56390);
return return_v;
}


int
f_1584_56166_56391(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>>
eventHandler,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 56166, 56391);
return 0;
}


System.Management.Automation.PSObject
f_1584_56617_56634(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 56617, 56634);
return return_v;
}


System.Management.Automation.ProgressRecord
f_1584_56579_56635(System.Management.Automation.PSObject
data)
{
var return_v = RemotingDecoder.GetPowerShellProgress( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 56579, 56635);
return return_v;
}


System.Management.Automation.Internal.InformationalMessage
f_1584_56819_56888(System.Management.Automation.ProgressRecord
message,System.Management.Automation.RemotingDataType
dataType)
{
var return_v = new System.Management.Automation.Internal.InformationalMessage( (object)message, dataType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 56819, 56888);
return return_v;
}


System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>
f_1584_56739_56889(System.Management.Automation.Internal.InformationalMessage
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 56739, 56889);
return return_v;
}


int
f_1584_56664_56890(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>>
eventHandler,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 56664, 56890);
return 0;
}


System.Management.Automation.PSObject
f_1584_57131_57148(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 57131, 57148);
return return_v;
}


System.Management.Automation.InformationRecord
f_1584_57090_57149(System.Management.Automation.PSObject
data)
{
var return_v = RemotingDecoder.GetPowerShellInformation( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 57090, 57149);
return return_v;
}


System.Management.Automation.Internal.InformationalMessage
f_1584_57333_57411(System.Management.Automation.InformationRecord
message,System.Management.Automation.RemotingDataType
dataType)
{
var return_v = new System.Management.Automation.Internal.InformationalMessage( (object)message, dataType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 57333, 57411);
return return_v;
}


System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>
f_1584_57253_57412(System.Management.Automation.Internal.InformationalMessage
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 57253, 57412);
return return_v;
}


int
f_1584_57178_57413(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>>
eventHandler,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 57178, 57413);
return 0;
}


System.Management.Automation.PSObject
f_1584_57646_57663(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 57646, 57663);
return return_v;
}


System.Management.Automation.Remoting.RemoteHostCall
f_1584_57624_57664(System.Management.Automation.PSObject
data)
{
var return_v = RemoteHostCall.Decode( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 57624, 57664);
return return_v;
}


System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>
f_1584_57725_57780(System.Management.Automation.Remoting.RemoteHostCall
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 57725, 57780);
return return_v;
}


int
f_1584_57691_57781(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>>
eventHandler,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 57691, 57781);
return 0;
}


int
f_1584_57912_57967(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 57912, 57967);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,51601,58047);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,51601,58047);
}
		}

internal void SetStateToFailed(Exception reason)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,58471,58819);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,58544,58696);

f_1584_58544_58695(BrokenNotificationFromRunspacePool != null, "ClientRemotePowerShell should subscribe to all data structure handler events");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,58712,58808);

f_1584_58712_58807(
            BrokenNotificationFromRunspacePool, this, f_1584_58764_58806(reason));
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,58471,58819);

int
f_1584_58544_58695(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 58544, 58695);
return 0;
}


System.Management.Automation.RemoteDataEventArgs<System.Exception>
f_1584_58764_58806(System.Exception
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Exception>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 58764, 58806);
return return_v;
}


int
f_1584_58712_58807(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Exception>>
eventHandler,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Exception>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Exception>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 58712, 58807);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,58471,58819);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,58471,58819);
}
		}

internal void SetStateToStopped(Exception reason)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,59051,59400);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,59125,59277);

f_1584_59125_59276(ClosedNotificationFromRunspacePool != null, "ClientRemotePowerShell should subscribe to all data structure handler events");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,59293,59389);

f_1584_59293_59388(
            ClosedNotificationFromRunspacePool, this, f_1584_59345_59387(reason));
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,59051,59400);

int
f_1584_59125_59276(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 59125, 59276);
return 0;
}


System.Management.Automation.RemoteDataEventArgs<System.Exception>
f_1584_59345_59387(System.Exception
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Exception>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 59345, 59387);
return return_v;
}


int
f_1584_59293_59388(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Exception>>
eventHandler,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Exception>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Exception>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 59293, 59388);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,59051,59400);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,59051,59400);
}
		}

internal void CloseConnectionAsync(Exception sessionCloseReason)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,59498,60533);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,59587,59629);

_sessionClosedReason = sessionCloseReason;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,59731,60476);

f_1584_59731_59747().CloseCompleted += delegate (object source, EventArgs args)
            {
                if (CloseCompleted != null)
                {
                    // If the provided event args are empty then call CloseCompleted with
                    // RemoteSessionStateEventArgs containing session closed reason exception.
                    EventArgs closeCompletedEventArgs = (args == EventArgs.Empty) ?
                        new RemoteSessionStateEventArgs(new RemoteSessionStateInfo(RemoteSessionState.Closed, _sessionClosedReason)) :
                        args;

                    CloseCompleted(this, closeCompletedEventArgs);
                }

                TransportManager.Dispose();
            };
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,60492,60522);

f_1584_60492_60521(f_1584_60492_60508());
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,59498,60533);

System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
f_1584_59731_59747()
{
var return_v = TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 59731, 59747);
return return_v;
}


System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
f_1584_60492_60508()
{
var return_v = TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 60492, 60508);
return return_v;
}


int
f_1584_60492_60521(System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
this_param)
{
this_param.CloseAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 60492, 60521);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,59498,60533);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,59498,60533);
}
		}

internal void RaiseRemoveAssociationEvent()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,60810,60941);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,60878,60930);

f_1584_60878_60929(            RemoveAssociation, this, EventArgs.Empty);
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,60810,60941);

int
f_1584_60878_60929(System.EventHandler
eventHandler,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
sender,System.EventArgs
eventArgs)
{
eventHandler.SafeInvoke( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 60878, 60929);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,60810,60941);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,60810,60941);
}
		}

internal void ProcessDisconnect(RunspacePoolStateInfo rsStateInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,61146,61969);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,61322,61527);

PSInvocationStateInfo 
stateInfo =
f_1584_61385_61526(PSInvocationState.Disconnected, (DynAbs.Tracing.TraceSender.Conditional_F1(1584, 61476, 61497)||((                                (rsStateInfo != null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1584, 61500, 61518))||DynAbs.Tracing.TraceSender.Conditional_F3(1584, 61521, 61525)))?f_1584_61500_61518(rsStateInfo):null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,61543,61688);

f_1584_61543_61687(InvocationStateInfoReceived != null, "ClientRemotePowerShell should subscribe to all data structure handler events");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,61702,61823);

f_1584_61702_61822(            InvocationStateInfoReceived, this, f_1584_61764_61821(stateInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,61839,61958);

f_1584_61839_61957(ref _connectionState, connectionStates.Disconnected, connectionStates.Connected);
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,61146,61969);

System.Exception
f_1584_61500_61518(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.Reason ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 61500, 61518);
return return_v;
}


System.Management.Automation.PSInvocationStateInfo
f_1584_61385_61526(System.Management.Automation.PSInvocationState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.PSInvocationStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 61385, 61526);
return return_v;
}


int
f_1584_61543_61687(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 61543, 61687);
return 0;
}


System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSInvocationStateInfo>
f_1584_61764_61821(System.Management.Automation.PSInvocationStateInfo
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSInvocationStateInfo>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 61764, 61821);
return return_v;
}


int
f_1584_61702_61822(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSInvocationStateInfo>>
eventHandler,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSInvocationStateInfo>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSInvocationStateInfo>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 61702, 61822);
return 0;
}


int
f_1584_61839_61957(ref int
location1,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler.connectionStates
value,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler.connectionStates
comparand)
{
var return_v = Interlocked.CompareExchange( ref location1, (int)value, (int)comparand);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 61839, 61957);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,61146,61969);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,61146,61969);
}
		}

internal void ReconnectAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,62417,62949);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,62472,62613);

int 
currentState = f_1584_62491_62612(ref _connectionState, connectionStates.Reconnecting, connectionStates.Disconnected)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,62627,62888) || true) && ((currentState != (int)connectionStates.Disconnected))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,62627,62888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,62717,62792);

f_1584_62717_62791(false, "Pipeline DS Handler is in unexpected connection state");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,62866,62873);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,62627,62888);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,62904,62938);

f_1584_62904_62937(f_1584_62904_62920());
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,62417,62949);

int
f_1584_62491_62612(ref int
location1,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler.connectionStates
value,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler.connectionStates
comparand)
{
var return_v = Interlocked.CompareExchange( ref location1, (int)value, (int)comparand);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 62491, 62612);
return return_v;
}


int
f_1584_62717_62791(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 62717, 62791);
return 0;
}


System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
f_1584_62904_62920()
{
var return_v = TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 62904, 62920);
return return_v;
}


int
f_1584_62904_62937(System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
this_param)
{
this_param.ReconnectAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 62904, 62937);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,62417,62949);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,62417,62949);
}
		}

internal void ConnectAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,63046,63482);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,63099,63238);

int 
currentState = f_1584_63118_63237(ref _connectionState, connectionStates.Connecting, connectionStates.Disconnected)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,63396,63425);

f_1584_63396_63424(this, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,63439,63471);

f_1584_63439_63470(f_1584_63439_63455());
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,63046,63482);

int
f_1584_63118_63237(ref int
location1,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler.connectionStates
value,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler.connectionStates
comparand)
{
var return_v = Interlocked.CompareExchange( ref location1, (int)value, (int)comparand);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 63118, 63237);
return return_v;
}


int
f_1584_63396_63424(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param,bool
inDisconnectMode)
{
this_param.SetupTransportManager( inDisconnectMode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 63396, 63424);
return 0;
}


System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
f_1584_63439_63455()
{
var return_v = TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 63439, 63455);
return return_v;
}


int
f_1584_63439_63470(System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
this_param)
{
this_param.ConnectAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 63439, 63470);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,63046,63482);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,63046,63482);
}
		}

internal void ProcessRobustConnectionNotification(
            ConnectionStatusEventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,63681,63909);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,63849,63898);

f_1584_63849_63897(            // Raise event for PowerShell client.
            RobustConnectionNotification, this, e);
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,63681,63909);

int
f_1584_63849_63897(System.EventHandler<System.Management.Automation.Remoting.ConnectionStatusEventArgs>
eventHandler,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
sender,System.Management.Automation.Remoting.ConnectionStatusEventArgs
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.Remoting.ConnectionStatusEventArgs>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 63849, 63897);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,63681,63909);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,63681,63909);
}
		}

protected Guid clientRunspacePoolId;

protected Guid clientPowerShellId;

internal ClientPowerShellDataStructureHandler(BaseClientCommandTransportManager transportManager,
                    Guid clientRunspacePoolId, Guid clientPowerShellId)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1584,64684,65145);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,65654,65722);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,69487,69518);
this._inputSyncObject = f_1584_69506_69518();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,69685,69735);
this._connectionState = (int)connectionStates.Connected;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,69873,69893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,64879,64915);

TransportManager = transportManager;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,64929,64978);

this.clientRunspacePoolId = clientRunspacePoolId;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,64992,65037);

this.clientPowerShellId = clientPowerShellId;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,65051,65134);

transportManager.SignalCompleted += new EventHandler<EventArgs>(OnSignalCompleted);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1584,64684,65145);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,64684,65145);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,64684,65145);
}
		}

internal Guid PowerShellId
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,65439,65516);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,65475,65501);

return clientPowerShellId;
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,65439,65516);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,65388,65527);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,65388,65527);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal BaseClientCommandTransportManager TransportManager {get; }

private void SendDataAsync(RemoteDataObject data)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,66152,66388);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,66226,66297);

RemoteDataObject<object> 
dataToBeSent = (RemoteDataObject<object>)data
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,66311,66377);

f_1584_66311_66376(f_1584_66311_66350(f_1584_66311_66327()), dataToBeSent);
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,66152,66388);

System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
f_1584_66311_66327()
{
var return_v = TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 66311, 66327);
return return_v;
}


System.Management.Automation.Remoting.PrioritySendDataCollection
f_1584_66311_66350(System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
this_param)
{
var return_v = this_param.DataToBeSentCollection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 66311, 66350);
return return_v;
}


int
f_1584_66311_66376(System.Management.Automation.Remoting.PrioritySendDataCollection
this_param,System.Management.Automation.Remoting.RemoteDataObject<object>
data)
{
this_param.Add<object>( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 66311, 66376);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,66152,66388);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,66152,66388);
}
		}

private void HandleInputDataReady(object sender, EventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,66624,66956);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,66780,66796);
            // make sure only one thread calls the WriteInput.
            lock (_inputSyncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,66830,66888);

ObjectStreamBase 
inputstream = sender as ObjectStreamBase
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,66906,66930);

f_1584_66906_66929(this, inputstream);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,66624,66956);

int
f_1584_66906_66929(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param,System.Management.Automation.Internal.ObjectStreamBase
inputstream)
{
this_param.WriteInput( inputstream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 66906, 66929);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,66624,66956);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,66624,66956);
}
		}

private void WriteInput(ObjectStreamBase inputstream)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,67201,68576);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,67279,67370);

Collection<object> 
inputObjects = f_1584_67313_67369(f_1584_67313_67337(inputstream), Int32.MaxValue)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,67386,67609);
foreach(object inputObject in f_1584_67417_67429_I(inputObjects) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,67386,67609);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,67463,67594);

f_1584_67463_67593(this, f_1584_67477_67592(inputObject, clientRunspacePoolId, clientPowerShellId));
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,67386,67609);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1584,1,224);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1584,1,224);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,67625,68565) || true) && (f_1584_67629_67648_M(!inputstream.IsOpen))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,67625,68565);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,67763,67835);

inputObjects = f_1584_67778_67834(f_1584_67778_67802(inputstream), Int32.MaxValue);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,67855,68094);
foreach(object inputObject in f_1584_67886_67898_I(inputObjects) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1584,67855,68094);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,67940,68075);

f_1584_67940_68074(this, f_1584_67954_68073(inputObject, clientRunspacePoolId, clientPowerShellId));
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,67855,68094);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1584,1,240);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1584,1,240);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,68312,68358);

inputstream.DataReady -= HandleInputDataReady;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,68428,68550);

f_1584_68428_68549(this, f_1584_68442_68548(clientRunspacePoolId, clientPowerShellId));
DynAbs.Tracing.TraceSender.TraceExitCondition(1584,67625,68565);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,67201,68576);

System.Management.Automation.Runspaces.PipelineReader<object>
f_1584_67313_67337(System.Management.Automation.Internal.ObjectStreamBase
this_param)
{
var return_v = this_param.ObjectReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 67313, 67337);
return return_v;
}


System.Collections.ObjectModel.Collection<object>
f_1584_67313_67369(System.Management.Automation.Runspaces.PipelineReader<object>
this_param,int
maxRequested)
{
var return_v = this_param.NonBlockingRead( maxRequested);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 67313, 67369);
return return_v;
}


System.Management.Automation.Remoting.RemoteDataObject
f_1584_67477_67592(object
data,System.Guid
clientRemoteRunspacePoolId,System.Guid
clientPowerShellId)
{
var return_v = RemotingEncoder.GeneratePowerShellInput( data, clientRemoteRunspacePoolId, clientPowerShellId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 67477, 67592);
return return_v;
}


int
f_1584_67463_67593(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param,System.Management.Automation.Remoting.RemoteDataObject
data)
{
this_param.SendDataAsync( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 67463, 67593);
return 0;
}


System.Collections.ObjectModel.Collection<object>
f_1584_67417_67429_I(System.Collections.ObjectModel.Collection<object>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 67417, 67429);
return return_v;
}


bool
f_1584_67629_67648_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 67629, 67648);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1584_67778_67802(System.Management.Automation.Internal.ObjectStreamBase
this_param)
{
var return_v = this_param.ObjectReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 67778, 67802);
return return_v;
}


System.Collections.ObjectModel.Collection<object>
f_1584_67778_67834(System.Management.Automation.Runspaces.PipelineReader<object>
this_param,int
maxRequested)
{
var return_v = this_param.NonBlockingRead( maxRequested);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 67778, 67834);
return return_v;
}


System.Management.Automation.Remoting.RemoteDataObject
f_1584_67954_68073(object
data,System.Guid
clientRemoteRunspacePoolId,System.Guid
clientPowerShellId)
{
var return_v = RemotingEncoder.GeneratePowerShellInput( data, clientRemoteRunspacePoolId, clientPowerShellId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 67954, 68073);
return return_v;
}


int
f_1584_67940_68074(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param,System.Management.Automation.Remoting.RemoteDataObject
data)
{
this_param.SendDataAsync( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 67940, 68074);
return 0;
}


System.Collections.ObjectModel.Collection<object>
f_1584_67886_67898_I(System.Collections.ObjectModel.Collection<object>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 67886, 67898);
return return_v;
}


System.Management.Automation.Remoting.RemoteDataObject
f_1584_68442_68548(System.Guid
clientRemoteRunspacePoolId,System.Guid
clientPowerShellId)
{
var return_v = RemotingEncoder.GeneratePowerShellInputEnd( clientRemoteRunspacePoolId, clientPowerShellId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 68442, 68548);
return return_v;
}


int
f_1584_68428_68549(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param,System.Management.Automation.Remoting.RemoteDataObject
data)
{
this_param.SendDataAsync( data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 68428, 68549);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,67201,68576);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,67201,68576);
}
		}

private void SetupTransportManager(bool inDisconnectMode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1584,68817,69300);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,68899,68967);

f_1584_68899_68915().WSManTransportErrorOccured += HandleTransportError;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,68981,69045);

f_1584_68981_68997().ReconnectCompleted += HandleReconnectCompleted;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,69059,69119);

f_1584_69059_69075().ConnectCompleted += HandleConnectCompleted;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,69133,69215);

f_1584_69133_69149().DelayStreamRequestProcessed += HandleDelayStreamRequestProcessed;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,69229,69289);

f_1584_69229_69245().startInDisconnectedMode = inDisconnectMode;
DynAbs.Tracing.TraceSender.TraceExitMethod(1584,68817,69300);

System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
f_1584_68899_68915()
{
var return_v = TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 68899, 68915);
return return_v;
}


System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
f_1584_68981_68997()
{
var return_v = TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 68981, 68997);
return return_v;
}


System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
f_1584_69059_69075()
{
var return_v = TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 69059, 69075);
return return_v;
}


System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
f_1584_69133_69149()
{
var return_v = TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 69133, 69149);
return return_v;
}


System.Management.Automation.Remoting.Client.BaseClientCommandTransportManager
f_1584_69229_69245()
{
var return_v = TransportManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1584, 69229, 69245);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,68817,69300);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,68817,69300);
}
		}

private object _inputSyncObject ;

        private enum connectionStates
        {
            Connected = 1, Disconnected = 3, Reconnecting = 4, Connecting = 5
        }

private int _connectionState ;

private Exception _sessionClosedReason;

static ClientPowerShellDataStructureHandler()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1584,41786,69939);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1584,41786,69939);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,41786,69939);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1584,41786,69939);

object
f_1584_69506_69518()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1584, 69506, 69518);
return return_v;
}

}
internal class InformationalMessage
{
internal object Message {get; }

internal RemotingDataType DataType {get; }

internal InformationalMessage(object message, RemotingDataType dataType)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1584,70098,70258);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,69999,70031);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,70043,70086);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,70195,70215);

DataType = dataType;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1584,70229,70247);

Message = message;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1584,70098,70258);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1584,70098,70258);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,70098,70258);
}
		}

static InformationalMessage()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1584,69947,70265);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1584,69947,70265);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1584,69947,70265);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1584,69947,70265);
}
}
