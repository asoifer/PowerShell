// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting;
using System.Management.Automation.Remoting.Client;
using System.Management.Automation.Tracing;
using System.Threading;
using Microsoft.PowerShell.Telemetry;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Runspaces.Internal
{
internal class RemoteRunspacePoolInternal : RunspacePoolInternal, IDisposable
{
internal RemoteRunspacePoolInternal(int minRunspaces,
            int maxRunspaces, TypeTable typeTable, PSHost host, PSPrimitiveDictionary applicationArguments, RunspaceConnectionInfo connectionInfo, string name = null)
:base(f_1581_3129_3141_C(minRunspaces) ,maxRunspaces)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1581,2887,4236);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,10229,10319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,10514,10581);
this.ConnectCommands = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,11004,11062);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,12605,12694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,26598,26658);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,28756,28779);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,28815,28876);
this._applicationPrivateDataReceived = f_1581_28849_28876(false);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,77402,77417);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,77575,77591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,77690,77707);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,77795,77809);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,77915,77937);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,78031,78052);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,78127,78138);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,78151,78203);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,78228,78241);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,78267,78295);
this._friendlyName = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,78374,78393);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,3181,3324) || true) && (connectionInfo == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,3181,3324);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,3241,3309);

throw f_1581_3247_3308("WSManConnectionInfo");
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,3181,3324);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,3340,3711);

f_1581_3340_3710(PSEventId.RunspacePoolConstructor, PSOpcode.Constructor, PSTask.CreateRunspace, PSKeyword.UseAlwaysOperational, instanceId.ToString(), f_1581_3590_3638(                    minPoolSz, f_1581_3609_3637()), f_1581_3661_3709(                    maxPoolSz, f_1581_3680_3708()));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,3727,3775);

_connectionInfo = f_1581_3745_3774(connectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,3791,3808);

this.host = host;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,3822,3866);

ApplicationArguments = applicationArguments;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,3880,3911);

AvailableForConnection = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,3925,3969);

DispatchTable = f_1581_3941_3968();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,3983,4069);

_runningPowerShells = f_1581_4005_4068();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,4085,4182) || true) && (!f_1581_4090_4116(name))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,4085,4182);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,4150,4167);

this.Name = name;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,4085,4182);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,4198,4225);

f_1581_4198_4224(this, typeTable);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1581,2887,4236);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,2887,4236);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,2887,4236);
}
		}

internal RemoteRunspacePoolInternal(Guid instanceId, string name, bool isDisconnected,
            ConnectCommandInfo[] connectCommands, RunspaceConnectionInfo connectionInfo, PSHost host, TypeTable typeTable)
:base(f_1581_5203_5204_C(1) ,1)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1581,4972,7316);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,10229,10319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,10514,10581);
this.ConnectCommands = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,11004,11062);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,12605,12694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,26598,26658);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,28756,28779);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,28815,28876);
this._applicationPrivateDataReceived = f_1581_28849_28876(false);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,77402,77417);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,77575,77591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,77690,77707);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,77795,77809);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,77915,77937);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,78031,78052);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,78127,78138);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,78151,78203);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,78228,78241);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,78267,78295);
this._friendlyName = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,78374,78393);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,5233,5370) || true) && (instanceId == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,5233,5370);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,5289,5355);

throw f_1581_5295_5354("RunspacePool Guid");
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,5233,5370);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,5386,5531) || true) && (connectCommands == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,5386,5531);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,5447,5516);

throw f_1581_5453_5515("ConnectCommandInfo[]");
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,5386,5531);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,5547,5690) || true) && (connectionInfo == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,5547,5690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,5607,5675);

throw f_1581_5613_5674("WSManConnectionInfo");
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,5547,5690);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,5706,5974) || true) && (connectionInfo is WSManConnectionInfo)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,5706,5974);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,5781,5829);

_connectionInfo = f_1581_5799_5828(connectionInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,5706,5974);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,5706,5974);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,5895,5959);

f_1581_5895_5958(false, "ConnectionInfo must be WSManConnectionInfo");
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,5706,5974);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,6089,6118);

this.instanceId = instanceId;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,6331,6351);

this.minPoolSz = -1;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,6365,6385);

this.maxPoolSz = -1;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,6401,6772);

f_1581_6401_6771(PSEventId.RunspacePoolConstructor, PSOpcode.Constructor, PSTask.CreateRunspace, PSKeyword.UseAlwaysOperational, instanceId.ToString(), f_1581_6651_6699(                    minPoolSz, f_1581_6670_6698()), f_1581_6722_6770(                    maxPoolSz, f_1581_6741_6769()));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,6788,6822);

ConnectCommands = connectCommands;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,6836,6853);

this.Name = name;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,6867,6884);

this.host = host;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,6898,6942);

DispatchTable = f_1581_6914_6941();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,6956,7042);

_runningPowerShells = f_1581_6978_7041();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,7120,7206);

f_1581_7120_7205(this, f_1581_7141_7204(RunspacePoolState.Disconnected, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,7222,7249);

f_1581_7222_7248(this, typeTable);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,7265,7305);

AvailableForConnection = isDisconnected;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1581,4972,7316);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,4972,7316);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,4972,7316);
}
		}

private void CreateDSHandler(TypeTable typeTable)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,7464,9714);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,7538,7621);

DataStructureHandler = f_1581_7561_7620(this, typeTable);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,7705,7846);

f_1581_7705_7725().RemoteHostCallReceived +=
                new EventHandler<RemoteDataEventArgs<RemoteHostCall>>(HandleRemoteHostCalls);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,7860,8005);

f_1581_7860_7880().StateInfoReceived +=
                new EventHandler<RemoteDataEventArgs<RunspacePoolStateInfo>>(HandleStateInfoReceived);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,8019,8167);

f_1581_8019_8039().RSPoolInitInfoReceived +=
                new EventHandler<RemoteDataEventArgs<RunspacePoolInitInfo>>(HandleInitInfoReceived);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,8181,8352);

f_1581_8181_8201().ApplicationPrivateDataReceived +=
                new EventHandler<RemoteDataEventArgs<PSPrimitiveDictionary>>(HandleApplicationPrivateDataReceived);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,8366,8493);

f_1581_8366_8386().SessionClosing +=
                new EventHandler<RemoteDataEventArgs<Exception>>(HandleSessionClosing);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,8507,8632);

f_1581_8507_8527().SessionClosed +=
                new EventHandler<RemoteDataEventArgs<Exception>>(HandleSessionClosed);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,8646,8794);

f_1581_8646_8666().SetMaxMinRunspacesResponseReceived +=
                new EventHandler<RemoteDataEventArgs<PSObject>>(HandleResponseReceived);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,8808,8943);

f_1581_8808_8828().URIRedirectionReported +=
                new EventHandler<RemoteDataEventArgs<Uri>>(HandleURIDirectionReported);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,8957,9096);

f_1581_8957_8977().PSEventArgsReceived +=
                new EventHandler<RemoteDataEventArgs<PSEventArgs>>(HandlePSEventArgsReceived);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,9110,9247);

f_1581_9110_9130().SessionDisconnected +=
                new EventHandler<RemoteDataEventArgs<Exception>>(HandleSessionDisconnected);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,9261,9396);

f_1581_9261_9281().SessionReconnected +=
                new EventHandler<RemoteDataEventArgs<Exception>>(HandleSessionReconnected);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,9410,9553);

f_1581_9410_9430().SessionRCDisconnecting +=
                new EventHandler<RemoteDataEventArgs<Exception>>(HandleSessionRCDisconnecting);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,9567,9703);

f_1581_9567_9587().SessionCreateCompleted +=
                new EventHandler<CreateCompleteEventArgs>(HandleSessionCreateCompleted);
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,7464,9714);

System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_7561_7620(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
clientRunspacePool,System.Management.Automation.Runspaces.TypeTable
typeTable)
{
var return_v = new System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler( clientRunspacePool, typeTable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 7561, 7620);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_7705_7725()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 7705, 7725);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_7860_7880()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 7860, 7880);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_8019_8039()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 8019, 8039);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_8181_8201()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 8181, 8201);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_8366_8386()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 8366, 8386);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_8507_8527()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 8507, 8527);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_8646_8666()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 8646, 8666);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_8808_8828()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 8808, 8828);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_8957_8977()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 8957, 8977);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_9110_9130()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 9110, 9130);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_9261_9281()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 9261, 9281);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_9410_9430()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 9410, 9430);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_9567_9587()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 9567, 9587);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,7464,9714);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,7464,9714);
}
		}

public override RunspaceConnectionInfo ConnectionInfo
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,9980,10054);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,10016,10039);

return _connectionInfo;
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,9980,10054);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,9902,10065);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,9902,10065);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal ClientRunspacePoolDataStructureHandler DataStructureHandler {get; private set; }

internal ConnectCommandInfo[] ConnectCommands {get; set; }

internal string Name
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,10759,10788);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,10765,10786);

return _friendlyName;
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,10759,10788);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,10714,10861);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,10714,10861);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,10804,10850);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,10810,10848);

_friendlyName = value ??(DynAbs.Tracing.TraceSender.Expression_Null<string>(1581, 10826, 10847)??string.Empty);
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,10804,10850);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,10714,10861);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,10714,10861);
}
		}}

internal bool AvailableForConnection {get; private set; }

internal int MaxRetryConnectionTime
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,11256,11395);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,11292,11380);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1581, 11299, 11329)||(((f_1581_11300_11320()!= null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1581, 11332, 11375))||DynAbs.Tracing.TraceSender.Conditional_F3(1581, 11378, 11379)))?f_1581_11332_11375(f_1581_11332_11352()):0;
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,11256,11395);

System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_11300_11320()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 11300, 11320);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_11332_11352()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 11332, 11352);
return return_v;
}


int
f_1581_11332_11375(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param)
{
var return_v = this_param.MaxRetryConnectionTime ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 11332, 11375);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,11196,11406);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,11196,11406);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override RunspacePoolAvailability RunspacePoolAvailability
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,11604,12412);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,11640,11678);

RunspacePoolAvailability 
availability
=default(RunspacePoolAvailability);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,11696,12357) || true) && (f_1581_11700_11715(stateInfo)== RunspacePoolState.Disconnected)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,11696,12357);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,11928,12149);

availability = (DynAbs.Tracing.TraceSender.Conditional_F1(1581, 11943, 11967)||(((f_1581_11944_11966()) &&DynAbs.Tracing.TraceSender.Conditional_F2(1581, 11999, 12028))||DynAbs.Tracing.TraceSender.Conditional_F3(1581, 12119, 12148)))?                            RunspacePoolAvailability.None :                            RunspacePoolAvailability.Busy;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,11696,12357);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,11696,12357);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,12293,12338);

availability = DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.RunspacePoolAvailability,1581,12308,12337);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,11696,12357);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,12377,12397);

return availability;
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,11604,12412);

System.Management.Automation.Runspaces.RunspacePoolState
f_1581_11700_11715(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 11700, 11715);
return return_v;
}


bool
f_1581_11944_11966()
{
var return_v = AvailableForConnection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 11944, 11966);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,11514,12423);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,11514,12423);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool IsRemoteDebugStop
{            set;
            get;
}

internal override bool ResetRunspaceState()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,13028,14038);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,13218,13292);

Version 
remoteProtocolVersionDeclaredByServer = f_1581_13266_13291()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,13306,13619) || true) && ((remoteProtocolVersionDeclaredByServer == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1581, 13310, 13461)||                (remoteProtocolVersionDeclaredByServer < RemotingConstants.ProtocolVersionWin10RTM)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,13306,13619);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,13495,13604);

throw f_1581_13501_13603(f_1581_13544_13602());
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,13306,13619);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,13635,13651);

long 
callId = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,13673,13683);

            lock (syncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,13717,13758);

callId = f_1581_13726_13757(f_1581_13726_13739());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,13776,13836);

f_1581_13776_13835(f_1581_13776_13796(), callId);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,13932,13991);

object 
response = f_1581_13950_13990(f_1581_13950_13963(), callId, false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,14005,14027);

return (bool)response;
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,13028,14038);

System.Version
f_1581_13266_13291()
{
var return_v = PSRemotingProtocolVersion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 13266, 13291);
return return_v;
}


string
f_1581_13544_13602()
{
var return_v = RunspacePoolStrings.ResetRunspaceStateNotSupportedOnServer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 13544, 13602);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1581_13501_13603(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 13501, 13603);
return return_v;
}


System.Management.Automation.Remoting.DispatchTable<object>
f_1581_13726_13739()
{
var return_v = DispatchTable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 13726, 13739);
return return_v;
}


long
f_1581_13726_13757(System.Management.Automation.Remoting.DispatchTable<object>
this_param)
{
var return_v = this_param.CreateNewCallId();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 13726, 13757);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_13776_13796()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 13776, 13796);
return return_v;
}


int
f_1581_13776_13835(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,long
callId)
{
this_param.SendResetRunspaceStateToServer( callId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 13776, 13835);
return 0;
}


System.Management.Automation.Remoting.DispatchTable<object>
f_1581_13950_13963()
{
var return_v = DispatchTable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 13950, 13963);
return return_v;
}


object
f_1581_13950_13990(System.Management.Automation.Remoting.DispatchTable<object>
this_param,long
callId,bool
defaultValue)
{
var return_v = this_param.GetResponse( callId, (object)defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 13950, 13990);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,13028,14038);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,13028,14038);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool SetMaxRunspaces(int maxRunspaces)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,14690,16500);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,14771,14800);

bool 
isSizeIncreased = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,14814,14830);

long 
callId = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,14852,14862);

            lock (syncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,14896,15190) || true) && (maxRunspaces < minPoolSz ||(DynAbs.Tracing.TraceSender.Expression_False(1581, 14900, 14953)||maxRunspaces == maxPoolSz )||(DynAbs.Tracing.TraceSender.Expression_False(1581, 14900, 15000)||f_1581_14957_14972(stateInfo)== RunspacePoolState.Closed
)||(DynAbs.Tracing.TraceSender.Expression_False(1581, 14900, 15069)||f_1581_15025_15040(stateInfo)== RunspacePoolState.Closing )||(DynAbs.Tracing.TraceSender.Expression_False(1581, 14900, 15116)||f_1581_15073_15088(stateInfo)== RunspacePoolState.Broken))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,14896,15190);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,15158,15171);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,14896,15190);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,15399,15644) || true) && (f_1581_15403_15418(stateInfo)== RunspacePoolState.BeforeOpen ||(DynAbs.Tracing.TraceSender.Expression_False(1581, 15403, 15524)||f_1581_15475_15490(stateInfo)== RunspacePoolState.Disconnected))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,15399,15644);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,15566,15591);

maxPoolSz = maxRunspaces;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,15613,15625);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,15399,15644);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,15929,15970);

callId = f_1581_15938_15969(f_1581_15938_15951());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,15990,16061);

f_1581_15990_16060(f_1581_15990_16010(), maxRunspaces, callId);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,16156,16215);

object 
response = f_1581_16174_16214(f_1581_16174_16187(), callId, false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,16231,16264);

isSizeIncreased = (bool)response;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,16280,16450) || true) && (isSizeIncreased)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,16280,16450);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,16339,16349);
                lock (syncObject)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,16391,16416);

maxPoolSz = maxRunspaces;
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,16280,16450);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,16466,16489);

return isSizeIncreased;
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,14690,16500);

System.Management.Automation.Runspaces.RunspacePoolState
f_1581_14957_14972(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 14957, 14972);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_15025_15040(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 15025, 15040);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_15073_15088(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 15073, 15088);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_15403_15418(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 15403, 15418);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_15475_15490(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 15475, 15490);
return return_v;
}


System.Management.Automation.Remoting.DispatchTable<object>
f_1581_15938_15951()
{
var return_v = DispatchTable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 15938, 15951);
return return_v;
}


long
f_1581_15938_15969(System.Management.Automation.Remoting.DispatchTable<object>
this_param)
{
var return_v = this_param.CreateNewCallId();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 15938, 15969);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_15990_16010()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 15990, 16010);
return return_v;
}


int
f_1581_15990_16060(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,int
maxRunspaces,long
callId)
{
this_param.SendSetMaxRunspacesToServer( maxRunspaces, callId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 15990, 16060);
return 0;
}


System.Management.Automation.Remoting.DispatchTable<object>
f_1581_16174_16187()
{
var return_v = DispatchTable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 16174, 16187);
return return_v;
}


object
f_1581_16174_16214(System.Management.Automation.Remoting.DispatchTable<object>
this_param,long
callId,bool
defaultValue)
{
var return_v = this_param.GetResponse( callId, (object)defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 16174, 16214);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,14690,16500);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,14690,16500);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool SetMinRunspaces(int minRunspaces)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,17108,18965);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,17189,17218);

bool 
isSizeDecreased = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,17232,17248);

long 
callId = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,17270,17280);

            lock (syncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,17314,17655) || true) && ((minRunspaces < 1) ||(DynAbs.Tracing.TraceSender.Expression_False(1581, 17318, 17366)||(minRunspaces > maxPoolSz) )||(DynAbs.Tracing.TraceSender.Expression_False(1581, 17318, 17397)||(minRunspaces == minPoolSz)
)||(DynAbs.Tracing.TraceSender.Expression_False(1581, 17318, 17465)||f_1581_17422_17437(stateInfo)== RunspacePoolState.Closed )||(DynAbs.Tracing.TraceSender.Expression_False(1581, 17318, 17513)||f_1581_17469_17484(stateInfo)== RunspacePoolState.Closing )||(DynAbs.Tracing.TraceSender.Expression_False(1581, 17318, 17581)||f_1581_17538_17553(stateInfo)== RunspacePoolState.Broken))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,17314,17655);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,17623,17636);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,17314,17655);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,17864,18109) || true) && (f_1581_17868_17883(stateInfo)== RunspacePoolState.BeforeOpen ||(DynAbs.Tracing.TraceSender.Expression_False(1581, 17868, 17989)||f_1581_17940_17955(stateInfo)== RunspacePoolState.Disconnected))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,17864,18109);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,18031,18056);

minPoolSz = minRunspaces;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,18078,18090);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,17864,18109);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,18394,18435);

callId = f_1581_18403_18434(f_1581_18403_18416());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,18455,18526);

f_1581_18455_18525(f_1581_18455_18475(), minRunspaces, callId);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,18621,18680);

object 
response = f_1581_18639_18679(f_1581_18639_18652(), callId, false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,18696,18729);

isSizeDecreased = (bool)response;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,18745,18915) || true) && (isSizeDecreased)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,18745,18915);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,18804,18814);
                lock (syncObject)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,18856,18881);

minPoolSz = minRunspaces;
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,18745,18915);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,18931,18954);

return isSizeDecreased;
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,17108,18965);

