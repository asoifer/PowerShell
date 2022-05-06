// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.IO;
using System.Linq;
using System.Management.Automation.Internal;

/*
 *
 * This visitor makes a determination as to whether an operation is safe in a GetPowerShell API Context.
 * It is modeled on the ConstantValueVisitor with changes which allow those
 * operations which are deemed safe, rather than constant. The following are differences from
 * ConstantValueVisitor:
 *  o Because we are going to call for values in ScriptBlockToPowerShell, the
 *    Get*ValueVisitor class is removed
 *  o IsGetPowerShellSafeValueVisitor only needs to determine whether it is safe, we won't return
 *    anything but that determination (vs actually returning a value in the out constantValue parameter
 *    as is found in the ConstantValueVisitor).
 *  o the internal bool members (Checking* members in ConstantValues) aren't needed as those checks are not germane
 *  o VisitExpandableStringExpression may be safe under the proper circumstances
 *  o VisitIndexExpression may be safe under the proper circumstances
 *  o VisitStatementBlock is safe if its component statements are safe
 *  o VisitBinaryExpression is not safe as it allows for a DOS attack
 *  o VisitVariableExpression is generally safe, there are checks outside of this code for ensuring variables actually
 *    have provided references. Those other checks ensure that the variable isn't something like $PID or $HOME, etc.,
 *    otherwise it's a safe operation, such as reference to a variable such as $true, or passed parameters.
 *  o VisitTypeExpression is not safe as it enables determining what types are available on the system which
 *    can imply what software has been installed on the system.
 *  o VisitMemberExpression is not safe as allows for the same attack as VisitTypeExpression
 *  o VisitArrayExpression may be safe if its components are safe
 *  o VisitArrayLiteral may be safe if its components are safe
 *  o VisitHashtable may be safe if its components are safe
 *  o VisitTernaryExpression may be safe if its components are safe
 */

namespace System.Management.Automation.Language
{
internal class IsSafeValueVisitor : ICustomAstVisitor2
{
public static bool IsAstSafe(Ast ast, GetSafeValueVisitor.SafeValueContext safeValueContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1554,2323,2565);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,2440,2510);

IsSafeValueVisitor 
visitor = f_1554_2469_2509(safeValueContext)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,2524,2554);

return f_1554_2531_2553(visitor, ast);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1554,2323,2565);

System.Management.Automation.Language.IsSafeValueVisitor
f_1554_2469_2509(System.Management.Automation.Language.GetSafeValueVisitor.SafeValueContext
safeValueContext)
{
var return_v = new System.Management.Automation.Language.IsSafeValueVisitor( safeValueContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 2469, 2509);
return return_v;
}


bool
f_1554_2531_2553(System.Management.Automation.Language.IsSafeValueVisitor
this_param,System.Management.Automation.Language.Ast
ast)
{
var return_v = this_param.IsAstSafe( ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 2531, 2553);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,2323,2565);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,2323,2565);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal IsSafeValueVisitor(GetSafeValueVisitor.SafeValueContext safeValueContext)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1554,2577,2732);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,3239,3254);
this._visitCount = 0;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,3630,3647);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,2684,2721);

_safeValueContext = safeValueContext;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1554,2577,2732);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,2577,2732);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,2577,2732);
}
		}

internal bool IsAstSafe(Ast ast)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,2744,2959);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,2801,2919) || true) && ((bool)f_1554_2811_2827(ast, this)&&(DynAbs.Tracing.TraceSender.Expression_True(1554, 2805, 2858)&&_visitCount < MaxVisitCount))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,2801,2919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,2892,2904);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,2801,2919);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,2935,2948);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,2744,2959);

object
f_1554_2811_2827(System.Management.Automation.Language.Ast
this_param,System.Management.Automation.Language.IsSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 2811, 2827);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,2744,2959);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,2744,2959);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static readonly IsSafeValueVisitor Default ;

private uint _visitCount ;

private const uint 
MaxVisitCount = 5000
;

private const int 
MaxHashtableKeyCount = 500
;

private readonly GetSafeValueVisitor.SafeValueContext _safeValueContext;

public object VisitErrorStatement(ErrorStatementAst errorStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,3660,3748);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,3733,3746);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,3660,3748);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,3660,3748);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,3660,3748);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitErrorExpression(ErrorExpressionAst errorExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,3760,3851);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,3836,3849);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,3760,3851);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,3760,3851);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,3760,3851);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitScriptBlock(ScriptBlockAst scriptBlockAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,3863,3942);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,3927,3940);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,3863,3942);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,3863,3942);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,3863,3942);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitParamBlock(ParamBlockAst paramBlockAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,3954,4030);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,4015,4028);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,3954,4030);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,3954,4030);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,3954,4030);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitNamedBlock(NamedBlockAst namedBlockAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,4042,4118);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,4103,4116);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,4042,4118);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,4042,4118);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,4042,4118);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTypeConstraint(TypeConstraintAst typeConstraintAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,4130,4218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,4203,4216);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,4130,4218);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,4130,4218);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,4130,4218);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitAttribute(AttributeAst attributeAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,4230,4303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,4288,4301);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,4230,4303);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,4230,4303);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,4230,4303);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitNamedAttributeArgument(NamedAttributeArgumentAst namedAttributeArgumentAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,4315,4427);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,4412,4425);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,4315,4427);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,4315,4427);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,4315,4427);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitParameter(ParameterAst parameterAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,4439,4512);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,4497,4510);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,4439,4512);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,4439,4512);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,4439,4512);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitFunctionDefinition(FunctionDefinitionAst functionDefinitionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,4524,4624);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,4609,4622);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,4524,4624);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,4524,4624);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,4524,4624);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitIfStatement(IfStatementAst ifStmtAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,4636,4710);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,4695,4708);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,4636,4710);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,4636,4710);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,4636,4710);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTrap(TrapStatementAst trapStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,4722,4798);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,4783,4796);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,4722,4798);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,4722,4798);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,4722,4798);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitSwitchStatement(SwitchStatementAst switchStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,4810,4901);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,4886,4899);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,4810,4901);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,4810,4901);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,4810,4901);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitDataStatement(DataStatementAst dataStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,4913,4998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,4983,4996);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,4913,4998);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,4913,4998);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,4913,4998);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitForEachStatement(ForEachStatementAst forEachStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,5010,5104);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,5089,5102);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,5010,5104);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,5010,5104);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,5010,5104);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitDoWhileStatement(DoWhileStatementAst doWhileStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,5116,5210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,5195,5208);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,5116,5210);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,5116,5210);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,5116,5210);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitForStatement(ForStatementAst forStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,5222,5304);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,5289,5302);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,5222,5304);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,5222,5304);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,5222,5304);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitWhileStatement(WhileStatementAst whileStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,5316,5404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,5389,5402);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,5316,5404);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,5316,5404);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,5316,5404);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitCatchClause(CatchClauseAst catchClauseAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,5416,5495);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,5480,5493);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,5416,5495);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,5416,5495);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,5416,5495);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTryStatement(TryStatementAst tryStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,5507,5589);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,5574,5587);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,5507,5589);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,5507,5589);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,5507,5589);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitBreakStatement(BreakStatementAst breakStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,5601,5689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,5674,5687);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,5601,5689);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,5601,5689);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,5601,5689);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitContinueStatement(ContinueStatementAst continueStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,5701,5798);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,5783,5796);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,5701,5798);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,5701,5798);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,5701,5798);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitReturnStatement(ReturnStatementAst returnStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,5810,5901);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,5886,5899);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,5810,5901);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,5810,5901);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,5810,5901);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitExitStatement(ExitStatementAst exitStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,5913,5998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,5983,5996);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,5913,5998);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,5913,5998);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,5913,5998);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitThrowStatement(ThrowStatementAst throwStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,6010,6098);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,6083,6096);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,6010,6098);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,6010,6098);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,6010,6098);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitDoUntilStatement(DoUntilStatementAst doUntilStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,6110,6204);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,6189,6202);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,6110,6204);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,6110,6204);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,6110,6204);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitAssignmentStatement(AssignmentStatementAst assignmentStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,6216,6319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,6304,6317);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,6216,6319);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,6216,6319);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,6216,6319);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitCommand(CommandAst commandAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,6331,6398);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,6383,6396);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,6331,6398);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,6331,6398);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,6331,6398);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitCommandExpression(CommandExpressionAst commandExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,6410,6507);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,6492,6505);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,6410,6507);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,6410,6507);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,6410,6507);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitCommandParameter(CommandParameterAst commandParameterAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,6519,6613);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,6598,6611);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,6519,6613);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,6519,6613);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,6519,6613);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitFileRedirection(FileRedirectionAst fileRedirectionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,6625,6716);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,6701,6714);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,6625,6716);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,6625,6716);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,6625,6716);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitMergingRedirection(MergingRedirectionAst mergingRedirectionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,6728,6828);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,6813,6826);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,6728,6828);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,6728,6828);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,6728,6828);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitAttributedExpression(AttributedExpressionAst attributedExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,6840,6946);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,6931,6944);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,6840,6946);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,6840,6946);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,6840,6946);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitBlockStatement(BlockStatementAst blockStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,6958,7046);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,7031,7044);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,6958,7046);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,6958,7046);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,6958,7046);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitInvokeMemberExpression(InvokeMemberExpressionAst invokeMemberExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,7058,7170);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,7155,7168);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,7058,7170);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,7058,7170);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,7058,7170);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTypeDefinition(TypeDefinitionAst typeDefinitionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,7182,7270);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,7255,7268);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,7182,7270);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,7182,7270);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,7182,7270);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitPropertyMember(PropertyMemberAst propertyMemberAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,7282,7370);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,7355,7368);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,7282,7370);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,7282,7370);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,7282,7370);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitFunctionMember(FunctionMemberAst functionMemberAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,7382,7470);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,7455,7468);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,7382,7470);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,7382,7470);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,7382,7470);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitBaseCtorInvokeMemberExpression(BaseCtorInvokeMemberExpressionAst baseCtorInvokeMemberExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,7482,7618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,7603,7616);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,7482,7618);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,7482,7618);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,7482,7618);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitUsingStatement(UsingStatementAst usingStatement) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,7630,7715);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,7700,7713);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,7630,7715);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,7630,7715);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,7630,7715);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitConfigurationDefinition(ConfigurationDefinitionAst configurationDefinitionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,7727,7842);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,7827,7840);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,7727,7842);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,7727,7842);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,7727,7842);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitDynamicKeywordStatement(DynamicKeywordStatementAst dynamicKeywordAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,7854,7960);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,7945,7958);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,7854,7960);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,7854,7960);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,7854,7960);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitIndexExpression(IndexExpressionAst indexExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,7972,8180);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,8070,8169);

