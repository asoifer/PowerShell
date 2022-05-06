// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

//
//  Application white listing policies such as AppLocker and DeviceGuard UMCI are only implemented on Windows OSs
//

using System.Management.Automation.Internal;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;

namespace System.Management.Automation.Security
{
    /// <summary>
    /// How the policy is being enforced.
    /// </summary>
    // Internal Note: Current code that consumes this enum assumes that anything but 'Enforce' means
    // that the script is allowed, and that a system lockdown policy that is anything but 'None' means
    // that the API should be called again for individual files. If any elements are added to this enum,
    // callers of the GetLockdownPolicy() should be reviewed.
    public enum SystemEnforcementMode
    {
        /// Not enforced at all
        None = 0,

        /// Enabled - allow, but audit
        Audit = 1,

        /// Enabled, enforce restrictions
        Enforce = 2
    }
public sealed class SystemPolicy
{
private SystemPolicy()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1229,1343,1387);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1229,1343,1387);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1229,1343,1387);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1229,1343,1387);
}
		}

public static SystemEnforcementMode GetSystemLockdownPolicy()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1229,1577,2128);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,1663,2065) || true) && (s_allowDebugOverridePolicy ||(DynAbs.Tracing.TraceSender.Expression_False(1229, 1667, 1729)||(s_systemLockdownPolicy == null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,1663,2065);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,1769,1795);
                lock (s_systemLockdownPolicyLock)
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,1837,2031) || true) && (s_allowDebugOverridePolicy ||(DynAbs.Tracing.TraceSender.Expression_False(1229, 1841, 1903)||(s_systemLockdownPolicy == null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,1837,2031);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,1953,2008);

s_systemLockdownPolicy = f_1229_1978_2007(null, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,1837,2031);
}
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,1663,2065);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,2081,2117);

return f_1229_2088_2116(s_systemLockdownPolicy);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1229,1577,2128);

System.Management.Automation.Security.SystemEnforcementMode
f_1229_1978_2007(string
path,System.Runtime.InteropServices.SafeHandle
handle)
{
var return_v = GetLockdownPolicy( path, handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 1978, 2007);
return return_v;
}


System.Management.Automation.Security.SystemEnforcementMode
f_1229_2088_2116(System.Management.Automation.Security.SystemEnforcementMode?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1229, 2088, 2116);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1229,1577,2128);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1229,1577,2128);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static object s_systemLockdownPolicyLock ;

private static SystemEnforcementMode? s_systemLockdownPolicy ;

private static bool s_allowDebugOverridePolicy ;

public static SystemEnforcementMode GetLockdownPolicy(string path, SafeHandle handle)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1229,2536,4384);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,2697,2746);

var 
wldpFilePolicy = f_1229_2718_2745(path, handle)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,2760,2882) || true) && (wldpFilePolicy == SystemEnforcementMode.Enforce)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,2760,2882);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,2845,2867);

return wldpFilePolicy;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,2760,2882);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,3124,3183);

var 
appLockerFilePolicy = f_1229_3150_3182(path, handle)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,3197,3329) || true) && (appLockerFilePolicy == SystemEnforcementMode.Enforce)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,3197,3329);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,3287,3314);

return appLockerFilePolicy;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,3197,3329);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,3572,3684);

SystemEnforcementMode 
systemWldpPolicy = f_1229_3613_3683(s_cachedWldpSystemPolicy, SystemEnforcementMode.None)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,3698,3894) || true) && ((systemWldpPolicy == SystemEnforcementMode.Audit) ||(DynAbs.Tracing.TraceSender.Expression_False(1229, 3702, 3823)||                (systemWldpPolicy == SystemEnforcementMode.Enforce)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,3698,3894);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,3857,3879);

return wldpFilePolicy;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,3698,3894);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,4050,4237) || true) && (f_1229_4054_4118(s_cachedSaferSystemPolicy, SaferPolicy.Allowed)==
                SaferPolicy.Disallowed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,4050,4237);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,4195,4222);

return appLockerFilePolicy;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,4050,4237);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,4337,4373);

return f_1229_4344_4372(path);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1229,2536,4384);

System.Management.Automation.Security.SystemEnforcementMode
f_1229_2718_2745(string
path,System.Runtime.InteropServices.SafeHandle
handle)
{
var return_v = GetWldpPolicy( path, handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 2718, 2745);
return return_v;
}


System.Management.Automation.Security.SystemEnforcementMode
f_1229_3150_3182(string
path,System.Runtime.InteropServices.SafeHandle
handle)
{
var return_v = GetAppLockerPolicy( path, handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 3150, 3182);
return return_v;
}