System.Management.Automation.Runspaces.RunspacePoolState
f_1581_17422_17437(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 17422, 17437);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_17469_17484(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 17469, 17484);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_17538_17553(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 17538, 17553);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_17868_17883(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 17868, 17883);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_17940_17955(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 17940, 17955);
return return_v;
}


System.Management.Automation.Remoting.DispatchTable<object>
f_1581_18403_18416()
{
var return_v = DispatchTable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 18403, 18416);
return return_v;
}


long
f_1581_18403_18434(System.Management.Automation.Remoting.DispatchTable<object>
this_param)
{
var return_v = this_param.CreateNewCallId();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 18403, 18434);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_18455_18475()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 18455, 18475);
return return_v;
}


int
f_1581_18455_18525(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,int
minRunspaces,long
callId)
{
this_param.SendSetMinRunspacesToServer( minRunspaces, callId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 18455, 18525);
return 0;
}


System.Management.Automation.Remoting.DispatchTable<object>
f_1581_18639_18652()
{
var return_v = DispatchTable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 18639, 18652);
return return_v;
}


object
f_1581_18639_18679(System.Management.Automation.Remoting.DispatchTable<object>
this_param,long
callId,bool
defaultValue)
{
var return_v = this_param.GetResponse( callId, (object)defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 18639, 18679);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,17108,18965);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,17108,18965);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override int GetAvailableRunspaces()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,19232,20726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,19302,19329);

int 
availableRunspaces = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,19343,19359);

long 
callId = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,19381,19391);

            lock (syncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,19583,20391) || true) && (f_1581_19587_19602(stateInfo)== RunspacePoolState.Opened)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,19583,20391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,19959,20000);

callId = f_1581_19968_19999(f_1581_19968_19981());
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,19583,20391);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,19583,20391);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,20042,20391) || true) && (f_1581_20046_20061(stateInfo)!= RunspacePoolState.BeforeOpen &&(DynAbs.Tracing.TraceSender.Expression_True(1581, 20046, 20141)&&f_1581_20097_20112(stateInfo)!= RunspacePoolState.Opening))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,20042,20391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,20183,20273);

throw f_1581_20189_20272(f_1581_20219_20271());
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,20042,20391);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,20042,20391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,20355,20372);

return maxPoolSz;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,20042,20391);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,19583,20391);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,20411,20474);

f_1581_20411_20473(f_1581_20411_20431(), callId);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,20569,20624);

object 
response = f_1581_20587_20623(f_1581_20587_20600(), callId, 0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,20638,20673);

availableRunspaces = (int)response;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,20689,20715);

return availableRunspaces;
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,19232,20726);

System.Management.Automation.Runspaces.RunspacePoolState
f_1581_19587_19602(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 19587, 19602);
return return_v;
}


System.Management.Automation.Remoting.DispatchTable<object>
f_1581_19968_19981()
{
var return_v = DispatchTable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 19968, 19981);
return return_v;
}


long
f_1581_19968_19999(System.Management.Automation.Remoting.DispatchTable<object>
this_param)
{
var return_v = this_param.CreateNewCallId();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 19968, 19999);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_20046_20061(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 20046, 20061);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_20097_20112(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 20097, 20112);
return return_v;
}


string
f_1581_20219_20271()
{
var return_v = HostInterfaceExceptionsStrings.RunspacePoolNotOpened;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 20219, 20271);
return return_v;
}


System.InvalidOperationException
f_1581_20189_20272(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 20189, 20272);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_20411_20431()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 20411, 20431);
return return_v;
}


int
f_1581_20411_20473(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,long
callId)
{
this_param.SendGetAvailableRunspacesToServer( callId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 20411, 20473);
return 0;
}


System.Management.Automation.Remoting.DispatchTable<object>
f_1581_20587_20600()
{
var return_v = DispatchTable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 20587, 20600);
return return_v;
}


object
f_1581_20587_20623(System.Management.Automation.Remoting.DispatchTable<object>
this_param,long
callId,int
defaultValue)
{
var return_v = this_param.GetResponse( callId, (object)defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 20587, 20623);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,19232,20726);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,19232,20726);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void HandleApplicationPrivateDataReceived(object sender,
            RemoteDataEventArgs<PSPrimitiveDictionary> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,21041,21256);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,21198,21245);

f_1581_21198_21244(            this, f_1581_21229_21243(eventArgs));
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,21041,21256);

System.Management.Automation.PSPrimitiveDictionary
f_1581_21229_21243(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSPrimitiveDictionary>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 21229, 21243);
return return_v;
}


int
f_1581_21198_21244(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.PSPrimitiveDictionary
applicationPrivateData)
{
this_param.SetApplicationPrivateData( applicationPrivateData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 21198, 21244);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,21041,21256);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,21041,21256);
}
		}

internal void HandleInitInfoReceived(object sender,
                        RemoteDataEventArgs<RunspacePoolInitInfo> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,21268,22352);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,21422,21509);

RunspacePoolStateInfo 
info = f_1581_21451_21508(RunspacePoolState.Opened, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,21525,21550);

bool 
raiseEvents = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,21572,21582);

            lock (syncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,21616,21656);

minPoolSz = f_1581_21628_21655(f_1581_21628_21642(eventArgs));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,21674,21714);

maxPoolSz = f_1581_21686_21713(f_1581_21686_21700(eventArgs));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,21732,21967) || true) && (f_1581_21736_21751(stateInfo)== RunspacePoolState.Connecting)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,21732,21967);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,21825,21856);

f_1581_21825_21855(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,21880,21899);

raiseEvents = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,21921,21948);

f_1581_21921_21947(this, info);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,21732,21967);
}
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,21998,22341) || true) && (raiseEvents)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,21998,22341);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,22260,22326);

f_1581_22260_22325(WaitAndRaiseConnectEventsProc, info);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,21998,22341);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,21268,22352);

System.Management.Automation.RunspacePoolStateInfo
f_1581_21451_21508(System.Management.Automation.Runspaces.RunspacePoolState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.RunspacePoolStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 21451, 21508);
return return_v;
}


System.Management.Automation.Remoting.RunspacePoolInitInfo
f_1581_21628_21642(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RunspacePoolInitInfo>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 21628, 21642);
return return_v;
}


int
f_1581_21628_21655(System.Management.Automation.Remoting.RunspacePoolInitInfo
this_param)
{
var return_v = this_param.MinRunspaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 21628, 21655);
return return_v;
}


System.Management.Automation.Remoting.RunspacePoolInitInfo
f_1581_21686_21700(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RunspacePoolInitInfo>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 21686, 21700);
return return_v;
}


int
f_1581_21686_21713(System.Management.Automation.Remoting.RunspacePoolInitInfo
this_param)
{
var return_v = this_param.MaxRunspaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 21686, 21713);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_21736_21751(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 21736, 21751);
return return_v;
}


int
f_1581_21825_21855(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
this_param.ResetDisconnectedOnExpiresOn();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 21825, 21855);
return 0;
}


int
f_1581_21921_21947(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
newStateInfo)
{
this_param.SetRunspacePoolState( newStateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 21921, 21947);
return 0;
}


bool
f_1581_22260_22325(System.Threading.WaitCallback
callBack,System.Management.Automation.RunspacePoolStateInfo
state)
{
var return_v = ThreadPool.QueueUserWorkItem( callBack, (object)state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 22260, 22325);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,21268,22352);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,21268,22352);
}
		}

internal void HandleStateInfoReceived(object sender,
            RemoteDataEventArgs<RunspacePoolStateInfo> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,22682,25273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,22826,22878);

RunspacePoolStateInfo 
newStateInfo = f_1581_22863_22877(eventArgs)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,22892,22917);

bool 
raiseEvents = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,22933,23006);

f_1581_22933_23005(newStateInfo != null, "state information should not be null");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,23022,25262) || true) && (f_1581_23026_23044(newStateInfo)== RunspacePoolState.Opened)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,23022,25262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,23112,23122);
                lock (syncObject)
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,23164,23365) || true) && (f_1581_23168_23183(stateInfo)== RunspacePoolState.Opening)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,23164,23365);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,23262,23297);

f_1581_23262_23296(this, newStateInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,23323,23342);

raiseEvents = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,23164,23365);
}
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,23404,23672) || true) && (raiseEvents)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,23404,23672);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,23577,23610);

f_1581_23577_23609(this, stateInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,23632,23653);

f_1581_23632_23652(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,23404,23672);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,23022,25262);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,23022,25262);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,23706,25262) || true) && (f_1581_23710_23728(newStateInfo)== RunspacePoolState.Closed ||(DynAbs.Tracing.TraceSender.Expression_False(1581, 23710, 23806)||f_1581_23760_23778(newStateInfo)== RunspacePoolState.Broken))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,23706,25262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,23840,23861);

bool 
doClose = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,23887,23897);

                lock (syncObject)
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,23939,24169) || true) && (f_1581_23943_23958(stateInfo)== RunspacePoolState.Closed ||(DynAbs.Tracing.TraceSender.Expression_False(1581, 23943, 24033)||f_1581_23990_24005(stateInfo)== RunspacePoolState.Broken))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,23939,24169);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,24139,24146);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,23939,24169);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,24193,24529) || true) && (f_1581_24197_24212(stateInfo)== RunspacePoolState.Opening
||(DynAbs.Tracing.TraceSender.Expression_False(1581, 24197, 24310)||f_1581_24267_24282(stateInfo)== RunspacePoolState.Opened
)||(DynAbs.Tracing.TraceSender.Expression_False(1581, 24197, 24380)||f_1581_24336_24351(stateInfo)== RunspacePoolState.Closing))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,24193,24529);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,24430,24445);

doClose = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,24471,24506);

f_1581_24471_24505(this, newStateInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,24193,24529);
}
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,24568,25247) || true) && (doClose)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,24568,25247);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,24840,25043) || true) && (_closeAsyncResult == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,24840,25043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,24974,25020);

f_1581_24974_25019(f_1581_24974_24994());
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,24840,25043);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,24568,25247);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,23706,25262);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,23022,25262);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,22682,25273);

System.Management.Automation.RunspacePoolStateInfo
f_1581_22863_22877(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.RunspacePoolStateInfo>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 22863, 22877);
return return_v;
}


int
f_1581_22933_23005(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 22933, 23005);
return 0;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_23026_23044(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 23026, 23044);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_23168_23183(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 23168, 23183);
return return_v;
}


int
f_1581_23262_23296(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
newStateInfo)
{
this_param.SetRunspacePoolState( newStateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 23262, 23296);
return 0;
}


int
f_1581_23577_23609(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
stateInfo)
{
this_param.RaiseStateChangeEvent( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 23577, 23609);
return 0;
}


int
f_1581_23632_23652(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
this_param.SetOpenAsCompleted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 23632, 23652);
return 0;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_23710_23728(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 23710, 23728);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_23760_23778(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 23760, 23778);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_23943_23958(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 23943, 23958);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_23990_24005(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 23990, 24005);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_24197_24212(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 24197, 24212);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_24267_24282(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 24267, 24282);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_24336_24351(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 24336, 24351);
return return_v;
}


int
f_1581_24471_24505(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
newStateInfo)
{
this_param.SetRunspacePoolState( newStateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 24471, 24505);
return 0;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_24974_24994()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 24974, 24994);
return return_v;
}


int
f_1581_24974_25019(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param)
{
this_param.CloseRunspacePoolAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 24974, 25019);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,22682,25273);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,22682,25273);
}
		}

internal void HandleRemoteHostCalls(object sender,
            RemoteDataEventArgs<RemoteHostCall> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,25573,26335);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,25708,26324) || true) && (HostCallReceived != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,25708,26324);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,25770,25817);

f_1581_25770_25816(                HostCallReceived, sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,25708,26324);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,25708,26324);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,25883,25924);

RemoteHostCall 
hostCall = f_1581_25909_25923(eventArgs)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,25944,26309) || true) && (f_1581_25948_25969(hostCall))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,25944,26309);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,26011,26044);

f_1581_26011_26043(                    hostCall, host);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,25944,26309);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,25944,26309);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,26126,26202);

RemoteHostResponse 
remoteHostResponse = f_1581_26166_26201(hostCall, host)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,26224,26290);

f_1581_26224_26289(f_1581_26224_26244(), remoteHostResponse);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,25944,26309);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,25708,26324);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,25573,26335);

int
f_1581_25770_25816(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>>
eventHandler,object
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>>( sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 25770, 25816);
return 0;
}


System.Management.Automation.Remoting.RemoteHostCall
f_1581_25909_25923(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 25909, 25923);
return return_v;
}


bool
f_1581_25948_25969(System.Management.Automation.Remoting.RemoteHostCall
this_param)
{
var return_v = this_param.IsVoidMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 25948, 25969);
return return_v;
}


int
f_1581_26011_26043(System.Management.Automation.Remoting.RemoteHostCall
this_param,System.Management.Automation.Host.PSHost
clientHost)
{
this_param.ExecuteVoidMethod( clientHost);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 26011, 26043);
return 0;
}


System.Management.Automation.Remoting.RemoteHostResponse
f_1581_26166_26201(System.Management.Automation.Remoting.RemoteHostCall
this_param,System.Management.Automation.Host.PSHost
clientHost)
{
var return_v = this_param.ExecuteNonVoidMethod( clientHost);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 26166, 26201);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_26224_26244()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 26224, 26244);
return return_v;
}


int
f_1581_26224_26289(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,System.Management.Automation.Remoting.RemoteHostResponse
hostResponse)
{
this_param.SendHostResponseToServer( hostResponse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 26224, 26289);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,25573,26335);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,25573,26335);
}
		}

internal PSHost Host
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,26392,26455);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,26428,26440);

return host;
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,26392,26455);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,26347,26466);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,26347,26466);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal PSPrimitiveDictionary ApplicationArguments {get; }

internal override PSPrimitiveDictionary GetApplicationPrivateData()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,27171,27714);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,27263,27656) || true) && (f_1581_27267_27299(f_1581_27267_27293(this))== RunspacePoolState.Disconnected &&(DynAbs.Tracing.TraceSender.Expression_True(1581, 27267, 27397)&&                !f_1581_27355_27397(_applicationPrivateDataReceived, 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,27263,27656);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,27629,27641);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,27263,27656);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,27672,27703);

return _applicationPrivateData;
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,27171,27714);

System.Management.Automation.RunspacePoolStateInfo
f_1581_27267_27293(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.RunspacePoolStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 27267, 27293);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_27267_27299(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 27267, 27299);
return return_v;
}


bool
f_1581_27355_27397(System.Threading.ManualResetEvent
this_param,int
millisecondsTimeout)
{
var return_v = this_param.WaitOne( millisecondsTimeout);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 27355, 27397);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,27171,27714);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,27171,27714);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void SetApplicationPrivateData(PSPrimitiveDictionary applicationPrivateData)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,27726,28429);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,27842,27857);
            lock (this.syncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,27891,28091) || true) && (f_1581_27895_27937(_applicationPrivateDataReceived, 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,27891,28091);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,27979,27986);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,27891,28091);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,28111,28160);

_applicationPrivateData = applicationPrivateData;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,28178,28216);

f_1581_28178_28215(                _applicationPrivateDataReceived);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,28236,28403);
foreach(Runspace runspace in f_1581_28266_28283_I(this.runspaceList) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,28236,28403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,28325,28384);

f_1581_28325_28383(                    runspace, applicationPrivateData);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,28236,28403);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1581,1,168);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1581,1,168);
}            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,27726,28429);

bool
f_1581_27895_27937(System.Threading.ManualResetEvent
this_param,int
millisecondsTimeout)
{
var return_v = this_param.WaitOne( millisecondsTimeout);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 27895, 27937);
return return_v;
}


bool
f_1581_28178_28215(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 28178, 28215);
return return_v;
}


int
f_1581_28325_28383(System.Management.Automation.Runspaces.Runspace
this_param,System.Management.Automation.PSPrimitiveDictionary
applicationPrivateData)
{
this_param.SetApplicationPrivateData( applicationPrivateData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 28325, 28383);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>
f_1581_28266_28283_I(System.Collections.Generic.List<System.Management.Automation.Runspaces.Runspace>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 28266, 28283);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,27726,28429);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,27726,28429);
}
		}

internal override void PropagateApplicationPrivateData(Runspace runspace)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,28441,28714);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,28539,28703) || true) && (f_1581_28543_28585(_applicationPrivateDataReceived, 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,28539,28703);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,28619,28688);

f_1581_28619_28687(                runspace, f_1581_28654_28686(this));
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,28539,28703);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,28441,28714);

bool
f_1581_28543_28585(System.Threading.ManualResetEvent
this_param,int
millisecondsTimeout)
{
var return_v = this_param.WaitOne( millisecondsTimeout);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 28543, 28585);
return return_v;
}


System.Management.Automation.PSPrimitiveDictionary
f_1581_28654_28686(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.GetApplicationPrivateData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 28654, 28686);
return return_v;
}


int
f_1581_28619_28687(System.Management.Automation.Runspaces.Runspace
this_param,System.Management.Automation.PSPrimitiveDictionary
applicationPrivateData)
{
this_param.SetApplicationPrivateData( applicationPrivateData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 28619, 28687);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,28441,28714);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,28441,28714);
}
		}

private PSPrimitiveDictionary _applicationPrivateData;

private ManualResetEvent _applicationPrivateDataReceived ;

        /// <summary>
        /// This event is raised, when a host call is for a remote runspace
        /// which this runspace pool wraps.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<RemoteHostCall>> 
HostCallReceived
;

        /// <summary>
        /// EventHandler used to report connection URI redirections to the application.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<Uri>> 
URIRedirectionReported
;

        /// <summary>
        /// Notifies the successful creation of the runspace session.
        /// </summary>
        internal event EventHandler<CreateCompleteEventArgs> 
SessionCreateCompleted
;

internal void CreatePowerShellOnServerAndInvoke(ClientRemotePowerShell shell)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,29672,30001);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,29774,29836);

f_1581_29774_29835(f_1581_29774_29794(), shell);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,29905,29990) || true) && (f_1581_29909_29923_M(!shell.NoInput))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,29905,29990);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,29957,29975);

f_1581_29957_29974(                shell);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,29905,29990);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,29672,30001);

System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_29774_29794()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 29774, 29794);
return return_v;
}


int
f_1581_29774_29835(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
shell)
{
this_param.CreatePowerShellOnServerAndInvoke( shell);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 29774, 29835);
return 0;
}


bool
f_1581_29909_29923_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 29909, 29923);
return return_v;
}


int
f_1581_29957_29974(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param)
{
this_param.SendInput();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 29957, 29974);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,29672,30001);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,29672,30001);
}
		}

internal void AddRemotePowerShellDSHandler(Guid psShellInstanceId, ClientPowerShellDataStructureHandler psDSHandler)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,30337,30571);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,30478,30560);

