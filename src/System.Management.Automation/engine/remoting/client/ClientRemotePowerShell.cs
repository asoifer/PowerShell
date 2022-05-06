// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Runspaces.Internal
{
internal class ClientRemotePowerShell : IDisposable
{
[TraceSourceAttribute("CRPS", "ClientRemotePowerShell")]
        private static PSTraceSource s_tracer ;

internal ClientRemotePowerShell(PowerShell shell, RemoteRunspacePoolInternal runspacePool)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1570,1201,1693);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,38703,38714);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,38752,38763);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,38807,38827);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,38859,38864);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,38936,38943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,38985,38993);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,39031,39043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,39071,39083);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,39141,39161);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,39187,39205);
this.stopCalled = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,39233,39242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,39290,39302);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,39609,39628);
this.initialized = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,39982,40034);
this._stateInfoQueue = f_1570_40000_40034();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,40079,40132);
this._connectionRetryStatus = PSConnectionRetryStatus.None;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,1316,1335);

this.shell = shell;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,1349,1396);

clientRunspacePoolId = f_1570_1372_1395(runspacePool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,1410,1443);

this.runspacePool = runspacePool;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,1626,1682);

computerName = f_1570_1641_1681(f_1570_1641_1668(runspacePool));
DynAbs.Tracing.TraceSender.TraceExitConstructor(1570,1201,1693);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,1201,1693);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,1201,1693);
}
		}

internal Guid InstanceId
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,1968,2048);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,2004,2033);

return f_1570_2011_2032(f_1570_2011_2021());
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,1968,2048);

System.Management.Automation.PowerShell
f_1570_2011_2021()
{
var return_v = PowerShell;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 2011, 2021);
return return_v;
}


System.Guid
f_1570_2011_2032(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 2011, 2032);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,1919,2059);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,1919,2059);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal PowerShell PowerShell
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,2242,2306);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,2278,2291);

return shell;
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,2242,2306);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,2187,2317);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,2187,2317);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal void SetStateInfo(PSInvocationStateInfo stateInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,2512,2640);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,2596,2629);

f_1570_2596_2628(            shell, stateInfo);
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,2512,2640);

int
f_1570_2596_2628(System.Management.Automation.PowerShell
this_param,System.Management.Automation.PSInvocationStateInfo
stateInfo)
{
this_param.SetStateChanged( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 2596, 2628);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,2512,2640);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,2512,2640);
}
		}

internal bool NoInput
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,2814,2880);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,2850,2865);

return noInput;
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,2814,2880);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,2768,2891);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,2768,2891);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal ObjectStreamBase InputStream
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,3067,3137);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,3103,3122);

return inputstream;
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,3067,3137);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,3005,3501);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,3005,3501);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,3153,3490);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,3189,3209);

inputstream = value;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,3229,3475) || true) && (inputstream != null &&(DynAbs.Tracing.TraceSender.Expression_True(1570, 3233, 3301)&&(f_1570_3257_3275(inputstream)||(DynAbs.Tracing.TraceSender.Expression_False(1570, 3257, 3300)||f_1570_3279_3296(inputstream)> 0))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,3229,3475);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,3343,3359);

noInput = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,3229,3475);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,3229,3475);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,3441,3456);

noInput = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,3229,3475);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,3153,3490);

bool
f_1570_3257_3275(System.Management.Automation.Internal.ObjectStreamBase
this_param)
{
var return_v = this_param.IsOpen ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 3257, 3275);
return return_v;
}


int
f_1570_3279_3296(System.Management.Automation.Internal.ObjectStreamBase
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 3279, 3296);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,3005,3501);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,3005,3501);
}
		}}

internal ObjectStreamBase OutputStream
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,3679,3750);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,3715,3735);

return outputstream;
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,3679,3750);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,3616,3849);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,3616,3849);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,3766,3838);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,3802,3823);

outputstream = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,3766,3838);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,3616,3849);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,3616,3849);
}
		}}

internal ClientPowerShellDataStructureHandler DataStructureHandler
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,4043,4122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,4079,4107);

return dataStructureHandler;
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,4043,4122);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,3952,4133);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,3952,4133);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal PSInvocationSettings Settings
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,4346,4413);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,4382,4398);

return settings;
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,4346,4413);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,4283,4424);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,4283,4424);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal void UnblockCollections()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,4634,4911);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,4693,4723);

f_1570_4693_4722(            shell);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,4739,4760);

f_1570_4739_4759(
            outputstream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,4774,4794);

f_1570_4774_4793(            errorstream);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,4808,4900) || true) && (inputstream != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,4808,4900);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,4865,4885);

f_1570_4865_4884(                inputstream);
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,4808,4900);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,4634,4911);

int
f_1570_4693_4722(System.Management.Automation.PowerShell
this_param)
{
this_param.ClearRemotePowerShell();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 4693, 4722);
return 0;
}


int
f_1570_4739_4759(System.Management.Automation.Internal.ObjectStreamBase
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 4739, 4759);
return 0;
}


int
f_1570_4774_4793(System.Management.Automation.Internal.ObjectStreamBase
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 4774, 4793);
return 0;
}


int
f_1570_4865_4884(System.Management.Automation.Internal.ObjectStreamBase
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 4865, 4884);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,4634,4911);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,4634,4911);
}
		}

internal void StopAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,5169,6351);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,5355,5416);

PSConnectionRetryStatus 
retryStatus = _connectionRetryStatus
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,5430,5962) || true) && ((retryStatus == PSConnectionRetryStatus.NetworkFailureDetected ||(DynAbs.Tracing.TraceSender.Expression_False(1570, 5435, 5579)||                 retryStatus == PSConnectionRetryStatus.ConnectionRetryAttempt)) &&(DynAbs.Tracing.TraceSender.Expression_True(1570, 5434, 5674)&&f_1570_5601_5646(f_1570_5601_5640(this.runspacePool))== RunspacePoolState.Opened))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,5430,5962);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,5876,5922);

f_1570_5876_5921(                // While in robust connection retry mode, this call forces robust connections
                // to abort retries and go directly to auto-disconnect.
                this.runspacePool, null, null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,5940,5947);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,5430,5962);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,6259,6277);

stopCalled = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,6291,6340);

f_1570_6291_6339(            dataStructureHandler);
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,5169,6351);

System.Management.Automation.RunspacePoolStateInfo
f_1570_5601_5640(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.RunspacePoolStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 5601, 5640);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1570_5601_5646(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 5601, 5646);
return return_v;
}


System.IAsyncResult
f_1570_5876_5921(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.AsyncCallback
callback,object
state)
{
var return_v = this_param.BeginDisconnect( callback, state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 5876, 5921);
return return_v;
}


int
f_1570_6291_6339(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param)
{
this_param.SendStopPowerShellMessage();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 6291, 6339);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,5169,6351);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,5169,6351);
}
		}

internal void SendInput()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,6410,6520);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,6460,6509);

f_1570_6460_6508(            dataStructureHandler, this.inputstream);
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,6410,6520);

int
f_1570_6460_6508(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param,System.Management.Automation.Internal.ObjectStreamBase
inputstream)
{
this_param.SendInput( inputstream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 6460, 6508);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,6410,6520);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,6410,6520);
}
		}

        /// <summary>
        /// This event is raised, when a host call is for a remote pipeline
        /// which this remote powershell wraps.
        /// </summary>
        internal event EventHandler<RemoteDataEventArgs<RemoteHostCall>> 
HostCallReceived
;

internal void Initialize(
            ObjectStreamBase inputstream, ObjectStreamBase outputstream,
                 ObjectStreamBase errorstream, PSInformationalBuffers informationalBuffers,
                        PSInvocationSettings settings)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,7460,10072);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,7733,7752);

initialized = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,7766,7815);

this.informationalBuffers = informationalBuffers;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,7829,7855);

InputStream = inputstream;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,7869,7900);

this.errorstream = errorstream;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,7914,7947);

this.outputstream = outputstream;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,7961,7986);

this.settings = settings;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,8002,8218) || true) && (settings == null ||(DynAbs.Tracing.TraceSender.Expression_False(1570, 8006, 8047)||f_1570_8026_8039(settings)== null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,8002,8218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,8081,8111);

hostToUse = f_1570_8093_8110(runspacePool);
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,8002,8218);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,8002,8218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,8177,8203);

hostToUse = f_1570_8189_8202(settings);
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,8002,8218);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,8234,8334);

dataStructureHandler = f_1570_8257_8333(f_1570_8257_8290(runspacePool), this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,8418,8583);

dataStructureHandler.InvocationStateInfoReceived +=
                new EventHandler<RemoteDataEventArgs<PSInvocationStateInfo>>(HandleInvocationStateInfoReceived);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,8597,8704);