return (bool)f_1554_8083_8120(f_1554_8083_8107(indexExpressionAst), this)&&(DynAbs.Tracing.TraceSender.Expression_True(1554, 8077, 8168)&&(bool)f_1554_8130_8168(f_1554_8130_8155(indexExpressionAst), this));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,7972,8180);

System.Management.Automation.Language.ExpressionAst
f_1554_8083_8107(System.Management.Automation.Language.IndexExpressionAst
this_param)
{
var return_v = this_param.Index;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 8083, 8107);
return return_v;
}


object
f_1554_8083_8120(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.IsSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 8083, 8120);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1554_8130_8155(System.Management.Automation.Language.IndexExpressionAst
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 8130, 8155);
return return_v;
}


object
f_1554_8130_8168(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.IsSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 8130, 8168);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,7972,8180);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,7972,8180);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitExpandableStringExpression(ExpandableStringExpressionAst expandableStringExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,8192,8702);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,8323,8342);

bool 
isSafe = true
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,8356,8661);
foreach(var nestedExpression in f_1554_8389_8436_I(f_1554_8389_8436(expandableStringExpressionAst)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,8356,8661);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,8470,8484);

_visitCount++;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,8502,8646) || true) && (!(bool)f_1554_8513_8542(nestedExpression, this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,8502,8646);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,8584,8599);

isSafe = false;
DynAbs.Tracing.TraceSender.TraceBreak(1554,8621,8627);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,8502,8646);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,8356,8661);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1554,1,306);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1554,1,306);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,8677,8691);

return isSafe;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,8192,8702);

System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
f_1554_8389_8436(System.Management.Automation.Language.ExpandableStringExpressionAst
this_param)
{
var return_v = this_param.NestedExpressions;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 8389, 8436);
return return_v;
}


object
f_1554_8513_8542(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.IsSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 8513, 8542);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
f_1554_8389_8436_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 8389, 8436);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,8192,8702);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,8192,8702);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitStatementBlock(StatementBlockAst statementBlockAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,8714,9300);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,8809,8828);

bool 
isSafe = true
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,8842,9259);
foreach(var statement in f_1554_8868_8896_I(f_1554_8868_8896(statementBlockAst)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,8842,9259);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,8930,8944);

_visitCount++;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,8962,9087) || true) && (statement == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,8962,9087);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,9025,9040);

isSafe = false;
DynAbs.Tracing.TraceSender.TraceBreak(1554,9062,9068);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,8962,9087);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,9107,9244) || true) && (!(bool)f_1554_9118_9140(statement, this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,9107,9244);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,9182,9197);

isSafe = false;
DynAbs.Tracing.TraceSender.TraceBreak(1554,9219,9225);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,9107,9244);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,8842,9259);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1554,1,418);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1554,1,418);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,9275,9289);

return isSafe;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,8714,9300);

System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
f_1554_8868_8896(System.Management.Automation.Language.StatementBlockAst
this_param)
{
var return_v = this_param.Statements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 8868, 8896);
return return_v;
}


object
f_1554_9118_9140(System.Management.Automation.Language.StatementAst
this_param,System.Management.Automation.Language.IsSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 9118, 9140);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
f_1554_8868_8896_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 8868, 8896);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,8714,9300);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,8714,9300);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitPipeline(PipelineAst pipelineAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,9312,9504);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,9389,9432);

var 
expr = f_1554_9400_9431(pipelineAst)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,9446,9493);

return expr != null &&(DynAbs.Tracing.TraceSender.Expression_True(1554, 9453, 9492)&&(bool)f_1554_9475_9492(expr, this));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,9312,9504);

System.Management.Automation.Language.ExpressionAst
f_1554_9400_9431(System.Management.Automation.Language.PipelineAst
this_param)
{
var return_v = this_param.GetPureExpression();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 9400, 9431);
return return_v;
}


object
f_1554_9475_9492(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.IsSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 9475, 9492);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,9312,9504);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,9312,9504);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTernaryExpression(TernaryExpressionAst ternaryExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,9516,9829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,9620,9818);

return (bool)f_1554_9633_9676(f_1554_9633_9663(ternaryExpressionAst), this)&&(DynAbs.Tracing.TraceSender.Expression_True(1554, 9627, 9746)&&                   (bool)f_1554_9706_9746(f_1554_9706_9733(ternaryExpressionAst), this))&&(DynAbs.Tracing.TraceSender.Expression_True(1554, 9627, 9817)&&                   (bool)f_1554_9776_9817(f_1554_9776_9804(ternaryExpressionAst), this));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,9516,9829);

System.Management.Automation.Language.ExpressionAst
f_1554_9633_9663(System.Management.Automation.Language.TernaryExpressionAst
this_param)
{
var return_v = this_param.Condition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 9633, 9663);
return return_v;
}


object
f_1554_9633_9676(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.IsSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 9633, 9676);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1554_9706_9733(System.Management.Automation.Language.TernaryExpressionAst
this_param)
{
var return_v = this_param.IfTrue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 9706, 9733);
return return_v;
}


object
f_1554_9706_9746(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.IsSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 9706, 9746);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1554_9776_9804(System.Management.Automation.Language.TernaryExpressionAst
this_param)
{
var return_v = this_param.IfFalse;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 9776, 9804);
return return_v;
}


object
f_1554_9776_9817(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.IsSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 9776, 9817);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,9516,9829);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,9516,9829);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitBinaryExpression(BinaryExpressionAst binaryExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,9841,10193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,10169,10182);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,9841,10193);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,9841,10193);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,9841,10193);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitUnaryExpression(UnaryExpressionAst unaryExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,10205,10718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,10303,10560);

bool 
unaryExpressionIsSafe = f_1554_10332_10397(f_1554_10332_10360(unaryExpressionAst), TokenFlags.CanConstantFold)&&(DynAbs.Tracing.TraceSender.Expression_True(1554, 10332, 10495)&&                !f_1554_10419_10495(f_1554_10419_10447(unaryExpressionAst), TokenFlags.DisallowedInRestrictedMode))&&(DynAbs.Tracing.TraceSender.Expression_True(1554, 10332, 10559)&&                (bool)f_1554_10522_10559(f_1554_10522_10546(unaryExpressionAst), this))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,10574,10662) || true) && (unaryExpressionIsSafe)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,10574,10662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,10633,10647);

_visitCount++;
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,10574,10662);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,10678,10707);

return unaryExpressionIsSafe;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,10205,10718);

System.Management.Automation.Language.TokenKind
f_1554_10332_10360(System.Management.Automation.Language.UnaryExpressionAst
this_param)
{
var return_v = this_param.TokenKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 10332, 10360);
return return_v;
}


bool
f_1554_10332_10397(System.Management.Automation.Language.TokenKind
kind,System.Management.Automation.Language.TokenFlags
flag)
{
var return_v = kind.HasTrait( flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 10332, 10397);
return return_v;
}


