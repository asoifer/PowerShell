// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting.Client;
using System.Management.Automation.Runspaces.Internal;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
internal class ClientMethodExecutor
{
private BaseClientTransportManager _transportManager;

private PSHost _clientHost;

private Guid _clientRunspacePoolId;

private Guid _clientPowerShellId;

private RemoteHostCall _remoteHostCall;

internal RemoteHostCall RemoteHostCall
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1569,1330,1404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,1366,1389);

return _remoteHostCall;
DynAbs.Tracing.TraceSender.TraceExitMethod(1569,1330,1404);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1569,1267,1415);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1569,1267,1415);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private ClientMethodExecutor(BaseClientTransportManager transportManager, PSHost clientHost, Guid clientRunspacePoolId, Guid clientPowerShellId, RemoteHostCall remoteHostCall)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1569,1525,2145);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,658,675);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,776,787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,1161,1176);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,1725,1799);

f_1569_1725_1798(transportManager != null, "Expected transportManager != null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,1813,1883);

f_1569_1813_1882(remoteHostCall != null, "Expected remoteHostCall != null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,1897,1934);

_transportManager = transportManager;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,1948,1981);

_remoteHostCall = remoteHostCall;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,1995,2020);

_clientHost = clientHost;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,2034,2079);

_clientRunspacePoolId = clientRunspacePoolId;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,2093,2134);

_clientPowerShellId = clientPowerShellId;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1569,1525,2145);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1569,1525,2145);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1569,1525,2145);
}
		}

internal static void Dispatch(
            BaseClientTransportManager transportManager,
            PSHost clientHost,
            PSDataCollectionStream<ErrorRecord> errorStream,
            ObjectStream methodExecutorStream,
            bool isMethodExecutorStreamEnabled,
            RemoteRunspacePoolInternal runspacePool,
            Guid clientPowerShellId,
            RemoteHostCall remoteHostCall)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1569,2280,5004);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,2720,2912);

ClientMethodExecutor 
methodExecutor =
f_1569_2775_2911(transportManager, clientHost, f_1569_2830_2853(runspacePool), clientPowerShellId, remoteHostCall)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,3072,3218) || true) && (clientPowerShellId == Guid.Empty)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1569,3072,3218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,3142,3178);

f_1569_3142_3177(                methodExecutor, errorStream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,3196,3203);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1569,3072,3218);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,3310,3346);

bool 
hostAllowSetShouldExit = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,3360,3890) || true) && (clientHost != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1569,3360,3890);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,3416,3478);

PSObject 
hostPrivateData = f_1569_3443_3465(clientHost)as PSObject
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,3496,3875) || true) && (hostPrivateData != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1569,3496,3875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,3565,3678);

PSNoteProperty 
allowSetShouldExit = f_1569_3601_3659(f_1569_3601_3627(hostPrivateData), "AllowSetShouldExitFromRemote")as PSNoteProperty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,3700,3856);

hostAllowSetShouldExit = (DynAbs.Tracing.TraceSender.Conditional_F1(1569, 3725, 3789)||(((allowSetShouldExit != null &&(DynAbs.Tracing.TraceSender.Expression_True(1569, 3726, 3788)&&f_1569_3756_3780(allowSetShouldExit)is bool)) &&DynAbs.Tracing.TraceSender.Conditional_F2(1569, 3817, 3847))||DynAbs.Tracing.TraceSender.Conditional_F3(1569, 3850, 3855)))?                        (bool)f_1569_3823_3847(allowSetShouldExit):false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1569,3496,3875);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1569,3360,3890);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,4322,4511) || true) && (f_1569_4326_4356(remoteHostCall)&&(DynAbs.Tracing.TraceSender.Expression_True(1569, 4326, 4389)&&isMethodExecutorStreamEnabled )&&(DynAbs.Tracing.TraceSender.Expression_True(1569, 4326, 4416)&&!hostAllowSetShouldExit))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1569,4322,4511);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,4450,4471);

f_1569_4450_4470(                runspacePool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,4489,4496);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1569,4322,4511);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,4602,4993) || true) && (isMethodExecutorStreamEnabled)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1569,4602,4993);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,4669,4763);

