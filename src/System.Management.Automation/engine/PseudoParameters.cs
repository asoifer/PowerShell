// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Management.Automation
{
public class RuntimeDefinedParameter
{
public RuntimeDefinedParameter()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1325,1078,1132);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,3406,3426);
this._name = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,4189,4203);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,4769,4775);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,4904,4935);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,5204,5283);
this.Attributes = f_1325_5255_5282();DynAbs.Tracing.TraceSender.TraceExitConstructor(1325,1078,1132);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1325,1078,1132);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1325,1078,1132);
}
		}

public RuntimeDefinedParameter(string name, Type parameterType, Collection<Attribute> attributes)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1325,2167,2765);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,3406,3426);
this._name = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,4189,4203);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,4769,4775);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,4904,4935);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,5204,5283);
this.Attributes = f_1325_5255_5282();
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,2289,2417) || true) && (f_1325_2293_2319(name))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1325,2289,2417);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,2353,2402);

throw f_1325_2359_2401("name");
DynAbs.Tracing.TraceSender.TraceExitCondition(1325,2289,2417);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,2433,2569) || true) && (parameterType == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1325,2433,2569);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,2492,2554);

throw f_1325_2498_2553("parameterType");
DynAbs.Tracing.TraceSender.TraceExitCondition(1325,2433,2569);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,2585,2598);

_name = name;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,2612,2643);

_parameterType = parameterType;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,2659,2754) || true) && (attributes != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1325,2659,2754);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,2715,2739);

Attributes = attributes;
DynAbs.Tracing.TraceSender.TraceExitCondition(1325,2659,2754);
}
DynAbs.Tracing.TraceSender.TraceExitConstructor(1325,2167,2765);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1325,2167,2765);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1325,2167,2765);
}
		}

public string Name
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1325,3062,3126);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,3098,3111);

return _name;
DynAbs.Tracing.TraceSender.TraceExitMethod(1325,3062,3126);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1325,3019,3379);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1325,3019,3379);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1325,3142,3368);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,3178,3319) || true) && (f_1325_3182_3209(value))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1325,3178,3319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,3251,3300);

throw f_1325_3257_3299("name");
DynAbs.Tracing.TraceSender.TraceExitCondition(1325,3178,3319);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,3339,3353);

_name = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1325,3142,3368);

bool
f_1325_3182_3209(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1325, 3182, 3209);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1325_3257_3299(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1325, 3257, 3299);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1325,3019,3379);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1325,3019,3379);
}
		}}

private string _name ;

public Type ParameterType
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1325,3838,3911);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,3874,3896);

return _parameterType;
DynAbs.Tracing.TraceSender.TraceExitMethod(1325,3838,3911);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1325,3788,4164);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1325,3788,4164);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1325,3927,4153);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,3963,4095) || true) && (value == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1325,3963,4095);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,4022,4076);

throw f_1325_4028_4075("value");
DynAbs.Tracing.TraceSender.TraceExitCondition(1325,3963,4095);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,4115,4138);

_parameterType = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1325,3927,4153);

System.Management.Automation.PSArgumentNullException
f_1325_4028_4075(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1325, 4028, 4075);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1325,3788,4164);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1325,3788,4164);
}
		}}

private Type _parameterType;

public object Value
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1325,4548,4613);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,4584,4598);

return _value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1325,4548,4613);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1325,4504,4742);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1325,4504,4742);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1325,4629,4731);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,4665,4683);

this.IsSet = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,4701,4716);

_value = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1325,4629,4731);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1325,4504,4742);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1325,4504,4742);
}
		}}

private object _value;

public bool IsSet {get; set; }

public Collection<Attribute> Attributes {get; }

internal bool IsDisabled()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1325,5434,6451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,5485,5520);

bool 
hasParameterAttribute = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,5534,5572);

bool 
hasEnabledParamAttribute = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,5586,5619);