System.Management.Automation.Security.SystemEnforcementMode
f_1229_3613_3683(System.Management.Automation.Security.SystemEnforcementMode?
this_param,System.Management.Automation.Security.SystemEnforcementMode
defaultValue)
{
var return_v = this_param.GetValueOrDefault( defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 3613, 3683);
return return_v;
}


System.Management.Automation.Internal.SaferPolicy
f_1229_4054_4118(System.Management.Automation.Internal.SaferPolicy?
this_param,System.Management.Automation.Internal.SaferPolicy
defaultValue)
{
var return_v = this_param.GetValueOrDefault( defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 4054, 4118);
return return_v;
}


System.Management.Automation.Security.SystemEnforcementMode
f_1229_4344_4372(string
path)
{
var return_v = GetDebugLockdownPolicy( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 4344, 4372);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1229,2536,4384);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1229,2536,4384);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods",
            MessageId = "System.Runtime.InteropServices.SafeHandle.DangerousGetHandle")]
        private static SystemEnforcementMode GetWldpPolicy(string path, SafeHandle handle)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1229,4396,7131);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,4809,4964) || true) && (s_hadMissingWldpAssembly)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,4809,4964);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,4871,4949);

return f_1229_4878_4948(s_cachedWldpSystemPolicy, SystemEnforcementMode.None);
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,4809,4964);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,5068,5337) || true) && (f_1229_5072_5098(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,5068,5337);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,5132,5322) || true) && ((s_cachedWldpSystemPolicy != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1229, 5136, 5223)&&(!InternalTestHooks.BypassAppLockerPolicyCaching)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,5132,5322);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,5265,5303);

return f_1229_5272_5302(s_cachedWldpSystemPolicy);
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,5132,5322);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,5068,5337);
}

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,5389,5457);

WLDP_HOST_INFORMATION 
hostInformation = f_1229_5429_5456()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,5475,5555);

hostInformation.dwRevision = WldpNativeConstants.WLDP_HOST_INFORMATION_REVISION;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,5573,5637);

hostInformation.dwHostId = WLDP_HOST_ID.WLDP_HOST_ID_POWERSHELL;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,5657,6058) || true) && (!f_1229_5662_5688(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,5657,6058);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,5730,5762);

hostInformation.szSource = path;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,5786,6039) || true) && (handle != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,5786,6039);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,5854,5886);

IntPtr 
fileHandle = IntPtr.Zero
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,5912,5953);

fileHandle = f_1229_5925_5952(handle);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,5979,6016);

hostInformation.hSource = fileHandle;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,5786,6039);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,5657,6058);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,6078,6104);

uint 
pdwLockdownState = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,6122,6221);

int 
result = f_1229_6135_6220(ref hostInformation, ref pdwLockdownState, 0)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,6239,6887) || true) && (result >= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,6239,6887);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,6296,6389);

SystemEnforcementMode 
resultingLockdownPolicy = f_1229_6344_6388(pdwLockdownState)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,6503,6657) || true) && (f_1229_6507_6533(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,6503,6657);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,6583,6634);

s_cachedWldpSystemPolicy = resultingLockdownPolicy;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,6503,6657);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,6681,6712);

return resultingLockdownPolicy;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,6239,6887);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,6239,6887);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,6831,6868);

return SystemEnforcementMode.Enforce;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,6239,6887);
}
            }
            catch (DllNotFoundException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1229,6916,7120);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,6977,7009);

s_hadMissingWldpAssembly = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,7027,7105);

return f_1229_7034_7104(s_cachedWldpSystemPolicy, SystemEnforcementMode.None);
DynAbs.Tracing.TraceSender.TraceExitCatch(1229,6916,7120);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1229,4396,7131);

System.Management.Automation.Security.SystemEnforcementMode
f_1229_4878_4948(System.Management.Automation.Security.SystemEnforcementMode?
this_param,System.Management.Automation.Security.SystemEnforcementMode
defaultValue)
{
var return_v = this_param.GetValueOrDefault( defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 4878, 4948);
return return_v;
}


bool
f_1229_5072_5098(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 5072, 5098);
return return_v;
}


System.Management.Automation.Security.SystemEnforcementMode
f_1229_5272_5302(System.Management.Automation.Security.SystemEnforcementMode?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1229, 5272, 5302);
return return_v;
}


System.Management.Automation.Security.SystemPolicy.WLDP_HOST_INFORMATION
f_1229_5429_5456()
{
var return_v = new System.Management.Automation.Security.SystemPolicy.WLDP_HOST_INFORMATION();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 5429, 5456);
return return_v;
}


bool
f_1229_5662_5688(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 5662, 5688);
return return_v;
}


System.IntPtr
f_1229_5925_5952(System.Runtime.InteropServices.SafeHandle
this_param)
{
var return_v = this_param.DangerousGetHandle();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 5925, 5952);
return return_v;
}