f_1581_30478_30559(f_1581_30478_30498(), psShellInstanceId, psDSHandler);
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,30337,30571);

System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_30478_30498()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 30478, 30498);
return return_v;
}


int
f_1581_30478_30559(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,System.Guid
psShellInstanceId,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
psDSHandler)
{
this_param.AddRemotePowerShellDSHandler( psShellInstanceId, psDSHandler);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 30478, 30559);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,30337,30571);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,30337,30571);
}
		}

internal bool CanDisconnect
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,30741,31410);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,30777,30851);

Version 
remoteProtocolVersionDeclaredByServer = f_1581_30825_30850()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,30869,31362) || true) && (remoteProtocolVersionDeclaredByServer != null &&(DynAbs.Tracing.TraceSender.Expression_True(1581, 30873, 30950)&&f_1581_30922_30942()!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,30869,31362);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,31172,31343);

return (remoteProtocolVersionDeclaredByServer >= RemotingConstants.ProtocolVersionWin8RTM &&(DynAbs.Tracing.TraceSender.Expression_True(1581, 31180, 31341)&&f_1581_31294_31341(f_1581_31294_31314())));
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,30869,31362);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,31382,31395);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,30741,31410);

System.Version
f_1581_30825_30850()
{
var return_v = PSRemotingProtocolVersion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 30825, 30850);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_30922_30942()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 30922, 30942);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_31294_31314()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 31294, 31314);
return return_v;
}


bool
f_1581_31294_31341(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param)
{
var return_v = this_param.EndpointSupportsDisconnect;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 31294, 31341);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,30689,31421);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,30689,31421);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal Version PSRemotingProtocolVersion
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,31650,32253);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,31686,31722);

Version 
winRMProtocolVersion = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,31742,31816);

PSPrimitiveDictionary 
psPrimitiveDictionary = f_1581_31788_31815(this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,31834,32190) || true) && (psPrimitiveDictionary != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,31834,32190);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,31909,32171);

f_1581_31909_32170(psPrimitiveDictionary, out winRMProtocolVersion, PSVersionInfo.PSVersionTableName, PSVersionInfo.PSRemotingProtocolVersionName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,31834,32190);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,32210,32238);

return winRMProtocolVersion;
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,31650,32253);

System.Management.Automation.PSPrimitiveDictionary
f_1581_31788_31815(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.GetApplicationPrivateData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 31788, 31815);
return return_v;
}


bool
f_1581_31909_32170(System.Management.Automation.PSPrimitiveDictionary
data,out System.Version
result,params string[]
keys)
{
var return_v = PSPrimitiveDictionary.TryPathGet( (System.Collections.IDictionary)data, out result, keys);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 31909, 32170);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,31583,32264);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,31583,32264);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal void PushRunningPowerShell(PowerShell ps)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,32428,32625);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,32503,32571);

f_1581_32503_32570(ps != null, "Caller should not pass in null reference.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,32585,32614);

f_1581_32585_32613(            _runningPowerShells, ps);
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,32428,32625);

int
f_1581_32503_32570(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 32503, 32570);
return 0;
}


int
f_1581_32585_32613(System.Collections.Concurrent.ConcurrentStack<System.Management.Automation.PowerShell>
this_param,System.Management.Automation.PowerShell
item)
{
this_param.Push( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 32585, 32613);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,32428,32625);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,32428,32625);
}
		}

internal PowerShell PopRunningPowerShell()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,32790,33045);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,32857,32879);

PowerShell 
powershell
=default(PowerShell);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,32893,33006) || true) && (f_1581_32897_32939(_runningPowerShells, out powershell))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,32893,33006);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,32973,32991);

return powershell;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,32893,33006);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,33022,33034);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,32790,33045);

bool
f_1581_32897_32939(System.Collections.Concurrent.ConcurrentStack<System.Management.Automation.PowerShell>
this_param,out System.Management.Automation.PowerShell
result)
{
var return_v = this_param.TryPop( out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 32897, 32939);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,32790,33045);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,32790,33045);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal PowerShell GetCurrentRunningPowerShell()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,33200,33463);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,33274,33296);

PowerShell 
powershell
=default(PowerShell);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,33310,33424) || true) && (f_1581_33314_33357(_runningPowerShells, out powershell))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,33310,33424);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,33391,33409);

return powershell;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,33310,33424);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,33440,33452);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,33200,33463);

bool
f_1581_33314_33357(System.Collections.Concurrent.ConcurrentStack<System.Management.Automation.PowerShell>
this_param,out System.Management.Automation.PowerShell
result)
{
var return_v = this_param.TryPeek( out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 33314, 33357);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,33200,33463);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,33200,33463);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override IAsyncResult CoreOpen(bool isAsync, AsyncCallback callback,
            object asyncState)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,34679,36142);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,34814,34870);

f_1581_34814_34869(f_1581_34853_34868(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,34884,35042);

f_1581_34884_35041(PSEventId.RunspacePoolOpen, PSOpcode.Open, PSTask.CreateRunspace, PSKeyword.UseAlwaysOperational);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,35106,35208);

f_1581_35106_35207(TelemetryType.RemoteSessionOpen, f_1581_35188_35206(isAsync));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,35330,35340);

            lock (syncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,35374,35402);

f_1581_35374_35401(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,35422,35493);

stateInfo = f_1581_35434_35492(RunspacePoolState.Opening, null);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,35676,35709);

f_1581_35676_35708(this, stateInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,35725,35853);

RunspacePoolAsyncResult 
asyncResult = f_1581_35763_35852(instanceId, callback, asyncState, true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,35869,35900);

_openAsyncResult = asyncResult;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,36042,36096);

f_1581_36042_36095(f_1581_36042_36062());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,36112,36131);

return asyncResult;
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,34679,36142);

System.Guid
f_1581_34853_34868(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 34853, 34868);
return return_v;
}


int
f_1581_34814_34869(System.Guid
newActivityId)
{
PSEtwLog.SetActivityIdForCurrentThread( newActivityId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 34814, 34869);
return 0;
}


int
f_1581_34884_35041(System.Management.Automation.Internal.PSEventId
id,System.Management.Automation.Internal.PSOpcode
opcode,System.Management.Automation.Internal.PSTask
task,System.Management.Automation.Internal.PSKeyword
keyword,params object[]
args)
{
PSEtwLog.LogOperationalVerbose( id, opcode, task, keyword, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 34884, 35041);
return 0;
}


string
f_1581_35188_35206(bool
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 35188, 35206);
return return_v;
}


int
f_1581_35106_35207(Microsoft.PowerShell.Telemetry.TelemetryType
metricId,string
data)
{
ApplicationInsightsTelemetry.SendTelemetryMetric( metricId, data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 35106, 35207);
return 0;
}


int
f_1581_35374_35401(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
this_param.AssertIfStateIsBeforeOpen();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 35374, 35401);
return 0;
}


System.Management.Automation.RunspacePoolStateInfo
f_1581_35434_35492(System.Management.Automation.Runspaces.RunspacePoolState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.RunspacePoolStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 35434, 35492);
return return_v;
}


int
f_1581_35676_35708(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
stateInfo)
{
this_param.RaiseStateChangeEvent( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 35676, 35708);
return 0;
}


System.Management.Automation.Runspaces.RunspacePoolAsyncResult
f_1581_35763_35852(System.Guid
ownerId,System.AsyncCallback
callback,object
state,bool
isCalledFromOpenAsync)
{
var return_v = new System.Management.Automation.Runspaces.RunspacePoolAsyncResult( ownerId, callback, state, isCalledFromOpenAsync);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 35763, 35852);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_36042_36062()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 36042, 36062);
return return_v;
}


int
f_1581_36042_36095(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param)
{
this_param.CreateRunspacePoolAndOpenAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 36042, 36095);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,34679,36142);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,34679,36142);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override void Open()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,36306,36455);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,36358,36407);

IAsyncResult 
asyncResult = f_1581_36385_36406(this, null, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,36423,36444);

f_1581_36423_36443(this, asyncResult);
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,36306,36455);

System.IAsyncResult
f_1581_36385_36406(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.AsyncCallback
callback,object
state)
{
var return_v = this_param.BeginOpen( callback, state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 36385, 36406);
return return_v;
}


int
f_1581_36423_36443(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.IAsyncResult
asyncResult)
{
this_param.EndOpen( asyncResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 36423, 36443);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,36306,36455);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,36306,36455);
}
		}

public override void Close()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,37021,37202);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,37105,37155);

IAsyncResult 
asyncResult = f_1581_37132_37154(this, null, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,37169,37191);

f_1581_37169_37190(this, asyncResult);
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,37021,37202);

System.IAsyncResult
f_1581_37132_37154(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.AsyncCallback
callback,object
asyncState)
{
var return_v = this_param.BeginClose( callback, asyncState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 37132, 37154);
return return_v;
}


int
f_1581_37169_37190(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.IAsyncResult
asyncResult)
{
this_param.EndClose( asyncResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 37169, 37190);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,37021,37202);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,37021,37202);
}
		}

public override IAsyncResult BeginClose(AsyncCallback callback, object asyncState)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,37809,40990);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,37916,37941);

bool 
raiseEvents = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,37955,37980);

bool 
skipClosing = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,37994,38090);

RunspacePoolStateInfo 
copyState = f_1581_38028_38089(RunspacePoolState.BeforeOpen, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,38104,38147);

RunspacePoolAsyncResult 
asyncResult = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,38169,38179);

            lock (syncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,38213,40252) || true) && ((f_1581_38218_38233(stateInfo)== RunspacePoolState.Closed) ||(DynAbs.Tracing.TraceSender.Expression_False(1581, 38217, 38332)||                    (f_1581_38288_38303(stateInfo)== RunspacePoolState.Broken)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,38213,40252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,38374,38393);

skipClosing = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,38415,38498);

asyncResult = f_1581_38429_38497(instanceId, callback, asyncState, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,38213,40252);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,38213,40252);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,38540,40252) || true) && (f_1581_38544_38559(stateInfo)== RunspacePoolState.BeforeOpen)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,38540,40252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,38633,38715);

copyState = stateInfo = f_1581_38657_38714(RunspacePoolState.Closed, null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,38737,38756);

raiseEvents = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,38778,38797);

skipClosing = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,38819,38844);

_closeAsyncResult = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,38866,38949);

asyncResult = f_1581_38880_38948(instanceId, callback, asyncState, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,38540,40252);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,38540,40252);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,38991,40252) || true) && (f_1581_38995_39010(stateInfo)== RunspacePoolState.Opened ||(DynAbs.Tracing.TraceSender.Expression_False(1581, 38995, 39112)||f_1581_39068_39083(stateInfo)== RunspacePoolState.Opening))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,38991,40252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,39154,39237);

copyState = stateInfo = f_1581_39178_39236(RunspacePoolState.Closing, null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,39259,39348);

_closeAsyncResult = f_1581_39279_39347(instanceId, callback, asyncState, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,39370,39402);

asyncResult = _closeAsyncResult;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,39424,39443);

raiseEvents = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,38991,40252);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,38991,40252);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,39485,40252) || true) && (f_1581_39489_39504(stateInfo)== RunspacePoolState.Disconnected ||(DynAbs.Tracing.TraceSender.Expression_False(1581, 39489, 39618)||f_1581_39568_39583(stateInfo)== RunspacePoolState.Disconnecting )||(DynAbs.Tracing.TraceSender.Expression_False(1581, 39489, 39695)||f_1581_39648_39663(stateInfo)== RunspacePoolState.Connecting))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,39485,40252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,39933,40022);

_closeAsyncResult = f_1581_39953_40021(instanceId, callback, asyncState, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,40044,40076);

asyncResult = _closeAsyncResult;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,39485,40252);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,39485,40252);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,40118,40252) || true) && (f_1581_40122_40137(stateInfo)== RunspacePoolState.Closing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,40118,40252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,40208,40233);

return _closeAsyncResult;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,40118,40252);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,39485,40252);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,38991,40252);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,38540,40252);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,38213,40252);
}
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,40333,40430) || true) && (raiseEvents)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,40333,40430);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,40382,40415);

f_1581_40382_40414(this, copyState);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,40333,40430);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,40446,40944) || true) && (!skipClosing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,40446,40944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,40741,40787);

f_1581_40741_40786(f_1581_40741_40761());
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,40446,40944);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,40446,40944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,40896,40929);

f_1581_40896_40928(                // signal the wait handle
                asyncResult, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,40446,40944);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,40960,40979);

return asyncResult;
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,37809,40990);

System.Management.Automation.RunspacePoolStateInfo
f_1581_38028_38089(System.Management.Automation.Runspaces.RunspacePoolState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.RunspacePoolStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 38028, 38089);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_38218_38233(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 38218, 38233);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_38288_38303(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 38288, 38303);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolAsyncResult
f_1581_38429_38497(System.Guid
ownerId,System.AsyncCallback
callback,object
state,bool
isCalledFromOpenAsync)
{
var return_v = new System.Management.Automation.Runspaces.RunspacePoolAsyncResult( ownerId, callback, state, isCalledFromOpenAsync);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 38429, 38497);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_38544_38559(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 38544, 38559);
return return_v;
}


System.Management.Automation.RunspacePoolStateInfo
f_1581_38657_38714(System.Management.Automation.Runspaces.RunspacePoolState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.RunspacePoolStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 38657, 38714);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolAsyncResult
f_1581_38880_38948(System.Guid
ownerId,System.AsyncCallback
callback,object
state,bool
isCalledFromOpenAsync)
{
var return_v = new System.Management.Automation.Runspaces.RunspacePoolAsyncResult( ownerId, callback, state, isCalledFromOpenAsync);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 38880, 38948);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_38995_39010(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 38995, 39010);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_39068_39083(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 39068, 39083);
return return_v;
}


System.Management.Automation.RunspacePoolStateInfo
f_1581_39178_39236(System.Management.Automation.Runspaces.RunspacePoolState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.RunspacePoolStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 39178, 39236);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolAsyncResult
f_1581_39279_39347(System.Guid
ownerId,System.AsyncCallback
callback,object
state,bool
isCalledFromOpenAsync)
{
var return_v = new System.Management.Automation.Runspaces.RunspacePoolAsyncResult( ownerId, callback, state, isCalledFromOpenAsync);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 39279, 39347);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_39489_39504(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 39489, 39504);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_39568_39583(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 39568, 39583);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_39648_39663(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 39648, 39663);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolAsyncResult
f_1581_39953_40021(System.Guid
ownerId,System.AsyncCallback
callback,object
state,bool
isCalledFromOpenAsync)
{
var return_v = new System.Management.Automation.Runspaces.RunspacePoolAsyncResult( ownerId, callback, state, isCalledFromOpenAsync);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 39953, 40021);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_40122_40137(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 40122, 40137);
return return_v;
}


int
f_1581_40382_40414(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
stateInfo)
{
this_param.RaiseStateChangeEvent( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 40382, 40414);
return 0;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_40741_40761()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 40741, 40761);
return return_v;
}


int
f_1581_40741_40786(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param)
{
this_param.CloseRunspacePoolAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 40741, 40786);
return 0;
}


int
f_1581_40896_40928(System.Management.Automation.Runspaces.RunspacePoolAsyncResult
this_param,System.Exception
exception)
{
this_param.SetAsCompleted( exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 40896, 40928);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,37809,40990);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,37809,40990);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override void Disconnect()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,41086,41253);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,41144,41199);

IAsyncResult 
asyncResult = f_1581_41171_41198(this, null, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,41215,41242);

f_1581_41215_41241(this, asyncResult);
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,41086,41253);

System.IAsyncResult
f_1581_41171_41198(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.AsyncCallback
callback,object
state)
{
var return_v = this_param.BeginDisconnect( callback, state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 41171, 41198);
return return_v;
}


int
f_1581_41215_41241(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.IAsyncResult
asyncResult)
{
this_param.EndDisconnect( asyncResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 41215, 41241);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,41086,41253);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,41086,41253);
}
		}

public override IAsyncResult BeginDisconnect(AsyncCallback callback, object state)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,41517,43470);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,41624,41792) || true) && (f_1581_41628_41642_M(!CanDisconnect))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,41624,41792);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,41676,41777);

throw f_1581_41682_41776(f_1581_41725_41775());
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,41624,41792);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,41808,41839);

RunspacePoolState 
currentState
=default(RunspacePoolState);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,41853,41878);

bool 
raiseEvents = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,41898,41908);
            lock (syncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,41942,41973);

currentState = f_1581_41957_41972(stateInfo);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,41991,42298) || true) && (currentState == RunspacePoolState.Opened)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,41991,42298);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,42077,42179);

RunspacePoolStateInfo 
newStateInfo = f_1581_42114_42178(RunspacePoolState.Disconnecting, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,42203,42238);

f_1581_42203_42237(this, newStateInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,42260,42279);

raiseEvents = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,41991,42298);
}
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,42375,42477) || true) && (raiseEvents)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,42375,42477);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,42424,42462);

f_1581_42424_42461(this, this.stateInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,42375,42477);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,42493,43459) || true) && (currentState == RunspacePoolState.Opened)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,42493,43459);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,42571,42695);

RunspacePoolAsyncResult 
asyncResult = f_1581_42609_42694(instanceId, callback, state, false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,42715,42752);

_disconnectAsyncResult = asyncResult;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,42770,42813);

f_1581_42770_42812(f_1581_42770_42790());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,42996,43015);

return asyncResult;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,42493,43459);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,42493,43459);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,43081,43205);

string 
message = f_1581_43098_43204(f_1581_43116_43160(), RunspacePoolState.Opened, f_1581_43188_43203(stateInfo))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,43223,43396);

InvalidRunspacePoolStateException 
invalidStateException = f_1581_43281_43395(message, f_1581_43353_43368(stateInfo), RunspacePoolState.Opened)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,43416,43444);

throw invalidStateException;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,42493,43459);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,41517,43470);

bool
f_1581_41628_41642_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 41628, 41642);
return return_v;
}


string
f_1581_41725_41775()
{
var return_v = RunspacePoolStrings.DisconnectNotSupportedOnServer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 41725, 41775);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1581_41682_41776(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 41682, 41776);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_41957_41972(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 41957, 41972);
return return_v;
}


System.Management.Automation.RunspacePoolStateInfo
f_1581_42114_42178(System.Management.Automation.Runspaces.RunspacePoolState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.RunspacePoolStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 42114, 42178);
return return_v;
}


int
f_1581_42203_42237(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
newStateInfo)
{
this_param.SetRunspacePoolState( newStateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 42203, 42237);
return 0;
}


int
f_1581_42424_42461(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
stateInfo)
{
this_param.RaiseStateChangeEvent( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 42424, 42461);
return 0;
}