dataStructureHandler.OutputReceived += new EventHandler<RemoteDataEventArgs<object>>(HandleOutputReceived);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,8718,8828);

dataStructureHandler.ErrorReceived += new EventHandler<RemoteDataEventArgs<ErrorRecord>>(HandleErrorReceived);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,8842,9008);

dataStructureHandler.InformationalMessageReceived +=
                new EventHandler<RemoteDataEventArgs<InformationalMessage>>(HandleInformationalMessageReceived);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,9022,9158);

dataStructureHandler.HostCallReceived +=
                new EventHandler<RemoteDataEventArgs<RemoteHostCall>>(HandleHostCallReceived);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,9172,9338);

dataStructureHandler.ClosedNotificationFromRunspacePool +=
                new EventHandler<RemoteDataEventArgs<Exception>>(HandleCloseNotificationFromRunspacePool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,9352,9519);

dataStructureHandler.BrokenNotificationFromRunspacePool +=
                new EventHandler<RemoteDataEventArgs<Exception>>(HandleBrokenNotificationFromRunspacePool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,9533,9647);

dataStructureHandler.ConnectCompleted += new EventHandler<RemoteDataEventArgs<Exception>>(HandleConnectCompleted);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,9661,9777);

dataStructureHandler.ReconnectCompleted += new EventHandler<RemoteDataEventArgs<Exception>>(HandleConnectCompleted);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,9791,9941);

dataStructureHandler.RobustConnectionNotification +=
                new EventHandler<ConnectionStatusEventArgs>(HandleRobustConnectionNotification);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,9955,10061);

dataStructureHandler.CloseCompleted +=
                new EventHandler<EventArgs>(HandleCloseCompleted);
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,7460,10072);

System.Management.Automation.Host.PSHost
f_1570_8026_8039(System.Management.Automation.PSInvocationSettings
this_param)
{
var return_v = this_param.Host ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 8026, 8039);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1570_8093_8110(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 8093, 8110);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1570_8189_8202(System.Management.Automation.PSInvocationSettings
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 8189, 8202);
return return_v;
}


System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
f_1570_8257_8290(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.DataStructureHandler;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 8257, 8290);
return return_v;
}


System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
f_1570_8257_8333(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
this_param,System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
shell)
{
var return_v = this_param.CreatePowerShellDataStructureHandler( shell);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 8257, 8333);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,7460,10072);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,7460,10072);
}
		}

internal void Clear()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,10195,10272);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,10241,10261);

initialized = false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,10195,10272);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,10195,10272);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,10195,10272);
}
		}

internal bool Initialized
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,10449,10519);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,10485,10504);

return initialized;
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,10449,10519);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,10399,10530);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,10399,10530);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal static void ExitHandler(object sender, RemoteDataEventArgs<RemoteHostCall> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1570,10678,11195);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,10797,10838);

RemoteHostCall 
hostcall = f_1570_10823_10837(eventArgs)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,10854,10951) || true) && (f_1570_10858_10895(hostcall))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,10854,10951);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,10929,10936);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,10854,10951);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,11052,11125);

ClientRemotePowerShell 
remotePowerShell = (ClientRemotePowerShell)sender
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,11141,11184);

f_1570_11141_11183(
            remotePowerShell, hostcall);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1570,10678,11195);

System.Management.Automation.Remoting.RemoteHostCall
f_1570_10823_10837(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 10823, 10837);
return return_v;
}


bool
f_1570_10858_10895(System.Management.Automation.Remoting.RemoteHostCall
this_param)
{
var return_v = this_param.IsSetShouldExitOrPopRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 10858, 10895);
return return_v;
}


int
f_1570_11141_11183(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param,System.Management.Automation.Remoting.RemoteHostCall
hostcall)
{
this_param.ExecuteHostCall( hostcall);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 11141, 11183);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,10678,11195);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,10678,11195);
}
		}

internal void ConnectAsync(ConnectCommandInfo connectCmdInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,11987,12837);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,12073,12826) || true) && (connectCmdInfo == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,12073,12826);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,12215,12258);

f_1570_12215_12257(                // Attempt to do a reconnect with the current PSRP client state.
                this.dataStructureHandler);
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,12073,12826);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,12073,12826);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,12412,12509);

f_1570_12412_12508(f_1570_12423_12446(this.shell)!= null, "Invalid runspace pool for this powershell object.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,12527,12697);

f_1570_12527_12696(f_1570_12527_12577(f_1570_12527_12550(this.shell)), f_1570_12653_12668(this), this.dataStructureHandler);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,12770,12811);

f_1570_12770_12810(
                // Now do the asynchronous connect.
                this.dataStructureHandler);
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,12073,12826);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,11987,12837);

int
f_1570_12215_12257(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param)
{
this_param.ReconnectAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 12215, 12257);
return 0;
}


System.Management.Automation.Runspaces.RunspacePool
f_1570_12423_12446(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.RunspacePool ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 12423, 12446);
return return_v;
}


int
f_1570_12412_12508(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 12412, 12508);
return 0;
}


System.Management.Automation.Runspaces.RunspacePool
f_1570_12527_12550(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 12527, 12550);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1570_12527_12577(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 12527, 12577);
return return_v;
}


System.Guid
f_1570_12653_12668(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 12653, 12668);
return return_v;
}


int
f_1570_12527_12696(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param,System.Guid
psShellInstanceId,System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
psDSHandler)
{
this_param.AddRemotePowerShellDSHandler( psShellInstanceId, psDSHandler);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 12527, 12696);
return 0;
}


int
f_1570_12770_12810(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param)
{
this_param.ConnectAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 12770, 12810);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,11987,12837);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,11987,12837);
}
		}

        /// <summary>
        /// This event is fired when this PowerShell object receives a robust connection
        /// notification from the transport.
        /// </summary>
        internal event EventHandler<PSConnectionRetryStatusEventArgs> 
RCConnectionNotification
;

internal PSConnectionRetryStatus ConnectionRetryStatus
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,13310,13348);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,13316,13346);

return _connectionRetryStatus;
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,13310,13348);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,13231,13359);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,13231,13359);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private void HandleErrorReceived(object sender, RemoteDataEventArgs<ErrorRecord> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,13822,14111);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,13938,14100);
using(f_1570_13945_13974(s_tracer))            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,14008,14033);

f_1570_14008_14032(                shell, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,14051,14085);

f_1570_14051_14084(                errorstream, f_1570_14069_14083(eventArgs));
DynAbs.Tracing.TraceSender.TraceExitUsing(1570,13938,14100);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,13822,14111);

System.IDisposable
f_1570_13945_13974(System.Management.Automation.PSTraceSource
this_param)
{
var return_v = this_param.TraceEventHandlers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 13945, 13974);
return return_v;
}


int
f_1570_14008_14032(System.Management.Automation.PowerShell
this_param,bool
status)
{
this_param.SetHadErrors( status);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 14008, 14032);
return 0;
}


System.Management.Automation.ErrorRecord
f_1570_14069_14083(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.ErrorRecord>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 14069, 14083);
return return_v;
}


int
f_1570_14051_14084(System.Management.Automation.Internal.ObjectStreamBase
this_param,System.Management.Automation.ErrorRecord
value)
{
var return_v = this_param.Write( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 14051, 14084);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,13822,14111);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,13822,14111);
}
		}

private void HandleOutputReceived(object sender, RemoteDataEventArgs<object> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,14491,15024);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,14603,15013);
using(f_1570_14610_14639(s_tracer))            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,14673,14702);

object 
data = f_1570_14687_14701(eventArgs)
;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,14766,14791);

f_1570_14766_14790(                    outputstream, data);
                }
                catch (PSInvalidCastException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1570,14828,14998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,14901,14979);

f_1570_14901_14978(                    shell, f_1570_14923_14977(PSInvocationState.Failed, e));
DynAbs.Tracing.TraceSender.TraceExitCatch(1570,14828,14998);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(1570,14603,15013);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,14491,15024);

System.IDisposable
f_1570_14610_14639(System.Management.Automation.PSTraceSource
this_param)
{
var return_v = this_param.TraceEventHandlers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 14610, 14639);
return return_v;
}


object
f_1570_14687_14701(System.Management.Automation.RemoteDataEventArgs<object>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 14687, 14701);
return return_v;
}


int
f_1570_14766_14790(System.Management.Automation.Internal.ObjectStreamBase
this_param,object
value)
{
var return_v = this_param.Write( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 14766, 14790);
return return_v;
}


