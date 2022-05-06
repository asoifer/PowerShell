// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Management.Automation.Internal;
using System.Reflection;

namespace System.Management.Automation.Language
{
internal class IsConstantValueVisitor : ICustomAstVisitor2
{
public static bool IsConstant(Ast ast, out object constantValue, bool forAttribute = false, bool forRequires = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1546,708,2013);
            try
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,886,1667) || true) && ((bool)f_1546_896_1019(ast, new IsConstantValueVisitor { CheckingAttributeArgument = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => forAttribute,1546,907,1018),CheckingRequiresArgument = forRequires }))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1546,886,1667);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,1061,1085);

Ast 
parent = f_1546_1074_1084(ast)
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,1107,1373) || true) && (parent != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1546,1107,1373);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,1178,1299) || true) && (parent is DataStatementAst)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1546,1178,1299);
DynAbs.Tracing.TraceSender.TraceBreak(1546,1266,1272);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1546,1178,1299);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,1327,1350);

parent = f_1546_1336_1349(parent);
DynAbs.Tracing.TraceSender.TraceExitCondition(1546,1107,1373);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1546,1107,1373);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1546,1107,1373);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,1397,1648) || true) && (parent == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1546,1397,1648);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,1465,1587);

constantValue = f_1546_1481_1586(ast, new ConstantValueVisitor { AttributeArgument = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => forAttribute,1546,1492,1585),RequiresArgument = forRequires });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,1613,1625);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1546,1397,1648);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1546,886,1667);
}
            }
            catch (Exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1546,1696,1938);
DynAbs.Tracing.TraceSender.TraceExitCatch(1546,1696,1938);
                // If we get an exception, ignore it and assume the expression isn't constant.
                // This can happen, e.g. if a cast is invalid:
                //     [int]"zed"
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,1954,1975);

constantValue = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,1989,2002);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1546,708,2013);

object
f_1546_896_1019(System.Management.Automation.Language.Ast
this_param,System.Management.Automation.Language.IsConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 896, 1019);
return return_v;
}


System.Management.Automation.Language.Ast
f_1546_1074_1084(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 1074, 1084);
return return_v;
}


System.Management.Automation.Language.Ast
f_1546_1336_1349(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 1336, 1349);
return return_v;
}


object
f_1546_1481_1586(System.Management.Automation.Language.Ast
this_param,System.Management.Automation.Language.ConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 1481, 1586);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,708,2013);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,708,2013);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool CheckingAttributeArgument {get; set; }

internal bool CheckingClassAttributeArguments {get; set; }

internal bool CheckingRequiresArgument {get; set; }

public object VisitErrorStatement(ErrorStatementAst errorStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,2221,2309);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,2294,2307);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,2221,2309);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,2221,2309);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,2221,2309);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitErrorExpression(ErrorExpressionAst errorExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,2321,2412);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,2397,2410);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,2321,2412);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,2321,2412);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,2321,2412);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitScriptBlock(ScriptBlockAst scriptBlockAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,2424,2503);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,2488,2501);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,2424,2503);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,2424,2503);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,2424,2503);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitParamBlock(ParamBlockAst paramBlockAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,2515,2591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,2576,2589);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,2515,2591);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,2515,2591);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,2515,2591);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitNamedBlock(NamedBlockAst namedBlockAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,2603,2679);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,2664,2677);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,2603,2679);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,2603,2679);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,2603,2679);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTypeConstraint(TypeConstraintAst typeConstraintAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,2691,2779);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,2764,2777);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,2691,2779);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,2691,2779);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,2691,2779);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitAttribute(AttributeAst attributeAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,2791,2864);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,2849,2862);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,2791,2864);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,2791,2864);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,2791,2864);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitNamedAttributeArgument(NamedAttributeArgumentAst namedAttributeArgumentAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,2876,2988);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,2973,2986);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,2876,2988);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,2876,2988);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,2876,2988);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitParameter(ParameterAst parameterAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,3000,3073);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,3058,3071);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,3000,3073);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,3000,3073);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,3000,3073);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitFunctionDefinition(FunctionDefinitionAst functionDefinitionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,3085,3185);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,3170,3183);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,3085,3185);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,3085,3185);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,3085,3185);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitIfStatement(IfStatementAst ifStmtAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,3197,3271);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,3256,3269);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,3197,3271);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,3197,3271);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,3197,3271);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTrap(TrapStatementAst trapStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,3283,3359);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,3344,3357);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,3283,3359);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,3283,3359);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,3283,3359);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitSwitchStatement(SwitchStatementAst switchStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,3371,3462);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,3447,3460);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,3371,3462);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,3371,3462);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,3371,3462);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitDataStatement(DataStatementAst dataStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,3474,3559);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,3544,3557);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,3474,3559);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,3474,3559);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,3474,3559);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitForEachStatement(ForEachStatementAst forEachStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,3571,3665);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,3650,3663);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,3571,3665);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,3571,3665);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,3571,3665);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitDoWhileStatement(DoWhileStatementAst doWhileStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,3677,3771);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,3756,3769);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,3677,3771);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,3677,3771);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,3677,3771);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitForStatement(ForStatementAst forStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,3783,3865);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,3850,3863);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,3783,3865);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,3783,3865);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,3783,3865);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitWhileStatement(WhileStatementAst whileStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,3877,3965);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,3950,3963);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,3877,3965);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,3877,3965);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,3877,3965);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitCatchClause(CatchClauseAst catchClauseAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,3977,4056);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,4041,4054);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,3977,4056);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,3977,4056);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,3977,4056);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTryStatement(TryStatementAst tryStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,4068,4150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,4135,4148);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,4068,4150);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,4068,4150);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,4068,4150);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitBreakStatement(BreakStatementAst breakStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,4162,4250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,4235,4248);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,4162,4250);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,4162,4250);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,4162,4250);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitContinueStatement(ContinueStatementAst continueStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,4262,4359);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,4344,4357);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,4262,4359);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,4262,4359);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,4262,4359);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitReturnStatement(ReturnStatementAst returnStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,4371,4462);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,4447,4460);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,4371,4462);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,4371,4462);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,4371,4462);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitExitStatement(ExitStatementAst exitStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,4474,4559);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,4544,4557);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,4474,4559);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,4474,4559);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,4474,4559);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitThrowStatement(ThrowStatementAst throwStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,4571,4659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,4644,4657);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,4571,4659);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,4571,4659);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,4571,4659);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitDoUntilStatement(DoUntilStatementAst doUntilStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,4671,4765);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,4750,4763);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,4671,4765);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,4671,4765);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,4671,4765);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitAssignmentStatement(AssignmentStatementAst assignmentStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,4777,4880);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,4865,4878);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,4777,4880);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,4777,4880);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,4777,4880);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitCommand(CommandAst commandAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,4892,4959);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,4944,4957);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,4892,4959);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,4892,4959);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,4892,4959);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitCommandExpression(CommandExpressionAst commandExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,4971,5068);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,5053,5066);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,4971,5068);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,4971,5068);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,4971,5068);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitCommandParameter(CommandParameterAst commandParameterAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,5080,5174);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,5159,5172);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,5080,5174);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,5080,5174);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,5080,5174);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitFileRedirection(FileRedirectionAst fileRedirectionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,5186,5277);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,5262,5275);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,5186,5277);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,5186,5277);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,5186,5277);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitMergingRedirection(MergingRedirectionAst mergingRedirectionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,5289,5389);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,5374,5387);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,5289,5389);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,5289,5389);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,5289,5389);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitExpandableStringExpression(ExpandableStringExpressionAst expandableStringExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,5401,5525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,5510,5523);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,5401,5525);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,5401,5525);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,5401,5525);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitIndexExpression(IndexExpressionAst indexExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,5537,5628);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,5613,5626);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,5537,5628);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,5537,5628);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,5537,5628);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitAttributedExpression(AttributedExpressionAst attributedExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,5640,5746);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,5731,5744);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,5640,5746);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,5640,5746);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,5640,5746);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitBlockStatement(BlockStatementAst blockStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,5758,5846);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,5831,5844);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,5758,5846);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,5758,5846);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,5758,5846);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitInvokeMemberExpression(InvokeMemberExpressionAst invokeMemberExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,5858,5970);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,5955,5968);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,5858,5970);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,5858,5970);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,5858,5970);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTypeDefinition(TypeDefinitionAst typeDefinitionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,5982,6070);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,6055,6068);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,5982,6070);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,5982,6070);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,5982,6070);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitPropertyMember(PropertyMemberAst propertyMemberAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,6082,6170);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,6155,6168);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,6082,6170);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,6082,6170);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,6082,6170);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitFunctionMember(FunctionMemberAst functionMemberAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,6182,6270);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,6255,6268);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,6182,6270);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,6182,6270);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,6182,6270);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitBaseCtorInvokeMemberExpression(BaseCtorInvokeMemberExpressionAst baseCtorInvokeMemberExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,6282,6418);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,6403,6416);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,6282,6418);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,6282,6418);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,6282,6418);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitUsingStatement(UsingStatementAst usingStatement) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,6430,6515);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,6500,6513);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,6430,6515);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,6430,6515);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,6430,6515);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitConfigurationDefinition(ConfigurationDefinitionAst configurationDefinitionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,6527,6642);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,6627,6640);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,6527,6642);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,6527,6642);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,6527,6642);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitDynamicKeywordStatement(DynamicKeywordStatementAst dynamicKeywordAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,6654,6760);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,6745,6758);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,6654,6760);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,6654,6760);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,6654,6760);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitStatementBlock(StatementBlockAst statementBlockAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,6772,7143);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,6867,6917) || true) && (f_1546_6871_6894(statementBlockAst)!= null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1546,6867,6917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,6904,6917);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1546,6867,6917);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,6931,6988) || true) && (f_1546_6935_6969(f_1546_6935_6963(statementBlockAst))> 1)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1546,6931,6988);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,6975,6988);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1546,6931,6988);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,7002,7063);

