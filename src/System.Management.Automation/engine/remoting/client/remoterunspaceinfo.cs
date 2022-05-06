// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Internal;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Runspaces
{
    /// <summary>
    /// Computer target type.
    /// </summary>
    public enum TargetMachineType
    {
        /// <summary>
        /// Target is a machine with which the session is based on networking.
        /// </summary>
        RemoteMachine,

        /// <summary>
        /// Target is a virtual machine with which the session is based on Hyper-V socket.
        /// </summary>
        VirtualMachine,

        /// <summary>
        /// Target is a container with which the session is based on Hyper-V socket (Hyper-V
        /// container) or named pipe (windows container)
        /// </summary>
        Container
    }
public sealed class PSSession
{
private RemoteRunspace _remoteRunspace;

private static int s_seed ;

public TargetMachineType ComputerType {get; set; }

public string ComputerName
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1580,2169,2271);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,2205,2256);

return f_1580_2212_2255(f_1580_2212_2242(_remoteRunspace));
DynAbs.Tracing.TraceSender.TraceExitMethod(1580,2169,2271);

System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1580_2212_2242(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 2212, 2242);
return return_v;
}


string
f_1580_2212_2255(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 2212, 2255);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1580,2118,2282);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1580,2118,2282);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public string ContainerId
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1580,2432,2862);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,2468,2847) || true) && (f_1580_2472_2484()== TargetMachineType.Container)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,2468,2847);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,2557,2656);

ContainerConnectionInfo 
connectionInfo = f_1580_2598_2628(_remoteRunspace)as ContainerConnectionInfo
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,2678,2726);

return f_1580_2685_2725(f_1580_2685_2713(connectionInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,2468,2847);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,2468,2847);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,2808,2828);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,2468,2847);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1580,2432,2862);

System.Management.Automation.Runspaces.TargetMachineType
f_1580_2472_2484()
{
var return_v = ComputerType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 2472, 2484);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1580_2598_2628(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 2598, 2628);
return return_v;
}


System.Management.Automation.Runspaces.ContainerProcess
f_1580_2685_2713(System.Management.Automation.Runspaces.ContainerConnectionInfo
this_param)
{
var return_v = this_param.ContainerProc;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 2685, 2713);
return return_v;
}


string
f_1580_2685_2725(System.Management.Automation.Runspaces.ContainerProcess
this_param)
{
var return_v = this_param.ContainerId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 2685, 2725);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1580,2382,2873);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1580,2382,2873);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public string VMName
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1580,3026,3343);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,3062,3328) || true) && (f_1580_3066_3078()== TargetMachineType.VirtualMachine)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,3062,3328);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,3156,3207);

return f_1580_3163_3206(f_1580_3163_3193(_remoteRunspace));
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,3062,3328);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,3062,3328);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,3289,3309);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,3062,3328);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1580,3026,3343);

System.Management.Automation.Runspaces.TargetMachineType
f_1580_3066_3078()
{
var return_v = ComputerType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 3066, 3078);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1580_3163_3193(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 3163, 3193);
return return_v;
}


string
f_1580_3163_3206(System.Management.Automation.Runspaces.RunspaceConnectionInfo
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 3163, 3206);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1580,2981,3354);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1580,2981,3354);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public Guid? VMId
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1580,3504,3898);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,3540,3883) || true) && (f_1580_3544_3556()== TargetMachineType.VirtualMachine)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,3540,3883);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,3634,3719);

VMConnectionInfo 
connectionInfo = f_1580_3668_3698(_remoteRunspace)as VMConnectionInfo
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,3741,3770);

return f_1580_3748_3769(connectionInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,3540,3883);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,3540,3883);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,3852,3864);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,3540,3883);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1580,3504,3898);

System.Management.Automation.Runspaces.TargetMachineType
f_1580_3544_3556()
{
var return_v = ComputerType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 3544, 3556);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1580_3668_3698(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 3668, 3698);
return return_v;
}


System.Guid
f_1580_3748_3769(System.Management.Automation.Runspaces.VMConnectionInfo
this_param)
{
var return_v = this_param.VMGuid;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 3748, 3769);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1580,3462,3909);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1580,3462,3909);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public string ConfigurationName {get; }

