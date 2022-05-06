// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Management.Automation.Runspaces;

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
public sealed class SessionState
{
internal SessionState(SessionStateInternal sessionState)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1353,927,1198);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,11933,11946);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,11991,11997);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,12051,12060);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,12094,12099);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,12139,12148);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,1008,1142) || true) && (sessionState == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1353,1008,1142);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,1066,1127);

throw f_1353_1072_1126("sessionState");
DynAbs.Tracing.TraceSender.TraceExitCondition(1353,1008,1142);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,1158,1187);

_sessionState = sessionState;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1353,927,1198);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1353,927,1198);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1353,927,1198);
}
		}

internal SessionState(ExecutionContext context, bool createAsChild, bool linkToGlobal)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1353,1940,2502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,11933,11946);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,11991,11997);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,12051,12060);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,12094,12099);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,12139,12148);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,2051,2145) || true) && (context == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1353,2051,2145);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,2089,2145);

throw f_1353_2095_2144("ExecutionContext");
DynAbs.Tracing.TraceSender.TraceExitCondition(1353,2051,2145);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,2161,2435) || true) && (createAsChild)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1353,2161,2435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,2212,2304);

_sessionState = f_1353_2228_2303(f_1353_2253_2279(context), linkToGlobal, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1353,2161,2435);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1353,2161,2435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,2370,2420);

_sessionState = f_1353_2386_2419(context);
DynAbs.Tracing.TraceSender.TraceExitCondition(1353,2161,2435);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,2451,2491);

_sessionState.PublicSessionState = this;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1353,1940,2502);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1353,1940,2502);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1353,1940,2502);
}
		}

public SessionState()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1353,2614,2975);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,11933,11946);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,11991,11997);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,12051,12060);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,12094,12099);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,12139,12148);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,2660,2732);

ExecutionContext 
ecFromTLS = f_1353_2689_2731()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,2746,2842) || true) && (ecFromTLS == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1353,2746,2842);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,2786,2842);

throw f_1353_2792_2841("ExecutionContext");
DynAbs.Tracing.TraceSender.TraceExitCondition(1353,2746,2842);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,2858,2910);

_sessionState = f_1353_2874_2909(ecFromTLS);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,2924,2964);

_sessionState.PublicSessionState = this;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1353,2614,2975);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1353,2614,2975);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1353,2614,2975);
}
		}

public DriveManagementIntrinsics Drive
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1353,3211,3292);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,3217,3290);

return _drive ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.DriveManagementIntrinsics>(1353, 3224, 3289)??(_drive = f_1353_3244_3288(_sessionState)));
DynAbs.Tracing.TraceSender.TraceExitMethod(1353,3211,3292);

System.Management.Automation.DriveManagementIntrinsics
f_1353_3244_3288(System.Management.Automation.SessionStateInternal
sessionState)
{
var return_v = new System.Management.Automation.DriveManagementIntrinsics( sessionState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1353, 3244, 3288);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1353,3148,3303);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1353,3148,3303);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public CmdletProviderManagementIntrinsics Provider
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1353,3485,3581);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,3491,3579);

return _provider ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.CmdletProviderManagementIntrinsics>(1353, 3498, 3578)??(_provider = f_1353_3524_3577(_sessionState)));
DynAbs.Tracing.TraceSender.TraceExitMethod(1353,3485,3581);

System.Management.Automation.CmdletProviderManagementIntrinsics
f_1353_3524_3577(System.Management.Automation.SessionStateInternal
sessionState)
{
var return_v = new System.Management.Automation.CmdletProviderManagementIntrinsics( sessionState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1353, 3524, 3577);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1353,3410,3592);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1353,3410,3592);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public PathIntrinsics Path
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1353,3759,3827);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,3765,3825);

return _path ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.PathIntrinsics>(1353, 3772, 3824)??(_path = f_1353_3790_3823(_sessionState)));
DynAbs.Tracing.TraceSender.TraceExitMethod(1353,3759,3827);

System.Management.Automation.PathIntrinsics
f_1353_3790_3823(System.Management.Automation.SessionStateInternal
sessionState)
{
var return_v = new System.Management.Automation.PathIntrinsics( sessionState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1353, 3790, 3823);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1353,3708,3838);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1353,3708,3838);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public PSVariableIntrinsics PSVariable
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1353,4025,4107);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,4031,4105);

return _variable ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.PSVariableIntrinsics>(1353, 4038, 4104)??(_variable = f_1353_4064_4103(_sessionState)));
DynAbs.Tracing.TraceSender.TraceExitMethod(1353,4025,4107);

