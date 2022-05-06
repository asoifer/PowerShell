// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation
{
internal class QuestionMarkVariable : PSVariable
{
internal QuestionMarkVariable(ExecutionContext context)
:base(f_1327_578_603_C(SpecialVariables.Question) ,true,ScopedItemOptions.ReadOnly | ScopedItemOptions.AllScope,f_1327_668_702())
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1327,502,758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1327,804,812);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1327,728,747);

_context = context;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1327,502,758);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1327,502,758);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1327,502,758);
}
		}

private readonly ExecutionContext _context;

public override object Value
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1327,978,1117);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1327,1014,1042);

f_1327_1014_1041(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1327,1060,1102);

return f_1327_1067_1101(_context);
DynAbs.Tracing.TraceSender.TraceExitMethod(1327,978,1117);

int
f_1327_1014_1041(System.Management.Automation.QuestionMarkVariable
this_param)
{
this_param.DebuggerCheckVariableRead();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1327, 1014, 1041);
return 0;
}


bool
f_1327_1067_1101(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.QuestionMarkVariableValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1327, 1067, 1101);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1327,925,1307);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1327,925,1307);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1327,1133,1296);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1327,1262,1281);

base.Value = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1327,1133,1296);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1327,925,1307);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1327,925,1307);
}
		}}

static QuestionMarkVariable()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1327,225,1314);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1327,225,1314);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1327,225,1314);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1327,225,1314);

static string
f_1327_668_702()
{
var return_v = RunspaceInit.DollarHookDescription;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1327, 668, 702);
return return_v;
}


static string
f_1327_578_603_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1327, 502, 758);
return return_v;
}

}
}