System.Management.Automation.PSInvocationStateInfo
f_1570_14923_14977(System.Management.Automation.PSInvocationState
state,System.Management.Automation.PSInvalidCastException
reason)
{
var return_v = new System.Management.Automation.PSInvocationStateInfo( state, (System.Exception)reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 14923, 14977);
return return_v;
}


int
f_1570_14901_14978(System.Management.Automation.PowerShell
this_param,System.Management.Automation.PSInvocationStateInfo
stateInfo)
{
this_param.SetStateChanged( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 14901, 14978);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,14491,15024);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,14491,15024);
}
		}

private void HandleInvocationStateInfoReceived(object sender,
            RemoteDataEventArgs<PSInvocationStateInfo> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,15379,18651);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,15532,18640);
using(f_1570_15539_15568(s_tracer))            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,15602,15651);

PSInvocationStateInfo 
stateInfo = f_1570_15636_15650(eventArgs)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,15769,15993);

f_1570_15769_15992(!(f_1570_15782_15797(stateInfo)== PSInvocationState.Running ||(DynAbs.Tracing.TraceSender.Expression_False(1570, 15782, 15903)||f_1570_15858_15873(stateInfo)== PSInvocationState.Stopping)), "Transient states should not be received from the server");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,16013,18625) || true) && (f_1570_16017_16032(stateInfo)== PSInvocationState.Disconnected)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,16013,18625);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,16108,16132);

f_1570_16108_16131(this, stateInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,16013,18625);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,16013,18625);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,16174,18625) || true) && (f_1570_16178_16193(stateInfo)== PSInvocationState.Stopped ||(DynAbs.Tracing.TraceSender.Expression_False(1570, 16178, 16295)||f_1570_16252_16267(stateInfo)== PSInvocationState.Failed )||(DynAbs.Tracing.TraceSender.Expression_False(1570, 16178, 16371)||f_1570_16325_16340(stateInfo)== PSInvocationState.Completed))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,16174,18625);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,16651,16681);

bool 
terminateSession = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,16703,17200) || true) && (f_1570_16707_16722(stateInfo)== PSInvocationState.Failed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,16703,17200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,16800,16907);

PSRemotingTransportException 
remotingTransportException = f_1570_16858_16874(stateInfo)as PSRemotingTransportException
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,16933,17177);

terminateSession = (remotingTransportException != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1570, 16952, 17176)&&                                           (f_1570_17037_17073(remotingTransportException)== System.Management.Automation.Remoting.Client.WSManNativeApi.ERROR_WSMAN_TARGETSESSION_DOESNOTEXIST));
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,16703,17200);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,17419,17440);

f_1570_17419_17439(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,17464,18381) || true) && (stopCalled ||(DynAbs.Tracing.TraceSender.Expression_False(1570, 17468, 17498)||terminateSession))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,17464,18381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,17600,17619);

stopCalled = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,17869,17994);

f_1570_17869_17993(
                        // if a Stop method has been called, then powershell
                        // would have already raised a Stopping event, after
                        // which only a Stopped should be raised
                        _stateInfoQueue, f_1570_17893_17992(PSInvocationState.Stopped, f_1570_17975_17991(stateInfo)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,18176,18225);

f_1570_18176_18224(this, f_1570_18207_18223(stateInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,17464,18381);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,17464,18381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,18323,18358);

f_1570_18323_18357(                        _stateInfoQueue, stateInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,17464,18381);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,18558,18606);

f_1570_18558_18605(                    // calling close async only after making sure all the internal members are prepared
                    // to handle close complete.
                    dataStructureHandler, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,16174,18625);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,16013,18625);
}
DynAbs.Tracing.TraceSender.TraceExitUsing(1570,15532,18640);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,15379,18651);

System.IDisposable
f_1570_15539_15568(System.Management.Automation.PSTraceSource
this_param)
{
var return_v = this_param.TraceEventHandlers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 15539, 15568);
return return_v;
}


System.Management.Automation.PSInvocationStateInfo
f_1570_15636_15650(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.PSInvocationStateInfo>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 15636, 15650);
return return_v;
}


System.Management.Automation.PSInvocationState
f_1570_15782_15797(System.Management.Automation.PSInvocationStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 15782, 15797);
return return_v;
}


System.Management.Automation.PSInvocationState
f_1570_15858_15873(System.Management.Automation.PSInvocationStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 15858, 15873);
return return_v;
}


int
f_1570_15769_15992(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 15769, 15992);
return 0;
}


System.Management.Automation.PSInvocationState
f_1570_16017_16032(System.Management.Automation.PSInvocationStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 16017, 16032);
return return_v;
}


int
f_1570_16108_16131(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param,System.Management.Automation.PSInvocationStateInfo
stateInfo)
{
this_param.SetStateInfo( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 16108, 16131);
return 0;
}


System.Management.Automation.PSInvocationState
f_1570_16178_16193(System.Management.Automation.PSInvocationStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 16178, 16193);
return return_v;
}


System.Management.Automation.PSInvocationState
f_1570_16252_16267(System.Management.Automation.PSInvocationStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 16252, 16267);
return return_v;
}


System.Management.Automation.PSInvocationState
f_1570_16325_16340(System.Management.Automation.PSInvocationStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 16325, 16340);
return return_v;
}


System.Management.Automation.PSInvocationState
f_1570_16707_16722(System.Management.Automation.PSInvocationStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 16707, 16722);
return return_v;
}


System.Exception
f_1570_16858_16874(System.Management.Automation.PSInvocationStateInfo
this_param)
{
var return_v = this_param.Reason ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 16858, 16874);
return return_v;
}


int
f_1570_17037_17073(System.Management.Automation.Remoting.PSRemotingTransportException
this_param)
{
var return_v = this_param.ErrorCode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 17037, 17073);
return return_v;
}


int
f_1570_17419_17439(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param)
{
this_param.UnblockCollections();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 17419, 17439);
return 0;
}


System.Exception
f_1570_17975_17991(System.Management.Automation.PSInvocationStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 17975, 17991);
return return_v;
}


System.Management.Automation.PSInvocationStateInfo
f_1570_17893_17992(System.Management.Automation.PSInvocationState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.PSInvocationStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 17893, 17992);
return return_v;
}


int
f_1570_17869_17993(System.Collections.Generic.Queue<System.Management.Automation.PSInvocationStateInfo>
this_param,System.Management.Automation.PSInvocationStateInfo
item)
{
this_param.Enqueue( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 17869, 17993);
return 0;
}


System.Exception
f_1570_18207_18223(System.Management.Automation.PSInvocationStateInfo
this_param)
{
var return_v = this_param.Reason;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 18207, 18223);
return return_v;
}


int
f_1570_18176_18224(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param,System.Exception
ex)
{
this_param.CheckAndCloseRunspaceAfterStop( ex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 18176, 18224);
return 0;
}


int
f_1570_18323_18357(System.Collections.Generic.Queue<System.Management.Automation.PSInvocationStateInfo>
this_param,System.Management.Automation.PSInvocationStateInfo
item)
{
this_param.Enqueue( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 18323, 18357);
return 0;
}


int
f_1570_18558_18605(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param,System.Exception
sessionCloseReason)
{
this_param.CloseConnectionAsync( sessionCloseReason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 18558, 18605);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,15379,18651);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,15379,18651);
}
		}

private void CheckAndCloseRunspaceAfterStop(Exception ex)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,18950,20742);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,19032,19117);

PSRemotingTransportException 
transportException = ex as PSRemotingTransportException
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,19131,20731) || true) && (transportException != null &&(DynAbs.Tracing.TraceSender.Expression_True(1570, 19135, 19613)&&                (f_1570_19183_19211(transportException)== System.Management.Automation.Remoting.Client.WSManNativeApi.ERROR_WSMAN_SENDDATA_CANNOT_CONNECT ||(DynAbs.Tracing.TraceSender.Expression_False(1570, 19183, 19460)||f_1570_19332_19360(transportException)== System.Management.Automation.Remoting.Client.WSManNativeApi.ERROR_WSMAN_SENDDATA_CANNOT_COMPLETE )||(DynAbs.Tracing.TraceSender.Expression_False(1570, 19183, 19612)||f_1570_19482_19510(transportException)== System.Management.Automation.Remoting.Client.WSManNativeApi.ERROR_WSMAN_TARGETSESSION_DOESNOTEXIST))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,19131,20731);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,19647,19695);

object 
rsObject = f_1570_19665_19694(shell)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,19713,20716) || true) && (rsObject is Runspace)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,19713,20716);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,19779,19818);

Runspace 
runspace = (Runspace)rsObject
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,19840,20168) || true) && (f_1570_19844_19876(f_1570_19844_19870(runspace))== RunspaceState.Opened)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,19840,20168);
                        try
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,20010,20027);