var 
pipeline = f_1546_7017_7062(f_1546_7017_7045(statementBlockAst))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,7077,7132);

return pipeline != null &&(DynAbs.Tracing.TraceSender.Expression_True(1546, 7084, 7131)&&(bool)f_1546_7110_7131(pipeline, this));
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,6772,7143);

System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TrapStatementAst>
f_1546_6871_6894(System.Management.Automation.Language.StatementBlockAst
this_param)
{
var return_v = this_param.Traps ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 6871, 6894);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
f_1546_6935_6963(System.Management.Automation.Language.StatementBlockAst
this_param)
{
var return_v = this_param.Statements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 6935, 6963);
return return_v;
}


int
f_1546_6935_6969(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 6935, 6969);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
f_1546_7017_7045(System.Management.Automation.Language.StatementBlockAst
this_param)
{
var return_v = this_param.Statements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 7017, 7045);
return return_v;
}


System.Management.Automation.Language.StatementAst
f_1546_7017_7062(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
source)
{
var return_v = source.FirstOrDefault<System.Management.Automation.Language.StatementAst>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 7017, 7062);
return return_v;
}


object
f_1546_7110_7131(System.Management.Automation.Language.StatementAst
this_param,System.Management.Automation.Language.IsConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 7110, 7131);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,6772,7143);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,6772,7143);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitPipeline(PipelineAst pipelineAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,7155,7347);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,7232,7275);

var 
expr = f_1546_7243_7274(pipelineAst)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,7289,7336);

return expr != null &&(DynAbs.Tracing.TraceSender.Expression_True(1546, 7296, 7335)&&(bool)f_1546_7318_7335(expr, this));
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,7155,7347);

System.Management.Automation.Language.ExpressionAst
f_1546_7243_7274(System.Management.Automation.Language.PipelineAst
this_param)
{
var return_v = this_param.GetPureExpression();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 7243, 7274);
return return_v;
}


object
f_1546_7318_7335(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.IsConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 7318, 7335);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,7155,7347);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,7155,7347);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsNullDivisor(ExpressionAst operand)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1546,7359,8331);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,7440,7487);

var 
varExpr = operand as VariableExpressionAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,7501,7582) || true) && (varExpr == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1546,7501,7582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,7554,7567);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1546,7501,7582);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,7598,7649);

var 
parent = f_1546_7611_7625(operand)as BinaryExpressionAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,7663,7770) || true) && (parent == null ||(DynAbs.Tracing.TraceSender.Expression_False(1546, 7667, 7708)||f_1546_7685_7697(parent)!= operand))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1546,7663,7770);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,7742,7755);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1546,7663,7770);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,7786,8291);

switch (f_1546_7794_7809(parent))
            {

case TokenKind.Divide:
                case TokenKind.DivideEquals:
                case TokenKind.Rem:
                case TokenKind.RemainderEquals:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1546,7786,8291);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,8019,8070);

string 
name = f_1546_8033_8069(f_1546_8033_8053(varExpr))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,8092,8276);

return (f_1546_8100_8171(name, SpecialVariables.False, StringComparison.OrdinalIgnoreCase)||(DynAbs.Tracing.TraceSender.Expression_False(1546, 8100, 8274)||f_1546_8204_8274(                            name, SpecialVariables.Null, StringComparison.OrdinalIgnoreCase)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1546,7786,8291);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,8307,8320);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1546,7359,8331);

System.Management.Automation.Language.Ast
f_1546_7611_7625(System.Management.Automation.Language.ExpressionAst
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 7611, 7625);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1546_7685_7697(System.Management.Automation.Language.BinaryExpressionAst
this_param)
{
var return_v = this_param.Right ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 7685, 7697);
return return_v;
}


System.Management.Automation.Language.TokenKind
f_1546_7794_7809(System.Management.Automation.Language.BinaryExpressionAst
this_param)
{
var return_v = this_param.Operator;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 7794, 7809);
return return_v;
}


System.Management.Automation.VariablePath
f_1546_8033_8053(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.VariablePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 8033, 8053);
return return_v;
}


string
f_1546_8033_8069(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.UnqualifiedPath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 8033, 8069);
return return_v;
}


bool
f_1546_8100_8171(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 8100, 8171);
return return_v;
}


bool
f_1546_8204_8274(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 8204, 8274);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,7359,8331);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,7359,8331);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTernaryExpression(TernaryExpressionAst ternaryExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,8343,8656);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,8447,8645);

return (bool)f_1546_8460_8503(f_1546_8460_8490(ternaryExpressionAst), this)&&(DynAbs.Tracing.TraceSender.Expression_True(1546, 8454, 8573)&&                   (bool)f_1546_8533_8573(f_1546_8533_8560(ternaryExpressionAst), this))&&(DynAbs.Tracing.TraceSender.Expression_True(1546, 8454, 8644)&&                   (bool)f_1546_8603_8644(f_1546_8603_8631(ternaryExpressionAst), this));
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,8343,8656);

System.Management.Automation.Language.ExpressionAst
f_1546_8460_8490(System.Management.Automation.Language.TernaryExpressionAst
this_param)
{
var return_v = this_param.Condition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 8460, 8490);
return return_v;
}


object
f_1546_8460_8503(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.IsConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 8460, 8503);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1546_8533_8560(System.Management.Automation.Language.TernaryExpressionAst
this_param)
{
var return_v = this_param.IfTrue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 8533, 8560);
return return_v;
}


object
f_1546_8533_8573(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.IsConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 8533, 8573);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1546_8603_8631(System.Management.Automation.Language.TernaryExpressionAst
this_param)
{
var return_v = this_param.IfFalse;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 8603, 8631);
return return_v;
}


object
f_1546_8603_8644(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.IsConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 8603, 8644);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,8343,8656);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,8343,8656);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitBinaryExpression(BinaryExpressionAst binaryExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,8668,9027);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,8769,9016);

return f_1546_8776_8841(f_1546_8776_8804(binaryExpressionAst), TokenFlags.CanConstantFold)&&(DynAbs.Tracing.TraceSender.Expression_True(1546, 8776, 8905)&&                (bool)f_1546_8868_8905(f_1546_8868_8892(binaryExpressionAst), this))&&(DynAbs.Tracing.TraceSender.Expression_True(1546, 8776, 8953)&&(bool)f_1546_8915_8953(f_1546_8915_8940(binaryExpressionAst), this))&&(DynAbs.Tracing.TraceSender.Expression_True(1546, 8776, 9015)&&!f_1546_8975_9015(f_1546_8989_9014(binaryExpressionAst)));
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,8668,9027);