public Guid InstanceId
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1580,4229,4314);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,4265,4299);

return f_1580_4272_4298(_remoteRunspace);
DynAbs.Tracing.TraceSender.TraceExitMethod(1580,4229,4314);

System.Guid
f_1580_4272_4298(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 4272, 4298);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1580,4182,4325);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1580,4182,4325);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public int Id {get; }

public string Name {get; set; }

public RunspaceAvailability Availability
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1580,4875,4963);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,4911,4948);

return f_1580_4918_4947(f_1580_4918_4926());
DynAbs.Tracing.TraceSender.TraceExitMethod(1580,4875,4963);

System.Management.Automation.Runspaces.Runspace
f_1580_4918_4926()
{
var return_v = Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 4918, 4926);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceAvailability
f_1580_4918_4947(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceAvailability;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 4918, 4947);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1580,4810,4974);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1580,4810,4974);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public PSPrimitiveDictionary ApplicationPrivateData
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1580,5280,5380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,5316,5365);

return f_1580_5323_5364(f_1580_5323_5336(this));
DynAbs.Tracing.TraceSender.TraceExitMethod(1580,5280,5380);

System.Management.Automation.Runspaces.Runspace
f_1580_5323_5336(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 5323, 5336);
return return_v;
}


System.Management.Automation.PSPrimitiveDictionary
f_1580_5323_5364(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.GetApplicationPrivateData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1580, 5323, 5364);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1580,5204,5391);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1580,5204,5391);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public Runspace Runspace
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1580,5830,5904);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,5866,5889);

return _remoteRunspace;
DynAbs.Tracing.TraceSender.TraceExitMethod(1580,5830,5904);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1580,5781,5915);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1580,5781,5915);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public string Transport {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(1580,6039,6060);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,6042,6060);
return f_1580_6042_6060(this);DynAbs.Tracing.TraceSender.TraceExitMethod(1580,6039,6060);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1580,6039,6060);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1580,6039,6060);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override string ToString()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1580,6273,6524);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,6415,6454);

string 
formatString = "[PSSession]{0}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,6468,6513);

return f_1580_6475_6512(formatString, f_1580_6507_6511());
DynAbs.Tracing.TraceSender.TraceExitMethod(1580,6273,6524);

string
f_1580_6507_6511()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 6507, 6511);
return return_v;
}


string
f_1580_6475_6512(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1580, 6475, 6512);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1580,6273,6524);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1580,6273,6524);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool InsertRunspace(RemoteRunspace remoteRunspace)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1580,7053,7387);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,7137,7301) || true) && (remoteRunspace == null ||(DynAbs.Tracing.TraceSender.Expression_False(1580, 7141, 7239)||f_1580_7184_7209(remoteRunspace)!= f_1580_7213_7239(_remoteRunspace)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,7137,7301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,7273,7286);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,7137,7301);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,7317,7350);

_remoteRunspace = remoteRunspace;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,7364,7376);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1580,7053,7387);

System.Guid
f_1580_7184_7209(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.InstanceId ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 7184, 7209);
return return_v;
}


System.Guid
f_1580_7213_7239(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 7213, 7239);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1580,7053,7387);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1580,7053,7387);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal PSSession(RemoteRunspace remoteRunspace)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1580,7755,10075);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,1619,1634);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,1966,2017);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,4028,4068);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,4476,4498);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,4615,4647);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,7829,7862);

_remoteRunspace = remoteRunspace;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,7934,8223) || true) && (f_1580_7938_7964(remoteRunspace)!= -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,7934,8223);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,8004,8036);

Id = f_1580_8009_8035(remoteRunspace);
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,7934,8223);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,7934,8223);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,8102,8158);

Id = f_1580_8107_8157(ref s_seed);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,8176,8208);

remoteRunspace.PSSessionId = f_1580_8205_8207();
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,7934,8223);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,8298,8581) || true) && (!f_1580_8303_8353(f_1580_8324_8352(remoteRunspace)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,8298,8581);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,8387,8423);

