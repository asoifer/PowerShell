// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Management.Automation.Remoting;
using System.Management.Automation.Remoting.Client;
using System.Management.Automation.Runspaces;

using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell.Commands
{
public abstract partial class PSRemotingCmdlet : PSCmdlet
{
protected override void BeginProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,1186,1386);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,1252,1375) || true) && (f_1602_1256_1271_M(!SkipWinRMCheck))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,1252,1375);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,1305,1360);

f_1602_1305_1359();
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,1252,1375);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,1186,1386);

bool
f_1602_1256_1271_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 1256, 1271);
return return_v;
}


int
f_1602_1305_1359()
{
RemotingCommandUtil.CheckRemotingCmdletPrerequisites();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 1305, 1359);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,1186,1386);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,1186,1386);
}
		}

internal void WriteStreamObject(Action<Cmdlet> action)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,1616,1719);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,1695,1708);

f_1602_1695_1707(action, this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,1616,1719);

int
f_1602_1695_1707(System.Action<System.Management.Automation.Cmdlet>
this_param,Microsoft.PowerShell.Commands.PSRemotingCmdlet
obj)
{
this_param.Invoke( (System.Management.Automation.Cmdlet)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 1695, 1707);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,1616,1719);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,1616,1719);
}
		}

protected void ResolveComputerNames(string[] computerNames, out string[] resolvedComputerNames)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,2073,2853);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,2193,2842) || true) && (computerNames == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,2193,2842);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,2252,2290);

resolvedComputerNames = new string[1];
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,2310,2362);

resolvedComputerNames[0] = f_1602_2337_2361(this, ".");
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,2193,2842);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,2193,2842);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,2396,2842) || true) && (f_1602_2400_2420(computerNames)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,2396,2842);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,2459,2505);

resolvedComputerNames = f_1602_2483_2504();
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,2396,2842);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,2396,2842);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,2571,2628);

resolvedComputerNames = new string[f_1602_2606_2626(computerNames)];
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,2657,2662);

                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,2648,2827) || true) && (i < f_1602_2668_2696(resolvedComputerNames))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,2698,2701)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1602,2648,2827))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,2648,2827);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,2743,2808);

resolvedComputerNames[i] = f_1602_2770_2807(this, computerNames[i]);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,180);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,180);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1602,2396,2842);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,2193,2842);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,2073,2853);

string
f_1602_2337_2361(Microsoft.PowerShell.Commands.PSRemotingCmdlet
this_param,string
computerName)
{
var return_v = this_param.ResolveComputerName( computerName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 2337, 2361);
return return_v;
}


int
f_1602_2400_2420(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 2400, 2420);
return return_v;
}


string[]
f_1602_2483_2504()
{
var return_v = Array.Empty<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 2483, 2504);
return return_v;
}


int
f_1602_2606_2626(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 2606, 2626);
return return_v;
}


int
f_1602_2668_2696(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 2668, 2696);
return return_v;
}


string
f_1602_2770_2807(Microsoft.PowerShell.Commands.PSRemotingCmdlet
this_param,string
computerName)
{
var return_v = this_param.ResolveComputerName( computerName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 2770, 2807);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,2073,2853);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,2073,2853);
}
		}

protected string ResolveComputerName(string computerName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,3144,3794);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,3226,3288);

f_1602_3226_3287(computerName != null, "Null ComputerName");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,3304,3783) || true) && (f_1602_3308_3376(computerName, ".", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,3304,3783);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,3663,3682);

return s_LOCALHOST;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,3304,3783);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,3304,3783);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,3748,3768);

return computerName;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,3304,3783);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,3144,3794);

int
f_1602_3226_3287(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 3226, 3287);
return 0;
}


bool
f_1602_3308_3376(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 3308, 3376);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,3144,3794);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,3144,3794);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal string GetMessage(string resourceString)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,4162,4328);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,4236,4286);

string 
message = f_1602_4253_4285(this, resourceString, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,4302,4317);

return message;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,4162,4328);

string
f_1602_4253_4285(Microsoft.PowerShell.Commands.PSRemotingCmdlet
this_param,string
resourceString,params object[]
args)
{
var return_v = this_param.GetMessage( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 4253, 4285);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,4162,4328);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,4162,4328);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal string GetMessage(string resourceString, params object[] args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,4512,4887);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,4608,4623);

string 
message
=default(string);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,4639,4845) || true) && (args != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,4639,4845);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,4689,4739);

message = f_1602_4699_4738(resourceString, args);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,4639,4845);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,4639,4845);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,4805,4830);

message = resourceString;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,4639,4845);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,4861,4876);

return message;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,4512,4887);

string
f_1602_4699_4738(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 4699, 4738);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,4512,4887);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,4512,4887);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static string s_LOCALHOST ;

protected const string 
ComputerNameParameterSet = "ComputerName"
;

protected const string 
ComputerInstanceIdParameterSet = "ComputerInstanceId"
;

protected const string 
ContainerIdParameterSet = "ContainerId"
;

protected const string 
VMIdParameterSet = "VMId"
;

protected const string 
VMNameParameterSet = "VMName"
;

protected const string 
SSHHostParameterSet = "SSHHost"
;

protected const string 
SSHHostHashParameterSet = "SSHHostHashParam"
;

protected const string 
SessionParameterSet = "Session"
;

protected const string 
UseWindowsPowerShellParameterSet = "UseWindowsPowerShellParameterSet"
;

protected const string 
DefaultPowerShellRemoteShellName = System.Management.Automation.Remoting.Client.WSManNativeApi.ResourceURIPrefix + "Microsoft.PowerShell"
;

protected const string 
DefaultPowerShellRemoteShellAppName = "WSMan"
;

internal bool SkipWinRMCheck {get; set; }

protected string ResolveShell(string shell)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,7805,8315);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,7873,7894);

string 
resolvedShell
=default(string);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,7910,8267) || true) && (!f_1602_7915_7942(shell))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,7910,8267);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,7976,7998);

resolvedShell = shell;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,7910,8267);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,7910,8267);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,8064,8252);

resolvedShell = (string)f_1602_8088_8251(f_1602_8088_8126(f_1602_8088_8109(f_1602_8088_8100())), SpecialVariables.PSSessionConfigurationNameVarPath, DefaultPowerShellRemoteShellName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,7910,8267);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,8283,8304);

return resolvedShell;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,7805,8315);

bool
f_1602_7915_7942(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 7915, 7942);
return return_v;
}


System.Management.Automation.SessionState
f_1602_8088_8100()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 8088, 8100);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1602_8088_8109(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Internal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 8088, 8109);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1602_8088_8126(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 8088, 8126);
return return_v;
}


object
f_1602_8088_8251(System.Management.Automation.ExecutionContext
this_param,System.Management.Automation.VariablePath
path,string
defaultValue)
{
var return_v = this_param.GetVariableValue( path, (object)defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 8088, 8251);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,7805,8315);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,7805,8315);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected string ResolveAppName(string appName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,8702,9250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,8774,8797);

string 
resolvedAppName
=default(string);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,8813,9200) || true) && (!f_1602_8818_8847(appName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,8813,9200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,8881,8907);

resolvedAppName = appName;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,8813,9200);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,8813,9200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,8973,9185);

resolvedAppName = (string)f_1602_8999_9184(f_1602_8999_9037(f_1602_8999_9020(f_1602_8999_9011())), SpecialVariables.PSSessionApplicationNameVarPath, DefaultPowerShellRemoteShellAppName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,8813,9200);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,9216,9239);

return resolvedAppName;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,8702,9250);

bool
f_1602_8818_8847(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 8818, 8847);
return return_v;
}


System.Management.Automation.SessionState
f_1602_8999_9011()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 8999, 9011);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1602_8999_9020(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Internal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 8999, 9020);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1602_8999_9037(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 8999, 9037);
return return_v;
}


object
f_1602_8999_9184(System.Management.Automation.ExecutionContext
this_param,System.Management.Automation.VariablePath
path,string
defaultValue)
{
var return_v = this_param.GetVariableValue( path, (object)defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 8999, 9184);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,8702,9250);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,8702,9250);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public PSRemotingCmdlet()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1602,981,9279);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,7331,7382);
this.SkipWinRMCheck = false;DynAbs.Tracing.TraceSender.TraceExitConstructor(1602,981,9279);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,981,9279);
}


static PSRemotingCmdlet()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1602,981,9279);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,4996,5021);
s_LOCALHOST = "localhost";DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,5308,5349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,5498,5551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,5675,5714);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,5833,5858);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,5977,6006);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,6126,6157);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,6314,6358);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,6478,6509);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,6646,6715);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,6830,6967);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,7112,7157);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1602,981,9279);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,981,9279);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1602,981,9279);
}

internal struct SSHConnection
    {

public string ComputerName;

public string UserName;

public string KeyFilePath;

public int Port;

public string Subsystem;
static SSHConnection(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1602,9372,9581);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1602,9372,9581);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,9372,9581);
}
    }
public abstract partial class PSRemotingBaseCmdlet : PSRemotingCmdlet
{        
        /// <summary>
        /// State of virtual machine. This is the same as VMState in
        /// \vm\ux\powershell\objects\common\Types.cs.
        /// </summary>
        internal enum VMState
        {
            /// <summary>
            /// Other. Corresponds to CIM_EnabledLogicalElement.EnabledState = Other.
            /// </summary>
            Other = 1,

            /// <summary>
            /// Running. Corresponds to CIM_EnabledLogicalElement.EnabledState = Enabled.
            /// </summary>
            Running = 2,

            /// <summary>
            /// Off. Corresponds to CIM_EnabledLogicalElement.EnabledState = Disabled.
            /// </summary>
            Off = 3,

            /// <summary>
            /// Stopping. Corresponds to CIM_EnabledLogicalElement.EnabledState = ShuttingDown.
            /// </summary>
            Stopping = 4,

            /// <summary>
            /// Saved. Corresponds to CIM_EnabledLogicalElement.EnabledState = Enabled but offline.
            /// </summary>
            Saved = 6,

            /// <summary>
            /// Paused. Corresponds to CIM_EnabledLogicalElement.EnabledState = Quiesce.
            /// </summary>
            Paused = 9,

            /// <summary>
            /// Starting. EnabledStateStarting. State transition from PowerOff or Saved to Running.
            /// </summary>
            Starting = 10,

            /// <summary>
            /// Reset. Corresponds to CIM_EnabledLogicalElement.EnabledState = Reset.
            /// </summary>
            Reset = 11,

            /// <summary>
            /// Saving. Corresponds to EnabledStateSaving.
            /// </summary>
            Saving = 32773,

            /// <summary>
            /// Pausing. Corresponds to EnabledStatePausing.
            /// </summary>
            Pausing = 32776,

            /// <summary>
            /// Resuming. Corresponds to EnabledStateResuming.
            /// </summary>
            Resuming = 32777,

            /// <summary>
            /// FastSaved. EnabledStateFastSuspend.
            /// </summary>
            FastSaved = 32779,

            /// <summary>
            /// FastSaving. EnabledStateFastSuspending.
            /// </summary>
            FastSaving = 32780,

            /// <summary>
            /// ForceShutdown. Used to force a graceful shutdown of the virtual machine.
            /// </summary>
            ForceShutdown = 32781,

            /// <summary>
            /// ForceReboot. Used to force a graceful reboot of the virtual machine.
            /// </summary>
            ForceReboot = 32782,

            /// <summary>
            /// RunningCritical. Critical states.
            /// </summary>
            RunningCritical,

            /// <summary>
            /// OffCritical. Critical states.
            /// </summary>
            OffCritical,

            /// <summary>
            /// StoppingCritical. Critical states.
            /// </summary>
            StoppingCritical,

            /// <summary>
            /// SavedCritical. Critical states.
            /// </summary>
            SavedCritical,

            /// <summary>
            /// PausedCritical. Critical states.
            /// </summary>
            PausedCritical,

            /// <summary>
            /// StartingCritical. Critical states.
            /// </summary>
            StartingCritical,

            /// <summary>
            /// ResetCritical. Critical states.
            /// </summary>
            ResetCritical,

            /// <summary>
            /// SavingCritical. Critical states.
            /// </summary>
            SavingCritical,

            /// <summary>
            /// PausingCritical. Critical states.
            /// </summary>
            PausingCritical,

            /// <summary>
            /// ResumingCritical. Critical states.
            /// </summary>
            ResumingCritical,

            /// <summary>
            /// FastSavedCritical. Critical states.
            /// </summary>
            FastSavedCritical,

            /// <summary>
            /// FastSavingCritical. Critical states.
            /// </summary>
            FastSavingCritical,
        }

[Parameter(Position = 0,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRemotingBaseCmdlet.SessionParameterSet)]
        [ValidateNotNullOrEmpty]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public virtual PSSession[] Session {get; set; }

[Parameter(Position = 0,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRemotingBaseCmdlet.ComputerNameParameterSet)]
        [Alias("Cn")]
        public virtual string[] ComputerName {get; set; }

protected string[] ResolvedComputerNames {get; set; }

[SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays",
            Justification = "This is by spec.")]
        [Parameter(Position = 0,
                   Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRemotingBaseCmdlet.VMIdParameterSet)]
        [ValidateNotNullOrEmpty]
        [Alias("VMGuid")]
        public virtual Guid[] VMId {get; set; }

[SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays",
            Justification = "This is by spec.")]
        [Parameter(Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRemotingBaseCmdlet.VMNameParameterSet)]
        [ValidateNotNullOrEmpty]
        public virtual string[] VMName {get; set; }

[Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRemotingBaseCmdlet.ComputerNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRemotingBaseCmdlet.UriParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRemotingBaseCmdlet.VMIdParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRemotingBaseCmdlet.VMNameParameterSet)]
        [Credential()]
        public virtual PSCredential Credential
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,18156,18228);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,18192,18213);

return _pscredential;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,18156,18228);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,17504,18429);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,17504,18429);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,18244,18418);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,18280,18302);

_pscredential = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,18320,18403);

f_1602_18320_18402(f_1602_18352_18362(), f_1602_18364_18385(), f_1602_18387_18401());
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,18244,18418);

System.Management.Automation.PSCredential
f_1602_18352_18362()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 18352, 18362);
return return_v;
}


string
f_1602_18364_18385()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 18364, 18385);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1602_18387_18401()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 18387, 18401);
return return_v;
}


int
f_1602_18320_18402(System.Management.Automation.PSCredential
credential,string
thumbprint,System.Management.Automation.Runspaces.AuthenticationMechanism
authentication)
{
ValidateSpecifiedAuthentication( credential, thumbprint, authentication);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 18320, 18402);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,17504,18429);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,17504,18429);
}
		}}

private PSCredential _pscredential;

[SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays",
            Justification = "This is by spec.")]
        [Parameter(Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRemotingBaseCmdlet.ContainerIdParameterSet)]
        [ValidateNotNullOrEmpty]
        public virtual string[] ContainerId {get; set; }

[Parameter(ParameterSetName = PSRemotingBaseCmdlet.ContainerIdParameterSet)]
        public virtual SwitchParameter RunAsAdministrator {get; set; }

[Parameter(ParameterSetName = PSRemotingBaseCmdlet.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = PSRemotingBaseCmdlet.SSHHostParameterSet)]
        [ValidateRange((int)1, (int)UInt16.MaxValue)]
        public virtual int Port {get; set; }

[Parameter(ParameterSetName = PSRemotingBaseCmdlet.ComputerNameParameterSet)]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SSL")]
        public virtual SwitchParameter UseSSL {get; set; }

[Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRemotingBaseCmdlet.ComputerNameParameterSet)]
        public virtual string ApplicationName
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,21492,21559);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,21528,21544);

return _appName;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,21492,21559);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,21283,21670);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,21283,21670);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,21575,21659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,21611,21644);

_appName = f_1602_21622_21643(this, value);
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,21575,21659);

string
f_1602_21622_21643(Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet
this_param,string
appName)
{
var return_v = this_param.ResolveAppName( appName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 21622, 21643);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,21283,21670);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,21283,21670);
}
		}}

private string _appName;

[Parameter(ParameterSetName = PSRemotingBaseCmdlet.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = PSRemotingBaseCmdlet.SessionParameterSet)]
        [Parameter(ParameterSetName = PSRemotingBaseCmdlet.UriParameterSet)]
        [Parameter(ParameterSetName = PSRemotingBaseCmdlet.ContainerIdParameterSet)]
        [Parameter(ParameterSetName = PSRemotingBaseCmdlet.VMIdParameterSet)]
        [Parameter(ParameterSetName = PSRemotingBaseCmdlet.VMNameParameterSet)]
        public virtual int ThrottleLimit {set; get; }

[Parameter(Position = 0, Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRemotingBaseCmdlet.UriParameterSet)]
        [ValidateNotNullOrEmpty]
        [Alias("URI", "CU")]
        public virtual Uri[] ConnectionUri {get; set; }

[Parameter(ParameterSetName = PSRemotingBaseCmdlet.UriParameterSet)]
        public virtual SwitchParameter AllowRedirection
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,23281,23314);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,23287,23312);

return _allowRedirection;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,23281,23314);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,23131,23375);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,23131,23375);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,23330,23364);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,23336,23362);

_allowRedirection = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,23330,23364);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,23131,23375);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,23131,23375);
}
		}}

private bool _allowRedirection ;

[Parameter(ParameterSetName = PSRemotingBaseCmdlet.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = PSRemotingBaseCmdlet.UriParameterSet)]
        [ValidateNotNull]
        public virtual PSSessionOption SessionOption
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,23907,24389);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,23943,24332) || true) && (_sessionOption == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,23943,24332);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,24011,24086);

object 
tmp = f_1602_24024_24085(f_1602_24024_24052(f_1602_24024_24041(this)), DEFAULT_SESSION_OPTION)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,24108,24313) || true) && (tmp == null ||(DynAbs.Tracing.TraceSender.Expression_False(1602, 24112, 24201)||!f_1602_24128_24201(tmp, out _sessionOption)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,24108,24313);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,24251,24290);

_sessionOption = f_1602_24268_24289();
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,24108,24313);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,23943,24332);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,24352,24374);

return _sessionOption;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,23907,24389);

System.Management.Automation.SessionState
f_1602_24024_24041(Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet
this_param)
{
var return_v = this_param.SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 24024, 24041);
return return_v;
}


System.Management.Automation.PSVariableIntrinsics
f_1602_24024_24052(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.PSVariable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 24024, 24052);
return return_v;
}


object
f_1602_24024_24085(System.Management.Automation.PSVariableIntrinsics
this_param,string
name)
{
var return_v = this_param.GetValue( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 24024, 24085);
return return_v;
}


bool
f_1602_24128_24201(object
valueToConvert,out System.Management.Automation.Remoting.PSSessionOption
result)
{
var return_v = LanguagePrimitives.TryConvertTo<PSSessionOption>( valueToConvert, out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 24128, 24201);
return return_v;
}


System.Management.Automation.Remoting.PSSessionOption
f_1602_24268_24289()
{
var return_v = new System.Management.Automation.Remoting.PSSessionOption();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 24268, 24289);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,23646,24447);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,23646,24447);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,24405,24436);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,24411,24434);

_sessionOption = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,24405,24436);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,23646,24447);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,23646,24447);
}
		}}

private PSSessionOption _sessionOption;

internal const string 
DEFAULT_SESSION_OPTION = "PSSessionOption"
;

[Parameter(ParameterSetName = PSRemotingBaseCmdlet.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = PSRemotingBaseCmdlet.UriParameterSet)]
        public virtual AuthenticationMechanism Authentication
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,24976,25049);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,25012,25034);

return _authMechanism;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,24976,25049);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,24733,25323);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,24733,25323);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,25065,25312);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,25101,25124);

_authMechanism = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,25214,25297);

f_1602_25214_25296(f_1602_25246_25256(), f_1602_25258_25279(), f_1602_25281_25295());
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,25065,25312);

System.Management.Automation.PSCredential
f_1602_25246_25256()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 25246, 25256);
return return_v;
}


string
f_1602_25258_25279()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 25258, 25279);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1602_25281_25295()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 25281, 25295);
return return_v;
}


int
f_1602_25214_25296(System.Management.Automation.PSCredential
credential,string
thumbprint,System.Management.Automation.Runspaces.AuthenticationMechanism
authentication)
{
ValidateSpecifiedAuthentication( credential, thumbprint, authentication);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 25214, 25296);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,24733,25323);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,24733,25323);
}
		}}

private AuthenticationMechanism _authMechanism ;

[Parameter(ParameterSetName = NewPSSessionCommand.ComputerNameParameterSet)]
        [Parameter(ParameterSetName = NewPSSessionCommand.UriParameterSet)]
        public virtual string CertificateThumbprint
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,25827,25854);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,25833,25852);

return _thumbPrint;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,25827,25854);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,25596,26053);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,25596,26053);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,25870,26042);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,25906,25926);

_thumbPrint = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,25944,26027);

f_1602_25944_26026(f_1602_25976_25986(), f_1602_25988_26009(), f_1602_26011_26025());
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,25870,26042);

System.Management.Automation.PSCredential
f_1602_25976_25986()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 25976, 25986);
return return_v;
}


string
f_1602_25988_26009()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 25988, 26009);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1602_26011_26025()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 26011, 26025);
return return_v;
}


int
f_1602_25944_26026(System.Management.Automation.PSCredential
credential,string
thumbprint,System.Management.Automation.Runspaces.AuthenticationMechanism
authentication)
{
ValidateSpecifiedAuthentication( credential, thumbprint, authentication);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 25944, 26026);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,25596,26053);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,25596,26053);
}
		}}

private string _thumbPrint ;

[Parameter(Position = 0, Mandatory = true,
            ParameterSetName = PSRemotingBaseCmdlet.SSHHostParameterSet)]
        [ValidateNotNullOrEmpty()]
        public virtual string[] HostName
{            get;
            set;
}

[Parameter(ParameterSetName = PSRemotingBaseCmdlet.SSHHostParameterSet)]
        [ValidateNotNullOrEmpty()]
        public virtual string UserName
{            get;
            set;
}

[Parameter(ParameterSetName = PSRemotingBaseCmdlet.SSHHostParameterSet)]
        [ValidateNotNullOrEmpty()]
        [Alias("IdentityFilePath")]
        public virtual string KeyFilePath
{            get;
            set;
}

[Parameter(ParameterSetName = PSRemotingBaseCmdlet.SSHHostParameterSet)]
        [ValidateSet("true")]
        public virtual SwitchParameter SSHTransport
{            get;
            set;
}

[Parameter(ParameterSetName = PSRemotingBaseCmdlet.SSHHostHashParameterSet, Mandatory = true)]
        [ValidateNotNullOrEmpty()]
        public virtual Hashtable[] SSHConnection
{            get;
            set;
}

[Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.SSHHostParameterSet)]
        public virtual string Subsystem {get; set; }

internal static void ValidateSpecifiedAuthentication(PSCredential credential, string thumbprint, AuthenticationMechanism authentication)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1602,29244,30673);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,29405,29776) || true) && ((credential != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 29409, 29453)&&(thumbprint != null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,29405,29776);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,29487,29696);

string 
message = f_1602_29504_29695(f_1602_29573_29630(), "CertificateThumbPrint", "Credential")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,29716,29761);

throw f_1602_29722_29760(message);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,29405,29776);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,29792,30207) || true) && ((authentication != AuthenticationMechanism.Default) &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 29796, 29871)&&(thumbprint != null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,29792,30207);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,29905,30127);

string 
message = f_1602_29922_30126(f_1602_29991_30048(), "CertificateThumbPrint", f_1602_30100_30125(authentication))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,30147,30192);

throw f_1602_30153_30191(message);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,29792,30207);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,30223,30662) || true) && ((authentication == AuthenticationMechanism.NegotiateWithImplicitCredential) &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 30227, 30343)&&                (credential != null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,30223,30662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,30377,30584);

string 
message = f_1602_30394_30583(f_1602_30463_30520(), "Credential", f_1602_30557_30582(authentication))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,30602,30647);

throw f_1602_30608_30646(message);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,30223,30662);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1602,29244,30673);

string
f_1602_29573_29630()
{
var return_v =                     RemotingErrorIdStrings.NewRunspaceAmbiguousAuthentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 29573, 29630);
return return_v;
}


string
f_1602_29504_29695(string
resourceString,params object[]
args)
{
var return_v = PSRemotingErrorInvariants.FormatResourceString( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 29504, 29695);
return return_v;
}


System.InvalidOperationException
f_1602_29722_29760(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 29722, 29760);
return return_v;
}


string
f_1602_29991_30048()
{
var return_v =                     RemotingErrorIdStrings.NewRunspaceAmbiguousAuthentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 29991, 30048);
return return_v;
}


string
f_1602_30100_30125(System.Management.Automation.Runspaces.AuthenticationMechanism
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 30100, 30125);
return return_v;
}


string
f_1602_29922_30126(string
resourceString,params object[]
args)
{
var return_v = PSRemotingErrorInvariants.FormatResourceString( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 29922, 30126);
return return_v;
}


System.InvalidOperationException
f_1602_30153_30191(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 30153, 30191);
return return_v;
}


string
f_1602_30463_30520()
{
var return_v =                     RemotingErrorIdStrings.NewRunspaceAmbiguousAuthentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 30463, 30520);
return return_v;
}


string
f_1602_30557_30582(System.Management.Automation.Runspaces.AuthenticationMechanism
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 30557, 30582);
return return_v;
}


string
f_1602_30394_30583(string
resourceString,params object[]
args)
{
var return_v = PSRemotingErrorInvariants.FormatResourceString( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 30394, 30583);
return return_v;
}


System.InvalidOperationException
f_1602_30608_30646(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 30608, 30646);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,29244,30673);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,29244,30673);
}
		}

private const string 
ComputerNameParameter = "ComputerName"
;

private const string 
HostNameAlias = "HostName"
;

private const string 
UserNameParameter = "UserName"
;

private const string 
KeyFilePathParameter = "KeyFilePath"
;

private const string 
IdentityFilePathAlias = "IdentityFilePath"
;

private const string 
PortParameter = "Port"
;

private const string 
SubsystemParameter = "Subsystem"
;

protected void ParseSshHostName(string hostname, out string host, out string userName, out int port)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,31670,32762);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,31795,31811);

host = hostname;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,31825,31850);

userName = f_1602_31836_31849(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,31864,31881);

port = f_1602_31871_31880(this);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,31931,31977);

Uri 
uri = f_1602_31941_31976("ssh://" + hostname)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,31995,32032);

host = f_1602_32002_32031(this, f_1602_32022_32030(uri));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,32050,32094);

f_1602_32050_32093(this, new string[] { host });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,32112,32229) || true) && (f_1602_32116_32128(uri)!= string.Empty)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,32112,32229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,32186,32210);

userName = f_1602_32197_32209(uri);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,32112,32229);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,32249,32344) || true) && (f_1602_32253_32261(uri)!= -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,32249,32344);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,32309,32325);

port = f_1602_32316_32324(uri);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,32249,32344);
}
            }
            catch (UriFormatException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,32373,32751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,32432,32736);

f_1602_32432_32735(this, f_1602_32454_32734(f_1602_32492_32631(f_1602_32514_32630(f_1602_32587_32629())), "PSSessionInvalidComputerName", ErrorCategory.InvalidArgument, hostname));
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,32373,32751);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,31670,32762);

string
f_1602_31836_31849(Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet
this_param)
{
var return_v = this_param.UserName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 31836, 31849);
return return_v;
}


int
f_1602_31871_31880(Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet
this_param)
{
var return_v = this_param.Port;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 31871, 31880);
return return_v;
}


System.Uri
f_1602_31941_31976(string
uriString)
{
var return_v = new System.Uri( uriString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 31941, 31976);
return return_v;
}


string
f_1602_32022_32030(System.Uri
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 32022, 32030);
return return_v;
}


string
f_1602_32002_32031(Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet
this_param,string
computerName)
{
var return_v = this_param.ResolveComputerName( computerName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 32002, 32031);
return return_v;
}


int
f_1602_32050_32093(Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet
this_param,string[]
computerNames)
{
this_param.ValidateComputerName( computerNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 32050, 32093);
return 0;
}


string
f_1602_32116_32128(System.Uri
this_param)
{
var return_v = this_param.UserInfo ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 32116, 32128);
return return_v;
}


string
f_1602_32197_32209(System.Uri
this_param)
{
var return_v = this_param.UserInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 32197, 32209);
return return_v;
}


int
f_1602_32253_32261(System.Uri
this_param)
{
var return_v = this_param.Port ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 32253, 32261);
return return_v;
}


int
f_1602_32316_32324(System.Uri
this_param)
{
var return_v = this_param.Port;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 32316, 32324);
return return_v;
}


string
f_1602_32587_32629()
{
var return_v =                         RemotingErrorIdStrings.InvalidComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 32587, 32629);
return return_v;
}


string
f_1602_32514_32630(string
resourceString,params object[]
args)
{
var return_v = PSRemotingErrorInvariants.FormatResourceString( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 32514, 32630);
return return_v;
}


System.ArgumentException
f_1602_32492_32631(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 32492, 32631);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_32454_32734(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 32454, 32734);
return return_v;
}


int
f_1602_32432_32735(Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 32432, 32735);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,31670,32762);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,31670,32762);
}
		}

internal SSHConnection[] ParseSSHConnectionHashTable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,32946,36579);
string host = default(string);
string userName = default(string);
int port = default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,33025,33085);

List<SSHConnection> 
connections = f_1602_33059_33084()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,33099,36523);
foreach(var item in f_1602_33120_33138_I(f_1602_33120_33138(this)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,33099,36523);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,33172,33396) || true) && (f_1602_33176_33215(item, ComputerNameParameter)&&(DynAbs.Tracing.TraceSender.Expression_True(1602, 33176, 33250)&&f_1602_33219_33250(item, HostNameAlias)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,33172,33396);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,33292,33377);

throw f_1602_33298_33376(f_1602_33322_33375());
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,33172,33396);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,33416,33646) || true) && (f_1602_33420_33458(item, KeyFilePathParameter)&&(DynAbs.Tracing.TraceSender.Expression_True(1602, 33420, 33501)&&f_1602_33462_33501(item, IdentityFilePathAlias)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,33416,33646);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,33543,33627);

throw f_1602_33549_33626(f_1602_33573_33625());
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,33416,33646);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,33666,33717);

SSHConnection 
connectionInfo = f_1602_33697_33716()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,33735,36240);
foreach(var key in f_1602_33755_33764_I(f_1602_33755_33764(item)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,33735,36240);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,33806,33839);

string 
paramName = key as string
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,33861,34053) || true) && (f_1602_33865_33896(paramName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,33861,34053);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,33946,34030);

throw f_1602_33952_34029(f_1602_33976_34028());
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,33861,34053);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,34077,36221) || true) && (f_1602_34081_34156(paramName, ComputerNameParameter, StringComparison.OrdinalIgnoreCase)||(DynAbs.Tracing.TraceSender.Expression_False(1602, 34081, 34227)||f_1602_34160_34227(paramName, HostNameAlias, StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,34077,36221);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,34277,34374);

var 
resolvedComputerName = f_1602_34304_34373(this, f_1602_34324_34372(f_1602_34356_34371(item, paramName)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,34400,34491);

f_1602_34400_34490(this, resolvedComputerName, out host, out userName, out port);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,34517,34552);

connectionInfo.ComputerName = host;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,34578,34726) || true) && (userName != string.Empty)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,34578,34726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,34664,34699);

connectionInfo.UserName = userName;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,34578,34726);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,34754,34880) || true) && (port != -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,34754,34880);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,34826,34853);

connectionInfo.Port = port;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,34754,34880);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,34077,36221);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,34077,36221);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,34930,36221) || true) && (f_1602_34934_35005(paramName, UserNameParameter, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,34930,36221);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,35055,35130);

connectionInfo.UserName = f_1602_35081_35129(f_1602_35113_35128(item, paramName));
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,34930,36221);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,34930,36221);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,35180,36221) || true) && (f_1602_35184_35258(paramName, KeyFilePathParameter, StringComparison.OrdinalIgnoreCase)||(DynAbs.Tracing.TraceSender.Expression_False(1602, 35184, 35337)||f_1602_35262_35337(paramName, IdentityFilePathAlias, StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,35180,36221);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,35387,35465);

connectionInfo.KeyFilePath = f_1602_35416_35464(f_1602_35448_35463(item, paramName));
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,35180,36221);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,35180,36221);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,35515,36221) || true) && (f_1602_35519_35586(paramName, PortParameter, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,35515,36221);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,35636,35704);

connectionInfo.Port = f_1602_35658_35703(f_1602_35687_35702(item, paramName));
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,35515,36221);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,35515,36221);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,35754,36221) || true) && (f_1602_35758_35830(paramName, SubsystemParameter, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,35754,36221);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,35880,35956);

connectionInfo.Subsystem = f_1602_35907_35955(f_1602_35939_35954(item, paramName));
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,35754,36221);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,35754,36221);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,36054,36198);

throw f_1602_36060_36197(f_1602_36114_36196(f_1602_36132_36184(), paramName));
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,35754,36221);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,35515,36221);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,35180,36221);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,34930,36221);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,34077,36221);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,33735,36240);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,2506);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,2506);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,36260,36456) || true) && (f_1602_36264_36313(connectionInfo.ComputerName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,36260,36456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,36355,36437);

throw f_1602_36361_36436(f_1602_36385_36435());
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,36260,36456);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,36476,36508);

f_1602_36476_36507(
                connections, connectionInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,33099,36523);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,3425);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,3425);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,36539,36568);

return f_1602_36546_36567(connections);
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,32946,36579);

System.Collections.Generic.List<Microsoft.PowerShell.Commands.SSHConnection>
f_1602_33059_33084()
{
var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.SSHConnection>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 33059, 33084);
return return_v;
}


System.Collections.Hashtable[]
f_1602_33120_33138(Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet
this_param)
{
var return_v = this_param.SSHConnection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 33120, 33138);
return return_v;
}


bool
f_1602_33176_33215(System.Collections.Hashtable
this_param,string
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 33176, 33215);
return return_v;
}


bool
f_1602_33219_33250(System.Collections.Hashtable
this_param,string
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 33219, 33250);
return return_v;
}