int
f_1229_6135_6220(ref System.Management.Automation.Security.SystemPolicy.WLDP_HOST_INFORMATION
pHostInformation,ref uint
pdwLockdownState,int
dwFlags)
{
var return_v = WldpNativeMethods.WldpGetLockdownPolicy( ref pHostInformation, ref pdwLockdownState, (uint)dwFlags);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 6135, 6220);
return return_v;
}


System.Management.Automation.Security.SystemEnforcementMode
f_1229_6344_6388(uint
pdwLockdownState)
{
var return_v = GetLockdownPolicyForResult( pdwLockdownState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 6344, 6388);
return return_v;
}


bool
f_1229_6507_6533(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 6507, 6533);
return return_v;
}


System.Management.Automation.Security.SystemEnforcementMode
f_1229_7034_7104(System.Management.Automation.Security.SystemEnforcementMode?
this_param,System.Management.Automation.Security.SystemEnforcementMode
defaultValue)
{
var return_v = this_param.GetValueOrDefault( defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 7034, 7104);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1229,4396,7131);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1229,4396,7131);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static SystemEnforcementMode? s_cachedWldpSystemPolicy ;

private const string 
AppLockerTestFileName = "__PSScriptPolicyTest_"
;

private const string 
AppLockerTestFileContents = "# PowerShell test file to determine AppLocker lockdown mode "
;

private static SystemEnforcementMode GetAppLockerPolicy(string path, SafeHandle handle)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1229,7426,13922);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,7538,7582);

SaferPolicy 
result = SaferPolicy.Disallowed
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,7915,13911) || true) && (f_1229_7919_7945(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,7915,13911);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,7979,13232) || true) && ((s_cachedSaferSystemPolicy != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1229, 7983, 8071)&&(!InternalTestHooks.BypassAppLockerPolicyCaching)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,7979,13232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,8113,8154);

result = f_1229_8122_8153(s_cachedSaferSystemPolicy);
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,7979,13232);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,7979,13232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,8615,8644);

string 
testPathScript = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,8666,8695);

string 
testPathModule = null
;
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,8839,8879);

string 
tempPath = f_1229_8857_8878()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,8907,8925);

int 
iteration = 0
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,8951,11327) || true) && (iteration++ < 2)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,8951,11327);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,9031,9050);

bool 
error = false
;

                            try
                            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,9150,9332) || true) && (!f_1229_9155_9184(tempPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,9150,9332);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,9258,9297);

f_1229_9258_9296(tempPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,9150,9332);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,9368,9473);

testPathScript = f_1229_9385_9472(tempPath, AppLockerTestFileName + f_1229_9435_9462()+ ".ps1");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,9507,9613);

testPathModule = f_1229_9524_9612(tempPath, AppLockerTestFileName + f_1229_9574_9601()+ ".psm1");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,9838,9916);

string 
dtAppLockerTestFileContents = AppLockerTestFileContents + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (DateTime.Now).ToString(),1229,9903,9915)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,9950,10016);

f_1229_9950_10015(testPathScript, dtAppLockerTestFileContents);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,10050,10116);

f_1229_10050_10115(testPathModule, dtAppLockerTestFileContents);
                            }
                            catch (System.IO.IOException)
                            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1229,10177,10375);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,10271,10297) || true) && (iteration == 2)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,10271,10297);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,10291,10297);

throw;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,10271,10297);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,10331,10344);

error = true;
DynAbs.Tracing.TraceSender.TraceExitCatch(1229,10177,10375);
                            }
                            catch (System.UnauthorizedAccessException)
                            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1229,10405,10616);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,10512,10538) || true) && (iteration == 2)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,10512,10538);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,10532,10538);

throw;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,10512,10538);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,10572,10585);

error = true;
DynAbs.Tracing.TraceSender.TraceExitCatch(1229,10405,10616);
                            }
                            catch (System.Security.SecurityException)
                            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1229,10646,10856);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,10752,10778) || true) && (iteration == 2)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,10752,10778);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,10772,10778);

throw;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,10752,10778);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,10812,10825);

error = true;
DynAbs.Tracing.TraceSender.TraceExitCatch(1229,10646,10856);
                            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,10888,10910) || true) && (!error)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,10888,10910);
DynAbs.Tracing.TraceSender.TraceBreak(1229,10902,10908);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,10888,10910);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,11124,11204);

Guid 
AppDatalocalLowFolderId = f_1229_11155_11203("A520A1A4-1780-4FF6-BD18-167343C5AF16")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,11234,11300);

tempPath = f_1229_11245_11288(AppDatalocalLowFolderId)+ @"\Temp";
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,8951,11327);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1229,8951,11327);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1229,8951,11327);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,11396,11453);

result = f_1229_11405_11452(testPathScript, testPathModule);
                    }
                    catch (System.IO.IOException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1229,11498,11710);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,11655,11687);