System.Management.Automation.Language.TokenKind
f_1546_8776_8804(System.Management.Automation.Language.BinaryExpressionAst
this_param)
{
var return_v = this_param.Operator;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 8776, 8804);
return return_v;
}


bool
f_1546_8776_8841(System.Management.Automation.Language.TokenKind
kind,System.Management.Automation.Language.TokenFlags
flag)
{
var return_v = kind.HasTrait( flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 8776, 8841);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1546_8868_8892(System.Management.Automation.Language.BinaryExpressionAst
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 8868, 8892);
return return_v;
}


object
f_1546_8868_8905(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.IsConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 8868, 8905);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1546_8915_8940(System.Management.Automation.Language.BinaryExpressionAst
this_param)
{
var return_v = this_param.Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 8915, 8940);
return return_v;
}


object
f_1546_8915_8953(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.IsConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 8915, 8953);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1546_8989_9014(System.Management.Automation.Language.BinaryExpressionAst
this_param)
{
var return_v = this_param.Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 8989, 9014);
return return_v;
}


bool
f_1546_8975_9015(System.Management.Automation.Language.ExpressionAst
operand)
{
var return_v = IsNullDivisor( operand);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 8975, 9015);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,8668,9027);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,8668,9027);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitUnaryExpression(UnaryExpressionAst unaryExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,9039,9285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,9137,9274);

return f_1546_9144_9209(f_1546_9144_9172(unaryExpressionAst), TokenFlags.CanConstantFold)&&(DynAbs.Tracing.TraceSender.Expression_True(1546, 9144, 9273)&&                (bool)f_1546_9236_9273(f_1546_9236_9260(unaryExpressionAst), this));
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,9039,9285);

System.Management.Automation.Language.TokenKind
f_1546_9144_9172(System.Management.Automation.Language.UnaryExpressionAst
this_param)
{
var return_v = this_param.TokenKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 9144, 9172);
return return_v;
}


bool
f_1546_9144_9209(System.Management.Automation.Language.TokenKind
kind,System.Management.Automation.Language.TokenFlags
flag)
{
var return_v = kind.HasTrait( flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 9144, 9209);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1546_9236_9260(System.Management.Automation.Language.UnaryExpressionAst
this_param)
{
var return_v = this_param.Child;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 9236, 9260);
return return_v;
}


object
f_1546_9236_9273(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.IsConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 9236, 9273);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,9039,9285);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,9039,9285);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitConvertExpression(ConvertExpressionAst convertExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,9297,9873);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,9401,9467);

var 
type = f_1546_9412_9466(f_1546_9412_9446(f_1546_9412_9437(convertExpressionAst)))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,9481,9559) || true) && (type == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1546,9481,9559);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,9531,9544);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1546,9481,9559);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,9575,9793) || true) && (!f_1546_9580_9602(type))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1546,9575,9793);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,9765,9778);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1546,9575,9793);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,9809,9862);

return (bool)f_1546_9822_9861(f_1546_9822_9848(convertExpressionAst), this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,9297,9873);

System.Management.Automation.Language.TypeConstraintAst
f_1546_9412_9437(System.Management.Automation.Language.ConvertExpressionAst
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 9412, 9437);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1546_9412_9446(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 9412, 9446);
return return_v;
}


System.Type
f_1546_9412_9466(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.GetReflectionType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 9412, 9466);
return return_v;
}


bool
f_1546_9580_9602(System.Type
type)
{
var return_v = type.IsSafePrimitive();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 9580, 9602);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1546_9822_9848(System.Management.Automation.Language.ConvertExpressionAst
this_param)
{
var return_v = this_param.Child;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 9822, 9848);
return return_v;
}


object
f_1546_9822_9861(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.IsConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 9822, 9861);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,9297,9873);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,9297,9873);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitConstantExpression(ConstantExpressionAst constantExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,9885,10015);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,9992,10004);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,9885,10015);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,9885,10015);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,9885,10015);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitStringConstantExpression(StringConstantExpressionAst stringConstantExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,10027,10175);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,10152,10164);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,10027,10175);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,10027,10175);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,10027,10175);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitSubExpression(SubExpressionAst subExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,10187,10341);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,10279,10330);

return f_1546_10286_10329(f_1546_10286_10316(subExpressionAst), this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,10187,10341);

System.Management.Automation.Language.StatementBlockAst
f_1546_10286_10316(System.Management.Automation.Language.SubExpressionAst
this_param)
{
var return_v = this_param.SubExpression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 10286, 10316);
return return_v;
}


object
f_1546_10286_10329(System.Management.Automation.Language.StatementBlockAst
this_param,System.Management.Automation.Language.IsConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 10286, 10329);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,10187,10341);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,10187,10341);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitUsingExpression(UsingExpressionAst usingExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,10353,10607);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,10543,10596);

return f_1546_10550_10595(f_1546_10550_10582(usingExpressionAst), this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,10353,10607);

System.Management.Automation.Language.ExpressionAst
f_1546_10550_10582(System.Management.Automation.Language.UsingExpressionAst
this_param)
{
var return_v = this_param.SubExpression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 10550, 10582);
return return_v;
}


object
f_1546_10550_10595(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.IsConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 10550, 10595);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,10353,10607);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,10353,10607);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitVariableExpression(VariableExpressionAst variableExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,10619,10787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,10726,10776);

return f_1546_10733_10775(variableExpressionAst);
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,10619,10787);

bool
f_1546_10733_10775(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.IsConstantVariable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 10733, 10775);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,10619,10787);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,10619,10787);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTypeExpression(TypeExpressionAst typeExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,10799,11252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,11133,11241);

return f_1546_11140_11165()||(DynAbs.Tracing.TraceSender.Expression_False(1546, 11140, 11240)||f_1546_11186_11232(f_1546_11186_11212(typeExpressionAst))!= null);
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,10799,11252);

bool
f_1546_11140_11165()
{
var return_v = CheckingAttributeArgument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 11140, 11165);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1546_11186_11212(System.Management.Automation.Language.TypeExpressionAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 11186, 11212);
return return_v;
}


System.Type
f_1546_11186_11232(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.GetReflectionType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 11186, 11232);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,10799,11252);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,10799,11252);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitMemberExpression(MemberExpressionAst memberExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,11264,12303);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,11365,11516) || true) && (f_1546_11369_11396_M(!memberExpressionAst.Static)||(DynAbs.Tracing.TraceSender.Expression_False(1546, 11369, 11454)||!(f_1546_11402_11432(memberExpressionAst)is TypeExpressionAst)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1546,11365,11516);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,11488,11501);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1546,11365,11516);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,11532,11624);

var 
type = f_1546_11543_11623(f_1546_11543_11603(((TypeExpressionAst)f_1546_11563_11593(memberExpressionAst))))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,11638,11716) || true) && (type == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1546,11638,11716);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,11688,11701);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1546,11638,11716);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,11732,11803);

var 
member = f_1546_11745_11771(memberExpressionAst)as StringConstantExpressionAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,11817,11897) || true) && (member == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1546,11817,11897);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,11869,11882);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1546,11817,11897);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,11913,12096);

var 
memberInfo = f_1546_11930_12095(type, f_1546_11945_11957(member), MemberTypes.Field, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,12110,12198) || true) && (f_1546_12114_12131(memberInfo)!= 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1546,12110,12198);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,12170,12183);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1546,12110,12198);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,12214,12292);

return (f_1546_12222_12259(((FieldInfo)memberInfo[0]))& FieldAttributes.Literal) != 0;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,11264,12303);

bool
f_1546_11369_11396_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 11369, 11396);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1546_11402_11432(System.Management.Automation.Language.MemberExpressionAst
this_param)
{
var return_v = this_param.Expression ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 11402, 11432);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1546_11563_11593(System.Management.Automation.Language.MemberExpressionAst
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 11563, 11593);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1546_11543_11603(System.Management.Automation.Language.TypeExpressionAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 11543, 11603);
return return_v;
}


System.Type
f_1546_11543_11623(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.GetReflectionType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 11543, 11623);
return return_v;
}


System.Management.Automation.Language.CommandElementAst
f_1546_11745_11771(System.Management.Automation.Language.MemberExpressionAst
this_param)
{
var return_v = this_param.Member ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 11745, 11771);
return return_v;
}


string
f_1546_11945_11957(System.Management.Automation.Language.StringConstantExpressionAst
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 11945, 11957);
return return_v;
}