System.Management.Automation.PSVariableIntrinsics
f_1353_4064_4103(System.Management.Automation.SessionStateInternal
sessionState)
{
var return_v = new System.Management.Automation.PSVariableIntrinsics( sessionState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1353, 4064, 4103);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1353,3962,4118);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1353,3962,4118);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public PSLanguageMode LanguageMode
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1353,4301,4343);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,4307,4341);

return f_1353_4314_4340(_sessionState);
DynAbs.Tracing.TraceSender.TraceExitMethod(1353,4301,4343);

System.Management.Automation.PSLanguageMode
f_1353_4314_4340(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.LanguageMode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1353, 4314, 4340);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1353,4242,4413);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1353,4242,4413);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1353,4359,4402);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,4365,4400);

_sessionState.LanguageMode = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1353,4359,4402);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1353,4242,4413);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1353,4242,4413);
}
		}}

public bool UseFullLanguageModeInDebugger
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1353,4660,4719);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,4666,4717);

return f_1353_4673_4716(_sessionState);
DynAbs.Tracing.TraceSender.TraceExitMethod(1353,4660,4719);

bool
f_1353_4673_4716(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.UseFullLanguageModeInDebugger;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1353, 4673, 4716);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1353,4594,4730);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1353,4594,4730);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public List<string> Scripts
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1353,5016,5053);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,5022,5051);

return f_1353_5029_5050(_sessionState);
DynAbs.Tracing.TraceSender.TraceExitMethod(1353,5016,5053);

System.Collections.Generic.List<string>
f_1353_5029_5050(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.Scripts;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1353, 5029, 5050);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1353,4964,5064);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1353,4964,5064);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public List<string> Applications
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1353,5365,5407);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,5371,5405);

return f_1353_5378_5404(_sessionState);
DynAbs.Tracing.TraceSender.TraceExitMethod(1353,5365,5407);

System.Collections.Generic.List<string>
f_1353_5378_5404(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.Applications;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1353, 5378, 5404);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1353,5308,5418);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1353,5308,5418);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public PSModuleInfo Module
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1353,5599,5635);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,5605,5633);

return f_1353_5612_5632(_sessionState);
DynAbs.Tracing.TraceSender.TraceExitMethod(1353,5599,5635);

System.Management.Automation.PSModuleInfo
f_1353_5612_5632(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1353, 5612, 5632);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1353,5548,5646);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1353,5548,5646);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public ProviderIntrinsics InvokeProvider
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1353,5840,5884);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,5846,5882);

return f_1353_5853_5881(_sessionState);
DynAbs.Tracing.TraceSender.TraceExitMethod(1353,5840,5884);

System.Management.Automation.ProviderIntrinsics
f_1353_5853_5881(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.InvokeProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1353, 5853, 5881);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1353,5775,5895);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1353,5775,5895);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public CommandInvocationIntrinsics InvokeCommand
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1353,6107,6184);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,6113,6182);

return f_1353_6120_6181(f_1353_6120_6167(f_1353_6120_6150(_sessionState)));
DynAbs.Tracing.TraceSender.TraceExitMethod(1353,6107,6184);

System.Management.Automation.ExecutionContext
f_1353_6120_6150(System.Management.Automation.SessionStateInternal
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1353, 6120, 6150);
return return_v;
}


System.Management.Automation.EngineIntrinsics
f_1353_6120_6167(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineIntrinsics;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1353, 6120, 6167);
return return_v;
}


System.Management.Automation.CommandInvocationIntrinsics
f_1353_6120_6181(System.Management.Automation.EngineIntrinsics
this_param)
{
var return_v = this_param.InvokeCommand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1353, 6120, 6181);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1353,6034,6195);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1353,6034,6195);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public static void ThrowIfNotVisible(CommandOrigin origin, object valueToCheck)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1353,6673,9138);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,6777,6809);

SessionStateException 
exception
=default(SessionStateException);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,6823,9127) || true) && (!f_1353_6828_6859(origin, valueToCheck))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1353,6823,9127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,6893,6936);

PSVariable 
sv = valueToCheck as PSVariable
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,6954,7404) || true) && (sv != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1353,6954,7404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,7010,7345);

exception =
f_1353_7046_7344(f_1353_7101_7108(sv), SessionStateCategory.Variable, "VariableIsPrivate", f_1353_7246_7283(), ErrorCategory.PermissionDenied);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,7369,7385);

throw exception;
DynAbs.Tracing.TraceSender.TraceExitCondition(1353,6954,7404);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,7424,7472);

CommandInfo 
cinfo = valueToCheck as CommandInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,7490,8674) || true) && (cinfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1353,7490,8674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,7549,7581);

string 
commandName = f_1353_7570_7580(cinfo)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,7603,8615) || true) && (commandName != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1353,7603,8615);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,7751,8127);

