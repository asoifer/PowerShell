// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis;

namespace System.Management.Automation.Language
{
    /// <summary>
    /// Each Visit* method in <see ref="AstVisitor"/> returns one of these values to control
    /// how visiting nodes in the AST should proceed.
    /// </summary>
    public enum AstVisitAction
    {
        /// <summary>
        /// Continue visiting all nodes the ast.
        /// </summary>
        Continue,

        /// <summary>
        /// Skip visiting child nodes of currently visited node, but continue visiting other nodes.
        /// </summary>
        SkipChildren,

        /// <summary>
        /// Stop visiting all nodes.
        /// </summary>
        StopVisit,
    }
public abstract class AstVisitor
{
internal AstVisitAction CheckForPostAction(Ast ast, AstVisitAction action)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,1196,1514);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,1295,1348);

var 
postActionHandler = this as IAstPostVisitHandler
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,1362,1473) || true) && (postActionHandler != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1552,1362,1473);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,1425,1458);

f_1552_1425_1457(                postActionHandler, ast);
DynAbs.Tracing.TraceSender.TraceExitCondition(1552,1362,1473);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,1489,1503);

return action;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,1196,1514);

int
f_1552_1425_1457(System.Management.Automation.Language.IAstPostVisitHandler
this_param,System.Management.Automation.Language.Ast
ast)
{
this_param.PostVisit( ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1552, 1425, 1457);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,1196,1514);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,1196,1514);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitErrorStatement(ErrorStatementAst errorStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,1550,1672);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,1639,1670);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,1550,1672);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,1550,1672);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,1550,1672);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitErrorExpression(ErrorExpressionAst errorExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,1706,1831);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,1798,1829);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,1706,1831);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,1706,1831);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,1706,1831);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitScriptBlock(ScriptBlockAst scriptBlockAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,1865,1978);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,1945,1976);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,1865,1978);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,1865,1978);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,1865,1978);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Param")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "param")]
        public virtual AstVisitAction VisitParamBlock(ParamBlockAst paramBlockAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,2012,2350);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,2317,2348);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,2012,2350);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,2012,2350);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,2012,2350);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitNamedBlock(NamedBlockAst namedBlockAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,2384,2494);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,2461,2492);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,2384,2494);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,2384,2494);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,2384,2494);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitTypeConstraint(TypeConstraintAst typeConstraintAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,2528,2650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,2617,2648);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,2528,2650);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,2528,2650);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,2528,2650);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitAttribute(AttributeAst attributeAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,2684,2791);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,2758,2789);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,2684,2791);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,2684,2791);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,2684,2791);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitParameter(ParameterAst parameterAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,2825,2932);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,2899,2930);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,2825,2932);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,2825,2932);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,2825,2932);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitTypeExpression(TypeExpressionAst typeExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,2966,3088);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,3055,3086);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,2966,3088);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,2966,3088);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,2966,3088);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitFunctionDefinition(FunctionDefinitionAst functionDefinitionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,3122,3256);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,3223,3254);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,3122,3256);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,3122,3256);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,3122,3256);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitStatementBlock(StatementBlockAst statementBlockAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,3290,3412);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,3379,3410);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,3290,3412);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,3290,3412);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,3290,3412);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitIfStatement(IfStatementAst ifStmtAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,3446,3554);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,3521,3552);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,3446,3554);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,3446,3554);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,3446,3554);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitTrap(TrapStatementAst trapStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,3588,3698);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,3665,3696);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,3588,3698);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,3588,3698);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,3588,3698);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitSwitchStatement(SwitchStatementAst switchStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,3732,3857);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,3824,3855);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,3732,3857);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,3732,3857);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,3732,3857);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitDataStatement(DataStatementAst dataStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,3891,4010);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,3977,4008);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,3891,4010);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,3891,4010);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,3891,4010);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitForEachStatement(ForEachStatementAst forEachStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,4044,4172);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,4139,4170);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,4044,4172);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,4044,4172);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,4044,4172);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitDoWhileStatement(DoWhileStatementAst doWhileStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,4206,4334);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,4301,4332);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,4206,4334);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,4206,4334);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,4206,4334);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitForStatement(ForStatementAst forStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,4368,4484);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,4451,4482);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,4368,4484);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,4368,4484);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,4368,4484);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitWhileStatement(WhileStatementAst whileStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,4518,4640);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,4607,4638);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,4518,4640);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,4518,4640);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,4518,4640);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitCatchClause(CatchClauseAst catchClauseAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,4674,4787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,4754,4785);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,4674,4787);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,4674,4787);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,4674,4787);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitTryStatement(TryStatementAst tryStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,4821,4937);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,4904,4935);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,4821,4937);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,4821,4937);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,4821,4937);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitBreakStatement(BreakStatementAst breakStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,4971,5093);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,5060,5091);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,4971,5093);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,4971,5093);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,4971,5093);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitContinueStatement(ContinueStatementAst continueStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,5127,5258);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,5225,5256);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,5127,5258);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,5127,5258);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,5127,5258);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitReturnStatement(ReturnStatementAst returnStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,5292,5417);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,5384,5415);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,5292,5417);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,5292,5417);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,5292,5417);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitExitStatement(ExitStatementAst exitStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,5451,5570);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,5537,5568);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,5451,5570);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,5451,5570);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,5451,5570);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitThrowStatement(ThrowStatementAst throwStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,5604,5726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,5693,5724);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,5604,5726);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,5604,5726);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,5604,5726);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitDoUntilStatement(DoUntilStatementAst doUntilStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,5760,5888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,5855,5886);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,5760,5888);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,5760,5888);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,5760,5888);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitAssignmentStatement(AssignmentStatementAst assignmentStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,5922,6059);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,6026,6057);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,5922,6059);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,5922,6059);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,5922,6059);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitPipeline(PipelineAst pipelineAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,6093,6197);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,6164,6195);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,6093,6197);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,6093,6197);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,6093,6197);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitCommand(CommandAst commandAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,6231,6332);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,6299,6330);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,6231,6332);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,6231,6332);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,6231,6332);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitCommandExpression(CommandExpressionAst commandExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,6366,6497);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,6464,6495);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,6366,6497);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,6366,6497);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,6366,6497);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitCommandParameter(CommandParameterAst commandParameterAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,6531,6659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,6626,6657);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,6531,6659);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,6531,6659);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,6531,6659);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitMergingRedirection(MergingRedirectionAst redirectionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,6693,6820);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,6787,6818);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,6693,6820);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,6693,6820);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,6693,6820);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitFileRedirection(FileRedirectionAst redirectionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,6854,6975);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,6942,6973);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,6854,6975);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,6854,6975);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,6854,6975);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitBinaryExpression(BinaryExpressionAst binaryExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,7009,7137);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,7104,7135);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,7009,7137);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,7009,7137);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,7009,7137);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitUnaryExpression(UnaryExpressionAst unaryExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,7171,7296);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,7263,7294);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,7171,7296);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,7171,7296);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,7171,7296);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitConvertExpression(ConvertExpressionAst convertExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,7330,7461);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,7428,7459);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,7330,7461);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,7330,7461);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,7330,7461);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitConstantExpression(ConstantExpressionAst constantExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,7495,7629);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,7596,7627);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,7495,7629);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,7495,7629);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,7495,7629);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitStringConstantExpression(StringConstantExpressionAst stringConstantExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,7663,7815);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,7782,7813);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,7663,7815);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,7663,7815);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,7663,7815);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "SubExpression")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "subExpression")]
        public virtual AstVisitAction VisitSubExpression(SubExpressionAst subExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,7849,8212);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,8179,8210);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,7849,8212);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,7849,8212);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,7849,8212);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitUsingExpression(UsingExpressionAst usingExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,8246,8371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,8338,8369);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,8246,8371);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,8246,8371);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,8246,8371);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitVariableExpression(VariableExpressionAst variableExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,8405,8539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,8506,8537);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,8405,8539);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,8405,8539);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,8405,8539);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitMemberExpression(MemberExpressionAst memberExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,8573,8701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,8668,8699);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,8573,8701);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,8573,8701);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,8573,8701);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitInvokeMemberExpression(InvokeMemberExpressionAst methodCallAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,8735,8869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,8836,8867);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,8735,8869);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,8735,8869);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,8735,8869);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitArrayExpression(ArrayExpressionAst arrayExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,8903,9028);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,8995,9026);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,8903,9028);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,8903,9028);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,8903,9028);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitArrayLiteral(ArrayLiteralAst arrayLiteralAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,9062,9178);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,9145,9176);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,9062,9178);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,9062,9178);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,9062,9178);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitHashtable(HashtableAst hashtableAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,9212,9319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,9286,9317);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,9212,9319);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,9212,9319);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,9212,9319);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitScriptBlockExpression(ScriptBlockExpressionAst scriptBlockExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,9353,9496);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,9463,9494);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,9353,9496);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,9353,9496);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,9353,9496);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Paren")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "paren")]
        public virtual AstVisitAction VisitParenExpression(ParenExpressionAst parenExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,9530,9883);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,9850,9881);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,9530,9883);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,9530,9883);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,9530,9883);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitExpandableStringExpression(ExpandableStringExpressionAst expandableStringExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,9917,10075);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,10042,10073);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,9917,10075);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,9917,10075);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,9917,10075);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitIndexExpression(IndexExpressionAst indexExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,10109,10234);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,10201,10232);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,10109,10234);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,10109,10234);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,10109,10234);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitAttributedExpression(AttributedExpressionAst attributedExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,10268,10408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,10375,10406);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,10268,10408);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,10268,10408);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,10268,10408);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitBlockStatement(BlockStatementAst blockStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,10442,10564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,10531,10562);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,10442,10564);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,10442,10564);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,10442,10564);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitNamedAttributeArgument(NamedAttributeArgumentAst namedAttributeArgumentAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,10598,10744);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,10711,10742);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,10598,10744);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,10598,10744);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,10598,10744);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public AstVisitor()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1552,1147,10751);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1552,1147,10751);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,1147,10751);
}