Name = f_1580_8394_8422(remoteRunspace);
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,8298,8581);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,8298,8581);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,8489,8512);

Name = "Runspace" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_1580_8509_8511()).ToString(),1580,8509,8511);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,8530,8566);

remoteRunspace.PSSessionName = f_1580_8561_8565();
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,8298,8581);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,8597,10064);

switch (f_1580_8605_8634(remoteRunspace))
            {

case WSManConnectionInfo _:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,8597,10064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,8717,8764);

ComputerType = TargetMachineType.RemoteMachine;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,8786,8982);

string 
fullShellName = f_1580_8809_8981(f_1580_8900_8929(remoteRunspace), "ShellUri", string.Empty)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,9004,9059);

ConfigurationName = f_1580_9024_9058(this, fullShellName);
DynAbs.Tracing.TraceSender.TraceBreak(1580,9081,9087);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,8597,10064);

case VMConnectionInfo vmConnectionInfo:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,8597,10064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,9168,9216);

ComputerType = TargetMachineType.VirtualMachine;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,9238,9293);

ConfigurationName = f_1580_9258_9292(vmConnectionInfo);
DynAbs.Tracing.TraceSender.TraceBreak(1580,9315,9321);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,8597,10064);

case ContainerConnectionInfo containerConnectionInfo:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,8597,10064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,9416,9459);

ComputerType = TargetMachineType.Container;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,9481,9557);

ConfigurationName = f_1580_9501_9556(f_1580_9501_9538(containerConnectionInfo));
DynAbs.Tracing.TraceSender.TraceBreak(1580,9579,9585);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,8597,10064);

case SSHConnectionInfo _:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,8597,10064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,9652,9699);

ComputerType = TargetMachineType.RemoteMachine;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,9721,9756);

ConfigurationName = "DefaultShell";
DynAbs.Tracing.TraceSender.TraceBreak(1580,9778,9784);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,8597,10064);

case NewProcessConnectionInfo _:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,8597,10064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,9858,9905);

ComputerType = TargetMachineType.RemoteMachine;
DynAbs.Tracing.TraceSender.TraceBreak(1580,9927,9933);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,8597,10064);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,8597,10064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,9983,10021);

f_1580_9983_10020(false, "Invalid Runspace");
DynAbs.Tracing.TraceSender.TraceBreak(1580,10043,10049);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,8597,10064);
            }
DynAbs.Tracing.TraceSender.TraceExitConstructor(1580,7755,10075);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1580,7755,10075);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1580,7755,10075);
}
		}

private string GetTransportName()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1580,10310,11034);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,10368,11023);

switch (f_1580_10376_10406(_remoteRunspace))
            {

case WSManConnectionInfo _:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,10368,11023);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,10489,10504);

return "WSMan";
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,10368,11023);

case SSHConnectionInfo  _:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,10368,11023);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,10572,10585);

return "SSH";
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,10368,11023);

case NamedPipeConnectionInfo _:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,10368,11023);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,10658,10677);

return "NamedPipe";
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,10368,11023);

case ContainerConnectionInfo _:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,10368,11023);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,10750,10769);

return "Container";
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,10368,11023);

case NewProcessConnectionInfo _:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,10368,11023);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,10843,10860);

return "Process";
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,10368,11023);

case VMConnectionInfo _:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,10368,11023);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,10926,10941);

return "VMBus";
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,10368,11023);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1580,10368,11023);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,10991,11008);

return "Unknown";
DynAbs.Tracing.TraceSender.TraceExitCondition(1580,10368,11023);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1580,10310,11034);

System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1580_10376_10406(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 10376, 10406);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1580,10310,11034);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1580,10310,11034);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string GetDisplayShellName(string shell)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1580,11285,11639);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,11358,11457);

string 
shellPrefix = System.Management.Automation.Remoting.Client.WSManNativeApi.ResourceURIPrefix
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,11471,11546);

