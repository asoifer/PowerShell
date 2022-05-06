// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Emit;

namespace System.Management.Automation.Language
{
    /// <summary>
    /// </summary>
    public interface ICustomAstVisitor
    {

object VisitErrorStatement(ErrorStatementAst errorStatementAst);

object VisitErrorExpression(ErrorExpressionAst errorExpressionAst);

object VisitScriptBlock(ScriptBlockAst scriptBlockAst);

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Param")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "param")]
        object VisitParamBlock(ParamBlockAst paramBlockAst);

object VisitNamedBlock(NamedBlockAst namedBlockAst);

object VisitTypeConstraint(TypeConstraintAst typeConstraintAst);

object VisitAttribute(AttributeAst attributeAst);

object VisitNamedAttributeArgument(NamedAttributeArgumentAst namedAttributeArgumentAst);

object VisitParameter(ParameterAst parameterAst);

object VisitFunctionDefinition(FunctionDefinitionAst functionDefinitionAst);

object VisitStatementBlock(StatementBlockAst statementBlockAst);

object VisitIfStatement(IfStatementAst ifStmtAst);

object VisitTrap(TrapStatementAst trapStatementAst);

object VisitSwitchStatement(SwitchStatementAst switchStatementAst);

object VisitDataStatement(DataStatementAst dataStatementAst);

object VisitForEachStatement(ForEachStatementAst forEachStatementAst);

object VisitDoWhileStatement(DoWhileStatementAst doWhileStatementAst);

object VisitForStatement(ForStatementAst forStatementAst);

object VisitWhileStatement(WhileStatementAst whileStatementAst);

object VisitCatchClause(CatchClauseAst catchClauseAst);

object VisitTryStatement(TryStatementAst tryStatementAst);

object VisitBreakStatement(BreakStatementAst breakStatementAst);

object VisitContinueStatement(ContinueStatementAst continueStatementAst);

object VisitReturnStatement(ReturnStatementAst returnStatementAst);

object VisitExitStatement(ExitStatementAst exitStatementAst);

object VisitThrowStatement(ThrowStatementAst throwStatementAst);

object VisitDoUntilStatement(DoUntilStatementAst doUntilStatementAst);

object VisitAssignmentStatement(AssignmentStatementAst assignmentStatementAst);

object VisitPipeline(PipelineAst pipelineAst);

object VisitCommand(CommandAst commandAst);

object VisitCommandExpression(CommandExpressionAst commandExpressionAst);

object VisitCommandParameter(CommandParameterAst commandParameterAst);

object VisitFileRedirection(FileRedirectionAst fileRedirectionAst);

object VisitMergingRedirection(MergingRedirectionAst mergingRedirectionAst);

object VisitBinaryExpression(BinaryExpressionAst binaryExpressionAst);

object VisitUnaryExpression(UnaryExpressionAst unaryExpressionAst);

object VisitConvertExpression(ConvertExpressionAst convertExpressionAst);

object VisitConstantExpression(ConstantExpressionAst constantExpressionAst);

object VisitStringConstantExpression(StringConstantExpressionAst stringConstantExpressionAst);

[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "SubExpression")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "subExpression")]
        object VisitSubExpression(SubExpressionAst subExpressionAst);

object VisitUsingExpression(UsingExpressionAst usingExpressionAst);

object VisitVariableExpression(VariableExpressionAst variableExpressionAst);

object VisitTypeExpression(TypeExpressionAst typeExpressionAst);

object VisitMemberExpression(MemberExpressionAst memberExpressionAst);

object VisitInvokeMemberExpression(InvokeMemberExpressionAst invokeMemberExpressionAst);

object VisitArrayExpression(ArrayExpressionAst arrayExpressionAst);

object VisitArrayLiteral(ArrayLiteralAst arrayLiteralAst);

object VisitHashtable(HashtableAst hashtableAst);

object VisitScriptBlockExpression(ScriptBlockExpressionAst scriptBlockExpressionAst);

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Paren")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "paren")]
        object VisitParenExpression(ParenExpressionAst parenExpressionAst);

object VisitExpandableStringExpression(ExpandableStringExpressionAst expandableStringExpressionAst);

object VisitIndexExpression(IndexExpressionAst indexExpressionAst);

object VisitAttributedExpression(AttributedExpressionAst attributedExpressionAst);

object VisitBlockStatement(BlockStatementAst blockStatementAst);

            }

    /// <summary/>
    public interface ICustomAstVisitor2 : ICustomAstVisitor
    {

private object DefaultVisit(Ast ast) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,6891,6898);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,6894,6898);
return null;DynAbs.Tracing.TraceSender.TraceExitMethod(1543,6891,6898);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,6891,6898);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,6891,6898);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

object VisitTypeDefinition(TypeDefinitionAst typeDefinitionAst);

object VisitPropertyMember(PropertyMemberAst propertyMemberAst);

object VisitFunctionMember(FunctionMemberAst functionMemberAst);

object VisitBaseCtorInvokeMemberExpression(BaseCtorInvokeMemberExpressionAst baseCtorInvokeMemberExpressionAst);

object VisitUsingStatement(UsingStatementAst usingStatement);

object VisitConfigurationDefinition(ConfigurationDefinitionAst configurationDefinitionAst);

object VisitDynamicKeywordStatement(DynamicKeywordStatementAst dynamicKeywordAst);

        /// <summary/>
        object VisitTernaryExpression(TernaryExpressionAst ternaryExpressionAst) => DefaultVisit(ternaryExpressionAst);

        /// <summary/>
        object VisitPipelineChain(PipelineChainAst statementChainAst) => DefaultVisit(statementChainAst);
    }
class CheckAllParentsSet : AstVisitor2
{
internal CheckAllParentsSet(Ast root)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1543,8050,8140);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,8152,8182);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,8112,8129);

this.Root = root;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1543,8050,8140);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,8050,8140);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,8050,8140);
}
		}

private Ast Root {get; set; }

internal AstVisitAction CheckParent(Ast ast)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,8194,8442);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,8263,8384) || true) && (ast != f_1543_8274_8278())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1543,8263,8384);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,8312,8369);

f_1543_8312_8368(f_1543_8331_8341(ast)!= null, "Parent not set");
DynAbs.Tracing.TraceSender.TraceExitCondition(1543,8263,8384);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,8400,8431);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,8194,8442);

System.Management.Automation.Language.Ast
f_1543_8274_8278()
{
var return_v = Root;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1543, 8274, 8278);
return return_v;
}


System.Management.Automation.Language.Ast
f_1543_8331_8341(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1543, 8331, 8341);
return return_v;
}


int
f_1543_8312_8368(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 8312, 8368);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,8194,8442);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,8194,8442);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitErrorStatement(ErrorStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,8454,8556);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,8530,8554);

return f_1543_8537_8553(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,8454,8556);

System.Management.Automation.Language.AstVisitAction
f_1543_8537_8553(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.ErrorStatementAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 8537, 8553);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,8454,8556);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,8454,8556);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitErrorExpression(ErrorExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,8568,8672);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,8646,8670);

return f_1543_8653_8669(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,8568,8672);

System.Management.Automation.Language.AstVisitAction
f_1543_8653_8669(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.ErrorExpressionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 8653, 8669);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,8568,8672);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,8568,8672);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitScriptBlock(ScriptBlockAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,8684,8780);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,8754,8778);

return f_1543_8761_8777(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,8684,8780);

System.Management.Automation.Language.AstVisitAction
f_1543_8761_8777(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.ScriptBlockAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 8761, 8777);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,8684,8780);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,8684,8780);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitParamBlock(ParamBlockAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,8792,8886);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,8860,8884);

return f_1543_8867_8883(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,8792,8886);

System.Management.Automation.Language.AstVisitAction
f_1543_8867_8883(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.ParamBlockAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 8867, 8883);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,8792,8886);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,8792,8886);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitNamedBlock(NamedBlockAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,8898,8992);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,8966,8990);

return f_1543_8973_8989(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,8898,8992);

System.Management.Automation.Language.AstVisitAction
f_1543_8973_8989(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.NamedBlockAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 8973, 8989);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,8898,8992);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,8898,8992);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitTypeConstraint(TypeConstraintAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,9004,9106);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,9080,9104);

