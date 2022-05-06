// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting;
using System.Management.Automation.Runspaces;

using Microsoft.Win32;

namespace Microsoft.PowerShell.Commands
{
    /// <summary>
    /// This enum is used to distinguish two sets of parameters on some of the remoting cmdlets.
    /// </summary>
    internal enum RunspaceParameterSet
    {
        /// <summary>
        /// Use ComputerName parameter set.
        /// </summary>
        ComputerName,
        /// <summary>
        /// Use Runspace Parameter set.
        /// </summary>
        Runspace
    }
internal static class RemotingCommandUtil
{
internal static bool HasRepeatingRunspaces(PSSession[] runspaceInfos)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1606,1001,1917);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,1095,1231) || true) && (runspaceInfos == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1606,1095,1231);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,1154,1216);

throw f_1606_1160_1215("runspaceInfos");
DynAbs.Tracing.TraceSender.TraceExitCondition(1606,1095,1231);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,1247,1389) || true) && (f_1606_1251_1277(runspaceInfos, 0)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1606,1247,1389);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,1316,1374);

throw f_1606_1322_1373("runspaceInfos");
DynAbs.Tracing.TraceSender.TraceExitCondition(1606,1247,1389);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,1414,1419);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,1405,1877) || true) && (i < f_1606_1425_1451(runspaceInfos, 0))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,1453,1456)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1606,1405,1877))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1606,1405,1877);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,1499,1504);
                for (int 
k = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,1490,1862) || true) && (k < f_1606_1510_1536(runspaceInfos, 0))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,1538,1541)
,k++,DynAbs.Tracing.TraceSender.TraceExitCondition(1606,1490,1862))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1606,1490,1862);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,1583,1843) || true) && (i != k)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1606,1583,1843);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,1643,1820) || true) && (f_1606_1647_1683(f_1606_1647_1672(runspaceInfos[i]))== f_1606_1687_1723(f_1606_1687_1712(runspaceInfos[k])))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1606,1643,1820);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,1781,1793);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1606,1643,1820);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1606,1583,1843);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1606,1,373);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1606,1,373);
}}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1606,1,473);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1606,1,473);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,1893,1906);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1606,1001,1917);

System.Management.Automation.PSArgumentNullException
f_1606_1160_1215(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 1160, 1215);
return return_v;
}


int
f_1606_1251_1277(System.Management.Automation.Runspaces.PSSession[]
this_param,int
dimension)
{
var return_v = this_param.GetLength( dimension);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 1251, 1277);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1606_1322_1373(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 1322, 1373);
return return_v;
}


int
f_1606_1425_1451(System.Management.Automation.Runspaces.PSSession[]
this_param,int
dimension)
{
var return_v = this_param.GetLength( dimension);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 1425, 1451);
return return_v;
}


int
f_1606_1510_1536(System.Management.Automation.Runspaces.PSSession[]
this_param,int
dimension)
{
var return_v = this_param.GetLength( dimension);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 1510, 1536);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1606_1647_1672(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1606, 1647, 1672);
return return_v;
}


System.Guid
f_1606_1647_1683(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.InstanceId ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1606, 1647, 1683);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1606_1687_1712(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1606, 1687, 1712);
return return_v;
}


System.Guid
f_1606_1687_1723(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1606, 1687, 1723);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1606,1001,1917);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1606,1001,1917);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool ExceedMaximumAllowableRunspaces(PSSession[] runspaceInfos)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1606,1929,2367);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,2033,2169) || true) && (runspaceInfos == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1606,2033,2169);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,2092,2154);

throw f_1606_2098_2153("runspaceInfos");
DynAbs.Tracing.TraceSender.TraceExitCondition(1606,2033,2169);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,2185,2327) || true) && (f_1606_2189_2215(runspaceInfos, 0)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1606,2185,2327);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,2254,2312);

throw f_1606_2260_2311("runspaceInfos");
DynAbs.Tracing.TraceSender.TraceExitCondition(1606,2185,2327);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,2343,2356);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1606,1929,2367);

System.Management.Automation.PSArgumentNullException
f_1606_2098_2153(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 2098, 2153);
return return_v;
}


int
f_1606_2189_2215(System.Management.Automation.Runspaces.PSSession[]
this_param,int
dimension)
{
var return_v = this_param.GetLength( dimension);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 2189, 2215);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1606_2260_2311(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 2260, 2311);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1606,1929,2367);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1606,1929,2367);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static void CheckRemotingCmdletPrerequisites()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1606,2533,4935);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,2716,2741);