string
f_1602_33322_33375()
{
var return_v = RemotingErrorIdStrings.SSHConnectionDuplicateHostName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 33322, 33375);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1602_33298_33376(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 33298, 33376);
return return_v;
}


bool
f_1602_33420_33458(System.Collections.Hashtable
this_param,string
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 33420, 33458);
return return_v;
}


bool
f_1602_33462_33501(System.Collections.Hashtable
this_param,string
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 33462, 33501);
return return_v;
}


string
f_1602_33573_33625()
{
var return_v = RemotingErrorIdStrings.SSHConnectionDuplicateKeyPath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 33573, 33625);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1602_33549_33626(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 33549, 33626);
return return_v;
}


Microsoft.PowerShell.Commands.SSHConnection
f_1602_33697_33716()
{
var return_v = new Microsoft.PowerShell.Commands.SSHConnection();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 33697, 33716);
return return_v;
}


System.Collections.ICollection
f_1602_33755_33764(System.Collections.Hashtable
this_param)
{
var return_v = this_param.Keys;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 33755, 33764);
return return_v;
}


bool
f_1602_33865_33896(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 33865, 33896);
return return_v;
}


string
f_1602_33976_34028()
{
var return_v = RemotingErrorIdStrings.InvalidSSHConnectionParameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 33976, 34028);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1602_33952_34029(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 33952, 34029);
return return_v;
}


bool
f_1602_34081_34156(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 34081, 34156);
return return_v;
}


bool
f_1602_34160_34227(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 34160, 34227);
return return_v;
}


object
f_1602_34356_34371(System.Collections.Hashtable
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 34356, 34371);
return return_v;
}


string
f_1602_34324_34372(object
param)
{
var return_v = GetSSHConnectionStringParameter( param);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 34324, 34372);
return return_v;
}


string
f_1602_34304_34373(Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet
this_param,string
computerName)
{
var return_v = this_param.ResolveComputerName( computerName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 34304, 34373);
return return_v;
}


int
f_1602_34400_34490(Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet
this_param,string
hostname,out string
host,out string
userName,out int
port)
{
this_param.ParseSshHostName( hostname, out host, out userName, out port);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 34400, 34490);
return 0;
}


bool
f_1602_34934_35005(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 34934, 35005);
return return_v;
}


object
f_1602_35113_35128(System.Collections.Hashtable
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 35113, 35128);
return return_v;
}


string
f_1602_35081_35129(object
param)
{
var return_v = GetSSHConnectionStringParameter( param);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 35081, 35129);
return return_v;
}


bool
f_1602_35184_35258(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 35184, 35258);
return return_v;
}


bool
f_1602_35262_35337(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 35262, 35337);
return return_v;
}


object
f_1602_35448_35463(System.Collections.Hashtable
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 35448, 35463);
return return_v;
}


string
f_1602_35416_35464(object
param)
{
var return_v = GetSSHConnectionStringParameter( param);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 35416, 35464);
return return_v;
}


bool
f_1602_35519_35586(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 35519, 35586);
return return_v;
}


object
f_1602_35687_35702(System.Collections.Hashtable
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 35687, 35702);
return return_v;
}


int
f_1602_35658_35703(object
param)
{
var return_v = GetSSHConnectionIntParameter( param);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 35658, 35703);
return return_v;
}


bool
f_1602_35758_35830(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 35758, 35830);
return return_v;
}


object
f_1602_35939_35954(System.Collections.Hashtable
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 35939, 35954);
return return_v;
}


string
f_1602_35907_35955(object
param)
{
var return_v = GetSSHConnectionStringParameter( param);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 35907, 35955);
return return_v;
}


string
f_1602_36132_36184()
{
var return_v = RemotingErrorIdStrings.UnknownSSHConnectionParameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 36132, 36184);
return return_v;
}


string
f_1602_36114_36196(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 36114, 36196);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1602_36060_36197(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 36060, 36197);
return return_v;
}


System.Collections.ICollection
f_1602_33755_33764_I(System.Collections.ICollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 33755, 33764);
return return_v;
}


bool
f_1602_36264_36313(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 36264, 36313);
return return_v;
}


string
f_1602_36385_36435()
{
var return_v = RemotingErrorIdStrings.MissingRequiredSSHParameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 36385, 36435);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1602_36361_36436(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 36361, 36436);
return return_v;
}


int
f_1602_36476_36507(System.Collections.Generic.List<Microsoft.PowerShell.Commands.SSHConnection>
this_param,Microsoft.PowerShell.Commands.SSHConnection
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 36476, 36507);
return 0;
}


System.Collections.Hashtable[]
f_1602_33120_33138_I(System.Collections.Hashtable[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 33120, 33138);
return return_v;
}


Microsoft.PowerShell.Commands.SSHConnection[]
f_1602_36546_36567(System.Collections.Generic.List<Microsoft.PowerShell.Commands.SSHConnection>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 36546, 36567);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,32946,36579);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,32946,36579);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected void ValidateRemoteRunspacesSpecified()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,36923,38263);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,36997,37125);

f_1602_36997_37124(f_1602_37008_37015()!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 37008, 37046)&&f_1602_37027_37041(f_1602_37027_37034())!= 0), "Remote Runspaces specified must not be null or empty");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,37222,37633) || true) && (f_1602_37226_37276(f_1602_37268_37275()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,37222,37633);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,37310,37618);

f_1602_37310_37617(this, f_1602_37332_37616(f_1602_37348_37459(f_1602_37392_37458(this, f_1602_37403_37457())), f_1602_37486_37546(                        PSRemotingErrorId.RemoteRunspaceInfoHasDuplicates), ErrorCategory.InvalidArgument, f_1602_37608_37615()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,37222,37633);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,37831,38252) || true) && (f_1602_37835_37895(f_1602_37887_37894()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,37831,38252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,37929,38237);

f_1602_37929_38236(this, f_1602_37951_38235(f_1602_37967_38078(f_1602_38011_38077(this, f_1602_38022_38076())), f_1602_38105_38165(                        PSRemotingErrorId.RemoteRunspaceInfoLimitExceeded), ErrorCategory.InvalidArgument, f_1602_38227_38234()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,37831,38252);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,36923,38263);

System.Management.Automation.Runspaces.PSSession[]
f_1602_37008_37015()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 37008, 37015);
return return_v;
}


System.Management.Automation.Runspaces.PSSession[]
f_1602_37027_37034()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 37027, 37034);
return return_v;
}


int
f_1602_37027_37041(System.Management.Automation.Runspaces.PSSession[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 37027, 37041);
return return_v;
}


int
f_1602_36997_37124(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 36997, 37124);
return 0;
}


System.Management.Automation.Runspaces.PSSession[]
f_1602_37268_37275()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 37268, 37275);
return return_v;
}


bool
f_1602_37226_37276(System.Management.Automation.Runspaces.PSSession[]
runspaceInfos)
{
var return_v = RemotingCommandUtil.HasRepeatingRunspaces( runspaceInfos);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 37226, 37276);
return return_v;
}


string
f_1602_37403_37457()
{
var return_v = RemotingErrorIdStrings.RemoteRunspaceInfoHasDuplicates;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 37403, 37457);
return return_v;
}


string
f_1602_37392_37458(Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet
this_param,string
resourceString)
{
var return_v = this_param.GetMessage( resourceString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 37392, 37458);
return return_v;
}


System.ArgumentException
f_1602_37348_37459(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 37348, 37459);
return return_v;
}


string
f_1602_37486_37546(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 37486, 37546);
return return_v;
}


System.Management.Automation.Runspaces.PSSession[]
f_1602_37608_37615()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 37608, 37615);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_37332_37616(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Runspaces.PSSession[]
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 37332, 37616);
return return_v;
}


int
f_1602_37310_37617(Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 37310, 37617);
return 0;
}


System.Management.Automation.Runspaces.PSSession[]
f_1602_37887_37894()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 37887, 37894);
return return_v;
}


bool
f_1602_37835_37895(System.Management.Automation.Runspaces.PSSession[]
runspaceInfos)
{
var return_v = RemotingCommandUtil.ExceedMaximumAllowableRunspaces( runspaceInfos);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 37835, 37895);
return return_v;
}


string
f_1602_38022_38076()
{
var return_v = RemotingErrorIdStrings.RemoteRunspaceInfoLimitExceeded;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 38022, 38076);
return return_v;
}


string
f_1602_38011_38077(Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet
this_param,string
resourceString)
{
var return_v = this_param.GetMessage( resourceString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 38011, 38077);
return return_v;
}


System.ArgumentException
f_1602_37967_38078(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 37967, 38078);
return return_v;
}


string
f_1602_38105_38165(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 38105, 38165);
return return_v;
}


System.Management.Automation.Runspaces.PSSession[]
f_1602_38227_38234()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 38227, 38234);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_37951_38235(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Runspaces.PSSession[]
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 37951, 38235);
return return_v;
}


int
f_1602_37929_38236(Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 37929, 38236);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,36923,38263);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,36923,38263);
}
		}

internal void UpdateConnectionInfo(WSManConnectionInfo connectionInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,38696,39444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,38791,38860);

f_1602_38791_38859(connectionInfo != null, "connectionInfo cannot be null.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,38876,38929);

f_1602_38876_38928(
            connectionInfo, f_1602_38909_38927(this));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,38945,39226) || true) && (!f_1602_38950_39047(f_1602_38950_38966(), PSRemotingBaseCmdlet.UriParameterSet, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,38945,39226);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,39158,39211);

connectionInfo.MaximumConnectionRedirectionCount = 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,38945,39226);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,39242,39433) || true) && (!_allowRedirection)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,39242,39433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,39365,39418);

connectionInfo.MaximumConnectionRedirectionCount = 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,39242,39433);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,38696,39444);

int
f_1602_38791_38859(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 38791, 38859);
return 0;
}


System.Management.Automation.Remoting.PSSessionOption
f_1602_38909_38927(Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet
this_param)
{
var return_v = this_param.SessionOption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 38909, 38927);
return return_v;
}


int
f_1602_38876_38928(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param,System.Management.Automation.Remoting.PSSessionOption
options)
{
this_param.SetSessionOptions( options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 38876, 38928);
return 0;
}


string
f_1602_38950_38966()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 38950, 38966);
return return_v;
}


bool
f_1602_38950_39047(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 38950, 39047);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,38696,39444);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,38696,39444);
}
		}

protected const string 
UriParameterSet = "Uri"
;

protected void ValidateComputerName(string[] computerNames)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,39868,40647);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,39952,40636);
foreach(string computerName in f_1602_39984_39997_I(computerNames) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,39952,40636);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,40031,40090);

UriHostNameType 
nametype = f_1602_40058_40089(computerName)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,40108,40621) || true) && (!(nametype == UriHostNameType.Dns ||(DynAbs.Tracing.TraceSender.Expression_False(1602, 40114, 40181)||nametype == UriHostNameType.IPv4 )||(DynAbs.Tracing.TraceSender.Expression_False(1602, 40114, 40238)||                    nametype == UriHostNameType.IPv6)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,40108,40621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,40281,40602);

f_1602_40281_40601(this, f_1602_40303_40600(f_1602_40345_40488(f_1602_40367_40487(f_1602_40444_40486())), "PSSessionInvalidComputerName", ErrorCategory.InvalidArgument, computerNames));
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,40108,40621);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,39952,40636);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,685);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,685);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1602,39868,40647);

System.UriHostNameType
f_1602_40058_40089(string
name)
{
var return_v = Uri.CheckHostName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 40058, 40089);
return return_v;
}


string
f_1602_40444_40486()
{
var return_v =                             RemotingErrorIdStrings.InvalidComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 40444, 40486);
return return_v;
}


string
f_1602_40367_40487(string
resourceString,params object[]
args)
{
var return_v = PSRemotingErrorInvariants.FormatResourceString( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 40367, 40487);
return return_v;
}


System.ArgumentException
f_1602_40345_40488(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 40345, 40488);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_40303_40600(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string[]
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 40303, 40600);
return return_v;
}


int
f_1602_40281_40601(Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 40281, 40601);
return 0;
}


string[]
f_1602_39984_39997_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 39984, 39997);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,39868,40647);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,39868,40647);
}
		}

private static string GetSSHConnectionStringParameter(object param)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1602,40901,41502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,40993,41011);

string 
paramValue
=default(string);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,41061,41118);

paramValue = f_1602_41074_41117(param);
            }
            catch (PSInvalidCastException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,41147,41271);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,41212,41256);

throw f_1602_41218_41255(f_1602_41242_41251(e), e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,41147,41271);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,41287,41391) || true) && (!f_1602_41292_41324(paramValue))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,41287,41391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,41358,41376);

return paramValue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,41287,41391);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,41407,41491);

throw f_1602_41413_41490(f_1602_41437_41489());
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1602,40901,41502);

string
f_1602_41074_41117(object
valueToConvert)
{
var return_v = LanguagePrimitives.ConvertTo<string>( valueToConvert);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 41074, 41117);
return return_v;
}


string
f_1602_41242_41251(System.Management.Automation.PSInvalidCastException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 41242, 41251);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1602_41218_41255(string
message,System.Management.Automation.PSInvalidCastException
innerException)
{
var return_v = new System.Management.Automation.PSArgumentException( message, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 41218, 41255);
return return_v;
}


bool
f_1602_41292_41324(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 41292, 41324);
return return_v;
}


string
f_1602_41437_41489()
{
var return_v = RemotingErrorIdStrings.InvalidSSHConnectionParameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 41437, 41489);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1602_41413_41490(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 41413, 41490);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,40901,41502);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,40901,41502);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static int GetSSHConnectionIntParameter(object param)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1602,41758,42258);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,41844,41994) || true) && (param == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,41844,41994);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,41895,41979);

throw f_1602_41901_41978(f_1602_41925_41977());
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,41844,41994);
}

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,42046,42094);

return f_1602_42053_42093(param);
            }
            catch (PSInvalidCastException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,42123,42247);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,42188,42232);

throw f_1602_42194_42231(f_1602_42218_42227(e), e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,42123,42247);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1602,41758,42258);

string
f_1602_41925_41977()
{
var return_v = RemotingErrorIdStrings.InvalidSSHConnectionParameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 41925, 41977);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1602_41901_41978(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 41901, 41978);
return return_v;
}


int
f_1602_42053_42093(object
valueToConvert)
{
var return_v = LanguagePrimitives.ConvertTo<int>( valueToConvert);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 42053, 42093);
return return_v;
}


string
f_1602_42218_42227(System.Management.Automation.PSInvalidCastException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 42218, 42227);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1602_42194_42231(string
message,System.Management.Automation.PSInvalidCastException
innerException)
{
var return_v = new System.Management.Automation.PSArgumentException( message, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 42194, 42231);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,41758,42258);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,41758,42258);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override void BeginProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,42429,43636);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,42495,42518);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BeginProcessing(),1602,42495,42517);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,42582,42950) || true) && ((f_1602_42587_42603()== PSRemotingBaseCmdlet.SSHHostParameterSet) &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 42586, 42695)&&                (f_1602_42670_42686(this)!= null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,42582,42950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,42785,42935);

this.KeyFilePath = f_1602_42804_42934(f_1602_42840_42856(this), true, this, false, f_1602_42877_42933());
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,42582,42950);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,43014,43081);

int 
idleTimeout = (int)f_1602_43037_43050().IdleTimeout.TotalMilliseconds
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,43095,43494) || true) && (idleTimeout != BaseTransportManager.UseServerDefaultIdleTimeout &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 43099, 43236)&&                idleTimeout < BaseTransportManager.MinimumIdleTimeout))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,43095,43494);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,43270,43479);

throw f_1602_43276_43478(f_1602_43322_43477(f_1602_43340_43387(), idleTimeout / 1000, BaseTransportManager.MinimumIdleTimeout / 1000));
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,43095,43494);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,43510,43625) || true) && (f_1602_43514_43544(_appName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,43510,43625);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,43578,43610);

_appName = f_1602_43589_43609(this, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,43510,43625);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,42429,43636);

string
f_1602_42587_42603()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 42587, 42603);
return return_v;
}


string
f_1602_42670_42686(Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet
this_param)
{
var return_v = this_param.KeyFilePath ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 42670, 42686);
return return_v;
}


string
f_1602_42840_42856(Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet
this_param)
{
var return_v = this_param.KeyFilePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 42840, 42856);
return return_v;
}


string
f_1602_42877_42933()
{
var return_v = RemotingErrorIdStrings.FilePathNotFromFileSystemProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 42877, 42933);
return return_v;
}


string
f_1602_42804_42934(string
path,bool
isLiteralPath,Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet
cmdlet,bool
allowNonexistingPaths,string
resourceString)
{
var return_v = PathResolver.ResolveProviderAndPath( path, isLiteralPath, (System.Management.Automation.PSCmdlet)cmdlet, allowNonexistingPaths, resourceString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 42804, 42934);
return return_v;
}


System.Management.Automation.Remoting.PSSessionOption
f_1602_43037_43050()
{
var return_v = SessionOption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 43037, 43050);
return return_v;
}


string
f_1602_43340_43387()
{
var return_v = RemotingErrorIdStrings.InvalidIdleTimeoutOption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 43340, 43387);
return return_v;
}


string
f_1602_43322_43477(string
formatSpec,int
o1,int
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 43322, 43477);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1602_43276_43478(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 43276, 43478);
return return_v;
}


bool
f_1602_43514_43544(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 43514, 43544);
return return_v;
}


string
f_1602_43589_43609(Microsoft.PowerShell.Commands.PSRemotingBaseCmdlet
this_param,string
appName)
{
var return_v = this_param.ResolveAppName( appName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 43589, 43609);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,42429,43636);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,42429,43636);
}
		}

public PSRemotingBaseCmdlet()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1602,9949,43675);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,14808,15160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,15512,15766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,16112,16166);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,16270,16725);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,16829,17229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,18462,18475);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,18572,18982);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,20013,20274);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,21697,21705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,21948,22492);
this.ThrottleLimit = 0;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,22678,22980);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,23400,23425);
this._allowRedirection = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,24483,24497);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,25367,25415);
this._authMechanism = AuthenticationMechanism.Default;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,26080,26098);
this._thumbPrint = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,26248,26501);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,26588,26794);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,26885,27131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,28100,28338);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,28487,28674);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1602,9949,43675);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,9949,43675);
}


static PSRemotingBaseCmdlet()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1602,9949,43675);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,24530,24572);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,30806,30844);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,30876,30902);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,30934,30964);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,30996,31032);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,31064,31106);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,31138,31160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,31192,31224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,39558,39581);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1602,9949,43675);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,9949,43675);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1602,9949,43675);
}
public abstract partial class PSExecutionCmdlet : PSRemotingBaseCmdlet
{
protected const string 
FilePathVMIdParameterSet = "FilePathVMId"
;

protected const string 
FilePathVMNameParameterSet = "FilePathVMName"
;

protected const string 
FilePathContainerIdParameterSet = "FilePathContainerId"
;

protected const string 
FilePathSSHHostParameterSet = "FilePathSSHHost"
;

protected const string 
FilePathSSHHostHashParameterSet = "FilePathSSHHostHash"
;

[Parameter(ValueFromPipeline = true)]
        public virtual PSObject InputObject {get; set; }

public virtual ScriptBlock ScriptBlock
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,45703,45774);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,45739,45759);

return _scriptBlock;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,45703,45774);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,45640,45873);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,45640,45873);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,45790,45862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,45826,45847);

_scriptBlock = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,45790,45862);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,45640,45873);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,45640,45873);
}
		}}

private ScriptBlock _scriptBlock;

[Parameter(Position = 1,
                   Mandatory = true,
                   ParameterSetName = FilePathComputerNameParameterSet)]
        [Parameter(Position = 1,
                   Mandatory = true,
                   ParameterSetName = FilePathSessionParameterSet)]
        [Parameter(Position = 1,
                   Mandatory = true,
                   ParameterSetName = FilePathUriParameterSet)]
        [ValidateNotNull]
        public virtual string FilePath
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,46679,46747);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,46715,46732);

return _filePath;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,46679,46747);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,46173,46843);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,46173,46843);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,46763,46832);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,46799,46817);

_filePath = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,46763,46832);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,46173,46843);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,46173,46843);
}
		}}

private string _filePath;

protected bool IsLiteralPath {get; set; }

[Parameter()]
        [Alias("Args")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public virtual object[] ArgumentList
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,47372,47436);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,47408,47421);

return _args;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,47372,47436);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,47169,47528);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,47169,47528);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,47452,47517);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,47488,47502);

_args = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,47452,47517);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,47169,47528);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,47169,47528);
}
		}}

private object[] _args;

protected bool InvokeAndDisconnect {get; set; }

[SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        protected string[] DisconnectedSessionName {get; set; }

public virtual SwitchParameter EnableNetworkAccess {get; set; }

[SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays",
            Justification = "This is by spec.")]
        [Parameter(Position = 0, Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.VMIdParameterSet)]
        [Parameter(Position = 0, Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.FilePathVMIdParameterSet)]
        [ValidateNotNullOrEmpty]
        [Alias("VMGuid")]
        public override Guid[] VMId {get; set; }

[SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays",
            Justification = "This is by spec.")]
        [Parameter(Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.VMNameParameterSet)]
        [Parameter(Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.FilePathVMNameParameterSet)]
        [ValidateNotNullOrEmpty]
        public override string[] VMName {get; set; }

[SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays",
            Justification = "This is by spec.")]
        [Parameter(Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.ContainerIdParameterSet)]
        [Parameter(Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.FilePathContainerIdParameterSet)]
        [ValidateNotNullOrEmpty]
        public override string[] ContainerId {get; set; }

[Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.ComputerNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.UriParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.FilePathComputerNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.FilePathUriParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.ContainerIdParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.VMIdParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.VMNameParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.FilePathContainerIdParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.FilePathVMIdParameterSet)]
        [Parameter(ValueFromPipelineByPropertyName = true,
                   ParameterSetName = InvokeCommandCommand.FilePathVMNameParameterSet)]
        public virtual string ConfigurationName {get; set; }

protected virtual void CreateHelpersForSpecifiedComputerNames()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,52959,55871);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,53047,53091);

f_1602_53047_53090(this, f_1602_53068_53089());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,53164,53201);

RemoteRunspace 
remoteRunspace = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,53215,53315);

string 
scheme = (DynAbs.Tracing.TraceSender.Conditional_F1(1602, 53231, 53247)||((f_1602_53231_53237().IsPresent &&DynAbs.Tracing.TraceSender.Conditional_F2(1602, 53250, 53281))||DynAbs.Tracing.TraceSender.Conditional_F3(1602, 53284, 53314)))?WSManConnectionInfo.HttpsScheme :WSManConnectionInfo.HttpScheme
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,53340,53345);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,53331,55860) || true) && (i < f_1602_53351_53379(f_1602_53351_53372()))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,53381,53384)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1602,53331,55860))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,53331,55860);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,53462,53525);

WSManConnectionInfo 
connectionInfo = f_1602_53499_53524()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,53547,53578);

connectionInfo.Scheme = scheme;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,53600,53655);

connectionInfo.ComputerName = f_1602_53630_53651()[i];
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,53677,53704);

connectionInfo.Port = f_1602_53699_53703();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,53726,53767);

connectionInfo.AppName = f_1602_53751_53766();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,53789,53833);

connectionInfo.ShellUri = f_1602_53815_53832();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,53855,54159) || true) && (f_1602_53859_53880()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,53855,54159);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,53938,53999);

connectionInfo.CertificateThumbprint = f_1602_53977_53998();
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,53855,54159);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,53855,54159);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,54097,54136);

connectionInfo.Credential = f_1602_54125_54135();
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,53855,54159);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,54183,54239);

connectionInfo.AuthenticationMechanism = f_1602_54224_54238();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,54263,54300);

f_1602_54263_54299(this, connectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,54324,54381);

connectionInfo.EnableNetworkAccess = f_1602_54361_54380();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,54615,54657);

int 
rsId = f_1602_54626_54656()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,54679,54864);

string 
rsName = (DynAbs.Tracing.TraceSender.Conditional_F1(1602, 54695, 54766)||(((f_1602_54696_54719()!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 54696, 54765)&&f_1602_54731_54761(f_1602_54731_54754())> i)) &&DynAbs.Tracing.TraceSender.Conditional_F2(1602, 54794, 54820))||DynAbs.Tracing.TraceSender.Conditional_F3(1602, 54823, 54863)))?f_1602_54794_54817()[i] :f_1602_54823_54863(out rsId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,54888,55076);

remoteRunspace = f_1602_54905_55075(f_1602_54924_54967(), connectionInfo, f_1602_55010_55019(this), f_1602_55021_55060(f_1602_55021_55039(this)), rsName, rsId);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,55100,55182);

f_1602_55100_55136(f_1602_55100_55121(remoteRunspace)).PSEventReceived += OnRunspacePSEventReceived;
                }
                catch (UriFormatException uriException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,55219,55571);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,55299,55471);

ErrorRecord 
errorRecord = f_1602_55325_55470(uriException, "CreateRemoteRunspaceFailed", ErrorCategory.InvalidArgument, f_1602_55445_55466()[i])
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,55495,55519);

f_1602_55495_55518(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,55543,55552);

continue;
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,55219,55571);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,55591,55642);

Pipeline 
pipeline = f_1602_55611_55641(this, remoteRunspace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,55662,55799);

IThrottleOperation 
operation =
f_1602_55714_55798(remoteRunspace, pipeline, f_1602_55778_55797())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,55819,55845);

f_1602_55819_55844(f_1602_55819_55829(), operation);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,2530);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,2530);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1602,52959,55871);

string[]
f_1602_53068_53089()
{
var return_v = ResolvedComputerNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 53068, 53089);
return return_v;
}


int
f_1602_53047_53090(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,string[]
computerNames)
{
this_param.ValidateComputerName( computerNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 53047, 53090);
return 0;
}


System.Management.Automation.SwitchParameter
f_1602_53231_53237()
{
var return_v = UseSSL;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 53231, 53237);
return return_v;
}


string[]
f_1602_53351_53372()
{
var return_v = ResolvedComputerNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 53351, 53372);
return return_v;
}


int
f_1602_53351_53379(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 53351, 53379);
return return_v;
}


System.Management.Automation.Runspaces.WSManConnectionInfo
f_1602_53499_53524()
{
var return_v = new System.Management.Automation.Runspaces.WSManConnectionInfo();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 53499, 53524);
return return_v;
}


string[]
f_1602_53630_53651()
{
var return_v = ResolvedComputerNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 53630, 53651);
return return_v;
}


int
f_1602_53699_53703()
{
var return_v = Port;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 53699, 53703);
return return_v;
}


string
f_1602_53751_53766()
{
var return_v = ApplicationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 53751, 53766);
return return_v;
}


string
f_1602_53815_53832()
{
var return_v = ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 53815, 53832);
return return_v;
}


string
f_1602_53859_53880()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 53859, 53880);
return return_v;
}


string
f_1602_53977_53998()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 53977, 53998);
return return_v;
}


System.Management.Automation.PSCredential
f_1602_54125_54135()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 54125, 54135);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1602_54224_54238()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 54224, 54238);
return return_v;
}


int
f_1602_54263_54299(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo)
{
this_param.UpdateConnectionInfo( connectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 54263, 54299);
return 0;
}


System.Management.Automation.SwitchParameter
f_1602_54361_54380()
{
var return_v = EnableNetworkAccess;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 54361, 54380);
return return_v;
}


int
f_1602_54626_54656()
{
var return_v = PSSession.GenerateRunspaceId();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 54626, 54656);
return return_v;
}


string[]
f_1602_54696_54719()
{
var return_v = DisconnectedSessionName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 54696, 54719);
return return_v;
}


string[]
f_1602_54731_54754()
{
var return_v = DisconnectedSessionName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 54731, 54754);
return return_v;
}


int
f_1602_54731_54761(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 54731, 54761);
return return_v;
}


string[]
f_1602_54794_54817()
{
var return_v = DisconnectedSessionName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 54794, 54817);
return return_v;
}


string
f_1602_54823_54863(out int
rtnId)
{
var return_v = PSSession.GenerateRunspaceName( out rtnId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 54823, 54863);
return return_v;
}


System.Management.Automation.Runspaces.TypeTable
f_1602_54924_54967()
{
var return_v = Utils.GetTypeTableFromExecutionContextTLS();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 54924, 54967);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1602_55010_55019(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 55010, 55019);
return return_v;
}


System.Management.Automation.Remoting.PSSessionOption
f_1602_55021_55039(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.SessionOption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 55021, 55039);
return return_v;
}


System.Management.Automation.PSPrimitiveDictionary
f_1602_55021_55060(System.Management.Automation.Remoting.PSSessionOption
this_param)
{
var return_v = this_param.ApplicationArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 55021, 55060);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1602_54905_55075(System.Management.Automation.Runspaces.TypeTable
typeTable,System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.PSPrimitiveDictionary
applicationArguments,string
name,int
id)
{
var return_v = new System.Management.Automation.RemoteRunspace( typeTable, (System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host, applicationArguments, name, id);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 54905, 55075);
return return_v;
}


System.Management.Automation.PSEventManager
f_1602_55100_55121(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.Events;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 55100, 55121);
return return_v;
}


System.Management.Automation.PSEventArgsCollection
f_1602_55100_55136(System.Management.Automation.PSEventManager
this_param)
{
var return_v = this_param.ReceivedEvents;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 55100, 55136);
return return_v;
}


string[]
f_1602_55445_55466()
{
var return_v = ResolvedComputerNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 55445, 55466);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_55325_55470(System.UriFormatException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 55325, 55470);
return return_v;
}


int
f_1602_55495_55518(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 55495, 55518);
return 0;
}


System.Management.Automation.Runspaces.Pipeline
f_1602_55611_55641(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.RemoteRunspace
remoteRunspace)
{
var return_v = this_param.CreatePipeline( remoteRunspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 55611, 55641);
return return_v;
}


bool
f_1602_55778_55797()
{
var return_v = InvokeAndDisconnect;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 55778, 55797);
return return_v;
}


Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName
f_1602_55714_55798(System.Management.Automation.RemoteRunspace
remoteRunspace,System.Management.Automation.Runspaces.Pipeline
pipeline,bool
invokeAndDisconnect)
{
var return_v = new Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName( remoteRunspace, pipeline, invokeAndDisconnect);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 55714, 55798);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1602_55819_55829()
{
var return_v = Operations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 55819, 55829);
return return_v;
}


int
f_1602_55819_55844(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
this_param,System.Management.Automation.Remoting.IThrottleOperation
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 55819, 55844);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,52959,55871);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,52959,55871);
}
		}

protected void CreateHelpersForSpecifiedSSHComputerNames()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,56021,56826);
string host = default(string);
string userName = default(string);
int port = default(int);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,56104,56815);
foreach(string computerName in f_1602_56136_56157_I(f_1602_56136_56157()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,56104,56815);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,56191,56274);

f_1602_56191_56273(this, computerName, out host, out userName, out port);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,56294,56396);

var 
sshConnectionInfo = f_1602_56318_56395(userName, host, f_1602_56356_56372(this), port, f_1602_56380_56394(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,56414,56463);

var 
typeTable = f_1602_56430_56462()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,56481,56592);

var 
remoteRunspace = f_1602_56502_56573(sshConnectionInfo, f_1602_56552_56561(this), typeTable)as RemoteRunspace
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,56610,56656);

var 
pipeline = f_1602_56625_56655(this, remoteRunspace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,56676,56756);

var 
operation = f_1602_56692_56755(remoteRunspace, pipeline)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,56774,56800);

f_1602_56774_56799(f_1602_56774_56784(), operation);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,56104,56815);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,712);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,712);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1602,56021,56826);

string[]
f_1602_56136_56157()
{
var return_v = ResolvedComputerNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 56136, 56157);
return return_v;
}


int
f_1602_56191_56273(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,string
hostname,out string
host,out string
userName,out int
port)
{
this_param.ParseSshHostName( hostname, out host, out userName, out port);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 56191, 56273);
return 0;
}


string
f_1602_56356_56372(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.KeyFilePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 56356, 56372);
return return_v;
}


string
f_1602_56380_56394(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.Subsystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 56380, 56394);
return return_v;
}


System.Management.Automation.Runspaces.SSHConnectionInfo
f_1602_56318_56395(string
userName,string
computerName,string
keyFilePath,int
port,string
subsystem)
{
var return_v = new System.Management.Automation.Runspaces.SSHConnectionInfo( userName, computerName, keyFilePath, port, subsystem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 56318, 56395);
return return_v;
}


System.Management.Automation.Runspaces.TypeTable
f_1602_56430_56462()
{
var return_v = TypeTable.LoadDefaultTypeFiles();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 56430, 56462);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1602_56552_56561(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 56552, 56561);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1602_56502_56573(System.Management.Automation.Runspaces.SSHConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Runspaces.TypeTable
typeTable)
{
var return_v = RunspaceFactory.CreateRunspace( (System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host, typeTable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 56502, 56573);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1602_56625_56655(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.RemoteRunspace
remoteRunspace)
{
var return_v = this_param.CreatePipeline( remoteRunspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 56625, 56655);
return return_v;
}


Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName
f_1602_56692_56755(System.Management.Automation.RemoteRunspace
remoteRunspace,System.Management.Automation.Runspaces.Pipeline
pipeline)
{
var return_v = new Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName( remoteRunspace, pipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 56692, 56755);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1602_56774_56784()
{
var return_v = Operations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 56774, 56784);
return return_v;
}


int
f_1602_56774_56799(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
this_param,Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName
item)
{
this_param.Add( (System.Management.Automation.Remoting.IThrottleOperation)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 56774, 56799);
return 0;
}


string[]
f_1602_56136_56157_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 56136, 56157);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,56021,56826);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,56021,56826);
}
		}

protected void CreateHelpersForSpecifiedSSHHashComputerNames()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,56965,57901);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,57052,57103);

var 
sshConnections = f_1602_57073_57102(this)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,57117,57890);
foreach(var sshConnection in f_1602_57147_57161_I(sshConnections) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,57117,57890);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,57195,57471);

var 
sshConnectionInfo = f_1602_57219_57470(sshConnection.UserName, sshConnection.ComputerName, sshConnection.KeyFilePath, sshConnection.Port, sshConnection.Subsystem)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,57489,57538);

var 
typeTable = f_1602_57505_57537()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,57556,57667);

