// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation.Internal;

namespace System.Management.Automation
{
internal class ScriptParameterBinderController : ParameterBinderController
{
internal ScriptParameterBinderController(
            ScriptBlock script,
            InvocationInfo invocationInfo,
            ExecutionContext context,
            InternalCommand command,
            SessionStateScope localScope)
:base(f_1335_1622_1636_C(invocationInfo) ,context,f_1335_1647_1726(script, invocationInfo, context, command, localScope))
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1335,1363,2360);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,2535,2589);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,1752,1789);

this.DollarArgs = f_1335_1770_1788();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,1944,2349) || true) && (f_1335_1948_1975(script))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1335,1944,2349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,2009,2095);

UnboundParameters = f_1335_2029_2094(f_1335_2029_2052(this), f_1335_2069_2093(script));
DynAbs.Tracing.TraceSender.TraceExitCondition(1335,1944,2349);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1335,1944,2349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,2161,2208);

_bindableParameters = f_1335_2183_2207(script);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,2226,2334);

UnboundParameters = f_1335_2246_2333(f_1335_2287_2332(f_1335_2287_2325(_bindableParameters)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1335,1944,2349);
}
DynAbs.Tracing.TraceSender.TraceExitConstructor(1335,1363,2360);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1335,1363,2360);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1335,1363,2360);
}
		}

internal List<object> DollarArgs {get; private set; }

internal void BindCommandLineParameters(Collection<CommandParameterInternal> arguments)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1335,2960,4394);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,3153,3288);
foreach(CommandParameterInternal argument in f_1335_3199_3208_I(arguments) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1335,3153,3288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,3242,3273);

f_1335_3242_3272(f_1335_3242_3258(), argument);
DynAbs.Tracing.TraceSender.TraceExitCondition(1335,3153,3288);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1335,1,136);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1335,1,136);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,3304,3330);

f_1335_3304_3329(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,3434,3486);

UnboundArguments = f_1335_3453_3485(this, f_1335_3468_3484());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,3502,3550);

ParameterBindingException 
parameterBindingError
=default(ParameterBindingException);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,3564,3785);

UnboundArguments =
f_1335_3600_3784(this, f_1335_3647_3663(), uint.MaxValue, uint.MaxValue, out parameterBindingError);

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,3837,3895);

f_1335_3837_3864(this).RecordBoundParameters = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,4048,4078);

f_1335_4048_4077(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,4176,4219);

f_1335_4176_4218(this, f_1335_4201_4217());
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1335,4248,4360);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,4288,4345);

f_1335_4288_4315(this).RecordBoundParameters = true;
DynAbs.Tracing.TraceSender.TraceExitFinally(1335,4248,4360);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,4376,4383);

return;
DynAbs.Tracing.TraceSender.TraceExitMethod(1335,2960,4394);

System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
f_1335_3242_3258()
{
var return_v = UnboundArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 3242, 3258);
return return_v;
}


int
f_1335_3242_3272(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
this_param,System.Management.Automation.CommandParameterInternal
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 3242, 3272);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
f_1335_3199_3208_I(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 3199, 3208);
return return_v;
}


int
f_1335_3304_3329(System.Management.Automation.ScriptParameterBinderController
this_param)
{
this_param.ReparseUnboundArguments();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 3304, 3329);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
f_1335_3468_3484()
{
var return_v = UnboundArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 3468, 3484);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
f_1335_3453_3485(System.Management.Automation.ScriptParameterBinderController
this_param,System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
arguments)
{
var return_v = this_param.BindParameters( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 3453, 3485);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
f_1335_3647_3663()
{
var return_v = UnboundArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 3647, 3663);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
f_1335_3600_3784(System.Management.Automation.ScriptParameterBinderController
this_param,System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
unboundArguments,uint
validParameterSets,uint
defaultParameterSet,out System.Management.Automation.ParameterBindingException
outgoingBindingException)
{
var return_v = this_param.BindPositionalParameters( unboundArguments, validParameterSets, defaultParameterSet, out outgoingBindingException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 3600, 3784);
return return_v;
}


System.Management.Automation.ParameterBinderBase
f_1335_3837_3864(System.Management.Automation.ScriptParameterBinderController
this_param)
{
var return_v = this_param.DefaultParameterBinder;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 3837, 3864);
return return_v;
}