bool 
notSupported = true
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,2755,2833);

string 
WSManKeyPath = "Software\\Microsoft\\Windows\\CurrentVersion\\WSMAN\\"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,2849,2882);

f_1606_2849_2881();

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,3102,3132);

string 
wsManStackValue = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,3150,3220);

RegistryKey 
wsManKey = f_1606_3173_3219(Registry.LocalMachine, WSManKeyPath)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,3238,3386) || true) && (wsManKey != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1606,3238,3386);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,3300,3367);

wsManStackValue = (string)f_1606_3326_3366(wsManKey, "ServiceStackVersion");
DynAbs.Tracing.TraceSender.TraceExitCondition(1606,3238,3386);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,3406,3635);

Version 
wsManStackVersion = (DynAbs.Tracing.TraceSender.Conditional_F1(1606, 3434, 3472)||((!f_1606_3435_3472(wsManStackValue)&&DynAbs.Tracing.TraceSender.Conditional_F2(1606, 3496, 3531))||DynAbs.Tracing.TraceSender.Conditional_F3(1606, 3555, 3634)))?f_1606_3496_3531(f_1606_3508_3530(wsManStackValue)):                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSMAN_STACK_VERSION
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,3717,3841) || true) && (wsManStackVersion >= f_1606_3742_3759(2, 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1606,3717,3841);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,3801,3822);

notSupported = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1606,3717,3841);
}
            }
            catch (FormatException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1606,3870,3961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,3926,3946);

notSupported = true;
DynAbs.Tracing.TraceSender.TraceExitCatch(1606,3870,3961);
            }
            catch (OverflowException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1606,3975,4068);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,4033,4053);

notSupported = true;
DynAbs.Tracing.TraceSender.TraceExitCatch(1606,3975,4068);
            }
            catch (ArgumentException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1606,4082,4175);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,4140,4160);

notSupported = true;
DynAbs.Tracing.TraceSender.TraceExitCatch(1606,4082,4175);
            }
            catch (System.Security.SecurityException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1606,4189,4298);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,4263,4283);

notSupported = true;
DynAbs.Tracing.TraceSender.TraceExitCatch(1606,4189,4298);
            }
            catch (ObjectDisposedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1606,4312,4411);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,4376,4396);

notSupported = true;
DynAbs.Tracing.TraceSender.TraceExitCatch(1606,4312,4411);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,4427,4916) || true) && (notSupported)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1606,4427,4916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,4537,4901);

throw f_1606_4543_4900("Windows PowerShell remoting features are not enabled or not supported on this machine.\nThis may be because you do not have the correct version of WS-Management installed or this version of Windows does not support remoting currently.\n For more information, type 'get-help about_remote_requirements'.");
DynAbs.Tracing.TraceSender.TraceExitCondition(1606,4427,4916);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1606,2533,4935);

int
f_1606_2849_2881()
{
CheckHostRemotingPrerequisites();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 2849, 2881);
return 0;
}


Microsoft.Win32.RegistryKey
f_1606_3173_3219(Microsoft.Win32.RegistryKey
this_param,string
name)
{
var return_v = this_param.OpenSubKey( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 3173, 3219);
return return_v;
}


object
f_1606_3326_3366(Microsoft.Win32.RegistryKey
this_param,string
name)
{
var return_v = this_param.GetValue( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 3326, 3366);
return return_v;
}


bool
f_1606_3435_3472(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 3435, 3472);
return return_v;
}


string
f_1606_3508_3530(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 3508, 3530);
return return_v;
}


System.Version
f_1606_3496_3531(string
version)
{
var return_v = new System.Version( version);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 3496, 3531);
return return_v;
}


System.Version
f_1606_3742_3759(int
major,int
minor)
{
var return_v = new System.Version( major, minor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 3742, 3759);
return return_v;
}


System.InvalidOperationException
f_1606_4543_4900(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 4543, 4900);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1606,2533,4935);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1606,2533,4935);
}
		}

internal static void CheckHostRemotingPrerequisites()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1606,5471,6291);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,5703,5742);

bool 
isWinPEHost = f_1606_5722_5741()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,5756,6280) || true) && (isWinPEHost)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1606,5756,6280);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,6001,6187);

ErrorRecord 
errorRecord = f_1606_6027_6186(f_1606_6043_6141(f_1606_6073_6140(f_1606_6091_6139())), null, ErrorCategory.InvalidOperation, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,6205,6265);