var 
remoteRunspace = f_1602_57577_57648(sshConnectionInfo, f_1602_57627_57636(this), typeTable)as RemoteRunspace
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,57685,57731);

var 
pipeline = f_1602_57700_57730(this, remoteRunspace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,57751,57831);

var 
operation = f_1602_57767_57830(remoteRunspace, pipeline)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,57849,57875);

f_1602_57849_57874(f_1602_57849_57859(), operation);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,57117,57890);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,774);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,774);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1602,56965,57901);

Microsoft.PowerShell.Commands.SSHConnection[]
f_1602_57073_57102(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.ParseSSHConnectionHashTable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 57073, 57102);
return return_v;
}


System.Management.Automation.Runspaces.SSHConnectionInfo
f_1602_57219_57470(string
userName,string
computerName,string
keyFilePath,int
port,string
subsystem)
{
var return_v = new System.Management.Automation.Runspaces.SSHConnectionInfo( userName, computerName, keyFilePath, port, subsystem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 57219, 57470);
return return_v;
}


System.Management.Automation.Runspaces.TypeTable
f_1602_57505_57537()
{
var return_v = TypeTable.LoadDefaultTypeFiles();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 57505, 57537);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1602_57627_57636(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 57627, 57636);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1602_57577_57648(System.Management.Automation.Runspaces.SSHConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Runspaces.TypeTable
typeTable)
{
var return_v = RunspaceFactory.CreateRunspace( (System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host, typeTable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 57577, 57648);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1602_57700_57730(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.RemoteRunspace
remoteRunspace)
{
var return_v = this_param.CreatePipeline( remoteRunspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 57700, 57730);
return return_v;
}


Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName
f_1602_57767_57830(System.Management.Automation.RemoteRunspace
remoteRunspace,System.Management.Automation.Runspaces.Pipeline
pipeline)
{
var return_v = new Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName( remoteRunspace, pipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 57767, 57830);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1602_57849_57859()
{
var return_v = Operations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 57849, 57859);
return return_v;
}


int
f_1602_57849_57874(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
this_param,Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName
item)
{
this_param.Add( (System.Management.Automation.Remoting.IThrottleOperation)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 57849, 57874);
return 0;
}


Microsoft.PowerShell.Commands.SSHConnection[]
f_1602_57147_57161_I(Microsoft.PowerShell.Commands.SSHConnection[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 57147, 57161);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,56965,57901);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,56965,57901);
}
		}

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspaces")]
        protected void CreateHelpersForSpecifiedRunspaces()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,58083,59221);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,58277,58310);

RemoteRunspace[] 
remoteRunspaces
=default(RemoteRunspace[]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,58324,58345);

Pipeline[] 
pipelines
=default(Pipeline[]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,58429,58457);

int 
length = f_1602_58442_58456(f_1602_58442_58449())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,58471,58516);

remoteRunspaces = new RemoteRunspace[length];
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,58541,58546);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,58532,58669) || true) && (i < length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,58560,58563)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1602,58532,58669))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,58532,58669);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,58597,58654);

remoteRunspaces[i] = (RemoteRunspace)f_1602_58634_58653(f_1602_58634_58641()[i]);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,138);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,138);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,58840,58873);

pipelines = new Pipeline[length];
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,58898,58903);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,58889,59210) || true) && (i < length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,58917,58920)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1602,58889,59210))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,58889,59210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,58954,59004);

pipelines[i] = f_1602_58969_59003(this, remoteRunspaces[i]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,59072,59151);

IThrottleOperation 
operation = f_1602_59103_59150(pipelines[i])
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,59169,59195);

f_1602_59169_59194(f_1602_59169_59179(), operation);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,322);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,322);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1602,58083,59221);

System.Management.Automation.Runspaces.PSSession[]
f_1602_58442_58449()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 58442, 58449);
return return_v;
}


int
f_1602_58442_58456(System.Management.Automation.Runspaces.PSSession[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 58442, 58456);
return return_v;
}


System.Management.Automation.Runspaces.PSSession[]
f_1602_58634_58641()
{
var return_v = Session;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 58634, 58641);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1602_58634_58653(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 58634, 58653);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1602_58969_59003(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.RemoteRunspace
remoteRunspace)
{
var return_v = this_param.CreatePipeline( remoteRunspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 58969, 59003);
return return_v;
}


Microsoft.PowerShell.Commands.ExecutionCmdletHelperRunspace
f_1602_59103_59150(System.Management.Automation.Runspaces.Pipeline
pipeline)
{
var return_v = new Microsoft.PowerShell.Commands.ExecutionCmdletHelperRunspace( pipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 59103, 59150);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1602_59169_59179()
{
var return_v = Operations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 59169, 59179);
return return_v;
}


int
f_1602_59169_59194(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
this_param,System.Management.Automation.Remoting.IThrottleOperation
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 59169, 59194);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,58083,59221);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,58083,59221);
}
		}

protected void CreateHelpersForSpecifiedUris()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,59388,61847);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,59516,59553);

RemoteRunspace 
remoteRunspace = null
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,59576,59581);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,59567,61836) || true) && (i < f_1602_59587_59607(f_1602_59587_59600()))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,59609,59612)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1602,59567,61836))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,59567,61836);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,59690,59753);

WSManConnectionInfo 
connectionInfo = f_1602_59727_59752()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,59777,59825);

connectionInfo.ConnectionUri = f_1602_59808_59821()[i];
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,59847,59891);

connectionInfo.ShellUri = f_1602_59873_59890();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,59915,60219) || true) && (f_1602_59919_59940()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,59915,60219);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,59998,60059);

connectionInfo.CertificateThumbprint = f_1602_60037_60058();
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,59915,60219);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,59915,60219);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,60157,60196);

connectionInfo.Credential = f_1602_60185_60195();
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,59915,60219);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,60243,60299);

connectionInfo.AuthenticationMechanism = f_1602_60284_60298();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,60323,60360);

f_1602_60323_60359(this, connectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,60384,60441);

connectionInfo.EnableNetworkAccess = f_1602_60421_60440();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,60465,60692);

remoteRunspace = (RemoteRunspace)f_1602_60498_60691(connectionInfo, f_1602_60545_60554(this), f_1602_60581_60624(), f_1602_60651_60690(f_1602_60651_60669(this)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,60716,60831);

f_1602_60716_60830(remoteRunspace != null, "RemoteRunspace object created using URI is null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,60855,60937);

f_1602_60855_60891(f_1602_60855_60876(remoteRunspace)).PSEventReceived += OnRunspacePSEventReceived;
                }
                catch (UriFormatException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,60974,61151);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,61043,61101);

f_1602_61043_61100(this, e, f_1602_61083_61096()[i]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,61123,61132);

continue;
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,60974,61151);
                }
                catch (InvalidOperationException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,61169,61353);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,61245,61303);

f_1602_61245_61302(this, e, f_1602_61285_61298()[i]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,61325,61334);

continue;
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,61169,61353);
                }
                catch (ArgumentException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,61371,61547);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,61439,61497);

f_1602_61439_61496(this, e, f_1602_61479_61492()[i]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,61519,61528);

continue;
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,61371,61547);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,61567,61618);

Pipeline 
pipeline = f_1602_61587_61617(this, remoteRunspace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,61638,61775);

IThrottleOperation 
operation =
f_1602_61690_61774(remoteRunspace, pipeline, f_1602_61754_61773())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,61795,61821);

f_1602_61795_61820(f_1602_61795_61805(), operation);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,2270);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,2270);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1602,59388,61847);

System.Uri[]
f_1602_59587_59600()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 59587, 59600);
return return_v;
}


int
f_1602_59587_59607(System.Uri[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 59587, 59607);
return return_v;
}


System.Management.Automation.Runspaces.WSManConnectionInfo
f_1602_59727_59752()
{
var return_v = new System.Management.Automation.Runspaces.WSManConnectionInfo();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 59727, 59752);
return return_v;
}


System.Uri[]
f_1602_59808_59821()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 59808, 59821);
return return_v;
}


string
f_1602_59873_59890()
{
var return_v = ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 59873, 59890);
return return_v;
}


string
f_1602_59919_59940()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 59919, 59940);
return return_v;
}


string
f_1602_60037_60058()
{
var return_v = CertificateThumbprint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 60037, 60058);
return return_v;
}


System.Management.Automation.PSCredential
f_1602_60185_60195()
{
var return_v = Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 60185, 60195);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1602_60284_60298()
{
var return_v = Authentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 60284, 60298);
return return_v;
}


int
f_1602_60323_60359(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo)
{
this_param.UpdateConnectionInfo( connectionInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 60323, 60359);
return 0;
}


System.Management.Automation.SwitchParameter
f_1602_60421_60440()
{
var return_v = EnableNetworkAccess;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 60421, 60440);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1602_60545_60554(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 60545, 60554);
return return_v;
}


System.Management.Automation.Runspaces.TypeTable
f_1602_60581_60624()
{
var return_v = Utils.GetTypeTableFromExecutionContextTLS();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 60581, 60624);
return return_v;
}


System.Management.Automation.Remoting.PSSessionOption
f_1602_60651_60669(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.SessionOption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 60651, 60669);
return return_v;
}


System.Management.Automation.PSPrimitiveDictionary
f_1602_60651_60690(System.Management.Automation.Remoting.PSSessionOption
this_param)
{
var return_v = this_param.ApplicationArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 60651, 60690);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1602_60498_60691(System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Runspaces.TypeTable
typeTable,System.Management.Automation.PSPrimitiveDictionary
applicationArguments)
{
var return_v = RunspaceFactory.CreateRunspace( (System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host, typeTable, applicationArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 60498, 60691);
return return_v;
}


int
f_1602_60716_60830(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 60716, 60830);
return 0;
}


System.Management.Automation.PSEventManager
f_1602_60855_60876(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.Events;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 60855, 60876);
return return_v;
}


System.Management.Automation.PSEventArgsCollection
f_1602_60855_60891(System.Management.Automation.PSEventManager
this_param)
{
var return_v = this_param.ReceivedEvents;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 60855, 60891);
return return_v;
}


System.Uri[]
f_1602_61083_61096()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 61083, 61096);
return return_v;
}


int
f_1602_61043_61100(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.UriFormatException
e,System.Uri
uri)
{
this_param.WriteErrorCreateRemoteRunspaceFailed( (System.Exception)e, uri);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 61043, 61100);
return 0;
}


System.Uri[]
f_1602_61285_61298()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 61285, 61298);
return return_v;
}


int
f_1602_61245_61302(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.InvalidOperationException
e,System.Uri
uri)
{
this_param.WriteErrorCreateRemoteRunspaceFailed( (System.Exception)e, uri);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 61245, 61302);
return 0;
}


System.Uri[]
f_1602_61479_61492()
{
var return_v = ConnectionUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 61479, 61492);
return return_v;
}


int
f_1602_61439_61496(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.ArgumentException
e,System.Uri
uri)
{
this_param.WriteErrorCreateRemoteRunspaceFailed( (System.Exception)e, uri);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 61439, 61496);
return 0;
}


System.Management.Automation.Runspaces.Pipeline
f_1602_61587_61617(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.RemoteRunspace
remoteRunspace)
{
var return_v = this_param.CreatePipeline( remoteRunspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 61587, 61617);
return return_v;
}


bool
f_1602_61754_61773()
{
var return_v = InvokeAndDisconnect;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 61754, 61773);
return return_v;
}


Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName
f_1602_61690_61774(System.Management.Automation.RemoteRunspace
remoteRunspace,System.Management.Automation.Runspaces.Pipeline
pipeline,bool
invokeAndDisconnect)
{
var return_v = new Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName( remoteRunspace, pipeline, invokeAndDisconnect);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 61690, 61774);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1602_61795_61805()
{
var return_v = Operations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 61795, 61805);
return return_v;
}


int
f_1602_61795_61820(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
this_param,System.Management.Automation.Remoting.IThrottleOperation
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 61795, 61820);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,59388,61847);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,59388,61847);
}
		}

protected virtual void CreateHelpersForSpecifiedVMSession()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,62012,70023);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,62096,62115);

int 
inputArraySize
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,62129,62139);

int 
index
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,62153,62168);

string 
command
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,62182,62201);

bool[] 
vmIsRunning
=default(bool[]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,62215,62244);

Collection<PSObject> 
results
=default(Collection<PSObject>);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,62260,66170) || true) && ((f_1602_62265_62281()== PSExecutionCmdlet.VMIdParameterSet) ||(DynAbs.Tracing.TraceSender.Expression_False(1602, 62264, 62405)||                (f_1602_62342_62358()== PSExecutionCmdlet.FilePathVMIdParameterSet)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,62260,66170);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,62439,62473);

inputArraySize = f_1602_62456_62472(f_1602_62456_62465(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,62491,62532);

this.VMName = new string[inputArraySize];
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,62550,62589);

vmIsRunning = new bool[inputArraySize];
try {
                for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,62614,62623)
,index = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,62609,64086) || true) && (index < inputArraySize)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,62649,62656)
,index++,DynAbs.Tracing.TraceSender.TraceExitCondition(1602,62609,64086))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,62609,64086);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,62698,62725);

vmIsRunning[index] = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,62749,62781);

command = "Get-VM -Id $args[0]";

                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,62857,62995);

results = f_1602_62867_62994(f_1602_62867_62885(this), command, false, PipelineResultTypes.None, null, f_1602_62977_62986(this)[index]);
                    }
                    catch (CommandNotFoundException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,63040,63542);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,63121,63484);

f_1602_63121_63483(this, f_1602_63173_63482(f_1602_63223_63293(f_1602_63245_63292()), f_1602_63328_63381(                                PSRemotingErrorId.HyperVModuleNotAvailable), ErrorCategory.NotInstalled, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,63512,63519);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,63040,63542);
                    }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,63566,64067) || true) && (f_1602_63570_63583(results)!= 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,63566,64067);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,63638,63672);

f_1602_63638_63649(this)[index] = string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,63566,64067);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,63566,64067);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,63770,63837);

f_1602_63770_63781(this)[index] = (string)f_1602_63799_63836(f_1602_63799_63830(f_1602_63799_63820(f_1602_63799_63809(results, 0)), "VMName"));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,63865,64044) || true) && ((VMState)f_1602_63878_63914(f_1602_63878_63908(f_1602_63878_63899(f_1602_63878_63888(results, 0)), "State"))== VMState.Running)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,63865,64044);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,63991,64017);

vmIsRunning[index] = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,63865,64044);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,63566,64067);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,1478);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,1478);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1602,62260,66170);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,62260,66170);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,64152,64406);

f_1602_64152_64405((f_1602_64164_64180()== PSExecutionCmdlet.VMNameParameterSet) ||(DynAbs.Tracing.TraceSender.Expression_False(1602, 64163, 64319)||                           (f_1602_64254_64270()== PSExecutionCmdlet.FilePathVMNameParameterSet)), "Expected ParameterSetName == VMName or FilePathVMName");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,64426,64462);

inputArraySize = f_1602_64443_64461(f_1602_64443_64454(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,64480,64517);

this.VMId = new Guid[inputArraySize];
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,64535,64574);

vmIsRunning = new bool[inputArraySize];
try {
                for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,64599,64608)
,index = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,64594,66155) || true) && (index < inputArraySize)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,64634,64641)
,index++,DynAbs.Tracing.TraceSender.TraceExitCondition(1602,64594,66155))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,64594,66155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,64683,64710);

vmIsRunning[index] = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,64734,64765);

command = "Get-VM -Name $args";

                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,64841,64981);

results = f_1602_64851_64980(f_1602_64851_64869(this), command, false, PipelineResultTypes.None, null, f_1602_64961_64972(this)[index]);
                    }
                    catch (CommandNotFoundException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,65026,65528);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,65107,65470);

f_1602_65107_65469(this, f_1602_65159_65468(f_1602_65209_65279(f_1602_65231_65278()), f_1602_65314_65367(                                PSRemotingErrorId.HyperVModuleNotAvailable), ErrorCategory.NotInstalled, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,65498,65505);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,65026,65528);
                    }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,65552,66136) || true) && (f_1602_65556_65569(results)!= 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,65552,66136);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,65624,65654);

f_1602_65624_65633(this)[index] = Guid.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,65552,66136);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,65552,66136);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,65752,65813);

f_1602_65752_65761(this)[index] = (Guid)f_1602_65777_65812(f_1602_65777_65806(f_1602_65777_65798(f_1602_65777_65787(results, 0)), "VMId"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,65839,65906);

f_1602_65839_65850(this)[index] = (string)f_1602_65868_65905(f_1602_65868_65899(f_1602_65868_65889(f_1602_65868_65878(results, 0)), "VMName"));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,65934,66113) || true) && ((VMState)f_1602_65947_65983(f_1602_65947_65977(f_1602_65947_65968(f_1602_65947_65957(results, 0)), "State"))== VMState.Running)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,65934,66113);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,66060,66086);

vmIsRunning[index] = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,65934,66113);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,65552,66136);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,1562);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,1562);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1602,62260,66170);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,66186,66222);

ResolvedComputerNames = f_1602_66210_66221(this);
try {
            for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,66243,66252)
,index = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,66238,70012) || true) && (index < f_1602_66262_66290(f_1602_66262_66283()))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,66292,66299)
,index++,DynAbs.Tracing.TraceSender.TraceExitCondition(1602,66238,70012))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,66238,70012);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,66333,68388) || true) && ((f_1602_66338_66347(this)[index] == Guid.Empty) &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 66337, 66546)&&                    ((f_1602_66396_66412()== PSExecutionCmdlet.VMNameParameterSet) ||(DynAbs.Tracing.TraceSender.Expression_False(1602, 66395, 66545)||                     (f_1602_66480_66496()== PSExecutionCmdlet.FilePathVMNameParameterSet)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,66333,68388);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,66588,67013);

f_1602_66588_67012(this, f_1602_66625_67011(f_1602_66671_66833(f_1602_66693_66832(this, f_1602_66704_66749(), f_1602_66813_66824(this)[index])), f_1602_66864_66915(                            PSRemotingErrorId.InvalidVMNameNotSingle), ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,67037,67046);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,66333,68388);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,66333,68388);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,67088,68388) || true) && ((f_1602_67093_67104(this)[index] == string.Empty) &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 67092, 67311)&&                         ((f_1602_67160_67176()== PSExecutionCmdlet.VMIdParameterSet) ||(DynAbs.Tracing.TraceSender.Expression_False(1602, 67159, 67310)||                          (f_1602_67247_67263()== PSExecutionCmdlet.FilePathVMIdParameterSet)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,67088,68388);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,67353,67787);

f_1602_67353_67786(this, f_1602_67390_67785(f_1602_67436_67609(f_1602_67458_67608(this, f_1602_67469_67512(), f_1602_67576_67585(this)[index].ToString(null))), f_1602_67640_67689(                            PSRemotingErrorId.InvalidVMIdNotSingle), ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,67811,67820);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,67088,68388);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,67088,68388);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,67862,68388) || true) && (!vmIsRunning[index])
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,67862,68388);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,67927,68336);

f_1602_67927_68335(this, f_1602_67964_68334(f_1602_68010_68164(f_1602_68032_68163(this, f_1602_68043_68080(), f_1602_68144_68155(this)[index])), f_1602_68195_68238(                            PSRemotingErrorId.InvalidVMState), ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,68360,68369);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,67862,68388);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,67088,68388);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,66333,68388);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,68472,68509);

RemoteRunspace 
remoteRunspace = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,68527,68559);

VMConnectionInfo 
connectionInfo
=default(VMConnectionInfo);

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,68623,68740);

connectionInfo = f_1602_68640_68739(f_1602_68661_68676(this), f_1602_68678_68687(this)[index], f_1602_68696_68707(this)[index], f_1602_68716_68738(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,68764,68913);

remoteRunspace = f_1602_68781_68912(f_1602_68800_68843(), connectionInfo, f_1602_68886_68895(this), null, null, -1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,68937,69019);

f_1602_68937_68973(f_1602_68937_68958(remoteRunspace)).PSEventReceived += OnRunspacePSEventReceived;
                }
                catch (InvalidOperationException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,69056,69392);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,69132,69325);

ErrorRecord 
errorRecord = f_1602_69158_69324(e, "CreateRemoteRunspaceForVMFailed", ErrorCategory.InvalidOperation, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,69349,69373);

f_1602_69349_69372(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,69056,69392);
                }
                catch (ArgumentException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,69410,69737);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,69478,69670);

ErrorRecord 
errorRecord = f_1602_69504_69669(e, "CreateRemoteRunspaceForVMFailed", ErrorCategory.InvalidArgument, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,69694,69718);

f_1602_69694_69717(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,69410,69737);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,69757,69808);

Pipeline 
pipeline = f_1602_69777_69807(this, remoteRunspace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,69828,69951);

IThrottleOperation 
operation =
f_1602_69880_69950(remoteRunspace, pipeline, false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,69971,69997);

f_1602_69971_69996(f_1602_69971_69981(), operation);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,3775);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,3775);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1602,62012,70023);

string
f_1602_62265_62281()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 62265, 62281);
return return_v;
}


string
f_1602_62342_62358()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 62342, 62358);
return return_v;
}


System.Guid[]
f_1602_62456_62465(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.VMId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 62456, 62465);
return return_v;
}


int
f_1602_62456_62472(System.Guid[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 62456, 62472);
return return_v;
}


System.Management.Automation.CommandInvocationIntrinsics
f_1602_62867_62885(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.InvokeCommand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 62867, 62885);
return return_v;
}


System.Guid[]
f_1602_62977_62986(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.VMId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 62977, 62986);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1602_62867_62994(System.Management.Automation.CommandInvocationIntrinsics
this_param,string
script,bool
useNewScope,System.Management.Automation.Runspaces.PipelineResultTypes
writeToPipeline,System.Collections.IList
input,params object[]
args)
{
var return_v = this_param.InvokeScript( script, useNewScope, writeToPipeline, input, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 62867, 62994);
return return_v;
}


string
f_1602_63245_63292()
{
var return_v = RemotingErrorIdStrings.HyperVModuleNotAvailable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 63245, 63292);
return return_v;
}


System.ArgumentException
f_1602_63223_63293(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 63223, 63293);
return return_v;
}


string
f_1602_63328_63381(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 63328, 63381);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_63173_63482(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 63173, 63482);
return return_v;
}


int
f_1602_63121_63483(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 63121, 63483);
return 0;
}


int
f_1602_63570_63583(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 63570, 63583);
return return_v;
}


string[]
f_1602_63638_63649(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 63638, 63649);
return return_v;
}


string[]
f_1602_63770_63781(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 63770, 63781);
return return_v;
}


System.Management.Automation.PSObject
f_1602_63799_63809(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 63799, 63809);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1602_63799_63820(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 63799, 63820);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1602_63799_63830(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 63799, 63830);
return return_v;
}


object
f_1602_63799_63836(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 63799, 63836);
return return_v;
}


System.Management.Automation.PSObject
f_1602_63878_63888(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 63878, 63888);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1602_63878_63899(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 63878, 63899);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1602_63878_63908(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 63878, 63908);
return return_v;
}


object
f_1602_63878_63914(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 63878, 63914);
return return_v;
}


string
f_1602_64164_64180()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 64164, 64180);
return return_v;
}


string
f_1602_64254_64270()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 64254, 64270);
return return_v;
}


int
f_1602_64152_64405(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 64152, 64405);
return 0;
}


string[]
f_1602_64443_64454(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 64443, 64454);
return return_v;
}


int
f_1602_64443_64461(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 64443, 64461);
return return_v;
}


System.Management.Automation.CommandInvocationIntrinsics
f_1602_64851_64869(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.InvokeCommand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 64851, 64869);
return return_v;
}


string[]
f_1602_64961_64972(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 64961, 64972);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1602_64851_64980(System.Management.Automation.CommandInvocationIntrinsics
this_param,string
script,bool
useNewScope,System.Management.Automation.Runspaces.PipelineResultTypes
writeToPipeline,System.Collections.IList
input,params object[]
args)
{
var return_v = this_param.InvokeScript( script, useNewScope, writeToPipeline, input, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 64851, 64980);
return return_v;
}


string
f_1602_65231_65278()
{
var return_v = RemotingErrorIdStrings.HyperVModuleNotAvailable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 65231, 65278);
return return_v;
}


System.ArgumentException
f_1602_65209_65279(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 65209, 65279);
return return_v;
}


string
f_1602_65314_65367(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 65314, 65367);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_65159_65468(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 65159, 65468);
return return_v;
}


int
f_1602_65107_65469(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 65107, 65469);
return 0;
}


int
f_1602_65556_65569(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 65556, 65569);
return return_v;
}


System.Guid[]
f_1602_65624_65633(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.VMId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 65624, 65633);
return return_v;
}


System.Guid[]
f_1602_65752_65761(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.VMId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 65752, 65761);
return return_v;
}


System.Management.Automation.PSObject
f_1602_65777_65787(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 65777, 65787);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1602_65777_65798(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 65777, 65798);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1602_65777_65806(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 65777, 65806);
return return_v;
}


object
f_1602_65777_65812(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 65777, 65812);
return return_v;
}


string[]
f_1602_65839_65850(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 65839, 65850);
return return_v;
}


System.Management.Automation.PSObject
f_1602_65868_65878(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 65868, 65878);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1602_65868_65889(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 65868, 65889);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1602_65868_65899(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 65868, 65899);
return return_v;
}


object
f_1602_65868_65905(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 65868, 65905);
return return_v;
}


System.Management.Automation.PSObject
f_1602_65947_65957(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 65947, 65957);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1602_65947_65968(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 65947, 65968);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1602_65947_65977(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 65947, 65977);
return return_v;
}


object
f_1602_65947_65983(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 65947, 65983);
return return_v;
}


string[]
f_1602_66210_66221(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 66210, 66221);
return return_v;
}


string[]
f_1602_66262_66283()
{
var return_v = ResolvedComputerNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 66262, 66283);
return return_v;
}


int
f_1602_66262_66290(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 66262, 66290);
return return_v;
}


System.Guid[]
f_1602_66338_66347(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.VMId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 66338, 66347);
return return_v;
}


string
f_1602_66396_66412()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 66396, 66412);
return return_v;
}


string
f_1602_66480_66496()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 66480, 66496);
return return_v;
}


string
f_1602_66704_66749()
{
var return_v = RemotingErrorIdStrings.InvalidVMNameNotSingle;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 66704, 66749);
return return_v;
}


string[]
f_1602_66813_66824(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 66813, 66824);
return return_v;
}


string
f_1602_66693_66832(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,string
resourceString,params object[]
args)
{
var return_v = this_param.GetMessage( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 66693, 66832);
return return_v;
}


System.ArgumentException
f_1602_66671_66833(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 66671, 66833);
return return_v;
}


string
f_1602_66864_66915(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 66864, 66915);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_66625_67011(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 66625, 67011);
return return_v;
}


int
f_1602_66588_67012(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 66588, 67012);
return 0;
}


string[]
f_1602_67093_67104(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 67093, 67104);
return return_v;
}


string
f_1602_67160_67176()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 67160, 67176);
return return_v;
}


string
f_1602_67247_67263()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 67247, 67263);
return return_v;
}


string
f_1602_67469_67512()
{
var return_v = RemotingErrorIdStrings.InvalidVMIdNotSingle;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 67469, 67512);
return return_v;
}


System.Guid[]
f_1602_67576_67585(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.VMId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 67576, 67585);
return return_v;
}


string
f_1602_67458_67608(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,string
resourceString,params object[]
args)
{
var return_v = this_param.GetMessage( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 67458, 67608);
return return_v;
}


System.ArgumentException
f_1602_67436_67609(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 67436, 67609);
return return_v;
}


string
f_1602_67640_67689(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 67640, 67689);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_67390_67785(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 67390, 67785);
return return_v;
}


int
f_1602_67353_67786(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 67353, 67786);
return 0;
}


string
f_1602_68043_68080()
{
var return_v = RemotingErrorIdStrings.InvalidVMState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 68043, 68080);
return return_v;
}


string[]
f_1602_68144_68155(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 68144, 68155);
return return_v;
}


string
f_1602_68032_68163(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,string
resourceString,params object[]
args)
{
var return_v = this_param.GetMessage( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 68032, 68163);
return return_v;
}


System.ArgumentException
f_1602_68010_68164(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 68010, 68164);
return return_v;
}


string
f_1602_68195_68238(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 68195, 68238);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_67964_68334(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 67964, 68334);
return return_v;
}


int
f_1602_67927_68335(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 67927, 68335);
return 0;
}


System.Management.Automation.PSCredential
f_1602_68661_68676(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 68661, 68676);
return return_v;
}


System.Guid[]
f_1602_68678_68687(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.VMId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 68678, 68687);
return return_v;
}


string[]
f_1602_68696_68707(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 68696, 68707);
return return_v;
}


string
f_1602_68716_68738(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 68716, 68738);
return return_v;
}


System.Management.Automation.Runspaces.VMConnectionInfo
f_1602_68640_68739(System.Management.Automation.PSCredential
credential,System.Guid
vmGuid,string
vmName,string
configurationName)
{
var return_v = new System.Management.Automation.Runspaces.VMConnectionInfo( credential, vmGuid, vmName, configurationName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 68640, 68739);
return return_v;
}


System.Management.Automation.Runspaces.TypeTable
f_1602_68800_68843()
{
var return_v = Utils.GetTypeTableFromExecutionContextTLS();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 68800, 68843);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1602_68886_68895(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 68886, 68895);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1602_68781_68912(System.Management.Automation.Runspaces.TypeTable
typeTable,System.Management.Automation.Runspaces.VMConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.PSPrimitiveDictionary
applicationArguments,string
name,int
id)
{
var return_v = new System.Management.Automation.RemoteRunspace( typeTable, (System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host, applicationArguments, name, id);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 68781, 68912);
return return_v;
}


System.Management.Automation.PSEventManager
f_1602_68937_68958(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.Events;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 68937, 68958);
return return_v;
}


System.Management.Automation.PSEventArgsCollection
f_1602_68937_68973(System.Management.Automation.PSEventManager
this_param)
{
var return_v = this_param.ReceivedEvents;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 68937, 68973);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_69158_69324(System.InvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 69158, 69324);
return return_v;
}


int
f_1602_69349_69372(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 69349, 69372);
return 0;
}


System.Management.Automation.ErrorRecord
f_1602_69504_69669(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 69504, 69669);
return return_v;
}


int
f_1602_69694_69717(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 69694, 69717);
return 0;
}


System.Management.Automation.Runspaces.Pipeline
f_1602_69777_69807(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.RemoteRunspace
remoteRunspace)
{
var return_v = this_param.CreatePipeline( remoteRunspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 69777, 69807);
return return_v;
}


Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName
f_1602_69880_69950(System.Management.Automation.RemoteRunspace
remoteRunspace,System.Management.Automation.Runspaces.Pipeline
pipeline,bool
invokeAndDisconnect)
{
var return_v = new Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName( remoteRunspace, pipeline, invokeAndDisconnect);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 69880, 69950);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1602_69971_69981()
{
var return_v = Operations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 69971, 69981);
return return_v;
}


int
f_1602_69971_69996(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
this_param,System.Management.Automation.Remoting.IThrottleOperation
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 69971, 69996);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,62012,70023);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,62012,70023);
}
		}

protected virtual void CreateHelpersForSpecifiedContainerSession()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,70190,73244);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,70281,70332);

List<string> 
resolvedNameList = f_1602_70313_70331()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,70348,70614);

f_1602_70348_70613((f_1602_70360_70376()== PSExecutionCmdlet.ContainerIdParameterSet) ||(DynAbs.Tracing.TraceSender.Expression_False(1602, 70359, 70521)||                       (f_1602_70451_70467()== PSExecutionCmdlet.FilePathContainerIdParameterSet)), "Expected ParameterSetName == ContainerId or FilePathContainerId");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,70630,73166);
foreach(var input in f_1602_70652_70663_I(f_1602_70652_70663()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,70630,73166);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,70805,70842);

RemoteRunspace 
remoteRunspace = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,70860,70906);

ContainerConnectionInfo 
connectionInfo = null
;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,71172,71304);

connectionInfo = f_1602_71189_71303(input, f_1602_71250_71268().IsPresent, f_1602_71280_71302(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,71328,71378);

f_1602_71328_71377(
                    resolvedNameList, f_1602_71349_71376(connectionInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,71402,71442);

f_1602_71402_71441(
                    connectionInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,71466,71615);

remoteRunspace = f_1602_71483_71614(f_1602_71502_71545(), connectionInfo, f_1602_71588_71597(this), null, null, -1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,71639,71721);

f_1602_71639_71675(f_1602_71639_71660(remoteRunspace)).PSEventReceived += OnRunspacePSEventReceived;
                }
                catch (InvalidOperationException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,71758,72132);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,71834,72034);

ErrorRecord 
errorRecord = f_1602_71860_72033(e, "CreateRemoteRunspaceForContainerFailed", ErrorCategory.InvalidOperation, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,72058,72082);

f_1602_72058_72081(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,72104,72113);

continue;
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,71758,72132);
                }
                catch (ArgumentException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,72150,72515);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,72218,72417);

ErrorRecord 
errorRecord = f_1602_72244_72416(e, "CreateRemoteRunspaceForContainerFailed", ErrorCategory.InvalidArgument, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,72441,72465);

f_1602_72441_72464(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,72487,72496);

continue;
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,72150,72515);
                }
                catch (Exception e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,72533,72891);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,72593,72793);

ErrorRecord 
errorRecord = f_1602_72619_72792(e, "CreateRemoteRunspaceForContainerFailed", ErrorCategory.InvalidOperation, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,72817,72841);

f_1602_72817_72840(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,72863,72872);

continue;
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,72533,72891);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,72911,72962);

Pipeline 
pipeline = f_1602_72931_72961(this, remoteRunspace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,72982,73105);

IThrottleOperation 
operation =
f_1602_73034_73104(remoteRunspace, pipeline, false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,73125,73151);

f_1602_73125_73150(f_1602_73125_73135(), operation);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,70630,73166);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,2537);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,2537);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,73182,73233);

ResolvedComputerNames = f_1602_73206_73232(resolvedNameList);
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,70190,73244);

System.Collections.Generic.List<string>
f_1602_70313_70331()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 70313, 70331);
return return_v;
}


string
f_1602_70360_70376()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 70360, 70376);
return return_v;
}