f_1570_20010_20026(                            runspace);
                        }
                        catch (PSRemotingTransportException)
                        { DynAbs.Tracing.TraceSender.TraceEnterCatch(1570,20080,20145);
DynAbs.Tracing.TraceSender.TraceExitCatch(1570,20080,20145);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,19840,20168);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,19713,20716);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,19713,20716);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,20210,20716) || true) && (rsObject is RunspacePool)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,20210,20716);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,20280,20331);

RunspacePool 
runspacePool = (RunspacePool)rsObject
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,20353,20697) || true) && (f_1570_20357_20397(f_1570_20357_20391(runspacePool))== RunspacePoolState.Opened)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,20353,20697);
                        try
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,20535,20556);

f_1570_20535_20555(                            runspacePool);
                        }
                        catch (PSRemotingTransportException)
                        { DynAbs.Tracing.TraceSender.TraceEnterCatch(1570,20609,20674);
DynAbs.Tracing.TraceSender.TraceExitCatch(1570,20609,20674);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,20353,20697);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,20210,20716);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,19713,20716);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,19131,20731);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,18950,20742);

int
f_1570_19183_19211(System.Management.Automation.Remoting.PSRemotingTransportException
this_param)
{
var return_v = this_param.ErrorCode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 19183, 19211);
return return_v;
}


int
f_1570_19332_19360(System.Management.Automation.Remoting.PSRemotingTransportException
this_param)
{
var return_v = this_param.ErrorCode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 19332, 19360);
return return_v;
}


int
f_1570_19482_19510(System.Management.Automation.Remoting.PSRemotingTransportException
this_param)
{
var return_v = this_param.ErrorCode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 19482, 19510);
return return_v;
}


object
f_1570_19665_19694(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.GetRunspaceConnection();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 19665, 19694);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1570_19844_19870(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 19844, 19870);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1570_19844_19876(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 19844, 19876);
return return_v;
}


int
f_1570_20010_20026(System.Management.Automation.Runspaces.Runspace
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 20010, 20026);
return 0;
}


System.Management.Automation.RunspacePoolStateInfo
f_1570_20357_20391(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RunspacePoolStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 20357, 20391);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePoolState
f_1570_20357_20397(System.Management.Automation.RunspacePoolStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 20357, 20397);
return return_v;
}


int
f_1570_20535_20555(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 20535, 20555);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,18950,20742);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,18950,20742);
}
		}

private void HandleInformationalMessageReceived(object sender,
            RemoteDataEventArgs<InformationalMessage> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,21055,22907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,21208,22896);
using(f_1570_21215_21244(s_tracer))            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,21278,21328);

InformationalMessage 
infoMessage = f_1570_21313_21327(eventArgs)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,21348,22881);

switch (f_1570_21356_21376(infoMessage))
                {

case RemotingDataType.PowerShellDebug:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,21348,22881);
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,21513,21577);

f_1570_21513_21576(                            informationalBuffers, f_1570_21556_21575(infoMessage));
                        }
DynAbs.Tracing.TraceSender.TraceBreak(1570,21632,21638);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,21348,22881);

case RemotingDataType.PowerShellVerbose:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,21348,22881);
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,21759,21827);

f_1570_21759_21826(                            informationalBuffers, f_1570_21806_21825(infoMessage));
                        }
DynAbs.Tracing.TraceSender.TraceBreak(1570,21882,21888);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,21348,22881);

case RemotingDataType.PowerShellWarning:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,21348,22881);
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,22009,22077);

f_1570_22009_22076(                            informationalBuffers, f_1570_22056_22075(infoMessage));
                        }
DynAbs.Tracing.TraceSender.TraceBreak(1570,22132,22138);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,21348,22881);

case RemotingDataType.PowerShellProgress:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,21348,22881);
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,22260,22460);

ProgressRecord 
progress = (ProgressRecord)f_1570_22302_22459(f_1570_22331_22350(infoMessage), typeof(ProgressRecord), f_1570_22409_22458())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,22490,22533);

f_1570_22490_22532(                            informationalBuffers, progress);
                        }
DynAbs.Tracing.TraceSender.TraceBreak(1570,22588,22594);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,21348,22881);

case RemotingDataType.PowerShellInformationStream:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,21348,22881);
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,22725,22801);

f_1570_22725_22800(                            informationalBuffers, f_1570_22780_22799(infoMessage));
                        }
DynAbs.Tracing.TraceSender.TraceBreak(1570,22856,22862);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,21348,22881);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(1570,21208,22896);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,21055,22907);

System.IDisposable
f_1570_21215_21244(System.Management.Automation.PSTraceSource
this_param)
{
var return_v = this_param.TraceEventHandlers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 21215, 21244);
return return_v;
}


System.Management.Automation.Internal.InformationalMessage
f_1570_21313_21327(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 21313, 21327);
return return_v;
}


System.Management.Automation.RemotingDataType
f_1570_21356_21376(System.Management.Automation.Internal.InformationalMessage
this_param)
{
var return_v = this_param.DataType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 21356, 21376);
return return_v;
}


object
f_1570_21556_21575(System.Management.Automation.Internal.InformationalMessage
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 21556, 21575);
return return_v;
}


int
f_1570_21513_21576(System.Management.Automation.PSInformationalBuffers
this_param,object
item)
{
this_param.AddDebug( (System.Management.Automation.DebugRecord)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 21513, 21576);
return 0;
}


object
f_1570_21806_21825(System.Management.Automation.Internal.InformationalMessage
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 21806, 21825);
return return_v;
}


int
f_1570_21759_21826(System.Management.Automation.PSInformationalBuffers
this_param,object
item)
{
this_param.AddVerbose( (System.Management.Automation.VerboseRecord)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 21759, 21826);
return 0;
}


object
f_1570_22056_22075(System.Management.Automation.Internal.InformationalMessage
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 22056, 22075);
return return_v;
}


int
f_1570_22009_22076(System.Management.Automation.PSInformationalBuffers
this_param,object
item)
{
this_param.AddWarning( (System.Management.Automation.WarningRecord)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 22009, 22076);
return 0;
}


object
f_1570_22331_22350(System.Management.Automation.Internal.InformationalMessage
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 22331, 22350);
return return_v;
}


System.Globalization.CultureInfo
f_1570_22409_22458()
{
var return_v = System.Globalization.CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 22409, 22458);
return return_v;
}


object
f_1570_22302_22459(object
valueToConvert,System.Type
resultType,System.Globalization.CultureInfo
formatProvider)
{
var return_v = LanguagePrimitives.ConvertTo( valueToConvert, resultType, (System.IFormatProvider)formatProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 22302, 22459);
return return_v;
}


int
f_1570_22490_22532(System.Management.Automation.PSInformationalBuffers
this_param,System.Management.Automation.ProgressRecord
item)
{
this_param.AddProgress( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 22490, 22532);
return 0;
}


object
f_1570_22780_22799(System.Management.Automation.Internal.InformationalMessage
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 22780, 22799);
return return_v;
}


int
f_1570_22725_22800(System.Management.Automation.PSInformationalBuffers
this_param,object
item)
{
this_param.AddInformation( (System.Management.Automation.InformationRecord)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 22725, 22800);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,21055,22907);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,21055,22907);
}
		}

private void HandleHostCallReceived(object sender, RemoteDataEventArgs<RemoteHostCall> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,23055,24604);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,23177,24593);
using(f_1570_23184_23213(s_tracer))            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,23247,23379);

Collection<RemoteHostCall> 
prerequisiteCalls =
f_1570_23315_23378(f_1570_23315_23329(eventArgs), computerName)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,23399,24578) || true) && (HostCallReceived != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,23399,24578);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,23533,23973) || true) && (f_1570_23537_23560(prerequisiteCalls)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,23533,23973);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,23614,23950);
foreach(RemoteHostCall hostcall in f_1570_23650_23667_I(prerequisiteCalls) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,23614,23950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,23725,23851);

RemoteDataEventArgs<RemoteHostCall> 
args =
f_1570_23801_23850(hostcall)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,23883,23923);

f_1570_23883_23922(
                            HostCallReceived, this, args);
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,23614,23950);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1570,1,337);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1570,1,337);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1570,23533,23973);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,23997,24042);

f_1570_23997_24041(
                    HostCallReceived, this, eventArgs);
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,23399,24578);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,23399,24578);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,24235,24503) || true) && (f_1570_24239_24262(prerequisiteCalls)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,24235,24503);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,24316,24480);
foreach(RemoteHostCall hostcall in f_1570_24352_24369_I(prerequisiteCalls) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,24316,24480);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,24427,24453);