result = SaferPolicy.Disallowed;
DynAbs.Tracing.TraceSender.TraceExitCatch(1229,11498,11710);
                    }
                    catch (System.UnauthorizedAccessException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1229,11732,12299);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,12019,12276);

result =
(DynAbs.Tracing.TraceSender.Conditional_F1(1229, 12057, 12199)||((                            (f_1229_12058_12131(f_1229_12058_12112())== System.Security.Principal.TokenImpersonationLevel.Impersonation) &&DynAbs.Tracing.TraceSender.Conditional_F2(1229, 12231, 12250))||DynAbs.Tracing.TraceSender.Conditional_F3(1229, 12253, 12275)))?                            SaferPolicy.Allowed :SaferPolicy.Disallowed;
DynAbs.Tracing.TraceSender.TraceExitCatch(1229,11732,12299);
                    }
                    catch (ArgumentException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1229,12321,12776);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,12498,12753);

result =
(DynAbs.Tracing.TraceSender.Conditional_F1(1229, 12535, 12677)||((                           (f_1229_12536_12609(f_1229_12536_12590())== System.Security.Principal.TokenImpersonationLevel.Impersonation) &&DynAbs.Tracing.TraceSender.Conditional_F2(1229, 12708, 12727))||DynAbs.Tracing.TraceSender.Conditional_F3(1229, 12730, 12752)))?                           SaferPolicy.Allowed :SaferPolicy.Disallowed;
DynAbs.Tracing.TraceSender.TraceExitCatch(1229,12321,12776);
                    }
                    finally
                    {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1229,12798,13154);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,13025,13065);

f_1229_13025_13064(testPathScript);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,13091,13131);

f_1229_13091_13130(testPathModule);
DynAbs.Tracing.TraceSender.TraceExitFinally(1229,12798,13154);
                    }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,13178,13213);

s_cachedSaferSystemPolicy = result;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,7979,13232);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,13252,13502) || true) && (result == SaferPolicy.Disallowed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,13252,13502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,13330,13367);

return SystemEnforcementMode.Enforce;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,13252,13502);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,13252,13502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,13449,13483);

return SystemEnforcementMode.None;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,13252,13502);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,7915,13911);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,7915,13911);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,13636,13690);

result = f_1229_13645_13689(path, handle);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,13708,13842) || true) && (result == SaferPolicy.Disallowed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,13708,13842);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,13786,13823);

return SystemEnforcementMode.Enforce;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,13708,13842);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,13862,13896);

return SystemEnforcementMode.None;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,7915,13911);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1229,7426,13922);

bool
f_1229_7919_7945(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 7919, 7945);
return return_v;
}


System.Management.Automation.Internal.SaferPolicy
f_1229_8122_8153(System.Management.Automation.Internal.SaferPolicy?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1229, 8122, 8153);
return return_v;
}


string
f_1229_8857_8878()
{
var return_v = IO.Path.GetTempPath();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 8857, 8878);
return return_v;
}


bool
f_1229_9155_9184(string
path)
{
var return_v = IO.Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 9155, 9184);
return return_v;
}


System.IO.DirectoryInfo
f_1229_9258_9296(string
path)
{
var return_v = IO.Directory.CreateDirectory( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 9258, 9296);
return return_v;
}


string
f_1229_9435_9462()
{
var return_v = IO.Path.GetRandomFileName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 9435, 9462);
return return_v;
}


string
f_1229_9385_9472(string
path1,string
path2)
{
var return_v = IO.Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 9385, 9472);
return return_v;
}


string
f_1229_9574_9601()
{
var return_v = IO.Path.GetRandomFileName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 9574, 9601);
return return_v;
}


string
f_1229_9524_9612(string
path1,string
path2)
{
var return_v = IO.Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 9524, 9612);
return return_v;
}


int
f_1229_9950_10015(string
path,string
contents)
{
IO.File.WriteAllText( path, contents);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 9950, 10015);
return 0;
}


int
f_1229_10050_10115(string
path,string
contents)
{
IO.File.WriteAllText( path, contents);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 10050, 10115);
return 0;
}


System.Guid
f_1229_11155_11203(string
g)
{
var return_v = new System.Guid( g);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 11155, 11203);
return return_v;
}


string
f_1229_11245_11288(System.Guid
knownFolderId)
{
var return_v = GetKnownFolderPath( knownFolderId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 11245, 11288);
return return_v;
}


System.Management.Automation.Internal.SaferPolicy
f_1229_11405_11452(string
testPathScript,string
testPathModule)
{
var return_v = TestSaferPolicy( testPathScript, testPathModule);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 11405, 11452);
return return_v;
}


System.Security.Principal.WindowsIdentity
f_1229_12058_12112()
{
var return_v = System.Security.Principal.WindowsIdentity.GetCurrent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 12058, 12112);
return return_v;
}