string
f_1602_70451_70467()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 70451, 70467);
return return_v;
}


int
f_1602_70348_70613(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 70348, 70613);
return 0;
}


string[]
f_1602_70652_70663()
{
var return_v = ContainerId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 70652, 70663);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1602_71250_71268()
{
var return_v = RunAsAdministrator;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 71250, 71268);
return return_v;
}


string
f_1602_71280_71302(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.ConfigurationName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 71280, 71302);
return return_v;
}


System.Management.Automation.Runspaces.ContainerConnectionInfo
f_1602_71189_71303(string
containerId,bool
runAsAdmin,string
configurationName)
{
var return_v = ContainerConnectionInfo.CreateContainerConnectionInfo( containerId, runAsAdmin, configurationName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 71189, 71303);
return return_v;
}


string
f_1602_71349_71376(System.Management.Automation.Runspaces.ContainerConnectionInfo
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 71349, 71376);
return return_v;
}


int
f_1602_71328_71377(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 71328, 71377);
return 0;
}


int
f_1602_71402_71441(System.Management.Automation.Runspaces.ContainerConnectionInfo
this_param)
{
this_param.CreateContainerProcess();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 71402, 71441);
return 0;
}


System.Management.Automation.Runspaces.TypeTable
f_1602_71502_71545()
{
var return_v = Utils.GetTypeTableFromExecutionContextTLS();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 71502, 71545);
return return_v;
}


System.Management.Automation.Host.PSHost
f_1602_71588_71597(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 71588, 71597);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1602_71483_71614(System.Management.Automation.Runspaces.TypeTable
typeTable,System.Management.Automation.Runspaces.ContainerConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.PSPrimitiveDictionary
applicationArguments,string
name,int
id)
{
var return_v = new System.Management.Automation.RemoteRunspace( typeTable, (System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host, applicationArguments, name, id);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 71483, 71614);
return return_v;
}


System.Management.Automation.PSEventManager
f_1602_71639_71660(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.Events;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 71639, 71660);
return return_v;
}


System.Management.Automation.PSEventArgsCollection
f_1602_71639_71675(System.Management.Automation.PSEventManager
this_param)
{
var return_v = this_param.ReceivedEvents;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 71639, 71675);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_71860_72033(System.InvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 71860, 72033);
return return_v;
}


int
f_1602_72058_72081(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 72058, 72081);
return 0;
}


System.Management.Automation.ErrorRecord
f_1602_72244_72416(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 72244, 72416);
return return_v;
}


int
f_1602_72441_72464(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 72441, 72464);
return 0;
}


System.Management.Automation.ErrorRecord
f_1602_72619_72792(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 72619, 72792);
return return_v;
}


int
f_1602_72817_72840(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 72817, 72840);
return 0;
}


System.Management.Automation.Runspaces.Pipeline
f_1602_72931_72961(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.RemoteRunspace
remoteRunspace)
{
var return_v = this_param.CreatePipeline( remoteRunspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 72931, 72961);
return return_v;
}


Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName
f_1602_73034_73104(System.Management.Automation.RemoteRunspace
remoteRunspace,System.Management.Automation.Runspaces.Pipeline
pipeline,bool
invokeAndDisconnect)
{
var return_v = new Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName( remoteRunspace, pipeline, invokeAndDisconnect);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 73034, 73104);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1602_73125_73135()
{
var return_v = Operations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 73125, 73135);
return return_v;
}


int
f_1602_73125_73150(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
this_param,System.Management.Automation.Remoting.IThrottleOperation
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 73125, 73150);
return 0;
}


string[]
f_1602_70652_70663_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 70652, 70663);
return return_v;
}


string[]
f_1602_73206_73232(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 73206, 73232);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,70190,73244);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,70190,73244);
}
		}

internal Pipeline CreatePipeline(RemoteRunspace remoteRunspace)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,73492,74853);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,74027,74093);

string 
serverPsVersion = f_1602_74052_74092(this, remoteRunspace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,74107,74413);

System.Management.Automation.PowerShell 
powershellToUse = (DynAbs.Tracing.TraceSender.Conditional_F1(1602, 74165, 74190)||(((serverPsVersion == PSv2)
&&DynAbs.Tracing.TraceSender.Conditional_F2(1602, 74268, 74290))||DynAbs.Tracing.TraceSender.Conditional_F3(1602, 74368, 74412)))?f_1602_74268_74290(this):f_1602_74368_74412(this, serverPsVersion)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,74427,74550);

Pipeline 
pipeline =
f_1602_74464_74549(                remoteRunspace, f_1602_74494_74542(f_1602_74494_74530(f_1602_74494_74527(f_1602_74494_74518(powershellToUse)), 0)), true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,74566,74592);

f_1602_74566_74591(f_1602_74566_74583(pipeline));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,74608,74749);
foreach(Command command in f_1602_74636_74669_I(f_1602_74636_74669(f_1602_74636_74660(powershellToUse))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,74608,74749);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,74703,74734);

f_1602_74703_74733(f_1602_74703_74720(pipeline), command);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,74608,74749);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,142);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,142);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,74765,74810);

pipeline.RedirectShellErrorOutputPipe = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,74826,74842);

return pipeline;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,73492,74853);

string
f_1602_74052_74092(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.RemoteRunspace
remoteRunspace)
{
var return_v = this_param.GetRemoteServerPsVersion( remoteRunspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 74052, 74092);
return return_v;
}


System.Management.Automation.PowerShell
f_1602_74268_74290(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.GetPowerShellForPSv2();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 74268, 74290);
return return_v;
}


System.Management.Automation.PowerShell
f_1602_74368_74412(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,string
serverPsVersion)
{
var return_v = this_param.GetPowerShellForPSv3OrLater( serverPsVersion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 74368, 74412);
return return_v;
}


System.Management.Automation.PSCommand
f_1602_74494_74518(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 74494, 74518);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_1602_74494_74527(System.Management.Automation.PSCommand
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 74494, 74527);
return return_v;
}


System.Management.Automation.Runspaces.Command
f_1602_74494_74530(System.Management.Automation.Runspaces.CommandCollection
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 74494, 74530);
return return_v;
}


string
f_1602_74494_74542(System.Management.Automation.Runspaces.Command
this_param)
{
var return_v = this_param.CommandText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 74494, 74542);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1602_74464_74549(System.Management.Automation.RemoteRunspace
this_param,string
command,bool
addToHistory)
{
var return_v = this_param.CreatePipeline( command, addToHistory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 74464, 74549);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_1602_74566_74583(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 74566, 74583);
return return_v;
}


int
f_1602_74566_74591(System.Management.Automation.Runspaces.CommandCollection
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 74566, 74591);
return 0;
}


System.Management.Automation.PSCommand
f_1602_74636_74660(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 74636, 74660);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_1602_74636_74669(System.Management.Automation.PSCommand
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 74636, 74669);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_1602_74703_74720(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 74703, 74720);
return return_v;
}


int
f_1602_74703_74733(System.Management.Automation.Runspaces.CommandCollection
this_param,System.Management.Automation.Runspaces.Command
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 74703, 74733);
return 0;
}


System.Management.Automation.Runspaces.CommandCollection
f_1602_74636_74669_I(System.Management.Automation.Runspaces.CommandCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 74636, 74669);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,73492,74853);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,73492,74853);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string GetRemoteServerPsVersion(RemoteRunspace remoteRunspace)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,74976,77276);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,75071,75332) || true) && (f_1602_75075_75104(remoteRunspace)is NewProcessConnectionInfo)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,75071,75332);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,75298,75317);

return PSv5OrLater;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,75071,75332);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,75348,75440);

PSPrimitiveDictionary 
psApplicationPrivateData = f_1602_75397_75439(remoteRunspace)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,75454,75882) || true) && (psApplicationPrivateData == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,75454,75882);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,75855,75867);

return PSv2;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,75454,75882);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,76300,77237) || true) && (f_1602_76304_76332(remoteRunspace))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,76300,77237);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,76366,76397);

Version 
serverPsVersion = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,76415,76643);

f_1602_76415_76642(psApplicationPrivateData, out serverPsVersion, PSVersionInfo.PSVersionTableName, PSVersionInfo.PSVersionName);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,76663,76810) || true) && (serverPsVersion != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,76663,76810);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,76732,76791);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1602, 76739, 76765)||((f_1602_76739_76760(serverPsVersion)>= 5 &&DynAbs.Tracing.TraceSender.Conditional_F2(1602, 76768, 76779))||DynAbs.Tracing.TraceSender.Conditional_F3(1602, 76782, 76790)))?PSv5OrLater :PSv3Orv4;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,76663,76810);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,77085,77222);

f_1602_77085_77221(false, "Application private data is available but we failed to get the server powershell version. This should never happen.");
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,76300,77237);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,77253,77265);

return PSv2;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,74976,77276);

System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1602_75075_75104(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.ConnectionInfo ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 75075, 75104);
return return_v;
}


System.Management.Automation.PSPrimitiveDictionary
f_1602_75397_75439(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.GetApplicationPrivateData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 75397, 75439);
return return_v;
}


bool
f_1602_76304_76332(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.CanDisconnect;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 76304, 76332);
return return_v;
}


bool
f_1602_76415_76642(System.Management.Automation.PSPrimitiveDictionary
data,out System.Version
result,params string[]
keys)
{
var return_v = PSPrimitiveDictionary.TryPathGet( (System.Collections.IDictionary)data, out result, keys);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 76415, 76642);
return return_v;
}


int
f_1602_76739_76760(System.Version
this_param)
{
var return_v = this_param.Major ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 76739, 76760);
return return_v;
}


int
f_1602_77085_77221(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 77085, 77221);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,74976,77276);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,74976,77276);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void OnRunspacePSEventReceived(object sender, PSEventArgs e)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,77390,77570);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,77484,77559) || true) && (f_1602_77488_77499(this)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,77484,77559);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,77526,77559);

f_1602_77526_77558(f_1602_77526_77537(this), e);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,77484,77559);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,77390,77570);

System.Management.Automation.PSEventManager
f_1602_77488_77499(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.Events ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 77488, 77499);
return return_v;
}


System.Management.Automation.PSEventManager
f_1602_77526_77537(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.Events;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 77526, 77537);
return return_v;
}


int
f_1602_77526_77558(System.Management.Automation.PSEventManager
this_param,System.Management.Automation.PSEventArgs
forwardedEvent)
{
this_param.AddForwardedEvent( forwardedEvent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 77526, 77558);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,77390,77570);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,77390,77570);
}
		}

internal List<IThrottleOperation> Operations {get; }

protected void CloseAllInputStreams()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,77953,78238);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,78015,78227);
foreach(IThrottleOperation operation in f_1602_78056_78066_I(f_1602_78056_78066()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,78015,78227);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,78100,78164);

ExecutionCmdletHelper 
helper = (ExecutionCmdletHelper)operation
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,78182,78212);

f_1602_78182_78211(f_1602_78182_78203(f_1602_78182_78197(helper)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,78015,78227);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,213);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,213);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1602,77953,78238);

System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1602_78056_78066()
{
var return_v = Operations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 78056, 78066);
return return_v;
}


System.Management.Automation.Runspaces.Pipeline
f_1602_78182_78197(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
this_param)
{
var return_v = this_param.Pipeline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 78182, 78197);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1602_78182_78203(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Input;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 78182, 78203);
return return_v;
}


int
f_1602_78182_78211(System.Management.Automation.Runspaces.PipelineWriter
this_param)
{
this_param.Close();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 78182, 78211);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1602_78056_78066_I(System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 78056, 78066);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,77953,78238);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,77953,78238);
}
		}

private void WriteErrorCreateRemoteRunspaceFailed(Exception e, Uri uri)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,78579,79114);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,78675,78919);

f_1602_78675_78918(e is UriFormatException ||(DynAbs.Tracing.TraceSender.Expression_False(1602, 78686, 78743)||e is InvalidOperationException )||(DynAbs.Tracing.TraceSender.Expression_False(1602, 78686, 78793)||                       e is ArgumentException), "Exception has to be of type UriFormatException or InvalidOperationException or ArgumentException");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,78935,79063);

ErrorRecord 
errorRecord = f_1602_78961_79062(e, "CreateRemoteRunspaceFailed", ErrorCategory.InvalidArgument, uri)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,79079,79103);

f_1602_79079_79102(this, errorRecord);
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,78579,79114);

int
f_1602_78675_78918(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 78675, 78918);
return 0;
}


System.Management.Automation.ErrorRecord
f_1602_78961_79062(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Uri
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 78961, 79062);
return return_v;
}


int
f_1602_79079_79102(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 79079, 79102);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,78579,79114);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,78579,79114);
}
		}

protected const string 
FilePathComputerNameParameterSet = "FilePathComputerName"
;

protected const string 
LiteralFilePathComputerNameParameterSet = "LiteralFilePathComputerName"
;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspace")]
        protected const string 
FilePathSessionParameterSet = "FilePathRunspace"
;

protected const string 
FilePathUriParameterSet = "FilePathUri"
;

private const string 
PSv5OrLater = "PSv5OrLater"
;

private const string 
PSv3Orv4 = "PSv3Orv4"
;

private const string 
PSv2 = "PSv2"
;

private System.Management.Automation.PowerShell _powershellV2;

private System.Management.Automation.PowerShell _powershellV3;

protected ScriptBlock GetScriptBlockFromFile(string filePath, bool isLiteralPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,80622,82156);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,80789,81057) || true) && ((!isLiteralPath) &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 80793, 80865)&&f_1602_80813_80865(filePath)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,80789,81057);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,80899,81042);

throw f_1602_80905_81041(f_1602_80927_81028(f_1602_80974_81027()), "filePath");
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,80789,81057);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,81073,81327) || true) && (!f_1602_81078_81139(filePath, ".ps1", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,81073,81327);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,81173,81312);

throw f_1602_81179_81311(f_1602_81201_81298(f_1602_81248_81297()), "filePath");
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,81073,81327);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,81377,81531);

string 
resolvedPath = f_1602_81399_81530(filePath, isLiteralPath, this, false, f_1602_81473_81529())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,81584,81677);

ExternalScriptInfo 
scriptInfo = f_1602_81616_81676(filePath, resolvedPath, f_1602_81663_81675(this))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,81861,82099) || true) && (!f_1602_81866_81928(filePath, ".psd1", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,81861,82099);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,81962,82084);

f_1602_81962_82083(f_1602_81962_81995(f_1602_81962_81974(this)), scriptInfo, CommandOrigin.Internal, f_1602_82050_82082(f_1602_82050_82062(this)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,81861,82099);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,82115,82145);

return f_1602_82122_82144(scriptInfo);
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,80622,82156);

bool
f_1602_80813_80865(string
pattern)
{
var return_v = WildcardPattern.ContainsWildcardCharacters( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 80813, 80865);
return return_v;
}


string
f_1602_80974_81027()
{
var return_v = RemotingErrorIdStrings.WildCardErrorFilePathParameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 80974, 81027);
return return_v;
}


string
f_1602_80927_81028(string
resourceString,params object[]
args)
{
var return_v = PSRemotingErrorInvariants.FormatResourceString( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 80927, 81028);
return return_v;
}


System.ArgumentException
f_1602_80905_81041(string
message,string
paramName)
{
var return_v = new System.ArgumentException( message, paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 80905, 81041);
return return_v;
}


bool
f_1602_81078_81139(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.EndsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 81078, 81139);
return return_v;
}


string
f_1602_81248_81297()
{
var return_v = RemotingErrorIdStrings.FilePathShouldPS1Extension;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 81248, 81297);
return return_v;
}


string
f_1602_81201_81298(string
resourceString,params object[]
args)
{
var return_v = PSRemotingErrorInvariants.FormatResourceString( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 81201, 81298);
return return_v;
}


System.ArgumentException
f_1602_81179_81311(string
message,string
paramName)
{
var return_v = new System.ArgumentException( message, paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 81179, 81311);
return return_v;
}


string
f_1602_81473_81529()
{
var return_v = RemotingErrorIdStrings.FilePathNotFromFileSystemProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 81473, 81529);
return return_v;
}


string
f_1602_81399_81530(string
path,bool
isLiteralPath,Microsoft.PowerShell.Commands.PSExecutionCmdlet
cmdlet,bool
allowNonexistingPaths,string
resourceString)
{
var return_v = PathResolver.ResolveProviderAndPath( path, isLiteralPath, (System.Management.Automation.PSCmdlet)cmdlet, allowNonexistingPaths, resourceString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 81399, 81530);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1602_81663_81675(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 81663, 81675);
return return_v;
}


System.Management.Automation.ExternalScriptInfo
f_1602_81616_81676(string
name,string
path,System.Management.Automation.ExecutionContext
context)
{
var return_v = new System.Management.Automation.ExternalScriptInfo( name, path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 81616, 81676);
return return_v;
}


bool
f_1602_81866_81928(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.EndsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 81866, 81928);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1602_81962_81974(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 81962, 81974);
return return_v;
}


System.Management.Automation.AuthorizationManager
f_1602_81962_81995(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.AuthorizationManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 81962, 81995);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1602_82050_82062(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 82050, 82062);
return return_v;
}


System.Management.Automation.Internal.Host.InternalHost
f_1602_82050_82082(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineHostInterface;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 82050, 82082);
return return_v;
}


int
f_1602_81962_82083(System.Management.Automation.AuthorizationManager
this_param,System.Management.Automation.ExternalScriptInfo
commandInfo,System.Management.Automation.CommandOrigin
origin,System.Management.Automation.Internal.Host.InternalHost
host)
{
this_param.ShouldRunInternal( (System.Management.Automation.CommandInfo)commandInfo, origin, (System.Management.Automation.Host.PSHost)host);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 81962, 82083);
return 0;
}


System.Management.Automation.ScriptBlock
f_1602_82122_82144(System.Management.Automation.ExternalScriptInfo
this_param)
{
var return_v = this_param.ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 82122, 82144);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,80622,82156);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,80622,82156);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override void BeginProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,82380,85926);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,82446,83004) || true) && ((f_1602_82451_82467()== PSExecutionCmdlet.VMIdParameterSet) ||(DynAbs.Tracing.TraceSender.Expression_False(1602, 82450, 82585)||                (f_1602_82528_82544()== PSExecutionCmdlet.VMNameParameterSet) )||(DynAbs.Tracing.TraceSender.Expression_False(1602, 82450, 82669)||                (f_1602_82607_82623()== PSExecutionCmdlet.ContainerIdParameterSet) )||(DynAbs.Tracing.TraceSender.Expression_False(1602, 82450, 82754)||                (f_1602_82691_82707()== PSExecutionCmdlet.FilePathVMIdParameterSet) )||(DynAbs.Tracing.TraceSender.Expression_False(1602, 82450, 82841)||                (f_1602_82776_82792()== PSExecutionCmdlet.FilePathVMNameParameterSet) )||(DynAbs.Tracing.TraceSender.Expression_False(1602, 82450, 82933)||                (f_1602_82863_82879()== PSExecutionCmdlet.FilePathContainerIdParameterSet)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,82446,83004);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,82967,82989);

SkipWinRMCheck = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,82446,83004);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,83020,83043);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BeginProcessing(),1602,83020,83042);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,83059,83193) || true) && (_filePath != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,83059,83193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,83114,83178);

_scriptBlock = f_1602_83129_83177(this, _filePath, f_1602_83163_83176());
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,83059,83193);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,83209,85915);

switch (f_1602_83217_83233())
            {

case PSExecutionCmdlet.FilePathComputerNameParameterSet:
                case PSExecutionCmdlet.LiteralFilePathComputerNameParameterSet:
                case PSExecutionCmdlet.ComputerNameParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,83209,85915);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,83519,83557);

string[] 
resolvedComputerNames = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,83583,83645);

f_1602_83583_83644(this, f_1602_83604_83616(), out resolvedComputerNames);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,83671,83717);

ResolvedComputerNames = resolvedComputerNames;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,83745,83786);

f_1602_83745_83785(this);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1602,83833,83839);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,83209,85915);

case PSExecutionCmdlet.SSHHostParameterSet:
                case PSExecutionCmdlet.FilePathSSHHostParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,83209,85915);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,84020,84058);

string[] 
resolvedComputerNames = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,84084,84142);

f_1602_84084_84141(this, f_1602_84105_84113(), out resolvedComputerNames);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,84168,84214);

ResolvedComputerNames = resolvedComputerNames;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,84242,84286);

f_1602_84242_84285(this);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1602,84333,84339);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,83209,85915);

case PSExecutionCmdlet.SSHHostHashParameterSet:
                case PSExecutionCmdlet.FilePathSSHHostHashParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,83209,85915);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,84528,84576);

f_1602_84528_84575(this);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1602,84623,84629);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,83209,85915);

case PSExecutionCmdlet.FilePathSessionParameterSet:
                case PSExecutionCmdlet.SessionParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,83209,85915);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,84810,84845);

f_1602_84810_84844(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,84873,84910);

f_1602_84873_84909(this);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1602,84957,84963);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,83209,85915);

case PSExecutionCmdlet.FilePathUriParameterSet:
                case PSExecutionCmdlet.UriParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,83209,85915);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,85136,85168);

f_1602_85136_85167(this);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1602,85215,85221);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,83209,85915);

case PSExecutionCmdlet.VMIdParameterSet:
                case PSExecutionCmdlet.VMNameParameterSet:
                case PSExecutionCmdlet.FilePathVMIdParameterSet:
                case PSExecutionCmdlet.FilePathVMNameParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,83209,85915);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,85524,85561);

f_1602_85524_85560(this);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1602,85608,85614);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,83209,85915);

case PSExecutionCmdlet.ContainerIdParameterSet:
                case PSExecutionCmdlet.FilePathContainerIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,83209,85915);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,85803,85847);

f_1602_85803_85846(this);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1602,85894,85900);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,83209,85915);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,82380,85926);

string
f_1602_82451_82467()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 82451, 82467);
return return_v;
}


string
f_1602_82528_82544()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 82528, 82544);
return return_v;
}


string
f_1602_82607_82623()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 82607, 82623);
return return_v;
}


string
f_1602_82691_82707()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 82691, 82707);
return return_v;
}


string
f_1602_82776_82792()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 82776, 82792);
return return_v;
}


string
f_1602_82863_82879()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 82863, 82879);
return return_v;
}


bool
f_1602_83163_83176()
{
var return_v = IsLiteralPath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 83163, 83176);
return return_v;
}


System.Management.Automation.ScriptBlock
f_1602_83129_83177(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,string
filePath,bool
isLiteralPath)
{
var return_v = this_param.GetScriptBlockFromFile( filePath, isLiteralPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 83129, 83177);
return return_v;
}


string
f_1602_83217_83233()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 83217, 83233);
return return_v;
}


string[]
f_1602_83604_83616()
{
var return_v = ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 83604, 83616);
return return_v;
}


int
f_1602_83583_83644(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,string[]
computerNames,out string[]
resolvedComputerNames)
{
this_param.ResolveComputerNames( computerNames, out resolvedComputerNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 83583, 83644);
return 0;
}


int
f_1602_83745_83785(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
this_param.CreateHelpersForSpecifiedComputerNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 83745, 83785);
return 0;
}


string[]
f_1602_84105_84113()
{
var return_v = HostName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 84105, 84113);
return return_v;
}


int
f_1602_84084_84141(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,string[]
computerNames,out string[]
resolvedComputerNames)
{
this_param.ResolveComputerNames( computerNames, out resolvedComputerNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 84084, 84141);
return 0;
}


int
f_1602_84242_84285(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
this_param.CreateHelpersForSpecifiedSSHComputerNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 84242, 84285);
return 0;
}


int
f_1602_84528_84575(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
this_param.CreateHelpersForSpecifiedSSHHashComputerNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 84528, 84575);
return 0;
}


int
f_1602_84810_84844(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
this_param.ValidateRemoteRunspacesSpecified();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 84810, 84844);
return 0;
}


int
f_1602_84873_84909(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
this_param.CreateHelpersForSpecifiedRunspaces();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 84873, 84909);
return 0;
}


int
f_1602_85136_85167(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
this_param.CreateHelpersForSpecifiedUris();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 85136, 85167);
return 0;
}


int
f_1602_85524_85560(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
this_param.CreateHelpersForSpecifiedVMSession();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 85524, 85560);
return 0;
}


int
f_1602_85803_85846(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
this_param.CreateHelpersForSpecifiedContainerSession();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 85803, 85846);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,82380,85926);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,82380,85926);
}
		}

private System.Management.Automation.PowerShell GetPowerShellForPSv2()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,87167,89014);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,87262,87314) || true) && (_powershellV2 != null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,87262,87314);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,87291,87312);

return _powershellV2;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,87262,87314);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,87401,87439);

_powershellV2 = f_1602_87417_87438(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,87453,88002) || true) && (_powershellV2 != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,87453,88002);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,87564,87915);
foreach(var command in f_1602_87588_87619_I(f_1602_87588_87619(f_1602_87588_87610(_powershellV2))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,87564,87915);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,87661,87896) || true) && (f_1602_87665_87689(command))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,87661,87896);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,87820,87841);

_powershellV2 = null;
DynAbs.Tracing.TraceSender.TraceBreak(1602,87867,87873);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,87661,87896);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,87564,87915);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,352);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,352);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,87935,87987) || true) && (_powershellV2 != null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,87935,87987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,87964,87985);

return _powershellV2;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,87935,87987);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,87453,88002);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,88018,88049);

List<string> 
newParameterNames
=default(List<string>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,88063,88095);

List<object> 
newParameterValues
=default(List<object>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,88111,88211);

string 
scriptTextAdaptedForPSv2 = f_1602_88145_88210(this, out newParameterNames, out newParameterValues)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,88225,88326);

_powershellV2 = f_1602_88241_88325(f_1602_88241_88289(), scriptTextAdaptedForPSv2);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,88342,88528) || true) && (_args != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,88342,88528);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,88393,88513);
foreach(object arg in f_1602_88416_88421_I(_args) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,88393,88513);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,88463,88494);

f_1602_88463_88493(                    _powershellV2, arg);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,88393,88513);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,121);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,121);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1602,88342,88528);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,88544,88966) || true) && (newParameterNames != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,88544,88966);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,88607,88752);

f_1602_88607_88751(newParameterValues != null &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 88618, 88699)&&f_1602_88648_88671(newParameterNames)== f_1602_88675_88699(newParameterValues)), "We should get the value for each using variable");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,88779,88784);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,88770,88951) || true) && (i < f_1602_88790_88813(newParameterNames))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,88815,88818)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1602,88770,88951))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,88770,88951);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,88860,88932);

f_1602_88860_88931(                    _powershellV2, f_1602_88887_88907(newParameterNames, i), f_1602_88909_88930(newParameterValues, i));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,182);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,182);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1602,88544,88966);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,88982,89003);

return _powershellV2;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,87167,89014);

System.Management.Automation.PowerShell
f_1602_87417_87438(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.ConvertToPowerShell();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 87417, 87438);
return return_v;
}


System.Management.Automation.PSCommand
f_1602_87588_87610(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 87588, 87610);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_1602_87588_87619(System.Management.Automation.PSCommand
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 87588, 87619);
return return_v;
}


bool
f_1602_87665_87689(System.Management.Automation.Runspaces.Command
this_param)
{
var return_v = this_param.IsEndOfStatement;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 87665, 87689);
return return_v;
}


System.Management.Automation.Runspaces.CommandCollection
f_1602_87588_87619_I(System.Management.Automation.Runspaces.CommandCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 87588, 87619);
return return_v;
}


string
f_1602_88145_88210(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,out System.Collections.Generic.List<string>
newParameterNames,out System.Collections.Generic.List<object>
newParameterValues)
{
var return_v = this_param.GetConvertedScript( out newParameterNames, out newParameterValues);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 88145, 88210);
return return_v;
}


System.Management.Automation.PowerShell
f_1602_88241_88289()
{
var return_v = System.Management.Automation.PowerShell.Create();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 88241, 88289);
return return_v;
}


System.Management.Automation.PowerShell
f_1602_88241_88325(System.Management.Automation.PowerShell
this_param,string
script)
{
var return_v = this_param.AddScript( script);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 88241, 88325);
return return_v;
}


System.Management.Automation.PowerShell
f_1602_88463_88493(System.Management.Automation.PowerShell
this_param,object
value)
{
var return_v = this_param.AddArgument( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 88463, 88493);
return return_v;
}


object[]
f_1602_88416_88421_I(object[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 88416, 88421);
return return_v;
}


int
f_1602_88648_88671(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 88648, 88671);
return return_v;
}


int
f_1602_88675_88699(System.Collections.Generic.List<object>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 88675, 88699);
return return_v;
}


int
f_1602_88607_88751(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 88607, 88751);
return 0;
}


int
f_1602_88790_88813(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 88790, 88813);
return return_v;
}


string
f_1602_88887_88907(System.Collections.Generic.List<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 88887, 88907);
return return_v;
}


object
f_1602_88909_88930(System.Collections.Generic.List<object>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 88909, 88930);
return return_v;
}


System.Management.Automation.PowerShell
f_1602_88860_88931(System.Management.Automation.PowerShell
this_param,string
parameterName,object
value)
{
var return_v = this_param.AddParameter( parameterName, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 88860, 88931);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,87167,89014);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,87167,89014);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private System.Management.Automation.PowerShell GetPowerShellForPSv3OrLater(string serverPsVersion)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,91432,94389);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,91556,91608) || true) && (_powershellV3 != null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,91556,91608);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,91585,91606);

return _powershellV3;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,91556,91608);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,91695,91733);

_powershellV3 = f_1602_91711_91732(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,91749,91801) || true) && (_powershellV3 != null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,91749,91801);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,91778,91799);

return _powershellV3;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,91749,91801);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,92283,92377);

bool 
allowUsingExpressions = (f_1602_92313_92346(f_1602_92313_92333(f_1602_92313_92320()))!= PSLanguageMode.NoLanguage)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,92391,92426);

object[] 
usingValuesInArray = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,92440,92477);

IDictionary 
usingValuesInDict = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,92581,93438) || true) && (serverPsVersion == PSv3Orv4)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,92581,93438);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,92646,92774);

usingValuesInArray = f_1602_92667_92773(_scriptBlock, allowUsingExpressions, f_1602_92759_92766(), null);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,92792,93166) || true) && (usingValuesInArray == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,92792,93166);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,93117,93147);

return f_1602_93124_93146(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,92792,93166);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,92581,93438);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,92581,93438);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,93291,93423);

usingValuesInDict = f_1602_93311_93422(_scriptBlock, allowUsingExpressions, f_1602_93408_93415(), null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,92581,93438);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,93454,93628);

string 
textOfScriptBlock = (DynAbs.Tracing.TraceSender.Conditional_F1(1602, 93481, 93513)||((f_1602_93481_93513(f_1602_93481_93498(this))&&DynAbs.Tracing.TraceSender.Conditional_F2(1602, 93533, 93584))||DynAbs.Tracing.TraceSender.Conditional_F3(1602, 93604, 93627)))?f_1602_93533_93584(_scriptBlock):f_1602_93604_93627(_scriptBlock)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,93644,93738);

_powershellV3 = f_1602_93660_93737(f_1602_93660_93708(), textOfScriptBlock);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,93754,93940) || true) && (_args != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,93754,93940);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,93805,93925);
foreach(object arg in f_1602_93828_93833_I(_args) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,93805,93925);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,93875,93906);

f_1602_93875_93905(                    _powershellV3, arg);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,93805,93925);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,121);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,121);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1602,93754,93940);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,93956,94341) || true) && (usingValuesInDict != null &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 93960, 94016)&&f_1602_93989_94012(usingValuesInDict)> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,93956,94341);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,94050,94122);

f_1602_94050_94121(                _powershellV3, Parser.VERBATIM_ARGUMENT, usingValuesInDict);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,93956,94341);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,93956,94341);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,94156,94341) || true) && (usingValuesInArray != null &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 94160, 94219)&&f_1602_94190_94215(usingValuesInArray)> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,94156,94341);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,94253,94326);

f_1602_94253_94325(                _powershellV3, Parser.VERBATIM_ARGUMENT, usingValuesInArray);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,94156,94341);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,93956,94341);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,94357,94378);

return _powershellV3;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,91432,94389);

System.Management.Automation.PowerShell
f_1602_91711_91732(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.ConvertToPowerShell();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 91711, 91732);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1602_92313_92320()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 92313, 92320);
return return_v;
}


System.Management.Automation.SessionState
f_1602_92313_92333(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 92313, 92333);
return return_v;
}


System.Management.Automation.PSLanguageMode
f_1602_92313_92346(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.LanguageMode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 92313, 92346);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1602_92759_92766()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 92759, 92766);
return return_v;
}


object[]
f_1602_92667_92773(System.Management.Automation.ScriptBlock
scriptBlock,bool
isTrustedInput,System.Management.Automation.ExecutionContext
context,System.Collections.Generic.Dictionary<string, object>
variables)
{
var return_v = ScriptBlockToPowerShellConverter.GetUsingValuesAsArray( scriptBlock, isTrustedInput, context, variables);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 92667, 92773);
return return_v;
}


System.Management.Automation.PowerShell
f_1602_93124_93146(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.GetPowerShellForPSv2();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 93124, 93146);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1602_93408_93415()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 93408, 93415);
return return_v;
}


System.Collections.Generic.Dictionary<string, object>
f_1602_93311_93422(System.Management.Automation.ScriptBlock
scriptBlock,bool
isTrustedInput,System.Management.Automation.ExecutionContext
context,System.Collections.Generic.Dictionary<string, object>
variables)
{
var return_v = ScriptBlockToPowerShellConverter.GetUsingValuesAsDictionary( scriptBlock, isTrustedInput, context, variables);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 93311, 93422);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1602_93481_93498(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 93481, 93498);
return return_v;
}


bool
f_1602_93481_93513(System.Management.Automation.InvocationInfo
this_param)
{
var return_v = this_param.ExpectingInput
;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 93481, 93513);
return return_v;
}


string
f_1602_93533_93584(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.GetWithInputHandlingForInvokeCommand();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 93533, 93584);
return return_v;
}


string
f_1602_93604_93627(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 93604, 93627);
return return_v;
}