System.Management.Automation.Language.TokenKind
f_1554_10419_10447(System.Management.Automation.Language.UnaryExpressionAst
this_param)
{
var return_v = this_param.TokenKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 10419, 10447);
return return_v;
}


bool
f_1554_10419_10495(System.Management.Automation.Language.TokenKind
kind,System.Management.Automation.Language.TokenFlags
flag)
{
var return_v = kind.HasTrait( flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 10419, 10495);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1554_10522_10546(System.Management.Automation.Language.UnaryExpressionAst
this_param)
{
var return_v = this_param.Child;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 10522, 10546);
return return_v;
}


object
f_1554_10522_10559(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.IsSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 10522, 10559);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,10205,10718);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,10205,10718);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitConvertExpression(ConvertExpressionAst convertExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,10730,11334);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,10834,10900);

var 
type = f_1554_10845_10899(f_1554_10845_10879(f_1554_10845_10870(convertExpressionAst)))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,10914,10992) || true) && (type == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,10914,10992);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,10964,10977);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,10914,10992);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,11008,11226) || true) && (!f_1554_11013_11035(type))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,11008,11226);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,11198,11211);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,11008,11226);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,11242,11256);

_visitCount++;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,11270,11323);

return (bool)f_1554_11283_11322(f_1554_11283_11309(convertExpressionAst), this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,10730,11334);

System.Management.Automation.Language.TypeConstraintAst
f_1554_10845_10870(System.Management.Automation.Language.ConvertExpressionAst
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 10845, 10870);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1554_10845_10879(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 10845, 10879);
return return_v;
}


System.Type
f_1554_10845_10899(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.GetReflectionType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 10845, 10899);
return return_v;
}


bool
f_1554_11013_11035(System.Type
type)
{
var return_v = type.IsSafePrimitive();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 11013, 11035);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1554_11283_11309(System.Management.Automation.Language.ConvertExpressionAst
this_param)
{
var return_v = this_param.Child;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 11283, 11309);
return return_v;
}


object
f_1554_11283_11322(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.IsSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 11283, 11322);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,10730,11334);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,10730,11334);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitConstantExpression(ConstantExpressionAst constantExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,11346,11504);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,11453,11467);

_visitCount++;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,11481,11493);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,11346,11504);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,11346,11504);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,11346,11504);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitStringConstantExpression(StringConstantExpressionAst stringConstantExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,11516,11692);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,11641,11655);

_visitCount++;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,11669,11681);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,11516,11692);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,11516,11692);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,11516,11692);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitSubExpression(SubExpressionAst subExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,11704,11858);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,11796,11847);

return f_1554_11803_11846(f_1554_11803_11833(subExpressionAst), this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,11704,11858);

System.Management.Automation.Language.StatementBlockAst
f_1554_11803_11833(System.Management.Automation.Language.SubExpressionAst
this_param)
{
var return_v = this_param.SubExpression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 11803, 11833);
return return_v;
}


object
f_1554_11803_11846(System.Management.Automation.Language.StatementBlockAst
this_param,System.Management.Automation.Language.IsSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 11803, 11846);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,11704,11858);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,11704,11858);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitUsingExpression(UsingExpressionAst usingExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,11870,12148);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,12056,12070);

_visitCount++;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,12084,12137);

return f_1554_12091_12136(f_1554_12091_12123(usingExpressionAst), this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,11870,12148);

System.Management.Automation.Language.ExpressionAst
f_1554_12091_12123(System.Management.Automation.Language.UsingExpressionAst
this_param)
{
var return_v = this_param.SubExpression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 12091, 12123);
return return_v;
}


object
f_1554_12091_12136(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.IsSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 12091, 12136);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,11870,12148);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,11870,12148);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitVariableExpression(VariableExpressionAst variableExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,12160,13372);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,12267,12281);

_visitCount++;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,12297,12818) || true) && (_safeValueContext == GetSafeValueVisitor.SafeValueContext.GetPowerShell)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,12297,12818);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,12791,12803);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,12297,12818);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,12834,13240) || true) && (_safeValueContext == GetSafeValueVisitor.SafeValueContext.ModuleAnalysis)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,12834,13240);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,12944,13225);

return f_1554_12951_12993(variableExpressionAst)||(DynAbs.Tracing.TraceSender.Expression_False(1554, 12951, 13224)||                       (f_1554_13022_13070(f_1554_13022_13056(variableExpressionAst))&&(DynAbs.Tracing.TraceSender.Expression_True(1554, 13022, 13223)&&f_1554_13099_13223(f_1554_13099_13149(f_1554_13099_13133(variableExpressionAst)), SpecialVariables.PSScriptRoot, StringComparison.OrdinalIgnoreCase))));
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,12834,13240);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,13256,13276);

bool 
unused = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,13290,13361);

return f_1554_13297_13360(variableExpressionAst, null, ref unused);
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,12160,13372);

bool
f_1554_12951_12993(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.IsConstantVariable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 12951, 12993);
return return_v;
}


System.Management.Automation.VariablePath
f_1554_13022_13056(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.VariablePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 13022, 13056);
return return_v;
}


bool
f_1554_13022_13070(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.IsUnqualified ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 13022, 13070);
return return_v;
}


System.Management.Automation.VariablePath
f_1554_13099_13133(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.VariablePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 13099, 13133);
return return_v;
}


string
f_1554_13099_13149(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.UnqualifiedPath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 13099, 13149);
return return_v;
}


bool
f_1554_13099_13223(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 13099, 13223);
return return_v;
}


bool
f_1554_13297_13360(System.Management.Automation.Language.VariableExpressionAst
this_param,System.Collections.Generic.HashSet<string>
validVariables,ref bool
usesParameter)
{
var return_v = this_param.IsSafeVariableReference( validVariables, ref usesParameter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 13297, 13360);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,12160,13372);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,12160,13372);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTypeExpression(TypeExpressionAst typeExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,13384,13737);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,13713,13726);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,13384,13737);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,13384,13737);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,13384,13737);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitMemberExpression(MemberExpressionAst memberExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,13749,13874);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,13850,13863);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,13749,13874);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,13749,13874);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,13749,13874);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitArrayExpression(ArrayExpressionAst arrayExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,13886,14126);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,14062,14115);

return f_1554_14069_14114(f_1554_14069_14101(arrayExpressionAst), this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,13886,14126);

System.Management.Automation.Language.StatementBlockAst
f_1554_14069_14101(System.Management.Automation.Language.ArrayExpressionAst
this_param)
{
var return_v = this_param.SubExpression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 14069, 14101);
return return_v;
}


object
f_1554_14069_14114(System.Management.Automation.Language.StatementBlockAst
this_param,System.Management.Automation.Language.IsSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 14069, 14114);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,13886,14126);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,13886,14126);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitArrayLiteral(ArrayLiteralAst arrayLiteralAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,14138,14377);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,14227,14297);

bool 
isSafe = f_1554_14241_14296(f_1554_14241_14265(arrayLiteralAst), e => (bool)e.Accept(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,14352,14366);

return isSafe;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,14138,14377);

System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
f_1554_14241_14265(System.Management.Automation.Language.ArrayLiteralAst
this_param)
{
var return_v = this_param.Elements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 14241, 14265);
return return_v;
}


bool
f_1554_14241_14296(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
source,System.Func<System.Management.Automation.Language.ExpressionAst, bool>
predicate)
{
var return_v = source.All<System.Management.Automation.Language.ExpressionAst>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 14241, 14296);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,14138,14377);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,14138,14377);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitHashtable(HashtableAst hashtableAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,14389,14727);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,14469,14590) || true) && (f_1554_14473_14505(f_1554_14473_14499(hashtableAst))> MaxHashtableKeyCount)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,14469,14590);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,14562,14575);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,14469,14590);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,14606,14716);

return f_1554_14613_14715(f_1554_14613_14639(hashtableAst), pair => (bool)pair.Item1.Accept(this) && (bool)pair.Item2.Accept(this));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,14389,14727);

System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
f_1554_14473_14499(System.Management.Automation.Language.HashtableAst
this_param)
{
var return_v = this_param.KeyValuePairs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 14473, 14499);
return return_v;
}


int
f_1554_14473_14505(System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 14473, 14505);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
f_1554_14613_14639(System.Management.Automation.Language.HashtableAst
this_param)
{
var return_v = this_param.KeyValuePairs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 14613, 14639);
return return_v;
}


bool
f_1554_14613_14715(System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
source,System.Func<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>, bool>
predicate)
{
var return_v = source.All<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 14613, 14715);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,14389,14727);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,14389,14727);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitScriptBlockExpression(ScriptBlockExpressionAst scriptBlockExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,14739,15017);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,14994,15006);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,14739,15017);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,14739,15017);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,14739,15017);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitParenExpression(ParenExpressionAst parenExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,15029,15186);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,15127,15175);

return f_1554_15134_15174(f_1554_15134_15161(parenExpressionAst), this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,15029,15186);