int
f_1335_4048_4077(System.Management.Automation.ScriptParameterBinderController
this_param)
{
this_param.BindUnboundScriptParameters();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 4048, 4077);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
f_1335_4201_4217()
{
var return_v = UnboundArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 4201, 4217);
return return_v;
}


int
f_1335_4176_4218(System.Management.Automation.ScriptParameterBinderController
this_param,System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
arguments)
{
this_param.HandleRemainingArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 4176, 4218);
return 0;
}


System.Management.Automation.ParameterBinderBase
f_1335_4288_4315(System.Management.Automation.ScriptParameterBinderController
this_param)
{
var return_v = this_param.DefaultParameterBinder;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 4288, 4315);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1335,2960,4394);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1335,2960,4394);
}
		}

internal override bool BindParameter(CommandParameterInternal argument, ParameterBindingFlags flags)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1335,4938,5312);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,5165,5275);

f_1335_5165_5274(f_1335_5165_5187(), f_1335_5202_5224(argument), f_1335_5226_5248(argument), parameterMetadata: null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,5289,5301);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1335,4938,5312);

System.Management.Automation.ParameterBinderBase
f_1335_5165_5187()
{
var return_v = DefaultParameterBinder;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 5165, 5187);
return return_v;
}


string
f_1335_5202_5224(System.Management.Automation.CommandParameterInternal
this_param)
{
var return_v = this_param.ParameterName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 5202, 5224);
return return_v;
}


object
f_1335_5226_5248(System.Management.Automation.CommandParameterInternal
this_param)
{
var return_v = this_param.ArgumentValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 5226, 5248);
return return_v;
}


int
f_1335_5165_5274(System.Management.Automation.ParameterBinderBase
this_param,string
name,object
value,System.Management.Automation.CompiledCommandParameter
parameterMetadata)
{
this_param.BindParameter( name, value, parameterMetadata: parameterMetadata);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 5165, 5274);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1335,4938,5312);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1335,4938,5312);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override Collection<CommandParameterInternal> BindParameters(Collection<CommandParameterInternal> arguments)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1335,5534,8431);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,5676,5765);

Collection<CommandParameterInternal> 
result = f_1335_5722_5764()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,5781,8390);
foreach(CommandParameterInternal argument in f_1335_5827_5836_I(arguments) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1335,5781,8390);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,5870,6019) || true) && (f_1335_5874_5906_M(!argument.ParameterNameSpecified))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1335,5870,6019);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,5948,5969);

f_1335_5948_5968(                    result, argument);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,5991,6000);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1335,5870,6019);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,6174,6468);

MergedCompiledCommandParameter 
parameter =
f_1335_6238_6467(f_1335_6238_6256(), f_1335_6304_6326(argument), false, true, f_1335_6391_6466(f_1335_6410_6439(f_1335_6410_6429(this)), f_1335_6441_6465(argument)))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,6612,8375) || true) && (parameter != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1335,6612,8375);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,6822,7595) || true) && (f_1335_6826_6879(f_1335_6826_6841(), f_1335_6854_6878(f_1335_6854_6873(parameter))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1335,6822,7595);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,6929,7521);

ParameterBindingException 
bindingException =
f_1335_7003_7520(ErrorCategory.InvalidArgument, f_1335_7131_7150(this), f_1335_7185_7218(this, argument), f_1335_7253_7275(argument), null, null, f_1335_7388_7432(), nameof(ParameterBinderStrings.ParameterAlreadyBound))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,7549,7572);

throw bindingException;
DynAbs.Tracing.TraceSender.TraceExitCondition(1335,6822,7595);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,7619,7709);