System.Management.Automation.PowerShell
f_1602_93660_93708()
{
var return_v = System.Management.Automation.PowerShell.Create();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 93660, 93708);
return return_v;
}


System.Management.Automation.PowerShell
f_1602_93660_93737(System.Management.Automation.PowerShell
this_param,string
script)
{
var return_v = this_param.AddScript( script);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 93660, 93737);
return return_v;
}


System.Management.Automation.PowerShell
f_1602_93875_93905(System.Management.Automation.PowerShell
this_param,object
value)
{
var return_v = this_param.AddArgument( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 93875, 93905);
return return_v;
}


object[]
f_1602_93828_93833_I(object[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 93828, 93833);
return return_v;
}


int
f_1602_93989_94012(System.Collections.IDictionary
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 93989, 94012);
return return_v;
}


System.Management.Automation.PowerShell
f_1602_94050_94121(System.Management.Automation.PowerShell
this_param,string
parameterName,System.Collections.IDictionary
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 94050, 94121);
return return_v;
}


int
f_1602_94190_94215(object[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 94190, 94215);
return return_v;
}


System.Management.Automation.PowerShell
f_1602_94253_94325(System.Management.Automation.PowerShell
this_param,string
parameterName,object[]
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 94253, 94325);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,91432,94389);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,91432,94389);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private System.Management.Automation.PowerShell ConvertToPowerShell()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,94401,95279);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,94495,94553);

System.Management.Automation.PowerShell 
powershell = null
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,94685,94761);

bool 
isTrustedInput = (f_1602_94708_94728(f_1602_94708_94715())== PSLanguageMode.FullLanguage)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,94779,94842);

powershell = f_1602_94792_94841(_scriptBlock, isTrustedInput, _args);
            }
            catch (ScriptBlockToPowerShellNotSupportedException)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,94871,95234);
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,94871,95234);
                // conversion failed, we need to send the script to the remote end.
                // since the PowerShell instance would be different according to the PSVersion of the remote end,
                // we generate it when we know which version we are talking to.
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,95250,95268);

return powershell;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,94401,95279);

System.Management.Automation.ExecutionContext
f_1602_94708_94715()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 94708, 94715);
return return_v;
}


System.Management.Automation.PSLanguageMode
f_1602_94708_94728(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.LanguageMode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 94708, 94728);
return return_v;
}


System.Management.Automation.PowerShell
f_1602_94792_94841(System.Management.Automation.ScriptBlock
this_param,bool
isTrustedInput,params object[]
args)
{
var return_v = this_param.GetPowerShell( isTrustedInput, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 94792, 94841);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,94401,95279);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,94401,95279);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string GetConvertedScript(out List<string> newParameterNames, out List<object> newParameterValues)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,95821,98248);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,95952,95977);

newParameterNames = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,95978,96004);

newParameterValues = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,96018,96050);

string 
textOfScriptBlock = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,96111,96188);

List<VariableExpressionAst> 
usingVariables = f_1602_96156_96187(this, _scriptBlock)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,96204,98196) || true) && (usingVariables == null ||(DynAbs.Tracing.TraceSender.Expression_False(1602, 96208, 96259)||f_1602_96234_96254(usingVariables)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,96204,98196);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,96372,96547);

textOfScriptBlock = (DynAbs.Tracing.TraceSender.Conditional_F1(1602, 96392, 96424)||((f_1602_96392_96424(f_1602_96392_96409(this))&&DynAbs.Tracing.TraceSender.Conditional_F2(1602, 96448, 96499))||DynAbs.Tracing.TraceSender.Conditional_F3(1602, 96523, 96546)))?f_1602_96448_96499(_scriptBlock):f_1602_96523_96546(_scriptBlock);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,96204,98196);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,96204,98196);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,96613,96652);

newParameterNames = f_1602_96633_96651();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,96670,96720);

var 
paramNamesWithDollarSign = f_1602_96701_96719()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,96738,96793);

var 
paramUsingVars = f_1602_96759_96792()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,96811,96883);

var 
nameHashSet = f_1602_96829_96882(f_1602_96849_96881())
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,96903,97564);
foreach(var varAst in f_1602_96926_96940_I(usingVariables) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,96903,97564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,96982,97028);

string 
varName = f_1602_96999_97027(f_1602_96999_97018(varAst))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,97050,97110);

string 
paramName = UsingExpressionAst.UsingPrefix + varName
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,97132,97177);

string 
paramNameWithDollar = "$" + paramName
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,97201,97545) || true) && (!f_1602_97206_97247(nameHashSet, paramNameWithDollar))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,97201,97545);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,97297,97330);

f_1602_97297_97329(                        newParameterNames, paramName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,97356,97406);

f_1602_97356_97405(                        paramNamesWithDollarSign, paramNameWithDollar);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,97432,97459);

f_1602_97432_97458(                        paramUsingVars, varAst);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,97485,97522);

f_1602_97485_97521(                        nameHashSet, paramNameWithDollar);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,97201,97545);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,96903,97564);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,662);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,662);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,97647,97707);

newParameterValues = f_1602_97668_97706(this, paramUsingVars);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,97775,97848);

string 
additionalNewParams = f_1602_97804_97847(", ", paramNamesWithDollarSign)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,97866,98181);

textOfScriptBlock = (DynAbs.Tracing.TraceSender.Conditional_F1(1602, 97886, 97918)||((f_1602_97886_97918(f_1602_97886_97903(this))&&DynAbs.Tracing.TraceSender.Conditional_F2(1602, 97942, 98061))||DynAbs.Tracing.TraceSender.Conditional_F3(1602, 98085, 98180)))?f_1602_97942_98061(_scriptBlock, f_1602_98011_98060(usingVariables, additionalNewParams)):f_1602_98085_98180(_scriptBlock, f_1602_98130_98179(usingVariables, additionalNewParams));
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,96204,98196);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,98212,98237);

return textOfScriptBlock;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,95821,98248);

System.Collections.Generic.List<System.Management.Automation.Language.VariableExpressionAst>
f_1602_96156_96187(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Management.Automation.ScriptBlock
localScriptBlock)
{
var return_v = this_param.GetUsingVariables( localScriptBlock);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 96156, 96187);
return return_v;
}


int
f_1602_96234_96254(System.Collections.Generic.List<System.Management.Automation.Language.VariableExpressionAst>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 96234, 96254);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1602_96392_96409(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 96392, 96409);
return return_v;
}


bool
f_1602_96392_96424(System.Management.Automation.InvocationInfo
this_param)
{
var return_v = this_param.ExpectingInput
;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 96392, 96424);
return return_v;
}


string
f_1602_96448_96499(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.GetWithInputHandlingForInvokeCommand();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 96448, 96499);
return return_v;
}


string
f_1602_96523_96546(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 96523, 96546);
return return_v;
}


System.Collections.Generic.List<string>
f_1602_96633_96651()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 96633, 96651);
return return_v;
}


System.Collections.Generic.List<string>
f_1602_96701_96719()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 96701, 96719);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Language.VariableExpressionAst>
f_1602_96759_96792()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.VariableExpressionAst>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 96759, 96792);
return return_v;
}


System.StringComparer
f_1602_96849_96881()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 96849, 96881);
return return_v;
}


System.Collections.Generic.HashSet<string>
f_1602_96829_96882(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.HashSet<string>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 96829, 96882);
return return_v;
}


System.Management.Automation.VariablePath
f_1602_96999_97018(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.VariablePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 96999, 97018);
return return_v;
}


string
f_1602_96999_97027(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.UserPath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 96999, 97027);
return return_v;
}


bool
f_1602_97206_97247(System.Collections.Generic.HashSet<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 97206, 97247);
return return_v;
}


int
f_1602_97297_97329(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 97297, 97329);
return 0;
}


int
f_1602_97356_97405(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 97356, 97405);
return 0;
}


int
f_1602_97432_97458(System.Collections.Generic.List<System.Management.Automation.Language.VariableExpressionAst>
this_param,System.Management.Automation.Language.VariableExpressionAst
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 97432, 97458);
return 0;
}


bool
f_1602_97485_97521(System.Collections.Generic.HashSet<string>
this_param,string
item)
{
var return_v = this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 97485, 97521);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Language.VariableExpressionAst>
f_1602_96926_96940_I(System.Collections.Generic.List<System.Management.Automation.Language.VariableExpressionAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 96926, 96940);
return return_v;
}


System.Collections.Generic.List<object>
f_1602_97668_97706(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param,System.Collections.Generic.List<System.Management.Automation.Language.VariableExpressionAst>
paramUsingVars)
{
var return_v = this_param.GetUsingVariableValues( paramUsingVars);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 97668, 97706);
return return_v;
}


string
f_1602_97804_97847(string
separator,System.Collections.Generic.List<string>
values)
{
var return_v = string.Join( separator, (System.Collections.Generic.IEnumerable<string?>)values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 97804, 97847);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1602_97886_97903(Microsoft.PowerShell.Commands.PSExecutionCmdlet
this_param)
{
var return_v = this_param.MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 97886, 97903);
return return_v;
}


bool
f_1602_97886_97918(System.Management.Automation.InvocationInfo
this_param)
{
var return_v = this_param.ExpectingInput
;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 97886, 97918);
return return_v;
}


System.Tuple<System.Collections.Generic.List<System.Management.Automation.Language.VariableExpressionAst>, string>
f_1602_98011_98060(System.Collections.Generic.List<System.Management.Automation.Language.VariableExpressionAst>
item1,string
item2)
{
var return_v = Tuple.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 98011, 98060);
return return_v;
}


string
f_1602_97942_98061(System.Management.Automation.ScriptBlock
this_param,System.Tuple<System.Collections.Generic.List<System.Management.Automation.Language.VariableExpressionAst>, string>
usingVariablesTuple)
{
var return_v = this_param.GetWithInputHandlingForInvokeCommandWithUsingExpression( usingVariablesTuple);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 97942, 98061);
return return_v;
}


System.Tuple<System.Collections.Generic.List<System.Management.Automation.Language.VariableExpressionAst>, string>
f_1602_98130_98179(System.Collections.Generic.List<System.Management.Automation.Language.VariableExpressionAst>
item1,string
item2)
{
var return_v = Tuple.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 98130, 98179);
return return_v;
}


string
f_1602_98085_98180(System.Management.Automation.ScriptBlock
this_param,System.Tuple<System.Collections.Generic.List<System.Management.Automation.Language.VariableExpressionAst>, string>
usingVariablesTuple)
{
var return_v = this_param.ToStringWithDollarUsingHandling( usingVariablesTuple);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 98085, 98180);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,95821,98248);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,95821,98248);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private List<object> GetUsingVariableValues(List<VariableExpressionAst> paramUsingVars)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,98463,100258);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,98575,98627);

var 
values = f_1602_98588_98626(f_1602_98605_98625(paramUsingVars))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,98641,98684);

VariableExpressionAst 
currentVarAst = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,98698,98783);

Version 
oldStrictVersion = f_1602_98725_98782(f_1602_98725_98764(f_1602_98725_98751(f_1602_98725_98732())))
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,98835,98919);

f_1602_98835_98874(f_1602_98835_98861(f_1602_98835_98842())).StrictModeVersion = f_1602_98895_98918();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,99201,99293);

bool 
allowVariableAccess = (f_1602_99229_99262(f_1602_99229_99249(f_1602_99229_99236()))!= PSLanguageMode.NoLanguage)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,99313,99577);
foreach(var varAst in f_1602_99336_99350_I(paramUsingVars) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,99313,99577);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,99392,99415);

currentVarAst = varAst;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,99437,99518);

object 
value = f_1602_99452_99517(varAst, allowVariableAccess, f_1602_99509_99516())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,99540,99558);

f_1602_99540_99557(                    values, value);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,99313,99577);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,265);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,265);
}            }
            catch (RuntimeException rte)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,99606,100071);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,99667,100056) || true) && (f_1602_99671_99764(f_1602_99671_99708(f_1602_99671_99686(rte)), "VariableIsUndefined", StringComparison.Ordinal))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,99667,100056);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,99806,100037);

throw f_1602_99812_100036(null, typeof(RuntimeException), f_1602_99910_99930(currentVarAst), "UsingVariableIsUndefined", f_1602_99960_100005(), f_1602_100007_100035(f_1602_100007_100022(rte)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,99667,100056);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,99606,100071);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1602,100085,100217);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,100125,100202);

f_1602_100125_100164(f_1602_100125_100151(f_1602_100125_100132())).StrictModeVersion = oldStrictVersion;
DynAbs.Tracing.TraceSender.TraceExitFinally(1602,100085,100217);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,100233,100247);

return values;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,98463,100258);

int
f_1602_98605_98625(System.Collections.Generic.List<System.Management.Automation.Language.VariableExpressionAst>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 98605, 98625);
return return_v;
}


System.Collections.Generic.List<object>
f_1602_98588_98626(int
capacity)
{
var return_v = new System.Collections.Generic.List<object>( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 98588, 98626);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1602_98725_98732()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 98725, 98732);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1602_98725_98751(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineSessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 98725, 98751);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1602_98725_98764(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.CurrentScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 98725, 98764);
return return_v;
}


System.Version
f_1602_98725_98782(System.Management.Automation.SessionStateScope
this_param)
{
var return_v = this_param.StrictModeVersion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 98725, 98782);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1602_98835_98842()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 98835, 98842);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1602_98835_98861(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineSessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 98835, 98861);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1602_98835_98874(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.CurrentScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 98835, 98874);
return return_v;
}


System.Version
f_1602_98895_98918()
{
var return_v = PSVersionInfo.PSVersion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 98895, 98918);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1602_99229_99236()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 99229, 99236);
return return_v;
}


System.Management.Automation.SessionState
f_1602_99229_99249(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 99229, 99249);
return return_v;
}


System.Management.Automation.PSLanguageMode
f_1602_99229_99262(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.LanguageMode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 99229, 99262);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1602_99509_99516()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 99509, 99516);
return return_v;
}


object
f_1602_99452_99517(System.Management.Automation.Language.VariableExpressionAst
expressionAst,bool
isTrustedInput,System.Management.Automation.ExecutionContext
context)
{
var return_v = Compiler.GetExpressionValue( (System.Management.Automation.Language.ExpressionAst)expressionAst, isTrustedInput, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 99452, 99517);
return return_v;
}


int
f_1602_99540_99557(System.Collections.Generic.List<object>
this_param,object
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 99540, 99557);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Language.VariableExpressionAst>
f_1602_99336_99350_I(System.Collections.Generic.List<System.Management.Automation.Language.VariableExpressionAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 99336, 99350);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_99671_99686(System.Management.Automation.RuntimeException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 99671, 99686);
return return_v;
}


string
f_1602_99671_99708(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.FullyQualifiedErrorId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 99671, 99708);
return return_v;
}


bool
f_1602_99671_99764(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 99671, 99764);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1602_99910_99930(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 99910, 99930);
return return_v;
}


string
f_1602_99960_100005()
{
var return_v = AutomationExceptions.UsingVariableIsUndefined;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 99960, 100005);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_100007_100022(System.Management.Automation.RuntimeException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 100007, 100022);
return return_v;
}


object
f_1602_100007_100035(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.TargetObject;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 100007, 100035);
return return_v;
}


System.Management.Automation.RuntimeException
f_1602_99812_100036(object
targetObject,System.Type
exceptionType,System.Management.Automation.Language.IScriptExtent
errorPosition,string
resourceIdAndErrorId,string
resourceString,params object[]
args)
{
var return_v = InterpreterError.NewInterpreterException( targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 99812, 100036);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1602_100125_100132()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 100125, 100132);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1602_100125_100151(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineSessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 100125, 100151);
return return_v;
}


System.Management.Automation.SessionStateScope
f_1602_100125_100164(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.CurrentScope;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 100125, 100164);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,98463,100258);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,98463,100258);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private List<VariableExpressionAst> GetUsingVariables(ScriptBlock localScriptBlock)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,100519,101089);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,100627,100817) || true) && (localScriptBlock == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,100627,100817);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,100689,100802);

throw f_1602_100695_100801("localScriptBlock", "Caller needs to make sure the parameter value is not null");
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,100627,100817);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,100833,100942);

var 
allUsingExprs = f_1602_100853_100941(f_1602_100920_100940(localScriptBlock))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,100956,101078);

return f_1602_100963_101077(f_1602_100963_101068(allUsingExprs, usingExpr => UsingExpressionAst.ExtractUsingVariable((UsingExpressionAst)usingExpr)));
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,100519,101089);

System.ArgumentNullException
f_1602_100695_100801(string
paramName,string
message)
{
var return_v = new System.ArgumentNullException( paramName, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 100695, 100801);
return return_v;
}


System.Management.Automation.Language.Ast
f_1602_100920_100940(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.Ast;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 100920, 100940);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Ast>
f_1602_100853_100941(System.Management.Automation.Language.Ast
ast)
{
var return_v = UsingExpressionAstSearcher.FindAllUsingExpressionExceptForWorkflow( ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 100853, 100941);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.Language.VariableExpressionAst>
f_1602_100963_101068(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Ast>
source,System.Func<System.Management.Automation.Language.Ast, System.Management.Automation.Language.VariableExpressionAst>
selector)
{
var return_v = source.Select<System.Management.Automation.Language.Ast,System.Management.Automation.Language.VariableExpressionAst>( selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 100963, 101068);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Language.VariableExpressionAst>
f_1602_100963_101077(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.VariableExpressionAst>
source)
{
var return_v = source.ToList<System.Management.Automation.Language.VariableExpressionAst>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 100963, 101077);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,100519,101089);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,100519,101089);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public PSExecutionCmdlet()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1602,43920,101146);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,45272,45392);
this.InputObject = f_1602_45371_45391();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,45905,45917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,46870,46879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,47008,47050);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,47557,47562);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,47771,47828);
this.InvokeAndDisconnect = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,47962,48112);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,48734,49369);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,49473,50061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,50157,50760);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,51210,52725);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,77747,77834);
this.Operations = f_1602_77803_77833();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,80280,80293);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,80352,80365);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1602,43920,101146);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,43920,101146);
}


static PSExecutionCmdlet()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1602,43920,101146);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,44150,44191);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,44320,44365);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,44499,44554);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,44684,44731);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,44897,44952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,79245,79302);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,79441,79512);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,79757,79805);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,79928,79967);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,80094,80121);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,80153,80174);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,80206,80219);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1602,43920,101146);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,43920,101146);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1602,43920,101146);

System.Management.Automation.PSObject
f_1602_45371_45391()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 45371, 45391);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>
f_1602_77803_77833()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Remoting.IThrottleOperation>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 77803, 77833);
return return_v;
}

}
public abstract partial class PSRunspaceCmdlet : PSRemotingCmdlet
{
protected const string 
ContainerIdInstanceIdParameterSet = "ContainerIdInstanceId"
;

protected const string 
VMIdInstanceIdParameterSet = "VMIdInstanceId"
;

protected const string 
VMNameInstanceIdParameterSet = "VMNameInstanceId"
;

[Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRunspaceCmdlet.InstanceIdParameterSet)]
        [ValidateNotNull]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public virtual Guid[] InstanceId
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,102679,102756);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,102715,102741);

return _remoteRunspaceIds;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,102679,102756);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,102342,102861);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,102342,102861);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,102772,102850);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,102808,102835);

_remoteRunspaceIds = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,102772,102850);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,102342,102861);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,102342,102861);
}
		}}

private Guid[] _remoteRunspaceIds;

[Parameter(Position = 0,
                   ValueFromPipelineByPropertyName = true,
                   Mandatory = true,
                   ParameterSetName = PSRunspaceCmdlet.IdParameterSet)]
        [ValidateNotNull]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public int[] Id {get; set; }

[Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRunspaceCmdlet.NameParameterSet)]
        [ValidateNotNullOrEmpty()]
        public virtual string[] Name
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,103734,103799);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,103770,103784);

return _names;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,103734,103799);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,103492,103892);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,103492,103892);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,103815,103881);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,103851,103866);

_names = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,103815,103881);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,103492,103892);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,103492,103892);
}
		}}

private string[] _names;

[Parameter(Position = 0,
                   Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRunspaceCmdlet.ComputerNameParameterSet)]
        [ValidateNotNullOrEmpty]
        [Alias("Cn")]
        public virtual string[] ComputerName
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,104412,104485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,104448,104470);

return _computerNames;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,104412,104485);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,104079,104586);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,104079,104586);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,104501,104575);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,104537,104560);

_computerNames = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,104501,104575);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,104079,104586);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,104079,104586);
}
		}}

private string[] _computerNames;

[SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays",
            Justification = "This is by spec.")]
        [Parameter(Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRunspaceCmdlet.ContainerIdParameterSet)]
        [Parameter(Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRunspaceCmdlet.ContainerIdInstanceIdParameterSet)]
        [ValidateNotNullOrEmpty]
        public virtual string[] ContainerId {get; set; }

[SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays",
            Justification = "This is by spec.")]
        [Parameter(Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRunspaceCmdlet.VMIdParameterSet)]
        [Parameter(Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRunspaceCmdlet.VMIdInstanceIdParameterSet)]
        [ValidateNotNullOrEmpty]
        [Alias("VMGuid")]
        public virtual Guid[] VMId {get; set; }

[SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays",
            Justification = "This is by spec.")]
        [Parameter(Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRunspaceCmdlet.VMNameParameterSet)]
        [Parameter(Mandatory = true,
                   ValueFromPipelineByPropertyName = true,
                   ParameterSetName = PSRunspaceCmdlet.VMNameInstanceIdParameterSet)]
        [ValidateNotNullOrEmpty]
        public virtual string[] VMName {get; set; }

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspaces")]
        protected Dictionary<Guid, PSSession> GetMatchingRunspaces(bool writeobject,
            bool writeErrorOnNoMatch)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,107197,107558);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,107455,107547);

return f_1602_107462_107546(this, writeobject, writeErrorOnNoMatch, SessionFilterState.All, null);
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,107197,107558);

System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1602_107462_107546(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,bool
writeobject,bool
writeErrorOnNoMatch,Microsoft.PowerShell.Commands.SessionFilterState
filterState,string
configurationName)
{
var return_v = this_param.GetMatchingRunspaces( writeobject, writeErrorOnNoMatch, filterState, configurationName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 107462, 107546);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,107197,107558);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,107197,107558);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspaces")]
        protected Dictionary<Guid, PSSession> GetMatchingRunspaces(bool writeobject,
            bool writeErrorOnNoMatch,
            SessionFilterState filterState,
            string configurationName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,108135,111345);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,108477,111306);

switch (f_1602_108485_108501())
            {

case PSRunspaceCmdlet.ComputerNameParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,108477,111306);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,108631,108707);

return f_1602_108638_108706(this, writeobject, writeErrorOnNoMatch);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,108477,111306);

case PSRunspaceCmdlet.InstanceIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,108477,111306);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,108844,108918);

return f_1602_108851_108917(this, writeobject, writeErrorOnNoMatch);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,108477,111306);

case PSRunspaceCmdlet.NameParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,108477,111306);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,109049,109117);

return f_1602_109056_109116(this, writeobject, writeErrorOnNoMatch);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,108477,111306);

case PSRunspaceCmdlet.IdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,108477,111306);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,109246,109319);

return f_1602_109253_109318(this, writeobject, writeErrorOnNoMatch);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,108477,111306);

case PSRunspaceCmdlet.ContainerIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,108477,111306);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,109713,109811);

return f_1602_109720_109810(this, writeobject, filterState, configurationName, true);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,108477,111306);

case PSRunspaceCmdlet.ContainerIdInstanceIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,108477,111306);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,110013,110128);

return f_1602_110020_110127(this, writeobject, filterState, configurationName, true);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,108477,111306);

case PSRunspaceCmdlet.VMIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,108477,111306);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,110311,110390);

return f_1602_110318_110389(this, writeobject, filterState, configurationName);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,108477,111306);

case PSRunspaceCmdlet.VMIdInstanceIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,108477,111306);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,110580,110676);

return f_1602_110587_110675(this, writeobject, filterState, configurationName);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,108477,111306);

case PSRunspaceCmdlet.VMNameParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,108477,111306);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,110861,110960);

return f_1602_110868_110959(this, writeobject, filterState, configurationName, false);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,108477,111306);

case PSRunspaceCmdlet.VMNameInstanceIdParameterSet:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,108477,111306);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,111152,111268);

return f_1602_111159_111267(this, writeobject, filterState, configurationName, false);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,108477,111306);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,111322,111334);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,108135,111345);

string
f_1602_108485_108501()
{
var return_v = ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 108485, 108501);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1602_108638_108706(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,bool
writeobject,bool
writeErrorOnNoMatch)
{
var return_v = this_param.GetMatchingRunspacesByComputerName( writeobject, writeErrorOnNoMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 108638, 108706);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1602_108851_108917(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,bool
writeobject,bool
writeErrorOnNoMatch)
{
var return_v = this_param.GetMatchingRunspacesByRunspaceId( writeobject, writeErrorOnNoMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 108851, 108917);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1602_109056_109116(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,bool
writeobject,bool
writeErrorOnNoMatch)
{
var return_v = this_param.GetMatchingRunspacesByName( writeobject, writeErrorOnNoMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 109056, 109116);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1602_109253_109318(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,bool
writeobject,bool
writeErrorOnNoMatch)
{
var return_v = this_param.GetMatchingRunspacesBySessionId( writeobject, writeErrorOnNoMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 109253, 109318);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1602_109720_109810(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,bool
writeobject,Microsoft.PowerShell.Commands.SessionFilterState
filterState,string
configurationName,bool
isContainer)
{
var return_v = this_param.GetMatchingRunspacesByVMNameContainerId( writeobject, filterState, configurationName, isContainer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 109720, 109810);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1602_110020_110127(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,bool
writeobject,Microsoft.PowerShell.Commands.SessionFilterState
filterState,string
configurationName,bool
isContainer)
{
var return_v = this_param.GetMatchingRunspacesByVMNameContainerIdSessionInstanceId( writeobject, filterState, configurationName, isContainer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 110020, 110127);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1602_110318_110389(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,bool
writeobject,Microsoft.PowerShell.Commands.SessionFilterState
filterState,string
configurationName)
{
var return_v = this_param.GetMatchingRunspacesByVMId( writeobject, filterState, configurationName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 110318, 110389);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1602_110587_110675(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,bool
writeobject,Microsoft.PowerShell.Commands.SessionFilterState
filterState,string
configurationName)
{
var return_v = this_param.GetMatchingRunspacesByVMIdSessionInstanceId( writeobject, filterState, configurationName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 110587, 110675);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1602_110868_110959(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,bool
writeobject,Microsoft.PowerShell.Commands.SessionFilterState
filterState,string
configurationName,bool
isContainer)
{
var return_v = this_param.GetMatchingRunspacesByVMNameContainerId( writeobject, filterState, configurationName, isContainer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 110868, 110959);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1602_111159_111267(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,bool
writeobject,Microsoft.PowerShell.Commands.SessionFilterState
filterState,string
configurationName,bool
isContainer)
{
var return_v = this_param.GetMatchingRunspacesByVMNameContainerIdSessionInstanceId( writeobject, filterState, configurationName, isContainer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 111159, 111267);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,108135,111345);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,108135,111345);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Dictionary<Guid, PSSession> GetAllRunspaces(bool writeobject,
            bool writeErrorOnNoMatch)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,111357,112127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,111491,111563);

Dictionary<Guid, PSSession> 
matches = f_1602_111529_111562()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,111577,111649);

List<PSSession> 
remoteRunspaceInfos = f_1602_111615_111648(f_1602_111615_111638(this))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,111663,112085);
foreach(PSSession remoteRunspaceInfo in f_1602_111704_111723_I(remoteRunspaceInfos) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,111663,112085);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,111817,112070) || true) && (writeobject)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,111817,112070);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,111874,111906);

f_1602_111874_111905(this, remoteRunspaceInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,111817,112070);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,111817,112070);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,111988,112051);

f_1602_111988_112050(                    matches, f_1602_112000_112029(remoteRunspaceInfo), remoteRunspaceInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,111817,112070);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,111663,112085);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,423);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,423);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,112101,112116);

return matches;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,111357,112127);

System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1602_111529_111562()
{
var return_v = new System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 111529, 111562);
return return_v;
}


System.Management.Automation.RunspaceRepository
f_1602_111615_111638(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 111615, 111638);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1602_111615_111648(System.Management.Automation.RunspaceRepository
this_param)
{
var return_v = this_param.Runspaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 111615, 111648);
return return_v;
}


int
f_1602_111874_111905(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,System.Management.Automation.Runspaces.PSSession
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 111874, 111905);
return 0;
}


System.Guid
f_1602_112000_112029(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 112000, 112029);
return return_v;
}


int
f_1602_111988_112050(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
this_param,System.Guid
key,System.Management.Automation.Runspaces.PSSession
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 111988, 112050);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1602_111704_111723_I(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 111704, 111723);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,111357,112127);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,111357,112127);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Dictionary<Guid, PSSession> GetMatchingRunspacesByComputerName(bool writeobject,
            bool writeErrorOnNoMatch)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,112524,114783);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,112676,112838) || true) && (_computerNames == null ||(DynAbs.Tracing.TraceSender.Expression_False(1602, 112680, 112732)||f_1602_112706_112727(_computerNames)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,112676,112838);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,112766,112823);

return f_1602_112773_112822(this, writeobject, writeErrorOnNoMatch);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,112676,112838);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,112854,112926);

Dictionary<Guid, PSSession> 
matches = f_1602_112892_112925()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,112942,113014);

List<PSSession> 
remoteRunspaceInfos = f_1602_112980_113013(f_1602_112980_113003(this))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,113117,114741);
foreach(string computerName in f_1602_113149_113163_I(_computerNames) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,113117,114741);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,113197,113297);

WildcardPattern 
computerNamePattern = f_1602_113235_113296(computerName, WildcardOptions.IgnoreCase)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,113422,113441);

bool 
found = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,113459,114349);
foreach(PSSession remoteRunspaceInfo in f_1602_113500_113519_I(remoteRunspaceInfos) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,113459,114349);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,113561,114330) || true) && (f_1602_113565_113625(computerNamePattern, f_1602_113593_113624(remoteRunspaceInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,113561,114330);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,113675,113688);

found = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,113716,114307) || true) && (writeobject)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,113716,114307);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,113789,113821);

f_1602_113789_113820(this, remoteRunspaceInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,113716,114307);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,113716,114307);
                            try
                            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,114003,114066);

f_1602_114003_114065(                                matches, f_1602_114015_114044(remoteRunspaceInfo), remoteRunspaceInfo);
                            }
                            catch (ArgumentException)
                            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,114127,114280);
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,114127,114280);
                                // if match already found ignore
                            }
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,113716,114307);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,113561,114330);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,113459,114349);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,891);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,891);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,114430,114726) || true) && (!found &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 114434, 114463)&&writeErrorOnNoMatch))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,114430,114726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,114505,114707);

f_1602_114505_114706(this, PSRemotingErrorId.RemoteRunspaceNotAvailableForSpecifiedComputer, f_1602_114597_114666(), computerName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,114430,114726);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,113117,114741);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,1625);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,1625);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,114757,114772);

return matches;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,112524,114783);

int
f_1602_112706_112727(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 112706, 112727);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1602_112773_112822(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,bool
writeobject,bool
writeErrorOnNoMatch)
{
var return_v = this_param.GetAllRunspaces( writeobject, writeErrorOnNoMatch);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 112773, 112822);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1602_112892_112925()
{
var return_v = new System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 112892, 112925);
return return_v;
}


System.Management.Automation.RunspaceRepository
f_1602_112980_113003(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 112980, 113003);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1602_112980_113013(System.Management.Automation.RunspaceRepository
this_param)
{
var return_v = this_param.Runspaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 112980, 113013);
return return_v;
}


System.Management.Automation.WildcardPattern
f_1602_113235_113296(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 113235, 113296);
return return_v;
}


string
f_1602_113593_113624(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 113593, 113624);
return return_v;
}


bool
f_1602_113565_113625(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 113565, 113625);
return return_v;
}


int
f_1602_113789_113820(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,System.Management.Automation.Runspaces.PSSession
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 113789, 113820);
return 0;
}


System.Guid
f_1602_114015_114044(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 114015, 114044);
return return_v;
}


int
f_1602_114003_114065(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
this_param,System.Guid
key,System.Management.Automation.Runspaces.PSSession
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 114003, 114065);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1602_113500_113519_I(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 113500, 113519);
return return_v;
}


string
f_1602_114597_114666()
{
var return_v = RemotingErrorIdStrings.RemoteRunspaceNotAvailableForSpecifiedComputer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 114597, 114666);
return return_v;
}


int
f_1602_114505_114706(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,System.Management.Automation.Remoting.PSRemotingErrorId
errorId,string
resourceString,string
errorArgument)
{
this_param.WriteInvalidArgumentError( errorId, resourceString, (object)errorArgument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 114505, 114706);
return 0;
}


string[]
f_1602_113149_113163_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 113149, 113163);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,112524,114783);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,112524,114783);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspaces")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "writeobject")]
        protected Dictionary<Guid, PSSession> GetMatchingRunspacesByName(bool writeobject,
            bool writeErrorOnNoMatch)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,115177,117479);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,115561,115633);

Dictionary<Guid, PSSession> 
matches = f_1602_115599_115632()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,115649,115721);

List<PSSession> 
remoteRunspaceInfos = f_1602_115687_115720(f_1602_115687_115710(this))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,115824,117437);
foreach(string name in f_1602_115848_115854_I(_names) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,115824,117437);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,115888,115972);

WildcardPattern 
namePattern = f_1602_115918_115971(name, WildcardOptions.IgnoreCase)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,116097,116116);

bool 
found = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,116134,117008);
foreach(PSSession remoteRunspaceInfo in f_1602_116175_116194_I(remoteRunspaceInfos) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,116134,117008);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,116236,116989) || true) && (f_1602_116240_116284(namePattern, f_1602_116260_116283(remoteRunspaceInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,116236,116989);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,116334,116347);

found = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,116375,116966) || true) && (writeobject)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,116375,116966);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,116448,116480);

f_1602_116448_116479(this, remoteRunspaceInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,116375,116966);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,116375,116966);
                            try
                            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,116662,116725);