f_1570_24427_24452(this, hostcall);
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,24316,24480);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1570,1,165);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1570,1,165);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1570,24235,24503);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,24527,24559);

f_1570_24527_24558(this, f_1570_24543_24557(eventArgs));
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,23399,24578);
}
DynAbs.Tracing.TraceSender.TraceExitUsing(1570,23177,24593);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,23055,24604);

System.IDisposable
f_1570_23184_23213(System.Management.Automation.PSTraceSource
this_param)
{
var return_v = this_param.TraceEventHandlers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 23184, 23213);
return return_v;
}


System.Management.Automation.Remoting.RemoteHostCall
f_1570_23315_23329(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 23315, 23329);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.RemoteHostCall>
f_1570_23315_23378(System.Management.Automation.Remoting.RemoteHostCall
this_param,string
computerName)
{
var return_v = this_param.PerformSecurityChecksOnHostMessage( computerName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 23315, 23378);
return return_v;
}


int
f_1570_23537_23560(System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.RemoteHostCall>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 23537, 23560);
return return_v;
}


System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>
f_1570_23801_23850(System.Management.Automation.Remoting.RemoteHostCall
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 23801, 23850);
return return_v;
}


int
f_1570_23883_23922(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>>
eventHandler,System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 23883, 23922);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.RemoteHostCall>
f_1570_23650_23667_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.RemoteHostCall>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 23650, 23667);
return return_v;
}


int
f_1570_23997_24041(System.EventHandler<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>>
eventHandler,System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 23997, 24041);
return 0;
}


int
f_1570_24239_24262(System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.RemoteHostCall>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 24239, 24262);
return return_v;
}


int
f_1570_24427_24452(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param,System.Management.Automation.Remoting.RemoteHostCall
hostcall)
{
this_param.ExecuteHostCall( hostcall);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 24427, 24452);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.RemoteHostCall>
f_1570_24352_24369_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.RemoteHostCall>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 24352, 24369);
return return_v;
}


System.Management.Automation.Remoting.RemoteHostCall
f_1570_24543_24557(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 24543, 24557);
return return_v;
}


int
f_1570_24527_24558(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param,System.Management.Automation.Remoting.RemoteHostCall
hostcall)
{
this_param.ExecuteHostCall( hostcall);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 24527, 24558);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,23055,24604);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,23055,24604);
}
		}

private void HandleConnectCompleted(object sender, RemoteDataEventArgs<Exception> e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,24895,25248);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,25164,25237);

f_1570_25164_25236(this, f_1570_25177_25235(PSInvocationState.Running, null));
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,24895,25248);

System.Management.Automation.PSInvocationStateInfo
f_1570_25177_25235(System.Management.Automation.PSInvocationState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.PSInvocationStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 25177, 25235);
return return_v;
}


int
f_1570_25164_25236(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param,System.Management.Automation.PSInvocationStateInfo
stateInfo)
{
this_param.SetStateInfo( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 25164, 25236);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,24895,25248);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,24895,25248);
}
		}

private void HandleCloseCompleted(object sender, EventArgs args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,25779,27722);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,26039,26060);

f_1570_26039_26059(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,26240,26291);

f_1570_26240_26290(
            // close the transport manager when CreateCloseAckPacket is received
            // otherwise may have race conditions in Server.OutOfProcessMediator
            dataStructureHandler);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,26307,27711) || true) && (f_1570_26311_26332(_stateInfoQueue)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,26307,27711);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,26605,27383) || true) && (!f_1570_26610_26653(this, f_1570_26621_26652(f_1570_26621_26646(shell))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,26605,27383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,26862,26945);

RemoteSessionStateEventArgs 
sessionEventArgs = args as RemoteSessionStateEventArgs
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,26967,27068);

Exception 
closeReason = (DynAbs.Tracing.TraceSender.Conditional_F1(1570, 26991, 27017)||(((sessionEventArgs != null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1570, 27020, 27060))||DynAbs.Tracing.TraceSender.Conditional_F3(1570, 27063, 27067)))?f_1570_27020_27060(f_1570_27020_27053(sessionEventArgs)):null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,27090,27272);

PSInvocationState 
finishedState = (DynAbs.Tracing.TraceSender.Conditional_F1(1570, 27124, 27191)||(((f_1570_27125_27156(f_1570_27125_27150(shell))== PSInvocationState.Disconnected) &&DynAbs.Tracing.TraceSender.Conditional_F2(1570, 27219, 27243))||DynAbs.Tracing.TraceSender.Conditional_F3(1570, 27246, 27271)))?                        PSInvocationState.Failed :PSInvocationState.Stopped
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,27296,27364);

f_1570_27296_27363(this, f_1570_27309_27362(finishedState, closeReason));
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,26605,27383);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,26307,27711);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,26307,27711);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,27497,27696) || true) && (f_1570_27504_27525(_stateInfoQueue)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,27497,27696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,27571,27631);

PSInvocationStateInfo 
stateInfo = f_1570_27605_27630(_stateInfoQueue)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,27653,27677);

f_1570_27653_27676(this, stateInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,27497,27696);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1570,27497,27696);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1570,27497,27696);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1570,26307,27711);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,25779,27722);

int
f_1570_26039_26059(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param)
{
this_param.UnblockCollections();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 26039, 26059);
return 0;
}


int
f_1570_26240_26290(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param)
{
this_param.RaiseRemoveAssociationEvent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 26240, 26290);
return 0;
}


int
f_1570_26311_26332(System.Collections.Generic.Queue<System.Management.Automation.PSInvocationStateInfo>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 26311, 26332);
return return_v;
}


System.Management.Automation.PSInvocationStateInfo
f_1570_26621_26646(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.InvocationStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 26621, 26646);
return return_v;
}


System.Management.Automation.PSInvocationState
f_1570_26621_26652(System.Management.Automation.PSInvocationStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 26621, 26652);
return return_v;
}


bool
f_1570_26610_26653(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param,System.Management.Automation.PSInvocationState
state)
{
var return_v = this_param.IsFinished( state);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 26610, 26653);
return return_v;
}


System.Management.Automation.RemoteSessionStateInfo
f_1570_27020_27053(System.Management.Automation.RemoteSessionStateEventArgs
this_param)
{
var return_v = this_param.SessionStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 27020, 27053);
return return_v;
}


System.Exception
f_1570_27020_27060(System.Management.Automation.RemoteSessionStateInfo
this_param)
{
var return_v = this_param.Reason ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 27020, 27060);
return return_v;
}


System.Management.Automation.PSInvocationStateInfo
f_1570_27125_27150(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.InvocationStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 27125, 27150);
return return_v;
}


System.Management.Automation.PSInvocationState
f_1570_27125_27156(System.Management.Automation.PSInvocationStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 27125, 27156);
return return_v;
}


System.Management.Automation.PSInvocationStateInfo
f_1570_27309_27362(System.Management.Automation.PSInvocationState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.PSInvocationStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 27309, 27362);
return return_v;
}


int
f_1570_27296_27363(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param,System.Management.Automation.PSInvocationStateInfo
stateInfo)
{
this_param.SetStateInfo( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 27296, 27363);
return 0;
}


int
f_1570_27504_27525(System.Collections.Generic.Queue<System.Management.Automation.PSInvocationStateInfo>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 27504, 27525);
return return_v;
}


System.Management.Automation.PSInvocationStateInfo
f_1570_27605_27630(System.Collections.Generic.Queue<System.Management.Automation.PSInvocationStateInfo>
this_param)
{
var return_v = this_param.Dequeue();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 27605, 27630);
return return_v;
}


int
f_1570_27653_27676(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param,System.Management.Automation.PSInvocationStateInfo
stateInfo)
{
this_param.SetStateInfo( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 27653, 27676);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,25779,27722);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,25779,27722);
}
		}

private bool IsFinished(PSInvocationState state)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,27734,27981);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,27807,27970);

return (state == PSInvocationState.Completed ||(DynAbs.Tracing.TraceSender.Expression_False(1570, 27815, 27909)||                    state == PSInvocationState.Failed )||(DynAbs.Tracing.TraceSender.Expression_False(1570, 27815, 27968)||                    state == PSInvocationState.Stopped));
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,27734,27981);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,27734,27981);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,27734,27981);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void ExecuteHostCall(RemoteHostCall hostcall)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,28152,28741);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,28230,28730) || true) && (f_1570_28234_28255(hostcall))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,28230,28730);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,28289,28426) || true) && (f_1570_28293_28330(hostcall))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,28289,28426);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,28372,28407);

f_1570_28372_28406(                    this.shell);
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,28289,28426);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,28446,28484);