f_1569_4669_4762(methodExecutorStream != null, "method executor stream can't be null when enabled");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,4781,4824);

f_1569_4781_4823(                methodExecutorStream, methodExecutor);
DynAbs.Tracing.TraceSender.TraceExitCondition(1569,4602,4993);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1569,4602,4993);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,4942,4978);

f_1569_4942_4977(                methodExecutor, errorStream);
DynAbs.Tracing.TraceSender.TraceExitCondition(1569,4602,4993);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1569,2280,5004);

System.Guid
f_1569_2830_2853(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1569, 2830, 2853);
return return_v;
}


System.Management.Automation.Remoting.ClientMethodExecutor
f_1569_2775_2911(System.Management.Automation.Remoting.Client.BaseClientTransportManager
transportManager,System.Management.Automation.Host.PSHost
clientHost,System.Guid
clientRunspacePoolId,System.Guid
clientPowerShellId,System.Management.Automation.Remoting.RemoteHostCall
remoteHostCall)
{
var return_v = new System.Management.Automation.Remoting.ClientMethodExecutor( transportManager, clientHost, clientRunspacePoolId, clientPowerShellId, remoteHostCall);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1569, 2775, 2911);
return return_v;
}


int
f_1569_3142_3177(System.Management.Automation.Remoting.ClientMethodExecutor
this_param,System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.ErrorRecord>
errorStream)
{
this_param.Execute( errorStream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1569, 3142, 3177);
return 0;
}


System.Management.Automation.PSObject
f_1569_3443_3465(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.PrivateData ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1569, 3443, 3465);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1569_3601_3627(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1569, 3601, 3627);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1569_3601_3659(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1569, 3601, 3659);
return return_v;
}


object
f_1569_3756_3780(System.Management.Automation.PSNoteProperty
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1569, 3756, 3780);
return return_v;
}


object
f_1569_3823_3847(System.Management.Automation.PSNoteProperty
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1569, 3823, 3847);
return return_v;
}


bool
f_1569_4326_4356(System.Management.Automation.Remoting.RemoteHostCall
this_param)
{
var return_v = this_param.IsSetShouldExit ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1569, 4326, 4356);
return return_v;
}


int
f_1569_4450_4470(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1569, 4450, 4470);
return 0;
}


int
f_1569_4669_4762(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1569, 4669, 4762);
return 0;
}


int
f_1569_4781_4823(System.Management.Automation.Internal.ObjectStream
this_param,System.Management.Automation.Remoting.ClientMethodExecutor
value)
{
var return_v = this_param.Write( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1569, 4781, 4823);
return return_v;
}


int
f_1569_4942_4977(System.Management.Automation.Remoting.ClientMethodExecutor
this_param,System.Management.Automation.Internal.PSDataCollectionStream<System.Management.Automation.ErrorRecord>
errorStream)
{
this_param.Execute( errorStream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1569, 4942, 4977);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1569,2280,5004);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1569,2280,5004);
}
		}

private bool IsRunspacePushed(PSHost host)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1569,5096,5552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,5163,5243);

IHostSupportsInteractiveSession 
host2 = host as IHostSupportsInteractiveSession
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,5257,5293) || true) && (host2 == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1569,5257,5293);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,5278,5291);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1569,5257,5293);
}

            // IsRunspacePushed can throw (not implemented exception)
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,5416,5446);

return f_1569_5423_5445(host2);
            }
            catch (PSNotImplementedException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1569,5475,5512);
DynAbs.Tracing.TraceSender.TraceExitCatch(1569,5475,5512);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,5528,5541);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1569,5096,5552);

bool
f_1569_5423_5445(System.Management.Automation.Host.IHostSupportsInteractiveSession
this_param)
{
var return_v = this_param.IsRunspacePushed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1569, 5423, 5445);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1569,5096,5552);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1569,5096,5552);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void Execute(PSDataCollectionStream<ErrorRecord> errorStream)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1569,5633,6825);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,5728,5772);

Action<ErrorRecord> 
writeErrorAction = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,5897,6767) || true) && (errorStream == null ||(DynAbs.Tracing.TraceSender.Expression_False(1569, 5901, 5953)||f_1569_5924_5953(this, _clientHost)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1569,5897,6767);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,5987,6487);

