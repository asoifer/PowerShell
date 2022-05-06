// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;
using System.Management.Automation.Runspaces;

namespace System.Management.Automation
{
public class ScriptInfo : CommandInfo, IScriptCommandInfo
{
internal ScriptInfo(string name, ScriptBlock script, ExecutionContext context)
:base(f_1333_1122_1126_C(name) ,CommandTypes.Script,context)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1333,1023,1353);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1333,2394,2446);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1333,4021,4037);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1333,1182,1300) || true) && (script == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1333,1182,1300);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1333,1234,1285);

throw f_1333_1240_1284("script");
DynAbs.Tracing.TraceSender.TraceExitCondition(1333,1182,1300);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1333,1316,1342);

this.ScriptBlock = script;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1333,1023,1353);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1333,1023,1353);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1333,1023,1353);
}
		}

internal ScriptInfo(ScriptInfo other)
:base(f_1333_1543_1548_C(other) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1333,1485,1622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1333,2394,2446);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1333,4021,4037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1333,1574,1611);

this.ScriptBlock = f_1333_1593_1610(other);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1333,1485,1622);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1333,1485,1622);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1333,1485,1622);
}
		}

internal override CommandInfo CreateGetCommandCopy(object[] argumentList)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1333,1863,2091);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1333,1961,2054);

ScriptInfo 
copy = new ScriptInfo(this) { IsGetCommandCopy = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true,1333,1979,2053),Arguments = argumentList }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1333,2068,2080);

return copy;
DynAbs.Tracing.TraceSender.TraceExitMethod(1333,1863,2091);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1333,1863,2091);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1333,1863,2091);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override HelpCategory HelpCategory
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1333,2198,2240);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1333,2204,2238);

return HelpCategory.ScriptCommand;
DynAbs.Tracing.TraceSender.TraceExitMethod(1333,2198,2240);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1333,2130,2251);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1333,2130,2251);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public ScriptBlock ScriptBlock {get; private set; }

public override string Definition
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1333,2706,2787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1333,2742,2772);

return f_1333_2749_2771(f_1333_2749_2760());
DynAbs.Tracing.TraceSender.TraceExitMethod(1333,2706,2787);

System.Management.Automation.ScriptBlock
f_1333_2749_2760()
{
var return_v = ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1333, 2749, 2760);
return return_v;
}


string
f_1333_2749_2771(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1333, 2749, 2771);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1333,2648,2798);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1333,2648,2798);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override ReadOnlyCollection<PSTypeName> OutputType
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1333,3005,3043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1333,3011,3041);

return f_1333_3018_3040(f_1333_3018_3029());
DynAbs.Tracing.TraceSender.TraceExitMethod(1333,3005,3043);

System.Management.Automation.ScriptBlock
f_1333_3018_3029()
{
var return_v = ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1333, 3018, 3029);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
f_1333_3018_3040(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.OutputType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1333, 3018, 3040);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1333,2923,3054);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1333,2923,3054);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override string ToString()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1333,3184,3283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1333,3242,3272);

return f_1333_3249_3271(f_1333_3249_3260());
DynAbs.Tracing.TraceSender.TraceExitMethod(1333,3184,3283);

System.Management.Automation.ScriptBlock
f_1333_3249_3260()
{
var return_v = ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1333, 3249, 3260);
return return_v;
}


string
f_1333_3249_3271(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1333, 3249, 3271);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1333,3184,3283);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1333,3184,3283);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool ImplementsDynamicParameters
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1333,3491,3539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1333,3497,3537);

return f_1333_3504_3536(f_1333_3504_3515());
DynAbs.Tracing.TraceSender.TraceExitMethod(1333,3491,3539);

System.Management.Automation.ScriptBlock
f_1333_3504_3515()
{
var return_v = ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1333, 3504, 3515);
return return_v;
}


bool
f_1333_3504_3536(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.HasDynamicParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1333, 3504, 3536);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1333,3416,3550);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1333,3416,3550);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override CommandMetadata CommandMetadata
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1333,3733,3974);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1333,3769,3959);

return _commandMetadata ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.CommandMetadata>(1333, 3776, 3958)??                       (_commandMetadata =
f_1333_3865_3957(f_1333_3885_3901(this), f_1333_3903_3912(this), f_1333_3914_3956())));
DynAbs.Tracing.TraceSender.TraceExitMethod(1333,3733,3974);

System.Management.Automation.ScriptBlock
f_1333_3885_3901(System.Management.Automation.ScriptInfo
this_param)
{
var return_v = this_param.ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1333, 3885, 3901);
return return_v;
}


string
f_1333_3903_3912(System.Management.Automation.ScriptInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1333, 3903, 3912);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1333_3914_3956()
{
var return_v = LocalPipeline.GetExecutionContextFromTLS();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1333, 3914, 3956);
return return_v;
}


System.Management.Automation.CommandMetadata
f_1333_3865_3957(System.Management.Automation.ScriptBlock
scriptblock,string
commandName,System.Management.Automation.ExecutionContext
context)
{
var return_v = new System.Management.Automation.CommandMetadata( scriptblock, commandName, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1333, 3865, 3957);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1333,3659,3985);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1333,3659,3985);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private CommandMetadata _commandMetadata;

static ScriptInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1333,360,4045);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1333,360,4045);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1333,360,4045);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1333,360,4045);

System.Management.Automation.PSArgumentException
f_1333_1240_1284(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1333, 1240, 1284);
return return_v;
}


static string
f_1333_1122_1126_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1333, 1023, 1353);
return return_v;
}


System.Management.Automation.ScriptBlock
f_1333_1593_1610(System.Management.Automation.ScriptInfo
this_param)
{
var return_v = this_param.ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1333, 1593, 1610);
return return_v;
}


static System.Management.Automation.CommandInfo
f_1333_1543_1548_C(System.Management.Automation.CommandInfo
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1333, 1485, 1622);
return return_v;
}

}
}