exception =
f_1353_7792_8126(commandName, SessionStateCategory.Command, "NamedCommandIsPrivate", f_1353_8019_8060(), ErrorCategory.PermissionDenied);
DynAbs.Tracing.TraceSender.TraceExitCondition(1353,7603,8615);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1353,7603,8615);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,8225,8592);

exception =
f_1353_8266_8591(string.Empty, SessionStateCategory.Command, "CommandIsPrivate", f_1353_8489_8525(), ErrorCategory.PermissionDenied);
DynAbs.Tracing.TraceSender.TraceExitCondition(1353,7603,8615);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,8639,8655);

throw exception;
DynAbs.Tracing.TraceSender.TraceExitCondition(1353,7490,8674);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,8762,9076);

exception =
f_1353_8795_9075(null, SessionStateCategory.Resource, "ResourceIsPrivate", f_1353_8980_9017(), ErrorCategory.PermissionDenied);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,9096,9112);

throw exception;
DynAbs.Tracing.TraceSender.TraceExitCondition(1353,6823,9127);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1353,6673,9138);

bool
f_1353_6828_6859(System.Management.Automation.CommandOrigin
origin,object
valueToCheck)
{
var return_v = IsVisible( origin, valueToCheck);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1353, 6828, 6859);
return return_v;
}


string
f_1353_7101_7108(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1353, 7101, 7108);
return return_v;
}


string
f_1353_7246_7283()
{
var return_v =                            SessionStateStrings.VariableIsPrivate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1353, 7246, 7283);
return return_v;
}


System.Management.Automation.SessionStateException
f_1353_7046_7344(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr,System.Management.Automation.ErrorCategory
errorCategory,params object[]
messageArgs)
{
var return_v = new System.Management.Automation.SessionStateException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr, errorCategory, messageArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1353, 7046, 7344);
return return_v;
}


string
f_1353_7570_7580(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1353, 7570, 7580);
return return_v;
}


string
f_1353_8019_8060()
{
var return_v =                                 SessionStateStrings.NamedCommandIsPrivate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1353, 8019, 8060);
return return_v;
}


System.Management.Automation.SessionStateException
f_1353_7792_8126(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr,System.Management.Automation.ErrorCategory
errorCategory,params object[]
messageArgs)
{
var return_v = new System.Management.Automation.SessionStateException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr, errorCategory, messageArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1353, 7792, 8126);
return return_v;
}


string
f_1353_8489_8525()
{
var return_v =                                 SessionStateStrings.CommandIsPrivate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1353, 8489, 8525);
return return_v;
}


System.Management.Automation.SessionStateException
f_1353_8266_8591(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr,System.Management.Automation.ErrorCategory
errorCategory,params object[]
messageArgs)
{
var return_v = new System.Management.Automation.SessionStateException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr, errorCategory, messageArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1353, 8266, 8591);
return return_v;
}


string
f_1353_8980_9017()
{
var return_v =                         SessionStateStrings.ResourceIsPrivate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1353, 8980, 9017);
return return_v;
}


System.Management.Automation.SessionStateException
f_1353_8795_9075(string
itemName,System.Management.Automation.SessionStateCategory
sessionStateCategory,string
errorIdAndResourceId,string
resourceStr,System.Management.Automation.ErrorCategory
errorCategory,params object[]
messageArgs)
{
var return_v = new System.Management.Automation.SessionStateException( itemName, sessionStateCategory, errorIdAndResourceId, resourceStr, errorCategory, messageArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1353, 8795, 9075);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1353,6673,9138);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1353,6673,9138);
}
		}

public static bool IsVisible(CommandOrigin origin, object valueToCheck)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1353,9511,9953);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,9607,9674) || true) && (origin == CommandOrigin.Internal)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1353,9607,9674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,9662,9674);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1353,9607,9674);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,9688,9774);

IHasSessionStateEntryVisibility 
obj = valueToCheck as IHasSessionStateEntryVisibility
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,9788,9914) || true) && (obj != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1353,9788,9914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,9837,9899);

return (f_1353_9845_9859(obj)== SessionStateEntryVisibility.Public);
DynAbs.Tracing.TraceSender.TraceExitCondition(1353,9788,9914);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,9930,9942);

return true;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1353,9511,9953);

System.Management.Automation.SessionStateEntryVisibility
f_1353_9845_9859(System.Management.Automation.IHasSessionStateEntryVisibility
this_param)
{
var return_v = this_param.Visibility ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1353, 9845, 9859);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1353,9511,9953);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1353,9511,9953);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static bool IsVisible(CommandOrigin origin, PSVariable variable)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1353,10322,10719);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,10418,10485) || true) && (origin == CommandOrigin.Internal)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1353,10418,10485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,10473,10485);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1353,10418,10485);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,10499,10625) || true) && (variable == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1353,10499,10625);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,10553,10610);