return f_1543_9087_9103(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,9004,9106);

System.Management.Automation.Language.AstVisitAction
f_1543_9087_9103(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.TypeConstraintAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 9087, 9103);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,9004,9106);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,9004,9106);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitAttribute(AttributeAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,9118,9210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,9184,9208);

return f_1543_9191_9207(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,9118,9210);

System.Management.Automation.Language.AstVisitAction
f_1543_9191_9207(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.AttributeAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 9191, 9207);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,9118,9210);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,9118,9210);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitParameter(ParameterAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,9222,9314);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,9288,9312);

return f_1543_9295_9311(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,9222,9314);

System.Management.Automation.Language.AstVisitAction
f_1543_9295_9311(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.ParameterAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 9295, 9311);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,9222,9314);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,9222,9314);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitTypeExpression(TypeExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,9326,9428);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,9402,9426);

return f_1543_9409_9425(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,9326,9428);

System.Management.Automation.Language.AstVisitAction
f_1543_9409_9425(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.TypeExpressionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 9409, 9425);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,9326,9428);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,9326,9428);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitFunctionDefinition(FunctionDefinitionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,9440,9550);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,9524,9548);

return f_1543_9531_9547(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,9440,9550);

System.Management.Automation.Language.AstVisitAction
f_1543_9531_9547(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.FunctionDefinitionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 9531, 9547);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,9440,9550);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,9440,9550);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitStatementBlock(StatementBlockAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,9562,9664);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,9638,9662);

return f_1543_9645_9661(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,9562,9664);

System.Management.Automation.Language.AstVisitAction
f_1543_9645_9661(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.StatementBlockAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 9645, 9661);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,9562,9664);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,9562,9664);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitIfStatement(IfStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,9676,9772);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,9746,9770);

return f_1543_9753_9769(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,9676,9772);

System.Management.Automation.Language.AstVisitAction
f_1543_9753_9769(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.IfStatementAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 9753, 9769);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,9676,9772);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,9676,9772);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitTrap(TrapStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,9784,9875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,9849,9873);

return f_1543_9856_9872(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,9784,9875);

System.Management.Automation.Language.AstVisitAction
f_1543_9856_9872(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.TrapStatementAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 9856, 9872);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,9784,9875);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,9784,9875);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitSwitchStatement(SwitchStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,9887,9991);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,9965,9989);

return f_1543_9972_9988(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,9887,9991);

System.Management.Automation.Language.AstVisitAction
f_1543_9972_9988(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.SwitchStatementAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 9972, 9988);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,9887,9991);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,9887,9991);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitDataStatement(DataStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,10003,10103);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,10077,10101);

return f_1543_10084_10100(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,10003,10103);

System.Management.Automation.Language.AstVisitAction
f_1543_10084_10100(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.DataStatementAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 10084, 10100);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,10003,10103);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,10003,10103);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitForEachStatement(ForEachStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,10115,10221);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,10195,10219);

return f_1543_10202_10218(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,10115,10221);

System.Management.Automation.Language.AstVisitAction
f_1543_10202_10218(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.ForEachStatementAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 10202, 10218);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,10115,10221);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,10115,10221);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitDoWhileStatement(DoWhileStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,10233,10339);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,10313,10337);

return f_1543_10320_10336(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,10233,10339);

System.Management.Automation.Language.AstVisitAction
f_1543_10320_10336(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.DoWhileStatementAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 10320, 10336);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,10233,10339);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,10233,10339);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitForStatement(ForStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,10351,10449);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,10423,10447);

return f_1543_10430_10446(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,10351,10449);

System.Management.Automation.Language.AstVisitAction
f_1543_10430_10446(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.ForStatementAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 10430, 10446);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,10351,10449);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,10351,10449);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitWhileStatement(WhileStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,10461,10563);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,10537,10561);

return f_1543_10544_10560(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,10461,10563);

System.Management.Automation.Language.AstVisitAction
f_1543_10544_10560(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.WhileStatementAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 10544, 10560);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,10461,10563);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,10461,10563);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitCatchClause(CatchClauseAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,10575,10671);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,10645,10669);

return f_1543_10652_10668(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,10575,10671);

System.Management.Automation.Language.AstVisitAction
f_1543_10652_10668(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.CatchClauseAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 10652, 10668);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,10575,10671);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,10575,10671);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitTryStatement(TryStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,10683,10781);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,10755,10779);

return f_1543_10762_10778(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,10683,10781);

System.Management.Automation.Language.AstVisitAction
f_1543_10762_10778(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.TryStatementAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 10762, 10778);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,10683,10781);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,10683,10781);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitBreakStatement(BreakStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,10793,10895);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,10869,10893);

return f_1543_10876_10892(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,10793,10895);

System.Management.Automation.Language.AstVisitAction
f_1543_10876_10892(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.BreakStatementAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 10876, 10892);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,10793,10895);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,10793,10895);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitContinueStatement(ContinueStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,10907,11015);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,10989,11013);

return f_1543_10996_11012(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,10907,11015);

System.Management.Automation.Language.AstVisitAction
f_1543_10996_11012(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.ContinueStatementAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 10996, 11012);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,10907,11015);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,10907,11015);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitReturnStatement(ReturnStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,11027,11131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,11105,11129);

return f_1543_11112_11128(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,11027,11131);

System.Management.Automation.Language.AstVisitAction
f_1543_11112_11128(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.ReturnStatementAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 11112, 11128);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,11027,11131);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,11027,11131);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitExitStatement(ExitStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,11143,11243);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,11217,11241);

return f_1543_11224_11240(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,11143,11243);

System.Management.Automation.Language.AstVisitAction
f_1543_11224_11240(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.ExitStatementAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 11224, 11240);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,11143,11243);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,11143,11243);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitThrowStatement(ThrowStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,11255,11357);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,11331,11355);

return f_1543_11338_11354(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,11255,11357);

System.Management.Automation.Language.AstVisitAction
f_1543_11338_11354(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.ThrowStatementAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 11338, 11354);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,11255,11357);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,11255,11357);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitDoUntilStatement(DoUntilStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,11369,11475);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,11449,11473);

return f_1543_11456_11472(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,11369,11475);

System.Management.Automation.Language.AstVisitAction
f_1543_11456_11472(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.DoUntilStatementAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 11456, 11472);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,11369,11475);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,11369,11475);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitAssignmentStatement(AssignmentStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,11487,11599);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,11573,11597);

return f_1543_11580_11596(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,11487,11599);

System.Management.Automation.Language.AstVisitAction
f_1543_11580_11596(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.AssignmentStatementAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 11580, 11596);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,11487,11599);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,11487,11599);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitPipeline(PipelineAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,11611,11701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,11675,11699);

return f_1543_11682_11698(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,11611,11701);

System.Management.Automation.Language.AstVisitAction
f_1543_11682_11698(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.PipelineAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 11682, 11698);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,11611,11701);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,11611,11701);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitCommand(CommandAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,11713,11801);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,11775,11799);

return f_1543_11782_11798(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,11713,11801);

System.Management.Automation.Language.AstVisitAction
f_1543_11782_11798(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.CommandAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 11782, 11798);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,11713,11801);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,11713,11801);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitCommandExpression(CommandExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,11813,11921);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,11895,11919);

return f_1543_11902_11918(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,11813,11921);

System.Management.Automation.Language.AstVisitAction
f_1543_11902_11918(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.CommandExpressionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 11902, 11918);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,11813,11921);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,11813,11921);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitCommandParameter(CommandParameterAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,11933,12039);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,12013,12037);

return f_1543_12020_12036(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,11933,12039);

System.Management.Automation.Language.AstVisitAction
f_1543_12020_12036(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.CommandParameterAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 12020, 12036);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,11933,12039);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,11933,12039);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitMergingRedirection(MergingRedirectionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,12051,12161);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,12135,12159);

return f_1543_12142_12158(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,12051,12161);