writeErrorAction = delegate (ErrorRecord errorRecord)
                {
                    try
                    {
                        if (_clientHost.UI != null)
                        {
                            _clientHost.UI.WriteErrorLine(errorRecord.ToString());
                        }
                    }
                    catch (Exception)
                    {
                        // Catch-all OK, 3rd party callout.
                    }
                };
DynAbs.Tracing.TraceSender.TraceExitCondition(1569,5897,6767);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1569,5897,6767);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,6607,6752);

writeErrorAction = delegate (ErrorRecord errorRecord)
                {
                    errorStream.Write(errorRecord);
                };
DynAbs.Tracing.TraceSender.TraceExitCondition(1569,5897,6767);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,6783,6814);

f_1569_6783_6813(
            this, writeErrorAction);
DynAbs.Tracing.TraceSender.TraceExitMethod(1569,5633,6825);

bool
f_1569_5924_5953(System.Management.Automation.Remoting.ClientMethodExecutor
this_param,System.Management.Automation.Host.PSHost
host)
{
var return_v = this_param.IsRunspacePushed( host);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1569, 5924, 5953);
return return_v;
}


int
f_1569_6783_6813(System.Management.Automation.Remoting.ClientMethodExecutor
this_param,System.Action<System.Management.Automation.ErrorRecord>
writeErrorAction)
{
this_param.Execute( writeErrorAction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1569, 6783, 6813);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1569,5633,6825);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1569,5633,6825);
}
		}

internal void Execute(Cmdlet cmdlet)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1569,6906,7010);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,6967,6999);

f_1569_6967_6998(            this, cmdlet.WriteError);
DynAbs.Tracing.TraceSender.TraceExitMethod(1569,6906,7010);

int
f_1569_6967_6998(System.Management.Automation.Remoting.ClientMethodExecutor
this_param,System.Action<System.Management.Automation.ErrorRecord>
writeErrorAction)
{
this_param.Execute( writeErrorAction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1569, 6967, 6998);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1569,6906,7010);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1569,6906,7010);
}
		}

internal void Execute(Action<ErrorRecord> writeErrorAction)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1569,7091,8048);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,7175,8037) || true) && (f_1569_7179_7207(_remoteHostCall))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1569,7175,8037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,7241,7271);

f_1569_7241_7270(this, writeErrorAction);
DynAbs.Tracing.TraceSender.TraceExitCondition(1569,7175,8037);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1569,7175,8037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,7337,7530);

RemotingDataType 
remotingDataType =
(DynAbs.Tracing.TraceSender.Conditional_F1(1569, 7394, 7427)||((                    _clientPowerShellId == Guid.Empty &&DynAbs.Tracing.TraceSender.Conditional_F2(1569, 7430, 7477))||DynAbs.Tracing.TraceSender.Conditional_F3(1569, 7480, 7529)))?RemotingDataType.RemoteRunspaceHostResponseData :RemotingDataType.RemotePowerShellHostResponseData
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,7550,7640);

RemoteHostResponse 
remoteHostResponse = f_1569_7590_7639(_remoteHostCall, _clientHost)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,7658,7900);

RemoteDataObject<PSObject> 
dataToBeSent = f_1569_7700_7899(RemotingDestination.Server, remotingDataType, _clientRunspacePoolId, _clientPowerShellId, f_1569_7871_7898(remoteHostResponse))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,7920,8022);

f_1569_7920_8021(f_1569_7920_7960(_transportManager), dataToBeSent, DataPriorityType.PromptResponse);
DynAbs.Tracing.TraceSender.TraceExitCondition(1569,7175,8037);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1569,7091,8048);

bool
f_1569_7179_7207(System.Management.Automation.Remoting.RemoteHostCall
this_param)
{
var return_v = this_param.IsVoidMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1569, 7179, 7207);
return return_v;
}


int
f_1569_7241_7270(System.Management.Automation.Remoting.ClientMethodExecutor
this_param,System.Action<System.Management.Automation.ErrorRecord>
writeErrorAction)
{
this_param.ExecuteVoid( writeErrorAction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1569, 7241, 7270);
return 0;
}