f_1335_7619_7708(this, uint.MaxValue, argument, parameter, ParameterBindingFlags.ShouldCoerceType);
DynAbs.Tracing.TraceSender.TraceExitCondition(1335,6612,8375);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1335,6612,8375);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,7751,8375) || true) && (f_1335_7755_7850(f_1335_7755_7777(argument), Language.Parser.VERBATIM_PARAMETERNAME, StringComparison.Ordinal))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1335,7751,8375);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,8157,8253);

f_1335_8157_8252(f_1335_8157_8201(f_1335_8157_8179()), f_1335_8229_8251(argument));
DynAbs.Tracing.TraceSender.TraceExitCondition(1335,7751,8375);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1335,7751,8375);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,8335,8356);

f_1335_8335_8355(                    result, argument);
DynAbs.Tracing.TraceSender.TraceExitCondition(1335,7751,8375);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1335,6612,8375);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1335,5781,8390);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1335,1,2610);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1335,1,2610);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,8406,8420);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1335,5534,8431);

System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
f_1335_5722_5764()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 5722, 5764);
return return_v;
}


bool
f_1335_5874_5906_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 5874, 5906);
return return_v;
}


int
f_1335_5948_5968(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
this_param,System.Management.Automation.CommandParameterInternal
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 5948, 5968);
return 0;
}


System.Management.Automation.MergedCommandParameterMetadata
f_1335_6238_6256()
{
var return_v = BindableParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 6238, 6256);
return return_v;
}


string
f_1335_6304_6326(System.Management.Automation.CommandParameterInternal
this_param)
{
var return_v = this_param.ParameterName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 6304, 6326);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1335_6410_6429(System.Management.Automation.ScriptParameterBinderController
this_param)
{
var return_v = this_param.InvocationInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 6410, 6429);
return return_v;
}


System.Management.Automation.CommandInfo
f_1335_6410_6439(System.Management.Automation.InvocationInfo
this_param)
{
var return_v = this_param.MyCommand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 6410, 6439);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1335_6441_6465(System.Management.Automation.CommandParameterInternal
this_param)
{
var return_v = this_param.ParameterExtent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 6441, 6465);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1335_6391_6466(System.Management.Automation.CommandInfo
commandInfo,System.Management.Automation.Language.IScriptExtent
scriptPosition)
{
var return_v = new System.Management.Automation.InvocationInfo( commandInfo, scriptPosition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 6391, 6466);
return return_v;
}


System.Management.Automation.MergedCompiledCommandParameter
f_1335_6238_6467(System.Management.Automation.MergedCommandParameterMetadata
this_param,string
name,bool
throwOnParameterNotFound,bool
tryExactMatching,System.Management.Automation.InvocationInfo
invocationInfo)
{
var return_v = this_param.GetMatchingParameter( name, throwOnParameterNotFound, tryExactMatching, invocationInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 6238, 6467);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
f_1335_6826_6841()
{
var return_v = BoundParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 6826, 6841);
return return_v;
}


System.Management.Automation.CompiledCommandParameter
f_1335_6854_6873(System.Management.Automation.MergedCompiledCommandParameter
this_param)
{
var return_v = this_param.Parameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 6854, 6873);
return return_v;
}


string
f_1335_6854_6878(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 6854, 6878);
return return_v;
}


bool
f_1335_6826_6879(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
this_param,string
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 6826, 6879);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1335_7131_7150(System.Management.Automation.ScriptParameterBinderController
this_param)
{
var return_v = this_param.InvocationInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 7131, 7150);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1335_7185_7218(System.Management.Automation.ScriptParameterBinderController
this_param,System.Management.Automation.CommandParameterInternal
cpi)
{
var return_v = this_param.GetParameterErrorExtent( cpi);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 7185, 7218);
return return_v;
}


string
f_1335_7253_7275(System.Management.Automation.CommandParameterInternal
this_param)
{
var return_v = this_param.ParameterName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 7253, 7275);
return return_v;
}