System.Reflection.MemberInfo[]
f_1546_11930_12095(System.Type
this_param,string
name,System.Reflection.MemberTypes
type,System.Reflection.BindingFlags
bindingAttr)
{
var return_v = this_param.GetMember( name, type, bindingAttr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 11930, 12095);
return return_v;
}


int
f_1546_12114_12131(System.Reflection.MemberInfo[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 12114, 12131);
return return_v;
}


System.Reflection.FieldAttributes
f_1546_12222_12259(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.Attributes ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 12222, 12259);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,11264,12303);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,11264,12303);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitArrayExpression(ArrayExpressionAst arrayExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,12315,12437);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,12413,12426);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,12315,12437);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,12315,12437);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,12315,12437);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitArrayLiteral(ArrayLiteralAst arrayLiteralAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,12449,12861);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,12728,12850);

return (f_1546_12736_12761()||(DynAbs.Tracing.TraceSender.Expression_False(1546, 12736, 12789)||f_1546_12765_12789())) &&(DynAbs.Tracing.TraceSender.Expression_True(1546, 12735, 12849)&&f_1546_12794_12849(f_1546_12794_12818(arrayLiteralAst), e => (bool)e.Accept(this)));
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,12449,12861);

bool
f_1546_12736_12761()
{
var return_v = CheckingAttributeArgument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 12736, 12761);
return return_v;
}


bool
f_1546_12765_12789()
{
var return_v = CheckingRequiresArgument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 12765, 12789);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
f_1546_12794_12818(System.Management.Automation.Language.ArrayLiteralAst
this_param)
{
var return_v = this_param.Elements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 12794, 12818);
return return_v;
}


bool
f_1546_12794_12849(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
source,System.Func<System.Management.Automation.Language.ExpressionAst, bool>
predicate)
{
var return_v = source.All<System.Management.Automation.Language.ExpressionAst>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 12794, 12849);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,12449,12861);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,12449,12861);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitHashtable(HashtableAst hashtableAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,12873,13122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,12953,13111);

return f_1546_12960_12984()&&(DynAbs.Tracing.TraceSender.Expression_True(1546, 12960, 13110)&&f_1546_13008_13110(f_1546_13008_13034(hashtableAst), pair => (bool)pair.Item1.Accept(this) && (bool)pair.Item2.Accept(this)));
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,12873,13122);

bool
f_1546_12960_12984()
{
var return_v = CheckingRequiresArgument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 12960, 12984);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
f_1546_13008_13034(System.Management.Automation.Language.HashtableAst
this_param)
{
var return_v = this_param.KeyValuePairs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 13008, 13034);
return return_v;
}


bool
f_1546_13008_13110(System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
source,System.Func<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>, bool>
predicate)
{
var return_v = source.All<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 13008, 13110);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,12873,13122);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,12873,13122);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitScriptBlockExpression(ScriptBlockExpressionAst scriptBlockExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,13134,13718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,13638,13707);

return f_1546_13645_13670()&&(DynAbs.Tracing.TraceSender.Expression_True(1546, 13645, 13706)&&f_1546_13674_13706_M(!CheckingClassAttributeArguments));
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,13134,13718);

bool
f_1546_13645_13670()
{
var return_v = CheckingAttributeArgument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 13645, 13670);
return return_v;
}


bool
f_1546_13674_13706_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 13674, 13706);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,13134,13718);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,13134,13718);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitParenExpression(ParenExpressionAst parenExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,13730,13887);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,13828,13876);

return f_1546_13835_13875(f_1546_13835_13862(parenExpressionAst), this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,13730,13887);

System.Management.Automation.Language.PipelineBaseAst
f_1546_13835_13862(System.Management.Automation.Language.ParenExpressionAst
this_param)
{
var return_v = this_param.Pipeline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 13835, 13862);
return return_v;
}


object
f_1546_13835_13875(System.Management.Automation.Language.PipelineBaseAst
this_param,System.Management.Automation.Language.IsConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 13835, 13875);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,13730,13887);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,13730,13887);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public IsConstantValueVisitor()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1546,633,13894);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,2025,2078);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,2088,2147);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,2157,2209);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1546,633,13894);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,633,13894);
}


static IsConstantValueVisitor()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1546,633,13894);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1546,633,13894);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,633,13894);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1546,633,13894);
}
internal class ConstantValueVisitor : ICustomAstVisitor2
{
internal bool AttributeArgument {get; set; }

internal bool RequiresArgument {get; set; }

[Conditional("DEBUG")]
        [Conditional("ASSERTIONS_TRACE")]
        private void CheckIsConstant(Ast ast, string msg)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,14086,14434);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,14235,14423);

f_1546_14235_14422(f_1546_14278_14416(ast, new IsConstantValueVisitor { CheckingAttributeArgument = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1546_14346_14368(this),1546,14289,14415),CheckingRequiresArgument = f_1546_14397_14413()}), msg);
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,14086,14434);

bool
f_1546_14346_14368(System.Management.Automation.Language.ConstantValueVisitor
this_param)
{
var return_v = this_param.AttributeArgument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 14346, 14368);
return return_v;
}


bool
f_1546_14397_14413()
{
var return_v = RequiresArgument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 14397, 14413);
return return_v;
}


object
f_1546_14278_14416(System.Management.Automation.Language.Ast
this_param,System.Management.Automation.Language.IsConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 14278, 14416);
return return_v;
}


int
f_1546_14235_14422(object
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( (bool)condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 14235, 14422);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,14086,14434);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,14086,14434);
}
		}

private static object CompileAndInvoke(Ast ast)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1546,14446,14874);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,14554,14621);

var 
compiler = new Compiler { CompilingConstantExpression = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true,1546,14569,14620) }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,14639,14724);

return f_1546_14646_14723(f_1546_14646_14707(f_1546_14646_14697(f_1546_14676_14696(ast, compiler))));
            }
            catch (TargetInvocationException tie)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1546,14753,14863);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,14823,14848);

throw f_1546_14829_14847(tie);
DynAbs.Tracing.TraceSender.TraceExitCatch(1546,14753,14863);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1546,14446,14874);

object
f_1546_14676_14696(System.Management.Automation.Language.Ast
this_param,System.Management.Automation.Language.Compiler
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 14676, 14696);
return return_v;
}


System.Linq.Expressions.LambdaExpression
f_1546_14646_14697(object
body,params System.Linq.Expressions.ParameterExpression[]
parameters)
{
var return_v = Expression.Lambda( (System.Linq.Expressions.Expression)body, parameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 14646, 14697);
return return_v;
}


System.Delegate
f_1546_14646_14707(System.Linq.Expressions.LambdaExpression
this_param)
{
var return_v = this_param.Compile();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 14646, 14707);
return return_v;
}


object?
f_1546_14646_14723(System.Delegate
this_param,params object?[]
args)
{
var return_v = this_param.DynamicInvoke( args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 14646, 14723);
return return_v;
}


System.Exception
f_1546_14829_14847(System.Reflection.TargetInvocationException
this_param)
{
var return_v = this_param.InnerException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 14829, 14847);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,14446,14874);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,14446,14874);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitErrorStatement(ErrorStatementAst errorStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,14886,14989);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,14959,14987);

return f_1546_14966_14986();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,14886,14989);

System.Management.Automation.PSObject
f_1546_14966_14986()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 14966, 14986);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,14886,14989);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,14886,14989);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitErrorExpression(ErrorExpressionAst errorExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,15001,15107);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,15077,15105);

return f_1546_15084_15104();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,15001,15107);

System.Management.Automation.PSObject
f_1546_15084_15104()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 15084, 15104);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,15001,15107);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,15001,15107);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitScriptBlock(ScriptBlockAst scriptBlockAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,15119,15213);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,15183,15211);

return f_1546_15190_15210();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,15119,15213);

System.Management.Automation.PSObject
f_1546_15190_15210()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 15190, 15210);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,15119,15213);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,15119,15213);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitParamBlock(ParamBlockAst paramBlockAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,15225,15316);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,15286,15314);

return f_1546_15293_15313();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,15225,15316);

System.Management.Automation.PSObject
f_1546_15293_15313()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 15293, 15313);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,15225,15316);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,15225,15316);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitNamedBlock(NamedBlockAst namedBlockAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,15328,15419);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,15389,15417);

return f_1546_15396_15416();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,15328,15419);