System.Management.Automation.Remoting.RemoteHostResponse
f_1569_7590_7639(System.Management.Automation.Remoting.RemoteHostCall
this_param,System.Management.Automation.Host.PSHost
clientHost)
{
var return_v = this_param.ExecuteNonVoidMethod( clientHost);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1569, 7590, 7639);
return return_v;
}


System.Management.Automation.PSObject
f_1569_7871_7898(System.Management.Automation.Remoting.RemoteHostResponse
this_param)
{
var return_v = this_param.Encode();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1569, 7871, 7898);
return return_v;
}


System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
f_1569_7700_7899(System.Management.Automation.RemotingDestination
destination,System.Management.Automation.RemotingDataType
dataType,System.Guid
runspacePoolId,System.Guid
powerShellId,System.Management.Automation.PSObject
data)
{
var return_v = RemoteDataObject<PSObject>.CreateFrom( destination, dataType, runspacePoolId, powerShellId, data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1569, 7700, 7899);
return return_v;
}


System.Management.Automation.Remoting.PrioritySendDataCollection
f_1569_7920_7960(System.Management.Automation.Remoting.Client.BaseClientTransportManager
this_param)
{
var return_v = this_param.DataToBeSentCollection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1569, 7920, 7960);
return return_v;
}


int
f_1569_7920_8021(System.Management.Automation.Remoting.PrioritySendDataCollection
this_param,System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
data,System.Management.Automation.Remoting.DataPriorityType
priority)
{
this_param.Add<System.Management.Automation.PSObject>( data, priority);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1569, 7920, 8021);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1569,7091,8048);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1569,7091,8048);
}
		}

internal void ExecuteVoid(Action<ErrorRecord> writeErrorAction)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1569,8134,9041);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,8258,8305);

f_1569_8258_8304(                _remoteHostCall, _clientHost);
            }
            catch (Exception exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1569,8334,9030);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,8494,8628) || true) && (f_1569_8498_8522(exception)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1569,8494,8628);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,8572,8609);

exception = f_1569_8584_8608(exception);
DynAbs.Tracing.TraceSender.TraceExitCondition(1569,8494,8628);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,8719,8967);

ErrorRecord 
errorRecord = f_1569_8745_8966(exception, f_1569_8815_8864(                    PSRemotingErrorId.RemoteHostCallFailed), ErrorCategory.InvalidArgument, f_1569_8939_8965(_remoteHostCall))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1569,8985,9015);

f_1569_8985_9014(writeErrorAction, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCatch(1569,8334,9030);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1569,8134,9041);

int
f_1569_8258_8304(System.Management.Automation.Remoting.RemoteHostCall
this_param,System.Management.Automation.Host.PSHost
clientHost)
{
this_param.ExecuteVoidMethod( clientHost);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1569, 8258, 8304);
return 0;
}


System.Exception
f_1569_8498_8522(System.Exception
this_param)
{
var return_v = this_param.InnerException ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1569, 8498, 8522);
return return_v;
}


System.Exception
f_1569_8584_8608(System.Exception
this_param)
{
var return_v = this_param.InnerException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1569, 8584, 8608);
return return_v;
}


string
f_1569_8815_8864(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1569, 8815, 8864);
return return_v;
}


string
f_1569_8939_8965(System.Management.Automation.Remoting.RemoteHostCall
this_param)
{
var return_v = this_param.MethodName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1569, 8939, 8965);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1569_8745_8966(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1569, 8745, 8966);
return return_v;
}


int
f_1569_8985_9014(System.Action<System.Management.Automation.ErrorRecord>
this_param,System.Management.Automation.ErrorRecord
obj)
{
this_param.Invoke( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1569, 8985, 9014);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1569,8134,9041);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1569,8134,9041);
}
		}

static ClientMethodExecutor()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1569,492,9048);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1569,492,9048);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1569,492,9048);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1569,492,9048);

int
f_1569_1725_1798(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1569, 1725, 1798);
return 0;
}


int
f_1569_1813_1882(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1569, 1813, 1882);
return 0;
}

}
}