string
f_1335_7388_7432()
{
var return_v =                                 ParameterBinderStrings.ParameterAlreadyBound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 7388, 7432);
return return_v;
}


System.Management.Automation.ParameterBindingException
f_1335_7003_7520(System.Management.Automation.ErrorCategory
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
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 7003, 7520);
return return_v;
}


bool
f_1335_7619_7708(System.Management.Automation.ScriptParameterBinderController
this_param,uint
parameterSets,System.Management.Automation.CommandParameterInternal
argument,System.Management.Automation.MergedCompiledCommandParameter
parameter,System.Management.Automation.ParameterBindingFlags
flags)
{
var return_v = this_param.BindParameter( parameterSets, argument, parameter, flags);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 7619, 7708);
return return_v;
}


string
f_1335_7755_7777(System.Management.Automation.CommandParameterInternal
this_param)
{
var return_v = this_param.ParameterName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 7755, 7777);
return return_v;
}


bool
f_1335_7755_7850(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 7755, 7850);
return return_v;
}


System.Management.Automation.ParameterBinderBase
f_1335_8157_8179()
{
var return_v = DefaultParameterBinder;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 8157, 8179);
return return_v;
}


System.Management.Automation.CommandLineParameters
f_1335_8157_8201(System.Management.Automation.ParameterBinderBase
this_param)
{
var return_v = this_param.CommandLineParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 8157, 8201);
return return_v;
}


object
f_1335_8229_8251(System.Management.Automation.CommandParameterInternal
this_param)
{
var return_v = this_param.ArgumentValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 8229, 8251);
return return_v;
}


int
f_1335_8157_8252(System.Management.Automation.CommandLineParameters
this_param,object
obj)
{
this_param.SetImplicitUsingParameters( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 8157, 8252);
return 0;
}


int
f_1335_8335_8355(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
this_param,System.Management.Automation.CommandParameterInternal
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 8335, 8355);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
f_1335_5827_5836_I(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 5827, 5836);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1335,5534,8431);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1335,5534,8431);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void HandleRemainingArguments(Collection<CommandParameterInternal> arguments)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1335,8823,13039);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,8933,8972);

List<object> 
args = f_1335_8953_8971()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,8988,12794);
foreach(CommandParameterInternal parameter in f_1335_9035_9044_I(arguments) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1335,8988,12794);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,9078,9157);

object 
argValue = (DynAbs.Tracing.TraceSender.Conditional_F1(1335, 9096, 9123)||((f_1335_9096_9123(parameter)&&DynAbs.Tracing.TraceSender.Conditional_F2(1335, 9126, 9149))||DynAbs.Tracing.TraceSender.Conditional_F3(1335, 9152, 9156)))?f_1335_9126_9149(parameter):null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,10973,11633) || true) && (f_1335_10977_11016(parameter)&&(DynAbs.Tracing.TraceSender.Expression_True(1335, 10977, 11116)&&f_1335_11041_11116(f_1335_11041_11064(parameter), "$args", StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1335,10973,11633);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,11331,11581) || true) && (argValue is object[])
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1335,11331,11581);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,11405,11441);

f_1335_11405_11440(                        args, argValue as object[]);
DynAbs.Tracing.TraceSender.TraceExitCondition(1335,11331,11581);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1335,11331,11581);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,11539,11558);

f_1335_11539_11557(                        args, argValue);
DynAbs.Tracing.TraceSender.TraceExitCondition(1335,11331,11581);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,11605,11614);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1335,10973,11633);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,11653,12648) || true) && (f_1335_11657_11689(parameter))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1335,11653,12648);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,12034,12118);

var 
parameterText = f_1335_12054_12117(f_1335_12067_12116(f_1335_12078_12115(f_1335_12078_12101(parameter))))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,12140,12581) || true) && (f_1335_12144_12214(f_1335_12144_12168(parameterText), NotePropertyNameForSplattingParametersInArgs)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1335,12140,12581);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,12272,12489);