int 
index = f_1580_11483_11545(shell, shellPrefix, StringComparison.OrdinalIgnoreCase)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,11562,11628);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1580, 11569, 11581)||(((index == 0) &&DynAbs.Tracing.TraceSender.Conditional_F2(1580, 11584, 11619))||DynAbs.Tracing.TraceSender.Conditional_F3(1580, 11622, 11627)))?f_1580_11584_11619(shell, f_1580_11600_11618(shellPrefix)):shell;
DynAbs.Tracing.TraceSender.TraceExitMethod(1580,11285,11639);

int
f_1580_11483_11545(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.IndexOf( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1580, 11483, 11545);
return return_v;
}


int
f_1580_11600_11618(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 11600, 11618);
return return_v;
}


string
f_1580_11584_11619(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1580, 11584, 11619);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1580,11285,11639);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1580,11285,11639);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string GenerateRunspaceName(out int rtnId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1580,11916,12113);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,11999,12029);

int 
id = f_1580_12008_12028()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,12043,12054);

rtnId = id;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,12068,12102);

return "Runspace" + f_1580_12088_12101(id);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1580,11916,12113);

int
f_1580_12008_12028()
{
var return_v = GenerateRunspaceId();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1580, 12008, 12028);
return return_v;
}


string
f_1580_12088_12101(int
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1580, 12088, 12101);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1580,11916,12113);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1580,11916,12113);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static int GenerateRunspaceId()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1580,12274,12408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,12339,12397);

return f_1580_12346_12396(ref s_seed);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1580,12274,12408);

int
f_1580_12346_12396(ref int
location)
{
var return_v = System.Threading.Interlocked.Increment( ref location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1580, 12346, 12396);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1580,12274,12408);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1580,12274,12408);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static PSSession()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1580,1515,12437);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1580,1779,1789);
s_seed = 0;DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1580,1515,12437);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1580,1515,12437);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1580,1515,12437);

string
f_1580_6042_6060(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.GetTransportName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1580, 6042, 6060);
return return_v;
}


int
f_1580_7938_7964(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.PSSessionId ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 7938, 7964);
return return_v;
}


int
f_1580_8009_8035(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.PSSessionId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 8009, 8035);
return return_v;
}


int
f_1580_8107_8157(ref int
location)
{
var return_v = System.Threading.Interlocked.Increment( ref location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1580, 8107, 8157);
return return_v;
}


int
f_1580_8205_8207()
{
var return_v = Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 8205, 8207);
return return_v;
}


string
f_1580_8324_8352(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.PSSessionName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 8324, 8352);
return return_v;
}


bool
f_1580_8303_8353(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1580, 8303, 8353);
return return_v;
}


string
f_1580_8394_8422(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.PSSessionName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 8394, 8422);
return return_v;
}


int
f_1580_8509_8511()
{
var return_v = Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 8509, 8511);
return return_v;
}


string
f_1580_8561_8565()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 8561, 8565);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1580_8605_8634(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 8605, 8634);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1580_8900_8929(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 8900, 8929);
return return_v;
}


string
f_1580_8809_8981(System.Management.Automation.Runspaces.RunspaceConnectionInfo
rsCI,string
property,string
defaultValue)
{
var return_v = WSManConnectionInfo.ExtractPropertyAsWsManConnectionInfo<string>( rsCI, property, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1580, 8809, 8981);
return return_v;
}


string
f_1580_9024_9058(System.Management.Automation.Runspaces.PSSession
this_param,string
shell)
{
var return_v = this_param.GetDisplayShellName( shell);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1580, 9024, 9058);
return return_v;
}


string
f_1580_9258_9292(System.Management.Automation.Runspaces.VMConnectionInfo
this_param)
{
var return_v = this_param.ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 9258, 9292);
return return_v;
}


System.Management.Automation.Runspaces.ContainerProcess
f_1580_9501_9538(System.Management.Automation.Runspaces.ContainerConnectionInfo
this_param)
{
var return_v = this_param.ContainerProc;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 9501, 9538);
return return_v;
}


string
f_1580_9501_9556(System.Management.Automation.Runspaces.ContainerProcess
this_param)
{
var return_v = this_param.ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1580, 9501, 9556);
return return_v;
}


int
f_1580_9983_10020(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1580, 9983, 10020);
return 0;
}

}
}
