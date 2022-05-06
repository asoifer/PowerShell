// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Internal;

namespace System.Management.Automation
{
internal class RuntimeDefinedParameterBinder : ParameterBinderBase
{
internal RuntimeDefinedParameterBinder(
            RuntimeDefinedParameterDictionary target,
            InternalCommand command,
            CommandLineParameters commandLineParameters)
:base(f_1324_1395_1401_C(target) ,f_1324_1403_1423(command),f_1324_1425_1440(command),command)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1324,1184,2550);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1324,1550,2472);
foreach(var pair in f_1324_1571_1577_I(target) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1324,1550,2472);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1324,1611,1633);

string 
key = pair.Key
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1324,1651,1691);

RuntimeDefinedParameter 
pp = pair.Value
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1324,1709,1755);

string 
ppName = (DynAbs.Tracing.TraceSender.Conditional_F1(1324, 1725, 1737)||(((pp == null) &&DynAbs.Tracing.TraceSender.Conditional_F2(1324, 1740, 1744))||DynAbs.Tracing.TraceSender.Conditional_F3(1324, 1747, 1754)))?null :f_1324_1747_1754(pp)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1324,1773,2457) || true) && (pp == null ||(DynAbs.Tracing.TraceSender.Expression_False(1324, 1777, 1804)||key != ppName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1324,1773,2457);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1324,1846,2391);

ParameterBindingException 
bindingException =
f_1324_1916_2390(ErrorCategory.InvalidArgument, f_1324_2036_2056(command), null, ppName, null, null, f_1324_2229_2287(), "RuntimeDefinedParameterNameMismatch", key)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1324,2415,2438);

throw bindingException;
DynAbs.Tracing.TraceSender.TraceExitCondition(1324,1773,2457);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1324,1550,2472);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1324,1,923);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1324,1,923);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1324,2488,2539);

this.CommandLineParameters = commandLineParameters;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1324,1184,2550);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1324,1184,2550);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1324,1184,2550);
}
		}

internal new RuntimeDefinedParameterDictionary Target
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1324,2881,2988);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1324,2917,2973);

return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Target,1324,2924,2935)as RuntimeDefinedParameterDictionary;
DynAbs.Tracing.TraceSender.TraceExitMethod(1324,2881,2988);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1324,2803,3086);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1324,2803,3086);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1324,3004,3075);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1324,3040,3060);

base.Target = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1324,3004,3075);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1324,2803,3086);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1324,2803,3086);
}
		}}

internal override object GetDefaultParameterValue(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1324,3467,3821);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1324,3554,3575);

object 
result = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1324,3589,3623);

RuntimeDefinedParameter 
parameter
=default(RuntimeDefinedParameter);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1324,3637,3780) || true) && (f_1324_3641_3685(f_1324_3641_3652(this), name, out parameter)&&(DynAbs.Tracing.TraceSender.Expression_True(1324, 3641, 3706)&&parameter != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1324,3637,3780);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1324,3740,3765);

result = f_1324_3749_3764(parameter);
DynAbs.Tracing.TraceSender.TraceExitCondition(1324,3637,3780);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1324,3796,3810);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1324,3467,3821);

System.Management.Automation.RuntimeDefinedParameterDictionary
f_1324_3641_3652(System.Management.Automation.RuntimeDefinedParameterBinder
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1324, 3641, 3652);
return return_v;
}


bool
f_1324_3641_3685(System.Management.Automation.RuntimeDefinedParameterDictionary
this_param,string
key,out System.Management.Automation.RuntimeDefinedParameter
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1324, 3641, 3685);
return return_v;
}


object
f_1324_3749_3764(System.Management.Automation.RuntimeDefinedParameter
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1324, 3749, 3764);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1324,3467,3821);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1324,3467,3821);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override void BindParameter(string name, object value, CompiledCommandParameter parameterMetadata)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1324,4644,5016);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1324,4776,4904) || true) && (f_1324_4780_4806(name))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1324,4776,4904);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1324,4840,4889);

throw f_1324_4846_4888("name");
DynAbs.Tracing.TraceSender.TraceExitCondition(1324,4776,4904);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1324,4920,4947);

f_1324_4920_4932(f_1324_4920_4926(), name).Value = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1324,4961,5005);

f_1324_4961_5004(f_1324_4961_4987(this), name, value);
DynAbs.Tracing.TraceSender.TraceExitMethod(1324,4644,5016);

bool
f_1324_4780_4806(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1324, 4780, 4806);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1324_4846_4888(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1324, 4846, 4888);
return return_v;
}


System.Management.Automation.RuntimeDefinedParameterDictionary
f_1324_4920_4926()
{
var return_v = Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1324, 4920, 4926);
return return_v;
}


System.Management.Automation.RuntimeDefinedParameter
f_1324_4920_4932(System.Management.Automation.RuntimeDefinedParameterDictionary
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1324, 4920, 4932);
return return_v;
}


System.Management.Automation.CommandLineParameters
f_1324_4961_4987(System.Management.Automation.RuntimeDefinedParameterBinder
this_param)
{
var return_v = this_param.CommandLineParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1324, 4961, 4987);
return return_v;
}


int
f_1324_4961_5004(System.Management.Automation.CommandLineParameters
this_param,string
name,object
value)
{
this_param.Add( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1324, 4961, 5004);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1324,4644,5016);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1324,4644,5016);
}
		}

static RuntimeDefinedParameterBinder()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1324,361,5063);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1324,361,5063);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1324,361,5063);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1324,361,5063);

static System.Management.Automation.InvocationInfo
f_1324_1403_1423(System.Management.Automation.Internal.InternalCommand
this_param)
{
var return_v = this_param.MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1324, 1403, 1423);
return return_v;
}


static System.Management.Automation.ExecutionContext
f_1324_1425_1440(System.Management.Automation.Internal.InternalCommand
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1324, 1425, 1440);
return return_v;
}


string
f_1324_1747_1754(System.Management.Automation.RuntimeDefinedParameter
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1324, 1747, 1754);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1324_2036_2056(System.Management.Automation.Internal.InternalCommand
this_param)
{
var return_v = this_param.MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1324, 2036, 2056);
return return_v;
}


string
f_1324_2229_2287()
{
var return_v =                             ParameterBinderStrings.RuntimeDefinedParameterNameMismatch;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1324, 2229, 2287);
return return_v;
}


System.Management.Automation.ParameterBindingException
f_1324_1916_2390(System.Management.Automation.ErrorCategory
errorCategory,System.Management.Automation.InvocationInfo
invocationInfo,System.Management.Automation.Language.IScriptExtent
errorPosition,string
parameterName,System.Type
parameterType,System.Type
typeSpecified,string
resourceString,string
errorId,params object[]
args)
{
var return_v = new System.Management.Automation.ParameterBindingException( errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1324, 1916, 2390);
return return_v;
}


System.Management.Automation.RuntimeDefinedParameterDictionary
f_1324_1571_1577_I(System.Management.Automation.RuntimeDefinedParameterDictionary
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1324, 1571, 1577);
return return_v;
}


static object
f_1324_1395_1401_C(object
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1324, 1184, 2550);
return return_v;
}

}
}