System.Management.Automation.PSObject
f_1546_15396_15416()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 15396, 15416);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,15328,15419);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,15328,15419);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTypeConstraint(TypeConstraintAst typeConstraintAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,15431,15534);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,15504,15532);

return f_1546_15511_15531();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,15431,15534);

System.Management.Automation.PSObject
f_1546_15511_15531()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 15511, 15531);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,15431,15534);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,15431,15534);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitAttribute(AttributeAst attributeAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,15546,15634);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,15604,15632);

return f_1546_15611_15631();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,15546,15634);

System.Management.Automation.PSObject
f_1546_15611_15631()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 15611, 15631);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,15546,15634);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,15546,15634);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitNamedAttributeArgument(NamedAttributeArgumentAst namedAttributeArgumentAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,15646,15773);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,15743,15771);

return f_1546_15750_15770();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,15646,15773);

System.Management.Automation.PSObject
f_1546_15750_15770()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 15750, 15770);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,15646,15773);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,15646,15773);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitParameter(ParameterAst parameterAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,15785,15873);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,15843,15871);

return f_1546_15850_15870();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,15785,15873);

System.Management.Automation.PSObject
f_1546_15850_15870()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 15850, 15870);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,15785,15873);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,15785,15873);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitFunctionDefinition(FunctionDefinitionAst functionDefinitionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,15885,16000);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,15970,15998);

return f_1546_15977_15997();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,15885,16000);

System.Management.Automation.PSObject
f_1546_15977_15997()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 15977, 15997);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,15885,16000);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,15885,16000);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitIfStatement(IfStatementAst ifStmtAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,16012,16101);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,16071,16099);

return f_1546_16078_16098();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,16012,16101);

System.Management.Automation.PSObject
f_1546_16078_16098()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 16078, 16098);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,16012,16101);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,16012,16101);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTrap(TrapStatementAst trapStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,16113,16204);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,16174,16202);

return f_1546_16181_16201();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,16113,16204);

System.Management.Automation.PSObject
f_1546_16181_16201()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 16181, 16201);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,16113,16204);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,16113,16204);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitSwitchStatement(SwitchStatementAst switchStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,16216,16322);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,16292,16320);

return f_1546_16299_16319();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,16216,16322);

System.Management.Automation.PSObject
f_1546_16299_16319()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 16299, 16319);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,16216,16322);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,16216,16322);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitDataStatement(DataStatementAst dataStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,16334,16434);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,16404,16432);

return f_1546_16411_16431();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,16334,16434);

System.Management.Automation.PSObject
f_1546_16411_16431()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 16411, 16431);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,16334,16434);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,16334,16434);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitForEachStatement(ForEachStatementAst forEachStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,16446,16555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,16525,16553);

return f_1546_16532_16552();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,16446,16555);

System.Management.Automation.PSObject
f_1546_16532_16552()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 16532, 16552);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,16446,16555);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,16446,16555);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitDoWhileStatement(DoWhileStatementAst doWhileStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,16567,16676);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,16646,16674);

return f_1546_16653_16673();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,16567,16676);

System.Management.Automation.PSObject
f_1546_16653_16673()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 16653, 16673);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,16567,16676);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,16567,16676);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitForStatement(ForStatementAst forStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,16688,16785);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,16755,16783);

return f_1546_16762_16782();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,16688,16785);

System.Management.Automation.PSObject
f_1546_16762_16782()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 16762, 16782);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,16688,16785);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,16688,16785);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitWhileStatement(WhileStatementAst whileStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,16797,16900);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,16870,16898);

return f_1546_16877_16897();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,16797,16900);

System.Management.Automation.PSObject
f_1546_16877_16897()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 16877, 16897);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,16797,16900);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,16797,16900);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitCatchClause(CatchClauseAst catchClauseAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,16912,17006);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,16976,17004);

return f_1546_16983_17003();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,16912,17006);

System.Management.Automation.PSObject
f_1546_16983_17003()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 16983, 17003);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,16912,17006);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,16912,17006);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTryStatement(TryStatementAst tryStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,17018,17115);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,17085,17113);

return f_1546_17092_17112();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,17018,17115);

System.Management.Automation.PSObject
f_1546_17092_17112()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 17092, 17112);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,17018,17115);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,17018,17115);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitBreakStatement(BreakStatementAst breakStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,17127,17230);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,17200,17228);

return f_1546_17207_17227();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,17127,17230);

System.Management.Automation.PSObject
f_1546_17207_17227()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 17207, 17227);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,17127,17230);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,17127,17230);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitContinueStatement(ContinueStatementAst continueStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,17242,17354);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,17324,17352);

return f_1546_17331_17351();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,17242,17354);

System.Management.Automation.PSObject
f_1546_17331_17351()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 17331, 17351);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,17242,17354);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,17242,17354);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitReturnStatement(ReturnStatementAst returnStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,17366,17472);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,17442,17470);

return f_1546_17449_17469();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,17366,17472);

System.Management.Automation.PSObject
f_1546_17449_17469()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 17449, 17469);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,17366,17472);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,17366,17472);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitExitStatement(ExitStatementAst exitStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,17484,17584);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,17554,17582);

return f_1546_17561_17581();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,17484,17584);

System.Management.Automation.PSObject
f_1546_17561_17581()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 17561, 17581);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,17484,17584);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,17484,17584);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitThrowStatement(ThrowStatementAst throwStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,17596,17699);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,17669,17697);

return f_1546_17676_17696();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,17596,17699);

System.Management.Automation.PSObject
f_1546_17676_17696()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 17676, 17696);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,17596,17699);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,17596,17699);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitDoUntilStatement(DoUntilStatementAst doUntilStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,17711,17820);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,17790,17818);

return f_1546_17797_17817();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,17711,17820);

System.Management.Automation.PSObject
f_1546_17797_17817()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 17797, 17817);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,17711,17820);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,17711,17820);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitAssignmentStatement(AssignmentStatementAst assignmentStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,17832,17950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,17920,17948);

return f_1546_17927_17947();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,17832,17950);

System.Management.Automation.PSObject
f_1546_17927_17947()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 17927, 17947);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,17832,17950);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,17832,17950);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitCommand(CommandAst commandAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,17962,18044);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,18014,18042);

return f_1546_18021_18041();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,17962,18044);

System.Management.Automation.PSObject
f_1546_18021_18041()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 18021, 18041);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,17962,18044);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,17962,18044);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitCommandExpression(CommandExpressionAst commandExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,18056,18168);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,18138,18166);

return f_1546_18145_18165();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,18056,18168);

System.Management.Automation.PSObject
f_1546_18145_18165()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 18145, 18165);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,18056,18168);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,18056,18168);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitCommandParameter(CommandParameterAst commandParameterAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,18180,18289);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,18259,18287);

return f_1546_18266_18286();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,18180,18289);

System.Management.Automation.PSObject
f_1546_18266_18286()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 18266, 18286);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,18180,18289);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,18180,18289);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitFileRedirection(FileRedirectionAst fileRedirectionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,18301,18407);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,18377,18405);

return f_1546_18384_18404();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,18301,18407);

System.Management.Automation.PSObject
f_1546_18384_18404()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 18384, 18404);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,18301,18407);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,18301,18407);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitMergingRedirection(MergingRedirectionAst mergingRedirectionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,18419,18534);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,18504,18532);

return f_1546_18511_18531();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,18419,18534);

System.Management.Automation.PSObject
f_1546_18511_18531()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 18511, 18531);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,18419,18534);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,18419,18534);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitExpandableStringExpression(ExpandableStringExpressionAst expandableStringExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,18546,18685);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,18655,18683);

return f_1546_18662_18682();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,18546,18685);

System.Management.Automation.PSObject
f_1546_18662_18682()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 18662, 18682);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,18546,18685);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,18546,18685);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitIndexExpression(IndexExpressionAst indexExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,18697,18803);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,18773,18801);

return f_1546_18780_18800();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,18697,18803);

System.Management.Automation.PSObject
f_1546_18780_18800()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 18780, 18800);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,18697,18803);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,18697,18803);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitAttributedExpression(AttributedExpressionAst attributedExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,18815,18936);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,18906,18934);

return f_1546_18913_18933();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,18815,18936);