throw f_1353_10559_10609("variable");
DynAbs.Tracing.TraceSender.TraceExitCondition(1353,10499,10625);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,10641,10708);

return (f_1353_10649_10668(variable)== SessionStateEntryVisibility.Public);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1353,10322,10719);

System.Management.Automation.PSArgumentNullException
f_1353_10559_10609(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1353, 10559, 10609);
return return_v;
}


System.Management.Automation.SessionStateEntryVisibility
f_1353_10649_10668(System.Management.Automation.PSVariable
this_param)
{
var return_v = this_param.Visibility ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1353, 10649, 10668);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1353,10322,10719);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1353,10322,10719);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static bool IsVisible(CommandOrigin origin, CommandInfo commandInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1353,11090,11500);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,11190,11257) || true) && (origin == CommandOrigin.Internal)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1353,11190,11257);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,11245,11257);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1353,11190,11257);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,11271,11403) || true) && (commandInfo == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1353,11271,11403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,11328,11388);

throw f_1353_11334_11387("commandInfo");
DynAbs.Tracing.TraceSender.TraceExitCondition(1353,11271,11403);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,11419,11489);

return (f_1353_11427_11449(commandInfo)== SessionStateEntryVisibility.Public);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1353,11090,11500);

System.Management.Automation.PSArgumentNullException
f_1353_11334_11387(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1353, 11334, 11387);
return return_v;
}


System.Management.Automation.SessionStateEntryVisibility
f_1353_11427_11449(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.Visibility ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1353, 11427, 11449);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1353,11090,11500);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1353,11090,11500);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal SessionStateInternal Internal
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1353,11783,11812);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1353,11789,11810);

return _sessionState;
DynAbs.Tracing.TraceSender.TraceExitMethod(1353,11783,11812);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1353,11720,11823);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1353,11720,11823);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private SessionStateInternal _sessionState;

private DriveManagementIntrinsics _drive;

private CmdletProviderManagementIntrinsics _provider;

private PathIntrinsics _path;

private PSVariableIntrinsics _variable;

static SessionState()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1353,424,12191);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1353,424,12191);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1353,424,12191);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1353,424,12191);

System.Management.Automation.PSArgumentNullException
f_1353_1072_1126(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1353, 1072, 1126);
return return_v;
}


System.InvalidOperationException
f_1353_2095_2144(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1353, 2095, 2144);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1353_2253_2279(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineSessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1353, 2253, 2279);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1353_2228_2303(System.Management.Automation.SessionStateInternal
parent,bool
linkToGlobal,System.Management.Automation.ExecutionContext
context)
{
var return_v = new System.Management.Automation.SessionStateInternal( parent, linkToGlobal, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1353, 2228, 2303);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1353_2386_2419(System.Management.Automation.ExecutionContext
context)
{
var return_v = new System.Management.Automation.SessionStateInternal( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1353, 2386, 2419);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1353_2689_2731()
{
var return_v = LocalPipeline.GetExecutionContextFromTLS();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1353, 2689, 2731);
return return_v;
}


System.InvalidOperationException
f_1353_2792_2841(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1353, 2792, 2841);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1353_2874_2909(System.Management.Automation.ExecutionContext
context)
{
var return_v = new System.Management.Automation.SessionStateInternal( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1353, 2874, 2909);
return return_v;
}

}

    /// <summary>
    /// This enum defines the visibility of execution environment elements...
    /// </summary>
    public enum SessionStateEntryVisibility
    {
        /// <summary>
        /// Entries are visible to requests from outside the runspace.
        /// </summary>
        Public = 0,

        /// <summary>
        /// Entries are not visible to requests from outside the runspace.
        /// </summary>
        Private = 1
    }

    internal interface IHasSessionStateEntryVisibility
    {

SessionStateEntryVisibility Visibility {get; set; }
    }

    /// <summary>
    /// This enum defines what subset of the PowerShell language is permitted when
    /// calling into this execution environment.
    /// </summary>
    public enum PSLanguageMode
    {
        /// <summary>
        /// All PowerShell language elements are available.
        /// </summary>
        FullLanguage = 0,

        /// <summary>
        /// A subset of language elements are available to external requests.
        /// </summary>
        RestrictedLanguage = 1,

        /// <summary>
        /// Commands containing script text to evaluate are not allowed. You can only
        /// call commands using the Runspace APIs when in this mode.
        /// </summary>
        NoLanguage = 2,

        /// <summary>
        /// Exposes a subset of the PowerShell language that limits itself to core PowerShell
        /// types, does not support method invocation (except on those types), and does not
        /// support property setters (except on those types).
        /// </summary>
        ConstrainedLanguage = 3
    }
}