var 
noteProperty = new PSNoteProperty(NotePropertyNameForSplattingParametersInArgs,
f_1335_12419_12442(parameter))
                        { IsHidden = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true,1335,12291,12488) }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,12515,12558);

f_1335_12515_12557(f_1335_12515_12539(parameterText), noteProperty);
DynAbs.Tracing.TraceSender.TraceExitCondition(1335,12140,12581);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,12605,12629);

f_1335_12605_12628(
                    args, parameterText);
DynAbs.Tracing.TraceSender.TraceExitCondition(1335,11653,12648);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,12668,12779) || true) && (f_1335_12672_12699(parameter))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1335,12668,12779);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,12741,12760);

f_1335_12741_12759(                    args, argValue);
DynAbs.Tracing.TraceSender.TraceExitCondition(1335,12668,12779);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1335,8988,12794);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1335,1,3807);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1335,1,3807);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,12810,12846);

object[] 
argsArray = f_1335_12831_12845(args)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,12862,12958);

f_1335_12862_12957(f_1335_12862_12884(), SpecialVariables.Args, argsArray, parameterMetadata: null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,12974,13005);

f_1335_12974_13004(f_1335_12974_12984(), argsArray);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,13021,13028);

return;
DynAbs.Tracing.TraceSender.TraceExitMethod(1335,8823,13039);

System.Collections.Generic.List<object>
f_1335_8953_8971()
{
var return_v = new System.Collections.Generic.List<object>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 8953, 8971);
return return_v;
}


bool
f_1335_9096_9123(System.Management.Automation.CommandParameterInternal
this_param)
{
var return_v = this_param.ArgumentSpecified ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 9096, 9123);
return return_v;
}


object
f_1335_9126_9149(System.Management.Automation.CommandParameterInternal
this_param)
{
var return_v = this_param.ArgumentValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 9126, 9149);
return return_v;
}


bool
f_1335_10977_11016(System.Management.Automation.CommandParameterInternal
this_param)
{
var return_v = this_param.ParameterAndArgumentSpecified ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 10977, 11016);
return return_v;
}


string
f_1335_11041_11064(System.Management.Automation.CommandParameterInternal
this_param)
{
var return_v = this_param.ParameterName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 11041, 11064);
return return_v;
}


bool
f_1335_11041_11116(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 11041, 11116);
return return_v;
}


int
f_1335_11405_11440(System.Collections.Generic.List<object>
this_param,object[]
collection)
{
this_param.AddRange( (System.Collections.Generic.IEnumerable<object>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 11405, 11440);
return 0;
}


int
f_1335_11539_11557(System.Collections.Generic.List<object>
this_param,object
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 11539, 11557);
return 0;
}


bool
f_1335_11657_11689(System.Management.Automation.CommandParameterInternal
this_param)
{
var return_v = this_param.ParameterNameSpecified;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 11657, 11689);
return return_v;
}


string
f_1335_12078_12101(System.Management.Automation.CommandParameterInternal
this_param)
{
var return_v = this_param.ParameterText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 12078, 12101);
return return_v;
}


char[]
f_1335_12078_12115(string
this_param)
{
var return_v = this_param.ToCharArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 12078, 12115);
return return_v;
}


string
f_1335_12067_12116(char[]
value)
{
var return_v = new string( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 12067, 12116);
return return_v;
}


System.Management.Automation.PSObject
f_1335_12054_12117(string
obj)
{
var return_v = new System.Management.Automation.PSObject( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 12054, 12117);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1335_12144_12168(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 12144, 12168);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1335_12144_12214(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 12144, 12214);
return return_v;
}


string
f_1335_12419_12442(System.Management.Automation.CommandParameterInternal
this_param)
{
var return_v = this_param.ParameterName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 12419, 12442);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1335_12515_12539(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 12515, 12539);
return return_v;
}


int
f_1335_12515_12557(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 12515, 12557);
return 0;
}


int
f_1335_12605_12628(System.Collections.Generic.List<object>
this_param,System.Management.Automation.PSObject
item)
{
this_param.Add( (object)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 12605, 12628);
return 0;
}