static AstVisitor()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1552,1147,10751);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1552,1147,10751);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,1147,10751);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1552,1147,10751);
}
public abstract class AstVisitor2 : AstVisitor
{
public virtual AstVisitAction VisitTypeDefinition(TypeDefinitionAst typeDefinitionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,10929,11051);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,11018,11049);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,10929,11051);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,10929,11051);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,10929,11051);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitPropertyMember(PropertyMemberAst propertyMemberAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,11087,11209);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,11176,11207);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,11087,11209);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,11087,11209);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,11087,11209);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitFunctionMember(FunctionMemberAst functionMemberAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,11245,11367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,11334,11365);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,11245,11367);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,11245,11367);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,11245,11367);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitBaseCtorInvokeMemberExpression(BaseCtorInvokeMemberExpressionAst baseCtorInvokeMemberExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,11403,11573);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,11540,11571);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,11403,11573);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,11403,11573);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,11403,11573);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitUsingStatement(UsingStatementAst usingStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,11609,11731);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,11698,11729);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,11609,11731);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,11609,11731);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,11609,11731);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitConfigurationDefinition(ConfigurationDefinitionAst configurationDefinitionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,11767,11916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,11883,11914);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,11767,11916);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,11767,11916);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,11767,11916);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitDynamicKeywordStatement(DynamicKeywordStatementAst dynamicKeywordStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,11952,12101);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,12068,12099);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,11952,12101);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,11952,12101);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,11952,12101);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitTernaryExpression(TernaryExpressionAst ternaryExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,12137,12268);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,12235,12266);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,12137,12268);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,12137,12268);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,12137,12268);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual AstVisitAction VisitPipelineChain(PipelineChainAst statementChain) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1552,12304,12421);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1552,12388,12419);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1552,12304,12421);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1552,12304,12421);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,12304,12421);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public AstVisitor2()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1552,10842,12428);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1552,10842,12428);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,10842,12428);
}


static AstVisitor2()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1552,10842,12428);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1552,10842,12428);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1552,10842,12428);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1552,10842,12428);
}

    /// <summary>
    /// Implement this interface when you implement <see cref="AstVisitor"/> or <see cref="AstVisitor2"/> when
    /// you want to do something after possibly visiting the children of the ast.
    /// </summary>
    public interface IAstPostVisitHandler
    {

void PostVisit(Ast ast);
    }
}