System.Management.Automation.PSObject
f_1546_18913_18933()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 18913, 18933);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,18815,18936);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,18815,18936);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitBlockStatement(BlockStatementAst blockStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,18948,19051);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,19021,19049);

return f_1546_19028_19048();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,18948,19051);

System.Management.Automation.PSObject
f_1546_19028_19048()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 19028, 19048);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,18948,19051);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,18948,19051);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitInvokeMemberExpression(InvokeMemberExpressionAst invokeMemberExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,19063,19190);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,19160,19188);

return f_1546_19167_19187();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,19063,19190);

System.Management.Automation.PSObject
f_1546_19167_19187()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 19167, 19187);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,19063,19190);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,19063,19190);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTypeDefinition(TypeDefinitionAst typeDefinitionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,19202,19305);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,19275,19303);

return f_1546_19282_19302();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,19202,19305);

System.Management.Automation.PSObject
f_1546_19282_19302()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 19282, 19302);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,19202,19305);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,19202,19305);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitPropertyMember(PropertyMemberAst propertyMemberAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,19317,19420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,19390,19418);

return f_1546_19397_19417();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,19317,19420);

System.Management.Automation.PSObject
f_1546_19397_19417()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 19397, 19417);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,19317,19420);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,19317,19420);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitFunctionMember(FunctionMemberAst functionMemberAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,19432,19535);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,19505,19533);

return f_1546_19512_19532();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,19432,19535);

System.Management.Automation.PSObject
f_1546_19512_19532()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 19512, 19532);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,19432,19535);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,19432,19535);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitBaseCtorInvokeMemberExpression(BaseCtorInvokeMemberExpressionAst baseCtorInvokeMemberExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,19547,19698);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,19668,19696);

return f_1546_19675_19695();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,19547,19698);

System.Management.Automation.PSObject
f_1546_19675_19695()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 19675, 19695);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,19547,19698);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,19547,19698);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitUsingStatement(UsingStatementAst usingStatement) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,19710,19810);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,19780,19808);

return f_1546_19787_19807();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,19710,19810);

System.Management.Automation.PSObject
f_1546_19787_19807()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 19787, 19807);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,19710,19810);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,19710,19810);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitConfigurationDefinition(ConfigurationDefinitionAst configurationDefinitionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,19822,19952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,19922,19950);

return f_1546_19929_19949();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,19822,19952);

System.Management.Automation.PSObject
f_1546_19929_19949()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 19929, 19949);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,19822,19952);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,19822,19952);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitDynamicKeywordStatement(DynamicKeywordStatementAst dynamicKeywordAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,19964,20085);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,20055,20083);

return f_1546_20062_20082();
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,19964,20085);

System.Management.Automation.PSObject
f_1546_20062_20082()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 20062, 20082);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,19964,20085);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,19964,20085);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitStatementBlock(StatementBlockAst statementBlockAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,20099,20342);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,20194,20265);

f_1546_20194_20264(this, statementBlockAst, "Caller to verify ast is constant");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,20279,20331);

return f_1546_20286_20330(f_1546_20286_20317(f_1546_20286_20314(statementBlockAst), 0), this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,20099,20342);

int
f_1546_20194_20264(System.Management.Automation.Language.ConstantValueVisitor
this_param,System.Management.Automation.Language.StatementBlockAst
ast,string
msg)
{
this_param.CheckIsConstant( (System.Management.Automation.Language.Ast)ast, msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 20194, 20264);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
f_1546_20286_20314(System.Management.Automation.Language.StatementBlockAst
this_param)
{
var return_v = this_param.Statements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 20286, 20314);
return return_v;
}


System.Management.Automation.Language.StatementAst
f_1546_20286_20317(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 20286, 20317);
return return_v;
}


object
f_1546_20286_20330(System.Management.Automation.Language.StatementAst
this_param,System.Management.Automation.Language.ConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 20286, 20330);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,20099,20342);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,20099,20342);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitPipeline(PipelineAst pipelineAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,20354,20573);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,20431,20496);

f_1546_20431_20495(this, pipelineAst, "Caller to verify ast is constant");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,20510,20562);

return f_1546_20517_20561(f_1546_20517_20548(pipelineAst), this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,20354,20573);

int
f_1546_20431_20495(System.Management.Automation.Language.ConstantValueVisitor
this_param,System.Management.Automation.Language.PipelineAst
ast,string
msg)
{
this_param.CheckIsConstant( (System.Management.Automation.Language.Ast)ast, msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 20431, 20495);
return 0;
}


System.Management.Automation.Language.ExpressionAst
f_1546_20517_20548(System.Management.Automation.Language.PipelineAst
this_param)
{
var return_v = this_param.GetPureExpression();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 20517, 20548);
return return_v;
}


object
f_1546_20517_20561(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.ConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 20517, 20561);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,20354,20573);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,20354,20573);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTernaryExpression(TernaryExpressionAst ternaryExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,20585,21032);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,20689,20763);

f_1546_20689_20762(this, ternaryExpressionAst, "Caller to verify ast is constant");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,20779,20842);

object 
condition = f_1546_20798_20841(f_1546_20798_20828(ternaryExpressionAst), this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,20856,21021);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1546, 20863, 20899)||((f_1546_20863_20899(condition)&&DynAbs.Tracing.TraceSender.Conditional_F2(1546, 20919, 20959))||DynAbs.Tracing.TraceSender.Conditional_F3(1546, 20979, 21020)))?f_1546_20919_20959(f_1546_20919_20946(ternaryExpressionAst), this):f_1546_20979_21020(f_1546_20979_21007(ternaryExpressionAst), this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,20585,21032);

int
f_1546_20689_20762(System.Management.Automation.Language.ConstantValueVisitor
this_param,System.Management.Automation.Language.TernaryExpressionAst
ast,string
msg)
{
this_param.CheckIsConstant( (System.Management.Automation.Language.Ast)ast, msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 20689, 20762);
return 0;
}


System.Management.Automation.Language.ExpressionAst
f_1546_20798_20828(System.Management.Automation.Language.TernaryExpressionAst
this_param)
{
var return_v = this_param.Condition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 20798, 20828);
return return_v;
}


object
f_1546_20798_20841(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.ConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 20798, 20841);
return return_v;
}


bool
f_1546_20863_20899(object
obj)
{
var return_v = LanguagePrimitives.IsTrue( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 20863, 20899);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1546_20919_20946(System.Management.Automation.Language.TernaryExpressionAst
this_param)
{
var return_v = this_param.IfTrue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 20919, 20946);
return return_v;
}


object
f_1546_20919_20959(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.ConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 20919, 20959);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1546_20979_21007(System.Management.Automation.Language.TernaryExpressionAst
this_param)
{
var return_v = this_param.IfFalse;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 20979, 21007);
return return_v;
}


object
f_1546_20979_21020(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.ConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 20979, 21020);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,20585,21032);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,20585,21032);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitBinaryExpression(BinaryExpressionAst binaryExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,21044,21288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,21145,21218);

f_1546_21145_21217(this, binaryExpressionAst, "Caller to verify ast is constant");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,21232,21277);

return f_1546_21239_21276(binaryExpressionAst);
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,21044,21288);

int
f_1546_21145_21217(System.Management.Automation.Language.ConstantValueVisitor
this_param,System.Management.Automation.Language.BinaryExpressionAst
ast,string
msg)
{
this_param.CheckIsConstant( (System.Management.Automation.Language.Ast)ast, msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 21145, 21217);
return 0;
}


object
f_1546_21239_21276(System.Management.Automation.Language.BinaryExpressionAst
ast)
{
var return_v = CompileAndInvoke( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 21239, 21276);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,21044,21288);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,21044,21288);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitUnaryExpression(UnaryExpressionAst unaryExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,21300,21539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,21398,21470);

f_1546_21398_21469(this, unaryExpressionAst, "Caller to verify ast is constant");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,21484,21528);

return f_1546_21491_21527(unaryExpressionAst);
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,21300,21539);

int
f_1546_21398_21469(System.Management.Automation.Language.ConstantValueVisitor
this_param,System.Management.Automation.Language.UnaryExpressionAst
ast,string
msg)
{
this_param.CheckIsConstant( (System.Management.Automation.Language.Ast)ast, msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 21398, 21469);
return 0;
}