System.Management.Automation.Language.AstVisitAction
f_1543_12142_12158(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.MergingRedirectionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 12142, 12158);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,12051,12161);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,12051,12161);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitFileRedirection(FileRedirectionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,12173,12277);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,12251,12275);

return f_1543_12258_12274(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,12173,12277);

System.Management.Automation.Language.AstVisitAction
f_1543_12258_12274(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.FileRedirectionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 12258, 12274);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,12173,12277);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,12173,12277);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitBinaryExpression(BinaryExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,12289,12395);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,12369,12393);

return f_1543_12376_12392(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,12289,12395);

System.Management.Automation.Language.AstVisitAction
f_1543_12376_12392(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.BinaryExpressionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 12376, 12392);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,12289,12395);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,12289,12395);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitUnaryExpression(UnaryExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,12407,12511);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,12485,12509);

return f_1543_12492_12508(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,12407,12511);

System.Management.Automation.Language.AstVisitAction
f_1543_12492_12508(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.UnaryExpressionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 12492, 12508);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,12407,12511);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,12407,12511);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitConvertExpression(ConvertExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,12523,12631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,12605,12629);

return f_1543_12612_12628(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,12523,12631);

System.Management.Automation.Language.AstVisitAction
f_1543_12612_12628(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.ConvertExpressionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 12612, 12628);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,12523,12631);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,12523,12631);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitConstantExpression(ConstantExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,12643,12753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,12727,12751);

return f_1543_12734_12750(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,12643,12753);

System.Management.Automation.Language.AstVisitAction
f_1543_12734_12750(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.ConstantExpressionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 12734, 12750);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,12643,12753);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,12643,12753);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitStringConstantExpression(StringConstantExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,12765,12887);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,12861,12885);

return f_1543_12868_12884(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,12765,12887);

System.Management.Automation.Language.AstVisitAction
f_1543_12868_12884(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.StringConstantExpressionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 12868, 12884);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,12765,12887);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,12765,12887);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitSubExpression(SubExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,12899,12999);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,12973,12997);

return f_1543_12980_12996(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,12899,12999);

System.Management.Automation.Language.AstVisitAction
f_1543_12980_12996(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.SubExpressionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 12980, 12996);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,12899,12999);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,12899,12999);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitUsingExpression(UsingExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,13011,13115);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,13089,13113);

return f_1543_13096_13112(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,13011,13115);

System.Management.Automation.Language.AstVisitAction
f_1543_13096_13112(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.UsingExpressionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 13096, 13112);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,13011,13115);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,13011,13115);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitVariableExpression(VariableExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,13127,13237);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,13211,13235);

return f_1543_13218_13234(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,13127,13237);

System.Management.Automation.Language.AstVisitAction
f_1543_13218_13234(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.VariableExpressionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 13218, 13234);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,13127,13237);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,13127,13237);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitMemberExpression(MemberExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,13249,13355);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,13329,13353);

return f_1543_13336_13352(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,13249,13355);

System.Management.Automation.Language.AstVisitAction
f_1543_13336_13352(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.MemberExpressionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 13336, 13352);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,13249,13355);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,13249,13355);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitInvokeMemberExpression(InvokeMemberExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,13367,13485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,13459,13483);

return f_1543_13466_13482(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,13367,13485);

System.Management.Automation.Language.AstVisitAction
f_1543_13466_13482(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.InvokeMemberExpressionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 13466, 13482);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,13367,13485);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,13367,13485);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitArrayExpression(ArrayExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,13497,13601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,13575,13599);

return f_1543_13582_13598(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,13497,13601);

System.Management.Automation.Language.AstVisitAction
f_1543_13582_13598(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.ArrayExpressionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 13582, 13598);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,13497,13601);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,13497,13601);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitArrayLiteral(ArrayLiteralAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,13613,13711);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,13685,13709);

return f_1543_13692_13708(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,13613,13711);

System.Management.Automation.Language.AstVisitAction
f_1543_13692_13708(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.ArrayLiteralAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 13692, 13708);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,13613,13711);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,13613,13711);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitHashtable(HashtableAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,13723,13815);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,13789,13813);

return f_1543_13796_13812(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,13723,13815);

System.Management.Automation.Language.AstVisitAction
f_1543_13796_13812(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.HashtableAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 13796, 13812);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,13723,13815);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,13723,13815);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitScriptBlockExpression(ScriptBlockExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,13827,13943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,13917,13941);

return f_1543_13924_13940(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,13827,13943);

System.Management.Automation.Language.AstVisitAction
f_1543_13924_13940(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.ScriptBlockExpressionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 13924, 13940);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,13827,13943);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,13827,13943);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitParenExpression(ParenExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,13955,14059);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,14033,14057);

return f_1543_14040_14056(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,13955,14059);

System.Management.Automation.Language.AstVisitAction
f_1543_14040_14056(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.ParenExpressionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 14040, 14056);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,13955,14059);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,13955,14059);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitExpandableStringExpression(ExpandableStringExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,14071,14197);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,14171,14195);

return f_1543_14178_14194(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,14071,14197);

System.Management.Automation.Language.AstVisitAction
f_1543_14178_14194(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.ExpandableStringExpressionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 14178, 14194);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,14071,14197);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,14071,14197);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitIndexExpression(IndexExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,14209,14313);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,14287,14311);

return f_1543_14294_14310(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,14209,14313);

System.Management.Automation.Language.AstVisitAction
f_1543_14294_14310(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.IndexExpressionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 14294, 14310);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,14209,14313);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,14209,14313);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitAttributedExpression(AttributedExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,14325,14439);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,14413,14437);

return f_1543_14420_14436(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,14325,14439);

System.Management.Automation.Language.AstVisitAction
f_1543_14420_14436(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.AttributedExpressionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 14420, 14436);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,14325,14439);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,14325,14439);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitBlockStatement(BlockStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,14451,14553);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,14527,14551);

return f_1543_14534_14550(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,14451,14553);

System.Management.Automation.Language.AstVisitAction
f_1543_14534_14550(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.BlockStatementAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 14534, 14550);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,14451,14553);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,14451,14553);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitNamedAttributeArgument(NamedAttributeArgumentAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,14565,14683);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,14657,14681);

return f_1543_14664_14680(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,14565,14683);

System.Management.Automation.Language.AstVisitAction
f_1543_14664_14680(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.NamedAttributeArgumentAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 14664, 14680);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,14565,14683);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,14565,14683);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitTypeDefinition(TypeDefinitionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,14695,14797);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,14771,14795);

return f_1543_14778_14794(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,14695,14797);

System.Management.Automation.Language.AstVisitAction
f_1543_14778_14794(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.TypeDefinitionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 14778, 14794);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,14695,14797);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,14695,14797);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitFunctionMember(FunctionMemberAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,14809,14911);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,14885,14909);

return f_1543_14892_14908(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,14809,14911);

System.Management.Automation.Language.AstVisitAction
f_1543_14892_14908(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.FunctionMemberAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 14892, 14908);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,14809,14911);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,14809,14911);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitPropertyMember(PropertyMemberAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,14923,15025);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,14999,15023);

return f_1543_15006_15022(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,14923,15025);

System.Management.Automation.Language.AstVisitAction
f_1543_15006_15022(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.PropertyMemberAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 15006, 15022);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,14923,15025);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,14923,15025);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitUsingStatement(UsingStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,15037,15139);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,15113,15137);

return f_1543_15120_15136(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,15037,15139);

System.Management.Automation.Language.AstVisitAction
f_1543_15120_15136(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.UsingStatementAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 15120, 15136);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,15037,15139);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,15037,15139);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitConfigurationDefinition(ConfigurationDefinitionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,15151,15271);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,15245,15269);

return f_1543_15252_15268(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,15151,15271);

System.Management.Automation.Language.AstVisitAction
f_1543_15252_15268(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.ConfigurationDefinitionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 15252, 15268);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,15151,15271);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,15151,15271);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitDynamicKeywordStatement(DynamicKeywordStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,15283,15403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,15377,15401);

return f_1543_15384_15400(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,15283,15403);