System.Security.Principal.TokenImpersonationLevel
f_1229_12058_12131(System.Security.Principal.WindowsIdentity
this_param)
{
var return_v = this_param.ImpersonationLevel ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1229, 12058, 12131);
return return_v;
}


System.Security.Principal.WindowsIdentity
f_1229_12536_12590()
{
var return_v = System.Security.Principal.WindowsIdentity.GetCurrent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 12536, 12590);
return return_v;
}


System.Security.Principal.TokenImpersonationLevel
f_1229_12536_12609(System.Security.Principal.WindowsIdentity
this_param)
{
var return_v = this_param.ImpersonationLevel ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1229, 12536, 12609);
return return_v;
}


bool
f_1229_13025_13064(string
filepath)
{
var return_v = PathUtils.TryDeleteFile( filepath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 13025, 13064);
return return_v;
}


bool
f_1229_13091_13130(string
filepath)
{
var return_v = PathUtils.TryDeleteFile( filepath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 13091, 13130);
return return_v;
}


System.Management.Automation.Internal.SaferPolicy
f_1229_13645_13689(string
path,System.Runtime.InteropServices.SafeHandle
handle)
{
var return_v = SecuritySupport.GetSaferPolicy( path, handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 13645, 13689);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1229,7426,13922);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1229,7426,13922);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static SaferPolicy? s_cachedSaferSystemPolicy ;

private static string GetKnownFolderPath(Guid knownFolderId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1229,14007,14660);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,14092,14121);

IntPtr 
pszPath = IntPtr.Zero
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,14171,14263);

int 
hr = f_1229_14180_14262(knownFolderId, 0, IntPtr.Zero, out pszPath)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,14281,14393) || true) && (hr >= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,14281,14393);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,14334,14374);

return f_1229_14341_14373(pszPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,14281,14393);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,14413,14447);

throw f_1229_14419_14446();
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1229,14476,14649);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,14516,14634) || true) && (pszPath != IntPtr.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,14516,14634);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,14584,14615);

f_1229_14584_14614(pszPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,14516,14634);
}
DynAbs.Tracing.TraceSender.TraceExitFinally(1229,14476,14649);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1229,14007,14660);

int
f_1229_14180_14262(System.Guid
rfid,int
dwFlags,System.IntPtr
hToken,out System.IntPtr
pszPath)
{
var return_v = WldpNativeMethods.SHGetKnownFolderPath( rfid, dwFlags, hToken, out pszPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 14180, 14262);
return return_v;
}


string?
f_1229_14341_14373(System.IntPtr
ptr)
{
var return_v = Marshal.PtrToStringAuto( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 14341, 14373);
return return_v;
}


System.IO.IOException
f_1229_14419_14446()
{
var return_v = new System.IO.IOException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 14419, 14446);
return return_v;
}


int
f_1229_14584_14614(System.IntPtr
ptr)
{
Marshal.FreeCoTaskMem( ptr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 14584, 14614);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1229,14007,14660);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1229,14007,14660);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static SaferPolicy TestSaferPolicy(string testPathScript, string testPathModule)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1229,14672,15061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,14785,14859);

SaferPolicy 
result = f_1229_14806_14858(testPathScript, null)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,14873,15020) || true) && (result == SaferPolicy.Disallowed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,14873,15020);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,14943,15005);

result = f_1229_14952_15004(testPathModule, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,14873,15020);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,15036,15050);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1229,14672,15061);

System.Management.Automation.Internal.SaferPolicy
f_1229_14806_14858(string
path,System.Runtime.InteropServices.SafeHandle
handle)
{
var return_v = SecuritySupport.GetSaferPolicy( path, handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 14806, 14858);
return return_v;
}


System.Management.Automation.Internal.SaferPolicy
f_1229_14952_15004(string
path,System.Runtime.InteropServices.SafeHandle
handle)
{
var return_v = SecuritySupport.GetSaferPolicy( path, handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 14952, 15004);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1229,14672,15061);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1229,14672,15061);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static SystemEnforcementMode GetDebugLockdownPolicy(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1229,15073,17802);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,15170,15204);

s_allowDebugOverridePolicy = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,15306,17178) || true) && (path != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,15306,17178);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,15537,15701) || true) && (f_1229_15541_15601(path, "System32", StringComparison.OrdinalIgnoreCase)>= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,15537,15701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,15648,15682);

return SystemEnforcementMode.None;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,15537,15701);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,15721,16940);
using(RegistryKey 
hklm = f_1229_15747_15819(RegistryHive.LocalMachine, RegistryView.Default)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,15861,16921);
using(RegistryKey 
wldpPolicy = f_1229_15893_15959(hklm, "SYSTEM\\CurrentControlSet\\Control\\CI\\TRSData")
)                    {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,16009,16898) || true) && (wldpPolicy != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,16009,16898);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,16089,16148);