f_1602_116662_116724(                                matches, f_1602_116674_116703(remoteRunspaceInfo), remoteRunspaceInfo);
                            }
                            catch (ArgumentException)
                            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,116786,116939);
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,116786,116939);
                                // if match already found ignore
                            }
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,116375,116966);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,116236,116989);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,116134,117008);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,875);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,875);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,117089,117422) || true) && (!found &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 117093, 117122)&&writeErrorOnNoMatch )&&(DynAbs.Tracing.TraceSender.Expression_True(1602, 117093, 117175)&&!f_1602_117127_117175(name)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,117089,117422);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,117217,117403);

f_1602_117217_117402(this, PSRemotingErrorId.RemoteRunspaceNotAvailableForSpecifiedName, f_1602_117305_117370(), name);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,117089,117422);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,115824,117437);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,1614);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,1614);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,117453,117468);

return matches;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,115177,117479);

System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1602_115599_115632()
{
var return_v = new System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 115599, 115632);
return return_v;
}


System.Management.Automation.RunspaceRepository
f_1602_115687_115710(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 115687, 115710);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1602_115687_115720(System.Management.Automation.RunspaceRepository
this_param)
{
var return_v = this_param.Runspaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 115687, 115720);
return return_v;
}


System.Management.Automation.WildcardPattern
f_1602_115918_115971(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 115918, 115971);
return return_v;
}


string
f_1602_116260_116283(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 116260, 116283);
return return_v;
}


bool
f_1602_116240_116284(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 116240, 116284);
return return_v;
}


int
f_1602_116448_116479(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,System.Management.Automation.Runspaces.PSSession
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 116448, 116479);
return 0;
}


System.Guid
f_1602_116674_116703(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 116674, 116703);
return return_v;
}


int
f_1602_116662_116724(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
this_param,System.Guid
key,System.Management.Automation.Runspaces.PSSession
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 116662, 116724);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1602_116175_116194_I(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 116175, 116194);
return return_v;
}


bool
f_1602_117127_117175(string
pattern)
{
var return_v = WildcardPattern.ContainsWildcardCharacters( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 117127, 117175);
return return_v;
}


string
f_1602_117305_117370()
{
var return_v = RemotingErrorIdStrings.RemoteRunspaceNotAvailableForSpecifiedName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 117305, 117370);
return return_v;
}


int
f_1602_117217_117402(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,System.Management.Automation.Remoting.PSRemotingErrorId
errorId,string
resourceString,string
errorArgument)
{
this_param.WriteInvalidArgumentError( errorId, resourceString, (object)errorArgument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 117217, 117402);
return 0;
}


string[]
f_1602_115848_115854_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 115848, 115854);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,115177,117479);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,115177,117479);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspaces")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "writeobject")]
        protected Dictionary<Guid, PSSession> GetMatchingRunspacesByRunspaceId(bool writeobject,
            bool writeErrorOnNoMatch)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,117894,120101);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,118284,118356);

Dictionary<Guid, PSSession> 
matches = f_1602_118322_118355()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,118372,118444);

List<PSSession> 
remoteRunspaceInfos = f_1602_118410_118443(f_1602_118410_118433(this))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,118547,120059);
foreach(Guid remoteRunspaceId in f_1602_118581_118599_I(_remoteRunspaceIds) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,118547,120059);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,118738,118757);

bool 
found = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,118775,119659);
foreach(PSSession remoteRunspaceInfo in f_1602_118816_118835_I(remoteRunspaceInfos) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,118775,119659);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,118877,119640) || true) && (remoteRunspaceId.Equals(f_1602_118905_118934(remoteRunspaceInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,118877,119640);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,118985,118998);

found = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,119026,119617) || true) && (writeobject)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,119026,119617);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,119099,119131);

f_1602_119099_119130(this, remoteRunspaceInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,119026,119617);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,119026,119617);
                            try
                            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,119313,119376);

f_1602_119313_119375(                                matches, f_1602_119325_119354(remoteRunspaceInfo), remoteRunspaceInfo);
                            }
                            catch (ArgumentException)
                            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,119437,119590);
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,119437,119590);
                                // if match already found ignore
                            }
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,119026,119617);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,118877,119640);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,118775,119659);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,885);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,885);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,119740,120044) || true) && (!found &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 119744, 119773)&&writeErrorOnNoMatch))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,119740,120044);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,119815,120025);

f_1602_119815_120024(this, PSRemotingErrorId.RemoteRunspaceNotAvailableForSpecifiedRunspaceId, f_1602_119909_119980(), remoteRunspaceId);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,119740,120044);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,118547,120059);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,1513);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,1513);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,120075,120090);

return matches;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,117894,120101);

System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1602_118322_118355()
{
var return_v = new System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 118322, 118355);
return return_v;
}


System.Management.Automation.RunspaceRepository
f_1602_118410_118433(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 118410, 118433);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1602_118410_118443(System.Management.Automation.RunspaceRepository
this_param)
{
var return_v = this_param.Runspaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 118410, 118443);
return return_v;
}


System.Guid
f_1602_118905_118934(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 118905, 118934);
return return_v;
}


int
f_1602_119099_119130(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,System.Management.Automation.Runspaces.PSSession
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 119099, 119130);
return 0;
}


System.Guid
f_1602_119325_119354(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 119325, 119354);
return return_v;
}


int
f_1602_119313_119375(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
this_param,System.Guid
key,System.Management.Automation.Runspaces.PSSession
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 119313, 119375);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1602_118816_118835_I(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 118816, 118835);
return return_v;
}


string
f_1602_119909_119980()
{
var return_v = RemotingErrorIdStrings.RemoteRunspaceNotAvailableForSpecifiedRunspaceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 119909, 119980);
return return_v;
}


int
f_1602_119815_120024(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,System.Management.Automation.Remoting.PSRemotingErrorId
errorId,string
resourceString,System.Guid
errorArgument)
{
this_param.WriteInvalidArgumentError( errorId, resourceString, (object)errorArgument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 119815, 120024);
return 0;
}


System.Guid[]
f_1602_118581_118599_I(System.Guid[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 118581, 118599);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,117894,120101);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,117894,120101);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Dictionary<Guid, PSSession> GetMatchingRunspacesBySessionId(bool writeobject,
            bool writeErrorOnNoMatch)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,120571,122484);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,120720,120792);

Dictionary<Guid, PSSession> 
matches = f_1602_120758_120791()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,120808,120880);

List<PSSession> 
remoteRunspaceInfos = f_1602_120846_120879(f_1602_120846_120869(this))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,120983,122442);
foreach(int sessionId in f_1602_121009_121011_I(f_1602_121009_121011()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,120983,122442);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,121150,121169);

bool 
found = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,121187,122051);
foreach(PSSession remoteRunspaceInfo in f_1602_121228_121247_I(remoteRunspaceInfos) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,121187,122051);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,121289,122032) || true) && (sessionId == f_1602_121306_121327(remoteRunspaceInfo))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,121289,122032);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,121377,121390);

found = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,121418,122009) || true) && (writeobject)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,121418,122009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,121491,121523);

f_1602_121491_121522(this, remoteRunspaceInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,121418,122009);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,121418,122009);
                            try
                            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,121705,121768);

f_1602_121705_121767(                                matches, f_1602_121717_121746(remoteRunspaceInfo), remoteRunspaceInfo);
                            }
                            catch (ArgumentException)
                            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,121829,121982);
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,121829,121982);
                                // if match already found ignore
                            }
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,121418,122009);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,121289,122032);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,121187,122051);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,865);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,865);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,122132,122427) || true) && (!found &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 122136, 122165)&&writeErrorOnNoMatch))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,122132,122427);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,122207,122408);

f_1602_122207_122407(this, PSRemotingErrorId.RemoteRunspaceNotAvailableForSpecifiedSessionId, f_1602_122300_122370(), sessionId);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,122132,122427);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,120983,122442);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,1460);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,1460);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,122458,122473);

return matches;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,120571,122484);

System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1602_120758_120791()
{
var return_v = new System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 120758, 120791);
return return_v;
}


System.Management.Automation.RunspaceRepository
f_1602_120846_120869(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 120846, 120869);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1602_120846_120879(System.Management.Automation.RunspaceRepository
this_param)
{
var return_v = this_param.Runspaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 120846, 120879);
return return_v;
}


int[]
f_1602_121009_121011()
{
var return_v = Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 121009, 121011);
return return_v;
}


int
f_1602_121306_121327(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 121306, 121327);
return return_v;
}


int
f_1602_121491_121522(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,System.Management.Automation.Runspaces.PSSession
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 121491, 121522);
return 0;
}


System.Guid
f_1602_121717_121746(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 121717, 121746);
return return_v;
}


int
f_1602_121705_121767(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
this_param,System.Guid
key,System.Management.Automation.Runspaces.PSSession
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 121705, 121767);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1602_121228_121247_I(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 121228, 121247);
return return_v;
}


string
f_1602_122300_122370()
{
var return_v = RemotingErrorIdStrings.RemoteRunspaceNotAvailableForSpecifiedSessionId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 122300, 122370);
return return_v;
}


int
f_1602_122207_122407(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,System.Management.Automation.Remoting.PSRemotingErrorId
errorId,string
resourceString,int
errorArgument)
{
this_param.WriteInvalidArgumentError( errorId, resourceString, (object)errorArgument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 122207, 122407);
return 0;
}


int[]
f_1602_121009_121011_I(int[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 121009, 121011);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,120571,122484);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,120571,122484);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Dictionary<Guid, PSSession> GetMatchingRunspacesByVMNameContainerId(bool writeobject,
            SessionFilterState filterState,
            string configurationName,
            bool isContainer)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,123070,126052);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,123303,123323);

string[] 
inputNames
=default(string[]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,123337,123368);

TargetMachineType 
computerType
=default(TargetMachineType);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,123382,123403);

bool 
supportWildChar
=default(bool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,123417,123449);

string[] 
sessionNames = { "*" }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,123463,123639);

WildcardPattern 
configurationNamePattern =
(DynAbs.Tracing.TraceSender.Conditional_F1(1602, 123523, 123562)||((f_1602_123523_123562(configurationName)&&DynAbs.Tracing.TraceSender.Conditional_F2(1602, 123565, 123569))||DynAbs.Tracing.TraceSender.Conditional_F3(1602, 123572, 123638)))?null :f_1602_123572_123638(configurationName, WildcardOptions.IgnoreCase)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,123653,123725);

Dictionary<Guid, PSSession> 
matches = f_1602_123691_123724()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,123739,123811);

List<PSSession> 
remoteRunspaceInfos = f_1602_123777_123810(f_1602_123777_123800(this))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,124005,124390) || true) && (isContainer)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,124005,124390);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,124054,124079);

inputNames = f_1602_124067_124078();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,124097,124140);

computerType = TargetMachineType.Container;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,124158,124182);

supportWildChar = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,124005,124390);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,124005,124390);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,124248,124268);

inputNames = f_1602_124261_124267();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,124286,124334);

computerType = TargetMachineType.VirtualMachine;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,124352,124375);

supportWildChar = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,124005,124390);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,124483,124568) || true) && (f_1602_124487_124491()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,124483,124568);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,124533,124553);

sessionNames = f_1602_124548_124552();
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,124483,124568);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,124584,126010);
foreach(string inputName in f_1602_124613_124623_I(inputNames) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,124584,126010);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,124657,124751);

WildcardPattern 
inputNamePattern = f_1602_124692_124750(inputName, WildcardOptions.IgnoreCase)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,124771,125995);
foreach(string sessionName in f_1602_124802_124814_I(sessionNames) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,124771,125995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,124856,125022);

WildcardPattern 
sessionNamePattern =
(DynAbs.Tracing.TraceSender.Conditional_F1(1602, 124918, 124951)||((f_1602_124918_124951(sessionName)&&DynAbs.Tracing.TraceSender.Conditional_F2(1602, 124954, 124958))||DynAbs.Tracing.TraceSender.Conditional_F3(1602, 124961, 125021)))?null :f_1602_124961_125021(sessionName, WildcardOptions.IgnoreCase)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,125046,125885);

var 
matchingRunspaceInfos = f_1602_125074_125884(f_1602_125074_125838(remoteRunspaceInfos
, session => (supportWildChar ? inputNamePattern.IsMatch(session.VMName)
                                                                      : inputName.Equals(session.ContainerId)) &&
                                                     ((sessionNamePattern == null) ? true : sessionNamePattern.IsMatch(session.Name)) &&
                                                     QueryRunspaces.TestRunspaceState(session.Runspace, filterState) &&
                                                     ((configurationNamePattern == null) ? true : configurationNamePattern.IsMatch(session.ConfigurationName)) &&
                                                     (session.ComputerType == computerType)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,125909,125976);

f_1602_125909_125975(this, matchingRunspaceInfos, writeobject, ref matches);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,124771,125995);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,1225);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,1225);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1602,124584,126010);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,1427);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,1427);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,126026,126041);

return matches;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,123070,126052);

bool
f_1602_123523_123562(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 123523, 123562);
return return_v;
}


System.Management.Automation.WildcardPattern
f_1602_123572_123638(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 123572, 123638);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1602_123691_123724()
{
var return_v = new System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 123691, 123724);
return return_v;
}


System.Management.Automation.RunspaceRepository
f_1602_123777_123800(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 123777, 123800);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1602_123777_123810(System.Management.Automation.RunspaceRepository
this_param)
{
var return_v = this_param.Runspaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 123777, 123810);
return return_v;
}


string[]
f_1602_124067_124078()
{
var return_v = ContainerId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 124067, 124078);
return return_v;
}


string[]
f_1602_124261_124267()
{
var return_v = VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 124261, 124267);
return return_v;
}


string[]
f_1602_124487_124491()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 124487, 124491);
return return_v;
}


string[]
f_1602_124548_124552()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 124548, 124552);
return return_v;
}


System.Management.Automation.WildcardPattern
f_1602_124692_124750(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 124692, 124750);
return return_v;
}


bool
f_1602_124918_124951(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 124918, 124951);
return return_v;
}


System.Management.Automation.WildcardPattern
f_1602_124961_125021(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 124961, 125021);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.PSSession>
f_1602_125074_125838(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
source,System.Func<System.Management.Automation.Runspaces.PSSession, bool>
predicate)
{
var return_v = source.Where<System.Management.Automation.Runspaces.PSSession>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 125074, 125838);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1602_125074_125884(System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.PSSession>
source)
{
var return_v = source.ToList<System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 125074, 125884);
return return_v;
}


int
f_1602_125909_125975(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
matchingRunspaceInfos,bool
writeobject,ref System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
matches)
{
this_param.WriteOrAddMatches( matchingRunspaceInfos, writeobject, ref matches);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 125909, 125975);
return 0;
}


string[]
f_1602_124802_124814_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 124802, 124814);
return return_v;
}


string[]
f_1602_124613_124623_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 124613, 124623);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,123070,126052);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,123070,126052);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Dictionary<Guid, PSSession> GetMatchingRunspacesByVMNameContainerIdSessionInstanceId(bool writeobject,
            SessionFilterState filterState,
            string configurationName,
            bool isContainer)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,126635,129186);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,126885,126905);

string[] 
inputNames
=default(string[]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,126919,126950);

TargetMachineType 
computerType
=default(TargetMachineType);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,126964,126985);

bool 
supportWildChar
=default(bool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,126999,127175);

WildcardPattern 
configurationNamePattern =
(DynAbs.Tracing.TraceSender.Conditional_F1(1602, 127059, 127098)||((f_1602_127059_127098(configurationName)&&DynAbs.Tracing.TraceSender.Conditional_F2(1602, 127101, 127105))||DynAbs.Tracing.TraceSender.Conditional_F3(1602, 127108, 127174)))?null :f_1602_127108_127174(configurationName, WildcardOptions.IgnoreCase)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,127189,127261);

Dictionary<Guid, PSSession> 
matches = f_1602_127227_127260()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,127275,127347);

List<PSSession> 
remoteRunspaceInfos = f_1602_127313_127346(f_1602_127313_127336(this))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,127541,127926) || true) && (isContainer)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,127541,127926);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,127590,127615);

inputNames = f_1602_127603_127614();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,127633,127676);

computerType = TargetMachineType.Container;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,127694,127718);

supportWildChar = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,127541,127926);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,127541,127926);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,127784,127804);

inputNames = f_1602_127797_127803();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,127822,127870);

computerType = TargetMachineType.VirtualMachine;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,127888,127911);

supportWildChar = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,127541,127926);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,127942,129144);
foreach(string inputName in f_1602_127971_127981_I(inputNames) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,127942,129144);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,128015,128109);

WildcardPattern 
inputNamePattern = f_1602_128050_128108(inputName, WildcardOptions.IgnoreCase)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,128129,129129);
foreach(Guid sessionInstanceId in f_1602_128164_128174_I(f_1602_128164_128174()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,128129,129129);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,128216,129019);

var 
matchingRunspaceInfos = f_1602_128244_129018(f_1602_128244_128972(remoteRunspaceInfos
, session => (supportWildChar ? inputNamePattern.IsMatch(session.VMName)
                                                                      : inputName.Equals(session.ContainerId)) &&
                                                     sessionInstanceId.Equals(session.InstanceId) &&
                                                     QueryRunspaces.TestRunspaceState(session.Runspace, filterState) &&
                                                     ((configurationNamePattern == null) ? true : configurationNamePattern.IsMatch(session.ConfigurationName)) &&
                                                     (session.ComputerType == computerType)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,129043,129110);

f_1602_129043_129109(this, matchingRunspaceInfos, writeobject, ref matches);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,128129,129129);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,1001);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,1001);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1602,127942,129144);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,1203);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,1203);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,129160,129175);

return matches;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,126635,129186);

bool
f_1602_127059_127098(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 127059, 127098);
return return_v;
}


System.Management.Automation.WildcardPattern
f_1602_127108_127174(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 127108, 127174);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1602_127227_127260()
{
var return_v = new System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 127227, 127260);
return return_v;
}


System.Management.Automation.RunspaceRepository
f_1602_127313_127336(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 127313, 127336);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1602_127313_127346(System.Management.Automation.RunspaceRepository
this_param)
{
var return_v = this_param.Runspaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 127313, 127346);
return return_v;
}


string[]
f_1602_127603_127614()
{
var return_v = ContainerId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 127603, 127614);
return return_v;
}


string[]
f_1602_127797_127803()
{
var return_v = VMName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 127797, 127803);
return return_v;
}


System.Management.Automation.WildcardPattern
f_1602_128050_128108(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 128050, 128108);
return return_v;
}


System.Guid[]
f_1602_128164_128174()
{
var return_v = InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 128164, 128174);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.PSSession>
f_1602_128244_128972(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
source,System.Func<System.Management.Automation.Runspaces.PSSession, bool>
predicate)
{
var return_v = source.Where<System.Management.Automation.Runspaces.PSSession>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 128244, 128972);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1602_128244_129018(System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.PSSession>
source)
{
var return_v = source.ToList<System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 128244, 129018);
return return_v;
}


int
f_1602_129043_129109(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
matchingRunspaceInfos,bool
writeobject,ref System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
matches)
{
this_param.WriteOrAddMatches( matchingRunspaceInfos, writeobject, ref matches);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 129043, 129109);
return 0;
}


System.Guid[]
f_1602_128164_128174_I(System.Guid[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 128164, 128174);
return return_v;
}


string[]
f_1602_127971_127981_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 127971, 127981);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,126635,129186);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,126635,129186);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Dictionary<Guid, PSSession> GetMatchingRunspacesByVMId(bool writeobject,
            SessionFilterState filterState,
            string configurationName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,129646,131639);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,129835,129867);

string[] 
sessionNames = { "*" }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,129881,130057);

WildcardPattern 
configurationNamePattern =
(DynAbs.Tracing.TraceSender.Conditional_F1(1602, 129941, 129980)||((f_1602_129941_129980(configurationName)&&DynAbs.Tracing.TraceSender.Conditional_F2(1602, 129983, 129987))||DynAbs.Tracing.TraceSender.Conditional_F3(1602, 129990, 130056)))?null :f_1602_129990_130056(configurationName, WildcardOptions.IgnoreCase)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,130071,130143);

Dictionary<Guid, PSSession> 
matches = f_1602_130109_130142()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,130157,130229);

List<PSSession> 
remoteRunspaceInfos = f_1602_130195_130228(f_1602_130195_130218(this))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,130323,130408) || true) && (f_1602_130327_130331()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,130323,130408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,130373,130393);

sessionNames = f_1602_130388_130392();
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,130323,130408);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,130424,131597);
foreach(Guid vmId in f_1602_130446_130450_I(f_1602_130446_130450()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,130424,131597);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,130484,131582);
foreach(string sessionName in f_1602_130515_130527_I(sessionNames) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,130484,131582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,130569,130735);

WildcardPattern 
sessionNamePattern =
(DynAbs.Tracing.TraceSender.Conditional_F1(1602, 130631, 130664)||((f_1602_130631_130664(sessionName)&&DynAbs.Tracing.TraceSender.Conditional_F2(1602, 130667, 130671))||DynAbs.Tracing.TraceSender.Conditional_F3(1602, 130674, 130734)))?null :f_1602_130674_130734(sessionName, WildcardOptions.IgnoreCase)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,130759,131472);

var 
matchingRunspaceInfos = f_1602_130787_131471(f_1602_130787_131425(remoteRunspaceInfos
, session => vmId.Equals(session.VMId) &&
                                                     ((sessionNamePattern == null) ? true : sessionNamePattern.IsMatch(session.Name)) &&
                                                     QueryRunspaces.TestRunspaceState(session.Runspace, filterState) &&
                                                     ((configurationNamePattern == null) ? true : configurationNamePattern.IsMatch(session.ConfigurationName)) &&
                                                     (session.ComputerType == TargetMachineType.VirtualMachine)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,131496,131563);

f_1602_131496_131562(this, matchingRunspaceInfos, writeobject, ref matches);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,130484,131582);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,1099);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,1099);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1602,130424,131597);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,1174);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,1174);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,131613,131628);

return matches;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,129646,131639);

bool
f_1602_129941_129980(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 129941, 129980);
return return_v;
}


System.Management.Automation.WildcardPattern
f_1602_129990_130056(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 129990, 130056);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1602_130109_130142()
{
var return_v = new System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 130109, 130142);
return return_v;
}


System.Management.Automation.RunspaceRepository
f_1602_130195_130218(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 130195, 130218);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1602_130195_130228(System.Management.Automation.RunspaceRepository
this_param)
{
var return_v = this_param.Runspaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 130195, 130228);
return return_v;
}


string[]
f_1602_130327_130331()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 130327, 130331);
return return_v;
}


string[]
f_1602_130388_130392()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 130388, 130392);
return return_v;
}


System.Guid[]
f_1602_130446_130450()
{
var return_v = VMId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 130446, 130450);
return return_v;
}


bool
f_1602_130631_130664(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 130631, 130664);
return return_v;
}


System.Management.Automation.WildcardPattern
f_1602_130674_130734(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 130674, 130734);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.PSSession>
f_1602_130787_131425(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
source,System.Func<System.Management.Automation.Runspaces.PSSession, bool>
predicate)
{
var return_v = source.Where<System.Management.Automation.Runspaces.PSSession>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 130787, 131425);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1602_130787_131471(System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.PSSession>
source)
{
var return_v = source.ToList<System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 130787, 131471);
return return_v;
}


int
f_1602_131496_131562(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
matchingRunspaceInfos,bool
writeobject,ref System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
matches)
{
this_param.WriteOrAddMatches( matchingRunspaceInfos, writeobject, ref matches);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 131496, 131562);
return 0;
}


string[]
f_1602_130515_130527_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 130515, 130527);
return return_v;
}


System.Guid[]
f_1602_130446_130450_I(System.Guid[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 130446, 130450);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,129646,131639);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,129646,131639);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Dictionary<Guid, PSSession> GetMatchingRunspacesByVMIdSessionInstanceId(bool writeobject,
            SessionFilterState filterState,
            string configurationName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,132096,133657);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,132302,132478);

WildcardPattern 
configurationNamePattern =
(DynAbs.Tracing.TraceSender.Conditional_F1(1602, 132362, 132401)||((f_1602_132362_132401(configurationName)&&DynAbs.Tracing.TraceSender.Conditional_F2(1602, 132404, 132408))||DynAbs.Tracing.TraceSender.Conditional_F3(1602, 132411, 132477)))?null :f_1602_132411_132477(configurationName, WildcardOptions.IgnoreCase)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,132492,132564);

Dictionary<Guid, PSSession> 
matches = f_1602_132530_132563()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,132578,132650);

List<PSSession> 
remoteRunspaceInfos = f_1602_132616_132649(f_1602_132616_132639(this))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,132666,133615);
foreach(Guid vmId in f_1602_132688_132692_I(f_1602_132688_132692()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,132666,133615);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,132726,133600);
foreach(Guid sessionInstanceId in f_1602_132761_132771_I(f_1602_132761_132771()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,132726,133600);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,132813,133490);

var 
matchingRunspaceInfos = f_1602_132841_133489(f_1602_132841_133443(remoteRunspaceInfos
, session => vmId.Equals(session.VMId) &&
                                                     sessionInstanceId.Equals(session.InstanceId) &&
                                                     QueryRunspaces.TestRunspaceState(session.Runspace, filterState) &&
                                                     ((configurationNamePattern == null) ? true : configurationNamePattern.IsMatch(session.ConfigurationName)) &&
                                                     (session.ComputerType == TargetMachineType.VirtualMachine)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,133514,133581);

f_1602_133514_133580(this, matchingRunspaceInfos, writeobject, ref matches);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,132726,133600);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,875);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,875);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1602,132666,133615);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,950);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,950);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,133631,133646);

return matches;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,132096,133657);

bool
f_1602_132362_132401(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 132362, 132401);
return return_v;
}


System.Management.Automation.WildcardPattern
f_1602_132411_132477(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 132411, 132477);
return return_v;
}


System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
f_1602_132530_132563()
{
var return_v = new System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 132530, 132563);
return return_v;
}


System.Management.Automation.RunspaceRepository
f_1602_132616_132639(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param)
{
var return_v = this_param.RunspaceRepository;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 132616, 132639);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1602_132616_132649(System.Management.Automation.RunspaceRepository
this_param)
{
var return_v = this_param.Runspaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 132616, 132649);
return return_v;
}


System.Guid[]
f_1602_132688_132692()
{
var return_v = VMId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 132688, 132692);
return return_v;
}


System.Guid[]
f_1602_132761_132771()
{
var return_v = InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 132761, 132771);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.PSSession>
f_1602_132841_133443(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
source,System.Func<System.Management.Automation.Runspaces.PSSession, bool>
predicate)
{
var return_v = source.Where<System.Management.Automation.Runspaces.PSSession>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 132841, 133443);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1602_132841_133489(System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.PSSession>
source)
{
var return_v = source.ToList<System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 132841, 133489);
return return_v;
}


int
f_1602_133514_133580(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
matchingRunspaceInfos,bool
writeobject,ref System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
matches)
{
this_param.WriteOrAddMatches( matchingRunspaceInfos, writeobject, ref matches);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 133514, 133580);
return 0;
}


System.Guid[]
f_1602_132761_132771_I(System.Guid[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 132761, 132771);
return return_v;
}


System.Guid[]
f_1602_132688_132692_I(System.Guid[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 132688, 132692);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,132096,133657);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,132096,133657);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void WriteOrAddMatches(List<PSSession> matchingRunspaceInfos,
            bool writeobject,
            ref Dictionary<Guid, PSSession> matches)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,134090,134870);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,134269,134859);
foreach(PSSession remoteRunspaceInfo in f_1602_134310_134331_I(matchingRunspaceInfos) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,134269,134859);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,134365,134844) || true) && (writeobject)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,134365,134844);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,134422,134454);

f_1602_134422_134453(this, remoteRunspaceInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,134365,134844);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,134365,134844);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,134588,134651);

f_1602_134588_134650(                        matches, f_1602_134600_134629(remoteRunspaceInfo), remoteRunspaceInfo);
                    }
                    catch (ArgumentException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,134696,134825);
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,134696,134825);
                        // if match already found ignore
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,134365,134844);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,134269,134859);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,591);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,591);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1602,134090,134870);

int
f_1602_134422_134453(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,System.Management.Automation.Runspaces.PSSession
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 134422, 134453);
return 0;
}


System.Guid
f_1602_134600_134629(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 134600, 134629);
return return_v;
}


int
f_1602_134588_134650(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.Runspaces.PSSession>
this_param,System.Guid
key,System.Management.Automation.Runspaces.PSSession
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 134588, 134650);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
f_1602_134310_134331_I(System.Collections.Generic.List<System.Management.Automation.Runspaces.PSSession>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 134310, 134331);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,134090,134870);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,134090,134870);
}
		}

private void WriteInvalidArgumentError(PSRemotingErrorId errorId, string resourceString, object errorArgument)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,134972,135336);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,135107,135166);

string 
message = f_1602_135124_135165(this, resourceString, errorArgument)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,135182,135325);

f_1602_135182_135324(this, f_1602_135193_135323(f_1602_135209_135239(message), f_1602_135241_135259(errorId), ErrorCategory.InvalidArgument, errorArgument));
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,134972,135336);

string
f_1602_135124_135165(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,string
resourceString,params object[]
args)
{
var return_v = this_param.GetMessage( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 135124, 135165);
return return_v;
}


System.ArgumentException
f_1602_135209_135239(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 135209, 135239);
return return_v;
}


string
f_1602_135241_135259(System.Management.Automation.Remoting.PSRemotingErrorId
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 135241, 135259);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_135193_135323(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 135193, 135323);
return return_v;
}


int
f_1602_135182_135324(Microsoft.PowerShell.Commands.PSRunspaceCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 135182, 135324);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,134972,135336);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,134972,135336);
}
		}

protected const string 
InstanceIdParameterSet = "InstanceId"
;

protected const string 
IdParameterSet = "Id"
;

protected const string 
NameParameterSet = "Name"
;

public PSRunspaceCmdlet()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1602,101460,135914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,102888,102906);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,103025,103380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,103921,103927);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,104615,104629);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,104726,105322);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,105426,106026);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,106130,106711);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1602,101460,135914);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,101460,135914);
}


static PSRunspaceCmdlet()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1602,101460,135914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,101728,101787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,101942,101987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,102146,102195);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,135545,135582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,135704,135725);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,135841,135866);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1602,101460,135914);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,101460,135914);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1602,101460,135914);
}
internal abstract partial class ExecutionCmdletHelper : IThrottleOperation
{
internal Pipeline Pipeline
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,136353,136420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,136389,136405);

return pipeline;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,136353,136420);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,136302,136431);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,136302,136431);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected Pipeline pipeline;

internal Exception InternalException
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,136688,136764);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,136724,136749);

return internalException;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,136688,136764);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,136627,136775);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,136627,136775);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected Exception internalException;

internal Runspace PipelineRunspace
{            set;
            get;
}

internal void ConfigureRunspaceDebugging(Runspace runspace)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,137093,137884);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,137177,137272) || true) && (f_1602_137181_137206_M(!RunspaceDebuggingEnabled)||(DynAbs.Tracing.TraceSender.Expression_False(1602, 137181, 137228)||(runspace == null) )||(DynAbs.Tracing.TraceSender.Expression_False(1602, 137181, 137259)||(f_1602_137233_137250(runspace)== null)))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,137177,137272);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,137263,137270);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,137177,137272);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,137288,137341);

f_1602_137288_137305(runspace).DebuggerStop += HandleDebuggerStop;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,137456,137539);

f_1602_137456_137473(runspace).UnhandledBreakpointMode = UnhandledBreakpointProcessingMode.Wait;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,137555,137873) || true) && (f_1602_137559_137585())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,137555,137873);
                // Configure runspace debugger to run script in step mode
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,137738,137782);

f_1602_137738_137781(f_1602_137738_137755(runspace), true);
                }
                catch (PSInvalidOperationException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,137819,137858);
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,137819,137858);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,137555,137873);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,137093,137884);

bool
f_1602_137181_137206_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 137181, 137206);
return return_v;
}


System.Management.Automation.Debugger
f_1602_137233_137250(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.Debugger ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 137233, 137250);
return return_v;
}


System.Management.Automation.Debugger
f_1602_137288_137305(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.Debugger;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 137288, 137305);
return return_v;
}


System.Management.Automation.Debugger
f_1602_137456_137473(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.Debugger;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 137456, 137473);
return return_v;
}


bool
f_1602_137559_137585()
{
var return_v = RunspaceDebugStepInEnabled;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 137559, 137585);
return return_v;
}


System.Management.Automation.Debugger
f_1602_137738_137755(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.Debugger;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 137738, 137755);
return return_v;
}


int
f_1602_137738_137781(System.Management.Automation.Debugger
this_param,bool
enabled)
{
this_param.SetDebuggerStepMode( enabled);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 137738, 137781);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,137093,137884);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,137093,137884);
}
		}

internal void CleanupRunspaceDebugging(Runspace runspace)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,137896,138124);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,137978,138044) || true) && ((runspace == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1602, 137982, 138031)||(f_1602_138005_138022(runspace)== null)))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,137978,138044);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,138035,138042);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,137978,138044);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,138060,138113);

f_1602_138060_138077(runspace).DebuggerStop -= HandleDebuggerStop;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,137896,138124);

System.Management.Automation.Debugger
f_1602_138005_138022(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.Debugger ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 138005, 138022);
return return_v;
}


System.Management.Automation.Debugger
f_1602_138060_138077(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.Debugger;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 138060, 138077);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,137896,138124);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,137896,138124);
}
		}

private void HandleDebuggerStop(object sender, DebuggerStopEventArgs args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,138136,138508);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,138235,138296);

f_1602_138235_138260(f_1602_138235_138251()).DebuggerStop -= HandleDebuggerStop;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,138342,138388);

f_1602_138342_138387(this, f_1602_138370_138386());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,138471,138497);

args.SuspendRemote = true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,138136,138508);

System.Management.Automation.Runspaces.Runspace
f_1602_138235_138251()
{
var return_v = PipelineRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 138235, 138251);
return return_v;
}


System.Management.Automation.Debugger
f_1602_138235_138260(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.Debugger;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 138235, 138260);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1602_138370_138386()
{
var return_v = PipelineRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 138370, 138386);
return return_v;
}