f_1570_28446_28483(
                hostcall, hostToUse);
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,28230,28730);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,28230,28730);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,28550,28631);

RemoteHostResponse 
remoteHostResponse = f_1570_28590_28630(hostcall, hostToUse)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,28649,28715);

f_1570_28649_28714(                dataStructureHandler, remoteHostResponse);
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,28230,28730);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,28152,28741);

bool
f_1570_28234_28255(System.Management.Automation.Remoting.RemoteHostCall
this_param)
{
var return_v = this_param.IsVoidMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 28234, 28255);
return return_v;
}


bool
f_1570_28293_28330(System.Management.Automation.Remoting.RemoteHostCall
this_param)
{
var return_v = this_param.IsSetShouldExitOrPopRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 28293, 28330);
return return_v;
}


int
f_1570_28372_28406(System.Management.Automation.PowerShell
this_param)
{
this_param.ClearRemotePowerShell();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 28372, 28406);
return 0;
}


int
f_1570_28446_28483(System.Management.Automation.Remoting.RemoteHostCall
this_param,System.Management.Automation.Host.PSHost
clientHost)
{
this_param.ExecuteVoidMethod( clientHost);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 28446, 28483);
return 0;
}


System.Management.Automation.Remoting.RemoteHostResponse
f_1570_28590_28630(System.Management.Automation.Remoting.RemoteHostCall
this_param,System.Management.Automation.Host.PSHost
clientHost)
{
var return_v = this_param.ExecuteNonVoidMethod( clientHost);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 28590, 28630);
return return_v;
}


int
f_1570_28649_28714(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param,System.Management.Automation.Remoting.RemoteHostResponse
hostResponse)
{
this_param.SendHostResponseToServer( hostResponse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 28649, 28714);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,28152,28741);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,28152,28741);
}
		}

private void HandleCloseNotificationFromRunspacePool(object sender,
            RemoteDataEventArgs<Exception> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,28889,29876);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,29323,29344);

f_1570_29323_29343(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,29437,29488);

f_1570_29437_29487(
            // Since this is a terminal state..close the transport manager.
            dataStructureHandler);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,29618,29718);

f_1570_29618_29717(this, f_1570_29631_29716(PSInvocationState.Stopped, f_1570_29701_29715(eventArgs)));
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,28889,29876);

int
f_1570_29323_29343(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param)
{
this_param.UnblockCollections();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 29323, 29343);
return 0;
}


int
f_1570_29437_29487(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param)
{
this_param.RaiseRemoveAssociationEvent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 29437, 29487);
return 0;
}


System.Exception
f_1570_29701_29715(System.Management.Automation.RemoteDataEventArgs<System.Exception>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 29701, 29715);
return return_v;
}


System.Management.Automation.PSInvocationStateInfo
f_1570_29631_29716(System.Management.Automation.PSInvocationState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.PSInvocationStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 29631, 29716);
return return_v;
}


int
f_1570_29618_29717(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param,System.Management.Automation.PSInvocationStateInfo
stateInfo)
{
this_param.SetStateInfo( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 29618, 29717);
return 0;
}


            // Not calling dataStructureHandler.CloseConnection() as this must
            // have already been called by RunspacePool.Close()
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,28889,29876);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,28889,29876);
}
		}

private void HandleBrokenNotificationFromRunspacePool(object sender,
            RemoteDataEventArgs<Exception> eventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,30431,31816);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,30866,30887);

f_1570_30866_30886(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,30980,31031);

f_1570_30980_31030(
            // Since this is a terminal state..close the transport manager.
            dataStructureHandler);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,31045,31658) || true) && (stopCalled)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,31045,31658);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,31137,31156);

stopCalled = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,31374,31478);

f_1570_31374_31477(this, f_1570_31387_31476(PSInvocationState.Stopped, f_1570_31461_31475(eventArgs)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,31045,31658);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,31045,31658);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,31544,31643);

f_1570_31544_31642(this, f_1570_31557_31641(PSInvocationState.Failed, f_1570_31626_31640(eventArgs)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,31045,31658);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,30431,31816);

int
f_1570_30866_30886(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param)
{
this_param.UnblockCollections();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 30866, 30886);
return 0;
}


int
f_1570_30980_31030(System.Management.Automation.Internal.ClientPowerShellDataStructureHandler
this_param)
{
this_param.RaiseRemoveAssociationEvent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 30980, 31030);
return 0;
}


System.Exception
f_1570_31461_31475(System.Management.Automation.RemoteDataEventArgs<System.Exception>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 31461, 31475);
return return_v;
}


System.Management.Automation.PSInvocationStateInfo
f_1570_31387_31476(System.Management.Automation.PSInvocationState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.PSInvocationStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 31387, 31476);
return return_v;
}


int
f_1570_31374_31477(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param,System.Management.Automation.PSInvocationStateInfo
stateInfo)
{
this_param.SetStateInfo( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 31374, 31477);
return 0;
}


System.Exception
f_1570_31626_31640(System.Management.Automation.RemoteDataEventArgs<System.Exception>
this_param)
{
var return_v = this_param.Data;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 31626, 31640);
return return_v;
}


System.Management.Automation.PSInvocationStateInfo
f_1570_31557_31641(System.Management.Automation.PSInvocationState
state,System.Exception
reason)
{
var return_v = new System.Management.Automation.PSInvocationStateInfo( state, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 31557, 31641);
return return_v;
}


int
f_1570_31544_31642(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param,System.Management.Automation.PSInvocationStateInfo
stateInfo)
{
this_param.SetStateInfo( stateInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 31544, 31642);
return 0;
}


            // Not calling dataStructureHandler.CloseConnection() as this must
            // have already been called by RunspacePool.Close()
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,30431,31816);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,30431,31816);
}
		}

private void HandleRobustConnectionNotification(
            object sender,
            ConnectionStatusEventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,32057,38589);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,32300,32366);

PSConnectionRetryStatusEventArgs 
connectionRetryStatusArgs = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,32380,32415);

WarningRecord 
warningRecord = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,32429,32460);

ErrorRecord 
errorRecord = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,32474,32549);

int 
maxRetryConnectionTimeMSecs = f_1570_32508_32548(this.runspacePool)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,32563,32635);

int 
maxRetryConnectionTimeMinutes = maxRetryConnectionTimeMSecs / 60000
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,32649,36662);

switch (f_1570_32657_32671(e))
            {

case ConnectionStatus.NetworkFailureDetected:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,32649,36662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,32772,33061);

warningRecord = f_1570_32788_33060(PSConnectionRetryStatusEventArgs.FQIDNetworkFailureDetected, f_1570_32918_33059(f_1570_32936_32983(), this.computerName, maxRetryConnectionTimeMinutes));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,33085,33315);

connectionRetryStatusArgs =
f_1570_33138_33314(PSConnectionRetryStatus.NetworkFailureDetected, this.computerName, maxRetryConnectionTimeMSecs, warningRecord);
DynAbs.Tracing.TraceSender.TraceBreak(1570,33337,33343);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,32649,36662);

case ConnectionStatus.ConnectionRetryAttempt:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,32649,36662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,33430,33663);

warningRecord = f_1570_33446_33662(PSConnectionRetryStatusEventArgs.FQIDConnectionRetryAttempt, f_1570_33576_33661(f_1570_33594_33641(), this.computerName));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,33687,33917);

connectionRetryStatusArgs =
f_1570_33740_33916(PSConnectionRetryStatus.ConnectionRetryAttempt, this.computerName, maxRetryConnectionTimeMSecs, warningRecord);
DynAbs.Tracing.TraceSender.TraceBreak(1570,33939,33945);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,32649,36662);

case ConnectionStatus.ConnectionRetrySucceeded:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,32649,36662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,34034,34265);

warningRecord = f_1570_34050_34264(PSConnectionRetryStatusEventArgs.FQIDConnectionRetrySucceeded, f_1570_34182_34263(f_1570_34200_34243(), this.computerName));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,34289,34523);

connectionRetryStatusArgs =
f_1570_34342_34522(PSConnectionRetryStatus.ConnectionRetrySucceeded, this.computerName, maxRetryConnectionTimeMinutes, warningRecord);
DynAbs.Tracing.TraceSender.TraceBreak(1570,34545,34551);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,32649,36662);

case ConnectionStatus.AutoDisconnectStarting:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,32649,36662);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,34665,34908);

warningRecord = f_1570_34681_34907(PSConnectionRetryStatusEventArgs.FQIDAutoDisconnectStarting, f_1570_34819_34906(f_1570_34837_34886(), this.computerName));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,34936,35176);