System.Management.Automation.Language.PipelineBaseAst
f_1554_15134_15161(System.Management.Automation.Language.ParenExpressionAst
this_param)
{
var return_v = this_param.Pipeline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 15134, 15161);
return return_v;
}


object
f_1554_15134_15174(System.Management.Automation.Language.PipelineBaseAst
this_param,System.Management.Automation.Language.IsSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 15134, 15174);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,15029,15186);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,15029,15186);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static IsSafeValueVisitor()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1554,2252,15193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,3083,3161);
Default = f_1554_3093_3161(GetSafeValueVisitor.SafeValueContext.Default);DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,3284,3304);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,3333,3359);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1554,2252,15193);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,2252,15193);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1554,2252,15193);

static System.Management.Automation.Language.IsSafeValueVisitor
f_1554_3093_3161(System.Management.Automation.Language.GetSafeValueVisitor.SafeValueContext
safeValueContext)
{
var return_v = new System.Management.Automation.Language.IsSafeValueVisitor( safeValueContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 3093, 3161);
return return_v;
}

}
internal class GetSafeValueVisitor : ICustomAstVisitor2
{        internal enum SafeValueContext
        {
            Default,
            GetPowerShell,
            ModuleAnalysis
        }

private GetSafeValueVisitor() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1554,15681,15714);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1554,15681,15714);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,15681,15714);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,15681,15714);
}
		}

public static object GetSafeValue(Ast ast, ExecutionContext context, SafeValueContext safeValueContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1554,15726,16250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,15854,15874);

t_context = context;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,15888,16037) || true) && (f_1554_15892_15943(ast, safeValueContext))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,15888,16037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,15977,16022);

return f_1554_15984_16021(ast, f_1554_15995_16020());
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,15888,16037);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,16053,16169) || true) && (safeValueContext == SafeValueContext.ModuleAnalysis)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,16053,16169);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,16142,16154);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,16053,16169);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,16185,16239);

throw f_1554_16191_16238(nameof(ast));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1554,15726,16250);

bool
f_1554_15892_15943(System.Management.Automation.Language.Ast
ast,System.Management.Automation.Language.GetSafeValueVisitor.SafeValueContext
safeValueContext)
{
var return_v = IsSafeValueVisitor.IsAstSafe( ast, safeValueContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 15892, 15943);
return return_v;
}


System.Management.Automation.Language.GetSafeValueVisitor
f_1554_15995_16020()
{
var return_v = new System.Management.Automation.Language.GetSafeValueVisitor();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 15995, 16020);
return return_v;
}


object
f_1554_15984_16021(System.Management.Automation.Language.Ast
this_param,System.Management.Automation.Language.GetSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 15984, 16021);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1554_16191_16238(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 16191, 16238);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,15726,16250);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,15726,16250);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[ThreadStatic]
        private static ExecutionContext t_context;

public object VisitErrorStatement(ErrorStatementAst errorStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,16473,16616);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,16546,16614);

throw f_1554_16552_16613(nameof(errorStatementAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,16473,16616);

System.Management.Automation.PSArgumentException
f_1554_16552_16613(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 16552, 16613);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,16473,16616);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,16473,16616);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitErrorExpression(ErrorExpressionAst errorExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,16628,16775);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,16704,16773);

throw f_1554_16710_16772(nameof(errorExpressionAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,16628,16775);

System.Management.Automation.PSArgumentException
f_1554_16710_16772(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 16710, 16772);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,16628,16775);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,16628,16775);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitScriptBlock(ScriptBlockAst scriptBlockAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,16787,16918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,16851,16916);

throw f_1554_16857_16915(nameof(scriptBlockAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,16787,16918);

System.Management.Automation.PSArgumentException
f_1554_16857_16915(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 16857, 16915);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,16787,16918);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,16787,16918);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitParamBlock(ParamBlockAst paramBlockAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,16930,17057);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,16991,17055);

throw f_1554_16997_17054(nameof(paramBlockAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,16930,17057);

System.Management.Automation.PSArgumentException
f_1554_16997_17054(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 16997, 17054);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,16930,17057);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,16930,17057);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitNamedBlock(NamedBlockAst namedBlockAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,17069,17196);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,17130,17194);

throw f_1554_17136_17193(nameof(namedBlockAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,17069,17196);

System.Management.Automation.PSArgumentException
f_1554_17136_17193(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 17136, 17193);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,17069,17196);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,17069,17196);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTypeConstraint(TypeConstraintAst typeConstraintAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,17208,17351);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,17281,17349);

throw f_1554_17287_17348(nameof(typeConstraintAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,17208,17351);

System.Management.Automation.PSArgumentException
f_1554_17287_17348(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 17287, 17348);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,17208,17351);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,17208,17351);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitAttribute(AttributeAst attributeAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,17363,17486);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,17421,17484);

throw f_1554_17427_17483(nameof(attributeAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,17363,17486);

System.Management.Automation.PSArgumentException
f_1554_17427_17483(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 17427, 17483);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,17363,17486);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,17363,17486);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitNamedAttributeArgument(NamedAttributeArgumentAst namedAttributeArgumentAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,17498,17673);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,17595,17671);

throw f_1554_17601_17670(nameof(namedAttributeArgumentAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,17498,17673);

System.Management.Automation.PSArgumentException
f_1554_17601_17670(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 17601, 17670);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,17498,17673);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,17498,17673);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitParameter(ParameterAst parameterAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,17685,17808);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,17743,17806);

throw f_1554_17749_17805(nameof(parameterAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,17685,17808);

System.Management.Automation.PSArgumentException
f_1554_17749_17805(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 17749, 17805);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,17685,17808);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,17685,17808);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitFunctionDefinition(FunctionDefinitionAst functionDefinitionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,17820,17979);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,17905,17977);

throw f_1554_17911_17976(nameof(functionDefinitionAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,17820,17979);

System.Management.Automation.PSArgumentException
f_1554_17911_17976(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 17911, 17976);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,17820,17979);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,17820,17979);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitIfStatement(IfStatementAst ifStmtAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,17991,18112);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,18050,18110);

throw f_1554_18056_18109(nameof(ifStmtAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,17991,18112);

System.Management.Automation.PSArgumentException
f_1554_18056_18109(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 18056, 18109);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,17991,18112);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,17991,18112);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTrap(TrapStatementAst trapStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,18124,18254);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,18185,18252);

throw f_1554_18191_18251(nameof(trapStatementAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,18124,18254);

System.Management.Automation.PSArgumentException
f_1554_18191_18251(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 18191, 18251);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,18124,18254);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,18124,18254);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitSwitchStatement(SwitchStatementAst switchStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,18266,18413);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,18342,18411);

throw f_1554_18348_18410(nameof(switchStatementAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,18266,18413);

System.Management.Automation.PSArgumentException
f_1554_18348_18410(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 18348, 18410);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,18266,18413);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,18266,18413);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitDataStatement(DataStatementAst dataStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,18425,18564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,18495,18562);

throw f_1554_18501_18561(nameof(dataStatementAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,18425,18564);

System.Management.Automation.PSArgumentException
f_1554_18501_18561(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 18501, 18561);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,18425,18564);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,18425,18564);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitForEachStatement(ForEachStatementAst forEachStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,18576,18727);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,18655,18725);

throw f_1554_18661_18724(nameof(forEachStatementAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,18576,18727);

System.Management.Automation.PSArgumentException
f_1554_18661_18724(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 18661, 18724);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,18576,18727);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,18576,18727);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitDoWhileStatement(DoWhileStatementAst doWhileStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,18739,18890);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,18818,18888);

throw f_1554_18824_18887(nameof(doWhileStatementAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,18739,18890);

System.Management.Automation.PSArgumentException
f_1554_18824_18887(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 18824, 18887);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,18739,18890);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,18739,18890);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitForStatement(ForStatementAst forStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,18902,19037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,18969,19035);

throw f_1554_18975_19034(nameof(forStatementAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,18902,19037);

System.Management.Automation.PSArgumentException
f_1554_18975_19034(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 18975, 19034);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,18902,19037);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,18902,19037);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitWhileStatement(WhileStatementAst whileStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,19049,19192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,19122,19190);

throw f_1554_19128_19189(nameof(whileStatementAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,19049,19192);

System.Management.Automation.PSArgumentException
f_1554_19128_19189(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 19128, 19189);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,19049,19192);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,19049,19192);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitCatchClause(CatchClauseAst catchClauseAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,19204,19335);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,19268,19333);

throw f_1554_19274_19332(nameof(catchClauseAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,19204,19335);

System.Management.Automation.PSArgumentException
f_1554_19274_19332(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 19274, 19332);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,19204,19335);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,19204,19335);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTryStatement(TryStatementAst tryStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,19347,19482);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,19414,19480);