System.Management.Automation.Language.AstVisitAction
f_1543_15384_15400(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.DynamicKeywordStatementAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 15384, 15400);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,15283,15403);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,15283,15403);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitTernaryExpression(TernaryExpressionAst ast) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,15495,15514);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,15498,15514);
return f_1543_15498_15514(this, ast);DynAbs.Tracing.TraceSender.TraceExitMethod(1543,15495,15514);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,15495,15514);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,15495,15514);
}
			throw new System.Exception("Slicer error: unreachable code");

System.Management.Automation.Language.AstVisitAction
f_1543_15498_15514(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.TernaryExpressionAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 15498, 15514);
return return_v;
}

		}

public override AstVisitAction VisitPipelineChain(PipelineChainAst ast) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,15599,15618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,15602,15618);
return f_1543_15602_15618(this, ast);DynAbs.Tracing.TraceSender.TraceExitMethod(1543,15599,15618);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,15599,15618);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,15599,15618);
}
			throw new System.Exception("Slicer error: unreachable code");

System.Management.Automation.Language.AstVisitAction
f_1543_15602_15618(System.Management.Automation.Language.CheckAllParentsSet
this_param,System.Management.Automation.Language.PipelineChainAst
ast)
{
var return_v = this_param.CheckParent( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 15602, 15618);
return return_v;
}

		}

static CheckAllParentsSet()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1543,7995,15626);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1543,7995,15626);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,7995,15626);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1543,7995,15626);
}
class CheckTypeBuilder : AstVisitor2
{
public override AstVisitAction VisitTypeConstraint(TypeConstraintAst ast)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,15818,16184);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,15916,15961);

Type 
type = f_1543_15928_15960(f_1543_15928_15940(ast))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,15975,16126) || true) && (type != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1543,15975,16126);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,16025,16111);

f_1543_16025_16110(!(type is TypeBuilder), "ReflectionType can never be TypeBuilder");
DynAbs.Tracing.TraceSender.TraceExitCondition(1543,15975,16126);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,16142,16173);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,15818,16184);

System.Management.Automation.Language.ITypeName
f_1543_15928_15940(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1543, 15928, 15940);
return return_v;
}


System.Type
f_1543_15928_15960(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.GetReflectionType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 15928, 15960);
return return_v;
}


int
f_1543_16025_16110(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 16025, 16110);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,15818,16184);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,15818,16184);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public CheckTypeBuilder()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1543,15765,16191);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1543,15765,16191);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,15765,16191);
}


static CheckTypeBuilder()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1543,15765,16191);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1543,15765,16191);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,15765,16191);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1543,15765,16191);
}
internal class AstSearcher : AstVisitor2
{
internal static IEnumerable<Ast> FindAll(Ast ast, Func<Ast, bool> predicate, bool searchNestedScriptBlocks)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1543,16437,16873);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,16569,16652);

f_1543_16569_16651(ast != null &&(DynAbs.Tracing.TraceSender.Expression_True(1543, 16588, 16620)&&predicate != null), "caller to verify arguments");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,16668,16782);

var 
searcher = f_1543_16683_16781(predicate, stopOnFirst: false, searchNestedScriptBlocks: searchNestedScriptBlocks)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,16796,16824);

f_1543_16796_16823(            ast, searcher);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,16838,16862);

return searcher.Results;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1543,16437,16873);

int
f_1543_16569_16651(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 16569, 16651);
return 0;
}


System.Management.Automation.Language.AstSearcher
f_1543_16683_16781(System.Func<System.Management.Automation.Language.Ast, bool>
callback,bool
stopOnFirst,bool
searchNestedScriptBlocks)
{
var return_v = new System.Management.Automation.Language.AstSearcher( callback, stopOnFirst: stopOnFirst, searchNestedScriptBlocks: searchNestedScriptBlocks);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 16683, 16781);
return return_v;
}


System.Management.Automation.Language.AstVisitAction
f_1543_16796_16823(System.Management.Automation.Language.Ast
this_param,System.Management.Automation.Language.AstSearcher
visitor)
{
var return_v = this_param.InternalVisit( (System.Management.Automation.Language.AstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 16796, 16823);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,16437,16873);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,16437,16873);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static Ast FindFirst(Ast ast, Func<Ast, bool> predicate, bool searchNestedScriptBlocks)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1543,16885,17326);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,17006,17089);

f_1543_17006_17088(ast != null &&(DynAbs.Tracing.TraceSender.Expression_True(1543, 17025, 17057)&&predicate != null), "caller to verify arguments");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,17105,17218);

var 
searcher = f_1543_17120_17217(predicate, stopOnFirst: true, searchNestedScriptBlocks: searchNestedScriptBlocks)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,17232,17260);

f_1543_17232_17259(            ast, searcher);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,17274,17315);

return f_1543_17281_17314(searcher.Results);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1543,16885,17326);

int
f_1543_17006_17088(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 17006, 17088);
return 0;
}


System.Management.Automation.Language.AstSearcher
f_1543_17120_17217(System.Func<System.Management.Automation.Language.Ast, bool>
callback,bool
stopOnFirst,bool
searchNestedScriptBlocks)
{
var return_v = new System.Management.Automation.Language.AstSearcher( callback, stopOnFirst: stopOnFirst, searchNestedScriptBlocks: searchNestedScriptBlocks);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 17120, 17217);
return return_v;
}


System.Management.Automation.Language.AstVisitAction
f_1543_17232_17259(System.Management.Automation.Language.Ast
this_param,System.Management.Automation.Language.AstSearcher
visitor)
{
var return_v = this_param.InternalVisit( (System.Management.Automation.Language.AstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 17232, 17259);
return return_v;
}


System.Management.Automation.Language.Ast
f_1543_17281_17314(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
source)
{
var return_v = source.FirstOrDefault<System.Management.Automation.Language.Ast>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 17281, 17314);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,16885,17326);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,16885,17326);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool Contains(Ast ast, Func<Ast, bool> predicate, bool searchNestedScriptBlocks)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1543,17338,17787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,17459,17542);

f_1543_17459_17541(ast != null &&(DynAbs.Tracing.TraceSender.Expression_True(1543, 17478, 17510)&&predicate != null), "caller to verify arguments");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,17558,17671);

var 
searcher = f_1543_17573_17670(predicate, stopOnFirst: true, searchNestedScriptBlocks: searchNestedScriptBlocks)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,17685,17713);

f_1543_17685_17712(            ast, searcher);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,17727,17776);

return f_1543_17734_17767(searcher.Results)!= null;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1543,17338,17787);

int
f_1543_17459_17541(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 17459, 17541);
return 0;
}


System.Management.Automation.Language.AstSearcher
f_1543_17573_17670(System.Func<System.Management.Automation.Language.Ast, bool>
callback,bool
stopOnFirst,bool
searchNestedScriptBlocks)
{
var return_v = new System.Management.Automation.Language.AstSearcher( callback, stopOnFirst: stopOnFirst, searchNestedScriptBlocks: searchNestedScriptBlocks);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 17573, 17670);
return return_v;
}


System.Management.Automation.Language.AstVisitAction
f_1543_17685_17712(System.Management.Automation.Language.Ast
this_param,System.Management.Automation.Language.AstSearcher
visitor)
{
var return_v = this_param.InternalVisit( (System.Management.Automation.Language.AstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 17685, 17712);
return return_v;
}


System.Management.Automation.Language.Ast
f_1543_17734_17767(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
source)
{
var return_v = source.FirstOrDefault<System.Management.Automation.Language.Ast>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 17734, 17767);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,17338,17787);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,17338,17787);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool IsUsingDollarInput(Ast ast)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1543,17799,18516);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,17872,18505);

return (f_1543_17880_18503(ast, ast_ =>
                {
                    var varAst = ast_ as VariableExpressionAst;
                    if (varAst != null)
                    {
                        return varAst.VariablePath.IsVariable &&
                               varAst.VariablePath.UnqualifiedPath.Equals(SpecialVariables.Input,
                                                                          StringComparison.OrdinalIgnoreCase);
                    }

                    return false;
                }, searchNestedScriptBlocks: false));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1543,17799,18516);