connectionRetryStatusArgs =
f_1570_34993_35175(PSConnectionRetryStatus.AutoDisconnectStarting, this.computerName, maxRetryConnectionTimeMinutes, warningRecord);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1570,35223,35229);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,32649,36662);

case ConnectionStatus.AutoDisconnectSucceeded:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,32649,36662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,35317,35545);

warningRecord = f_1570_35333_35544(PSConnectionRetryStatusEventArgs.FQIDAutoDisconnectSucceeded, f_1570_35464_35543(f_1570_35482_35523(), this.computerName));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,35569,35802);

connectionRetryStatusArgs =
f_1570_35622_35801(PSConnectionRetryStatus.AutoDisconnectSucceeded, this.computerName, maxRetryConnectionTimeMinutes, warningRecord);
DynAbs.Tracing.TraceSender.TraceBreak(1570,35824,35830);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,32649,36662);

case ConnectionStatus.InternalErrorAbort:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,32649,36662);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,35940,36030);

string 
msg = f_1570_35953_36029(f_1570_35971_36009(), this.computerName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,36056,36108);

RuntimeException 
reason = f_1570_36082_36107(msg)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,36134,36332);

errorRecord = f_1570_36148_36331(reason, PSConnectionRetryStatusEventArgs.FQIDNetworkOrDisconnectFailed, ErrorCategory.InvalidOperation, this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,36360,36594);

connectionRetryStatusArgs =
f_1570_36417_36593(PSConnectionRetryStatus.InternalErrorAbort, this.computerName, maxRetryConnectionTimeMinutes, errorRecord);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1570,36641,36647);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,32649,36662);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,36678,36771) || true) && (connectionRetryStatusArgs == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,36678,36771);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,36749,36756);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,36678,36771);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,36829,36893);

_connectionRetryStatus = f_1570_36854_36892(connectionRetryStatusArgs);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,36909,37991) || true) && (warningRecord != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,36909,37991);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,36968,37150);

RemotingWarningRecord 
remotingWarningRecord = f_1570_37014_37149(warningRecord, f_1570_37098_37148(this.computerName, f_1570_37132_37147(this)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,37233,37453);

f_1570_37233_37452(this, this, f_1570_37295_37451(f_1570_37367_37450(remotingWarningRecord, RemotingDataType.PowerShellWarning)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,37516,37712);

RemoteHostCall 
writeWarning = f_1570_37546_37711(-100, RemoteHostMethodId.WriteWarningLine, new object[] { f_1570_37687_37708(warningRecord)})
;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,37776,37885);

f_1570_37776_37884(this, this, f_1570_37830_37883(writeWarning));
                }
                catch (PSNotImplementedException)
                { DynAbs.Tracing.TraceSender.TraceEnterCatch(1570,37922,37976);
DynAbs.Tracing.TraceSender.TraceExitCatch(1570,37922,37976);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,36909,37991);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,38007,38464) || true) && (errorRecord != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,38007,38464);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,38064,38238);

RemotingErrorRecord 
remotingErrorRecord = f_1570_38106_38237(errorRecord, f_1570_38186_38236(this.computerName, f_1570_38220_38235(this)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,38343,38449);

f_1570_38343_38448(this, this, f_1570_38390_38447(remotingErrorRecord));
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,38007,38464);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,38509,38578);

f_1570_38509_38577(
            // Raise event.
            RCConnectionNotification, this, connectionRetryStatusArgs);
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,32057,38589);

int
f_1570_32508_32548(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.MaxRetryConnectionTime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 32508, 32548);
return return_v;
}


System.Management.Automation.Remoting.ConnectionStatus
f_1570_32657_32671(System.Management.Automation.Remoting.ConnectionStatusEventArgs
this_param)
{
var return_v = this_param.Notification;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 32657, 32671);
return return_v;
}


string
f_1570_32936_32983()
{
var return_v = RemotingErrorIdStrings.RCNetworkFailureDetected;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 32936, 32983);
return return_v;
}


string
f_1570_32918_33059(string
formatSpec,string
o1,int
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 32918, 33059);
return return_v;
}


System.Management.Automation.WarningRecord
f_1570_32788_33060(string
fullyQualifiedWarningId,string
message)
{
var return_v = new System.Management.Automation.WarningRecord( fullyQualifiedWarningId, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 32788, 33060);
return return_v;
}


System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatusEventArgs
f_1570_33138_33314(System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatus
notification,string
computerName,int
maxRetryConnectionTime,System.Management.Automation.WarningRecord
infoRecord)
{
var return_v = new System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatusEventArgs( notification, computerName, maxRetryConnectionTime, (object)infoRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 33138, 33314);
return return_v;
}


string
f_1570_33594_33641()
{
var return_v = RemotingErrorIdStrings.RCConnectionRetryAttempt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 33594, 33641);
return return_v;
}


string
f_1570_33576_33661(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 33576, 33661);
return return_v;
}


System.Management.Automation.WarningRecord
f_1570_33446_33662(string
fullyQualifiedWarningId,string
message)
{
var return_v = new System.Management.Automation.WarningRecord( fullyQualifiedWarningId, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 33446, 33662);
return return_v;
}


System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatusEventArgs
f_1570_33740_33916(System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatus
notification,string
computerName,int
maxRetryConnectionTime,System.Management.Automation.WarningRecord
infoRecord)
{
var return_v = new System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatusEventArgs( notification, computerName, maxRetryConnectionTime, (object)infoRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 33740, 33916);
return return_v;
}


string
f_1570_34200_34243()
{
var return_v = RemotingErrorIdStrings.RCReconnectSucceeded;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 34200, 34243);
return return_v;
}


string
f_1570_34182_34263(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 34182, 34263);
return return_v;
}


System.Management.Automation.WarningRecord
f_1570_34050_34264(string
fullyQualifiedWarningId,string
message)
{
var return_v = new System.Management.Automation.WarningRecord( fullyQualifiedWarningId, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 34050, 34264);
return return_v;
}


System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatusEventArgs
f_1570_34342_34522(System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatus
notification,string
computerName,int
maxRetryConnectionTime,System.Management.Automation.WarningRecord
infoRecord)
{
var return_v = new System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatusEventArgs( notification, computerName, maxRetryConnectionTime, (object)infoRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 34342, 34522);
return return_v;
}


string
f_1570_34837_34886()
{
var return_v = RemotingErrorIdStrings.RCAutoDisconnectingWarning;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 34837, 34886);
return return_v;
}


string
f_1570_34819_34906(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 34819, 34906);
return return_v;
}


System.Management.Automation.WarningRecord
f_1570_34681_34907(string
fullyQualifiedWarningId,string
message)
{
var return_v = new System.Management.Automation.WarningRecord( fullyQualifiedWarningId, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 34681, 34907);
return return_v;
}


System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatusEventArgs
f_1570_34993_35175(System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatus
notification,string
computerName,int
maxRetryConnectionTime,System.Management.Automation.WarningRecord
infoRecord)
{
var return_v = new System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatusEventArgs( notification, computerName, maxRetryConnectionTime, (object)infoRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 34993, 35175);
return return_v;
}


string
f_1570_35482_35523()
{
var return_v = RemotingErrorIdStrings.RCAutoDisconnected;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 35482, 35523);
return return_v;
}


string
f_1570_35464_35543(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 35464, 35543);
return return_v;
}


System.Management.Automation.WarningRecord
f_1570_35333_35544(string
fullyQualifiedWarningId,string
message)
{
var return_v = new System.Management.Automation.WarningRecord( fullyQualifiedWarningId, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 35333, 35544);
return return_v;
}


System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatusEventArgs
f_1570_35622_35801(System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatus
notification,string
computerName,int
maxRetryConnectionTime,System.Management.Automation.WarningRecord
infoRecord)
{
var return_v = new System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatusEventArgs( notification, computerName, maxRetryConnectionTime, (object)infoRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 35622, 35801);
return return_v;
}


string
f_1570_35971_36009()
{
var return_v = RemotingErrorIdStrings.RCInternalError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 35971, 36009);
return return_v;
}


string
f_1570_35953_36029(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 35953, 36029);
return return_v;
}


System.Management.Automation.RuntimeException
f_1570_36082_36107(string
message)
{
var return_v = new System.Management.Automation.RuntimeException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 36082, 36107);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1570_36148_36331(System.Management.Automation.RuntimeException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 36148, 36331);
return return_v;
}


System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatusEventArgs
f_1570_36417_36593(System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatus
notification,string
computerName,int
maxRetryConnectionTime,System.Management.Automation.ErrorRecord
infoRecord)
{
var return_v = new System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatusEventArgs( notification, computerName, maxRetryConnectionTime, (object)infoRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 36417, 36593);
return return_v;
}