throw f_1554_19420_19479(nameof(tryStatementAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,19347,19482);

System.Management.Automation.PSArgumentException
f_1554_19420_19479(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 19420, 19479);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,19347,19482);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,19347,19482);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitBreakStatement(BreakStatementAst breakStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,19494,19637);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,19567,19635);

throw f_1554_19573_19634(nameof(breakStatementAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,19494,19637);

System.Management.Automation.PSArgumentException
f_1554_19573_19634(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 19573, 19634);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,19494,19637);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,19494,19637);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitContinueStatement(ContinueStatementAst continueStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,19649,19804);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,19731,19802);

throw f_1554_19737_19801(nameof(continueStatementAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,19649,19804);

System.Management.Automation.PSArgumentException
f_1554_19737_19801(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 19737, 19801);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,19649,19804);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,19649,19804);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitReturnStatement(ReturnStatementAst returnStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,19816,19963);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,19892,19961);

throw f_1554_19898_19960(nameof(returnStatementAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,19816,19963);

System.Management.Automation.PSArgumentException
f_1554_19898_19960(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 19898, 19960);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,19816,19963);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,19816,19963);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitExitStatement(ExitStatementAst exitStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,19975,20114);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,20045,20112);

throw f_1554_20051_20111(nameof(exitStatementAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,19975,20114);

System.Management.Automation.PSArgumentException
f_1554_20051_20111(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 20051, 20111);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,19975,20114);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,19975,20114);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitThrowStatement(ThrowStatementAst throwStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,20126,20269);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,20199,20267);

throw f_1554_20205_20266(nameof(throwStatementAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,20126,20269);

System.Management.Automation.PSArgumentException
f_1554_20205_20266(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 20205, 20266);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,20126,20269);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,20126,20269);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitDoUntilStatement(DoUntilStatementAst doUntilStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,20281,20432);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,20360,20430);

throw f_1554_20366_20429(nameof(doUntilStatementAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,20281,20432);

System.Management.Automation.PSArgumentException
f_1554_20366_20429(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 20366, 20429);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,20281,20432);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,20281,20432);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitAssignmentStatement(AssignmentStatementAst assignmentStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,20444,20607);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,20532,20605);

throw f_1554_20538_20604(nameof(assignmentStatementAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,20444,20607);

System.Management.Automation.PSArgumentException
f_1554_20538_20604(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 20538, 20604);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,20444,20607);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,20444,20607);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitCommand(CommandAst commandAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,20619,20734);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,20671,20732);

throw f_1554_20677_20731(nameof(commandAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,20619,20734);

System.Management.Automation.PSArgumentException
f_1554_20677_20731(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 20677, 20731);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,20619,20734);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,20619,20734);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitCommandExpression(CommandExpressionAst commandExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,20746,20901);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,20828,20899);

throw f_1554_20834_20898(nameof(commandExpressionAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,20746,20901);

System.Management.Automation.PSArgumentException
f_1554_20834_20898(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 20834, 20898);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,20746,20901);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,20746,20901);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitCommandParameter(CommandParameterAst commandParameterAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,20913,21064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,20992,21062);

throw f_1554_20998_21061(nameof(commandParameterAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,20913,21064);

System.Management.Automation.PSArgumentException
f_1554_20998_21061(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 20998, 21061);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,20913,21064);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,20913,21064);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitFileRedirection(FileRedirectionAst fileRedirectionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,21076,21223);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,21152,21221);

throw f_1554_21158_21220(nameof(fileRedirectionAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,21076,21223);

System.Management.Automation.PSArgumentException
f_1554_21158_21220(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 21158, 21220);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,21076,21223);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,21076,21223);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitMergingRedirection(MergingRedirectionAst mergingRedirectionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,21235,21394);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,21320,21392);

throw f_1554_21326_21391(nameof(mergingRedirectionAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,21235,21394);

System.Management.Automation.PSArgumentException
f_1554_21326_21391(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 21326, 21391);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,21235,21394);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,21235,21394);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitAttributedExpression(AttributedExpressionAst attributedExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,21406,21573);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,21497,21571);

throw f_1554_21503_21570(nameof(attributedExpressionAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,21406,21573);

System.Management.Automation.PSArgumentException
f_1554_21503_21570(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 21503, 21570);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,21406,21573);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,21406,21573);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitBlockStatement(BlockStatementAst blockStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,21585,21728);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,21658,21726);

throw f_1554_21664_21725(nameof(blockStatementAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,21585,21728);

System.Management.Automation.PSArgumentException
f_1554_21664_21725(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 21664, 21725);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,21585,21728);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,21585,21728);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitInvokeMemberExpression(InvokeMemberExpressionAst invokeMemberExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,21740,21915);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,21837,21913);

throw f_1554_21843_21912(nameof(invokeMemberExpressionAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,21740,21915);

System.Management.Automation.PSArgumentException
f_1554_21843_21912(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 21843, 21912);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,21740,21915);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,21740,21915);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTypeDefinition(TypeDefinitionAst typeDefinitionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,21927,22070);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,22000,22068);

throw f_1554_22006_22067(nameof(typeDefinitionAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,21927,22070);

System.Management.Automation.PSArgumentException
f_1554_22006_22067(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 22006, 22067);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,21927,22070);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,21927,22070);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitPropertyMember(PropertyMemberAst propertyMemberAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,22082,22225);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,22155,22223);

throw f_1554_22161_22222(nameof(propertyMemberAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,22082,22225);

System.Management.Automation.PSArgumentException
f_1554_22161_22222(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 22161, 22222);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,22082,22225);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,22082,22225);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitFunctionMember(FunctionMemberAst functionMemberAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,22237,22380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,22310,22378);

throw f_1554_22316_22377(nameof(functionMemberAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,22237,22380);

System.Management.Automation.PSArgumentException
f_1554_22316_22377(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 22316, 22377);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,22237,22380);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,22237,22380);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitBaseCtorInvokeMemberExpression(BaseCtorInvokeMemberExpressionAst baseCtorInvokeMemberExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,22392,22599);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,22513,22597);

throw f_1554_22519_22596(nameof(baseCtorInvokeMemberExpressionAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,22392,22599);

System.Management.Automation.PSArgumentException
f_1554_22519_22596(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 22519, 22596);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,22392,22599);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,22392,22599);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitUsingStatement(UsingStatementAst usingStatement) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,22611,22748);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,22681,22746);

throw f_1554_22687_22745(nameof(usingStatement));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,22611,22748);

System.Management.Automation.PSArgumentException
f_1554_22687_22745(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 22687, 22745);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,22611,22748);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,22611,22748);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitConfigurationDefinition(ConfigurationDefinitionAst configurationDefinitionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,22760,22939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,22860,22937);

throw f_1554_22866_22936(nameof(configurationDefinitionAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,22760,22939);

System.Management.Automation.PSArgumentException
f_1554_22866_22936(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 22866, 22936);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,22760,22939);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,22760,22939);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitDynamicKeywordStatement(DynamicKeywordStatementAst dynamicKeywordAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,22951,23112);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,23042,23110);

throw f_1554_23048_23109(nameof(dynamicKeywordAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,22951,23112);

System.Management.Automation.PSArgumentException
f_1554_23048_23109(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 23048, 23109);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,22951,23112);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,22951,23112);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object GetSingleValueFromTarget(object target, object index)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,23524,24874);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,23617,23653);

var 
targetString = target as string
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,23667,24005) || true) && (targetString != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,23667,24005);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,23725,23749);

var 
offset = (int)index
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,23767,23883) || true) && (f_1554_23771_23787(offset)>= f_1554_23791_23810(targetString))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,23767,23883);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,23852,23864);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,23767,23883);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,23903,23990);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1554, 23910, 23921)||((offset >= 0 &&DynAbs.Tracing.TraceSender.Conditional_F2(1554, 23924, 23944))||DynAbs.Tracing.TraceSender.Conditional_F3(1554, 23947, 23989)))?f_1554_23924_23944(targetString, offset):f_1554_23947_23989(targetString, f_1554_23960_23979(targetString)+ offset);
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,23667,24005);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,24021,24058);

var 
targetArray = target as object[]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,24072,24472) || true) && (targetArray != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,24072,24472);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,24196,24220);

var 
offset = (int)index
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,24238,24353) || true) && (f_1554_24242_24258(offset)>= f_1554_24262_24280(targetArray))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,24238,24353);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,24322,24334);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,24238,24353);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,24373,24457);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1554, 24380, 24391)||((offset >= 0 &&DynAbs.Tracing.TraceSender.Conditional_F2(1554, 24394, 24413))||DynAbs.Tracing.TraceSender.Conditional_F3(1554, 24416, 24456)))?targetArray[offset] :targetArray[f_1554_24428_24446(targetArray)+ offset];
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,24072,24472);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,24488,24530);

var 
targetHashtable = target as Hashtable
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,24544,24650) || true) && (targetHashtable != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,24544,24650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,24605,24635);

return f_1554_24612_24634(targetHashtable, index);
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,24544,24650);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,24841,24863);