bool
f_1543_17880_18503(System.Management.Automation.Language.Ast
ast,System.Func<System.Management.Automation.Language.Ast, bool>
predicate,bool
searchNestedScriptBlocks)
{
var return_v = AstSearcher.Contains( ast, predicate, searchNestedScriptBlocks: searchNestedScriptBlocks);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 17880, 18503);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,17799,18516);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,17799,18516);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected AstSearcher(Func<Ast, bool> callback, bool stopOnFirst, bool searchNestedScriptBlocks)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1543,18569,18875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,18920,18929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,18962,18974);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,19007,19032);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,19072,19079);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,18690,18711);

_callback = callback;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,18725,18752);

_stopOnFirst = stopOnFirst;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,18766,18819);

_searchNestedScriptBlocks = searchNestedScriptBlocks;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,18833,18864);

this.Results = f_1543_18848_18863();
DynAbs.Tracing.TraceSender.TraceExitConstructor(1543,18569,18875);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,18569,18875);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,18569,18875);
}
		}

private readonly Func<Ast, bool> _callback;

private readonly bool _stopOnFirst;

private readonly bool _searchNestedScriptBlocks;

protected readonly List<Ast> Results;

protected AstVisitAction Check(Ast ast)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,19092,19425);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,19156,19367) || true) && (f_1543_19160_19174(this, ast))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1543,19156,19367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,19208,19225);

f_1543_19208_19224(                Results, ast);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,19243,19352) || true) && (_stopOnFirst)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1543,19243,19352);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,19301,19333);

return AstVisitAction.StopVisit;
DynAbs.Tracing.TraceSender.TraceExitCondition(1543,19243,19352);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1543,19156,19367);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,19383,19414);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,19092,19425);

bool
f_1543_19160_19174(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.Ast
arg)
{
var return_v = this_param._callback( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 19160, 19174);
return return_v;
}


int
f_1543_19208_19224(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
this_param,System.Management.Automation.Language.Ast
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 19208, 19224);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,19092,19425);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,19092,19425);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected AstVisitAction CheckScriptBlock(Ast ast)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,19437,19744);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,19512,19536);

var 
action = f_1543_19525_19535(this, ast)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,19550,19703) || true) && (action == AstVisitAction.Continue &&(DynAbs.Tracing.TraceSender.Expression_True(1543, 19554, 19617)&&!_searchNestedScriptBlocks))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1543,19550,19703);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,19651,19688);

action = AstVisitAction.SkipChildren;
DynAbs.Tracing.TraceSender.TraceExitCondition(1543,19550,19703);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,19719,19733);

return action;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,19437,19744);

System.Management.Automation.Language.AstVisitAction
f_1543_19525_19535(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.Ast
ast)
{
var return_v = this_param.Check( ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 19525, 19535);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,19437,19744);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,19437,19744);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitErrorStatement(ErrorStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,19756,19852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,19832,19850);

return f_1543_19839_19849(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,19756,19852);

System.Management.Automation.Language.AstVisitAction
f_1543_19839_19849(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.ErrorStatementAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 19839, 19849);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,19756,19852);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,19756,19852);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitErrorExpression(ErrorExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,19864,19962);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,19942,19960);

return f_1543_19949_19959(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,19864,19962);

System.Management.Automation.Language.AstVisitAction
f_1543_19949_19959(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.ErrorExpressionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 19949, 19959);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,19864,19962);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,19864,19962);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitScriptBlock(ScriptBlockAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,19974,20064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,20044,20062);

return f_1543_20051_20061(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,19974,20064);

System.Management.Automation.Language.AstVisitAction
f_1543_20051_20061(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.ScriptBlockAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 20051, 20061);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,19974,20064);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,19974,20064);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitParamBlock(ParamBlockAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,20076,20164);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,20144,20162);

return f_1543_20151_20161(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,20076,20164);

System.Management.Automation.Language.AstVisitAction
f_1543_20151_20161(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.ParamBlockAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 20151, 20161);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,20076,20164);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,20076,20164);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitNamedBlock(NamedBlockAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,20176,20264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,20244,20262);

return f_1543_20251_20261(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,20176,20264);

System.Management.Automation.Language.AstVisitAction
f_1543_20251_20261(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.NamedBlockAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 20251, 20261);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,20176,20264);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,20176,20264);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitTypeConstraint(TypeConstraintAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,20276,20372);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,20352,20370);

return f_1543_20359_20369(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,20276,20372);

System.Management.Automation.Language.AstVisitAction
f_1543_20359_20369(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.TypeConstraintAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 20359, 20369);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,20276,20372);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,20276,20372);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitAttribute(AttributeAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,20384,20470);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,20450,20468);

return f_1543_20457_20467(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,20384,20470);

System.Management.Automation.Language.AstVisitAction
f_1543_20457_20467(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.AttributeAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 20457, 20467);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,20384,20470);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,20384,20470);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitParameter(ParameterAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,20482,20568);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,20548,20566);

return f_1543_20555_20565(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,20482,20568);

System.Management.Automation.Language.AstVisitAction
f_1543_20555_20565(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.ParameterAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 20555, 20565);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,20482,20568);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,20482,20568);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitTypeExpression(TypeExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,20580,20676);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,20656,20674);

return f_1543_20663_20673(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,20580,20676);

System.Management.Automation.Language.AstVisitAction
f_1543_20663_20673(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.TypeExpressionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 20663, 20673);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,20580,20676);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,20580,20676);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitFunctionDefinition(FunctionDefinitionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,20688,20803);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,20772,20801);

return f_1543_20779_20800(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,20688,20803);

System.Management.Automation.Language.AstVisitAction
f_1543_20779_20800(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.FunctionDefinitionAst
ast)
{
var return_v = this_param.CheckScriptBlock( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 20779, 20800);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,20688,20803);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,20688,20803);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitStatementBlock(StatementBlockAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,20815,20911);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,20891,20909);

return f_1543_20898_20908(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,20815,20911);

System.Management.Automation.Language.AstVisitAction
f_1543_20898_20908(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.StatementBlockAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 20898, 20908);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,20815,20911);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,20815,20911);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitIfStatement(IfStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,20923,21013);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,20993,21011);

return f_1543_21000_21010(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,20923,21013);

System.Management.Automation.Language.AstVisitAction
f_1543_21000_21010(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.IfStatementAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 21000, 21010);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,20923,21013);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,20923,21013);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitTrap(TrapStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,21025,21121);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,21090,21119);

return f_1543_21097_21118(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,21025,21121);

System.Management.Automation.Language.AstVisitAction
f_1543_21097_21118(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.TrapStatementAst
ast)
{
var return_v = this_param.CheckScriptBlock( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 21097, 21118);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,21025,21121);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,21025,21121);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitSwitchStatement(SwitchStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,21133,21231);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,21211,21229);

return f_1543_21218_21228(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,21133,21231);

System.Management.Automation.Language.AstVisitAction
f_1543_21218_21228(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.SwitchStatementAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 21218, 21228);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,21133,21231);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,21133,21231);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitDataStatement(DataStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,21243,21337);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,21317,21335);

return f_1543_21324_21334(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,21243,21337);

System.Management.Automation.Language.AstVisitAction
f_1543_21324_21334(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.DataStatementAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 21324, 21334);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,21243,21337);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,21243,21337);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitForEachStatement(ForEachStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,21349,21449);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,21429,21447);

return f_1543_21436_21446(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,21349,21449);

System.Management.Automation.Language.AstVisitAction
f_1543_21436_21446(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.ForEachStatementAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 21436, 21446);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,21349,21449);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,21349,21449);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitDoWhileStatement(DoWhileStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,21461,21561);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,21541,21559);

return f_1543_21548_21558(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,21461,21561);

System.Management.Automation.Language.AstVisitAction
f_1543_21548_21558(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.DoWhileStatementAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 21548, 21558);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,21461,21561);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,21461,21561);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitForStatement(ForStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,21573,21665);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,21645,21663);

return f_1543_21652_21662(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,21573,21665);

System.Management.Automation.Language.AstVisitAction
f_1543_21652_21662(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.ForStatementAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 21652, 21662);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,21573,21665);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,21573,21665);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitWhileStatement(WhileStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,21677,21773);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,21753,21771);