System.Management.Automation.Runspaces.RunspacePoolAsyncResult
f_1581_42609_42694(System.Guid
ownerId,System.AsyncCallback
callback,object
state,bool
isCalledFromOpenAsync)
{
var return_v = new System.Management.Automation.Runspaces.RunspacePoolAsyncResult( ownerId, callback, state, isCalledFromOpenAsync);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 42609, 42694);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_42770_42790()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 42770, 42790);
return return_v;
}


int
f_1581_42770_42812(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param)
{
this_param.DisconnectPoolAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 42770, 42812);
return 0;
}


string
f_1581_43116_43160()
{
var return_v = RunspacePoolStrings.InvalidRunspacePoolState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 43116, 43160);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_43188_43203(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 43188, 43203);
return return_v;
}


string
f_1581_43098_43204(string
formatSpec,System.Management.Automation.Runspaces.RunspacePoolState
o1,System.Management.Automation.Runspaces.RunspacePoolState
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 43098, 43204);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_43353_43368(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 43353, 43368);
return return_v;
}


System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
f_1581_43281_43395(string
message,System.Management.Automation.Runspaces.RunspacePoolState
currentState,System.Management.Automation.Runspaces.RunspacePoolState
expectedState)
{
var return_v = new System.Management.Automation.Runspaces.InvalidRunspacePoolStateException( message, currentState, expectedState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 43281, 43395);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,41517,43470);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,41517,43470);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override void EndDisconnect(IAsyncResult asyncResult)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,43659,44536);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,43744,43876) || true) && (asyncResult == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,43744,43876);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,43801,43861);

throw f_1581_43807_43860("asyncResult");
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,43744,43876);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,43892,43971);

RunspacePoolAsyncResult 
rsAsyncResult = asyncResult as RunspacePoolAsyncResult
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,43987,44483) || true) && ((rsAsyncResult == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1581, 43991, 44072)||                (f_1581_44036_44057(rsAsyncResult)!= instanceId) )||(DynAbs.Tracing.TraceSender.Expression_False(1581, 43991, 44134)||                (f_1581_44094_44133(rsAsyncResult))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,43987,44483);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,44168,44468);

throw f_1581_44174_44467("asyncResult", f_1581_44282_44321(), "IAsyncResult", "BeginOpen");
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,43987,44483);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,44499,44525);

f_1581_44499_44524(
            rsAsyncResult);
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,43659,44536);

System.Management.Automation.PSArgumentNullException
f_1581_43807_43860(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 43807, 43860);
return return_v;
}


System.Guid
f_1581_44036_44057(System.Management.Automation.Runspaces.RunspacePoolAsyncResult
this_param)
{
var return_v = this_param.OwnerId ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 44036, 44057);
return return_v;
}


bool
f_1581_44094_44133(System.Management.Automation.Runspaces.RunspacePoolAsyncResult
this_param)
{
var return_v = this_param.IsAssociatedWithAsyncOpen;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 44094, 44133);
return return_v;
}


string
f_1581_44282_44321()
{
var return_v =                                                          RunspacePoolStrings.AsyncResultNotOwned;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 44282, 44321);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1581_44174_44467(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 44174, 44467);
return return_v;
}


int
f_1581_44499_44524(System.Management.Automation.Runspaces.RunspacePoolAsyncResult
this_param)
{
this_param.EndInvoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 44499, 44524);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,43659,44536);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,43659,44536);
}
		}

public override void Connect()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,44629,44787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,44684,44736);

IAsyncResult 
asyncResult = f_1581_44711_44735(this, null, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,44752,44776);

f_1581_44752_44775(this, asyncResult);
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,44629,44787);

System.IAsyncResult
f_1581_44711_44735(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.AsyncCallback
callback,object
state)
{
var return_v = this_param.BeginConnect( callback, state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 44711, 44735);
return return_v;
}


int
f_1581_44752_44775(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.IAsyncResult
asyncResult)
{
this_param.EndConnect( asyncResult);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 44752, 44775);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,44629,44787);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,44629,44787);
}
		}

public override IAsyncResult BeginConnect(AsyncCallback callback, object state)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,45048,47749);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,45152,45312) || true) && (f_1581_45156_45179_M(!AvailableForConnection))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,45152,45312);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,45213,45297);

throw f_1581_45219_45296(f_1581_45262_45295());
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,45152,45312);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,45328,45359);

RunspacePoolState 
currentState
=default(RunspacePoolState);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,45373,45398);

bool 
raiseEvents = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,45418,45428);
            lock (syncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,45462,45493);

currentState = f_1581_45477_45492(stateInfo);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,45511,45821) || true) && (currentState == RunspacePoolState.Disconnected)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,45511,45821);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,45603,45702);

RunspacePoolStateInfo 
newStateInfo = f_1581_45640_45701(RunspacePoolState.Connecting, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,45726,45761);

f_1581_45726_45760(this, newStateInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,45783,45802);

raiseEvents = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,45511,45821);
}
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,45898,46000) || true) && (raiseEvents)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,45898,46000);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,45947,45985);

f_1581_45947_45984(this, this.stateInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,45898,46000);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,46016,46036);

raiseEvents = false;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,46052,47738) || true) && (currentState == RunspacePoolState.Disconnected)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,46052,47738);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,46318,46434);

RunspacePoolAsyncResult 
ret = f_1581_46348_46433(instanceId, callback, state, false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,46454,47117) || true) && (_canReconnect)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,46454,47117);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,46653,46681);

_reconnectAsyncResult = ret;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,46703,46745);

f_1581_46703_46744(f_1581_46703_46723());
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,46454,47117);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,46454,47117);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,47013,47036);

_openAsyncResult = ret;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,47058,47098);

f_1581_47058_47097(f_1581_47058_47078());
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,46454,47117);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,47137,47251) || true) && (raiseEvents)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,47137,47251);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,47194,47232);

f_1581_47194_47231(this, this.stateInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,47137,47251);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,47271,47282);

return ret;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,46052,47738);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,46052,47738);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,47348,47478);

string 
message = f_1581_47365_47477(f_1581_47383_47427(), RunspacePoolState.Disconnected, f_1581_47461_47476(stateInfo))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,47496,47675);

InvalidRunspacePoolStateException 
invalidStateException = f_1581_47554_47674(message, f_1581_47626_47641(stateInfo), RunspacePoolState.Disconnected)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,47695,47723);

throw invalidStateException;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,46052,47738);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,45048,47749);

bool
f_1581_45156_45179_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 45156, 45179);
return return_v;
}


string
f_1581_45262_45295()
{
var return_v = RunspacePoolStrings.CannotConnect;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 45262, 45295);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1581_45219_45296(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 45219, 45296);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_45477_45492(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 45477, 45492);
return return_v;
}


System.Management.Automation.RunspacePoolStateInfo
f_1581_45640_45701(System.Management.Automation.Runspaces.RunspacePoolState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.RunspacePoolStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 45640, 45701);
return return_v;
}


int
f_1581_45726_45760(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
newStateInfo)
{
this_param.SetRunspacePoolState( newStateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 45726, 45760);
return 0;
}


int
f_1581_45947_45984(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
stateInfo)
{
this_param.RaiseStateChangeEvent( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 45947, 45984);
return 0;
}


System.Management.Automation.Runspaces.RunspacePoolAsyncResult
f_1581_46348_46433(System.Guid
ownerId,System.AsyncCallback
callback,object
state,bool
isCalledFromOpenAsync)
{
var return_v = new System.Management.Automation.Runspaces.RunspacePoolAsyncResult( ownerId, callback, state, isCalledFromOpenAsync);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 46348, 46433);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_46703_46723()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 46703, 46723);
return return_v;
}


int
f_1581_46703_46744(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param)
{
this_param.ReconnectPoolAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 46703, 46744);
return 0;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_47058_47078()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 47058, 47078);
return return_v;
}


int
f_1581_47058_47097(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param)
{
this_param.ConnectPoolAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 47058, 47097);
return 0;
}


int
f_1581_47194_47231(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
stateInfo)
{
this_param.RaiseStateChangeEvent( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 47194, 47231);
return 0;
}


string
f_1581_47383_47427()
{
var return_v = RunspacePoolStrings.InvalidRunspacePoolState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 47383, 47427);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_47461_47476(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 47461, 47476);
return return_v;
}


string
f_1581_47365_47477(string
formatSpec,System.Management.Automation.Runspaces.RunspacePoolState
o1,System.Management.Automation.Runspaces.RunspacePoolState
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 47365, 47477);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_47626_47641(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 47626, 47641);
return return_v;
}


System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
f_1581_47554_47674(string
message,System.Management.Automation.Runspaces.RunspacePoolState
currentState,System.Management.Automation.Runspaces.RunspacePoolState
expectedState)
{
var return_v = new System.Management.Automation.Runspaces.InvalidRunspacePoolStateException( message, currentState, expectedState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 47554, 47674);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,45048,47749);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,45048,47749);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override void EndConnect(IAsyncResult asyncResult)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,47925,48799);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,48007,48139) || true) && (asyncResult == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,48007,48139);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,48064,48124);

throw f_1581_48070_48123("asyncResult");
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,48007,48139);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,48155,48234);

RunspacePoolAsyncResult 
rsAsyncResult = asyncResult as RunspacePoolAsyncResult
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,48250,48746) || true) && ((rsAsyncResult == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1581, 48254, 48335)||                (f_1581_48299_48320(rsAsyncResult)!= instanceId) )||(DynAbs.Tracing.TraceSender.Expression_False(1581, 48254, 48397)||                (f_1581_48357_48396(rsAsyncResult))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,48250,48746);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,48431,48731);

throw f_1581_48437_48730("asyncResult", f_1581_48545_48584(), "IAsyncResult", "BeginOpen");
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,48250,48746);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,48762,48788);

f_1581_48762_48787(
            rsAsyncResult);
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,47925,48799);

System.Management.Automation.PSArgumentNullException
f_1581_48070_48123(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 48070, 48123);
return return_v;
}


System.Guid
f_1581_48299_48320(System.Management.Automation.Runspaces.RunspacePoolAsyncResult
this_param)
{
var return_v = this_param.OwnerId ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 48299, 48320);
return return_v;
}


bool
f_1581_48357_48396(System.Management.Automation.Runspaces.RunspacePoolAsyncResult
this_param)
{
var return_v = this_param.IsAssociatedWithAsyncOpen;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 48357, 48396);
return return_v;
}


string
f_1581_48545_48584()
{
var return_v =                                                          RunspacePoolStrings.AsyncResultNotOwned;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 48545, 48584);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1581_48437_48730(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 48437, 48730);
return return_v;
}


int
f_1581_48762_48787(System.Management.Automation.Runspaces.RunspacePoolAsyncResult
this_param)
{
this_param.EndInvoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 48762, 48787);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,47925,48799);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,47925,48799);
}
		}

public override Collection<PowerShell> CreateDisconnectedPowerShells(RunspacePool runspacePool)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,49103,49997);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,49223,49290);

Collection<PowerShell> 
psCollection = f_1581_49261_49289()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,49306,49671) || true) && (f_1581_49310_49325()== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,49306,49671);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,49500,49589);

string 
msg = f_1581_49513_49588(f_1581_49531_49576(), f_1581_49578_49587(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,49607,49656);

throw f_1581_49613_49655(msg);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,49306,49671);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,49777,49950);
foreach(ConnectCommandInfo connectCmdInfo in f_1581_49823_49838_I(f_1581_49823_49838()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,49777,49950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,49872,49935);

f_1581_49872_49934(                psCollection, f_1581_49889_49933(connectCmdInfo, runspacePool));
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,49777,49950);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1581,1,174);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1581,1,174);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,49966,49986);

return psCollection;
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,49103,49997);

System.Collections.ObjectModel.Collection<System.Management.Automation.PowerShell>
f_1581_49261_49289()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PowerShell>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 49261, 49289);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ConnectCommandInfo[]
f_1581_49310_49325()
{
var return_v = ConnectCommands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 49310, 49325);
return return_v;
}


string
f_1581_49531_49576()
{
var return_v = RunspacePoolStrings.CannotReconstructCommands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 49531, 49576);
return return_v;
}


string
f_1581_49578_49587(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 49578, 49587);
return return_v;
}


string
f_1581_49513_49588(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 49513, 49588);
return return_v;
}


System.Management.Automation.Runspaces.InvalidRunspacePoolStateException
f_1581_49613_49655(string
message)
{
var return_v = new System.Management.Automation.Runspaces.InvalidRunspacePoolStateException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 49613, 49655);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ConnectCommandInfo[]
f_1581_49823_49838()
{
var return_v = ConnectCommands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 49823, 49838);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_49889_49933(System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
connectCmdInfo,System.Management.Automation.Runspaces.RunspacePool
rsConnection)
{
var return_v = new System.Management.Automation.PowerShell( connectCmdInfo, (object)rsConnection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 49889, 49933);
return return_v;
}


int
f_1581_49872_49934(System.Collections.ObjectModel.Collection<System.Management.Automation.PowerShell>
this_param,System.Management.Automation.PowerShell
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 49872, 49934);
return 0;
}


System.Management.Automation.Runspaces.Internal.ConnectCommandInfo[]
f_1581_49823_49838_I(System.Management.Automation.Runspaces.Internal.ConnectCommandInfo[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 49823, 49838);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,49103,49997);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,49103,49997);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override RunspacePoolCapability GetCapabilities()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,50159,50490);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,50240,50307);

RunspacePoolCapability 
returnCaps = RunspacePoolCapability.Default
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,50323,50445) || true) && (f_1581_50327_50340())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,50323,50445);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,50374,50430);

returnCaps |= RunspacePoolCapability.SupportsDisconnect;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,50323,50445);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,50461,50479);

return returnCaps;
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,50159,50490);

bool
f_1581_50327_50340()
{
var return_v = CanDisconnect;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 50327, 50340);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,50159,50490);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,50159,50490);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static RunspacePool[] GetRemoteRunspacePools(RunspaceConnectionInfo connectionInfo, PSHost host, TypeTable typeTable)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1581,50573,55713);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,50724,50809);

WSManConnectionInfo 
wsmanConnectionInfoParam = connectionInfo as WSManConnectionInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,50895,51014) || true) && (wsmanConnectionInfoParam == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,50895,51014);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,50965,50999);

throw f_1581_50971_50998();
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,50895,51014);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,51030,51094);

List<RunspacePool> 
discRunspacePools = f_1581_51069_51093()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,51154,51262);

Collection<PSObject> 
runspaceItems = f_1581_51191_51261(wsmanConnectionInfoParam)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,51276,55651);
foreach(PSObject rsObject in f_1581_51306_51319_I(runspaceItems) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,51276,55651);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,51448,51522);

WSManConnectionInfo 
wsmanConnectionInfo = f_1581_51490_51521(wsmanConnectionInfoParam)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,51542,51601);

PSPropertyInfo 
pspShellId = f_1581_51570_51600(f_1581_51570_51589(rsObject), "ShellId")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,51619,51674);

PSPropertyInfo 
pspState = f_1581_51645_51673(f_1581_51645_51664(rsObject), "State")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,51692,51745);

PSPropertyInfo 
pspName = f_1581_51717_51744(f_1581_51717_51736(rsObject), "Name")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,51763,51830);

PSPropertyInfo 
pspResourceUri = f_1581_51795_51829(f_1581_51795_51814(rsObject), "ResourceUri")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,51850,52007) || true) && (pspShellId == null ||(DynAbs.Tracing.TraceSender.Expression_False(1581, 51854, 51892)||pspState == null )||(DynAbs.Tracing.TraceSender.Expression_False(1581, 51854, 51911)||pspName == null )||(DynAbs.Tracing.TraceSender.Expression_False(1581, 51854, 51937)||pspResourceUri == null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,51850,52007);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,51979,51988);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,51850,52007);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,52027,52069);

string 
strName = f_1581_52044_52068(f_1581_52044_52057(pspName))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,52087,52140);

string 
strShellUri = f_1581_52108_52139(f_1581_52108_52128(pspResourceUri))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,52158,52265);

bool 
isDisconnected = f_1581_52180_52264(f_1581_52180_52205(f_1581_52180_52194(pspState)), "Disconnected", StringComparison.OrdinalIgnoreCase)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,52283,52338);

Guid 
shellId = Guid.Parse(f_1581_52309_52336(f_1581_52309_52325(pspShellId)))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,52425,52600) || true) && (f_1581_52429_52521(strShellUri, WSManNativeApi.ResourceURIPrefix, StringComparison.OrdinalIgnoreCase)== false)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,52425,52600);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,52572,52581);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,52425,52600);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,52697,52754);

f_1581_52697_52753(wsmanConnectionInfo, rsObject);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,52880,52927);

wsmanConnectionInfo.EnableNetworkAccess = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,53021,53403) || true) && (isDisconnected)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,53021,53403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,53081,53106);

DateTime? 
disconnectedOn
=default(DateTime?);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,53128,53148);

DateTime? 
expiresOn
=default(DateTime?);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,53170,53246);

f_1581_53170_53245(rsObject, out disconnectedOn, out expiresOn);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,53268,53320);

wsmanConnectionInfo.DisconnectedOn = disconnectedOn;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,53342,53384);

wsmanConnectionInfo.ExpiresOn = expiresOn;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,53021,53403);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,53423,53497);

List<ConnectCommandInfo> 
connectCmdInfos = f_1581_53466_53496()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,53578,53612);

Collection<PSObject> 
commandItems
=default(Collection<PSObject>);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,53674,53767);

commandItems = f_1581_53689_53766(shellId, wsmanConnectionInfo);
                }
                catch (CmdletInvocationException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1581,53804,54273);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,53880,54224) || true) && (f_1581_53884_53900(e)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1581, 53884, 53957)&&f_1581_53912_53928(e)is InvalidOperationException))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,53880,54224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,54192,54201);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,53880,54224);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,54248,54254);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1581,53804,54273);
                }
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,54293,55068);
foreach(PSObject cmdObject in f_1581_54324_54336_I(commandItems) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,54293,55068);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,54378,54442);

PSPropertyInfo 
pspCommandId = f_1581_54408_54441(f_1581_54408_54428(cmdObject), "CommandId")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,54464,54532);

PSPropertyInfo 
pspCommandLine = f_1581_54496_54531(f_1581_54496_54516(cmdObject), "CommandLine")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,54556,54773) || true) && (pspCommandId == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,54556,54773);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,54630,54715);

f_1581_54630_54714(false, "Should not get an empty command Id from a remote runspace pool.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,54741,54750);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,54556,54773);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,54797,54888);

string 
cmdLine = (DynAbs.Tracing.TraceSender.Conditional_F1(1581, 54814, 54838)||(((pspCommandLine != null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1581, 54841, 54872))||DynAbs.Tracing.TraceSender.Conditional_F3(1581, 54875, 54887)))?f_1581_54841_54872(f_1581_54841_54861(pspCommandLine)):string.Empty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,54910,54965);