System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatus
f_1570_36854_36892(System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatusEventArgs
this_param)
{
var return_v = this_param.Notification;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 36854, 36892);
return return_v;
}


System.Guid
f_1570_37132_37147(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 37132, 37147);
return return_v;
}


System.Management.Automation.Remoting.OriginInfo
f_1570_37098_37148(string
computerName,System.Guid
runspaceID)
{
var return_v = new System.Management.Automation.Remoting.OriginInfo( computerName, runspaceID);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 37098, 37148);
return return_v;
}


System.Management.Automation.Runspaces.RemotingWarningRecord
f_1570_37014_37149(System.Management.Automation.WarningRecord
warningRecord,System.Management.Automation.Remoting.OriginInfo
originInfo)
{
var return_v = new System.Management.Automation.Runspaces.RemotingWarningRecord( warningRecord, originInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 37014, 37149);
return return_v;
}


System.Management.Automation.Internal.InformationalMessage
f_1570_37367_37450(System.Management.Automation.Runspaces.RemotingWarningRecord
message,System.Management.Automation.RemotingDataType
dataType)
{
var return_v = new System.Management.Automation.Internal.InformationalMessage( (object)message, dataType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 37367, 37450);
return return_v;
}


System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>
f_1570_37295_37451(System.Management.Automation.Internal.InformationalMessage
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 37295, 37451);
return return_v;
}


int
f_1570_37233_37452(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param,System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Internal.InformationalMessage>
eventArgs)
{
this_param.HandleInformationalMessageReceived( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 37233, 37452);
return 0;
}


string
f_1570_37687_37708(System.Management.Automation.WarningRecord
this_param)
{
var return_v = this_param.Message ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 37687, 37708);
return return_v;
}


System.Management.Automation.Remoting.RemoteHostCall
f_1570_37546_37711(int
callId,System.Management.Automation.Remoting.RemoteHostMethodId
methodId,object[]
parameters)
{
var return_v = new System.Management.Automation.Remoting.RemoteHostCall( (long)callId, methodId, parameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 37546, 37711);
return return_v;
}


System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>
f_1570_37830_37883(System.Management.Automation.Remoting.RemoteHostCall
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 37830, 37883);
return return_v;
}


int
f_1570_37776_37884(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param,System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostCall>
eventArgs)
{
this_param.HandleHostCallReceived( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 37776, 37884);
return 0;
}


System.Guid
f_1570_38220_38235(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 38220, 38235);
return return_v;
}


System.Management.Automation.Remoting.OriginInfo
f_1570_38186_38236(string
computerName,System.Guid
runspaceID)
{
var return_v = new System.Management.Automation.Remoting.OriginInfo( computerName, runspaceID);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 38186, 38236);
return return_v;
}


System.Management.Automation.Runspaces.RemotingErrorRecord
f_1570_38106_38237(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.Remoting.OriginInfo
originInfo)
{
var return_v = new System.Management.Automation.Runspaces.RemotingErrorRecord( errorRecord, originInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 38106, 38237);
return return_v;
}


System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.ErrorRecord>
f_1570_38390_38447(System.Management.Automation.Runspaces.RemotingErrorRecord
data)
{
var return_v = new System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.ErrorRecord>( (object)data);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 38390, 38447);
return return_v;
}


int
f_1570_38343_38448(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param,System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
sender,System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.ErrorRecord>
eventArgs)
{
this_param.HandleErrorReceived( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 38343, 38448);
return 0;
}


int
f_1570_38509_38577(System.EventHandler<System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatusEventArgs>
eventHandler,System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
sender,System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatusEventArgs
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.Runspaces.Internal.PSConnectionRetryStatusEventArgs>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 38509, 38577);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,32057,38589);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,32057,38589);
}
		}

protected ObjectStreamBase inputstream;

protected ObjectStreamBase errorstream;

protected PSInformationalBuffers informationalBuffers;

protected PowerShell shell;

protected Guid clientRunspacePoolId;

protected bool noInput;

protected PSInvocationSettings settings;

protected ObjectStreamBase outputstream;

protected string computerName;

protected ClientPowerShellDataStructureHandler dataStructureHandler;

protected bool stopCalled ;

protected PSHost hostToUse;

protected RemoteRunspacePoolInternal runspacePool;

protected const string 
WRITE_DEBUG_LINE = "WriteDebugLine"
;

protected const string 
WRITE_VERBOSE_LINE = "WriteVerboseLine"
;

protected const string 
WRITE_WARNING_LINE = "WriteWarningLine"
;

protected const string 
WRITE_PROGRESS = "WriteProgress"
;

protected bool initialized ;

private Queue<PSInvocationStateInfo> _stateInfoQueue ;

private PSConnectionRetryStatus _connectionRetryStatus ;

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,40306,40419);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,40352,40366);

f_1570_40352_40365(this, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,40382,40408);

f_1570_40382_40407(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,40306,40419);

int
f_1570_40352_40365(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
this_param,bool
disposing)
{
this_param.Dispose( disposing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 40352, 40365);
return 0;
}


int
f_1570_40382_40407(System.Management.Automation.Runspaces.Internal.ClientRemotePowerShell
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 40382, 40407);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,40306,40419);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,40306,40419);
}
		}

protected void Dispose(bool disposing)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1570,40599,40847);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,40662,40836) || true) && (disposing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1570,40662,40836);
DynAbs.Tracing.TraceSender.TraceExitCondition(1570,40662,40836);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1570,40599,40847);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,40599,40847);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,40599,40847);
}
		}

static ClientRemotePowerShell()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1570,584,40886);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,773,845);
s_tracer = f_1570_784_845("CRPS", "ClientRemotePowerShellBase");DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,39336,39371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,39405,39444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,39478,39517);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,39551,39583);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1570,584,40886);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,584,40886);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1570,584,40886);

static System.Management.Automation.PSTraceSource
f_1570_784_845(string
name,string
description)
{
var return_v = PSTraceSource.GetTracer( name, description);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 784, 845);
return return_v;
}


System.Guid
f_1570_1372_1395(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 1372, 1395);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1570_1641_1668(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 1641, 1668);
return return_v;
}


string
f_1570_1641_1681(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1570, 1641, 1681);
return return_v;
}


System.Collections.Generic.Queue<System.Management.Automation.PSInvocationStateInfo>
f_1570_40000_40034()
{
var return_v = new System.Collections.Generic.Queue<System.Management.Automation.PSInvocationStateInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1570, 40000, 40034);
return return_v;
}

}

    
    /// <summary>
    /// Robust Connection notifications.
    /// </summary>
    internal enum PSConnectionRetryStatus
    {
        None = 0,
        NetworkFailureDetected = 1,
        ConnectionRetryAttempt = 2,
        ConnectionRetrySucceeded = 3,
        AutoDisconnectStarting = 4,
        AutoDisconnectSucceeded = 5,
        InternalErrorAbort = 6
    };
internal sealed class PSConnectionRetryStatusEventArgs : EventArgs
{
internal const string 
FQIDNetworkFailureDetected = "PowerShellNetworkFailureDetected"
;

internal const string 
FQIDConnectionRetryAttempt = "PowerShellConnectionRetryAttempt"
;

internal const string 
FQIDConnectionRetrySucceeded = "PowerShellConnectionRetrySucceeded"
;

internal const string 
FQIDAutoDisconnectStarting = "PowerShellNetworkFailedStartDisconnect"
;

internal const string 
FQIDAutoDisconnectSucceeded = "PowerShellAutoDisconnectSucceeded"
;

internal const string 
FQIDNetworkOrDisconnectFailed = "PowerShellNetworkOrDisconnectFailed"
;

internal PSConnectionRetryStatusEventArgs(
            PSConnectionRetryStatus notification,
            string computerName,
            int maxRetryConnectionTime,
            object infoRecord)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1570,42083,42496);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,42508,42562);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,42574,42611);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,42623,42667);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,42679,42721);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,42308,42336);

Notification = notification;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,42350,42378);

ComputerName = computerName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,42392,42440);

MaxRetryConnectionTime = maxRetryConnectionTime;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,42454,42485);

InformationRecord = infoRecord;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1570,42083,42496);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1570,42083,42496);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,42083,42496);
}
		}

internal PSConnectionRetryStatus Notification {get; }

internal string ComputerName {get; }

internal int MaxRetryConnectionTime {get; }

internal object InformationRecord {get; }

static PSConnectionRetryStatusEventArgs()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1570,41404,42728);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,41509,41572);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,41605,41668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,41701,41768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,41801,41870);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,41903,41968);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1570,42001,42070);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1570,41404,42728);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1570,41404,42728);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1570,41404,42728);
}

    }