int
f_1602_138342_138387(Microsoft.PowerShell.Commands.ExecutionCmdletHelper
this_param,System.Management.Automation.Runspaces.Runspace
runspace)
{
this_param.RaiseRunspaceDebugStopEvent( runspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 138342, 138387);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,138136,138508);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,138136,138508);
}
		}

public ExecutionCmdletHelper()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1602,136110,138537);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,136462,136470);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,136807,136824);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,136955,137047);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1602,136110,138537);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,136110,138537);
}


static ExecutionCmdletHelper()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1602,136110,138537);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1602,136110,138537);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,136110,138537);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1602,136110,138537);
}
internal class ExecutionCmdletHelperRunspace : ExecutionCmdletHelper
{
internal bool ShouldUseSteppablePipelineOnServer;

internal ExecutionCmdletHelperRunspace(Pipeline pipeline)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1602,139466,139748);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,139245,139279);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,139548,139573);

this.pipeline = pipeline;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,139587,139624);

PipelineRunspace = f_1602_139606_139623(pipeline);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,139638,139737);

this.pipeline.StateChanged += new EventHandler<PipelineStateEventArgs>(HandlePipelineStateChanged);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1602,139466,139748);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,139466,139748);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,139466,139748);
}
		}

internal override void StartOperation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,139857,140816);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,139921,139966);

f_1602_139921_139965(this, f_1602_139948_139964());

            try
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,140018,140238) || true) && (ShouldUseSteppablePipelineOnServer &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 140022, 140096)&&pipeline is RemotePipeline rPipeline))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,140018,140238);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,140138,140166);

f_1602_140138_140165(                    rPipeline, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,140188,140219);

f_1602_140188_140218(                    rPipeline, true);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,140018,140238);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,140258,140281);

f_1602_140258_140280(
                pipeline);
            }
            catch (InvalidRunspaceStateException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,140310,140467);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,140382,140404);

internalException = e;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,140422,140452);

f_1602_140422_140451(this);
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,140310,140467);
            }
            catch (InvalidPipelineStateException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,140481,140638);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,140553,140575);

internalException = e;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,140593,140623);

f_1602_140593_140622(this);
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,140481,140638);
            }
            catch (InvalidOperationException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,140652,140805);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,140720,140742);

internalException = e;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,140760,140790);

f_1602_140760_140789(this);
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,140652,140805);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,139857,140816);

System.Management.Automation.Runspaces.Runspace
f_1602_139948_139964()
{
var return_v = PipelineRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 139948, 139964);
return return_v;
}


int
f_1602_139921_139965(Microsoft.PowerShell.Commands.ExecutionCmdletHelperRunspace
this_param,System.Management.Automation.Runspaces.Runspace
runspace)
{
this_param.ConfigureRunspaceDebugging( runspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 139921, 139965);
return 0;
}


int
f_1602_140138_140165(System.Management.Automation.RemotePipeline
this_param,bool
isNested)
{
this_param.SetIsNested( isNested);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 140138, 140165);
return 0;
}


int
f_1602_140188_140218(System.Management.Automation.RemotePipeline
this_param,bool
isSteppable)
{
this_param.SetIsSteppable( isSteppable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 140188, 140218);
return 0;
}


int
f_1602_140258_140280(System.Management.Automation.Runspaces.Pipeline
this_param)
{
this_param.InvokeAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 140258, 140280);
return 0;
}


int
f_1602_140422_140451(Microsoft.PowerShell.Commands.ExecutionCmdletHelperRunspace
this_param)
{
this_param.RaiseOperationCompleteEvent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 140422, 140451);
return 0;
}


int
f_1602_140593_140622(Microsoft.PowerShell.Commands.ExecutionCmdletHelperRunspace
this_param)
{
this_param.RaiseOperationCompleteEvent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 140593, 140622);
return 0;
}


int
f_1602_140760_140789(Microsoft.PowerShell.Commands.ExecutionCmdletHelperRunspace
this_param)
{
this_param.RaiseOperationCompleteEvent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 140760, 140789);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,139857,140816);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,139857,140816);
}
		}

internal override void StopOperation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,140924,141795);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,140987,141784) || true) && (f_1602_140991_141023(f_1602_140991_141017(pipeline))== PipelineState.Running ||(DynAbs.Tracing.TraceSender.Expression_False(1602, 140991, 141131)||f_1602_141069_141101(f_1602_141069_141095(pipeline))== PipelineState.Disconnected )||(DynAbs.Tracing.TraceSender.Expression_False(1602, 140991, 141212)||f_1602_141152_141184(f_1602_141152_141178(pipeline))== PipelineState.NotStarted))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,140987,141784);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,141533,141554);

f_1602_141533_141553(                // If the pipeline state has reached Complete/Failed/Stopped
                // by the time control reaches here, then this operation
                // becomes a no-op. However, an OperationComplete would have
                // already been raised from the handler
                pipeline);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,140987,141784);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,140987,141784);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,141739,141769);

f_1602_141739_141768(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,140987,141784);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,140924,141795);

System.Management.Automation.Runspaces.PipelineStateInfo
f_1602_140991_141017(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.PipelineStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 140991, 141017);
return return_v;
}


System.Management.Automation.Runspaces.PipelineState
f_1602_140991_141023(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 140991, 141023);
return return_v;
}


System.Management.Automation.Runspaces.PipelineStateInfo
f_1602_141069_141095(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.PipelineStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 141069, 141095);
return return_v;
}


System.Management.Automation.Runspaces.PipelineState
f_1602_141069_141101(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 141069, 141101);
return return_v;
}


System.Management.Automation.Runspaces.PipelineStateInfo
f_1602_141152_141178(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.PipelineStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 141152, 141178);
return return_v;
}


System.Management.Automation.Runspaces.PipelineState
f_1602_141152_141184(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 141152, 141184);
return return_v;
}


int
f_1602_141533_141553(System.Management.Automation.Runspaces.Pipeline
this_param)
{
this_param.StopAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 141533, 141553);
return 0;
}


int
f_1602_141739_141768(Microsoft.PowerShell.Commands.ExecutionCmdletHelperRunspace
this_param)
{
this_param.RaiseOperationCompleteEvent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 141739, 141768);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,140924,141795);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,140924,141795);
}
		}

        internal override event EventHandler<OperationStateEventArgs> 
OperationComplete
;

private void HandlePipelineStateChanged(object sender, PipelineStateEventArgs stateEventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,142402,142942);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,142520,142583);

PipelineStateInfo 
stateInfo = f_1602_142550_142582(stateEventArgs)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,142599,142871);

switch (f_1602_142607_142622(stateInfo))
            {

case PipelineState.Running:
                case PipelineState.NotStarted:
                case PipelineState.Stopping:
                case PipelineState.Disconnected:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,142599,142871);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,142849,142856);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,142599,142871);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,142887,142931);

f_1602_142887_142930(this, stateEventArgs);
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,142402,142942);

System.Management.Automation.Runspaces.PipelineStateInfo
f_1602_142550_142582(System.Management.Automation.Runspaces.PipelineStateEventArgs
this_param)
{
var return_v = this_param.PipelineStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 142550, 142582);
return return_v;
}


System.Management.Automation.Runspaces.PipelineState
f_1602_142607_142622(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 142607, 142622);
return return_v;
}


int
f_1602_142887_142930(Microsoft.PowerShell.Commands.ExecutionCmdletHelperRunspace
this_param,System.Management.Automation.Runspaces.PipelineStateEventArgs
baseEventArgs)
{
this_param.RaiseOperationCompleteEvent( (System.EventArgs)baseEventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 142887, 142930);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,142402,142942);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,142402,142942);
}
		}

private void RaiseOperationCompleteEvent()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,143103,143215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,143170,143204);

f_1602_143170_143203(this, null);
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,143103,143215);

int
f_1602_143170_143203(Microsoft.PowerShell.Commands.ExecutionCmdletHelperRunspace
this_param,System.EventArgs
baseEventArgs)
{
this_param.RaiseOperationCompleteEvent( baseEventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 143170, 143203);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,143103,143215);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,143103,143215);
}
		}

private void RaiseOperationCompleteEvent(EventArgs baseEventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,143445,144440);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,143535,143578);

f_1602_143535_143577(this, f_1602_143560_143576());

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,143594,143990) || true) && (pipeline != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,143594,143990);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,143844,143938);

pipeline.StateChanged -= new EventHandler<PipelineStateEventArgs>(HandlePipelineStateChanged);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,143956,143975);

f_1602_143956_143974(                pipeline);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,143594,143990);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,144006,144107);

OperationStateEventArgs 
operationStateEventArgs =
f_1602_144077_144106()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,144121,144211);

operationStateEventArgs.OperationState =
                    OperationState.StopComplete;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,144225,144275);

operationStateEventArgs.BaseEvent = baseEventArgs;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,144291,144429) || true) && (OperationComplete != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,144291,144429);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,144354,144414);

f_1602_144354_144413(                OperationComplete, this, operationStateEventArgs);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,144291,144429);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,143445,144440);

System.Management.Automation.Runspaces.Runspace
f_1602_143560_143576()
{
var return_v = PipelineRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 143560, 143576);
return return_v;
}


int
f_1602_143535_143577(Microsoft.PowerShell.Commands.ExecutionCmdletHelperRunspace
this_param,System.Management.Automation.Runspaces.Runspace
runspace)
{
this_param.CleanupRunspaceDebugging( runspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 143535, 143577);
return 0;
}


int
f_1602_143956_143974(System.Management.Automation.Runspaces.Pipeline
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 143956, 143974);
return 0;
}


System.Management.Automation.Remoting.OperationStateEventArgs
f_1602_144077_144106()
{
var return_v = new System.Management.Automation.Remoting.OperationStateEventArgs();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 144077, 144106);
return return_v;
}


int
f_1602_144354_144413(System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>
eventHandler,Microsoft.PowerShell.Commands.ExecutionCmdletHelperRunspace
sender,System.Management.Automation.Remoting.OperationStateEventArgs
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.Remoting.OperationStateEventArgs>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 144354, 144413);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,143445,144440);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,143445,144440);
}
		}

static ExecutionCmdletHelperRunspace()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1602,139010,144447);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1602,139010,144447);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,139010,144447);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1602,139010,144447);

System.Management.Automation.Runspaces.Runspace
f_1602_139606_139623(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 139606, 139623);
return return_v;
}

}
internal class ExecutionCmdletHelperComputerName : ExecutionCmdletHelper
{
private bool _invokeAndDisconnect;

internal RemoteRunspace RemoteRunspace {get; private set; }

internal ExecutionCmdletHelperComputerName(RemoteRunspace remoteRunspace, Pipeline pipeline, bool invokeAndDisconnect = false)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1602,146073,146888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,145419,145439);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,145600,145660);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,146224,146323);

f_1602_146224_146322(remoteRunspace != null, "RemoteRunspace reference cannot be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,146337,146371);

PipelineRunspace = remoteRunspace;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,146387,146430);

_invokeAndDisconnect = invokeAndDisconnect;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,146446,146478);

RemoteRunspace = remoteRunspace;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,146492,146609);

remoteRunspace.StateChanged +=
                new EventHandler<RunspaceStateEventArgs>(HandleRunspaceStateChanged);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,146625,146711);

f_1602_146625_146710(pipeline != null, "Pipeline cannot be null or empty");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,146727,146752);

this.pipeline = pipeline;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,146766,146877);

pipeline.StateChanged +=
                new EventHandler<PipelineStateEventArgs>(HandlePipelineStateChanged);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1602,146073,146888);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,146073,146888);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,146073,146888);
}
		}

internal override void StartOperation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,147000,147323);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,147100,147127);

f_1602_147100_147126(f_1602_147100_147114());
            }
            catch (PSRemotingTransportException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,147156,147312);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,147227,147249);

internalException = e;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,147267,147297);

f_1602_147267_147296(this);
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,147156,147312);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,147000,147323);

System.Management.Automation.RemoteRunspace
f_1602_147100_147114()
{
var return_v = RemoteRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 147100, 147114);
return return_v;
}


int
f_1602_147100_147126(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.OpenAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 147100, 147126);
return 0;
}


int
f_1602_147267_147296(Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName
this_param)
{
this_param.RaiseOperationCompleteEvent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 147267, 147296);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,147000,147323);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,147000,147323);
}
		}

internal override void StopOperation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,147422,148466);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,147485,147509);

bool 
needToStop = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,147564,147773) || true) && (f_1602_147568_147600(f_1602_147568_147594(pipeline))== PipelineState.Running ||(DynAbs.Tracing.TraceSender.Expression_False(1602, 147568, 147706)||f_1602_147646_147678(f_1602_147646_147672(pipeline))== PipelineState.NotStarted))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,147564,147773);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,147740,147758);

needToStop = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,147564,147773);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,147789,148455) || true) && (needToStop)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,147789,148455);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,148124,148145);

f_1602_148124_148144(                // If the pipeline state has reached Complete/Failed/Stopped
                // by the time control reaches here, then this operation
                // becomes a no-op. However, an OperationComplete would have
                // already been raised from the handler
                pipeline);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,147789,148455);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,147789,148455);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,148410,148440);

f_1602_148410_148439(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,147789,148455);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,147422,148466);

System.Management.Automation.Runspaces.PipelineStateInfo
f_1602_147568_147594(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.PipelineStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 147568, 147594);
return return_v;
}


System.Management.Automation.Runspaces.PipelineState
f_1602_147568_147600(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 147568, 147600);
return return_v;
}


System.Management.Automation.Runspaces.PipelineStateInfo
f_1602_147646_147672(System.Management.Automation.Runspaces.Pipeline
this_param)
{
var return_v = this_param.PipelineStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 147646, 147672);
return return_v;
}


System.Management.Automation.Runspaces.PipelineState
f_1602_147646_147678(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 147646, 147678);
return return_v;
}


int
f_1602_148124_148144(System.Management.Automation.Runspaces.Pipeline
this_param)
{
this_param.StopAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 148124, 148144);
return 0;
}


int
f_1602_148410_148439(Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName
this_param)
{
this_param.RaiseOperationCompleteEvent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 148410, 148439);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,147422,148466);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,147422,148466);
}
		}

        internal override event EventHandler<OperationStateEventArgs> 
OperationComplete
;

private void HandleRunspaceStateChanged(object sender,
                RunspaceStateEventArgs stateEventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,148837,151181);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,148972,149033);

RunspaceState 
state = f_1602_148994_149032(f_1602_148994_149026(stateEventArgs))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,149049,151170);

switch (state)
            {

case RunspaceState.BeforeOpen:
                case RunspaceState.Opening:
                case RunspaceState.Closing:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,149049,151170);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,149238,149245);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,149049,151170);

case RunspaceState.Opened:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,149049,151170);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,149340,149383);

f_1602_149340_149382(this, f_1602_149367_149381());

                        // if successfully opened
                        // Call InvokeAsync() on the pipeline
                        try
                        {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,149585,149895) || true) && (_invokeAndDisconnect)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,149585,149895);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,149675,149711);

f_1602_149675_149710(                                pipeline);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,149585,149895);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,149585,149895);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,149841,149864);

f_1602_149841_149863(                                pipeline);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,149585,149895);
}
                        }
                        catch (InvalidPipelineStateException)
                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,149948,150097);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,150042,150070);

f_1602_150042_150069(f_1602_150042_150056());
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,149948,150097);
                        }
                        catch (InvalidRunspaceStateException e)
                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,150123,150326);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,150219,150241);

internalException = e;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,150271,150299);

f_1602_150271_150298(f_1602_150271_150285());
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,150123,150326);
                        }
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1602,150373,150379);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,149049,151170);

case RunspaceState.Broken:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,149049,151170);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,150474,150518);

f_1602_150474_150517(this, stateEventArgs);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1602,150565,150571);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,149049,151170);

case RunspaceState.Closed:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,149049,151170);
                    {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,150778,151102) || true) && (f_1602_150782_150821(f_1602_150782_150814(stateEventArgs))!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,150778,151102);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,150887,150931);

f_1602_150887_150930(this, stateEventArgs);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,150778,151102);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,150778,151102);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,151045,151075);

f_1602_151045_151074(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,150778,151102);
}
                    }
DynAbs.Tracing.TraceSender.TraceBreak(1602,151149,151155);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,149049,151170);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,148837,151181);

System.Management.Automation.Runspaces.RunspaceStateInfo
f_1602_148994_149026(System.Management.Automation.Runspaces.RunspaceStateEventArgs
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 148994, 149026);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1602_148994_149032(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 148994, 149032);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1602_149367_149381()
{
var return_v = RemoteRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 149367, 149381);
return return_v;
}


int
f_1602_149340_149382(Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName
this_param,System.Management.Automation.RemoteRunspace
runspace)
{
this_param.ConfigureRunspaceDebugging( (System.Management.Automation.Runspaces.Runspace)runspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 149340, 149382);
return 0;
}


int
f_1602_149675_149710(System.Management.Automation.Runspaces.Pipeline
this_param)
{
this_param.InvokeAsyncAndDisconnect();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 149675, 149710);
return 0;
}


int
f_1602_149841_149863(System.Management.Automation.Runspaces.Pipeline
this_param)
{
this_param.InvokeAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 149841, 149863);
return 0;
}


System.Management.Automation.RemoteRunspace
f_1602_150042_150056()
{
var return_v = RemoteRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 150042, 150056);
return return_v;
}


int
f_1602_150042_150069(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.CloseAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 150042, 150069);
return 0;
}


System.Management.Automation.RemoteRunspace
f_1602_150271_150285()
{
var return_v = RemoteRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 150271, 150285);
return return_v;
}


int
f_1602_150271_150298(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.CloseAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 150271, 150298);
return 0;
}


int
f_1602_150474_150517(Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName
this_param,System.Management.Automation.Runspaces.RunspaceStateEventArgs
baseEventArgs)
{
this_param.RaiseOperationCompleteEvent( (System.EventArgs)baseEventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 150474, 150517);
return 0;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1602_150782_150814(System.Management.Automation.Runspaces.RunspaceStateEventArgs
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 150782, 150814);
return return_v;
}


System.Exception
f_1602_150782_150821(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.Reason ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 150782, 150821);
return return_v;
}


int
f_1602_150887_150930(Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName
this_param,System.Management.Automation.Runspaces.RunspaceStateEventArgs
baseEventArgs)
{
this_param.RaiseOperationCompleteEvent( (System.EventArgs)baseEventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 150887, 150930);
return 0;
}


int
f_1602_151045_151074(Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName
this_param)
{
this_param.RaiseOperationCompleteEvent();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 151045, 151074);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,148837,151181);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,148837,151181);
}
		}

private void HandlePipelineStateChanged(object sender,
                        PipelineStateEventArgs stateEventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,151453,152213);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,151596,151657);

PipelineState 
state = f_1602_151618_151656(f_1602_151618_151650(stateEventArgs))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,151673,152202);

switch (state)
            {

case PipelineState.Running:
                case PipelineState.NotStarted:
                case PipelineState.Stopping:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,151673,152202);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,151863,151870);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,151673,152202);

case PipelineState.Completed:
                case PipelineState.Stopped:
                case PipelineState.Failed:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,151673,152202);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,152030,152157) || true) && (f_1602_152034_152048()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,152030,152157);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,152106,152134);

f_1602_152106_152133(f_1602_152106_152120());
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,152030,152157);
}
DynAbs.Tracing.TraceSender.TraceBreak(1602,152181,152187);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,151673,152202);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,151453,152213);

System.Management.Automation.Runspaces.PipelineStateInfo
f_1602_151618_151650(System.Management.Automation.Runspaces.PipelineStateEventArgs
this_param)
{
var return_v = this_param.PipelineStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 151618, 151650);
return return_v;
}


System.Management.Automation.Runspaces.PipelineState
f_1602_151618_151656(System.Management.Automation.Runspaces.PipelineStateInfo
this_param)
{
var return_v = this_param.State;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 151618, 151656);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1602_152034_152048()
{
var return_v = RemoteRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 152034, 152048);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1602_152106_152120()
{
var return_v = RemoteRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 152106, 152120);
return return_v;
}


int
f_1602_152106_152133(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.CloseAsync();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 152106, 152133);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,151453,152213);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,151453,152213);
}
		}

private void RaiseOperationCompleteEvent()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,152374,152486);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,152441,152475);

f_1602_152441_152474(this, null);
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,152374,152486);

int
f_1602_152441_152474(Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName
this_param,System.EventArgs
baseEventArgs)
{
this_param.RaiseOperationCompleteEvent( baseEventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 152441, 152474);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,152374,152486);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,152374,152486);
}
		}

private void RaiseOperationCompleteEvent(EventArgs baseEventArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,152716,153780);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,152806,153202) || true) && (pipeline != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,152806,153202);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,153056,153150);

pipeline.StateChanged -= new EventHandler<PipelineStateEventArgs>(HandlePipelineStateChanged);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,153168,153187);

f_1602_153168_153186(                pipeline);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,152806,153202);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,153218,153410) || true) && (f_1602_153222_153236()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,153218,153410);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,153330,153355);

f_1602_153330_153354(f_1602_153330_153344());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,153373,153395);

RemoteRunspace = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,153218,153410);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,153426,153527);

OperationStateEventArgs 
operationStateEventArgs =
f_1602_153497_153526()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,153541,153631);

operationStateEventArgs.OperationState =
                    OperationState.StopComplete;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,153645,153695);

operationStateEventArgs.BaseEvent = baseEventArgs;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,153709,153769);

f_1602_153709_153768(            OperationComplete, this, operationStateEventArgs);
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,152716,153780);

int
f_1602_153168_153186(System.Management.Automation.Runspaces.Pipeline
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 153168, 153186);
return 0;
}


System.Management.Automation.RemoteRunspace
f_1602_153222_153236()
{
var return_v = RemoteRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 153222, 153236);
return return_v;
}


System.Management.Automation.RemoteRunspace
f_1602_153330_153344()
{
var return_v = RemoteRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 153330, 153344);
return return_v;
}


int
f_1602_153330_153354(System.Management.Automation.RemoteRunspace
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 153330, 153354);
return 0;
}


System.Management.Automation.Remoting.OperationStateEventArgs
f_1602_153497_153526()
{
var return_v = new System.Management.Automation.Remoting.OperationStateEventArgs();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 153497, 153526);
return return_v;
}


int
f_1602_153709_153768(System.EventHandler<System.Management.Automation.Remoting.OperationStateEventArgs>
eventHandler,Microsoft.PowerShell.Commands.ExecutionCmdletHelperComputerName
sender,System.Management.Automation.Remoting.OperationStateEventArgs
eventArgs)
{
eventHandler.SafeInvoke<System.Management.Automation.Remoting.OperationStateEventArgs>( (object)sender, eventArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 153709, 153768);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,152716,153780);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,152716,153780);
}
		}

static ExecutionCmdletHelperComputerName()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1602,145143,153787);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1602,145143,153787);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,145143,153787);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1602,145143,153787);

int
f_1602_146224_146322(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 146224, 146322);
return 0;
}


int
f_1602_146625_146710(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 146625, 146710);
return 0;
}

}
internal static class PathResolver
{
internal static string ResolveProviderAndPath(string path, bool isLiteralPath, PSCmdlet cmdlet, bool allowNonexistingPaths, string resourceString)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1602,154664,155248);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,154870,154958);

PathInfo 
resolvedPath = f_1602_154894_154957(path, isLiteralPath, allowNonexistingPaths, cmdlet)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,154974,155128) || true) && (f_1602_154978_155016(f_1602_154978_154999(resolvedPath))== typeof(FileSystemProvider))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,154974,155128);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,155080,155113);

return f_1602_155087_155112(resolvedPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,154974,155128);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,155144,155237);

throw f_1602_155150_155236(resourceString, f_1602_155209_155235(f_1602_155209_155230(resolvedPath)));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1602,154664,155248);

System.Management.Automation.PathInfo
f_1602_154894_154957(string
pathToResolve,bool
isLiteralPath,bool
allowNonexistingPaths,System.Management.Automation.PSCmdlet
cmdlet)
{
var return_v = ResolvePath( pathToResolve, isLiteralPath, allowNonexistingPaths, cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 154894, 154957);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1602_154978_154999(System.Management.Automation.PathInfo
this_param)
{
var return_v = this_param.Provider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 154978, 154999);
return return_v;
}


System.Type
f_1602_154978_155016(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.ImplementingType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 154978, 155016);
return return_v;
}


string
f_1602_155087_155112(System.Management.Automation.PathInfo
this_param)
{
var return_v = this_param.ProviderPath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 155087, 155112);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1602_155209_155230(System.Management.Automation.PathInfo
this_param)
{
var return_v = this_param.Provider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 155209, 155230);
return return_v;
}


string
f_1602_155209_155235(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 155209, 155235);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1602_155150_155236(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 155150, 155236);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,154664,155248);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,154664,155248);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static PathInfo ResolvePath(
            string pathToResolve,
            bool isLiteralPath,
            bool allowNonexistingPaths,
            PSCmdlet cmdlet)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1602,155978,159355);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,156226,156295);

CmdletProviderContext 
cmdContext = f_1602_156261_156294(cmdlet)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,156309,156362);

cmdContext.SuppressWildcardExpansion = isLiteralPath;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,156378,156436);

Collection<PathInfo> 
results = f_1602_156409_156435()
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,156527,156712);

Collection<PathInfo> 
pathInfos =
f_1602_156581_156711(f_1602_156581_156605(f_1602_156581_156600(cmdlet)), pathToResolve, cmdContext)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,156732,156854);
foreach(PathInfo pathInfo in f_1602_156762_156771_I(pathInfos) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,156732,156854);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,156813,156835);

f_1602_156813_156834(                    results, pathInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,156732,156854);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,123);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,123);
}            }
            catch (PSNotSupportedException notSupported)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,156883,157134);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,156960,157119);

f_1602_156960_157118(                cmdlet, f_1602_157011_157117(f_1602_157053_157077(notSupported), notSupported));
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,156883,157134);
            }
            catch (System.Management.Automation.DriveNotFoundException driveNotFound)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,157148,157430);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,157254,157415);

f_1602_157254_157414(                cmdlet, f_1602_157305_157413(f_1602_157347_157372(driveNotFound), driveNotFound));
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,157148,157430);
            }
            catch (ProviderNotFoundException providerNotFound)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,157444,157709);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,157527,157694);

f_1602_157527_157693(                cmdlet, f_1602_157578_157692(f_1602_157620_157648(providerNotFound), providerNotFound));
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,157444,157709);
            }
            catch (ItemNotFoundException pathNotFound)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,157723,158855);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,157798,158840) || true) && (allowNonexistingPaths)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,157798,158840);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,157865,157894);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,157916,157970);

System.Management.Automation.PSDriveInfo 
drive = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,157992,158271);

string 
unresolvedPath =
f_1602_158041_158270(f_1602_158041_158065(f_1602_158041_158060(cmdlet)), pathToResolve, cmdContext, out provider, out drive)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,158295,158524);

PathInfo 
pathInfo =
f_1602_158340_158523(drive, provider, unresolvedPath, f_1602_158503_158522(cmdlet))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,158546,158568);

f_1602_158546_158567(                    results, pathInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,157798,158840);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,157798,158840);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,158650,158821);

f_1602_158650_158820(                    cmdlet, f_1602_158705_158819(f_1602_158751_158775(pathNotFound), pathNotFound));
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,157798,158840);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,157723,158855);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,158871,159344) || true) && (f_1602_158875_158888(results)== 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,158871,159344);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,158927,158945);

return f_1602_158934_158944(results, 0);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,158871,159344);
}

else // if (results.Count > 1)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,158871,159344);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,159037,159092);

Exception 
e = f_1602_159051_159091()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,159110,159299);

f_1602_159110_159298(                cmdlet, f_1602_159161_159297(e, "NotSupported", ErrorCategory.NotImplemented, results));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,159317,159329);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,158871,159344);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1602,155978,159355);

System.Management.Automation.CmdletProviderContext
f_1602_156261_156294(System.Management.Automation.PSCmdlet
command)
{
var return_v = new System.Management.Automation.CmdletProviderContext( (System.Management.Automation.Cmdlet)command);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 156261, 156294);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
f_1602_156409_156435()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 156409, 156435);
return return_v;
}


System.Management.Automation.SessionState
f_1602_156581_156600(System.Management.Automation.PSCmdlet
this_param)
{
var return_v = this_param.SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 156581, 156600);
return return_v;
}


System.Management.Automation.PathIntrinsics
f_1602_156581_156605(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 156581, 156605);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
f_1602_156581_156711(System.Management.Automation.PathIntrinsics
this_param,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.GetResolvedPSPathFromPSPath( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 156581, 156711);
return return_v;
}


int
f_1602_156813_156834(System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
this_param,System.Management.Automation.PathInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 156813, 156834);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
f_1602_156762_156771_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 156762, 156771);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_157053_157077(System.Management.Automation.PSNotSupportedException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 157053, 157077);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_157011_157117(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.PSNotSupportedException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 157011, 157117);
return return_v;
}


int
f_1602_156960_157118(System.Management.Automation.PSCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 156960, 157118);
return 0;
}


System.Management.Automation.ErrorRecord
f_1602_157347_157372(System.Management.Automation.DriveNotFoundException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 157347, 157372);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_157305_157413(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.DriveNotFoundException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 157305, 157413);
return return_v;
}


int
f_1602_157254_157414(System.Management.Automation.PSCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 157254, 157414);
return 0;
}


System.Management.Automation.ErrorRecord
f_1602_157620_157648(System.Management.Automation.ProviderNotFoundException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 157620, 157648);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_157578_157692(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.ProviderNotFoundException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 157578, 157692);
return return_v;
}


int
f_1602_157527_157693(System.Management.Automation.PSCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 157527, 157693);
return 0;
}


System.Management.Automation.SessionState
f_1602_158041_158060(System.Management.Automation.PSCmdlet
this_param)
{
var return_v = this_param.SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 158041, 158060);
return return_v;
}


System.Management.Automation.PathIntrinsics
f_1602_158041_158065(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 158041, 158065);
return return_v;
}


string
f_1602_158041_158270(System.Management.Automation.PathIntrinsics
this_param,string
path,System.Management.Automation.CmdletProviderContext
context,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.PSDriveInfo
drive)
{
var return_v = this_param.GetUnresolvedProviderPathFromPSPath( path, context, out provider, out drive);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 158041, 158270);
return return_v;
}


System.Management.Automation.SessionState
f_1602_158503_158522(System.Management.Automation.PSCmdlet
this_param)
{
var return_v = this_param.SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 158503, 158522);
return return_v;
}


System.Management.Automation.PathInfo
f_1602_158340_158523(System.Management.Automation.PSDriveInfo
drive,System.Management.Automation.ProviderInfo
provider,string
path,System.Management.Automation.SessionState
sessionState)
{
var return_v = new System.Management.Automation.PathInfo( drive, provider, path, sessionState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 158340, 158523);
return return_v;
}


int
f_1602_158546_158567(System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
this_param,System.Management.Automation.PathInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 158546, 158567);
return 0;
}


System.Management.Automation.ErrorRecord
f_1602_158751_158775(System.Management.Automation.ItemNotFoundException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 158751, 158775);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_158705_158819(System.Management.Automation.ErrorRecord
errorRecord,System.Management.Automation.ItemNotFoundException
replaceParentContainsErrorRecordException)
{
var return_v = new System.Management.Automation.ErrorRecord( errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 158705, 158819);
return return_v;
}


int
f_1602_158650_158820(System.Management.Automation.PSCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 158650, 158820);
return 0;
}


int
f_1602_158875_158888(System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 158875, 158888);
return return_v;
}


System.Management.Automation.PathInfo
f_1602_158934_158944(System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 158934, 158944);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1602_159051_159091()
{
var return_v = PSTraceSource.NewNotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 159051, 159091);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_159161_159297(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 159161, 159297);
return return_v;
}


int
f_1602_159110_159298(System.Management.Automation.PSCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 159110, 159298);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,155978,159355);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,155978,159355);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static PathResolver()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1602,153908,159362);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1602,153908,159362);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,153908,159362);
}

}
internal class QueryRunspaces
{
internal QueryRunspaces()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1602,159495,159580);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,176382,176397);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,159545,159569);

_stopProcessing = false;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1602,159495,159580);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,159495,159580);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,159495,159580);
}
		}

internal Collection<PSSession> GetDisconnectedSessions(Collection<WSManConnectionInfo> connectionInfos, PSHost host,
                                                               ObjectStream stream, RunspaceRepository runspaceRepository,
                                                               int throttleLimit, SessionFilterState filterState,
                                                               Guid[] matchIds, string[] matchNames, string configurationName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,160711,169504);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,161219,161290);

Collection<PSSession> 
filteredPSSessions = f_1602_161262_161289()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,161387,166143);
foreach(WSManConnectionInfo connectionInfo in f_1602_161434_161449_I(connectionInfos) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,161387,166143);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,161483,161511);

Runspace[] 
runspaces = null
;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,161575,161650);

runspaces = f_1602_161587_161649(connectionInfo, host, f_1602_161631_161648());
                }
                catch (System.Management.Automation.RuntimeException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,161687,163234);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,161783,163215) || true) && (f_1602_161787_161803(e)is InvalidOperationException)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,161783,163215);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,162257,163088) || true) && (f_1602_162261_162280(stream)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 162261, 162318)&&f_1602_162292_162318(f_1602_162292_162311(stream))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,162257,163088);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,162376,162390);

int 
errorCode
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,162420,162577);

string 
msg = f_1602_162433_162576(f_1602_162451_162497(), f_1602_162499_162526(connectionInfo), f_1602_162528_162575(f_1602_162543_162559(e), out errorCode))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,162607,162717);

string 
FQEID = f_1602_162622_162716(errorCode, "RemotePSSessionQueryFailed")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,162747,162810);

Exception 
reason = f_1602_162766_162809(msg, f_1602_162792_162808(e))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,162840,162945);

ErrorRecord 
errorRecord = f_1602_162866_162944(reason, FQEID, ErrorCategory.InvalidOperation, connectionInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,162975,163061);

f_1602_162975_163060(f_1602_162975_162994(stream), (cmdlet => cmdlet.WriteError(errorRecord)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,162257,163088);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,161783,163215);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,161783,163215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,163186,163192);