object 
exclusionPathsKey = f_1229_16116_16147(wldpPolicy, "TestPath")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,16180,16199);

f_1229_16180_16198(
                            wldpPolicy);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,16229,16242);

f_1229_16229_16241(                            hklm);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,16274,16871) || true) && (exclusionPathsKey != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,16274,16871);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,16369,16423);

string[] 
exclusionPaths = (string[])exclusionPathsKey
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,16457,16840);
foreach(string exclusionPath in f_1229_16490_16504_I(exclusionPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,16457,16840);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,16578,16805) || true) && (f_1229_16582_16645(path, exclusionPath, StringComparison.OrdinalIgnoreCase)>= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,16578,16805);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,16732,16766);

return SystemEnforcementMode.None;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,16578,16805);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,16457,16840);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1229,1,384);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1229,1,384);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1229,16274,16871);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,16009,16898);
}
DynAbs.Tracing.TraceSender.TraceExitUsing(1229,15861,16921);
                    }
DynAbs.Tracing.TraceSender.TraceExitUsing(1229,15721,16940);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,17087,17163);

return f_1229_17094_17162(s_systemLockdownPolicy, SystemEnforcementMode.None);
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,15306,17178);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,17283,17309);

uint 
pdwLockdownState = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,17323,17431);

object 
result = f_1229_17339_17430("__PSLockdownPolicy", EnvironmentVariableTarget.Machine)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,17445,17644) || true) && (result != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,17445,17644);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,17497,17559);

pdwLockdownState = f_1229_17516_17558(result);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,17577,17629);

return f_1229_17584_17628(pdwLockdownState);
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,17445,17644);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,17757,17791);

return SystemEnforcementMode.None;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1229,15073,17802);

int
f_1229_15541_15601(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.IndexOf( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 15541, 15601);
return return_v;
}


Microsoft.Win32.RegistryKey
f_1229_15747_15819(Microsoft.Win32.RegistryHive
hKey,Microsoft.Win32.RegistryView
view)
{
var return_v = RegistryKey.OpenBaseKey( hKey, view);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 15747, 15819);
return return_v;
}


Microsoft.Win32.RegistryKey
f_1229_15893_15959(Microsoft.Win32.RegistryKey
this_param,string
name)
{
var return_v = this_param.OpenSubKey( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 15893, 15959);
return return_v;
}


object
f_1229_16116_16147(Microsoft.Win32.RegistryKey
this_param,string
name)
{
var return_v = this_param.GetValue( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 16116, 16147);
return return_v;
}


int
f_1229_16180_16198(Microsoft.Win32.RegistryKey
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 16180, 16198);
return 0;
}


int
f_1229_16229_16241(Microsoft.Win32.RegistryKey
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 16229, 16241);
return 0;
}


int
f_1229_16582_16645(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.IndexOf( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 16582, 16645);
return return_v;
}


string[]
f_1229_16490_16504_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 16490, 16504);
return return_v;
}


System.Management.Automation.Security.SystemEnforcementMode
f_1229_17094_17162(System.Management.Automation.Security.SystemEnforcementMode?
this_param,System.Management.Automation.Security.SystemEnforcementMode
defaultValue)
{
var return_v = this_param.GetValueOrDefault( defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 17094, 17162);
return return_v;
}


string?
f_1229_17339_17430(string
variable,System.EnvironmentVariableTarget
target)
{
var return_v = Environment.GetEnvironmentVariable( variable, target);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 17339, 17430);
return return_v;
}


uint
f_1229_17516_17558(object
valueToConvert)
{
var return_v = LanguagePrimitives.ConvertTo<uint>( valueToConvert);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 17516, 17558);
return return_v;
}


System.Management.Automation.Security.SystemEnforcementMode
f_1229_17584_17628(uint
pdwLockdownState)
{
var return_v = GetLockdownPolicyForResult( pdwLockdownState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 17584, 17628);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1229,15073,17802);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1229,15073,17802);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool s_hadMissingWldpAssembly ;

internal static bool IsClassInApprovedList(Guid clsid)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1229,18072,20061);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,18187,18255);

WLDP_HOST_INFORMATION 
hostInformation = f_1229_18227_18254()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,18273,18353);

hostInformation.dwRevision = WldpNativeConstants.WLDP_HOST_INFORMATION_REVISION;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,18371,18435);

hostInformation.dwHostId = WLDP_HOST_ID.WLDP_HOST_ID_POWERSHELL;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,18455,18475);

int 
pIsApproved = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,18493,18602);