return f_1543_21760_21770(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,21677,21773);

System.Management.Automation.Language.AstVisitAction
f_1543_21760_21770(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.WhileStatementAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 21760, 21770);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,21677,21773);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,21677,21773);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitCatchClause(CatchClauseAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,21785,21875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,21855,21873);

return f_1543_21862_21872(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,21785,21875);

System.Management.Automation.Language.AstVisitAction
f_1543_21862_21872(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.CatchClauseAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 21862, 21872);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,21785,21875);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,21785,21875);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitTryStatement(TryStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,21887,21979);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,21959,21977);

return f_1543_21966_21976(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,21887,21979);

System.Management.Automation.Language.AstVisitAction
f_1543_21966_21976(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.TryStatementAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 21966, 21976);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,21887,21979);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,21887,21979);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitBreakStatement(BreakStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,21991,22087);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,22067,22085);

return f_1543_22074_22084(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,21991,22087);

System.Management.Automation.Language.AstVisitAction
f_1543_22074_22084(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.BreakStatementAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 22074, 22084);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,21991,22087);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,21991,22087);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitContinueStatement(ContinueStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,22099,22201);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,22181,22199);

return f_1543_22188_22198(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,22099,22201);

System.Management.Automation.Language.AstVisitAction
f_1543_22188_22198(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.ContinueStatementAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 22188, 22198);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,22099,22201);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,22099,22201);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitReturnStatement(ReturnStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,22213,22311);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,22291,22309);

return f_1543_22298_22308(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,22213,22311);

System.Management.Automation.Language.AstVisitAction
f_1543_22298_22308(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.ReturnStatementAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 22298, 22308);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,22213,22311);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,22213,22311);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitExitStatement(ExitStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,22323,22417);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,22397,22415);

return f_1543_22404_22414(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,22323,22417);

System.Management.Automation.Language.AstVisitAction
f_1543_22404_22414(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.ExitStatementAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 22404, 22414);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,22323,22417);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,22323,22417);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitThrowStatement(ThrowStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,22429,22525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,22505,22523);

return f_1543_22512_22522(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,22429,22525);

System.Management.Automation.Language.AstVisitAction
f_1543_22512_22522(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.ThrowStatementAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 22512, 22522);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,22429,22525);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,22429,22525);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitDoUntilStatement(DoUntilStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,22537,22637);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,22617,22635);

return f_1543_22624_22634(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,22537,22637);

System.Management.Automation.Language.AstVisitAction
f_1543_22624_22634(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.DoUntilStatementAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 22624, 22634);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,22537,22637);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,22537,22637);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitAssignmentStatement(AssignmentStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,22649,22755);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,22735,22753);

return f_1543_22742_22752(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,22649,22755);

System.Management.Automation.Language.AstVisitAction
f_1543_22742_22752(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.AssignmentStatementAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 22742, 22752);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,22649,22755);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,22649,22755);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitPipeline(PipelineAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,22767,22851);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,22831,22849);

return f_1543_22838_22848(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,22767,22851);

System.Management.Automation.Language.AstVisitAction
f_1543_22838_22848(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.PipelineAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 22838, 22848);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,22767,22851);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,22767,22851);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitCommand(CommandAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,22863,22945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,22925,22943);

return f_1543_22932_22942(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,22863,22945);

System.Management.Automation.Language.AstVisitAction
f_1543_22932_22942(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.CommandAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 22932, 22942);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,22863,22945);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,22863,22945);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitCommandExpression(CommandExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,22957,23059);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,23039,23057);

return f_1543_23046_23056(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,22957,23059);

System.Management.Automation.Language.AstVisitAction
f_1543_23046_23056(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.CommandExpressionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 23046, 23056);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,22957,23059);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,22957,23059);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitCommandParameter(CommandParameterAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,23071,23171);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,23151,23169);

return f_1543_23158_23168(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,23071,23171);

System.Management.Automation.Language.AstVisitAction
f_1543_23158_23168(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.CommandParameterAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 23158, 23168);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,23071,23171);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,23071,23171);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitMergingRedirection(MergingRedirectionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,23183,23287);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,23267,23285);

return f_1543_23274_23284(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,23183,23287);

System.Management.Automation.Language.AstVisitAction
f_1543_23274_23284(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.MergingRedirectionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 23274, 23284);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,23183,23287);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,23183,23287);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitFileRedirection(FileRedirectionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,23299,23397);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,23377,23395);

return f_1543_23384_23394(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,23299,23397);

System.Management.Automation.Language.AstVisitAction
f_1543_23384_23394(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.FileRedirectionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 23384, 23394);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,23299,23397);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,23299,23397);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitBinaryExpression(BinaryExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,23409,23509);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,23489,23507);

return f_1543_23496_23506(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,23409,23509);

System.Management.Automation.Language.AstVisitAction
f_1543_23496_23506(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.BinaryExpressionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 23496, 23506);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,23409,23509);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,23409,23509);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitUnaryExpression(UnaryExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,23521,23619);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,23599,23617);

return f_1543_23606_23616(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,23521,23619);

System.Management.Automation.Language.AstVisitAction
f_1543_23606_23616(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.UnaryExpressionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 23606, 23616);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,23521,23619);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,23521,23619);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitConvertExpression(ConvertExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,23631,23733);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,23713,23731);

return f_1543_23720_23730(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,23631,23733);

System.Management.Automation.Language.AstVisitAction
f_1543_23720_23730(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.ConvertExpressionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 23720, 23730);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,23631,23733);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,23631,23733);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitConstantExpression(ConstantExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,23745,23849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,23829,23847);

return f_1543_23836_23846(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,23745,23849);

System.Management.Automation.Language.AstVisitAction
f_1543_23836_23846(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.ConstantExpressionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 23836, 23846);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,23745,23849);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,23745,23849);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitStringConstantExpression(StringConstantExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,23861,23977);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,23957,23975);

return f_1543_23964_23974(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,23861,23977);

System.Management.Automation.Language.AstVisitAction
f_1543_23964_23974(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.StringConstantExpressionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 23964, 23974);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,23861,23977);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,23861,23977);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitSubExpression(SubExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,23989,24083);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,24063,24081);

return f_1543_24070_24080(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,23989,24083);

System.Management.Automation.Language.AstVisitAction
f_1543_24070_24080(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.SubExpressionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 24070, 24080);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,23989,24083);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,23989,24083);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitUsingExpression(UsingExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,24095,24193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,24173,24191);

return f_1543_24180_24190(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,24095,24193);

System.Management.Automation.Language.AstVisitAction
f_1543_24180_24190(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.UsingExpressionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 24180, 24190);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,24095,24193);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,24095,24193);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitVariableExpression(VariableExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,24205,24309);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,24289,24307);

return f_1543_24296_24306(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,24205,24309);

System.Management.Automation.Language.AstVisitAction
f_1543_24296_24306(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.VariableExpressionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 24296, 24306);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,24205,24309);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,24205,24309);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitMemberExpression(MemberExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,24321,24421);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,24401,24419);

return f_1543_24408_24418(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,24321,24421);

System.Management.Automation.Language.AstVisitAction
f_1543_24408_24418(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.MemberExpressionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 24408, 24418);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,24321,24421);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,24321,24421);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitInvokeMemberExpression(InvokeMemberExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,24433,24545);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,24525,24543);

return f_1543_24532_24542(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,24433,24545);

System.Management.Automation.Language.AstVisitAction
f_1543_24532_24542(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.InvokeMemberExpressionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 24532, 24542);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,24433,24545);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,24433,24545);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitArrayExpression(ArrayExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,24557,24655);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,24635,24653);

return f_1543_24642_24652(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,24557,24655);

System.Management.Automation.Language.AstVisitAction
f_1543_24642_24652(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.ArrayExpressionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 24642, 24652);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,24557,24655);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,24557,24655);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitArrayLiteral(ArrayLiteralAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,24667,24759);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,24739,24757);

return f_1543_24746_24756(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,24667,24759);