bool
f_1335_12672_12699(System.Management.Automation.CommandParameterInternal
this_param)
{
var return_v = this_param.ArgumentSpecified;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 12672, 12699);
return return_v;
}


int
f_1335_12741_12759(System.Collections.Generic.List<object>
this_param,object
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 12741, 12759);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
f_1335_9035_9044_I(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 9035, 9044);
return return_v;
}


object[]
f_1335_12831_12845(System.Collections.Generic.List<object>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 12831, 12845);
return return_v;
}


System.Management.Automation.ParameterBinderBase
f_1335_12862_12884()
{
var return_v = DefaultParameterBinder;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 12862, 12884);
return return_v;
}


int
f_1335_12862_12957(System.Management.Automation.ParameterBinderBase
this_param,string
name,object[]
value,System.Management.Automation.CompiledCommandParameter
parameterMetadata)
{
this_param.BindParameter( name, (object)value, parameterMetadata: parameterMetadata);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 12862, 12957);
return 0;
}


System.Collections.Generic.List<object>
f_1335_12974_12984()
{
var return_v = DollarArgs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 12974, 12984);
return return_v;
}


int
f_1335_12974_13004(System.Collections.Generic.List<object>
this_param,object[]
collection)
{
this_param.AddRange( (System.Collections.Generic.IEnumerable<object>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 12974, 13004);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1335,8823,13039);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1335,8823,13039);
}
		}

internal const string 
NotePropertyNameForSplattingParametersInArgs = "<CommandParameterName>"
;

static ScriptParameterBinderController()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1335,458,13152);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1335,13073,13144);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1335,458,13152);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1335,458,13152);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1335,458,13152);

static System.Management.Automation.ScriptParameterBinder
f_1335_1647_1726(System.Management.Automation.ScriptBlock
script,System.Management.Automation.InvocationInfo
invocationInfo,System.Management.Automation.ExecutionContext
context,System.Management.Automation.Internal.InternalCommand
command,System.Management.Automation.SessionStateScope
localScope)
{
var return_v = new System.Management.Automation.ScriptParameterBinder( script, invocationInfo, context, command, localScope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 1647, 1726);
return return_v;
}


System.Collections.Generic.List<object>
f_1335_1770_1788()
{
var return_v = new System.Collections.Generic.List<object>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 1770, 1788);
return return_v;
}


bool
f_1335_1948_1975(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.HasDynamicParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 1948, 1975);
return return_v;
}


System.Management.Automation.MergedCommandParameterMetadata
f_1335_2029_2052(System.Management.Automation.ScriptParameterBinderController
this_param)
{
var return_v = this_param.BindableParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 2029, 2052);
return return_v;
}


System.Management.Automation.MergedCommandParameterMetadata
f_1335_2069_2093(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.ParameterMetadata;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 2069, 2093);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
f_1335_2029_2094(System.Management.Automation.MergedCommandParameterMetadata
this_param,System.Management.Automation.MergedCommandParameterMetadata
metadata)
{
var return_v = this_param.ReplaceMetadata( metadata);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 2029, 2094);
return return_v;
}


System.Management.Automation.MergedCommandParameterMetadata
f_1335_2183_2207(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.ParameterMetadata;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 2183, 2207);
return return_v;
}


System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
f_1335_2287_2325(System.Management.Automation.MergedCommandParameterMetadata
this_param)
{
var return_v = this_param.BindableParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 2287, 2325);
return return_v;
}


System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>
f_1335_2287_2332(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
this_param)
{
var return_v = this_param.Values;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1335, 2287, 2332);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
f_1335_2246_2333(System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>
collection)
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>( (System.Collections.Generic.IEnumerable<System.Management.Automation.MergedCompiledCommandParameter>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1335, 2246, 2333);
return return_v;
}


static System.Management.Automation.InvocationInfo
f_1335_1622_1636_C(System.Management.Automation.InvocationInfo
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1335, 1363, 2360);
return return_v;
}

}
}