throw f_1606_6211_6264(f_1606_6241_6263(errorRecord));
DynAbs.Tracing.TraceSender.TraceExitCondition(1606,5756,6280);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1606,5471,6291);

bool
f_1606_5722_5741()
{
var return_v = Utils.IsWinPEHost();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 5722, 5741);
return return_v;
}


string
f_1606_6091_6139()
{
var return_v = RemotingErrorIdStrings.WinPERemotingNotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1606, 6091, 6139);
return return_v;
}


string
f_1606_6073_6140(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 6073, 6140);
return return_v;
}


System.InvalidOperationException
f_1606_6043_6141(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 6043, 6141);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1606_6027_6186(System.InvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 6027, 6186);
return return_v;
}


string
f_1606_6241_6263(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 6241, 6263);
return return_v;
}


System.InvalidOperationException
f_1606_6211_6264(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 6211, 6264);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1606,5471,6291);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1606,5471,6291);
}
		}

internal static void CheckPSVersion(Version version)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1606,6303,6950);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,6451,6939) || true) && (version != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1606,6451,6939);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,6579,6924) || true) && (!(f_1606_6585_6598(version)>= 2 &&(DynAbs.Tracing.TraceSender.Expression_True(1606, 6585, 6625)&&f_1606_6607_6620(version)<= 4 )&&(DynAbs.Tracing.TraceSender.Expression_True(1606, 6585, 6647)&&f_1606_6629_6642(version)== 0)) &&(DynAbs.Tracing.TraceSender.Expression_True(1606, 6583, 6716)&&                    !(f_1606_6675_6688(version)== 5 &&(DynAbs.Tracing.TraceSender.Expression_True(1606, 6675, 6715)&&f_1606_6697_6710(version)<= 1))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1606,6579,6924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,6758,6905);

throw f_1606_6764_6904(f_1606_6811_6903(f_1606_6829_6880(), version, "PSVersion"));
DynAbs.Tracing.TraceSender.TraceExitCondition(1606,6579,6924);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1606,6451,6939);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1606,6303,6950);

int
f_1606_6585_6598(System.Version
this_param)
{
var return_v = this_param.Major ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1606, 6585, 6598);
return return_v;
}


int
f_1606_6607_6620(System.Version
this_param)
{
var return_v = this_param.Major ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1606, 6607, 6620);
return return_v;
}


int
f_1606_6629_6642(System.Version
this_param)
{
var return_v = this_param.Minor ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1606, 6629, 6642);
return return_v;
}


int
f_1606_6675_6688(System.Version
this_param)
{
var return_v = this_param.Major ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1606, 6675, 6688);
return return_v;
}


int
f_1606_6697_6710(System.Version
this_param)
{
var return_v = this_param.Minor ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1606, 6697, 6710);
return return_v;
}


string
f_1606_6829_6880()
{
var return_v = RemotingErrorIdStrings.PSVersionParameterOutOfRange;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1606, 6829, 6880);
return return_v;
}


string
f_1606_6811_6903(string
formatSpec,System.Version
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 6811, 6903);
return return_v;
}


System.ArgumentException
f_1606_6764_6904(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 6764, 6904);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1606,6303,6950);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1606,6303,6950);
}
		}

internal static void CheckIfPowerShellVersionIsInstalled(Version version)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1606,7126,8873);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,7277,8862) || true) && (version != null &&(DynAbs.Tracing.TraceSender.Expression_True(1606, 7281, 7318)&&f_1606_7300_7313(version)== 2))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1606,7277,8862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1606,7429,7647);

throw f_1606_7435_7646(f_1606_7479_7645(f_1606_7552_7597(), version, "PSVersion"));
DynAbs.Tracing.TraceSender.TraceExitCondition(1606,7277,8862);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1606,7126,8873);

int
f_1606_7300_7313(System.Version
this_param)
{
var return_v = this_param.Major ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1606, 7300, 7313);
return return_v;
}


string
f_1606_7552_7597()
{
var return_v =                         RemotingErrorIdStrings.PowerShellNotInstalled;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1606, 7552, 7597);
return return_v;
}


string
f_1606_7479_7645(string
resourceString,params object[]
args)
{
var return_v = PSRemotingErrorInvariants.FormatResourceString( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 7479, 7645);
return return_v;
}


System.ArgumentException
f_1606_7435_7646(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1606, 7435, 7646);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1606,7126,8873);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1606,7126,8873);
}
		}

static RemotingCommandUtil()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1606,943,8880);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1606,943,8880);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1606,943,8880);
}

}
}