throw;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,161783,163215);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,161687,163234);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,163254,163340) || true) && (_stopProcessing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,163254,163340);
DynAbs.Tracing.TraceSender.TraceBreak(1602,163315,163321);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,163254,163340);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,163437,166128) || true) && (runspaces != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,163437,166128);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,163582,163605);

string 
shellUri = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,163627,164099) || true) && (!f_1602_163632_163671(configurationName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,163627,164099);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,163721,164076);

shellUri = (DynAbs.Tracing.TraceSender.Conditional_F1(1602, 163732, 163918)||(((f_1602_163733_163911(configurationName, System.Management.Automation.Remoting.Client.WSManNativeApi.ResourceURIPrefix, StringComparison.OrdinalIgnoreCase)!= -1) &&DynAbs.Tracing.TraceSender.Conditional_F2(1602, 163958, 163975))||DynAbs.Tracing.TraceSender.Conditional_F3(1602, 163978, 164075)))?                                    configurationName :System.Management.Automation.Remoting.Client.WSManNativeApi.ResourceURIPrefix + configurationName;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,163627,164099);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,164123,166109);
foreach(Runspace runspace in f_1602_164153_164162_I(runspaces) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,164123,166109);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,164300,164864) || true) && (shellUri != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,164300,164864);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,164462,164551);

WSManConnectionInfo 
wsmanConnectionInfo = f_1602_164504_164527(runspace)as WSManConnectionInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,164581,164837) || true) && (wsmanConnectionInfo != null &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 164585, 164731)&&                                !f_1602_164650_164731(shellUri, f_1602_164666_164694(wsmanConnectionInfo), StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,164581,164837);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,164797,164806);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,164581,164837);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,164300,164864);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,165183,165218);

PSSession 
existingPSSession = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,165244,165427) || true) && (runspaceRepository != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,165244,165427);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,165332,165400);

existingPSSession = f_1602_165352_165399(runspaceRepository, f_1602_165379_165398(runspace));
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,165244,165427);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,165455,166086) || true) && (existingPSSession != null &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 165459, 165574)&&f_1602_165517_165574(f_1602_165537_165563(existingPSSession), runspace)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,165455,166086);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,165632,165833) || true) && (f_1602_165636_165694(f_1602_165654_165680(existingPSSession), filterState))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,165632,165833);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,165760,165802);

f_1602_165760_165801(                                filteredPSSessions, existingPSSession);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,165632,165833);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,165455,166086);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,165455,166086);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,165891,166086) || true) && (f_1602_165895_165935(runspace, filterState))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,165891,166086);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,165993,166059);

f_1602_165993_166058(                            filteredPSSessions, f_1602_166016_166057(runspace as RemoteRunspace));
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,165891,166086);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,165455,166086);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,164123,166109);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,1987);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,1987);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1602,163437,166128);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,161387,166143);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,4757);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,4757);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,166232,169493) || true) && ((matchIds != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 166236, 166288)&&(f_1602_166259_166283(filteredPSSessions)> 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,166232,169493);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,166322,166391);

Collection<PSSession> 
matchIdsSessions = f_1602_166363_166390()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,166409,167622);
foreach(Guid id in f_1602_166429_166437_I(matchIds) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,166409,167622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,166479,166503);

bool 
matchFound = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,166525,167031);
foreach(PSSession psSession in f_1602_166557_166575_I(filteredPSSessions) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,166525,167031);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,166625,166735) || true) && (_stopProcessing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,166625,166735);
DynAbs.Tracing.TraceSender.TraceBreak(1602,166702,166708);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,166625,166735);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,166763,167008) || true) && (f_1602_166767_166785(psSession).InstanceId.Equals(id))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,166763,167008);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,166865,166883);

matchFound = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,166913,166945);

f_1602_166913_166944(                            matchIdsSessions, psSession);
DynAbs.Tracing.TraceSender.TraceBreak(1602,166975,166981);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,166763,167008);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,166525,167031);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,507);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,507);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,167055,167603) || true) && (!matchFound &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 167059, 167101)&&f_1602_167074_167093(stream)!= null )&&(DynAbs.Tracing.TraceSender.Expression_True(1602, 167059, 167131)&&f_1602_167105_167131(f_1602_167105_167124(stream))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,167055,167603);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,167181,167261);

string 
msg = f_1602_167194_167260(f_1602_167212_167255(), id)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,167287,167332);

Exception 
reason = f_1602_167306_167331(msg)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,167358,167468);

ErrorRecord 
errorRecord = f_1602_167384_167467(reason, "PSSessionIdMatchFail", ErrorCategory.InvalidOperation, id)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,167494,167580);

f_1602_167494_167579(f_1602_167494_167513(stream), (cmdlet => cmdlet.WriteError(errorRecord)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,167055,167603);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,166409,167622);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,1214);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,1214);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,167689,167713);

return matchIdsSessions;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,166232,169493);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,166232,169493);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,167747,169493) || true) && ((matchNames != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 167751, 167805)&&(f_1602_167776_167800(filteredPSSessions)> 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,167747,169493);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,167839,167910);

Collection<PSSession> 
matchNamesSessions = f_1602_167882_167909()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,167928,169289);
foreach(string name in f_1602_167952_167962_I(matchNames) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,167928,169289);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,168004,168088);

WildcardPattern 
namePattern = f_1602_168034_168087(name, WildcardOptions.IgnoreCase)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,168110,168134);

bool 
matchFound = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,168156,168690);
foreach(PSSession psSession in f_1602_168188_168206_I(filteredPSSessions) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,168156,168690);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,168256,168366) || true) && (_stopProcessing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,168256,168366);
DynAbs.Tracing.TraceSender.TraceBreak(1602,168333,168339);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,168256,168366);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,168394,168667) || true) && (f_1602_168398_168500(namePattern, f_1602_168418_168499(f_1602_168418_168494(f_1602_168418_168467(((RemoteRunspace)f_1602_168435_168453(psSession)))))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,168394,168667);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,168558,168576);

matchFound = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,168606,168640);

f_1602_168606_168639(                            matchNamesSessions, psSession);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,168394,168667);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,168156,168690);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,535);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,535);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,168714,169270) || true) && (!matchFound &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 168718, 168760)&&f_1602_168733_168752(stream)!= null )&&(DynAbs.Tracing.TraceSender.Expression_True(1602, 168718, 168790)&&f_1602_168764_168790(f_1602_168764_168783(stream))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,168714,169270);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,168840,168924);

string 
msg = f_1602_168853_168923(f_1602_168871_168916(), name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,168950,168995);

Exception 
reason = f_1602_168969_168994(msg)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,169021,169135);

ErrorRecord 
errorRecord = f_1602_169047_169134(reason, "PSSessionNameMatchFail", ErrorCategory.InvalidOperation, name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,169161,169247);

f_1602_169161_169246(f_1602_169161_169180(stream), (cmdlet => cmdlet.WriteError(errorRecord)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,168714,169270);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,167928,169289);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,1,1362);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,1,1362);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,169309,169335);

return matchNamesSessions;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,167747,169493);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,167747,169493);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,169452,169478);

return filteredPSSessions;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,167747,169493);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,166232,169493);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,160711,169504);

System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
f_1602_161262_161289()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 161262, 161289);
return return_v;
}


System.Management.Automation.Runspaces.TypeTable
f_1602_161631_161648()
{
var return_v = BuiltInTypesTable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 161631, 161648);
return return_v;
}


System.Management.Automation.Runspaces.Runspace[]
f_1602_161587_161649(System.Management.Automation.Runspaces.WSManConnectionInfo
connectionInfo,System.Management.Automation.Host.PSHost
host,System.Management.Automation.Runspaces.TypeTable
typeTable)
{
var return_v = Runspace.GetRunspaces( (System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host, typeTable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 161587, 161649);
return return_v;
}


System.Exception
f_1602_161787_161803(System.Management.Automation.RuntimeException
this_param)
{
var return_v = this_param.InnerException ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 161787, 161803);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1602_162261_162280(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 162261, 162280);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1602_162292_162311(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 162292, 162311);
return return_v;
}


bool
f_1602_162292_162318(System.Management.Automation.Runspaces.PipelineWriter
this_param)
{
var return_v = this_param.IsOpen;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 162292, 162318);
return return_v;
}


string
f_1602_162451_162497()
{
var return_v = RemotingErrorIdStrings.QueryForRunspacesFailed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 162451, 162497);
return return_v;
}


string
f_1602_162499_162526(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.ComputerName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 162499, 162526);
return return_v;
}


System.Exception
f_1602_162543_162559(System.Management.Automation.RuntimeException
this_param)
{
var return_v = this_param.InnerException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 162543, 162559);
return return_v;
}


string
f_1602_162528_162575(System.Exception
e,out int
errorCode)
{
var return_v = ExtractMessage( e, out errorCode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 162528, 162575);
return return_v;
}


string
f_1602_162433_162576(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 162433, 162576);
return return_v;
}


string
f_1602_162622_162716(int
transportErrorCode,string
defaultFQEID)
{
var return_v = WSManTransportManagerUtils.GetFQEIDFromTransportError( transportErrorCode, defaultFQEID);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 162622, 162716);
return return_v;
}


System.Exception
f_1602_162792_162808(System.Management.Automation.RuntimeException
this_param)
{
var return_v = this_param.InnerException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 162792, 162808);
return return_v;
}


System.Management.Automation.RuntimeException
f_1602_162766_162809(string
message,System.Exception
innerException)
{
var return_v = new System.Management.Automation.RuntimeException( message, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 162766, 162809);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_162866_162944(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.Runspaces.WSManConnectionInfo
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 162866, 162944);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1602_162975_162994(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 162975, 162994);
return return_v;
}


int
f_1602_162975_163060(System.Management.Automation.Runspaces.PipelineWriter
this_param,System.Action<System.Management.Automation.Cmdlet>
obj)
{
var return_v = this_param.Write( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 162975, 163060);
return return_v;
}


bool
f_1602_163632_163671(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 163632, 163671);
return return_v;
}


int
f_1602_163733_163911(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.IndexOf( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 163733, 163911);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceConnectionInfo
f_1602_164504_164527(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.ConnectionInfo ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 164504, 164527);
return return_v;
}


string
f_1602_164666_164694(System.Management.Automation.Runspaces.WSManConnectionInfo
this_param)
{
var return_v = this_param.ShellUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 164666, 164694);
return return_v;
}


bool
f_1602_164650_164731(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 164650, 164731);
return return_v;
}


System.Guid
f_1602_165379_165398(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 165379, 165398);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1602_165352_165399(System.Management.Automation.RunspaceRepository
this_param,System.Guid
instanceId)
{
var return_v = this_param.GetItem( instanceId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 165352, 165399);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1602_165537_165563(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 165537, 165563);
return return_v;
}


bool
f_1602_165517_165574(System.Management.Automation.Runspaces.Runspace
existingRunspace,System.Management.Automation.Runspaces.Runspace
queriedrunspace)
{
var return_v = UseExistingRunspace( existingRunspace, queriedrunspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 165517, 165574);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1602_165654_165680(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 165654, 165680);
return return_v;
}


bool
f_1602_165636_165694(System.Management.Automation.Runspaces.Runspace
runspace,Microsoft.PowerShell.Commands.SessionFilterState
filterState)
{
var return_v = TestRunspaceState( runspace, filterState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 165636, 165694);
return return_v;
}


int
f_1602_165760_165801(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 165760, 165801);
return 0;
}


bool
f_1602_165895_165935(System.Management.Automation.Runspaces.Runspace
runspace,Microsoft.PowerShell.Commands.SessionFilterState
filterState)
{
var return_v = TestRunspaceState( runspace, filterState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 165895, 165935);
return return_v;
}


System.Management.Automation.Runspaces.PSSession
f_1602_166016_166057(System.Management.Automation.Runspaces.Runspace
remoteRunspace)
{
var return_v = new System.Management.Automation.Runspaces.PSSession( (System.Management.Automation.RemoteRunspace)remoteRunspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 166016, 166057);
return return_v;
}


int
f_1602_165993_166058(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 165993, 166058);
return 0;
}


System.Management.Automation.Runspaces.Runspace[]
f_1602_164153_164162_I(System.Management.Automation.Runspaces.Runspace[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 164153, 164162);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.WSManConnectionInfo>
f_1602_161434_161449_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.WSManConnectionInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 161434, 161449);
return return_v;
}


int
f_1602_166259_166283(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 166259, 166283);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
f_1602_166363_166390()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 166363, 166390);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1602_166767_166785(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 166767, 166785);
return return_v;
}


int
f_1602_166913_166944(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 166913, 166944);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
f_1602_166557_166575_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 166557, 166575);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1602_167074_167093(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 167074, 167093);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1602_167105_167124(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 167105, 167124);
return return_v;
}


bool
f_1602_167105_167131(System.Management.Automation.Runspaces.PipelineWriter
this_param)
{
var return_v = this_param.IsOpen;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 167105, 167131);
return return_v;
}


string
f_1602_167212_167255()
{
var return_v = RemotingErrorIdStrings.SessionIdMatchFailed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 167212, 167255);
return return_v;
}


string
f_1602_167194_167260(string
formatSpec,System.Guid
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 167194, 167260);
return return_v;
}


System.Management.Automation.RuntimeException
f_1602_167306_167331(string
message)
{
var return_v = new System.Management.Automation.RuntimeException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 167306, 167331);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_167384_167467(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,System.Guid
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 167384, 167467);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1602_167494_167513(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 167494, 167513);
return return_v;
}


int
f_1602_167494_167579(System.Management.Automation.Runspaces.PipelineWriter
this_param,System.Action<System.Management.Automation.Cmdlet>
obj)
{
var return_v = this_param.Write( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 167494, 167579);
return return_v;
}


System.Guid[]
f_1602_166429_166437_I(System.Guid[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 166429, 166437);
return return_v;
}


int
f_1602_167776_167800(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 167776, 167800);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
f_1602_167882_167909()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 167882, 167909);
return return_v;
}


System.Management.Automation.WildcardPattern
f_1602_168034_168087(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 168034, 168087);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1602_168435_168453(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 168435, 168453);
return return_v;
}


System.Management.Automation.Runspaces.RunspacePool
f_1602_168418_168467(System.Management.Automation.RemoteRunspace
this_param)
{
var return_v = this_param.RunspacePool;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 168418, 168467);
return return_v;
}


System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
f_1602_168418_168494(System.Management.Automation.Runspaces.RunspacePool
this_param)
{
var return_v = this_param.RemoteRunspacePoolInternal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 168418, 168494);
return return_v;
}


string
f_1602_168418_168499(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 168418, 168499);
return return_v;
}


bool
f_1602_168398_168500(System.Management.Automation.WildcardPattern
this_param,string
input)
{
var return_v = this_param.IsMatch( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 168398, 168500);
return return_v;
}


int
f_1602_168606_168639(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
this_param,System.Management.Automation.Runspaces.PSSession
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 168606, 168639);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
f_1602_168188_168206_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 168188, 168206);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1602_168733_168752(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 168733, 168752);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1602_168764_168783(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 168764, 168783);
return return_v;
}


bool
f_1602_168764_168790(System.Management.Automation.Runspaces.PipelineWriter
this_param)
{
var return_v = this_param.IsOpen;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 168764, 168790);
return return_v;
}


string
f_1602_168871_168916()
{
var return_v = RemotingErrorIdStrings.SessionNameMatchFailed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 168871, 168916);
return return_v;
}


string
f_1602_168853_168923(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 168853, 168923);
return return_v;
}


System.Management.Automation.RuntimeException
f_1602_168969_168994(string
message)
{
var return_v = new System.Management.Automation.RuntimeException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 168969, 168994);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1602_169047_169134(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 169047, 169134);
return return_v;
}


System.Management.Automation.Runspaces.PipelineWriter
f_1602_169161_169180(System.Management.Automation.Internal.ObjectStream
this_param)
{
var return_v = this_param.ObjectWriter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 169161, 169180);
return return_v;
}


int
f_1602_169161_169246(System.Management.Automation.Runspaces.PipelineWriter
this_param,System.Action<System.Management.Automation.Cmdlet>
obj)
{
var return_v = this_param.Write( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 169161, 169246);
return return_v;
}


string[]
f_1602_167952_167962_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 167952, 167962);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,160711,169504);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,160711,169504);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool UseExistingRunspace(
            Runspace existingRunspace,
            Runspace queriedrunspace)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1602,169918,170853);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,170062,170121);

f_1602_170062_170120(existingRunspace != null, "Invalid parameter.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,170135,170193);

f_1602_170135_170192(queriedrunspace != null, "Invalid parameter.");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,170209,170339) || true) && (f_1602_170213_170253(f_1602_170213_170247(existingRunspace))== RunspaceState.Broken)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,170209,170339);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,170311,170324);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,170209,170339);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,170355,170577) || true) && (f_1602_170359_170399(f_1602_170359_170393(existingRunspace))== RunspaceState.Disconnected &&(DynAbs.Tracing.TraceSender.Expression_True(1602, 170359, 170515)&&f_1602_170450_170486(queriedrunspace)== RunspaceAvailability.Busy))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,170355,170577);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,170549,170562);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,170355,170577);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,170680,170745);

existingRunspace.DisconnectedOn = f_1602_170714_170744(queriedrunspace);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,170759,170814);

existingRunspace.ExpiresOn = f_1602_170788_170813(queriedrunspace);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,170830,170842);

return true;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1602,169918,170853);

int
f_1602_170062_170120(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 170062, 170120);
return 0;
}


int
f_1602_170135_170192(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 170135, 170192);
return 0;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1602_170213_170247(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 170213, 170247);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1602_170213_170253(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 170213, 170253);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1602_170359_170393(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 170359, 170393);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1602_170359_170399(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 170359, 170399);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceAvailability
f_1602_170450_170486(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceAvailability ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 170450, 170486);
return return_v;
}


System.DateTime?
f_1602_170714_170744(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.DisconnectedOn;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 170714, 170744);
return return_v;
}


System.DateTime?
f_1602_170788_170813(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.ExpiresOn;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 170788, 170813);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,169918,170853);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,169918,170853);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string ExtractMessage(
            Exception e,
            out int errorCode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1602,171222,173935);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,171343,171357);

errorCode = 0;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,171373,171493) || true) && (e == null ||(DynAbs.Tracing.TraceSender.Expression_False(1602, 171377, 171424)||f_1602_171407_171416(e)== null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,171373,171493);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,171458,171478);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,171373,171493);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,171509,171530);

string 
rtnMsg = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,171580,171699);

System.Xml.XmlReaderSettings 
xmlReaderSettings = f_1602_171629_171698(f_1602_171629_171690())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,171717,171766);

xmlReaderSettings.MaxCharactersInDocument = 4096;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,171784,171835);

xmlReaderSettings.MaxCharactersFromEntities = 1024;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,171853,171921);

xmlReaderSettings.DtdProcessing = System.Xml.DtdProcessing.Prohibit;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,171941,173804);
using(System.Xml.XmlReader 
reader = f_1602_171978_172089(f_1602_172032_172069(f_1602_172059_172068(e)), xmlReaderSettings)
)                {
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,172131,173785) || true) && (f_1602_172138_172151(reader))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,172131,173785);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,172201,173762) || true) && (f_1602_172205_172220(reader)== System.Xml.XmlNodeType.Element)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,172201,173762);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,172312,173735) || true) && (f_1602_172316_172386(f_1602_172316_172332(reader), "Message", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,172312,173735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,172452,172497);

rtnMsg = f_1602_172461_172496(reader);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,172312,173735);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,172312,173735);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,172563,173735) || true) && (f_1602_172567_172640(f_1602_172567_172583(reader), "WSManFault", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,172563,173735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,172706,172759);

string 
errorCodeString = f_1602_172731_172758(reader, "Code")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,172793,173704) || true) && (errorCodeString != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,172793,173704);
                                    try
                                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,173118,173218);

Int64 
eCode = f_1602_173132_173217(errorCodeString, f_1602_173165_173216())
;
                                        unchecked
                                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,173358,173381);

errorCode = (int)eCode;
                                        }
                                    }
                                    catch (FormatException)
                                    { DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,173501,173565);
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,173501,173565);
}
                                    catch (OverflowException)
                                    { DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,173603,173669);
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,173603,173669);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,172793,173704);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,172563,173735);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,172312,173735);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,172201,173762);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,172131,173785);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1602,172131,173785);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1602,172131,173785);
}DynAbs.Tracing.TraceSender.TraceExitUsing(1602,171941,173804);
                }
            }
            catch (System.Xml.XmlException)
            { DynAbs.Tracing.TraceSender.TraceEnterCatch(1602,173833,173881);
DynAbs.Tracing.TraceSender.TraceExitCatch(1602,173833,173881);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,173897,173924);

return rtnMsg ??(DynAbs.Tracing.TraceSender.Expression_Null<string>(1602, 173904, 173923)??f_1602_173914_173923(e));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1602,171222,173935);

string
f_1602_171407_171416(System.Exception
this_param)
{
var return_v = this_param.Message ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 171407, 171416);
return return_v;
}


System.Xml.XmlReaderSettings
f_1602_171629_171690()
{
var return_v = InternalDeserializer.XmlReaderSettingsForUntrustedXmlDocument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 171629, 171690);
return return_v;
}


System.Xml.XmlReaderSettings
f_1602_171629_171698(System.Xml.XmlReaderSettings
this_param)
{
var return_v = this_param.Clone();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 171629, 171698);
return return_v;
}


string
f_1602_172059_172068(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 172059, 172068);
return return_v;
}


System.IO.StringReader
f_1602_172032_172069(string
s)
{
var return_v = new System.IO.StringReader( s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 172032, 172069);
return return_v;
}


System.Xml.XmlReader
f_1602_171978_172089(System.IO.StringReader
input,System.Xml.XmlReaderSettings
settings)
{
var return_v = System.Xml.XmlReader.Create( (System.IO.TextReader)input, settings);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 171978, 172089);
return return_v;
}


bool
f_1602_172138_172151(System.Xml.XmlReader
this_param)
{
var return_v = this_param.Read();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 172138, 172151);
return return_v;
}


System.Xml.XmlNodeType
f_1602_172205_172220(System.Xml.XmlReader
this_param)
{
var return_v = this_param.NodeType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 172205, 172220);
return return_v;
}


string
f_1602_172316_172332(System.Xml.XmlReader
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 172316, 172332);
return return_v;
}


bool
f_1602_172316_172386(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 172316, 172386);
return return_v;
}


string
f_1602_172461_172496(System.Xml.XmlReader
this_param)
{
var return_v = this_param.ReadElementContentAsString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 172461, 172496);
return return_v;
}


string
f_1602_172567_172583(System.Xml.XmlReader
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 172567, 172583);
return return_v;
}


bool
f_1602_172567_172640(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 172567, 172640);
return return_v;
}


string
f_1602_172731_172758(System.Xml.XmlReader
this_param,string
name)
{
var return_v = this_param.GetAttribute( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 172731, 172758);
return return_v;
}


System.Globalization.NumberFormatInfo
f_1602_173165_173216()
{
var return_v = System.Globalization.NumberFormatInfo.InvariantInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 173165, 173216);
return return_v;
}


long
f_1602_173132_173217(string
value,System.Globalization.NumberFormatInfo
provider)
{
var return_v = Convert.ToInt64( value, (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 173132, 173217);
return return_v;
}


string
f_1602_173914_173923(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 173914, 173923);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,171222,173935);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,171222,173935);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void StopAllOperations()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,174055,174147);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,174113,174136);

_stopProcessing = true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,174055,174147);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,174055,174147);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,174055,174147);
}
		}

public static bool TestRunspaceState(Runspace runspace, SessionFilterState filterState)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1602,174468,175667);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,174580,174592);

bool 
result
=default(bool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,174608,175626);

switch (filterState)
            {

case SessionFilterState.All:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,174608,175626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,174711,174725);

result = true;
DynAbs.Tracing.TraceSender.TraceBreak(1602,174747,174753);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,174608,175626);

case SessionFilterState.Opened:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,174608,175626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,174826,174894);

result = (f_1602_174836_174868(f_1602_174836_174862(runspace))== RunspaceState.Opened);
DynAbs.Tracing.TraceSender.TraceBreak(1602,174916,174922);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,174608,175626);

case SessionFilterState.Closed:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,174608,175626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,174995,175063);

result = (f_1602_175005_175037(f_1602_175005_175031(runspace))== RunspaceState.Closed);
DynAbs.Tracing.TraceSender.TraceBreak(1602,175085,175091);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,174608,175626);

case SessionFilterState.Disconnected:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,174608,175626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,175170,175244);

result = (f_1602_175180_175212(f_1602_175180_175206(runspace))== RunspaceState.Disconnected);
DynAbs.Tracing.TraceSender.TraceBreak(1602,175266,175272);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,174608,175626);

case SessionFilterState.Broken:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,174608,175626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,175345,175413);

result = (f_1602_175355_175387(f_1602_175355_175381(runspace))== RunspaceState.Broken);
DynAbs.Tracing.TraceSender.TraceBreak(1602,175435,175441);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,174608,175626);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,174608,175626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,175491,175546);

f_1602_175491_175545(false, "Invalid SessionFilterState value.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,175568,175583);

result = false;
DynAbs.Tracing.TraceSender.TraceBreak(1602,175605,175611);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,174608,175626);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,175642,175656);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1602,174468,175667);

System.Management.Automation.Runspaces.RunspaceStateInfo
f_1602_174836_174862(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 174836, 174862);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1602_174836_174868(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 174836, 174868);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1602_175005_175031(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 175005, 175031);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1602_175005_175037(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 175005, 175037);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1602_175180_175206(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 175180, 175206);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1602_175180_175212(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 175180, 175212);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceStateInfo
f_1602_175355_175381(System.Management.Automation.Runspaces.Runspace
this_param)
{
var return_v = this_param.RunspaceStateInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 175355, 175381);
return return_v;
}


System.Management.Automation.Runspaces.RunspaceState
f_1602_175355_175387(System.Management.Automation.Runspaces.RunspaceStateInfo
this_param)
{
var return_v = this_param.State ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 175355, 175387);
return return_v;
}


int
f_1602_175491_175545(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 175491, 175545);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,174468,175667);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,174468,175667);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static TypeTable BuiltInTypesTable
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1602,175869,176289);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,175905,176235) || true) && (s_TypeTable == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,175905,176235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,175976,175988);
                    lock (s_SyncObject)
                    {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,176038,176193) || true) && (s_TypeTable == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,176038,176193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,176119,176166);

s_TypeTable = f_1602_176133_176165();
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,176038,176193);
}
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,175905,176235);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,176255,176274);

return s_TypeTable;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1602,175869,176289);

System.Management.Automation.Runspaces.TypeTable
f_1602_176133_176165()
{
var return_v = TypeTable.LoadDefaultTypeFiles();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 176133, 176165);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,175801,176300);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,175801,176300);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private bool _stopProcessing;

private static readonly object s_SyncObject ;

private static TypeTable s_TypeTable;

static QueryRunspaces()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1602,159418,176545);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,176441,176468);
s_SyncObject = f_1602_176456_176468();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,176504,176515);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1602,159418,176545);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,159418,176545);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1602,159418,176545);

static object
f_1602_176456_176468()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 176456, 176468);
return return_v;
}

}

    
    
    /// <summary>
    /// Runspace states that can be used as filters for querying remote runspaces.
    /// </summary>
    public enum SessionFilterState
    {
        /// <summary>
        /// Return runspaces in any state.
        /// </summary>
        All = 0,

        /// <summary>
        /// Return runspaces in Opened state.
        /// </summary>
        Opened = 1,

        /// <summary>
        /// Return runspaces in Disconnected state.
        /// </summary>
        Disconnected = 2,

        /// <summary>
        /// Return runspaces in Closed state.
        /// </summary>
        Closed = 3,

        /// <summary>
        /// Return runspaces in Broken state.
        /// </summary>
        Broken = 4
    }

    
    }

namespace System.Management.Automation.Remoting
{
    /// <summary>
    /// IMPORTANT: proxy configuration is supported for HTTPS only; for HTTP, the direct
    /// connection to the server is used.
    /// </summary>
    [SuppressMessage("Microsoft.Design", "CA1027:MarkEnumsWithFlags")]
    public enum ProxyAccessType
    {
        /// <summary>
        /// ProxyAccessType is not specified. That means Proxy information (ProxyAccessType, ProxyAuthenticationMechanism
        /// and ProxyCredential)is not passed to WSMan at all.
        /// </summary>
        None = 0,
        /// <summary>
        /// Use the Internet Explorer proxy configuration for the current user.
        ///  Internet Explorer proxy settings for the current active network connection.
        ///  This option requires the user profile to be loaded, so the option can
        ///  be directly used when called within a process that is running under
        ///  an interactive user account identity; if the client application is running
        ///  under a user context different than the interactive user, the client
        ///  application has to explicitly load the user profile prior to using this option.
        /// </summary>
        IEConfig = 1,
        /// <summary>
        /// Proxy settings configured for WinHTTP, using the ProxyCfg.exe utility.
        /// </summary>
        WinHttpConfig = 2,
        /// <summary>
        /// Force autodetection of proxy.
        /// </summary>
        AutoDetect = 4,
        /// <summary>
        /// Do not use a proxy server - resolves all host names locally.
        /// </summary>
        NoProxyServer = 8
    }
public sealed class PSSessionOption
{
public PSSessionOption()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1602,179366,179412);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,179641,179763);
this.MaximumConnectionRedirectionCount = WSManConnectionInfo.defaultMaximumConnectionRedirectionCount;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,180294,180342);
this.NoCompression = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,180725,180776);
this.NoMachineProfile = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,181025,181101);
this.ProxyAccessType = ProxyAccessType.None;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,182806,182862);
this._proxyAuthentication = AuthenticationMechanism.Negotiate;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,183009,183058);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,183550,183587);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,183884,183921);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,184218,184263);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,184656,184785);
this.OperationTimeout = TimeSpan.FromMilliseconds(BaseTransportManager.ClientDefaultOperationTimeoutMs);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,185059,185097);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,185277,185421);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,185577,185729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,186059,186169);
this.OutputBufferingMode = WSManConnectionInfo.DefaultOutputBufferingMode;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,186351,186453);
this.MaxConnectionRetryCount = WSManConnectionInfo.DefaultMaxConnectionRetryCount;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,186569,186609);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,186728,186770);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,187025,187084);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,187317,187381);
this.MaximumReceivedObjectSize = 200 << 20;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,187583,187739);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,188210,188323);
this.OpenTimeout = TimeSpan.FromMilliseconds(RunspaceConnectionInfo.DefaultOpenTimeout);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,188981,189098);
this.CancelTimeout = TimeSpan.FromMilliseconds(RunspaceConnectionInfo.defaultCancelTimeout);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,189533,189646);
this.IdleTimeout = TimeSpan.FromMilliseconds(RunspaceConnectionInfo.DefaultIdleTimeout);DynAbs.Tracing.TraceSender.TraceExitConstructor(1602,179366,179412);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,179366,179412);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,179366,179412);
}
		}

public int MaximumConnectionRedirectionCount {get; set; }

public bool NoCompression {get; set; }

public bool NoMachineProfile {get; set; }

public ProxyAccessType ProxyAccessType {get; set; }

public AuthenticationMechanism ProxyAuthentication
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,181843,181879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,181849,181877);

return _proxyAuthentication;
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,181843,181879);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,181768,182762);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,181768,182762);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1602,181895,182751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,181931,182736);

switch (value)
                {

case AuthenticationMechanism.Basic:
                    case AuthenticationMechanism.Negotiate:
                    case AuthenticationMechanism.Digest:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,181931,182736);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,182166,182195);

_proxyAuthentication = value;
DynAbs.Tracing.TraceSender.TraceBreak(1602,182221,182227);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,181931,182736);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1602,181931,182736);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,182283,182654);

string 
message = f_1602_182300_182653(f_1602_182347_182398(), value, f_1602_182465_182505(                            AuthenticationMechanism.Basic), f_1602_182536_182580(                            AuthenticationMechanism.Negotiate), f_1602_182611_182652(                            AuthenticationMechanism.Digest))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1602,182680,182717);

throw f_1602_182686_182716(message);
DynAbs.Tracing.TraceSender.TraceExitCondition(1602,181931,182736);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1602,181895,182751);

string
f_1602_182347_182398()
{
var return_v = RemotingErrorIdStrings.ProxyAmbiguousAuthentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1602, 182347, 182398);
return return_v;
}


string
f_1602_182465_182505(System.Management.Automation.Runspaces.AuthenticationMechanism
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 182465, 182505);
return return_v;
}


string
f_1602_182536_182580(System.Management.Automation.Runspaces.AuthenticationMechanism
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 182536, 182580);
return return_v;
}


string
f_1602_182611_182652(System.Management.Automation.Runspaces.AuthenticationMechanism
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 182611, 182652);
return return_v;
}


string
f_1602_182300_182653(string
resourceString,params object[]
args)
{
var return_v = PSRemotingErrorInvariants.FormatResourceString( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 182300, 182653);
return return_v;
}


System.ArgumentException
f_1602_182686_182716(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1602, 182686, 182716);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1602,181768,182762);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,181768,182762);
}
		}}

private AuthenticationMechanism _proxyAuthentication ;

public PSCredential ProxyCredential {get; set; }

public bool SkipCACheck {get; set; }

public bool SkipCNCheck {get; set; }

public bool SkipRevocationCheck {get; set; }

public TimeSpan OperationTimeout {get; set; }

public bool NoEncryption {get; set; }

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "UTF")]
        public bool UseUTF16 {get; set; }

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SPN")]
        public bool IncludePortInSPN {get; set; }

public OutputBufferingMode OutputBufferingMode {get; set; }

public int MaxConnectionRetryCount {get; set; }

public CultureInfo Culture {get; set; }

public CultureInfo UICulture {get; set; }

public int? MaximumReceivedDataSizePerCommand {get; set; }

public int? MaximumReceivedObjectSize {get; set; }

[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public PSPrimitiveDictionary ApplicationArguments {get; set; }

public TimeSpan OpenTimeout {get; set; }

public TimeSpan CancelTimeout {get; set; }

public TimeSpan IdleTimeout {get; set; }

static PSSessionOption()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1602,179198,189653);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1602,179198,189653);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1602,179198,189653);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1602,179198,189653);
}
}