Guid 
cmdId = Guid.Parse(f_1581_54934_54963(f_1581_54934_54952(pspCommandId)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,54989,55049);

f_1581_54989_55048(
                    connectCmdInfos, f_1581_55009_55047(cmdId, cmdLine));
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,54293,55068);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1581,1,776);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1581,1,776);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,55417,55582);

RunspacePool 
runspacePool = f_1581_55445_55581(isDisconnected, shellId, strName, f_1581_55517_55542(                    connectCmdInfos), wsmanConnectionInfo, host, typeTable)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,55600,55636);

f_1581_55600_55635(                discRunspacePools, runspacePool);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,51276,55651);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1581,1,4376);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1581,1,4376);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,55667,55702);

return f_1581_55674_55701(discRunspacePools);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1581,50573,55713);

System.NotSupportedException
f_1581_50971_50998()
{
var return_v = new System.NotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 50971, 50998);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.RunspacePool>
f_1581_51069_51093()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Runspaces.RunspacePool>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 51069, 51093);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1581_51191_51261(System.Management.Automation.Runspaces.WSManConnectionInfo
wsmanConnectionInfo)
{
var return_v = RemoteRunspacePoolEnumeration.GetRemotePools( wsmanConnectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 51191, 51261);
return return_v;
}


System.Management.Automation.Runspaces.WSManConnectionInfo
f_1581_51490_51521(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.Copy();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 51490, 51521);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1581_51570_51589(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 51570, 51589);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1581_51570_51600(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 51570, 51600);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1581_51645_51664(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 51645, 51664);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1581_51645_51673(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 51645, 51673);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1581_51717_51736(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 51717, 51736);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1581_51717_51744(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 51717, 51744);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1581_51795_51814(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 51795, 51814);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1581_51795_51829(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 51795, 51829);
return return_v;
}


object
f_1581_52044_52057(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 52044, 52057);
return return_v;
}


string?
f_1581_52044_52068(object
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 52044, 52068);
return return_v;
}


object
f_1581_52108_52128(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 52108, 52128);
return return_v;
}


string?
f_1581_52108_52139(object
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 52108, 52139);
return return_v;
}


object
f_1581_52180_52194(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 52180, 52194);
return return_v;
}


string?
f_1581_52180_52205(object
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 52180, 52205);
return return_v;
}


bool
f_1581_52180_52264(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 52180, 52264);
return return_v;
}


object
f_1581_52309_52325(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 52309, 52325);
return return_v;
}


string?
f_1581_52309_52336(object
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 52309, 52336);
return return_v;
}


bool
f_1581_52429_52521(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.StartsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 52429, 52521);
return return_v;
}


int
f_1581_52697_52753(System.Management.Automation.Runspaces.WSManConnectionInfo
wsmanConnectionInfo,System.Management.Automation.PSObject
rsInfoObject)
{
UpdateWSManConnectionInfo( wsmanConnectionInfo, rsInfoObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 52697, 52753);
return 0;
}


int
f_1581_53170_53245(System.Management.Automation.PSObject
rsInfoObject,out System.DateTime?
disconnectedOn,out System.DateTime?
expiresOn)
{
ComputeDisconnectedOnExpiresOn( rsInfoObject, out disconnectedOn, out expiresOn);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 53170, 53245);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.Internal.ConnectCommandInfo>
f_1581_53466_53496()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Runspaces.Internal.ConnectCommandInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 53466, 53496);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1581_53689_53766(System.Guid
shellId,System.Management.Automation.Runspaces.WSManConnectionInfo
wsmanConnectionInfo)
{
var return_v = RemoteRunspacePoolEnumeration.GetRemoteCommands( shellId, wsmanConnectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 53689, 53766);
return return_v;
}


System.Exception
f_1581_53884_53900(System.Management.Automation.CmdletInvocationException
this_param)
{
var return_v = this_param.InnerException ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 53884, 53900);
return return_v;
}


System.Exception
f_1581_53912_53928(System.Management.Automation.CmdletInvocationException
this_param)
{
var return_v = this_param.InnerException ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 53912, 53928);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1581_54408_54428(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 54408, 54428);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1581_54408_54441(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 54408, 54441);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1581_54496_54516(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 54496, 54516);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1581_54496_54531(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 54496, 54531);
return return_v;
}


int
f_1581_54630_54714(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 54630, 54714);
return 0;
}


object
f_1581_54841_54861(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 54841, 54861);
return return_v;
}


string?
f_1581_54841_54872(object
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 54841, 54872);
return return_v;
}


object
f_1581_54934_54952(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 54934, 54952);
return return_v;
}


string?
f_1581_54934_54963(object
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 54934, 54963);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
f_1581_55009_55047(System.Guid
cmdId,string
cmdStr)
{
var return_v = new System.Management.Automation.Runspaces.Internal.ConnectCommandInfo( cmdId, cmdStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 55009, 55047);
return return_v;
}


int
f_1581_54989_55048(System.Collections.Generic.List<System.Management.Automation.Runspaces.Internal.ConnectCommandInfo>
this_param,System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 54989, 55048);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1581_54324_54336_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 54324, 54336);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ConnectCommandInfo[]
f_1581_55517_55542(System.Collections.Generic.List<System.Management.Automation.Runspaces.Internal.ConnectCommandInfo>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 55517, 55542);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1581_55445_55581(bool
isDisconnected,System.Guid
instanceId,string
name,System.Management.Automation.Runspaces.Internal.ConnectCommandInfo[]
connectCommands,System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Runspaces.TypeTable
typeTable)
{
var return_v = new System.Management.Automation.Runspaces.RunspacePool( isDisconnected, instanceId, name, connectCommands, (System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host, typeTable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 55445, 55581);
return return_v;
}


int
f_1581_55600_55635(System.Collections.Generic.List<System.Management.Automation.Runspaces.RunspacePool>
this_param,System.Management.Automation.Runspaces.RunspacePool
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 55600, 55635);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1581_51306_51319_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 51306, 51319);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool[]
f_1581_55674_55701(System.Collections.Generic.List<System.Management.Automation.Runspaces.RunspacePool>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 55674, 55701);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,50573,55713);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,50573,55713);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static RunspacePool GetRemoteRunspacePool(RunspaceConnectionInfo connectionInfo, Guid sessionId, Guid? commandId, PSHost host, TypeTable typeTable)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1581,55725,56281);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,55906,55980);

List<ConnectCommandInfo> 
connectCmdInfos = f_1581_55949_55979()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,55994,56139) || true) && (commandId != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,55994,56139);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,56049,56124);

f_1581_56049_56123(                connectCmdInfos, f_1581_56069_56122(commandId.Value, string.Empty));
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,55994,56139);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,56155,56270);

return f_1581_56162_56269(true, sessionId, string.Empty, f_1581_56210_56235(connectCmdInfos), connectionInfo, host, typeTable);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1581,55725,56281);

System.Collections.Generic.List<System.Management.Automation.Runspaces.Internal.ConnectCommandInfo>
f_1581_55949_55979()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Runspaces.Internal.ConnectCommandInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 55949, 55979);
return return_v;
}


System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
f_1581_56069_56122(System.Guid
cmdId,string
cmdStr)
{
var return_v = new System.Management.Automation.Runspaces.Internal.ConnectCommandInfo( cmdId, cmdStr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 56069, 56122);
return return_v;
}


int
f_1581_56049_56123(System.Collections.Generic.List<System.Management.Automation.Runspaces.Internal.ConnectCommandInfo>
this_param,System.Management.Automation.Runspaces.Internal.ConnectCommandInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 56049, 56123);
return 0;
}


System.Management.Automation.Runspaces.Internal.ConnectCommandInfo[]
f_1581_56210_56235(System.Collections.Generic.List<System.Management.Automation.Runspaces.Internal.ConnectCommandInfo>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 56210, 56235);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1581_56162_56269(bool
isDisconnected,System.Guid
instanceId,string
name,System.Management.Automation.Runspaces.Internal.ConnectCommandInfo[]
connectCommands,System.Management.Automation.Runspaces.RunspaceConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Runspaces.TypeTable
typeTable)
{
var return_v = new System.Management.Automation.Runspaces.RunspacePool( isDisconnected, instanceId, name, connectCommands, connectionInfo, host, typeTable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 56162, 56269);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,55725,56281);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,55725,56281);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static void UpdateWSManConnectionInfo(
            WSManConnectionInfo wsmanConnectionInfo,
            PSObject rsInfoObject)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1581,56293,60830);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,56454,56525);

PSPropertyInfo 
pspIdleTimeOut = f_1581_56486_56524(f_1581_56486_56509(rsInfoObject), "IdleTimeOut")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,56539,56608);

PSPropertyInfo 
pspBufferMode = f_1581_56570_56607(f_1581_56570_56593(rsInfoObject), "BufferMode")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,56622,56693);

PSPropertyInfo 
pspResourceUri = f_1581_56654_56692(f_1581_56654_56677(rsInfoObject), "ResourceUri")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,56707,56768);

PSPropertyInfo 
pspLocale = f_1581_56734_56767(f_1581_56734_56757(rsInfoObject), "Locale")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,56782,56851);

PSPropertyInfo 
pspDataLocale = f_1581_56813_56850(f_1581_56813_56836(rsInfoObject), "DataLocale")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,56865,56944);

PSPropertyInfo 
pspCompressionMode = f_1581_56901_56943(f_1581_56901_56924(rsInfoObject), "CompressionMode")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,56958,57023);

PSPropertyInfo 
pspEncoding = f_1581_56987_57022(f_1581_56987_57010(rsInfoObject), "Encoding")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,57037,57106);

PSPropertyInfo 
pspProfile = f_1581_57065_57105(f_1581_57065_57088(rsInfoObject), "ProfileLoaded")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,57120,57197);

PSPropertyInfo 
pspMaxIdleTimeout = f_1581_57155_57196(f_1581_57155_57178(rsInfoObject), "MaxIdleTimeout")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,57213,57497) || true) && (pspIdleTimeOut != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,57213,57497);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,57273,57289);

int 
idleTimeout
=default(int);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,57307,57482) || true) && (f_1581_57311_57375(f_1581_57327_57347(pspIdleTimeOut)as string, out idleTimeout))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,57307,57482);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,57417,57463);

wsmanConnectionInfo.IdleTimeout = idleTimeout;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,57307,57482);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,57213,57497);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,57513,58071) || true) && (pspBufferMode != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,57513,58071);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,57572,57625);

string 
bufferingMode = f_1581_57595_57614(pspBufferMode)as string
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,57643,58056) || true) && (bufferingMode != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,57643,58056);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,57710,57750);

OutputBufferingMode 
outputBufferingMode
=default(OutputBufferingMode);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,57772,58037) || true) && (f_1581_57776_57850(bufferingMode, out outputBufferingMode))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,57772,58037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,57952,58014);

wsmanConnectionInfo.OutputBufferingMode = outputBufferingMode;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,57772,58037);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,57643,58056);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,57513,58071);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,58087,58359) || true) && (pspResourceUri != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,58087,58359);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,58147,58199);

string 
strShellUri = f_1581_58168_58188(pspResourceUri)as string
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,58217,58344) || true) && (strShellUri != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,58217,58344);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,58282,58325);

wsmanConnectionInfo.ShellUri = strShellUri;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,58217,58344);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,58087,58359);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,58375,58802) || true) && (pspLocale != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,58375,58802);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,58430,58477);

string 
localString = f_1581_58451_58466(pspLocale)as string
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,58495,58787) || true) && (localString != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,58495,58787);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,58612,58673);

wsmanConnectionInfo.UICulture = f_1581_58644_58672(localString);
                    }
                    catch (ArgumentException)
                    { DynAbs.Tracing.TraceSender.TraceEnterCatch(1581,58718,58768);
DynAbs.Tracing.TraceSender.TraceExitCatch(1581,58718,58768);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,58495,58787);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,58375,58802);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,58818,59263) || true) && (pspDataLocale != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,58818,59263);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,58877,58932);

string 
dataLocalString = f_1581_58902_58921(pspDataLocale)as string
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,58950,59248) || true) && (dataLocalString != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,58950,59248);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,59071,59134);

wsmanConnectionInfo.Culture = f_1581_59101_59133(dataLocalString);
                    }
                    catch (ArgumentException)
                    { DynAbs.Tracing.TraceSender.TraceEnterCatch(1581,59179,59229);
DynAbs.Tracing.TraceSender.TraceExitCatch(1581,59179,59229);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,58950,59248);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,58818,59263);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,59279,59695) || true) && (pspCompressionMode != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,59279,59695);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,59343,59409);

string 
compressionModeString = f_1581_59374_59398(pspCompressionMode)as string
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,59427,59680) || true) && (compressionModeString != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,59427,59680);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,59502,59661);

wsmanConnectionInfo.UseCompression = (DynAbs.Tracing.TraceSender.Conditional_F1(1581, 59539, 59620)||((f_1581_59539_59620(compressionModeString, "NoCompression", StringComparison.OrdinalIgnoreCase)&&DynAbs.Tracing.TraceSender.Conditional_F2(1581, 59648, 59653))||DynAbs.Tracing.TraceSender.Conditional_F3(1581, 59656, 59660)))?false :true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,59427,59680);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,59279,59695);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,59711,60078) || true) && (pspEncoding != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,59711,60078);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,59768,59820);

string 
encodingString = f_1581_59792_59809(pspEncoding)as string
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,59838,60063) || true) && (encodingString != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,59838,60063);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,59906,60044);

wsmanConnectionInfo.UseUTF16 = (DynAbs.Tracing.TraceSender.Conditional_F1(1581, 59937, 60003)||((f_1581_59937_60003(encodingString, "UTF16", StringComparison.OrdinalIgnoreCase)&&DynAbs.Tracing.TraceSender.Conditional_F2(1581, 60031, 60035))||DynAbs.Tracing.TraceSender.Conditional_F3(1581, 60038, 60043)))?true :false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,59838,60063);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,59711,60078);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,60094,60501) || true) && (pspProfile != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,60094,60501);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,60150,60213);

string 
machineProfileLoadedString = f_1581_60186_60202(pspProfile)as string
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,60231,60486) || true) && (machineProfileLoadedString != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,60231,60486);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,60311,60467);

wsmanConnectionInfo.NoMachineProfile = (DynAbs.Tracing.TraceSender.Conditional_F1(1581, 60350, 60426)||((f_1581_60350_60426(machineProfileLoadedString, "Yes", StringComparison.OrdinalIgnoreCase)&&DynAbs.Tracing.TraceSender.Conditional_F2(1581, 60454, 60459))||DynAbs.Tracing.TraceSender.Conditional_F3(1581, 60462, 60466)))?false :true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,60231,60486);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,60094,60501);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,60517,60819) || true) && (pspMaxIdleTimeout != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,60517,60819);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,60580,60599);

int 
maxIdleTimeout
=default(int);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,60617,60804) || true) && (f_1581_60621_60691(f_1581_60637_60660(pspMaxIdleTimeout)as string, out maxIdleTimeout))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,60617,60804);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,60733,60785);

wsmanConnectionInfo.MaxIdleTimeout = maxIdleTimeout;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,60617,60804);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,60517,60819);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1581,56293,60830);

System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1581_56486_56509(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 56486, 56509);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1581_56486_56524(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 56486, 56524);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1581_56570_56593(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 56570, 56593);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1581_56570_56607(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 56570, 56607);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1581_56654_56677(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 56654, 56677);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1581_56654_56692(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 56654, 56692);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1581_56734_56757(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 56734, 56757);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1581_56734_56767(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 56734, 56767);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1581_56813_56836(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 56813, 56836);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1581_56813_56850(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 56813, 56850);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1581_56901_56924(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 56901, 56924);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1581_56901_56943(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 56901, 56943);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1581_56987_57010(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 56987, 57010);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1581_56987_57022(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 56987, 57022);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1581_57065_57088(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 57065, 57088);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1581_57065_57105(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 57065, 57105);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1581_57155_57178(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 57155, 57178);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1581_57155_57196(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 57155, 57196);
return return_v;
}


object
f_1581_57327_57347(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 57327, 57347);
return return_v;
}


bool
f_1581_57311_57375(object
timeString,out int
value)
{
var return_v = GetTimeIntValue( (string)timeString, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 57311, 57375);
return return_v;
}


object
f_1581_57595_57614(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 57595, 57614);
return return_v;
}


bool
f_1581_57776_57850(string
value,out System.Management.Automation.Runspaces.OutputBufferingMode
result)
{
var return_v = Enum.TryParse<OutputBufferingMode>( value, out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 57776, 57850);
return return_v;
}


object
f_1581_58168_58188(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 58168, 58188);
return return_v;
}


object
f_1581_58451_58466(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 58451, 58466);
return return_v;
}


System.Globalization.CultureInfo
f_1581_58644_58672(string
name)
{
var return_v = new System.Globalization.CultureInfo( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 58644, 58672);
return return_v;
}


object
f_1581_58902_58921(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 58902, 58921);
return return_v;
}


System.Globalization.CultureInfo
f_1581_59101_59133(string
name)
{
var return_v = new System.Globalization.CultureInfo( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 59101, 59133);
return return_v;
}


object
f_1581_59374_59398(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 59374, 59398);
return return_v;
}


bool
f_1581_59539_59620(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 59539, 59620);
return return_v;
}


object
f_1581_59792_59809(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 59792, 59809);
return return_v;
}


bool
f_1581_59937_60003(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 59937, 60003);
return return_v;
}


object
f_1581_60186_60202(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 60186, 60202);
return return_v;
}


bool
f_1581_60350_60426(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 60350, 60426);
return return_v;
}


object
f_1581_60637_60660(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 60637, 60660);
return return_v;
}


bool
f_1581_60621_60691(object
timeString,out int
value)
{
var return_v = GetTimeIntValue( (string)timeString, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 60621, 60691);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,56293,60830);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,56293,60830);
}
		}

private static void ComputeDisconnectedOnExpiresOn(
            PSObject rsInfoObject,
            out DateTime? disconnectedOn,
            out DateTime? expiresOn)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1581,60842,62562);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,61035,61106);

PSPropertyInfo 
pspIdleTimeOut = f_1581_61067_61105(f_1581_61067_61090(rsInfoObject), "IdleTimeOut")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,61120,61199);

PSPropertyInfo 
pspShellInactivity = f_1581_61156_61198(f_1581_61156_61179(rsInfoObject), "ShellInactivity")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,61215,62482) || true) && (pspIdleTimeOut != null &&(DynAbs.Tracing.TraceSender.Expression_True(1581, 61219, 61271)&&pspShellInactivity != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,61215,62482);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,61305,61371);