bool 
hasSeenExpAttribute = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,5635,6220);
foreach(Attribute attr in f_1325_5662_5672_I(f_1325_5662_5672()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1325,5635,6220);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,5706,6205) || true) && (!hasSeenExpAttribute &&(DynAbs.Tracing.TraceSender.Expression_True(1325, 5710, 5776)&&attr is ExperimentalAttribute expAttribute))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1325,5706,6205);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,5818,5859) || true) && (f_1325_5822_5841(expAttribute))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1325,5818,5859);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,5845,5857);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1325,5818,5859);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,5883,5910);

hasSeenExpAttribute = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1325,5706,6205);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1325,5706,6205);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,5952,6205) || true) && (attr is ParameterAttribute paramAttribute)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1325,5952,6205);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,6039,6068);

hasParameterAttribute = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,6090,6130) || true) && (f_1325_6094_6115(paramAttribute))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1325,6090,6130);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,6119,6128);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1325,6090,6130);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,6154,6186);

hasEnabledParamAttribute = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1325,5952,6205);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1325,5706,6205);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1325,5635,6220);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1325,1,586);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1325,1,586);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,6382,6440);

return hasParameterAttribute &&(DynAbs.Tracing.TraceSender.Expression_True(1325, 6389, 6439)&&!hasEnabledParamAttribute);
DynAbs.Tracing.TraceSender.TraceExitMethod(1325,5434,6451);

System.Collections.ObjectModel.Collection<System.Attribute>
f_1325_5662_5672()
{
var return_v = Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1325, 5662, 5672);
return return_v;
}


bool
f_1325_5822_5841(System.Management.Automation.ExperimentalAttribute
this_param)
{
var return_v = this_param.ToHide;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1325, 5822, 5841);
return return_v;
}


bool
f_1325_6094_6115(System.Management.Automation.ParameterAttribute
this_param)
{
var return_v = this_param.ToHide;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1325, 6094, 6115);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1325_5662_5672_I(System.Collections.ObjectModel.Collection<System.Attribute>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1325, 5662, 5672);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1325,5434,6451);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1325,5434,6451);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static RuntimeDefinedParameter()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1325,916,6458);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1325,916,6458);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1325,916,6458);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1325,916,6458);

bool
f_1325_2293_2319(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1325, 2293, 2319);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1325_2359_2401(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1325, 2359, 2401);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1325_2498_2553(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1325, 2498, 2553);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1325_5255_5282()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Attribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1325, 5255, 5282);
return return_v;
}

}
[Serializable]
    public class RuntimeDefinedParameterDictionary : Dictionary<string, RuntimeDefinedParameter>
{
public RuntimeDefinedParameterDictionary()
:base(f_1325_7523_7555_C(f_1325_7523_7555()) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1325,7460,7578);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,7907,7931);
this._helpFile = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,8078,8110);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1325,7460,7578);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1325,7460,7578);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1325,7460,7578);
}
		}

public string HelpFile
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1325,7757,7782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,7763,7780);

return _helpFile;
DynAbs.Tracing.TraceSender.TraceExitMethod(1325,7757,7782);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1325,7710,7880);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1325,7710,7880);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1325,7798,7869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,7804,7867);

_helpFile = (DynAbs.Tracing.TraceSender.Conditional_F1(1325, 7816, 7843)||((f_1325_7816_7843(value)&&DynAbs.Tracing.TraceSender.Conditional_F2(1325, 7846, 7858))||DynAbs.Tracing.TraceSender.Conditional_F3(1325, 7861, 7866)))?string.Empty :value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1325,7798,7869);

bool
f_1325_7816_7843(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1325, 7816, 7843);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1325,7710,7880);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1325,7710,7880);
}
		}}

private string _helpFile ;

public object Data {get; set; }

internal static RuntimeDefinedParameter[] EmptyParameterArray ;

static RuntimeDefinedParameterDictionary()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1325,7202,8224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1325,8164,8216);
EmptyParameterArray = new RuntimeDefinedParameter[0];DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1325,7202,8224);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1325,7202,8224);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1325,7202,8224);

static System.StringComparer
f_1325_7523_7555()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1325, 7523, 7555);
return return_v;
}


static System.Collections.Generic.IEqualityComparer<string>
f_1325_7523_7555_C(System.Collections.Generic.IEqualityComparer<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1325, 7460, 7578);
return return_v;
}

}
}