int 
result = f_1229_18506_18601(ref clsid, ref hostInformation, ref pIsApproved, 0)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,18622,19409) || true) && (result >= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,18622,19409);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,18679,19390) || true) && (pIsApproved == 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,18679,19390);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,18991,19327) || true) && (s_allowDebugOverridePolicy)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,18991,19327);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,19079,19300) || true) && (f_1229_19083_19190(clsid.ToString(), "0000050b-0000-0010-8000-00aa006d2ea4", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,19079,19300);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,19256,19269);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,19079,19300);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,18991,19327);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,19355,19367);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,18679,19390);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,18622,19409);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,19429,19442);

return false;
            }
            catch (DllNotFoundException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1229,19471,20050);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,19818,20002) || true) && (f_1229_19822_19929(clsid.ToString(), "f6d90f11-9c73-11d3-b32e-00c04f990bb4", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,19818,20002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,19971,19983);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,19818,20002);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,20022,20035);

return false;
DynAbs.Tracing.TraceSender.TraceExitCatch(1229,19471,20050);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1229,18072,20061);

System.Management.Automation.Security.SystemPolicy.WLDP_HOST_INFORMATION
f_1229_18227_18254()
{
var return_v = new System.Management.Automation.Security.SystemPolicy.WLDP_HOST_INFORMATION();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 18227, 18254);
return return_v;
}


int
f_1229_18506_18601(ref System.Guid
rclsid,ref System.Management.Automation.Security.SystemPolicy.WLDP_HOST_INFORMATION
pHostInformation,ref int
ptIsApproved,int
dwFlags)
{
var return_v = WldpNativeMethods.WldpIsClassInApprovedList( ref rclsid, ref pHostInformation, ref ptIsApproved, (uint)dwFlags);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 18506, 18601);
return return_v;
}


bool
f_1229_19083_19190(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 19083, 19190);
return return_v;
}


bool
f_1229_19822_19929(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 19822, 19929);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1229,18072,20061);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1229,18072,20061);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static SystemEnforcementMode GetLockdownPolicyForResult(uint pdwLockdownState)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1229,20073,20785);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,20184,20774) || true) && ((pdwLockdownState & WldpNativeConstants.WLDP_LOCKDOWN_UMCIAUDIT_FLAG) ==
                SystemPolicy.WldpNativeConstants.WLDP_LOCKDOWN_UMCIAUDIT_FLAG)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,20184,20774);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,20373,20408);

return SystemEnforcementMode.Audit;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,20184,20774);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,20184,20774);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,20442,20774) || true) && ((pdwLockdownState & WldpNativeConstants.WLDP_LOCKDOWN_UMCIENFORCE_FLAG) ==
                WldpNativeConstants.WLDP_LOCKDOWN_UMCIENFORCE_FLAG)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,20442,20774);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,20622,20659);

return SystemEnforcementMode.Enforce;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,20442,20774);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,20442,20774);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,20725,20759);

return SystemEnforcementMode.None;
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,20442,20774);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,20184,20774);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1229,20073,20785);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1229,20073,20785);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1229,20073,20785);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string DumpLockdownState(uint pdwLockdownState)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1229,20797,22174);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,20885,20919);

string 
returnValue = string.Empty
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,20935,21153) || true) && ((pdwLockdownState & WldpNativeConstants.WLDP_LOCKDOWN_DEFINED_FLAG) == WldpNativeConstants.WLDP_LOCKDOWN_DEFINED_FLAG)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,20935,21153);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,21090,21138);

returnValue += "WLDP_LOCKDOWN_DEFINED_FLAG\r\n";
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,20935,21153);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,21169,21396) || true) && ((pdwLockdownState & WldpNativeConstants.WLDP_LOCKDOWN_SECUREBOOT_FLAG) == WldpNativeConstants.WLDP_LOCKDOWN_SECUREBOOT_FLAG)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,21169,21396);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,21330,21381);

returnValue += "WLDP_LOCKDOWN_SECUREBOOT_FLAG\r\n";
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,21169,21396);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,21412,21642) || true) && ((pdwLockdownState & WldpNativeConstants.WLDP_LOCKDOWN_DEBUGPOLICY_FLAG) == WldpNativeConstants.WLDP_LOCKDOWN_DEBUGPOLICY_FLAG)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,21412,21642);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,21575,21627);

returnValue += "WLDP_LOCKDOWN_DEBUGPOLICY_FLAG\r\n";
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,21412,21642);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,21658,21888) || true) && ((pdwLockdownState & WldpNativeConstants.WLDP_LOCKDOWN_UMCIENFORCE_FLAG) == WldpNativeConstants.WLDP_LOCKDOWN_UMCIENFORCE_FLAG)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,21658,21888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,21821,21873);