string 
shellInactivityString = f_1581_61336_61360(pspShellInactivity)as string
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,61389,61405);

int 
idleTimeout
=default(int);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,61423,62467) || true) && ((shellInactivityString != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1581, 61427, 61547)&&f_1581_61483_61547(f_1581_61499_61519(pspIdleTimeOut)as string, out idleTimeout)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,61423,62467);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,61641,61721);

TimeSpan 
shellInactivityTime = f_1581_61672_61720(shellInactivityString)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,61747,61815);

TimeSpan 
idleTimeoutTime = TimeSpan.FromSeconds(idleTimeout / 1000)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,61843,62201) || true) && (idleTimeoutTime > shellInactivityTime)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,61843,62201);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,61942,61970);

DateTime 
now = DateTime.Now
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,62000,62051);

disconnectedOn = now.Subtract(shellInactivityTime);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,62081,62135);

expiresOn = disconnectedOn.Value.Add(idleTimeoutTime);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,62167,62174);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,61843,62201);
}
                    }
                    catch (FormatException)
                    { DynAbs.Tracing.TraceSender.TraceEnterCatch(1581,62246,62294);
DynAbs.Tracing.TraceSender.TraceExitCatch(1581,62246,62294);
}
                    catch (ArgumentOutOfRangeException)
                    { DynAbs.Tracing.TraceSender.TraceEnterCatch(1581,62316,62376);
DynAbs.Tracing.TraceSender.TraceExitCatch(1581,62316,62376);
}
                    catch (OverflowException)
                    { DynAbs.Tracing.TraceSender.TraceEnterCatch(1581,62398,62448);
DynAbs.Tracing.TraceSender.TraceExitCatch(1581,62398,62448);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,61423,62467);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,61215,62482);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,62498,62520);

disconnectedOn = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,62534,62551);

expiresOn = null;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1581,60842,62562);

System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1581_61067_61090(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 61067, 61090);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1581_61067_61105(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 61067, 61105);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1581_61156_61179(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 61156, 61179);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1581_61156_61198(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 61156, 61198);
return return_v;
}


object
f_1581_61336_61360(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 61336, 61360);
return return_v;
}


object
f_1581_61499_61519(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 61499, 61519);
return return_v;
}


bool
f_1581_61483_61547(object
timeString,out int
value)
{
var return_v = GetTimeIntValue( (string)timeString, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 61483, 61547);
return return_v;
}


System.TimeSpan
f_1581_61672_61720(string
s)
{
var return_v = Xml.XmlConvert.ToTimeSpan( s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 61672, 61720);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,60842,62562);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,60842,62562);
}
		}

private static bool GetTimeIntValue(string timeString, out int value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1581,62574,63432);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,62668,63368) || true) && (timeString != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,62668,63368);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,62724,62813);

string 
timeoutString = f_1581_62747_62812(f_1581_62747_62785(timeString, "PT", string.Empty), "S", string.Empty)
;
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,62942,63036);

int 
idleTimeout = (int)(f_1581_62966_63027(timeoutString, f_1581_62998_63026())* 1000)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,63058,63208) || true) && (idleTimeout > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,63058,63208);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,63127,63147);

value = idleTimeout;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,63173,63185);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,63058,63208);
}
                }
                catch (FormatException)
                { DynAbs.Tracing.TraceSender.TraceEnterCatch(1581,63245,63289);
DynAbs.Tracing.TraceSender.TraceExitCatch(1581,63245,63289);
}
                catch (OverflowException)
                { DynAbs.Tracing.TraceSender.TraceEnterCatch(1581,63307,63353);
DynAbs.Tracing.TraceSender.TraceExitCatch(1581,63307,63353);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,62668,63368);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,63384,63394);

value = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,63408,63421);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1581,62574,63432);

string
f_1581_62747_62785(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 62747, 62785);
return return_v;
}


string
f_1581_62747_62812(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 62747, 62812);
return return_v;
}


System.Globalization.CultureInfo
f_1581_62998_63026()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 62998, 63026);
return return_v;
}


double
f_1581_62966_63027(string
value,System.Globalization.CultureInfo
provider)
{
var return_v = Convert.ToDouble( value, (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 62966, 63027);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,62574,63432);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,62574,63432);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void SetRunspacePoolState(RunspacePoolStateInfo newStateInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,63794,63941);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,63888,63930);

f_1581_63888_63929(this, newStateInfo, false);
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,63794,63941);

int
f_1581_63888_63929(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
newStateInfo,bool
raiseEvents)
{
this_param.SetRunspacePoolState( newStateInfo, raiseEvents);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 63888, 63929);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,63794,63941);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,63794,63941);
}
		}

private void SetRunspacePoolState(RunspacePoolStateInfo newStateInfo, bool raiseEvents)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,64358,64888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,64470,64495);

stateInfo = newStateInfo;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,64593,64761);

AvailableForConnection = (f_1581_64619_64634(stateInfo)== RunspacePoolState.Disconnected ||(DynAbs.Tracing.TraceSender.Expression_False(1581, 64619, 64759)||f_1581_64716_64731(stateInfo)== RunspacePoolState.Opened));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,64777,64877) || true) && (raiseEvents)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,64777,64877);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,64826,64862);

f_1581_64826_64861(this, newStateInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,64777,64877);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,64358,64888);

System.Management.Automation.Runspaces.RunspacePoolState
f_1581_64619_64634(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 64619, 64634);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_64716_64731(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 64716, 64731);
return return_v;
}


int
f_1581_64826_64861(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
stateInfo)
{
this_param.RaiseStateChangeEvent( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 64826, 64861);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,64358,64888);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,64358,64888);
}
		}

private void HandleSessionDisconnected(object sender, RemoteDataEventArgs<Exception> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,64900,65952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,65020,65045);

bool 
stateChange = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,65065,65080);
            lock (this.syncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,65114,65420) || true) && (f_1581_65118_65133(stateInfo)== RunspacePoolState.Disconnecting)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,65114,65420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,65210,65240);

f_1581_65210_65239(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,65264,65360);

f_1581_65264_65359(this, f_1581_65285_65358(RunspacePoolState.Disconnected, f_1581_65343_65357(eventArgs)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,65382,65401);

stateChange = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,65114,65420);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,65688,65709);

_canReconnect = true;
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,65794,65941) || true) && (stateChange)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,65794,65941);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,65843,65881);

f_1581_65843_65880(this, this.stateInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,65899,65926);

f_1581_65899_65925(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,65794,65941);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,64900,65952);

System.Management.Automation.Runspaces.RunspacePoolState
f_1581_65118_65133(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 65118, 65133);
return return_v;
}


int
f_1581_65210_65239(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
this_param.UpdateDisconnectedExpiresOn();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 65210, 65239);
return 0;
}


System.Exception
f_1581_65343_65357(System.Management.Automation.RemoteDataEventArgs<System.Exception>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 65343, 65357);
return return_v;
}


System.Management.Automation.RunspacePoolStateInfo
f_1581_65285_65358(System.Management.Automation.Runspaces.RunspacePoolState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.RunspacePoolStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 65285, 65358);
return return_v;
}


int
f_1581_65264_65359(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
newStateInfo)
{
this_param.SetRunspacePoolState( newStateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 65264, 65359);
return 0;
}


int
f_1581_65843_65880(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
stateInfo)
{
this_param.RaiseStateChangeEvent( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 65843, 65880);
return 0;
}


int
f_1581_65899_65925(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
this_param.SetDisconnectAsCompleted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 65899, 65925);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,64900,65952);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,64900,65952);
}
		}

private void SetDisconnectAsCompleted()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,65964,66265);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,66028,66254) || true) && (_disconnectAsyncResult != null &&(DynAbs.Tracing.TraceSender.Expression_True(1581, 66032, 66101)&&f_1581_66066_66101_M(!_disconnectAsyncResult.IsCompleted)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,66028,66254);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,66135,66191);

f_1581_66135_66190(                _disconnectAsyncResult, f_1581_66173_66189(stateInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,66209,66239);

_disconnectAsyncResult = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,66028,66254);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,65964,66265);

bool
f_1581_66066_66101_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 66066, 66101);
return return_v;
}


System.Exception
f_1581_66173_66189(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 66173, 66189);
return return_v;
}


int
f_1581_66135_66190(System.Management.Automation.Runspaces.RunspacePoolAsyncResult
this_param,System.Exception
exception)
{
this_param.SetAsCompleted( exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 66135, 66190);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,65964,66265);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,65964,66265);
}
		}

private void HandleSessionReconnected(object sender, RemoteDataEventArgs<Exception> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,66277,67020);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,66396,66421);

bool 
stateChange = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,66441,66456);
            lock (this.syncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,66490,66778) || true) && (f_1581_66494_66509(stateInfo)== RunspacePoolState.Connecting)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,66490,66778);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,66583,66614);

f_1581_66583_66613(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,66638,66718);

f_1581_66638_66717(this, f_1581_66659_66716(RunspacePoolState.Opened, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,66740,66759);

stateChange = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,66490,66778);
}
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,66863,67009) || true) && (stateChange)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,66863,67009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,66912,66950);

f_1581_66912_66949(this, this.stateInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,66968,66994);

f_1581_66968_66993(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,66863,67009);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,66277,67020);

System.Management.Automation.Runspaces.RunspacePoolState
f_1581_66494_66509(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 66494, 66509);
return return_v;
}


int
f_1581_66583_66613(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
this_param.ResetDisconnectedOnExpiresOn();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 66583, 66613);
return 0;
}


System.Management.Automation.RunspacePoolStateInfo
f_1581_66659_66716(System.Management.Automation.Runspaces.RunspacePoolState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.RunspacePoolStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 66659, 66716);
return return_v;
}


int
f_1581_66638_66717(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
newStateInfo)
{
this_param.SetRunspacePoolState( newStateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 66638, 66717);
return 0;
}


int
f_1581_66912_66949(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
stateInfo)
{
this_param.RaiseStateChangeEvent( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 66912, 66949);
return 0;
}


int
f_1581_66968_66993(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
this_param.SetReconnectAsCompleted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 66968, 66993);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,66277,67020);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,66277,67020);
}
		}

private void SetReconnectAsCompleted()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,67032,67328);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,67095,67317) || true) && (_reconnectAsyncResult != null &&(DynAbs.Tracing.TraceSender.Expression_True(1581, 67099, 67166)&&f_1581_67132_67166_M(!_reconnectAsyncResult.IsCompleted)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,67095,67317);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,67200,67255);

f_1581_67200_67254(                _reconnectAsyncResult, f_1581_67237_67253(stateInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,67273,67302);

_reconnectAsyncResult = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,67095,67317);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,67032,67328);

bool
f_1581_67132_67166_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 67132, 67166);
return return_v;
}


System.Exception
f_1581_67237_67253(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 67237, 67253);
return return_v;
}


int
f_1581_67200_67254(System.Management.Automation.Runspaces.RunspacePoolAsyncResult
this_param,System.Exception
exception)
{
this_param.SetAsCompleted( exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 67200, 67254);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,67032,67328);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,67032,67328);
}
		}

private void HandleSessionClosing(object sender, RemoteDataEventArgs<Exception> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,67611,67906);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,67863,67895);

_closingReason = f_1581_67880_67894(eventArgs);
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,67611,67906);

System.Exception
f_1581_67880_67894(System.Management.Automation.RemoteDataEventArgs<System.Exception>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 67880, 67894);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,67611,67906);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,67611,67906);
}
		}

private void HandleSessionClosed(object sender, RemoteDataEventArgs<Exception> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,68186,70355);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,68300,68407) || true) && (f_1581_68304_68318(eventArgs)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,68300,68407);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,68360,68392);

_closingReason = f_1581_68377_68391(eventArgs);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,68300,68407);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,68461,68489);

RunspacePoolState 
prevState
=default(RunspacePoolState);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,68503,68543);

RunspacePoolStateInfo 
finishedStateInfo
=default(RunspacePoolStateInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,68563,68573);
            lock (syncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,68607,68635);

prevState = f_1581_68619_68634(stateInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,68655,69530);

switch (prevState)
                {

case RunspacePoolState.Opening:
                    case RunspacePoolState.Opened:
                    case RunspacePoolState.Disconnecting:
                    case RunspacePoolState.Disconnected:
                    case RunspacePoolState.Connecting:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,68655,69530);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,69186,69276);

f_1581_69186_69275(this, f_1581_69207_69274(RunspacePoolState.Broken, _closingReason));
DynAbs.Tracing.TraceSender.TraceBreak(1581,69302,69308);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,68655,69530);

case RunspacePoolState.Closing:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,68655,69530);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,69389,69479);

f_1581_69389_69478(this, f_1581_69410_69477(RunspacePoolState.Closed, _closingReason));
DynAbs.Tracing.TraceSender.TraceBreak(1581,69505,69511);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,68655,69530);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,69550,69631);

finishedStateInfo = f_1581_69570_69630(f_1581_69596_69611(stateInfo), f_1581_69613_69629(stateInfo));
            }

            // Raise notification event outside of lock.
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,69756,69797);

f_1581_69756_69796(this, finishedStateInfo);
            }
            catch (Exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1581,69826,69939);
DynAbs.Tracing.TraceSender.TraceExitCatch(1581,69826,69939);
                // Don't throw exception on notification thread.
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,70171,70198);

f_1581_70171_70197(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,70212,70238);

f_1581_70212_70237(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,70322,70344);

f_1581_70322_70343(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,68186,70355);

System.Exception
f_1581_68304_68318(System.Management.Automation.RemoteDataEventArgs<System.Exception>
this_param)
{
var return_v = this_param.Data ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 68304, 68318);
return return_v;
}


System.Exception
f_1581_68377_68391(System.Management.Automation.RemoteDataEventArgs<System.Exception>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 68377, 68391);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_68619_68634(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 68619, 68634);
return return_v;
}


System.Management.Automation.RunspacePoolStateInfo
f_1581_69207_69274(System.Management.Automation.Runspaces.RunspacePoolState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.RunspacePoolStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 69207, 69274);
return return_v;
}


int
f_1581_69186_69275(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
newStateInfo)
{
this_param.SetRunspacePoolState( newStateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 69186, 69275);
return 0;
}


System.Management.Automation.RunspacePoolStateInfo
f_1581_69410_69477(System.Management.Automation.Runspaces.RunspacePoolState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.RunspacePoolStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 69410, 69477);
return return_v;
}


int
f_1581_69389_69478(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
newStateInfo)
{
this_param.SetRunspacePoolState( newStateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 69389, 69478);
return 0;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1581_69596_69611(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 69596, 69611);
return return_v;
}


System.Exception
f_1581_69613_69629(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 69613, 69629);
return return_v;
}


System.Management.Automation.RunspacePoolStateInfo
f_1581_69570_69630(System.Management.Automation.Runspaces.RunspacePoolState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.RunspacePoolStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 69570, 69630);
return return_v;
}


int
f_1581_69756_69796(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
stateInfo)
{
this_param.RaiseStateChangeEvent( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 69756, 69796);
return 0;
}


int
f_1581_70171_70197(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
this_param.SetDisconnectAsCompleted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 70171, 70197);
return 0;
}


int
f_1581_70212_70237(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
this_param.SetReconnectAsCompleted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 70212, 70237);
return 0;
}


int
f_1581_70322_70343(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
this_param.SetCloseAsCompleted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 70322, 70343);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,68186,70355);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,68186,70355);
}
		}

private void SetOpenAsCompleted()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,70471,70824);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,70529,70592);

RunspacePoolAsyncResult 
tempOpenAsyncResult = _openAsyncResult
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,70606,70630);

_openAsyncResult = null;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,70644,70813) || true) && (tempOpenAsyncResult != null &&(DynAbs.Tracing.TraceSender.Expression_True(1581, 70648, 70711)&&f_1581_70679_70711_M(!tempOpenAsyncResult.IsCompleted)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,70644,70813);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,70745,70798);

f_1581_70745_70797(                tempOpenAsyncResult, f_1581_70780_70796(stateInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,70644,70813);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,70471,70824);

bool
f_1581_70679_70711_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 70679, 70711);
return return_v;
}


System.Exception
f_1581_70780_70796(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 70780, 70796);
return return_v;
}


int
f_1581_70745_70797(System.Management.Automation.Runspaces.RunspacePoolAsyncResult
this_param,System.Exception
exception)
{
this_param.SetAsCompleted( exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 70745, 70797);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,70471,70824);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,70471,70824);
}
		}

private void SetCloseAsCompleted()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,70941,71757);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,71041,71071);

f_1581_71041_71070(f_1581_71041_71054());

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,71087,71259) || true) && (_closeAsyncResult != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,71087,71259);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,71150,71201);

f_1581_71150_71200(                _closeAsyncResult, f_1581_71183_71199(stateInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,71219,71244);

_closeAsyncResult = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,71087,71259);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,71505,71526);

f_1581_71505_71525(this);

            // Ensure private application data wait is released.
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,71644,71682);

f_1581_71644_71681(                _applicationPrivateDataReceived);
            }
            catch (ObjectDisposedException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1581,71711,71746);
DynAbs.Tracing.TraceSender.TraceExitCatch(1581,71711,71746);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,70941,71757);

System.Management.Automation.Remoting.DispatchTable<object>
f_1581_71041_71054()
{
var return_v = DispatchTable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 71041, 71054);
return return_v;
}


int
f_1581_71041_71070(System.Management.Automation.Remoting.DispatchTable<object>
this_param)
{
this_param.AbortAllCalls();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 71041, 71070);
return 0;
}


System.Exception
f_1581_71183_71199(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 71183, 71199);
return return_v;
}


int
f_1581_71150_71200(System.Management.Automation.Runspaces.RunspacePoolAsyncResult
this_param,System.Exception
exception)
{
this_param.SetAsCompleted( exception);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 71150, 71200);
return 0;
}


int
f_1581_71505_71525(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
this_param.SetOpenAsCompleted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 71505, 71525);
return 0;
}


bool
f_1581_71644_71681(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Set();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 71644, 71681);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,70941,71757);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,70941,71757);
}
		}

private void HandleResponseReceived(object sender, RemoteDataEventArgs<PSObject> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,72162,72613);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,72278,72309);

PSObject 
data = f_1581_72294_72308(eventArgs)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,72323,72441);

object 
response = f_1581_72341_72440(data, RemoteDataNameStrings.RunspacePoolOperationResponse)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,72455,72544);

long 
callId = f_1581_72469_72543(data, RemoteDataNameStrings.CallId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,72558,72602);

f_1581_72558_72601(f_1581_72558_72571(), callId, response);
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,72162,72613);