throw f_1554_24847_24862();
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,23524,24874);

int
f_1554_23771_23787(int
value)
{
var return_v = Math.Abs( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 23771, 23787);
return return_v;
}


int
f_1554_23791_23810(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 23791, 23810);
return return_v;
}


char
f_1554_23924_23944(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 23924, 23944);
return return_v;
}


int
f_1554_23960_23979(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 23960, 23979);
return return_v;
}


char
f_1554_23947_23989(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 23947, 23989);
return return_v;
}


int
f_1554_24242_24258(int
value)
{
var return_v = Math.Abs( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 24242, 24258);
return return_v;
}


int
f_1554_24262_24280(object[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 24262, 24280);
return return_v;
}


int
f_1554_24428_24446(object[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 24428, 24446);
return return_v;
}


object
f_1554_24612_24634(System.Collections.Hashtable
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 24612, 24634);
return return_v;
}


System.Exception
f_1554_24847_24862()
{
var return_v = new System.Exception();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 24847, 24862);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,23524,24874);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,23524,24874);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private object GetIndexedValueFromTarget(object target, object index)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,24886,25192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,24980,25015);

var 
indexArray = index as object[]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,25029,25181);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1554, 25036, 25054)||((indexArray != null &&DynAbs.Tracing.TraceSender.Conditional_F2(1554, 25057, 25138))||DynAbs.Tracing.TraceSender.Conditional_F3(1554, 25141, 25180)))?f_1554_25057_25138(f_1554_25057_25128(((object[])indexArray), i => GetSingleValueFromTarget(target, i))):f_1554_25141_25180(this, target, index);
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,24886,25192);

System.Collections.Generic.IEnumerable<object>
f_1554_25057_25128(object[]
source,System.Func<object, object>
selector)
{
var return_v = source.Select<object,object>( selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 25057, 25128);
return return_v;
}


object[]
f_1554_25057_25138(System.Collections.Generic.IEnumerable<object>
source)
{
var return_v = source.ToArray<object>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 25057, 25138);
return return_v;
}


object
f_1554_25141_25180(System.Management.Automation.Language.GetSafeValueVisitor
this_param,object
target,object
index)
{
var return_v = this_param.GetSingleValueFromTarget( target, index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 25141, 25180);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,24886,25192);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,24886,25192);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitIndexExpression(IndexExpressionAst indexExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,25204,25720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,25377,25427);

var 
index = f_1554_25389_25426(f_1554_25389_25413(indexExpressionAst), this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,25441,25493);

var 
target = f_1554_25454_25492(f_1554_25454_25479(indexExpressionAst), this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,25507,25645) || true) && (index == null ||(DynAbs.Tracing.TraceSender.Expression_False(1554, 25511, 25542)||target == null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,25507,25645);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,25576,25630);

throw f_1554_25582_25629("indexExpressionAst");
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,25507,25645);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,25661,25709);

return f_1554_25668_25708(this, target, index);
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,25204,25720);

System.Management.Automation.Language.ExpressionAst
f_1554_25389_25413(System.Management.Automation.Language.IndexExpressionAst
this_param)
{
var return_v = this_param.Index;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 25389, 25413);
return return_v;
}


object
f_1554_25389_25426(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.GetSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 25389, 25426);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1554_25454_25479(System.Management.Automation.Language.IndexExpressionAst
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 25454, 25479);
return return_v;
}


object
f_1554_25454_25492(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.GetSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 25454, 25492);
return return_v;
}


System.ArgumentNullException
f_1554_25582_25629(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 25582, 25629);
return return_v;
}


object
f_1554_25668_25708(System.Management.Automation.Language.GetSafeValueVisitor
this_param,object
target,object
index)
{
var return_v = this_param.GetIndexedValueFromTarget( target, index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 25668, 25708);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,25204,25720);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,25204,25720);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitExpandableStringExpression(ExpandableStringExpressionAst expandableStringExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,25732,29655);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,25863,25951);

object[] 
safeValues = new object[f_1554_25896_25949(f_1554_25896_25943(expandableStringExpressionAst))]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,26035,26053);

string 
ofs = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,26067,26203) || true) && (t_context != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,26067,26203);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,26122,26188);

ofs = f_1554_26128_26177(f_1554_26128_26161(f_1554_26128_26150(t_context)), "OFS")as string;
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,26067,26203);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,26219,26293) || true) && (ofs == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,26219,26293);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,26268,26278);

ofs = " ";
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,26219,26293);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,26318,26328);

            for (int 
offset = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,26309,29543) || true) && (offset < f_1554_26339_26356(safeValues))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,26358,26366)
,offset++,DynAbs.Tracing.TraceSender.TraceExitCondition(1554,26309,29543))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,26309,29543);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,26400,26482);

var 
result = f_1554_26413_26481(f_1554_26413_26468(f_1554_26413_26460(expandableStringExpressionAst), offset), this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,27735,27772);

var 
resultArray = result as object[]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,28344,29528) || true) && (resultArray != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,28344,29528);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,28409,28471);

object[] 
subExpressionResult = new object[f_1554_28451_28469(resultArray)]
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,28502,28525);
                    for (int 
subExpressionOffset = 0
;
(DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,28493,29316) || true) && (subExpressionOffset < f_1554_28574_28600(subExpressionResult))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,28627,28648)
,                        subExpressionOffset++,DynAbs.Tracing.TraceSender.TraceExitCondition(1554,28493,29316))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,28493,29316);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,28774,28840);

object[] 
subResult = resultArray[subExpressionOffset] as object[]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,28866,29293) || true) && (subResult != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,28866,29293);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,28945,29016);

subExpressionResult[subExpressionOffset] = f_1554_28988_29015(ofs, subResult);
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,28866,29293);
}

else // it is a scalar, so we can just add it to our collections

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,28866,29293);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,29190,29266);

subExpressionResult[subExpressionOffset] = resultArray[subExpressionOffset];
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,28866,29293);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1554,1,824);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1554,1,824);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,29340,29399);

safeValues[offset] = f_1554_29361_29398(ofs, subExpressionResult);
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,28344,29528);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,28344,29528);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,29481,29509);

safeValues[offset] = result;
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,28344,29528);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1554,1,3235);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1554,1,3235);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,29559,29644);

return f_1554_29566_29643(f_1554_29584_29630(expandableStringExpressionAst), safeValues);
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,25732,29655);

System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
f_1554_25896_25943(System.Management.Automation.Language.ExpandableStringExpressionAst
this_param)
{
var return_v = this_param.NestedExpressions;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 25896, 25943);
return return_v;
}


int
f_1554_25896_25949(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 25896, 25949);
return return_v;
}


System.Management.Automation.SessionState
f_1554_26128_26150(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 26128, 26150);
return return_v;
}


System.Management.Automation.PSVariableIntrinsics
f_1554_26128_26161(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.PSVariable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 26128, 26161);
return return_v;
}


object
f_1554_26128_26177(System.Management.Automation.PSVariableIntrinsics
this_param,string
name)
{
var return_v = this_param.GetValue( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 26128, 26177);
return return_v;
}


int
f_1554_26339_26356(object[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 26339, 26356);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
f_1554_26413_26460(System.Management.Automation.Language.ExpandableStringExpressionAst
this_param)
{
var return_v = this_param.NestedExpressions;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 26413, 26460);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1554_26413_26468(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 26413, 26468);
return return_v;
}


object
f_1554_26413_26481(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.GetSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 26413, 26481);
return return_v;
}


int
f_1554_28451_28469(object[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 28451, 28469);
return return_v;
}


int
f_1554_28574_28600(object[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 28574, 28600);
return return_v;
}


string
f_1554_28988_29015(string
separator,params object[]
values)
{
var return_v = string.Join( separator, values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 28988, 29015);
return return_v;
}


string
f_1554_29361_29398(string
separator,params object[]
values)
{
var return_v = string.Join( separator, values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 29361, 29398);
return return_v;
}


string
f_1554_29584_29630(System.Management.Automation.Language.ExpandableStringExpressionAst
this_param)
{
var return_v = this_param.FormatExpression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 29584, 29630);
return return_v;
}


string
f_1554_29566_29643(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 29566, 29643);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,25732,29655);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,25732,29655);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitStatementBlock(StatementBlockAst statementBlockAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,29667,30710);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,29762,29804);

ArrayList 
statementList = f_1554_29788_29803()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,29818,30652);
foreach(var statement in f_1554_29844_29872_I(f_1554_29844_29872(statementBlockAst)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,29818,30652);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,29906,30637) || true) && (statement != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,29906,30637);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,29969,30002);

var 
obj = f_1554_29979_30001(statement, this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,30024,30079);

var 
enumerator = f_1554_30041_30078(obj)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,30101,30468) || true) && (enumerator != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,30101,30468);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,30173,30324) || true) && (f_1554_30180_30201(enumerator))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,30173,30324);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,30259,30297);