System.Management.Automation.Language.AstVisitAction
f_1543_24746_24756(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.ArrayLiteralAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 24746, 24756);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,24667,24759);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,24667,24759);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitHashtable(HashtableAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,24771,24857);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,24837,24855);

return f_1543_24844_24854(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,24771,24857);

System.Management.Automation.Language.AstVisitAction
f_1543_24844_24854(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.HashtableAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 24844, 24854);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,24771,24857);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,24771,24857);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitScriptBlockExpression(ScriptBlockExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,24869,24990);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,24959,24988);

return f_1543_24966_24987(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,24869,24990);

System.Management.Automation.Language.AstVisitAction
f_1543_24966_24987(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.ScriptBlockExpressionAst
ast)
{
var return_v = this_param.CheckScriptBlock( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 24966, 24987);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,24869,24990);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,24869,24990);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitParenExpression(ParenExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,25002,25100);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,25080,25098);

return f_1543_25087_25097(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,25002,25100);

System.Management.Automation.Language.AstVisitAction
f_1543_25087_25097(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.ParenExpressionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 25087, 25097);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,25002,25100);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,25002,25100);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitExpandableStringExpression(ExpandableStringExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,25112,25232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,25212,25230);

return f_1543_25219_25229(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,25112,25232);

System.Management.Automation.Language.AstVisitAction
f_1543_25219_25229(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.ExpandableStringExpressionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 25219, 25229);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,25112,25232);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,25112,25232);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitIndexExpression(IndexExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,25244,25342);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,25322,25340);

return f_1543_25329_25339(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,25244,25342);

System.Management.Automation.Language.AstVisitAction
f_1543_25329_25339(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.IndexExpressionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 25329, 25339);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,25244,25342);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,25244,25342);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitAttributedExpression(AttributedExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,25354,25462);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,25442,25460);

return f_1543_25449_25459(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,25354,25462);

System.Management.Automation.Language.AstVisitAction
f_1543_25449_25459(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.AttributedExpressionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 25449, 25459);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,25354,25462);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,25354,25462);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitNamedAttributeArgument(NamedAttributeArgumentAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,25474,25586);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,25566,25584);

return f_1543_25573_25583(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,25474,25586);

System.Management.Automation.Language.AstVisitAction
f_1543_25573_25583(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.NamedAttributeArgumentAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 25573, 25583);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,25474,25586);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,25474,25586);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitTypeDefinition(TypeDefinitionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,25598,25694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,25674,25692);

return f_1543_25681_25691(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,25598,25694);

System.Management.Automation.Language.AstVisitAction
f_1543_25681_25691(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.TypeDefinitionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 25681, 25691);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,25598,25694);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,25598,25694);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitPropertyMember(PropertyMemberAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,25706,25802);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,25782,25800);

return f_1543_25789_25799(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,25706,25802);

System.Management.Automation.Language.AstVisitAction
f_1543_25789_25799(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.PropertyMemberAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 25789, 25799);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,25706,25802);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,25706,25802);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitFunctionMember(FunctionMemberAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,25814,25910);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,25890,25908);

return f_1543_25897_25907(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,25814,25910);

System.Management.Automation.Language.AstVisitAction
f_1543_25897_25907(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.FunctionMemberAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 25897, 25907);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,25814,25910);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,25814,25910);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitUsingStatement(UsingStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,25922,26018);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,25998,26016);

return f_1543_26005_26015(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,25922,26018);

System.Management.Automation.Language.AstVisitAction
f_1543_26005_26015(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.UsingStatementAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 26005, 26015);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,25922,26018);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,25922,26018);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitBlockStatement(BlockStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,26030,26126);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,26106,26124);

return f_1543_26113_26123(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,26030,26126);

System.Management.Automation.Language.AstVisitAction
f_1543_26113_26123(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.BlockStatementAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 26113, 26123);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,26030,26126);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,26030,26126);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitConfigurationDefinition(ConfigurationDefinitionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,26138,26252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,26232,26250);

return f_1543_26239_26249(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,26138,26252);

System.Management.Automation.Language.AstVisitAction
f_1543_26239_26249(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.ConfigurationDefinitionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 26239, 26249);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,26138,26252);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,26138,26252);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitDynamicKeywordStatement(DynamicKeywordStatementAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,26264,26378);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,26358,26376);

return f_1543_26365_26375(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,26264,26378);

System.Management.Automation.Language.AstVisitAction
f_1543_26365_26375(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.DynamicKeywordStatementAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 26365, 26375);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,26264,26378);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,26264,26378);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitTernaryExpression(TernaryExpressionAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,26390,26492);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,26472,26490);

return f_1543_26479_26489(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,26390,26492);

System.Management.Automation.Language.AstVisitAction
f_1543_26479_26489(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.TernaryExpressionAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 26479, 26489);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,26390,26492);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,26390,26492);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitPipelineChain(PipelineChainAst ast) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,26504,26598);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,26578,26596);

return f_1543_26585_26595(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,26504,26598);

System.Management.Automation.Language.AstVisitAction
f_1543_26585_26595(System.Management.Automation.Language.AstSearcher
this_param,System.Management.Automation.Language.PipelineChainAst
ast)
{
var return_v = this_param.Check( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 26585, 26595);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,26504,26598);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,26504,26598);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static AstSearcher()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1543,16342,26605);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1543,16342,26605);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,16342,26605);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1543,16342,26605);