System.Management.Automation.PSObject
f_1581_72294_72308(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 72294, 72308);
return return_v;
}


object
f_1581_72341_72440(System.Management.Automation.PSObject
psObject,string
propertyName)
{
var return_v = RemotingDecoder.GetPropertyValue<object>( psObject, propertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 72341, 72440);
return return_v;
}


long
f_1581_72469_72543(System.Management.Automation.PSObject
psObject,string
propertyName)
{
var return_v = RemotingDecoder.GetPropertyValue<long>( psObject, propertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 72469, 72543);
return return_v;
}


System.Management.Automation.Remoting.DispatchTable<object>
f_1581_72558_72571()
{
var return_v = DispatchTable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 72558, 72571);
return return_v;
}


int
f_1581_72558_72601(System.Management.Automation.Remoting.DispatchTable<object>
this_param,long
callId,object
remoteHostResponse)
{
this_param.SetResponse( callId, remoteHostResponse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 72558, 72601);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,72162,72613);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,72162,72613);
}
		}

private void HandleURIDirectionReported(object sender, RemoteDataEventArgs<Uri> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,72931,73352);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,73046,73127);

WSManConnectionInfo 
wsmanConnectionInfo = _connectionInfo as WSManConnectionInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,73141,73341) || true) && (wsmanConnectionInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,73141,73341);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,73206,73257);

wsmanConnectionInfo.ConnectionUri = f_1581_73242_73256(eventArgs);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,73275,73326);

f_1581_73275_73325(                URIRedirectionReported, this, eventArgs);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,73141,73341);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,72931,73352);

System.Uri
f_1581_73242_73256(System.Management.Automation.RemoteDataEventArgs<System.Uri>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 73242, 73256);
return return_v;
}


int
f_1581_73275_73325(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Uri>>
eventHandler,System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
sender,System.Management.Automation.RemoteDataEventArgs<System.Uri>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Uri>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 73275, 73325);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,72931,73352);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,72931,73352);
}
		}

private void HandlePSEventArgsReceived(object sender, RemoteDataEventArgs<PSEventArgs> e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,73510,73658);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,73624,73647);

f_1581_73624_73646(this, f_1581_73639_73645(e));
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,73510,73658);

System.Management.Automation.PSEventArgs
f_1581_73639_73645(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSEventArgs>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 73639, 73645);
return return_v;
}


int
f_1581_73624_73646(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.PSEventArgs
e)
{
this_param.OnForwardEvent( e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 73624, 73646);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,73510,73658);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,73510,73658);
}
		}

private void HandleSessionRCDisconnecting(object sender, RemoteDataEventArgs<Exception> e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,73940,74448);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,74055,74208);

f_1581_74055_74207(f_1581_74066_74086(this.stateInfo)== RunspacePoolState.Opened, "RC disconnect should only occur for runspace pools in the Opened state.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,74230,74245);

            lock (this.syncObject)
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,74279,74368);

f_1581_74279_74367(this, f_1581_74300_74366(RunspacePoolState.Disconnecting, f_1581_74359_74365(e)));
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,74399,74437);

f_1581_74399_74436(this, this.stateInfo);
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,73940,74448);

System.Management.Automation.Runspaces.RunspacePoolState
f_1581_74066_74086(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 74066, 74086);
return return_v;
}


int
f_1581_74055_74207(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 74055, 74207);
return 0;
}


System.Exception
f_1581_74359_74365(System.Management.Automation.RemoteDataEventArgs<System.Exception>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 74359, 74365);
return return_v;
}


System.Management.Automation.RunspacePoolStateInfo
f_1581_74300_74366(System.Management.Automation.Runspaces.RunspacePoolState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.RunspacePoolStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 74300, 74366);
return return_v;
}


int
f_1581_74279_74367(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
newStateInfo)
{
this_param.SetRunspacePoolState( newStateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 74279, 74367);
return 0;
}


int
f_1581_74399_74436(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
stateInfo)
{
this_param.RaiseStateChangeEvent( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 74399, 74436);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,73940,74448);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,73940,74448);
}
		}

private void HandleSessionCreateCompleted(object sender, CreateCompleteEventArgs eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,74652,75557);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,74851,75423) || true) && (eventArgs != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,74851,75423);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,74906,74973);

_connectionInfo.IdleTimeout = f_1581_74936_74972(f_1581_74936_74960(eventArgs));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,74991,75064);

_connectionInfo.MaxIdleTimeout = f_1581_75024_75063(f_1581_75024_75048(eventArgs));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,75082,75163);

WSManConnectionInfo 
wsmanConnectionInfo = _connectionInfo as WSManConnectionInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,75181,75408) || true) && (wsmanConnectionInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,75181,75408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,75254,75389);

wsmanConnectionInfo.OutputBufferingMode =
f_1581_75321_75388(((WSManConnectionInfo)f_1581_75343_75367(eventArgs)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,75181,75408);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,74851,75423);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,75470,75546);

f_1581_75470_75545(
            // Forward event.
            SessionCreateCompleted, this, eventArgs);
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,74652,75557);

System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1581_74936_74960(System.Management.Automation.Remoting.CreateCompleteEventArgs
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 74936, 74960);
return return_v;
}


int
f_1581_74936_74972(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.IdleTimeout;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 74936, 74972);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1581_75024_75048(System.Management.Automation.Remoting.CreateCompleteEventArgs
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 75024, 75048);
return return_v;
}


int
f_1581_75024_75063(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.MaxIdleTimeout;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 75024, 75063);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1581_75343_75367(System.Management.Automation.Remoting.CreateCompleteEventArgs
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 75343, 75367);
return return_v;
}


System.Management.Automation.Runspaces.OutputBufferingMode
f_1581_75321_75388(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.OutputBufferingMode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 75321, 75388);
return return_v;
}


int
f_1581_75470_75545(System.EventHandler<System.Management.Automation.Remoting.CreateCompleteEventArgs>
eventHandler,System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
sender,System.Management.Automation.Remoting.CreateCompleteEventArgs
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.Remoting.CreateCompleteEventArgs>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 75470, 75545);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,74652,75557);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,74652,75557);
}
		}

private void ResetDisconnectedOnExpiresOn()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,75569,75918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,75684,75765);

WSManConnectionInfo 
wsManConnectionInfo = _connectionInfo as WSManConnectionInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,75779,75907) || true) && (wsManConnectionInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,75779,75907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,75844,75892);

f_1581_75844_75891(                wsManConnectionInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,75779,75907);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,75569,75918);

int
f_1581_75844_75891(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
this_param.NullDisconnectedExpiresOn();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 75844, 75891);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,75569,75918);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,75569,75918);
}
		}

private void UpdateDisconnectedExpiresOn()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,75930,76306);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,76068,76149);

WSManConnectionInfo 
wsManConnectionInfo = _connectionInfo as WSManConnectionInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,76163,76295) || true) && (wsManConnectionInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,76163,76295);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,76228,76280);

f_1581_76228_76279(                wsManConnectionInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,76163,76295);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,75930,76306);

int
f_1581_76228_76279(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
this_param.SetDisconnectedExpiresOnToNow();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 76228, 76279);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,75930,76306);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,75930,76306);
}
		}

private void WaitAndRaiseConnectEventsProc(object state)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,76543,77286);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,76624,76684);

RunspacePoolStateInfo 
info = state as RunspacePoolStateInfo
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,76698,76767);

f_1581_76698_76766(info != null, "State -> Event arguments cannot be null.");

            // Wait for private application data to arrive from server.
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,76892,76934);

f_1581_76892_76933(                _applicationPrivateDataReceived);
            }
            catch (ObjectDisposedException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1581,76963,76998);
DynAbs.Tracing.TraceSender.TraceExitCatch(1581,76963,76998);
}

            // Raise state changed event.
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,77093,77121);

f_1581_77093_77120(this, info);
            }
            catch (Exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1581,77150,77197);
DynAbs.Tracing.TraceSender.TraceExitCatch(1581,77150,77197);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,77254,77275);

f_1581_77254_77274(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,76543,77286);

int
f_1581_76698_76766(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 76698, 76766);
return 0;
}


bool
f_1581_76892_76933(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.WaitOne();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 76892, 76933);
return return_v;
}


int
f_1581_77093_77120(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
stateInfo)
{
this_param.RaiseStateChangeEvent( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 77093, 77120);
return 0;
}


int
f_1581_77254_77274(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
this_param.SetOpenAsCompleted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 77254, 77274);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,76543,77286);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,76543,77286);
}
		}

private RunspaceConnectionInfo _connectionInfo;

private RunspacePoolAsyncResult _openAsyncResult;

private RunspacePoolAsyncResult _closeAsyncResult;

private Exception _closingReason;

private RunspacePoolAsyncResult _disconnectAsyncResult;

private RunspacePoolAsyncResult _reconnectAsyncResult;

private bool _isDisposed;

private DispatchTable<object> DispatchTable {get; }

private bool _canReconnect;

private string _friendlyName ;

private System.Collections.Concurrent.ConcurrentStack<PowerShell> _runningPowerShells;

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,78562,78675);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,78608,78622);

f_1581_78608_78621(this, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,78638,78664);

f_1581_78638_78663(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,78562,78675);

int
f_1581_78608_78621(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,bool
disposing)
{
this_param.Dispose( disposing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 78608, 78621);
return 0;
}


int
f_1581_78638_78663(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 78638, 78663);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,78562,78675);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,78562,78675);
}
		}

public override void Dispose(bool disposing)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1581,78855,79254);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,79003,79027);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(disposing),1581,79003,79026);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,79041,79243) || true) && (!_isDisposed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,79041,79243);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,79091,79110);

_isDisposed = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,79128,79168);

f_1581_79128_79167(f_1581_79128_79148(), disposing);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,79186,79228);

f_1581_79186_79227(                _applicationPrivateDataReceived);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,79041,79243);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1581,78855,79254);

System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1581_79128_79148()
{
var return_v = DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 79128, 79148);
return return_v;
}


int
f_1581_79128_79167(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,bool
disposing)
{
this_param.Dispose( disposing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 79128, 79167);
return 0;
}


int
f_1581_79186_79227(System.Threading.ManualResetEvent
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 79186, 79227);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,78855,79254);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,78855,79254);
}
		}

static RemoteRunspacePoolInternal()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1581,830,79295);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1581,830,79295);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,830,79295);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1581,830,79295);

System.Management.Automation.PSArgumentNullException
f_1581_3247_3308(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 3247, 3308);
return return_v;
}


System.Globalization.CultureInfo
f_1581_3609_3637()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 3609, 3637);
return return_v;
}


string
f_1581_3590_3638(int
this_param,System.Globalization.CultureInfo
provider)
{
var return_v = this_param.ToString( (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 3590, 3638);
return return_v;
}


System.Globalization.CultureInfo
f_1581_3680_3708()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 3680, 3708);
return return_v;
}


string
f_1581_3661_3709(int
this_param,System.Globalization.CultureInfo
provider)
{
var return_v = this_param.ToString( (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 3661, 3709);
return return_v;
}


int
f_1581_3340_3710(System.Management.Automation.Internal.PSEventId
id,System.Management.Automation.Internal.PSOpcode
opcode,System.Management.Automation.Internal.PSTask
task,System.Management.Automation.Internal.PSKeyword
keyword,params object[]
args)
{
PSEtwLog.LogOperationalVerbose( id, opcode, task, keyword, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 3340, 3710);
return 0;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1581_3745_3774(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.InternalCopy();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 3745, 3774);
return return_v;
}


System.Management.Automation.Remoting.DispatchTable<object>
f_1581_3941_3968()
{
var return_v = new System.Management.Automation.Remoting.DispatchTable<object>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 3941, 3968);
return return_v;
}


System.Collections.Concurrent.ConcurrentStack<System.Management.Automation.PowerShell>
f_1581_4005_4068()
{
var return_v = new System.Collections.Concurrent.ConcurrentStack<System.Management.Automation.PowerShell>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 4005, 4068);
return return_v;
}


bool
f_1581_4090_4116(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 4090, 4116);
return return_v;
}


int
f_1581_4198_4224(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.Runspaces.TypeTable
typeTable)
{
this_param.CreateDSHandler( typeTable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 4198, 4224);
return 0;
}


static int
f_1581_3129_3141_C(int
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1581, 2887, 4236);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1581_5295_5354(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 5295, 5354);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1581_5453_5515(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 5453, 5515);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1581_5613_5674(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 5613, 5674);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1581_5799_5828(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.InternalCopy();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 5799, 5828);
return return_v;
}


int
f_1581_5895_5958(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 5895, 5958);
return 0;
}


System.Globalization.CultureInfo
f_1581_6670_6698()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 6670, 6698);
return return_v;
}


string
f_1581_6651_6699(int
this_param,System.Globalization.CultureInfo
provider)
{
var return_v = this_param.ToString( (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 6651, 6699);
return return_v;
}


System.Globalization.CultureInfo
f_1581_6741_6769()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 6741, 6769);
return return_v;
}


string
f_1581_6722_6770(int
this_param,System.Globalization.CultureInfo
provider)
{
var return_v = this_param.ToString( (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 6722, 6770);
return return_v;
}


int
f_1581_6401_6771(System.Management.Automation.Internal.PSEventId
id,System.Management.Automation.Internal.PSOpcode
opcode,System.Management.Automation.Internal.PSTask
task,System.Management.Automation.Internal.PSKeyword
keyword,params object[]
args)
{
PSEtwLog.LogOperationalVerbose( id, opcode, task, keyword, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 6401, 6771);
return 0;
}


System.Management.Automation.Remoting.DispatchTable<object>
f_1581_6914_6941()
{
var return_v = new System.Management.Automation.Remoting.DispatchTable<object>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 6914, 6941);
return return_v;
}


System.Collections.Concurrent.ConcurrentStack<System.Management.Automation.PowerShell>
f_1581_6978_7041()
{
var return_v = new System.Collections.Concurrent.ConcurrentStack<System.Management.Automation.PowerShell>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 6978, 7041);
return return_v;
}


System.Management.Automation.RunspacePoolStateInfo
f_1581_7141_7204(System.Management.Automation.Runspaces.RunspacePoolState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.RunspacePoolStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 7141, 7204);
return return_v;
}


int
f_1581_7120_7205(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.RunspacePoolStateInfo
newStateInfo)
{
this_param.SetRunspacePoolState( newStateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 7120, 7205);
return 0;
}


int
f_1581_7222_7248(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Management.Automation.Runspaces.TypeTable
typeTable)
{
this_param.CreateDSHandler( typeTable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 7222, 7248);
return 0;
}


static int
f_1581_5203_5204_C(int
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1581, 4972, 7316);
return return_v;
}


System.Threading.ManualResetEvent
f_1581_28849_28876(bool
initialState)
{
var return_v = new System.Threading.ManualResetEvent( initialState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 28849, 28876);
return return_v;
}

}
internal class ConnectCommandInfo
{
public Guid CommandId {get; }

public string Command {get; }

public ConnectCommandInfo(Guid cmdId, string cmdStr)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1581,79989,80126);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,79576,79620);
this.CommandId = Guid.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,79715,79761);
this.Command = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,80066,80084);

CommandId = cmdId;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,80098,80115);

Command = cmdStr;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1581,79989,80126);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,79989,80126);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,79989,80126);
}
		}

static ConnectCommandInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1581,79438,80133);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1581,79438,80133);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,79438,80133);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1581,79438,80133);
}
internal static class RemoteRunspacePoolEnumeration
{
internal static Collection<PSObject> GetRemotePools(WSManConnectionInfo wsmanConnectionInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1581,80773,82913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,80890,80918);

Collection<PSObject> 
result
=default(Collection<PSObject>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,80932,82872);
using(PowerShell 
powerShell = f_1581_80963_80982()
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,81099,81142);

f_1581_81099_81141(                // Enumerate remote runspaces using the Get-WSManInstance cmdlet.
                powerShell, "Get-WSManInstance");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,81235,81283);

f_1581_81235_81282(
                // Add parameters to enumerate Shells (runspace pools).
                powerShell, "ResourceURI", "Shell");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,81301,81344);

f_1581_81301_81343(                powerShell, "Enumerate", true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,81422,81496);

f_1581_81422_81495(
                // Add parameters for server connection.
                powerShell, "ComputerName", f_1581_81462_81494(wsmanConnectionInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,81514,81627);

f_1581_81514_81626(                powerShell, "Authentication", f_1581_81556_81625(f_1581_81581_81624(wsmanConnectionInfo)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,81645,81818) || true) && (f_1581_81649_81679(wsmanConnectionInfo)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,81645,81818);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,81729,81799);

f_1581_81729_81798(                    powerShell, "Credential", f_1581_81767_81797(wsmanConnectionInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,81645,81818);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,81838,82044) || true) && (f_1581_81842_81883(wsmanConnectionInfo)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,81838,82044);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,81933,82025);

f_1581_81933_82024(                    powerShell, "CertificateThumbprint", f_1581_81982_82023(wsmanConnectionInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,81838,82044);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,82064,82224) || true) && (f_1581_82068_82099(wsmanConnectionInfo)!= -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,82064,82224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,82147,82205);

f_1581_82147_82204(                    powerShell, "Port", f_1581_82179_82203(wsmanConnectionInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,82064,82224);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,82244,82381) || true) && (f_1581_82248_82280(wsmanConnectionInfo))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,82244,82381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,82322,82362);

f_1581_82322_82361(                    powerShell, "UseSSL", true);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,82244,82381);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,82401,82707) || true) && (!f_1581_82406_82455(f_1581_82427_82454(wsmanConnectionInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,82401,82707);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,82554,82614);

string 
appName = f_1581_82571_82613(f_1581_82571_82598(wsmanConnectionInfo), '/')
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,82636,82688);

f_1581_82636_82687(                    powerShell, "ApplicationName", appName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,82401,82707);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,82727,82808);

f_1581_82727_82807(
                powerShell, "SessionOption", f_1581_82768_82806(wsmanConnectionInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,82828,82857);

result = f_1581_82837_82856(powerShell);
DynAbs.Tracing.TraceSender.TraceExitUsing(1581,80932,82872);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,82888,82902);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1581,80773,82913);

System.Management.Automation.PowerShell
f_1581_80963_80982()
{
var return_v = PowerShell.Create();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 80963, 80982);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_81099_81141(System.Management.Automation.PowerShell
this_param,string
cmdlet)
{
var return_v = this_param.AddCommand( cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 81099, 81141);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_81235_81282(System.Management.Automation.PowerShell
this_param,string
parameterName,string
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 81235, 81282);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_81301_81343(System.Management.Automation.PowerShell
this_param,string
parameterName,bool
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 81301, 81343);
return return_v;
}