f_1554_30259_30296(                            statementList, f_1554_30277_30295(enumerator));
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,30173,30324);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1554,30173,30324);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1554,30173,30324);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1554,30101,30468);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,30101,30468);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,30422,30445);

f_1554_30422_30444(                        statementList, obj);
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,30101,30468);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,29906,30637);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,29906,30637);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,30550,30618);

throw f_1554_30556_30617(nameof(statementBlockAst));
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,29906,30637);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,29818,30652);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1554,1,835);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1554,1,835);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,30668,30699);

return f_1554_30675_30698(statementList);
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,29667,30710);

System.Collections.ArrayList
f_1554_29788_29803()
{
var return_v = new System.Collections.ArrayList();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 29788, 29803);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
f_1554_29844_29872(System.Management.Automation.Language.StatementBlockAst
this_param)
{
var return_v = this_param.Statements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 29844, 29872);
return return_v;
}


object
f_1554_29979_30001(System.Management.Automation.Language.StatementAst
this_param,System.Management.Automation.Language.GetSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 29979, 30001);
return return_v;
}


System.Collections.IEnumerator
f_1554_30041_30078(object
obj)
{
var return_v = LanguagePrimitives.GetEnumerator( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 30041, 30078);
return return_v;
}


bool
f_1554_30180_30201(System.Collections.IEnumerator
this_param)
{
var return_v = this_param.MoveNext();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 30180, 30201);
return return_v;
}


object
f_1554_30277_30295(System.Collections.IEnumerator
this_param)
{
var return_v = this_param.Current;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 30277, 30295);
return return_v;
}


int
f_1554_30259_30296(System.Collections.ArrayList
this_param,object
value)
{
var return_v = this_param.Add( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 30259, 30296);
return return_v;
}


int
f_1554_30422_30444(System.Collections.ArrayList
this_param,object
value)
{
var return_v = this_param.Add( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 30422, 30444);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1554_30556_30617(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 30556, 30617);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
f_1554_29844_29872_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 29844, 29872);
return return_v;
}


object?[]
f_1554_30675_30698(System.Collections.ArrayList
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 30675, 30698);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,29667,30710);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,29667,30710);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitPipeline(PipelineAst pipelineAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,30722,31035);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,30799,30842);

var 
expr = f_1554_30810_30841(pipelineAst)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,30856,30946) || true) && (expr != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,30856,30946);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,30906,30931);

return f_1554_30913_30930(expr, this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,30856,30946);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,30962,31024);

throw f_1554_30968_31023(nameof(pipelineAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,30722,31035);

System.Management.Automation.Language.ExpressionAst
f_1554_30810_30841(System.Management.Automation.Language.PipelineAst
this_param)
{
var return_v = this_param.GetPureExpression();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 30810, 30841);
return return_v;
}


object
f_1554_30913_30930(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.GetSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 30913, 30930);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1554_30968_31023(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 30968, 31023);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,30722,31035);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,30722,31035);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTernaryExpression(TernaryExpressionAst ternaryExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,31047,31428);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,31151,31292) || true) && (t_context == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,31151,31292);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,31206,31277);

throw f_1554_31212_31276(nameof(ternaryExpressionAst));
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,31151,31292);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,31308,31417);

return f_1554_31315_31416(ternaryExpressionAst, isTrustedInput: true, t_context, usingValues: null);
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,31047,31428);

System.Management.Automation.PSArgumentException
f_1554_31212_31276(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 31212, 31276);
return return_v;
}


object
f_1554_31315_31416(System.Management.Automation.Language.TernaryExpressionAst
expressionAst,bool
isTrustedInput,System.Management.Automation.ExecutionContext
context,System.Collections.IDictionary
usingValues)
{
var return_v = Compiler.GetExpressionValue( (System.Management.Automation.Language.ExpressionAst)expressionAst, isTrustedInput: isTrustedInput, context, usingValues: usingValues);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 31315, 31416);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,31047,31428);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,31047,31428);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitBinaryExpression(BinaryExpressionAst binaryExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,31440,31849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,31768,31838);

throw f_1554_31774_31837(nameof(binaryExpressionAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,31440,31849);

System.Management.Automation.PSArgumentException
f_1554_31774_31837(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 31774, 31837);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,31440,31849);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,31440,31849);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitUnaryExpression(UnaryExpressionAst unaryExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,31861,32232);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,31959,32098) || true) && (t_context == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,31959,32098);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,32014,32083);

throw f_1554_32020_32082(nameof(unaryExpressionAst));
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,31959,32098);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,32114,32221);

return f_1554_32121_32220(unaryExpressionAst, isTrustedInput: true, t_context, usingValues: null);
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,31861,32232);

System.Management.Automation.PSArgumentException
f_1554_32020_32082(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 32020, 32082);
return return_v;
}


object
f_1554_32121_32220(System.Management.Automation.Language.UnaryExpressionAst
expressionAst,bool
isTrustedInput,System.Management.Automation.ExecutionContext
context,System.Collections.IDictionary
usingValues)
{
var return_v = Compiler.GetExpressionValue( (System.Management.Automation.Language.ExpressionAst)expressionAst, isTrustedInput: isTrustedInput, context, usingValues: usingValues);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 32121, 32220);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,31861,32232);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,31861,32232);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitConvertExpression(ConvertExpressionAst convertExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,32244,32823);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,32546,32687) || true) && (t_context == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,32546,32687);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,32601,32672);

throw f_1554_32607_32671(nameof(convertExpressionAst));
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,32546,32687);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,32703,32812);

return f_1554_32710_32811(convertExpressionAst, isTrustedInput: true, t_context, usingValues: null);
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,32244,32823);

System.Management.Automation.PSArgumentException
f_1554_32607_32671(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 32607, 32671);
return return_v;
}


object
f_1554_32710_32811(System.Management.Automation.Language.ConvertExpressionAst
expressionAst,bool
isTrustedInput,System.Management.Automation.ExecutionContext
context,System.Collections.IDictionary
usingValues)
{
var return_v = Compiler.GetExpressionValue( (System.Management.Automation.Language.ExpressionAst)expressionAst, isTrustedInput: isTrustedInput, context, usingValues: usingValues);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 32710, 32811);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,32244,32823);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,32244,32823);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitConstantExpression(ConstantExpressionAst constantExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,32835,32988);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,32942,32977);

return f_1554_32949_32976(constantExpressionAst);
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,32835,32988);

object
f_1554_32949_32976(System.Management.Automation.Language.ConstantExpressionAst
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 32949, 32976);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,32835,32988);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,32835,32988);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitStringConstantExpression(StringConstantExpressionAst stringConstantExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,33000,33177);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,33125,33166);

return f_1554_33132_33165(stringConstantExpressionAst);
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,33000,33177);

string
f_1554_33132_33165(System.Management.Automation.Language.StringConstantExpressionAst
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 33132, 33165);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,33000,33177);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,33000,33177);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitSubExpression(SubExpressionAst subExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,33189,33343);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,33281,33332);

return f_1554_33288_33331(f_1554_33288_33318(subExpressionAst), this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,33189,33343);

System.Management.Automation.Language.StatementBlockAst
f_1554_33288_33318(System.Management.Automation.Language.SubExpressionAst
this_param)
{
var return_v = this_param.SubExpression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 33288, 33318);
return return_v;
}


object
f_1554_33288_33331(System.Management.Automation.Language.StatementBlockAst
this_param,System.Management.Automation.Language.GetSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 33288, 33331);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,33189,33343);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,33189,33343);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitUsingExpression(UsingExpressionAst usingExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,33355,33605);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,33541,33594);

return f_1554_33548_33593(f_1554_33548_33580(usingExpressionAst), this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,33355,33605);

System.Management.Automation.Language.ExpressionAst
f_1554_33548_33580(System.Management.Automation.Language.UsingExpressionAst
this_param)
{
var return_v = this_param.SubExpression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 33548, 33580);
return return_v;
}


object
f_1554_33548_33593(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.GetSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 33548, 33593);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,33355,33605);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,33355,33605);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitVariableExpression(VariableExpressionAst variableExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,33617,35213);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,33989,34054);

string 
name = f_1554_34003_34053(f_1554_34003_34037(variableExpressionAst))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,34068,34576) || true) && (f_1554_34072_34114(variableExpressionAst))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,34068,34576);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,34148,34257) || true) && (f_1554_34152_34222(name, SpecialVariables.True, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,34148,34257);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,34245,34257);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,34148,34257);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,34277,34388) || true) && (f_1554_34281_34352(name, SpecialVariables.False, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,34277,34388);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,34375,34388);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,34277,34388);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,34408,34531);

f_1554_34408_34530(f_1554_34427_34497(name, SpecialVariables.Null, StringComparison.OrdinalIgnoreCase), "Unexpected constant variable");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,34549,34561);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,34068,34576);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,34592,34922) || true) && (f_1554_34596_34674(name, SpecialVariables.PSScriptRoot, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,34592,34922);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,34708,34763);