System.Collections.Generic.List<System.Management.Automation.Language.Ast>
f_1543_18848_18863()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.Ast>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1543, 18848, 18863);
return return_v;
}

}
public abstract class DefaultCustomAstVisitor : ICustomAstVisitor
{
public virtual object VisitErrorStatement(ErrorStatementAst errorStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,26836,26931);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,26917,26929);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,26836,26931);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,26836,26931);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,26836,26931);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitErrorExpression(ErrorExpressionAst errorExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,26965,27063);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,27049,27061);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,26965,27063);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,26965,27063);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,26965,27063);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitScriptBlock(ScriptBlockAst scriptBlockAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,27097,27183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,27169,27181);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,27097,27183);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,27097,27183);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,27097,27183);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitParamBlock(ParamBlockAst paramBlockAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,27217,27300);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,27286,27298);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,27217,27300);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,27217,27300);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,27217,27300);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitNamedBlock(NamedBlockAst namedBlockAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,27334,27417);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,27403,27415);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,27334,27417);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,27334,27417);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,27334,27417);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitTypeConstraint(TypeConstraintAst typeConstraintAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,27451,27546);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,27532,27544);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,27451,27546);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,27451,27546);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,27451,27546);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitAttribute(AttributeAst attributeAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,27580,27660);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,27646,27658);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,27580,27660);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,27580,27660);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,27580,27660);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitNamedAttributeArgument(NamedAttributeArgumentAst namedAttributeArgumentAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,27694,27813);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,27799,27811);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,27694,27813);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,27694,27813);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,27694,27813);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitParameter(ParameterAst parameterAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,27847,27927);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,27913,27925);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,27847,27927);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,27847,27927);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,27847,27927);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitStatementBlock(StatementBlockAst statementBlockAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,27961,28056);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,28042,28054);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,27961,28056);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,27961,28056);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,27961,28056);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitIfStatement(IfStatementAst ifStmtAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,28090,28171);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,28157,28169);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,28090,28171);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,28090,28171);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,28090,28171);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitTrap(TrapStatementAst trapStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,28205,28288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,28274,28286);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,28205,28288);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,28205,28288);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,28205,28288);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitSwitchStatement(SwitchStatementAst switchStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,28322,28420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,28406,28418);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,28322,28420);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,28322,28420);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,28322,28420);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitDataStatement(DataStatementAst dataStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,28454,28546);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,28532,28544);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,28454,28546);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,28454,28546);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,28454,28546);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitForEachStatement(ForEachStatementAst forEachStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,28580,28681);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,28667,28679);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,28580,28681);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,28580,28681);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,28580,28681);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitDoWhileStatement(DoWhileStatementAst doWhileStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,28715,28816);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,28802,28814);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,28715,28816);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,28715,28816);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,28715,28816);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitForStatement(ForStatementAst forStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,28850,28939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,28925,28937);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,28850,28939);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,28850,28939);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,28850,28939);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitWhileStatement(WhileStatementAst whileStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,28973,29068);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,29054,29066);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,28973,29068);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,28973,29068);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,28973,29068);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitCatchClause(CatchClauseAst catchClauseAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,29102,29188);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,29174,29186);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,29102,29188);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,29102,29188);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,29102,29188);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitTryStatement(TryStatementAst tryStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,29222,29311);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,29297,29309);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,29222,29311);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,29222,29311);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,29222,29311);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitBreakStatement(BreakStatementAst breakStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,29345,29440);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,29426,29438);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,29345,29440);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,29345,29440);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,29345,29440);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitContinueStatement(ContinueStatementAst continueStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,29474,29578);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,29564,29576);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,29474,29578);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,29474,29578);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,29474,29578);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitReturnStatement(ReturnStatementAst returnStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,29612,29710);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,29696,29708);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,29612,29710);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,29612,29710);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,29612,29710);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitExitStatement(ExitStatementAst exitStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,29744,29836);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,29822,29834);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,29744,29836);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,29744,29836);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,29744,29836);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitThrowStatement(ThrowStatementAst throwStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,29870,29965);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,29951,29963);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,29870,29965);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,29870,29965);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,29870,29965);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitDoUntilStatement(DoUntilStatementAst doUntilStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,29999,30100);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,30086,30098);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,29999,30100);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,29999,30100);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,29999,30100);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitAssignmentStatement(AssignmentStatementAst assignmentStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,30134,30244);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,30230,30242);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,30134,30244);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,30134,30244);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,30134,30244);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitPipeline(PipelineAst pipelineAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,30278,30355);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,30341,30353);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,30278,30355);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,30278,30355);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,30278,30355);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitCommand(CommandAst commandAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,30389,30463);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,30449,30461);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,30389,30463);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,30389,30463);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,30389,30463);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitCommandExpression(CommandExpressionAst commandExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,30497,30601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,30587,30599);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,30497,30601);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,30497,30601);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,30497,30601);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitCommandParameter(CommandParameterAst commandParameterAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,30635,30736);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,30722,30734);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,30635,30736);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,30635,30736);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,30635,30736);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitFileRedirection(FileRedirectionAst fileRedirectionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,30770,30868);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,30854,30866);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,30770,30868);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,30770,30868);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,30770,30868);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitMergingRedirection(MergingRedirectionAst mergingRedirectionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,30902,31009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,30995,31007);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,30902,31009);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,30902,31009);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,30902,31009);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitBinaryExpression(BinaryExpressionAst binaryExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,31043,31144);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,31130,31142);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,31043,31144);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,31043,31144);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,31043,31144);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitUnaryExpression(UnaryExpressionAst unaryExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,31178,31276);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,31262,31274);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,31178,31276);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,31178,31276);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,31178,31276);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitConvertExpression(ConvertExpressionAst convertExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,31310,31414);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,31400,31412);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,31310,31414);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,31310,31414);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,31310,31414);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitConstantExpression(ConstantExpressionAst constantExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,31448,31555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,31541,31553);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,31448,31555);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,31448,31555);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,31448,31555);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitStringConstantExpression(StringConstantExpressionAst stringConstantExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,31589,31714);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,31700,31712);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,31589,31714);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,31589,31714);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,31589,31714);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitSubExpression(SubExpressionAst subExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,31748,31840);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,31826,31838);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,31748,31840);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,31748,31840);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,31748,31840);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitUsingExpression(UsingExpressionAst usingExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,31874,31972);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,31958,31970);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,31874,31972);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,31874,31972);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,31874,31972);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitVariableExpression(VariableExpressionAst variableExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,32006,32113);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,32099,32111);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,32006,32113);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,32006,32113);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,32006,32113);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitTypeExpression(TypeExpressionAst typeExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,32147,32242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,32228,32240);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,32147,32242);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,32147,32242);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,32147,32242);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitMemberExpression(MemberExpressionAst memberExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,32276,32377);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,32363,32375);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,32276,32377);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,32276,32377);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,32276,32377);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitInvokeMemberExpression(InvokeMemberExpressionAst invokeMemberExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,32411,32530);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,32516,32528);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,32411,32530);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,32411,32530);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,32411,32530);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitArrayExpression(ArrayExpressionAst arrayExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,32564,32662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,32648,32660);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,32564,32662);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,32564,32662);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,32564,32662);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitArrayLiteral(ArrayLiteralAst arrayLiteralAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,32696,32785);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,32771,32783);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,32696,32785);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,32696,32785);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,32696,32785);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitHashtable(HashtableAst hashtableAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,32819,32899);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,32885,32897);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,32819,32899);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,32819,32899);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,32819,32899);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitParenExpression(ParenExpressionAst parenExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,32933,33031);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,33017,33029);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,32933,33031);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,32933,33031);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,32933,33031);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitExpandableStringExpression(ExpandableStringExpressionAst expandableStringExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,33065,33196);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,33182,33194);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,33065,33196);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,33065,33196);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,33065,33196);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitIndexExpression(IndexExpressionAst indexExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,33230,33328);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,33314,33326);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,33230,33328);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,33230,33328);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,33230,33328);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitAttributedExpression(AttributedExpressionAst attributedExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,33362,33475);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,33461,33473);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,33362,33475);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,33362,33475);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,33362,33475);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitBlockStatement(BlockStatementAst blockStatementAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,33509,33604);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,33590,33602);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,33509,33604);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,33509,33604);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,33509,33604);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitFunctionDefinition(FunctionDefinitionAst functionDefinitionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,33638,33745);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,33731,33743);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,33638,33745);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,33638,33745);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,33638,33745);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitScriptBlockExpression(ScriptBlockExpressionAst scriptBlockExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,33779,33895);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,33881,33893);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,33779,33895);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,33779,33895);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,33779,33895);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public DefaultCustomAstVisitor()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1543,26730,33902);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1543,26730,33902);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,26730,33902);
}


static DefaultCustomAstVisitor()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1543,26730,33902);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1543,26730,33902);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,26730,33902);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1543,26730,33902);
}
public abstract class DefaultCustomAstVisitor2 : DefaultCustomAstVisitor, ICustomAstVisitor2
{
public virtual object VisitPropertyMember(PropertyMemberAst propertyMemberAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,34161,34256);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,34242,34254);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,34161,34256);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,34161,34256);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,34161,34256);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitBaseCtorInvokeMemberExpression(BaseCtorInvokeMemberExpressionAst baseCtorInvokeMemberExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,34290,34433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,34419,34431);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,34290,34433);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,34290,34433);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,34290,34433);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitUsingStatement(UsingStatementAst usingStatement) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,34467,34559);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,34545,34557);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,34467,34559);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,34467,34559);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,34467,34559);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitConfigurationDefinition(ConfigurationDefinitionAst configurationAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,34593,34705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,34691,34703);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,34593,34705);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,34593,34705);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,34593,34705);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitDynamicKeywordStatement(DynamicKeywordStatementAst dynamicKeywordAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,34739,34852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,34838,34850);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,34739,34852);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,34739,34852);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,34739,34852);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitTypeDefinition(TypeDefinitionAst typeDefinitionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,34886,34981);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,34967,34979);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,34886,34981);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,34886,34981);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,34886,34981);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitFunctionMember(FunctionMemberAst functionMemberAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,35015,35110);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,35096,35108);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,35015,35110);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,35015,35110);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,35015,35110);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitTernaryExpression(TernaryExpressionAst ternaryExpressionAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,35144,35248);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,35234,35246);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,35144,35248);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,35144,35248);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,35144,35248);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual object VisitPipelineChain(PipelineChainAst statementChainAst) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1543,35282,35375);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1543,35361,35373);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1543,35282,35375);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1543,35282,35375);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,35282,35375);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public DefaultCustomAstVisitor2()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1543,34028,35382);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1543,34028,35382);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,34028,35382);
}


static DefaultCustomAstVisitor2()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1543,34028,35382);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1543,34028,35382);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1543,34028,35382);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1543,34028,35382);
}
}