string
f_1581_81462_81494(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 81462, 81494);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_81422_81495(System.Management.Automation.PowerShell
this_param,string
parameterName,string
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 81422, 81495);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1581_81581_81624(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.AuthenticationMechanism;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 81581, 81624);
return return_v;
}


int
f_1581_81556_81625(System.Management.Automation.Runspaces.AuthenticationMechanism
psAuth)
{
var return_v = ConvertPSAuthToWSManAuth( psAuth);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 81556, 81625);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_81514_81626(System.Management.Automation.PowerShell
this_param,string
parameterName,int
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 81514, 81626);
return return_v;
}


System.Management.Automation.PSCredential
f_1581_81649_81679(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.Credential ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 81649, 81679);
return return_v;
}


System.Management.Automation.PSCredential
f_1581_81767_81797(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 81767, 81797);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_81729_81798(System.Management.Automation.PowerShell
this_param,string
parameterName,System.Management.Automation.PSCredential
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 81729, 81798);
return return_v;
}


string
f_1581_81842_81883(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.CertificateThumbprint ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 81842, 81883);
return return_v;
}


string
f_1581_81982_82023(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 81982, 82023);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_81933_82024(System.Management.Automation.PowerShell
this_param,string
parameterName,string
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 81933, 82024);
return return_v;
}


int
f_1581_82068_82099(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.PortSetting ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 82068, 82099);
return return_v;
}


int
f_1581_82179_82203(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.Port;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 82179, 82203);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_82147_82204(System.Management.Automation.PowerShell
this_param,string
parameterName,int
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 82147, 82204);
return return_v;
}


bool
f_1581_82248_82280(System.Management.Automation.Runspaces.WSManConnectionInfo
wsmanConnectionInfo)
{
var return_v = CheckForSSL( wsmanConnectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 82248, 82280);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_82322_82361(System.Management.Automation.PowerShell
this_param,string
parameterName,bool
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 82322, 82361);
return return_v;
}


string
f_1581_82427_82454(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.AppName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 82427, 82454);
return return_v;
}


bool
f_1581_82406_82455(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 82406, 82455);
return return_v;
}


string
f_1581_82571_82598(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.AppName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 82571, 82598);
return return_v;
}


string
f_1581_82571_82613(string
this_param,char
trimChar)
{
var return_v = this_param.TrimStart( trimChar);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 82571, 82613);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_82636_82687(System.Management.Automation.PowerShell
this_param,string
parameterName,string
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 82636, 82687);
return return_v;
}


object
f_1581_82768_82806(System.Management.Automation.Runspaces.WSManConnectionInfo
wsmanConnectionInfo)
{
var return_v = GetSessionOptions( wsmanConnectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 82768, 82806);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_82727_82807(System.Management.Automation.PowerShell
this_param,string
parameterName,object
value)
{
var return_v = this_param.AddParameter( parameterName, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 82727, 82807);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1581_82837_82856(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 82837, 82856);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,80773,82913);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,80773,82913);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static Collection<PSObject> GetRemoteCommands(Guid shellId, WSManConnectionInfo wsmanConnectionInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1581,83365,85789);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,83499,83527);

Collection<PSObject> 
result
=default(Collection<PSObject>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,83541,85748);
using(PowerShell 
powerShell = f_1581_83572_83591()
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,83716,83759);

f_1581_83716_83758(                // Enumerate remote runspace commands using the Get-WSManInstance cmdlet.
                powerShell, "Get-WSManInstance");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,83837,83956);

string 
filterStr = f_1581_83856_83955(f_1581_83870_83898(), "ShellId='{0}'", f_1581_83917_83954(shellId.ToString()))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,83974,84031);

f_1581_83974_84030(                powerShell, "ResourceURI", @"Shell/Command");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,84049,84092);

f_1581_84049_84091(                powerShell, "Enumerate", true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,84110,84157);

f_1581_84110_84156(                powerShell, "Dialect", "Selector");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,84175,84220);

f_1581_84175_84219(                powerShell, "Filter", filterStr);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,84298,84372);

f_1581_84298_84371(
                // Add parameters for server connection.
                powerShell, "ComputerName", f_1581_84338_84370(wsmanConnectionInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,84390,84503);

f_1581_84390_84502(                powerShell, "Authentication", f_1581_84432_84501(f_1581_84457_84500(wsmanConnectionInfo)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,84521,84694) || true) && (f_1581_84525_84555(wsmanConnectionInfo)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,84521,84694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,84605,84675);

f_1581_84605_84674(                    powerShell, "Credential", f_1581_84643_84673(wsmanConnectionInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,84521,84694);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,84714,84920) || true) && (f_1581_84718_84759(wsmanConnectionInfo)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,84714,84920);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,84809,84901);

f_1581_84809_84900(                    powerShell, "CertificateThumbprint", f_1581_84858_84899(wsmanConnectionInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,84714,84920);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,84940,85100) || true) && (f_1581_84944_84975(wsmanConnectionInfo)!= -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,84940,85100);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,85023,85081);

f_1581_85023_85080(                    powerShell, "Port", f_1581_85055_85079(wsmanConnectionInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,84940,85100);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,85120,85257) || true) && (f_1581_85124_85156(wsmanConnectionInfo))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,85120,85257);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,85198,85238);

f_1581_85198_85237(                    powerShell, "UseSSL", true);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,85120,85257);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,85277,85583) || true) && (!f_1581_85282_85331(f_1581_85303_85330(wsmanConnectionInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,85277,85583);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,85430,85490);

string 
appName = f_1581_85447_85489(f_1581_85447_85474(wsmanConnectionInfo), '/')
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,85512,85564);

f_1581_85512_85563(                    powerShell, "ApplicationName", appName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,85277,85583);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,85603,85684);

f_1581_85603_85683(
                powerShell, "SessionOption", f_1581_85644_85682(wsmanConnectionInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,85704,85733);

result = f_1581_85713_85732(powerShell);
DynAbs.Tracing.TraceSender.TraceExitUsing(1581,83541,85748);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,85764,85778);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1581,83365,85789);

System.Management.Automation.PowerShell
f_1581_83572_83591()
{
var return_v = PowerShell.Create();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 83572, 83591);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_83716_83758(System.Management.Automation.PowerShell
this_param,string
cmdlet)
{
var return_v = this_param.AddCommand( cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 83716, 83758);
return return_v;
}


System.Globalization.CultureInfo
f_1581_83870_83898()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 83870, 83898);
return return_v;
}


string
f_1581_83917_83954(string
this_param)
{
var return_v = this_param.ToUpperInvariant();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 83917, 83954);
return return_v;
}


string
f_1581_83856_83955(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 83856, 83955);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_83974_84030(System.Management.Automation.PowerShell
this_param,string
parameterName,string
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 83974, 84030);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_84049_84091(System.Management.Automation.PowerShell
this_param,string
parameterName,bool
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 84049, 84091);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_84110_84156(System.Management.Automation.PowerShell
this_param,string
parameterName,string
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 84110, 84156);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_84175_84219(System.Management.Automation.PowerShell
this_param,string
parameterName,string
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 84175, 84219);
return return_v;
}


string
f_1581_84338_84370(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 84338, 84370);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_84298_84371(System.Management.Automation.PowerShell
this_param,string
parameterName,string
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 84298, 84371);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1581_84457_84500(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.AuthenticationMechanism;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 84457, 84500);
return return_v;
}


int
f_1581_84432_84501(System.Management.Automation.Runspaces.AuthenticationMechanism
psAuth)
{
var return_v = ConvertPSAuthToWSManAuth( psAuth);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 84432, 84501);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_84390_84502(System.Management.Automation.PowerShell
this_param,string
parameterName,int
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 84390, 84502);
return return_v;
}


System.Management.Automation.PSCredential
f_1581_84525_84555(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.Credential ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 84525, 84555);
return return_v;
}


System.Management.Automation.PSCredential
f_1581_84643_84673(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 84643, 84673);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_84605_84674(System.Management.Automation.PowerShell
this_param,string
parameterName,System.Management.Automation.PSCredential
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 84605, 84674);
return return_v;
}


string
f_1581_84718_84759(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.CertificateThumbprint ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 84718, 84759);
return return_v;
}


string
f_1581_84858_84899(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 84858, 84899);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_84809_84900(System.Management.Automation.PowerShell
this_param,string
parameterName,string
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 84809, 84900);
return return_v;
}


int
f_1581_84944_84975(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.PortSetting ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 84944, 84975);
return return_v;
}


int
f_1581_85055_85079(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.Port;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 85055, 85079);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_85023_85080(System.Management.Automation.PowerShell
this_param,string
parameterName,int
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 85023, 85080);
return return_v;
}


bool
f_1581_85124_85156(System.Management.Automation.Runspaces.WSManConnectionInfo
wsmanConnectionInfo)
{
var return_v = CheckForSSL( wsmanConnectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 85124, 85156);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_85198_85237(System.Management.Automation.PowerShell
this_param,string
parameterName,bool
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 85198, 85237);
return return_v;
}


string
f_1581_85303_85330(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.AppName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 85303, 85330);
return return_v;
}


bool
f_1581_85282_85331(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 85282, 85331);
return return_v;
}


string
f_1581_85447_85474(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.AppName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 85447, 85474);
return return_v;
}


string
f_1581_85447_85489(string
this_param,char
trimChar)
{
var return_v = this_param.TrimStart( trimChar);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 85447, 85489);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_85512_85563(System.Management.Automation.PowerShell
this_param,string
parameterName,string
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 85512, 85563);
return return_v;
}


object
f_1581_85644_85682(System.Management.Automation.Runspaces.WSManConnectionInfo
wsmanConnectionInfo)
{
var return_v = GetSessionOptions( wsmanConnectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 85644, 85682);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_85603_85683(System.Management.Automation.PowerShell
this_param,string
parameterName,object
value)
{
var return_v = this_param.AddParameter( parameterName, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 85603, 85683);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1581_85713_85732(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 85713, 85732);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,83365,85789);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,83365,85789);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static object GetSessionOptions(WSManConnectionInfo wsmanConnectionInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1581,86127,88193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,86232,86260);

Collection<PSObject> 
result
=default(Collection<PSObject>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,86274,88138);
using(PowerShell 
powerShell = f_1581_86305_86324()
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,86358,86406);

f_1581_86358_86405(                powerShell, "New-WSManSessionOption");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,86426,86996) || true) && (f_1581_86430_86465(wsmanConnectionInfo)!= ProxyAccessType.None)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,86426,86996);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,86531,86632);

f_1581_86531_86631(                    powerShell, "ProxyAccessType", "Proxy" + f_1581_86584_86630(f_1581_86584_86619(wsmanConnectionInfo)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,86654,86753);

f_1581_86654_86752(                    powerShell, "ProxyAuthentication", f_1581_86701_86751(f_1581_86701_86740(wsmanConnectionInfo)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,86777,86977) || true) && (f_1581_86781_86816(wsmanConnectionInfo)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,86777,86977);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,86874,86954);

f_1581_86874_86953(                        powerShell, "ProxyCredential", f_1581_86917_86952(wsmanConnectionInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,86777,86977);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,86426,86996);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,87346,87508) || true) && (f_1581_87350_87386(wsmanConnectionInfo))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,87346,87508);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,87428,87489);

f_1581_87428_87488(                    powerShell, "SPNPort", f_1581_87463_87487(wsmanConnectionInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,87346,87508);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,87528,87600);

f_1581_87528_87599(
                powerShell, "SkipCACheck", f_1581_87567_87598(wsmanConnectionInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,87618,87690);

f_1581_87618_87689(                powerShell, "SkipCNCheck", f_1581_87657_87688(wsmanConnectionInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,87708,87796);

f_1581_87708_87795(                powerShell, "SkipRevocationCheck", f_1581_87755_87794(wsmanConnectionInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,87816,87898);

f_1581_87816_87897(
                powerShell, "OperationTimeout", f_1581_87860_87896(wsmanConnectionInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,87916,87990);

f_1581_87916_87989(                powerShell, "NoEncryption", f_1581_87956_87988(wsmanConnectionInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,88008,88074);

f_1581_88008_88073(                powerShell, "UseUTF16", f_1581_88044_88072(wsmanConnectionInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,88094,88123);

result = f_1581_88103_88122(powerShell);
DynAbs.Tracing.TraceSender.TraceExitUsing(1581,86274,88138);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,88154,88182);

return f_1581_88161_88181(f_1581_88161_88170(result, 0));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1581,86127,88193);

System.Management.Automation.PowerShell
f_1581_86305_86324()
{
var return_v = PowerShell.Create();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 86305, 86324);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_86358_86405(System.Management.Automation.PowerShell
this_param,string
cmdlet)
{
var return_v = this_param.AddCommand( cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 86358, 86405);
return return_v;
}


System.Management.Automation.Remoting.ProxyAccessType
f_1581_86430_86465(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.ProxyAccessType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 86430, 86465);
return return_v;
}


System.Management.Automation.Remoting.ProxyAccessType
f_1581_86584_86619(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.ProxyAccessType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 86584, 86619);
return return_v;
}


string
f_1581_86584_86630(System.Management.Automation.Remoting.ProxyAccessType
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 86584, 86630);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_86531_86631(System.Management.Automation.PowerShell
this_param,string
parameterName,string
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 86531, 86631);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1581_86701_86740(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.ProxyAuthentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 86701, 86740);
return return_v;
}


string
f_1581_86701_86751(System.Management.Automation.Runspaces.AuthenticationMechanism
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 86701, 86751);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_86654_86752(System.Management.Automation.PowerShell
this_param,string
parameterName,string
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 86654, 86752);
return return_v;
}


System.Management.Automation.PSCredential
f_1581_86781_86816(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.ProxyCredential ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 86781, 86816);
return return_v;
}


System.Management.Automation.PSCredential
f_1581_86917_86952(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.ProxyCredential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 86917, 86952);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_86874_86953(System.Management.Automation.PowerShell
this_param,string
parameterName,System.Management.Automation.PSCredential
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 86874, 86953);
return return_v;
}


bool
f_1581_87350_87386(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.IncludePortInSPN;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 87350, 87386);
return return_v;
}


int
f_1581_87463_87487(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.Port;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 87463, 87487);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_87428_87488(System.Management.Automation.PowerShell
this_param,string
parameterName,int
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 87428, 87488);
return return_v;
}


bool
f_1581_87567_87598(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.SkipCACheck;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 87567, 87598);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_87528_87599(System.Management.Automation.PowerShell
this_param,string
parameterName,bool
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 87528, 87599);
return return_v;
}


bool
f_1581_87657_87688(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.SkipCNCheck;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 87657, 87688);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_87618_87689(System.Management.Automation.PowerShell
this_param,string
parameterName,bool
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 87618, 87689);
return return_v;
}


bool
f_1581_87755_87794(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.SkipRevocationCheck;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 87755, 87794);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_87708_87795(System.Management.Automation.PowerShell
this_param,string
parameterName,bool
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 87708, 87795);
return return_v;
}


int
f_1581_87860_87896(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.OperationTimeout;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 87860, 87896);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_87816_87897(System.Management.Automation.PowerShell
this_param,string
parameterName,int
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 87816, 87897);
return return_v;
}


bool
f_1581_87956_87988(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.NoEncryption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 87956, 87988);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_87916_87989(System.Management.Automation.PowerShell
this_param,string
parameterName,bool
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 87916, 87989);
return return_v;
}


bool
f_1581_88044_88072(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.UseUTF16;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 88044, 88072);
return return_v;
}


System.Management.Automation.PowerShell
f_1581_88008_88073(System.Management.Automation.PowerShell
this_param,string
parameterName,bool
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 88008, 88073);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1581_88103_88122(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 88103, 88122);
return return_v;
}


System.Management.Automation.PSObject
f_1581_88161_88170(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 88161, 88170);
return return_v;
}


object
f_1581_88161_88181(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.BaseObject;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 88161, 88181);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,86127,88193);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,86127,88193);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool CheckForSSL(WSManConnectionInfo wsmanConnectionInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1581,88205,88506);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,88302,88495);

return (!f_1581_88311_88359(f_1581_88332_88358(wsmanConnectionInfo))&&(DynAbs.Tracing.TraceSender.Expression_True(1581, 88310, 88493)&&f_1581_88384_88487(f_1581_88384_88410(wsmanConnectionInfo), WSManConnectionInfo.HttpsScheme, StringComparison.OrdinalIgnoreCase)!= -1));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1581,88205,88506);

string
f_1581_88332_88358(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.Scheme;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 88332, 88358);
return return_v;
}


bool
f_1581_88311_88359(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 88311, 88359);
return return_v;
}


string
f_1581_88384_88410(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.Scheme;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1581, 88384, 88410);
return return_v;
}


int
f_1581_88384_88487(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.IndexOf( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1581, 88384, 88487);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,88205,88506);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,88205,88506);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static int ConvertPSAuthToWSManAuth(AuthenticationMechanism psAuth)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1581,88518,89569);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,88618,88632);

int 
wsmanAuth
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,88648,89525);

switch (psAuth)
            {

case AuthenticationMechanism.Default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,88648,89525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,88755,88771);

wsmanAuth = 0x1;
DynAbs.Tracing.TraceSender.TraceBreak(1581,88793,88799);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,88648,89525);

case AuthenticationMechanism.Basic:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,88648,89525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,88876,88892);

wsmanAuth = 0x8;
DynAbs.Tracing.TraceSender.TraceBreak(1581,88914,88920);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,88648,89525);

case AuthenticationMechanism.Digest:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,88648,89525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,88998,89014);

wsmanAuth = 0x2;
DynAbs.Tracing.TraceSender.TraceBreak(1581,89036,89042);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,88648,89525);

case AuthenticationMechanism.Credssp:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,88648,89525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,89121,89138);

wsmanAuth = 0x80;
DynAbs.Tracing.TraceSender.TraceBreak(1581,89160,89166);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,88648,89525);

case AuthenticationMechanism.Kerberos:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,88648,89525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,89246,89263);

wsmanAuth = 0x10;
DynAbs.Tracing.TraceSender.TraceBreak(1581,89285,89291);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,88648,89525);

case AuthenticationMechanism.Negotiate:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,88648,89525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,89372,89388);

wsmanAuth = 0x4;
DynAbs.Tracing.TraceSender.TraceBreak(1581,89410,89416);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,88648,89525);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1581,88648,89525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,89466,89482);

wsmanAuth = 0x1;
DynAbs.Tracing.TraceSender.TraceBreak(1581,89504,89510);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1581,88648,89525);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1581,89541,89558);

return wsmanAuth;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1581,88518,89569);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1581,88518,89569);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,88518,89569);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static RemoteRunspacePoolEnumeration()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1581,80361,89576);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1581,80361,89576);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1581,80361,89576);
}

}

    }