var 
scriptFileName = f_1554_34729_34762(f_1554_34729_34757(variableExpressionAst))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,34781,34842) || true) && (scriptFileName == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,34781,34842);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,34830,34842);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,34781,34842);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,34862,34907);

return f_1554_34869_34906(scriptFileName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,34592,34922);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,34938,35114) || true) && (t_context != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,34938,35114);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,34993,35099);

return f_1554_35000_35098(f_1554_35029_35063(variableExpressionAst), t_context, variableExpressionAst);
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,34938,35114);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,35130,35202);

throw f_1554_35136_35201(nameof(variableExpressionAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,33617,35213);

System.Management.Automation.VariablePath
f_1554_34003_34037(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.VariablePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 34003, 34037);
return return_v;
}


string
f_1554_34003_34053(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.UnqualifiedPath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 34003, 34053);
return return_v;
}


bool
f_1554_34072_34114(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.IsConstantVariable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 34072, 34114);
return return_v;
}


bool
f_1554_34152_34222(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 34152, 34222);
return return_v;
}


bool
f_1554_34281_34352(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 34281, 34352);
return return_v;
}


bool
f_1554_34427_34497(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 34427, 34497);
return return_v;
}


int
f_1554_34408_34530(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 34408, 34530);
return 0;
}


bool
f_1554_34596_34674(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 34596, 34674);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1554_34729_34757(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 34729, 34757);
return return_v;
}


string
f_1554_34729_34762(System.Management.Automation.Language.IScriptExtent
this_param)
{
var return_v = this_param.File;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 34729, 34762);
return return_v;
}


string?
f_1554_34869_34906(string
path)
{
var return_v = Path.GetDirectoryName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 34869, 34906);
return return_v;
}


System.Management.Automation.VariablePath
f_1554_35029_35063(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.VariablePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 35029, 35063);
return return_v;
}


object
f_1554_35000_35098(System.Management.Automation.VariablePath
variablePath,System.Management.Automation.ExecutionContext
executionContext,System.Management.Automation.Language.VariableExpressionAst
varAst)
{
var return_v = VariableOps.GetVariableValue( variablePath, executionContext, varAst);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 35000, 35098);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1554_35136_35201(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 35136, 35201);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,33617,35213);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,33617,35213);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitTypeExpression(TypeExpressionAst typeExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,35225,35633);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,35554,35622);

throw f_1554_35560_35621(nameof(typeExpressionAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,35225,35633);

System.Management.Automation.PSArgumentException
f_1554_35560_35621(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 35560, 35621);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,35225,35633);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,35225,35633);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitMemberExpression(MemberExpressionAst memberExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,35645,35827);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,35746,35816);

throw f_1554_35752_35815(nameof(memberExpressionAst));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,35645,35827);

System.Management.Automation.PSArgumentException
f_1554_35752_35815(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 35752, 35815);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,35645,35827);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,35645,35827);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitArrayExpression(ArrayExpressionAst arrayExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,35839,36159);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,36015,36102);

var 
arrayExpressionAstResult = (object[])f_1554_36056_36101(f_1554_36056_36088(arrayExpressionAst), this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,36116,36148);

return arrayExpressionAstResult;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,35839,36159);

System.Management.Automation.Language.StatementBlockAst
f_1554_36056_36088(System.Management.Automation.Language.ArrayExpressionAst
this_param)
{
var return_v = this_param.SubExpression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 36056, 36088);
return return_v;
}


object
f_1554_36056_36101(System.Management.Automation.Language.StatementBlockAst
this_param,System.Management.Automation.Language.GetSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 36056, 36101);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,35839,36159);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,35839,36159);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitArrayLiteral(ArrayLiteralAst arrayLiteralAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,36171,36552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,36301,36343);

ArrayList 
arrayElements = f_1554_36327_36342()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,36357,36494);
foreach(var element in f_1554_36381_36405_I(f_1554_36381_36405(arrayLiteralAst)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,36357,36494);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,36439,36479);

f_1554_36439_36478(                arrayElements, f_1554_36457_36477(element, this));
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,36357,36494);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1554,1,138);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1554,1,138);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,36510,36541);

return f_1554_36517_36540(arrayElements);
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,36171,36552);

System.Collections.ArrayList
f_1554_36327_36342()
{
var return_v = new System.Collections.ArrayList();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 36327, 36342);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
f_1554_36381_36405(System.Management.Automation.Language.ArrayLiteralAst
this_param)
{
var return_v = this_param.Elements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 36381, 36405);
return return_v;
}


object
f_1554_36457_36477(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.GetSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 36457, 36477);
return return_v;
}


int
f_1554_36439_36478(System.Collections.ArrayList
this_param,object
value)
{
var return_v = this_param.Add( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 36439, 36478);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
f_1554_36381_36405_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 36381, 36405);
return return_v;
}


object?[]
f_1554_36517_36540(System.Collections.ArrayList
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 36517, 36540);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,36171,36552);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,36171,36552);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitHashtable(HashtableAst hashtableAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,36564,37007);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,36644,36721);

Hashtable 
hashtable = f_1554_36666_36720(f_1554_36680_36719())
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,36735,36963);
foreach(var pair in f_1554_36756_36782_I(f_1554_36756_36782(hashtableAst)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1554,36735,36963);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,36816,36850);

var 
key = f_1554_36826_36849(f_1554_36826_36836(pair), this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,36868,36904);

var 
value = f_1554_36880_36903(f_1554_36880_36890(pair), this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,36922,36948);

f_1554_36922_36947(                hashtable, key, value);
DynAbs.Tracing.TraceSender.TraceExitCondition(1554,36735,36963);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1554,1,229);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1554,1,229);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,36979,36996);

return hashtable;
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,36564,37007);

System.StringComparer
f_1554_36680_36719()
{
var return_v = StringComparer.CurrentCultureIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 36680, 36719);
return return_v;
}


System.Collections.Hashtable
f_1554_36666_36720(System.StringComparer
equalityComparer)
{
var return_v = new System.Collections.Hashtable( (System.Collections.IEqualityComparer)equalityComparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 36666, 36720);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
f_1554_36756_36782(System.Management.Automation.Language.HashtableAst
this_param)
{
var return_v = this_param.KeyValuePairs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 36756, 36782);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1554_36826_36836(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
this_param)
{
var return_v = this_param.Item1;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 36826, 36836);
return return_v;
}


object
f_1554_36826_36849(System.Management.Automation.Language.ExpressionAst
this_param,System.Management.Automation.Language.GetSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 36826, 36849);
return return_v;
}


System.Management.Automation.Language.StatementAst
f_1554_36880_36890(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
this_param)
{
var return_v = this_param.Item2;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 36880, 36890);
return return_v;
}


object
f_1554_36880_36903(System.Management.Automation.Language.StatementAst
this_param,System.Management.Automation.Language.GetSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 36880, 36903);
return return_v;
}


int
f_1554_36922_36947(System.Collections.Hashtable
this_param,object
key,object
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 36922, 36947);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
f_1554_36756_36782_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 36756, 36782);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,36564,37007);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,36564,37007);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitScriptBlockExpression(ScriptBlockExpressionAst scriptBlockExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,37019,37210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,37135,37199);

return f_1554_37142_37198(f_1554_37161_37197(f_1554_37161_37192(scriptBlockExpressionAst)));
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,37019,37210);

System.Management.Automation.Language.IScriptExtent
f_1554_37161_37192(System.Management.Automation.Language.ScriptBlockExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 37161, 37192);
return return_v;
}


string
f_1554_37161_37197(System.Management.Automation.Language.IScriptExtent
this_param)
{
var return_v = this_param.Text;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 37161, 37197);
return return_v;
}


System.Management.Automation.ScriptBlock
f_1554_37142_37198(string
script)
{
var return_v = ScriptBlock.Create( script);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 37142, 37198);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,37019,37210);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,37019,37210);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public object VisitParenExpression(ParenExpressionAst parenExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1554,37222,37379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,37320,37368);

return f_1554_37327_37367(f_1554_37327_37354(parenExpressionAst), this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1554,37222,37379);

System.Management.Automation.Language.PipelineBaseAst
f_1554_37327_37354(System.Management.Automation.Language.ParenExpressionAst
this_param)
{
var return_v = this_param.Pipeline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1554, 37327, 37354);
return return_v;
}


object
f_1554_37327_37367(System.Management.Automation.Language.PipelineBaseAst
this_param,System.Management.Automation.Language.GetSafeValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1554, 37327, 37367);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1554,37222,37379);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,37222,37379);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static GetSafeValueVisitor()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1554,15439,37386);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1554,16451,16460);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1554,15439,37386);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1554,15439,37386);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1554,15439,37386);
}
}