object
f_1546_21491_21527(System.Management.Automation.Language.UnaryExpressionAst
ast)
{
var return_v = CompileAndInvoke( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 21491, 21527);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,21300,21539);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,21300,21539);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitConvertExpression(ConvertExpressionAst convertExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,21551,21800);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,21655,21729);

f_1546_21655_21728(this, convertExpressionAst, "Caller to verify ast is constant");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,21743,21789);

return f_1546_21750_21788(convertExpressionAst);
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,21551,21800);

int
f_1546_21655_21728(System.Management.Automation.Language.ConstantValueVisitor
this_param,System.Management.Automation.Language.ConvertExpressionAst
ast,string
msg)
{
this_param.CheckIsConstant( (System.Management.Automation.Language.Ast)ast, msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 21655, 21728);
return 0;
}


object
f_1546_21750_21788(System.Management.Automation.Language.ConvertExpressionAst
ast)
{
var return_v = CompileAndInvoke( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 21750, 21788);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,21551,21800);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,21551,21800);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitConstantExpression(ConstantExpressionAst constantExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,21812,22054);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,21919,21994);

f_1546_21919_21993(this, constantExpressionAst, "Caller to verify ast is constant");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,22008,22043);

return f_1546_22015_22042(constantExpressionAst);
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,21812,22054);

int
f_1546_21919_21993(System.Management.Automation.Language.ConstantValueVisitor
this_param,System.Management.Automation.Language.ConstantExpressionAst
ast,string
msg)
{
this_param.CheckIsConstant( (System.Management.Automation.Language.Ast)ast, msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 21919, 21993);
return 0;
}


object
f_1546_22015_22042(System.Management.Automation.Language.ConstantExpressionAst
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 22015, 22042);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,21812,22054);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,21812,22054);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitStringConstantExpression(StringConstantExpressionAst stringConstantExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,22066,22338);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,22191,22272);

f_1546_22191_22271(this, stringConstantExpressionAst, "Caller to verify ast is constant");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,22286,22327);

return f_1546_22293_22326(stringConstantExpressionAst);
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,22066,22338);

int
f_1546_22191_22271(System.Management.Automation.Language.ConstantValueVisitor
this_param,System.Management.Automation.Language.StringConstantExpressionAst
ast,string
msg)
{
this_param.CheckIsConstant( (System.Management.Automation.Language.Ast)ast, msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 22191, 22271);
return 0;
}


string
f_1546_22293_22326(System.Management.Automation.Language.StringConstantExpressionAst
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 22293, 22326);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,22066,22338);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,22066,22338);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitSubExpression(SubExpressionAst subExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,22350,22588);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,22442,22512);

f_1546_22442_22511(this, subExpressionAst, "Caller to verify ast is constant");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,22526,22577);

return f_1546_22533_22576(f_1546_22533_22563(subExpressionAst), this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,22350,22588);

int
f_1546_22442_22511(System.Management.Automation.Language.ConstantValueVisitor
this_param,System.Management.Automation.Language.SubExpressionAst
ast,string
msg)
{
this_param.CheckIsConstant( (System.Management.Automation.Language.Ast)ast, msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 22442, 22511);
return 0;
}


System.Management.Automation.Language.StatementBlockAst
f_1546_22533_22563(System.Management.Automation.Language.SubExpressionAst
this_param)
{
var return_v = this_param.SubExpression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 22533, 22563);
return return_v;
}


object
f_1546_22533_22576(System.Management.Automation.Language.StatementBlockAst
this_param,System.Management.Automation.Language.ConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 22533, 22576);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,22350,22588);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,22350,22588);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitUsingExpression(UsingExpressionAst usingExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,22600,22862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,22698,22784);

f_1546_22698_22783(this, f_1546_22714_22746(usingExpressionAst), "Caller to verify ast is constant");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,22798,22851);

return f_1546_22805_22850(f_1546_22805_22837(usingExpressionAst), this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,22600,22862);

System.Management.Automation.Language.ExpressionAst
f_1546_22714_22746(System.Management.Automation.Language.UsingExpressionAst
this_param)
{
var return_v = this_param.SubExpression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 22714, 22746);
return return_v;
}


int
f_1546_22698_22783(System.Management.Automation.Language.ConstantValueVisitor
this_param,System.Management.Automation.Language.ExpressionAst
ast,string
msg)
{
this_param.CheckIsConstant( (System.Management.Automation.Language.Ast)ast, msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 22698, 22783);
return 0;
}


System.Management.Automation.Language.ExpressionAst
f_1546_22805_22837(System.Management.Automation.Language.UsingExpressionAst
this_param)
{
var return_v = this_param.SubExpression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 22805, 22837);
return return_v;
}


object
f_1546_22805_22850(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.ConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 22805, 22850);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,22600,22862);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,22600,22862);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitVariableExpression(VariableExpressionAst variableExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,22874,23553);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,22981,23056);

f_1546_22981_23055(this, variableExpressionAst, "Caller to verify ast is constant");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,23070,23135);

string 
name = f_1546_23084_23134(f_1546_23084_23118(variableExpressionAst))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,23149,23254) || true) && (f_1546_23153_23223(name, SpecialVariables.True, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1546,23149,23254);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,23242,23254);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1546,23149,23254);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,23270,23377) || true) && (f_1546_23274_23345(name, SpecialVariables.False, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1546,23270,23377);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,23364,23377);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1546,23270,23377);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,23393,23516);

f_1546_23393_23515(f_1546_23412_23482(name, SpecialVariables.Null, StringComparison.OrdinalIgnoreCase), "Unexpected constant variable");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,23530,23542);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,22874,23553);

int
f_1546_22981_23055(System.Management.Automation.Language.ConstantValueVisitor
this_param,System.Management.Automation.Language.VariableExpressionAst
ast,string
msg)
{
this_param.CheckIsConstant( (System.Management.Automation.Language.Ast)ast, msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 22981, 23055);
return 0;
}


System.Management.Automation.VariablePath
f_1546_23084_23118(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.VariablePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 23084, 23118);
return return_v;
}


string
f_1546_23084_23134(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.UnqualifiedPath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 23084, 23134);
return return_v;
}


bool
f_1546_23153_23223(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 23153, 23223);
return return_v;
}


bool
f_1546_23274_23345(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 23274, 23345);
return return_v;
}


bool
f_1546_23412_23482(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 23412, 23482);
return return_v;
}


int
f_1546_23393_23515(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 23393, 23515);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,22874,23553);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,22874,23553);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTypeExpression(TypeExpressionAst typeExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,23565,23810);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,23660,23731);

f_1546_23660_23730(this, typeExpressionAst, "Caller to verify ast is constant");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,23745,23799);

return f_1546_23752_23798(f_1546_23752_23778(typeExpressionAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,23565,23810);

int
f_1546_23660_23730(System.Management.Automation.Language.ConstantValueVisitor
this_param,System.Management.Automation.Language.TypeExpressionAst
ast,string
msg)
{
this_param.CheckIsConstant( (System.Management.Automation.Language.Ast)ast, msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 23660, 23730);
return 0;
}


System.Management.Automation.Language.ITypeName
f_1546_23752_23778(System.Management.Automation.Language.TypeExpressionAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 23752, 23778);
return return_v;
}


System.Type
f_1546_23752_23798(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.GetReflectionType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 23752, 23798);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,23565,23810);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,23565,23810);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitMemberExpression(MemberExpressionAst memberExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,23822,24460);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,23923,23996);

f_1546_23923_23995(this, memberExpressionAst, "Caller to verify ast is constant");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,24012,24104);

var 
type = f_1546_24023_24103(f_1546_24023_24083(((TypeExpressionAst)f_1546_24043_24073(memberExpressionAst))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,24118,24195);

var 
member = f_1546_24131_24194(((StringConstantExpressionAst)f_1546_24161_24187(memberExpressionAst)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,24209,24386);

var 
memberInfo = f_1546_24226_24385(type, member, MemberTypes.Field, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,24400,24449);

return f_1546_24407_24448(((FieldInfo)memberInfo[0]), null);
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,23822,24460);

int
f_1546_23923_23995(System.Management.Automation.Language.ConstantValueVisitor
this_param,System.Management.Automation.Language.MemberExpressionAst
ast,string
msg)
{
this_param.CheckIsConstant( (System.Management.Automation.Language.Ast)ast, msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 23923, 23995);
return 0;
}


System.Management.Automation.Language.ExpressionAst
f_1546_24043_24073(System.Management.Automation.Language.MemberExpressionAst
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 24043, 24073);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1546_24023_24083(System.Management.Automation.Language.TypeExpressionAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 24023, 24083);
return return_v;
}