returnValue += "WLDP_LOCKDOWN_UMCIENFORCE_FLAG\r\n";
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,21658,21888);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,21904,22128) || true) && ((pdwLockdownState & WldpNativeConstants.WLDP_LOCKDOWN_UMCIAUDIT_FLAG) == WldpNativeConstants.WLDP_LOCKDOWN_UMCIAUDIT_FLAG)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1229,21904,22128);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,22063,22113);

returnValue += "WLDP_LOCKDOWN_UMCIAUDIT_FLAG\r\n";
DynAbs.Tracing.TraceSender.TraceExitCondition(1229,21904,22128);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,22144,22163);

return returnValue;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1229,20797,22174);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1229,20797,22174);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1229,20797,22174);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool XamlWorkflowSupported {get; set; }
internal class WldpNativeConstants
{
internal const uint 
WLDP_HOST_INFORMATION_REVISION = 0x00000001
;

internal const uint 
WLDP_LOCKDOWN_UNDEFINED = 0
;

internal const uint 
WLDP_LOCKDOWN_DEFINED_FLAG = 0x80000000
;

internal const uint 
WLDP_LOCKDOWN_SECUREBOOT_FLAG = 1
;

internal const uint 
WLDP_LOCKDOWN_DEBUGPOLICY_FLAG = 2
;

internal const uint 
WLDP_LOCKDOWN_UMCIENFORCE_FLAG = 4
;

internal const uint 
WLDP_LOCKDOWN_UMCIAUDIT_FLAG = 8
;

public WldpNativeConstants()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1229,22446,22991);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1229,22446,22991);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1229,22446,22991);
}


static WldpNativeConstants()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1229,22446,22991);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,22525,22568);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,22605,22632);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,22667,22706);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,22741,22774);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,22809,22843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,22878,22912);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,22947,22979);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1229,22446,22991);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1229,22446,22991);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1229,22446,22991);
}

        /// <summary>
        /// The different host IDs understood by the lockdown policy.
        /// </summary>
        internal enum WLDP_HOST_ID
        {
            WLDP_HOST_ID_UNKNOWN = 0,
            WLDP_HOST_ID_GLOBAL = 1,
            WLDP_HOST_ID_VBA = 2,
            WLDP_HOST_ID_WSH = 3,
            WLDP_HOST_ID_POWERSHELL = 4,
            WLDP_HOST_ID_IE = 5,
            WLDP_HOST_ID_MSI = 6,
            WLDP_HOST_ID_MAX = 7,
        }

[StructLayoutAttribute(LayoutKind.Sequential)]
        internal struct WLDP_HOST_INFORMATION
        {

internal uint dwRevision;

internal WLDP_HOST_ID dwHostId;

[MarshalAsAttribute(UnmanagedType.LPWStr)]
            internal string szSource;

internal IntPtr hSource;
static WLDP_HOST_INFORMATION(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1229,23601,24084);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1229,23601,24084);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1229,23601,24084);
}
        }
internal class WldpNativeMethods
{
[DefaultDllImportSearchPathsAttribute(DllImportSearchPath.System32)]
            [DllImportAttribute("wldp.dll", EntryPoint = "WldpGetLockdownPolicy")]
            internal static extern int WldpGetLockdownPolicy(ref WLDP_HOST_INFORMATION pHostInformation, ref uint pdwLockdownState, uint dwFlags);

[DefaultDllImportSearchPathsAttribute(DllImportSearchPath.System32)]
            [DllImportAttribute("wldp.dll", EntryPoint = "WldpIsClassInApprovedList")]
            internal static extern int WldpIsClassInApprovedList(ref Guid rclsid, ref WLDP_HOST_INFORMATION pHostInformation, ref int ptIsApproved, uint dwFlags);

[DllImport("shell32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            internal static extern int SHGetKnownFolderPath(
                [MarshalAs(UnmanagedType.LPStruct)]
                Guid rfid,
                int dwFlags,
                IntPtr hToken,
                out IntPtr pszPath);

public WldpNativeMethods()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1229,24209,25726);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1229,24209,25726);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1229,24209,25726);
}


static WldpNativeMethods()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1229,24209,25726);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1229,24209,25726);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1229,24209,25726);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1229,24209,25726);
}

static SystemPolicy()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1229,1294,25733);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,2162,2203);
s_systemLockdownPolicyLock = f_1229_2191_2203();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,2252,2281);
s_systemLockdownPolicy = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,2312,2346);
s_allowDebugOverridePolicy = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,7181,7212);
s_cachedWldpSystemPolicy = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,7246,7293);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,7325,7415);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,13962,13994);
s_cachedSaferSystemPolicy = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,17834,17866);
s_hadMissingWldpAssembly = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1229,22263,22319);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1229,1294,25733);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1229,1294,25733);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1229,1294,25733);

static object
f_1229_2191_2203()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1229, 2191, 2203);
return return_v;
}

}
}