System.Type
f_1546_24023_24103(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.GetReflectionType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 24023, 24103);
return return_v;
}


System.Management.Automation.Language.CommandElementAst
f_1546_24161_24187(System.Management.Automation.Language.MemberExpressionAst
this_param)
{
var return_v = this_param.Member;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 24161, 24187);
return return_v;
}


string
f_1546_24131_24194(System.Management.Automation.Language.StringConstantExpressionAst
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 24131, 24194);
return return_v;
}


System.Reflection.MemberInfo[]
f_1546_24226_24385(System.Type
this_param,string
name,System.Reflection.MemberTypes
type,System.Reflection.BindingFlags
bindingAttr)
{
var return_v = this_param.GetMember( name, type, bindingAttr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 24226, 24385);
return return_v;
}


object?
f_1546_24407_24448(System.Reflection.FieldInfo
this_param,object?
obj)
{
var return_v = this_param.GetValue( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 24407, 24448);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,23822,24460);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,23822,24460);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitArrayExpression(ArrayExpressionAst arrayExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,24472,24720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,24570,24642);

f_1546_24570_24641(this, arrayExpressionAst, "Caller to verify ast is constant");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,24656,24709);

return f_1546_24663_24708(f_1546_24663_24695(arrayExpressionAst), this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,24472,24720);

int
f_1546_24570_24641(System.Management.Automation.Language.ConstantValueVisitor
this_param,System.Management.Automation.Language.ArrayExpressionAst
ast,string
msg)
{
this_param.CheckIsConstant( (System.Management.Automation.Language.Ast)ast, msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 24570, 24641);
return 0;
}


System.Management.Automation.Language.StatementBlockAst
f_1546_24663_24695(System.Management.Automation.Language.ArrayExpressionAst
this_param)
{
var return_v = this_param.SubExpression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 24663, 24695);
return return_v;
}


object
f_1546_24663_24708(System.Management.Automation.Language.StatementBlockAst
this_param,System.Management.Automation.Language.ConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 24663, 24708);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,24472,24720);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,24472,24720);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitArrayLiteral(ArrayLiteralAst arrayLiteralAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,24732,24985);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,24821,24890);

f_1546_24821_24889(this, arrayLiteralAst, "Caller to verify ast is constant");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,24904,24974);

return f_1546_24911_24973(f_1546_24911_24963(f_1546_24911_24935(arrayLiteralAst), e => e.Accept(this)));
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,24732,24985);

int
f_1546_24821_24889(System.Management.Automation.Language.ConstantValueVisitor
this_param,System.Management.Automation.Language.ArrayLiteralAst
ast,string
msg)
{
this_param.CheckIsConstant( (System.Management.Automation.Language.Ast)ast, msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 24821, 24889);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
f_1546_24911_24935(System.Management.Automation.Language.ArrayLiteralAst
this_param)
{
var return_v = this_param.Elements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 24911, 24935);
return return_v;
}


System.Collections.Generic.IEnumerable<object>
f_1546_24911_24963(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
source,System.Func<System.Management.Automation.Language.ExpressionAst, object>
selector)
{
var return_v = source.Select<System.Management.Automation.Language.ExpressionAst,object>( selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 24911, 24963);
return return_v;
}


object[]
f_1546_24911_24973(System.Collections.Generic.IEnumerable<object>
source)
{
var return_v = source.ToArray<object>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 24911, 24973);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,24732,24985);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,24732,24985);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitScriptBlockExpression(ScriptBlockExpressionAst scriptBlockExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,24997,25294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,25113,25191);

f_1546_25113_25190(this, scriptBlockExpressionAst, "Caller to verify ast is constant");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,25205,25283);

return f_1546_25212_25282(f_1546_25228_25264(scriptBlockExpressionAst), isFilter: false);
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,24997,25294);

int
f_1546_25113_25190(System.Management.Automation.Language.ConstantValueVisitor
this_param,System.Management.Automation.Language.ScriptBlockExpressionAst
ast,string
msg)
{
this_param.CheckIsConstant( (System.Management.Automation.Language.Ast)ast, msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 25113, 25190);
return 0;
}


System.Management.Automation.Language.ScriptBlockAst
f_1546_25228_25264(System.Management.Automation.Language.ScriptBlockExpressionAst
this_param)
{
var return_v = this_param.ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 25228, 25264);
return return_v;
}


System.Management.Automation.ScriptBlock
f_1546_25212_25282(System.Management.Automation.Language.ScriptBlockAst
ast,bool
isFilter)
{
var return_v = new System.Management.Automation.ScriptBlock( (System.Management.Automation.Language.IParameterMetadataProvider)ast, isFilter: isFilter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 25212, 25282);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,24997,25294);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,24997,25294);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitParenExpression(ParenExpressionAst parenExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,25306,25549);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,25404,25476);

f_1546_25404_25475(this, parenExpressionAst, "Caller to verify ast is constant");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,25490,25538);

return f_1546_25497_25537(f_1546_25497_25524(parenExpressionAst), this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,25306,25549);

int
f_1546_25404_25475(System.Management.Automation.Language.ConstantValueVisitor
this_param,System.Management.Automation.Language.ParenExpressionAst
ast,string
msg)
{
this_param.CheckIsConstant( (System.Management.Automation.Language.Ast)ast, msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 25404, 25475);
return 0;
}


System.Management.Automation.Language.PipelineBaseAst
f_1546_25497_25524(System.Management.Automation.Language.ParenExpressionAst
this_param)
{
var return_v = this_param.Pipeline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 25497, 25524);
return return_v;
}


object
f_1546_25497_25537(System.Management.Automation.Language.PipelineBaseAst
this_param,System.Management.Automation.Language.ConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 25497, 25537);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,25306,25549);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,25306,25549);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitHashtable(HashtableAst hashtableAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1546,25561,25962);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,25641,25707);

f_1546_25641_25706(this, hashtableAst, "Caller to verify ast is constant");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,25721,25750);

var 
result = f_1546_25734_25749()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,25764,25921);
foreach(var pair in f_1546_25785_25811_I(f_1546_25785_25811(hashtableAst)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1546,25764,25921);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,25845,25906);

f_1546_25845_25905(                result, f_1546_25856_25879(f_1546_25856_25866(pair), this), f_1546_25881_25904(f_1546_25881_25891(pair), this));
DynAbs.Tracing.TraceSender.TraceExitCondition(1546,25764,25921);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1546,1,158);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1546,1,158);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,25937,25951);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1546,25561,25962);

int
f_1546_25641_25706(System.Management.Automation.Language.ConstantValueVisitor
this_param,System.Management.Automation.Language.HashtableAst
ast,string
msg)
{
this_param.CheckIsConstant( (System.Management.Automation.Language.Ast)ast, msg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 25641, 25706);
return 0;
}


System.Collections.Hashtable
f_1546_25734_25749()
{
var return_v = new System.Collections.Hashtable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 25734, 25749);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
f_1546_25785_25811(System.Management.Automation.Language.HashtableAst
this_param)
{
var return_v = this_param.KeyValuePairs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 25785, 25811);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1546_25856_25866(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
this_param)
{
var return_v = this_param.Item1;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 25856, 25866);
return return_v;
}


object
f_1546_25856_25879(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.ConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 25856, 25879);
return return_v;
}


System.Management.Automation.Language.StatementAst
f_1546_25881_25891(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
this_param)
{
var return_v = this_param.Item2;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1546, 25881, 25891);
return return_v;
}


object
f_1546_25881_25904(System.Management.Automation.Language.StatementAst
this_param,System.Management.Automation.Language.ConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 25881, 25904);
return return_v;
}


int
f_1546_25845_25905(System.Collections.Hashtable
this_param,object
key,object
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 25845, 25905);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
f_1546_25785_25811_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1546, 25785, 25811);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1546,25561,25962);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,25561,25962);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public ConstantValueVisitor()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1546,13902,25969);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,13975,14020);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1546,14030,14074);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1546,13902,25969);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,13902,25969);
}


static ConstantValueVisitor()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1546,13902,25969);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1546,13902,25969);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1546,13902,25969);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1546,13902,25969);
}
}
